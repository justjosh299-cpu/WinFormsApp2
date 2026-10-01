Public Class Form1


    Private Sub regbtn_Click(sender As Object, e As EventArgs) Handles regbtn.Click
        Dim name As String = tbname.Text
        Dim reg As String = tbreg.Text

        MsgBox("Name: " & name & vbCrLf & "Registration Number: " & reg, MsgBoxStyle.Information, "Registration Details")
    End Sub
End Class
