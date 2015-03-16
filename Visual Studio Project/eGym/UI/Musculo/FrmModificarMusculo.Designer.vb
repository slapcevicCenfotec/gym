<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmModificarMusculo))
        Me.btnCancelar = New MetroFramework.Controls.MetroButton()
        Me.btnGuardar = New MetroFramework.Controls.MetroButton()
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
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel3 = New MetroFramework.Controls.MetroPanel()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroPanel2.SuspendLayout()
        Me.MetroPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.AutoSize = True
        Me.btnCancelar.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnCancelar.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.btnCancelar.Location = New System.Drawing.Point(16, 357)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(16)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(150, 30)
        Me.btnCancelar.Style = MetroFramework.MetroColorStyle.Purple
        Me.btnCancelar.TabIndex = 57
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnCancelar.UseSelectable = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.AutoSize = True
        Me.btnGuardar.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnGuardar.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.btnGuardar.Location = New System.Drawing.Point(466, 357)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(16)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(150, 30)
        Me.btnGuardar.Style = MetroFramework.MetroColorStyle.Purple
        Me.btnGuardar.TabIndex = 56
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnGuardar.UseSelectable = True
        '
        'txtIrrigacion
        '
        Me.txtIrrigacion.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtIrrigacion.Lines = New String(-1) {}
        Me.txtIrrigacion.Location = New System.Drawing.Point(366, 201)
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
        Me.txtInervacion.Location = New System.Drawing.Point(366, 135)
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
        Me.txtInserccion.Location = New System.Drawing.Point(366, 69)
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
        Me.MetroLabel6.Location = New System.Drawing.Point(366, 107)
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
        Me.txtOrigen.Location = New System.Drawing.Point(16, 201)
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
        Me.MetroLabel5.Location = New System.Drawing.Point(366, 173)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(91, 25)
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
        Me.MetroLabel4.Location = New System.Drawing.Point(366, 41)
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
        Me.MetroLabel3.Location = New System.Drawing.Point(16, 173)
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
        Me.txtUbicacion.Location = New System.Drawing.Point(16, 135)
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
        Me.MetroLabel1.Location = New System.Drawing.Point(16, 107)
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
        Me.txtNombre.Location = New System.Drawing.Point(16, 69)
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
        Me.MetroLabel2.Location = New System.Drawing.Point(16, 41)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(75, 25)
        Me.MetroLabel2.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel2.TabIndex = 44
        Me.MetroLabel2.Text = "Nombre"
        Me.MetroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel2.UseCustomBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.Icon = CType(resources.GetObject("ErrorProvider1.Icon"), System.Drawing.Icon)
        '
        'MetroPanel2
        '
        Me.MetroPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MetroPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.MetroPanel2.Controls.Add(Me.btnGuardar)
        Me.MetroPanel2.Controls.Add(Me.btnCancelar)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel8)
        Me.MetroPanel2.Controls.Add(Me.MetroPanel3)
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(163, 30)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(632, 403)
        Me.MetroPanel2.TabIndex = 63
        Me.MetroPanel2.UseCustomBackColor = True
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'MetroLabel8
        '
        Me.MetroLabel8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.MetroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MetroLabel8.Location = New System.Drawing.Point(0, 16)
        Me.MetroLabel8.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(186, 25)
        Me.MetroLabel8.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLabel8.TabIndex = 58
        Me.MetroLabel8.Text = "MODIFICAR MÚSCULO"
        Me.MetroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel8.UseCustomBackColor = True
        '
        'MetroPanel3
        '
        Me.MetroPanel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroPanel3.AutoScroll = True
        Me.MetroPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.MetroPanel3.Controls.Add(Me.MetroLabel2)
        Me.MetroPanel3.Controls.Add(Me.txtIrrigacion)
        Me.MetroPanel3.Controls.Add(Me.MetroLabel4)
        Me.MetroPanel3.Controls.Add(Me.MetroLabel5)
        Me.MetroPanel3.Controls.Add(Me.txtInervacion)
        Me.MetroPanel3.Controls.Add(Me.MetroLabel3)
        Me.MetroPanel3.Controls.Add(Me.txtNombre)
        Me.MetroPanel3.Controls.Add(Me.txtOrigen)
        Me.MetroPanel3.Controls.Add(Me.txtInserccion)
        Me.MetroPanel3.Controls.Add(Me.txtUbicacion)
        Me.MetroPanel3.Controls.Add(Me.MetroLabel1)
        Me.MetroPanel3.Controls.Add(Me.MetroLabel6)
        Me.MetroPanel3.HorizontalScrollbar = True
        Me.MetroPanel3.HorizontalScrollbarBarColor = True
        Me.MetroPanel3.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel3.HorizontalScrollbarSize = 10
        Me.MetroPanel3.Location = New System.Drawing.Point(0, 60)
        Me.MetroPanel3.Margin = New System.Windows.Forms.Padding(3, 67, 3, 67)
        Me.MetroPanel3.Name = "MetroPanel3"
        Me.MetroPanel3.Size = New System.Drawing.Size(632, 278)
        Me.MetroPanel3.TabIndex = 27
        Me.MetroPanel3.UseCustomBackColor = True
        Me.MetroPanel3.VerticalScrollbar = True
        Me.MetroPanel3.VerticalScrollbarBarColor = True
        Me.MetroPanel3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel3.VerticalScrollbarSize = 10
        '
        'FrmModificarMusculo
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.MetroPanel2)
        Me.Name = "FrmModificarMusculo"
        Me.Size = New System.Drawing.Size(960, 695)
        Me.Style = MetroFramework.MetroColorStyle.Purple
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroPanel2.ResumeLayout(False)
        Me.MetroPanel2.PerformLayout()
        Me.MetroPanel3.ResumeLayout(False)
        Me.MetroPanel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCancelar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnGuardar As MetroFramework.Controls.MetroButton
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
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroPanel3 As MetroFramework.Controls.MetroPanel

End Class
