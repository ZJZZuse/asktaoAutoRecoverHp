Public Class Form1

    Private dm As New Dm.dmsoft


    Private Const basePath = "E:\software\大漠插件\字体"

    Private Const fileName = "dm_soft.txt"

    Dim dm_ret As Integer

    Dim zoneWidth As Object = 800
    Dim zoneHeight As Object = 600

    Private autoFightManagers As New Collection

    Private askTaoCommonFunctionMangers As New Collection

    Private goalMap As New Hashtable

    Private goalHwnds As New Collection

    Private sForSends()
    Private sForSendsIndex = 0

    Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。


        TabControl1.TabPages.RemoveAt(0)

        Me.FormBorderStyle = FormBorderStyle.FixedSingle

        '调试的时候注释调
        'DmGuard.initAndGoGuard()


    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Dim hwnd = dm.FindWindow("AskTao", "问道")

        'dm_ret = dm.BindWindow(hwnd, "dx2", "dx2", "dx", 0)

        ''dm_ret = dm.GetClientSize(hwnd, zoneWidth, zoneHeight)

        'dm_ret = dm.SetPath(basePath)

        'dm_ret = dm.SetDict(0, "dm_soft.txt")

        ' dm_ret = dm.CaptureJpg(0, 0, zoneWidth, zoneHeight, Now.Millisecond + "screen.jpg", 100)

        'dm_ret = dm.CaptureJpg(0, 0, zoneWidth, zoneHeight, "1screen.jpg", 100)

        initTimeer(NumericUpDownsmhp)

        'MsgBox(dm.Ver)


    End Sub


    Sub sForSendsIndexChanger()

        sForSendsIndex += 1

        If sForSendsIndex >= sForSends.Count Then

            sForSendsIndex = 0

        End If

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

    Private Sub NumericUpDownsmhp_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles NumericUpDownsmhp.Enter
        initTimeer(sender)
    End Sub


    Sub initTimeer(ByVal sender)


        TimersimpleHMp.Interval = sender.Value * 1000
        TimerAutoClickCBtn.Interval = sender.Value * 1000

    End Sub

    'Private Sub NumericUpDownsmhp_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles NumericUpDownsmhp.LostFocus

    '    TimersimpleHMp.Interval = sender.Value * 1000
    '    TimerAutoClickCBtn.Interval = sender.Value * 1000
    '    TimerRandom.Interval = sender.Value * 1000

    'End Sub

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

        Dim hwndsS As String = dm.EnumWindow(0, "问道", "AskTao", 1 + 4 + 8 + 16 + 2)

        If String.IsNullOrEmpty(hwndsS) Then

            Exit Sub

        End If

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

        ListBoxGoalWins.ScrollAlwaysVisible = False

        Try

            findGoalWins()

        Catch ex As Exception



        End Try



    End Sub

    Private Sub ListBoxGoalWins_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBoxGoalWins.SelectedIndexChanged

    End Sub

    Sub bindAction(ByVal dm, ByVal hwnd)

        dm_ret = dm.BindWindow(hwnd, "dx2", "dx2", "dx", 0)

    End Sub

    Sub bindWins()

        Dim items = ListBoxGoalWins.SelectedItems

        autoFightManagers.Clear()

        For Each item In items

            Dim hwnd = goalMap.Item(item)

            Dim mydmT = New MyDm(New Dm.dmsoft, hwnd, AddressOf bindAction)

            autoFightManagers.Add(New AutoFightManager(mydmT))
            askTaoCommonFunctionMangers.Add(New AskTaoCommonFunctionManger(mydmT))

        Next

        'todo bind and goalObj set

        ' autoFightManagers.

        LabelBindCount.Text = autoFightManagers.Count


    End Sub

    Sub unbindWins()

        For Each item As AutoFightManager In autoFightManagers

            item.myDm.unbind()

        Next

        autoFightManagers.Clear()
        askTaoCommonFunctionMangers.Clear()

        LabelBindCount.Text = autoFightManagers.Count

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBind.Click

        bindWins()
    End Sub

    Private Sub ButtonUnbind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonUnbind.Click

        unbindWins()

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

    Private Sub TimerRandom_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerRandom.Tick

        Dim r As New Random

        Dim rI = r.Next(0, 6000)

        rI -= 3000

        TimersimpleHMp.Interval += rI
        TimerAutoClickCBtn.Interval += rI

    End Sub

    Private Sub CheckBoxAutoSendS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxAutoSendS.CheckedChanged
        TimerAutoSendS.Enabled = sender.Checked

        TimerAutoSendS.Interval = NumericUpDownAutoSendS.Value * 1000


    End Sub

    Private Sub NumericUpDownAutoSendS_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDownAutoSendS.ValueChanged

    End Sub

    Private Sub TimerAutoSendS_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerAutoSendS.Tick

        TimerAutoSendS.Interval += MyGameBaseHelper.generateCommonInterval

        Dim s = sForSends(sForSendsIndex)


        For Each askTaoc As AskTaoCommonFunctionManger In askTaoCommonFunctionMangers

            askTaoc.sendSTring(s)


        Next


        sForSendsIndexChanger()

    End Sub

    Private Sub TextBoxAutoTalk_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBoxAutoTalk.LostFocus

        sForSends = TextBoxAutoTalk.Text.Split(vbCrLf)

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxAutoTalk.TextChanged

    End Sub
End Class
