Public Class SysRleHelper

    Shared dllPaths = {"", ""}

    Shared Sub regeditDll()

        Dim ws = CreateObject("Wscript.Shell")

        Dim p = Application.StartupPath

        MsgBox(p)


        'For Each path In dllPaths

        '    ws.run("regsvr32 " + path + " /s")

        'Next



    End Sub




End Class
