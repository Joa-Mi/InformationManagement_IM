' ConfigForm.vb - Database Configuration Form
Imports System.IO
Imports MySqlConnector

Public Class ConfigForm
    Private configFilePath As String = Path.Combine(Application.StartupPath, "dbconfig.ini")

    Private Sub ConfigForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Center the form
        Me.StartPosition = FormStartPosition.CenterScreen

        ' Set default values
        txtHost.Text = "localhost"
        txtPort.Text = "3306"
        txtUsername.Text = "root"
    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        ' Test database connection
        If ValidateInputs() Then
            TestConnection()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Save configuration
        If ValidateInputs() Then
            If TestConnection() Then
                SaveConfiguration()
                MessageBox.Show("Configuration saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Open login form and close this form
                Dim loginForm As New Adminlogin()
                loginForm.Show()
                Me.Hide()
            End If
        End If
    End Sub

    Private Function ValidateInputs() As Boolean
        ' Check if required fields are filled
        If String.IsNullOrWhiteSpace(txtHost.Text) Then
            MessageBox.Show("Please enter Host/IP Address", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtHost.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtPort.Text) Then
            MessageBox.Show("Please enter Port", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPort.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtDatabase.Text) Then
            MessageBox.Show("Please enter Database Name", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDatabase.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtUsername.Text) Then
            MessageBox.Show("Please enter Username", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUsername.Focus()
            Return False
        End If

        Return True
    End Function

    Private Function TestConnection() As Boolean
        Try
            ' Build connection string
            Dim connStr As String = $"Server={txtHost.Text};Port={txtPort.Text};Database={txtDatabase.Text};Uid={txtUsername.Text};Pwd={txtPassword.Text};"

            ' Try to connect
            Using conn As New MySqlConnection(connStr)
                conn.Open()
                MessageBox.Show("Connection successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                conn.Close()
                Return True
            End Using
        Catch ex As Exception
            MessageBox.Show($"Connection failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Sub SaveConfiguration()
        Try
            ' Create INI file content
            Dim configContent As String = "[DATABASE]" & vbCrLf &
                                         "Host=" & txtHost.Text & vbCrLf &
                                         "Port=" & txtPort.Text & vbCrLf &
                                         "Database=" & txtDatabase.Text & vbCrLf &
                                         "Username=" & txtUsername.Text & vbCrLf &
                                         "Password=" & txtPassword.Text & vbCrLf

            ' Write to file
            File.WriteAllText(configFilePath, configContent)
        Catch ex As Exception
            MessageBox.Show($"Failed to save configuration: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ' Exit application if setup is cancelled
        If MessageBox.Show("Are you sure you want to exit? The application needs to be configured.", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

End Class


