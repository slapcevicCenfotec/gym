Imports EL
Imports System.IO


Public Class FrmModificarEjercicio

    Private Property ejercicioModificar As Ejercicio
    Private listaOriginal As List(Of Musculo)

    Private imageByte As Byte()
    Private imageByte2 As Byte()

    Public Sub New(ByVal pejercicio As Ejercicio)
        ejercicioModificar = pejercicio
        InitializeComponent()
    End Sub

    Private Sub FrmModificarEjercicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ejercicioImagenes As Ejercicio
     
        txtNombre.Text = ejercicioModificar.Nombre
        txtAlias.Text = ejercicioModificar.Alias
        txtPosInicial.Text = ejercicioModificar.PosicionInicial
        txtPosFinal.Text = ejercicioModificar.PosicionFinal
        txtErroresComunes.Text = ejercicioModificar.ErroresComunes
        txtDescripcion.Text = ejercicioModificar.Descripcion

        ejercicioImagenes = objeGestorEjercicio.getEjercicio(ejercicioModificar.Id)

        If Not ejercicioImagenes.PosicionInicialImg Is Nothing Then

            Dim posicionIncImg As Image
            Dim ms As MemoryStream = New System.IO.MemoryStream(ejercicioImagenes.PosicionInicialImg)
            posicionIncImg = System.Drawing.Image.FromStream(ms)
            imageByte = ejercicioImagenes.PosicionInicialImg
            ptbPosicionInicial.Image = posicionIncImg

        End If
        If Not ejercicioImagenes.PosicionFinalImg Is Nothing Then
            Dim posicionFinImg As Image
            Dim ms2 As MemoryStream = New System.IO.MemoryStream(ejercicioImagenes.PosicionFinalImg)
            posicionFinImg = System.Drawing.Image.FromStream(ms2)
            imageByte2 = ejercicioImagenes.PosicionFinalImg
            ptbPosicionFinal.Image = posicionFinImg
        End If


        cbListaMusculosPrincipales.DataSource = objGestorMusculo.listarMusculos()
        cbListaMusculosPrincipales.DisplayMember = "Nombre"
        cbListaMusculosPrincipales.ValueMember = "Id"

        Dim musculo As Musculo = objeGestorEjercicio.getMusculoPrincipal(ejercicioModificar.Id)

        If Not musculo Is Nothing Then
            cbListaMusculosPrincipales.SelectedValue = musculo.Id
        End If


        cbListaMusculosSecundarios.DataSource = objGestorMusculo.listarMusculos()
        cbListaMusculosSecundarios.DisplayMember = "Nombre"
        cbListaMusculosSecundarios.ValueMember = "Id"

        Dim listaMusculosSecundarios As List(Of Musculo)

        listaMusculosSecundarios = objeGestorEjercicio.getMusculoSecundarios(ejercicioModificar.Id)

        For Each Muscle As Musculo In listaMusculosSecundarios
            cbListaMusculosSecundarios.SelectedValue = Muscle.Id
            cbListaMusculosSecundarios.SetItemChecked(cbListaMusculosSecundarios.SelectedIndex, True)
        Next

    End Sub

   
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs)
        Dim resulValidation As Boolean

        resulValidation = validation()

        If resulValidation Then

            'objeGestorEjercicio.

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

    Private Sub btnGuardar_Click_1(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim idsMusculosSecundarios As String = ""

        Dim resulValidation As Boolean

        resulValidation = validation()

        If resulValidation Then

            Dim nombre As String = Me.txtNombre.Text
            Dim _alias As String = Me.txtAlias.Text
            Dim musculoPrincipal As String = Me.cbListaMusculosPrincipales.SelectedValue

            For Each li As Musculo In cbListaMusculosSecundarios.CheckedItems

                idsMusculosSecundarios &= li.Id & ","

            Next

            Dim posicionInicial As String = Me.txtPosInicial.Text
            Dim posicionFinal As String = Me.txtPosFinal.Text
            Dim descripcion As String = Me.txtDescripcion.Text
            Dim erroresComunes As String = Me.txtErroresComunes.Text

            objeGestorEjercicio.modificarEjercicio(ejercicioModificar.Id, nombre, _alias, posicionInicial, imageByte, posicionFinal, imageByte2, erroresComunes, descripcion, musculoPrincipal, idsMusculosSecundarios)

            Dim ctr As Control
            ctr = New FrmListarEjercicio
            ctr.Dock = DockStyle.Fill
            Me.Controls.Clear()
            Me.Controls.Add(ctr)

        End If
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        ptbPosicionFinal.Image = Nothing
        imageByte2 = Nothing
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        ptbPosicionInicial.Image = Nothing
        imageByte = Nothing
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim ctr As Control
        ctr = New FrmListarEjercicio
        ctr.Dock = DockStyle.Fill
        Me.Controls.Clear()
        Me.Controls.Add(ctr)
    End Sub
End Class
