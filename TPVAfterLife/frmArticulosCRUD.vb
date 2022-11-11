Imports System.Data.Common
Imports System.IO

Public Class frmArticulosCRUD

    Public conexion As New Conexion
    Dim imgRecogida() As Byte = {0}

    Private Sub frmArticulosCRUD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CancelButton = btnGUSalir
        conexion.Conectar()
        Me.cargaFormulario()
    End Sub

    Private Sub btnGUSalir_Click(sender As Object, e As EventArgs) Handles btnGUSalir.Click
        Dim confirma As frmConfirmacion = New frmConfirmacion("¿Seguro que desea cerrar?")
        If confirma.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.Close()
        End If
    End Sub

    Private Sub dgvArticulos_SelectionChanged(sender As Object, e As EventArgs) Handles dgvArticulos.SelectionChanged
        Dim img() As Byte
        If dgvArticulos.CurrentCell IsNot Nothing Then
            tbIdArticulo.Text = dgvArticulos.Rows(dgvArticulos.CurrentCell.RowIndex).Cells("IdArticulo").Value.ToString()
            tbNombre.Text = dgvArticulos.Rows(dgvArticulos.CurrentCell.RowIndex).Cells("Nombre").Value.ToString()
            tbPrecio.Text = dgvArticulos.Rows(dgvArticulos.CurrentCell.RowIndex).Cells("Precio").Value.ToString()
            tbStock.Text = dgvArticulos.Rows(dgvArticulos.CurrentCell.RowIndex).Cells("Stock").Value.ToString()
            cbGUCategoriasID.SelectedItem() = dgvArticulos.Rows(dgvArticulos.CurrentCell.RowIndex).Cells("IdCategoria").Value
            cbGUCategoriasNombre.SelectedIndex() = cbGUCategoriasID.SelectedIndex()
            If dgvArticulos.Rows(dgvArticulos.CurrentCell.RowIndex).Cells("imagen").Value IsNot DBNull.Value Then
                img = dgvArticulos.Rows(dgvArticulos.CurrentCell.RowIndex).Cells("imagen").Value
                imgRecogida = dgvArticulos.Rows(dgvArticulos.CurrentCell.RowIndex).Cells("imagen").Value
                Dim ms As New MemoryStream(img)
                pbGUProducto.Image = Image.FromStream(ms)
                lblGUImagen.Text = "Imagen del articulo cargada"
                btnGUEliminarIMG.Enabled = True
                btnGUAniadirImagen.Enabled = False
            Else
                pbGUProducto.Image = My.Resources.NotFoundIMG1
                btnGUEliminarIMG_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub tbPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbPrecio.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) And Asc(e.KeyChar) <> 44 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tbStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbStock.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnGUBorrar_Click(sender As Object, e As EventArgs) Handles btnGUBorrar.Click
        Dim miTablaArticulos As DataTable
        Dim miDataRowArticulosABorrar(), miDataRowArticuloBorrado As DataRow

        If camposSinInformacion() Then
            Dim mensaje As New frmMensaje("Debe seleccionar un articulo para borrar", False)
            mensaje.ShowDialog()
            Return
        End If

        miTablaArticulos = conexion._miDataSet.Tables("Articulos")
        miDataRowArticulosABorrar = miTablaArticulos.Select("IdArticulo = '" & tbIdArticulo.Text & "' AND Borrado = False")
        miDataRowArticuloBorrado = miDataRowArticulosABorrar(0)

        Dim confirma As frmConfirmacion = New frmConfirmacion("¿Seguro que desea borrar el articulo '" + miDataRowArticuloBorrado("Nombre") + "'?")
        If confirma.ShowDialog() = Windows.Forms.DialogResult.OK Then
            miDataRowArticuloBorrado("Borrado") = True
            conexion.miDataAdapterArticulos.Update(conexion._miDataSet, "Articulos")
        End If

        Me.cargaFormulario()

        'FALTA QUE EL DGV NO SE QUEDE SELECCIONADO

    End Sub

    Private Sub btnGUModificar_Click(sender As Object, e As EventArgs) Handles btnGUModificar.Click
        Dim miTablaArticulos As DataTable
        Dim miDataRowArticulosABorrar(), miDataRowArticuloBorrado As DataRow
        Dim precio As Double
        Dim stock As Integer

        If dgvArticulos.CurrentCell Is Nothing Then
            Dim mensaje As New frmMensaje("No hay ningun articulo seleccionado", False)
            mensaje.ShowDialog()
            Return
        End If

        miTablaArticulos = conexion._miDataSet.Tables("Articulos")
        miDataRowArticulosABorrar = miTablaArticulos.Select("IdArticulo = '" & tbIdArticulo.Text & "' AND Borrado = False")
        miDataRowArticuloBorrado = miDataRowArticulosABorrar(0)

        If camposSinInformacion() Then
            Dim mensaje As New frmMensaje("Introduzca datos en todos los campos", True)
            mensaje.ShowDialog()
            Return
        End If

        Dim confirma As frmConfirmacion = New frmConfirmacion("¿Seguro que desea modificar el articulo '" + miDataRowArticuloBorrado("Nombre") + "'?")
        If confirma.ShowDialog() = Windows.Forms.DialogResult.OK Then
            miDataRowArticuloBorrado("Nombre") = tbNombre.Text.Trim()
            Try
                precio = Double.Parse(tbPrecio.Text.Trim())
            Catch ex As Exception
                Dim mensaje As New frmMensaje("El precio no es válido", False)
                mensaje.ShowDialog()
                Return
            End Try
            miDataRowArticuloBorrado("Precio") = precio
            Try
                stock = Integer.Parse(tbStock.Text.Trim())
            Catch ex As Exception
                Dim mensaje As New frmMensaje("El stock no es válido", False)
                mensaje.ShowDialog()
                Return
            End Try
            miDataRowArticuloBorrado("Stock") = stock

            miDataRowArticuloBorrado("IdCategoria") = cbGUCategoriasID.SelectedItem()

            If imgRecogida(0) = 0 Then
                miDataRowArticuloBorrado("imagen") = DBNull.Value
            Else
                miDataRowArticuloBorrado("imagen") = imgRecogida
            End If

            conexion.miDataAdapterArticulos.Update(conexion._miDataSet, "Articulos")

            Me.cargaFormulario()
        End If

        'FALTA QUE EL DGV NO SE QUEDE SELECCIONADO

    End Sub

    Private Sub cbGUCategoriasNombre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGUCategoriasNombre.SelectedIndexChanged
        cbGUCategoriasID.SelectedIndex() = cbGUCategoriasNombre.SelectedIndex()
    End Sub

    Private Sub btnGUAniadir_Click(sender As Object, e As EventArgs) Handles btnGUAniadir.Click
        frmAniadirArticulo.ShowDialog()
        Me.frmArticulosCRUD_Load(sender, e)
    End Sub

    Private Sub btnGUAniadirImagen_Click(sender As Object, e As EventArgs) Handles btnGUAniadirImagen.Click
        Dim opf As New OpenFileDialog
        Dim ms As New MemoryStream

        opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"

        If opf.ShowDialog = DialogResult.OK Then
            pbGUImagenAux.Image = Image.FromFile(opf.FileName)
            pbGUImagenAux.Image.Save(ms, pbGUImagenAux.Image.RawFormat)
            imgRecogida = ms.ToArray()
            Dim filename As String = opf.FileName
            filename = filename.Substring(filename.LastIndexOf("\") + 1)
            lblGUImagen.Text = "Imagen --> ( " + filename + " )"
            btnGUEliminarIMG.Enabled = True
            btnGUAniadirImagen.Enabled = False
        End If

    End Sub

    Private Sub btnGUEliminarIMG_Click(sender As Object, e As EventArgs) Handles btnGUEliminarIMG.Click
        lblGUImagen.Text = "Imagen:"
        imgRecogida = {0}
        btnGUAniadirImagen.Enabled = True
        btnGUEliminarIMG.Enabled = False
    End Sub

    Private Function camposSinInformacion()
        Dim resul As Boolean = False
        If String.IsNullOrEmpty(tbNombre.Text.Trim()) Then
            resul = True
        ElseIf String.IsNullOrEmpty(tbPrecio.Text.Trim()) Then
            resul = True
        ElseIf String.IsNullOrEmpty(tbStock.Text.Trim()) Then
            resul = True
        ElseIf cbGUCategoriasID.SelectedIndex() = -1 Or cbGUCategoriasNombre.SelectedIndex() = -1 Then
            resul = True
        End If
        Return resul
    End Function

    Public Sub cargaFormulario()
        Dim miTablaArticulos, miTablaArticulosFiltrada, miTablaCategorias As DataTable
        Dim miDataRowArticulos(), miDataRowCategorias() As DataRow

        miTablaArticulos = conexion._miDataSet.Tables("Articulos")
        miDataRowArticulos = miTablaArticulos.Select("Borrado = False")
        miTablaArticulosFiltrada = miDataRowArticulos.CopyToDataTable()
        miTablaArticulosFiltrada.Columns.Add("Categoria", GetType(String))

        dgvArticulos.DataSource = miTablaArticulosFiltrada
        dgvArticulos.Columns("IdArticulo").Visible = False
        dgvArticulos.Columns("IdCategoria").Visible = False
        dgvArticulos.Columns("imagen").Visible = False
        dgvArticulos.Columns("Borrado").Visible = False
        dgvArticulos.ClearSelection()

        miTablaCategorias = conexion._miDataSet.Tables("Categorias")
        miDataRowCategorias = miTablaCategorias.Select("Borrado = False")
        For Each categoria As DataRow In miDataRowCategorias
            cbGUCategoriasNombre.Items.Add(categoria("NombreCategoria"))
            cbGUCategoriasID.Items.Add(categoria("IdCategoria"))
        Next

        tbNombre.Text = ""
        tbPrecio.Text = ""
        tbStock.Text = ""
        cbGUCategoriasNombre.SelectedIndex() = -1
        cbGUCategoriasID.SelectedIndex() = -1

        'FALTA CARGAR LA COLUMNA DE CATEGORIA

    End Sub

End Class