Imports System.IO
Imports System.Drawing
Imports EL

Public Class FrmRegistrarEjercicio



    Private Sub MetroLabel4_Click(sender As Object, e As EventArgs) Handles MetroLabel4.Click

    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        ofdBuscar.Filter = "All Files (*.*)|*.*|JPEG Files (*.jpeg)|*.jpeg|JPEG Files (*.jpg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif"
        ofdBuscar.ShowDialog()
        ptbPosicionInicial.Image = Image.FromFile(ofdBuscar.FileName)
        txtNombreImagen.Text = ofdBuscar.SafeFileName
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim resulValidation As Boolean

        resulValidation = validation()

        If resulValidation Then

            Dim nombre As String = txtNombre.Text
            Dim aliasText As String = txtAlias.Text
            Dim posicionInicial As String = txtPosInicial.Text
            Dim posicionFinal As String = txtPosFinal.Text
            Dim erroresComunes As String = txtErroresComunes.Text
            Dim descripcion As String = txtDescripcion.Text
            Dim idMusculoPrincipal As Integer = cbListaMusculosPrincipales.SelectedValue
            Dim idsMusculosSecundarios As String = ""

            For Each li As Musculo In lbMusculosSecundarios.SelectedItems

                idsMusculosSecundarios &= li.Id & ","

            Next

            Dim fs As New FileStream(ofdBuscar.FileName, FileMode.Open, FileAccess.Read)
            Dim bReader As New BinaryReader(fs)
            Dim imagenPosIni(fs.Length) As Byte
            bReader.Read(imagenPosIni, 0, fs.Length)
            fs.Close()

            Dim fs2 As New FileStream(ofdBuscar2.FileName, FileMode.Open, FileAccess.Read)
            Dim bReader2 As New BinaryReader(fs2)
            Dim imagenPosFinal(fs2.Length) As Byte
            bReader2.Read(imagenPosFinal, 0, fs2.Length)
            fs.Close()


            objeGestorEjercicio.insertarEjercicio(nombre, aliasText, posicionInicial, imagenPosIni, posicionFinal, imagenPosFinal, erroresComunes, descripcion, idMusculoPrincipal, idsMusculosSecundarios)

        End If
    End Sub

    Private Function validation() As Boolean

        Dim validar As Boolean = True

        If Not cls_validacion.validar(txtNombre) Then
            validar = False
        End If

        If Not cls_validacion.validar(txtAlias) Then
            validar = False
        End If

        If Not cls_validacion.validar(txtPosInicial) Then
            validar = False
        End If

        If Not cls_validacion.validar(txtPosFinal) Then
            validar = False
        End If

        If Not cls_validacion.validar(txtErroresComunes) Then
            validar = False
        End If

        If Not cls_validacion.validar(txtDescripcion) Then
            validar = False
        End If

        Return validar

    End Function


    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        ofdBuscar2.Filter = "All Files (*.*)|*.*|JPEG Files (*.jpeg)|*.jpeg|JPEG Files (*.jpg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif"
        ofdBuscar2.ShowDialog()
        ptbPosicionFinal.Image = Image.FromFile(ofdBuscar.FileName)
        txtNombreImagen2.Text = ofdBuscar.SafeFileName
    End Sub

    Private Sub FrmRegistrarEjercicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbListaMusculosPrincipales.DataSource = objGestorMusculo.listarMusculos()
        cbListaMusculosPrincipales.DisplayMember = "Nombre"
        cbListaMusculosPrincipales.ValueMember = "Id"

        lbMusculosSecundarios.DataSource = objGestorMusculo.listarMusculos()
        lbMusculosSecundarios.DisplayMember = "Nombre"
        lbMusculosSecundarios.ValueMember = "Id"


    End Sub

    Private Sub lbMusculosPrincipales_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbMusculosSecundarios.SelectedIndexChanged

    End Sub
End Class
