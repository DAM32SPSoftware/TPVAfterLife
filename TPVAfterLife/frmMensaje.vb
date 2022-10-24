Public Class frmMensaje

    Public Sub New(mensaje As String, warning As Boolean)
        InitializeComponent()
        lblMensaje.Text = mensaje
        If warning Then
            pbInfoWarning.Image = My.Resources.warning
        End If
    End Sub

    Private Sub btnGUAceptar_Click(sender As Object, e As EventArgs) Handles btnGUAceptar.Click
        Me.Close()
    End Sub

    Private Sub frmMensaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblMensaje.MaximumSize = New Size(380, 200)
        lblMensaje.AutoSize = True
    End Sub

End Class