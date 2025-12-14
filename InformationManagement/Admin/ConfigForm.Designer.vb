
' ============================================
' ConfigForm.Designer.vb - Form Designer Code
' ============================================
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConfigForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.RoundedPane21 = New InformationManagement.RoundedPane2()
        Me.txtPassword = New InformationManagement.RoundedTextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtUsername = New InformationManagement.RoundedTextBox()
        Me.lblDatabase = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtDatabase = New InformationManagement.RoundedTextBox()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.txtPort = New InformationManagement.RoundedTextBox()
        Me.txtHost = New InformationManagement.RoundedTextBox()
        Me.lblHost = New System.Windows.Forms.Label()
        Me.lblPort = New System.Windows.Forms.Label()
        Me.RoundedPane21.SuspendLayout()
        Me.SuspendLayout()
        '
        'RoundedPane21
        '
        Me.RoundedPane21.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RoundedPane21.BackColor = System.Drawing.Color.Transparent
        Me.RoundedPane21.BorderColor = System.Drawing.Color.LightGray
        Me.RoundedPane21.Controls.Add(Me.txtPassword)
        Me.RoundedPane21.Controls.Add(Me.lblTitle)
        Me.RoundedPane21.Controls.Add(Me.lblPassword)
        Me.RoundedPane21.Controls.Add(Me.btnCancel)
        Me.RoundedPane21.Controls.Add(Me.lblUsername)
        Me.RoundedPane21.Controls.Add(Me.txtUsername)
        Me.RoundedPane21.Controls.Add(Me.lblDatabase)
        Me.RoundedPane21.Controls.Add(Me.btnSave)
        Me.RoundedPane21.Controls.Add(Me.txtDatabase)
        Me.RoundedPane21.Controls.Add(Me.btnTest)
        Me.RoundedPane21.Controls.Add(Me.txtPort)
        Me.RoundedPane21.Controls.Add(Me.txtHost)
        Me.RoundedPane21.Controls.Add(Me.lblHost)
        Me.RoundedPane21.Controls.Add(Me.lblPort)
        Me.RoundedPane21.FillColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.RoundedPane21.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoundedPane21.Location = New System.Drawing.Point(174, 60)
        Me.RoundedPane21.Name = "RoundedPane21"
        Me.RoundedPane21.Size = New System.Drawing.Size(481, 505)
        Me.RoundedPane21.TabIndex = 16
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.Transparent
        Me.txtPassword.FocusBorderColor = System.Drawing.Color.DarkGray
        Me.txtPassword.Location = New System.Drawing.Point(67, 324)
        Me.txtPassword.MaxLength = 32767
        Me.txtPassword.MinimumSize = New System.Drawing.Size(50, 20)
        Me.txtPassword.Multiline = False
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.NormalBorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPassword.ReadOnly = False
        Me.txtPassword.Size = New System.Drawing.Size(342, 36)
        Me.txtPassword.TabIndex = 15
        Me.txtPassword.TextBoxBackColor = System.Drawing.Color.White
        Me.txtPassword.TextColor = System.Drawing.Color.Black
        Me.txtPassword.TextFont = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblTitle.Location = New System.Drawing.Point(117, 22)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(224, 25)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Database Configuration"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblPassword.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblPassword.Location = New System.Drawing.Point(64, 304)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(70, 19)
        Me.lblPassword.TabIndex = 9
        Me.lblPassword.Text = "Password:"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnCancel.Location = New System.Drawing.Point(208, 447)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(65, 36)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblUsername.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblUsername.Location = New System.Drawing.Point(64, 235)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(74, 19)
        Me.lblUsername.TabIndex = 7
        Me.lblUsername.Text = "Username:"
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.Transparent
        Me.txtUsername.FocusBorderColor = System.Drawing.Color.DarkGray
        Me.txtUsername.Location = New System.Drawing.Point(67, 255)
        Me.txtUsername.MaxLength = 32767
        Me.txtUsername.MinimumSize = New System.Drawing.Size(50, 20)
        Me.txtUsername.Multiline = False
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.NormalBorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.ReadOnly = False
        Me.txtUsername.Size = New System.Drawing.Size(342, 36)
        Me.txtUsername.TabIndex = 15
        Me.txtUsername.TextBoxBackColor = System.Drawing.Color.White
        Me.txtUsername.TextColor = System.Drawing.Color.Black
        Me.txtUsername.TextFont = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'lblDatabase
        '
        Me.lblDatabase.AutoSize = True
        Me.lblDatabase.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblDatabase.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblDatabase.Location = New System.Drawing.Point(64, 162)
        Me.lblDatabase.Name = "lblDatabase"
        Me.lblDatabase.Size = New System.Drawing.Size(109, 19)
        Me.lblDatabase.TabIndex = 5
        Me.lblDatabase.Text = "Database Name:"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(279, 447)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(130, 36)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "Save && Continue"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtDatabase
        '
        Me.txtDatabase.BackColor = System.Drawing.Color.Transparent
        Me.txtDatabase.FocusBorderColor = System.Drawing.Color.DarkGray
        Me.txtDatabase.Location = New System.Drawing.Point(67, 182)
        Me.txtDatabase.MaxLength = 32767
        Me.txtDatabase.MinimumSize = New System.Drawing.Size(50, 20)
        Me.txtDatabase.Multiline = False
        Me.txtDatabase.Name = "txtDatabase"
        Me.txtDatabase.NormalBorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtDatabase.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDatabase.ReadOnly = False
        Me.txtDatabase.Size = New System.Drawing.Size(342, 36)
        Me.txtDatabase.TabIndex = 15
        Me.txtDatabase.TextBoxBackColor = System.Drawing.Color.White
        Me.txtDatabase.TextColor = System.Drawing.Color.Black
        Me.txtDatabase.TextFont = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnTest
        '
        Me.btnTest.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnTest.FlatAppearance.BorderSize = 0
        Me.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTest.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnTest.Location = New System.Drawing.Point(242, 379)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(167, 36)
        Me.btnTest.TabIndex = 11
        Me.btnTest.Text = "Test Connection"
        Me.btnTest.UseVisualStyleBackColor = False
        '
        'txtPort
        '
        Me.txtPort.BackColor = System.Drawing.Color.Transparent
        Me.txtPort.FocusBorderColor = System.Drawing.Color.DarkGray
        Me.txtPort.Location = New System.Drawing.Point(299, 112)
        Me.txtPort.MaxLength = 32767
        Me.txtPort.MinimumSize = New System.Drawing.Size(50, 20)
        Me.txtPort.Multiline = False
        Me.txtPort.Name = "txtPort"
        Me.txtPort.NormalBorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtPort.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPort.ReadOnly = False
        Me.txtPort.Size = New System.Drawing.Size(110, 36)
        Me.txtPort.TabIndex = 15
        Me.txtPort.TextBoxBackColor = System.Drawing.Color.White
        Me.txtPort.TextColor = System.Drawing.Color.Black
        Me.txtPort.TextFont = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtHost
        '
        Me.txtHost.BackColor = System.Drawing.Color.Transparent
        Me.txtHost.FocusBorderColor = System.Drawing.Color.DarkGray
        Me.txtHost.Location = New System.Drawing.Point(67, 112)
        Me.txtHost.MaxLength = 32767
        Me.txtHost.MinimumSize = New System.Drawing.Size(50, 20)
        Me.txtHost.Multiline = False
        Me.txtHost.Name = "txtHost"
        Me.txtHost.NormalBorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txtHost.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtHost.ReadOnly = False
        Me.txtHost.Size = New System.Drawing.Size(216, 36)
        Me.txtHost.TabIndex = 14
        Me.txtHost.TextBoxBackColor = System.Drawing.Color.White
        Me.txtHost.TextColor = System.Drawing.Color.Black
        Me.txtHost.TextFont = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'lblHost
        '
        Me.lblHost.AutoSize = True
        Me.lblHost.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHost.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblHost.Location = New System.Drawing.Point(65, 87)
        Me.lblHost.Name = "lblHost"
        Me.lblHost.Size = New System.Drawing.Size(111, 19)
        Me.lblHost.TabIndex = 1
        Me.lblHost.Text = "Host/IP Address:"
        '
        'lblPort
        '
        Me.lblPort.AutoSize = True
        Me.lblPort.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblPort.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblPort.Location = New System.Drawing.Point(296, 87)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(37, 19)
        Me.lblPort.TabIndex = 3
        Me.lblPort.Text = "Port:"
        '
        'ConfigForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(838, 612)
        Me.Controls.Add(Me.RoundedPane21)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ConfigForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuration Page"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.RoundedPane21.ResumeLayout(False)
        Me.RoundedPane21.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblHost As Label
    Friend WithEvents lblPort As Label
    Friend WithEvents lblDatabase As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents btnTest As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtHost As RoundedTextBox
    Friend WithEvents txtPort As RoundedTextBox
    Friend WithEvents RoundedPane21 As RoundedPane2
    Friend WithEvents txtPassword As RoundedTextBox
    Friend WithEvents txtUsername As RoundedTextBox
    Friend WithEvents txtDatabase As RoundedTextBox
End Class