'Niks Final Project
'By Nikolas Karinja
'12/12/22

Public Class frmFinalPrj

    'Sub Methods

    Private Sub DisplayMsg(strMessage As String, strTitle As String, Buttons As [Enum], Icon As [Enum])

        Dim shoA = 3
        Dim shoB = 2
        Dim shoC = 4
        Dim shoD = 0

        shoD = shoA ^ shoB + shoC

        'Display a message
        MessageBox.Show(strMessage, strTitle, Buttons, Icon)

    End Sub

    Private Function GetRandom(shoRange As Short) As Short

        'Declare variables
        Dim shoRandNo As Short

        'Generate a random number
        Randomize()
        shoRandNo = Rnd() * shoRange
        Return shoRandNo

    End Function

    'Events

    Private Sub btnSummation_Click(sender As Object, e As EventArgs) Handles btnSummation.Click

        'Declare variables
        Dim shoANumber, shoTotal, shoSummAmt As Short

        'Check to see if input is a number, if so continue, if not display an error
        If Short.TryParse(txtNumber.Text, shoSummAmt) Then
            'Use a Loop to Do a Summation
            Do While shoANumber < shoSummAmt
                shoANumber += 1
                shoTotal += shoANumber
            Loop

            'Display the results of the summation
            DisplayMsg("The summation of 1 through " & shoANumber & " is " & shoTotal, "Summation Results", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            'Display an error
            DisplayMsg("Please enter a valid number", "Summation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNumber.Focus()

        End If

    End Sub

    Private Sub btnAvg_Click(sender As Object, e As EventArgs) Handles btnAvg.Click

        Dim shoAverage As Short
        Dim shoTotal, shoNum, shoNumCnt As Short
        Dim strMessage As String = ""

        If Short.TryParse(txtAvg.Text, shoNumCnt) Then

            'Generate a range of random numbers less than 20 and calculate and display the average
            'Accumulate numbers into shoTotal

            For x = 1 To shoNumCnt

                'Generate a random number between 1 and 20
                shoNum = GetRandom(20)

                'Accumulate the random numbers
                shoTotal += shoNum

                'Build a string with the random numbers
                strMessage = strMessage & shoNum

                'To prevent the comma from displaying at the end of the random number list
                If x < shoNumCnt Then strMessage = strMessage & ", "

            Next

            'Calculate and Display average

            shoAverage = shoTotal / shoNumCnt
            DisplayMsg("The average of " & strMessage & " is " & shoAverage, "Average", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else

            'Invalid data entered

            DisplayMsg("Invalid number entered, please try again.", "Average Calculator", MessageBoxButtons.OK, MessageBoxIcon.Error)

            txtAvg.Focus()

        End If

    End Sub

    Private Sub btnAge_Click(sender As Object, e As EventArgs) Handles btnAge.Click

        Dim shoMyAge As Long
        Dim datToday As Date = Today
        Dim datMyBirthDate As Date

        'Check to see if input is a date, if so continue, if not display an error

        If Date.TryParse(txtBirthDate.Text, datMyBirthDate) Then
            'Calculate age using DateDiff function
            shoMyAge = DateDiff("yyyy", datMyBirthDate, datToday)
            DisplayMsg("You are " & shoMyAge & " years young this year.", "Age", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            'Error Message
            DisplayMsg("Please provide a valid date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtBirthDate.Show()
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'Clear the textboxes
        txtAvg.Clear()
        txtBirthDate.Clear()
        txtNumber.Clear()

        'Reset the focus
        txtNumber.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Close the form
        Me.Close()

    End Sub

    Private Sub frmFinalPrj_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        'Prompt the user, exit if yes
        If MessageBox.Show("Exit Program?", "Final Project", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbNo Then
            e.Cancel = True
        Else
            Me.Dispose()
        End If

    End Sub
End Class
