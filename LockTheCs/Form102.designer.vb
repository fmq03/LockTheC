﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form102
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.p1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.t1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.l3 = New System.Windows.Forms.Label()
        Me.l1 = New System.Windows.Forms.Label()
        Me.time1 = New System.Windows.Forms.Timer(Me.components)
        Me.l2 = New System.Windows.Forms.Label()
        Me.ti2 = New System.Windows.Forms.Timer(Me.components)
        Me.ti3 = New System.Windows.Forms.Timer(Me.components)
        Me.l4 = New System.Windows.Forms.Label()
        Me.time2 = New System.Windows.Forms.Timer(Me.components)
        Me.timeshow = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.p1.SuspendLayout()
        Me.SuspendLayout()
        '
        'p1
        '
        Me.p1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.p1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.p1.Controls.Add(Me.Button2)
        Me.p1.Controls.Add(Me.Button1)
        Me.p1.Controls.Add(Me.t1)
        Me.p1.Controls.Add(Me.Label1)
        Me.p1.Location = New System.Drawing.Point(12, 230)
        Me.p1.Name = "p1"
        Me.p1.Size = New System.Drawing.Size(315, 113)
        Me.p1.TabIndex = 11
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(203, 60)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 34)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "关机"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(101, 60)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 34)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "确定"
        Me.Button1.UseVisualStyleBackColor = True
        '
        't1
        '
        Me.t1.Font = New System.Drawing.Font("宋体", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.t1.Location = New System.Drawing.Point(27, 25)
        Me.t1.Name = "t1"
        Me.t1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.t1.Size = New System.Drawing.Size(262, 29)
        Me.t1.TabIndex = 7
        Me.t1.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 12)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "请输入密码！"
        '
        'l3
        '
        Me.l3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.l3.AutoSize = True
        Me.l3.BackColor = System.Drawing.Color.Transparent
        Me.l3.Font = New System.Drawing.Font("宋体", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.l3.ForeColor = System.Drawing.Color.DarkGreen
        Me.l3.Location = New System.Drawing.Point(12, 396)
        Me.l3.Name = "l3"
        Me.l3.Size = New System.Drawing.Size(123, 19)
        Me.l3.TabIndex = 10
        Me.l3.Text = "七十一班所用"
        '
        'l1
        '
        Me.l1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.l1.AutoSize = True
        Me.l1.BackColor = System.Drawing.Color.Transparent
        Me.l1.Font = New System.Drawing.Font("宋体", 20.0!)
        Me.l1.ForeColor = System.Drawing.Color.Red
        Me.l1.Location = New System.Drawing.Point(188, 9)
        Me.l1.Name = "l1"
        Me.l1.Size = New System.Drawing.Size(351, 27)
        Me.l1.TabIndex = 9
        Me.l1.Text = "动电脑扣5分，关机扣10分！"
        '
        'time1
        '
        Me.time1.Interval = 500
        '
        'l2
        '
        Me.l2.AutoSize = True
        Me.l2.BackColor = System.Drawing.Color.Transparent
        Me.l2.Font = New System.Drawing.Font("宋体", 20.0!, System.Drawing.FontStyle.Bold)
        Me.l2.ForeColor = System.Drawing.Color.Red
        Me.l2.Location = New System.Drawing.Point(35, 111)
        Me.l2.Name = "l2"
        Me.l2.Size = New System.Drawing.Size(0, 27)
        Me.l2.TabIndex = 12
        '
        'ti2
        '
        Me.ti2.Interval = 10
        '
        'ti3
        '
        Me.ti3.Interval = 10
        '
        'l4
        '
        Me.l4.AutoSize = True
        Me.l4.BackColor = System.Drawing.Color.Transparent
        Me.l4.Font = New System.Drawing.Font("宋体", 15.0!)
        Me.l4.ForeColor = System.Drawing.Color.ForestGreen
        Me.l4.Location = New System.Drawing.Point(228, 358)
        Me.l4.Name = "l4"
        Me.l4.Size = New System.Drawing.Size(0, 20)
        Me.l4.TabIndex = 13
        '
        'time2
        '
        Me.time2.Interval = 500
        '
        'timeshow
        '
        Me.timeshow.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.timeshow.AutoSize = True
        Me.timeshow.BackColor = System.Drawing.Color.Transparent
        Me.timeshow.Font = New System.Drawing.Font("宋体", 19.0!)
        Me.timeshow.ForeColor = System.Drawing.Color.PowderBlue
        Me.timeshow.Location = New System.Drawing.Point(579, 388)
        Me.timeshow.Name = "timeshow"
        Me.timeshow.Size = New System.Drawing.Size(0, 26)
        Me.timeshow.TabIndex = 15
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.SpringGreen
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(464, 182)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(50, 50)
        Me.Button3.TabIndex = 16
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Form102
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(788, 424)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.timeshow)
        Me.Controls.Add(Me.l4)
        Me.Controls.Add(Me.l2)
        Me.Controls.Add(Me.p1)
        Me.Controls.Add(Me.l3)
        Me.Controls.Add(Me.l1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form102"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.p1.ResumeLayout(False)
        Me.p1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents p1 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents t1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents l3 As System.Windows.Forms.Label
    Friend WithEvents l1 As System.Windows.Forms.Label
    Friend WithEvents time1 As System.Windows.Forms.Timer
    Friend WithEvents l2 As System.Windows.Forms.Label
    Friend WithEvents ti2 As System.Windows.Forms.Timer
    Friend WithEvents ti3 As System.Windows.Forms.Timer
    Friend WithEvents l4 As System.Windows.Forms.Label
    Friend WithEvents time2 As System.Windows.Forms.Timer
    Friend WithEvents timeshow As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
