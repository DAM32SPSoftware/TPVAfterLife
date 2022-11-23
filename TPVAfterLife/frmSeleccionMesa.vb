Imports Guna.UI2.WinForms

Public Class frmSeleccionMesa

    'Public conexion As New Conexion
    Public Property codMesa As String
    Public Property codEmpleado As String

    Private Sub frmSeleccionMesa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Para colocar los botones:
        Dim miTablaMesas As DataTable
        Dim miDataRowMesas() As DataRow

        Try
            Form1.conexion.Conectar()
            miTablaMesas = Form1.conexion._miDataSet.Tables("Mesas")
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
                If mesa("Estado") = "Ocupada" Then
                    btn.ForeColor = Color.Red

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
        'Busco la Cuenta de Empleado a través del código introducido por el usuario en frmAutenticacionEmpleado
        miTablaCuentasEmpleados = Form1.conexion._miDataSet.Tables("CuentasEmpleados")
        miDataRowCuentas = miTablaCuentasEmpleados.Select("CodigoAutenticacion = '" & codAutenticacionEmple & "' AND Borrado = False")
        Try
            'Aquí saco a traves de la relación el Empleado de esa Cuenta de Empleado
            miDataRowEmpleados = miDataRowCuentas(0).GetChildRows("CuentasEmpleados_Empleados")
        Catch ex As Exception
            Dim mensaje As New frmMensaje("Codigo de empleado incorrecto o no valido", True)
            mensaje.ShowDialog()
            Return
        End Try
        'A partir de aquí solo se ejecuta si lo de arriba ha salido correctamente.
        'Ahora comprobamos si ese empleado está en activo, es decir, si borrado es false, y lo asignamos en un DataRow simple
        For Each emple As DataRow In miDataRowEmpleados
            If emple("Borrado") = False Then
                empleado = emple
            End If
        Next

        'codMesa lo recibimos como parámetro, gracias a: "AddHandler btn.Click, Sub() BotonMesa_Click(btn.Name)" cada vez que pulsamos uno de los botones autogenerados
        miTablaMesas = Form1.conexion._miDataSet.Tables("Mesas")
        miDataRowMesas = miTablaMesas.Select("IdMesa = '" & codMesa & "' AND Borrado = False")
        mesa = miDataRowMesas(0)

        'Si la mesa está libre creamos un nuevo registro en la tabla Comandas, donde se relacionan tanto el IdEmpleado (obtenido a través del DataRow empleado
        'como el IdMesa, recibio a través de codMesa como antes hemos comentado
        If mesa("Estado") = "Libre" Then
            Dim nuevoDataRowComandas As DataRow
            nuevoDataRowComandas = Form1.conexion._miDataSet.Tables("Comandas").NewRow
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
            Form1.conexion._miDataSet.Tables("Comandas").Rows.Add(nuevoDataRowComandas)

            'Actualizamos el estado de la mesa, y añadimos la nueva comanda
            Form1.conexion.miDataAdapterMesas.Update(Form1.conexion._miDataSet, "Mesas")
            Form1.conexion.miDataAdapterComandas.Update(Form1.conexion._miDataSet, "Comandas")
            Form1.conexion.Conectar()

            'Pasamos los IDs a las variables globales
            Me.codMesa = mesa("IdMesa")
            Me.codEmpleado = empleado("IdEmpleado")
            Me.DialogResult = Windows.Forms.DialogResult.OK

            'Si la mesa está ocupada:
        ElseIf mesa("Estado") = "Ocupada" Then
            'Comprobamos si está pagada la comanda en esa única mesa, si no está pagada (FormaPago null) la comanda se asigna como comandaAbierta
            miDataRowComandas = mesa.GetChildRows("Comandas_Mesas")
            'Una mesa puede tener varias comandas abiertas de diferentes empleados
            For Each comanda As DataRow In miDataRowComandas
                If comanda("FormaPago") Is DBNull.Value Then
                    comandaAbierta = comanda
                End If
            Next

            'Aquí miramos si el Empleado es "dueño" de alguna de esas comandas
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