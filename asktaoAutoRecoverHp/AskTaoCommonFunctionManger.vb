Public Class AskTaoCommonFunctionManger

    Inherits MyAskTaoBase

    Sub New(ByVal myDm As MyDm)

        MyBase.New(myDm)

        Me.dm = myDm.dm

    End Sub


    Sub sendSTring(ByVal s)

        dm_ret = dm.ActiveInputMethod(myDm.hwnd, "Chinese (Simplified, Singapore) - US Keyboard")

        dm.SendString2(myDm.hwnd, s)

        myDm.delay(100)

        dm.KeyPressChar("enter")

    End Sub



End Class
