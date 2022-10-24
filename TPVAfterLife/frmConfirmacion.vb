Imports System.Reflection.Emit

Public Class frmConfirmacion

    Public Sub New(pregunta As String)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        lblPregunta.Text = pregunta
    End Sub

    Private Sub btnGUDenegar_Click(sender As Object, e As EventArgs) Handles btnGUDenegar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnGUConfirmar_Click(sender As Object, e As EventArgs) Handles btnGUConfirmar.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub frmConfirmacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPregunta.MaximumSize = New Size(400, 200)
        lblPregunta.AutoSize = True
    End Sub
End Class