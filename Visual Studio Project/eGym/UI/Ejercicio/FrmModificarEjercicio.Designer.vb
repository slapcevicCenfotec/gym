﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModificarEjercicio
    Inherits MetroFramework.Controls.MetroUserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.txtDescripcion = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.txtErroresComunes = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel15 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.txtPosFinal = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroButton3 = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.txtPosInicial = New MetroFramework.Controls.MetroTextBox()
        Me.txtAlias = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel14 = New MetroFramework.Controls.MetroLabel()
        Me.txtNombre = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel13 = New MetroFramework.Controls.MetroLabel()
        Me.cbListaMusculosPrincipales = New MetroFramework.Controls.MetroComboBox()
        Me.ptbPosicionFinal = New System.Windows.Forms.PictureBox()
        Me.ptbPosicionInicial = New System.Windows.Forms.PictureBox()
        Me.cbListaMusculosSecundarios = New System.Windows.Forms.CheckedListBox()
        CType(Me.ptbPosicionFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbPosicionInicial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroButton1
        '
        Me.MetroButton1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroButton1.AutoSize = True
        Me.MetroButton1.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.MetroButton1.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.MetroButton1.Location = New System.Drawing.Point(640, 179)
        Me.MetroButton1.Margin = New System.Windows.Forms.Padding(16)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(40, 40)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroButton1.TabIndex = 92
        Me.MetroButton1.Text = "X"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroButton1.UseSelectable = True
        '
        'MetroLabel6
        '
        Me.MetroLabel6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel6.Location = New System.Drawing.Point(124, 292)
        Me.MetroLabel6.Margin = New System.Windows.Forms.Padding(0)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(180, 30)
        Me.MetroLabel6.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel6.TabIndex = 91
        Me.MetroLabel6.Text = "Músculo Secundarios"
        Me.MetroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLabel5
        '
        Me.MetroLabel5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel5.Location = New System.Drawing.Point(124, 217)
        Me.MetroLabel5.Margin = New System.Windows.Forms.Padding(0)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(147, 30)
        Me.MetroLabel5.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel5.TabIndex = 90
        Me.MetroLabel5.Text = "Músculo Principal"
        Me.MetroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtDescripcion.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtDescripcion.Lines = New String(-1) {}
        Me.txtDescripcion.Location = New System.Drawing.Point(430, 465)
        Me.txtDescripcion.MaxLength = 32767
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDescripcion.SelectedText = ""
        Me.txtDescripcion.Size = New System.Drawing.Size(250, 106)
        Me.txtDescripcion.TabIndex = 89
        Me.txtDescripcion.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtDescripcion.UseSelectable = True
        '
        'MetroLabel7
        '
        Me.MetroLabel7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel7.Location = New System.Drawing.Point(430, 432)
        Me.MetroLabel7.Margin = New System.Windows.Forms.Padding(0)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(147, 30)
        Me.MetroLabel7.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel7.TabIndex = 88
        Me.MetroLabel7.Text = "Descripción"
        Me.MetroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'txtErroresComunes
        '
        Me.txtErroresComunes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtErroresComunes.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtErroresComunes.Lines = New String(-1) {}
        Me.txtErroresComunes.Location = New System.Drawing.Point(715, 465)
        Me.txtErroresComunes.MaxLength = 32767
        Me.txtErroresComunes.Multiline = True
        Me.txtErroresComunes.Name = "txtErroresComunes"
        Me.txtErroresComunes.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtErroresComunes.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtErroresComunes.SelectedText = ""
        Me.txtErroresComunes.Size = New System.Drawing.Size(250, 106)
        Me.txtErroresComunes.TabIndex = 87
        Me.txtErroresComunes.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtErroresComunes.UseSelectable = True
        '
        'MetroLabel15
        '
        Me.MetroLabel15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel15.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel15.Location = New System.Drawing.Point(715, 432)
        Me.MetroLabel15.Margin = New System.Windows.Forms.Padding(0)
        Me.MetroLabel15.Name = "MetroLabel15"
        Me.MetroLabel15.Size = New System.Drawing.Size(147, 30)
        Me.MetroLabel15.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel15.TabIndex = 86
        Me.MetroLabel15.Text = "Errores Comunes"
        Me.MetroLabel15.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLabel4
        '
        Me.MetroLabel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel4.Location = New System.Drawing.Point(430, 146)
        Me.MetroLabel4.Margin = New System.Windows.Forms.Padding(0)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(220, 30)
        Me.MetroLabel4.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel4.TabIndex = 85
        Me.MetroLabel4.Text = "Fotografía Posición Final"
        Me.MetroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLabel3
        '
        Me.MetroLabel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel3.Location = New System.Drawing.Point(430, 75)
        Me.MetroLabel3.Margin = New System.Windows.Forms.Padding(0)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(133, 30)
        Me.MetroLabel3.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel3.TabIndex = 84
        Me.MetroLabel3.Text = "Posición Final"
        Me.MetroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'txtPosFinal
        '
        Me.txtPosFinal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPosFinal.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtPosFinal.Lines = New String(-1) {}
        Me.txtPosFinal.Location = New System.Drawing.Point(430, 108)
        Me.txtPosFinal.MaxLength = 32767
        Me.txtPosFinal.Name = "txtPosFinal"
        Me.txtPosFinal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPosFinal.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPosFinal.SelectedText = ""
        Me.txtPosFinal.Size = New System.Drawing.Size(250, 35)
        Me.txtPosFinal.TabIndex = 83
        Me.txtPosFinal.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtPosFinal.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.Location = New System.Drawing.Point(715, 146)
        Me.MetroLabel2.Margin = New System.Windows.Forms.Padding(0)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(220, 30)
        Me.MetroLabel2.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel2.TabIndex = 82
        Me.MetroLabel2.Text = "Fotografía Posición Inicial"
        Me.MetroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroButton3
        '
        Me.MetroButton3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroButton3.AutoSize = True
        Me.MetroButton3.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.MetroButton3.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.MetroButton3.Location = New System.Drawing.Point(925, 179)
        Me.MetroButton3.Margin = New System.Windows.Forms.Padding(16)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.Size = New System.Drawing.Size(40, 40)
        Me.MetroButton3.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroButton3.TabIndex = 81
        Me.MetroButton3.Text = "X"
        Me.MetroButton3.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroButton3.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(715, 75)
        Me.MetroLabel1.Margin = New System.Windows.Forms.Padding(0)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(133, 30)
        Me.MetroLabel1.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel1.TabIndex = 80
        Me.MetroLabel1.Text = "Posición Inicial"
        Me.MetroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'txtPosInicial
        '
        Me.txtPosInicial.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPosInicial.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtPosInicial.Lines = New String(-1) {}
        Me.txtPosInicial.Location = New System.Drawing.Point(715, 108)
        Me.txtPosInicial.MaxLength = 32767
        Me.txtPosInicial.Name = "txtPosInicial"
        Me.txtPosInicial.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPosInicial.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPosInicial.SelectedText = ""
        Me.txtPosInicial.Size = New System.Drawing.Size(250, 35)
        Me.txtPosInicial.TabIndex = 79
        Me.txtPosInicial.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtPosInicial.UseSelectable = True
        '
        'txtAlias
        '
        Me.txtAlias.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtAlias.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtAlias.Lines = New String(-1) {}
        Me.txtAlias.Location = New System.Drawing.Point(124, 179)
        Me.txtAlias.MaxLength = 32767
        Me.txtAlias.Name = "txtAlias"
        Me.txtAlias.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAlias.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtAlias.SelectedText = ""
        Me.txtAlias.Size = New System.Drawing.Size(250, 35)
        Me.txtAlias.TabIndex = 78
        Me.txtAlias.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtAlias.UseSelectable = True
        '
        'MetroLabel14
        '
        Me.MetroLabel14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel14.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel14.Location = New System.Drawing.Point(124, 146)
        Me.MetroLabel14.Margin = New System.Windows.Forms.Padding(0)
        Me.MetroLabel14.Name = "MetroLabel14"
        Me.MetroLabel14.Size = New System.Drawing.Size(100, 30)
        Me.MetroLabel14.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel14.TabIndex = 77
        Me.MetroLabel14.Text = "Alias"
        Me.MetroLabel14.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtNombre.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtNombre.Lines = New String(-1) {}
        Me.txtNombre.Location = New System.Drawing.Point(124, 108)
        Me.txtNombre.MaxLength = 32767
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNombre.SelectedText = ""
        Me.txtNombre.Size = New System.Drawing.Size(250, 35)
        Me.txtNombre.TabIndex = 76
        Me.txtNombre.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtNombre.UseSelectable = True
        '
        'MetroLabel13
        '
        Me.MetroLabel13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel13.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel13.Location = New System.Drawing.Point(124, 75)
        Me.MetroLabel13.Margin = New System.Windows.Forms.Padding(0)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(100, 30)
        Me.MetroLabel13.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel13.TabIndex = 75
        Me.MetroLabel13.Text = "Nombre "
        Me.MetroLabel13.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'cbListaMusculosPrincipales
        '
        Me.cbListaMusculosPrincipales.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbListaMusculosPrincipales.FontSize = MetroFramework.MetroComboBoxSize.Tall
        Me.cbListaMusculosPrincipales.ForeColor = System.Drawing.Color.YellowGreen
        Me.cbListaMusculosPrincipales.FormattingEnabled = True
        Me.cbListaMusculosPrincipales.ItemHeight = 29
        Me.cbListaMusculosPrincipales.Location = New System.Drawing.Point(124, 250)
        Me.cbListaMusculosPrincipales.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.cbListaMusculosPrincipales.Name = "cbListaMusculosPrincipales"
        Me.cbListaMusculosPrincipales.Size = New System.Drawing.Size(250, 35)
        Me.cbListaMusculosPrincipales.TabIndex = 73
        Me.cbListaMusculosPrincipales.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.cbListaMusculosPrincipales.UseSelectable = True
        '
        'ptbPosicionFinal
        '
        Me.ptbPosicionFinal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ptbPosicionFinal.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.ptbPosicionFinal.Location = New System.Drawing.Point(430, 179)
        Me.ptbPosicionFinal.Name = "ptbPosicionFinal"
        Me.ptbPosicionFinal.Size = New System.Drawing.Size(250, 250)
        Me.ptbPosicionFinal.TabIndex = 72
        Me.ptbPosicionFinal.TabStop = False
        '
        'ptbPosicionInicial
        '
        Me.ptbPosicionInicial.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ptbPosicionInicial.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.ptbPosicionInicial.Location = New System.Drawing.Point(715, 179)
        Me.ptbPosicionInicial.Name = "ptbPosicionInicial"
        Me.ptbPosicionInicial.Size = New System.Drawing.Size(250, 250)
        Me.ptbPosicionInicial.TabIndex = 71
        Me.ptbPosicionInicial.TabStop = False
        '
        'cbListaMusculosSecundarios
        '
        Me.cbListaMusculosSecundarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.cbListaMusculosSecundarios.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.cbListaMusculosSecundarios.FormattingEnabled = True
        Me.cbListaMusculosSecundarios.Location = New System.Drawing.Point(118, 325)
        Me.cbListaMusculosSecundarios.Name = "cbListaMusculosSecundarios"
        Me.cbListaMusculosSecundarios.Size = New System.Drawing.Size(250, 244)
        Me.cbListaMusculosSecundarios.TabIndex = 93
        '
        'FrmModificarEjercicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.cbListaMusculosSecundarios)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.txtErroresComunes)
        Me.Controls.Add(Me.MetroLabel15)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.txtPosFinal)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroButton3)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.txtPosInicial)
        Me.Controls.Add(Me.txtAlias)
        Me.Controls.Add(Me.MetroLabel14)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.MetroLabel13)
        Me.Controls.Add(Me.cbListaMusculosPrincipales)
        Me.Controls.Add(Me.ptbPosicionFinal)
        Me.Controls.Add(Me.ptbPosicionInicial)
        Me.Name = "FrmModificarEjercicio"
        Me.Size = New System.Drawing.Size(1088, 647)
        Me.Style = MetroFramework.MetroColorStyle.Purple
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        CType(Me.ptbPosicionFinal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbPosicionInicial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtDescripcion As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtErroresComunes As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel15 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtPosFinal As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroButton3 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtPosInicial As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtAlias As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel14 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNombre As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbListaMusculosPrincipales As MetroFramework.Controls.MetroComboBox
    Friend WithEvents ptbPosicionFinal As System.Windows.Forms.PictureBox
    Friend WithEvents ptbPosicionInicial As System.Windows.Forms.PictureBox
    Friend WithEvents cbListaMusculosSecundarios As System.Windows.Forms.CheckedListBox

End Class
