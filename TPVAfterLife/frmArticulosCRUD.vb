Imports System.Data.Common

Public Class frmArticulosCRUD

    Public conexion As New Conexion

    Private Sub btnGUSalir_Click(sender As Object, e As EventArgs) Handles btnGUSalir.Click
        Dim confirma As frmConfirmacion = New frmConfirmacion("¿Seguro que desea cerrar?")
        If confirma.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.Close()
        End If
    End Sub

    Private Sub frmArticulosCRUD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim miTablaArticulos, miTablaArticulosFiltrada As DataTable
        Dim miDataRowArticulos() As DataRow

        CancelButton = btnGUSalir

        Try
            conexion.Conectar()
            miTablaArticulos = conexion._miDataSet.Tables("Articulos")
            miDataRowArticulos = miTablaArticulos.Select("Borrado = False")
            miTablaArticulosFiltrada = miDataRowArticulos.CopyToDataTable()
            miTablaArticulosFiltrada.Columns.Add("Categoria", GetType(String))

            dgvArticulos.DataSource = miTablaArticulosFiltrada
            dgvArticulos.Columns("IdArticulo").Visible = False
            dgvArticulos.Columns("IdCategoria").Visible = False
            dgvArticulos.Columns("Borrado").Visible = False
        Catch ex As Exception
            Dim mensaje As New frmMensaje("Error en la conexión al obtener datos", True)
            mensaje.ShowDialog()
            Me.Close()
        End Try
    End Sub
End Class