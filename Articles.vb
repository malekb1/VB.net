Module Articles
    Public Structure Article
        Dim code As Integer
        Dim qte As Integer
        Dim designation As String
        Dim prix As Double
    End Structure

    Public listArticles As New List(Of Article)

    Public Sub AjouterArticle(A As Article)
        Dim x As Integer = Existe(A)
        If x >= 0 Then
            Dim temp As Article = listArticles(x)
            temp.qte += A.qte
            temp.prix = A.prix
            listArticles(x) = temp
        Else
            listArticles.Add(A)
        End If
    End Sub
    Private Function Existe(A As Article) As Integer
        Dim p As Integer = -1
        For i As Integer = 0 To listArticles.Count - 1
            If listArticles(i).code = A.code Then
                p = i
                Exit For
            End If
        Next
        Return p
    End Function
End Module