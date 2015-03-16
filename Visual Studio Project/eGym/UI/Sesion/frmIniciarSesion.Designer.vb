<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIniciarSesion
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIniciarSesion))
        Me.btnIngresar = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txtNombreUsuario = New MetroFramework.Controls.MetroTextBox()
        Me.txtContrasena = New MetroFramework.Controls.MetroTextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.btnCancelar = New MetroFramework.Controls.MetroButton()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnIngresar
        '
        Me.btnIngresar.AutoSize = True
        Me.btnIngresar.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnIngresar.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btnIngresar.Location = New System.Drawing.Point(399, 186)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(100, 35)
        Me.btnIngresar.TabIndex = 3
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnIngresar.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.Location = New System.Drawing.Point(64, 140)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(98, 25)
        Me.MetroLabel2.TabIndex = 2
        Me.MetroLabel2.Text = "Contraseña"
        Me.MetroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtNombreUsuario.Lines = New String() {"dannye629@gmail.com"}
        Me.txtNombreUsuario.Location = New System.Drawing.Point(249, 84)
        Me.txtNombreUsuario.MaxLength = 32767
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNombreUsuario.SelectedText = ""
        Me.txtNombreUsuario.Size = New System.Drawing.Size(250, 35)
        Me.txtNombreUsuario.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtNombreUsuario.TabIndex = 1
        Me.txtNombreUsuario.Text = "dannye629@gmail.com"
        Me.txtNombreUsuario.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtNombreUsuario.UseSelectable = True
        '
        'txtContrasena
        '
        Me.txtContrasena.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtContrasena.Lines = New String() {"danny"}
        Me.txtContrasena.Location = New System.Drawing.Point(249, 135)
        Me.txtContrasena.MaxLength = 32767
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtContrasena.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtContrasena.SelectedText = ""
        Me.txtContrasena.Size = New System.Drawing.Size(250, 35)
        Me.txtContrasena.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtContrasena.TabIndex = 2
        Me.txtContrasena.Text = "danny"
        Me.txtContrasena.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtContrasena.UseSelectable = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkRate = 0
        Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.Icon = CType(resources.GetObject("ErrorProvider1.Icon"), System.Drawing.Icon)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(64, 89)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(160, 25)
        Me.MetroLabel1.TabIndex = 1
        Me.MetroLabel1.Text = "Nombre de usuario"
        Me.MetroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'btnCancelar
        '
        Me.btnCancelar.AutoSize = True
        Me.btnCancelar.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnCancelar.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btnCancelar.Location = New System.Drawing.Point(64, 186)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 35)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnCancelar.UseSelectable = True
        '
        'frmIniciarSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 243)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.txtContrasena)
        Me.Controls.Add(Me.txtNombreUsuario)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.btnIngresar)
        Me.MaximizeBox = False
        Me.Name = "frmIniciarSesion"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Purple
        Me.Text = "eGym"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnIngresar As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNombreUsuario As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtContrasena As MetroFramework.Controls.MetroTextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnCancelar As MetroFramework.Controls.MetroButton
End Class
