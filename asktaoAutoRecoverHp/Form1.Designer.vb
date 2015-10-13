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
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.HpMpUserControlPetHp = New asktaoAutoRecoverHp.HpMpUserControl()
        Me.HpMpUserControlPetMp = New asktaoAutoRecoverHp.HpMpUserControl()
        Me.HpMpUserControlRoleHp = New asktaoAutoRecoverHp.HpMpUserControl()
        Me.HpMpUserControlRoleMp = New asktaoAutoRecoverHp.HpMpUserControl()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxEnableAllRecover = New System.Windows.Forms.CheckBox()
        Me.TimerAllRecover = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        Me.TextBox1.Size = New System.Drawing.Size(164, 130)
        Me.TextBox1.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(592, 297)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(584, 271)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.CheckBoxEnableAllRecover)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(584, 271)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Hp Mp"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'HpMpUserControlPetHp
        '
        Me.HpMpUserControlPetHp.Dock = System.Windows.Forms.DockStyle.Top
        Me.HpMpUserControlPetHp.Location = New System.Drawing.Point(3, 17)
        Me.HpMpUserControlPetHp.Name = "HpMpUserControlPetHp"
        Me.HpMpUserControlPetHp.Size = New System.Drawing.Size(263, 73)
        Me.HpMpUserControlPetHp.TabIndex = 0
        '
        'HpMpUserControlPetMp
        '
        Me.HpMpUserControlPetMp.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.HpMpUserControlPetMp.Location = New System.Drawing.Point(3, 115)
        Me.HpMpUserControlPetMp.Name = "HpMpUserControlPetMp"
        Me.HpMpUserControlPetMp.Size = New System.Drawing.Size(263, 73)
        Me.HpMpUserControlPetMp.TabIndex = 1
        '
        'HpMpUserControlRoleHp
        '
        Me.HpMpUserControlRoleHp.Dock = System.Windows.Forms.DockStyle.Top
        Me.HpMpUserControlRoleHp.Location = New System.Drawing.Point(3, 17)
        Me.HpMpUserControlRoleHp.Name = "HpMpUserControlRoleHp"
        Me.HpMpUserControlRoleHp.Size = New System.Drawing.Size(263, 73)
        Me.HpMpUserControlRoleHp.TabIndex = 2
        '
        'HpMpUserControlRoleMp
        '
        Me.HpMpUserControlRoleMp.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.HpMpUserControlRoleMp.Location = New System.Drawing.Point(3, 113)
        Me.HpMpUserControlRoleMp.Name = "HpMpUserControlRoleMp"
        Me.HpMpUserControlRoleMp.Size = New System.Drawing.Size(263, 73)
        Me.HpMpUserControlRoleMp.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.HpMpUserControlPetHp)
        Me.GroupBox1.Controls.Add(Me.HpMpUserControlPetMp)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(269, 191)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "pet"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.HpMpUserControlRoleMp)
        Me.GroupBox2.Controls.Add(Me.HpMpUserControlRoleHp)
        Me.GroupBox2.Location = New System.Drawing.Point(309, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(269, 189)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "role"
        '
        'CheckBoxEnableAllRecover
        '
        Me.CheckBoxEnableAllRecover.AutoSize = True
        Me.CheckBoxEnableAllRecover.Location = New System.Drawing.Point(491, 249)
        Me.CheckBoxEnableAllRecover.Name = "CheckBoxEnableAllRecover"
        Me.CheckBoxEnableAllRecover.Size = New System.Drawing.Size(84, 16)
        Me.CheckBoxEnableAllRecover.TabIndex = 6
        Me.CheckBoxEnableAllRecover.Text = "enable all"
        Me.CheckBoxEnableAllRecover.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 418)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents HpMpUserControlPetHp As asktaoAutoRecoverHp.HpMpUserControl
    Friend WithEvents HpMpUserControlPetMp As asktaoAutoRecoverHp.HpMpUserControl
    Friend WithEvents HpMpUserControlRoleMp As asktaoAutoRecoverHp.HpMpUserControl
    Friend WithEvents HpMpUserControlRoleHp As asktaoAutoRecoverHp.HpMpUserControl
    Friend WithEvents CheckBoxEnableAllRecover As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TimerAllRecover As System.Windows.Forms.Timer

End Class
