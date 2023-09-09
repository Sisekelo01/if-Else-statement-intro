Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles greetbtn.Click
        Dim language As String
        language = txttypeLanguage.Text.ToLower

        If language = "Zulu" Then
            MsgBox("Sawubona")
        ElseIf language = "xhosa" Then
            MsgBox("Molo")

        ElseIf language = "sesotho" Then
            MsgBox("Dumela")

        ElseIf language = "tsonga" Then
            MsgBox("Avuxeni")

        ElseIf language = "venda" Then
            MsgBox("Ndaa")
        Else
            MsgBox("Hello, please type a south african language")

        End If










    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
