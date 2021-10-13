Imports System.Data.Odbc
Public Class NEW_CONSUMER_DATA_INPUT

    'SAVE BUTTON
    Dim CONSUMER_ID_INT As Integer 'TO GET CONSUMER_ID FROM COUNTER_DB TABLE AND INCREMENT ITS VALUE AND FILL IT IN CONSUMER_ID TEXTBOX. USED IN FORM LOAD AND SAVE BUTTON
    Private Sub SAVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SAVE.Click
        Dim connection As New OdbcConnection
        Dim command As New OdbcCommand

        connection = New OdbcConnection("dsn=EBS_ODBC;user=root;pwd=root")
        connection.Open()
        Try
            command = New OdbcCommand("INSERT INTO CONSUMER_DB (CONSUMER_NAME, CONSUMER_PHONE, CONSUMER_EMAIL, CONSUMER_STATE, CONSUMER_CITY, CONSUMER_PIN_CODE, METER_ID) VALUES(' " & CONSUMER_NAME.Text & " ',' " & CONSUMER_PHONE.Text & " ',' " & CONSUMER_EMAIL.Text & " ',' " & CONSUMER_STATE.Text & " ',' " & CONSUMER_CITY.Text & " ',' " & CONSUMER_PIN_CODE.Text & " ', '" & METER_ID.Text & " ')", connection)
            command.ExecuteNonQuery()
            MsgBox("Inserted Succesfully!")
        Catch EXCEPTION As Exception
            MsgBox(EXCEPTION.ToString)
        End Try

        'RELOAD DATA INTO VIEW_CONSUMER_LIST DATAGRIDVIEWER IN ORDER FOR THE NEW ENTRY TO APPEAR
        Dim ADAPTER As New OdbcDataAdapter
        Dim DATA_TABLE As New DataTable
        connection = New OdbcConnection("dsn=EBS_ODBC;user=root;pwd=root")
        ADAPTER = New OdbcDataAdapter("select * from CONSUMER_DB", connection)
        ADAPTER.Fill(DATA_TABLE)
        VIEW_CONSUMER_LIST.DataSource = DATA_TABLE

        'CLEAR ALL TEXTBOXES AND BRING FOCUS TO CONSUMER_ID TEXTBOX
        CONSUMER_NAME.Clear()
        CONSUMER_PHONE.Clear()
        CONSUMER_EMAIL.Clear()
        CONSUMER_STATE.Clear()
        CONSUMER_CITY.Clear()
        CONSUMER_PIN_CODE.Clear()
        METER_ID.Clear()

        CONSUMER_NAME.Focus()

        connection.Close()
    End Sub

    'FILL DATAGRIDVIEWER WITH EXISTING CUSTOMER INFORMATION AUTOMATICALLY WHEN FORM LOADS
    Private Sub NEW_CONSUMER_DATA_INPUT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim connection As New OdbcConnection
        Dim command As New OdbcCommand

        connection = New OdbcConnection("dsn=EBS_ODBC;user=root;pwd=root")
        connection.Open()

        'LOAD DATA INTO VIEW_CONSUMER_LIST DATAGRIDVIEWER
        Dim ADAPTER As New OdbcDataAdapter
        Dim DATA_TABLE As New DataTable
        connection = New OdbcConnection("dsn=EBS_ODBC;user=root;pwd=root")
        ADAPTER = New OdbcDataAdapter("select * from CONSUMER_DB", connection)
        ADAPTER.Fill(DATA_TABLE)
        VIEW_CONSUMER_LIST.DataSource = DATA_TABLE


        connection.Close()
    End Sub

    'CONSUMER_PHONE TEXTBOX WILL ONLY ACCEPT INTEGER VALUES
    Private Sub CONSUMER_PHONE_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CONSUMER_PHONE.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    'CONSUMER_PIN_CODE TEXTBOX WILL ONLY ACCEPT INTEGER VALUES
    Private Sub CONSUMER_PIN_CODE_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CONSUMER_PIN_CODE.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class