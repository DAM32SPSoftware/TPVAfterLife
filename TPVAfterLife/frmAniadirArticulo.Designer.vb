<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAniadirArticulo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAniadirArticulo))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblGUSeleccionMesa = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnGUCancelar = New Guna.UI2.WinForms.Guna2Button()
        Me.btnGUAniadir = New Guna.UI2.WinForms.Guna2Button()
        Me.cbGUCategoriasID = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cbGUCategoriasNombre = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblGUCategoria = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.tbStock = New System.Windows.Forms.TextBox()
        Me.lblGUStock = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.tbPrecio = New System.Windows.Forms.TextBox()
        Me.lblGUPrecio = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.lblGUNombre = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblGUImagen = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnGUEliminarIMG = New Guna.UI2.WinForms.Guna2Button()
        Me.btnGUAniadirImagen = New Guna.UI2.WinForms.Guna2Button()
        Me.pbGUImagenAux = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Panel1.SuspendLayout()
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
        Me.Panel1.Location = New System.Drawing.Point(-1, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(654, 86)
        Me.Panel1.TabIndex = 38
        Me.Panel1.TabStop = True
        '
        'lblGUSeleccionMesa
        '
        Me.lblGUSeleccionMesa.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblGUSeleccionMesa.BackColor = System.Drawing.Color.Transparent
        Me.lblGUSeleccionMesa.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblGUSeleccionMesa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.lblGUSeleccionMesa.Location = New System.Drawing.Point(230, 24)
        Me.lblGUSeleccionMesa.Name = "lblGUSeleccionMesa"
        Me.lblGUSeleccionMesa.Size = New System.Drawing.Size(212, 42)
        Me.lblGUSeleccionMesa.TabIndex = 5
        Me.lblGUSeleccionMesa.TabStop = False
        Me.lblGUSeleccionMesa.Text = "Añadir Articulo"
        '
        'btnGUCancelar
        '
        Me.btnGUCancelar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGUCancelar.BackColor = System.Drawing.Color.Transparent
        Me.btnGUCancelar.BorderRadius = 15
        Me.btnGUCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGUCancelar.CustomizableEdges.BottomRight = False
        Me.btnGUCancelar.CustomizableEdges.TopRight = False
        Me.btnGUCancelar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGUCancelar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGUCancelar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGUCancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGUCancelar.FillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnGUCancelar.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGUCancelar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnGUCancelar.ImageOffset = New System.Drawing.Point(-2, 0)
        Me.btnGUCancelar.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnGUCancelar.Location = New System.Drawing.Point(74, 602)
        Me.btnGUCancelar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGUCancelar.Name = "btnGUCancelar"
        Me.btnGUCancelar.ShadowDecoration.BorderRadius = 20
        Me.btnGUCancelar.Size = New System.Drawing.Size(252, 79)
        Me.btnGUCancelar.TabIndex = 42
        Me.btnGUCancelar.Text = "Cancelar"
        '
        'btnGUAniadir
        '
        Me.btnGUAniadir.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGUAniadir.BackColor = System.Drawing.Color.Transparent
        Me.btnGUAniadir.BorderRadius = 15
        Me.btnGUAniadir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGUAniadir.CustomizableEdges.BottomLeft = False
        Me.btnGUAniadir.CustomizableEdges.TopLeft = False
        Me.btnGUAniadir.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGUAniadir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGUAniadir.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGUAniadir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGUAniadir.FillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnGUAniadir.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGUAniadir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnGUAniadir.ImageSize = New System.Drawing.Size(40, 35)
        Me.btnGUAniadir.Location = New System.Drawing.Point(332, 602)
        Me.btnGUAniadir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGUAniadir.Name = "btnGUAniadir"
        Me.btnGUAniadir.ShadowDecoration.BorderRadius = 20
        Me.btnGUAniadir.Size = New System.Drawing.Size(252, 79)
        Me.btnGUAniadir.TabIndex = 41
        Me.btnGUAniadir.Text = "Añadir"
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
        Me.cbGUCategoriasID.Location = New System.Drawing.Point(125, 416)
        Me.cbGUCategoriasID.Name = "cbGUCategoriasID"
        Me.cbGUCategoriasID.Size = New System.Drawing.Size(413, 36)
        Me.cbGUCategoriasID.TabIndex = 67
        Me.cbGUCategoriasID.Visible = False
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
        Me.cbGUCategoriasNombre.Location = New System.Drawing.Point(125, 416)
        Me.cbGUCategoriasNombre.Name = "cbGUCategoriasNombre"
        Me.cbGUCategoriasNombre.Size = New System.Drawing.Size(413, 36)
        Me.cbGUCategoriasNombre.TabIndex = 66
        '
        'lblGUCategoria
        '
        Me.lblGUCategoria.BackColor = System.Drawing.Color.Transparent
        Me.lblGUCategoria.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGUCategoria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.lblGUCategoria.Location = New System.Drawing.Point(125, 381)
        Me.lblGUCategoria.Name = "lblGUCategoria"
        Me.lblGUCategoria.Size = New System.Drawing.Size(92, 30)
        Me.lblGUCategoria.TabIndex = 65
        Me.lblGUCategoria.TabStop = False
        Me.lblGUCategoria.Text = "Categoria:"
        Me.lblGUCategoria.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbStock
        '
        Me.tbStock.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbStock.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.tbStock.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tbStock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.tbStock.Location = New System.Drawing.Point(125, 327)
        Me.tbStock.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbStock.MaxLength = 20
        Me.tbStock.Name = "tbStock"
        Me.tbStock.PlaceholderText = "Introduzca el stock"
        Me.tbStock.Size = New System.Drawing.Size(414, 39)
        Me.tbStock.TabIndex = 62
        '
        'lblGUStock
        '
        Me.lblGUStock.BackColor = System.Drawing.Color.Transparent
        Me.lblGUStock.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGUStock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.lblGUStock.Location = New System.Drawing.Point(125, 292)
        Me.lblGUStock.Name = "lblGUStock"
        Me.lblGUStock.Size = New System.Drawing.Size(56, 30)
        Me.lblGUStock.TabIndex = 61
        Me.lblGUStock.TabStop = False
        Me.lblGUStock.Text = "Stock:"
        Me.lblGUStock.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbPrecio
        '
        Me.tbPrecio.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbPrecio.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.tbPrecio.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tbPrecio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.tbPrecio.Location = New System.Drawing.Point(125, 238)
        Me.tbPrecio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbPrecio.MaxLength = 20
        Me.tbPrecio.Name = "tbPrecio"
        Me.tbPrecio.PlaceholderText = "Introduzca el precio"
        Me.tbPrecio.Size = New System.Drawing.Size(414, 39)
        Me.tbPrecio.TabIndex = 60
        '
        'lblGUPrecio
        '
        Me.lblGUPrecio.BackColor = System.Drawing.Color.Transparent
        Me.lblGUPrecio.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGUPrecio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.lblGUPrecio.Location = New System.Drawing.Point(125, 203)
        Me.lblGUPrecio.Name = "lblGUPrecio"
        Me.lblGUPrecio.Size = New System.Drawing.Size(61, 30)
        Me.lblGUPrecio.TabIndex = 59
        Me.lblGUPrecio.TabStop = False
        Me.lblGUPrecio.Text = "Precio:"
        '
        'tbNombre
        '
        Me.tbNombre.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.tbNombre.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tbNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.tbNombre.Location = New System.Drawing.Point(125, 149)
        Me.tbNombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbNombre.MaxLength = 50
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.PlaceholderText = "Introduzca el nombre"
        Me.tbNombre.Size = New System.Drawing.Size(414, 39)
        Me.tbNombre.TabIndex = 58
        '
        'lblGUNombre
        '
        Me.lblGUNombre.BackColor = System.Drawing.Color.Transparent
        Me.lblGUNombre.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGUNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.lblGUNombre.Location = New System.Drawing.Point(125, 114)
        Me.lblGUNombre.Name = "lblGUNombre"
        Me.lblGUNombre.Size = New System.Drawing.Size(80, 30)
        Me.lblGUNombre.TabIndex = 57
        Me.lblGUNombre.TabStop = False
        Me.lblGUNombre.Text = "Nombre:"
        '
        'lblGUImagen
        '
        Me.lblGUImagen.BackColor = System.Drawing.Color.Transparent
        Me.lblGUImagen.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGUImagen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.lblGUImagen.Location = New System.Drawing.Point(125, 470)
        Me.lblGUImagen.Name = "lblGUImagen"
        Me.lblGUImagen.Size = New System.Drawing.Size(72, 30)
        Me.lblGUImagen.TabIndex = 70
        Me.lblGUImagen.Text = "Imagen:"
        Me.lblGUImagen.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.btnGUEliminarIMG.Location = New System.Drawing.Point(490, 505)
        Me.btnGUEliminarIMG.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGUEliminarIMG.Name = "btnGUEliminarIMG"
        Me.btnGUEliminarIMG.ShadowDecoration.BorderRadius = 20
        Me.btnGUEliminarIMG.Size = New System.Drawing.Size(49, 46)
        Me.btnGUEliminarIMG.TabIndex = 69
        Me.btnGUEliminarIMG.Text = "X"
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
        Me.btnGUAniadirImagen.Location = New System.Drawing.Point(125, 505)
        Me.btnGUAniadirImagen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGUAniadirImagen.Name = "btnGUAniadirImagen"
        Me.btnGUAniadirImagen.ShadowDecoration.BorderRadius = 20
        Me.btnGUAniadirImagen.Size = New System.Drawing.Size(359, 46)
        Me.btnGUAniadirImagen.TabIndex = 68
        Me.btnGUAniadirImagen.Text = "Añadir imagen"
        '
        'pbGUImagenAux
        '
        Me.pbGUImagenAux.ImageRotate = 0!
        Me.pbGUImagenAux.Location = New System.Drawing.Point(25, 131)
        Me.pbGUImagenAux.Name = "pbGUImagenAux"
        Me.pbGUImagenAux.Size = New System.Drawing.Size(71, 87)
        Me.pbGUImagenAux.TabIndex = 71
        Me.pbGUImagenAux.TabStop = False
        Me.pbGUImagenAux.Visible = False
        '
        'frmAniadirArticulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(650, 740)
        Me.Controls.Add(Me.pbGUImagenAux)
        Me.Controls.Add(Me.lblGUImagen)
        Me.Controls.Add(Me.btnGUEliminarIMG)
        Me.Controls.Add(Me.btnGUAniadirImagen)
        Me.Controls.Add(Me.cbGUCategoriasID)
        Me.Controls.Add(Me.cbGUCategoriasNombre)
        Me.Controls.Add(Me.lblGUCategoria)
        Me.Controls.Add(Me.tbStock)
        Me.Controls.Add(Me.lblGUStock)
        Me.Controls.Add(Me.tbPrecio)
        Me.Controls.Add(Me.lblGUPrecio)
        Me.Controls.Add(Me.tbNombre)
        Me.Controls.Add(Me.lblGUNombre)
        Me.Controls.Add(Me.btnGUCancelar)
        Me.Controls.Add(Me.btnGUAniadir)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAniadirArticulo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TPV Bar AfterLife"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbGUImagenAux, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblGUSeleccionMesa As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnGUCancelar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnGUAniadir As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cbGUCategoriasID As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cbGUCategoriasNombre As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblGUCategoria As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents tbStock As TextBox
    Friend WithEvents lblGUStock As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents tbPrecio As TextBox
    Friend WithEvents lblGUPrecio As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents lblGUNombre As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblGUImagen As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnGUEliminarIMG As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnGUAniadirImagen As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pbGUImagenAux As Guna.UI2.WinForms.Guna2PictureBox
End Class
