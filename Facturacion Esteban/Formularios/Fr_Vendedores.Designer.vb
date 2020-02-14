<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fr_Vendedores
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fr_Vendedores))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_Codigo = New System.Windows.Forms.TextBox()
        Me.Btn_Salir = New System.Windows.Forms.Button()
        Me.Txt_Nombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_Agregar = New System.Windows.Forms.Button()
        Me.Lv_Vendedores = New System.Windows.Forms.ListView()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo"
        '
        'Txt_Codigo
        '
        Me.Txt_Codigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Codigo.Location = New System.Drawing.Point(108, 38)
        Me.Txt_Codigo.Name = "Txt_Codigo"
        Me.Txt_Codigo.Size = New System.Drawing.Size(149, 20)
        Me.Txt_Codigo.TabIndex = 1
        '
        'Btn_Salir
        '
        Me.Btn_Salir.Location = New System.Drawing.Point(108, 124)
        Me.Btn_Salir.Name = "Btn_Salir"
        Me.Btn_Salir.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Salir.TabIndex = 2
        Me.Btn_Salir.Text = "Salir"
        Me.Btn_Salir.UseVisualStyleBackColor = True
        '
        'Txt_Nombre
        '
        Me.Txt_Nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Nombre.Location = New System.Drawing.Point(108, 80)
        Me.Txt_Nombre.Name = "Txt_Nombre"
        Me.Txt_Nombre.Size = New System.Drawing.Size(149, 20)
        Me.Txt_Nombre.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre"
        '
        'Btn_Agregar
        '
        Me.Btn_Agregar.Location = New System.Drawing.Point(206, 124)
        Me.Btn_Agregar.Name = "Btn_Agregar"
        Me.Btn_Agregar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Agregar.TabIndex = 5
        Me.Btn_Agregar.Text = "Agregar"
        Me.Btn_Agregar.UseVisualStyleBackColor = True
        '
        'Lv_Vendedores
        '
        Me.Lv_Vendedores.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7})
        Me.Lv_Vendedores.FullRowSelect = True
        Me.Lv_Vendedores.GridLines = True
        Me.Lv_Vendedores.Location = New System.Drawing.Point(12, 153)
        Me.Lv_Vendedores.Name = "Lv_Vendedores"
        Me.Lv_Vendedores.Size = New System.Drawing.Size(478, 204)
        Me.Lv_Vendedores.TabIndex = 11
        Me.Lv_Vendedores.UseCompatibleStateImageBehavior = False
        Me.Lv_Vendedores.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Codigo"
        Me.ColumnHeader6.Width = 99
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Nombre"
        Me.ColumnHeader7.Width = 372
        '
        'Fr_Vendedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 367)
        Me.ControlBox = False
        Me.Controls.Add(Me.Lv_Vendedores)
        Me.Controls.Add(Me.Btn_Agregar)
        Me.Controls.Add(Me.Txt_Nombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Btn_Salir)
        Me.Controls.Add(Me.Txt_Codigo)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(558, 462)
        Me.Name = "Fr_Vendedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vendedores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txt_Codigo As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Salir As System.Windows.Forms.Button
    Friend WithEvents Txt_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents Lv_Vendedores As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
End Class
