Imports System.IO
Imports System.Data.SqlClient
Public Class Adminmenu
    Dim ar As String
    Dim con As SqlConnection
    Private Sub Adminmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub SetNombreUsuario2(usuario As String)
        Label1.Text = "Bienvenido Administrador: " & usuario
    End Sub

    Function leerarchivo(ByVal archivo As String) As String
        If File.Exists("c:\ABM\ip.txt") = True Then
            Dim SR As StreamReader = File.OpenText("c:\ABM\ip.txt")
            Dim Line As String = SR.ReadLine()
            SR.Close()
            Return Line
        Else
            MsgBox("Verifique Falta Archivo de Configuracion")
            Me.Close()
            Return String.Empty
        End If
    End Function

    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click

        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cli As New Clientes
        cli.ShowDialog()
    End Sub

    Private Sub bProveedores_Click(sender As Object, e As EventArgs) Handles bProveedores.Click
        Dim prov As New Proveedores
        prov.ShowDialog()
    End Sub

    Private Sub bClientes_Click(sender As Object, e As EventArgs) Handles bClientes.Click
        Dim pro As New adminmer
        pro.ShowDialog()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class