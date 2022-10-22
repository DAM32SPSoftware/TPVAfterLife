<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfirmacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfirmacion))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblPregunta = New System.Windows.Forms.Label()
        Me.btnGUDenegar = New Guna.UI2.WinForms.Guna2Button()
        Me.btnGUConfirmar = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = Global.TPVAfterLife.My.Resources.Resources.pregunta_crema_
        Me.PictureBox1.Location = New System.Drawing.Point(51, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(161, 160)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblPregunta
        '
        Me.lblPregunta.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPregunta.AutoSize = True
        Me.lblPregunta.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPregunta.Location = New System.Drawing.Point(257, 55)
        Me.lblPregunta.Name = "lblPregunta"
        Me.lblPregunta.Size = New System.Drawing.Size(192, 46)
        Me.lblPregunta.TabIndex = 1
        Me.lblPregunta.Text = "lblPregunta"
        '
        'btnGUDenegar
        '
        Me.btnGUDenegar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGUDenegar.BackColor = System.Drawing.Color.Transparent
        Me.btnGUDenegar.BorderRadius = 15
        Me.btnGUDenegar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGUDenegar.CustomizableEdges.BottomRight = False
        Me.btnGUDenegar.CustomizableEdges.TopRight = False
        Me.btnGUDenegar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGUDenegar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGUDenegar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGUDenegar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGUDenegar.FillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnGUDenegar.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGUDenegar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnGUDenegar.Image = Global.TPVAfterLife.My.Resources.Resources.denegar3
        Me.btnGUDenegar.ImageOffset = New System.Drawing.Point(-2, 0)
        Me.btnGUDenegar.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnGUDenegar.Location = New System.Drawing.Point(89, 264)
        Me.btnGUDenegar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGUDenegar.Name = "btnGUDenegar"
        Me.btnGUDenegar.ShadowDecoration.BorderRadius = 20
        Me.btnGUDenegar.Size = New System.Drawing.Size(280, 79)
        Me.btnGUDenegar.TabIndex = 10
        Me.btnGUDenegar.Text = "No"
        '
        'btnGUConfirmar
        '
        Me.btnGUConfirmar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGUConfirmar.BackColor = System.Drawing.Color.Transparent
        Me.btnGUConfirmar.BorderRadius = 15
        Me.btnGUConfirmar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGUConfirmar.CustomizableEdges.BottomLeft = False
        Me.btnGUConfirmar.CustomizableEdges.TopLeft = False
        Me.btnGUConfirmar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGUConfirmar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGUConfirmar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGUConfirmar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGUConfirmar.FillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnGUConfirmar.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGUConfirmar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnGUConfirmar.Image = Global.TPVAfterLife.My.Resources.Resources.check
        Me.btnGUConfirmar.ImageSize = New System.Drawing.Size(40, 35)
        Me.btnGUConfirmar.Location = New System.Drawing.Point(375, 264)
        Me.btnGUConfirmar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGUConfirmar.Name = "btnGUConfirmar"
        Me.btnGUConfirmar.ShadowDecoration.BorderRadius = 20
        Me.btnGUConfirmar.Size = New System.Drawing.Size(280, 79)
        Me.btnGUConfirmar.TabIndex = 9
        Me.btnGUConfirmar.Text = "Sí"
        '
        'frmConfirmacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(730, 395)
        Me.Controls.Add(Me.btnGUDenegar)
        Me.Controls.Add(Me.btnGUConfirmar)
        Me.Controls.Add(Me.lblPregunta)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConfirmacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TPV Bar AfterLife"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblPregunta As Label
    Friend WithEvents btnGUDenegar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnGUConfirmar As Guna.UI2.WinForms.Guna2Button
End Class
