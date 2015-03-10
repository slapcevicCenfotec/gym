<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModificarTipoDeMaquina
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmModificarTipoDeMaquina))
        Me.txtTipoDeMaquina = New MetroFramework.Controls.MetroTextBox()
        Me.rtbDescripcion = New System.Windows.Forms.RichTextBox()
        Me.ofdBuscar = New System.Windows.Forms.OpenFileDialog()
        Me.pbxFoto = New System.Windows.Forms.PictureBox()
        Me.lblTipoDeMaquina = New MetroFramework.Controls.MetroLabel()
        Me.lblDescripcion = New MetroFramework.Controls.MetroLabel()
        Me.btnGuardar = New MetroFramework.Controls.MetroButton()
        Me.btnCancelar = New MetroFramework.Controls.MetroButton()
        Me.txtNombreImagen = New MetroFramework.Controls.MetroTextBox()
        Me.btnAgregarFoto = New MetroFramework.Controls.MetroButton()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.pbxFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTipoDeMaquina
        '
        Me.txtTipoDeMaquina.Lines = New String(-1) {}
        Me.txtTipoDeMaquina.Location = New System.Drawing.Point(170, 74)
        Me.txtTipoDeMaquina.MaxLength = 32767
        Me.txtTipoDeMaquina.Name = "txtTipoDeMaquina"
        Me.txtTipoDeMaquina.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTipoDeMaquina.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTipoDeMaquina.SelectedText = ""
        Me.txtTipoDeMaquina.Size = New System.Drawing.Size(200, 23)
        Me.txtTipoDeMaquina.TabIndex = 2
        Me.txtTipoDeMaquina.UseSelectable = True
        '
        'rtbDescripcion
        '
        Me.rtbDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbDescripcion.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbDescripcion.Location = New System.Drawing.Point(170, 122)
        Me.rtbDescripcion.Name = "rtbDescripcion"
        Me.rtbDescripcion.Size = New System.Drawing.Size(200, 100)
        Me.rtbDescripcion.TabIndex = 3
        Me.rtbDescripcion.Text = ""
        '
        'pbxFoto
        '
        Me.pbxFoto.BackColor = System.Drawing.Color.White
        Me.pbxFoto.Location = New System.Drawing.Point(453, 74)
        Me.pbxFoto.Name = "pbxFoto"
        Me.pbxFoto.Size = New System.Drawing.Size(148, 148)
        Me.pbxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxFoto.TabIndex = 4
        Me.pbxFoto.TabStop = False
        '
        'lblTipoDeMaquina
        '
        Me.lblTipoDeMaquina.AutoSize = True
        Me.lblTipoDeMaquina.Location = New System.Drawing.Point(10, 76)
        Me.lblTipoDeMaquina.Name = "lblTipoDeMaquina"
        Me.lblTipoDeMaquina.Size = New System.Drawing.Size(109, 19)
        Me.lblTipoDeMaquina.TabIndex = 5
        Me.lblTipoDeMaquina.Text = "Tipo de máquina"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(10, 122)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(76, 19)
        Me.lblDescripcion.TabIndex = 6
        Me.lblDescripcion.Text = "Descripción"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(433, 45)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 7
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseSelectable = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(526, 45)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 8
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseSelectable = True
        '
        'txtNombreImagen
        '
        Me.txtNombreImagen.Lines = New String(-1) {}
        Me.txtNombreImagen.Location = New System.Drawing.Point(453, 247)
        Me.txtNombreImagen.MaxLength = 32767
        Me.txtNombreImagen.Name = "txtNombreImagen"
        Me.txtNombreImagen.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreImagen.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNombreImagen.SelectedText = ""
        Me.txtNombreImagen.Size = New System.Drawing.Size(148, 23)
        Me.txtNombreImagen.TabIndex = 9
        Me.txtNombreImagen.UseSelectable = True
        '
        'btnAgregarFoto
        '
        Me.btnAgregarFoto.Location = New System.Drawing.Point(526, 74)
        Me.btnAgregarFoto.Name = "btnAgregarFoto"
        Me.btnAgregarFoto.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregarFoto.TabIndex = 10
        Me.btnAgregarFoto.Text = "Cambiar"
        Me.btnAgregarFoto.UseSelectable = True
        '
        'ErrorProvider
        '
        Me.ErrorProvider.BlinkRate = 0
        Me.ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider.ContainerControl = Me
        Me.ErrorProvider.Icon = CType(resources.GetObject("ErrorProvider.Icon"), System.Drawing.Icon)
        '
        'FrmModificarTipoDeMaquina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnAgregarFoto)
        Me.Controls.Add(Me.txtNombreImagen)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.lblTipoDeMaquina)
        Me.Controls.Add(Me.pbxFoto)
        Me.Controls.Add(Me.rtbDescripcion)
        Me.Controls.Add(Me.txtTipoDeMaquina)
        Me.Name = "FrmModificarTipoDeMaquina"
        Me.Size = New System.Drawing.Size(650, 400)
        CType(Me.pbxFoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTipoDeMaquina As MetroFramework.Controls.MetroTextBox
    Friend WithEvents rtbDescripcion As System.Windows.Forms.RichTextBox
    Friend WithEvents ofdBuscar As System.Windows.Forms.OpenFileDialog
    Friend WithEvents pbxFoto As System.Windows.Forms.PictureBox
    Friend WithEvents lblTipoDeMaquina As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblDescripcion As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnGuardar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCancelar As MetroFramework.Controls.MetroButton
    Friend WithEvents txtNombreImagen As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnAgregarFoto As MetroFramework.Controls.MetroButton
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider

End Class
