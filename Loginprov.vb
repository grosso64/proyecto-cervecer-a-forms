Imports System.IO
Imports System.Data.SqlClient
Public Class Loginprov

    Dim ar As String
    Dim con As New SqlConnection("data source=" & CStr(leerarchivo(ar)) & "; initial catalog=abm; integrated security=true")

    Public UsuarioLog1 As String

    Function leerarchivo(ByVal archivo As String) As String
        If File.Exists("c:\ABM\ip.txt") = True Then
            Dim SR As StreamReader = File.OpenText("c:\ABM\ip.txt")
            Dim Line As String = SR.ReadLine()
            SR.Close()
            Return Line
        Else
            MsgBox("Verifique Falta Archivo de Configuracion")
            Me.Close()
        End If
    End Function
    Private Sub tUsuario_TextChanged(sender As Object, e As EventArgs) Handles tUsuario.TextChanged

    End Sub

    Private Sub bIngresar_Click(sender As Object, e As EventArgs) Handles bIngresar.Click
        tUsuario.Text = tUsuario.Text.Replace("'", "").Replace(" ", "").Replace("""", "")
        tContrasenia.Text = tContrasenia.Text.Replace("'", "").Replace(" ", "").Replace("""", "") '
        Dim consulta As String = "SELECT * FROM proveedores WHERE usuario1 = '" & tUsuario.Text & "' AND contrasenia1 = '" & tContrasenia.Text & "'"
        Dim da As New SqlDataAdapter(consulta, con)
        Dim ds As New DataSet
        da.Fill(ds, "proveedores")
        If ds.Tables("proveedores").Rows.Count = 1 Then
            Dim provmenu1 As New provmenu1

            Dim apellido As String = ds.Tables("proveedores").Rows(0)("apellidoprov").ToString()
            Dim nombre As String = ds.Tables("proveedores").Rows(0)("nombreprov").ToString()
            provmenu1.SetNombreproveedor(apellido & " " & nombre)
            provmenu1.ShowDialog()
            Close()
        Else
            MsgBox("usuario o contraseña incorrectos", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class