'Payden Hoskins
'RCET2265
'Spring 2026
'Address label program
'https://github.com/PaydenHoskins/AddressLabel.git

Option Compare Text
Option Explicit On
Option Strict On

Public Class AddressLabelForm

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'Closes and ends program
        Me.Close()
        End
    End Sub
    Sub Reset()
        'Sets all my textboxes to empty
        FirstNameTextBox.Text = ""
        LastNameTextBox.Text = ""
        StreetAddressTextBox.Text = ""
        CityTextBox.Text = ""
        StateTextBox.Text = ""
        ZipTextBox.Text = ""
    End Sub
    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click
        'Only writes to the label if everything is filled out 
        If UserIputIsValid() = True Then
            DisplayLabel.Text = FormatDisplayLabel()
        End If
    End Sub
    Function FormatDisplayLabel() As String
        'formats the label
        Dim display As String
        display = FirstNameTextBox.Text & " " & LastNameTextBox.Text & vbNewLine _
            & StreetAddressTextBox.Text & vbNewLine _
            & CityTextBox.Text & "," & " " & StateTextBox.Text & " " & ZipTextBox.Text
        Return display
    End Function

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        'Clears the label and text boxes
        Reset()
        DisplayLabel.Text = ""
    End Sub
    Function UserIputIsValid() As Boolean
        'Makes sure all text boxes have inputs
        Dim Valid As Boolean = True
        Dim message As String
        If IsNumeric(ZipTextBox.Text) = False Then
            Valid = False
            ZipTextBox.Focus()
            message &= "Please enter a valid Zip Code." & vbNewLine
        End If
        If StateTextBox.Text = "" Then
            Valid = False
            StateTextBox.Focus()
            message &= "Please enter a valid State." & vbNewLine
        End If

        If CityTextBox.Text = "" Then
            Valid = False
            CityTextBox.Focus()
            message &= "Please enter a valid City." & vbNewLine
        End If
        If StreetAddressTextBox.Text = "" Then
            Valid = False
            StreetAddressTextBox.Focus()
            message &= "Please enter a valid address." & vbNewLine
        End If
        If LastNameTextBox.Text = "" Then
            Valid = False
            LastNameTextBox.Focus()
            message &= "Please enter a valid last name." & vbNewLine
        End If
        If FirstNameTextBox.Text = "" Then
            Valid = False
            FirstNameTextBox.Focus()
            message &= "Please enter a valid first name." & vbNewLine
        End If
        If Not Valid Then
            MsgBox(message, MsgBoxStyle.Exclamation, "User Input Fail!")
        End If
        Return Valid
    End Function

    Private Sub AddressLabelForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'loads all the textboxes as empty
        Reset()
    End Sub
End Class
