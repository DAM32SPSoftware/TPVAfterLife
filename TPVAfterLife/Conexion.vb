Imports System.Data.SqlClient

Public Class Conexion
    Private miDataSet As DataSet
    Public miConexion As New SqlConnection
    Public miDataAdapterCuentasEmpleados, miDataAdapterEmpleados, miDataAdapterTipoEmpleado, miDataAdapterMesas, miDataAdapterComandas As SqlDataAdapter
    Public miDataAdapterFacturas, miDataAdapterCajas, miDataAdapterLineaComandas, miDataAdapterArticulos, miDataAdapterCategorias As SqlDataAdapter
    Public cadenaDeConexion = "SERVER=DESKTOP-198S9HC\SQLEXPRESS;Integrated Security=SSPI;DATABASE=Reto1DAM32"

    Public Sub Conectar()
        Try

            miConexion.ConnectionString = cadenaDeConexion

            miDataAdapterCuentasEmpleados = New SqlDataAdapter("SELECT * FROM CuentasEmpleados", miConexion)
            miDataAdapterEmpleados = New SqlDataAdapter("SELECT * FROM Empleados", miConexion)
            miDataAdapterTipoEmpleado = New SqlDataAdapter("SELECT * FROM TipoEmpleado", miConexion)
            miDataAdapterMesas = New SqlDataAdapter("SELECT * FROM Mesas", miConexion)
            miDataAdapterComandas = New SqlDataAdapter("SELECT * FROM Comandas", miConexion)
            miDataAdapterFacturas = New SqlDataAdapter("SELECT * FROM Facturas", miConexion)
            miDataAdapterCajas = New SqlDataAdapter("SELECT * FROM Cajas", miConexion)
            miDataAdapterLineaComandas = New SqlDataAdapter("SELECT * FROM LineaComandas", miConexion)
            miDataAdapterArticulos = New SqlDataAdapter("SELECT * FROM Articulos", miConexion)
            miDataAdapterCategorias = New SqlDataAdapter("SELECT * FROM Categorias", miConexion)

            Dim miCommandBuilder1 As SqlCommandBuilder = New SqlCommandBuilder(miDataAdapterCuentasEmpleados)
            Dim miCommandBuilder2 As SqlCommandBuilder = New SqlCommandBuilder(miDataAdapterEmpleados)
            Dim miCommandBuilder3 As SqlCommandBuilder = New SqlCommandBuilder(miDataAdapterTipoEmpleado)
            Dim miCommandBuilder4 As SqlCommandBuilder = New SqlCommandBuilder(miDataAdapterMesas)
            Dim miCommandBuilder5 As SqlCommandBuilder = New SqlCommandBuilder(miDataAdapterComandas)
            Dim miCommandBuilder6 As SqlCommandBuilder = New SqlCommandBuilder(miDataAdapterFacturas)
            Dim miCommandBuilder7 As SqlCommandBuilder = New SqlCommandBuilder(miDataAdapterCajas)
            Dim miCommandBuilder8 As SqlCommandBuilder = New SqlCommandBuilder(miDataAdapterLineaComandas)
            Dim miCommandBuilder9 As SqlCommandBuilder = New SqlCommandBuilder(miDataAdapterArticulos)
            Dim miCommandBuilder10 As SqlCommandBuilder = New SqlCommandBuilder(miDataAdapterCategorias)

            miDataSet = New DataSet

            miConexion.Open()

            miDataAdapterCuentasEmpleados.Fill(miDataSet, "CuentasEmpleados")
            miDataAdapterEmpleados.Fill(miDataSet, "Empleados")
            miDataAdapterTipoEmpleado.Fill(miDataSet, "TipoEmpleado")
            miDataAdapterMesas.Fill(miDataSet, "Mesas")
            miDataAdapterComandas.Fill(miDataSet, "Comandas")
            miDataAdapterFacturas.Fill(miDataSet, "Facturas")
            miDataAdapterCajas.Fill(miDataSet, "Cajas")
            miDataAdapterLineaComandas.Fill(miDataSet, "LineaComandas")
            miDataAdapterArticulos.Fill(miDataSet, "Articulos")
            miDataAdapterCategorias.Fill(miDataSet, "Categorias")

            miDataAdapterCuentasEmpleados = Nothing
            miDataAdapterEmpleados = Nothing
            miDataAdapterTipoEmpleado = Nothing
            miDataAdapterMesas = Nothing
            miDataAdapterComandas = Nothing
            miDataAdapterFacturas = Nothing
            miDataAdapterCajas = Nothing
            miDataAdapterLineaComandas = Nothing
            miDataAdapterArticulos = Nothing
            miDataAdapterCategorias = Nothing

            miConexion.Close()

            miDataSet.Relations.Add("Empleados_Empleados",
                        miDataSet.Tables("Empleados").Columns("IdEmpleado"),
                        miDataSet.Tables("Empleados").Columns("Gerente"))
            miDataSet.Relations.Add("CuentasEmpleados_Empleados",
                        miDataSet.Tables("Empleados").Columns("IdEmpleado"),
                        miDataSet.Tables("CuentasEmpleados").Columns("IdEmpleado"))
            miDataSet.Relations.Add("Empleados_TipoEmpleado",
                        miDataSet.Tables("TipoEmpleado").Columns("IdTipoEmpleado"),
                        miDataSet.Tables("Empleados").Columns("IdTipoEmpleado"))
            miDataSet.Relations.Add("Comandas_Mesas",
                        miDataSet.Tables("Mesas").Columns("IdMesa"),
                        miDataSet.Tables("Comandas").Columns("IdMesa"))
            miDataSet.Relations.Add("Facturas_Cajas",
                        miDataSet.Tables("Cajas").Columns("IdCaja"),
                        miDataSet.Tables("Facturas").Columns("IdCaja"))
            miDataSet.Relations.Add("Comandas_Facturas",
                        miDataSet.Tables("Facturas").Columns("IdFactura"),
                        miDataSet.Tables("Comandas").Columns("IdFactura"))
            miDataSet.Relations.Add("Articulos_Categorias",
                        miDataSet.Tables("Categorias").Columns("IdCategoria"),
                        miDataSet.Tables("Articulos").Columns("IdCategoria"))
            miDataSet.Relations.Add("LineaComandas_Articulos",
                        miDataSet.Tables("Articulos").Columns("IdArticulo"),
                        miDataSet.Tables("LineaComandas").Columns("IdArticulo"))
            miDataSet.Relations.Add("LineaComndas_Comandas",
                        miDataSet.Tables("Comandas").Columns("IdComanda"),
                        miDataSet.Tables("LineaComandas").Columns("IdComanda"))
            miDataSet.Relations.Add("Comandas_Empleados",
                        miDataSet.Tables("Empleados").Columns("IdEmpleado"),
                        miDataSet.Tables("Comandas").Columns("IdEmpleado"))

        Catch ex As Exception
            Dim mensaje As New frmMensaje("Error al crear la conexion", True)
            mensaje.ShowDialog()
            Console.WriteLine(ex)
            Exit Sub
        End Try
    End Sub

    Public Property _miDataSet As DataSet
        Get
            Return miDataSet
        End Get
        Set(value As DataSet)
            miDataSet = value
        End Set
    End Property

End Class
