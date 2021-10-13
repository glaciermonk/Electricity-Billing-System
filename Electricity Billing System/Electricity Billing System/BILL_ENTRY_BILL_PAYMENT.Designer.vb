<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BILL_ENTRY_BILL_PAYMENT
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.UNITS_CONSUMED = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.CONSUMER_ID = New System.Windows.Forms.ComboBox
        Me.BUTTON_SAVE = New System.Windows.Forms.Button
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.STATUS = New System.Windows.Forms.ComboBox
        Me.WARN = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.AMOUNT = New System.Windows.Forms.TextBox
        Me.BUTTON_PAY = New System.Windows.Forms.Button
        Me.BILL_ID2 = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.PAYMENT_METHOD = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.WARN2 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Print = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Units Consumed"
        '
        'UNITS_CONSUMED
        '
        Me.UNITS_CONSUMED.Location = New System.Drawing.Point(213, 73)
        Me.UNITS_CONSUMED.Name = "UNITS_CONSUMED"
        Me.UNITS_CONSUMED.Size = New System.Drawing.Size(163, 22)
        Me.UNITS_CONSUMED.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label2.Location = New System.Drawing.Point(25, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(182, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Enter\Select Consumer ID"
        '
        'CONSUMER_ID
        '
        Me.CONSUMER_ID.FormattingEnabled = True
        Me.CONSUMER_ID.Location = New System.Drawing.Point(213, 37)
        Me.CONSUMER_ID.Name = "CONSUMER_ID"
        Me.CONSUMER_ID.Size = New System.Drawing.Size(163, 23)
        Me.CONSUMER_ID.TabIndex = 4
        '
        'BUTTON_SAVE
        '
        Me.BUTTON_SAVE.BackgroundImage = Global.Electricity_Billing_System.My.Resources.Resources.Material_Colors_iPhone_Wallpaper_iphoneswallpapers_com
        Me.BUTTON_SAVE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BUTTON_SAVE.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BUTTON_SAVE.ForeColor = System.Drawing.SystemColors.Window
        Me.BUTTON_SAVE.Location = New System.Drawing.Point(86, 236)
        Me.BUTTON_SAVE.Name = "BUTTON_SAVE"
        Me.BUTTON_SAVE.Size = New System.Drawing.Size(130, 41)
        Me.BUTTON_SAVE.TabIndex = 6
        Me.BUTTON_SAVE.Text = "SAVE"
        Me.BUTTON_SAVE.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(149, 161)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(227, 22)
        Me.DateTimePicker1.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Bill Date"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(149, 198)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(227, 22)
        Me.DateTimePicker2.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Bill Due Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Bill Status"
        '
        'STATUS
        '
        Me.STATUS.FormattingEnabled = True
        Me.STATUS.Items.AddRange(New Object() {"PAID", "UNPAID"})
        Me.STATUS.Location = New System.Drawing.Point(213, 116)
        Me.STATUS.Name = "STATUS"
        Me.STATUS.Size = New System.Drawing.Size(163, 23)
        Me.STATUS.TabIndex = 12
        '
        'WARN
        '
        Me.WARN.AutoSize = True
        Me.WARN.Location = New System.Drawing.Point(27, 4)
        Me.WARN.Name = "WARN"
        Me.WARN.Size = New System.Drawing.Size(0, 15)
        Me.WARN.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.GroupBox1.BackgroundImage = Global.Electricity_Billing_System.My.Resources.Resources.blogimage800x600
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.WARN)
        Me.GroupBox1.Controls.Add(Me.STATUS)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.BUTTON_SAVE)
        Me.GroupBox1.Controls.Add(Me.CONSUMER_ID)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.UNITS_CONSUMED)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(18, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(530, 293)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bill Entry"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(62, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 19)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Bill ID"
        '
        'AMOUNT
        '
        Me.AMOUNT.Location = New System.Drawing.Point(65, 95)
        Me.AMOUNT.Name = "AMOUNT"
        Me.AMOUNT.ReadOnly = True
        Me.AMOUNT.Size = New System.Drawing.Size(196, 22)
        Me.AMOUNT.TabIndex = 18
        '
        'BUTTON_PAY
        '
        Me.BUTTON_PAY.BackColor = System.Drawing.Color.Green
        Me.BUTTON_PAY.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BUTTON_PAY.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BUTTON_PAY.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BUTTON_PAY.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BUTTON_PAY.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.BUTTON_PAY.Location = New System.Drawing.Point(65, 203)
        Me.BUTTON_PAY.Name = "BUTTON_PAY"
        Me.BUTTON_PAY.Size = New System.Drawing.Size(84, 35)
        Me.BUTTON_PAY.TabIndex = 19
        Me.BUTTON_PAY.Text = "Pay"
        Me.BUTTON_PAY.UseVisualStyleBackColor = False
        '
        'BILL_ID2
        '
        Me.BILL_ID2.FormattingEnabled = True
        Me.BILL_ID2.Location = New System.Drawing.Point(140, 40)
        Me.BILL_ID2.Name = "BILL_ID2"
        Me.BILL_ID2.Size = New System.Drawing.Size(121, 23)
        Me.BILL_ID2.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(62, 137)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 19)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Payment Method"
        '
        'PAYMENT_METHOD
        '
        Me.PAYMENT_METHOD.FormattingEnabled = True
        Me.PAYMENT_METHOD.Items.AddRange(New Object() {"Cash", "Credit Card", "Debit Card"})
        Me.PAYMENT_METHOD.Location = New System.Drawing.Point(65, 159)
        Me.PAYMENT_METHOD.Name = "PAYMENT_METHOD"
        Me.PAYMENT_METHOD.Size = New System.Drawing.Size(196, 23)
        Me.PAYMENT_METHOD.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(62, 73)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(137, 19)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Amount in Rupees:"
        '
        'WARN2
        '
        Me.WARN2.AutoSize = True
        Me.WARN2.Location = New System.Drawing.Point(62, 16)
        Me.WARN2.Name = "WARN2"
        Me.WARN2.Size = New System.Drawing.Size(0, 15)
        Me.WARN2.TabIndex = 24
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox2.BackgroundImage = Global.Electricity_Billing_System.My.Resources.Resources.wind_power
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox2.Controls.Add(Me.Print)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.WARN2)
        Me.GroupBox2.Controls.Add(Me.PAYMENT_METHOD)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.BILL_ID2)
        Me.GroupBox2.Controls.Add(Me.BUTTON_PAY)
        Me.GroupBox2.Controls.Add(Me.AMOUNT)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(573, 17)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(517, 293)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Bill Payment"
        '
        'Print
        '
        Me.Print.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Print.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Print.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Print.ForeColor = System.Drawing.SystemColors.Window
        Me.Print.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Print.Location = New System.Drawing.Point(178, 203)
        Me.Print.Name = "Print"
        Me.Print.Size = New System.Drawing.Size(83, 35)
        Me.Print.TabIndex = 25
        Me.Print.Text = "Print"
        Me.Print.UseVisualStyleBackColor = False
        '
        'BILL_ENTRY_BILL_PAYMENT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Electricity_Billing_System.My.Resources.Resources.Material_Colors_iPhone_Wallpaper_iphoneswallpapers_com
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1083, 325)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "BILL_ENTRY_BILL_PAYMENT"
        Me.Text = "Bill Entry and Payment"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UNITS_CONSUMED As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CONSUMER_ID As System.Windows.Forms.ComboBox
    Friend WithEvents BUTTON_SAVE As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents STATUS As System.Windows.Forms.ComboBox
    Friend WithEvents WARN As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents AMOUNT As System.Windows.Forms.TextBox
    Friend WithEvents BUTTON_PAY As System.Windows.Forms.Button
    Friend WithEvents BILL_ID2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PAYMENT_METHOD As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents WARN2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Print As System.Windows.Forms.Button
End Class
