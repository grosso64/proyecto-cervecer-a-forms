<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class proveedores
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(proveedores))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.pCamposP = New System.Windows.Forms.Panel()
        Me.tContrasenia1 = New System.Windows.Forms.TextBox()
        Me.tUsuario1 = New System.Windows.Forms.TextBox()
        Me.lUsuario1 = New System.Windows.Forms.Label()
        Me.lContrasenia1 = New System.Windows.Forms.Label()
        Me.tMail = New System.Windows.Forms.TextBox()
        Me.tTelefono = New System.Windows.Forms.TextBox()
        Me.tProvincia = New System.Windows.Forms.TextBox()
        Me.tLocalidad = New System.Windows.Forms.TextBox()
        Me.tCP = New System.Windows.Forms.TextBox()
        Me.tDomicilio = New System.Windows.Forms.TextBox()
        Me.tDNI = New System.Windows.Forms.TextBox()
        Me.tNombre = New System.Windows.Forms.TextBox()
        Me.tApellido = New System.Windows.Forms.TextBox()
        Me.lMail = New System.Windows.Forms.Label()
        Me.lTelefono = New System.Windows.Forms.Label()
        Me.lProvincia = New System.Windows.Forms.Label()
        Me.LLocalidad = New System.Windows.Forms.Label()
        Me.lPostal = New System.Windows.Forms.Label()
        Me.lDomicilio = New System.Windows.Forms.Label()
        Me.lDocumento = New System.Windows.Forms.Label()
        Me.lNombre = New System.Windows.Forms.Label()
        Me.lAapellido = New System.Windows.Forms.Label()
        Me.bNuevo = New System.Windows.Forms.Button()
        Me.lID2 = New System.Windows.Forms.Label()
        Me.bAceptar = New System.Windows.Forms.Button()
        Me.pBotone = New System.Windows.Forms.Panel()
        Me.bEliminar = New System.Windows.Forms.Button()
        Me.bVolver = New System.Windows.Forms.Button()
        Me.bBuscar = New System.Windows.Forms.Button()
        Me.tAapellido = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.apeynom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nprov = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pCamposP.SuspendLayout()
        Me.pBotone.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.apeynom, Me.Nprov})
        Me.DataGridView1.Location = New System.Drawing.Point(11, 75)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(389, 379)
        Me.DataGridView1.TabIndex = 11
        '
        'pCamposP
        '
        Me.pCamposP.BackColor = System.Drawing.Color.Transparent
        Me.pCamposP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pCamposP.Controls.Add(Me.tContrasenia1)
        Me.pCamposP.Controls.Add(Me.tUsuario1)
        Me.pCamposP.Controls.Add(Me.lUsuario1)
        Me.pCamposP.Controls.Add(Me.lContrasenia1)
        Me.pCamposP.Controls.Add(Me.tMail)
        Me.pCamposP.Controls.Add(Me.tTelefono)
        Me.pCamposP.Controls.Add(Me.tProvincia)
        Me.pCamposP.Controls.Add(Me.tLocalidad)
        Me.pCamposP.Controls.Add(Me.tCP)
        Me.pCamposP.Controls.Add(Me.tDomicilio)
        Me.pCamposP.Controls.Add(Me.tDNI)
        Me.pCamposP.Controls.Add(Me.tNombre)
        Me.pCamposP.Controls.Add(Me.tApellido)
        Me.pCamposP.Controls.Add(Me.lMail)
        Me.pCamposP.Controls.Add(Me.lTelefono)
        Me.pCamposP.Controls.Add(Me.lProvincia)
        Me.pCamposP.Controls.Add(Me.LLocalidad)
        Me.pCamposP.Controls.Add(Me.lPostal)
        Me.pCamposP.Controls.Add(Me.lDomicilio)
        Me.pCamposP.Controls.Add(Me.lDocumento)
        Me.pCamposP.Controls.Add(Me.lNombre)
        Me.pCamposP.Controls.Add(Me.lAapellido)
        Me.pCamposP.Location = New System.Drawing.Point(461, 75)
        Me.pCamposP.Margin = New System.Windows.Forms.Padding(2)
        Me.pCamposP.Name = "pCamposP"
        Me.pCamposP.Size = New System.Drawing.Size(432, 292)
        Me.pCamposP.TabIndex = 12
        '
        'tContrasenia1
        '
        Me.tContrasenia1.Location = New System.Drawing.Point(148, 265)
        Me.tContrasenia1.Name = "tContrasenia1"
        Me.tContrasenia1.Size = New System.Drawing.Size(215, 20)
        Me.tContrasenia1.TabIndex = 22
        '
        'tUsuario1
        '
        Me.tUsuario1.Location = New System.Drawing.Point(148, 239)
        Me.tUsuario1.Name = "tUsuario1"
        Me.tUsuario1.Size = New System.Drawing.Size(215, 20)
        Me.tUsuario1.TabIndex = 21
        '
        'lUsuario1
        '
        Me.lUsuario1.AutoSize = True
        Me.lUsuario1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lUsuario1.Location = New System.Drawing.Point(44, 243)
        Me.lUsuario1.Name = "lUsuario1"
        Me.lUsuario1.Size = New System.Drawing.Size(62, 16)
        Me.lUsuario1.TabIndex = 20
        Me.lUsuario1.Text = "Usuario"
        '
        'lContrasenia1
        '
        Me.lContrasenia1.AutoSize = True
        Me.lContrasenia1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lContrasenia1.Location = New System.Drawing.Point(44, 269)
        Me.lContrasenia1.Name = "lContrasenia1"
        Me.lContrasenia1.Size = New System.Drawing.Size(87, 16)
        Me.lContrasenia1.TabIndex = 19
        Me.lContrasenia1.Text = "Contraseña"
        '
        'tMail
        '
        Me.tMail.Location = New System.Drawing.Point(148, 215)
        Me.tMail.Margin = New System.Windows.Forms.Padding(2)
        Me.tMail.Name = "tMail"
        Me.tMail.Size = New System.Drawing.Size(215, 20)
        Me.tMail.TabIndex = 18
        '
        'tTelefono
        '
        Me.tTelefono.Location = New System.Drawing.Point(148, 188)
        Me.tTelefono.Margin = New System.Windows.Forms.Padding(2)
        Me.tTelefono.Name = "tTelefono"
        Me.tTelefono.Size = New System.Drawing.Size(215, 20)
        Me.tTelefono.TabIndex = 17
        '
        'tProvincia
        '
        Me.tProvincia.Location = New System.Drawing.Point(148, 162)
        Me.tProvincia.Margin = New System.Windows.Forms.Padding(2)
        Me.tProvincia.Name = "tProvincia"
        Me.tProvincia.Size = New System.Drawing.Size(215, 20)
        Me.tProvincia.TabIndex = 16
        '
        'tLocalidad
        '
        Me.tLocalidad.Location = New System.Drawing.Point(148, 133)
        Me.tLocalidad.Margin = New System.Windows.Forms.Padding(2)
        Me.tLocalidad.Name = "tLocalidad"
        Me.tLocalidad.Size = New System.Drawing.Size(215, 20)
        Me.tLocalidad.TabIndex = 15
        '
        'tCP
        '
        Me.tCP.Location = New System.Drawing.Point(148, 108)
        Me.tCP.Margin = New System.Windows.Forms.Padding(2)
        Me.tCP.Name = "tCP"
        Me.tCP.Size = New System.Drawing.Size(103, 20)
        Me.tCP.TabIndex = 14
        '
        'tDomicilio
        '
        Me.tDomicilio.Location = New System.Drawing.Point(148, 83)
        Me.tDomicilio.Margin = New System.Windows.Forms.Padding(2)
        Me.tDomicilio.Name = "tDomicilio"
        Me.tDomicilio.Size = New System.Drawing.Size(215, 20)
        Me.tDomicilio.TabIndex = 13
        '
        'tDNI
        '
        Me.tDNI.Location = New System.Drawing.Point(148, 59)
        Me.tDNI.Margin = New System.Windows.Forms.Padding(2)
        Me.tDNI.Name = "tDNI"
        Me.tDNI.Size = New System.Drawing.Size(215, 20)
        Me.tDNI.TabIndex = 12
        '
        'tNombre
        '
        Me.tNombre.Location = New System.Drawing.Point(148, 36)
        Me.tNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.tNombre.Name = "tNombre"
        Me.tNombre.Size = New System.Drawing.Size(215, 20)
        Me.tNombre.TabIndex = 11
        '
        'tApellido
        '
        Me.tApellido.Location = New System.Drawing.Point(148, 11)
        Me.tApellido.Margin = New System.Windows.Forms.Padding(2)
        Me.tApellido.Name = "tApellido"
        Me.tApellido.Size = New System.Drawing.Size(215, 20)
        Me.tApellido.TabIndex = 10
        '
        'lMail
        '
        Me.lMail.AutoSize = True
        Me.lMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lMail.Location = New System.Drawing.Point(49, 218)
        Me.lMail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lMail.Name = "lMail"
        Me.lMail.Size = New System.Drawing.Size(37, 17)
        Me.lMail.TabIndex = 8
        Me.lMail.Text = "Mail"
        '
        'lTelefono
        '
        Me.lTelefono.AutoSize = True
        Me.lTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTelefono.Location = New System.Drawing.Point(44, 188)
        Me.lTelefono.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lTelefono.Name = "lTelefono"
        Me.lTelefono.Size = New System.Drawing.Size(72, 17)
        Me.lTelefono.TabIndex = 7
        Me.lTelefono.Text = "Teléfono"
        '
        'lProvincia
        '
        Me.lProvincia.AutoSize = True
        Me.lProvincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lProvincia.Location = New System.Drawing.Point(44, 162)
        Me.lProvincia.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lProvincia.Name = "lProvincia"
        Me.lProvincia.Size = New System.Drawing.Size(75, 17)
        Me.lProvincia.TabIndex = 6
        Me.lProvincia.Text = "Provincia"
        '
        'LLocalidad
        '
        Me.LLocalidad.AutoSize = True
        Me.LLocalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLocalidad.Location = New System.Drawing.Point(44, 136)
        Me.LLocalidad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LLocalidad.Name = "LLocalidad"
        Me.LLocalidad.Size = New System.Drawing.Size(78, 17)
        Me.LLocalidad.TabIndex = 5
        Me.LLocalidad.Text = "Localidad"
        '
        'lPostal
        '
        Me.lPostal.AutoSize = True
        Me.lPostal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lPostal.Location = New System.Drawing.Point(44, 111)
        Me.lPostal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lPostal.Name = "lPostal"
        Me.lPostal.Size = New System.Drawing.Size(100, 17)
        Me.lPostal.TabIndex = 4
        Me.lPostal.Text = "Código Post."
        '
        'lDomicilio
        '
        Me.lDomicilio.AutoSize = True
        Me.lDomicilio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lDomicilio.Location = New System.Drawing.Point(44, 86)
        Me.lDomicilio.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lDomicilio.Name = "lDomicilio"
        Me.lDomicilio.Size = New System.Drawing.Size(73, 17)
        Me.lDomicilio.TabIndex = 3
        Me.lDomicilio.Text = "Domicilio"
        '
        'lDocumento
        '
        Me.lDocumento.AutoSize = True
        Me.lDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lDocumento.Location = New System.Drawing.Point(44, 62)
        Me.lDocumento.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lDocumento.Name = "lDocumento"
        Me.lDocumento.Size = New System.Drawing.Size(89, 17)
        Me.lDocumento.TabIndex = 2
        Me.lDocumento.Text = "Documento"
        '
        'lNombre
        '
        Me.lNombre.AutoSize = True
        Me.lNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lNombre.Location = New System.Drawing.Point(49, 39)
        Me.lNombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lNombre.Name = "lNombre"
        Me.lNombre.Size = New System.Drawing.Size(64, 17)
        Me.lNombre.TabIndex = 1
        Me.lNombre.Text = "Nombre"
        '
        'lAapellido
        '
        Me.lAapellido.AutoSize = True
        Me.lAapellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lAapellido.Location = New System.Drawing.Point(44, 14)
        Me.lAapellido.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lAapellido.Name = "lAapellido"
        Me.lAapellido.Size = New System.Drawing.Size(66, 17)
        Me.lAapellido.TabIndex = 0
        Me.lAapellido.Text = "Apellido"
        '
        'bNuevo
        '
        Me.bNuevo.BackColor = System.Drawing.Color.Transparent
        Me.bNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bNuevo.Location = New System.Drawing.Point(174, 26)
        Me.bNuevo.Margin = New System.Windows.Forms.Padding(2)
        Me.bNuevo.Name = "bNuevo"
        Me.bNuevo.Size = New System.Drawing.Size(120, 30)
        Me.bNuevo.TabIndex = 13
        Me.bNuevo.Text = "Nuevo"
        Me.bNuevo.UseVisualStyleBackColor = False
        '
        'lID2
        '
        Me.lID2.AutoSize = True
        Me.lID2.BackColor = System.Drawing.Color.Transparent
        Me.lID2.Location = New System.Drawing.Point(880, 60)
        Me.lID2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lID2.Name = "lID2"
        Me.lID2.Size = New System.Drawing.Size(13, 13)
        Me.lID2.TabIndex = 15
        Me.lID2.Text = "0"
        '
        'bAceptar
        '
        Me.bAceptar.BackColor = System.Drawing.Color.Transparent
        Me.bAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAceptar.Location = New System.Drawing.Point(13, 26)
        Me.bAceptar.Margin = New System.Windows.Forms.Padding(2)
        Me.bAceptar.Name = "bAceptar"
        Me.bAceptar.Size = New System.Drawing.Size(143, 30)
        Me.bAceptar.TabIndex = 14
        Me.bAceptar.Text = "Aceptar Cambios"
        Me.bAceptar.UseVisualStyleBackColor = False
        '
        'pBotone
        '
        Me.pBotone.BackColor = System.Drawing.Color.Transparent
        Me.pBotone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pBotone.Controls.Add(Me.Label2)
        Me.pBotone.Controls.Add(Me.bEliminar)
        Me.pBotone.Controls.Add(Me.bAceptar)
        Me.pBotone.Controls.Add(Me.bNuevo)
        Me.pBotone.Cursor = System.Windows.Forms.Cursors.Default
        Me.pBotone.Location = New System.Drawing.Point(461, 371)
        Me.pBotone.Margin = New System.Windows.Forms.Padding(2)
        Me.pBotone.Name = "pBotone"
        Me.pBotone.Size = New System.Drawing.Size(432, 83)
        Me.pBotone.TabIndex = 14
        '
        'bEliminar
        '
        Me.bEliminar.BackColor = System.Drawing.Color.Transparent
        Me.bEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bEliminar.Location = New System.Drawing.Point(308, 26)
        Me.bEliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.bEliminar.Name = "bEliminar"
        Me.bEliminar.Size = New System.Drawing.Size(120, 30)
        Me.bEliminar.TabIndex = 15
        Me.bEliminar.Text = "Eliminar"
        Me.bEliminar.UseVisualStyleBackColor = False
        '
        'bVolver
        '
        Me.bVolver.BackColor = System.Drawing.Color.Transparent
        Me.bVolver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bVolver.Location = New System.Drawing.Point(0, 543)
        Me.bVolver.Margin = New System.Windows.Forms.Padding(2)
        Me.bVolver.Name = "bVolver"
        Me.bVolver.Size = New System.Drawing.Size(141, 30)
        Me.bVolver.TabIndex = 16
        Me.bVolver.Text = "Volver al Menu"
        Me.bVolver.UseVisualStyleBackColor = False
        '
        'bBuscar
        '
        Me.bBuscar.BackColor = System.Drawing.Color.Transparent
        Me.bBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bBuscar.Location = New System.Drawing.Point(561, 28)
        Me.bBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.bBuscar.Name = "bBuscar"
        Me.bBuscar.Size = New System.Drawing.Size(83, 29)
        Me.bBuscar.TabIndex = 17
        Me.bBuscar.Text = "Buscar"
        Me.bBuscar.UseVisualStyleBackColor = False
        '
        'tAapellido
        '
        Me.tAapellido.Location = New System.Drawing.Point(317, 34)
        Me.tAapellido.Name = "tAapellido"
        Me.tAapellido.Size = New System.Drawing.Size(239, 20)
        Me.tAapellido.TabIndex = 18
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(282, 34)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(18, 20)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(11, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(255, 17)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Buscar por apellido del proveedor"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(288, 39)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "para eliminar un proveedor, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "toque sobre el nombre del proveedor de la lista y " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "toque el boton eliminar"
        '
        'apeynom
        '
        Me.apeynom.DataPropertyName = "apeynom"
        Me.apeynom.HeaderText = "apellido y nombre"
        Me.apeynom.Name = "apeynom"
        Me.apeynom.Width = 300
        '
        'Nprov
        '
        Me.Nprov.DataPropertyName = "Nprov"
        Me.Nprov.HeaderText = "Nprov"
        Me.Nprov.Name = "Nprov"
        Me.Nprov.Visible = False
        Me.Nprov.Width = 300
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(96, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(249, 15)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Click en nuevo para cargar su usuario"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(566, 514)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(327, 59)
        Me.Panel1.TabIndex = 22
        '
        'proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gold
        Me.ClientSize = New System.Drawing.Size(957, 574)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.tAapellido)
        Me.Controls.Add(Me.bBuscar)
        Me.Controls.Add(Me.bVolver)
        Me.Controls.Add(Me.lID2)
        Me.Controls.Add(Me.pBotone)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.pCamposP)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "proveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proveedores"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pCamposP.ResumeLayout(False)
        Me.pCamposP.PerformLayout()
        Me.pBotone.ResumeLayout(False)
        Me.pBotone.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents pCamposP As Panel
    Friend WithEvents bNuevo As Button
    Friend WithEvents lMail As Label
    Friend WithEvents lTelefono As Label
    Friend WithEvents lProvincia As Label
    Friend WithEvents LLocalidad As Label
    Friend WithEvents lPostal As Label
    Friend WithEvents lDomicilio As Label
    Friend WithEvents lDocumento As Label
    Friend WithEvents lNombre As Label
    Friend WithEvents lAapellido As Label
    Friend WithEvents tMail As TextBox
    Friend WithEvents tTelefono As TextBox
    Friend WithEvents tProvincia As TextBox
    Friend WithEvents tLocalidad As TextBox
    Friend WithEvents tCP As TextBox
    Friend WithEvents tDomicilio As TextBox
    Friend WithEvents tDNI As TextBox
    Friend WithEvents tNombre As TextBox
    Friend WithEvents tApellido As TextBox
    Friend WithEvents lID2 As Label
    Friend WithEvents bAceptar As Button
    Friend WithEvents pBotone As Panel
    Friend WithEvents bVolver As Button
    Friend WithEvents tContrasenia1 As TextBox
    Friend WithEvents tUsuario1 As TextBox
    Friend WithEvents lUsuario1 As Label
    Friend WithEvents lContrasenia1 As Label
    Friend WithEvents bEliminar As Button
    Friend WithEvents bBuscar As Button
    Friend WithEvents tAapellido As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents apeynom As DataGridViewTextBoxColumn
    Friend WithEvents Nprov As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
End Class

