<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistrarMaquina
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRegistrarMaquina))
        Me.lblTipoDeMaquina = New MetroFramework.Controls.MetroLabel()
        Me.lblNumeroDeActivo = New MetroFramework.Controls.MetroLabel()
        Me.lblNumeroDeMaquina = New MetroFramework.Controls.MetroLabel()
        Me.btnGuardar = New MetroFramework.Controls.MetroButton()
        Me.btnCancelar = New MetroFramework.Controls.MetroButton()
        Me.txtNumeroDeActivo = New MetroFramework.Controls.MetroTextBox()
        Me.txtNumeroDeMaquina = New MetroFramework.Controls.MetroTextBox()
        Me.cmbTipoDeMaquina = New MetroFramework.Controls.MetroComboBox()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTipoDeMaquina
        '
        Me.lblTipoDeMaquina.AutoSize = True
        Me.lblTipoDeMaquina.Location = New System.Drawing.Point(127, 127)
        Me.lblTipoDeMaquina.Name = "lblTipoDeMaquina"
        Me.lblTipoDeMaquina.Size = New System.Drawing.Size(109, 19)
        Me.lblTipoDeMaquina.TabIndex = 0
        Me.lblTipoDeMaquina.Text = "Tipo de máquina"
        '
        'lblNumeroDeActivo
        '
        Me.lblNumeroDeActivo.AutoSize = True
        Me.lblNumeroDeActivo.Location = New System.Drawing.Point(127, 186)
        Me.lblNumeroDeActivo.Name = "lblNumeroDeActivo"
        Me.lblNumeroDeActivo.Size = New System.Drawing.Size(115, 19)
        Me.lblNumeroDeActivo.TabIndex = 0
        Me.lblNumeroDeActivo.Text = "Número de activo"
        '
        'lblNumeroDeMaquina
        '
        Me.lblNumeroDeMaquina.AutoSize = True
        Me.lblNumeroDeMaquina.Location = New System.Drawing.Point(127, 245)
        Me.lblNumeroDeMaquina.Name = "lblNumeroDeMaquina"
        Me.lblNumeroDeMaquina.Size = New System.Drawing.Size(132, 19)
        Me.lblNumeroDeMaquina.TabIndex = 0
        Me.lblNumeroDeMaquina.Text = "Número de máquina"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(433, 45)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 3
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseSelectable = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(526, 45)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseSelectable = True
        '
        'txtNumeroDeActivo
        '
        Me.txtNumeroDeActivo.Lines = New String(-1) {}
        Me.txtNumeroDeActivo.Location = New System.Drawing.Point(308, 184)
        Me.txtNumeroDeActivo.MaxLength = 32767
        Me.txtNumeroDeActivo.Name = "txtNumeroDeActivo"
        Me.txtNumeroDeActivo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumeroDeActivo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNumeroDeActivo.SelectedText = ""
        Me.txtNumeroDeActivo.Size = New System.Drawing.Size(200, 23)
        Me.txtNumeroDeActivo.TabIndex = 2
        Me.txtNumeroDeActivo.UseSelectable = True
        '
        'txtNumeroDeMaquina
        '
        Me.txtNumeroDeMaquina.Lines = New String(-1) {}
        Me.txtNumeroDeMaquina.Location = New System.Drawing.Point(308, 243)
        Me.txtNumeroDeMaquina.MaxLength = 32767
        Me.txtNumeroDeMaquina.Name = "txtNumeroDeMaquina"
        Me.txtNumeroDeMaquina.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumeroDeMaquina.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNumeroDeMaquina.SelectedText = ""
        Me.txtNumeroDeMaquina.Size = New System.Drawing.Size(200, 23)
        Me.txtNumeroDeMaquina.TabIndex = 3
        Me.txtNumeroDeMaquina.UseSelectable = True
        '
        'cmbTipoDeMaquina
        '
        Me.cmbTipoDeMaquina.FormattingEnabled = True
        Me.cmbTipoDeMaquina.ItemHeight = 23
        Me.cmbTipoDeMaquina.Location = New System.Drawing.Point(308, 122)
        Me.cmbTipoDeMaquina.Name = "cmbTipoDeMaquina"
        Me.cmbTipoDeMaquina.Size = New System.Drawing.Size(200, 29)
        Me.cmbTipoDeMaquina.TabIndex = 1
        Me.cmbTipoDeMaquina.UseSelectable = True
        '
        'ErrorProvider
        '
        Me.ErrorProvider.BlinkRate = 0
        Me.ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider.ContainerControl = Me
        Me.ErrorProvider.Icon = CType(resources.GetObject("ErrorProvider.Icon"), System.Drawing.Icon)
        '
        'FrmRegistrarMaquina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cmbTipoDeMaquina)
        Me.Controls.Add(Me.txtNumeroDeMaquina)
        Me.Controls.Add(Me.txtNumeroDeActivo)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.lblNumeroDeMaquina)
        Me.Controls.Add(Me.lblNumeroDeActivo)
        Me.Controls.Add(Me.lblTipoDeMaquina)
        Me.Name = "FrmRegistrarMaquina"
        Me.Size = New System.Drawing.Size(650, 400)
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTipoDeMaquina As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblNumeroDeActivo As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblNumeroDeMaquina As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnGuardar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCancelar As MetroFramework.Controls.MetroButton
    Friend WithEvents txtNumeroDeActivo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtNumeroDeMaquina As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cmbTipoDeMaquina As MetroFramework.Controls.MetroComboBox
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider

End Class
