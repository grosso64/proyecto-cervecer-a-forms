<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        Me.lMenu = New System.Windows.Forms.Label()
        Me.bClientes = New System.Windows.Forms.Button()
        Me.bProveedores = New System.Windows.Forms.Button()
        Me.bSalir = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lMenu
        '
        Me.lMenu.AutoSize = True
        Me.lMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lMenu.Location = New System.Drawing.Point(227, 107)
        Me.lMenu.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lMenu.Name = "lMenu"
        Me.lMenu.Size = New System.Drawing.Size(0, 20)
        Me.lMenu.TabIndex = 0
        '
        'bClientes
        '
        Me.bClientes.BackColor = System.Drawing.Color.Gold
        Me.bClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bClientes.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bClientes.ForeColor = System.Drawing.Color.Black
        Me.bClientes.Location = New System.Drawing.Point(97, 206)
        Me.bClientes.Margin = New System.Windows.Forms.Padding(2)
        Me.bClientes.Name = "bClientes"
        Me.bClientes.Size = New System.Drawing.Size(159, 61)
        Me.bClientes.TabIndex = 1
        Me.bClientes.Text = "Clientes"
        Me.bClientes.UseVisualStyleBackColor = False
        '
        'bProveedores
        '
        Me.bProveedores.BackColor = System.Drawing.Color.Gold
        Me.bProveedores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bProveedores.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bProveedores.ForeColor = System.Drawing.Color.Black
        Me.bProveedores.Location = New System.Drawing.Point(97, 131)
        Me.bProveedores.Margin = New System.Windows.Forms.Padding(2)
        Me.bProveedores.Name = "bProveedores"
        Me.bProveedores.Size = New System.Drawing.Size(159, 61)
        Me.bProveedores.TabIndex = 2
        Me.bProveedores.Text = "Proveedores"
        Me.bProveedores.UseVisualStyleBackColor = False
        '
        'bSalir
        '
        Me.bSalir.BackColor = System.Drawing.Color.Gold
        Me.bSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bSalir.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bSalir.ForeColor = System.Drawing.Color.Black
        Me.bSalir.Location = New System.Drawing.Point(0, 488)
        Me.bSalir.Margin = New System.Windows.Forms.Padding(2)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(98, 36)
        Me.bSalir.TabIndex = 3
        Me.bSalir.Text = "Salir"
        Me.bSalir.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gold
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(97, 52)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(159, 61)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Administrador"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.bProveedores)
        Me.Panel1.Controls.Add(Me.bClientes)
        Me.Panel1.Location = New System.Drawing.Point(255, 107)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(350, 331)
        Me.Panel1.TabIndex = 5
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(941, 535)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.bSalir)
        Me.Controls.Add(Me.lMenu)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lMenu As Label
    Friend WithEvents bClientes As Button
    Friend WithEvents bProveedores As Button
    Friend WithEvents bSalir As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
End Class
