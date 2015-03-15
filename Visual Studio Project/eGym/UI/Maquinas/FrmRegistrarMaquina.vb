Imports EL

Public Class lblTitulo

    Private Sub FrmRegistrarMaquina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbTipoDeMaquina.DataSource = objGestorTipoDeMaquina.listarTiposDeMaquinas()
        cmbTipoDeMaquina.DisplayMember = "Nombre"
        cmbTipoDeMaquina.ValueMember = "Id"

        txtNumeroDeActivo.MaxLength = 50
        txtNumeroDeMaquina.MaxLength = 50
        cmbTipoDeMaquina.SelectedItem = Nothing

    End Sub


    Private Function validarFormRegistrarMaquina() As Boolean
        Dim validado As Boolean = True
        If txtNumeroDeActivo.Text.Length = 0 Then
            ErPrValidaciones.SetError(txtNumeroDeActivo, "El número de activo es un campo obligatorio")
            validado = False
        Else
            ErPrValidaciones.SetError(txtNumeroDeActivo, "")
        End If

        If txtNumeroDeMaquina.Text.Length = 0 Then
            ErPrValidaciones.SetError(txtNumeroDeMaquina, "El número de máquina es un campo obligatorio")
            validado = False
        Else
            ErPrValidaciones.SetError(txtNumeroDeMaquina, "")
        End If

        If cmbTipoDeMaquina.SelectedValue = Nothing Then
            ErPrValidaciones.SetError(cmbTipoDeMaquina, "El tipo de máquina es un campo obligatorio")
            validado = False
        Else
            ErPrValidaciones.SetError(cmbTipoDeMaquina, "")
        End If

        Return validado
    End Function

    Sub clearScreen()
        Me.txtNumeroDeActivo.Text = String.Empty
        Me.txtNumeroDeMaquina.Text = String.Empty
        Me.cmbTipoDeMaquina.SelectedItem = Nothing
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim numeroActivo As String = txtNumeroDeActivo.Text
        Dim numeroMaquina As String = txtNumeroDeMaquina.Text
        Dim tipoDeMaquina As String = cmbTipoDeMaquina.SelectedValue

        If validarFormRegistrarMaquina() Then
            Try
                objGestorMaquina.insertarMaquina(numeroActivo, numeroMaquina, tipoDeMaquina)
                clearScreen()

                Dim ctr As Control
                ctr = New FrmListarMaquinas
                ctr.Dock = DockStyle.Fill
                Me.Controls.Clear()
                Me.Controls.Add(ctr)
            Catch ex As Exception
                ErPrExcepciones.SetError(btnGuardar, ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        clearScreen()

        Dim ctr As Control
        ctr = New FrmListarMaquinas
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub
End Class
