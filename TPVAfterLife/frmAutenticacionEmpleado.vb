Public Class frmAutenticacionEmpleado
    Public Property codigo As Integer
    Private Sub frmAutenticacionEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.codigo = 0
        Me.verificaMayorQueCero()
        AcceptButton = btnGUAceptar
        CancelButton = btnGUCancelar
    End Sub

    Private Sub btnGUUno_Click(sender As Object, e As EventArgs) Handles btnGUUno.Click
        Me.clickTecladoNumerico(1)
    End Sub
    Private Sub btnGUDos_Click(sender As Object, e As EventArgs) Handles btnGUDos.Click
        Me.clickTecladoNumerico(2)
    End Sub
    Private Sub btnGUTres_Click(sender As Object, e As EventArgs) Handles btnGUTres.Click
        Me.clickTecladoNumerico(3)
    End Sub
    Private Sub btnGUCuatro_Click(sender As Object, e As EventArgs) Handles btnGUCuatro.Click
        Me.clickTecladoNumerico(4)
    End Sub
    Private Sub btnGUCinco_Click(sender As Object, e As EventArgs) Handles btnGUCinco.Click
        Me.clickTecladoNumerico(5)
    End Sub
    Private Sub btnGUSeis_Click(sender As Object, e As EventArgs) Handles btnGUSeis.Click
        Me.clickTecladoNumerico(6)
    End Sub
    Private Sub btnGUSiete_Click(sender As Object, e As EventArgs) Handles btnGUSiete.Click
        Me.clickTecladoNumerico(7)
    End Sub
    Private Sub btnGUOcho_Click(sender As Object, e As EventArgs) Handles btnGUOcho.Click
        Me.clickTecladoNumerico(8)
    End Sub
    Private Sub btnGUNueve_Click(sender As Object, e As EventArgs) Handles btnGUNueve.Click
        Me.clickTecladoNumerico(9)
    End Sub
    Private Sub btnGUCero_Click(sender As Object, e As EventArgs) Handles btnGUCero.Click
        Me.clickTecladoNumerico(0)
    End Sub
    Private Sub btnGUBorrar_Click(sender As Object, e As EventArgs) Handles btnGUBorrar.Click
        Me.codigo = 0
        Me.verificaMayorQueCero()
    End Sub

    Private Sub btnGUCancelar_Click(sender As Object, e As EventArgs) Handles btnGUCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub verificaMayorQueCero()
        If Me.codigo < 0 Then
            Me.codigo = 0
        End If
        tbCodigo.Text = Me.codigo
    End Sub

    Private Sub clickTecladoNumerico(num As Integer)
        If (Me.codigo * 10) > 10000000 Then
            Return
        End If
        Me.codigo = (Me.codigo * 10) + num
        Me.verificaMayorQueCero()
    End Sub

    Private Sub btnGUAceptar_Click(sender As Object, e As EventArgs) Handles btnGUAceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class