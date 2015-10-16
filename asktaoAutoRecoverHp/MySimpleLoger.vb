Public Class MySimpleLoger

    Shared Sub log(ByVal info)

        Dim dateT As String = Now.ToLongDateString

        dateT = dateT.Replace("/", "")


        Dim timeT = Now.ToLongTimeString

        MyCommonToolsZ.write(dateT + ".txt", timeT + " : " + info)

    End Sub

End Class
