Public Class frmBurgers
    Private Sub btnPrime_Click(sender As Object, e As EventArgs) Handles btnPrime.Click
        picPrime.Visible = True
    End Sub

    Private Sub btnVeggie_Click(sender As Object, e As EventArgs) Handles btnVeggie.Click
        picVeggie.Visible = True
    End Sub

    Private Sub btnSelectMeal_Click(sender As Object, e As EventArgs) Handles btnSelectMeal.Click
        btnSelectMeal.Enabled = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

    End Sub
End Class


