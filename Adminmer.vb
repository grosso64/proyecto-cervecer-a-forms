Imports System.IO
Imports System.Data.SqlClient
Public Class adminmer
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
        End If
    End Function
    Sub buscar(ByVal condicion As String)
        Dim consulta As String = "SELECT TOP 100 PERCENT Nmer, mercaderia, tipo, cantidad, precio FROM Mercaderiaprov WHERE " & condicion
        Dim da1 As New SqlDataAdapter(consulta, con)
        Dim dsa As New DataSet
        da1.Fill(dsa, "Mercaderiaprov")
        If dsa.Tables("Mercaderiaprov").Rows.Count = 0 Then
            DataGridView1.Visible = False
            lID2.Visible = False
        Else
            DataGridView1.DataSource = dsa.Tables("Mercaderiaprov")
            DataGridView1.Refresh()
            DataGridView1.Visible = True
            lID2.Visible = True
        End If
    End Sub


    Sub CargarCamposMercaderia()
        If Val(lID2.Text) = 0 Then
            pBotones.Visible = False
            pCampos.Visible = False

            Exit Sub
        Else
            pBotones.Visible = True
            pCampos.Visible = True

            Dim da1 As New SqlDataAdapter("SELECT  
                ltrim(rtrim(isnull(Mercaderia,'****')))as mercaderia,
                ltrim(rtrim(isnull(tipo,'****')))as tipo,
                isnull(Cantidad,0)as Cantidad,
                isnull(Precio,0)as Precio
                from Mercaderiaprov where Nmer=" & Val(lID2.Text), con)

            Dim dsa As New DataSet
            da1.Fill(dsa, "Mercaderiaprov")
            If dsa.Tables("Mercaderiaprov").Rows.Count > 0 Then

                tMercaderia.Text = dsa.Tables("Mercaderiaprov").Rows(0)("mercaderia")
                tTipo.Text = dsa.Tables("Mercaderiaprov").Rows(0)("tipo")
                tCantidad.Text = dsa.Tables("Mercaderiaprov").Rows(0)("cantidad").ToString()
                tPrecio.Text = dsa.Tables("Mercaderiaprov").Rows(0)("precio")
            Else
                LimpiarCamposClientes()
            End If
        End If

    End Sub
    Private Sub LimpiarCamposClientes()
        lID2.Text = "0"
        tMercaderia.Text = ""
        tTipo.Text = ""
        tCantidad.Text = ""
        tPrecio.Text = ""
    End Sub
    Private Sub DataGridView1_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.RowEnter
        FilaClick(e)
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        FilaClick(e)


    End Sub

    Sub FilaClick(ByVal e As Object)
        Dim fila As Integer = e.RowIndex
        Dim tfila As String

        If IsNothing(DataGridView1.Rows(fila).Cells(0).Value) Then
            lID2.Text = "0"

            Exit Sub
        Else
            tfila = DataGridView1.Rows(fila).Cells(0).Value
            lID2.Text = tfila.ToString()
            CargarCamposMercaderia()
        End If

    End Sub
    Private Sub bAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bAceptar.Click
        Dim errores As String = "", en As String = vbCrLf
        If tMercaderia.Text.Trim.Length < 1 Then
            errores &= "Por Favor complete el nombre del producto." & en
        End If
        If tTipo.Text.Trim.Length < 1 Then
            errores &= "Por Favor complete el Nombre del tipo del producto." & en
        End If
        If errores.Length > 0 Then
            MsgBox("Hubo errores, por favor verifique y corrija antes de intentar de nuevo:" & en & en & errores)
            Exit Sub
            If tCantidad.Text.Trim.Length < 1 Then
                errores &= "Por Favor complete la cantidad del producto." & en
            End If
            If tPrecio.Text.Trim.Length < 1 Then
                errores &= "Por Favor complete el Precio del producto." & en
            End If

        End If
        If SQL_Accion("update Mercaderiaprov set Mercaderia='" & tMercaderia.Text.Trim.ToUpper.Replace("'", "´") & "', tipo='" & tTipo.Text.Trim.ToUpper.Replace("'", "´") & "',Cantidad='" & tCantidad.Text.Trim.ToUpper.Replace("'", "´") & "',precio='" & tPrecio.Text.Trim.ToUpper.Replace("'", "´") & "' where Nmer=" & VNum(lID2.Text)) = True Then
            MsgBox("Cambios realizados correctamente.")

            buscar(" Nmer=" & VNum(lID2.Text))

        Else

            MsgBox("Se produjo un error al querer guardar los datos del cliente, reintente, y si el error persiste, anote todos los datos que quiso ingresar y comuníquese con el programador.")
        End If
    End Sub
    Private Sub bNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bNuevo.Click
        If SQL_Accion("insert into mercaderiaprov (mercaderia, tipo, cantidad, precio) values ( '*******', '********', 0 , 0 )") Then

            buscar("mercaderia like '****%' ")

            MsgBox("Se ha creado un registro para un nuevo producto, cargue los datos  y luego confirme con el botón 'Aceptar Cambios'.")

        End If
    End Sub
    Private Sub bVolver_Click(sender As Object, e As EventArgs) Handles bVolver.Click
        Me.Close()
    End Sub

    Private Sub Cliregg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buscar("1 = 1")
    End Sub

    Private Sub tCantidad_TextChanged(sender As Object, e As EventArgs) Handles tCantidad.TextChanged

    End Sub

    Private Sub bBuscar_Click(sender As Object, e As EventArgs) Handles bBuscar.Click
        buscar("mercaderia Like '%" & tMeercaderia.Text.Trim & "%'")
    End Sub


    Private Sub bEliminar_Click_1(sender As Object, e As EventArgs) Handles bEliminar.Click
        If MessageBox.Show("Quiere ELIMINAR definitivamente al PRODUCTO?: " & tMercaderia.Text.Trim.ToUpper, "Eliminar PRODUCTO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        If SQL_Accion("delete from mercaderiaprov  where  Nmer=" & Val(lID2.Text)) = False Then
            MsgBox("Error al intentar borrar el producto, intente nuevamente, y si persiste, comuniquese con el programador.")
        Else
            buscar(" 1=1 ")
            MsgBox("producto ELIMINADO de la Base de Datos.")
        End If
    End Sub

End Class