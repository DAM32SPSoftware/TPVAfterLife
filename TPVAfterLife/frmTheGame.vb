﻿Public Class frmTheGame
    Private Sub btnGUCerrar_Click(sender As Object, e As EventArgs) Handles btnGUCerrar.Click
        Me.Close()
    End Sub

    Private Sub frmTheGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AcceptButton = btnGUCerrar
        CancelButton = btnGUCerrar
    End Sub
End Class