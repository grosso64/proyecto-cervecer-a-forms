﻿Public Class ProvInicio
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim provlog As New Loginprov
        provlog.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim provreg As New provreg
        provreg.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub

    Private Sub ProvInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class