'Doyle Shaw
'RCET0265
'Fall 2020
'Address label program
'https://github.com/shawdoyl/AddressLabel.git

Public Class AddressLabelForm

    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click
        Dim displayText As String

        displayText = FirstNameTextBox.Text & " " & LastNameTextBox.Text &
            vbNewLine & StreetAddressTextBox.Text & vbNewLine & CityTextBox.Text _
            & ", " & StateTextBox.Text & " " & ZipTextBox.Text
        DisplayLabel.Text = displayText
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        DisplayLabel.Text = ""
    End Sub

    Private Sub AddressLabelForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResetForm()
    End Sub

    Sub ResetForm()
        'clear all textboxes
        FirstNameTextBox.Text = ""
        LastNameTextBox.Text = ""
        StreetAddressTextBox.Text = ""
        CityTextBox.Text = ""
        StateTextBox.Text = ""
        ZipTextBox.Text = ""

        'Enable by default
        ExitButton.Enabled = True
        DisplayButton.Enabled = False
        ClearButton.Enabled = True
    End Sub

    Private Sub AnyTextChanged(sender As Object, e As EventArgs) Handles FirstNameTextBox.TextChanged, LastNameTextBox.TextChanged, StreetAddressTextBox.TextChanged, CityTextBox.TextChanged, StateTextBox.TextChanged, ZipTextBox.TextChanged
        EvaluateTextBoxes()
    End Sub

    Sub EvaluateTextBoxes()

        If FirstNameTextBox.Text <> "" And LastNameTextBox.Text <> "" And StreetAddressTextBox.Text <> "" And CityTextBox.Text <> "" And StateTextBox.Text <> "" And ZipTextBox.Text <> "" Then
            DisplayButton.Enabled = True
        Else
            DisplayButton.Enabled = False
        End If

    End Sub

    'Sub to check if Zip code is actually a six digit integer. 
    Private Sub ZipTextBox_Validate(sender As Object, e As EventArgs) Handles ZipTextBox.Leave
        Dim tempNumber As Integer

        If ZipTextBox.Text <> "" Then
            If Len(ZipTextBox.Text) <> 5 Then
                MsgBox("Please enter a valid Zip code.")
                ZipTextBox.Text = ""
            Else
                Try
                    tempNumber = CInt(ZipTextBox.Text)

                Catch ex As Exception
                    MsgBox("Please enter a valid Zip code.")
                    ZipTextBox.Text = ""
                End Try
            End If

        ElseIf ZipTextBox.Text = "" Then

        End If
    End Sub

End Class
