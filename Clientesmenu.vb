Imports System.IO
Imports System.Data.SqlClient

Public Class Clientesmenu
    Dim ar As String
    Dim con As SqlConnection




    Public Sub SetNombreCliente(usuario As String)
        Label2.Text = "Bienvenido: " & usuario

    End Sub

    Private Sub Clientesmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New SqlConnection("data source=" & CStr(leerarchivo(ar)) & "; initial catalog=abm; integrated security=true")
        CargarDatos()

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

    Private Sub CargarDatos()
        Dim ds As String = "SELECT mercaderia, tipo, cantidad, precio FROM mercaderiaprov"
        Dim dsa As New DataTable()

        Try
            con.Open()

            Using adapter As New SqlDataAdapter(ds, con)
                adapter.Fill(dsa)
            End Using

            DataGridView1.DataSource = dsa
        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class

