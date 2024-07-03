Public Class Menu
    Private Sub bClientes_Click(sender As Object, e As EventArgs) Handles bClientes.Click
        Dim clieinicio As New Clieinicio
        clieinicio.ShowDialog()
    End Sub

    Private Sub bProveedores_Click(sender As Object, e As EventArgs) Handles bProveedores.Click
        Dim provmenu As New ProvInicio
        provmenu.ShowDialog()
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        Me.Close()



    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim admincio As New Adminicio
        admincio.ShowDialog()
    End Sub
End Class