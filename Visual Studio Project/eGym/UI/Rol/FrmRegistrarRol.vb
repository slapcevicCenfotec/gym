Public Class FrmRegistrarRol

    Private Sub FrmRegistrarRol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarPermisos()
    End Sub

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
            pnlPermisos.Controls.Add(chK)
            initiaValue = initiaValue + 15
        Next
    End Sub


    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click


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

    Private Sub frmListarRoles()
        Dim ctr As Control
        ctr = New FrmListarRoles
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub


    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        frmListarRoles()
    End Sub

End Class
