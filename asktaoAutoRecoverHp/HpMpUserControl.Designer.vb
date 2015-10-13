<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HpMpUserControl
    Inherits System.Windows.Forms.UserControl

    'UserControl 重写 Dispose，以清理组件列表。
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
        Me.CheckBoxEnable = New System.Windows.Forms.CheckBox()
        Me.TrackBarRatio = New System.Windows.Forms.TrackBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TimerRecover = New System.Windows.Forms.Timer(Me.components)
        CType(Me.TrackBarRatio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CheckBoxEnable
        '
        Me.CheckBoxEnable.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.CheckBoxEnable.AutoSize = True
        Me.CheckBoxEnable.Location = New System.Drawing.Point(201, 47)
        Me.CheckBoxEnable.Name = "CheckBoxEnable"
        Me.CheckBoxEnable.Size = New System.Drawing.Size(60, 16)
        Me.CheckBoxEnable.TabIndex = 0
        Me.CheckBoxEnable.Text = "enable"
        Me.CheckBoxEnable.UseVisualStyleBackColor = True
        '
        'TrackBarRatio
        '
        Me.TrackBarRatio.Location = New System.Drawing.Point(3, 3)
        Me.TrackBarRatio.Name = "TrackBarRatio"
        Me.TrackBarRatio.Size = New System.Drawing.Size(258, 45)
        Me.TrackBarRatio.TabIndex = 1
        Me.TrackBarRatio.Value = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 12)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'TimerRecover
        '
        Me.TimerRecover.Interval = 1000
        '
        'HpMpUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TrackBarRatio)
        Me.Controls.Add(Me.CheckBoxEnable)
        Me.Name = "HpMpUserControl"
        Me.Size = New System.Drawing.Size(268, 73)
        CType(Me.TrackBarRatio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckBoxEnable As System.Windows.Forms.CheckBox
    Friend WithEvents TrackBarRatio As System.Windows.Forms.TrackBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TimerRecover As System.Windows.Forms.Timer

End Class
