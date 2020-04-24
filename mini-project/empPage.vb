Imports System.Data.SqlClient
Public Class empPage
    Dim conn As SqlConnection = New SqlConnection("Data Source=192.168.1.37, 1433;Initial Catalog=mini-projectDB;Persist Security Info=True;User ID=admin;Password=miniproject")
    Private Sub empPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getPosition()
        getDataEmp()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ClearInput()
        Me.Hide()
        menuPage.Show()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearInput()
    End Sub

    Public Sub ClearInput()
        inputUser.Clear()
        inputPass.Clear()
        inputFname.Clear()
        inputLname.Clear()
        inputAddress.Clear()
        inputGender.ResetText()
        inputTel.Clear()
        inputPosition.ResetText()
        inputSalary.Value = 0
    End Sub

    Public Sub getPosition()
        Dim command As New SqlCommand("select * from position", conn)

        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()

        adapter.Fill(table)

        inputPosition.DataSource = table

        inputPosition.DisplayMember = "position"
        inputPosition.ValueMember = "position_id"
    End Sub

    Public Sub getDataEmp()
        Dim cmd As New SqlCommand("select employee.emp_id, employee.username, employee.pass, employee.empName, employee.empLastname, employee.empAddress, employee.gender, employee.tel, 
                                    employee.salary, position.position  
                                    from employee inner join position on employee.position_id = position.position_id", conn)

        Dim da As New SqlDataAdapter(cmd)

        Dim dt As New DataTable()

        da.Fill(dt)

        dataEmp.DataSource = dt
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim cmd As New SqlCommand("INSERT INTO employee (username, pass, empName, empLastname, empAddress, gender, tel, salary, position_id) 
                                          VALUES (@username, @pass, @empName, @empLastname, @empAddress, @gender, @tel, @salary, @position_id)", conn)


        cmd.Parameters.AddWithValue("@username", inputUser.Text)
        cmd.Parameters.AddWithValue("@pass", inputPass.Text)
        cmd.Parameters.AddWithValue("@empName", inputFname.Text)
        cmd.Parameters.AddWithValue("@empLastname", inputLname.Text)
        cmd.Parameters.AddWithValue("@empAddress", inputAddress.Text)
        cmd.Parameters.AddWithValue("@gender", inputGender.SelectedItem)
        cmd.Parameters.AddWithValue("@tel", inputTel.Text)
        cmd.Parameters.AddWithValue("@salary", inputSalary.Value)
        cmd.Parameters.AddWithValue("@position_id", inputPosition.SelectedValue)

        conn.Open()
        If cmd.ExecuteNonQuery() Then
            ClearInput()
            getDataEmp()
            MessageBox.Show("Add data complete")
        End If
        conn.Close()


    End Sub

    Private Sub dataEmp_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dataEmp.CellMouseClick
        Dim i As Integer

        i = dataEmp.CurrentRow.Index

        inputUser.Text = dataEmp.Item(1, i).Value
        inputPass.Text = dataEmp.Item(2, i).Value
        inputFname.Text = dataEmp.Item(3, i).Value
        inputLname.Text = dataEmp.Item(4, i).Value
        inputAddress.Text = dataEmp.Item(5, i).Value
        inputGender.Text = dataEmp.Item(6, i).Value
        inputTel.Text = dataEmp.Item(7, i).Value
        inputPosition.Text = dataEmp.Item(9, i).Value
        inputSalary.Text = dataEmp.Item(8, i).Value

    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Dim i As Integer

        i = dataEmp.CurrentCell.RowIndex

        Dim id As Integer = dataEmp.Item(0, i).Value

        Dim cmd As New SqlCommand("DELETE FROM employee WHERE emp_id=@id", conn)

        cmd.Parameters.AddWithValue("@id", id)

        conn.Open()
        If cmd.ExecuteNonQuery() Then
            ClearInput()
            getDataEmp()
            MessageBox.Show("Delete data complete")
        End If
        conn.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim i As Integer

        i = dataEmp.CurrentCell.RowIndex

        Dim id As Integer = dataEmp.Item(0, i).Value

        Dim cmd As New SqlCommand("UPDATE employee SET username=@user, pass=@pass, empName=@Fname, empLastname=@Lname, empAddress=@address, gender=@gender, tel=@tel, salary=@salary, position_id=@position_id  WHERE emp_id=@id", conn)

        cmd.Parameters.AddWithValue("@id", id)
        cmd.Parameters.AddWithValue("@user", inputUser.Text)
        cmd.Parameters.AddWithValue("@pass", inputPass.Text)
        cmd.Parameters.AddWithValue("@Fname", inputFname.Text)
        cmd.Parameters.AddWithValue("@Lname", inputLname.Text)
        cmd.Parameters.AddWithValue("@address", inputAddress.Text)
        cmd.Parameters.AddWithValue("@gender", inputGender.SelectedItem)
        cmd.Parameters.AddWithValue("@tel", inputTel.Text)
        cmd.Parameters.AddWithValue("@salary", inputSalary.Value)
        cmd.Parameters.AddWithValue("@position_id", inputPosition.SelectedValue)

        conn.Open()
        If cmd.ExecuteNonQuery() Then
            ClearInput()
            getDataEmp()
            MessageBox.Show("Edit data complete")
        End If
        conn.Close()
    End Sub
End Class