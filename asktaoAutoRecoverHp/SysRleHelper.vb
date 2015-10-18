Imports System.IO

Public Class SysRleHelper

    Shared dllPaths = {"dm.dll", "BSSOFT.DLL"}


    Shared Sub regeditDllByCondition()

        Try

            Dim objT = New Dm.dmsoft
            Dim ojbT1 = New bssoftT.Class


        Catch ex As Exception
            regeditDll()
        End Try


    End Sub


    Shared Sub regeditDll()

        Dim ws = CreateObject("Wscript.Shell")

        'Dim p = Application.StartupPath + "\"

        ' MsgBox(p)


        For Each path In dllPaths

            ws.run("regsvr32 " + path + " /s")

        Next



    End Sub


End Class
