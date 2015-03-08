<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistrarMusculo
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
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.txtNombre = New MetroFramework.Controls.MetroTextBox()
        Me.txtUbicacion = New MetroFramework.Controls.MetroTextBox()
        Me.txtOrigen = New MetroFramework.Controls.MetroTextBox()
        Me.txtInserccion = New MetroFramework.Controls.MetroTextBox()
        Me.txtInervacion = New MetroFramework.Controls.MetroTextBox()
        Me.txtIrrigacion = New MetroFramework.Controls.MetroTextBox()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(55, 45)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(66, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Nombre :"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(55, 91)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(73, 19)
        Me.MetroLabel2.TabIndex = 1
        Me.MetroLabel2.Text = "Ubicacion :"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(55, 134)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(57, 19)
        Me.MetroLabel3.TabIndex = 2
        Me.MetroLabel3.Text = "Origen :"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(55, 181)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(73, 19)
        Me.MetroLabel4.TabIndex = 3
        Me.MetroLabel4.Text = "Insercción :"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(55, 224)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(75, 19)
        Me.MetroLabel5.TabIndex = 4
        Me.MetroLabel5.Text = "Inervación :"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(55, 272)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(71, 19)
        Me.MetroLabel6.TabIndex = 5
        Me.MetroLabel6.Text = "Irrigación :"
        '
        'txtNombre
        '
        Me.txtNombre.Lines = New String(-1) {}
        Me.txtNombre.Location = New System.Drawing.Point(180, 41)
        Me.txtNombre.MaxLength = 32767
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNombre.SelectedText = ""
        Me.txtNombre.Size = New System.Drawing.Size(104, 23)
        Me.txtNombre.TabIndex = 6
        Me.txtNombre.UseSelectable = True
        '
        'txtUbicacion
        '
        Me.txtUbicacion.Lines = New String(-1) {}
        Me.txtUbicacion.Location = New System.Drawing.Point(180, 87)
        Me.txtUbicacion.MaxLength = 32767
        Me.txtUbicacion.Name = "txtUbicacion"
        Me.txtUbicacion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUbicacion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtUbicacion.SelectedText = ""
        Me.txtUbicacion.Size = New System.Drawing.Size(104, 23)
        Me.txtUbicacion.TabIndex = 7
        Me.txtUbicacion.UseSelectable = True
        '
        'txtOrigen
        '
        Me.txtOrigen.Lines = New String(-1) {}
        Me.txtOrigen.Location = New System.Drawing.Point(180, 130)
        Me.txtOrigen.MaxLength = 32767
        Me.txtOrigen.Name = "txtOrigen"
        Me.txtOrigen.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtOrigen.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtOrigen.SelectedText = ""
        Me.txtOrigen.Size = New System.Drawing.Size(104, 23)
        Me.txtOrigen.TabIndex = 8
        Me.txtOrigen.UseSelectable = True
        '
        'txtInserccion
        '
        Me.txtInserccion.Lines = New String(-1) {}
        Me.txtInserccion.Location = New System.Drawing.Point(180, 177)
        Me.txtInserccion.MaxLength = 32767
        Me.txtInserccion.Name = "txtInserccion"
        Me.txtInserccion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtInserccion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtInserccion.SelectedText = ""
        Me.txtInserccion.Size = New System.Drawing.Size(104, 23)
        Me.txtInserccion.TabIndex = 9
        Me.txtInserccion.UseSelectable = True
        '
        'txtInervacion
        '
        Me.txtInervacion.Lines = New String(-1) {}
        Me.txtInervacion.Location = New System.Drawing.Point(180, 224)
        Me.txtInervacion.MaxLength = 32767
        Me.txtInervacion.Name = "txtInervacion"
        Me.txtInervacion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtInervacion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtInervacion.SelectedText = ""
        Me.txtInervacion.Size = New System.Drawing.Size(104, 23)
        Me.txtInervacion.TabIndex = 10
        Me.txtInervacion.UseSelectable = True
        '
        'txtIrrigacion
        '
        Me.txtIrrigacion.Lines = New String(-1) {}
        Me.txtIrrigacion.Location = New System.Drawing.Point(180, 268)
        Me.txtIrrigacion.MaxLength = 32767
        Me.txtIrrigacion.Name = "txtIrrigacion"
        Me.txtIrrigacion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIrrigacion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtIrrigacion.SelectedText = ""
        Me.txtIrrigacion.Size = New System.Drawing.Size(104, 23)
        Me.txtIrrigacion.TabIndex = 11
        Me.txtIrrigacion.UseSelectable = True
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(341, 45)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 23)
        Me.MetroButton1.TabIndex = 12
        Me.MetroButton1.Text = "Guardar"
        Me.MetroButton1.UseSelectable = True
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(445, 45)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(75, 23)
        Me.MetroButton2.TabIndex = 13
        Me.MetroButton2.Text = "Cancelar"
        Me.MetroButton2.UseSelectable = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.MetroLabel1)
        Me.Panel1.Controls.Add(Me.MetroButton2)
        Me.Panel1.Controls.Add(Me.MetroLabel2)
        Me.Panel1.Controls.Add(Me.MetroButton1)
        Me.Panel1.Controls.Add(Me.MetroLabel3)
        Me.Panel1.Controls.Add(Me.txtIrrigacion)
        Me.Panel1.Controls.Add(Me.MetroLabel4)
        Me.Panel1.Controls.Add(Me.txtInervacion)
        Me.Panel1.Controls.Add(Me.MetroLabel5)
        Me.Panel1.Controls.Add(Me.txtInserccion)
        Me.Panel1.Controls.Add(Me.MetroLabel6)
        Me.Panel1.Controls.Add(Me.txtOrigen)
        Me.Panel1.Controls.Add(Me.txtNombre)
        Me.Panel1.Controls.Add(Me.txtUbicacion)
        Me.Panel1.Location = New System.Drawing.Point(40, 35)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(531, 315)
        Me.Panel1.TabIndex = 14
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'FrmRegistrarMusculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmRegistrarMusculo"
        Me.Size = New System.Drawing.Size(632, 457)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNombre As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtUbicacion As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtOrigen As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtInserccion As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtInervacion As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtIrrigacion As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip

End Class
