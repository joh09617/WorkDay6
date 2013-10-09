Option Strict On

Public Class Form1

    Private Sub btnPopulation_Click(sender As System.Object, e As System.EventArgs) Handles btnPopulation.Click

        Dim currentYear As Integer
        Dim currentPopulation As Double

        currentYear = 2012
        currentPopulation = 7000

        Do While (currentPopulation > 6)
            currentYear = currentYear - 50
            currentPopulation = currentPopulation / 2
        Loop

        MessageBox.Show("The year is " & currentYear, "Error")

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
