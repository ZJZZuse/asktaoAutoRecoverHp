Public Class AskTaoCommonFunctionManger

    Inherits MyAskTaoBase

    Sub New(ByVal myDm As MyDm)

        MyBase.New(myDm)

        Me.dm = myDm.dm

    End Sub


    Sub sendSTring(ByVal s)

        dm.SendString(myDm.hwnd, s)

        myDm.delay(100)

        dm.KeyPressChar("enter")

    End Sub



End Class
