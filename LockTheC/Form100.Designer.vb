<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form100
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Dinminute = New System.Windows.Forms.TextBox()
        Me.Dinsecond = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Anhour = New System.Windows.Forms.TextBox()
        Me.Anminute = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LinPassWD = New System.Windows.Forms.TextBox()
        Me.LinPassWDs = New System.Windows.Forms.TextBox()
        Me.LinTittle = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(12, 12)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(95, 16)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "计划按时锁屏"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(12, 34)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(71, 16)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "定时锁屏"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(12, 86)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(71, 16)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.Text = "按时锁屏"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(12, 138)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(71, 16)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.Text = "立即锁屏"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(12, 160)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(96, 16)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "指定临时密码"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(11, 248)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(72, 16)
        Me.CheckBox2.TabIndex = 5
        Me.CheckBox2.Text = "指定标语"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 297)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(162, 36)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "开始"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(13, 339)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(71, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "传统密码"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(13, 368)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(161, 23)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "退出"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Dinminute
        '
        Me.Dinminute.Location = New System.Drawing.Point(3, 3)
        Me.Dinminute.MaxLength = 3
        Me.Dinminute.Name = "Dinminute"
        Me.Dinminute.Size = New System.Drawing.Size(46, 21)
        Me.Dinminute.TabIndex = 9
        '
        'Dinsecond
        '
        Me.Dinsecond.Location = New System.Drawing.Point(79, 3)
        Me.Dinsecond.MaxLength = 2
        Me.Dinsecond.Name = "Dinsecond"
        Me.Dinsecond.Size = New System.Drawing.Size(46, 21)
        Me.Dinsecond.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 12)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "分"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(131, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 12)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "秒"
        '
        'Anhour
        '
        Me.Anhour.Location = New System.Drawing.Point(3, 3)
        Me.Anhour.MaxLength = 3
        Me.Anhour.Name = "Anhour"
        Me.Anhour.Size = New System.Drawing.Size(46, 21)
        Me.Anhour.TabIndex = 14
        '
        'Anminute
        '
        Me.Anminute.Location = New System.Drawing.Point(79, 3)
        Me.Anminute.MaxLength = 2
        Me.Anminute.Name = "Anminute"
        Me.Anminute.Size = New System.Drawing.Size(46, 21)
        Me.Anminute.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(55, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 12)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "时"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(131, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 12)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "分"
        '
        'LinPassWD
        '
        Me.LinPassWD.Location = New System.Drawing.Point(4, 9)
        Me.LinPassWD.Name = "LinPassWD"
        Me.LinPassWD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.LinPassWD.Size = New System.Drawing.Size(165, 21)
        Me.LinPassWD.TabIndex = 18
        '
        'LinPassWDs
        '
        Me.LinPassWDs.Location = New System.Drawing.Point(4, 36)
        Me.LinPassWDs.Name = "LinPassWDs"
        Me.LinPassWDs.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.LinPassWDs.Size = New System.Drawing.Size(165, 21)
        Me.LinPassWDs.TabIndex = 19
        '
        'LinTittle
        '
        Me.LinTittle.Enabled = False
        Me.LinTittle.Location = New System.Drawing.Point(11, 270)
        Me.LinTittle.Name = "LinTittle"
        Me.LinTittle.Size = New System.Drawing.Size(165, 21)
        Me.LinTittle.TabIndex = 20
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel1.Location = New System.Drawing.Point(67, 394)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(53, 12)
        Me.LinkLabel1.TabIndex = 21
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "By fmq03"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Dinminute)
        Me.Panel1.Controls.Add(Me.Dinsecond)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Enabled = False
        Me.Panel1.Location = New System.Drawing.Point(11, 56)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(162, 28)
        Me.Panel1.TabIndex = 22
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Anhour)
        Me.Panel2.Controls.Add(Me.Anminute)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Enabled = False
        Me.Panel2.Location = New System.Drawing.Point(12, 108)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(161, 27)
        Me.Panel2.TabIndex = 23
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.LinPassWDs)
        Me.Panel3.Controls.Add(Me.LinPassWD)
        Me.Panel3.Enabled = False
        Me.Panel3.Location = New System.Drawing.Point(11, 182)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(179, 60)
        Me.Panel3.TabIndex = 24
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(99, 339)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(74, 23)
        Me.Button4.TabIndex = 25
        Me.Button4.Text = "滑动密码"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form100
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(191, 416)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.LinTittle)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.RadioButton4)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Name = "Form100"
        Me.Text = "锁屏设置"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Dinminute As System.Windows.Forms.TextBox
    Friend WithEvents Dinsecond As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Anhour As System.Windows.Forms.TextBox
    Friend WithEvents Anminute As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LinPassWD As System.Windows.Forms.TextBox
    Friend WithEvents LinPassWDs As System.Windows.Forms.TextBox
    Friend WithEvents LinTittle As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Button4 As System.Windows.Forms.Button

End Class
