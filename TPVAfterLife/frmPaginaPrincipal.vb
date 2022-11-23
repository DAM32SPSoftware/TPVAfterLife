Imports Guna.UI2.WinForms

Public Class frmPaginaPrincipal

    'TO_DO

    'SE TIENEN QUE REINICIAR LOS DATOS DEL ARTICULO SELECCIONADO AL CAMBIAR DE COMANDA
    'ADMINISTRAR ARTICULOS SOLO SI ERES ADMIN

    'Public conexion As New Conexion
    Dim cantidad As Integer
    Private codMesa As String
    Private codEmpleado As String
    Public comandaAbierta As DataRow
    Private articuloSeleccionado As DataRow
    Dim miDataRowArticulosEnLineaComandas() As DataRow
    Dim miTablaArticulosDeComanda As DataTable

    Public Sub New(idEmpleado As String)
        InitializeComponent()

        Dim miTablaEmpleados As DataTable
        Dim miDataRowEmpleados() As DataRow
        Dim dataEmpleado As DataRow

        tbArticulo.Text = ""
        tbPrecioTotal.Text = ""
        tbTotalAPagar.Text = ""
        tbMesaSeleccionada.Text = ""
        tbUnidades.Text = ""

        'If dataEmpleado("IdEmpleado") AND dataEmpleado("Gerente") son iguales (tienen el mismo ID) entonces el boton de gestión de empleados aparece habilitado

        Try
            Form1.conexion.Conectar()
            miTablaEmpleados = Form1.conexion._miDataSet.Tables("Empleados")
            miDataRowEmpleados = miTablaEmpleados.Select("IdEmpleado = '" & idEmpleado & "' AND Borrado = False")
            dataEmpleado = miDataRowEmpleados(0)
            lblGUEmpleado.Text = dataEmpleado("Nombre") + " " + dataEmpleado("Apellido")
            If (dataEmpleado("IdEmpleado") = dataEmpleado("Gerente")) Then
                btnGestionEmpleados.Enabled = True
                btnGestionArticulos.Enabled = True
            End If

        Catch ex As Exception
            lblGUEmpleado.Text = "ERROR"
        End Try

        Dim fechaHoraActual As Date = Date.Now
        lblGUFecha.Text = fechaHoraActual.ToString("d")

        lblGUCajaActual.Text = "Caja 1"

    End Sub

    Private Sub frmPaginaPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CancelButton = btnGUApagar
        RellenarArticulos()

        miTablaArticulosDeComanda = New DataTable
        miTablaArticulosDeComanda.Columns.Add("IdArticulo", GetType(Integer))
        miTablaArticulosDeComanda.Columns.Add("Nombre", GetType(String))
        miTablaArticulosDeComanda.Columns.Add("Cantidad", GetType(Integer))
        miTablaArticulosDeComanda.Columns.Add("Precio", GetType(Double))
        miTablaArticulosDeComanda.Columns.Add("Categoria", GetType(String))

        Me.cantidad = 0

    End Sub

    Private Sub RellenarArticulos()
        Dim miTablaArticulos As DataTable
        Dim miDataRowArticulos() As DataRow

        Try
            miTablaArticulos = Form1.conexion._miDataSet.Tables("Articulos")
            miDataRowArticulos = miTablaArticulos.Select("Borrado = False")

            Dim coordX As Integer = 105
            Dim coordY As Integer = 120
            Dim aux As Integer = 0

            For Each articulo As DataRow In miDataRowArticulos

                If aux = 4 Then
                    coordX = 105 '105
                    coordY += 120
                    aux = 0
                End If

                Dim btn As New Guna2Button With {
                    .Name = articulo("IdArticulo"),
                    .Text = articulo("Nombre"),
                    .Size = New Size(130, 105),
                    .MaximumSize = New Size(97, 80),
                    .MinimumSize = New Size(97, 80),
                    .Location = New Point(coordX, coordY),
                    .Font = New Drawing.Font("Segoe UI", 10, FontStyle.Bold),
                    .ForeColor = Color.FromArgb(63, 99, 88),
                    .Cursor = Cursors.Hand,
                    .BorderRadius = 15,
                    .FillColor = Color.FromArgb(252, 226, 173),
                    .TextAlign = HorizontalAlignment.Center
                }
                If articulo("Stock") = 0 Then
                    btn.Enabled = False
                End If

                coordX = coordX + 150
                aux += 1
                Me.Panel2.Controls.Add(btn)

                AddHandler btn.Click, Sub() btnArticulo_Click(btn.Name)

            Next

        Catch ex As Exception
            Dim mensaje As New frmMensaje("No hay mesas en la base de datos", True)
            mensaje.ShowDialog()
        End Try
    End Sub

    Private Sub btnGUCerrar_Click(sender As Object, e As EventArgs) Handles btnGUApagar.Click
        Dim confirma As frmConfirmacion = New frmConfirmacion("¿Seguro que desea salir del TPV?")
        If confirma.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.Close()
        End If
    End Sub

    Private Sub timerHoraActual_Tick(sender As Object, e As EventArgs) Handles timerHoraActual.Tick
        lblGUHora.Text = TimeOfDay
    End Sub

    'a cambiar:'
    Private Sub btnArticulo_Click(name As String)
        Dim miTablaArticulos, miTablaCategorias As DataTable
        Dim precioTotal As Double
        miTablaArticulos = Form1.conexion._miDataSet.Tables("Articulos")
        miTablaCategorias = Form1.conexion._miDataSet.Tables("Categorias")

        If Me.comandaAbierta Is Nothing Then
            Dim mensaje As frmMensaje = New frmMensaje("No hay ninguna comanda abierta!", False)
            mensaje.ShowDialog()
        Else
            Dim cantidad As frmCantidadProducto = New frmCantidadProducto(name, comandaAbierta("IdComanda"))
            MessageBox.Show("Antes del OK")
            If cantidad.ShowDialog() = DialogResult.OK Then
                'conexion.ActualizarDB()
                'Dim miTablaMesas As DataTable
                'Dim miDataRowMesas(), miDataRowComandas() As DataRow
                'Dim mesa As DataRow

                'miTablaMesas = conexion._miDataSet.Tables("Mesas")
                'miDataRowMesas = miTablaMesas.Select("IdMesa = '" & Me.codMesa & "' AND Borrado = False")
                'mesa = miDataRowMesas(0)

                ''Obtengo las comandas de dicha mesa y comprueba si está pagada y si está borrada, si está sin pagar y no está borrada va al dataRow
                'miDataRowComandas = mesa.GetChildRows("Comandas_Mesas")
                'For Each comanda As DataRow In miDataRowComandas
                '    If comanda("FormaPago") Is DBNull.Value And comanda("Borrado") = False Then
                '        Me.comandaAbierta = comanda
                '        'AQUI HAY ALGO RARO PORQUE COMANDAABIERTA ES DATAROW SIMPLE POR LO QUE SOLO SE ESTÁ QUEDANDO CON LA ÚLTIMA COMANDA QUE VEA
                '    End If
                'Next
                MessageBox.Show("Antes del try")
                Try
                    'Obtenemos todos sus Artículos:
                    Dim pruebaRow() As DataRow
                    Dim prueba As DataRow
                    Form1.conexion.Conectar()
                    Form1.conexion.ActualizarDB()
                    pruebaRow = Form1.conexion._miDataSet.Tables("LineaComandas").Select("IdComanda = '" & comandaAbierta("IdComanda") & "'")

                    miTablaArticulosDeComanda.Rows.Clear()

                    For Each articulo As DataRow In pruebaRow
                        MessageBox.Show(articulo("IdArticulo"))
                        'Obtenemos la info tanto de Articulos como de Categorias
                        Dim miDataRowInfoArticulo() As DataRow = miTablaArticulos.Select("IdArticulo = '" & articulo("IdArticulo") & "' AND Borrado = False")
                        Dim infoArticulo = miDataRowInfoArticulo(0)
                        Dim miDataRowCategorias() As DataRow = miTablaCategorias.Select("IdCategoria = '" & infoArticulo("IdCategoria") & "' AND Borrado = False")
                        Dim infoCategoria = miDataRowCategorias(0)

                        'Añadimos dicho articulo a lo que luego se usará como fuente para el dataGridView
                        miTablaArticulosDeComanda.Rows.Add(infoArticulo("IdArticulo"), infoArticulo("Nombre"), articulo("Cantidad"), infoArticulo("Precio"), infoCategoria("NombreCategoria"))

                        'Actualizamos el precio total
                        precioTotal = precioTotal + (articulo("Cantidad") * infoArticulo("Precio"))
                    Next

                    tbUnidades.Text = ""
                    tbArticulo.Text = ""
                    tbPrecioTotal.Text = ""
                    tbTotalAPagar.Text = ""
                    tbEfectivo.Text = ""
                    'Fuente de datos para el dgv
                    dgvComandas.DataSource = ""
                    dgvComandas.DataSource = miTablaArticulosDeComanda
                    'Ocultamos IdArticulo
                    dgvComandas.Columns("IdArticulo").Visible = False
                    tbTotalAPagar.Text = precioTotal
                    Form1.conexion.ActualizarDB()
                Catch ex As Exception
                    Dim mensaje As frmMensaje = New frmMensaje("Error!", False)
                    mensaje.ShowDialog()
                End Try
            Else
                MessageBox.Show("nO HA SIDO OK")
            End If
        End If
    End Sub

    Private Sub btnMesas_Click(sender As Object, e As EventArgs) Handles btnMesas.Click
        Dim miTablaMesas, miTablaArticulos, miTablaCategorias As DataTable
        Dim miDataRowMesas(), miDataRowComandas() As DataRow
        Dim mesa As DataRow
        Dim precioTotal As Double
        Form1.conexion.ActualizarDB()
        Dim selecMesas As frmSeleccionMesa = New frmSeleccionMesa
        If (selecMesas.ShowDialog() = DialogResult.OK) Then
            dgvComandas.ClearSelection()

            'Pasamos los dos resultados obtenidos del otro form a variables globales de este form
            Me.codMesa = selecMesas.codMesa
            Me.codEmpleado = selecMesas.codEmpleado

            miTablaMesas = Form1.conexion._miDataSet.Tables("Mesas")
            miDataRowMesas = miTablaMesas.Select("IdMesa = '" & Me.codMesa & "' AND Borrado = False")
            mesa = miDataRowMesas(0)

            'Obtengo las comandas de dicha mesa y comprueba si está pagada y si está borrada, si está sin pagar y no está borrada va al dataRow
            miDataRowComandas = mesa.GetChildRows("Comandas_Mesas")
            For Each comanda As DataRow In miDataRowComandas
                If comanda("FormaPago") Is DBNull.Value And comanda("Borrado") = False Then
                    Me.comandaAbierta = comanda
                    'AQUI HAY ALGO RARO PORQUE COMANDA ABIERTA ES DATAROW SIMPLE POR LO QUE SOLO SE ESTÁ QUEDANDO CON LA ÚLTIMA COMANDA QUE VEA
                End If
            Next

            'Form1.conexion._miDataSet.Tables("LineaComandas").

            'Hacemos conexiones tanto a Artículos como a Categorias
            miTablaArticulos = Form1.conexion._miDataSet.Tables("Articulos")
            miTablaCategorias = Form1.conexion._miDataSet.Tables("Categorias")

            'Creamos este tipo de tabla para luego usarla como fuente para el dataGridView
            'miTablaArticulosDeComanda = New DataTable
            'miTablaArticulosDeComanda.Columns.Add("IdArticulo", GetType(Integer))
            'miTablaArticulosDeComanda.Columns.Add("Nombre", GetType(String))
            'miTablaArticulosDeComanda.Columns.Add("Cantidad", GetType(Integer))
            'miTablaArticulosDeComanda.Columns.Add("Precio", GetType(Double))
            'miTablaArticulosDeComanda.Columns.Add("Categoria", GetType(String))

            'Si hay una comandaAbierta:
            If Me.comandaAbierta IsNot Nothing Then
                'Obtenemos todos sus Artículos:
                miDataRowArticulosEnLineaComandas = Me.comandaAbierta.GetChildRows("LineaComandas_Comandas")

                For Each articulo As DataRow In miDataRowArticulosEnLineaComandas
                    'Obtenemos la info tanto de Articulos como de Categorias
                    Dim miDataRowInfoArticulo() As DataRow = miTablaArticulos.Select("IdArticulo = '" & articulo("IdArticulo") & "' AND Borrado = False")
                    Dim infoArticulo = miDataRowInfoArticulo(0)
                    Dim miDataRowCategorias() As DataRow = miTablaCategorias.Select("IdCategoria = '" & infoArticulo("IdCategoria") & "' AND Borrado = False")
                    Dim infoCategoria = miDataRowCategorias(0)

                    'Añadimos dicho articulo a lo que luego se usará como fuente para el dataGridView
                    miTablaArticulosDeComanda.Rows.Add(infoArticulo("IdArticulo"), infoArticulo("Nombre"), articulo("Cantidad"), infoArticulo("Precio"), infoCategoria("NombreCategoria"))

                    'Actualizamos el precio total
                    precioTotal = precioTotal + (articulo("Cantidad") * infoArticulo("Precio"))
                Next
            End If

            tbMesaSeleccionada.Text = ""
            tbUnidades.Text = ""
            tbArticulo.Text = ""
            tbPrecioTotal.Text = ""
            tbTotalAPagar.Text = ""
            tbEfectivo.Text = ""
            dgvComandas.DataSource = ""
            miTablaArticulosDeComanda.Rows.Clear()
            'Fuente de datos para el dgv
            dgvComandas.DataSource = miTablaArticulosDeComanda
            'Ocultamos IdArticulo
            dgvComandas.Columns("IdArticulo").Visible = False
            tbMesaSeleccionada.Text = mesa("Denominacion")
            tbTotalAPagar.Text = precioTotal
            Form1.conexion.ActualizarDB()

            btnMesas.Enabled = False


        Else
            Return
        End If

    End Sub

    Private Sub btnBorrarComanda_Click(sender As Object, e As EventArgs) Handles btnBorrarComanda.Click
        If Me.comandaAbierta Is Nothing Then
            Dim mensaje As New frmMensaje("No hay ninguna comanda seleccionada", False)
            mensaje.ShowDialog()
        Else
            Dim confirma As frmConfirmacion = New frmConfirmacion("¿Seguro que desea borrar la comanda?")
            If confirma.ShowDialog() = Windows.Forms.DialogResult.OK Then

                Dim miTablaMesas As DataTable
                Dim miDataRowMesas() As DataRow
                Dim mesa As DataRow

                'Me.comandaAbierta = Nothing

                miTablaMesas = Form1.conexion._miDataSet.Tables("Mesas")
                miDataRowMesas = miTablaMesas.Select("IdMesa = '" & Me.codMesa & "' AND Borrado = False")
                mesa = miDataRowMesas(0)

                mesa("Estado") = "Libre"

                tbMesaSeleccionada.Text = ""
                tbUnidades.Text = ""
                tbArticulo.Text = ""
                tbPrecioTotal.Text = ""
                tbTotalAPagar.Text = ""
                tbEfectivo.Text = ""
                dgvComandas.DataSource = ""

                Form1.conexion.miDataAdapterMesas.Update(Form1.conexion._miDataSet, "Mesas")
                Form1.conexion.miDataAdapterComandas.Update(Form1.conexion._miDataSet, "Comandas")

                Dim mensaje As New frmMensaje("Se ha eliminado la comanda", False)
                mensaje.ShowDialog()

                btnMesas.Enabled = True




                Dim miLineaComandas As DataRow()

                miLineaComandas = Form1.conexion._miDataSet.Tables("LineaComandas").Select("IdComanda = '" & Me.comandaAbierta("IdComanda") & "'")
                For Each linea In miLineaComandas
                    linea.Delete()
                Next
                Form1.conexion.ActualizarDB()
                Me.comandaAbierta = Nothing
            End If
        End If
    End Sub

    Private Sub dgvComandas_SelectionChanged(sender As Object, e As EventArgs) Handles dgvComandas.SelectionChanged
        If dgvComandas.CurrentCell IsNot Nothing Then
            tbUnidades.Text = dgvComandas.Rows(dgvComandas.CurrentCell.RowIndex).Cells("Cantidad").Value.ToString()
            tbArticulo.Text = dgvComandas.Rows(dgvComandas.CurrentCell.RowIndex).Cells("Nombre").Value.ToString()
            Dim valor As Double = Math.Round(dgvComandas.Rows(dgvComandas.CurrentCell.RowIndex).Cells("Precio").Value.ToString() * dgvComandas.Rows(dgvComandas.CurrentCell.RowIndex).Cells("Cantidad").Value.ToString(), 2)
            tbPrecioTotal.Text = valor
        End If
    End Sub

    Private Sub btnBorrarProducto_Click(sender As Object, e As EventArgs)
        Dim miTablaArticulos, miTablaCategorias As DataTable
        Dim precioTotal As Double
        miTablaArticulos = Form1.conexion._miDataSet.Tables("Articulos")
        miTablaCategorias = Form1.conexion._miDataSet.Tables("Categorias")



        If Me.comandaAbierta Is Nothing Then
            Dim mensaje As frmMensaje = New frmMensaje("No hay ninguna comanda abierta!", False)
            mensaje.ShowDialog()
        Else
            If dgvComandas.SelectedRows.Count = 1 And dgvComandas.CurrentCell IsNot Nothing Then
                Dim confirma As frmConfirmacion = New frmConfirmacion("¿Seguro que desea borrar el producto seleccionado?")
                If confirma.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Try
                        Dim miTablaLineaComandas As DataTable
                        miTablaLineaComandas = Form1.conexion._miDataSet.Tables("LineaComandas")
                        miTablaLineaComandas.Rows(dgvComandas.CurrentCell.RowIndex).Delete()
                        'Form1.conexion.Conectar()
                        Form1.conexion.ActualizarDB()

                        Dim mensaje As frmMensaje = New frmMensaje("Producto eliminado con éxito!", False)
                        mensaje.ShowDialog()
                        miTablaArticulosDeComanda.Rows.Clear()
                        'Obtenemos todos sus Artículos:
                        'miTablaArticulosDeComanda.Rows.Clear()
                        Dim prueba2() As DataRow
                        Dim prueba3 As DataRow
                        prueba2 = Form1.conexion._miDataSet.Tables("Comandas").Select("IdComanda = '" & comandaAbierta("IdComanda") & "'")
                        miDataRowArticulosEnLineaComandas = prueba2(0).GetChildRows("LineaComandas_Comandas")

                        For Each articulo As DataRow In miDataRowArticulosEnLineaComandas
                            'Obtenemos la info tanto de Articulos como de Categorias
                            Dim miDataRowInfoArticulo() As DataRow = miTablaArticulos.Select("IdArticulo = '" & articulo("IdArticulo") & "' AND Borrado = False")
                            Dim infoArticulo = miDataRowInfoArticulo(0)
                            Dim miDataRowCategorias() As DataRow = miTablaCategorias.Select("IdCategoria = '" & infoArticulo("IdCategoria") & "' AND Borrado = False")
                            Dim infoCategoria = miDataRowCategorias(0)

                            'Añadimos dicho articulo a lo que luego se usará como fuente para el dataGridView
                            miTablaArticulosDeComanda.Rows.Add(infoArticulo("IdArticulo"), infoArticulo("Nombre"), articulo("Cantidad"), infoArticulo("Precio"), infoCategoria("NombreCategoria"))

                            'Actualizamos el precio total
                            precioTotal = precioTotal + (articulo("Cantidad") * infoArticulo("Precio"))
                        Next

                        tbUnidades.Text = ""
                        tbArticulo.Text = ""
                        tbPrecioTotal.Text = ""
                        tbTotalAPagar.Text = ""
                        tbEfectivo.Text = ""
                        dgvComandas.DataSource = ""
                        'Fuente de datos para el dgv
                        dgvComandas.DataSource = miTablaArticulosDeComanda
                        'Ocultamos IdArticulo
                        dgvComandas.Columns("IdArticulo").Visible = False
                        tbTotalAPagar.Text = precioTotal

                        Form1.conexion.ActualizarDB()
                    Catch ex As Exception
                        Dim mensaje As frmMensaje = New frmMensaje("Error!", False)
                        mensaje.ShowDialog()
                    End Try
                End If
            Else
                Dim mensaje As frmMensaje = New frmMensaje("Seleccione un producto a eliminar!", False)
                mensaje.ShowDialog()
            End If
        End If
    End Sub

    Private Sub btnGestionArticulos_Click(sender As Object, e As EventArgs) Handles btnGestionArticulos.Click
        frmArticulosCRUD.ShowDialog()
    End Sub

    Private Sub btnEditarProducto_Click(sender As Object, e As EventArgs) Handles btnEditarComanda.Click
        Dim miTablaArticulos, miTablaCategorias As DataTable
        Dim precioTotal As Double
        miTablaArticulos = Form1.conexion._miDataSet.Tables("Articulos")
        miTablaCategorias = Form1.conexion._miDataSet.Tables("Categorias")
        Dim miTablaLineaComandas As DataTable
        miTablaLineaComandas = Form1.conexion._miDataSet.Tables("LineaComandas")
        If dgvComandas.SelectedRows.Count = 1 And dgvComandas.CurrentCell IsNot Nothing Then
            Dim frmEditar As frmEditarProducto = New frmEditarProducto(miTablaLineaComandas.Rows(dgvComandas.CurrentCell.RowIndex).Item("IdArticulo"))
            If frmEditar.ShowDialog() = Windows.Forms.DialogResult.OK Then
                'Dim prueba1() As DataRow
                Form1.conexion._miDataSet.Tables("LineaComandas").Rows(dgvComandas.CurrentCell.RowIndex).Item("Cantidad") = Integer.Parse(frmEditar.cantidad)
                'miTablaLineaComandas.Rows(dgvComandas.CurrentCell.RowIndex).Item("Cantidad") = Integer.Parse(frmEditar.cantidad)

                Form1.conexion.ActualizarDB()
            End If
            Dim prueba2() As DataRow
            Dim prueba3 As DataRow
            miTablaArticulosDeComanda.Rows.Clear()
            prueba2 = Form1.conexion._miDataSet.Tables("Comandas").Select("IdComanda = '" & comandaAbierta("IdComanda") & "'")
            miDataRowArticulosEnLineaComandas = prueba2(0).GetChildRows("LineaComandas_Comandas")

            For Each articulo As DataRow In miDataRowArticulosEnLineaComandas
                'Obtenemos la info tanto de Articulos como de Categorias
                Dim miDataRowInfoArticulo() As DataRow = miTablaArticulos.Select("IdArticulo = '" & articulo("IdArticulo") & "' AND Borrado = False")
                Dim infoArticulo = miDataRowInfoArticulo(0)
                Dim miDataRowCategorias() As DataRow = miTablaCategorias.Select("IdCategoria = '" & infoArticulo("IdCategoria") & "' AND Borrado = False")
                Dim infoCategoria = miDataRowCategorias(0)

                'Añadimos dicho articulo a lo que luego se usará como fuente para el dataGridView
                miTablaArticulosDeComanda.Rows.Add(infoArticulo("IdArticulo"), infoArticulo("Nombre"), articulo("Cantidad"), infoArticulo("Precio"), infoCategoria("NombreCategoria"))

                'Actualizamos el precio total
                precioTotal = precioTotal + (articulo("Cantidad") * infoArticulo("Precio"))
            Next

            tbUnidades.Text = ""
            tbArticulo.Text = ""
            tbPrecioTotal.Text = ""
            tbTotalAPagar.Text = ""
            tbEfectivo.Text = ""
            dgvComandas.DataSource = ""
            'Fuente de datos para el dgv
            dgvComandas.DataSource = miTablaArticulosDeComanda
            'Ocultamos IdArticulo
            dgvComandas.Columns("IdArticulo").Visible = False
            tbTotalAPagar.Text = precioTotal
            Form1.conexion.ActualizarDB()
        Else
            Dim mensaje As frmMensaje = New frmMensaje("Seleccione un producto a editar!", False)
            mensaje.ShowDialog()
        End If
    End Sub

    Private Sub verificaMayorQueCero()
        If Me.cantidad < 0 Then
            Me.cantidad = 0
        End If
        tbEfectivo.Text = Me.cantidad
    End Sub

    Private Sub clickTecladoNumerico(num As Integer)
        If (Me.cantidad * 10) > 10000000 Then
            Return
        End If
        Me.cantidad = (Me.cantidad * 10) + num
        Me.verificaMayorQueCero()
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

    Private Sub btnGUCorregir_Click(sender As Object, e As EventArgs) Handles btnGUCorregir.Click
        Me.cantidad = 0
        Me.verificaMayorQueCero()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If tbEfectivo.Text Is String.Empty Or tbTotalAPagar.Text Is String.Empty Then
            Dim mensaje As frmMensaje = New frmMensaje("No se puede cobrar todavía!", False)
            mensaje.ShowDialog()
            Return
        End If
        If Double.Parse(tbEfectivo.Text) < Double.Parse(tbTotalAPagar.Text) Then
            Dim mensaje As frmMensaje = New frmMensaje("La cantidad de efectivo debe ser mayor que el total a pagar!", False)
            mensaje.ShowDialog()
            Return
        End If
        Dim confirma As frmConfirmacion = New frmConfirmacion("¿Seguro que desea cobrar?")
        If confirma.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim mensaje As frmMensaje = New frmMensaje("La factura está siendo impresa... Total a devolver: " & Double.Parse(tbEfectivo.Text) - Double.Parse(tbTotalAPagar.Text) & "€", False)
            mensaje.ShowDialog()
            comandaPagada()
            btnMesas.Enabled = True
        End If
    End Sub

    Public Sub comandaPagada()
        Dim miTablaMesas As DataTable
        Dim miDataRowMesas() As DataRow
        Dim mesa As DataRow

        Dim miTablaComandas As DataTable
        Dim miLineaComandas As DataRow()

        Form1.conexion.Conectar()

        miTablaComandas = Form1.conexion._miDataSet.Tables("Comandas")
        miLineaComandas = miTablaComandas.Select()

        For Each linea In miLineaComandas
            linea("FormaPago") = "Metálico"
            linea("PrecioTotal") = Double.Parse(tbTotalAPagar.Text)
            linea("Borrado") = False
        Next

        'mesa("Estado") = "Libre"

        tbMesaSeleccionada.Text = ""
        tbUnidades.Text = ""
        tbArticulo.Text = ""
        tbPrecioTotal.Text = ""
        tbTotalAPagar.Text = ""
        tbEfectivo.Text = ""
        dgvComandas.DataSource = ""

        dgvComandas.ClearSelection()

        tbUnidades.Text = ""
        tbArticulo.Text = ""
        tbTotalAPagar.Text = ""


        Form1.conexion.miDataAdapterMesas.Update(Form1.conexion._miDataSet, "Mesas")
        Form1.conexion.miDataAdapterComandas.Update(Form1.conexion._miDataSet, "Comandas")
        Me.comandaAbierta = Nothing
        Form1.conexion.ActualizarDB()

        'Dim miLineaComandas As DataRow()

        'Me.comandaAbierta("FormaPago") = "Metálico"
        'Me.comandaAbierta("PrecioTotal") = Double.Parse(tbTotalAPagar.Text)

        'miTablaMesas = Form1.conexion._miDataSet.Tables("Mesas")
        'miDataRowMesas = miTablaMesas.Select("IdMesa = '" & Me.codMesa & "' AND Borrado = False")
        'mesa = miDataRowMesas(0)

        'mesa("Estado") = "Libre"

        'tbMesaSeleccionada.Text = ""
        'tbUnidades.Text = ""
        'tbArticulo.Text = ""
        'tbPrecioTotal.Text = ""
        'tbTotalAPagar.Text = ""
        'tbEfectivo.Text = ""
        'dgvComandas.DataSource = ""

        'dgvComandas.ClearSelection()

        'tbUnidades.Text = ""
        'tbArticulo.Text = ""
        'tbTotalAPagar.Text = ""

        'Dim miLineaComandas As DataRow()

        'miLineaComandas = Form1.conexion._miDataSet.Tables("LineaComandas").Select("IdComanda = '" & Me.comandaAbierta("IdComanda") & "'")
        'For Each linea In miLineaComandas
        '    linea.Delete()
        'Next

        'Form1.conexion.miDataAdapterMesas.Update(Form1.conexion._miDataSet, "Mesas")
        'Form1.conexion.miDataAdapterComandas.Update(Form1.conexion._miDataSet, "Comandas")
        'Me.comandaAbierta = Nothing
        'Form1.conexion.ActualizarDB()
    End Sub

    Private Sub btnGUOk_Click(sender As Object, e As EventArgs) Handles btnGUOk.Click
        Dim mensaje As frmMensaje = New frmMensaje("Es necesario tener lector de tarjetas para usar esta funcionalidad!", True)
        mensaje.ShowDialog()
    End Sub

    Private Sub dgvComandas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvComandas.CellContentClick

    End Sub

    Private Sub btnUltimaComanda_Click(sender As Object, e As EventArgs) Handles btnUltimaComanda.Click
        Dim cajaDiaria As frmCajaDiaria = New frmCajaDiaria()
        cajaDiaria.ShowDialog()
    End Sub
End Class