Public Class FrmMensajeOk

    Public Sub New(ByVal pmensaje As String)
        InitializeComponent()
        lblMensaje.Text = pmensaje
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Me.Close()
    End Sub
End Class