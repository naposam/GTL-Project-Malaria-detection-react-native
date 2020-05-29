Imports System.Data.SqlClient
Public Class RegTRY
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Private Sub StudentBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles StudentBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StudentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SCHOOLDataSet3)

    End Sub

    Private Sub RegTRY_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SCHOOLDataSet3.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.SCHOOLDataSet3.Student)

    End Sub
    Public Sub FilterData(valueToSearch As String)
        con = New SqlConnection(My.Settings.SCHOOLConnectionString.ToString())


        Dim SearchQuary As String = "SELECT * FROM Student WHERE CONCAT(StudentID,FirstName,MiddleName,LastName,Address,DOB,Gender,Year) like '%" & valueToSearch & "%'"


        Dim cmd As New SqlCommand(SearchQuary, con)
        Dim Adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        Adapter.Fill(table)
        StudentDataGridView.DataSource = table

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            con = New SqlConnection(My.Settings.SCHOOLConnectionString.ToString())

            cmd = New SqlCommand("DELETE  From Staff Where StuffID =@id", con)
            If con.State = ConnectionState.Closed Then
                con.Open()


            End If
            cmd.Parameters.AddWithValue("@id", TextBox1.Text)

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

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        FilterData(TextBox1.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class