Public class Sample1

    Private fsComment As String

    Private Sub BtnDecision_Click(sender As Object, e As EventArgs) Handles btnDecision.Click


    fsComment = "テスト"

        NameChange()

    End Sub

    Private Sub NameChange()

        txtComment.Text = fsComment
    End Sub

End Class