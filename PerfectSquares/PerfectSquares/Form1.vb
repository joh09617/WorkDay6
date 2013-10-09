Public Class Form1

    Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click

        lstResult.Items.Clear()

        Dim i As Integer
        i = 1
        Do While (i <= 10)
            lstResult.Items.Add("the perfect square: " & i ^ 2)
            i += 1
        Loop

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
