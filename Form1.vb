'Andrew Ritchie
'21800567
'8/08/18
'Version 1

Public Class Form1


    Private Sub btnSpin_Click(sender As Object, e As EventArgs) Handles btnSpin.Click

        'declare the variables to run lblBox1 lblBox2 lblBox3
        Dim intRandom1 As Integer
        Dim intRandom2 As Integer
        Dim intRandom3 As Integer

        'initiate the declared random variables in lblBox1 lblBox2 lblBox3
        picBox1.Visible = False

        intRandom1 = 1 + CInt(9 * Rnd())
        intRandom2 = 1 + CInt(9 * Rnd())
        intRandom3 = 1 + CInt(9 * Rnd())

        'join intRandom variables with lblBox1 lblBox2 lblBox3
        lblBox1.Text = intRandom1.ToString
        lblBox2.Text = intRandom2.ToString
        lblBox3.Text = intRandom3.ToString

        'Print the results
        If intRandom1 = 7 Or intRandom2 = 7 Or intRandom3 = 7 Then
            picBox1.Visible = True
        End If


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'close the program
        Me.Close()

    End Sub

    Private Sub btnSuperSpin_Click(sender As Object, e As EventArgs) Handles btnSuperSpin.Click

        'declare the variables to run lblBox1 lblBox2 lblBox3
        Dim intRandom1 As Integer
        Dim intRandom2 As Integer
        Dim intRandom3 As Integer

        'initiate the declared random variables in lblBox1 lblBox2 lblBox3
        picBox1.Visible = False

        intRandom1 = 1 + CInt(9 * Rnd())
        intRandom2 = 1 + CInt(9 * Rnd())
        intRandom3 = 1 + CInt(9 * Rnd())

        'join intRandom variables with lblBox1 lblBox2 lblBox3
        lblBox1.Text = intRandom1.ToString
        lblBox2.Text = intRandom2.ToString
        lblBox3.Text = intRandom3.ToString

        'Print the results
        If intRandom1 = 7 Or intRandom2 = 7 And intRandom3 = 7 Then
            picBox1.Visible = True
        End If

    End Sub

End Class

