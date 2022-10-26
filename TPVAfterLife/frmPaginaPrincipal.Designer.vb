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
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.btnGUApagar.Location = New System.Drawing.Point(595, 504)
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
        Me.Panel1.Location = New System.Drawing.Point(-8, 832)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1318, 76)
        Me.Panel1.TabIndex = 8
        '
        'lblGUHora
        '
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
        Me.lblGUInfoEmpleado.BackColor = System.Drawing.Color.Transparent
        Me.lblGUInfoEmpleado.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblGUInfoEmpleado.Location = New System.Drawing.Point(36, 23)
        Me.lblGUInfoEmpleado.Name = "lblGUInfoEmpleado"
        Me.lblGUInfoEmpleado.Size = New System.Drawing.Size(93, 23)
        Me.lblGUInfoEmpleado.TabIndex = 0
        Me.lblGUInfoEmpleado.Text = "EMPLEADO:"
        '
        'frmPaginaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1295, 900)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnGUApagar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPaginaPrincipal"
        Me.Text = "frmPaginaPrincipal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
End Class
