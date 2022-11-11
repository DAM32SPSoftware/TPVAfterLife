Imports System.IO

Public Class frmAniadirArticulo

    Public conexion As New Conexion
    Dim imgRecogida() As Byte = {0}

    Private Sub frmAniadirArticulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim miTablaCategorias As DataTable
        Dim miDataRowCategorias() As DataRow
        CancelButton = btnGUCancelar
        Me.limpiarCampos()
        conexion.Conectar()
        miTablaCategorias = conexion._miDataSet.Tables("Categorias")
        miDataRowCategorias = miTablaCategorias.Select("Borrado = False")
        For Each categoria As DataRow In miDataRowCategorias
            cbGUCategoriasNombre.Items.Add(categoria("NombreCategoria"))
            cbGUCategoriasID.Items.Add(categoria("IdCategoria"))
        Next
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

    Private Sub btnGUCancelar_Click(sender As Object, e As EventArgs) Handles btnGUCancelar.Click
        If camposConInformacion() = False Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Dim confirma As frmConfirmacion = New frmConfirmacion("¿Desea salir sin guardar el articulo?")
            If confirma.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        End If
    End Sub

    Private Sub cbGUCategoriasNombre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGUCategoriasNombre.SelectedIndexChanged
        cbGUCategoriasID.SelectedIndex() = cbGUCategoriasNombre.SelectedIndex()
    End Sub
    Private Sub btnGUAniadir_Click(sender As Object, e As EventArgs) Handles btnGUAniadir.Click
        Dim miNuevoDataRowArticulos As DataRow
        Dim precio As Double
        Dim stock As Integer

        If camposSinInformacion() Then
            Dim mensaje As New frmMensaje("Introduzca datos en todos los campos", True)
            mensaje.ShowDialog()
            Return
        End If

        Try
            precio = Double.Parse(tbPrecio.Text.Trim())
        Catch ex As Exception
            Dim mensaje As New frmMensaje("El precio no es válido", False)
            mensaje.ShowDialog()
            Return
        End Try
        Try
            stock = Integer.Parse(tbStock.Text.Trim())
        Catch ex As Exception
            Dim mensaje As New frmMensaje("El stock no es válido", False)
            mensaje.ShowDialog()
            Return
        End Try
        miNuevoDataRowArticulos = conexion._miDataSet.Tables("Articulos").NewRow
        miNuevoDataRowArticulos("IdArticulo") = 1234
        miNuevoDataRowArticulos("Nombre") = tbNombre.Text
        miNuevoDataRowArticulos("Precio") = precio
        miNuevoDataRowArticulos("Stock") = stock
        miNuevoDataRowArticulos("Borrado") = False
        miNuevoDataRowArticulos("IdCategoria") = cbGUCategoriasID.SelectedItem()
        If imgRecogida(0) = 0 Then
            miNuevoDataRowArticulos("imagen") = DBNull.Value
        Else
            miNuevoDataRowArticulos("imagen") = imgRecogida
        End If

        Dim confirma As frmConfirmacion = New frmConfirmacion("¿Desea añadir el articulo '" + miNuevoDataRowArticulos("Nombre") + "'?")
        If confirma.ShowDialog() = Windows.Forms.DialogResult.OK Then
            conexion._miDataSet.Tables("Articulos").Rows.Add(miNuevoDataRowArticulos)
            conexion.miDataAdapterArticulos.Update(conexion._miDataSet, "Articulos")
            Dim mensaje As frmMensaje = New frmMensaje("El articulo '" + miNuevoDataRowArticulos("Nombre") + "' ha sido añadido", False)
            mensaje.ShowDialog()
            Me.limpiarCampos()
        End If

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

    Private Function camposConInformacion()
        Dim resul As Boolean = False
        If String.IsNullOrEmpty(tbNombre.Text.Trim()) = False Then
            resul = True
        ElseIf String.IsNullOrEmpty(tbPrecio.Text.Trim()) = False Then
            resul = True
        ElseIf String.IsNullOrEmpty(tbStock.Text.Trim()) = False Then
            resul = True
        ElseIf cbGUCategoriasID.SelectedIndex() <> -1 Or cbGUCategoriasNombre.SelectedIndex() <> -1 Then
            resul = True
        End If
        Return resul
    End Function

    Private Sub limpiarCampos()
        tbNombre.Text = ""
        tbPrecio.Text = ""
        tbStock.Text = ""
        cbGUCategoriasNombre.SelectedIndex() = -1
        cbGUCategoriasID.SelectedIndex() = -1
        lblGUImagen.Text = "Imagen:"
        imgRecogida = {0}
        btnGUAniadirImagen.Enabled = True
        btnGUEliminarIMG.Enabled = False
    End Sub

End Class