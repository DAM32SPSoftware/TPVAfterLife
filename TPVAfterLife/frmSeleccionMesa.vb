Imports Guna.UI2.WinForms

Public Class frmSeleccionMesa

    Public conexion As New Conexion
    Public Property codMesa As String
    Public Property codEmpleado As String

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
                If mesa("Estado") = "No disponible" Then
                    btn.Enabled = False
                End If

                coordX = coordX + 200
                aux += 1
                Me.Controls.Add(btn)
                AddHandler btn.Click, Sub() BotonMesa_Click(btn.Name)

            Next

        Catch ex As Exception
            Dim mensaje As New frmMensaje("No hay mesas en la base de datos", True)
            mensaje.ShowDialog()
        End Try

    End Sub

    Private Sub BotonMesa_Click(codMesa As String)

        Dim codAutenticacionEmple As String

        Dim miTablaMesas, miTablaCuentasEmpleados As DataTable
        Dim miDataRowMesas(), miDataRowCuentas(), miDataRowEmpleados(), miDataRowComandas() As DataRow
        Dim mesa, empleado, comandaAbierta As DataRow

        Dim formCodigo As New frmAutenticacionEmpleado
        If (formCodigo.ShowDialog() = DialogResult.OK) Then
            codAutenticacionEmple = formCodigo.codigo
        Else
            Return
        End If

        miTablaCuentasEmpleados = conexion._miDataSet.Tables("CuentasEmpleados")
        miDataRowCuentas = miTablaCuentasEmpleados.Select("CodigoAutenticacion = '" & codAutenticacionEmple & "' AND Borrado = False")
        Try
            miDataRowEmpleados = miDataRowCuentas(0).GetChildRows("CuentasEmpleados_Empleados")
        Catch ex As Exception
            Dim mensaje As New frmMensaje("Codigo de empleado incorrecto o no valido", True)
            mensaje.ShowDialog()
            Return
        End Try
        For Each emple As DataRow In miDataRowEmpleados
            If emple("Borrado") = False Then
                empleado = emple
            End If
        Next

        miTablaMesas = conexion._miDataSet.Tables("Mesas")
        miDataRowMesas = miTablaMesas.Select("IdMesa = '" & codMesa & "' AND Borrado = False")
        mesa = miDataRowMesas(0)

        If mesa("Estado") = "Libre" Then
            Dim nuevoDataRowComandas As DataRow
            nuevoDataRowComandas = conexion._miDataSet.Tables("Comandas").NewRow
            nuevoDataRowComandas("IdComanda") = Int((9999999 * Rnd()) + 1)
            nuevoDataRowComandas("IdEmpleado") = empleado("IdEmpleado")
            nuevoDataRowComandas("IdMesa") = codMesa
            nuevoDataRowComandas("FechaComanda") = Date.Now.ToString("d")
            'nuevoDataRowComandas("FormaPago") = ""
            'nuevoDataRowComandas("PrecioTotal") = ""
            'nuevoDataRowComandas("IdFactura") = ""
            nuevoDataRowComandas("Borrado") = False

            'miTablaMesas.Rows(conexion._miDataSet.Tables("Mesas").Rows.IndexOf(mesa)).Item("Estado") = "Ocupada"
            mesa("Estado") = "Ocupada"
            conexion._miDataSet.Tables("Comandas").Rows.Add(nuevoDataRowComandas)

            conexion.miDataAdapterMesas.Update(conexion._miDataSet, "Mesas")
            conexion.miDataAdapterComandas.Update(conexion._miDataSet, "Comandas")

            Me.codMesa = mesa("IdMesa")
            Me.codEmpleado = empleado("IdEmpleado")
            Me.DialogResult = Windows.Forms.DialogResult.OK
        ElseIf mesa("Estado") = "Ocupada" Then
            miDataRowComandas = mesa.GetChildRows("Comandas_Mesas")
            For Each comanda As DataRow In miDataRowComandas
                If comanda("FormaPago") Is DBNull.Value Then
                    comandaAbierta = comanda
                End If
            Next
            Dim dataRowEmpleado() As DataRow = miTablaCuentasEmpleados.Select("IdEmpleado = '" & comandaAbierta("IdEmpleado") & "' AND Borrado = False")
            Dim authEmpleado As String = dataRowEmpleado(0)("CodigoAutenticacion")
            If authEmpleado = codAutenticacionEmple Then
                Me.codMesa = mesa("IdMesa")
                Me.codEmpleado = comandaAbierta("IdEmpleado")
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                Dim mensaje As New frmMensaje("Codigo de empleado incorrecto o no valido", True)
                mensaje.ShowDialog()
                Return
            End If
        End If

        Me.Close()

    End Sub

    Private Sub Guna2GroupBox1_Click(sender As Object, e As EventArgs)

    End Sub
End Class