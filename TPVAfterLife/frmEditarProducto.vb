Public Class frmEditarProducto
    Public cantidad As Integer
    'Public conexion As New Conexion
    Public idProducto As Integer

    Public Sub New(CodProducto As Integer)
        InitializeComponent()
        Form1.conexion.Conectar()

        Dim miArticulo() As DataRow
        miArticulo = Form1.conexion._miDataSet.Tables("Articulos").Select("IdArticulo = '" & CodProducto & "'")
        lblGUProducto.Text = miArticulo(0).Item("Nombre").ToString

        idProducto = CodProducto

    End Sub

    Private Sub frmCantidadProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cantidad = 0
        Me.verificaMayorQueCero()

        AcceptButton = btnGUAceptar
        CancelButton = btnGUCancelar
    End Sub

    Private Sub btnGUCancelar_Click(sender As Object, e As EventArgs) Handles btnGUCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnGUAumentar_Click(sender As Object, e As EventArgs) Handles btnGUAumentar.Click
        Me.cantidad = Me.cantidad + 1
        Me.verificaMayorQueCero()
    End Sub

    Private Sub btnGUDisminuir_Click(sender As Object, e As EventArgs) Handles btnGUDisminuir.Click
        Me.cantidad = Me.cantidad - 1
        Me.verificaMayorQueCero()
    End Sub

    Private Sub btnGUBorrar_Click(sender As Object, e As EventArgs) Handles btnGUBorrar.Click
        Me.cantidad = 0
        Me.verificaMayorQueCero()
    End Sub

    Private Sub verificaMayorQueCero()
        If Me.cantidad < 0 Then
            Me.cantidad = 0
        End If
        tbCantidad.Text = Me.cantidad
    End Sub

    Private Sub clickTecladoNumerico(num As Integer)
        If (Me.cantidad * 10) > 10000000 Then
            Return
        End If
        Me.cantidad = (Me.cantidad * 10) + num
        Me.verificaMayorQueCero()
    End Sub

    Private Sub btnGUUno_Click(sender As Object, e As EventArgs) Handles btnGUUno.Click
        Me.clickTecladoNumerico(1)
    End Sub

    Private Sub btnGUDos_Click(sender As Object, e As EventArgs) Handles btnGUDos.Click
        Me.clickTecladoNumerico(2)
    End Sub

    Private Sub btnGUTres_Click(sender As Object, e As EventArgs) Handles btnGUTres.Click
        Me.clickTecladoNumerico(3)
    End Sub

    Private Sub btnGUCuatro_Click(sender As Object, e As EventArgs) Handles btnGUCuatro.Click
        Me.clickTecladoNumerico(4)
    End Sub

    Private Sub btnGUCinco_Click(sender As Object, e As EventArgs) Handles btnGUCinco.Click
        Me.clickTecladoNumerico(5)
    End Sub

    Private Sub btnGUSeis_Click(sender As Object, e As EventArgs) Handles btnGUSeis.Click
        Me.clickTecladoNumerico(6)
    End Sub

    Private Sub btnGUSiete_Click(sender As Object, e As EventArgs) Handles btnGUSiete.Click
        Me.clickTecladoNumerico(7)
    End Sub

    Private Sub btnGUOcho_Click(sender As Object, e As EventArgs) Handles btnGUOcho.Click
        Me.clickTecladoNumerico(8)
    End Sub

    Private Sub btnGUNueve_Click(sender As Object, e As EventArgs) Handles btnGUNueve.Click
        Me.clickTecladoNumerico(9)
    End Sub

    Private Sub btnGUCero_Click(sender As Object, e As EventArgs) Handles btnGUCero.Click
        Me.clickTecladoNumerico(0)
    End Sub

    Private Sub btnGUAceptar_Click(sender As Object, e As EventArgs) Handles btnGUAceptar.Click
        Dim miDataRow As DataRow

        If Me.cantidad <= 0 Then
            Dim mensaje As New frmMensaje("La cantidad debe ser mayor que cero", True)
            mensaje.ShowDialog()
        Else

            Dim mensaje As New frmMensaje("Producto editado con éxito!", False)
            mensaje.ShowDialog()

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If


        'If Me.cantidad <= 0 Then
        '    Dim mensaje As New frmMensaje("La cantidad debe ser mayor que cero", True)
        '    mensaje.ShowDialog()
        'Else
        '    Dim miTablaArticulos, miTablaCategorias, miTablaArticulosDeComanda As DataTable
        '    Dim precioTotal As Double
        '    miTablaArticulos = Conexion._miDataSet.Tables("Articulos")
        '    miTablaCategorias = Conexion._miDataSet.Tables("Categorias")

        '    miTablaArticulosDeComanda = New DataTable
        '    miTablaArticulosDeComanda.Columns.Add("IdArticulo", GetType(Integer))
        '    miTablaArticulosDeComanda.Columns.Add("Nombre", GetType(String))
        '    miTablaArticulosDeComanda.Columns.Add("Cantidad", GetType(Integer))
        '    miTablaArticulosDeComanda.Columns.Add("Precio", GetType(Double))
        '    miTablaArticulosDeComanda.Columns.Add("Categoria", GetType(String))
        '    Try
        '        Dim miTablaLineaComandas As DataTable
        '        miTablaLineaComandas = Conexion._miDataSet.Tables("LineaComandas")
        '        miTablaLineaComandas.Rows(dgvComandas.CurrentCell.RowIndex).Delete()
        '        Conexion.ActualizarDB()

        '        Dim mensaje As frmMensaje = New frmMensaje("Producto eliminado con éxito!", False)
        '        mensaje.ShowDialog()

        '        'Obtenemos todos sus Artículos:
        '        miDataRowArticulosEnLineaComandas = Me.comandaAbierta.GetChildRows("LineaComandas_Comandas")

        '        For Each articulo As DataRow In miDataRowArticulosEnLineaComandas
        '            'Obtenemos la info tanto de Articulos como de Categorias
        '            Dim miDataRowInfoArticulo() As DataRow = miTablaArticulos.Select("IdArticulo = '" & articulo("IdArticulo") & "' AND Borrado = False")
        '            Dim infoArticulo = miDataRowInfoArticulo(0)
        '            Dim miDataRowCategorias() As DataRow = miTablaCategorias.Select("IdCategoria = '" & infoArticulo("IdCategoria") & "' AND Borrado = False")
        '            Dim infoCategoria = miDataRowCategorias(0)

        '            'Añadimos dicho articulo a lo que luego se usará como fuente para el dataGridView
        '            miTablaArticulosDeComanda.Rows.Add(infoArticulo("IdArticulo"), infoArticulo("Nombre"), articulo("Cantidad"), infoArticulo("Precio"), infoCategoria("NombreCategoria"))

        '            'Actualizamos el precio total
        '            precioTotal = precioTotal + (articulo("Cantidad") * infoArticulo("Precio"))
        '        Next

        '        tbUnidades.Text = ""
        '        tbArticulo.Text = ""
        '        tbPrecioTotal.Text = ""
        '        tbTotalAPagar.Text = ""
        '        dgvComandas.DataSource = ""
        '        'Fuente de datos para el dgv
        '        frmPaginaPrincipal.dgvComandas.DataSource = miTablaArticulosDeComanda
        '        'Ocultamos IdArticulo
        '        dgvComandas.Columns("IdArticulo").Visible = False
        '        tbTotalAPagar.Text = precioTotal

        '    Catch ex As Exception
        '        Dim mensaje As frmMensaje = New frmMensaje("Error!", False)
        '        mensaje.ShowDialog()
        '    End Try
        'End If
    End Sub
End Class