Imports System.Data.Common.CommandTrees.ExpressionBuilder
Imports System.Data.SqlClient
Public Class Login
    Dim conn As SqlConnection = New SqlConnection("Data Source=192.168.1.37, 1433;Initial Catalog=mini-projectDB;Persist Security Info=True;User ID=admin;Password=miniproject")
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim cmd As New SqlCommand("select * from employee where username='" + txtUser.Text + "' and pass='" + txtPass.Text + "'", conn)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)



        If (dt.Rows.Count > 0) Then
            Dim today As DateTime = DateTime.Now()
            Dim row As DataRow = dt.Rows(0)
            Dim dataID As Integer = row("emp_id")


            Dim cmd2 As New SqlCommand("INSERT INTO attendance (atd_date_time, emp_id) VALUES (@today, @dataID)", conn)

            cmd2.Parameters.AddWithValue("@today", Today)
            cmd2.Parameters.AddWithValue("@dataID", dataID)

            conn.Open()

            cmd2.ExecuteNonQuery()

            conn.Close()

            MessageBox.Show("Login successfully")
            Me.Hide()
            menuPage.Show()

        Else
            MessageBox.Show("Login Failed")
        End If

    End Sub

End Class
