<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAcercaDe
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAcercaDe))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblAqui = New System.Windows.Forms.Label()
        Me.btnGUAceptar = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TPVAfterLife.My.Resources.Resources.SpLogo
        Me.PictureBox1.Location = New System.Drawing.Point(174, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(475, 278)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(240, 218)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(302, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SP Soluciones de Software S.Coop."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(240, 252)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "TPV Bar AfterLife v.12.04.2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(240, 281)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(245, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "© 2022 SP Software Studios"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(240, 312)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(268, 25)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Todos los derechos reservados"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(240, 344)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(316, 25)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Para obtener mas información pulsa"
        '
        'lblAqui
        '
        Me.lblAqui.AutoSize = True
        Me.lblAqui.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblAqui.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.lblAqui.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblAqui.Location = New System.Drawing.Point(549, 344)
        Me.lblAqui.Name = "lblAqui"
        Me.lblAqui.Size = New System.Drawing.Size(49, 25)
        Me.lblAqui.TabIndex = 7
        Me.lblAqui.Text = "aquí"
        '
        'btnGUAceptar
        '
        Me.btnGUAceptar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnGUAceptar.BorderRadius = 15
        Me.btnGUAceptar.BorderThickness = 3
        Me.btnGUAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGUAceptar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGUAceptar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGUAceptar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGUAceptar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGUAceptar.FillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnGUAceptar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGUAceptar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnGUAceptar.Location = New System.Drawing.Point(349, 408)
        Me.btnGUAceptar.Name = "btnGUAceptar"
        Me.btnGUAceptar.Size = New System.Drawing.Size(129, 56)
        Me.btnGUAceptar.TabIndex = 8
        Me.btnGUAceptar.Text = "Aceptar"
        '
        'Guna2AnimateWindow1
        '
        Me.Guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_HOR_POSITIVE
        Me.Guna2AnimateWindow1.Interval = 300
        Me.Guna2AnimateWindow1.TargetForm = Me
        '
        'frmAcercaDe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 492)
        Me.Controls.Add(Me.btnGUAceptar)
        Me.Controls.Add(Me.lblAqui)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAcercaDe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acerca De SP Software"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblAqui As Label
    Friend WithEvents btnGUAceptar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
End Class
