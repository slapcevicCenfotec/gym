''' <summary>
''' Autor: Alexis Soto
''' Fecha: 03/15/2015
''' Descripcion: Instancia del User COntrol Modificar Datos del gimnasio
''' </summary>
Public Class FrmGimnasio
    Inherits MetroFramework.Controls.MetroUserControl
    Dim id As Int32
    Dim modo As String


    ''' <summary>
    ''' Autor: Alexis Soto
    ''' Fecha: 03/15/2015
    ''' Descripcion:Inicializa una instancia de<see cref="FrmGimnasio"/> class.
    ''' </summary>
    ''' <param name="pmodo">The pmodo.</param>
    ''' <param name="pid">The pid.</param>
    Public Sub New(pmodo As String, pid As Int32)
        InitializeComponent()
        ''Determina el modo del UserControl Modificar o Insertar en caso de que se no haya configurado
        modo = pmodo
        If modo = "Modificar" Then
            llenarCampos(pid)
            id = pid
        End If

    End Sub
    ''' <summary>
    ''' Autor: Alexis Soto
    ''' Fecha: 03/15/2015
    ''' Descripcion: Obtiene los datos del gimnasio al pasar el ID
    ''' </summary>
    ''' <param name="pIdGim">The p identifier rol.</param>
    Private Sub llenarCampos(pIdGim As Int32)
        For Each item In objGestorGimnasio.obtenerGimnasio(pIdGim)
            txtNombre.Text = item.Nombre
            txtUbicacion.Text = item.Ubicacion
            txtTelefono.Text = item.Telefono
            txtFax.Text = item.Fax
            txtCedulaJuridica.Text = item.CedulaJuridica
        Next
    End Sub
    ''' <summary>
    ''' Handles the Load event of the FrmGimnasio control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub FrmGimnasio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ''' <summary>
    ''' Autor: Alexis Soto
    ''' Fecha: 03/15/2015
    ''' Descripcion: Obtiene  los datos del UserCOntrol y los envia a Insertar
    ''' </summary>
    Public Sub insertarGimnasio()
        Dim nombre As String
        Dim descripcion As String
        Dim ubicacion As String
        Dim telefono As String
        Dim fax As String
        Dim cedulaJuridica As String

        nombre = Me.txtNombre.Text
        descripcion = Me.txtUbicacion.Text
        ubicacion = Me.txtUbicacion.Text
        telefono = Me.txtTelefono.Text
        fax = Me.txtFax.Text
        cedulaJuridica = Me.txtCedulaJuridica.Text


        objGestorGimnasio.insertarGimnasio(nombre, ubicacion, telefono, fax, cedulaJuridica)


    End Sub

    ''' <summary>
    ''' Autor: Alexis Soto
    ''' Fecha: 03/15/2015
    ''' Descripcion: Obtiene  los datos del UserCOntrol y los envia a modificar
    ''' </summary>
    Public Sub modificarGimnasio()
        Dim nombre As String
        Dim ubicacion As String
        Dim telefono As String
        Dim fax As String
        Dim cedulaJuridica As String


        nombre = Me.txtNombre.Text
        ubicacion = Me.txtUbicacion.Text
        telefono = Me.txtTelefono.Text
        fax = Me.txtFax.Text
        cedulaJuridica = Me.txtCedulaJuridica.Text
        objGestorGimnasio.ModificarGimnasio(id, nombre, ubicacion, telefono, fax, cedulaJuridica)
    End Sub

    ''' <summary>
    ''' Autor: Alexis Soto
    ''' Fecha: 03/15/2015
    ''' Descripcion: Valida los datos del formuario y llama al metdoo Insertar o modificar dependiendo del modo
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub btnGuardar_Click_1(sender As Object, e As EventArgs) Handles btnGuardar.Click
        ErrorProvider.Clear()
        If txtNombre.Text = "" Then
            ErrorProvider.SetError(txtNombre, "El nombre es un campo obligatorio")
        ElseIf txtUbicacion.Text = "" Then
            ErrorProvider.SetError(txtUbicacion, "La Ubicacion es un campo obligatorio")
        ElseIf txtTelefono.Text = "" Then
            ErrorProvider.SetError(txtTelefono, "El Telefono es un campo obligatorio")
        ElseIf txtFax.Text = "" Then
            ErrorProvider.SetError(txtFax, "El Fax es un campo obligatorio")
        ElseIf txtCedulaJuridica.Text = "" Then
            ErrorProvider.SetError(txtCedulaJuridica, "La Cedula Juridica es un campo obligatorio")
        Else
            If modo = "Modificar" Then
                modificarGimnasio()
                Me.Controls.Clear()
                Me.Dispose()
            Else
                insertarGimnasio()
                Me.Controls.Clear()
                Me.Dispose()
            End If
        End If

    End Sub

    ''' <summary>
    ''' Autor: Alexis Soto
    ''' Fecha: 03/15/2015
    ''' Descripcion: Cierra el Formulario
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub
End Class
