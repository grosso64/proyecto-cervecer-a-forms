Imports System.IO
Imports System.Data.SqlClient
Public Class proveedores
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

        Dim da1 As New SqlDataAdapter("SELECT TOP (100) PERCENT Nprov, ApeyNom from proveedores_búsqueda where " & condicion & " order by ApeyNom", con)
        Dim dsa As New DataSet
        da1.Fill(dsa, "proveedores")
        If dsa.Tables("proveedores").Rows.Count = 0 Then
            DataGridView1.Visible = False
            lID2.Visible = False
        Else
            DataGridView1.DataSource = dsa.Tables("proveedores")
            DataGridView1.Refresh()
            DataGridView1.Visible = True

            lID2.Visible = True

        End If

    End Sub
    Sub CargarCamposProveedores()
        If Val(lID2.Text) = 0 Then
            pBotone.Visible = False
            pCamposP.Visible = False

            Exit Sub
        Else
            pBotone.Visible = True
            pCamposP.Visible = True
            Dim da1 As New SqlDataAdapter("SELECT  
                  upper(ltrim(rtrim(isnull(apellidoprov,'****')))) as apellido, 
                upper(ltrim(rtrim(isnull(nombreprov,'****')))) as nombre, 
                isnull([Documento-prov],0) as documento, 
                ltrim(rtrim(isnull(domicilioprov,''))) as domicilio,
                ltrim(rtrim(isnull([localidadprov],''))) as localidad, 
                ltrim (rtrim(isnull ([PostalProv], ''))) as postal, 
                ltrim(rtrim(isnull([provinciaprov],''))) as provincia,
                ltrim(rtrim(isnull([teléfonosprov],''))) as telefono,
                ltrim(rtrim(isnull([E-Mail-prov],''))) as mail,
                ltrim(rtrim(isnull(usuario1,''))) as usuario1,
                ltrim(rtrim(isnull(contrasenia1,''))) as contrasenia1
                from Proveedores where Nprov=" & Val(lID2.Text), con)

            Dim dsa As New DataSet
            da1.Fill(dsa, "proveedores")
            If dsa.Tables("proveedores").Rows.Count > 0 Then
                tApellido.Text = dsa.Tables("proveedores").Rows(0)("apellido")
                tNombre.Text = dsa.Tables("proveedores").Rows(0)("nombre")
                tDNI.Text = dsa.Tables("proveedores").Rows(0)("Documento")
                tDomicilio.Text = dsa.Tables("Proveedores").Rows(0)("domicilio")
                tCP.Text = dsa.Tables("Proveedores").Rows(0)("postal")
                tLocalidad.Text = dsa.Tables("Proveedores").Rows(0)("localidad")
                tProvincia.Text = dsa.Tables("Proveedores").Rows(0)("provincia")
                tMail.Text = dsa.Tables("proveedores").Rows(0)("mail")
                tTelefono.Text = dsa.Tables("proveedores").Rows(0)("telefono")
                tUsuario1.Text = dsa.Tables("proveedores").Rows(0)("usuario1")
                tContrasenia1.Text = dsa.Tables("proveedores").Rows(0)("contrasenia1")

            Else
                LimpiarCamposProveedores()
            End If
        End If

    End Sub
    Private Sub LimpiarCamposProveedores()
        lID2.Text = "0"
        tApellido.Text = ""
        tNombre.Text = ""
        tDNI.Text = ""
        tDomicilio.Text = ""
        tCP.Text = ""
        tLocalidad.Text = ""
        tProvincia.Text = ""
        tMail.Text = ""
        tTelefono.Text = ""
        tUsuario1.Text = ""
        tContrasenia1.Text = ""
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
            CargarCamposProveedores()
        End If

    End Sub
    Private Sub bAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bAceptar.Click
        Dim errores As String = "", en As String = vbCrLf
        If tApellido.Text.Trim.Length < 3 Then
            errores &= "Por Favor complete el Apellido del proveedor." & en
        End If
        If tNombre.Text.Trim.Length < 3 Then
            errores &= "Por Favor complete el Nombre del proveedor." & en
        End If
        tDNI.Text = Val(tDNI.Text.Trim.Replace(".", "").Replace(" ", "").Replace(",", ""))
        If tDNI.Text.Trim.Length < 4 Or tDNI.Text.IndexOf("11111") > -1 Or tDNI.Text.IndexOf("12345") > -1 Or tDNI.Text.IndexOf("000000") > -1 Then
            errores &= "Por Favor complete CORRECTAMENTE el DNI del proveedor." & en
        End If
        If tMail.Text.Trim.Length <> 0 And (tMail.Text.IndexOf("@") < 0 Or tMail.Text.IndexOf(".") < 0) Then
            errores &= "mail incorrecto, Por Favor complete CORRECTAMENTE el mail" & en
        End If
        If ExisteUsuario1(tUsuario1.Text.Trim.ToUpper.Replace("'", "´")) Then
            MsgBox("El usuario ya existe o es el mismo, Por favor, elija otro nombre de usuario.")
            Exit Sub
        End If
        If errores.Length > 0 Then
            MsgBox("Hubo errores, por favor verifique y corrija antes de intentar de nuevo:" & en & en & errores)
            Exit Sub

        End If
        If SQL_Accion("update proveedores set apellidoprov='" & tApellido.Text.Trim.ToUpper.Replace("'", "´") & "', nombreprov='" & tNombre.Text.Trim.ToUpper.Replace("'", "´") & "', [Documento-prov]=" & Val(tDNI.Text.Trim.Replace(".", "").Replace(" ", "").Replace(",", "")) & ",domicilioprov='" & tDomicilio.Text.Trim.ToUpper.Replace("'", "´") & "', [localidadprov]='" & tLocalidad.Text.Trim.ToUpper.Replace("'", "´") & "', [provinciaprov]='" & tProvincia.Text.Trim.ToUpper.Replace("'", "´") & "', [postalprov]=' " & tCP.Text.Trim.ToUpper.Replace("'", "´") & " ', [teléfonosprov]='" & tTelefono.Text.Trim.ToUpper.Replace("'", "´") & "', [e-mail-prov]='" & tMail.Text.Trim.ToUpper.Replace("'", "´") & "', usuario1='" & tUsuario1.Text.Trim.ToUpper.Replace("'", "´") & "',contrasenia1='" & tContrasenia1.Text.Trim.ToUpper.Replace("'", "´") & "' where nprov=" & VNum(lID2.Text)) = True Then
            MsgBox("Cambios realizados correctamente.")

            buscar(" nprov=" & VNum(lID2.Text))
        Else

            MsgBox("Se produjo un error al querer guardar los datos del proveedor, reintente, y si el error persiste, anote todos los datos que quiso ingresar y comuníquese con el programador.")
        End If
    End Sub
    Private Sub bNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bNuevo.Click
        If SQL_Accion("insert into proveedores (apellidoprov, nombreprov, [Documento-prov],domicilioprov, [localidadprov], [postalprov], [Provinciaprov],  [teléfonosprov], [e-mail-prov], usuario1, contrasenia1) values ('*******', '********',        0 ,'','','','','      ', '     ', '     ','  ' )") Then

            buscar("ApeyNom like '****%' ")

            MsgBox("Se ha creado un registro para un nuevo proveedor, cargue los datos y luego confirme con el botón 'Aceptar Cambios'.")
        End If
    End Sub
    Private Sub bVolver_Click(sender As Object, e As EventArgs) Handles bVolver.Click
        Me.Close()
    End Sub

    Private Sub proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buscar(" ApeyNom like '" & tAapellido.Text & "%' ")
        If DataGridView1.Rows.Count = 0 Then
            pBotone.Visible = False
            pCamposP.Visible = False
        End If
    End Sub

    Private Sub bEliminar_Click_1(sender As Object, e As EventArgs) Handles bEliminar.Click
        If MessageBox.Show("Quiere ELIMINAR definitivamente al PROVEEDOR: " & tApellido.Text.Trim.ToUpper, "Eliminar PROVEEDOR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        If SQL_Accion("delete from Proveedores  where  Nprov=" & Val(lID2.Text)) = False Then
            MsgBox("Error al intentar borrar el Proveedor, intente nuevamente, y si persiste, comuniquese con el programador.")
        Else

            buscar(" ApeyNom like '%" & tAapellido.Text & "%' ")
            MsgBox("Proveedor ELIMINADO de la Base de Datos.")

        End If
    End Sub

    Private Sub bBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bBuscar.Click
        buscar(" ApeyNom like '%" & tAapellido.Text & "%' ")
    End Sub

    Private Sub tAapellido_TextChanged(sender As Object, e As EventArgs) Handles tAapellido.TextChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class