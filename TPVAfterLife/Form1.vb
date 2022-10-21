Imports System.Windows

Public Class Form1
    Private Sub btnGUAcercaDe_Click(sender As Object, e As EventArgs) Handles btnGUAcercaDe.Click
        frmAcercaDe.ShowDialog()
    End Sub

    Private Sub btnGUSalir_Click(sender As Object, e As EventArgs) Handles btnGUSalir.Click
        Me.Close()
    End Sub

    Private Sub btnGUIniciarTPV_Click(sender As Object, e As EventArgs) Handles btnGUIniciarTPV.Click
        frmLogin.ShowDialog()
    End Sub
End Class
