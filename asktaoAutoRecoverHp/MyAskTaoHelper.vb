Public Class MyAskTaoHelper

    Protected dm As Dm.dmsoft

    Protected myDm As MyDm


    Sub New(ByVal myDm)

        Me.myDm = myDm

        Me.dm = myDm.dm

    End Sub


    Function gainPetHp()

        ' Dim s = dm.Ocr(136, 354, 246, 373, "f8fcf8-000000", 1.0)

        Dim s = dm.Ocr(136, 352, 242, 373, "f8fcf8-000000", 1.0)

        Dim hps = s.Split("/")

        Return hps

    End Function

    Sub toggleAtkTaoFunctionCommon(ByVal c)

        dm.KeyDownChar("alt")

        myDm.delay(100)

        dm.KeyPressChar("c")

        dm.KeyUpChar("alt")

    End Sub

    Sub toggleRoleView()

        toggleAtkTaoFunctionCommon("c")

    End Sub

    Sub togglePetView()

        toggleAtkTaoFunctionCommon("r")


    End Sub

    Sub recoverPetHp(ByVal ratio)

        Dim hps = gainPetHp()

        If hps(0) / CDbl(hps(1)) < ratio Then

            recoverPetHp()

        End If

    End Sub

    Sub recoverPetHp()

        myDm.initMousePosition()

        dm.MoveTo(513, 41)

        myDm.delay(100)

        dm.RightClick()
        dm.RightClick()

    End Sub

End Class
