Imports EL
Imports System.Text.RegularExpressions
Public Class FrmModificarTipoDePago
    Public actual As TipoDePago
    Dim montoRegex As Regex = New Regex("[+-]?(?=\d*[.eE])(?=\.?\d)\d*\.?\d*(?:[eE][+-]?\d+)?")
    Dim duracionRegex As Regex = New Regex("^[0-9]+$")
    Public Sub New(ByVal ptipoDePago As TipoDePago)
        actual = ptipoDePago
        InitializeComponent()
    End Sub
    Private Sub FrmAgregarTipoDePago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNombre.Text = actual.Nombre
        txtMonto.Text = actual.Monto
        txtDuracion.Text = actual.Duracion
    End Sub
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        If validarModificarTipoDePago() = True Then
            objGestorTipoPago.modificarTipoDePago(actual.Id, txtNombre.Text, txtMonto.Text, txtDuracion.Text, 1)
        End If
    End Sub
    Private Sub MetroLabel4_Click(sender As Object, e As EventArgs) Handles MetroLabel4.Click

    End Sub
    Private Sub MetroTextBox1_Click(sender As Object, e As EventArgs) Handles txtNombre.Click

    End Sub
    Private Sub MetroTextBox2_Click(sender As Object, e As EventArgs) Handles txtMonto.Click

    End Sub
    Private Sub MetroLabel3_Click(sender As Object, e As EventArgs) Handles MetroLabel3.Click

    End Sub
    Private Sub MetroTextBox3_Click(sender As Object, e As EventArgs) Handles txtDuracion.Click

    End Sub
    Private Sub MetroLabel2_Click(sender As Object, e As EventArgs) Handles MetroLabel2.Click

    End Sub
    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Dim ctr As Control
        ctr = New FrmListarTipoDePago
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub
    Private Function validarModificarTipoDePago() As Boolean

        Dim result As Boolean = True


        If txtNombre.Text = Nothing Then
            result = False
            ErrorProvider1.SetError(txtNombre, "Debe ingresar un nombre")
        End If
        If txtMonto.Text = Nothing Then
            result = False
            ErrorProvider1.SetError(txtMonto, "Debe ingresar un monto")
        Else
            If montoRegex.IsMatch(txtMonto.Text) = False Then
                result = False
                ErrorProvider1.SetError(txtMonto, "El campo monto debe ser un numero")
            End If
        End If
        If txtDuracion.Text = Nothing Then
            result = False
            ErrorProvider1.SetError(txtDuracion, "Debe ingresar una cantidad de dias.")
        Else
            If duracionRegex.IsMatch(txtDuracion.Text) = False Then
                result = False
                ErrorProvider1.SetError(txtDuracion, "El campo duracion debe ser de tipo numero")
            End If
        End If

        Return result

    End Function
End Class
