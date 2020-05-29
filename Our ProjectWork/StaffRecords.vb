Imports System.Data.SqlClient
Public Class StaffRecords
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Private Sub StaffRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SCHOOLDataSet1.Staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter.Fill(Me.SCHOOLDataSet1.Staff)

    End Sub

    Public Sub FilterData(valueToSearch As String)
        con = New SqlConnection(My.Settings.SCHOOLConnectionString.ToString())


        Dim SearchQuary As String = "SELECT * FROM Staff WHERE CONCAT(StuffID,FirstName,MiddleName,LastName,DOB,Gender,TelNumber,Status,Password,ComfirmPassword) like '%" & valueToSearch & "%'"


        Dim cmd As New SqlCommand(SearchQuary, con)
        Dim Adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        Adapter.Fill(table)
        StaffDataGridView.DataSource = table
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FilterData(txtUserID.Text)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtUserID.TextChanged
        FilterData(txtUserID.Text)

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            con = New SqlConnection(My.Settings.SCHOOLConnectionString.ToString())

            cmd = New SqlCommand("DELETE  From Staff Where StuffID =@id", con)
            If con.State = ConnectionState.Closed Then
                con.Open()


            End If
            cmd.Parameters.AddWithValue("@id", txtUserID.Text)

            cmd.ExecuteNonQuery()
            If MessageBox.Show("Do you really want to Delete this Record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
                MsgBox("Operation Cancel")
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show("Error while deleting reccord on table...." & ex.Message, "Delete Records")
        Finally
            con.Close()
        End Try

        Me.StaffTableAdapter.Fill(Me.SCHOOLDataSet1.Staff)
        StaffDataGridView.Refresh()



    End Sub

    Private Sub StaffBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles StaffBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StaffBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SCHOOLDataSet1)

    End Sub
End Class