Imports Guna.UI2.WinForms

Public Class frmSeleccionMesa

    Public conexion As New Conexion

    Private Sub frmSeleccionMesa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim miTablaMesas As DataTable
        Dim miDataRowMesas() As DataRow

        Try
            conexion.Conectar()
            miTablaMesas = conexion._miDataSet.Tables("Mesas")
            miDataRowMesas = miTablaMesas.Select("Borrado = False")

            Dim coordX As Integer = 105
            Dim coordY As Integer = 150
            Dim aux As Integer = 0
            Dim cont As Integer = 0

            For Each mesa As DataRow In miDataRowMesas

                If aux = 4 Then
                    coordX = 105
                    coordY += 170
                    aux = 0
                End If

                Dim btn As New Guna2Button With {
                    .Name = mesa("IdMesa"),
                    .Text = mesa("Denominacion"),
                    .Size = New Size(130, 105),
                    .MaximumSize = New Size(130, 105),
                    .MinimumSize = New Size(130, 105),
                    .Location = New Point(coordX, coordY),
                    .Font = New Drawing.Font("Segoe UI", 22, FontStyle.Bold),
                    .ForeColor = Color.FromArgb(63, 99, 88),
                    .Cursor = Cursors.Hand,
                    .BorderRadius = 15,
                    .FillColor = Color.FromArgb(252, 226, 173),
                    .TextAlign = HorizontalAlignment.Center
                }

                coordX = coordX + 200
                aux += 1
                Me.Controls.Add(btn)
                AddHandler btn.Click, Sub() ShowMessage_Click(btn.Name)
                cont += 1

            Next

        Catch ex As Exception
            Dim mensaje As New frmMensaje("No hay mesas en la base de datos", True)
            mensaje.ShowDialog()
        End Try

    End Sub

    Private Sub ShowMessage_Click(nombre As String)
        MessageBox.Show(nombre)
    End Sub

    Private Sub Guna2GroupBox1_Click(sender As Object, e As EventArgs)

    End Sub
End Class