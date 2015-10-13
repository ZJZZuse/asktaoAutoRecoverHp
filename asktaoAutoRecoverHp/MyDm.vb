Public Class MyDm


    Public Delegate Function findHwnd(ByVal dm)

    Public Delegate Sub bindAction(ByVal dm, ByVal hwnd, ByVal hwnds)

    Public Delegate Function gainDoneSign(ByVal dm)

    Public Delegate Function gainObjByDmCommon(ByVal dm)



    Property dm As Dm.dmsoft

    Property dm_ret

    Property basePath = "E:\software\大漠插件\字体"

    Property dictName = "dm_soft.txt"

    Property hwnds

    Property hwnd


    WriteOnly Property basePathAndDictName()


        Set(ByVal ps)
            basePath = ps(0)
            dictName = ps(1)
        End Set

    End Property



    Dim zoneWidth As Object = 800
    Dim zoneHeight As Object = 600



    Sub New()



    End Sub

    Sub New(ByVal dm)

        Me.dm = dm

    End Sub



    Sub askTaoBindW()

        dm_ret = dm.BindWindow(hwnd, "dx2", "dx2", "dx", 0)

    End Sub


    Sub initDm(ByVal findHwnd As findHwnd, ByVal bindAction As bindAction)


        Dim backs = findHwnd.Invoke(dm)

        If backs(1) Then

            hwnd = backs(0)

        Else

            hwnds = CStr(backs(0)).Split(",")

        End If


        bindAction.Invoke(dm, hwnd, hwnds)

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


    Protected Overrides Sub Finalize()

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


End Class
