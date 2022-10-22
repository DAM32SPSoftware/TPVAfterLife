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
        Me.btnGUCerrar = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'btnGUCerrar
        '
        Me.btnGUCerrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGUCerrar.BackColor = System.Drawing.Color.Transparent
        Me.btnGUCerrar.BorderRadius = 10
        Me.btnGUCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGUCerrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGUCerrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGUCerrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGUCerrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGUCerrar.FillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnGUCerrar.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGUCerrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnGUCerrar.Location = New System.Drawing.Point(320, 623)
        Me.btnGUCerrar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGUCerrar.Name = "btnGUCerrar"
        Me.btnGUCerrar.ShadowDecoration.BorderRadius = 20
        Me.btnGUCerrar.Size = New System.Drawing.Size(474, 54)
        Me.btnGUCerrar.TabIndex = 7
        Me.btnGUCerrar.Text = "Cerrar"
        '
        'frmPaginaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1079, 840)
        Me.Controls.Add(Me.btnGUCerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPaginaPrincipal"
        Me.Text = "frmPaginaPrincipal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnGUCerrar As Guna.UI2.WinForms.Guna2Button
End Class
