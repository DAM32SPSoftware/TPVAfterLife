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
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btnGUSalir = New Guna.UI2.WinForms.Guna2Button()
        Me.btnGUAniadir = New Guna.UI2.WinForms.Guna2Button()
        Me.btnGUBorrar = New Guna.UI2.WinForms.Guna2Button()
        Me.btnGUModificar = New Guna.UI2.WinForms.Guna2Button()
        Me.pbGUProducto = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.dgvArticulos = New System.Windows.Forms.DataGridView()
        Me.lblGUNombre = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbGUProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = Global.TPVAfterLife.My.Resources.Resources.LogoIcono_color_cremita_
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(48, 566)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(215, 205)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 39
        Me.Guna2PictureBox1.TabStop = False
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
        Me.pbGUProducto.ImageRotate = 0!
        Me.pbGUProducto.Location = New System.Drawing.Point(345, 543)
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
        Me.dgvArticulos.Location = New System.Drawing.Point(37, 128)
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
        Me.lblGUNombre.Location = New System.Drawing.Point(720, 128)
        Me.lblGUNombre.Name = "lblGUNombre"
        Me.lblGUNombre.Size = New System.Drawing.Size(80, 30)
        Me.lblGUNombre.TabIndex = 46
        Me.lblGUNombre.Text = "Nombre:"
        '
        'frmArticulosCRUD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1185, 835)
        Me.Controls.Add(Me.lblGUNombre)
        Me.Controls.Add(Me.dgvArticulos)
        Me.Controls.Add(Me.pbGUProducto)
        Me.Controls.Add(Me.btnGUSalir)
        Me.Controls.Add(Me.btnGUAniadir)
        Me.Controls.Add(Me.btnGUBorrar)
        Me.Controls.Add(Me.btnGUModificar)
        Me.Controls.Add(Me.Guna2PictureBox1)
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
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbGUProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblGUSeleccionMesa As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnGUSalir As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnGUAniadir As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnGUBorrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnGUModificar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pbGUProducto As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents dgvArticulos As DataGridView
    Friend WithEvents lblGUNombre As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
