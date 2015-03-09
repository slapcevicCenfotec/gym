Imports EL

Public Class FrmRegistrarMusculo

    Private validar As Boolean = True


    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click

        'If Not cls_validacion.validar(txtNombre) Then
        '    MessageBox.Show("Por favor digite la nombre del musculo", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    txtNombre.Focus()
        '    validar = False
        '    Return
        'End If

        'If Not cls_validacion.validar(txtUbicacion) Then
        '    MessageBox.Show("Por favor digite la ubicacion del musculo", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    txtUbicacion.Focus()
        '    validar = False
        '    Return
        'End If

        'If Not cls_validacion.validar(txtOrigen) Then
        '    MessageBox.Show("Por favor digite el origen del musculo", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    txtOrigen.Focus()
        '    validar = False
        '    Return
        'End If

        'If Not cls_validacion.validar(txtInserccion) Then
        '    MessageBox.Show("Por favor digite la inserccion del musculo", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    txtInserccion.Focus()
        '    validar = False
        '    Return
        'End If

        'If Not cls_validacion.validar(txtInervacion) Then
        '    MessageBox.Show("Por favor digite la inervacion del musculo", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    txtInervacion.Focus()
        '    validar = False
        '    Return
        'End If

        'If Not cls_validacion.validar(txtIrrigacion) Then
        '    MessageBox.Show("Por favor digite la irrigacion del musculo", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    txtInervacion.Focus()
        '    validar = False
        '    Return
        'End If

        Dim nombre As String = Me.txtNombre.Text
        Dim ubicacion As String = Me.txtUbicacion.Text
        Dim origen As String = Me.txtOrigen.Text
        Dim inserccion As String = Me.txtInserccion.Text
        Dim inervacion As String = Me.txtInervacion.Text
        Dim irrigacion As String = Me.txtIrrigacion.Text

        objGestorMusculo.agregarMusculo(nombre, ubicacion, origen, inserccion, inervacion, irrigacion)
    End Sub

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
