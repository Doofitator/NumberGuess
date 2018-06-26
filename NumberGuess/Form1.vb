Public Class frm_numberGuess

    'Make variables
    Public Shared int_currentNumber As Integer = 0
    Public Shared int_highestNumber As Integer = 100
    Public Shared int_lowestNumber As Integer = 0

    Private Sub generateNumber()
        'generate subroutine
        If int_highestNumber - int_lowestNumber <= 1 Then 'If the numbers are directly apart (e.g. 50 and 51)
            MessageBox.Show("You cheated!", "Cheat!", MessageBoxButtons.OK, MessageBoxIcon.Error) 'Alert: You cheated!
        Else
            int_currentNumber = Math.Round((int_lowestNumber + int_highestNumber) / 2) 'Get the halfway point (rounded up)
            lbl_display.Text = int_currentNumber 'Display it to the user
        End If
    End Sub

    Private Sub btn_main_Click(sender As Object, e As EventArgs) Handles btn_main.Click
        'main button clicked
        If btn_main.Text = "Start" Then
            generateNumber()
            btn_main.Text = "Correct"
            btn_higher.Enabled = True 'Enable higher and
            btn_lower.Enabled = True  'lower buttons.
        Else
            MessageBox.Show("Your number was " + int_currentNumber.ToString, "Wahoo!", MessageBoxButtons.OK, MessageBoxIcon.Information) 'Alert "Your number was x"
            btn_main.Text = "Start"     'Reset
            lbl_display.Text = 0        'form
            int_highestNumber = 100     'back
            int_lowestNumber = 0        'to
            int_currentNumber = 0       'how
            btn_higher.Enabled = False  'it
            btn_lower.Enabled = False   'began
        End If
    End Sub

    Private Sub btn_higher_Click(sender As Object, e As EventArgs) Handles btn_higher.Click
        'higher button clicked
        int_lowestNumber = int_currentNumber 'set lowestNumber's value to that of currentNumber
        generateNumber() 'call function
    End Sub

    Private Sub btn_lower_Click(sender As Object, e As EventArgs) Handles btn_lower.Click
        'lower button clicked
        int_highestNumber = int_currentNumber 'set highestNumber's value to that of currentNumber
        generateNumber() 'call function
    End Sub
End Class
