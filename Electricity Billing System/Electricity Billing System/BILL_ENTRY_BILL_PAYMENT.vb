Imports System.Data.Odbc
Public Class BILL_ENTRY_BILL_PAYMENT

    'SAVE BUTTON
    Private Sub BUTTON_SAVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BUTTON_SAVE.Click
        Dim connection As New OdbcConnection
        Dim command As New OdbcCommand
        Dim BILL_AMOUNT As Integer

        connection = New OdbcConnection("dsn=EBS_ODBC;user=root;pwd=root")
        connection.Open()

        Try
            'ENTER INFORMATION INTO BILL_DB
            BILL_AMOUNT = 50 * Convert.ToInt64(UNITS_CONSUMED.Text)  'CALCULATE BILL AMOUNT
            Dim NULL As String
            NULL = "NULL"
            command = New OdbcCommand("INSERT INTO BILL_DB (CONSUMER_ID, BILL_AMOUNT, BILL_DATE, BILL_DUE_DATE, UNITS_CONSUMED, BILL_STATUS, PAYMENT_METHOD) VALUES(' " & CONSUMER_ID.Text & " ',' " & BILL_AMOUNT.ToString & " ',' " & Format(DateTimePicker1.Value, "yyyy-MM-dd") & " ',' " & Format(DateTimePicker2.Value, "yyyy-MM-dd") & " ',' " & UNITS_CONSUMED.Text & " ',' " & STATUS.Text & " ',' " & NULL & " ' )", connection)
            command.ExecuteNonQuery()

            'THE ABOVE COMMAND SAVES BILL_STATUS AS " UNPAID " (BLANK SPACES AT BOTH ENDS) INSTEAD OF "UNPAID" WHICH CAUSES ISSUES IN VIEW_BILLING_INFO FORM, THE BELOW COMMAND FIXES THAT
            command = New OdbcCommand("update bill_db set bill_status = 'UNPAID' where bill_status = ' UNPAID ' ", connection)
            command.ExecuteNonQuery()
            MsgBox("Inserted Succesfully!")

            UNITS_CONSUMED.Clear()

            'REFRESH BILL_ID2 COMBOBOX IN Bill Payment GroupBox after bill entry
            Dim dr As OdbcDataReader
            command = New OdbcCommand("SELECT BILL_ID FROM BILL_DB WHERE BILL_STATUS = 'UNPAID'", connection)
            dr = command.ExecuteReader
            BILL_ID2.Items.Clear()
            While dr.Read
                BILL_ID2.Items.Add(dr(0))
            End While
            BUTTON_PAY.Show()
            WARN2.Text = ""

        Catch EXCEPTION As Exception
            MsgBox(Convert.ToString(EXCEPTION))
        End Try

        connection.Close()
    End Sub

    'FORM LOAD EVENTS
    Private Sub ENTER_UNITS_CONSUMED_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            STATUS.Text = "UNPAID" 'DEFAULT BILL STATUS SET TO "UNPAID"  

            Dim connection As New OdbcConnection
            Dim command As New OdbcCommand

            connection = New OdbcConnection("dsn=EBS_ODBC;user=root;pwd=root")
            connection.Open()


            'CHECK IF CONSUMER_DB IS EMPTY OR NOT, IF NOT FILL CONSUMER_ID COMBOBOX WITH CONSUMER IDs FROM CONSUMER_DB
            command = New OdbcCommand("SELECT CONSUMER_ID FROM CONSUMER_DB", connection)
            Dim DATA_READER As OdbcDataReader = command.ExecuteReader
            CONSUMER_ID.Items.Clear()
            If (DATA_READER.HasRows) Then
                While DATA_READER.Read
                    CONSUMER_ID.Items.Add(DATA_READER(0))
                End While
            Else
                BUTTON_SAVE.Hide()
                WARN.Text = "No consumer records found. Please enter at least one consumer record to be able to save billing info!"
            End If

            'CHECK IF BILL_DB IS EMPTY OR NOT AND FILL BILL_ID2 COMBOBOX WITH BILL IDs FROM BILL_DB
            command = New OdbcCommand("SELECT BILL_ID FROM BILL_DB WHERE BILL_STATUS = 'UNPAID'", connection)
            DATA_READER = command.ExecuteReader
            BILL_ID2.Items.Clear()
            If (DATA_READER.HasRows) Then
                While DATA_READER.Read
                    BILL_ID2.Items.Add(DATA_READER(0))
                End While
            Else
                BUTTON_PAY.Hide()
                WARN2.Text = "No pending bill payments!"
            End If

            'SET DUE DATE TO 30 DAYS
            Dim currDate, currDate30 As DateTime
            currDate = DateTimePicker1.Value()
            currDate30 = DateTimePicker1.Value.AddDays(30)
            currDate30.AddDays(30)
            DateTimePicker2.Value() = currDate30
            DateTimePicker1.Value() = currDate

            'DISABLE PRINT BUTTON ON FORMLOAD
            Print.Enabled = False

            connection.Close()
        Catch EXCEPTION As Exception
            MsgBox(Convert.ToString(EXCEPTION))
        End Try
    End Sub

    'SETS CURRENT DATE AND DUE DATE AUTOMATICALLY
    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        'SET DUE DATE TO 30 DAYS
        Dim currentDate, currentDate15 As DateTime
        currentDate = DateTimePicker1.Value()
        currentDate15 = DateTimePicker1.Value.AddDays(30)
        currentDate15.AddDays(30)
        DateTimePicker2.Value() = currentDate15
        DateTimePicker1.Value() = currentDate
    End Sub

    'BILL ID2 COMBOBOX
    Private Sub BILL_ID2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BILL_ID2.SelectedIndexChanged
        Dim connection As New OdbcConnection
        Dim command As New OdbcCommand
        Dim ADAPTER As New OdbcDataAdapter

        connection = New OdbcConnection("dsn=EBS_ODBC;user=root;pwd=root")
        connection.Open()

        command = New OdbcCommand("SELECT BILL_AMOUNT FROM BILL_DB WHERE BILL_ID = ' " & BILL_ID2.Text & " ' ", connection)
        Dim DATA_READER As OdbcDataReader = command.ExecuteReader
        Dim AMOUNT_ As Decimal

        DATA_READER.Read()
        AMOUNT_ = DATA_READER(0)
        AMOUNT.Text = Convert.ToString(AMOUNT_)

        Print.Enabled = True

        connection.Close()
    End Sub

    'PAY BUTTON
    Private Sub BUTTON_PAY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BUTTON_PAY.Click
        Dim connection As New OdbcConnection
        Dim command As New OdbcCommand

        connection = New OdbcConnection("dsn=EBS_ODBC;user=root;pwd=root")
        connection.Open()

        Try
            command = New OdbcCommand("UPDATE BILL_DB SET BILL_STATUS = 'PAID', PAYMENT_METHOD = ' " & PAYMENT_METHOD.Text & " ' WHERE BILL_ID = ' " & BILL_ID2.Text & " ' ", connection)
            command.ExecuteNonQuery()
            MsgBox("Paid Succesfully!")

        Catch EXCEPTION As Exception
            MsgBox(Convert.ToString(EXCEPTION))
        End Try

        connection.Close()
    End Sub

    'PRINT BUTTON
    Private Sub PRINT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Print.Click
        INVOICE_PREVIEW.Show()
        INVOICE_PREVIEW.MaximizeBox = True
    End Sub
End Class