<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fr_historial_productos_vendidos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Dtp_Fecha_inicio = New System.Windows.Forms.DateTimePicker()
        Me.Dtp_Fecha_fin = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_producto = New System.Windows.Forms.TextBox()
        Me.lb_filtro = New System.Windows.Forms.Label()
        Me.txt_cantidad = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_busqueda = New System.Windows.Forms.Button()
        Me.lb_estado = New System.Windows.Forms.Label()
        Me.MepDataGridView1 = New Facturacion_Esteban.MEPDataGridView()
        Me.c_nro_factura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_clientes = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.MepDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dtp_Fecha_inicio
        '
        Me.Dtp_Fecha_inicio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dtp_Fecha_inicio.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_Fecha_inicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_Fecha_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Dtp_Fecha_inicio.Location = New System.Drawing.Point(803, 60)
        Me.Dtp_Fecha_inicio.Name = "Dtp_Fecha_inicio"
        Me.Dtp_Fecha_inicio.Size = New System.Drawing.Size(120, 22)
        Me.Dtp_Fecha_inicio.TabIndex = 1
        Me.Dtp_Fecha_inicio.Value = New Date(2018, 1, 12, 0, 0, 0, 0)
        '
        'Dtp_Fecha_fin
        '
        Me.Dtp_Fecha_fin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dtp_Fecha_fin.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_Fecha_fin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_Fecha_fin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Dtp_Fecha_fin.Location = New System.Drawing.Point(955, 60)
        Me.Dtp_Fecha_fin.Name = "Dtp_Fecha_fin"
        Me.Dtp_Fecha_fin.Size = New System.Drawing.Size(120, 22)
        Me.Dtp_Fecha_fin.TabIndex = 2
        Me.Dtp_Fecha_fin.Value = New Date(2018, 1, 12, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(768, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "De:"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(929, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "A:"
        '
        'txt_producto
        '
        Me.txt_producto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_producto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_producto.Location = New System.Drawing.Point(12, 59)
        Me.txt_producto.Name = "txt_producto"
        Me.txt_producto.Size = New System.Drawing.Size(243, 22)
        Me.txt_producto.TabIndex = 5
        '
        'lb_filtro
        '
        Me.lb_filtro.AutoSize = True
        Me.lb_filtro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_filtro.Location = New System.Drawing.Point(12, 40)
        Me.lb_filtro.Name = "lb_filtro"
        Me.lb_filtro.Size = New System.Drawing.Size(120, 16)
        Me.lb_filtro.TabIndex = 6
        Me.lb_filtro.Text = "Filtro de Productos"
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_cantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cantidad.ForeColor = System.Drawing.Color.Blue
        Me.txt_cantidad.Location = New System.Drawing.Point(880, 464)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(195, 20)
        Me.txt_cantidad.TabIndex = 7
        Me.txt_cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(768, 465)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Cantidad Total:"
        '
        'btn_busqueda
        '
        Me.btn_busqueda.Location = New System.Drawing.Point(529, 59)
        Me.btn_busqueda.Name = "btn_busqueda"
        Me.btn_busqueda.Size = New System.Drawing.Size(75, 23)
        Me.btn_busqueda.TabIndex = 9
        Me.btn_busqueda.Text = "Busqueda"
        Me.btn_busqueda.UseVisualStyleBackColor = True
        '
        'lb_estado
        '
        Me.lb_estado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lb_estado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_estado.ForeColor = System.Drawing.Color.Blue
        Me.lb_estado.Location = New System.Drawing.Point(12, 457)
        Me.lb_estado.Name = "lb_estado"
        Me.lb_estado.Size = New System.Drawing.Size(1063, 23)
        Me.lb_estado.TabIndex = 10
        Me.lb_estado.Text = "Estado Nomal..."
        Me.lb_estado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MepDataGridView1
        '
        Me.MepDataGridView1.AllowUserToAddRows = False
        Me.MepDataGridView1.AllowUserToDeleteRows = False
        Me.MepDataGridView1.AllowUserToOrderColumns = True
        Me.MepDataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MepDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MepDataGridView1.ColumnHeadersHeight = 40
        Me.MepDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.MepDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.c_nro_factura, Me.c_fecha, Me.c_cliente, Me.c_codigo, Me.c_producto, Me.c_cantidad, Me.c_precio})
        Me.MepDataGridView1.Location = New System.Drawing.Point(12, 99)
        Me.MepDataGridView1.MultiSelect = False
        Me.MepDataGridView1.Name = "MepDataGridView1"
        Me.MepDataGridView1.Size = New System.Drawing.Size(1063, 343)
        Me.MepDataGridView1.TabIndex = 0
        '
        'c_nro_factura
        '
        Me.c_nro_factura.FillWeight = 1.0!
        Me.c_nro_factura.HeaderText = "Nro Factura"
        Me.c_nro_factura.Name = "c_nro_factura"
        Me.c_nro_factura.ReadOnly = True
        '
        'c_fecha
        '
        DataGridViewCellStyle1.Format = "M"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.c_fecha.DefaultCellStyle = DataGridViewCellStyle1
        Me.c_fecha.FillWeight = 1.0!
        Me.c_fecha.HeaderText = "Fecha"
        Me.c_fecha.Name = "c_fecha"
        Me.c_fecha.ReadOnly = True
        '
        'c_cliente
        '
        Me.c_cliente.FillWeight = 3.0!
        Me.c_cliente.HeaderText = "Cliente"
        Me.c_cliente.Name = "c_cliente"
        Me.c_cliente.ReadOnly = True
        '
        'c_codigo
        '
        Me.c_codigo.FillWeight = 1.0!
        Me.c_codigo.HeaderText = "Codigo"
        Me.c_codigo.Name = "c_codigo"
        Me.c_codigo.ReadOnly = True
        '
        'c_producto
        '
        Me.c_producto.FillWeight = 3.0!
        Me.c_producto.HeaderText = "Producto"
        Me.c_producto.Name = "c_producto"
        Me.c_producto.ReadOnly = True
        '
        'c_cantidad
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.c_cantidad.DefaultCellStyle = DataGridViewCellStyle2
        Me.c_cantidad.FillWeight = 1.0!
        Me.c_cantidad.HeaderText = "Cantidad"
        Me.c_cantidad.Name = "c_cantidad"
        Me.c_cantidad.ReadOnly = True
        '
        'c_precio
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.c_precio.DefaultCellStyle = DataGridViewCellStyle3
        Me.c_precio.FillWeight = 1.0!
        Me.c_precio.HeaderText = "Precio"
        Me.c_precio.Name = "c_precio"
        Me.c_precio.ReadOnly = True
        '
        'txt_clientes
        '
        Me.txt_clientes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_clientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_clientes.Location = New System.Drawing.Point(271, 59)
        Me.txt_clientes.Name = "txt_clientes"
        Me.txt_clientes.Size = New System.Drawing.Size(243, 22)
        Me.txt_clientes.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(268, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Filtro de Clientes"
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 200
        Me.ToolTip1.ReshowDelay = 100
        '
        'fr_historial_productos_vendidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1087, 496)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_clientes)
        Me.Controls.Add(Me.btn_busqueda)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_cantidad)
        Me.Controls.Add(Me.lb_filtro)
        Me.Controls.Add(Me.txt_producto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Dtp_Fecha_fin)
        Me.Controls.Add(Me.Dtp_Fecha_inicio)
        Me.Controls.Add(Me.MepDataGridView1)
        Me.Controls.Add(Me.lb_estado)
        Me.Name = "fr_historial_productos_vendidos"
        Me.Text = "Historial de Productos Vendidos"
        CType(Me.MepDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MepDataGridView1 As MEPDataGridView
    Friend WithEvents Dtp_Fecha_inicio As DateTimePicker
    Friend WithEvents Dtp_Fecha_fin As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_producto As TextBox
    Friend WithEvents lb_filtro As Label
    Friend WithEvents txt_cantidad As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_busqueda As Button
    Friend WithEvents lb_estado As Label
    Friend WithEvents c_nro_factura As DataGridViewTextBoxColumn
    Friend WithEvents c_fecha As DataGridViewTextBoxColumn
    Friend WithEvents c_cliente As DataGridViewTextBoxColumn
    Friend WithEvents c_codigo As DataGridViewTextBoxColumn
    Friend WithEvents c_producto As DataGridViewTextBoxColumn
    Friend WithEvents c_cantidad As DataGridViewTextBoxColumn
    Friend WithEvents c_precio As DataGridViewTextBoxColumn
    Friend WithEvents txt_clientes As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
