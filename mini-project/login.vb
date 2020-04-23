Imports System.Data.SqlClient
Public Class Login
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim conn As SqlConnection = New SqlConnection("Data Source=NNOTTP\SQLEXPRESS;Initial Catalog=mini-projectDB;Integrated Security=True")
        Dim cmd As New SqlCommand("select * from employee where username='" + txtUser.Text + "' and pass='" + txtPass.Text + "'", conn)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)

        If (dt.Rows.Count > 0) Then
            MessageBox.Show("Login successfully")
            Me.Hide()
            menuPage.Show()
        Else
            MessageBox.Show("Login Failed")
        End If

    End Sub
End Class
