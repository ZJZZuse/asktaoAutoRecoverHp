Public Class DmGuard

    Public Shared bsSoft As New BS24.Class

    ''' <summary>
    ''' common usage
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Shared Function initAndGoGuard()

        Return {registerBs(), doGuard()}

    End Function

    Shared Function registerBs()

        Return bsSoft.RegisterPlugin("bsplugin")

    End Function

    Shared Function doGuard()

        Return bsSoft.SuperProtect()


    End Function


End Class
