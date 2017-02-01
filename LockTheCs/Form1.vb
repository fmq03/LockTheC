Imports System.IO
Public Class Form1
    Dim timefile As Integer
    Public Lockmode As Integer
    Public stoptimem As Integer, stoptimes As Integer, isshutdown As Boolean, isshowtittle As Boolean
    Dim timegroup() As Usertimeset
    Private Structure Usertimeset
        Dim starthour As Integer
        Dim startminute As Integer
        Dim endhour As Integer
        Dim endminute As Integer
        Dim isshutdown As Boolean
    End Structure
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        firstload()
        'readtime()
        'wakeplan()
    End Sub
    Private Sub readtime()
        Dim i As Integer = 0
        For Each txtname As String In Directory.GetFiles(Application.StartupPath & "\", "time?.txt")
            i += 1
        Next
        ReDim timegroup(i)
        timefile = i
        i = 0
        For Each txtname As String In Directory.GetFiles(Application.StartupPath & "\", "time?.txt")
            Dim ss As New StreamReader(txtname, System.Text.Encoding.UTF8)
            If CInt(ss.ReadLine()) = 1 Then timegroup(i).isshutdown = True Else timegroup(i).isshutdown = False
            timegroup(i).starthour = CInt(ss.ReadLine())
            timegroup(i).startminute = CInt(ss.ReadLine())
            timegroup(i).endhour = CInt(ss.ReadLine())
            timegroup(i).endminute = CInt(ss.ReadLine)
            If CInt(ss.ReadLine()) = 1 Then isshowtittle = True Else isshowtittle = False
            ss.Close()
            i += 1
        Next
    End Sub
    Private Sub firstload()
        If File.Exists(Application.StartupPath & "\pwd.txt") = False Then MsgBox("Error") : Exit Sub
        If File.Exists(Application.StartupPath & "\lpwd.txt") = True Then

        End If
        readtime()
        wakeplan()
        Timer2.Start()
        Me.Visible = False
    End Sub
    Public Sub wakeplan()
        For i As Integer = 0 To timefile
            If timegroup(i).starthour > Now.Hour Then
                Timer1.Start()
                Exit For
            ElseIf timegroup(i).starthour = Now.Hour And timegroup(i).startminute > Now.Minute Then
                Timer1.Start()
                Exit For
            End If
        Next
        If Timer1.Enabled = False Then End
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        For i As Integer = 0 To timefile
            '   MsgBox(timegroup(i).starthour & ":" & timegroup(i).startminute)
            If Now.Hour = timegroup(i).starthour And Now.Minute = timegroup(i).startminute Then
                Form102.Show()
                Timer1.Stop()
                stoptimem = timegroup(i).endhour
                stoptimes = timegroup(i).endminute
                isshutdown = timegroup(i).isshutdown
            End If
        Next
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Static i As Integer
        i += 1
        If i = 6 Then
            Me.Visible = False
            Timer2.Stop()
        End If
    End Sub
End Class
