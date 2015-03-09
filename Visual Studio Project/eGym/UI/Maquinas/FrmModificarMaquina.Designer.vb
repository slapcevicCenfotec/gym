<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModificarMaquina
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
        Me.lblValidarNumeroMaquina = New MetroFramework.Controls.MetroLabel()
        Me.lblValidarNumeroActivo = New MetroFramework.Controls.MetroLabel()
        Me.lblValidarTipoDeMaquina = New MetroFramework.Controls.MetroLabel()
        Me.cmbTipoDeMaquina = New MetroFramework.Controls.MetroComboBox()
        Me.txtNumeroDeMaquina = New MetroFramework.Controls.MetroTextBox()
        Me.txtNumeroDeActivo = New MetroFramework.Controls.MetroTextBox()
        Me.btnCancelar = New MetroFramework.Controls.MetroButton()
        Me.btnGuardar = New MetroFramework.Controls.MetroButton()
        Me.lblNumeroDeMaquina = New MetroFramework.Controls.MetroLabel()
        Me.lblNumeroDeActivo = New MetroFramework.Controls.MetroLabel()
        Me.lblTipoDeMaquina = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'lblValidarNumeroMaquina
        '
        Me.lblValidarNumeroMaquina.AutoSize = True
        Me.lblValidarNumeroMaquina.BackColor = System.Drawing.Color.Transparent
        Me.lblValidarNumeroMaquina.ForeColor = System.Drawing.Color.Red
        Me.lblValidarNumeroMaquina.Location = New System.Drawing.Point(368, 279)
        Me.lblValidarNumeroMaquina.Name = "lblValidarNumeroMaquina"
        Me.lblValidarNumeroMaquina.Size = New System.Drawing.Size(0, 0)
        Me.lblValidarNumeroMaquina.TabIndex = 5
        Me.lblValidarNumeroMaquina.UseCustomBackColor = True
        Me.lblValidarNumeroMaquina.UseCustomForeColor = True
        '
        'lblValidarNumeroActivo
        '
        Me.lblValidarNumeroActivo.AutoSize = True
        Me.lblValidarNumeroActivo.BackColor = System.Drawing.Color.Transparent
        Me.lblValidarNumeroActivo.ForeColor = System.Drawing.Color.Red
        Me.lblValidarNumeroActivo.Location = New System.Drawing.Point(368, 210)
        Me.lblValidarNumeroActivo.Name = "lblValidarNumeroActivo"
        Me.lblValidarNumeroActivo.Size = New System.Drawing.Size(0, 0)
        Me.lblValidarNumeroActivo.TabIndex = 6
        Me.lblValidarNumeroActivo.UseCustomBackColor = True
        Me.lblValidarNumeroActivo.UseCustomForeColor = True
        '
        'lblValidarTipoDeMaquina
        '
        Me.lblValidarTipoDeMaquina.AutoSize = True
        Me.lblValidarTipoDeMaquina.BackColor = System.Drawing.Color.Transparent
        Me.lblValidarTipoDeMaquina.ForeColor = System.Drawing.Color.Red
        Me.lblValidarTipoDeMaquina.Location = New System.Drawing.Point(368, 154)
        Me.lblValidarTipoDeMaquina.Name = "lblValidarTipoDeMaquina"
        Me.lblValidarTipoDeMaquina.Size = New System.Drawing.Size(0, 0)
        Me.lblValidarTipoDeMaquina.TabIndex = 7
        Me.lblValidarTipoDeMaquina.UseCustomBackColor = True
        Me.lblValidarTipoDeMaquina.UseCustomForeColor = True
        '
        'cmbTipoDeMaquina
        '
        Me.cmbTipoDeMaquina.FormattingEnabled = True
        Me.cmbTipoDeMaquina.ItemHeight = 23
        Me.cmbTipoDeMaquina.Location = New System.Drawing.Point(308, 122)
        Me.cmbTipoDeMaquina.Name = "cmbTipoDeMaquina"
        Me.cmbTipoDeMaquina.Size = New System.Drawing.Size(200, 29)
        Me.cmbTipoDeMaquina.TabIndex = 11
        Me.cmbTipoDeMaquina.UseSelectable = True
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
        Me.txtNumeroDeMaquina.TabIndex = 13
        Me.txtNumeroDeMaquina.UseSelectable = True
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
        Me.txtNumeroDeActivo.TabIndex = 12
        Me.txtNumeroDeActivo.UseSelectable = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(526, 45)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 15
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseSelectable = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(433, 45)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 14
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseSelectable = True
        '
        'lblNumeroDeMaquina
        '
        Me.lblNumeroDeMaquina.AutoSize = True
        Me.lblNumeroDeMaquina.Location = New System.Drawing.Point(127, 245)
        Me.lblNumeroDeMaquina.Name = "lblNumeroDeMaquina"
        Me.lblNumeroDeMaquina.Size = New System.Drawing.Size(132, 19)
        Me.lblNumeroDeMaquina.TabIndex = 8
        Me.lblNumeroDeMaquina.Text = "Número de máquina"
        '
        'lblNumeroDeActivo
        '
        Me.lblNumeroDeActivo.AutoSize = True
        Me.lblNumeroDeActivo.Location = New System.Drawing.Point(127, 186)
        Me.lblNumeroDeActivo.Name = "lblNumeroDeActivo"
        Me.lblNumeroDeActivo.Size = New System.Drawing.Size(115, 19)
        Me.lblNumeroDeActivo.TabIndex = 9
        Me.lblNumeroDeActivo.Text = "Número de activo"
        '
        'lblTipoDeMaquina
        '
        Me.lblTipoDeMaquina.AutoSize = True
        Me.lblTipoDeMaquina.Location = New System.Drawing.Point(127, 127)
        Me.lblTipoDeMaquina.Name = "lblTipoDeMaquina"
        Me.lblTipoDeMaquina.Size = New System.Drawing.Size(109, 19)
        Me.lblTipoDeMaquina.TabIndex = 10
        Me.lblTipoDeMaquina.Text = "Tipo de máquina"
        '
        'FrmModificarMaquina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblValidarNumeroMaquina)
        Me.Controls.Add(Me.lblValidarNumeroActivo)
        Me.Controls.Add(Me.lblValidarTipoDeMaquina)
        Me.Controls.Add(Me.cmbTipoDeMaquina)
        Me.Controls.Add(Me.txtNumeroDeMaquina)
        Me.Controls.Add(Me.txtNumeroDeActivo)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.lblNumeroDeMaquina)
        Me.Controls.Add(Me.lblNumeroDeActivo)
        Me.Controls.Add(Me.lblTipoDeMaquina)
        Me.Name = "FrmModificarMaquina"
        Me.Size = New System.Drawing.Size(650, 400)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblValidarNumeroMaquina As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblValidarNumeroActivo As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblValidarTipoDeMaquina As MetroFramework.Controls.MetroLabel
    Friend WithEvents cmbTipoDeMaquina As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txtNumeroDeMaquina As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtNumeroDeActivo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnCancelar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnGuardar As MetroFramework.Controls.MetroButton
    Friend WithEvents lblNumeroDeMaquina As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblNumeroDeActivo As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblTipoDeMaquina As MetroFramework.Controls.MetroLabel

End Class
