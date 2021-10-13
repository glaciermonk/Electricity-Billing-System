Imports System.Data.Odbc
Public Class VIEW_ALL_RECORDS

    'FORM LOAD FILL CONSUMER_ID COMBOBOX AND LOAD ALL RECORDS FROM BILL_DB INTO DATAGRIDVIEWER
    Private Sub VIEW_BILLING_INFO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'RELOAD DATA INTO VIEW_CONSUMER_LIST DATAGRIDVIEWER IN ORDER FOR THE NEW ENTRY TO APPEAR
        Dim connection As New OdbcConnection
        Dim ADAPTER As New OdbcDataAdapter
        Dim DATA_TABLE As New DataTable
        Dim command As New OdbcCommand
        connection = New OdbcConnection("dsn=EBS_ODBC;user=root;pwd=root")
        connection.Open()
        ADAPTER = New OdbcDataAdapter("select * from BILL_DB", connection)
        ADAPTER.Fill(DATA_TABLE)
        VIEW_INFO.DataSource = DATA_TABLE
        BILL_STATUS.Text = "ALL"
        BILL_STATUS.Items.Add("ALL")
        BILL_STATUS.Items.Add("PAID")
        BILL_STATUS.Items.Add("UNPAID")

        CONSUMER_ID.Items.Add("ALL")
        CONSUMER_ID.Text = "ALL"
        'READ CONSUMER_ID FROM CONSUMER_DB AND FILL CONSUMER_ID COMBOBOX
        command = New OdbcCommand("select CONSUMER_ID from CONSUMER_DB", connection)
        Dim data_reader As OdbcDataReader = command.ExecuteReader
        While data_reader.Read
            CONSUMER_ID.Items.Add(data_reader(0))
        End While

        connection.Close()
    End Sub

    'VIEW BUTTON
    Private Sub BUTTON_VIEW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BUTTON_VIEW.Click

        Dim connection As New OdbcConnection
        Dim ADAPTER As New OdbcDataAdapter
        Dim DATA_TABLE As New DataTable
        Dim command As New OdbcCommand

        connection = New OdbcConnection("dsn=EBS_ODBC;user=root;pwd=root")
        connection.Open()

        If CONSUMER_ID.Text = "ALL" And BILL_STATUS.Text = "ALL" Then 'works
            ADAPTER = New OdbcDataAdapter("select * from BILL_DB", connection)
            ADAPTER.Fill(DATA_TABLE)
            VIEW_INFO.DataSource = DATA_TABLE
        ElseIf CONSUMER_ID.Text = "ALL" And BILL_STATUS.Text = "PAID" Then 'works
            ADAPTER = New OdbcDataAdapter("select * from BILL_DB where bill_status = 'PAID'", connection)
            ADAPTER.Fill(DATA_TABLE)
            VIEW_INFO.DataSource = DATA_TABLE
        ElseIf CONSUMER_ID.Text = "ALL" And BILL_STATUS.Text = "UNPAID" Then 'works
            ADAPTER = New OdbcDataAdapter("select * from BILL_DB where bill_status = 'UNPAID'", connection)
            ADAPTER.Fill(DATA_TABLE)
            VIEW_INFO.DataSource = DATA_TABLE
        ElseIf CONSUMER_ID.Text <> "ALL" And BILL_STATUS.Text = "PAID" Then 'works
            ADAPTER = New OdbcDataAdapter("select * from BILL_DB where CONSUMER_ID = ' " & CONSUMER_ID.Text & " ' and bill_status = 'PAID'", connection)
            ADAPTER.Fill(DATA_TABLE)
            VIEW_INFO.DataSource = DATA_TABLE
        ElseIf CONSUMER_ID.Text <> "ALL" And BILL_STATUS.Text = "UNPAID" Then 'works
            ADAPTER = New OdbcDataAdapter("select * from BILL_DB where CONSUMER_ID = ' " & CONSUMER_ID.Text & " ' and bill_status = 'UNPAID'", connection)
            ADAPTER.Fill(DATA_TABLE)
            VIEW_INFO.DataSource = DATA_TABLE
        ElseIf CONSUMER_ID.Text <> "ALL" And BILL_STATUS.Text = "ALL" Then 'works
            ADAPTER = New OdbcDataAdapter("select * from BILL_DB where CONSUMER_ID = ' " & CONSUMER_ID.Text & " '", connection)
            ADAPTER.Fill(DATA_TABLE)
            VIEW_INFO.DataSource = DATA_TABLE
        End If

        connection.Close()
    End Sub
End Class