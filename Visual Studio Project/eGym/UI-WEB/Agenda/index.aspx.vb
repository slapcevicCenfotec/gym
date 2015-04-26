Public Class index6
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("_USERID") Is Nothing Or Session("_USERID") = String.Empty Then
            Response.Redirect("iniciarsesion.aspx")
        End If
    End Sub

End Class