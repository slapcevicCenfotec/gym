﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModificarTipoDeMaquina
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmModificarTipoDeMaquina))
        Me.ofdBuscar = New System.Windows.Forms.OpenFileDialog()
        Me.txtNombreImagen = New MetroFramework.Controls.MetroTextBox()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErPrExcepciones = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnEliminarFoto = New MetroFramework.Controls.MetroButton()
        Me.lblFoto = New MetroFramework.Controls.MetroLabel()
        Me.txtDescripcion = New MetroFramework.Controls.MetroTextBox()
        Me.pbxFoto = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnCancelar = New MetroFramework.Controls.MetroButton()
        Me.btnGuardar = New MetroFramework.Controls.MetroButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTipoDeMaquina = New MetroFramework.Controls.MetroLabel()
        Me.txtTipoDeMaquina = New MetroFramework.Controls.MetroTextBox()
        Me.lblDescripcion = New MetroFramework.Controls.MetroLabel()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErPrExcepciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pbxFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNombreImagen
        '
        Me.txtNombreImagen.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtNombreImagen.Lines = New String(-1) {}
        Me.txtNombreImagen.Location = New System.Drawing.Point(334, 383)
        Me.txtNombreImagen.MaxLength = 32767
        Me.txtNombreImagen.Name = "txtNombreImagen"
        Me.txtNombreImagen.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreImagen.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNombreImagen.SelectedText = ""
        Me.txtNombreImagen.Size = New System.Drawing.Size(250, 35)
        Me.txtNombreImagen.TabIndex = 0
        Me.txtNombreImagen.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtNombreImagen.UseSelectable = True
        Me.txtNombreImagen.Visible = False
        '
        'ErrorProvider
        '
        Me.ErrorProvider.BlinkRate = 0
        Me.ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider.ContainerControl = Me
        Me.ErrorProvider.Icon = CType(resources.GetObject("ErrorProvider.Icon"), System.Drawing.Icon)
        '
        'ErPrExcepciones
        '
        Me.ErPrExcepciones.BlinkRate = 0
        Me.ErPrExcepciones.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErPrExcepciones.ContainerControl = Me
        Me.ErPrExcepciones.Icon = CType(resources.GetObject("ErPrExcepciones.Icon"), System.Drawing.Icon)
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnEliminarFoto)
        Me.Panel1.Controls.Add(Me.lblFoto)
        Me.Panel1.Controls.Add(Me.txtDescripcion)
        Me.Panel1.Controls.Add(Me.txtNombreImagen)
        Me.Panel1.Controls.Add(Me.pbxFoto)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.lblTipoDeMaquina)
        Me.Panel1.Controls.Add(Me.txtTipoDeMaquina)
        Me.Panel1.Controls.Add(Me.lblDescripcion)
        Me.Panel1.Location = New System.Drawing.Point(239, 76)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(600, 509)
        Me.Panel1.TabIndex = 12
        '
        'btnEliminarFoto
        '
        Me.btnEliminarFoto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminarFoto.Location = New System.Drawing.Point(549, 114)
        Me.btnEliminarFoto.Name = "btnEliminarFoto"
        Me.btnEliminarFoto.Size = New System.Drawing.Size(35, 35)
        Me.btnEliminarFoto.TabIndex = 3
        Me.btnEliminarFoto.Text = "X"
        Me.btnEliminarFoto.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnEliminarFoto.UseSelectable = True
        '
        'lblFoto
        '
        Me.lblFoto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFoto.AutoSize = True
        Me.lblFoto.BackColor = System.Drawing.Color.Transparent
        Me.lblFoto.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblFoto.Location = New System.Drawing.Point(334, 86)
        Me.lblFoto.Name = "lblFoto"
        Me.lblFoto.Size = New System.Drawing.Size(88, 25)
        Me.lblFoto.TabIndex = 9
        Me.lblFoto.Text = "Fotografía"
        Me.lblFoto.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.lblFoto.UseCustomBackColor = True
        '
        'txtDescripcion
        '
        Me.txtDescripcion.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtDescripcion.Lines = New String(-1) {}
        Me.txtDescripcion.Location = New System.Drawing.Point(16, 180)
        Me.txtDescripcion.MaxLength = 32767
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDescripcion.SelectedText = ""
        Me.txtDescripcion.Size = New System.Drawing.Size(250, 184)
        Me.txtDescripcion.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtDescripcion.TabIndex = 10
        Me.txtDescripcion.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtDescripcion.UseSelectable = True
        '
        'pbxFoto
        '
        Me.pbxFoto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbxFoto.BackColor = System.Drawing.Color.Transparent
        Me.pbxFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbxFoto.Location = New System.Drawing.Point(334, 114)
        Me.pbxFoto.Margin = New System.Windows.Forms.Padding(3, 0, 16, 0)
        Me.pbxFoto.Name = "pbxFoto"
        Me.pbxFoto.Size = New System.Drawing.Size(250, 250)
        Me.pbxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxFoto.TabIndex = 8
        Me.pbxFoto.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btnCancelar)
        Me.Panel3.Controls.Add(Me.btnGuardar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 442)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(600, 67)
        Me.Panel3.TabIndex = 1
        '
        'btnCancelar
        '
        Me.btnCancelar.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnCancelar.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.btnCancelar.Location = New System.Drawing.Point(16, 21)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(16)
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
        Me.btnGuardar.Location = New System.Drawing.Point(459, 21)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(16)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(125, 30)
        Me.btnGuardar.Style = MetroFramework.MetroColorStyle.Purple
        Me.btnGuardar.TabIndex = 4
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnGuardar.UseSelectable = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(600, 67)
        Me.Panel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(600, 67)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "MODIFICAR TIPO DE MAQUINA"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTipoDeMaquina
        '
        Me.lblTipoDeMaquina.AutoSize = True
        Me.lblTipoDeMaquina.BackColor = System.Drawing.Color.Transparent
        Me.lblTipoDeMaquina.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblTipoDeMaquina.Location = New System.Drawing.Point(16, 86)
        Me.lblTipoDeMaquina.Margin = New System.Windows.Forms.Padding(16, 16, 3, 0)
        Me.lblTipoDeMaquina.Name = "lblTipoDeMaquina"
        Me.lblTipoDeMaquina.Size = New System.Drawing.Size(141, 25)
        Me.lblTipoDeMaquina.TabIndex = 0
        Me.lblTipoDeMaquina.Text = "Tipo de máquina"
        Me.lblTipoDeMaquina.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.lblTipoDeMaquina.UseCustomBackColor = True
        '
        'txtTipoDeMaquina
        '
        Me.txtTipoDeMaquina.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtTipoDeMaquina.Lines = New String(-1) {}
        Me.txtTipoDeMaquina.Location = New System.Drawing.Point(16, 114)
        Me.txtTipoDeMaquina.MaxLength = 32767
        Me.txtTipoDeMaquina.Name = "txtTipoDeMaquina"
        Me.txtTipoDeMaquina.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTipoDeMaquina.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTipoDeMaquina.SelectedText = ""
        Me.txtTipoDeMaquina.Size = New System.Drawing.Size(250, 35)
        Me.txtTipoDeMaquina.Style = MetroFramework.MetroColorStyle.Purple
        Me.txtTipoDeMaquina.TabIndex = 1
        Me.txtTipoDeMaquina.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtTipoDeMaquina.UseSelectable = True
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.BackColor = System.Drawing.Color.Transparent
        Me.lblDescripcion.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblDescripcion.Location = New System.Drawing.Point(16, 152)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(100, 25)
        Me.lblDescripcion.TabIndex = 0
        Me.lblDescripcion.Text = "Descripción"
        Me.lblDescripcion.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.lblDescripcion.UseCustomBackColor = True
        '
        'FrmModificarTipoDeMaquina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmModificarTipoDeMaquina"
        Me.Size = New System.Drawing.Size(960, 695)
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErPrExcepciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbxFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ofdBuscar As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtNombreImagen As MetroFramework.Controls.MetroTextBox
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErPrExcepciones As System.Windows.Forms.ErrorProvider
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnEliminarFoto As MetroFramework.Controls.MetroButton
    Friend WithEvents lblFoto As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtDescripcion As MetroFramework.Controls.MetroTextBox
    Friend WithEvents pbxFoto As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnCancelar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnGuardar As MetroFramework.Controls.MetroButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTipoDeMaquina As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtTipoDeMaquina As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblDescripcion As MetroFramework.Controls.MetroLabel

End Class
