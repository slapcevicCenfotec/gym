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
        Me.btnIngresar = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txtNombreUsuario = New MetroFramework.Controls.MetroTextBox()
        Me.txtContrasena = New MetroFramework.Controls.MetroTextBox()
        Me.lblError = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(252, 114)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(75, 23)
        Me.btnIngresar.TabIndex = 0
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 60)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(127, 19)
        Me.MetroLabel1.TabIndex = 1
        Me.MetroLabel1.Text = "Nombre de usuario:"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(23, 89)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(78, 19)
        Me.MetroLabel2.TabIndex = 2
        Me.MetroLabel2.Text = "Contraseña:"
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.Lines = New String(-1) {}
        Me.txtNombreUsuario.Location = New System.Drawing.Point(175, 56)
        Me.txtNombreUsuario.MaxLength = 32767
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNombreUsuario.SelectedText = ""
        Me.txtNombreUsuario.Size = New System.Drawing.Size(152, 23)
        Me.txtNombreUsuario.TabIndex = 3
        Me.txtNombreUsuario.UseCustomBackColor = True
        Me.txtNombreUsuario.UseCustomForeColor = True
        Me.txtNombreUsuario.UseSelectable = True
        '
        'txtContrasena
        '
        Me.txtContrasena.Lines = New String(-1) {}
        Me.txtContrasena.Location = New System.Drawing.Point(175, 85)
        Me.txtContrasena.MaxLength = 32767
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContrasena.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtContrasena.SelectedText = ""
        Me.txtContrasena.Size = New System.Drawing.Size(152, 23)
        Me.txtContrasena.TabIndex = 4
        Me.txtContrasena.UseCustomBackColor = True
        Me.txtContrasena.UseCustomForeColor = True
        Me.txtContrasena.UseSelectable = True
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(18, 144)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(39, 19)
        Me.lblError.TabIndex = 5
        Me.lblError.Text = "Error"
        Me.lblError.UseCustomForeColor = True
        Me.lblError.Visible = False
        '
        'frmIniciarSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 200)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.txtContrasena)
        Me.Controls.Add(Me.txtNombreUsuario)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.btnIngresar)
        Me.Name = "frmIniciarSesion"
        Me.Text = "eGym"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnIngresar As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNombreUsuario As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtContrasena As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblError As MetroFramework.Controls.MetroLabel
End Class
