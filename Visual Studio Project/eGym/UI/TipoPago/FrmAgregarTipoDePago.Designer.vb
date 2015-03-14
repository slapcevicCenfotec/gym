<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAgregarTipoDePago
    Inherits System.Windows.Forms.UserControl

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
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.txtNombre = New MetroFramework.Controls.MetroTextBox()
        Me.txtMonto = New MetroFramework.Controls.MetroTextBox()
        Me.txtDuracion = New MetroFramework.Controls.MetroTextBox()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.lblError = New MetroFramework.Controls.MetroLabel()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(12, 15)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(141, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Agregar Tipo de Pago"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(102, 82)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(62, 19)
        Me.MetroLabel2.TabIndex = 1
        Me.MetroLabel2.Text = "Nombre:"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(113, 126)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(51, 19)
        Me.MetroLabel3.TabIndex = 2
        Me.MetroLabel3.Text = "Monto:"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(75, 172)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(89, 19)
        Me.MetroLabel4.TabIndex = 3
        Me.MetroLabel4.Text = "Diracion(Dias)"
        '
        'txtNombre
        '
        Me.txtNombre.Lines = New String(-1) {}
        Me.txtNombre.Location = New System.Drawing.Point(200, 78)
        Me.txtNombre.MaxLength = 32767
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNombre.SelectedText = ""
        Me.txtNombre.Size = New System.Drawing.Size(196, 23)
        Me.txtNombre.TabIndex = 4
        Me.txtNombre.UseSelectable = True
        '
        'txtMonto
        '
        Me.txtMonto.Lines = New String(-1) {}
        Me.txtMonto.Location = New System.Drawing.Point(200, 122)
        Me.txtMonto.MaxLength = 32767
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMonto.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMonto.SelectedText = ""
        Me.txtMonto.Size = New System.Drawing.Size(196, 23)
        Me.txtMonto.TabIndex = 5
        Me.txtMonto.UseSelectable = True
        '
        'txtDuracion
        '
        Me.txtDuracion.Lines = New String(-1) {}
        Me.txtDuracion.Location = New System.Drawing.Point(200, 168)
        Me.txtDuracion.MaxLength = 32767
        Me.txtDuracion.Name = "txtDuracion"
        Me.txtDuracion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDuracion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDuracion.SelectedText = ""
        Me.txtDuracion.Size = New System.Drawing.Size(196, 23)
        Me.txtDuracion.TabIndex = 6
        Me.txtDuracion.UseSelectable = True
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(200, 235)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 23)
        Me.MetroButton1.TabIndex = 7
        Me.MetroButton1.Text = "Registrar"
        Me.MetroButton1.UseSelectable = True
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(321, 235)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(75, 23)
        Me.MetroButton2.TabIndex = 8
        Me.MetroButton2.Text = "Cancelar"
        Me.MetroButton2.UseSelectable = True
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(75, 204)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(39, 19)
        Me.lblError.TabIndex = 9
        Me.lblError.Text = "Error"
        Me.lblError.UseCustomForeColor = True
        Me.lblError.Visible = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider1.ContainerControl = Me
        '
        'FrmAgregarTipoDePago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.txtDuracion)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Name = "FrmAgregarTipoDePago"
        Me.Size = New System.Drawing.Size(801, 369)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNombre As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtMonto As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtDuracion As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents lblError As MetroFramework.Controls.MetroLabel
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider

End Class
