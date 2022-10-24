Imports System.Windows
Imports System.Windows.Forms.Design.AxImporter

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AcceptButton = btnGUIniciarTPV
        CancelButton = btnGUSalir
    End Sub

    Private Sub btnGUAcercaDe_Click(sender As Object, e As EventArgs) Handles btnGUAcercaDe.Click
        frmAcercaDe.ShowDialog()
    End Sub

    Private Sub btnGUSalir_Click(sender As Object, e As EventArgs) Handles btnGUSalir.Click
        Dim confirma As frmConfirmacion = New frmConfirmacion("¿Seguro que desea salir?")
        If confirma.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.Close()
        End If
    End Sub

    Private Sub btnGUIniciarTPV_Click(sender As Object, e As EventArgs) Handles btnGUIniciarTPV.Click
        frmLogin.ShowDialog()
    End Sub

End Class
