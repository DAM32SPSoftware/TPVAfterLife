Imports System.Data.SqlClient

Public Class Conexion
    Private miDataSet As DataSet
    Public miConexion As New SqlConnection
    Public miDataAdapterCuentasEmpleados, miDataAdapterEmpleados, miDataAdapterTipoEmpleado As SqlDataAdapter
    Public cadenaDeConexion = "SERVER=DESKTOP-198S9HC\SQLEXPRESS;Integrated Security=SSPI;DATABASE=Reto1DAM32"

    Public Sub Conectar()
        Try

            miConexion.ConnectionString = cadenaDeConexion

            miDataAdapterCuentasEmpleados = New SqlDataAdapter("SELECT * FROM CuentasEmpleados", miConexion)
            miDataAdapterEmpleados = New SqlDataAdapter("SELECT * FROM Empleados", miConexion)
            miDataAdapterTipoEmpleado = New SqlDataAdapter("SELECT * FROM TipoEmpleado", miConexion)

            Dim miCommandBuilder As SqlCommandBuilder = New SqlCommandBuilder(miDataAdapterCuentasEmpleados)
            Dim miCommandBuilder2 As SqlCommandBuilder = New SqlCommandBuilder(miDataAdapterEmpleados)
            Dim miCommandBuilder3 As SqlCommandBuilder = New SqlCommandBuilder(miDataAdapterTipoEmpleado)

            miDataSet = New DataSet

            miConexion.Open()

            miDataAdapterCuentasEmpleados.Fill(miDataSet, "CuentasEmpleados")
            miDataAdapterEmpleados.Fill(miDataSet, "Empleados")
            miDataAdapterTipoEmpleado.Fill(miDataSet, "TipoEmpleado")

            miDataAdapterCuentasEmpleados = Nothing
            miDataAdapterEmpleados = Nothing
            miDataAdapterTipoEmpleado = Nothing

            miConexion.Close()

            miDataSet.Relations.Add("CuentasEmpleados_Empleados",
                        miDataSet.Tables("CuentasEmpleados").Columns("IdEmpleado"),
                        miDataSet.Tables("Empleados").Columns("IdEmpleado"))
            miDataSet.Relations.Add("Empleados_TipoEmpleado",
                        miDataSet.Tables("Empleados").Columns("IdTipoEmpleado"),
                        miDataSet.Tables("TipoEmpleado").Columns("IdTipoEmpleado"))
            miDataSet.Relations.Add("Empleados_Empleados",
                        miDataSet.Tables("Empleados").Columns("IdEmpleado"),
                        miDataSet.Tables("Empleados").Columns("Gerente"))

        Catch ex As Exception
            Dim mensaje As New frmMensaje("Error al crear la conexion", True)
            mensaje.ShowDialog()
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
