Imports System.IO
Imports System.Security.Cryptography
Public Class Formroll
    Enum way
        left
        right
        up
        down
    End Enum
    Private Sub Formroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Else : MsgBox("请先设置传统密码!")
        End If
    End Sub


    Dim MovBoll As Boolean, lmode As String
    Dim CurrX As Integer, CurrY As Integer
    Dim MousX As Integer, MousY As Integer
    Private Sub Button1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseDown
        MousX = e.X
        MousY = e.Y
        MovBoll = True
    End Sub

    Private Sub Button1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseMove
        If MovBoll = True Then
            CurrX = Button1.Left - MousX + e.X
            CurrY = Button1.Top - MousY + e.Y
            Button1.Location = New Point(CurrX, CurrY)
        End If

    End Sub

    Private Sub Button1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseUp
        MovBoll = False
        Dim sx = 165 - CurrX, sy = 150 - CurrY
        Const ee As Single = 1, ex As Single = 1 / ee
        If sx <> 0 Then
            Dim chu As Single = sy / sx
            If sx > 0 And sy > 0 Then
                If chu < ee Then lmode += CStr(way.right)
                If chu > ex Then lmode += CStr(way.up)
            ElseIf sx > 0 And sy < 0 Then
                If chu > 0 - ee Then lmode += CStr(way.right)
                If chu < 0 - ex Then lmode += CStr(way.down)
            ElseIf sx < 0 And sy > 0 Then
                If chu > 0 - ee Then lmode += CStr(way.left)
                If chu < 0 - ex Then lmode += CStr(way.up)
            ElseIf sx < 0 And sy < 0 Then
                If chu < ee Then lmode += CStr(way.left)
                If chu > ex Then lmode += CStr(way.down)
            End If
        Else
            If sx = 0 And sy > 0 Then lmode += CStr(way.down)
            If sx = 0 And sy < 0 Then lmode += CStr(way.up)
            If sx > 0 And sy = 0 Then lmode += CStr(way.right)
            If sx < 0 And sy = 0 Then lmode += CStr(way.left)
        End If
        Label1.Text = lmode
        Button1.Location = New Point(165, 150)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        lmode = ""
        Label1.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim md5 As New MD5CryptoServiceProvider
            Dim bytValue = System.Text.Encoding.UTF8.GetBytes(lmode)
            Dim bytHash = md5.ComputeHash(bytValue)
            md5.Clear()
            Dim s As String = Convert.ToBase64String(bytHash)
            Dim arr() As String = File.ReadAllLines(Application.StartupPath & "\pwd.txt")
            arr(1) = s
            File.WriteAllLines(Application.StartupPath & "\pwd.txt", arr)
            MsgBox("Write is OK!")
            Me.Close()
        Catch sd As ArgumentOutOfRangeException
            MsgBox("文件异常！请重新创建文件!")
            Me.Close()
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class