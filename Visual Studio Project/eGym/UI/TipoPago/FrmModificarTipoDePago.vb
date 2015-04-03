Imports EL
Imports System.Text.RegularExpressions
Public Class FrmModificarTipoDePago
    Public actual As TipoDePago
    Dim montoRegex As Regex = New Regex("^[0-9]+$")
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
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs)
        If validarModificarTipoDePago() = True Then
            objGestorTipoPago.modificarTipoDePago(actual.Id, txtNombre.Text, txtMonto.Text, txtDuracion.Text, 1)
        End If
    End Sub
    Private Sub MetroLabel4_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub MetroTextBox1_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub MetroTextBox2_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub MetroLabel3_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub MetroTextBox3_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub MetroLabel2_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub MetroButton2_Click(sender As Object, e As EventArgs)
        Dim ctr As Control
        ctr = New FrmListarTipoDePago
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub


    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim ctr As Control
        ctr = New FrmListarTipoDePago
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If validarModificarTipoDePago() = True Then
                objGestorTipoPago.modificarTipoDePago(actual.Id, txtNombre.Text, txtMonto.Text, txtDuracion.Text, 1)
                Dim ctr As Control
                ctr = New FrmListarTipoDePago
                ctr.Dock = DockStyle.Fill
                Me.Controls.Clear()
                Me.Controls.Add(ctr)
            End If
        Catch ex As Exception
            ErPrExcepciones.SetError(btnGuardar, ex.Message)
        End Try
    End Sub


    Private Function validarModificarTipoDePago() As Boolean
        Dim validado As Boolean = True
        If txtNombre.Text.Length = 0 Then
            ErPrValidaciones.SetError(txtNombre, "El nombre es un campo obligatorio")
            validado = False
        Else
            ErPrValidaciones.SetError(txtNombre, "")
        End If

        If txtMonto.Text.Length = 0 Then
            ErPrValidaciones.SetError(txtMonto, "El monto es un campo obligatorio")
            validado = False
        Else
            If montoRegex.IsMatch(txtMonto.Text) = False Then
                validado = False
                ErPrValidaciones.SetError(txtMonto, "Monto debe ser un numero")
            Else
                ErPrValidaciones.SetError(txtMonto, "")
            End If

        End If

        If txtDuracion.Text.Length = 0 Then
            ErPrValidaciones.SetError(txtDuracion, "La duracion es un dato obligatorio")
            validado = False
        Else
            If duracionRegex.IsMatch(txtDuracion.Text) = False Then
                validado = False
                ErPrValidaciones.SetError(txtDuracion, "Duracion debe ser un numero")
            Else
                ErPrValidaciones.SetError(txtDuracion, "")
            End If

        End If
        Return validado
    End Function


End Class
