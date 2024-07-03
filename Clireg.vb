Imports System.IO
Imports System.Data.SqlClient
Public Class Clireg
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

        Dim da1 As New SqlDataAdapter("SELECT TOP (100) PERCENT Ncli, ApeyNom from cliente1_búsqueda where " & condicion & " order by ApeyNom", con)
        Dim dsa As New DataSet
        da1.Fill(dsa, "Cliente1")
        If dsa.Tables("Cliente1").Rows.Count = 0 Then
            DataGridView1.Visible = False
            lID1.Visible = False
        Else
            DataGridView1.DataSource = dsa.Tables("Cliente1")
            DataGridView1.Refresh()
            DataGridView1.Visible = True

            lID1.Visible = True

        End If

    End Sub
    Sub CargarCamposClientes()


        Dim da1 As New SqlDataAdapter("SELECT  
                upper(ltrim(rtrim(isnull(apellidoCli,'****')))) as apellido, 
                upper(ltrim(rtrim(isnull(nombreCli,'****')))) as nombre,               
                isnull([Documento-cli],0) as Documento, 
                ltrim(rtrim(isnull([teléfonocli],''))) as telefono,
                ltrim(rtrim(isnull([E-Mail-cli],''))) as mail,
                ltrim(rtrim(isnull(usuario,'')))as usuario,
                ltrim(rtrim(isnull(contrasenia,'')))as contrasenia
                from Cliente1 where Ncli=" & Val(lID1.Text), con)

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

    End Sub
    Private Sub LimpiarCamposClientes()
        lID1.Text = "0"
        pBotones.Visible = False
        pCampos.Visible = False
        tAapellido.Text = ""
        tNombre.Text = ""
        tDNI.Text = ""
        tMail.Text = ""
        tTelefono.Text = ""
    End Sub
    Private Sub DataGridView1_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.RowEnter
        FilaClick(e)
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        FilaClick(e)
        pBotones.Visible = True

    End Sub

    Sub FilaClick(ByVal e As Object)
        Dim fila As Integer = e.RowIndex
        Dim tfila As String

        If IsNothing(DataGridView1.Rows(fila).Cells(0).Value) Then
            lID1.Text = "0"
            pBotones.Visible = False
            pCampos.Visible = False
            Exit Sub
        Else
            tfila = DataGridView1.Rows(fila).Cells(0).Value
            lID1.Text = tfila.ToString()
            CargarCamposClientes()
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
        If SQL_Accion("update Cliente1 set apellidocli='" & tAapellido.Text.Trim.ToUpper.Replace("'", "´") & "', nombrecli='" & tNombre.Text.Trim.ToUpper.Replace("'", "´") & "', [Documento-cli]=" & Val(tDNI.Text.Trim.Replace(".", "").Replace(" ", "").Replace(",", "")) & ", [teléfonocli]='" & tTelefono.Text.Trim.ToUpper.Replace("'", "´") & "', [e-mail-cli]='" & tMail.Text.Trim.ToUpper.Replace("'", "´") & "', usuario='" & tUsuario.Text.Trim.ToUpper.Replace("'", "´") & "',contrasenia='" & tContrasenia.Text.Trim.ToUpper.Replace("'", "´") & "' where ncli=" & VNum(lID1.Text)) = True Then
            MsgBox("Cambios realizados correctamente.")

            buscar(" ncli=" & VNum(lID1.Text))
        Else

            MsgBox("Se produjo un error al querer guardar los datos del cliente, reintente, y si el error persiste, anote todos los datos que quiso ingresar y comuníquese con el programador.")
        End If
    End Sub
    Private Sub bNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bNuevo.Click
        If SQL_Accion("insert into Cliente1 (apellidocli, nombrecli, [Documento-cli], [teléfonocli], [e-mail-cli], usuario, contrasenia) values ('*******', '********',        0, '      ', '     ', '     ','  ' )") Then

            buscar("ApeyNom like '****%' ")

            MsgBox("Se ha creado un registro para un nuevo cliente, cargue los datos y luego confirme con el botón 'Aceptar Cambios'.")
        End If
    End Sub
    Private Sub bVolver_Click(sender As Object, e As EventArgs) Handles bVolver.Click
        If MessageBox.Show("Verifique si los DATOS son correctos", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub
        Me.Close()
    End Sub
    Private Sub Cliregg_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class