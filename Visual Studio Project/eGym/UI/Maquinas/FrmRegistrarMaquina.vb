Imports EL

Public Class FrmRegistrarMaquina
    Private Property listaTiposDeMaquinas As List(Of TipoDeMaquina)

    Private Sub FrmRegistrarMaquina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbTipoDeMaquina.DataSource = objGestorTipoDeMaquina.listarTiposDeMaquinas()
        cmbTipoDeMaquina.DisplayMember = "Nombre"
        cmbTipoDeMaquina.ValueMember = "Id"

        txtNumeroDeActivo.MaxLength = 50
        txtNumeroDeMaquina.MaxLength = 50

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim numeroActivo As String = txtNumeroDeActivo.Text
        Dim numeroMaquina As String = txtNumeroDeMaquina.Text
        Dim tipoDeMaquina As String = cmbTipoDeMaquina.SelectedValue
        Dim habilitado As Boolean = True
        Dim idTipoMaquina As Integer

        If validarFormRegistrarMaquina() Then
            objGestorMaquina.insertarMaquina(numeroActivo, numeroMaquina, habilitado, idTipoMaquina)
            clearScreen()
        End If

    End Sub

    Private Function validarFormRegistrarMaquina() As Boolean
        Dim validado As Boolean = True
        If txtNumeroDeActivo.Text.Length = 0 Then
            ErrorProvider.SetError(txtNumeroDeActivo, "El número de activo es un campo obligatorio")
            validado = False
        Else
            ErrorProvider.SetError(txtNumeroDeActivo, "")
        End If

        If txtNumeroDeMaquina.Text.Length = 0 Then
            ErrorProvider.SetError(txtNumeroDeMaquina, "El número de máquina es un campo obligatorio")
            validado = False
        Else
            ErrorProvider.SetError(txtNumeroDeMaquina, "")
        End If

        If cmbTipoDeMaquina.SelectedItem = Nothing Then
            ErrorProvider.SetError(cmbTipoDeMaquina, "El tipo de máquina es un campo obligatorio")
            validado = False
        Else
            ErrorProvider.SetError(cmbTipoDeMaquina, "")
        End If

        Return validado
    End Function

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        clearScreen()

        Dim ctr As Control
        ctr = New FrmListarMaquinas
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub

    Sub clearScreen()
        Me.txtNumeroDeActivo.Text = String.Empty
        Me.txtNumeroDeMaquina.Text = String.Empty
        Me.cmbTipoDeMaquina.SelectedItem = Nothing
    End Sub
End Class
