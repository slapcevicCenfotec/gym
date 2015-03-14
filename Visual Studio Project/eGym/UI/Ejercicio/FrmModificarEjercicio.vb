Imports EL
Imports System.IO

Public Class FrmModificarEjercicio

    Private Property ejercicioModificar As Ejercicio
    Private listaOriginal As List(Of Musculo)

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

        ejercicioImagenes = objeGestorEjercicio.getImagenes(ejercicioModificar.Id)

        Dim posicionIncImg As Image
        Dim ms As MemoryStream = New System.IO.MemoryStream(ejercicioImagenes.PosicionInicialImg)
        posicionIncImg = System.Drawing.Image.FromStream(ms)

        Dim posicionFinImg As Image
        Dim ms2 As MemoryStream = New System.IO.MemoryStream(ejercicioImagenes.PosicionFinalImg)
        posicionFinImg = System.Drawing.Image.FromStream(ms2)

        ptbPosicionInicial.Image = posicionIncImg
        ptbPosicionFinal.Image = posicionFinImg

        cbListaMusculosPrincipales.DataSource = objGestorMusculo.listarMusculos()
        cbListaMusculosPrincipales.DisplayMember = "Nombre"
        cbListaMusculosPrincipales.ValueMember = "Id"

        Dim musculo As Musculo = objeGestorEjercicio.getMusculoPrincipal(ejercicioModificar.Id)

        cbListaMusculosPrincipales.SelectedValue = musculo.Id


        'lbMusculosSecundarios.DataSource = objeGestorEjercicio.
        'cbListaMusculosPrincipales.DisplayMember = "Nombre"
        'cbListaMusculosPrincipales.ValueMember = "Id"



    End Sub

   
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
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

End Class
