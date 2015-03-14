Imports EL

Public Class FrmRegistrarMusculo

    Private validar As Boolean = True


    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim resulValidation As Boolean

        resulValidation = validation()

        If resulValidation Then

            Dim nombre As String = Me.txtNombre.Text
            Dim ubicacion As String = Me.txtUbicacion.Text
            Dim origen As String = Me.txtOrigen.Text
            Dim inserccion As String = Me.txtInserccion.Text
            Dim inervacion As String = Me.txtInervacion.Text
            Dim irrigacion As String = Me.txtIrrigacion.Text

            objGestorMusculo.agregarMusculo(nombre, ubicacion, origen, inserccion, inervacion, irrigacion)
        End If
    End Sub

    Private Function validation() As Boolean

        Dim validar As Boolean = True

        If Not cls_validacion.validar(txtNombre) Then
            validar = False
        End If

        If Not cls_validacion.validar(txtUbicacion) Then
            validar = False
        End If

        If Not cls_validacion.validar(txtOrigen) Then
            validar = False
        End If

        If Not cls_validacion.validar(txtInserccion) Then
            validar = False
        End If

        If Not cls_validacion.validar(txtInervacion) Then
            validar = False
        End If

        If Not cls_validacion.validar(txtIrrigacion) Then
            validar = False
        End If

        Return validar

    End Function

    Private Sub txtIrrigacion_Click(sender As Object, e As EventArgs) Handles txtIrrigacion.Click

    End Sub

    Private Sub txtInervacion_Click(sender As Object, e As EventArgs) Handles txtInervacion.Click

    End Sub

    Private Sub txtInserccion_Click(sender As Object, e As EventArgs) Handles txtInserccion.Click

    End Sub

    Private Sub txtOrigen_Click(sender As Object, e As EventArgs) Handles txtOrigen.Click

    End Sub

    Private Sub txtUbicacion_Click(sender As Object, e As EventArgs) Handles txtUbicacion.Click

    End Sub

    Private Sub txtNombre_Click(sender As Object, e As EventArgs) Handles txtNombre.Click

    End Sub

    Private Sub MetroLabel6_Click(sender As Object, e As EventArgs) Handles MetroLabel6.Click

    End Sub

    Private Sub MetroLabel5_Click(sender As Object, e As EventArgs) Handles MetroLabel5.Click

    End Sub

    Private Sub MetroLabel4_Click(sender As Object, e As EventArgs) Handles MetroLabel4.Click

    End Sub

    Private Sub MetroLabel3_Click(sender As Object, e As EventArgs) Handles MetroLabel3.Click

    End Sub

    Private Sub MetroLabel2_Click(sender As Object, e As EventArgs) Handles MetroLabel2.Click

    End Sub

    Private Sub MetroLabel1_Click(sender As Object, e As EventArgs) Handles MetroLabel1.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
