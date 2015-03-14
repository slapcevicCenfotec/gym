<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistrarTiposMaquinas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRegistrarTiposMaquinas))
        Me.lblTipoDeMaquina = New MetroFramework.Controls.MetroLabel()
        Me.txtTipoDeMaquina = New MetroFramework.Controls.MetroTextBox()
        Me.lblDescripcion = New MetroFramework.Controls.MetroLabel()
        Me.rtbDescripcion = New System.Windows.Forms.RichTextBox()
        Me.btnAgregarFoto = New MetroFramework.Controls.MetroButton()
        Me.pbxFoto = New System.Windows.Forms.PictureBox()
        Me.ofdBuscar = New System.Windows.Forms.OpenFileDialog()
        Me.txtNombreImagen = New MetroFramework.Controls.MetroTextBox()
        Me.ErPrValidaciones = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErPrExcepciones = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnCancelar = New MetroFramework.Controls.MetroButton()
        Me.btnGuardar = New MetroFramework.Controls.MetroButton()
        Me.lblFoto = New MetroFramework.Controls.MetroLabel()
        CType(Me.pbxFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErPrValidaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErPrExcepciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTipoDeMaquina
        '
        Me.lblTipoDeMaquina.AutoSize = True
        Me.lblTipoDeMaquina.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblTipoDeMaquina.Location = New System.Drawing.Point(273, 155)
        Me.lblTipoDeMaquina.Name = "lblTipoDeMaquina"
        Me.lblTipoDeMaquina.Size = New System.Drawing.Size(141, 25)
        Me.lblTipoDeMaquina.TabIndex = 0
        Me.lblTipoDeMaquina.Text = "Tipo de máquina"
        Me.lblTipoDeMaquina.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'txtTipoDeMaquina
        '
        Me.txtTipoDeMaquina.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtTipoDeMaquina.Lines = New String(-1) {}
        Me.txtTipoDeMaquina.Location = New System.Drawing.Point(273, 183)
        Me.txtTipoDeMaquina.MaxLength = 32767
        Me.txtTipoDeMaquina.Name = "txtTipoDeMaquina"
        Me.txtTipoDeMaquina.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTipoDeMaquina.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTipoDeMaquina.SelectedText = ""
        Me.txtTipoDeMaquina.Size = New System.Drawing.Size(250, 35)
        Me.txtTipoDeMaquina.TabIndex = 1
        Me.txtTipoDeMaquina.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtTipoDeMaquina.UseSelectable = True
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblDescripcion.Location = New System.Drawing.Point(273, 221)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(100, 25)
        Me.lblDescripcion.TabIndex = 0
        Me.lblDescripcion.Text = "Descripción"
        Me.lblDescripcion.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'rtbDescripcion
        '
        Me.rtbDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rtbDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbDescripcion.Font = New System.Drawing.Font("Segoe UI Emoji", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbDescripcion.Location = New System.Drawing.Point(273, 249)
        Me.rtbDescripcion.Name = "rtbDescripcion"
        Me.rtbDescripcion.Size = New System.Drawing.Size(250, 150)
        Me.rtbDescripcion.TabIndex = 2
        Me.rtbDescripcion.Text = ""
        '
        'btnAgregarFoto
        '
        Me.btnAgregarFoto.Location = New System.Drawing.Point(781, 183)
        Me.btnAgregarFoto.Name = "btnAgregarFoto"
        Me.btnAgregarFoto.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregarFoto.TabIndex = 3
        Me.btnAgregarFoto.Text = "Agregar"
        Me.btnAgregarFoto.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnAgregarFoto.UseSelectable = True
        '
        'pbxFoto
        '
        Me.pbxFoto.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pbxFoto.Location = New System.Drawing.Point(606, 184)
        Me.pbxFoto.Name = "pbxFoto"
        Me.pbxFoto.Size = New System.Drawing.Size(250, 250)
        Me.pbxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxFoto.TabIndex = 8
        Me.pbxFoto.TabStop = False
        '
        'txtNombreImagen
        '
        Me.txtNombreImagen.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtNombreImagen.Lines = New String(-1) {}
        Me.txtNombreImagen.Location = New System.Drawing.Point(606, 440)
        Me.txtNombreImagen.MaxLength = 32767
        Me.txtNombreImagen.Name = "txtNombreImagen"
        Me.txtNombreImagen.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreImagen.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNombreImagen.SelectedText = ""
        Me.txtNombreImagen.Size = New System.Drawing.Size(250, 35)
        Me.txtNombreImagen.TabIndex = 0
        Me.txtNombreImagen.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtNombreImagen.UseSelectable = True
        '
        'ErPrValidaciones
        '
        Me.ErPrValidaciones.BlinkRate = 0
        Me.ErPrValidaciones.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErPrValidaciones.ContainerControl = Me
        Me.ErPrValidaciones.Icon = CType(resources.GetObject("ErPrValidaciones.Icon"), System.Drawing.Icon)
        '
        'ErPrExcepciones
        '
        Me.ErPrExcepciones.BlinkRate = 0
        Me.ErPrExcepciones.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErPrExcepciones.ContainerControl = Me
        Me.ErPrExcepciones.Icon = CType(resources.GetObject("ErPrExcepciones.Icon"), System.Drawing.Icon)
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnCancelar.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.btnCancelar.Location = New System.Drawing.Point(819, 16)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(15, 15, 0, 0)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(125, 30)
        Me.btnCancelar.Style = MetroFramework.MetroColorStyle.Purple
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnCancelar.UseSelectable = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnGuardar.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.btnGuardar.Location = New System.Drawing.Point(679, 16)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(15, 15, 0, 0)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(125, 30)
        Me.btnGuardar.Style = MetroFramework.MetroColorStyle.Purple
        Me.btnGuardar.TabIndex = 4
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnGuardar.UseSelectable = True
        '
        'lblFoto
        '
        Me.lblFoto.AutoSize = True
        Me.lblFoto.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblFoto.Location = New System.Drawing.Point(606, 155)
        Me.lblFoto.Name = "lblFoto"
        Me.lblFoto.Size = New System.Drawing.Size(45, 25)
        Me.lblFoto.TabIndex = 9
        Me.lblFoto.Text = "Foto"
        Me.lblFoto.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'FrmRegistrarTiposMaquinas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.lblFoto)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnAgregarFoto)
        Me.Controls.Add(Me.txtNombreImagen)
        Me.Controls.Add(Me.pbxFoto)
        Me.Controls.Add(Me.rtbDescripcion)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.txtTipoDeMaquina)
        Me.Controls.Add(Me.lblTipoDeMaquina)
        Me.Name = "FrmRegistrarTiposMaquinas"
        Me.Size = New System.Drawing.Size(960, 695)
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        CType(Me.pbxFoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErPrValidaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErPrExcepciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTipoDeMaquina As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtTipoDeMaquina As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblDescripcion As MetroFramework.Controls.MetroLabel
    Friend WithEvents rtbDescripcion As System.Windows.Forms.RichTextBox
    Friend WithEvents btnAgregarFoto As MetroFramework.Controls.MetroButton
    Friend WithEvents pbxFoto As System.Windows.Forms.PictureBox
    Friend WithEvents ofdBuscar As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtNombreImagen As MetroFramework.Controls.MetroTextBox
    Friend WithEvents ErPrValidaciones As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErPrExcepciones As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnCancelar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnGuardar As MetroFramework.Controls.MetroButton
    Friend WithEvents lblFoto As MetroFramework.Controls.MetroLabel

End Class
