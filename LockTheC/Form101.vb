Imports System.IO
Imports System.Security.Cryptography
Public Class Form101 '主本
    'Dim iss As Boolean, msx As Integer, msy As Integer, waystr As String
    Dim pass As String, tt As Integer
    ' Dim fs As System.IO.FileStream = New System.IO.FileStream(Environment.ExpandEnvironmentVariables("%windir%\system32\taskmgr.exe"), System.IO.FileMode.Open)
    Private Sub Form101_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Form100.islinpwd = True Then
            pass = Form100.linpwd
        End If
        ti2.Enabled = True
        l2.Text = Form100.tittles
        l1.Left = (Me.Width - l1.Width) \ 2
        p1.Visible = False
        Me.Opacity = 0
        loadimg()
        Me.TopMost = True
        Me.KeyPreview = True
    End Sub
    Enum way
        left
        right
        up
        down
        er
    End Enum
    Private Sub loadimg()
        If Directory.Exists(Application.StartupPath & "\img") = False Then Exit Sub
        Dim i As Integer, rnd As Random = New Random
        For Each File As String In Directory.GetFiles(Application.StartupPath & "\img\")
            i += 1
        Next
        If i = 0 Then Exit Sub
        Dim s As Integer = rnd.Next(1, i)
        i = 0
        Randomize()
        For Each File As String In Directory.GetFiles(Application.StartupPath & "\img\")
            i += 1
            If i = s Then Me.BackgroundImage = Image.FromFile(File)
        Next
    End Sub

    '检查密钥是否正确
    Private Sub checkpwd()
        If t1.Text = "return1error" Then clos()
        If Form100.islinpwd = True Then
            If t1.Text = Form100.linpwd Then clos()
        Else
            Dim readss As New StreamReader(Application.StartupPath & "\pwd.txt")
            Dim md5pwd As String = readss.ReadLine()
            Dim waypwd As String = readss.ReadLine()
            readss.Close()
            Dim md5 As New MD5CryptoServiceProvider
            Dim bytValue = System.Text.Encoding.UTF8.GetBytes(t1.Text)
            Dim bytHash = md5.ComputeHash(bytValue)
            md5.Clear()
            If Convert.ToBase64String(bytHash) = md5pwd Then clos()
            If Convert.ToBase64String(bytHash) = waypwd Then clos()
        End If
    End Sub
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        checkpwd()
    End Sub
    Private Sub clos()
        time2.Stop()
        l3.Text = "即将退出！"
        ti3.Start()
    End Sub
    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If time1.Enabled = False Then time1.Enabled = True
        tt = tt + 1
    End Sub
    '关机
    Private Sub time1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles time1.Tick
        Static aa As Integer
        aa = aa + 1
        If aa = 10 Then
            aa = 0
            Call aa1()
        Else
            l4.Text = "在" & CStr((10 - aa) / 2) & "秒内，再按一次关机"
            If tt = 2 Then Call aa2()
        End If
    End Sub
    Private Sub aa1()
        time1.Enabled = False
        tt = 0
        l4.Text = ""
    End Sub
    '关机辅助
    Private Sub aa2()
        time1.Enabled = False
        l4.Text = "保重......"
        Shell("Shutdown.exe -s -t 3")
    End Sub
    '按键屏蔽
    Private Sub Form101_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then checkpwd()
        If e.Alt = True Then
            Select Case e.KeyCode
                Case Keys.F4
                    e.Handled = True
                Case Keys.Tab
                    e.Handled = True
                Case Keys.Escape
                    e.Handled = True
            End Select
        End If

        Select Case e.KeyCode
            Case Keys.Alt
                e.Handled = True
            Case Keys.Shift
                e.Handled = True
            Case Keys.Control
                e.Handled = True
        End Select
        If e.KeyCode = Keys.LWin Then
            e.Handled = True
        End If
    End Sub
    '进入动画
    Private Sub ti2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ti2.Tick
        Static i As Integer
        i = i + 1
        Me.Opacity = i / 100
        If i = 100 Then
            Call enn()
        End If
    End Sub
    '进入动画辅助
    Private Sub enn()
        ti2.Enabled = False
        time2.Enabled = True
    End Sub
    '退出动画
    Private Sub ti3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ti3.Tick
        Static i As Integer
        i = i + 1
        Me.Opacity = (99 - i) / 100
        If Me.Opacity = 0.01 Then
            ti3.Enabled = False
            End
        End If
    End Sub
    '杀掉任务管理器
    Private Sub time2e_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles time2.Tick
        Shell("cmd /c taskkill /f /im taskmgr.exe", vbHide)
        timeshow.Text = Now.Hour & ":" & Now.Minute & ":" & Now.Second
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub t1_TextChanged(sender As Object, e As EventArgs) Handles t1.TextChanged

    End Sub

    Private Sub Form101_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        If p1.Visible = True Then p1.Visible = False Else p1.Visible = True
    End Sub

    Private Sub Form101_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        '    iss = True
        '    msx = e.X
        '    msy = e.Y
    End Sub

    Private Sub Form101_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        'iss = False
    End Sub

    Private Sub Form101_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove

    End Sub
End Class