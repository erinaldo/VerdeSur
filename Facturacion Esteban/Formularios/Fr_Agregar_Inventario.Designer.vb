<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fr_Agregar_Inventario
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fr_Agregar_Inventario))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_Codigo = New System.Windows.Forms.TextBox()
        Me.Txt_Descripcion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_Precio3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_Precio1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_Precio4 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txt_Precio2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.nud_Impuesto = New System.Windows.Forms.NumericUpDown()
        Me.lb_ImpuestoVentas = New System.Windows.Forms.Label()
        Me.Btn_Agregar = New System.Windows.Forms.Button()
        Me.Btn_Salir = New System.Windows.Forms.Button()
        Me.LV_Articulos = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txt_barcode = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.nud_Impuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo"
        '
        'Txt_Codigo
        '
        Me.Txt_Codigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Codigo.Location = New System.Drawing.Point(34, 34)
        Me.Txt_Codigo.MaxLength = 20
        Me.Txt_Codigo.Name = "Txt_Codigo"
        Me.Txt_Codigo.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Codigo.TabIndex = 0
        '
        'Txt_Descripcion
        '
        Me.Txt_Descripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Descripcion.Location = New System.Drawing.Point(167, 34)
        Me.Txt_Descripcion.MaxLength = 50
        Me.Txt_Descripcion.Name = "Txt_Descripcion"
        Me.Txt_Descripcion.Size = New System.Drawing.Size(270, 20)
        Me.Txt_Descripcion.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(164, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Descripcion"
        '
        'Txt_Precio3
        '
        Me.Txt_Precio3.Location = New System.Drawing.Point(78, 87)
        Me.Txt_Precio3.MaxLength = 12
        Me.Txt_Precio3.Name = "Txt_Precio3"
        Me.Txt_Precio3.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Precio3.TabIndex = 5
        Me.Txt_Precio3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Precio 3"
        '
        'Txt_Precio1
        '
        Me.Txt_Precio1.Location = New System.Drawing.Point(78, 61)
        Me.Txt_Precio1.MaxLength = 12
        Me.Txt_Precio1.Name = "Txt_Precio1"
        Me.Txt_Precio1.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Precio1.TabIndex = 3
        Me.Txt_Precio1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Precio 1"
        '
        'Txt_Precio4
        '
        Me.Txt_Precio4.Location = New System.Drawing.Point(287, 87)
        Me.Txt_Precio4.MaximumSize = New System.Drawing.Size(100, 20)
        Me.Txt_Precio4.MaxLength = 12
        Me.Txt_Precio4.Name = "Txt_Precio4"
        Me.Txt_Precio4.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Precio4.TabIndex = 6
        Me.Txt_Precio4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(195, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Precio Por Mayor"
        '
        'Txt_Precio2
        '
        Me.Txt_Precio2.Location = New System.Drawing.Point(287, 61)
        Me.Txt_Precio2.MaxLength = 12
        Me.Txt_Precio2.Name = "Txt_Precio2"
        Me.Txt_Precio2.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Precio2.TabIndex = 4
        Me.Txt_Precio2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(195, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Precio 2"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.nud_Impuesto)
        Me.GroupBox1.Controls.Add(Me.Txt_Precio1)
        Me.GroupBox1.Controls.Add(Me.lb_ImpuestoVentas)
        Me.GroupBox1.Controls.Add(Me.Txt_Precio4)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Txt_Precio2)
        Me.GroupBox1.Controls.Add(Me.Txt_Precio3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(34, 119)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(403, 120)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Precios"
        '
        'nud_Impuesto
        '
        Me.nud_Impuesto.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_Impuesto.Location = New System.Drawing.Point(152, 25)
        Me.nud_Impuesto.Name = "nud_Impuesto"
        Me.nud_Impuesto.Size = New System.Drawing.Size(77, 25)
        Me.nud_Impuesto.TabIndex = 12
        Me.nud_Impuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lb_ImpuestoVentas
        '
        Me.lb_ImpuestoVentas.AutoSize = True
        Me.lb_ImpuestoVentas.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_ImpuestoVentas.Location = New System.Drawing.Point(120, 27)
        Me.lb_ImpuestoVentas.Name = "lb_ImpuestoVentas"
        Me.lb_ImpuestoVentas.Size = New System.Drawing.Size(26, 17)
        Me.lb_ImpuestoVentas.TabIndex = 11
        Me.lb_ImpuestoVentas.Text = "IVA"
        '
        'Btn_Agregar
        '
        Me.Btn_Agregar.Location = New System.Drawing.Point(34, 245)
        Me.Btn_Agregar.Name = "Btn_Agregar"
        Me.Btn_Agregar.Size = New System.Drawing.Size(179, 35)
        Me.Btn_Agregar.TabIndex = 10
        Me.Btn_Agregar.Text = "Agregar"
        Me.Btn_Agregar.UseVisualStyleBackColor = True
        '
        'Btn_Salir
        '
        Me.Btn_Salir.Location = New System.Drawing.Point(233, 245)
        Me.Btn_Salir.Name = "Btn_Salir"
        Me.Btn_Salir.Size = New System.Drawing.Size(204, 35)
        Me.Btn_Salir.TabIndex = 11
        Me.Btn_Salir.Text = "Salir"
        Me.Btn_Salir.UseVisualStyleBackColor = True
        '
        'LV_Articulos
        '
        Me.LV_Articulos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.LV_Articulos.GridLines = True
        Me.LV_Articulos.Location = New System.Drawing.Point(12, 286)
        Me.LV_Articulos.Name = "LV_Articulos"
        Me.LV_Articulos.Size = New System.Drawing.Size(543, 168)
        Me.LV_Articulos.TabIndex = 12
        Me.LV_Articulos.UseCompatibleStateImageBehavior = False
        Me.LV_Articulos.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Codigo"
        Me.ColumnHeader1.Width = 120
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Descripcion"
        Me.ColumnHeader2.Width = 221
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Precio Sugerido"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader3.Width = 89
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Precio Por Mayor"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 102
        '
        'txt_barcode
        '
        Me.txt_barcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_barcode.Location = New System.Drawing.Point(114, 90)
        Me.txt_barcode.MaxLength = 50
        Me.txt_barcode.Name = "txt_barcode"
        Me.txt_barcode.Size = New System.Drawing.Size(270, 20)
        Me.txt_barcode.TabIndex = 2
        Me.txt_barcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(230, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Barcode"
        '
        'Fr_Agregar_Inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(572, 466)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_barcode)
        Me.Controls.Add(Me.LV_Articulos)
        Me.Controls.Add(Me.Btn_Salir)
        Me.Controls.Add(Me.Btn_Agregar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Txt_Descripcion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txt_Codigo)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(588, 800)
        Me.MinimumSize = New System.Drawing.Size(588, 440)
        Me.Name = "Fr_Agregar_Inventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso Inventario"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nud_Impuesto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txt_Codigo As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Descripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txt_Precio3 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Txt_Precio1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Txt_Precio4 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Txt_Precio2 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents Btn_Salir As System.Windows.Forms.Button
    Friend WithEvents LV_Articulos As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txt_barcode As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents nud_Impuesto As NumericUpDown
    Friend WithEvents lb_ImpuestoVentas As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
