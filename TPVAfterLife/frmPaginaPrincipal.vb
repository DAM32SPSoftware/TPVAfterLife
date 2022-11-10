Public Class frmPaginaPrincipal

    Public conexion As New Conexion

    Private codMesa As String
    Private codEmpleado As String

    Private comandaAbierta As DataRow

    Public Sub New(idEmpleado As String)
        InitializeComponent()

        Dim miTablaEmpleados As DataTable
        Dim miDataRowEmpleados() As DataRow
        Dim dataEmpleado As DataRow

        'tbArticulo.Text = "Sin datos"
        'tbPrecioTotal.Text = "Sin datos"
        'tbTotalAPagar.Text = "Sin datos"
        'tbMesaSeleccionada.Text = "Sin datos"
        'tbUnidades.Text = "Sin datos"

        tbArticulo.Text = ""
        tbPrecioTotal.Text = ""
        tbTotalAPagar.Text = ""
        tbMesaSeleccionada.Text = ""
        tbUnidades.Text = ""

        Try
            conexion.Conectar()
            miTablaEmpleados = conexion._miDataSet.Tables("Empleados")
            miDataRowEmpleados = miTablaEmpleados.Select("IdEmpleado = '" & idEmpleado & "' AND Borrado = False")
            dataEmpleado = miDataRowEmpleados(0)
            lblGUEmpleado.Text = dataEmpleado("Nombre") + " " + dataEmpleado("Apellido")
        Catch ex As Exception
            lblGUEmpleado.Text = "ERROR"
        End Try

        Dim fechaHoraActual As Date = Date.Now
        lblGUFecha.Text = fechaHoraActual.ToString("d")

        lblGUCajaActual.Text = "Caja 1"

    End Sub

    Private Sub frmPaginaPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CancelButton = btnGUApagar
    End Sub

    Private Sub btnGUCerrar_Click(sender As Object, e As EventArgs) Handles btnGUApagar.Click
        Dim confirma As frmConfirmacion = New frmConfirmacion("¿Seguro que desea salir del TPV?")
        If confirma.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.Close()
        End If
    End Sub

    Private Sub timerHoraActual_Tick(sender As Object, e As EventArgs) Handles timerHoraActual.Tick
        lblGUHora.Text = TimeOfDay
    End Sub

    Private Sub btnGUProductoDemo_Click(sender As Object, e As EventArgs) Handles btnGUProductoDemo.Click
        Dim cantidad As frmCantidadProducto = New frmCantidadProducto("Coca-Cola")
        cantidad.ShowDialog()
    End Sub

    Private Sub btnMesas_Click(sender As Object, e As EventArgs) Handles btnMesas.Click
        Dim miTablaMesas, miTablaArticulosDeComanda, miTablaArticulos, miTablaCategorias As DataTable
        Dim miDataRowMesas(), miDataRowComandas(), miDataRowArticulosEnLineaComandas() As DataRow
        Dim mesa As DataRow
        Dim precioTotal As Double

        Dim selecMesas As frmSeleccionMesa = New frmSeleccionMesa
        If (selecMesas.ShowDialog() = DialogResult.OK) Then
            Me.codMesa = selecMesas.codMesa
            Me.codEmpleado = selecMesas.codEmpleado

            miTablaMesas = conexion._miDataSet.Tables("Mesas")
            miDataRowMesas = miTablaMesas.Select("IdMesa = '" & Me.codMesa & "' AND Borrado = False")
            mesa = miDataRowMesas(0)

            miDataRowComandas = mesa.GetChildRows("Comandas_Mesas")
            For Each comanda As DataRow In miDataRowComandas
                If comanda("FormaPago") Is DBNull.Value And comanda("Borrado") = False Then
                    Me.comandaAbierta = comanda
                End If
            Next

            miTablaArticulos = conexion._miDataSet.Tables("Articulos")
            miTablaCategorias = conexion._miDataSet.Tables("Categorias")

            miTablaArticulosDeComanda = New DataTable
            miTablaArticulosDeComanda.Columns.Add("IdArticulo", GetType(Integer))
            miTablaArticulosDeComanda.Columns.Add("Nombre", GetType(String))
            miTablaArticulosDeComanda.Columns.Add("Cantidad", GetType(Integer))
            miTablaArticulosDeComanda.Columns.Add("Precio", GetType(Double))
            miTablaArticulosDeComanda.Columns.Add("Categoria", GetType(String))

            If Me.comandaAbierta IsNot Nothing Then
                miDataRowArticulosEnLineaComandas = Me.comandaAbierta.GetChildRows("LineaComandas_Comandas")

                For Each articulo As DataRow In miDataRowArticulosEnLineaComandas
                    Dim miDataRowInfoArticulo() As DataRow = miTablaArticulos.Select("IdArticulo = '" & articulo("IdArticulo") & "' AND Borrado = False")
                    Dim infoArticulo = miDataRowInfoArticulo(0)
                    Dim miDataRowCategorias() As DataRow = miTablaCategorias.Select("IdCategoria = '" & infoArticulo("IdCategoria") & "' AND Borrado = False")
                    Dim infoCategoria = miDataRowCategorias(0)

                    miTablaArticulosDeComanda.Rows.Add(infoArticulo("IdArticulo"), infoArticulo("Nombre"), articulo("Cantidad"), infoArticulo("Precio"), infoCategoria("NombreCategoria"))

                    precioTotal = precioTotal + (articulo("Cantidad") * infoArticulo("Precio"))
                Next
            End If

            tbMesaSeleccionada.Text = ""
            tbUnidades.Text = ""
            tbArticulo.Text = ""
            tbPrecioTotal.Text = ""
            tbTotalAPagar.Text = ""
            dgvComandas.DataSource = ""

            dgvComandas.DataSource = miTablaArticulosDeComanda
            dgvComandas.Columns("IdArticulo").Visible = False
            tbMesaSeleccionada.Text = mesa("Denominacion")
            tbTotalAPagar.Text = precioTotal
        Else
            Return
        End If

    End Sub

    Private Sub btnBorrarComanda_Click(sender As Object, e As EventArgs) Handles btnBorrarComanda.Click
        If Me.comandaAbierta Is Nothing Then
            Dim mensaje As New frmMensaje("No hay ninguna comanda seleccionada", False)
            mensaje.ShowDialog()
        Else
            Dim confirma As frmConfirmacion = New frmConfirmacion("¿Seguro que desea borrar la comanda?")
            If confirma.ShowDialog() = Windows.Forms.DialogResult.OK Then

                Dim miTablaMesas As DataTable
                Dim miDataRowMesas() As DataRow
                Dim mesa As DataRow

                Me.comandaAbierta("Borrado") = True

                miTablaMesas = conexion._miDataSet.Tables("Mesas")
                miDataRowMesas = miTablaMesas.Select("IdMesa = '" & Me.codMesa & "' AND Borrado = False")
                mesa = miDataRowMesas(0)

                mesa("Estado") = "Libre"

                tbMesaSeleccionada.Text = ""
                tbUnidades.Text = ""
                tbArticulo.Text = ""
                tbPrecioTotal.Text = ""
                tbTotalAPagar.Text = ""
                dgvComandas.DataSource = ""

                conexion.miDataAdapterMesas.Update(conexion._miDataSet, "Mesas")
                conexion.miDataAdapterComandas.Update(conexion._miDataSet, "Comandas")

                Dim mensaje As New frmMensaje("Se ha eliminado la comanda", False)
                mensaje.ShowDialog()

            End If
        End If
    End Sub

    Private Sub dgvComandas_SelectionChanged(sender As Object, e As EventArgs) Handles dgvComandas.SelectionChanged
        If dgvComandas.CurrentCell IsNot Nothing Then
            tbUnidades.Text = dgvComandas.Rows(dgvComandas.CurrentCell.RowIndex).Cells("Cantidad").Value.ToString()
            tbArticulo.Text = dgvComandas.Rows(dgvComandas.CurrentCell.RowIndex).Cells("Nombre").Value.ToString()
            Dim valor As Double = Math.Round(dgvComandas.Rows(dgvComandas.CurrentCell.RowIndex).Cells("Precio").Value.ToString() * dgvComandas.Rows(dgvComandas.CurrentCell.RowIndex).Cells("Cantidad").Value.ToString(), 2)
            tbPrecioTotal.Text = valor
        End If
    End Sub

    Private Sub btnBorrarProducto_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnGestionArticulos_Click(sender As Object, e As EventArgs) Handles btnGestionArticulos.Click
        frmArticulosCRUD.ShowDialog()
    End Sub
End Class