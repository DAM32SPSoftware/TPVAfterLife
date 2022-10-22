Imports System.Windows

Public Class Form1
    Protected Overrides Sub Finalize()
        Dim confirma As frmConfirmacion = New frmConfirmacion("¿Seguro que desea salir?")
        confirma.ShowDialog()
        If confirma.DialogResult.Yes Then

        End If
        MyBase.Finalize()
    End Sub

    Private Sub btnGUAcercaDe_Click(sender As Object, e As EventArgs) Handles btnGUAcercaDe.Click
        frmAcercaDe.ShowDialog()
    End Sub

    Private Sub btnGUSalir_Click(sender As Object, e As EventArgs) Handles btnGUSalir.Click
        Dim confirma As frmConfirmacion = New frmConfirmacion("Seguro que desea salir")
        confirma.ShowDialog()
    End Sub

    Private Sub btnGUIniciarTPV_Click(sender As Object, e As EventArgs) Handles btnGUIniciarTPV.Click
        frmLogin.ShowDialog()
    End Sub


End Class
