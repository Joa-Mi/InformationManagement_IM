' Module1.vb or Program.vb - Application Entry Point
Imports System.IO

Module MainModule
    Sub Main()
        ' Enable visual styles
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        ' Check if configuration file exists
        Dim configPath As String = Path.Combine(Application.StartupPath, "dbconfig.ini")

        If File.Exists(configPath) Then
            ' Config exists - go to login
            Application.Run(New Adminlogin())
        Else
            ' No config - show setup
            Application.Run(New ConfigForm())
        End If
    End Sub
End Module