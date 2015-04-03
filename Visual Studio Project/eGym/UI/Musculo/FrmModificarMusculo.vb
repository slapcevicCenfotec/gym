Imports EL

''' <summary>
''' Autor: Danny Espinoza
''' Fecha: 03/15/2015
''' Descripcion: Instancia del User COntrol Modificar Musculo
''' </summary>
''' <remarks></remarks>
Public Class FrmModificarMusculo

    Private musculoPorModificar As Musculo
    Private validar As Boolean
    ''' <summary>
    ''' Autor: Danny Espinoza
    ''' Fecha: 03/15/2015
    ''' Descripcion: Recibi el musculo que se desea modificar
    ''' </summary>
    ''' <param name="pMusculo"></param>
    ''' <remarks></remarks>
    Public Sub New(ByVal pMusculo As Musculo)
        Me.musculoPorModificar = pMusculo
        InitializeComponent()
    End Sub
    ''' <summary>
    ''' Autor: Danny Espinoza
    ''' Fecha: 03/15/2015
    ''' Descripcion: Carga informacíon del objeto que se va a modificar
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub FrmModificarMusculo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNombre.Text = musculoPorModificar.Nombre
        txtUbicacion.Text = musculoPorModificar.Ubicacion
        txtOrigen.Text = musculoPorModificar.Origen
        txtInserccion.Text = musculoPorModificar.Inserccion
        txtInervacion.Text = musculoPorModificar.Inervacion
        txtIrrigacion.Text = musculoPorModificar.Irrigacion

    End Sub
    ''' <summary>
    ''' Autor: Danny Espinoza
    ''' Fecha: 03/15/2015
    ''' Descripcion: Instancia del User COntrol Modificar Musculo
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function validation() As Boolean

        Dim validar As Boolean = True

        If Not cls_validacion.validar(txtNombre) Then
            ErrorProvider1.SetError(txtNombre, "Debe ingresar el nombre")
            validar = False
        End If

        If Not cls_validacion.validar(txtUbicacion) Then
            ErrorProvider1.SetError(txtUbicacion, "Debe ingresar la ubicación")
            validar = False
        End If

        If Not cls_validacion.validar(txtOrigen) Then
            ErrorProvider1.SetError(txtOrigen, "Debe ingresar el origen")
            validar = False
        End If

        If Not cls_validacion.validar(txtInserccion) Then
            ErrorProvider1.SetError(txtInserccion, "Debe ingresar la insercción")
            validar = False
        End If

        If Not cls_validacion.validar(txtInervacion) Then
            ErrorProvider1.SetError(txtInervacion, "Debe ingresar la inervación")
            validar = False
        End If

        If Not cls_validacion.validar(txtIrrigacion) Then
            ErrorProvider1.SetError(txtIrrigacion, "Debe ingresar la irrigación")
            validar = False
        End If

        Return validar

    End Function
   ''' <summary>
    ''' Autor: Danny Espinoza
    ''' Fecha: 03/15/2015
    ''' Descripcion: Botón de evento que modificar el músculo
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim resulValidation As Boolean

        resulValidation = validation()

        If resulValidation Then
            objGestorMusculo.modificarMusculo(musculoPorModificar.Id, txtNombre.Text, txtUbicacion.Text, txtOrigen.Text, txtInserccion.Text, txtInervacion.Text, txtIrrigacion.Text)
            Dim ctr As Control
            ctr = New FrmListarMusculo
            ctr.Dock = DockStyle.Fill
            Me.Controls.Clear()
            Me.Controls.Add(ctr)
        End If
    End Sub
    ''' <summary>
    ''' Autor: Danny Espinoza
    ''' Fecha: 03/15/2015
    ''' Descripcion: Botón de evento que retorna al formulario de listar músculos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim ctr As Control
        ctr = New FrmListarMusculo
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub
End Class
