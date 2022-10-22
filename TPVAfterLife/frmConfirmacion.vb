Public Class frmConfirmacion

    Private respuesta As Boolean

    Public Sub New(pregunta As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        lblPregunta.Text = pregunta
    End Sub

    Private Sub frmConfirmacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        respuesta = False
    End Sub

    Private Sub btnGUDenegar_Click(sender As Object, e As EventArgs) Handles btnGUDenegar.Click
        respuesta = False
    End Sub

    Private Sub btnGUConfirmar_Click(sender As Object, e As EventArgs) Handles btnGUConfirmar.Click

    End Sub

    Private Sub lblPregunta_Click(sender As Object, e As EventArgs) Handles lblPregunta.Click

    End Sub
End Class