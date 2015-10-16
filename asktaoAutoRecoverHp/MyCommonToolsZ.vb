Imports System.IO

Public Class MyCommonToolsZ

    Shared Sub write(ByVal strFilePath, ByVal s)

        Dim sw As StreamWriter = New StreamWriter(strFilePath, True) 'true是指以追加的方式打开指定文件

        sw.WriteLine(s)

        sw.Flush()

        sw.Close()
        sw = Nothing

    End Sub

    Shared Function reade(ByVal strPath As String)

        Dim results As String = ""

        Dim sr As StreamReader = New StreamReader(strPath, System.Text.Encoding.Default)

        Do While sr.Peek() > 0
            results += sr.ReadLine()
        Loop



        sr.Close()

        sr = Nothing

        Return results

    End Function

End Class
