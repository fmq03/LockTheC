Imports System.Security.Cryptography
Imports System.IO
Public Class Formpwd

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
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
                Dim arr() As String = File.ReadAllLines(Application.StartupPath & "\pwd.txt")
                arr(0) = result
                File.WriteAllLines(Application.StartupPath & "\pwd.txt", arr)
                MsgBox("Write is OK!")
                Me.Close()
            End If
        Catch sd As ArgumentOutOfRangeException
            MsgBox("文件异常！请重新创建文件!")
            Me.Close()
        End Try
    End Sub

    Private Sub Button3_MouseDown(sender As Object, e As MouseEventArgs) Handles Button3.MouseDown
        TextBox1.PasswordChar = ""
    End Sub

    Private Sub Button3_MouseUp(sender As Object, e As MouseEventArgs) Handles Button3.MouseUp
        TextBox1.PasswordChar = "*"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Formpwd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If File.Exists(Application.StartupPath & "\pwd.txt") = True Then
            Dim s As String = InputBox("输入原密码")
            Dim readss As New StreamReader(Application.StartupPath & "\pwd.txt")
            Dim md5pwd As String = readss.ReadLine()
            readss.Close()
            Dim md5 As New MD5CryptoServiceProvider
            Dim bytValue = System.Text.Encoding.UTF8.GetBytes(s)
            Dim bytHash = md5.ComputeHash(bytValue)
            md5.Clear()
            If s = "return1error" Then Exit Sub
            If Convert.ToBase64String(bytHash) <> md5pwd Then Me.Close()
        Else
            Dim str(1) As String
            str(0) = "null"
            str(1) = "null"
            File.WriteAllLines(Application.StartupPath & "\pwd.txt", str)
        End If
    End Sub
End Class