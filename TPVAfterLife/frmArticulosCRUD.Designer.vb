<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArticulosCRUD
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmArticulosCRUD))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblGUSeleccionMesa = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pbGULogo = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btnGUSalir = New Guna.UI2.WinForms.Guna2Button()
        Me.btnGUAniadir = New Guna.UI2.WinForms.Guna2Button()
        Me.btnGUBorrar = New Guna.UI2.WinForms.Guna2Button()
        Me.btnGUModificar = New Guna.UI2.WinForms.Guna2Button()
        Me.pbGUProducto = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.dgvArticulos = New System.Windows.Forms.DataGridView()
        Me.lblGUNombre = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.lblGUPrecio = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.tbPrecio = New System.Windows.Forms.TextBox()
        Me.tbStock = New System.Windows.Forms.TextBox()
        Me.lblGUStock = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblGUCategoria = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cbGUCategoriasNombre = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cbGUCategoriasID = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.tbIdArticulo = New System.Windows.Forms.TextBox()
        Me.btnGUAniadirImagen = New Guna.UI2.WinForms.Guna2Button()
        Me.pbGUImagenAux = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btnGUEliminarIMG = New Guna.UI2.WinForms.Guna2Button()
        Me.lblGUImagen = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Panel1.SuspendLayout()
        CType(Me.pbGULogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbGUProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbGUImagenAux, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblGUSeleccionMesa)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1190, 86)
        Me.Panel1.TabIndex = 37
        '
        'lblGUSeleccionMesa
        '
        Me.lblGUSeleccionMesa.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblGUSeleccionMesa.BackColor = System.Drawing.Color.Transparent
        Me.lblGUSeleccionMesa.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblGUSeleccionMesa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.lblGUSeleccionMesa.Location = New System.Drawing.Point(415, 22)
        Me.lblGUSeleccionMesa.Name = "lblGUSeleccionMesa"
        Me.lblGUSeleccionMesa.Size = New System.Drawing.Size(384, 42)
        Me.lblGUSeleccionMesa.TabIndex = 5
        Me.lblGUSeleccionMesa.Text = "Administración de Articulos"
        '
        'pbGULogo
        '
        Me.pbGULogo.Image = Global.TPVAfterLife.My.Resources.Resources.LogoIcono_color_cremita_
        Me.pbGULogo.ImageRotate = 0!
        Me.pbGULogo.Location = New System.Drawing.Point(68, 546)
        Me.pbGULogo.Name = "pbGULogo"
        Me.pbGULogo.Size = New System.Drawing.Size(215, 205)
        Me.pbGULogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbGULogo.TabIndex = 39
        Me.pbGULogo.TabStop = False
        '
        'btnGUSalir
        '
        Me.btnGUSalir.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGUSalir.BackColor = System.Drawing.Color.Transparent
        Me.btnGUSalir.BorderRadius = 10
        Me.btnGUSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGUSalir.CustomizableEdges.BottomLeft = False
        Me.btnGUSalir.CustomizableEdges.TopLeft = False
        Me.btnGUSalir.CustomizableEdges.TopRight = False
        Me.btnGUSalir.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGUSalir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGUSalir.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGUSalir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGUSalir.FillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnGUSalir.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGUSalir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnGUSalir.Location = New System.Drawing.Point(930, 710)
        Me.btnGUSalir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGUSalir.Name = "btnGUSalir"
        Me.btnGUSalir.ShadowDecoration.BorderRadius = 20
        Me.btnGUSalir.Size = New System.Drawing.Size(204, 82)
        Me.btnGUSalir.TabIndex = 43
        Me.btnGUSalir.Text = "Salir"
        '
        'btnGUAniadir
        '
        Me.btnGUAniadir.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGUAniadir.BackColor = System.Drawing.Color.Transparent
        Me.btnGUAniadir.BorderRadius = 10
        Me.btnGUAniadir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGUAniadir.CustomizableEdges.BottomRight = False
        Me.btnGUAniadir.CustomizableEdges.TopLeft = False
        Me.btnGUAniadir.CustomizableEdges.TopRight = False
        Me.btnGUAniadir.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGUAniadir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGUAniadir.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGUAniadir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGUAniadir.FillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnGUAniadir.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGUAniadir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnGUAniadir.Location = New System.Drawing.Point(720, 710)
        Me.btnGUAniadir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGUAniadir.Name = "btnGUAniadir"
        Me.btnGUAniadir.ShadowDecoration.BorderRadius = 20
        Me.btnGUAniadir.Size = New System.Drawing.Size(204, 82)
        Me.btnGUAniadir.TabIndex = 42
        Me.btnGUAniadir.Text = "Añadir"
        '
        'btnGUBorrar
        '
        Me.btnGUBorrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGUBorrar.BackColor = System.Drawing.Color.Transparent
        Me.btnGUBorrar.BorderRadius = 10
        Me.btnGUBorrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGUBorrar.CustomizableEdges.BottomLeft = False
        Me.btnGUBorrar.CustomizableEdges.BottomRight = False
        Me.btnGUBorrar.CustomizableEdges.TopLeft = False
        Me.btnGUBorrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGUBorrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGUBorrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGUBorrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGUBorrar.FillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnGUBorrar.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGUBorrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnGUBorrar.Location = New System.Drawing.Point(930, 624)
        Me.btnGUBorrar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGUBorrar.Name = "btnGUBorrar"
        Me.btnGUBorrar.ShadowDecoration.BorderRadius = 20
        Me.btnGUBorrar.Size = New System.Drawing.Size(204, 82)
        Me.btnGUBorrar.TabIndex = 41
        Me.btnGUBorrar.Text = "Borrar"
        '
        'btnGUModificar
        '
        Me.btnGUModificar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGUModificar.BackColor = System.Drawing.Color.Transparent
        Me.btnGUModificar.BorderRadius = 10
        Me.btnGUModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGUModificar.CustomizableEdges.BottomLeft = False
        Me.btnGUModificar.CustomizableEdges.BottomRight = False
        Me.btnGUModificar.CustomizableEdges.TopRight = False
        Me.btnGUModificar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGUModificar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGUModificar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGUModificar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGUModificar.FillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnGUModificar.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGUModificar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnGUModificar.Location = New System.Drawing.Point(720, 624)
        Me.btnGUModificar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGUModificar.Name = "btnGUModificar"
        Me.btnGUModificar.ShadowDecoration.BorderRadius = 20
        Me.btnGUModificar.Size = New System.Drawing.Size(204, 82)
        Me.btnGUModificar.TabIndex = 40
        Me.btnGUModificar.Text = "Modificar"
        '
        'pbGUProducto
        '
        Me.pbGUProducto.FillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.pbGUProducto.Image = Global.TPVAfterLife.My.Resources.Resources.NotFoundIMG1
        Me.pbGUProducto.ImageRotate = 0!
        Me.pbGUProducto.Location = New System.Drawing.Point(337, 543)
        Me.pbGUProducto.Name = "pbGUProducto"
        Me.pbGUProducto.Size = New System.Drawing.Size(279, 249)
        Me.pbGUProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbGUProducto.TabIndex = 44
        Me.pbGUProducto.TabStop = False
        '
        'dgvArticulos
        '
        Me.dgvArticulos.AllowUserToAddRows = False
        Me.dgvArticulos.AllowUserToDeleteRows = False
        Me.dgvArticulos.AllowUserToResizeColumns = False
        Me.dgvArticulos.AllowUserToResizeRows = False
        Me.dgvArticulos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvArticulos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvArticulos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.dgvArticulos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvArticulos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvArticulos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvArticulos.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvArticulos.Location = New System.Drawing.Point(44, 128)
        Me.dgvArticulos.MultiSelect = False
        Me.dgvArticulos.Name = "dgvArticulos"
        Me.dgvArticulos.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvArticulos.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvArticulos.RowTemplate.Height = 25
        Me.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvArticulos.Size = New System.Drawing.Size(610, 372)
        Me.dgvArticulos.TabIndex = 45
        '
        'lblGUNombre
        '
        Me.lblGUNombre.BackColor = System.Drawing.Color.Transparent
        Me.lblGUNombre.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGUNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.lblGUNombre.Location = New System.Drawing.Point(721, 128)
        Me.lblGUNombre.Name = "lblGUNombre"
        Me.lblGUNombre.Size = New System.Drawing.Size(80, 30)
        Me.lblGUNombre.TabIndex = 46
        Me.lblGUNombre.Text = "Nombre:"
        '
        'tbNombre
        '
        Me.tbNombre.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.tbNombre.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tbNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.tbNombre.Location = New System.Drawing.Point(721, 163)
        Me.tbNombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbNombre.MaxLength = 50
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.PlaceholderText = "Introduzca el nombre"
        Me.tbNombre.Size = New System.Drawing.Size(414, 39)
        Me.tbNombre.TabIndex = 47
        '
        'lblGUPrecio
        '
        Me.lblGUPrecio.BackColor = System.Drawing.Color.Transparent
        Me.lblGUPrecio.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGUPrecio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.lblGUPrecio.Location = New System.Drawing.Point(721, 217)
        Me.lblGUPrecio.Name = "lblGUPrecio"
        Me.lblGUPrecio.Size = New System.Drawing.Size(61, 30)
        Me.lblGUPrecio.TabIndex = 48
        Me.lblGUPrecio.Text = "Precio:"
        '
        'tbPrecio
        '
        Me.tbPrecio.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbPrecio.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.tbPrecio.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tbPrecio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.tbPrecio.Location = New System.Drawing.Point(721, 252)
        Me.tbPrecio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbPrecio.MaxLength = 20
        Me.tbPrecio.Name = "tbPrecio"
        Me.tbPrecio.PlaceholderText = "Introduzca el precio"
        Me.tbPrecio.Size = New System.Drawing.Size(414, 39)
        Me.tbPrecio.TabIndex = 49
        '
        'tbStock
        '
        Me.tbStock.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbStock.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.tbStock.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tbStock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.tbStock.Location = New System.Drawing.Point(721, 341)
        Me.tbStock.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbStock.MaxLength = 20
        Me.tbStock.Name = "tbStock"
        Me.tbStock.PlaceholderText = "Introduzca el stock"
        Me.tbStock.Size = New System.Drawing.Size(414, 39)
        Me.tbStock.TabIndex = 51
        '
        'lblGUStock
        '
        Me.lblGUStock.BackColor = System.Drawing.Color.Transparent
        Me.lblGUStock.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGUStock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.lblGUStock.Location = New System.Drawing.Point(719, 306)
        Me.lblGUStock.Name = "lblGUStock"
        Me.lblGUStock.Size = New System.Drawing.Size(56, 30)
        Me.lblGUStock.TabIndex = 50
        Me.lblGUStock.Text = "Stock:"
        Me.lblGUStock.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGUCategoria
        '
        Me.lblGUCategoria.BackColor = System.Drawing.Color.Transparent
        Me.lblGUCategoria.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGUCategoria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.lblGUCategoria.Location = New System.Drawing.Point(721, 395)
        Me.lblGUCategoria.Name = "lblGUCategoria"
        Me.lblGUCategoria.Size = New System.Drawing.Size(92, 30)
        Me.lblGUCategoria.TabIndex = 54
        Me.lblGUCategoria.Text = "Categoria:"
        Me.lblGUCategoria.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbGUCategoriasNombre
        '
        Me.cbGUCategoriasNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.cbGUCategoriasNombre.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbGUCategoriasNombre.DropDownHeight = 220
        Me.cbGUCategoriasNombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGUCategoriasNombre.FillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.cbGUCategoriasNombre.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbGUCategoriasNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbGUCategoriasNombre.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cbGUCategoriasNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.cbGUCategoriasNombre.IntegralHeight = False
        Me.cbGUCategoriasNombre.ItemHeight = 30
        Me.cbGUCategoriasNombre.Location = New System.Drawing.Point(721, 430)
        Me.cbGUCategoriasNombre.Name = "cbGUCategoriasNombre"
        Me.cbGUCategoriasNombre.Size = New System.Drawing.Size(413, 36)
        Me.cbGUCategoriasNombre.TabIndex = 55
        '
        'cbGUCategoriasID
        '
        Me.cbGUCategoriasID.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.cbGUCategoriasID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbGUCategoriasID.DropDownHeight = 220
        Me.cbGUCategoriasID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGUCategoriasID.FillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.cbGUCategoriasID.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbGUCategoriasID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbGUCategoriasID.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cbGUCategoriasID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.cbGUCategoriasID.IntegralHeight = False
        Me.cbGUCategoriasID.ItemHeight = 30
        Me.cbGUCategoriasID.Location = New System.Drawing.Point(721, 430)
        Me.cbGUCategoriasID.Name = "cbGUCategoriasID"
        Me.cbGUCategoriasID.Size = New System.Drawing.Size(413, 36)
        Me.cbGUCategoriasID.TabIndex = 56
        Me.cbGUCategoriasID.Visible = False
        '
        'tbIdArticulo
        '
        Me.tbIdArticulo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbIdArticulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.tbIdArticulo.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tbIdArticulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.tbIdArticulo.Location = New System.Drawing.Point(720, 91)
        Me.tbIdArticulo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbIdArticulo.MaxLength = 50
        Me.tbIdArticulo.Name = "tbIdArticulo"
        Me.tbIdArticulo.PlaceholderText = "Introduzca el Id"
        Me.tbIdArticulo.Size = New System.Drawing.Size(414, 39)
        Me.tbIdArticulo.TabIndex = 57
        Me.tbIdArticulo.Visible = False
        '
        'btnGUAniadirImagen
        '
        Me.btnGUAniadirImagen.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGUAniadirImagen.BackColor = System.Drawing.Color.Transparent
        Me.btnGUAniadirImagen.BorderRadius = 10
        Me.btnGUAniadirImagen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGUAniadirImagen.CustomizableEdges.BottomRight = False
        Me.btnGUAniadirImagen.CustomizableEdges.TopRight = False
        Me.btnGUAniadirImagen.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGUAniadirImagen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGUAniadirImagen.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGUAniadirImagen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGUAniadirImagen.FillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnGUAniadirImagen.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGUAniadirImagen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnGUAniadirImagen.Location = New System.Drawing.Point(720, 519)
        Me.btnGUAniadirImagen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGUAniadirImagen.Name = "btnGUAniadirImagen"
        Me.btnGUAniadirImagen.ShadowDecoration.BorderRadius = 20
        Me.btnGUAniadirImagen.Size = New System.Drawing.Size(359, 46)
        Me.btnGUAniadirImagen.TabIndex = 58
        Me.btnGUAniadirImagen.Text = "Añadir imagen"
        '
        'pbGUImagenAux
        '
        Me.pbGUImagenAux.ImageRotate = 0!
        Me.pbGUImagenAux.Location = New System.Drawing.Point(206, 773)
        Me.pbGUImagenAux.Name = "pbGUImagenAux"
        Me.pbGUImagenAux.Size = New System.Drawing.Size(188, 50)
        Me.pbGUImagenAux.TabIndex = 59
        Me.pbGUImagenAux.TabStop = False
        Me.pbGUImagenAux.Visible = False
        '
        'btnGUEliminarIMG
        '
        Me.btnGUEliminarIMG.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGUEliminarIMG.BackColor = System.Drawing.Color.Transparent
        Me.btnGUEliminarIMG.BorderRadius = 10
        Me.btnGUEliminarIMG.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGUEliminarIMG.CustomizableEdges.BottomLeft = False
        Me.btnGUEliminarIMG.CustomizableEdges.TopLeft = False
        Me.btnGUEliminarIMG.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGUEliminarIMG.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGUEliminarIMG.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGUEliminarIMG.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGUEliminarIMG.Enabled = False
        Me.btnGUEliminarIMG.FillColor = System.Drawing.Color.OrangeRed
        Me.btnGUEliminarIMG.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGUEliminarIMG.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnGUEliminarIMG.Location = New System.Drawing.Point(1085, 519)
        Me.btnGUEliminarIMG.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGUEliminarIMG.Name = "btnGUEliminarIMG"
        Me.btnGUEliminarIMG.ShadowDecoration.BorderRadius = 20
        Me.btnGUEliminarIMG.Size = New System.Drawing.Size(49, 46)
        Me.btnGUEliminarIMG.TabIndex = 60
        Me.btnGUEliminarIMG.Text = "X"
        '
        'lblGUImagen
        '
        Me.lblGUImagen.BackColor = System.Drawing.Color.Transparent
        Me.lblGUImagen.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGUImagen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.lblGUImagen.Location = New System.Drawing.Point(721, 484)
        Me.lblGUImagen.Name = "lblGUImagen"
        Me.lblGUImagen.Size = New System.Drawing.Size(72, 30)
        Me.lblGUImagen.TabIndex = 61
        Me.lblGUImagen.Text = "Imagen:"
        Me.lblGUImagen.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmArticulosCRUD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1185, 835)
        Me.Controls.Add(Me.lblGUImagen)
        Me.Controls.Add(Me.btnGUEliminarIMG)
        Me.Controls.Add(Me.pbGUImagenAux)
        Me.Controls.Add(Me.btnGUAniadirImagen)
        Me.Controls.Add(Me.tbIdArticulo)
        Me.Controls.Add(Me.cbGUCategoriasID)
        Me.Controls.Add(Me.cbGUCategoriasNombre)
        Me.Controls.Add(Me.lblGUCategoria)
        Me.Controls.Add(Me.tbStock)
        Me.Controls.Add(Me.lblGUStock)
        Me.Controls.Add(Me.tbPrecio)
        Me.Controls.Add(Me.lblGUPrecio)
        Me.Controls.Add(Me.tbNombre)
        Me.Controls.Add(Me.lblGUNombre)
        Me.Controls.Add(Me.dgvArticulos)
        Me.Controls.Add(Me.pbGUProducto)
        Me.Controls.Add(Me.btnGUSalir)
        Me.Controls.Add(Me.btnGUAniadir)
        Me.Controls.Add(Me.btnGUBorrar)
        Me.Controls.Add(Me.btnGUModificar)
        Me.Controls.Add(Me.pbGULogo)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmArticulosCRUD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TPV Bar AfterLife"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbGULogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbGUProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbGUImagenAux, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblGUSeleccionMesa As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pbGULogo As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnGUSalir As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnGUAniadir As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnGUBorrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnGUModificar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pbGUProducto As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents dgvArticulos As DataGridView
    Friend WithEvents lblGUNombre As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents lblGUPrecio As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents tbPrecio As TextBox
    Friend WithEvents tbStock As TextBox
    Friend WithEvents lblGUStock As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblGUCategoria As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cbGUCategoriasNombre As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cbGUCategoriasID As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents tbIdArticulo As TextBox
    Friend WithEvents btnGUAniadirImagen As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pbGUImagenAux As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnGUEliminarIMG As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblGUImagen As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
