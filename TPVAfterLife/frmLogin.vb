Imports System.Data.SqlClient

Public Class frmLogin

    Private miDataAdapter As SqlDataAdapter
    Private miDataSet As DataSet

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbContrasenia.ResetText()
        tbUsuario.ResetText()
    End Sub

    Private Sub btnGUIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnGUIniciarSesion.Click

        Dim miConexion As New SqlConnection
        miConexion.ConnectionString = "SERVER=DESKTOP-198S9HC\SQLEXPRESS;
                                Integrated Security=SSPI;DATABASE=Reto1DAM32"
        'dataset
        miDataSet = New DataSet

        miConexion.Open()

        'dataAdapter
        miDataAdapter = New SqlDataAdapter("SELECT * FROM CuentasEmpleados where Usuario=" + tbUsuario.Text.ToLower() + "and Contraseña=" + tbContrasenia.Text.ToLower(), miConexion)
        miDataAdapter.Fill(miDataSet, "CuentasEmpleados")
        miDataAdapter = Nothing

        'commandBuilder

        Dim miCommandBuilder As SqlCommandBuilder = New SqlCommandBuilder(miDataAdapter)

        miConexion.Close()

        Dim miTabla As DataTable
        Dim miColumna As DataColumn
        For Each miTabla In miDataSet.Tables

            For Each miColumna In miTabla.Columns
                tbContrasenia.Text = ""
                tbUsuario.Text = miColumna.Container.ToString()
            Next
            
        Next

        Me.Close()
        frmPaginaPrincipal.ShowDialog()
    End Sub

    Private Sub btnGUCancelar_Click(sender As Object, e As EventArgs) Handles btnGUCancelar.Click
        Me.Close()
    End Sub
End Class