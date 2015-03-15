﻿''' <summary>
''' Autor: Alexis Soto
''' Fecha: 03/15/2015
''' Descripcion: Instancia del User COntrol Modificar Rol
''' </summary>
Public Class FrmModificarRol
    Inherits MetroFramework.Controls.MetroUserControl
    Dim idRol As Integer
    ''' <summary>
    ''' Autor: Alexis Soto
    ''' Fecha: 03/15/2015
    ''' Descripcion: Inizializa una instacia de <see cref="FrmModificarRol"/> class.
    ''' </summary>
    ''' <param name="pIdRol">The p identifier rol.</param>
    Public Sub New(pIdRol As Int32)
        InitializeComponent()
        llenarCampos(pIdRol)
    End Sub


    ''' <summary>
    ''' Autor: Alexis Soto
    ''' Fecha: 03/15/2015
    ''' Descripcion: Agrega a una instancia Rol los datso del formulario y llama al metodo modificarRol
    ''' </summary>
    Public Sub modificarRol()
        Dim nombre As String
        Dim descripcion As String
        Dim lstItems As CheckBox
        Dim list As New List(Of Integer)
        nombre = Me.txtNombre.Text
        descripcion = Me.txtDescripcion.Text
        For Each item As Object In pnlPermisos.Controls
            Dim lstItem As String
            lstItem = CType(item, MetroFramework.Controls.MetroCheckBox).Name.Replace("CHK_", "")
            lstItems = New MetroFramework.Controls.MetroCheckBox
            If CType(item, MetroFramework.Controls.MetroCheckBox).Checked = True Then
                list.Add(lstItem)
            End If
        Next

        objGestorRol.ModificarRol(idRol, nombre, descripcion, list)
        frmListarRoles()
    End Sub



    ''' <summary>
    ''' Autor: Alexis Soto
    ''' Fecha: 03/15/2015
    ''' Descripcion: Valida que se haya seleccionado al menos un rol
    ''' </summary>
    ''' <returns></returns>
    Public Function validarPermisos() As Boolean
        Dim validarPermiso As Boolean
        validarPermiso = False

        For Each item As Object In pnlPermisos.Controls
            If CType(item, MetroFramework.Controls.MetroCheckBox).Checked = True Then
                validarPermiso = True
            End If
        Next

        Return validarPermiso
    End Function
    Private Sub FrmModificarRol_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ''' <summary>
    ''' Autor: Alexis Soto
    ''' Fecha: 03/15/2015
    ''' Descripcion: Obtiene la lista de permisoPorRol enviando como parametro el id del Rol
    ''' </summary>
    ''' <param name="pIdRol">The p identifier rol.</param>
    Private Sub llenarCampos(pIdRol As Int32)
        For Each item In objGestorRol.obtenerRol(pIdRol)
            txtNombre.Text = item.Nombre
            txtDescripcion.Text = item.Descripcion
            idRol = item.Id
            ListarPermisos(item.ListaPermisos)
        Next
    End Sub

    ''' <summary>
    ''' Autor: Alexis Soto
    ''' Fecha: 03/15/2015
    ''' Descripcion: Obtiene la lista de permisoPorRol enviando como parametro el id del Rol
    ''' </summary>
    ''' <param name="plistaPermisoRol">The plista permiso rol.</param>
    Private Sub ListarPermisos(plistaPermisoRol As Object)
        Dim offset As Integer
        Dim initiaValue As Integer
        Dim idChecked As Integer

        offset = 10
        initiaValue = 10

        objGestorPermiso.listarPermisos()

        pnlPermisos.Controls.Clear()
        For Each item In objGestorPermiso.listarPermisos()
            Dim chK As MetroFramework.Controls.MetroCheckBox
            chK = New MetroFramework.Controls.MetroCheckBox
            chK.Name = "CHK_" & item.Id
            chK.Text = item.Nombre
            chK.Location = New Point(offset, initiaValue)
            chK.Style = MetroFramework.MetroColorStyle.Purple
            chK.Theme = MetroFramework.MetroThemeStyle.Dark
            chK.FontSize = MetroFramework.MetroCheckBoxSize.Tall
            chK.FontWeight = MetroFramework.MetroCheckBoxWeight.Light
            chK.Size = New Size(150, 25)
            chK.UseCustomBackColor = True
            chK.BackColor = Color.Empty
            For Each permiso In plistaPermisoRol
                idChecked = CType(permiso, EL.Permiso).Id
                If item.Id = idChecked Then
                    chK.Checked = True
                End If
            Next
            pnlPermisos.Controls.Add(chK)
            initiaValue = initiaValue + 20
        Next
    End Sub

    ''' <summary>
    ''' Autor: Alexis Soto
    ''' Fecha: 03/15/2015
    ''' Descripcion: Crea una instancia FrmListarRoles para volver a la lista de roles
    ''' </summary>
    Private Sub frmListarRoles()
        Dim ctr As Control
        ctr = New FrmListarRoles
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub

    ''' <summary>
    ''' Autor: Alexis Soto
    ''' Fecha: 03/15/2015
    ''' Descripcion: Valida los campos del formulario y posteriormente llama al metodo ModificarRol
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub btnGuardar_Click_1(sender As Object, e As EventArgs) Handles btnGuardar.Click
        ErrorProvider.Clear()
        If txtNombre.Text = "" Then
            ErrorProvider.SetError(txtNombre, "El nombre es un campo obligatorio")
        ElseIf txtDescripcion.Text = "" Then
            ErrorProvider.SetError(txtDescripcion, "La Descripcion es un campo obligatorio")
        ElseIf validarPermisos() = False Then
            ErrorProvider.SetError(pnlPermisos, "Debe de seleccionar al menos un Rol")
        Else
            modificarRol()
        End If
    End Sub

    ''' <summary>
    ''' Autor: Alexis Soto
    ''' Fecha: 03/15/2015
    ''' Descripcion: LLama al User Control FrmListarRoles
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub btnCancelar_Click_1(sender As Object, e As EventArgs) Handles btnCancelar.Click
        frmListarRoles()
    End Sub
End Class
