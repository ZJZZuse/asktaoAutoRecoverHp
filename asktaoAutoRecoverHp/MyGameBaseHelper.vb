Public NotInheritable Class MyGameBaseHelper

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns>ms</returns>
    ''' <remarks></remarks>
    Shared Function generateCommonInterval()

        Dim r = New Random

        Dim i = r.Next(0, 6000)

        Return i - 3000


    End Function

End Class
