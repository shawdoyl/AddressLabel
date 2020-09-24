Public Class AddressLabelForm
    Private Sub AddressLabelForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayButton.Enabled = False
    End Sub
    Private Sub DisplayButton_Click(sender As Object, e As EventArgs)
        Dim displayText As String

        displayText = FirstNameTextBox.Text & " " & LastNameTextBox.Text &
            vbNewLine & StreetAddressTextBox.Text & vbNewLine & CityTextBox.Text _
            & ", " & StateTextBox.Text & " " & ZipTextBox.Text

        DisplayLabel.Text = displayText

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs)

        Me.Close()

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs)

        DisplayLabel.Text = ""

    End Sub
    Private Sub AnyTextChanged(sender As Object, e As EventArgs) Handles FirstNameTextBox.TextChanged, LastNameTextBox.TextChanged, StreetAddressTextBox.TextChanged, CityTextBox.TextChanged, StateTextBox.TextChanged, ZipTextBox.TextChanged
        EvaluateTextBoxes()
    End Sub

    Sub EvaluateTextBoxes()

        If FirstNameTextBox.Text <> "" And LastNameTextBox.Text <> "" And StreetAddressTextBox.Text <> "" And CityTextBox.Text <> "" And StateTextBox.Text <> "" And ZipTextBox.Text <> "" Then
            DisplayButton.Enabled = True
        Else

        End If

    End Sub


End Class
