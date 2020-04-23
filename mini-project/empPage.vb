Imports System.Data.SqlClient
Public Class empPage
    Dim conn As SqlConnection = New SqlConnection("Data Source=NNOTTP\SQLEXPRESS;Initial Catalog=mini-projectDB;Integrated Security=True")
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()
        menuPage.Show()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

    End Sub

    Private Sub empPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim command As New SqlCommand("select * from position", conn)

        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()

        adapter.Fill(table)

        inputPosition.DataSource = table

        inputPosition.DisplayMember = "position"
        inputPosition.ValueMember = "position_id"
    End Sub
End Class