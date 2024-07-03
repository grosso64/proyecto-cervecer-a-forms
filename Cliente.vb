Imports System.IO
Imports System.Data.SqlClient

Public Class Clientes

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

    Private Sub Clientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        buscar(" ApeyNom like '" & tApellido.Text & "%' ")
        If DataGridView1.Rows.Count = 0 Then
            pBotones.Visible = False
            pCampos.Visible = False
        End If
    End Sub

    Sub buscar(ByVal condicion As String)

        Dim da1 As New SqlDataAdapter("SELECT TOP (100) PERCENT Ncli, ApeyNom from cliente1_búsqueda where " & condicion & " order by ApeyNom", con)
        Dim dsa As New DataSet
        da1.Fill(dsa, "Cliente1")
        If dsa.Tables("Cliente1").Rows.Count = 0 Then

            DataGridView1.Visible = False

            lID.Visible = False
        Else

            DataGridView1.DataSource = dsa.Tables("Cliente1")
            DataGridView1.Refresh()
            DataGridView1.Visible = True

            lID.Visible = True

        End If

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
            lID.Text = "0"

            Exit Sub
        Else
            tfila = DataGridView1.Rows(fila).Cells(0).Value
            lID.Text = tfila.ToString()
            CargarCamposClientes()
        End If

    End Sub
    Sub CargarCamposClientes()
        If Val(lID.Text) = 0 Then
            pBotones.Visible = False
            pCampos.Visible = False

            Exit Sub
        Else
            pBotones.Visible = True
            pCampos.Visible = True
            Dim da1 As New SqlDataAdapter("SELECT  
                upper(ltrim(rtrim(isnull(apellidoCli,'****')))) as apellido, 
                upper(ltrim(rtrim(isnull(nombreCli,'****')))) as nombre,               
                isnull([Documento-cli],0) as Documento, 
                ltrim(rtrim(isnull([teléfonocli],''))) as telefono,
                ltrim(rtrim(isnull([E-Mail-cli],''))) as mail,
                ltrim(rtrim(isnull(usuario,'')))as usuario,
                ltrim(rtrim(isnull(contrasenia,'')))as contrasenia
                from Cliente1 where Ncli=" & Val(lID.Text), con)

            Dim dsa As New DataSet
            da1.Fill(dsa, "Cliente1")
            If dsa.Tables("Cliente1").Rows.Count > 0 Then
                tAapellido.Text = dsa.Tables("Cliente1").Rows(0)("apellido")
                tNombre.Text = dsa.Tables("Cliente1").Rows(0)("nombre")
                tDNI.Text = dsa.Tables("Cliente1").Rows(0)("Documento")
                tMail.Text = dsa.Tables("Cliente1").Rows(0)("mail")
                tTelefono.Text = dsa.Tables("Cliente1").Rows(0)("telefono")
                tUsuario.Text = dsa.Tables("Cliente1").Rows(0)("usuario")
                tContrasenia.Text = dsa.Tables("Cliente1").Rows(0)("contrasenia")

            Else
                LimpiarCamposClientes()
        End If

        End If

    End Sub

    Private Sub LimpiarCamposClientes()
        lID.Text = "0"
        tAapellido.Text = ""
        tNombre.Text = ""
        tDNI.Text = ""
        tMail.Text = ""
        tTelefono.Text = ""
    End Sub
    Private Sub bBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bBuscar.Click
        buscar(" ApeyNom like '%" & tApellido.Text & "%' ")
    End Sub


    Private Sub bEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bEliminar.Click
        If MessageBox.Show("Quiere ELIMINAR definitivamente al CLIENTE: " & tAapellido.Text.Trim.ToUpper, "Eliminar CLIENTE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        If SQL_Accion("delete from Cliente1  where  Ncli=" & Val(lID.Text)) = False Then
            MsgBox("Error al intentar borrar el Cliente, intente nuevamente, y si persiste, tome nota de los datos ingresados y comuniquese con el programador.")
        Else

            buscar(" ApeyNom like '%" & tApellido.Text & "%' ")
            MsgBox("cliente ELIMINADO de la Base de Datos.")
        End If

    End Sub

    Private Sub bAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bAceptar.Click
        Dim errores As String = "", en As String = vbCrLf
        If tAapellido.Text.Trim.Length < 3 Then
            errores &= "Por Favor complete el Apellido del Cliente." & en
        End If
        If tNombre.Text.Trim.Length < 3 Then
            errores &= "Por Favor complete el Nombre del Cliente." & en
        End If
        tDNI.Text = Val(tDNI.Text.Trim.Replace(".", "").Replace(" ", "").Replace(",", ""))
        If tDNI.Text.Trim.Length < 4 Or tDNI.Text.IndexOf("11111") > -1 Or tDNI.Text.IndexOf("12345") > -1 Or tDNI.Text.IndexOf("000000") > -1 Then
            errores &= "Por Favor complete CORRECTAMENTE el DNI del Cliente." & en
        End If
        If tMail.Text.Trim.Length <> 0 And (tMail.Text.IndexOf("@") < 0 Or tMail.Text.IndexOf(".") < 0) Then
            errores &= "mail incorrecto, Por Favor complete CORRECTAMENTE el mail" & en
        End If
        If ExisteUsuario(tUsuario.Text.Trim.ToUpper.Replace("'", "´")) Then
            MsgBox("El usuario ya existe o es el mismo, Por favor, elija otro nombre de usuario.")
            Exit Sub
        End If
        If errores.Length > 0 Then
            MsgBox("Hubo errores, por favor verifique y corrija antes de intentar de nuevo:" & en & en & errores)
            Exit Sub

        End If
        If SQL_Accion("update Cliente1 set apellidocli='" & tAapellido.Text.Trim.ToUpper.Replace("'", "´") & "', nombrecli='" & tNombre.Text.Trim.ToUpper.Replace("'", "´") & "', [Documento-cli]=" & Val(tDNI.Text.Trim.Replace(".", "").Replace(" ", "").Replace(",", "")) & ", [teléfonocli]='" & tTelefono.Text.Trim.ToUpper.Replace("'", "´") & "', [e-mail-cli]='" & tMail.Text.Trim.ToUpper.Replace("'", "´") & "', usuario='" & tUsuario.Text.Trim.ToUpper.Replace("'", "´") & "',contrasenia='" & tContrasenia.Text.Trim.ToUpper.Replace("'", "´") & "' where ncli=" & VNum(lID.Text)) = True Then
            MsgBox("Cambios realizados correctamente.")

            buscar(" ncli=" & VNum(lID.Text))
        Else

            MsgBox("Se produjo un error al querer guardar los datos del cliente, reintente, y si el error persiste, anote todos los datos que quiso ingresar y comuníquese con el programador.")
        End If
    End Sub

    Private Sub bNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bNuevo.Click
        If SQL_Accion("insert into Cliente1 (apellidocli, nombrecli, [Documento-cli], [teléfonocli], [e-mail-cli], usuario, contrasenia) values ('*******', '********',        0, '      ', '     ', '     ','  ' )") Then

            buscar("ApeyNom like '****%' ")

            MsgBox("Se ha creado un registro para un nuevo usuario, cargue los datos y luego confirme con el botón 'Aceptar Cambios'.")
        End If
    End Sub

    Private Sub bVolver_Click(sender As Object, e As EventArgs) Handles bVolver.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles tUsuario.TextChanged

    End Sub

    Private Sub tMail_TextChanged(sender As Object, e As EventArgs) Handles tMail.TextChanged

    End Sub
End Class
