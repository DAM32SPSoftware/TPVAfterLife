Public Class frmPaginaPrincipal

    Public conexion As New Conexion

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
            miDataRowEmpleados = miTablaEmpleados.Select("IdEmpleado = '" & idEmpleado & "'")
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
        Dim selecMesas As frmSeleccionMesa = New frmSeleccionMesa
        If (selecMesas.ShowDialog() = DialogResult.OK) Then
            Dim codMesa As String = selecMesas.codMesa

        Else
            Return
        End If

    End Sub
End Class