Imports System.Data.SqlClient
Imports System.Diagnostics.Metrics

Public Class frmLogin

    Public conexion As New Conexion

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbContrasenia.ResetText()
        tbUsuario.ResetText()
        AcceptButton = btnGUIniciarSesion
        CancelButton = btnGUCancelar
    End Sub

    Private Sub btnGUIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnGUIniciarSesion.Click
        Dim miTablaCuentasEmpleados, miTablaEmpleados, miTablaTipoEmpleado As DataTable
        Dim miDataRowCuentasEmpleados(), miDataRowEmpleados(), miDataRowTipoEmpleado() As DataRow
        Dim usuariologin, empleadoEspecifico, tipoEmpleado As DataRow

        Dim usuario = tbUsuario.Text.ToLower()
        Dim contrasenia = tbContrasenia.Text.ToLower()

        Try
            conexion.Conectar()
            miTablaCuentasEmpleados = conexion._miDataSet.Tables("CuentasEmpleados")
            'miTablaEmpleados = conexion._miDataSet.Tables("Empleados")
            'miTablaTipoEmpleado = conexion._miDataSet.Tables("TipoEmpleado")
            miDataRowCuentasEmpleados = miTablaCuentasEmpleados.Select("Usuario = '" & usuario & "' AND Contraseña = '" & contrasenia & "'")
            usuariologin = miDataRowCuentasEmpleados(0)
            'miDataRowEmpleados = miTablaEmpleados.Select("IdEmpleado = '" & usuariologin("IdEmpleado") & "'")
            'empleadoEspecifico = miDataRowEmpleados(0)
            'miDataRowTipoEmpleado = miTablaTipoEmpleado.Select("IdTipoEmpleado = '" & empleadoEspecifico("IdTipoEmpleado") & "'")
            'tipoEmpleado = miDataRowTipoEmpleado(0)

            If usuario = usuariologin("Usuario") And contrasenia = usuariologin("Contraseña") Then
                'If tipoEmpleado("NombreTipo") = "admin" Or tipoEmpleado("NombreTipo") = "gerente" Then
                '    Me.Visible = False
                '    Me.Close()
                '    frmPaginaPrincipal.ShowDialog()
                'Else
                '    Dim mensaje As New frmMensaje("Usuario o contraseña incorrectos o no son válidos", True)
                '    mensaje.ShowDialog()
                'End If
                Me.Visible = False
                Me.Close()
                frmPaginaPrincipal.ShowDialog()
            Else
                Dim mensaje As New frmMensaje("Usuario o contraseña incorrectos o no son válidos", True)
                mensaje.ShowDialog()
            End If
        Catch ex As Exception
            Dim mensaje As New frmMensaje("Usuario o contraseña incorrectos o no son válidos", True)
            mensaje.ShowDialog()
        End Try

    End Sub

    Private Sub btnGUCancelar_Click(sender As Object, e As EventArgs) Handles btnGUCancelar.Click
        Me.Close()
    End Sub
End Class