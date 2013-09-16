Option Strict On

Public Class Form1

    Private Sub btnFirstName_Click(sender As System.Object, e As System.EventArgs) Handles btnFirstName.Click
        Dim FullName As String
        ' read the input from the user
        FullName = txtFullName.Text
        ' store the input in top box as FullName

        Dim FullNameTrimmed As String
        FullNameTrimmed = FullName.Trim()


        'trim the input so as to remove leading spaces

        Dim idxspace As Integer
        idxspace = FullNameTrimmed.IndexOf(" ")
        ' find the first space

        Dim First_name As String
        First_name = FullNameTrimmed.Substring(0, idxspace)
        'extract first name

        txtFirstName.Text = First_name
        'Display result to user







    End Sub

    Private Sub txtFullName_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtFullName.TextChanged

    End Sub
End Class
