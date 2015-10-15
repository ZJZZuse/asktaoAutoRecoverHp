Public Class AutoFightManager

    Inherits MyAskTaoBase

    Dim dm_ret As Integer

    Sub New(ByVal myDm)
        MyBase.New(myDm)
    End Sub




    Sub toggleAutoFight()

        toggleAtkTaoFunctionCommon("z")

    End Sub

    Sub clickContinueBtn()

        myDm.initMousePosition()

        Dim intX = 0, intY = 0

        'dm.EnableDisplayDebug(1)

        Do While True
            Dim dm_retT = dm.FindStr(0, 0, myDm.zoneWidth, myDm.zoneHeight, "剩余", "f8fcf8-000000", 1.0, intX, intY)

            'dm.CapturePre(Now.Millisecond.ToString + "screen.bmp")


            If dm_retT <> -1 Then
                Exit Do
            End If

            
            myDm.delay(1000)

        Loop
       
        'dm_ret = dm.CaptureJpg(0, 0, myDm.zoneWidth, myDm.zoneHeight, Now.Millisecond.ToString + "screen.jpg", 100)







        'If dm_retT = -1 Then

        '    dm.MoveTo(76, 574)

        '    myDm.delay(100)

        '    dm.LeftDoubleClick()

        '    Exit Sub

        'End If

        dm.MoveTo(intX + 42, intY + 34)

        myDm.delay(100)

        dm.LeftDoubleClick()

    End Sub


    Function isMoveForFighting()

        'view the pos in the left up side, see wether the data is change


        myDm.delay(500)



        Return False

    End Function

    ''' 隔个10s运行一次即可
    Sub autoFightF()

        If isFightingState() Then

            If isAutoFightViewOpen() Then

                clickContinueBtn()


            Else

                toggleAutoFight()

            End If

        Else


            If Not isMoveForFighting() Then

                toggleAutoFight()

            End If



        End If


    End Sub

End Class
