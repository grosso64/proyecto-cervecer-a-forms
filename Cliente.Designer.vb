<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clientes))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tApellido = New System.Windows.Forms.TextBox()
        Me.bBuscar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Ncli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apeynom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pCampos = New System.Windows.Forms.Panel()
        Me.tContrasenia = New System.Windows.Forms.TextBox()
        Me.tUsuario = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tMail = New System.Windows.Forms.TextBox()
        Me.tTelefono = New System.Windows.Forms.TextBox()
        Me.tDNI = New System.Windows.Forms.TextBox()
        Me.tNombre = New System.Windows.Forms.TextBox()
        Me.tAapellido = New System.Windows.Forms.TextBox()
        Me.lMail = New System.Windows.Forms.Label()
        Me.lTelefono = New System.Windows.Forms.Label()
        Me.LDNI = New System.Windows.Forms.Label()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.lApellido = New System.Windows.Forms.Label()
        Me.pBotones = New System.Windows.Forms.Panel()
        Me.bEliminar = New System.Windows.Forms.Button()
        Me.bAceptar = New System.Windows.Forms.Button()
        Me.bNuevo = New System.Windows.Forms.Button()
        Me.lID = New System.Windows.Forms.Label()
        Me.pBorrar = New System.Windows.Forms.PictureBox()
        Me.bVolver = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pCampos.SuspendLayout()
        Me.pBotones.SuspendLayout()
        CType(Me.pBorrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(10, 40)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Buscar por apellido del cliente"
        '
        'tApellido
        '
        Me.tApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tApellido.Location = New System.Drawing.Point(276, 40)
        Me.tApellido.Margin = New System.Windows.Forms.Padding(2)
        Me.tApellido.Name = "tApellido"
        Me.tApellido.Size = New System.Drawing.Size(236, 23)
        Me.tApellido.TabIndex = 1
        '
        'bBuscar
        '
        Me.bBuscar.BackColor = System.Drawing.Color.Transparent
        Me.bBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bBuscar.Location = New System.Drawing.Point(528, 40)
        Me.bBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.bBuscar.Name = "bBuscar"
        Me.bBuscar.Size = New System.Drawing.Size(84, 24)
        Me.bBuscar.TabIndex = 2
        Me.bBuscar.Text = "Buscar"
        Me.bBuscar.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Ncli, Me.apeynom})
        Me.DataGridView1.Location = New System.Drawing.Point(29, 77)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(407, 393)
        Me.DataGridView1.TabIndex = 3
        '
        'Ncli
        '
        Me.Ncli.DataPropertyName = "Ncli"
        Me.Ncli.HeaderText = "Nº"
        Me.Ncli.Name = "Ncli"
        Me.Ncli.Visible = False
        Me.Ncli.Width = 35
        '
        'apeynom
        '
        Me.apeynom.DataPropertyName = "apeynom"
        Me.apeynom.HeaderText = "apellido y nombre"
        Me.apeynom.Name = "apeynom"
        Me.apeynom.Width = 280
        '
        'pCampos
        '
        Me.pCampos.BackColor = System.Drawing.Color.Transparent
        Me.pCampos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pCampos.Controls.Add(Me.tContrasenia)
        Me.pCampos.Controls.Add(Me.tUsuario)
        Me.pCampos.Controls.Add(Me.Label3)
        Me.pCampos.Controls.Add(Me.Label2)
        Me.pCampos.Controls.Add(Me.tMail)
        Me.pCampos.Controls.Add(Me.tTelefono)
        Me.pCampos.Controls.Add(Me.tDNI)
        Me.pCampos.Controls.Add(Me.tNombre)
        Me.pCampos.Controls.Add(Me.tAapellido)
        Me.pCampos.Controls.Add(Me.lMail)
        Me.pCampos.Controls.Add(Me.lTelefono)
        Me.pCampos.Controls.Add(Me.LDNI)
        Me.pCampos.Controls.Add(Me.LNombre)
        Me.pCampos.Controls.Add(Me.lApellido)
        Me.pCampos.Location = New System.Drawing.Point(468, 88)
        Me.pCampos.Margin = New System.Windows.Forms.Padding(2)
        Me.pCampos.Name = "pCampos"
        Me.pCampos.Size = New System.Drawing.Size(435, 298)
        Me.pCampos.TabIndex = 4
        '
        'tContrasenia
        '
        Me.tContrasenia.Location = New System.Drawing.Point(113, 164)
        Me.tContrasenia.Name = "tContrasenia"
        Me.tContrasenia.Size = New System.Drawing.Size(159, 20)
        Me.tContrasenia.TabIndex = 21
        '
        'tUsuario
        '
        Me.tUsuario.Location = New System.Drawing.Point(113, 138)
        Me.tUsuario.Name = "tUsuario"
        Me.tUsuario.Size = New System.Drawing.Size(159, 20)
        Me.tUsuario.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(5, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 18)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Contraseña"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(33, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 18)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Usuario"
        '
        'tMail
        '
        Me.tMail.Location = New System.Drawing.Point(113, 113)
        Me.tMail.Margin = New System.Windows.Forms.Padding(2)
        Me.tMail.Name = "tMail"
        Me.tMail.Size = New System.Drawing.Size(159, 20)
        Me.tMail.TabIndex = 17
        '
        'tTelefono
        '
        Me.tTelefono.Location = New System.Drawing.Point(113, 89)
        Me.tTelefono.Margin = New System.Windows.Forms.Padding(2)
        Me.tTelefono.Name = "tTelefono"
        Me.tTelefono.Size = New System.Drawing.Size(159, 20)
        Me.tTelefono.TabIndex = 16
        '
        'tDNI
        '
        Me.tDNI.Location = New System.Drawing.Point(113, 65)
        Me.tDNI.Margin = New System.Windows.Forms.Padding(2)
        Me.tDNI.Name = "tDNI"
        Me.tDNI.Size = New System.Drawing.Size(159, 20)
        Me.tDNI.TabIndex = 11
        '
        'tNombre
        '
        Me.tNombre.Location = New System.Drawing.Point(113, 41)
        Me.tNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.tNombre.Name = "tNombre"
        Me.tNombre.Size = New System.Drawing.Size(159, 20)
        Me.tNombre.TabIndex = 10
        '
        'tAapellido
        '
        Me.tAapellido.Location = New System.Drawing.Point(113, 14)
        Me.tAapellido.Margin = New System.Windows.Forms.Padding(2)
        Me.tAapellido.Name = "tAapellido"
        Me.tAapellido.Size = New System.Drawing.Size(159, 20)
        Me.tAapellido.TabIndex = 9
        '
        'lMail
        '
        Me.lMail.AutoSize = True
        Me.lMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lMail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lMail.Location = New System.Drawing.Point(34, 115)
        Me.lMail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lMail.Name = "lMail"
        Me.lMail.Size = New System.Drawing.Size(56, 18)
        Me.lMail.TabIndex = 8
        Me.lMail.Text = "E-Mail"
        '
        'lTelefono
        '
        Me.lTelefono.AutoSize = True
        Me.lTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTelefono.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lTelefono.Location = New System.Drawing.Point(27, 91)
        Me.lTelefono.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lTelefono.Name = "lTelefono"
        Me.lTelefono.Size = New System.Drawing.Size(74, 18)
        Me.lTelefono.TabIndex = 7
        Me.lTelefono.Text = "Teléfono"
        '
        'LDNI
        '
        Me.LDNI.AutoSize = True
        Me.LDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDNI.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LDNI.Location = New System.Drawing.Point(45, 67)
        Me.LDNI.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LDNI.Name = "LDNI"
        Me.LDNI.Size = New System.Drawing.Size(36, 18)
        Me.LDNI.TabIndex = 2
        Me.LDNI.Text = "DNI"
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LNombre.Location = New System.Drawing.Point(33, 43)
        Me.LNombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(68, 18)
        Me.LNombre.TabIndex = 1
        Me.LNombre.Text = "Nombre"
        '
        'lApellido
        '
        Me.lApellido.AutoSize = True
        Me.lApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lApellido.ForeColor = System.Drawing.Color.Black
        Me.lApellido.Location = New System.Drawing.Point(34, 16)
        Me.lApellido.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lApellido.Name = "lApellido"
        Me.lApellido.Size = New System.Drawing.Size(67, 18)
        Me.lApellido.TabIndex = 0
        Me.lApellido.Text = "Apellido"
        '
        'pBotones
        '
        Me.pBotones.BackColor = System.Drawing.Color.Transparent
        Me.pBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pBotones.Controls.Add(Me.Label4)
        Me.pBotones.Controls.Add(Me.bEliminar)
        Me.pBotones.Controls.Add(Me.bAceptar)
        Me.pBotones.Controls.Add(Me.bNuevo)
        Me.pBotones.Cursor = System.Windows.Forms.Cursors.Default
        Me.pBotones.Location = New System.Drawing.Point(468, 390)
        Me.pBotones.Margin = New System.Windows.Forms.Padding(2)
        Me.pBotones.Name = "pBotones"
        Me.pBotones.Size = New System.Drawing.Size(435, 80)
        Me.pBotones.TabIndex = 5
        '
        'bEliminar
        '
        Me.bEliminar.BackColor = System.Drawing.Color.Transparent
        Me.bEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bEliminar.ForeColor = System.Drawing.Color.Black
        Me.bEliminar.Location = New System.Drawing.Point(318, 25)
        Me.bEliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.bEliminar.Name = "bEliminar"
        Me.bEliminar.Size = New System.Drawing.Size(104, 33)
        Me.bEliminar.TabIndex = 2
        Me.bEliminar.Text = "Eliminar"
        Me.bEliminar.UseVisualStyleBackColor = False
        '
        'bAceptar
        '
        Me.bAceptar.BackColor = System.Drawing.Color.Transparent
        Me.bAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAceptar.Location = New System.Drawing.Point(14, 25)
        Me.bAceptar.Margin = New System.Windows.Forms.Padding(2)
        Me.bAceptar.Name = "bAceptar"
        Me.bAceptar.Size = New System.Drawing.Size(153, 33)
        Me.bAceptar.TabIndex = 0
        Me.bAceptar.Text = "Aceptar  Cambios"
        Me.bAceptar.UseVisualStyleBackColor = False
        '
        'bNuevo
        '
        Me.bNuevo.BackColor = System.Drawing.Color.Transparent
        Me.bNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bNuevo.Location = New System.Drawing.Point(190, 25)
        Me.bNuevo.Margin = New System.Windows.Forms.Padding(2)
        Me.bNuevo.Name = "bNuevo"
        Me.bNuevo.Size = New System.Drawing.Size(105, 33)
        Me.bNuevo.TabIndex = 1
        Me.bNuevo.Text = "Nuevo"
        Me.bNuevo.UseVisualStyleBackColor = False
        '
        'lID
        '
        Me.lID.AutoSize = True
        Me.lID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lID.Location = New System.Drawing.Point(888, 71)
        Me.lID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lID.Name = "lID"
        Me.lID.Size = New System.Drawing.Size(15, 15)
        Me.lID.TabIndex = 6
        Me.lID.Text = "0"
        '
        'pBorrar
        '
        Me.pBorrar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pBorrar.BackColor = System.Drawing.Color.Transparent
        Me.pBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pBorrar.Image = CType(resources.GetObject("pBorrar.Image"), System.Drawing.Image)
        Me.pBorrar.Location = New System.Drawing.Point(243, 40)
        Me.pBorrar.Margin = New System.Windows.Forms.Padding(2)
        Me.pBorrar.Name = "pBorrar"
        Me.pBorrar.Size = New System.Drawing.Size(19, 20)
        Me.pBorrar.TabIndex = 7
        Me.pBorrar.TabStop = False
        '
        'bVolver
        '
        Me.bVolver.BackColor = System.Drawing.Color.Transparent
        Me.bVolver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bVolver.ForeColor = System.Drawing.Color.Black
        Me.bVolver.Location = New System.Drawing.Point(1, 544)
        Me.bVolver.Margin = New System.Windows.Forms.Padding(2)
        Me.bVolver.Name = "bVolver"
        Me.bVolver.Size = New System.Drawing.Size(128, 28)
        Me.bVolver.TabIndex = 8
        Me.bVolver.Text = "Volver al Menu"
        Me.bVolver.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(318, 472)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 15)
        Me.Label6.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(97, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(249, 15)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Click en nuevo para cargar su usuario"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(576, 513)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(327, 59)
        Me.Panel1.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(269, 39)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "para eliminar un cliente, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "toque sobre el nombre del cliente de la lista y " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "toq" &
    "ue el boton eliminar"
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gold
        Me.ClientSize = New System.Drawing.Size(957, 574)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.bVolver)
        Me.Controls.Add(Me.pBorrar)
        Me.Controls.Add(Me.lID)
        Me.Controls.Add(Me.pBotones)
        Me.Controls.Add(Me.pCampos)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.bBuscar)
        Me.Controls.Add(Me.tApellido)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pCampos.ResumeLayout(False)
        Me.pCampos.PerformLayout()
        Me.pBotones.ResumeLayout(False)
        Me.pBotones.PerformLayout()
        CType(Me.pBorrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tApellido As TextBox
    Friend WithEvents bBuscar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents pCampos As Panel
    Friend WithEvents tMail As TextBox
    Friend WithEvents tTelefono As TextBox
    Friend WithEvents tDNI As TextBox
    Friend WithEvents tNombre As TextBox
    Friend WithEvents tAapellido As TextBox
    Friend WithEvents lMail As Label
    Friend WithEvents lTelefono As Label
    Friend WithEvents LDNI As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents lApellido As Label
    Friend WithEvents pBotones As Panel
    Friend WithEvents bEliminar As Button
    Friend WithEvents bNuevo As Button
    Friend WithEvents bAceptar As Button
    Friend WithEvents lID As Label
    Friend WithEvents pBorrar As PictureBox
    Friend WithEvents bVolver As Button
    Friend WithEvents tContrasenia As TextBox
    Friend WithEvents tUsuario As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Ncli As DataGridViewTextBoxColumn
    Friend WithEvents apeynom As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
End Class
