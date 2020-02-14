<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fr_Detalle_Clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fr_Detalle_Clientes))
        Me.Lv_Clientes = New System.Windows.Forms.ListView()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Btn_Añadir = New System.Windows.Forms.Button()
        Me.Btn_Actualizar = New System.Windows.Forms.Button()
        Me.Btn_Eliminar = New System.Windows.Forms.Button()
        Me.Txt_Busqueda_Nombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txt_Busqueda_Id = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Btn_Salir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lv_Clientes
        '
        Me.Lv_Clientes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7})
        Me.Lv_Clientes.FullRowSelect = True
        Me.Lv_Clientes.GridLines = True
        Me.Lv_Clientes.Location = New System.Drawing.Point(60, 12)
        Me.Lv_Clientes.Name = "Lv_Clientes"
        Me.Lv_Clientes.Size = New System.Drawing.Size(478, 204)
        Me.Lv_Clientes.TabIndex = 11
        Me.Lv_Clientes.UseCompatibleStateImageBehavior = False
        Me.Lv_Clientes.View = System.Windows.Forms.View.Details
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
        'Btn_Añadir
        '
        Me.Btn_Añadir.Location = New System.Drawing.Point(60, 286)
        Me.Btn_Añadir.Name = "Btn_Añadir"
        Me.Btn_Añadir.Size = New System.Drawing.Size(119, 41)
        Me.Btn_Añadir.TabIndex = 12
        Me.Btn_Añadir.Text = "Añadir"
        Me.Btn_Añadir.UseVisualStyleBackColor = True
        '
        'Btn_Actualizar
        '
        Me.Btn_Actualizar.Location = New System.Drawing.Point(185, 286)
        Me.Btn_Actualizar.Name = "Btn_Actualizar"
        Me.Btn_Actualizar.Size = New System.Drawing.Size(119, 41)
        Me.Btn_Actualizar.TabIndex = 13
        Me.Btn_Actualizar.Text = "Actualizar"
        Me.Btn_Actualizar.UseVisualStyleBackColor = True
        '
        'Btn_Eliminar
        '
        Me.Btn_Eliminar.Location = New System.Drawing.Point(310, 286)
        Me.Btn_Eliminar.Name = "Btn_Eliminar"
        Me.Btn_Eliminar.Size = New System.Drawing.Size(119, 41)
        Me.Btn_Eliminar.TabIndex = 14
        Me.Btn_Eliminar.Text = "Eliminar"
        Me.Btn_Eliminar.UseVisualStyleBackColor = True
        '
        'Txt_Busqueda_Nombre
        '
        Me.Txt_Busqueda_Nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Busqueda_Nombre.Location = New System.Drawing.Point(296, 248)
        Me.Txt_Busqueda_Nombre.MaxLength = 100
        Me.Txt_Busqueda_Nombre.Name = "Txt_Busqueda_Nombre"
        Me.Txt_Busqueda_Nombre.Size = New System.Drawing.Size(160, 20)
        Me.Txt_Busqueda_Nombre.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(296, 232)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Busqueda por Nombre"
        '
        'Txt_Busqueda_Id
        '
        Me.Txt_Busqueda_Id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Busqueda_Id.Location = New System.Drawing.Point(153, 248)
        Me.Txt_Busqueda_Id.Name = "Txt_Busqueda_Id"
        Me.Txt_Busqueda_Id.Size = New System.Drawing.Size(116, 20)
        Me.Txt_Busqueda_Id.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(153, 232)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Busqueda por Codigo:"
        '
        'Btn_Salir
        '
        Me.Btn_Salir.Location = New System.Drawing.Point(435, 286)
        Me.Btn_Salir.Name = "Btn_Salir"
        Me.Btn_Salir.Size = New System.Drawing.Size(119, 41)
        Me.Btn_Salir.TabIndex = 19
        Me.Btn_Salir.Text = "Salir"
        Me.Btn_Salir.UseVisualStyleBackColor = True
        '
        'Fr_Detalle_Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 351)
        Me.ControlBox = False
        Me.Controls.Add(Me.Btn_Salir)
        Me.Controls.Add(Me.Txt_Busqueda_Nombre)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Txt_Busqueda_Id)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Btn_Eliminar)
        Me.Controls.Add(Me.Btn_Actualizar)
        Me.Controls.Add(Me.Btn_Añadir)
        Me.Controls.Add(Me.Lv_Clientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(647, 390)
        Me.Name = "Fr_Detalle_Clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalles Clientes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lv_Clientes As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Btn_Añadir As System.Windows.Forms.Button
    Friend WithEvents Btn_Actualizar As System.Windows.Forms.Button
    Friend WithEvents Btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents Txt_Busqueda_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Txt_Busqueda_Id As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Btn_Salir As System.Windows.Forms.Button
End Class
