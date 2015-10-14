Public Class MyDm


    Public Delegate Function findHwnd(ByVal dm)

    Public Delegate Sub bindAction(ByVal dm, ByVal hwnd)

    Public Delegate Function gainDoneSign(ByVal dm)

    Public Delegate Function gainObjByDmCommon(ByVal dm)



    Property dm As Dm.dmsoft

    Property dm_ret

    Property basePath = "E:\software\大漠插件\字体"

    Property dictName = "dm_soft.txt"


    Property hwnd


    Sub initBaskPath()

        basePath = dm.GetBasePath()

    End Sub


    Public zoneWidth As Object = 800
    Public zoneHeight As Object = 600

    Sub New()



    End Sub

    Sub New(ByVal dm)

        Me.dm = dm

    End Sub

    ''' <summary>
    ''' common one time builder
    ''' </summary>
    ''' <param name="dm"></param>
    ''' <param name="hwnd"></param>
    ''' <param name="bindAction"></param>
    ''' <remarks></remarks>
    Sub New(ByVal dm As Dm.dmsoft, ByVal hwnd As Int32, ByVal bindAction As bindAction)

        Me.New(dm)

        initDm(hwnd, bindAction)

    End Sub


    Sub askTaoBindW()

        dm_ret = dm.BindWindow(hwnd, "dx2", "dx2", "dx", 0)

    End Sub



    Sub initDm(ByVal hwnd As Int32, ByVal bindAction As bindAction)

        Me.hwnd = hwnd

        bindAction.Invoke(dm, hwnd)

        dm_ret = dm.SetPath(basePath)

        dm_ret = dm.SetDict(0, dictName)

        dm_ret = dm.GetClientSize(hwnd, zoneWidth, zoneHeight)

    End Sub


    Sub initMousePosition()

        dm.MoveTo(zoneWidth + 50, zoneHeight + 50)

    End Sub

    Shared Sub delay(ByVal ms)

        Threading.Thread.Sleep(ms)

    End Sub


    Sub unbind()

        dm.UnBindWindow()

    End Sub

    'wait function
    Sub waitUntil(ByVal gainDoneSign As gainDoneSign)


        Do While True

            If gainDoneSign(dm) Then

                Exit Do

            End If

        Loop

    End Sub

    Protected Overloads Sub Dispose()

        dm.UnBindWindow()

    End Sub

End Class
