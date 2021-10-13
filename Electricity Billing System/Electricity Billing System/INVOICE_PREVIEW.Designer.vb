<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class INVOICE_PREVIEW
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
        Me.BILL_ID = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GENERATE_REPORT = New System.Windows.Forms.Button
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.INVOICE1 = New Electricity_Billing_System.INVOICE
        Me.SuspendLayout()
        '
        'BILL_ID
        '
        Me.BILL_ID.FormattingEnabled = True
        Me.BILL_ID.Location = New System.Drawing.Point(360, 33)
        Me.BILL_ID.Name = "BILL_ID"
        Me.BILL_ID.Size = New System.Drawing.Size(146, 21)
        Me.BILL_ID.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(320, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Bill ID"
        '
        'GENERATE_REPORT
        '
        Me.GENERATE_REPORT.Location = New System.Drawing.Point(545, 33)
        Me.GENERATE_REPORT.Name = "GENERATE_REPORT"
        Me.GENERATE_REPORT.Size = New System.Drawing.Size(146, 21)
        Me.GENERATE_REPORT.TabIndex = 3
        Me.GENERATE_REPORT.Text = "Generate Report"
        Me.GENERATE_REPORT.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.INVOICE1
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1005, 486)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'INVOICE_PREVIEW
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 486)
        Me.Controls.Add(Me.GENERATE_REPORT)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BILL_ID)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "INVOICE_PREVIEW"
        Me.Text = "INVOICE_PREVIEW"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents INVOICE1 As Electricity_Billing_System.INVOICE
    Friend WithEvents BILL_ID As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GENERATE_REPORT As System.Windows.Forms.Button
End Class
