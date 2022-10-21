Public Class frmAcercaDe
    Private Sub lblAqui_Click(sender As Object, e As EventArgs) Handles lblAqui.Click
        frmTheGame.ShowDialog()
    End Sub

    Private Sub btnGUAceptar_Click(sender As Object, e As EventArgs) Handles btnGUAceptar.Click
        Me.Close()
    End Sub
End Class