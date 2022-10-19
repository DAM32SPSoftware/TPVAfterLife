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
        Me.btnIDKBRO = New System.Windows.Forms.Button()
        Me.btnInicioTPV = New System.Windows.Forms.Button()
        Me.btnAcercaDe = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TPVAfterLife.My.Resources.Resources.LogoLetrero
        Me.PictureBox1.Location = New System.Drawing.Point(155, -23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(462, 238)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnIDKBRO
        '
        Me.btnIDKBRO.Location = New System.Drawing.Point(111, 206)
        Me.btnIDKBRO.Name = "btnIDKBRO"
        Me.btnIDKBRO.Size = New System.Drawing.Size(148, 134)
        Me.btnIDKBRO.TabIndex = 1
        Me.btnIDKBRO.Text = "IDK BRO"
        Me.btnIDKBRO.UseVisualStyleBackColor = True
        '
        'btnInicioTPV
        '
        Me.btnInicioTPV.Location = New System.Drawing.Point(330, 206)
        Me.btnInicioTPV.Name = "btnInicioTPV"
        Me.btnInicioTPV.Size = New System.Drawing.Size(148, 134)
        Me.btnInicioTPV.TabIndex = 2
        Me.btnInicioTPV.Text = "Inicar TPV"
        Me.btnInicioTPV.UseVisualStyleBackColor = True
        '
        'btnAcercaDe
        '
        Me.btnAcercaDe.Location = New System.Drawing.Point(547, 206)
        Me.btnAcercaDe.Name = "btnAcercaDe"
        Me.btnAcercaDe.Size = New System.Drawing.Size(148, 134)
        Me.btnAcercaDe.TabIndex = 3
        Me.btnAcercaDe.Text = "Acerca de SP Software"
        Me.btnAcercaDe.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnAcercaDe)
        Me.Controls.Add(Me.btnInicioTPV)
        Me.Controls.Add(Me.btnIDKBRO)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Bar AfterLife TPV"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnIDKBRO As Button
    Friend WithEvents btnInicioTPV As Button
    Friend WithEvents btnAcercaDe As Button
End Class
