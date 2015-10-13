Public Class Form1

    Private dm As New Dm.dmsoft

    Private Const basePath = "E:\software\大漠插件\字体"

    Dim dm_ret As Integer

    Dim zoneWidth As Object = 800
    Dim zoneHeight As Object = 600

    Private hpMpUserControls


    Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。

        HpMpUserControlPetHp.Label1.Text = My.Resources.hpString
        HpMpUserControlPetMp.Label1.Text = My.Resources.mpString
        HpMpUserControlRoleHp.Label1.Text = My.Resources.hpString
        HpMpUserControlRoleHp.Label1.Text = My.Resources.mpString


    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim hwnd = dm.FindWindow("AskTao", "问道")

        dm_ret = dm.BindWindow(hwnd, "dx2", "dx2", "dx", 0)

        'dm_ret = dm.GetClientSize(hwnd, zoneWidth, zoneHeight)

        dm_ret = dm.SetPath(basePath)

        dm_ret = dm.SetDict(0, "dm_soft.txt")

        dm_ret = dm.CaptureJpg(0, 0, zoneWidth, zoneHeight, Now.Millisecond + "screen.jpg", 100)

        'dm_ret = dm.CaptureJpg(0, 0, zoneWidth, zoneHeight, "1screen.jpg", 100)

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

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
