﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistrarPago
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
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.txtMonto = New MetroFramework.Controls.MetroTextBox()
        Me.txtFactura = New MetroFramework.Controls.MetroTextBox()
        Me.txtDesde = New MetroFramework.Controls.MetroTextBox()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.seTipo = New MetroFramework.Controls.MetroComboBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(18, 12)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(96, 19)
        Me.MetroLabel1.TabIndex = 1
        Me.MetroLabel1.Text = "Registrar pago"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(159, 101)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(54, 19)
        Me.MetroLabel2.TabIndex = 2
        Me.MetroLabel2.Text = "Factura:"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(162, 134)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(51, 19)
        Me.MetroLabel3.TabIndex = 3
        Me.MetroLabel3.Text = "Monto:"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(175, 170)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(38, 19)
        Me.MetroLabel4.TabIndex = 4
        Me.MetroLabel4.Text = "Tipo:"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(165, 206)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(48, 19)
        Me.MetroLabel5.TabIndex = 5
        Me.MetroLabel5.Text = "Desde:"
        '
        'txtMonto
        '
        Me.txtMonto.Lines = New String(-1) {}
        Me.txtMonto.Location = New System.Drawing.Point(219, 130)
        Me.txtMonto.MaxLength = 32767
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMonto.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMonto.SelectedText = ""
        Me.txtMonto.Size = New System.Drawing.Size(184, 23)
        Me.txtMonto.TabIndex = 8
        Me.txtMonto.UseSelectable = True
        '
        'txtFactura
        '
        Me.txtFactura.Lines = New String(-1) {}
        Me.txtFactura.Location = New System.Drawing.Point(219, 96)
        Me.txtFactura.MaxLength = 32767
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFactura.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtFactura.SelectedText = ""
        Me.txtFactura.Size = New System.Drawing.Size(184, 23)
        Me.txtFactura.TabIndex = 9
        Me.txtFactura.UseSelectable = True
        '
        'txtDesde
        '
        Me.txtDesde.Lines = New String(-1) {}
        Me.txtDesde.Location = New System.Drawing.Point(219, 206)
        Me.txtDesde.MaxLength = 32767
        Me.txtDesde.Name = "txtDesde"
        Me.txtDesde.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDesde.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDesde.SelectedText = ""
        Me.txtDesde.Size = New System.Drawing.Size(184, 23)
        Me.txtDesde.TabIndex = 10
        Me.txtDesde.UseSelectable = True
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(327, 254)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 23)
        Me.MetroButton1.TabIndex = 11
        Me.MetroButton1.Text = "Cancelar"
        Me.MetroButton1.UseSelectable = True
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(219, 254)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(75, 23)
        Me.MetroButton2.TabIndex = 12
        Me.MetroButton2.Text = "Registrar"
        Me.MetroButton2.UseSelectable = True
        '
        'seTipo
        '
        Me.seTipo.FormattingEnabled = True
        Me.seTipo.ItemHeight = 23
        Me.seTipo.Location = New System.Drawing.Point(219, 170)
        Me.seTipo.Name = "seTipo"
        Me.seTipo.Size = New System.Drawing.Size(184, 29)
        Me.seTipo.TabIndex = 13
        Me.seTipo.UseSelectable = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider1.ContainerControl = Me
        '
        'FrmRegistrarPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.seTipo)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.txtDesde)
        Me.Controls.Add(Me.txtFactura)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Name = "FrmRegistrarPago"
        Me.Size = New System.Drawing.Size(592, 365)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtMonto As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtFactura As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtDesde As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents seTipo As MetroFramework.Controls.MetroComboBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider

End Class
