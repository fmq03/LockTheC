Imports System.IO
Public Class Form100
    Public Lockmode As Integer '1计划按时 2定时 3按时 4立即
    Public stoptimem As Integer, stoptimes As Integer '传输的本轮结束时间
    Public isshowtittle As Boolean '两个可选参数
    Dim starttimes As Integer, starttimem As Integer '本轮开始时间
    Public islinpwd As Boolean, linpwd As String '指定临时密码
    Public tittles As String '传递正常的标题
    Private Structure Usertimeset
        Dim starthour As Integer
        Dim startminute As Integer
        Dim endhour As Integer
        Dim endminute As Integer
        Dim isshutdown As Boolean
    End Structure
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Panel1.Enabled = False
        Lockmode = 1
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Panel1.Enabled = True
        Panel2.Enabled = False
        Lockmode = 2
        Panel2.Enabled = False
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Panel1.Enabled = False
        Panel2.Enabled = True
        Lockmode = 3
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        Panel1.Enabled = False
        Panel2.Enabled = False
        Lockmode = 4
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Panel3.Enabled = True
            islinpwd = True
        Else
            Panel3.Enabled = False
            islinpwd = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            LinTittle.Enabled = True
        Else
            LinTittle.Enabled = False
        End If
    End Sub

    Private Sub Dinminute_TextChanged(sender As Object, e As EventArgs) Handles Dinminute.TextChanged
        If IsNumeric(Dinminute.Text) = False Then
            Dinminute.Text = ""
        End If
    End Sub

    Private Sub Dinsecond_TextChanged(sender As Object, e As EventArgs) Handles Dinsecond.TextChanged
        If IsNumeric(Dinminute.Text) = True Then
            If CInt(Dinminute.Text) > 59 Then Dinminute.Text = ""
        Else : Dinminute.Text = ""
        End If
    End Sub

    Private Sub Anhour_TextChanged(sender As Object, e As EventArgs) Handles Anhour.TextChanged
        If IsNumeric(Anhour.Text) = True Then
            If CInt(Anhour.Text) > 23 Then Anhour.Text = ""
        Else : Anhour.Text = ""
        End If
    End Sub

    Private Sub Anminute_TextChanged(sender As Object, e As EventArgs) Handles Anminute.TextChanged
        If IsNumeric(Anminute.Text) = True Then
            If CInt(Anminute.Text) > 59 Then Anminute.Text = ""
        Else : Anminute.Text = ""
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Formpwd.Show()
    End Sub

    Private Sub Form100_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If islinpwd = True Then
            If LinPassWD.Text = "" Or LinPassWDs.Text = "" Then Exit Sub
            If LinPassWD.Text = LinPassWDs.Text Then
                linpwd = LinPassWDs.Text
            Else : Exit Sub
            End If
        End If
        Dim readtittle As New StreamReader(Application.StartupPath & "\tittle.txt", System.Text.Encoding.Default)
        Dim s As String = readtittle.ReadLine
        If CheckBox2.Checked = True Then
            tittles = LinTittle.Text
            isshowtittle = True
        ElseIf s <> "" Then
            tittles = s
            isshowtittle = True
        Else
            isshowtittle = False
        End If
        Select Case Lockmode
            Case 1  '计划锁屏（全部移至副本）将做
                'If islinpwd = True Then
                '    File.Create(Application.StartupPath & "\lpwd.txt")
                '    Dim pwdr As New StreamWriter(Application.StartupPath & "\lpwd.txt")
                '    pwdr.WriteLine(linpwd)
                'End If
                'If LinTittle.Enabled = True Then
                '    File.Create(Application.StartupPath & "\ltittle.txt")
                '    Dim pwdr As New StreamWriter(Application.StartupPath & "\ltittle.txt")
                '    pwdr.WriteLine(LinTittle.Text)
                'End If
                Shell(Application.StartupPath & "\LockTheCs.exe")
                End
            Case 2
                If Dinsecond.Text = "" And Dinminute.Text = "" Then Exit Sub
                If Dinsecond.Text = "" Then Dinsecond.Text = "0"
                If Dinminute.Text = "" Then Dinminute.Text = "0"
                starttimes = Dinsecond.Text + CInt(Dinminute.Text * 60)
                Timer2.Start()
            Case 3
                If Anhour.Text = "" Then Exit Sub
                If Anminute.Text = "" Then Anminute.Text = "0"
                If Anminute.Text > 59 Then Exit Sub
                If Anhour.Text > 23 Then Exit Sub
                starttimem = CInt(Anhour.Text)
                starttimes = CInt(Anminute.Text)
                Timer1.Start()
            Case 4
                Form101.Show()
        End Select
        Me.Visible = False
    End Sub
   
    '定时处理
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Now.Hour = starttimem And Now.Minute = starttimes Then
            Form101.Show()
            Timer1.Stop()
        End If
    End Sub
    '倒计时处理
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        starttimes -= 1
        If starttimes = 0 Then
            Form101.Show()
            Timer2.Stop()
        End If
    End Sub
End Class
