<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTheGame
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGUCerrar = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(190, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 54)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "THE GAME"
        '
        'btnGUCerrar
        '
        Me.btnGUCerrar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnGUCerrar.BorderRadius = 15
        Me.btnGUCerrar.BorderThickness = 3
        Me.btnGUCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGUCerrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGUCerrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGUCerrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGUCerrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGUCerrar.FillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnGUCerrar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGUCerrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnGUCerrar.Location = New System.Drawing.Point(240, 143)
        Me.btnGUCerrar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGUCerrar.Name = "btnGUCerrar"
        Me.btnGUCerrar.Size = New System.Drawing.Size(118, 46)
        Me.btnGUCerrar.TabIndex = 9
        Me.btnGUCerrar.Text = "Cerrar"
        '
        'frmTheGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(593, 266)
        Me.Controls.Add(Me.btnGUCerrar)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTheGame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "The Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnGUCerrar As Guna.UI2.WinForms.Guna2Button
End Class
