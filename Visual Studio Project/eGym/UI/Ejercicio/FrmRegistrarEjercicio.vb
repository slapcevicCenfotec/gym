Imports System.IO
Imports System.Drawing
Imports EL

Public Class FrmRegistrarEjercicio

    Private imageByte As Byte() = Nothing
    Private imageByte2 As Byte() = Nothing


    Private Sub MetroButton1_Click(sender As Object, e As EventArgs)
        ofdBuscar.Filter = "All Files (*.*)|*.*|JPEG Files (*.jpeg)|*.jpeg|JPEG Files (*.jpg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif"
        ofdBuscar.ShowDialog()
        ptbPosicionInicial.Image = Image.FromFile(ofdBuscar.FileName)
        'txtNombreImagen.Text = ofdBuscar.SafeFileName
    End Sub

    Private Function validation() As Boolean

        Dim validar As Boolean = True

        If Not cls_validacion.validar(txtNombre) Then
            ErrorProvider1.SetError(txtNombre, "Debe ingresar el nombre")
            validar = False
        End If

        If Not cls_validacion.validar(txtAlias) Then
            ErrorProvider1.SetError(txtAlias, "Debe ingresar el alias")
            validar = False
        End If

        If Not cls_validacion.validar(txtPosInicial) Then
            ErrorProvider1.SetError(txtPosInicial, "Debe ingresar la posición Inicial")
            validar = False
        End If

        If Not cls_validacion.validar(txtPosFinal) Then
            ErrorProvider1.SetError(txtPosFinal, "Debe ingresar la posición Final")
            validar = False
        End If

        If Not cls_validacion.validar(txtErroresComunes) Then
            ErrorProvider1.SetError(txtPosFinal, "Debe ingresar los errores comunes")
            validar = False
        End If

        If Not cls_validacion.validar(txtDescripcion) Then
            ErrorProvider1.SetError(txtPosFinal, "Debe ingresar la descripción")
            validar = False
        End If

        If Not cls_validacion.validar(cbListaMusculosPrincipales) Then
            ErrorProvider1.SetError(cbListaMusculosPrincipales, "Debe seleccionar un músculo principal")
            validar = False
        End If


        Return validar

    End Function


    Private Sub MetroButton2_Click(sender As Object, e As EventArgs)
        ofdBuscar2.Filter = "All Files (*.*)|*.*|JPEG Files (*.jpeg)|*.jpeg|JPEG Files (*.jpg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif"
        ofdBuscar2.ShowDialog()
        ptbPosicionFinal.Image = Image.FromFile(ofdBuscar.FileName)
        'txtNombreImagen2.Text = ofdBuscar.SafeFileName
    End Sub

    Private Sub FrmRegistrarEjercicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cbListaMusculosPrincipales.DataSource = objGestorMusculo.listarMusculos()
        cbListaMusculosPrincipales.DisplayMember = "Nombre"
        cbListaMusculosPrincipales.ValueMember = "Id"

        lbMusculosSecundarios.DataSource = objGestorMusculo.listarMusculos()
        lbMusculosSecundarios.DisplayMember = "Nombre"
        lbMusculosSecundarios.ValueMember = "Id"


    End Sub

    Private Sub ptbPosicionInicial_Click(sender As Object, e As EventArgs) Handles ptbPosicionInicial.Click
        ofdBuscar.Filter = "All Files (*.*)|*.*|JPEG Files (*.jpeg)|*.jpeg|JPEG Files (*.jpg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif"
        If ofdBuscar.ShowDialog() = DialogResult.OK Then
            Try
                ptbPosicionInicial.Image = Image.FromFile(ofdBuscar.FileName)
                imageByte = File.ReadAllBytes(ofdBuscar.FileName)
            Catch ex As Exception
                ' La imagen cargada no es valida
            End Try
        End If
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        ptbPosicionInicial.Image = Nothing
        imageByte = Nothing
    End Sub

    Private Sub ptbPosicionFinal_Click(sender As Object, e As EventArgs) Handles ptbPosicionFinal.Click
        ofdBuscar2.Filter = "All Files (*.*)|*.*|JPEG Files (*.jpeg)|*.jpeg|JPEG Files (*.jpg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif"
        If ofdBuscar2.ShowDialog() = DialogResult.OK Then
            Try
                ptbPosicionFinal.Image = Image.FromFile(ofdBuscar2.FileName)
                imageByte2 = File.ReadAllBytes(ofdBuscar2.FileName)
            Catch ex As Exception
                ' La imagen cargada no es valida
            End Try
        End If
    End Sub

    Private Sub MetroButton1_Click_1(sender As Object, e As EventArgs)
        ptbPosicionFinal.Image = Nothing
        imageByte2 = Nothing
    End Sub

    Private Sub btnGuardar_Click_1(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim idsMusculosSecundarios As String = ""

        Dim resulValidation As Boolean

        resulValidation = validation()

        If resulValidation Then

            Dim nombre As String = Me.txtNombre.Text
            Dim _alias As String = Me.txtAlias.Text
            Dim musculoPrincipal As String = Me.cbListaMusculosPrincipales.SelectedValue

            For Each li As Musculo In lbMusculosSecundarios.CheckedItems

                idsMusculosSecundarios &= li.Id & ","

            Next



            Dim posicionInicial As String = Me.txtPosInicial.Text
            Dim posicionFinal As String = Me.txtPosFinal.Text
            Dim descripcion As String = Me.txtDescripcion.Text
            Dim erroresComunes As String = Me.txtErroresComunes.Text

            'Dim fs As New FileStream(ofdBuscar.FileName, FileMode.Open, FileAccess.Read)
            'Dim bReader As New BinaryReader(fs)
            'Dim foto(fs.Length) As Byte
            'bReader.Read(foto, 0, fs.Length)
            'fs.Close()

            'Dim fs2 As New FileStream(ofdBuscar2.FileName, FileMode.Open, FileAccess.Read)
            'Dim bReader2 As New BinaryReader(fs2)
            'Dim foto2(fs2.Length) As Byte
            'bReader2.Read(foto2, 0, fs2.Length)
            'fs2.Close()

            objeGestorEjercicio.insertarEjercicio(nombre, _alias, posicionInicial, imageByte, posicionFinal, imageByte2, erroresComunes, descripcion, musculoPrincipal, idsMusculosSecundarios)

            Dim ctr As Control
            ctr = New FrmListarEjercicio
            ctr.Dock = DockStyle.Fill
            Me.Controls.Clear()
            Me.Controls.Add(ctr)

        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim ctr As Control
        ctr = New FrmListarEjercicio
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub
End Class
