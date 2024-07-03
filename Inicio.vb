Public Class Inicio
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim menu As New Menu
        menu.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class