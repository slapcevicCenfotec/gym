<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistrarMusculo
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
        Me.components = New System.ComponentModel.Container()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
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
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnModificar.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnModificar.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.btnModificar.Location = New System.Drawing.Point(761, 34)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(15, 15, 0, 0)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(133, 30)
        Me.btnModificar.Style = MetroFramework.MetroColorStyle.Purple
        Me.btnModificar.TabIndex = 83
        Me.btnModificar.Text = "Cancelar"
        Me.btnModificar.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnModificar.UseSelectable = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEliminar.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnEliminar.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.btnEliminar.Location = New System.Drawing.Point(611, 34)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(15, 15, 0, 0)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(135, 30)
        Me.btnEliminar.Style = MetroFramework.MetroColorStyle.Purple
        Me.btnEliminar.TabIndex = 82
        Me.btnEliminar.Text = "Guardar"
        Me.btnEliminar.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnEliminar.UseSelectable = True
        '
        'txtIrrigacion
        '
        Me.txtIrrigacion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtIrrigacion.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtIrrigacion.Lines = New String(-1) {}
        Me.txtIrrigacion.Location = New System.Drawing.Point(321, 305)
        Me.txtIrrigacion.Margin = New System.Windows.Forms.Padding(15, 15, 0, 0)
        Me.txtIrrigacion.MaxLength = 32767
        Me.txtIrrigacion.Name = "txtIrrigacion"
        Me.txtIrrigacion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIrrigacion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtIrrigacion.SelectedText = ""
        Me.txtIrrigacion.Size = New System.Drawing.Size(196, 29)
        Me.txtIrrigacion.TabIndex = 81
        Me.txtIrrigacion.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtIrrigacion.UseSelectable = True
        '
        'txtInervacion
        '
        Me.txtInervacion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtInervacion.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtInervacion.Lines = New String(-1) {}
        Me.txtInervacion.Location = New System.Drawing.Point(321, 205)
        Me.txtInervacion.Margin = New System.Windows.Forms.Padding(15, 15, 0, 0)
        Me.txtInervacion.MaxLength = 32767
        Me.txtInervacion.Name = "txtInervacion"
        Me.txtInervacion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtInervacion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtInervacion.SelectedText = ""
        Me.txtInervacion.Size = New System.Drawing.Size(196, 29)
        Me.txtInervacion.TabIndex = 80
        Me.txtInervacion.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtInervacion.UseSelectable = True
        '
        'txtInserccion
        '
        Me.txtInserccion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtInserccion.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtInserccion.Lines = New String(-1) {}
        Me.txtInserccion.Location = New System.Drawing.Point(321, 102)
        Me.txtInserccion.Margin = New System.Windows.Forms.Padding(15, 15, 0, 0)
        Me.txtInserccion.MaxLength = 32767
        Me.txtInserccion.Name = "txtInserccion"
        Me.txtInserccion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtInserccion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtInserccion.SelectedText = ""
        Me.txtInserccion.Size = New System.Drawing.Size(196, 29)
        Me.txtInserccion.TabIndex = 79
        Me.txtInserccion.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtInserccion.UseSelectable = True
        '
        'MetroLabel6
        '
        Me.MetroLabel6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel6.Location = New System.Drawing.Point(321, 160)
        Me.MetroLabel6.Margin = New System.Windows.Forms.Padding(0)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(187, 30)
        Me.MetroLabel6.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel6.TabIndex = 78
        Me.MetroLabel6.Text = "Irrigación"
        Me.MetroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'txtOrigen
        '
        Me.txtOrigen.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtOrigen.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtOrigen.Lines = New String(-1) {}
        Me.txtOrigen.Location = New System.Drawing.Point(74, 305)
        Me.txtOrigen.Margin = New System.Windows.Forms.Padding(15, 15, 0, 0)
        Me.txtOrigen.MaxLength = 32767
        Me.txtOrigen.Name = "txtOrigen"
        Me.txtOrigen.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtOrigen.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtOrigen.SelectedText = ""
        Me.txtOrigen.Size = New System.Drawing.Size(178, 29)
        Me.txtOrigen.TabIndex = 77
        Me.txtOrigen.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtOrigen.UseSelectable = True
        '
        'MetroLabel5
        '
        Me.MetroLabel5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel5.Location = New System.Drawing.Point(321, 266)
        Me.MetroLabel5.Margin = New System.Windows.Forms.Padding(0)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(238, 30)
        Me.MetroLabel5.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel5.TabIndex = 76
        Me.MetroLabel5.Text = "Inervación"
        Me.MetroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLabel4
        '
        Me.MetroLabel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel4.Location = New System.Drawing.Point(321, 57)
        Me.MetroLabel4.Margin = New System.Windows.Forms.Padding(0)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(216, 30)
        Me.MetroLabel4.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel4.TabIndex = 75
        Me.MetroLabel4.Text = "Insercción"
        Me.MetroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroLabel3
        '
        Me.MetroLabel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel3.Location = New System.Drawing.Point(74, 266)
        Me.MetroLabel3.Margin = New System.Windows.Forms.Padding(0)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(238, 24)
        Me.MetroLabel3.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel3.TabIndex = 74
        Me.MetroLabel3.Text = "Origen"
        Me.MetroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'txtUbicacion
        '
        Me.txtUbicacion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtUbicacion.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtUbicacion.Lines = New String(-1) {}
        Me.txtUbicacion.Location = New System.Drawing.Point(74, 205)
        Me.txtUbicacion.Margin = New System.Windows.Forms.Padding(15, 15, 0, 0)
        Me.txtUbicacion.MaxLength = 32767
        Me.txtUbicacion.Name = "txtUbicacion"
        Me.txtUbicacion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUbicacion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtUbicacion.SelectedText = ""
        Me.txtUbicacion.Size = New System.Drawing.Size(178, 29)
        Me.txtUbicacion.TabIndex = 73
        Me.txtUbicacion.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtUbicacion.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(74, 166)
        Me.MetroLabel1.Margin = New System.Windows.Forms.Padding(0)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(238, 24)
        Me.MetroLabel1.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel1.TabIndex = 72
        Me.MetroLabel1.Text = "Ubicación"
        Me.MetroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtNombre.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtNombre.Lines = New String(-1) {}
        Me.txtNombre.Location = New System.Drawing.Point(74, 102)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(15, 15, 0, 0)
        Me.txtNombre.MaxLength = 32767
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNombre.SelectedText = ""
        Me.txtNombre.Size = New System.Drawing.Size(178, 29)
        Me.txtNombre.TabIndex = 71
        Me.txtNombre.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtNombre.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.Location = New System.Drawing.Point(74, 66)
        Me.MetroLabel2.Margin = New System.Windows.Forms.Padding(0)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(209, 24)
        Me.MetroLabel2.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel2.TabIndex = 70
        Me.MetroLabel2.Text = "Nombre"
        Me.MetroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroPanel1
        '
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(52, 57)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(541, 322)
        Me.MetroPanel1.TabIndex = 84
        Me.MetroPanel1.UseCustomBackColor = True
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'FrmRegistrarMusculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.txtIrrigacion)
        Me.Controls.Add(Me.txtInervacion)
        Me.Controls.Add(Me.txtInserccion)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.txtOrigen)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.txtUbicacion)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Name = "FrmRegistrarMusculo"
        Me.Size = New System.Drawing.Size(927, 457)
        Me.Style = MetroFramework.MetroColorStyle.Purple
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
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

End Class
