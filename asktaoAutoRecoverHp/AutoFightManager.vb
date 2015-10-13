Public Class AutoFightManager

    Inherits MyAskTaoHelper

    Sub New(ByVal myDm)
        MyBase.New(myDm)
    End Sub

    Function isFightingState()

        Return False

    End Function

    Function isAutoFightViewOpen()



        Return True

    End Function

    Sub toggleAutoFight()

        toggleAtkTaoFunctionCommon("z")

    End Sub

    Sub clickContinueBtn()

        myDm.initMousePosition()

        'moveto

        myDm.delay(100)

        dm.LeftDoubleClick()

    End Sub

    ''' 隔个10s运行一次即可
    Function isMoveForFighting()

        Return False

    End Function

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
