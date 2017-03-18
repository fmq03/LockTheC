Imports System.IO
Imports System.Security.Cryptography

Public Class Form102 '副本
    Dim pass As String, tt As Integer
    Dim bbx As Integer, bby As Integer
    ' Dim fs As System.IO.FileStream = New System.IO.FileStream(Environment.ExpandEnvironmentVariables("%windir%\system32\taskmgr.exe"), System.IO.FileMode.Open)
    Private Sub Form101_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If File.Exists(Application.StartupPath & "\tittle.txt") = True And Form1.isshowtittle = True Then
            Dim readtittle As New StreamReader(Application.StartupPath & "\tittle.txt", System.Text.Encoding.Default)
            l2.Text = readtittle.ReadLine
            readtittle.Close()
        End If
        ti2.Enabled = True
        l1.Left = (Me.Width - l1.Width) \ 2
        p1.Visible = False
        Button3.Visible = False
        bbx = (Me.Width - Button3.Width) \ 2
        Button3.Left = bbx
        bby = (Me.Height - Button3.Height) \ 2
        Button3.Top = bby
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
        Dim i As Integer, rnd As Random = New Random
        For Each File As String In Directory.GetFiles(Application.StartupPath & "\img\")
            i += 1
        Next
        Dim s As Integer = rnd.Next(1, i)
        i = 0
        Randomize()
        For Each File As String In Directory.GetFiles(Application.StartupPath & "\img\")
            i += 1
            If i = s Then Me.BackgroundImage = Image.FromFile(File)
        Next
    End Sub
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        ' Static aa As Integer
        'If Form100.te1 = False Then
        '    If t1.Text = pass Then
        '    Else
        '        aa = aa + 1
        '        If aa = 3 Then
        '            l3.Text = "倒霉了....."
        '            '  Shell("shutdown -s -t 0")
        '            Exit Sub
        '        Call clos()
        '    Else
        '        l3.Text = "密码错误！"
        '    End If
        'Else
        '    If t1.Text = pass Then
        '        Call clos()
        '        End If
        '        l3.Text = "密码错误！ 这是第" & aa & "次错了，再错" & 3 - aa & "次关机！"
        '    End If
        'End If
        checkpwd() '检测密码后解锁
    End Sub
    Private Sub checkpwd()
        If t1.Text = "return1error" Then clos()
        Dim readss As New StreamReader(Application.StartupPath & "\pwd.txt")
        Dim md5pwd As String = readss.ReadLine()
        readss.Close()
        Dim md5 As New MD5CryptoServiceProvider
        Dim bytValue = System.Text.Encoding.UTF8.GetBytes(t1.Text)
        Dim bytHash = md5.ComputeHash(bytValue)
        md5.Clear()
        If Convert.ToBase64String(bytHash) = md5pwd Then
            clos()
        End If
    End Sub
    '退出前准备
    Private Sub clos()
        time2.Stop()
        l4.Text = "即将退出！"
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
    '关机未成跳出
    Private Sub aa1()
        time1.Enabled = False
        tt = 0
        l4.Text = ""
    End Sub
    '关机成功跳出
    Private Sub aa2()
        time1.Enabled = False
        time2.Stop()
        l4.Text = "保重......"
        Shell("Shutdown.exe -s -t 0")
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
        'If e.Control = True And e.Alt = True And e.KeyCode = Keys.Escape Then
        '    e.Handled = True
        'End If
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
            If Form1.isshutdown = True Then aa2() : Exit Sub
            Form1.wakeplan()
            Me.Close()
        End If
    End Sub
    '杀掉任务管理器&自动解锁
    Private Sub time2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles time2.Tick
        Shell("cmd /c taskkill /f /im taskmgr.exe", vbHide)
        If Now.Hour = Form1.stoptimem And Now.Minute = Form1.stoptimes Then Call clos()
        timeshow.Text = Now.Hour & ":" & Now.Minute & ":" & Now.Second
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub t1_TextChanged(sender As Object, e As EventArgs) Handles t1.TextChanged

    End Sub
    Private Sub Form101_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        If p1.Visible = True Then p1.Visible = False Else p1.Visible = True : lmode = "" : Button4.Visible = False
        If Button3.Visible = True Then Button3.Visible = False Else Button3.Visible = True
    End Sub
    '滑动解锁代码
    Dim MovBoll As Boolean, lmode As String
    Dim CurrX As Integer, CurrY As Integer
    Dim MousX As Integer, MousY As Integer
    Private Sub Button3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button3.MouseDown
        MousX = e.X
        MousY = e.Y
        MovBoll = True
        Button4.Visible = True
    End Sub

    Private Sub Button3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button3.MouseMove
        If MovBoll = True Then
            CurrX = Button3.Left - MousX + e.X
            CurrY = Button3.Top - MousY + e.Y
            Button3.Location = New Point(CurrX, CurrY)
        End If

    End Sub

    Private Sub Button3_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button3.MouseUp
        MovBoll = False
        Dim sx = bbx - CurrX, sy = bby - CurrY
        Const ee As Single = 1, ex As Single = 1 / ee
        If sx <> 0 And sy <> 0 Then
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
        Button3.Location = New Point(bbx, bby)
        Dim md5 As New MD5CryptoServiceProvider
        Dim bytValue = System.Text.Encoding.UTF8.GetBytes(lmode)
        Dim bytHash = md5.ComputeHash(bytValue)
        md5.Clear()
        Dim s As String = Convert.ToBase64String(bytHash)
        Dim ss As New StreamReader(Application.StartupPath & "\pwd.txt")
        ss.ReadLine()
        Dim bz As String = ss.ReadLine()
        If s = bz Then clos()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        lmode = ""
        Button4.Visible = False
    End Sub
End Class