<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fr_Detalle_Articulos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fr_Detalle_Articulos))
        Me.Txt_Busqueda_Nombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Btn_Eliminar = New System.Windows.Forms.Button()
        Me.Btn_Actualizar = New System.Windows.Forms.Button()
        Me.Btn_Añadir = New System.Windows.Forms.Button()
        Me.Lv_Detalles = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Btn_Salir = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txt_Busqueda_Id = New System.Windows.Forms.TextBox()
        Me.txt_barcode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Txt_Busqueda_Nombre
        '
        Me.Txt_Busqueda_Nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Busqueda_Nombre.Location = New System.Drawing.Point(24, 332)
        Me.Txt_Busqueda_Nombre.MaxLength = 50
        Me.Txt_Busqueda_Nombre.Name = "Txt_Busqueda_Nombre"
        Me.Txt_Busqueda_Nombre.Size = New System.Drawing.Size(235, 20)
        Me.Txt_Busqueda_Nombre.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 316)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Busqueda por Nombre"
        '
        'Btn_Eliminar
        '
        Me.Btn_Eliminar.Location = New System.Drawing.Point(443, 378)
        Me.Btn_Eliminar.Name = "Btn_Eliminar"
        Me.Btn_Eliminar.Size = New System.Drawing.Size(119, 41)
        Me.Btn_Eliminar.TabIndex = 6
        Me.Btn_Eliminar.Text = "Eliminar"
        Me.Btn_Eliminar.UseVisualStyleBackColor = True
        '
        'Btn_Actualizar
        '
        Me.Btn_Actualizar.Location = New System.Drawing.Point(318, 378)
        Me.Btn_Actualizar.Name = "Btn_Actualizar"
        Me.Btn_Actualizar.Size = New System.Drawing.Size(119, 41)
        Me.Btn_Actualizar.TabIndex = 5
        Me.Btn_Actualizar.Text = "Actualizar"
        Me.Btn_Actualizar.UseVisualStyleBackColor = True
        '
        'Btn_Añadir
        '
        Me.Btn_Añadir.Location = New System.Drawing.Point(193, 378)
        Me.Btn_Añadir.Name = "Btn_Añadir"
        Me.Btn_Añadir.Size = New System.Drawing.Size(119, 41)
        Me.Btn_Añadir.TabIndex = 4
        Me.Btn_Añadir.Text = "Añadir"
        Me.Btn_Añadir.UseVisualStyleBackColor = True
        '
        'Lv_Detalles
        '
        Me.Lv_Detalles.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader5, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.Lv_Detalles.FullRowSelect = True
        Me.Lv_Detalles.GridLines = True
        Me.Lv_Detalles.Location = New System.Drawing.Point(12, 12)
        Me.Lv_Detalles.Name = "Lv_Detalles"
        Me.Lv_Detalles.Size = New System.Drawing.Size(860, 274)
        Me.Lv_Detalles.TabIndex = 1
        Me.Lv_Detalles.UseCompatibleStateImageBehavior = False
        Me.Lv_Detalles.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Codigo"
        Me.ColumnHeader1.Width = 120
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "BARCODE"
        Me.ColumnHeader5.Width = 150
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Descripcion"
        Me.ColumnHeader2.Width = 350
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Precio Sugerido"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader3.Width = 97
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Precio Por Mayor"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 111
        '
        'Btn_Salir
        '
        Me.Btn_Salir.Location = New System.Drawing.Point(568, 378)
        Me.Btn_Salir.Name = "Btn_Salir"
        Me.Btn_Salir.Size = New System.Drawing.Size(119, 41)
        Me.Btn_Salir.TabIndex = 7
        Me.Btn_Salir.Text = "Salir"
        Me.Btn_Salir.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(342, 316)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Busqueda por Codigo:"
        '
        'Txt_Busqueda_Id
        '
        Me.Txt_Busqueda_Id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Busqueda_Id.Location = New System.Drawing.Point(345, 332)
        Me.Txt_Busqueda_Id.MaxLength = 20
        Me.Txt_Busqueda_Id.Name = "Txt_Busqueda_Id"
        Me.Txt_Busqueda_Id.Size = New System.Drawing.Size(217, 20)
        Me.Txt_Busqueda_Id.TabIndex = 3
        '
        'txt_barcode
        '
        Me.txt_barcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_barcode.Location = New System.Drawing.Point(636, 332)
        Me.txt_barcode.MaxLength = 50
        Me.txt_barcode.Name = "txt_barcode"
        Me.txt_barcode.Size = New System.Drawing.Size(217, 20)
        Me.txt_barcode.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(633, 316)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Busqueda por Barcode:"
        '
        'Fr_Detalle_Articulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 456)
        Me.ControlBox = False
        Me.Controls.Add(Me.txt_barcode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_Salir)
        Me.Controls.Add(Me.Lv_Detalles)
        Me.Controls.Add(Me.Txt_Busqueda_Nombre)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Txt_Busqueda_Id)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Btn_Eliminar)
        Me.Controls.Add(Me.Btn_Actualizar)
        Me.Controls.Add(Me.Btn_Añadir)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(900, 500)
        Me.MinimumSize = New System.Drawing.Size(900, 472)
        Me.Name = "Fr_Detalle_Articulos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Articulos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txt_Busqueda_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents Btn_Actualizar As System.Windows.Forms.Button
    Friend WithEvents Btn_Añadir As System.Windows.Forms.Button
    Friend WithEvents Lv_Detalles As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Btn_Salir As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents Label6 As Label
    Friend WithEvents Txt_Busqueda_Id As TextBox
    Friend WithEvents txt_barcode As TextBox
    Friend WithEvents Label1 As Label
End Class
