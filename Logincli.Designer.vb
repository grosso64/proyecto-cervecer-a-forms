<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Logincli
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
        Me.bIngresar = New System.Windows.Forms.Button()
        Me.lUsuario = New System.Windows.Forms.Label()
        Me.lContrasenia = New System.Windows.Forms.Label()
        Me.tUsuario = New System.Windows.Forms.TextBox()
        Me.tContrasenia = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bIngresar
        '
        Me.bIngresar.BackColor = System.Drawing.Color.Transparent
        Me.bIngresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bIngresar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bIngresar.Location = New System.Drawing.Point(274, 266)
        Me.bIngresar.Margin = New System.Windows.Forms.Padding(2)
        Me.bIngresar.Name = "bIngresar"
        Me.bIngresar.Size = New System.Drawing.Size(101, 33)
        Me.bIngresar.TabIndex = 0
        Me.bIngresar.Text = "Ingresar"
        Me.bIngresar.UseVisualStyleBackColor = False
        '
        'lUsuario
        '
        Me.lUsuario.AutoSize = True
        Me.lUsuario.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lUsuario.Location = New System.Drawing.Point(181, 180)
        Me.lUsuario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lUsuario.Name = "lUsuario"
        Me.lUsuario.Size = New System.Drawing.Size(69, 19)
        Me.lUsuario.TabIndex = 2
        Me.lUsuario.Text = "Usuario"
        '
        'lContrasenia
        '
        Me.lContrasenia.AutoSize = True
        Me.lContrasenia.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lContrasenia.Location = New System.Drawing.Point(154, 226)
        Me.lContrasenia.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lContrasenia.Name = "lContrasenia"
        Me.lContrasenia.Size = New System.Drawing.Size(98, 19)
        Me.lContrasenia.TabIndex = 3
        Me.lContrasenia.Text = "Contraseña"
        '
        'tUsuario
        '
        Me.tUsuario.BackColor = System.Drawing.Color.White
        Me.tUsuario.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tUsuario.Location = New System.Drawing.Point(263, 180)
        Me.tUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.tUsuario.Name = "tUsuario"
        Me.tUsuario.Size = New System.Drawing.Size(131, 22)
        Me.tUsuario.TabIndex = 4
        '
        'tContrasenia
        '
        Me.tContrasenia.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tContrasenia.Location = New System.Drawing.Point(263, 223)
        Me.tContrasenia.Margin = New System.Windows.Forms.Padding(2)
        Me.tContrasenia.Name = "tContrasenia"
        Me.tContrasenia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tContrasenia.Size = New System.Drawing.Size(131, 22)
        Me.tContrasenia.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(138, 120)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(400, 22)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Porfavor ingrese su Usuario y Contraseña"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gold
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(3, 368)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 31)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Logincli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gold
        Me.ClientSize = New System.Drawing.Size(663, 400)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tContrasenia)
        Me.Controls.Add(Me.tUsuario)
        Me.Controls.Add(Me.lContrasenia)
        Me.Controls.Add(Me.lUsuario)
        Me.Controls.Add(Me.bIngresar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Logincli"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bIngresar As Button
    Friend WithEvents lUsuario As Label
    Friend WithEvents lContrasenia As Label
    Friend WithEvents tUsuario As TextBox
    Friend WithEvents tContrasenia As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
End Class