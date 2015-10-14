Public Class Form1

    Private dm As New Dm.dmsoft

    Private Const basePath = "E:\software\大漠插件\字体"

    Dim dm_ret As Integer

    Dim zoneWidth As Object = 800
    Dim zoneHeight As Object = 600

    Private autoFightManagers As New Collection

    Private goalMap As New Hashtable

    Private goalHwnds As New Collection


    Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。


        TabControl1.TabPages.RemoveAt(0)

        Me.FormBorderStyle = FormBorderStyle.FixedSingle
    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Dim hwnd = dm.FindWindow("AskTao", "问道")

        'dm_ret = dm.BindWindow(hwnd, "dx2", "dx2", "dx", 0)

        ''dm_ret = dm.GetClientSize(hwnd, zoneWidth, zoneHeight)

        'dm_ret = dm.SetPath(basePath)

        'dm_ret = dm.SetDict(0, "dm_soft.txt")

        'dm_ret = dm.CaptureJpg(0, 0, zoneWidth, zoneHeight, Now.Millisecond + "screen.jpg", 100)

        ''dm_ret = dm.CaptureJpg(0, 0, zoneWidth, zoneHeight, "1screen.jpg", 100)

    End Sub

    Function gainPetHp()

        ' Dim s = dm.Ocr(136, 354, 246, 373, "f8fcf8-000000", 1.0)

        Dim s = dm.Ocr(136, 352, 242, 373, "f8fcf8-000000", 1.0)

        Dim hps = s.Split("/")

        Return hps

    End Function

    Sub openPetView()



    End Sub

    Sub recoverPetHp(ByVal ratio)

        Dim hps = gainPetHp()

        If hps(0) / CDbl(hps(1)) < ratio Then

            recoverPetHp()

        End If

    End Sub


    Private Sub recoverPetHp()

        initMousePosition()

        dm.MoveTo(513, 41)

        delay(100)

        dm.RightClick()
        dm.RightClick()


    End Sub


    Sub initMousePosition()

        dm.MoveTo(zoneWidth + 50, zoneHeight + 50)

    End Sub

    Sub delay(ByVal ms)

        Threading.Thread.Sleep(ms)


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim hps = gainPetHp()

        TextBox1.Text = hps(0) + hps(1)

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub HpMpUserControlRoleHp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub NumericUpDownsmhp_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles NumericUpDownsmhp.LostFocus

        TimersimpleHMp.Interval = sender.Value * 1000
        TimerAutoClickCBtn.Interval = sender.Value * 1000

    End Sub

    Private Sub NumericUpDownsmhp_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDownsmhp.ValueChanged

    End Sub

    Private Sub CheckBoxEnableSimpleHpMp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxEnableSimpleHpMp.CheckedChanged

        TimersimpleHMp.Enabled = CheckBoxEnableSimpleHpMp.Checked

    End Sub

    Private Sub TimersimpleHMp_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimersimpleHMp.Tick

        For Each item As AutoFightManager In autoFightManagers

            item.recoverPetRoleHMPAnyWFacede()

        Next

    End Sub

    Private Sub TimerAutoClickCBtn_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerAutoClickCBtn.Tick

        For Each item As AutoFightManager In autoFightManagers

            item.clickContinueBtn()


        Next


    End Sub


    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        TimerAutoClickCBtn.Enabled = sender.Checked
    End Sub

    Private Sub findGoalWins()

        ListBoxGoalWins.Items.Clear()

        Dim hwndsS = dm.EnumWindow(0, "问道", "AskTao", 1 + 4 + 8 + 16 + 2)

        Dim hwnds = Split(hwndsS, ",")

        goalMap.Clear()

        For Each item As String In hwnds

            Dim intItem = CInt(item)

            Dim name = dm.GetWindowTitle(intItem)

            goalMap.Add(name, intItem)

            ListBoxGoalWins.Items.Add(name)

        Next


        End Sub

    Private Sub ListBoxGoalWins_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBoxGoalWins.GotFocus

        'findGoalWins()

    End Sub

    Private Sub ListBoxGoalWins_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBoxGoalWins.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click



        Dim items = ListBoxGoalWins.SelectedItems

        Dim hwnds = New Collection

        autoFightManagers.Clear()

        For Each item In items

            hwnds.Add(goalMap.Item(item))

        Next

        'todo bind and goalObj set

        ' autoFightManagers.

        LabelBindCount.Text = autoFightManagers.Count

    End Sub

    Private Sub ButtonUnbind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonUnbind.Click

        For Each item As AutoFightManager In autoFightManagers

            item.myDm.unbind()

        Next

        autoFightManagers.Clear()

        LabelBindCount.Text = autoFightManagers.Count

    End Sub


    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        Dim t = New AboutBox1

        t.ShowDialog()



    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub TimerTaishangLaojun_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerTaishangLaojun.Tick

        For Each item As AutoFightManager In autoFightManagers

            If item.isTaishangLaojunAppearing() Then

                dm.Beep(500, 5000)

            End If


        Next

    End Sub

    Private Sub CheckBoxTaishangLaojun_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxTaishangLaojun.CheckedChanged

        TimerTaishangLaojun.Enabled = sender.checked

    End Sub
End Class
