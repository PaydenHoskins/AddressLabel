'Payden Hoskins
'RCET2265
'Spring 2026
'Address label program
'

Option Compare Text
Option Explicit On
Option Strict On

Public Class AddressLabelForm
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
        End
    End Sub
    Sub Reset()
        FirstNameTextBox.Text = ""
        LastNameTextBox.Text = ""
        StreetAddressTextBox.Text = ""
        CityTextBox.Text = ""
        StateTextBox.Text = ""
        ZipTextBox.Text = ""
    End Sub
    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click
        DisplayLabel.Text = FormatDisplayLabel()
    End Sub
    Function FormatDisplayLabel() As String
        Dim display As String
        display = FirstNameTextBox.Text & " " & LastNameTextBox.Text & vbNewLine _
            & StreetAddressTextBox.Text & vbNewLine _
            & CityTextBox.Text & "," & " " & StateTextBox.Text & " " & ZipTextBox.Text
        Return display
    End Function

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        Reset()
        DisplayLabel.Text = ""
    End Sub
End Class
