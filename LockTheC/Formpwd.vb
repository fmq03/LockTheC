Imports System.Security.Cryptography
Imports System.IO
Public Class Formpwd

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = TextBox2.Text Then
            Dim md5 As New MD5CryptoServiceProvider
            Dim bytValue = System.Text.Encoding.UTF8.GetBytes(TextBox1.Text)
            ' 计算散列，并返回一个字节数组   
            Dim bytHash = md5.ComputeHash(bytValue)
            md5.Clear()
            ' 字节数组转换成字符串  
            Dim result = Convert.ToBase64String(bytHash)
            'MsgBox(result)
            Dim paths As String = Application.StartupPath & "\pwd.txt"
            ' Dim s As New FileInfo(paths)
            Dim ss As New StreamWriter(paths, False)
            ss.Write(result)
            ss.Close()
            'Dim sd As New StreamReader(paths)
            'MsgBox(sd.ReadLine)
            'sd.Close()
            MsgBox("Write is OK!")
            Me.Close()
        End If
    End Sub
End Class