Imports System.IO

Public Class SysRleHelper

    Shared dllPaths = {"dm.dll", "BSSOFT.DLL"}



    Shared Sub regeditDll()

        Dim ws = CreateObject("Wscript.Shell")

        Dim p = Application.StartupPath + "\"

        ' MsgBox(p)


        For Each path In dllPaths

            ws.run("regsvr32 " + p + path + " /s")

        Next



    End Sub


End Class
