Imports System.Web.Services

Public Class Session
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    <WebMethod> _
    Public Shared Sub SetUserId(userId As String)
        HttpContext.Current.Session("_USERID") = userId
    End Sub

    <WebMethod> _
    Public Shared Sub LogOff()
        HttpContext.Current.Session("_USERID") = Nothing
    End Sub

    Public Shared Sub SetPermissionList(permissionIds As String)
        Dim list As List(Of String) = New List(Of String)
        Dim ids As String() = permissionIds.Split(New Char() {"-"c})
        Dim id As String
        For Each id In ids
            list.Add(id)
        Next
        HttpContext.Current.Session("_USERPERMISSION") = list

    End Sub


End Class