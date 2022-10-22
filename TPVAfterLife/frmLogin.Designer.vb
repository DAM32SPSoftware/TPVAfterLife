<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.tbUsuario = New System.Windows.Forms.TextBox()
        Me.tbContrasenia = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGUIniciarSesion = New Guna.UI2.WinForms.Guna2Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnGUCancelar = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbUsuario
        '
        Me.tbUsuario.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.tbUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbUsuario.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tbUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.tbUsuario.Location = New System.Drawing.Point(318, 170)
        Me.tbUsuario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbUsuario.MaxLength = 20
        Me.tbUsuario.Name = "tbUsuario"
        Me.tbUsuario.PlaceholderText = "Escriba aquí"
        Me.tbUsuario.Size = New System.Drawing.Size(245, 34)
        Me.tbUsuario.TabIndex = 0
        '
        'tbContrasenia
        '
        Me.tbContrasenia.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbContrasenia.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.tbContrasenia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbContrasenia.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tbContrasenia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.tbContrasenia.Location = New System.Drawing.Point(318, 241)
        Me.tbContrasenia.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbContrasenia.MaxLength = 20
        Me.tbContrasenia.Name = "tbContrasenia"
        Me.tbContrasenia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbContrasenia.PlaceholderText = "Escriba aquí"
        Me.tbContrasenia.Size = New System.Drawing.Size(245, 34)
        Me.tbContrasenia.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(150, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(150, 241)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 32)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Contraseña:"
        '
        'btnGUIniciarSesion
        '
        Me.btnGUIniciarSesion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGUIniciarSesion.BackColor = System.Drawing.Color.Transparent
        Me.btnGUIniciarSesion.BorderRadius = 15
        Me.btnGUIniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGUIniciarSesion.CustomizableEdges.BottomLeft = False
        Me.btnGUIniciarSesion.CustomizableEdges.TopLeft = False
        Me.btnGUIniciarSesion.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGUIniciarSesion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGUIniciarSesion.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGUIniciarSesion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGUIniciarSesion.FillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnGUIniciarSesion.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGUIniciarSesion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnGUIniciarSesion.Location = New System.Drawing.Point(359, 325)
        Me.btnGUIniciarSesion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGUIniciarSesion.Name = "btnGUIniciarSesion"
        Me.btnGUIniciarSesion.ShadowDecoration.BorderRadius = 20
        Me.btnGUIniciarSesion.Size = New System.Drawing.Size(234, 54)
        Me.btnGUIniciarSesion.TabIndex = 6
        Me.btnGUIniciarSesion.Text = "Iniciar sesión"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = Global.TPVAfterLife.My.Resources.Resources.LogoIcono_color_cremita_
        Me.PictureBox1.Location = New System.Drawing.Point(284, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(154, 153)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
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
        Me.btnGUCancelar.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGUCancelar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnGUCancelar.Location = New System.Drawing.Point(119, 325)
        Me.btnGUCancelar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGUCancelar.Name = "btnGUCancelar"
        Me.btnGUCancelar.ShadowDecoration.BorderRadius = 20
        Me.btnGUCancelar.Size = New System.Drawing.Size(234, 54)
        Me.btnGUCancelar.TabIndex = 8
        Me.btnGUCancelar.Text = "Cancelar"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(700, 428)
        Me.Controls.Add(Me.btnGUCancelar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnGUIniciarSesion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbContrasenia)
        Me.Controls.Add(Me.tbUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Iniciar Sesión"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbUsuario As TextBox
    Friend WithEvents tbContrasenia As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnGUIniciarSesion As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnGUCancelar As Guna.UI2.WinForms.Guna2Button
End Class
