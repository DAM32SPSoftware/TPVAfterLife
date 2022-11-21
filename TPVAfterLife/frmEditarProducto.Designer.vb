<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditarProducto
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
        Me.btnGUBorrar = New Guna.UI2.WinForms.Guna2Button()
        Me.btnGUCancelar = New Guna.UI2.WinForms.Guna2Button()
        Me.btnGUAceptar = New Guna.UI2.WinForms.Guna2Button()
        Me.btnGUCero = New Guna.UI2.WinForms.Guna2Button()
        Me.btnGUNueve = New Guna.UI2.WinForms.Guna2Button()
        Me.btnGUOcho = New Guna.UI2.WinForms.Guna2Button()
        Me.btnGUSiete = New Guna.UI2.WinForms.Guna2Button()
        Me.btnGUSeis = New Guna.UI2.WinForms.Guna2Button()
        Me.btnGUCinco = New Guna.UI2.WinForms.Guna2Button()
        Me.btnGUCuatro = New Guna.UI2.WinForms.Guna2Button()
        Me.btnGUTres = New Guna.UI2.WinForms.Guna2Button()
        Me.btnGUDisminuir = New Guna.UI2.WinForms.Guna2Button()
        Me.btnGUAumentar = New Guna.UI2.WinForms.Guna2Button()
        Me.tbCantidad = New System.Windows.Forms.TextBox()
        Me.btnGUUno = New Guna.UI2.WinForms.Guna2Button()
        Me.btnGUDos = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblGUProducto = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblGUInfoProducto = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGUBorrar
        '
        Me.btnGUBorrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGUBorrar.BackColor = System.Drawing.Color.Transparent
        Me.btnGUBorrar.BorderRadius = 10
        Me.btnGUBorrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGUBorrar.CustomizableEdges.BottomLeft = False
        Me.btnGUBorrar.CustomizableEdges.TopLeft = False
        Me.btnGUBorrar.CustomizableEdges.TopRight = False
        Me.btnGUBorrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGUBorrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGUBorrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGUBorrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGUBorrar.FillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnGUBorrar.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGUBorrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnGUBorrar.Location = New System.Drawing.Point(659, 289)
        Me.btnGUBorrar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGUBorrar.Name = "btnGUBorrar"
        Me.btnGUBorrar.ShadowDecoration.BorderRadius = 20
        Me.btnGUBorrar.Size = New System.Drawing.Size(67, 51)
        Me.btnGUBorrar.TabIndex = 59
        Me.btnGUBorrar.Text = "X"
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
        Me.btnGUCancelar.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGUCancelar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnGUCancelar.ImageOffset = New System.Drawing.Point(-2, 0)
        Me.btnGUCancelar.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnGUCancelar.Location = New System.Drawing.Point(144, 388)
        Me.btnGUCancelar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGUCancelar.Name = "btnGUCancelar"
        Me.btnGUCancelar.ShadowDecoration.BorderRadius = 20
        Me.btnGUCancelar.Size = New System.Drawing.Size(280, 79)
        Me.btnGUCancelar.TabIndex = 58
        Me.btnGUCancelar.Text = "Cancelar"
        '
        'btnGUAceptar
        '
        Me.btnGUAceptar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGUAceptar.BackColor = System.Drawing.Color.Transparent
        Me.btnGUAceptar.BorderRadius = 15
        Me.btnGUAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGUAceptar.CustomizableEdges.BottomLeft = False
        Me.btnGUAceptar.CustomizableEdges.TopLeft = False
        Me.btnGUAceptar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGUAceptar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGUAceptar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGUAceptar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGUAceptar.FillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnGUAceptar.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGUAceptar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnGUAceptar.ImageSize = New System.Drawing.Size(40, 35)
        Me.btnGUAceptar.Location = New System.Drawing.Point(430, 388)
        Me.btnGUAceptar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGUAceptar.Name = "btnGUAceptar"
        Me.btnGUAceptar.ShadowDecoration.BorderRadius = 20
        Me.btnGUAceptar.Size = New System.Drawing.Size(280, 79)
        Me.btnGUAceptar.TabIndex = 57
        Me.btnGUAceptar.Text = "Aceptar"
        '
        'btnGUCero
        '
        Me.btnGUCero.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGUCero.BackColor = System.Drawing.Color.Transparent
        Me.btnGUCero.BorderRadius = 10
        Me.btnGUCero.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGUCero.CustomizableEdges.BottomRight = False
        Me.btnGUCero.CustomizableEdges.TopLeft = False
        Me.btnGUCero.CustomizableEdges.TopRight = False
        Me.btnGUCero.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGUCero.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGUCero.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGUCero.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGUCero.FillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnGUCero.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGUCero.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnGUCero.Location = New System.Drawing.Point(513, 289)
        Me.btnGUCero.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGUCero.Name = "btnGUCero"
        Me.btnGUCero.ShadowDecoration.BorderRadius = 20
        Me.btnGUCero.Size = New System.Drawing.Size(140, 51)
        Me.btnGUCero.TabIndex = 56
        Me.btnGUCero.Text = "0"
        '
        'btnGUNueve
        '
        Me.btnGUNueve.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGUNueve.BackColor = System.Drawing.Color.Transparent
        Me.btnGUNueve.BorderRadius = 10
        Me.btnGUNueve.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGUNueve.CustomizableEdges.BottomLeft = False
        Me.btnGUNueve.CustomizableEdges.BottomRight = False
        Me.btnGUNueve.CustomizableEdges.TopLeft = False
        Me.btnGUNueve.CustomizableEdges.TopRight = False
        Me.btnGUNueve.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGUNueve.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGUNueve.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGUNueve.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGUNueve.FillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnGUNueve.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGUNueve.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnGUNueve.Location = New System.Drawing.Point(659, 234)
        Me.btnGUNueve.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGUNueve.Name = "btnGUNueve"
        Me.btnGUNueve.ShadowDecoration.BorderRadius = 20
        Me.btnGUNueve.Size = New System.Drawing.Size(67, 51)
        Me.btnGUNueve.TabIndex = 55
        Me.btnGUNueve.Text = "9"
        '
        'btnGUOcho
        '
        Me.btnGUOcho.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGUOcho.BackColor = System.Drawing.Color.Transparent
        Me.btnGUOcho.BorderRadius = 10
        Me.btnGUOcho.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGUOcho.CustomizableEdges.BottomLeft = False
        Me.btnGUOcho.CustomizableEdges.BottomRight = False
        Me.btnGUOcho.CustomizableEdges.TopLeft = False
        Me.btnGUOcho.CustomizableEdges.TopRight = False
        Me.btnGUOcho.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGUOcho.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGUOcho.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGUOcho.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGUOcho.FillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnGUOcho.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGUOcho.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnGUOcho.Location = New System.Drawing.Point(586, 234)
        Me.btnGUOcho.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGUOcho.Name = "btnGUOcho"
        Me.btnGUOcho.ShadowDecoration.BorderRadius = 20
        Me.btnGUOcho.Size = New System.Drawing.Size(67, 51)
        Me.btnGUOcho.TabIndex = 54
        Me.btnGUOcho.Text = "8"
        '
        'btnGUSiete
        '
        Me.btnGUSiete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGUSiete.BackColor = System.Drawing.Color.Transparent
        Me.btnGUSiete.BorderRadius = 10
        Me.btnGUSiete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGUSiete.CustomizableEdges.BottomLeft = False
        Me.btnGUSiete.CustomizableEdges.BottomRight = False
        Me.btnGUSiete.CustomizableEdges.TopLeft = False
        Me.btnGUSiete.CustomizableEdges.TopRight = False
        Me.btnGUSiete.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGUSiete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGUSiete.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGUSiete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGUSiete.FillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnGUSiete.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGUSiete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnGUSiete.Location = New System.Drawing.Point(513, 234)
        Me.btnGUSiete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGUSiete.Name = "btnGUSiete"
        Me.btnGUSiete.ShadowDecoration.BorderRadius = 20
        Me.btnGUSiete.Size = New System.Drawing.Size(67, 51)
        Me.btnGUSiete.TabIndex = 53
        Me.btnGUSiete.Text = "7"
        '
        'btnGUSeis
        '
        Me.btnGUSeis.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGUSeis.BackColor = System.Drawing.Color.Transparent
        Me.btnGUSeis.BorderRadius = 10
        Me.btnGUSeis.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGUSeis.CustomizableEdges.BottomLeft = False
        Me.btnGUSeis.CustomizableEdges.BottomRight = False
        Me.btnGUSeis.CustomizableEdges.TopLeft = False
        Me.btnGUSeis.CustomizableEdges.TopRight = False
        Me.btnGUSeis.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGUSeis.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGUSeis.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGUSeis.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGUSeis.FillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnGUSeis.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGUSeis.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnGUSeis.Location = New System.Drawing.Point(659, 179)
        Me.btnGUSeis.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGUSeis.Name = "btnGUSeis"
        Me.btnGUSeis.ShadowDecoration.BorderRadius = 20
        Me.btnGUSeis.Size = New System.Drawing.Size(67, 51)
        Me.btnGUSeis.TabIndex = 52
        Me.btnGUSeis.Text = "6"
        '
        'btnGUCinco
        '
        Me.btnGUCinco.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGUCinco.BackColor = System.Drawing.Color.Transparent
        Me.btnGUCinco.BorderRadius = 10
        Me.btnGUCinco.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGUCinco.CustomizableEdges.BottomLeft = False
        Me.btnGUCinco.CustomizableEdges.BottomRight = False
        Me.btnGUCinco.CustomizableEdges.TopLeft = False
        Me.btnGUCinco.CustomizableEdges.TopRight = False
        Me.btnGUCinco.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGUCinco.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGUCinco.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGUCinco.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGUCinco.FillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnGUCinco.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGUCinco.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnGUCinco.Location = New System.Drawing.Point(586, 179)
        Me.btnGUCinco.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGUCinco.Name = "btnGUCinco"
        Me.btnGUCinco.ShadowDecoration.BorderRadius = 20
        Me.btnGUCinco.Size = New System.Drawing.Size(67, 51)
        Me.btnGUCinco.TabIndex = 51
        Me.btnGUCinco.Text = "5"
        '
        'btnGUCuatro
        '
        Me.btnGUCuatro.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGUCuatro.BackColor = System.Drawing.Color.Transparent
        Me.btnGUCuatro.BorderRadius = 10
        Me.btnGUCuatro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGUCuatro.CustomizableEdges.BottomLeft = False
        Me.btnGUCuatro.CustomizableEdges.BottomRight = False
        Me.btnGUCuatro.CustomizableEdges.TopLeft = False
        Me.btnGUCuatro.CustomizableEdges.TopRight = False
        Me.btnGUCuatro.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGUCuatro.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGUCuatro.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGUCuatro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGUCuatro.FillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnGUCuatro.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGUCuatro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnGUCuatro.Location = New System.Drawing.Point(513, 179)
        Me.btnGUCuatro.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGUCuatro.Name = "btnGUCuatro"
        Me.btnGUCuatro.ShadowDecoration.BorderRadius = 20
        Me.btnGUCuatro.Size = New System.Drawing.Size(67, 51)
        Me.btnGUCuatro.TabIndex = 50
        Me.btnGUCuatro.Text = "4"
        '
        'btnGUTres
        '
        Me.btnGUTres.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGUTres.BackColor = System.Drawing.Color.Transparent
        Me.btnGUTres.BorderRadius = 10
        Me.btnGUTres.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGUTres.CustomizableEdges.BottomLeft = False
        Me.btnGUTres.CustomizableEdges.BottomRight = False
        Me.btnGUTres.CustomizableEdges.TopLeft = False
        Me.btnGUTres.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGUTres.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGUTres.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGUTres.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGUTres.FillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnGUTres.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGUTres.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnGUTres.Location = New System.Drawing.Point(659, 124)
        Me.btnGUTres.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGUTres.Name = "btnGUTres"
        Me.btnGUTres.ShadowDecoration.BorderRadius = 20
        Me.btnGUTres.Size = New System.Drawing.Size(67, 51)
        Me.btnGUTres.TabIndex = 49
        Me.btnGUTres.Text = "3"
        '
        'btnGUDisminuir
        '
        Me.btnGUDisminuir.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGUDisminuir.BackColor = System.Drawing.Color.Transparent
        Me.btnGUDisminuir.BorderRadius = 15
        Me.btnGUDisminuir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGUDisminuir.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGUDisminuir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGUDisminuir.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGUDisminuir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGUDisminuir.FillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnGUDisminuir.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGUDisminuir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnGUDisminuir.Location = New System.Drawing.Point(125, 230)
        Me.btnGUDisminuir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGUDisminuir.Name = "btnGUDisminuir"
        Me.btnGUDisminuir.ShadowDecoration.BorderRadius = 20
        Me.btnGUDisminuir.Size = New System.Drawing.Size(120, 110)
        Me.btnGUDisminuir.TabIndex = 46
        Me.btnGUDisminuir.Text = "Disminuir"
        '
        'btnGUAumentar
        '
        Me.btnGUAumentar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGUAumentar.BackColor = System.Drawing.Color.Transparent
        Me.btnGUAumentar.BorderRadius = 15
        Me.btnGUAumentar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGUAumentar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGUAumentar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGUAumentar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGUAumentar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGUAumentar.FillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnGUAumentar.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGUAumentar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnGUAumentar.Location = New System.Drawing.Point(312, 230)
        Me.btnGUAumentar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGUAumentar.Name = "btnGUAumentar"
        Me.btnGUAumentar.ShadowDecoration.BorderRadius = 20
        Me.btnGUAumentar.Size = New System.Drawing.Size(120, 110)
        Me.btnGUAumentar.TabIndex = 45
        Me.btnGUAumentar.Text = "Aumentar"
        '
        'tbCantidad
        '
        Me.tbCantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.tbCantidad.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.tbCantidad.Location = New System.Drawing.Point(125, 100)
        Me.tbCantidad.Name = "tbCantidad"
        Me.tbCantidad.ReadOnly = True
        Me.tbCantidad.Size = New System.Drawing.Size(307, 61)
        Me.tbCantidad.TabIndex = 42
        Me.tbCantidad.Text = "tbCantidad"
        Me.tbCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnGUUno
        '
        Me.btnGUUno.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGUUno.BackColor = System.Drawing.Color.Transparent
        Me.btnGUUno.BorderRadius = 10
        Me.btnGUUno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGUUno.CustomizableEdges.BottomLeft = False
        Me.btnGUUno.CustomizableEdges.BottomRight = False
        Me.btnGUUno.CustomizableEdges.TopRight = False
        Me.btnGUUno.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGUUno.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGUUno.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGUUno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGUUno.FillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnGUUno.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGUUno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnGUUno.Location = New System.Drawing.Point(513, 124)
        Me.btnGUUno.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGUUno.Name = "btnGUUno"
        Me.btnGUUno.ShadowDecoration.BorderRadius = 20
        Me.btnGUUno.Size = New System.Drawing.Size(67, 51)
        Me.btnGUUno.TabIndex = 47
        Me.btnGUUno.Text = "1"
        '
        'btnGUDos
        '
        Me.btnGUDos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGUDos.BackColor = System.Drawing.Color.Transparent
        Me.btnGUDos.BorderRadius = 10
        Me.btnGUDos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGUDos.CustomizableEdges.BottomLeft = False
        Me.btnGUDos.CustomizableEdges.BottomRight = False
        Me.btnGUDos.CustomizableEdges.TopLeft = False
        Me.btnGUDos.CustomizableEdges.TopRight = False
        Me.btnGUDos.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGUDos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGUDos.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGUDos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGUDos.FillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnGUDos.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGUDos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnGUDos.Location = New System.Drawing.Point(586, 124)
        Me.btnGUDos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGUDos.Name = "btnGUDos"
        Me.btnGUDos.ShadowDecoration.BorderRadius = 20
        Me.btnGUDos.Size = New System.Drawing.Size(67, 51)
        Me.btnGUDos.TabIndex = 48
        Me.btnGUDos.Text = "2"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblGUProducto)
        Me.Panel1.Controls.Add(Me.lblGUInfoProducto)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(799, 73)
        Me.Panel1.TabIndex = 60
        '
        'lblGUProducto
        '
        Me.lblGUProducto.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblGUProducto.BackColor = System.Drawing.Color.Transparent
        Me.lblGUProducto.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGUProducto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.lblGUProducto.Location = New System.Drawing.Point(304, 21)
        Me.lblGUProducto.Name = "lblGUProducto"
        Me.lblGUProducto.Size = New System.Drawing.Size(137, 32)
        Me.lblGUProducto.TabIndex = 6
        Me.lblGUProducto.Text = "lblGUProducto"
        '
        'lblGUInfoProducto
        '
        Me.lblGUInfoProducto.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblGUInfoProducto.BackColor = System.Drawing.Color.Transparent
        Me.lblGUInfoProducto.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblGUInfoProducto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.lblGUInfoProducto.Location = New System.Drawing.Point(12, 21)
        Me.lblGUInfoProducto.Name = "lblGUInfoProducto"
        Me.lblGUInfoProducto.Size = New System.Drawing.Size(286, 32)
        Me.lblGUInfoProducto.TabIndex = 5
        Me.lblGUInfoProducto.Text = "PRODUCTO SELECCIONADO:"
        '
        'frmEditarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 498)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnGUBorrar)
        Me.Controls.Add(Me.btnGUCancelar)
        Me.Controls.Add(Me.btnGUAceptar)
        Me.Controls.Add(Me.btnGUCero)
        Me.Controls.Add(Me.btnGUNueve)
        Me.Controls.Add(Me.btnGUOcho)
        Me.Controls.Add(Me.btnGUSiete)
        Me.Controls.Add(Me.btnGUSeis)
        Me.Controls.Add(Me.btnGUCinco)
        Me.Controls.Add(Me.btnGUCuatro)
        Me.Controls.Add(Me.btnGUTres)
        Me.Controls.Add(Me.btnGUDisminuir)
        Me.Controls.Add(Me.btnGUAumentar)
        Me.Controls.Add(Me.tbCantidad)
        Me.Controls.Add(Me.btnGUUno)
        Me.Controls.Add(Me.btnGUDos)
        Me.Name = "frmEditarProducto"
        Me.Text = "frmEditarProducto"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGUBorrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnGUCancelar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnGUAceptar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnGUCero As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnGUNueve As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnGUOcho As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnGUSiete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnGUSeis As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnGUCinco As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnGUCuatro As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnGUTres As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnGUDisminuir As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnGUAumentar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents tbCantidad As TextBox
    Friend WithEvents btnGUUno As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnGUDos As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblGUProducto As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblGUInfoProducto As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
