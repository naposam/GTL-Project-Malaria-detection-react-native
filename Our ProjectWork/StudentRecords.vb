Imports System.Data.SqlClient
Public Class StudentRecords
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            con = New SqlConnection(My.Settings.SCHOOLConnectionString.ToString())

            cmd = New SqlCommand("DELETE  From Student Where StudentID=@id", con)
            If con.State = ConnectionState.Closed Then
                con.Open()


            End If
            cmd.Parameters.AddWithValue("@id", txtSearch.Text)

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
    End Sub

    Private Sub StudentRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SCHOOLDataSet3.Student' table. You can move, or remove it, as needed.


        FilterData("")

    End Sub
    Public Sub FilterData(valueToSearch As String)
        con = New SqlConnection(My.Settings.SCHOOLConnectionString.ToString())


        Dim SearchQuary As String = "SELECT * FROM Student WHERE CONCAT(StudentID,FirstName,MiddleName,LastName,Address,DOB,Gender,Year) like '%" & valueToSearch & "%'"


        Dim cmd As New SqlCommand(SearchQuary, con)
        Dim Adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        Adapter.Fill(table)
        DataGridView1.DataSource = table
        DataGridView1.Refresh()
    End Sub

   

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        FilterData(txtSearch.Text)
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        FilterData(txtSearch.Text)
    End Sub

    Private Sub StudentBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        'Me.Validate()
        'Me.StudentBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.SCHOOLDataSet3)

    End Sub

   
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class