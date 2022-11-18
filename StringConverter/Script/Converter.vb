Public Class Converter
    Shared Function ConvertB64(txt As String)
        Try
            Return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(txt))
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "StringConverter")
        End Try
    End Function

    Shared Function ConvertHex(txt As String)
        Try
            Return Convert.ToHexString(System.Text.Encoding.UTF8.GetBytes(txt))
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "StringConverter")
        End Try
    End Function

    Shared Function ConvertHexString(txt As String)
        Try
            Return System.Text.Encoding.UTF8.GetString(Convert.FromHexString(txt))

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "StringConverter")
        End Try
    End Function

    Shared Function ConvertB64String(txt As String)
        Try
            Return System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(txt))
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "StringConverter")
        End Try

    End Function

End Class
