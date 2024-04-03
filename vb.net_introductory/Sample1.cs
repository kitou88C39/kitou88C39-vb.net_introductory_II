public class Sample1

    private Sub BtnDecision_Click(sender As Object, e As EventArgs) Handles btnDecision.Click

    Dim lsComment As String

    lsComment = "テスト"

        txtComment.Text = lsComment

    End Sub

    Private Sub NameChange()

        txtComment.Text = lsComment
    End Sub

End Class