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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGUApagar
        '
        Me.btnGUApagar.Anchor = System.Windows.Forms.AnchorStyles.Right
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
        Me.Guna2Button1.Anchor = System.Windows.Forms.AnchorStyles.Right
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
        Me.Guna2Button1.Location = New System.Drawing.Point(297, 580)
        Me.Guna2Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.BorderRadius = 20
        Me.Guna2Button1.Size = New System.Drawing.Size(249, 332)
        Me.Guna2Button1.TabIndex = 9
        Me.Guna2Button1.Text = "Cobrar"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Guna2PictureBox1.Image = Global.TPVAfterLife.My.Resources.Resources.LogoLetrero_color_cremita_
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(21, -32)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(301, 177)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 10
        Me.Guna2PictureBox1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(28, 114)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(518, 277)
        Me.DataGridView1.TabIndex = 11
        '
        'btnGUUno
        '
        Me.btnGUUno.Anchor = System.Windows.Forms.AnchorStyles.Right
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
        Me.btnGUUno.Location = New System.Drawing.Point(28, 580)
        Me.btnGUUno.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGUUno.Name = "btnGUUno"
        Me.btnGUUno.ShadowDecoration.BorderRadius = 20
        Me.btnGUUno.Size = New System.Drawing.Size(80, 80)
        Me.btnGUUno.TabIndex = 12
        Me.btnGUUno.Text = "1"
        '
        'btnGUDos
        '
        Me.btnGUDos.Anchor = System.Windows.Forms.AnchorStyles.Right
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
        Me.btnGUDos.Location = New System.Drawing.Point(112, 580)
        Me.btnGUDos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGUDos.Name = "btnGUDos"
        Me.btnGUDos.ShadowDecoration.BorderRadius = 20
        Me.btnGUDos.Size = New System.Drawing.Size(80, 80)
        Me.btnGUDos.TabIndex = 13
        Me.btnGUDos.Text = "2"
        '
        'btnGUTres
        '
        Me.btnGUTres.Anchor = System.Windows.Forms.AnchorStyles.Right
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
        Me.btnGUTres.Location = New System.Drawing.Point(197, 580)
        Me.btnGUTres.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGUTres.Name = "btnGUTres"
        Me.btnGUTres.ShadowDecoration.BorderRadius = 20
        Me.btnGUTres.Size = New System.Drawing.Size(80, 80)
        Me.btnGUTres.TabIndex = 14
        Me.btnGUTres.Text = "3"
        '
        'btnGUSeis
        '
        Me.btnGUSeis.Anchor = System.Windows.Forms.AnchorStyles.Right
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
        Me.btnGUSeis.Location = New System.Drawing.Point(196, 664)
        Me.btnGUSeis.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGUSeis.Name = "btnGUSeis"
        Me.btnGUSeis.ShadowDecoration.BorderRadius = 20
        Me.btnGUSeis.Size = New System.Drawing.Size(80, 80)
        Me.btnGUSeis.TabIndex = 17
        Me.btnGUSeis.Text = "6"
        '
        'btnGUCinco
        '
        Me.btnGUCinco.Anchor = System.Windows.Forms.AnchorStyles.Right
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
        Me.btnGUCinco.Location = New System.Drawing.Point(112, 664)
        Me.btnGUCinco.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGUCinco.Name = "btnGUCinco"
        Me.btnGUCinco.ShadowDecoration.BorderRadius = 20
        Me.btnGUCinco.Size = New System.Drawing.Size(80, 80)
        Me.btnGUCinco.TabIndex = 16
        Me.btnGUCinco.Text = "5"
        '
        'btnGUCuatro
        '
        Me.btnGUCuatro.Anchor = System.Windows.Forms.AnchorStyles.Right
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
        Me.btnGUCuatro.Location = New System.Drawing.Point(28, 664)
        Me.btnGUCuatro.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGUCuatro.Name = "btnGUCuatro"
        Me.btnGUCuatro.ShadowDecoration.BorderRadius = 20
        Me.btnGUCuatro.Size = New System.Drawing.Size(80, 80)
        Me.btnGUCuatro.TabIndex = 15
        Me.btnGUCuatro.Text = "4"
        '
        'btnGUNueve
        '
        Me.btnGUNueve.Anchor = System.Windows.Forms.AnchorStyles.Right
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
        Me.btnGUNueve.Location = New System.Drawing.Point(196, 748)
        Me.btnGUNueve.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGUNueve.Name = "btnGUNueve"
        Me.btnGUNueve.ShadowDecoration.BorderRadius = 20
        Me.btnGUNueve.Size = New System.Drawing.Size(80, 80)
        Me.btnGUNueve.TabIndex = 20
        Me.btnGUNueve.Text = "9"
        '
        'btnGUOcho
        '
        Me.btnGUOcho.Anchor = System.Windows.Forms.AnchorStyles.Right
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
        Me.btnGUOcho.Location = New System.Drawing.Point(112, 748)
        Me.btnGUOcho.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGUOcho.Name = "btnGUOcho"
        Me.btnGUOcho.ShadowDecoration.BorderRadius = 20
        Me.btnGUOcho.Size = New System.Drawing.Size(80, 80)
        Me.btnGUOcho.TabIndex = 19
        Me.btnGUOcho.Text = "8"
        '
        'btnGUSiete
        '
        Me.btnGUSiete.Anchor = System.Windows.Forms.AnchorStyles.Right
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
        Me.btnGUSiete.Location = New System.Drawing.Point(28, 748)
        Me.btnGUSiete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGUSiete.Name = "btnGUSiete"
        Me.btnGUSiete.ShadowDecoration.BorderRadius = 20
        Me.btnGUSiete.Size = New System.Drawing.Size(80, 80)
        Me.btnGUSiete.TabIndex = 18
        Me.btnGUSiete.Text = "7"
        '
        'btnGUCorregir
        '
        Me.btnGUCorregir.Anchor = System.Windows.Forms.AnchorStyles.Right
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
        Me.btnGUCorregir.Location = New System.Drawing.Point(196, 832)
        Me.btnGUCorregir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGUCorregir.Name = "btnGUCorregir"
        Me.btnGUCorregir.ShadowDecoration.BorderRadius = 20
        Me.btnGUCorregir.Size = New System.Drawing.Size(80, 80)
        Me.btnGUCorregir.TabIndex = 23
        Me.btnGUCorregir.Text = "C"
        '
        'btnGUCero
        '
        Me.btnGUCero.Anchor = System.Windows.Forms.AnchorStyles.Right
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
        Me.btnGUCero.Location = New System.Drawing.Point(112, 832)
        Me.btnGUCero.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGUCero.Name = "btnGUCero"
        Me.btnGUCero.ShadowDecoration.BorderRadius = 20
        Me.btnGUCero.Size = New System.Drawing.Size(80, 80)
        Me.btnGUCero.TabIndex = 22
        Me.btnGUCero.Text = "0"
        '
        'btnGUOk
        '
        Me.btnGUOk.Anchor = System.Windows.Forms.AnchorStyles.Right
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
        Me.btnGUOk.Location = New System.Drawing.Point(28, 832)
        Me.btnGUOk.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGUOk.Name = "btnGUOk"
        Me.btnGUOk.ShadowDecoration.BorderRadius = 20
        Me.btnGUOk.Size = New System.Drawing.Size(80, 80)
        Me.btnGUOk.TabIndex = 21
        Me.btnGUOk.Text = "OK"
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(28, 426)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(518, 116)
        Me.Panel2.TabIndex = 24
        '
        'frmPaginaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1295, 1007)
        Me.Controls.Add(Me.Panel2)
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
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnGUApagar)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPaginaPrincipal"
        Me.Text = "frmPaginaPrincipal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DataGridView1 As DataGridView
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
    Friend WithEvents Panel2 As Panel
End Class
