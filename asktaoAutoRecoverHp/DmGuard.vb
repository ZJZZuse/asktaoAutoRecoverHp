Public Class DmGuard

    Public Shared bsSoft As New bssoftT.Class

    ''' <summary>
    ''' common usage
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Shared Function initAndGoGuard()

        Dim r(2)

        r(0) = DmGuard.registerBs()

        r(1) = DmGuard.doGuard()

        Return r(2)

    End Function

    Shared Function registerBs()

        Return DmGuard.bsSoft.RegisterPlugin("bsplugin")

    End Function

    Shared Function doGuard()

        Return DmGuard.bsSoft.SuperProtect()


    End Function


End Class
