Public Class cls_validacion

    Public Shared Function validar(ByVal txt As MetroFramework.Controls.MetroTextBox) As Boolean

        If (String.IsNullOrEmpty(txt.Text) Or txt.Text.Length > txt.MaxLength) Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Shared Function validar(ByVal cb As MetroFramework.Controls.MetroComboBox) As Boolean

        If cb.SelectedIndex = -1 Then
            Return False
        Else
            Return True
        End If


    End Function

End Class
