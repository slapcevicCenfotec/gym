<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistrarTiposMaquinas
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
        Me.lblTipoDeMaquina = New MetroFramework.Controls.MetroLabel()
        Me.txtTipoDeMaquina = New MetroFramework.Controls.MetroTextBox()
        Me.lblDescripcion = New MetroFramework.Controls.MetroLabel()
        Me.rtbDescripcion = New System.Windows.Forms.RichTextBox()
        Me.btnAgregarFoto = New MetroFramework.Controls.MetroButton()
        Me.btnGuardar = New MetroFramework.Controls.MetroButton()
        Me.btnCancelar = New MetroFramework.Controls.MetroButton()
        Me.pbxFoto = New System.Windows.Forms.PictureBox()
        Me.ofdBuscar = New System.Windows.Forms.OpenFileDialog()
        Me.txtNombreImagen = New MetroFramework.Controls.MetroTextBox()
        Me.lblValidarNombre = New MetroFramework.Controls.MetroLabel()
        Me.lblValidarDescripcion = New MetroFramework.Controls.MetroLabel()
        Me.lblValidarFoto = New MetroFramework.Controls.MetroLabel()
        CType(Me.pbxFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTipoDeMaquina
        '
        Me.lblTipoDeMaquina.AutoSize = True
        Me.lblTipoDeMaquina.Location = New System.Drawing.Point(10, 76)
        Me.lblTipoDeMaquina.Name = "lblTipoDeMaquina"
        Me.lblTipoDeMaquina.Size = New System.Drawing.Size(109, 19)
        Me.lblTipoDeMaquina.TabIndex = 0
        Me.lblTipoDeMaquina.Text = "Tipo de máquina"
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
        Me.txtTipoDeMaquina.TabIndex = 1
        Me.txtTipoDeMaquina.UseSelectable = True
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(10, 122)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(76, 19)
        Me.lblDescripcion.TabIndex = 2
        Me.lblDescripcion.Text = "Descripción"
        '
        'rtbDescripcion
        '
        Me.rtbDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbDescripcion.Location = New System.Drawing.Point(170, 122)
        Me.rtbDescripcion.Name = "rtbDescripcion"
        Me.rtbDescripcion.Size = New System.Drawing.Size(200, 100)
        Me.rtbDescripcion.TabIndex = 3
        Me.rtbDescripcion.Text = ""
        '
        'btnAgregarFoto
        '
        Me.btnAgregarFoto.Location = New System.Drawing.Point(526, 74)
        Me.btnAgregarFoto.Name = "btnAgregarFoto"
        Me.btnAgregarFoto.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregarFoto.TabIndex = 5
        Me.btnAgregarFoto.Text = "Agregar"
        Me.btnAgregarFoto.UseSelectable = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(433, 45)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 6
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseSelectable = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(526, 45)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseSelectable = True
        '
        'pbxFoto
        '
        Me.pbxFoto.BackColor = System.Drawing.Color.White
        Me.pbxFoto.Location = New System.Drawing.Point(453, 74)
        Me.pbxFoto.Name = "pbxFoto"
        Me.pbxFoto.Size = New System.Drawing.Size(148, 148)
        Me.pbxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxFoto.TabIndex = 8
        Me.pbxFoto.TabStop = False
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
        'lblValidarNombre
        '
        Me.lblValidarNombre.AutoSize = True
        Me.lblValidarNombre.BackColor = System.Drawing.Color.Transparent
        Me.lblValidarNombre.ForeColor = System.Drawing.Color.Red
        Me.lblValidarNombre.Location = New System.Drawing.Point(170, 97)
        Me.lblValidarNombre.Name = "lblValidarNombre"
        Me.lblValidarNombre.Size = New System.Drawing.Size(0, 0)
        Me.lblValidarNombre.TabIndex = 11
        Me.lblValidarNombre.UseCustomBackColor = True
        Me.lblValidarNombre.UseCustomForeColor = True
        '
        'lblValidarDescripcion
        '
        Me.lblValidarDescripcion.AutoSize = True
        Me.lblValidarDescripcion.BackColor = System.Drawing.Color.Transparent
        Me.lblValidarDescripcion.ForeColor = System.Drawing.Color.Red
        Me.lblValidarDescripcion.Location = New System.Drawing.Point(170, 247)
        Me.lblValidarDescripcion.Name = "lblValidarDescripcion"
        Me.lblValidarDescripcion.Size = New System.Drawing.Size(0, 0)
        Me.lblValidarDescripcion.TabIndex = 13
        Me.lblValidarDescripcion.UseCustomBackColor = True
        Me.lblValidarDescripcion.UseCustomForeColor = True
        '
        'lblValidarFoto
        '
        Me.lblValidarFoto.AutoSize = True
        Me.lblValidarFoto.BackColor = System.Drawing.Color.Transparent
        Me.lblValidarFoto.ForeColor = System.Drawing.Color.Red
        Me.lblValidarFoto.Location = New System.Drawing.Point(453, 225)
        Me.lblValidarFoto.Name = "lblValidarFoto"
        Me.lblValidarFoto.Size = New System.Drawing.Size(0, 0)
        Me.lblValidarFoto.TabIndex = 14
        Me.lblValidarFoto.UseCustomBackColor = True
        Me.lblValidarFoto.UseCustomForeColor = True
        '
        'FrmRegistrarTiposMaquinas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnAgregarFoto)
        Me.Controls.Add(Me.lblValidarFoto)
        Me.Controls.Add(Me.lblValidarDescripcion)
        Me.Controls.Add(Me.lblValidarNombre)
        Me.Controls.Add(Me.txtNombreImagen)
        Me.Controls.Add(Me.pbxFoto)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.rtbDescripcion)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.txtTipoDeMaquina)
        Me.Controls.Add(Me.lblTipoDeMaquina)
        Me.Name = "FrmRegistrarTiposMaquinas"
        Me.Size = New System.Drawing.Size(650, 400)
        CType(Me.pbxFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTipoDeMaquina As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtTipoDeMaquina As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblDescripcion As MetroFramework.Controls.MetroLabel
    Friend WithEvents rtbDescripcion As System.Windows.Forms.RichTextBox
    Friend WithEvents btnAgregarFoto As MetroFramework.Controls.MetroButton
    Friend WithEvents btnGuardar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCancelar As MetroFramework.Controls.MetroButton
    Friend WithEvents pbxFoto As System.Windows.Forms.PictureBox
    Friend WithEvents ofdBuscar As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtNombreImagen As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblValidarNombre As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblValidarDescripcion As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblValidarFoto As MetroFramework.Controls.MetroLabel

End Class
