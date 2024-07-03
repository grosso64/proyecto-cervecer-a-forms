Public Class Clientelog
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim log As New Logincli
        log.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim clireg As New Clireg
        clireg.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub

    Private Sub Clientelog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class