Partial Class BatchManagement
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblIngredientName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotalStock = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblActiveBatches = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTotalValue = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblExpiringCount = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dgvBatches = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New InformationManagement.RoundedPane2()
        Me.Panel3 = New InformationManagement.RoundedPane2()
        Me.Panel4 = New InformationManagement.RoundedPane2()
        Me.Panel5 = New InformationManagement.RoundedPane2()
        Me.btnViewHistory = New ReaLTaiizor.Controls.Button()
        Me.btnAddBatch = New ReaLTaiizor.Controls.Button()
        Me.btnClose = New ReaLTaiizor.Controls.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvBatches, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lblIngredientName)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(884, 80)
        Me.Panel1.TabIndex = 0
        '
        'lblIngredientName
        '
        Me.lblIngredientName.AutoSize = True
        Me.lblIngredientName.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngredientName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblIngredientName.Location = New System.Drawing.Point(23, 33)
        Me.lblIngredientName.Name = "lblIngredientName"
        Me.lblIngredientName.Size = New System.Drawing.Size(208, 32)
        Me.lblIngredientName.TabIndex = 1
        Me.lblIngredientName.Text = "Ingredient Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(22, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Batch Management for"
        '
        'lblTotalStock
        '
        Me.lblTotalStock.AutoSize = True
        Me.lblTotalStock.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalStock.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalStock.Location = New System.Drawing.Point(17, 56)
        Me.lblTotalStock.Name = "lblTotalStock"
        Me.lblTotalStock.Size = New System.Drawing.Size(35, 23)
        Me.lblTotalStock.TabIndex = 1
        Me.lblTotalStock.Text = "0.0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(17, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Total Stock"
        '
        'lblActiveBatches
        '
        Me.lblActiveBatches.AutoSize = True
        Me.lblActiveBatches.BackColor = System.Drawing.Color.Transparent
        Me.lblActiveBatches.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold)
        Me.lblActiveBatches.Location = New System.Drawing.Point(19, 54)
        Me.lblActiveBatches.Name = "lblActiveBatches"
        Me.lblActiveBatches.Size = New System.Drawing.Size(20, 23)
        Me.lblActiveBatches.TabIndex = 1
        Me.lblActiveBatches.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(19, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Active Batches"
        '
        'lblTotalValue
        '
        Me.lblTotalValue.AutoSize = True
        Me.lblTotalValue.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalValue.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold)
        Me.lblTotalValue.Location = New System.Drawing.Point(16, 53)
        Me.lblTotalValue.Name = "lblTotalValue"
        Me.lblTotalValue.Size = New System.Drawing.Size(56, 23)
        Me.lblTotalValue.TabIndex = 1
        Me.lblTotalValue.Text = "₱0.00"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(16, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 17)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Total Value"
        '
        'lblExpiringCount
        '
        Me.lblExpiringCount.AutoSize = True
        Me.lblExpiringCount.BackColor = System.Drawing.Color.Transparent
        Me.lblExpiringCount.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold)
        Me.lblExpiringCount.ForeColor = System.Drawing.Color.Green
        Me.lblExpiringCount.Location = New System.Drawing.Point(10, 53)
        Me.lblExpiringCount.Name = "lblExpiringCount"
        Me.lblExpiringCount.Size = New System.Drawing.Size(20, 23)
        Me.lblExpiringCount.TabIndex = 1
        Me.lblExpiringCount.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label9.Location = New System.Drawing.Point(10, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(143, 17)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Expiring Soon (7 days)"
        '
        'dgvBatches
        '
        Me.dgvBatches.AllowUserToAddRows = False
        Me.dgvBatches.AllowUserToDeleteRows = False
        Me.dgvBatches.BackgroundColor = System.Drawing.Color.White
        Me.dgvBatches.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvBatches.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBatches.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvBatches.ColumnHeadersHeight = 40
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBatches.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvBatches.EnableHeadersVisualStyles = False
        Me.dgvBatches.Location = New System.Drawing.Point(29, 232)
        Me.dgvBatches.Name = "dgvBatches"
        Me.dgvBatches.ReadOnly = True
        Me.dgvBatches.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvBatches.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvBatches.Size = New System.Drawing.Size(815, 352)
        Me.dgvBatches.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 208)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 21)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Batch Inventory"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BorderColor = System.Drawing.Color.LightGray
        Me.Panel2.Controls.Add(Me.lblTotalStock)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.FillColor = System.Drawing.Color.White
        Me.Panel2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Panel2.Location = New System.Drawing.Point(29, 96)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(185, 96)
        Me.Panel2.TabIndex = 10
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BorderColor = System.Drawing.Color.LightGray
        Me.Panel3.Controls.Add(Me.lblActiveBatches)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.FillColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(240, 99)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(185, 96)
        Me.Panel3.TabIndex = 11
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.BorderColor = System.Drawing.Color.LightGray
        Me.Panel4.Controls.Add(Me.lblTotalValue)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.FillColor = System.Drawing.Color.White
        Me.Panel4.Location = New System.Drawing.Point(448, 99)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(185, 96)
        Me.Panel4.TabIndex = 12
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.BorderColor = System.Drawing.Color.LightGray
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Controls.Add(Me.lblExpiringCount)
        Me.Panel5.FillColor = System.Drawing.Color.White
        Me.Panel5.Location = New System.Drawing.Point(659, 99)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(185, 96)
        Me.Panel5.TabIndex = 13
        '
        'btnViewHistory
        '
        Me.btnViewHistory.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnViewHistory.BackColor = System.Drawing.Color.Transparent
        Me.btnViewHistory.BorderColor = System.Drawing.Color.Transparent
        Me.btnViewHistory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnViewHistory.EnteredBorderColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnViewHistory.EnteredColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnViewHistory.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnViewHistory.Image = Nothing
        Me.btnViewHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnViewHistory.InactiveColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.btnViewHistory.Location = New System.Drawing.Point(29, 609)
        Me.btnViewHistory.Name = "btnViewHistory"
        Me.btnViewHistory.PressedBorderColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnViewHistory.PressedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnViewHistory.Size = New System.Drawing.Size(124, 36)
        Me.btnViewHistory.TabIndex = 16
        Me.btnViewHistory.Text = "View History"
        Me.btnViewHistory.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'btnAddBatch
        '
        Me.btnAddBatch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddBatch.BackColor = System.Drawing.Color.Transparent
        Me.btnAddBatch.BorderColor = System.Drawing.Color.Transparent
        Me.btnAddBatch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddBatch.EnteredBorderColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnAddBatch.EnteredColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnAddBatch.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddBatch.Image = Nothing
        Me.btnAddBatch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddBatch.InactiveColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnAddBatch.Location = New System.Drawing.Point(625, 609)
        Me.btnAddBatch.Name = "btnAddBatch"
        Me.btnAddBatch.PressedBorderColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnAddBatch.PressedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAddBatch.Size = New System.Drawing.Size(124, 36)
        Me.btnAddBatch.TabIndex = 17
        Me.btnAddBatch.Text = "Add New Batch"
        Me.btnAddBatch.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.BorderColor = System.Drawing.Color.Transparent
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.EnteredBorderColor = System.Drawing.Color.Transparent
        Me.btnClose.EnteredColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnClose.Image = Nothing
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.InactiveColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(755, 609)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.PressedBorderColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnClose.PressedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnClose.Size = New System.Drawing.Size(89, 36)
        Me.btnClose.TabIndex = 18
        Me.btnClose.Text = "Close"
        Me.btnClose.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'BatchManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(884, 651)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAddBatch)
        Me.Controls.Add(Me.btnViewHistory)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvBatches)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BatchManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Batch Management"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvBatches, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblIngredientName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotalStock As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblActiveBatches As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTotalValue As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblExpiringCount As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents dgvBatches As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As RoundedPane2
    Friend WithEvents Panel3 As RoundedPane2
    Friend WithEvents Panel4 As RoundedPane2
    Friend WithEvents Panel5 As RoundedPane2
    Friend WithEvents btnViewHistory As ReaLTaiizor.Controls.Button
    Friend WithEvents btnAddBatch As ReaLTaiizor.Controls.Button
    Friend WithEvents btnClose As ReaLTaiizor.Controls.Button
End Class