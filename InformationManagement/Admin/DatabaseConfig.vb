' DatabaseConfig.vb - Helper class to read database configuration
Imports System.IO

Public Class DatabaseConfig
    Private Shared configPath As String = Path.Combine(Application.StartupPath, "dbconfig.ini")

    ' Properties to store config values
    Public Shared Property Host As String
    Public Shared Property Port As String
    Public Shared Property Database As String
    Public Shared Property Username As String
    Public Shared Property Password As String

    ' Read configuration from INI file
    Public Shared Function LoadConfig() As Boolean
        Try
            If Not File.Exists(configPath) Then
                Return False
            End If

            ' Read all lines from config file
            Dim lines() As String = File.ReadAllLines(configPath)

            For Each line As String In lines
                ' Skip empty lines and section headers
                If String.IsNullOrWhiteSpace(line) OrElse line.StartsWith("[") Then
                    Continue For
                End If

                ' Parse key=value pairs
                If line.Contains("=") Then
                    Dim parts() As String = line.Split(New Char() {"="c}, 2)
                    If parts.Length = 2 Then
                        Dim key As String = parts(0).Trim()
                        Dim value As String = parts(1).Trim()

                        Select Case key.ToLower()
                            Case "host"
                                Host = value
                            Case "port"
                                Port = value
                            Case "database"
                                Database = value
                            Case "username"
                                Username = value
                            Case "password"
                                Password = value
                        End Select
                    End If
                End If
            Next

            Return True
        Catch ex As Exception
            MessageBox.Show($"Error loading configuration: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' Get connection string
    Public Shared Function GetConnectionString() As String
        If LoadConfig() Then
            Return $"Server={Host};Port={Port};Database={Database};Uid={Username};Pwd={Password};"
        Else
            Return String.Empty
        End If
    End Function

    ' Check if config file exists
    Public Shared Function ConfigExists() As Boolean
        Return File.Exists(configPath)
    End Function
End Class