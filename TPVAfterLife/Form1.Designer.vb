<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnGUAcercaDe = New Guna.UI2.WinForms.Guna2Button()
        Me.btnGUIniciarTPV = New Guna.UI2.WinForms.Guna2Button()
        Me.btnGUSalir = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = Global.TPVAfterLife.My.Resources.Resources.LogoLetrero_color_cremita_
        Me.PictureBox1.Location = New System.Drawing.Point(-3, -102)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1280, 720)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnGUAcercaDe
        '
        Me.btnGUAcercaDe.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGUAcercaDe.BackColor = System.Drawing.Color.Transparent
        Me.btnGUAcercaDe.BorderRadius = 15
        Me.btnGUAcercaDe.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGUAcercaDe.CustomizableEdges.BottomRight = False
        Me.btnGUAcercaDe.CustomizableEdges.TopRight = False
        Me.btnGUAcercaDe.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGUAcercaDe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGUAcercaDe.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGUAcercaDe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGUAcercaDe.FillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnGUAcercaDe.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGUAcercaDe.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnGUAcercaDe.Location = New System.Drawing.Point(185, 467)
        Me.btnGUAcercaDe.Name = "btnGUAcercaDe"
        Me.btnGUAcercaDe.ShadowDecoration.BorderRadius = 20
        Me.btnGUAcercaDe.Size = New System.Drawing.Size(319, 105)
        Me.btnGUAcercaDe.TabIndex = 4
        Me.btnGUAcercaDe.Text = "Acerca de SP Software"
        '
        'btnGUIniciarTPV
        '
        Me.btnGUIniciarTPV.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGUIniciarTPV.BackColor = System.Drawing.Color.Transparent
        Me.btnGUIniciarTPV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGUIniciarTPV.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGUIniciarTPV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGUIniciarTPV.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGUIniciarTPV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGUIniciarTPV.FillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnGUIniciarTPV.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGUIniciarTPV.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnGUIniciarTPV.Location = New System.Drawing.Point(510, 467)
        Me.btnGUIniciarTPV.Name = "btnGUIniciarTPV"
        Me.btnGUIniciarTPV.ShadowDecoration.BorderRadius = 20
        Me.btnGUIniciarTPV.Size = New System.Drawing.Size(293, 105)
        Me.btnGUIniciarTPV.TabIndex = 5
        Me.btnGUIniciarTPV.Text = "Iniciar TPV"
        '
        'btnGUSalir
        '
        Me.btnGUSalir.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGUSalir.BackColor = System.Drawing.Color.Transparent
        Me.btnGUSalir.BorderRadius = 15
        Me.btnGUSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGUSalir.CustomizableEdges.BottomLeft = False
        Me.btnGUSalir.CustomizableEdges.TopLeft = False
        Me.btnGUSalir.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGUSalir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGUSalir.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGUSalir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGUSalir.FillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnGUSalir.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGUSalir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnGUSalir.Location = New System.Drawing.Point(809, 467)
        Me.btnGUSalir.Name = "btnGUSalir"
        Me.btnGUSalir.ShadowDecoration.BorderRadius = 15
        Me.btnGUSalir.ShadowDecoration.CustomizableEdges.BottomLeft = False
        Me.btnGUSalir.ShadowDecoration.CustomizableEdges.TopLeft = False
        Me.btnGUSalir.Size = New System.Drawing.Size(312, 105)
        Me.btnGUSalir.TabIndex = 6
        Me.btnGUSalir.Text = "Salir"
        '
        'Form1
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1273, 768)
        Me.Controls.Add(Me.btnGUSalir)
        Me.Controls.Add(Me.btnGUIniciarTPV)
        Me.Controls.Add(Me.btnGUAcercaDe)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bar AfterLife TPV"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnGUAcercaDe As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnGUIniciarTPV As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnGUSalir As Guna.UI2.WinForms.Guna2Button
End Class
