Imports System.Windows

Public Class Form1
    Private Sub btnAcercaDe_Click(sender As Object, e As EventArgs) Handles btnAcercaDe.Click
        frmAcercaDe.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class
