<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fr_Busca_Cliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fr_Busca_Cliente))
        Me.LV_Clientes = New System.Windows.Forms.ListView()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Txt_Busqueda_Nombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txt_Busqueda_Id = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Btn_Seleccionar_Cliente = New System.Windows.Forms.Button()
        Me.Btn_Salir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LV_Clientes
        '
        Me.LV_Clientes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7})
        Me.LV_Clientes.GridLines = True
        Me.LV_Clientes.Location = New System.Drawing.Point(4, 63)
        Me.LV_Clientes.Name = "LV_Clientes"
        Me.LV_Clientes.Size = New System.Drawing.Size(478, 204)
        Me.LV_Clientes.TabIndex = 3
        Me.LV_Clientes.UseCompatibleStateImageBehavior = False
        Me.LV_Clientes.View = System.Windows.Forms.View.Details
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
        'Txt_Busqueda_Nombre
        '
        Me.Txt_Busqueda_Nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Busqueda_Nombre.Location = New System.Drawing.Point(228, 37)
        Me.Txt_Busqueda_Nombre.MaxLength = 100
        Me.Txt_Busqueda_Nombre.Name = "Txt_Busqueda_Nombre"
        Me.Txt_Busqueda_Nombre.Size = New System.Drawing.Size(116, 20)
        Me.Txt_Busqueda_Nombre.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(228, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Busqueda por Nombre"
        '
        'Txt_Busqueda_Id
        '
        Me.Txt_Busqueda_Id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Busqueda_Id.Location = New System.Drawing.Point(85, 37)
        Me.Txt_Busqueda_Id.MaxLength = 20
        Me.Txt_Busqueda_Id.Name = "Txt_Busqueda_Id"
        Me.Txt_Busqueda_Id.Size = New System.Drawing.Size(116, 20)
        Me.Txt_Busqueda_Id.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(85, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Busqueda por Codigo:"
        '
        'Btn_Seleccionar_Cliente
        '
        Me.Btn_Seleccionar_Cliente.Location = New System.Drawing.Point(4, 273)
        Me.Btn_Seleccionar_Cliente.Name = "Btn_Seleccionar_Cliente"
        Me.Btn_Seleccionar_Cliente.Size = New System.Drawing.Size(478, 30)
        Me.Btn_Seleccionar_Cliente.TabIndex = 4
        Me.Btn_Seleccionar_Cliente.Text = "Seleccinar Cliente"
        Me.Btn_Seleccionar_Cliente.UseVisualStyleBackColor = True
        '
        'Btn_Salir
        '
        Me.Btn_Salir.Location = New System.Drawing.Point(4, 303)
        Me.Btn_Salir.Name = "Btn_Salir"
        Me.Btn_Salir.Size = New System.Drawing.Size(478, 30)
        Me.Btn_Salir.TabIndex = 5
        Me.Btn_Salir.Text = "Salir"
        Me.Btn_Salir.UseVisualStyleBackColor = True
        '
        'Fr_Busca_Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 335)
        Me.ControlBox = False
        Me.Controls.Add(Me.Btn_Salir)
        Me.Controls.Add(Me.Btn_Seleccionar_Cliente)
        Me.Controls.Add(Me.Txt_Busqueda_Nombre)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Txt_Busqueda_Id)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LV_Clientes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(504, 374)
        Me.MinimumSize = New System.Drawing.Size(504, 374)
        Me.Name = "Fr_Busca_Cliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Cliente"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LV_Clientes As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Txt_Busqueda_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Txt_Busqueda_Id As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Btn_Seleccionar_Cliente As System.Windows.Forms.Button
    Friend WithEvents Btn_Salir As System.Windows.Forms.Button
End Class
