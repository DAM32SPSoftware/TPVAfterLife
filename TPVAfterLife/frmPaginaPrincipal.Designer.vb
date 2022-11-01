<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPaginaPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim btnBorrarProducto As Guna.UI2.WinForms.Guna2Button
        Me.btnGUApagar = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblGUHora = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblGUFecha = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblGUCajaActual = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblGUEmpleado = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblGUInfoHora = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblGUInfoFecha = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblGUInfoCajaActual = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblGUInfoEmpleado = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.dgvComandas = New System.Windows.Forms.DataGridView()
        Me.btnGUUno = New Guna.UI2.WinForms.Guna2Button()
        Me.btnGUDos = New Guna.UI2.WinForms.Guna2Button()
        Me.btnGUTres = New Guna.UI2.WinForms.Guna2Button()
        Me.btnGUSeis = New Guna.UI2.WinForms.Guna2Button()
        Me.btnGUCinco = New Guna.UI2.WinForms.Guna2Button()
        Me.btnGUCuatro = New Guna.UI2.WinForms.Guna2Button()
        Me.btnGUNueve = New Guna.UI2.WinForms.Guna2Button()
        Me.btnGUOcho = New Guna.UI2.WinForms.Guna2Button()
        Me.btnGUSiete = New Guna.UI2.WinForms.Guna2Button()
        Me.btnGUCorregir = New Guna.UI2.WinForms.Guna2Button()
        Me.btnGUCero = New Guna.UI2.WinForms.Guna2Button()
        Me.btnGUOk = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.tbPrecioTotal = New System.Windows.Forms.TextBox()
        Me.tbArticulo = New System.Windows.Forms.TextBox()
        Me.tbUnidades = New System.Windows.Forms.TextBox()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnEditarComanda = New Guna.UI2.WinForms.Guna2Button()
        Me.btnUltimaComanda = New Guna.UI2.WinForms.Guna2Button()
        Me.btnBorrarComanda = New Guna.UI2.WinForms.Guna2Button()
        Me.btnMesas = New Guna.UI2.WinForms.Guna2Button()
        Me.btnGestionArticulos = New Guna.UI2.WinForms.Guna2Button()
        Me.btnGestionEmpleados = New Guna.UI2.WinForms.Guna2Button()
        Me.tbTotalAPagar = New System.Windows.Forms.TextBox()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.tbMesaSeleccionada = New System.Windows.Forms.TextBox()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.timerHoraActual = New System.Windows.Forms.Timer(Me.components)
        Me.btnGUProductoDemo = New Guna.UI2.WinForms.Guna2Button()
        btnBorrarProducto = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvComandas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBorrarProducto
        '
        btnBorrarProducto.Anchor = System.Windows.Forms.AnchorStyles.None
        btnBorrarProducto.BackColor = System.Drawing.Color.Transparent
        btnBorrarProducto.BorderRadius = 10
        btnBorrarProducto.Cursor = System.Windows.Forms.Cursors.Hand
        btnBorrarProducto.CustomizableEdges.TopLeft = False
        btnBorrarProducto.CustomizableEdges.TopRight = False
        btnBorrarProducto.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        btnBorrarProducto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        btnBorrarProducto.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        btnBorrarProducto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        btnBorrarProducto.FillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        btnBorrarProducto.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        btnBorrarProducto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        btnBorrarProducto.Location = New System.Drawing.Point(569, 442)
        btnBorrarProducto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        btnBorrarProducto.Name = "btnBorrarProducto"
        btnBorrarProducto.ShadowDecoration.BorderRadius = 20
        btnBorrarProducto.Size = New System.Drawing.Size(97, 80)
        btnBorrarProducto.TabIndex = 30
        btnBorrarProducto.Text = "Borrar Producto"
        '
        'btnGUApagar
        '
        Me.btnGUApagar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGUApagar.BackColor = System.Drawing.Color.Transparent
        Me.btnGUApagar.BorderRadius = 10
        Me.btnGUApagar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGUApagar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGUApagar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGUApagar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGUApagar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGUApagar.FillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnGUApagar.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGUApagar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnGUApagar.Location = New System.Drawing.Point(569, 822)
        Me.btnGUApagar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGUApagar.Name = "btnGUApagar"
        Me.btnGUApagar.ShadowDecoration.BorderRadius = 20
        Me.btnGUApagar.Size = New System.Drawing.Size(97, 90)
        Me.btnGUApagar.TabIndex = 7
        Me.btnGUApagar.Text = "Apagar"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblGUHora)
        Me.Panel1.Controls.Add(Me.lblGUFecha)
        Me.Panel1.Controls.Add(Me.lblGUCajaActual)
        Me.Panel1.Controls.Add(Me.lblGUEmpleado)
        Me.Panel1.Controls.Add(Me.lblGUInfoHora)
        Me.Panel1.Controls.Add(Me.lblGUInfoFecha)
        Me.Panel1.Controls.Add(Me.lblGUInfoCajaActual)
        Me.Panel1.Controls.Add(Me.lblGUInfoEmpleado)
        Me.Panel1.Location = New System.Drawing.Point(-8, 939)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1318, 76)
        Me.Panel1.TabIndex = 8
        '
        'lblGUHora
        '
        Me.lblGUHora.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblGUHora.BackColor = System.Drawing.Color.Transparent
        Me.lblGUHora.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGUHora.Location = New System.Drawing.Point(1160, 23)
        Me.lblGUHora.Name = "lblGUHora"
        Me.lblGUHora.Size = New System.Drawing.Size(103, 23)
        Me.lblGUHora.TabIndex = 7
        Me.lblGUHora.Text = "lblGUInfoHora"
        '
        'lblGUFecha
        '
        Me.lblGUFecha.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblGUFecha.BackColor = System.Drawing.Color.Transparent
        Me.lblGUFecha.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGUFecha.Location = New System.Drawing.Point(858, 23)
        Me.lblGUFecha.Name = "lblGUFecha"
        Me.lblGUFecha.Size = New System.Drawing.Size(82, 23)
        Me.lblGUFecha.TabIndex = 6
        Me.lblGUFecha.Text = "lblGUFecha"
        '
        'lblGUCajaActual
        '
        Me.lblGUCajaActual.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblGUCajaActual.BackColor = System.Drawing.Color.Transparent
        Me.lblGUCajaActual.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGUCajaActual.Location = New System.Drawing.Point(507, 23)
        Me.lblGUCajaActual.Name = "lblGUCajaActual"
        Me.lblGUCajaActual.Size = New System.Drawing.Size(115, 23)
        Me.lblGUCajaActual.TabIndex = 5
        Me.lblGUCajaActual.Text = "lblGUCajaActual"
        '
        'lblGUEmpleado
        '
        Me.lblGUEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblGUEmpleado.BackColor = System.Drawing.Color.Transparent
        Me.lblGUEmpleado.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGUEmpleado.Location = New System.Drawing.Point(135, 23)
        Me.lblGUEmpleado.Name = "lblGUEmpleado"
        Me.lblGUEmpleado.Size = New System.Drawing.Size(111, 23)
        Me.lblGUEmpleado.TabIndex = 4
        Me.lblGUEmpleado.Text = "lblGUEmpleado"
        '
        'lblGUInfoHora
        '
        Me.lblGUInfoHora.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblGUInfoHora.BackColor = System.Drawing.Color.Transparent
        Me.lblGUInfoHora.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblGUInfoHora.Location = New System.Drawing.Point(1102, 23)
        Me.lblGUInfoHora.Name = "lblGUInfoHora"
        Me.lblGUInfoHora.Size = New System.Drawing.Size(52, 23)
        Me.lblGUInfoHora.TabIndex = 3
        Me.lblGUInfoHora.Text = "HORA:"
        '
        'lblGUInfoFecha
        '
        Me.lblGUInfoFecha.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblGUInfoFecha.BackColor = System.Drawing.Color.Transparent
        Me.lblGUInfoFecha.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblGUInfoFecha.Location = New System.Drawing.Point(795, 23)
        Me.lblGUInfoFecha.Name = "lblGUInfoFecha"
        Me.lblGUInfoFecha.Size = New System.Drawing.Size(57, 23)
        Me.lblGUInfoFecha.TabIndex = 2
        Me.lblGUInfoFecha.Text = "FECHA:"
        '
        'lblGUInfoCajaActual
        '
        Me.lblGUInfoCajaActual.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblGUInfoCajaActual.BackColor = System.Drawing.Color.Transparent
        Me.lblGUInfoCajaActual.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblGUInfoCajaActual.Location = New System.Drawing.Point(390, 23)
        Me.lblGUInfoCajaActual.Name = "lblGUInfoCajaActual"
        Me.lblGUInfoCajaActual.Size = New System.Drawing.Size(111, 23)
        Me.lblGUInfoCajaActual.TabIndex = 1
        Me.lblGUInfoCajaActual.Text = "CAJA ACTUAL:"
        '
        'lblGUInfoEmpleado
        '
        Me.lblGUInfoEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblGUInfoEmpleado.BackColor = System.Drawing.Color.Transparent
        Me.lblGUInfoEmpleado.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblGUInfoEmpleado.Location = New System.Drawing.Point(36, 23)
        Me.lblGUInfoEmpleado.Name = "lblGUInfoEmpleado"
        Me.lblGUInfoEmpleado.Size = New System.Drawing.Size(93, 23)
        Me.lblGUInfoEmpleado.TabIndex = 0
        Me.lblGUInfoEmpleado.Text = "EMPLEADO:"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.BorderRadius = 10
        Me.Guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Guna2Button1.Location = New System.Drawing.Point(297, 734)
        Me.Guna2Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.BorderRadius = 20
        Me.Guna2Button1.Size = New System.Drawing.Size(249, 178)
        Me.Guna2Button1.TabIndex = 9
        Me.Guna2Button1.Text = "Cobrar"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2PictureBox1.Image = Global.TPVAfterLife.My.Resources.Resources.LogoLetrero_color_cremita_
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(21, -32)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(301, 177)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 10
        Me.Guna2PictureBox1.TabStop = False
        '
        'dgvComandas
        '
        Me.dgvComandas.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvComandas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvComandas.Location = New System.Drawing.Point(28, 106)
        Me.dgvComandas.Name = "dgvComandas"
        Me.dgvComandas.RowTemplate.Height = 25
        Me.dgvComandas.Size = New System.Drawing.Size(518, 332)
        Me.dgvComandas.TabIndex = 11
        '
        'btnGUUno
        '
        Me.btnGUUno.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGUUno.BackColor = System.Drawing.Color.Transparent
        Me.btnGUUno.BorderRadius = 10
        Me.btnGUUno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGUUno.CustomizableEdges.BottomLeft = False
        Me.btnGUUno.CustomizableEdges.BottomRight = False
        Me.btnGUUno.CustomizableEdges.TopRight = False
        Me.btnGUUno.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGUUno.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGUUno.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGUUno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGUUno.FillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnGUUno.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGUUno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnGUUno.Location = New System.Drawing.Point(28, 644)
        Me.btnGUUno.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGUUno.Name = "btnGUUno"
        Me.btnGUUno.ShadowDecoration.BorderRadius = 20
        Me.btnGUUno.Size = New System.Drawing.Size(80, 64)
        Me.btnGUUno.TabIndex = 12
        Me.btnGUUno.Text = "1"
        '
        'btnGUDos
        '
        Me.btnGUDos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGUDos.BackColor = System.Drawing.Color.Transparent
        Me.btnGUDos.BorderRadius = 10
        Me.btnGUDos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGUDos.CustomizableEdges.BottomLeft = False
        Me.btnGUDos.CustomizableEdges.BottomRight = False
        Me.btnGUDos.CustomizableEdges.TopLeft = False
        Me.btnGUDos.CustomizableEdges.TopRight = False
        Me.btnGUDos.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGUDos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGUDos.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGUDos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGUDos.FillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnGUDos.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGUDos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnGUDos.Location = New System.Drawing.Point(112, 644)
        Me.btnGUDos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGUDos.Name = "btnGUDos"
        Me.btnGUDos.ShadowDecoration.BorderRadius = 20
        Me.btnGUDos.Size = New System.Drawing.Size(80, 64)
        Me.btnGUDos.TabIndex = 13
        Me.btnGUDos.Text = "2"
        '
        'btnGUTres
        '
        Me.btnGUTres.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGUTres.BackColor = System.Drawing.Color.Transparent
        Me.btnGUTres.BorderRadius = 10
        Me.btnGUTres.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGUTres.CustomizableEdges.BottomLeft = False
        Me.btnGUTres.CustomizableEdges.BottomRight = False
        Me.btnGUTres.CustomizableEdges.TopLeft = False
        Me.btnGUTres.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGUTres.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGUTres.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGUTres.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGUTres.FillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnGUTres.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGUTres.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnGUTres.Location = New System.Drawing.Point(197, 644)
        Me.btnGUTres.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGUTres.Name = "btnGUTres"
        Me.btnGUTres.ShadowDecoration.BorderRadius = 20
        Me.btnGUTres.Size = New System.Drawing.Size(80, 64)
        Me.btnGUTres.TabIndex = 14
        Me.btnGUTres.Text = "3"
        '
        'btnGUSeis
        '
        Me.btnGUSeis.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGUSeis.BackColor = System.Drawing.Color.Transparent
        Me.btnGUSeis.BorderRadius = 10
        Me.btnGUSeis.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGUSeis.CustomizableEdges.BottomLeft = False
        Me.btnGUSeis.CustomizableEdges.BottomRight = False
        Me.btnGUSeis.CustomizableEdges.TopLeft = False
        Me.btnGUSeis.CustomizableEdges.TopRight = False
        Me.btnGUSeis.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGUSeis.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGUSeis.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGUSeis.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGUSeis.FillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnGUSeis.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGUSeis.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnGUSeis.Location = New System.Drawing.Point(196, 712)
        Me.btnGUSeis.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGUSeis.Name = "btnGUSeis"
        Me.btnGUSeis.ShadowDecoration.BorderRadius = 20
        Me.btnGUSeis.Size = New System.Drawing.Size(80, 64)
        Me.btnGUSeis.TabIndex = 17
        Me.btnGUSeis.Text = "6"
        '
        'btnGUCinco
        '
        Me.btnGUCinco.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGUCinco.BackColor = System.Drawing.Color.Transparent
        Me.btnGUCinco.BorderRadius = 10
        Me.btnGUCinco.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGUCinco.CustomizableEdges.BottomLeft = False
        Me.btnGUCinco.CustomizableEdges.BottomRight = False
        Me.btnGUCinco.CustomizableEdges.TopLeft = False
        Me.btnGUCinco.CustomizableEdges.TopRight = False
        Me.btnGUCinco.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGUCinco.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGUCinco.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGUCinco.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGUCinco.FillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnGUCinco.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGUCinco.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnGUCinco.Location = New System.Drawing.Point(112, 712)
        Me.btnGUCinco.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGUCinco.Name = "btnGUCinco"
        Me.btnGUCinco.ShadowDecoration.BorderRadius = 20
        Me.btnGUCinco.Size = New System.Drawing.Size(80, 64)
        Me.btnGUCinco.TabIndex = 16
        Me.btnGUCinco.Text = "5"
        '
        'btnGUCuatro
        '
        Me.btnGUCuatro.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGUCuatro.BackColor = System.Drawing.Color.Transparent
        Me.btnGUCuatro.BorderRadius = 10
        Me.btnGUCuatro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGUCuatro.CustomizableEdges.BottomLeft = False
        Me.btnGUCuatro.CustomizableEdges.BottomRight = False
        Me.btnGUCuatro.CustomizableEdges.TopLeft = False
        Me.btnGUCuatro.CustomizableEdges.TopRight = False
        Me.btnGUCuatro.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGUCuatro.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGUCuatro.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGUCuatro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGUCuatro.FillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnGUCuatro.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGUCuatro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnGUCuatro.Location = New System.Drawing.Point(28, 712)
        Me.btnGUCuatro.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGUCuatro.Name = "btnGUCuatro"
        Me.btnGUCuatro.ShadowDecoration.BorderRadius = 20
        Me.btnGUCuatro.Size = New System.Drawing.Size(80, 64)
        Me.btnGUCuatro.TabIndex = 15
        Me.btnGUCuatro.Text = "4"
        '
        'btnGUNueve
        '
        Me.btnGUNueve.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGUNueve.BackColor = System.Drawing.Color.Transparent
        Me.btnGUNueve.BorderRadius = 10
        Me.btnGUNueve.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGUNueve.CustomizableEdges.BottomLeft = False
        Me.btnGUNueve.CustomizableEdges.BottomRight = False
        Me.btnGUNueve.CustomizableEdges.TopLeft = False
        Me.btnGUNueve.CustomizableEdges.TopRight = False
        Me.btnGUNueve.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGUNueve.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGUNueve.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGUNueve.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGUNueve.FillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnGUNueve.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGUNueve.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnGUNueve.Location = New System.Drawing.Point(196, 780)
        Me.btnGUNueve.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGUNueve.Name = "btnGUNueve"
        Me.btnGUNueve.ShadowDecoration.BorderRadius = 20
        Me.btnGUNueve.Size = New System.Drawing.Size(80, 64)
        Me.btnGUNueve.TabIndex = 20
        Me.btnGUNueve.Text = "9"
        '
        'btnGUOcho
        '
        Me.btnGUOcho.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGUOcho.BackColor = System.Drawing.Color.Transparent
        Me.btnGUOcho.BorderRadius = 10
        Me.btnGUOcho.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGUOcho.CustomizableEdges.BottomLeft = False
        Me.btnGUOcho.CustomizableEdges.BottomRight = False
        Me.btnGUOcho.CustomizableEdges.TopLeft = False
        Me.btnGUOcho.CustomizableEdges.TopRight = False
        Me.btnGUOcho.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGUOcho.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGUOcho.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGUOcho.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGUOcho.FillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnGUOcho.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGUOcho.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnGUOcho.Location = New System.Drawing.Point(112, 780)
        Me.btnGUOcho.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGUOcho.Name = "btnGUOcho"
        Me.btnGUOcho.ShadowDecoration.BorderRadius = 20
        Me.btnGUOcho.Size = New System.Drawing.Size(80, 64)
        Me.btnGUOcho.TabIndex = 19
        Me.btnGUOcho.Text = "8"
        '
        'btnGUSiete
        '
        Me.btnGUSiete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGUSiete.BackColor = System.Drawing.Color.Transparent
        Me.btnGUSiete.BorderRadius = 10
        Me.btnGUSiete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGUSiete.CustomizableEdges.BottomLeft = False
        Me.btnGUSiete.CustomizableEdges.BottomRight = False
        Me.btnGUSiete.CustomizableEdges.TopLeft = False
        Me.btnGUSiete.CustomizableEdges.TopRight = False
        Me.btnGUSiete.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGUSiete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGUSiete.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGUSiete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGUSiete.FillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnGUSiete.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGUSiete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnGUSiete.Location = New System.Drawing.Point(28, 780)
        Me.btnGUSiete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGUSiete.Name = "btnGUSiete"
        Me.btnGUSiete.ShadowDecoration.BorderRadius = 20
        Me.btnGUSiete.Size = New System.Drawing.Size(80, 64)
        Me.btnGUSiete.TabIndex = 18
        Me.btnGUSiete.Text = "7"
        '
        'btnGUCorregir
        '
        Me.btnGUCorregir.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGUCorregir.BackColor = System.Drawing.Color.Transparent
        Me.btnGUCorregir.BorderRadius = 10
        Me.btnGUCorregir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGUCorregir.CustomizableEdges.BottomLeft = False
        Me.btnGUCorregir.CustomizableEdges.TopLeft = False
        Me.btnGUCorregir.CustomizableEdges.TopRight = False
        Me.btnGUCorregir.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGUCorregir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGUCorregir.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGUCorregir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGUCorregir.FillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnGUCorregir.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGUCorregir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnGUCorregir.Location = New System.Drawing.Point(196, 848)
        Me.btnGUCorregir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGUCorregir.Name = "btnGUCorregir"
        Me.btnGUCorregir.ShadowDecoration.BorderRadius = 20
        Me.btnGUCorregir.Size = New System.Drawing.Size(80, 64)
        Me.btnGUCorregir.TabIndex = 23
        Me.btnGUCorregir.Text = "C"
        '
        'btnGUCero
        '
        Me.btnGUCero.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGUCero.BackColor = System.Drawing.Color.Transparent
        Me.btnGUCero.BorderRadius = 10
        Me.btnGUCero.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGUCero.CustomizableEdges.BottomLeft = False
        Me.btnGUCero.CustomizableEdges.BottomRight = False
        Me.btnGUCero.CustomizableEdges.TopLeft = False
        Me.btnGUCero.CustomizableEdges.TopRight = False
        Me.btnGUCero.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGUCero.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGUCero.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGUCero.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGUCero.FillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnGUCero.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGUCero.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnGUCero.Location = New System.Drawing.Point(112, 848)
        Me.btnGUCero.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGUCero.Name = "btnGUCero"
        Me.btnGUCero.ShadowDecoration.BorderRadius = 20
        Me.btnGUCero.Size = New System.Drawing.Size(80, 64)
        Me.btnGUCero.TabIndex = 22
        Me.btnGUCero.Text = "0"
        '
        'btnGUOk
        '
        Me.btnGUOk.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGUOk.BackColor = System.Drawing.Color.Transparent
        Me.btnGUOk.BorderRadius = 10
        Me.btnGUOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGUOk.CustomizableEdges.BottomRight = False
        Me.btnGUOk.CustomizableEdges.TopLeft = False
        Me.btnGUOk.CustomizableEdges.TopRight = False
        Me.btnGUOk.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGUOk.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGUOk.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGUOk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGUOk.FillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnGUOk.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGUOk.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnGUOk.Location = New System.Drawing.Point(28, 848)
        Me.btnGUOk.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGUOk.Name = "btnGUOk"
        Me.btnGUOk.ShadowDecoration.BorderRadius = 20
        Me.btnGUOk.Size = New System.Drawing.Size(80, 64)
        Me.btnGUOk.TabIndex = 21
        Me.btnGUOk.Text = "OK"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Guna2Panel1.BorderRadius = 10
        Me.Guna2Panel1.BorderThickness = 12
        Me.Guna2Panel1.Controls.Add(Me.tbPrecioTotal)
        Me.Guna2Panel1.Controls.Add(Me.tbArticulo)
        Me.Guna2Panel1.Controls.Add(Me.tbUnidades)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2Panel1.Location = New System.Drawing.Point(28, 510)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(518, 114)
        Me.Guna2Panel1.TabIndex = 25
        '
        'tbPrecioTotal
        '
        Me.tbPrecioTotal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbPrecioTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.tbPrecioTotal.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.tbPrecioTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.tbPrecioTotal.Location = New System.Drawing.Point(366, 53)
        Me.tbPrecioTotal.MaxLength = 50
        Me.tbPrecioTotal.Name = "tbPrecioTotal"
        Me.tbPrecioTotal.ReadOnly = True
        Me.tbPrecioTotal.Size = New System.Drawing.Size(117, 34)
        Me.tbPrecioTotal.TabIndex = 13
        Me.tbPrecioTotal.Text = "tbPrecioTotal"
        '
        'tbArticulo
        '
        Me.tbArticulo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbArticulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.tbArticulo.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.tbArticulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.tbArticulo.Location = New System.Drawing.Point(169, 53)
        Me.tbArticulo.MaxLength = 50
        Me.tbArticulo.Name = "tbArticulo"
        Me.tbArticulo.ReadOnly = True
        Me.tbArticulo.Size = New System.Drawing.Size(176, 34)
        Me.tbArticulo.TabIndex = 12
        Me.tbArticulo.Text = "tbArticulo"
        '
        'tbUnidades
        '
        Me.tbUnidades.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tbUnidades.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.tbUnidades.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.tbUnidades.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.tbUnidades.Location = New System.Drawing.Point(32, 53)
        Me.tbUnidades.MaxLength = 50
        Me.tbUnidades.Name = "tbUnidades"
        Me.tbUnidades.ReadOnly = True
        Me.tbUnidades.Size = New System.Drawing.Size(117, 34)
        Me.tbUnidades.TabIndex = 11
        Me.tbUnidades.Text = "tbUnidades"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(366, 26)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(116, 23)
        Me.Guna2HtmlLabel3.TabIndex = 10
        Me.Guna2HtmlLabel3.Text = "PRECIO TOTAL:"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(169, 27)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(84, 23)
        Me.Guna2HtmlLabel2.TabIndex = 9
        Me.Guna2HtmlLabel2.Text = "ARTICULO:"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(32, 27)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(90, 23)
        Me.Guna2HtmlLabel1.TabIndex = 8
        Me.Guna2HtmlLabel1.Text = "UNIDADES:"
        '
        'btnEditarComanda
        '
        Me.btnEditarComanda.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEditarComanda.BackColor = System.Drawing.Color.Transparent
        Me.btnEditarComanda.BorderRadius = 10
        Me.btnEditarComanda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditarComanda.CustomizableEdges.BottomLeft = False
        Me.btnEditarComanda.CustomizableEdges.BottomRight = False
        Me.btnEditarComanda.CustomizableEdges.TopLeft = False
        Me.btnEditarComanda.CustomizableEdges.TopRight = False
        Me.btnEditarComanda.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEditarComanda.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEditarComanda.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEditarComanda.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEditarComanda.FillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnEditarComanda.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnEditarComanda.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnEditarComanda.Location = New System.Drawing.Point(569, 358)
        Me.btnEditarComanda.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEditarComanda.Name = "btnEditarComanda"
        Me.btnEditarComanda.ShadowDecoration.BorderRadius = 20
        Me.btnEditarComanda.Size = New System.Drawing.Size(97, 80)
        Me.btnEditarComanda.TabIndex = 29
        Me.btnEditarComanda.Text = "Editar Comanda"
        '
        'btnUltimaComanda
        '
        Me.btnUltimaComanda.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnUltimaComanda.BackColor = System.Drawing.Color.Transparent
        Me.btnUltimaComanda.BorderRadius = 10
        Me.btnUltimaComanda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUltimaComanda.CustomizableEdges.BottomLeft = False
        Me.btnUltimaComanda.CustomizableEdges.BottomRight = False
        Me.btnUltimaComanda.CustomizableEdges.TopLeft = False
        Me.btnUltimaComanda.CustomizableEdges.TopRight = False
        Me.btnUltimaComanda.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnUltimaComanda.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnUltimaComanda.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUltimaComanda.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnUltimaComanda.FillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnUltimaComanda.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnUltimaComanda.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnUltimaComanda.Location = New System.Drawing.Point(569, 274)
        Me.btnUltimaComanda.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUltimaComanda.Name = "btnUltimaComanda"
        Me.btnUltimaComanda.ShadowDecoration.BorderRadius = 20
        Me.btnUltimaComanda.Size = New System.Drawing.Size(97, 80)
        Me.btnUltimaComanda.TabIndex = 28
        Me.btnUltimaComanda.Text = "Ultima Comanda"
        '
        'btnBorrarComanda
        '
        Me.btnBorrarComanda.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBorrarComanda.BackColor = System.Drawing.Color.Transparent
        Me.btnBorrarComanda.BorderRadius = 10
        Me.btnBorrarComanda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrarComanda.CustomizableEdges.BottomLeft = False
        Me.btnBorrarComanda.CustomizableEdges.BottomRight = False
        Me.btnBorrarComanda.CustomizableEdges.TopLeft = False
        Me.btnBorrarComanda.CustomizableEdges.TopRight = False
        Me.btnBorrarComanda.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnBorrarComanda.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnBorrarComanda.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBorrarComanda.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnBorrarComanda.FillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnBorrarComanda.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnBorrarComanda.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnBorrarComanda.Location = New System.Drawing.Point(569, 190)
        Me.btnBorrarComanda.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBorrarComanda.Name = "btnBorrarComanda"
        Me.btnBorrarComanda.ShadowDecoration.BorderRadius = 20
        Me.btnBorrarComanda.Size = New System.Drawing.Size(97, 80)
        Me.btnBorrarComanda.TabIndex = 27
        Me.btnBorrarComanda.Text = "Borrar Comanda"
        '
        'btnMesas
        '
        Me.btnMesas.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnMesas.BackColor = System.Drawing.Color.Transparent
        Me.btnMesas.BorderRadius = 10
        Me.btnMesas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMesas.CustomizableEdges.BottomLeft = False
        Me.btnMesas.CustomizableEdges.BottomRight = False
        Me.btnMesas.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnMesas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnMesas.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnMesas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnMesas.FillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnMesas.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnMesas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnMesas.Location = New System.Drawing.Point(569, 106)
        Me.btnMesas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMesas.Name = "btnMesas"
        Me.btnMesas.ShadowDecoration.BorderRadius = 20
        Me.btnMesas.Size = New System.Drawing.Size(97, 80)
        Me.btnMesas.TabIndex = 26
        Me.btnMesas.Text = "Mesas"
        '
        'btnGestionArticulos
        '
        Me.btnGestionArticulos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGestionArticulos.BackColor = System.Drawing.Color.Transparent
        Me.btnGestionArticulos.BorderRadius = 10
        Me.btnGestionArticulos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGestionArticulos.CustomizableEdges.TopLeft = False
        Me.btnGestionArticulos.CustomizableEdges.TopRight = False
        Me.btnGestionArticulos.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGestionArticulos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGestionArticulos.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGestionArticulos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGestionArticulos.FillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnGestionArticulos.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGestionArticulos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnGestionArticulos.Location = New System.Drawing.Point(569, 664)
        Me.btnGestionArticulos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGestionArticulos.Name = "btnGestionArticulos"
        Me.btnGestionArticulos.ShadowDecoration.BorderRadius = 20
        Me.btnGestionArticulos.Size = New System.Drawing.Size(97, 80)
        Me.btnGestionArticulos.TabIndex = 32
        Me.btnGestionArticulos.Text = "Gestion Articulos"
        '
        'btnGestionEmpleados
        '
        Me.btnGestionEmpleados.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGestionEmpleados.BackColor = System.Drawing.Color.Transparent
        Me.btnGestionEmpleados.BorderRadius = 10
        Me.btnGestionEmpleados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGestionEmpleados.CustomizableEdges.BottomLeft = False
        Me.btnGestionEmpleados.CustomizableEdges.BottomRight = False
        Me.btnGestionEmpleados.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGestionEmpleados.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGestionEmpleados.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGestionEmpleados.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGestionEmpleados.FillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnGestionEmpleados.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGestionEmpleados.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnGestionEmpleados.Location = New System.Drawing.Point(569, 580)
        Me.btnGestionEmpleados.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGestionEmpleados.Name = "btnGestionEmpleados"
        Me.btnGestionEmpleados.ShadowDecoration.BorderRadius = 20
        Me.btnGestionEmpleados.Size = New System.Drawing.Size(97, 80)
        Me.btnGestionEmpleados.TabIndex = 33
        Me.btnGestionEmpleados.Text = "Gestión Empleados"
        '
        'tbTotalAPagar
        '
        Me.tbTotalAPagar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbTotalAPagar.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.tbTotalAPagar.Font = New System.Drawing.Font("Segoe UI", 19.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.tbTotalAPagar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.tbTotalAPagar.Location = New System.Drawing.Point(297, 677)
        Me.tbTotalAPagar.MaxLength = 50
        Me.tbTotalAPagar.Name = "tbTotalAPagar"
        Me.tbTotalAPagar.ReadOnly = True
        Me.tbTotalAPagar.Size = New System.Drawing.Size(249, 41)
        Me.tbTotalAPagar.TabIndex = 15
        Me.tbTotalAPagar.Text = "tbTotalAPagar"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(297, 639)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(174, 32)
        Me.Guna2HtmlLabel4.TabIndex = 14
        Me.Guna2HtmlLabel4.Text = "TOTAL A PAGAR:"
        '
        'tbMesaSeleccionada
        '
        Me.tbMesaSeleccionada.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbMesaSeleccionada.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.tbMesaSeleccionada.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.tbMesaSeleccionada.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.tbMesaSeleccionada.Location = New System.Drawing.Point(282, 458)
        Me.tbMesaSeleccionada.MaxLength = 50
        Me.tbMesaSeleccionada.Name = "tbMesaSeleccionada"
        Me.tbMesaSeleccionada.ReadOnly = True
        Me.tbMesaSeleccionada.Size = New System.Drawing.Size(249, 34)
        Me.tbMesaSeleccionada.TabIndex = 35
        Me.tbMesaSeleccionada.Text = "tbMesaSeleccionada"
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(47, 458)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(229, 32)
        Me.Guna2HtmlLabel5.TabIndex = 34
        Me.Guna2HtmlLabel5.Text = "MESA SELECCIONADA:"
        '
        'timerHoraActual
        '
        Me.timerHoraActual.Enabled = True
        '
        'btnGUProductoDemo
        '
        Me.btnGUProductoDemo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGUProductoDemo.BackColor = System.Drawing.Color.Transparent
        Me.btnGUProductoDemo.BorderRadius = 10
        Me.btnGUProductoDemo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGUProductoDemo.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGUProductoDemo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGUProductoDemo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGUProductoDemo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGUProductoDemo.FillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnGUProductoDemo.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGUProductoDemo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnGUProductoDemo.Location = New System.Drawing.Point(923, 467)
        Me.btnGUProductoDemo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGUProductoDemo.Name = "btnGUProductoDemo"
        Me.btnGUProductoDemo.ShadowDecoration.BorderRadius = 20
        Me.btnGUProductoDemo.Size = New System.Drawing.Size(186, 193)
        Me.btnGUProductoDemo.TabIndex = 36
        Me.btnGUProductoDemo.Text = "Producto Demo"
        '
        'frmPaginaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1295, 1007)
        Me.Controls.Add(Me.btnGUProductoDemo)
        Me.Controls.Add(Me.tbMesaSeleccionada)
        Me.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Controls.Add(Me.tbTotalAPagar)
        Me.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Controls.Add(Me.btnGestionEmpleados)
        Me.Controls.Add(Me.btnGestionArticulos)
        Me.Controls.Add(btnBorrarProducto)
        Me.Controls.Add(Me.btnEditarComanda)
        Me.Controls.Add(Me.btnUltimaComanda)
        Me.Controls.Add(Me.btnBorrarComanda)
        Me.Controls.Add(Me.btnMesas)
        Me.Controls.Add(Me.btnGUCorregir)
        Me.Controls.Add(Me.btnGUCero)
        Me.Controls.Add(Me.btnGUOk)
        Me.Controls.Add(Me.btnGUNueve)
        Me.Controls.Add(Me.btnGUOcho)
        Me.Controls.Add(Me.btnGUSiete)
        Me.Controls.Add(Me.btnGUSeis)
        Me.Controls.Add(Me.btnGUCinco)
        Me.Controls.Add(Me.btnGUCuatro)
        Me.Controls.Add(Me.btnGUTres)
        Me.Controls.Add(Me.btnGUDos)
        Me.Controls.Add(Me.btnGUUno)
        Me.Controls.Add(Me.dgvComandas)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnGUApagar)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPaginaPrincipal"
        Me.Text = "frmPaginaPrincipal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvComandas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGUApagar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblGUHora As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblGUFecha As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblGUCajaActual As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblGUEmpleado As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblGUInfoHora As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblGUInfoFecha As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblGUInfoCajaActual As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblGUInfoEmpleado As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents dgvComandas As DataGridView
    Friend WithEvents btnGUUno As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnGUDos As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnGUTres As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnGUSeis As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnGUCinco As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnGUCuatro As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnGUNueve As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnGUOcho As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnGUSiete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnGUCorregir As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnGUCero As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnGUOk As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents tbPrecioTotal As TextBox
    Friend WithEvents tbArticulo As TextBox
    Friend WithEvents tbUnidades As TextBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnEditarComanda As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnUltimaComanda As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnBorrarComanda As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnMesas As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnGestionArticulos As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnGestionEmpleados As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents tbTotalAPagar As TextBox
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents tbMesaSeleccionada As TextBox
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents timerHoraActual As Timer
    Friend WithEvents btnGUProductoDemo As Guna.UI2.WinForms.Guna2Button
End Class
