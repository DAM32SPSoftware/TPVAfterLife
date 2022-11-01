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
        Dim miTablaCuentasEmpleados As DataTable
        Dim miDataRowCuentasEmpleados() As DataRow
        Dim usuariologin As DataRow

        Dim usuario = tbUsuario.Text.ToLower().Trim()
        Dim contrasenia = tbContrasenia.Text.ToLower().Trim()

        Try
            conexion.Conectar()
            miTablaCuentasEmpleados = conexion._miDataSet.Tables("CuentasEmpleados")
            miDataRowCuentasEmpleados = miTablaCuentasEmpleados.Select("Usuario = '" & usuario & "' AND Contraseña = '" & contrasenia & "' AND Borrado = False")
            usuariologin = miDataRowCuentasEmpleados(0)

            If usuario = usuariologin("Usuario") And contrasenia = usuariologin("Contraseña") Then
                Me.Visible = False
                Me.Close()
                Dim PagPrincipal As New frmPaginaPrincipal(usuariologin("IdEmpleado"))
                PagPrincipal.ShowDialog()
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