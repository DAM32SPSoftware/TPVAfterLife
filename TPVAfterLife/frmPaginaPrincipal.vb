Public Class frmPaginaPrincipal
    Private Sub frmPaginaPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CancelButton = btnGUApagar
    End Sub

    Private Sub btnGUCerrar_Click(sender As Object, e As EventArgs) Handles btnGUApagar.Click
        Dim confirma As frmConfirmacion = New frmConfirmacion("¿Seguro que desea salir del TPV?")
        If confirma.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.Close()
        End If
    End Sub
End Class