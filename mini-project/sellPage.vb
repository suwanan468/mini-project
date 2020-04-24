Imports System.Data.SqlClient

Public Class sellPage
    Dim conn As SqlConnection = New SqlConnection("Data Source=192.168.1.37, 1433;Initial Catalog=mini-projectDB;Persist Security Info=True;User ID=admin;Password=miniproject")

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()
        menuPage.Show()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearSell()
    End Sub

    Public Sub ClearSell()
        inputOrderMenu.ResetText()
        inputAmount.Value = 0
    End Sub

    Private Sub sellPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getOrderMenu()
        getDataSellD()
        getDataSellM()
        getDataSellY()
    End Sub

    Public Sub getOrderMenu()
        Dim command As New SqlCommand("select product_id, product_name from product", conn)

        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()

        adapter.Fill(table)

        inputOrderMenu.DataSource = table

        inputOrderMenu.DisplayMember = "product_name"
        inputOrderMenu.ValueMember = "product_id"
    End Sub

    Public Sub getDataSellD()
        Dim thisDay As Integer = Date.Now.Day

        Dim cmd As New SqlCommand("select sell.sell_date_time As SellToday, product.product_name as Product, sell.Amount as amount
                                        from sell inner join product on sell.product_id = product.product_id where day(sell_date_time) = @day", conn)

        cmd.Parameters.AddWithValue("@day", thisDay)
        Dim da As New SqlDataAdapter(cmd)

        Dim dt As New DataTable()

        da.Fill(dt)

        dataSellD.DataSource = dt
    End Sub

    Public Sub getDataSellM()
        Dim thisMonth As Integer = Date.Now.Month

        Dim cmd As New SqlCommand("select sell.sell_date_time As SellMonth, product.product_name as Product, sell.amount as Amount
                                        from sell inner join product on sell.product_id = product.product_id where month(sell_date_time) = @month", conn)

        cmd.Parameters.AddWithValue("@month", thisMonth)

        Dim da As New SqlDataAdapter(cmd)

        Dim dt As New DataTable()

        da.Fill(dt)

        dataSellM.DataSource = dt
    End Sub

    Public Sub getDataSellY()
        Dim thisYear As Integer = Date.Now.Year
        Dim cmd As New SqlCommand("select sell.sell_date_time As SellYear, product.product_name as Product, sell.Amount as amount
                                        from sell inner join product on sell.product_id = product.product_id where year(sell_date_time) = @y", conn)

        cmd.Parameters.AddWithValue("@y", thisYear)
        Dim da As New SqlDataAdapter(cmd)

        Dim dt As New DataTable()

        da.Fill(dt)

        dataSellY.DataSource = dt
    End Sub

    Private Sub btnSell_Click(sender As Object, e As EventArgs) Handles btnSell.Click
        Dim today As Date = Date.Now()

        Dim cmd As New SqlCommand("INSERT INTO sell (sell_date_time, product_id, amount) 
                                          VALUES (@sell, @PId, @a)", conn)


        cmd.Parameters.AddWithValue("@sell", today)
        cmd.Parameters.AddWithValue("@PId", inputOrderMenu.SelectedValue)
        cmd.Parameters.AddWithValue("@a", inputAmount.Value)

        conn.Open()
        If cmd.ExecuteNonQuery() Then
            ClearSell()
            getDataSellD()
            getDataSellM()
            getDataSellY()
            MessageBox.Show("Complete")
        End If
        conn.Close()
    End Sub
End Class