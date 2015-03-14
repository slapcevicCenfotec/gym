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

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs)

        Dim resulValidation As Boolean

        resulValidation = validation()

        If resulValidation Then
            objGestorMusculo.modificarMusculo(musculoPorModificar.Id, txtNombre.Text, txtUbicacion.Text, txtOrigen.Text, txtInserccion.Text, txtInervacion.Text, txtIrrigacion.Text)

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

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs)
        Dim resulValidation As Boolean

        resulValidation = validation()

        If resulValidation Then
            objGestorMusculo.modificarMusculo(musculoPorModificar.Id, txtNombre.Text, txtUbicacion.Text, txtOrigen.Text, txtInserccion.Text, txtInervacion.Text, txtIrrigacion.Text)

        End If
    End Sub

End Class
