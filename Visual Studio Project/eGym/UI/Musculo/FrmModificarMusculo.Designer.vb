﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModificarMusculo
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
        Me.btnModificar = New MetroFramework.Controls.MetroButton()
        Me.btnEliminar = New MetroFramework.Controls.MetroButton()
        Me.txtIrrigacion = New MetroFramework.Controls.MetroTextBox()
        Me.txtInervacion = New MetroFramework.Controls.MetroTextBox()
        Me.txtInserccion = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.txtOrigen = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.txtUbicacion = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.txtNombre = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnModificar.AutoSize = True
        Me.btnModificar.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnModificar.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.btnModificar.Location = New System.Drawing.Point(16, 301)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(16)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(150, 30)
        Me.btnModificar.Style = MetroFramework.MetroColorStyle.Purple
        Me.btnModificar.TabIndex = 57
        Me.btnModificar.Text = "Cancelar"
        Me.btnModificar.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnModificar.UseSelectable = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.AutoSize = True
        Me.btnEliminar.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnEliminar.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.btnEliminar.Location = New System.Drawing.Point(466, 301)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(16)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(150, 30)
        Me.btnEliminar.Style = MetroFramework.MetroColorStyle.Purple
        Me.btnEliminar.TabIndex = 56
        Me.btnEliminar.Text = "Guardar"
        Me.btnEliminar.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnEliminar.UseSelectable = True
        '
        'txtIrrigacion
        '
        Me.txtIrrigacion.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtIrrigacion.Lines = New String(-1) {}
        Me.txtIrrigacion.Location = New System.Drawing.Point(366, 176)
        Me.txtIrrigacion.MaxLength = 32767
        Me.txtIrrigacion.Name = "txtIrrigacion"
        Me.txtIrrigacion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIrrigacion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtIrrigacion.SelectedText = ""
        Me.txtIrrigacion.Size = New System.Drawing.Size(250, 35)
        Me.txtIrrigacion.TabIndex = 55
        Me.txtIrrigacion.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtIrrigacion.UseSelectable = True
        '
        'txtInervacion
        '
        Me.txtInervacion.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtInervacion.Lines = New String(-1) {}
        Me.txtInervacion.Location = New System.Drawing.Point(366, 110)
        Me.txtInervacion.MaxLength = 32767
        Me.txtInervacion.Name = "txtInervacion"
        Me.txtInervacion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtInervacion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtInervacion.SelectedText = ""
        Me.txtInervacion.Size = New System.Drawing.Size(250, 35)
        Me.txtInervacion.TabIndex = 54
        Me.txtInervacion.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtInervacion.UseSelectable = True
        '
        'txtInserccion
        '
        Me.txtInserccion.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtInserccion.Lines = New String(-1) {}
        Me.txtInserccion.Location = New System.Drawing.Point(366, 44)
        Me.txtInserccion.MaxLength = 32767
        Me.txtInserccion.Name = "txtInserccion"
        Me.txtInserccion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtInserccion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtInserccion.SelectedText = ""
        Me.txtInserccion.Size = New System.Drawing.Size(250, 35)
        Me.txtInserccion.TabIndex = 53
        Me.txtInserccion.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtInserccion.UseSelectable = True
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel6.Location = New System.Drawing.Point(366, 82)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(83, 25)
        Me.MetroLabel6.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel6.TabIndex = 52
        Me.MetroLabel6.Text = "Irrigación"
        Me.MetroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel6.UseCustomBackColor = True
        '
        'txtOrigen
        '
        Me.txtOrigen.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtOrigen.Lines = New String(-1) {}
        Me.txtOrigen.Location = New System.Drawing.Point(16, 176)
        Me.txtOrigen.MaxLength = 32767
        Me.txtOrigen.Name = "txtOrigen"
        Me.txtOrigen.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtOrigen.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtOrigen.SelectedText = ""
        Me.txtOrigen.Size = New System.Drawing.Size(250, 35)
        Me.txtOrigen.TabIndex = 51
        Me.txtOrigen.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtOrigen.UseSelectable = True
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel5.Location = New System.Drawing.Point(366, 148)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(90, 25)
        Me.MetroLabel5.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel5.TabIndex = 50
        Me.MetroLabel5.Text = "Inervación"
        Me.MetroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel5.UseCustomBackColor = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel4.Location = New System.Drawing.Point(366, 16)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(88, 25)
        Me.MetroLabel4.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel4.TabIndex = 49
        Me.MetroLabel4.Text = "Insercción"
        Me.MetroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel4.UseCustomBackColor = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel3.Location = New System.Drawing.Point(16, 148)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(65, 25)
        Me.MetroLabel3.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel3.TabIndex = 48
        Me.MetroLabel3.Text = "Origen"
        Me.MetroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel3.UseCustomBackColor = True
        '
        'txtUbicacion
        '
        Me.txtUbicacion.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtUbicacion.Lines = New String(-1) {}
        Me.txtUbicacion.Location = New System.Drawing.Point(16, 110)
        Me.txtUbicacion.MaxLength = 32767
        Me.txtUbicacion.Name = "txtUbicacion"
        Me.txtUbicacion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUbicacion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtUbicacion.SelectedText = ""
        Me.txtUbicacion.Size = New System.Drawing.Size(250, 35)
        Me.txtUbicacion.TabIndex = 47
        Me.txtUbicacion.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtUbicacion.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(16, 82)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(87, 25)
        Me.MetroLabel1.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel1.TabIndex = 46
        Me.MetroLabel1.Text = "Ubicación"
        Me.MetroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel1.UseCustomBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtNombre.Lines = New String(-1) {}
        Me.txtNombre.Location = New System.Drawing.Point(16, 44)
        Me.txtNombre.MaxLength = 32767
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNombre.SelectedText = ""
        Me.txtNombre.Size = New System.Drawing.Size(250, 35)
        Me.txtNombre.TabIndex = 45
        Me.txtNombre.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtNombre.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.Location = New System.Drawing.Point(16, 16)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(75, 25)
        Me.MetroLabel2.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel2.TabIndex = 44
        Me.MetroLabel2.Text = "Nombre"
        Me.MetroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel2.UseCustomBackColor = True
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.MetroPanel1.Controls.Add(Me.btnModificar)
        Me.MetroPanel1.Controls.Add(Me.txtIrrigacion)
        Me.MetroPanel1.Controls.Add(Me.btnEliminar)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel2)
        Me.MetroPanel1.Controls.Add(Me.txtInervacion)
        Me.MetroPanel1.Controls.Add(Me.txtNombre)
        Me.MetroPanel1.Controls.Add(Me.txtInserccion)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel1)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel6)
        Me.MetroPanel1.Controls.Add(Me.txtUbicacion)
        Me.MetroPanel1.Controls.Add(Me.txtOrigen)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel3)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel5)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel4)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(100, 78)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(632, 347)
        Me.MetroPanel1.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroPanel1.TabIndex = 58
        Me.MetroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroPanel1.UseCustomBackColor = True
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'MetroLabel7
        '
        Me.MetroLabel7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel7.Location = New System.Drawing.Point(100, 50)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(187, 25)
        Me.MetroLabel7.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel7.TabIndex = 58
        Me.MetroLabel7.Text = "MODIFICAR MUSCULO"
        Me.MetroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel7.UseCustomBackColor = True
        '
        'FrmModificarMusculo
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Name = "FrmModificarMusculo"
        Me.Size = New System.Drawing.Size(833, 474)
        Me.Style = MetroFramework.MetroColorStyle.Purple
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnModificar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnEliminar As MetroFramework.Controls.MetroButton
    Friend WithEvents txtIrrigacion As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtInervacion As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtInserccion As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtOrigen As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtUbicacion As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNombre As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel

End Class
