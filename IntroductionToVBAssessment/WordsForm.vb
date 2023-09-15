Public Class WordsForm
    Private Sub WordsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim word As String = txtWordBox.Text

        If Not String.IsNullOrEmpty(word) And Not lbWords.Items.Contains(word) Then
            lbWords.Items.Add(word)
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtWordBox.Clear()
    End Sub

    Private Sub lbWords_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbWords.SelectedIndexChanged
        lblText.Text = lbWords.SelectedItem.ToString()
        lblText.BackColor = Color.White
    End Sub

    Private Sub rbToUpper_CheckedChanged(sender As Object, e As EventArgs) Handles rbToUpper.CheckedChanged
        lblText.Text = lblText.Text.ToUpper()
    End Sub

    Private Sub rbToLower_CheckedChanged(sender As Object, e As EventArgs) Handles rbToLower.CheckedChanged
        lblText.Text = lblText.Text.ToLower()
    End Sub

    Private Sub rbPurple_CheckedChanged(sender As Object, e As EventArgs) Handles rbPurple.CheckedChanged
        lblText.ForeColor = Color.Purple
    End Sub

    Private Sub rbBlue_CheckedChanged(sender As Object, e As EventArgs) Handles rbBlue.CheckedChanged
        lblText.ForeColor = Color.Blue
    End Sub
End Class