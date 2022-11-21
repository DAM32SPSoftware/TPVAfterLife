Public Class frmCajaDiaria

    Public conexion As New Conexion
    Dim miTablaArticulosDeComanda As DataTable
    Public totalHoy As Double
    Public Sub New()
        InitializeComponent()
        'Conexion.Conectar()
        'lblGUProducto.Text = CodProducto.ToString()

        'idProducto = CodProducto
        'idComanda = CodComanda

    End Sub

    Private Sub frmCajaDiaria_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CancelButton = Guna2Button1

        miTablaArticulosDeComanda = New DataTable
        miTablaArticulosDeComanda.Columns.Add("FechaComanda", GetType(Date))
        miTablaArticulosDeComanda.Columns.Add("FormaPago", GetType(String))
        miTablaArticulosDeComanda.Columns.Add("PrecioTotal", GetType(Double))

        conexion.Conectar()

        Dim miLineaComandas As DataTable
        Dim miDataRowLineaComandas As DataRow()

        Dim fechaHoraActual As Date = Date.Now
        lblGUFecha.Text = fechaHoraActual.ToString("yyyy'-'MM'-'dd")
        'Me.cantidad = 0
        'Me.verificaMayorQueCero()

        'AcceptButton = btnGUAceptar
        'CancelButton = btnGUCancelar
        Dim formaPago As String
        formaPago = "Metálico"

        miLineaComandas = conexion._miDataSet.Tables("Comandas")
        miDataRowLineaComandas = miLineaComandas.Select("FormaPago = '" & formaPago & "' AND FechaComanda = '" & Date.Parse(lblGUFecha.Text.ToString) & "'")

        For Each comanda As DataRow In miDataRowLineaComandas
            miTablaArticulosDeComanda.Rows.Add(comanda("FechaComanda"), comanda("FormaPago"), comanda("PrecioTotal"))
            totalHoy += comanda("PrecioTotal")
        Next

        lblTotal.Text = totalHoy.ToString & "€"
        DataGridView1.DataSource = miTablaArticulosDeComanda
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()
    End Sub
End Class