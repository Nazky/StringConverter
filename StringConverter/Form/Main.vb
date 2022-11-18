Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "StringToBase64" Then
            TextBox2.Text = Converter.ConvertB64(TextBox1.Text)
        ElseIf ComboBox1.Text = "Base64ToString" Then
            TextBox2.Text = Converter.ConvertB64String(TextBox1.Text)
        ElseIf ComboBox1.Text = "StringToHEX" Then
            TextBox2.Text = Converter.ConvertHex(TextBox1.Text)
        ElseIf ComboBox1.Text = "HEXToString" Then
            TextBox2.Text = Converter.ConvertHexString(TextBox1.Text)
        Else
            MsgBox("Please choose a method !", MsgBoxStyle.Critical, "StringConverter")
        End If
    End Sub
End Class
