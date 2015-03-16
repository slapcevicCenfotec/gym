''' <summary>
''' Autor: Alexis Soto
''' Fecha: 03/15/2015
''' Descripcion: Instancia del User COntrol Agregar un Rol
''' </summary>
Public Class FrmRegistrarRol
    Inherits MetroFramework.Controls.MetroUserControl


    ''' <summary>
    ''' Autor: Alexis Soto
    ''' Fecha: 03/15/2015
    ''' Descripcion: LLama al metdod ListarPermisos para obtener lista de permisos al cargar el UserControl
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub FrmRegistrarRol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarPermisos()
    End Sub

    ''' <summary>
    ''' Autor: Alexis Soto
    ''' Fecha: 03/15/2015
    ''' Descripcion: Obtiene la lista de permisos y la agregar al Panel de permisos  en al User Control
    ''' </summary>
    Private Sub ListarPermisos()

        Dim offset As Integer
        Dim initiaValue As Integer

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
            chK.UseCustomBackColor = True
            chK.BackColor = Color.Empty
            chK.Size = New Size(150, 25)
            pnlPermisos.Controls.Add(chK)
            initiaValue = initiaValue + 20
        Next
    End Sub

    ''' <summary>
    ''' Autor: Alexis Soto
    ''' Fecha: 03/15/2015
    ''' Descripcion: Valida que se haya seleccionado al menos un permiso del panel de permisos
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



    ''' <summary>
    ''' Autor: Alexis Soto
    ''' Fecha: 03/15/2015
    ''' Descripcion: Obtiene los datos del UserControl y crea una instancia para guardar los datos
    ''' </summary>
    Public Sub insertarRol()
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

        objGestorRol.insertarRol(nombre, descripcion, list)

        MetroFramework.MetroMessageBox.Show(eGym, "Egym", "El Rol se registro existosamente")
        frmListarRoles()
    End Sub


    ''' <summary>
    ''' Autor: Alexis Soto
    ''' Fecha: 03/15/2015
    ''' Descripcion: Llama al user Control ListarRoles
    ''' </summary>
    Private Sub frmListarRoles()
        Dim ctr As Control
        ctr = New FrmListarRoles
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub

    ''' <summary>
    ''' Autor: Alexis Soto
    ''' Fecha: 03/15/2015
    ''' Descripcion: Valida los campos y llama al metodo para insertar un Rol
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
            insertarRol()
        End If
    End Sub

    ''' <summary>
    ''' Autor: Alexis Soto
    ''' Fecha: 03/15/2015
    ''' Descripcion: Lamma al metodo ListarRoles
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        frmListarRoles()
    End Sub

    Private Sub txtNombre_Click(sender As Object, e As EventArgs) Handles txtNombre.Click

    End Sub
End Class
