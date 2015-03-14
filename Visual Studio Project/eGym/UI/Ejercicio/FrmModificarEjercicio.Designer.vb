<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModificarEjercicio
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
        Me.ptbPosicionFinal = New System.Windows.Forms.PictureBox()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.txtNombreImagen = New MetroFramework.Controls.MetroTextBox()
        Me.ptbPosicionInicial = New System.Windows.Forms.PictureBox()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.btnCancelar = New MetroFramework.Controls.MetroButton()
        Me.btnGuardar = New MetroFramework.Controls.MetroButton()
        Me.txtDescripcion = New MetroFramework.Controls.MetroTextBox()
        Me.txtPosInicial = New MetroFramework.Controls.MetroTextBox()
        Me.txtPosFinal = New MetroFramework.Controls.MetroTextBox()
        Me.txtErroresComunes = New MetroFramework.Controls.MetroTextBox()
        Me.txtAlias = New MetroFramework.Controls.MetroTextBox()
        Me.txtNombre = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.txtNombreImagen2 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.lbMusculosSecundarios = New System.Windows.Forms.ListBox()
        Me.cbListaMusculosPrincipales = New System.Windows.Forms.ComboBox()
        Me.lbMusculos = New System.Windows.Forms.ListBox()
        CType(Me.ptbPosicionFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbPosicionInicial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ptbPosicionFinal
        '
        Me.ptbPosicionFinal.Location = New System.Drawing.Point(161, 215)
        Me.ptbPosicionFinal.Name = "ptbPosicionFinal"
        Me.ptbPosicionFinal.Size = New System.Drawing.Size(100, 50)
        Me.ptbPosicionFinal.TabIndex = 42
        Me.ptbPosicionFinal.TabStop = False
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(390, 242)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(112, 23)
        Me.MetroButton2.TabIndex = 41
        Me.MetroButton2.Text = "Cambiar Imagen"
        Me.MetroButton2.UseSelectable = True
        '
        'txtNombreImagen
        '
        Me.txtNombreImagen.Lines = New String() {"MetroTextBox7"}
        Me.txtNombreImagen.Location = New System.Drawing.Point(402, 142)
        Me.txtNombreImagen.MaxLength = 32767
        Me.txtNombreImagen.Name = "txtNombreImagen"
        Me.txtNombreImagen.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreImagen.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNombreImagen.SelectedText = ""
        Me.txtNombreImagen.Size = New System.Drawing.Size(100, 23)
        Me.txtNombreImagen.TabIndex = 40
        Me.txtNombreImagen.Text = "MetroTextBox7"
        Me.txtNombreImagen.UseSelectable = True
        '
        'ptbPosicionInicial
        '
        Me.ptbPosicionInicial.Location = New System.Drawing.Point(291, 119)
        Me.ptbPosicionInicial.Name = "ptbPosicionInicial"
        Me.ptbPosicionInicial.Size = New System.Drawing.Size(100, 50)
        Me.ptbPosicionInicial.TabIndex = 39
        Me.ptbPosicionInicial.TabStop = False
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(526, 142)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(112, 23)
        Me.MetroButton1.TabIndex = 38
        Me.MetroButton1.Text = "Cambiar Imagen"
        Me.MetroButton1.UseSelectable = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(483, 54)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 37
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseSelectable = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(373, 50)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 36
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseSelectable = True
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Lines = New String(-1) {}
        Me.txtDescripcion.Location = New System.Drawing.Point(152, 335)
        Me.txtDescripcion.MaxLength = 32767
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDescripcion.SelectedText = ""
        Me.txtDescripcion.Size = New System.Drawing.Size(75, 23)
        Me.txtDescripcion.TabIndex = 35
        Me.txtDescripcion.UseSelectable = True
        '
        'txtPosInicial
        '
        Me.txtPosInicial.Lines = New String(-1) {}
        Me.txtPosInicial.Location = New System.Drawing.Point(169, 114)
        Me.txtPosInicial.MaxLength = 32767
        Me.txtPosInicial.Name = "txtPosInicial"
        Me.txtPosInicial.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPosInicial.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPosInicial.SelectedText = ""
        Me.txtPosInicial.Size = New System.Drawing.Size(75, 23)
        Me.txtPosInicial.TabIndex = 34
        Me.txtPosInicial.UseSelectable = True
        '
        'txtPosFinal
        '
        Me.txtPosFinal.Lines = New String(-1) {}
        Me.txtPosFinal.Location = New System.Drawing.Point(186, 186)
        Me.txtPosFinal.MaxLength = 32767
        Me.txtPosFinal.Name = "txtPosFinal"
        Me.txtPosFinal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPosFinal.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPosFinal.SelectedText = ""
        Me.txtPosFinal.Size = New System.Drawing.Size(75, 23)
        Me.txtPosFinal.TabIndex = 33
        Me.txtPosFinal.UseSelectable = True
        '
        'txtErroresComunes
        '
        Me.txtErroresComunes.Lines = New String(-1) {}
        Me.txtErroresComunes.Location = New System.Drawing.Point(169, 288)
        Me.txtErroresComunes.MaxLength = 32767
        Me.txtErroresComunes.Name = "txtErroresComunes"
        Me.txtErroresComunes.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtErroresComunes.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtErroresComunes.SelectedText = ""
        Me.txtErroresComunes.Size = New System.Drawing.Size(75, 23)
        Me.txtErroresComunes.TabIndex = 32
        Me.txtErroresComunes.UseSelectable = True
        '
        'txtAlias
        '
        Me.txtAlias.Lines = New String(-1) {}
        Me.txtAlias.Location = New System.Drawing.Point(169, 85)
        Me.txtAlias.MaxLength = 32767
        Me.txtAlias.Name = "txtAlias"
        Me.txtAlias.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAlias.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtAlias.SelectedText = ""
        Me.txtAlias.Size = New System.Drawing.Size(75, 23)
        Me.txtAlias.TabIndex = 31
        Me.txtAlias.UseSelectable = True
        '
        'txtNombre
        '
        Me.txtNombre.Lines = New String(-1) {}
        Me.txtNombre.Location = New System.Drawing.Point(169, 54)
        Me.txtNombre.MaxLength = 60
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNombre.SelectedText = ""
        Me.txtNombre.Size = New System.Drawing.Size(75, 23)
        Me.txtNombre.TabIndex = 30
        Me.txtNombre.UseSelectable = True
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(28, 339)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(83, 19)
        Me.MetroLabel8.TabIndex = 29
        Me.MetroLabel8.Text = "Descripción :"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(28, 292)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(114, 19)
        Me.MetroLabel7.TabIndex = 28
        Me.MetroLabel7.Text = "Errores comunes :"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(19, 237)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(136, 19)
        Me.MetroLabel6.TabIndex = 27
        Me.MetroLabel6.Text = "Posicion Final Imagen"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(16, 191)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(95, 19)
        Me.MetroLabel5.TabIndex = 26
        Me.MetroLabel5.Text = "Posicion Final :"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(28, 146)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(148, 19)
        Me.MetroLabel4.TabIndex = 25
        Me.MetroLabel4.Text = "Posicion Inicial Imagen :"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(28, 115)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(100, 19)
        Me.MetroLabel3.TabIndex = 24
        Me.MetroLabel3.Text = "Posición Inicial :"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(28, 85)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(43, 19)
        Me.MetroLabel2.TabIndex = 23
        Me.MetroLabel2.Text = "Alias :"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(28, 54)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(66, 19)
        Me.MetroLabel1.TabIndex = 22
        Me.MetroLabel1.Text = "Nombre :"
        '
        'txtNombreImagen2
        '
        Me.txtNombreImagen2.Lines = New String() {"MetroTextBox7"}
        Me.txtNombreImagen2.Location = New System.Drawing.Point(267, 215)
        Me.txtNombreImagen2.MaxLength = 32767
        Me.txtNombreImagen2.Name = "txtNombreImagen2"
        Me.txtNombreImagen2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreImagen2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNombreImagen2.SelectedText = ""
        Me.txtNombreImagen2.Size = New System.Drawing.Size(100, 23)
        Me.txtNombreImagen2.TabIndex = 43
        Me.txtNombreImagen2.Text = "MetroTextBox7"
        Me.txtNombreImagen2.UseSelectable = True
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(28, 382)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(118, 19)
        Me.MetroLabel9.TabIndex = 44
        Me.MetroLabel9.Text = "Musculo Principal :"
        '
        'lbMusculosSecundarios
        '
        Me.lbMusculosSecundarios.FormattingEnabled = True
        Me.lbMusculosSecundarios.Location = New System.Drawing.Point(345, 335)
        Me.lbMusculosSecundarios.Name = "lbMusculosSecundarios"
        Me.lbMusculosSecundarios.Size = New System.Drawing.Size(120, 95)
        Me.lbMusculosSecundarios.TabIndex = 46
        '
        'cbListaMusculosPrincipales
        '
        Me.cbListaMusculosPrincipales.FormattingEnabled = True
        Me.cbListaMusculosPrincipales.Location = New System.Drawing.Point(161, 382)
        Me.cbListaMusculosPrincipales.Name = "cbListaMusculosPrincipales"
        Me.cbListaMusculosPrincipales.Size = New System.Drawing.Size(121, 21)
        Me.cbListaMusculosPrincipales.TabIndex = 47
        '
        'lbMusculos
        '
        Me.lbMusculos.FormattingEnabled = True
        Me.lbMusculos.Location = New System.Drawing.Point(507, 335)
        Me.lbMusculos.Name = "lbMusculos"
        Me.lbMusculos.Size = New System.Drawing.Size(120, 95)
        Me.lbMusculos.TabIndex = 48
        '
        'FrmModificarEjercicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.lbMusculos)
        Me.Controls.Add(Me.cbListaMusculosPrincipales)
        Me.Controls.Add(Me.lbMusculosSecundarios)
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
        Me.Name = "FrmModificarEjercicio"
        Me.Size = New System.Drawing.Size(703, 461)
        CType(Me.ptbPosicionFinal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbPosicionInicial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ptbPosicionFinal As System.Windows.Forms.PictureBox
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents txtNombreImagen As MetroFramework.Controls.MetroTextBox
    Friend WithEvents ptbPosicionInicial As System.Windows.Forms.PictureBox
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCancelar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnGuardar As MetroFramework.Controls.MetroButton
    Friend WithEvents txtDescripcion As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPosInicial As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPosFinal As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtErroresComunes As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtAlias As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtNombre As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNombreImagen2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbMusculosSecundarios As System.Windows.Forms.ListBox
    Friend WithEvents cbListaMusculosPrincipales As System.Windows.Forms.ComboBox
    Friend WithEvents lbMusculos As System.Windows.Forms.ListBox

End Class
