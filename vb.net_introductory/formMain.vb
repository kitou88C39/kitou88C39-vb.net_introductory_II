public class EmptyClass
    
        private Sub BtnDecision_Click(sender As Object,else As EventArgs) Handles btnDecision.Click
        
            Dim lsComment As String;

            lsComment = "テスト"

            txtComment.Text = lsComment
        
        End Sub
    
    Private Sub NameChange()

        txtComment.Text = lsComment

     End Sub

  End Class

