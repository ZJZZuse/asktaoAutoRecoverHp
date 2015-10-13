Public Class MyAskTaoHelper

    Protected dm As Dm.dmsoft

    Protected myDm As MyDm


    Sub New(ByVal myDm)

        Me.myDm = myDm

        Me.dm = myDm.dm

    End Sub

    ''' <summary>
    ''' that's take effect in unfighting condition.
    ''' is the main w for use
    ''' </summary>
    ''' <param name="rHpR"></param>
    ''' <param name="rMpR"></param>
    ''' <param name="pHpR"></param>
    ''' <param name="pMpR"></param>
    ''' <remarks></remarks>
    Sub recoverPetRoleHMPAutoFacede(ByVal rHpR, ByVal rMpR, ByVal pHpR, ByVal pMpR)

        recoverRoleHp(rHpR)
        recoverRoleMp(rMpR)
        recoverPetHp(pHpR)
        recoverPetMp(pMpR)

    End Sub

    Function gainPetHp()

        ' Dim s = dm.Ocr(136, 354, 246, 373, "f8fcf8-000000", 1.0)

        Dim s = dm.Ocr(136, 352, 242, 373, "f8fcf8-000000", 1.0)

        Dim hps = s.Split("/")

        Return hps

    End Function

    ''' <summary>
    ''' to do
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function gainPetMp()

        ' Dim s = dm.Ocr(136, 354, 246, 373, "f8fcf8-000000", 1.0)

        Dim s = dm.Ocr(136, 352, 242, 373, "f8fcf8-000000", 1.0)

        Dim hps = s.Split("/")

        Return hps

    End Function

    Function gainRoleHp()
        Dim hps = Nothing




        Return hps

    End Function


    Function gainRoleMp()
        Dim hps = Nothing




        Return hps

    End Function

    Function isFightingState()

        'words

        Return False

    End Function

    Function isAutoFightViewOpen()

        'find for the dialog some certain text

        Return True

    End Function

    Function isRoleViewOpened()

        Return False

    End Function

    Function isPetViewOpened()

        'find words
        Return False

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

    Sub recoverRoleMp(ByVal ratio)

        Dim mps = gainPetMp()

        If isFightingState() Then

            Exit Sub

        End If


        If mps(0) / CDbl(mps(1)) < ratio Then

            recoverRoleHp()

        End If

    End Sub

    Sub recoverRoleHp(ByVal ratio)

        Dim hps = gainPetHp()


        If isFightingState() Then

            Exit Sub

        End If

        If hps(0) / CDbl(hps(1)) < ratio Then

            recoverRoleHp()

        End If

    End Sub

    Sub recoverPetMp(ByVal ratio)

        Dim mps = gainPetMp()


        If isFightingState() Then

            Exit Sub

        End If

        If mps(0) / CDbl(mps(1)) < ratio Then

            recoverPetHp()

        End If

    End Sub

    Sub recoverPetHp(ByVal ratio)

        Dim hps = gainPetHp()

        If isFightingState() Then

            Exit Sub

        End If


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

    Private Sub recoverRoleHp()
        Throw New NotImplementedException
    End Sub

End Class
