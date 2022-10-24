Imports System.Data.SqlClient
Imports System.Diagnostics.Metrics

Public Class frmLogin

    Private miDataAdapter As SqlDataAdapter
    Private miDataSet As DataSet

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbContrasenia.ResetText()
        tbUsuario.ResetText()
    End Sub

    Private Sub btnGUIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnGUIniciarSesion.Click
        Dim mytable As DataTable
        Dim myDataRow() As DataRow
        Dim userlogin As DataRow

        Dim usuario = tbUsuario.Text.ToLower()
        Dim contrasenia = tbContrasenia.Text.ToLower()

        Dim miConexion As New SqlConnection
        miConexion.ConnectionString = "SERVER=DESKTOP-198S9HC\SQLEXPRESS;
                                Integrated Security=SSPI;DATABASE=Reto1DAM32"

        'dataset
        miDataSet = New DataSet

        miConexion.Open()

        'dataAdapter
        'miDataAdapter = New SqlDataAdapter("SELECT * FROM CuentasEmpleados where Usuario=" + tbUsuario.Text.ToLower() + "and Contraseña=" + tbContrasenia.Text.ToLower(), miConexion)
        miDataAdapter = New SqlDataAdapter("SELECT * FROM CuentasEmpleados", miConexion)

        'commandBuilder
        Dim miCommandBuilder As SqlCommandBuilder = New SqlCommandBuilder(miDataAdapter)
        miDataAdapter.Fill(miDataSet, "CuentasEmpleados")

        miConexion.Close()

        mytable = miDataSet.Tables("CuentasEmpleados")
        myDataRow = mytable.Select("Usuario = '" & usuario.ToLower() & "' AND Contraseña = '" & contrasenia.ToLower() & "'")
        Try
            userlogin = myDataRow(0)
            If usuario = userlogin("Usuario") And contrasenia = userlogin("Contraseña") Then
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