<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMensaje
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMensaje))
        Me.btnGUAceptar = New Guna.UI2.WinForms.Guna2Button()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.pbInfoWarning = New System.Windows.Forms.PictureBox()
        CType(Me.pbInfoWarning, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGUAceptar
        '
        Me.btnGUAceptar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGUAceptar.BackColor = System.Drawing.Color.Transparent
        Me.btnGUAceptar.BorderRadius = 15
        Me.btnGUAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGUAceptar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGUAceptar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGUAceptar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGUAceptar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGUAceptar.FillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnGUAceptar.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGUAceptar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnGUAceptar.ImageSize = New System.Drawing.Size(40, 35)
        Me.btnGUAceptar.Location = New System.Drawing.Point(68, 222)
        Me.btnGUAceptar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGUAceptar.Name = "btnGUAceptar"
        Me.btnGUAceptar.ShadowDecoration.BorderRadius = 20
        Me.btnGUAceptar.Size = New System.Drawing.Size(479, 73)
        Me.btnGUAceptar.TabIndex = 13
        Me.btnGUAceptar.Text = "Aceptar"
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblMensaje.ForeColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.lblMensaje.Location = New System.Drawing.Point(204, 56)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(161, 41)
        Me.lblMensaje.TabIndex = 12
        Me.lblMensaje.Text = "lblMensaje"
        '
        'pbInfoWarning
        '
        Me.pbInfoWarning.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbInfoWarning.Image = Global.TPVAfterLife.My.Resources.Resources.info_crema_
        Me.pbInfoWarning.Location = New System.Drawing.Point(49, 46)
        Me.pbInfoWarning.Name = "pbInfoWarning"
        Me.pbInfoWarning.Size = New System.Drawing.Size(110, 117)
        Me.pbInfoWarning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbInfoWarning.TabIndex = 11
        Me.pbInfoWarning.TabStop = False
        '
        'frmMensaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(616, 339)
        Me.Controls.Add(Me.btnGUAceptar)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.pbInfoWarning)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMensaje"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TPV Bar AfterLife"
        CType(Me.pbInfoWarning, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGUAceptar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblMensaje As Label
    Friend WithEvents pbInfoWarning As PictureBox
End Class
