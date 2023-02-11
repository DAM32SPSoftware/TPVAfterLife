<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Meteorologia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Meteorologia))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnGUAcercaDe = New Guna.UI2.WinForms.Guna2Button()
        Me.btnGUSalir = New Guna.UI2.WinForms.Guna2Button()
        Me.lblViento = New System.Windows.Forms.Label()
        Me.lblPrediccion = New System.Windows.Forms.Label()
        Me.lblTempMax = New System.Windows.Forms.Label()
        Me.lblTempMin = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cbFecha = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(59, 195)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Fecha:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(56, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Temperatura mínima:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(56, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(177, 21)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Temperatura máxima:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(56, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 21)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Predicción:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(59, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 21)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Viento:"
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
        Me.btnGUAcercaDe.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGUAcercaDe.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnGUAcercaDe.Location = New System.Drawing.Point(5, 236)
        Me.btnGUAcercaDe.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGUAcercaDe.Name = "btnGUAcercaDe"
        Me.btnGUAcercaDe.ShadowDecoration.BorderRadius = 20
        Me.btnGUAcercaDe.Size = New System.Drawing.Size(206, 46)
        Me.btnGUAcercaDe.TabIndex = 6
        Me.btnGUAcercaDe.Text = "Subir archivo"
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
        Me.btnGUSalir.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGUSalir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnGUSalir.Location = New System.Drawing.Point(218, 236)
        Me.btnGUSalir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGUSalir.Name = "btnGUSalir"
        Me.btnGUSalir.ShadowDecoration.BorderRadius = 15
        Me.btnGUSalir.ShadowDecoration.CustomizableEdges.BottomLeft = False
        Me.btnGUSalir.ShadowDecoration.CustomizableEdges.TopLeft = False
        Me.btnGUSalir.Size = New System.Drawing.Size(206, 46)
        Me.btnGUSalir.TabIndex = 7
        Me.btnGUSalir.Text = "Volver"
        '
        'lblViento
        '
        Me.lblViento.AutoSize = True
        Me.lblViento.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblViento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.lblViento.Location = New System.Drawing.Point(236, 174)
        Me.lblViento.Name = "lblViento"
        Me.lblViento.Size = New System.Drawing.Size(81, 21)
        Me.lblViento.TabIndex = 12
        Me.lblViento.Text = "lblViento"
        '
        'lblPrediccion
        '
        Me.lblPrediccion.AutoSize = True
        Me.lblPrediccion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPrediccion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.lblPrediccion.Location = New System.Drawing.Point(236, 153)
        Me.lblPrediccion.Name = "lblPrediccion"
        Me.lblPrediccion.Size = New System.Drawing.Size(111, 21)
        Me.lblPrediccion.TabIndex = 11
        Me.lblPrediccion.Text = "lblPrediccion"
        '
        'lblTempMax
        '
        Me.lblTempMax.AutoSize = True
        Me.lblTempMax.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTempMax.ForeColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.lblTempMax.Location = New System.Drawing.Point(236, 132)
        Me.lblTempMax.Name = "lblTempMax"
        Me.lblTempMax.Size = New System.Drawing.Size(105, 21)
        Me.lblTempMax.TabIndex = 10
        Me.lblTempMax.Text = "lblTempMax"
        '
        'lblTempMin
        '
        Me.lblTempMin.AutoSize = True
        Me.lblTempMin.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTempMin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.lblTempMin.Location = New System.Drawing.Point(236, 111)
        Me.lblTempMin.Name = "lblTempMin"
        Me.lblTempMin.Size = New System.Drawing.Size(102, 21)
        Me.lblTempMin.TabIndex = 9
        Me.lblTempMin.Text = "lblTempMin"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(168, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 90)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'cbFecha
        '
        Me.cbFecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.cbFecha.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbFecha.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.cbFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.cbFecha.FormattingEnabled = True
        Me.cbFecha.Location = New System.Drawing.Point(239, 193)
        Me.cbFecha.Name = "cbFecha"
        Me.cbFecha.Size = New System.Drawing.Size(121, 29)
        Me.cbFecha.TabIndex = 14
        '
        'Meteorologia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(430, 308)
        Me.Controls.Add(Me.cbFecha)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblViento)
        Me.Controls.Add(Me.lblPrediccion)
        Me.Controls.Add(Me.lblTempMax)
        Me.Controls.Add(Me.lblTempMin)
        Me.Controls.Add(Me.btnGUSalir)
        Me.Controls.Add(Me.btnGUAcercaDe)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Meteorologia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Predicción Meteorológica"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnGUAcercaDe As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnGUSalir As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblViento As Label
    Friend WithEvents lblPrediccion As Label
    Friend WithEvents lblTempMax As Label
    Friend WithEvents lblTempMin As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cbFecha As ComboBox
End Class
