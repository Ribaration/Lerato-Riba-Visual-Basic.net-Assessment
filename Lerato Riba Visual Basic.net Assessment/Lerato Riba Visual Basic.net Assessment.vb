Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private wordList As New List(Of String)



    Private Sub listBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listBox.SelectedIndexChanged
        If listBox.SelectedIndex <> -1 Then
            Dim selectedWord As String = listBox.SelectedItem.ToString()
            UpdateLabel(selectedWord)
        End If
    End Sub

    Private Sub UpdateLabel(text As String)
        If toUpperRadioButton.Checked Then
            text = text.ToUpper()
        ElseIf toLowerRadioButton.Checked Then
            text = text.ToLower()
        End If

        label.Text = text
        label.BackColor = Color.White

        If purpleRadioButton.Checked Then
            label.ForeColor = Color.Purple
        ElseIf blueRadioButton.Checked Then
            label.ForeColor = Color.Blue
        End If
    End Sub
    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        'Declare Variable
        Dim newWord As String = textBox.Text.Trim()

        If Not String.IsNullOrEmpty(newWord) AndAlso Not wordList.Contains(newWord) Then
            wordList.Add(newWord)
            listBox.Items.Add(newWord)
        Else
            MessageBox.Show("Please enter a unique word or phrase.", "Error")
        End If
    End Sub
    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub toUpperRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles toUpperRadioButton.CheckedChanged
        label.Text = label.Text.ToUpper()
    End Sub

    Private Sub toLowerRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles toLowerRadioButton.CheckedChanged
        label.Text = label.Text.ToLower()
    End Sub

    Private Sub purpleRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles purpleRadioButton.CheckedChanged
        label.ForeColor = Color.Purple
    End Sub

    Private Sub blueRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles blueRadioButton.CheckedChanged
        label.ForeColor = Color.Blue
    End Sub
End Class
