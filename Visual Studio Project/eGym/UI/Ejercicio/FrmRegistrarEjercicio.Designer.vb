<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistrarEjercicio
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
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.txtNombre = New MetroFramework.Controls.MetroTextBox()
        Me.txtAlias = New MetroFramework.Controls.MetroTextBox()
        Me.txtErroresComunes = New MetroFramework.Controls.MetroTextBox()
        Me.txtPosFinal = New MetroFramework.Controls.MetroTextBox()
        Me.txtPosInicial = New MetroFramework.Controls.MetroTextBox()
        Me.txtDescripcion = New MetroFramework.Controls.MetroTextBox()
        Me.btnGuardar = New MetroFramework.Controls.MetroButton()
        Me.btnCancelar = New MetroFramework.Controls.MetroButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.ofdBuscar = New System.Windows.Forms.OpenFileDialog()
        Me.ptbPosicionInicial = New System.Windows.Forms.PictureBox()
        Me.txtNombreImagen = New MetroFramework.Controls.MetroTextBox()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.ofdBuscar2 = New System.Windows.Forms.OpenFileDialog()
        Me.ptbPosicionFinal = New System.Windows.Forms.PictureBox()
        Me.txtNombreImagen2 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.cbListaMusculosPrincipales = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.lbMusculosSecundarios = New System.Windows.Forms.ListBox()
        CType(Me.ptbPosicionInicial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbPosicionFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(55, 46)
        Me.MetroLabel1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(66, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Nombre :"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(55, 113)
        Me.MetroLabel2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(43, 19)
        Me.MetroLabel2.TabIndex = 1
        Me.MetroLabel2.Text = "Alias :"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(37, 194)
        Me.MetroLabel3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(100, 19)
        Me.MetroLabel3.TabIndex = 2
        Me.MetroLabel3.Text = "Posición Inicial :"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(37, 254)
        Me.MetroLabel4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(148, 19)
        Me.MetroLabel4.TabIndex = 3
        Me.MetroLabel4.Text = "Posicion Inicial Imagen :"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(420, 194)
        Me.MetroLabel5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(95, 19)
        Me.MetroLabel5.TabIndex = 4
        Me.MetroLabel5.Text = "Posicion Final :"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(454, 280)
        Me.MetroLabel6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(136, 19)
        Me.MetroLabel6.TabIndex = 5
        Me.MetroLabel6.Text = "Posicion Final Imagen"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(401, 46)
        Me.MetroLabel7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(114, 19)
        Me.MetroLabel7.TabIndex = 6
        Me.MetroLabel7.Text = "Errores comunes :"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(401, 97)
        Me.MetroLabel8.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(83, 19)
        Me.MetroLabel8.TabIndex = 7
        Me.MetroLabel8.Text = "Descripción :"
        '
        'txtNombre
        '
        Me.txtNombre.Lines = New String(-1) {}
        Me.txtNombre.Location = New System.Drawing.Point(158, 30)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.txtNombre.MaxLength = 60
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNombre.SelectedText = ""
        Me.txtNombre.Size = New System.Drawing.Size(138, 53)
        Me.txtNombre.TabIndex = 8
        Me.txtNombre.UseSelectable = True
        '
        'txtAlias
        '
        Me.txtAlias.Lines = New String(-1) {}
        Me.txtAlias.Location = New System.Drawing.Point(158, 97)
        Me.txtAlias.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.txtAlias.MaxLength = 32767
        Me.txtAlias.Name = "txtAlias"
        Me.txtAlias.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAlias.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtAlias.SelectedText = ""
        Me.txtAlias.Size = New System.Drawing.Size(138, 53)
        Me.txtAlias.TabIndex = 9
        Me.txtAlias.UseSelectable = True
        '
        'txtErroresComunes
        '
        Me.txtErroresComunes.Lines = New String(-1) {}
        Me.txtErroresComunes.Location = New System.Drawing.Point(538, 30)
        Me.txtErroresComunes.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.txtErroresComunes.MaxLength = 32767
        Me.txtErroresComunes.Name = "txtErroresComunes"
        Me.txtErroresComunes.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtErroresComunes.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtErroresComunes.SelectedText = ""
        Me.txtErroresComunes.Size = New System.Drawing.Size(138, 53)
        Me.txtErroresComunes.TabIndex = 10
        Me.txtErroresComunes.UseSelectable = True
        '
        'txtPosFinal
        '
        Me.txtPosFinal.Lines = New String(-1) {}
        Me.txtPosFinal.Location = New System.Drawing.Point(538, 180)
        Me.txtPosFinal.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.txtPosFinal.MaxLength = 32767
        Me.txtPosFinal.Name = "txtPosFinal"
        Me.txtPosFinal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPosFinal.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPosFinal.SelectedText = ""
        Me.txtPosFinal.Size = New System.Drawing.Size(205, 53)
        Me.txtPosFinal.TabIndex = 11
        Me.txtPosFinal.UseSelectable = True
        '
        'txtPosInicial
        '
        Me.txtPosInicial.Lines = New String(-1) {}
        Me.txtPosInicial.Location = New System.Drawing.Point(158, 169)
        Me.txtPosInicial.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.txtPosInicial.MaxLength = 32767
        Me.txtPosInicial.Name = "txtPosInicial"
        Me.txtPosInicial.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPosInicial.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPosInicial.SelectedText = ""
        Me.txtPosInicial.Size = New System.Drawing.Size(138, 53)
        Me.txtPosInicial.TabIndex = 12
        Me.txtPosInicial.UseSelectable = True
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Lines = New String(-1) {}
        Me.txtDescripcion.Location = New System.Drawing.Point(538, 113)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.txtDescripcion.MaxLength = 32767
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDescripcion.SelectedText = ""
        Me.txtDescripcion.Size = New System.Drawing.Size(138, 53)
        Me.txtDescripcion.TabIndex = 13
        Me.txtDescripcion.UseSelectable = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(1357, 46)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(138, 53)
        Me.btnGuardar.TabIndex = 14
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseSelectable = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(1507, 46)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(138, 53)
        Me.btnCancelar.TabIndex = 15
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseSelectable = True
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(208, 236)
        Me.MetroButton1.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(205, 53)
        Me.MetroButton1.TabIndex = 16
        Me.MetroButton1.Text = "Agregar imagen"
        Me.MetroButton1.UseSelectable = True
        '
        'ptbPosicionInicial
        '
        Me.ptbPosicionInicial.Location = New System.Drawing.Point(208, 289)
        Me.ptbPosicionInicial.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.ptbPosicionInicial.Name = "ptbPosicionInicial"
        Me.ptbPosicionInicial.Size = New System.Drawing.Size(183, 115)
        Me.ptbPosicionInicial.TabIndex = 17
        Me.ptbPosicionInicial.TabStop = False
        '
        'txtNombreImagen
        '
        Me.txtNombreImagen.Lines = New String() {"MetroTextBox7"}
        Me.txtNombreImagen.Location = New System.Drawing.Point(208, 407)
        Me.txtNombreImagen.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.txtNombreImagen.MaxLength = 32767
        Me.txtNombreImagen.Name = "txtNombreImagen"
        Me.txtNombreImagen.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreImagen.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNombreImagen.SelectedText = ""
        Me.txtNombreImagen.Size = New System.Drawing.Size(183, 53)
        Me.txtNombreImagen.TabIndex = 18
        Me.txtNombreImagen.Text = "MetroTextBox7"
        Me.txtNombreImagen.UseSelectable = True
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(639, 254)
        Me.MetroButton2.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(205, 53)
        Me.MetroButton2.TabIndex = 19
        Me.MetroButton2.Text = "Agregar imagen"
        Me.MetroButton2.UseSelectable = True
        '
        'ptbPosicionFinal
        '
        Me.ptbPosicionFinal.Location = New System.Drawing.Point(652, 309)
        Me.ptbPosicionFinal.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.ptbPosicionFinal.Name = "ptbPosicionFinal"
        Me.ptbPosicionFinal.Size = New System.Drawing.Size(183, 115)
        Me.ptbPosicionFinal.TabIndex = 20
        Me.ptbPosicionFinal.TabStop = False
        '
        'txtNombreImagen2
        '
        Me.txtNombreImagen2.Lines = New String() {"MetroTextBox7"}
        Me.txtNombreImagen2.Location = New System.Drawing.Point(661, 438)
        Me.txtNombreImagen2.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.txtNombreImagen2.MaxLength = 32767
        Me.txtNombreImagen2.Name = "txtNombreImagen2"
        Me.txtNombreImagen2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreImagen2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNombreImagen2.SelectedText = ""
        Me.txtNombreImagen2.Size = New System.Drawing.Size(183, 53)
        Me.txtNombreImagen2.TabIndex = 21
        Me.txtNombreImagen2.Text = "MetroTextBox7"
        Me.txtNombreImagen2.UseSelectable = True
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(778, 46)
        Me.MetroLabel9.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(111, 19)
        Me.MetroLabel9.TabIndex = 22
        Me.MetroLabel9.Text = "Musculo Principal"
        '
        'cbListaMusculosPrincipales
        '
        Me.cbListaMusculosPrincipales.FormattingEnabled = True
        Me.cbListaMusculosPrincipales.ItemHeight = 23
        Me.cbListaMusculosPrincipales.Location = New System.Drawing.Point(1060, 23)
        Me.cbListaMusculosPrincipales.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.cbListaMusculosPrincipales.Name = "cbListaMusculosPrincipales"
        Me.cbListaMusculosPrincipales.Size = New System.Drawing.Size(219, 29)
        Me.cbListaMusculosPrincipales.TabIndex = 23
        Me.cbListaMusculosPrincipales.UseSelectable = True
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(778, 194)
        Me.MetroLabel10.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(131, 19)
        Me.MetroLabel10.TabIndex = 24
        Me.MetroLabel10.Text = "Musculo Secundarios"
        '
        'lbMusculosSecundarios
        '
        Me.lbMusculosSecundarios.FormattingEnabled = True
        Me.lbMusculosSecundarios.ItemHeight = 30
        Me.lbMusculosSecundarios.Location = New System.Drawing.Point(1060, 194)
        Me.lbMusculosSecundarios.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.lbMusculosSecundarios.Name = "lbMusculosSecundarios"
        Me.lbMusculosSecundarios.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lbMusculosSecundarios.Size = New System.Drawing.Size(217, 214)
        Me.lbMusculosSecundarios.TabIndex = 25
        '
        'FrmRegistrarEjercicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.lbMusculosSecundarios)
        Me.Controls.Add(Me.MetroLabel10)
        Me.Controls.Add(Me.cbListaMusculosPrincipales)
        Me.Controls.Add(Me.MetroLabel9)
        Me.Controls.Add(Me.txtNombreImagen2)
        Me.Controls.Add(Me.ptbPosicionFinal)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.txtNombreImagen)
        Me.Controls.Add(Me.ptbPosicionInicial)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtPosInicial)
        Me.Controls.Add(Me.txtPosFinal)
        Me.Controls.Add(Me.txtErroresComunes)
        Me.Controls.Add(Me.txtAlias)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.Name = "FrmRegistrarEjercicio"
        Me.Size = New System.Drawing.Size(1677, 1440)
        CType(Me.ptbPosicionInicial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbPosicionFinal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNombre As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtAlias As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtErroresComunes As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPosFinal As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPosInicial As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtDescripcion As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnGuardar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCancelar As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents ofdBuscar As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ptbPosicionInicial As System.Windows.Forms.PictureBox
    Friend WithEvents txtNombreImagen As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents ofdBuscar2 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ptbPosicionFinal As System.Windows.Forms.PictureBox
    Friend WithEvents txtNombreImagen2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbListaMusculosPrincipales As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbMusculosSecundarios As System.Windows.Forms.ListBox

End Class
