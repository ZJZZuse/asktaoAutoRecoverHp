Public Class AutoFightManager

    Inherits MyAskTaoHelper

    Sub New(ByVal myDm)
        MyBase.New(myDm)
    End Sub




    Sub toggleAutoFight()

        toggleAtkTaoFunctionCommon("z")

    End Sub

    Sub clickContinueBtn()

        myDm.initMousePosition()

        'moveto

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
