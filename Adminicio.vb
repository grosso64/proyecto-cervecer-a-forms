Imports System.IO
Imports System.Data.SqlClient

Public Class Adminicio
    Dim ar As String
    Dim con As New SqlConnection("data source=" & CStr(leerarchivo(ar)) & "; initial catalog=abm; integrated security=true")

    Function leerarchivo(ByVal archivo As String) As String
        If File.Exists("c:\ABM\ip.txt") = True Then
            Dim SR As StreamReader = File.OpenText("c:\ABM\ip.txt")
            Dim Line As String = SR.ReadLine()
            SR.Close()
            Return Line
        Else
            MsgBox("Verifique Falta Archivo de Configuracion")
            Me.Close()
            Return String.Empty ' Devuelve un valor vacío si el archivo no existe
        End If
    End Function

    Private Sub tUsuario_TextChanged(sender As Object, e As EventArgs) Handles tUsuario.TextChanged

    End Sub

    Private Sub bIngresar_Click(sender As Object, e As EventArgs) Handles bIngresar.Click
        tUsuario.Text = tUsuario.Text.Replace("'", "").Replace(" ", "").Replace("""", "")
        tContrasenia.Text = tContrasenia.Text.Replace("'", "").Replace(" ", "").Replace("""", "")
        Dim consulta As String = "SELECT * FROM Administrador WHERE usuario2 = '" & tUsuario.Text & "' AND contrasenia2 = '" & tContrasenia.Text & "'"
        Dim da As New SqlDataAdapter(consulta, con)
        Dim ds As New DataSet
        da.Fill(ds, "Administrador")
        If ds.Tables("Administrador").Rows.Count = 1 Then
            Dim adminmenu As New Adminmenu
            adminmenu.SetNombreUsuario2(tUsuario.Text)
            adminmenu.ShowDialog()
            Close()
        Else
            MsgBox("Usuario o contraseña incorrectos", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Adminicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
