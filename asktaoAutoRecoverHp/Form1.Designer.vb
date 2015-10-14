<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelBindCount = New System.Windows.Forms.Label()
        Me.ButtonUnbind = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ListBoxGoalWins = New System.Windows.Forms.ListBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxEnableSimpleHpMp = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.NumericUpDownsmhp = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TimerAllRecover = New System.Windows.Forms.Timer(Me.components)
        Me.TimersimpleHMp = New System.Windows.Forms.Timer(Me.components)
        Me.TimerAutoClickCBtn = New System.Windows.Forms.Timer(Me.components)
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.CheckBoxTaishangLaojun = New System.Windows.Forms.CheckBox()
        Me.TimerTaishangLaojun = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.NumericUpDownsmhp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(198, 113)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(8, 6)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(164, 223)
        Me.TextBox1.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(290, 305)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.LabelBindCount)
        Me.TabPage2.Controls.Add(Me.ButtonUnbind)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.ListBoxGoalWins)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(282, 279)
        Me.TabPage2.TabIndex = 3
        Me.TabPage2.Text = "binding"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(188, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 12)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "bind count:"
        '
        'LabelBindCount
        '
        Me.LabelBindCount.AutoSize = True
        Me.LabelBindCount.Location = New System.Drawing.Point(265, 59)
        Me.LabelBindCount.Name = "LabelBindCount"
        Me.LabelBindCount.Size = New System.Drawing.Size(11, 12)
        Me.LabelBindCount.TabIndex = 3
        Me.LabelBindCount.Text = "0"
        '
        'ButtonUnbind
        '
        Me.ButtonUnbind.Location = New System.Drawing.Point(190, 240)
        Me.ButtonUnbind.Name = "ButtonUnbind"
        Me.ButtonUnbind.Size = New System.Drawing.Size(75, 23)
        Me.ButtonUnbind.TabIndex = 2
        Me.ButtonUnbind.Text = "unbind"
        Me.ButtonUnbind.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(190, 205)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "bind"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ListBoxGoalWins
        '
        Me.ListBoxGoalWins.FormattingEnabled = True
        Me.ListBoxGoalWins.ItemHeight = 12
        Me.ListBoxGoalWins.Items.AddRange(New Object() {"a", "a", "a", "a", "a"})
        Me.ListBoxGoalWins.Location = New System.Drawing.Point(9, 7)
        Me.ListBoxGoalWins.Name = "ListBoxGoalWins"
        Me.ListBoxGoalWins.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListBoxGoalWins.Size = New System.Drawing.Size(175, 256)
        Me.ListBoxGoalWins.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.CheckBoxTaishangLaojun)
        Me.TabPage3.Controls.Add(Me.CheckBox1)
        Me.TabPage3.Controls.Add(Me.CheckBoxEnableSimpleHpMp)
        Me.TabPage3.Controls.Add(Me.Panel1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(282, 279)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "simple hp mp"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(30, 102)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(162, 16)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "auto click continue btn"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBoxEnableSimpleHpMp
        '
        Me.CheckBoxEnableSimpleHpMp.AutoSize = True
        Me.CheckBoxEnableSimpleHpMp.Location = New System.Drawing.Point(30, 71)
        Me.CheckBoxEnableSimpleHpMp.Name = "CheckBoxEnableSimpleHpMp"
        Me.CheckBoxEnableSimpleHpMp.Size = New System.Drawing.Size(54, 16)
        Me.CheckBoxEnableSimpleHpMp.TabIndex = 0
        Me.CheckBoxEnableSimpleHpMp.Text = "hp mp"
        Me.CheckBoxEnableSimpleHpMp.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.NumericUpDownsmhp)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(30, 21)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(145, 29)
        Me.Panel1.TabIndex = 4
        '
        'NumericUpDownsmhp
        '
        Me.NumericUpDownsmhp.Location = New System.Drawing.Point(3, 3)
        Me.NumericUpDownsmhp.Name = "NumericUpDownsmhp"
        Me.NumericUpDownsmhp.Size = New System.Drawing.Size(120, 21)
        Me.NumericUpDownsmhp.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(129, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(11, 12)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "s"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(282, 279)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TimersimpleHMp
        '
        '
        'TimerAutoClickCBtn
        '
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(243, 311)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(35, 12)
        Me.LinkLabel1.TabIndex = 3
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "about"
        '
        'CheckBoxTaishangLaojun
        '
        Me.CheckBoxTaishangLaojun.AutoSize = True
        Me.CheckBoxTaishangLaojun.Location = New System.Drawing.Point(30, 257)
        Me.CheckBoxTaishangLaojun.Name = "CheckBoxTaishangLaojun"
        Me.CheckBoxTaishangLaojun.Size = New System.Drawing.Size(162, 16)
        Me.CheckBoxTaishangLaojun.TabIndex = 5
        Me.CheckBoxTaishangLaojun.Text = "Taishang Laojun waraing"
        Me.CheckBoxTaishangLaojun.UseVisualStyleBackColor = True
        '
        'TimerTaishangLaojun
        '
        Me.TimerTaishangLaojun.Interval = 30000
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(290, 332)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.TabControl1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "simple helper for askTao"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.NumericUpDownsmhp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TimerAllRecover As System.Windows.Forms.Timer
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDownsmhp As System.Windows.Forms.NumericUpDown
    Friend WithEvents CheckBoxEnableSimpleHpMp As System.Windows.Forms.CheckBox
    Friend WithEvents TimersimpleHMp As System.Windows.Forms.Timer
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents TimerAutoClickCBtn As System.Windows.Forms.Timer
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ListBoxGoalWins As System.Windows.Forms.ListBox
    Friend WithEvents ButtonUnbind As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LabelBindCount As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents CheckBoxTaishangLaojun As System.Windows.Forms.CheckBox
    Friend WithEvents TimerTaishangLaojun As System.Windows.Forms.Timer

End Class
