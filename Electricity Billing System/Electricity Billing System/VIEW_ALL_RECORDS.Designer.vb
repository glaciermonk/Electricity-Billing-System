<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VIEW_ALL_RECORDS
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.VIEW_INFO = New System.Windows.Forms.DataGridView
        Me.CONSUMER_ID = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.BILL_STATUS = New System.Windows.Forms.ComboBox
        Me.BUTTON_VIEW = New System.Windows.Forms.Button
        CType(Me.VIEW_INFO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VIEW_INFO
        '
        Me.VIEW_INFO.AllowUserToAddRows = False
        Me.VIEW_INFO.AllowUserToDeleteRows = False
        Me.VIEW_INFO.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.VIEW_INFO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VIEW_INFO.Location = New System.Drawing.Point(12, 12)
        Me.VIEW_INFO.Name = "VIEW_INFO"
        Me.VIEW_INFO.ReadOnly = True
        Me.VIEW_INFO.Size = New System.Drawing.Size(948, 400)
        Me.VIEW_INFO.TabIndex = 0
        '
        'CONSUMER_ID
        '
        Me.CONSUMER_ID.FormattingEnabled = True
        Me.CONSUMER_ID.Location = New System.Drawing.Point(264, 422)
        Me.CONSUMER_ID.Name = "CONSUMER_ID"
        Me.CONSUMER_ID.Size = New System.Drawing.Size(121, 21)
        Me.CONSUMER_ID.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(162, 423)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Consumer ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(433, 423)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Bill Status"
        '
        'BILL_STATUS
        '
        Me.BILL_STATUS.FormattingEnabled = True
        Me.BILL_STATUS.Location = New System.Drawing.Point(516, 420)
        Me.BILL_STATUS.Name = "BILL_STATUS"
        Me.BILL_STATUS.Size = New System.Drawing.Size(121, 21)
        Me.BILL_STATUS.TabIndex = 3
        '
        'BUTTON_VIEW
        '
        Me.BUTTON_VIEW.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BUTTON_VIEW.ForeColor = System.Drawing.SystemColors.Window
        Me.BUTTON_VIEW.Image = Global.Electricity_Billing_System.My.Resources.Resources.Material_Colors_iPhone_Wallpaper_iphoneswallpapers_com
        Me.BUTTON_VIEW.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BUTTON_VIEW.Location = New System.Drawing.Point(665, 418)
        Me.BUTTON_VIEW.Name = "BUTTON_VIEW"
        Me.BUTTON_VIEW.Size = New System.Drawing.Size(94, 26)
        Me.BUTTON_VIEW.TabIndex = 5
        Me.BUTTON_VIEW.Text = "VIEW"
        Me.BUTTON_VIEW.UseVisualStyleBackColor = True
        '
        'VIEW_ALL_RECORDS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Electricity_Billing_System.My.Resources.Resources.Material_Colors_iPhone_Wallpaper_iphoneswallpapers_com
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(972, 456)
        Me.Controls.Add(Me.BUTTON_VIEW)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BILL_STATUS)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CONSUMER_ID)
        Me.Controls.Add(Me.VIEW_INFO)
        Me.Name = "VIEW_ALL_RECORDS"
        Me.Text = "View Records"
        CType(Me.VIEW_INFO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents VIEW_INFO As System.Windows.Forms.DataGridView
    Friend WithEvents CONSUMER_ID As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BILL_STATUS As System.Windows.Forms.ComboBox
    Friend WithEvents BUTTON_VIEW As System.Windows.Forms.Button
End Class
