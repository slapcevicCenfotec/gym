Imports EL
Imports System.Text.RegularExpressions
Public Class FrmRegistrarTipoDePago
    Dim montoRegex As Regex = New Regex("[-+]?([0-9]*\.[0-9]+|[0-9]+)")
    Dim duracionRegex As Regex = New Regex("^[0-9]+$")

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.regresaListar()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If validarAgregarTipoDePago() = True Then
                objGestorTipoPago.insertarTipoDePago(txtNombre.Text, txtMonto.Text, txtDuracion.Text)
                Me.regresaListar()
            End If
        Catch ex As Exception
            ErPrExcepciones.SetError(btnGuardar, ex.Message)
        End Try
        
    End Sub
    Sub clearScreen()
        Me.txtMonto.Text = String.Empty
        Me.txtDuracion.Text = String.Empty
        Me.txtNombre.Text = String.Empty
    End Sub
    Private Sub regresaListar()
        Dim ctr As Control
        ctr = New FrmListarTipoDePago
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub


    Private Function validarAgregarTipoDePago() As Boolean
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
            End If
            ErPrValidaciones.SetError(txtMonto, "")
        End If

        If txtDuracion.Text.Length = 0 Then
            ErPrValidaciones.SetError(txtDuracion, "La duracion es un dato obligatorio")
            validado = False
        Else
            If duracionRegex.IsMatch(txtDuracion.Text) = False Then
                validado = False
                ErPrValidaciones.SetError(txtDuracion, "Duracion debe ser un numero")
            End If
            ErPrValidaciones.SetError(txtDuracion, "")
        End If
        Return validado
    End Function

    Private Sub txtNombre_Click(sender As Object, e As EventArgs) Handles txtNombre.Click

    End Sub

    Private Sub lblTipoDePagoNombre_Click(sender As Object, e As EventArgs) Handles lblTipoDePagoNombre.Click

    End Sub

    Private Sub MetroPanel1_Paint(sender As Object, e As PaintEventArgs) Handles MetroPanel1.Paint

    End Sub
End Class
