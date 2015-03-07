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
        Me.lblHabilitada = New MetroFramework.Controls.MetroLabel()
        Me.ckbHabilitado = New System.Windows.Forms.CheckBox()
        CType(Me.pbxFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTipoDeMaquina
        '
        Me.txtTipoDeMaquina.Lines = New String(-1) {}
        Me.txtTipoDeMaquina.Location = New System.Drawing.Point(260, 40)
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
        Me.rtbDescripcion.Location = New System.Drawing.Point(260, 88)
        Me.rtbDescripcion.Name = "rtbDescripcion"
        Me.rtbDescripcion.Size = New System.Drawing.Size(200, 100)
        Me.rtbDescripcion.TabIndex = 3
        Me.rtbDescripcion.Text = ""
        '
        'pbxFoto
        '
        Me.pbxFoto.Location = New System.Drawing.Point(543, 40)
        Me.pbxFoto.Name = "pbxFoto"
        Me.pbxFoto.Size = New System.Drawing.Size(148, 148)
        Me.pbxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxFoto.TabIndex = 4
        Me.pbxFoto.TabStop = False
        '
        'lblTipoDeMaquina
        '
        Me.lblTipoDeMaquina.AutoSize = True
        Me.lblTipoDeMaquina.Location = New System.Drawing.Point(100, 42)
        Me.lblTipoDeMaquina.Name = "lblTipoDeMaquina"
        Me.lblTipoDeMaquina.Size = New System.Drawing.Size(109, 19)
        Me.lblTipoDeMaquina.TabIndex = 5
        Me.lblTipoDeMaquina.Text = "Tipo de máquina"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(100, 88)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(76, 19)
        Me.lblDescripcion.TabIndex = 6
        Me.lblDescripcion.Text = "Descripción"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(593, 3)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 7
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseSelectable = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(674, 3)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 8
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseSelectable = True
        '
        'txtNombreImagen
        '
        Me.txtNombreImagen.Lines = New String(-1) {}
        Me.txtNombreImagen.Location = New System.Drawing.Point(543, 213)
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
        Me.btnAgregarFoto.Location = New System.Drawing.Point(597, 244)
        Me.btnAgregarFoto.Name = "btnAgregarFoto"
        Me.btnAgregarFoto.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregarFoto.TabIndex = 10
        Me.btnAgregarFoto.Text = "Agregar"
        Me.btnAgregarFoto.UseSelectable = True
        '
        'lblHabilitada
        '
        Me.lblHabilitada.AutoSize = True
        Me.lblHabilitada.Location = New System.Drawing.Point(100, 217)
        Me.lblHabilitada.Name = "lblHabilitada"
        Me.lblHabilitada.Size = New System.Drawing.Size(68, 19)
        Me.lblHabilitada.TabIndex = 11
        Me.lblHabilitada.Text = "Habilitada"
        '
        'ckbHabilitado
        '
        Me.ckbHabilitado.AutoSize = True
        Me.ckbHabilitado.Location = New System.Drawing.Point(260, 219)
        Me.ckbHabilitado.Name = "ckbHabilitado"
        Me.ckbHabilitado.Size = New System.Drawing.Size(15, 14)
        Me.ckbHabilitado.TabIndex = 12
        Me.ckbHabilitado.UseVisualStyleBackColor = True
        '
        'FrmModificarTipoDeMaquina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ckbHabilitado)
        Me.Controls.Add(Me.lblHabilitada)
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
        Me.Size = New System.Drawing.Size(968, 600)
        CType(Me.pbxFoto, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblHabilitada As MetroFramework.Controls.MetroLabel
    Friend WithEvents ckbHabilitado As System.Windows.Forms.CheckBox

End Class
