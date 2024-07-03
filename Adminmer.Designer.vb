<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class adminmer
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
        Me.pCampos = New System.Windows.Forms.Panel()
        Me.tPrecio = New System.Windows.Forms.TextBox()
        Me.tCantidad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tTipo = New System.Windows.Forms.TextBox()
        Me.tMercaderia = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pBotones = New System.Windows.Forms.Panel()
        Me.bEliminar = New System.Windows.Forms.Button()
        Me.bAceptar = New System.Windows.Forms.Button()
        Me.bNuevo = New System.Windows.Forms.Button()
        Me.bVolver = New System.Windows.Forms.Button()
        Me.lID2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.bBuscar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tMeercaderia = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Nmer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mercaderia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pCampos.SuspendLayout()
        Me.pBotones.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pCampos
        '
        Me.pCampos.BackColor = System.Drawing.Color.Transparent
        Me.pCampos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pCampos.Controls.Add(Me.tPrecio)
        Me.pCampos.Controls.Add(Me.tCantidad)
        Me.pCampos.Controls.Add(Me.Label5)
        Me.pCampos.Controls.Add(Me.Label4)
        Me.pCampos.Controls.Add(Me.tTipo)
        Me.pCampos.Controls.Add(Me.tMercaderia)
        Me.pCampos.Controls.Add(Me.Label3)
        Me.pCampos.Controls.Add(Me.Label2)
        Me.pCampos.Location = New System.Drawing.Point(470, 66)
        Me.pCampos.Margin = New System.Windows.Forms.Padding(2)
        Me.pCampos.Name = "pCampos"
        Me.pCampos.Size = New System.Drawing.Size(435, 337)
        Me.pCampos.TabIndex = 4
        '
        'tPrecio
        '
        Me.tPrecio.Location = New System.Drawing.Point(161, 195)
        Me.tPrecio.Name = "tPrecio"
        Me.tPrecio.Size = New System.Drawing.Size(158, 20)
        Me.tPrecio.TabIndex = 25
        '
        'tCantidad
        '
        Me.tCantidad.Location = New System.Drawing.Point(160, 168)
        Me.tCantidad.Name = "tCantidad"
        Me.tCantidad.Size = New System.Drawing.Size(158, 20)
        Me.tCantidad.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(46, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 18)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Precio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(46, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 18)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Cantidad"
        '
        'tTipo
        '
        Me.tTipo.Location = New System.Drawing.Point(160, 142)
        Me.tTipo.Name = "tTipo"
        Me.tTipo.Size = New System.Drawing.Size(159, 20)
        Me.tTipo.TabIndex = 21
        '
        'tMercaderia
        '
        Me.tMercaderia.Location = New System.Drawing.Point(160, 114)
        Me.tMercaderia.Name = "tMercaderia"
        Me.tMercaderia.Size = New System.Drawing.Size(159, 20)
        Me.tMercaderia.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(46, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 18)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Producto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(46, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 18)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Tipo"
        '
        'pBotones
        '
        Me.pBotones.BackColor = System.Drawing.Color.Transparent
        Me.pBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pBotones.Controls.Add(Me.Label7)
        Me.pBotones.Controls.Add(Me.bEliminar)
        Me.pBotones.Controls.Add(Me.bAceptar)
        Me.pBotones.Controls.Add(Me.bNuevo)
        Me.pBotones.Cursor = System.Windows.Forms.Cursors.Default
        Me.pBotones.Location = New System.Drawing.Point(470, 407)
        Me.pBotones.Margin = New System.Windows.Forms.Padding(2)
        Me.pBotones.Name = "pBotones"
        Me.pBotones.Size = New System.Drawing.Size(435, 80)
        Me.pBotones.TabIndex = 5
        '
        'bEliminar
        '
        Me.bEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bEliminar.Location = New System.Drawing.Point(319, 25)
        Me.bEliminar.Name = "bEliminar"
        Me.bEliminar.Size = New System.Drawing.Size(111, 33)
        Me.bEliminar.TabIndex = 2
        Me.bEliminar.Text = "Eliminar"
        Me.bEliminar.UseVisualStyleBackColor = True
        '
        'bAceptar
        '
        Me.bAceptar.BackColor = System.Drawing.Color.Transparent
        Me.bAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAceptar.Location = New System.Drawing.Point(2, 25)
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
        Me.bNuevo.Location = New System.Drawing.Point(174, 25)
        Me.bNuevo.Margin = New System.Windows.Forms.Padding(2)
        Me.bNuevo.Name = "bNuevo"
        Me.bNuevo.Size = New System.Drawing.Size(122, 33)
        Me.bNuevo.TabIndex = 1
        Me.bNuevo.Text = "Nuevo"
        Me.bNuevo.UseVisualStyleBackColor = False
        '
        'bVolver
        '
        Me.bVolver.BackColor = System.Drawing.Color.Transparent
        Me.bVolver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bVolver.ForeColor = System.Drawing.Color.Black
        Me.bVolver.Location = New System.Drawing.Point(2, 544)
        Me.bVolver.Margin = New System.Windows.Forms.Padding(2)
        Me.bVolver.Name = "bVolver"
        Me.bVolver.Size = New System.Drawing.Size(128, 28)
        Me.bVolver.TabIndex = 8
        Me.bVolver.Text = "Volver al Menu"
        Me.bVolver.UseVisualStyleBackColor = False
        '
        'lID2
        '
        Me.lID2.AutoSize = True
        Me.lID2.Location = New System.Drawing.Point(892, 51)
        Me.lID2.Name = "lID2"
        Me.lID2.Size = New System.Drawing.Size(13, 13)
        Me.lID2.TabIndex = 9
        Me.lID2.Text = "0"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nmer, Me.mercaderia, Me.tipo, Me.Cantidad, Me.Precio})
        Me.DataGridView1.Location = New System.Drawing.Point(2, 66)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(443, 299)
        Me.DataGridView1.TabIndex = 10
        '
        'bBuscar
        '
        Me.bBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bBuscar.Location = New System.Drawing.Point(538, 19)
        Me.bBuscar.Name = "bBuscar"
        Me.bBuscar.Size = New System.Drawing.Size(88, 27)
        Me.bBuscar.TabIndex = 12
        Me.bBuscar.Text = "Buscar"
        Me.bBuscar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(314, 501)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 15)
        Me.Label6.TabIndex = 15
        '
        'tMeercaderia
        '
        Me.tMeercaderia.Location = New System.Drawing.Point(283, 24)
        Me.tMeercaderia.Name = "tMeercaderia"
        Me.tMeercaderia.Size = New System.Drawing.Size(232, 20)
        Me.tMeercaderia.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(24, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 17)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Buscar por nombre del producto"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(111, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(249, 15)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Click en nuevo para cargar su usuario"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(578, 513)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(327, 59)
        Me.Panel1.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(22, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(281, 39)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "para eliminar un producto, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "toque sobre el nombre del producto de la lista y " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "t" &
    "oque el boton eliminar"
        '
        'Nmer
        '
        Me.Nmer.DataPropertyName = "Nmer"
        Me.Nmer.HeaderText = "Nmer"
        Me.Nmer.Name = "Nmer"
        Me.Nmer.Visible = False
        '
        'mercaderia
        '
        Me.mercaderia.DataPropertyName = "mercaderia"
        Me.mercaderia.HeaderText = "Producto"
        Me.mercaderia.Name = "mercaderia"
        Me.mercaderia.ReadOnly = True
        '
        'tipo
        '
        Me.tipo.DataPropertyName = "tipo"
        Me.tipo.HeaderText = "Tipo"
        Me.tipo.Name = "tipo"
        Me.tipo.ReadOnly = True
        '
        'Cantidad
        '
        Me.Cantidad.DataPropertyName = "Cantidad"
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        '
        'Precio
        '
        Me.Precio.DataPropertyName = "Precio"
        Me.Precio.HeaderText = "Precio por uni."
        Me.Precio.Name = "Precio"
        '
        'adminmer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gold
        Me.ClientSize = New System.Drawing.Size(957, 574)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tMeercaderia)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.bBuscar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lID2)
        Me.Controls.Add(Me.bVolver)
        Me.Controls.Add(Me.pBotones)
        Me.Controls.Add(Me.pCampos)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "adminmer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productos"
        Me.pCampos.ResumeLayout(False)
        Me.pCampos.PerformLayout()
        Me.pBotones.ResumeLayout(False)
        Me.pBotones.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pCampos As Panel
    Friend WithEvents pBotones As Panel
    Friend WithEvents bNuevo As Button
    Friend WithEvents bAceptar As Button
    Friend WithEvents bVolver As Button
    Friend WithEvents tTipo As TextBox
    Friend WithEvents tMercaderia As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lID2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents tPrecio As TextBox
    Friend WithEvents tCantidad As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents bBuscar As Button
    Friend WithEvents bEliminar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents tMeercaderia As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Nmer As DataGridViewTextBoxColumn
    Friend WithEvents mercaderia As DataGridViewTextBoxColumn
    Friend WithEvents tipo As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
End Class
