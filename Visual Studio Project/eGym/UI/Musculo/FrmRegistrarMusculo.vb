Imports EL
''' <summary>
''' Autor: Danny Espinoza
''' Fecha: 03/15/2015
''' Descripcion: Instancia del User COntrol para registrar músculo
''' </summary>
''' <remarks></remarks>
Public Class FrmRegistrarMusculo

    Private validar As Boolean = True

    ''' <summary>
    ''' Autor: Danny Espinoza
    ''' Fecha: 03/15/2015
    ''' Descripcion: Botón de evento que agregar el músculo
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs)
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
    ''' <summary>
    ''' Autor: Danny Espinoza
    ''' Fecha: 03/15/2015
    ''' Descripcion: metodo que valida los campos de formulario
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
    ''' Descripcion: Botón de evento que agregar el músculo
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
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
    ''' Descripcion: Botón de evento que returna al formulario de lista
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
