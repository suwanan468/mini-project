Public Class menuPage
    Private Sub btnExit2_Click(sender As Object, e As EventArgs) Handles btnExit2.Click
        Application.Exit()
    End Sub

    Private Sub btnEmp_Click(sender As Object, e As EventArgs) Handles btnEmp.Click
        empPage.Show()
        Me.Hide()
    End Sub
End Class