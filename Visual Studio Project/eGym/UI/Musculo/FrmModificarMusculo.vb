Imports EL

Public Class FrmModificarMusculo

    Private musculoPorModificar As Musculo
    Private validar As Boolean

    Public Sub New(ByVal pMusculo As Musculo)
        Me.musculoPorModificar = pMusculo
        InitializeComponent()
    End Sub

    Private Sub FrmModificarMusculo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNombre.Text = musculoPorModificar.Nombre
        txtUbicacion.Text = musculoPorModificar.Ubicacion
        txtOrigen.Text = musculoPorModificar.Origen
        txtInserccion.Text = musculoPorModificar.Inserccion
        txtInervacion.Text = musculoPorModificar.Inervacion
        txtIrrigacion.Text = musculoPorModificar.Irrigacion

    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        If Not cls_validacion.validar(txtNombre) Then
            MessageBox.Show("Por favor digite la nombre del musculo", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNombre.Focus()
            validar = False
            Return
        End If

        If Not cls_validacion.validar(txtUbicacion) Then
            MessageBox.Show("Por favor digite la ubicacion del musculo", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUbicacion.Focus()
            validar = False
            Return
        End If

        If Not cls_validacion.validar(txtOrigen) Then
            MessageBox.Show("Por favor digite el origen del musculo", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtOrigen.Focus()
            validar = False
            Return
        End If

        If Not cls_validacion.validar(txtInserccion) Then
            MessageBox.Show("Por favor digite la inserccion del musculo", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtInserccion.Focus()
            validar = False
            Return
        End If

        If Not cls_validacion.validar(txtInervacion) Then
            MessageBox.Show("Por favor digite la inervacion del musculo", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtInervacion.Focus()
            validar = False
            Return
        End If

        If Not cls_validacion.validar(txtIrrigacion) Then
            MessageBox.Show("Por favor digite la irrigacion del musculo", "Validacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtInervacion.Focus()
            validar = False
            Return
        End If

        objGestorMusculo.modificarMusculo(musculoPorModificar.Id, txtNombre.Text, txtUbicacion.Text, txtOrigen.Text, txtInserccion.Text, txtInervacion.Text, txtIrrigacion.Text)
    End Sub
End Class
