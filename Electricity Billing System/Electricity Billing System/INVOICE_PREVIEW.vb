Imports System.Data.Odbc
Public Class INVOICE_PREVIEW

    'FORM LOAD, FILL BILL_ID COMBOBOX WITH LIST OF BILL_IDs
    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        Try
            Dim connection As New OdbcConnection
            Dim command As New OdbcCommand
            connection = New OdbcConnection("dsn=EBS_ODBC;user=root;pwd=root")
            connection.Open()
            command = New OdbcCommand("SELECT * FROM BILL_DB", connection)
            Dim dr As OdbcDataReader = command.ExecuteReader
            BILL_ID.Items.Clear()
            While dr.Read
                BILL_ID.Items.Add(dr(1))
            End While

            connection.Close()

            'CLEAR CRYSTAL REPORT ON FORM LOAD
            CrystalReportViewer1.ReportSource = Nothing
            CrystalReportViewer1.Refresh()

            BILL_ID.Text = BILL_ENTRY_BILL_PAYMENT.BILL_ID2.Text
            GENERATE_REPORT_Click(sender, e)
        Catch error_ As Exception
            MsgBox(Convert.ToString(error_))
        End Try
    End Sub

    'GENERATE REPORT BUTTON
    Private Sub GENERATE_REPORT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GENERATE_REPORT.Click
        Try

            Dim connection As New OdbcConnection
            connection = New OdbcConnection("dsn=EBS_ODBC;user=root;pwd=root")

            'connection string
            connection.Open()
            Dim DATA_ADAPTER As New OdbcDataAdapter("select * from BILL_DB where BILL_ID=' " & BILL_ID.Text & " '", connection)
            Dim DATA_SET As New DataSet
            DATA_ADAPTER.Fill(DATA_SET)

            Dim rpath = "C:\Users\User\Documents\Visual Studio 2008\Projects\Electricity Billing System\Electricity Billing System\INVOICE.rpt"
            Dim doc As New CrystalDecisions.CrystalReports.Engine.ReportDocument()
            doc.Load(rpath)
            doc.SetDataSource(DATA_SET.Tables(0))
            CrystalReportViewer1.ReportSource = doc
            CrystalReportViewer1.RefreshReport()


            connection.Close()

        Catch error_ As Exception
            MsgBox(Convert.ToString(error_))
        End Try

    End Sub
End Class