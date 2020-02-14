<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Fr_Crear_Facturas
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fr_Crear_Facturas))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lv_BusquedaClientes = New System.Windows.Forms.ListView()
        Me.CH_Codigo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CH_Cliente = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Lv_Vendedor = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Txt_Cedula = New System.Windows.Forms.TextBox()
        Me.Btn_Nueva_Factura = New System.Windows.Forms.Button()
        Me.Btn_Salir = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Btn_Solo_Guardar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_Articulo_Nuevo = New System.Windows.Forms.Button()
        Me.Txt_Numero_Factura = New System.Windows.Forms.TextBox()
        Me.Dtp_Fecha = New System.Windows.Forms.DateTimePicker()
        Me.Btn_Historial = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Txt_Cambio = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Txt_Pago = New System.Windows.Forms.TextBox()
        Me.Lv_Busqueda_Articulos = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChCod = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChDesc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GB_Detalles = New System.Windows.Forms.GroupBox()
        Me.nudCantidad = New System.Windows.Forms.NumericUpDown()
        Me.txt_ImpuestoProducto = New System.Windows.Forms.TextBox()
        Me.lb_barcode = New System.Windows.Forms.Label()
        Me.chb_barcode = New System.Windows.Forms.CheckBox()
        Me.txt_barcode = New System.Windows.Forms.TextBox()
        Me.chb_cantidad = New System.Windows.Forms.CheckBox()
        Me.Txt_Codigo_Articulo = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Chb_Por_Mayor = New System.Windows.Forms.CheckBox()
        Me.Btn_Añadir = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Txt_Subtotal_Articulo = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Txt_Precio_Articulo = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Txt_Impuesto_Articulo = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Txt_Descripcion_Articulo = New System.Windows.Forms.TextBox()
        Me.Btn_Eliminar = New System.Windows.Forms.Button()
        Me.Btn_Cliente = New System.Windows.Forms.Button()
        Me.Btn_Imprimir = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Txt_Descuento = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_TotalImpuestos = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txt_Total = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Txt_Descuento_Final = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Txt_Subtotal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Cb_Vendedor = New System.Windows.Forms.ComboBox()
        Me.DGV_Comentarios = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Txt_Codigo_Cliente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Lb_Adelantar = New System.Windows.Forms.Label()
        Me.Lb_Retroceder = New System.Windows.Forms.Label()
        Me.cb_barcode = New System.Windows.Forms.PictureBox()
        Me.Factura = New System.Drawing.Printing.PrintDocument()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Lb_Numero_Linea = New System.Windows.Forms.Label()
        Me.CodPro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descrip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prec = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlCentral = New System.Windows.Forms.Panel()
        Me.lbDias = New System.Windows.Forms.Label()
        Me.lbCreditoA = New System.Windows.Forms.Label()
        Me.nudDias = New System.Windows.Forms.NumericUpDown()
        Me.cb_CondicionVenta = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nud_numero_copias = New System.Windows.Forms.NumericUpDown()
        Me.DGV_Facturas = New Facturacion_Esteban.MEPDataGridView()
        Me.C_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_Impuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_impuestos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbCondicionVenta = New System.Windows.Forms.Label()
        Me.txtOems = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.GB_Detalles.SuspendLayout()
        CType(Me.nudCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV_Comentarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cb_barcode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCentral.SuspendLayout()
        CType(Me.nudDias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_numero_copias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Facturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lv_BusquedaClientes
        '
        Me.lv_BusquedaClientes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CH_Codigo, Me.CH_Cliente})
        Me.lv_BusquedaClientes.FullRowSelect = True
        Me.lv_BusquedaClientes.GridLines = True
        Me.lv_BusquedaClientes.Location = New System.Drawing.Point(409, 14)
        Me.lv_BusquedaClientes.Name = "lv_BusquedaClientes"
        Me.lv_BusquedaClientes.Size = New System.Drawing.Size(510, 111)
        Me.lv_BusquedaClientes.TabIndex = 50
        Me.lv_BusquedaClientes.UseCompatibleStateImageBehavior = False
        Me.lv_BusquedaClientes.View = System.Windows.Forms.View.Details
        '
        'CH_Codigo
        '
        Me.CH_Codigo.Text = "Codigo"
        Me.CH_Codigo.Width = 96
        '
        'CH_Cliente
        '
        Me.CH_Cliente.Text = "Cliente"
        Me.CH_Cliente.Width = 421
        '
        'Lv_Vendedor
        '
        Me.Lv_Vendedor.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.Lv_Vendedor.FullRowSelect = True
        Me.Lv_Vendedor.GridLines = True
        Me.Lv_Vendedor.Location = New System.Drawing.Point(88, 384)
        Me.Lv_Vendedor.Name = "Lv_Vendedor"
        Me.Lv_Vendedor.Size = New System.Drawing.Size(219, 94)
        Me.Lv_Vendedor.TabIndex = 30
        Me.Lv_Vendedor.UseCompatibleStateImageBehavior = False
        Me.Lv_Vendedor.View = System.Windows.Forms.View.Details
        Me.Lv_Vendedor.Visible = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Id vendedor"
        Me.ColumnHeader1.Width = 106
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "cod Vendedor"
        Me.ColumnHeader2.Width = 100
        '
        'Txt_Cedula
        '
        Me.Txt_Cedula.BackColor = System.Drawing.SystemColors.Window
        Me.Txt_Cedula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Cedula.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Cedula.Location = New System.Drawing.Point(144, 102)
        Me.Txt_Cedula.MaxLength = 200
        Me.Txt_Cedula.Name = "Txt_Cedula"
        Me.Txt_Cedula.Size = New System.Drawing.Size(259, 23)
        Me.Txt_Cedula.TabIndex = 2
        '
        'Btn_Nueva_Factura
        '
        Me.Btn_Nueva_Factura.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Nueva_Factura.Location = New System.Drawing.Point(290, 618)
        Me.Btn_Nueva_Factura.Name = "Btn_Nueva_Factura"
        Me.Btn_Nueva_Factura.Size = New System.Drawing.Size(68, 24)
        Me.Btn_Nueva_Factura.TabIndex = 51
        Me.Btn_Nueva_Factura.Text = "Nueva"
        Me.Btn_Nueva_Factura.UseVisualStyleBackColor = True
        '
        'Btn_Salir
        '
        Me.Btn_Salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Salir.Location = New System.Drawing.Point(290, 676)
        Me.Btn_Salir.Name = "Btn_Salir"
        Me.Btn_Salir.Size = New System.Drawing.Size(68, 24)
        Me.Btn_Salir.TabIndex = 49
        Me.Btn_Salir.Text = "Salir"
        Me.Btn_Salir.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(785, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Numero De Factura:"
        '
        'Btn_Solo_Guardar
        '
        Me.Btn_Solo_Guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Solo_Guardar.Location = New System.Drawing.Point(123, 618)
        Me.Btn_Solo_Guardar.Name = "Btn_Solo_Guardar"
        Me.Btn_Solo_Guardar.Size = New System.Drawing.Size(161, 24)
        Me.Btn_Solo_Guardar.TabIndex = 48
        Me.Btn_Solo_Guardar.Text = "Solo Guardar"
        Me.Btn_Solo_Guardar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(864, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Fecha:"
        '
        'Btn_Articulo_Nuevo
        '
        Me.Btn_Articulo_Nuevo.Location = New System.Drawing.Point(23, 97)
        Me.Btn_Articulo_Nuevo.Name = "Btn_Articulo_Nuevo"
        Me.Btn_Articulo_Nuevo.Size = New System.Drawing.Size(115, 23)
        Me.Btn_Articulo_Nuevo.TabIndex = 47
        Me.Btn_Articulo_Nuevo.Text = "Articulo Nuevo"
        Me.Btn_Articulo_Nuevo.UseVisualStyleBackColor = True
        '
        'Txt_Numero_Factura
        '
        Me.Txt_Numero_Factura.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_Numero_Factura.BackColor = System.Drawing.Color.DarkCyan
        Me.Txt_Numero_Factura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Numero_Factura.ForeColor = System.Drawing.SystemColors.Window
        Me.Txt_Numero_Factura.Location = New System.Drawing.Point(927, 40)
        Me.Txt_Numero_Factura.Name = "Txt_Numero_Factura"
        Me.Txt_Numero_Factura.ReadOnly = True
        Me.Txt_Numero_Factura.Size = New System.Drawing.Size(151, 22)
        Me.Txt_Numero_Factura.TabIndex = 3
        Me.Txt_Numero_Factura.Text = "26 01 1985"
        Me.Txt_Numero_Factura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Dtp_Fecha
        '
        Me.Dtp_Fecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dtp_Fecha.CustomFormat = "dd/MM/yyyy hh:mm:ss"
        Me.Dtp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_Fecha.Location = New System.Drawing.Point(927, 14)
        Me.Dtp_Fecha.Name = "Dtp_Fecha"
        Me.Dtp_Fecha.Size = New System.Drawing.Size(151, 20)
        Me.Dtp_Fecha.TabIndex = 2
        '
        'Btn_Historial
        '
        Me.Btn_Historial.Location = New System.Drawing.Point(23, 72)
        Me.Btn_Historial.Name = "Btn_Historial"
        Me.Btn_Historial.Size = New System.Drawing.Size(115, 23)
        Me.Btn_Historial.TabIndex = 46
        Me.Btn_Historial.Text = "Historial"
        Me.Btn_Historial.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(13, 658)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(42, 13)
        Me.Label18.TabIndex = 43
        Me.Label18.Text = "Cambio"
        '
        'Txt_Cambio
        '
        Me.Txt_Cambio.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Txt_Cambio.Location = New System.Drawing.Point(16, 676)
        Me.Txt_Cambio.MaxLength = 12
        Me.Txt_Cambio.Name = "Txt_Cambio"
        Me.Txt_Cambio.Size = New System.Drawing.Size(84, 20)
        Me.Txt_Cambio.TabIndex = 12
        Me.Txt_Cambio.Text = "0,00"
        Me.Txt_Cambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(15, 617)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(32, 13)
        Me.Label17.TabIndex = 41
        Me.Label17.Text = "Pago"
        '
        'Txt_Pago
        '
        Me.Txt_Pago.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Txt_Pago.Location = New System.Drawing.Point(16, 630)
        Me.Txt_Pago.MaxLength = 12
        Me.Txt_Pago.Name = "Txt_Pago"
        Me.Txt_Pago.Size = New System.Drawing.Size(84, 20)
        Me.Txt_Pago.TabIndex = 11
        Me.Txt_Pago.Text = "0,00"
        Me.Txt_Pago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Lv_Busqueda_Articulos
        '
        Me.Lv_Busqueda_Articulos.BackColor = System.Drawing.Color.Gainsboro
        Me.Lv_Busqueda_Articulos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ChCod, Me.ChDesc, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.Lv_Busqueda_Articulos.FullRowSelect = True
        Me.Lv_Busqueda_Articulos.GridLines = True
        Me.Lv_Busqueda_Articulos.Location = New System.Drawing.Point(211, 233)
        Me.Lv_Busqueda_Articulos.Name = "Lv_Busqueda_Articulos"
        Me.Lv_Busqueda_Articulos.Size = New System.Drawing.Size(618, 205)
        Me.Lv_Busqueda_Articulos.TabIndex = 21
        Me.Lv_Busqueda_Articulos.UseCompatibleStateImageBehavior = False
        Me.Lv_Busqueda_Articulos.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.DisplayIndex = 2
        Me.ColumnHeader3.Text = "ChId"
        Me.ColumnHeader3.Width = 0
        '
        'ChCod
        '
        Me.ChCod.DisplayIndex = 0
        Me.ChCod.Text = "Codigo"
        Me.ChCod.Width = 96
        '
        'ChDesc
        '
        Me.ChDesc.DisplayIndex = 1
        Me.ChDesc.Text = "Descripcion"
        Me.ChDesc.Width = 310
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Sugerido"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 88
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Por Mayor"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader5.Width = 91
        '
        'GB_Detalles
        '
        Me.GB_Detalles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GB_Detalles.BackColor = System.Drawing.Color.Aquamarine
        Me.GB_Detalles.Controls.Add(Me.nudCantidad)
        Me.GB_Detalles.Controls.Add(Me.txt_ImpuestoProducto)
        Me.GB_Detalles.Controls.Add(Me.lb_barcode)
        Me.GB_Detalles.Controls.Add(Me.chb_barcode)
        Me.GB_Detalles.Controls.Add(Me.txt_barcode)
        Me.GB_Detalles.Controls.Add(Me.chb_cantidad)
        Me.GB_Detalles.Controls.Add(Me.Txt_Codigo_Articulo)
        Me.GB_Detalles.Controls.Add(Me.Label16)
        Me.GB_Detalles.Controls.Add(Me.Chb_Por_Mayor)
        Me.GB_Detalles.Controls.Add(Me.Btn_Añadir)
        Me.GB_Detalles.Controls.Add(Me.Label15)
        Me.GB_Detalles.Controls.Add(Me.Txt_Subtotal_Articulo)
        Me.GB_Detalles.Controls.Add(Me.Label14)
        Me.GB_Detalles.Controls.Add(Me.Txt_Precio_Articulo)
        Me.GB_Detalles.Controls.Add(Me.Label13)
        Me.GB_Detalles.Controls.Add(Me.Txt_Impuesto_Articulo)
        Me.GB_Detalles.Controls.Add(Me.Label12)
        Me.GB_Detalles.Controls.Add(Me.Label11)
        Me.GB_Detalles.Controls.Add(Me.Txt_Descripcion_Articulo)
        Me.GB_Detalles.Location = New System.Drawing.Point(16, 148)
        Me.GB_Detalles.Name = "GB_Detalles"
        Me.GB_Detalles.Size = New System.Drawing.Size(1062, 100)
        Me.GB_Detalles.TabIndex = 3
        Me.GB_Detalles.TabStop = False
        Me.GB_Detalles.Text = "Detalles"
        '
        'nudCantidad
        '
        Me.nudCantidad.DecimalPlaces = 2
        Me.nudCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudCantidad.Location = New System.Drawing.Point(574, 57)
        Me.nudCantidad.Maximum = New Decimal(New Integer() {-727379969, 232, 0, 0})
        Me.nudCantidad.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nudCantidad.Name = "nudCantidad"
        Me.nudCantidad.Size = New System.Drawing.Size(100, 22)
        Me.nudCantidad.TabIndex = 6
        Me.nudCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudCantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txt_ImpuestoProducto
        '
        Me.txt_ImpuestoProducto.BackColor = System.Drawing.SystemColors.Window
        Me.txt_ImpuestoProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ImpuestoProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ImpuestoProducto.Location = New System.Drawing.Point(965, 26)
        Me.txt_ImpuestoProducto.MaxLength = 20
        Me.txt_ImpuestoProducto.Name = "txt_ImpuestoProducto"
        Me.txt_ImpuestoProducto.Size = New System.Drawing.Size(88, 22)
        Me.txt_ImpuestoProducto.TabIndex = 44
        Me.txt_ImpuestoProducto.Visible = False
        '
        'lb_barcode
        '
        Me.lb_barcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_barcode.ForeColor = System.Drawing.Color.DarkBlue
        Me.lb_barcode.Location = New System.Drawing.Point(7, 40)
        Me.lb_barcode.Name = "lb_barcode"
        Me.lb_barcode.Size = New System.Drawing.Size(179, 13)
        Me.lb_barcode.TabIndex = 43
        Me.lb_barcode.Text = "DESCRIPCION"
        Me.lb_barcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lb_barcode.Visible = False
        '
        'chb_barcode
        '
        Me.chb_barcode.AutoSize = True
        Me.chb_barcode.Location = New System.Drawing.Point(16, 19)
        Me.chb_barcode.Name = "chb_barcode"
        Me.chb_barcode.Size = New System.Drawing.Size(66, 17)
        Me.chb_barcode.TabIndex = 42
        Me.chb_barcode.Text = "Barcode"
        Me.chb_barcode.UseVisualStyleBackColor = True
        '
        'txt_barcode
        '
        Me.txt_barcode.BackColor = System.Drawing.SystemColors.Window
        Me.txt_barcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_barcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_barcode.Location = New System.Drawing.Point(7, 57)
        Me.txt_barcode.MaxLength = 50
        Me.txt_barcode.Name = "txt_barcode"
        Me.txt_barcode.Size = New System.Drawing.Size(182, 22)
        Me.txt_barcode.TabIndex = 3
        Me.txt_barcode.Text = "BARCODE"
        Me.txt_barcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'chb_cantidad
        '
        Me.chb_cantidad.AutoSize = True
        Me.chb_cantidad.Location = New System.Drawing.Point(168, 19)
        Me.chb_cantidad.Name = "chb_cantidad"
        Me.chb_cantidad.Size = New System.Drawing.Size(106, 17)
        Me.chb_cantidad.TabIndex = 40
        Me.chb_cantidad.Text = "Primero Cantidad"
        Me.chb_cantidad.UseVisualStyleBackColor = True
        '
        'Txt_Codigo_Articulo
        '
        Me.Txt_Codigo_Articulo.BackColor = System.Drawing.SystemColors.Window
        Me.Txt_Codigo_Articulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Codigo_Articulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Codigo_Articulo.Location = New System.Drawing.Point(195, 57)
        Me.Txt_Codigo_Articulo.MaxLength = 20
        Me.Txt_Codigo_Articulo.Name = "Txt_Codigo_Articulo"
        Me.Txt_Codigo_Articulo.Size = New System.Drawing.Size(128, 22)
        Me.Txt_Codigo_Articulo.TabIndex = 4
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(804, 39)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(24, 13)
        Me.Label16.TabIndex = 39
        Me.Label16.Text = "IVA"
        '
        'Chb_Por_Mayor
        '
        Me.Chb_Por_Mayor.AutoSize = True
        Me.Chb_Por_Mayor.Location = New System.Drawing.Point(88, 19)
        Me.Chb_Por_Mayor.Name = "Chb_Por_Mayor"
        Me.Chb_Por_Mayor.Size = New System.Drawing.Size(74, 17)
        Me.Chb_Por_Mayor.TabIndex = 27
        Me.Chb_Por_Mayor.Text = "Por Mayor"
        Me.Chb_Por_Mayor.UseVisualStyleBackColor = True
        '
        'Btn_Añadir
        '
        Me.Btn_Añadir.Location = New System.Drawing.Point(965, 54)
        Me.Btn_Añadir.Name = "Btn_Añadir"
        Me.Btn_Añadir.Size = New System.Drawing.Size(89, 23)
        Me.Btn_Añadir.TabIndex = 10
        Me.Btn_Añadir.Text = "Añadir"
        Me.Btn_Añadir.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(873, 38)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 13)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "SUBTOTAL"
        '
        'Txt_Subtotal_Articulo
        '
        Me.Txt_Subtotal_Articulo.BackColor = System.Drawing.Color.Yellow
        Me.Txt_Subtotal_Articulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Subtotal_Articulo.Location = New System.Drawing.Point(860, 56)
        Me.Txt_Subtotal_Articulo.MaxLength = 12
        Me.Txt_Subtotal_Articulo.Name = "Txt_Subtotal_Articulo"
        Me.Txt_Subtotal_Articulo.ReadOnly = True
        Me.Txt_Subtotal_Articulo.Size = New System.Drawing.Size(99, 22)
        Me.Txt_Subtotal_Articulo.TabIndex = 9
        Me.Txt_Subtotal_Articulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(704, 40)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(47, 13)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "PRECIO"
        '
        'Txt_Precio_Articulo
        '
        Me.Txt_Precio_Articulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Precio_Articulo.Location = New System.Drawing.Point(680, 57)
        Me.Txt_Precio_Articulo.MaxLength = 12
        Me.Txt_Precio_Articulo.Name = "Txt_Precio_Articulo"
        Me.Txt_Precio_Articulo.Size = New System.Drawing.Size(114, 22)
        Me.Txt_Precio_Articulo.TabIndex = 7
        Me.Txt_Precio_Articulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(585, 39)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 13)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "CANTIDAD"
        '
        'Txt_Impuesto_Articulo
        '
        Me.Txt_Impuesto_Articulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Impuesto_Articulo.Location = New System.Drawing.Point(800, 56)
        Me.Txt_Impuesto_Articulo.MaxLength = 2
        Me.Txt_Impuesto_Articulo.Name = "Txt_Impuesto_Articulo"
        Me.Txt_Impuesto_Articulo.Size = New System.Drawing.Size(53, 22)
        Me.Txt_Impuesto_Articulo.TabIndex = 8
        Me.Txt_Impuesto_Articulo.Text = "0"
        Me.Txt_Impuesto_Articulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(331, 39)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 13)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "DESCRIPCION"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(192, 39)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "CODIGO"
        '
        'Txt_Descripcion_Articulo
        '
        Me.Txt_Descripcion_Articulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Descripcion_Articulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Descripcion_Articulo.Location = New System.Drawing.Point(329, 57)
        Me.Txt_Descripcion_Articulo.MaxLength = 150
        Me.Txt_Descripcion_Articulo.Name = "Txt_Descripcion_Articulo"
        Me.Txt_Descripcion_Articulo.Size = New System.Drawing.Size(239, 22)
        Me.Txt_Descripcion_Articulo.TabIndex = 5
        '
        'Btn_Eliminar
        '
        Me.Btn_Eliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Eliminar.Location = New System.Drawing.Point(290, 647)
        Me.Btn_Eliminar.Name = "Btn_Eliminar"
        Me.Btn_Eliminar.Size = New System.Drawing.Size(68, 24)
        Me.Btn_Eliminar.TabIndex = 22
        Me.Btn_Eliminar.Text = "Eliminar"
        Me.Btn_Eliminar.UseVisualStyleBackColor = True
        '
        'Btn_Cliente
        '
        Me.Btn_Cliente.Location = New System.Drawing.Point(23, 46)
        Me.Btn_Cliente.Name = "Btn_Cliente"
        Me.Btn_Cliente.Size = New System.Drawing.Size(115, 23)
        Me.Btn_Cliente.TabIndex = 20
        Me.Btn_Cliente.Text = "Nuevo Cliente"
        Me.Btn_Cliente.UseVisualStyleBackColor = True
        '
        'Btn_Imprimir
        '
        Me.Btn_Imprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Imprimir.Location = New System.Drawing.Point(123, 647)
        Me.Btn_Imprimir.Name = "Btn_Imprimir"
        Me.Btn_Imprimir.Size = New System.Drawing.Size(161, 24)
        Me.Btn_Imprimir.TabIndex = 18
        Me.Btn_Imprimir.Text = "IMPRIMIR F9"
        Me.Btn_Imprimir.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(845, 77)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 16)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Vendedor"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(717, 661)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(15, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "%"
        '
        'Txt_Descuento
        '
        Me.Txt_Descuento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_Descuento.ForeColor = System.Drawing.Color.DarkBlue
        Me.Txt_Descuento.Location = New System.Drawing.Point(657, 658)
        Me.Txt_Descuento.MaxLength = 3
        Me.Txt_Descuento.Name = "Txt_Descuento"
        Me.Txt_Descuento.Size = New System.Drawing.Size(59, 20)
        Me.Txt_Descuento.TabIndex = 13
        Me.Txt_Descuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txt_TotalImpuestos)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Txt_Total)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(847, 617)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(247, 87)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'txt_TotalImpuestos
        '
        Me.txt_TotalImpuestos.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TotalImpuestos.ForeColor = System.Drawing.Color.Black
        Me.txt_TotalImpuestos.Location = New System.Drawing.Point(77, 28)
        Me.txt_TotalImpuestos.MaxLength = 12
        Me.txt_TotalImpuestos.Name = "txt_TotalImpuestos"
        Me.txt_TotalImpuestos.Size = New System.Drawing.Size(164, 26)
        Me.txt_TotalImpuestos.TabIndex = 18
        Me.txt_TotalImpuestos.Text = "0,00"
        Me.txt_TotalImpuestos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "IVA:"
        '
        'Txt_Total
        '
        Me.Txt_Total.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Total.ForeColor = System.Drawing.Color.Red
        Me.Txt_Total.Location = New System.Drawing.Point(77, 55)
        Me.Txt_Total.MaxLength = 12
        Me.Txt_Total.Name = "Txt_Total"
        Me.Txt_Total.Size = New System.Drawing.Size(164, 26)
        Me.Txt_Total.TabIndex = 16
        Me.Txt_Total.Text = "0,00"
        Me.Txt_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "TOTAL:"
        '
        'Txt_Descuento_Final
        '
        Me.Txt_Descuento_Final.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_Descuento_Final.Location = New System.Drawing.Point(737, 658)
        Me.Txt_Descuento_Final.MaxLength = 12
        Me.Txt_Descuento_Final.Name = "Txt_Descuento_Final"
        Me.Txt_Descuento_Final.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Descuento_Final.TabIndex = 15
        Me.Txt_Descuento_Final.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(614, 661)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Desc:"
        '
        'Txt_Subtotal
        '
        Me.Txt_Subtotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_Subtotal.Location = New System.Drawing.Point(737, 629)
        Me.Txt_Subtotal.MaxLength = 12
        Me.Txt_Subtotal.Name = "Txt_Subtotal"
        Me.Txt_Subtotal.ReadOnly = True
        Me.Txt_Subtotal.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Subtotal.TabIndex = 14
        Me.Txt_Subtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(665, 629)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "SubTotal:"
        '
        'Cb_Vendedor
        '
        Me.Cb_Vendedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cb_Vendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Vendedor.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_Vendedor.FormattingEnabled = True
        Me.Cb_Vendedor.Location = New System.Drawing.Point(927, 68)
        Me.Cb_Vendedor.Name = "Cb_Vendedor"
        Me.Cb_Vendedor.Size = New System.Drawing.Size(151, 23)
        Me.Cb_Vendedor.TabIndex = 7
        '
        'DGV_Comentarios
        '
        Me.DGV_Comentarios.AllowUserToAddRows = False
        Me.DGV_Comentarios.AllowUserToResizeColumns = False
        Me.DGV_Comentarios.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Comentarios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_Comentarios.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGV_Comentarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Comentarios.ColumnHeadersVisible = False
        Me.DGV_Comentarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        Me.DGV_Comentarios.Location = New System.Drawing.Point(144, 46)
        Me.DGV_Comentarios.Name = "DGV_Comentarios"
        Me.DGV_Comentarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_Comentarios.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_Comentarios.RowHeadersVisible = False
        Me.DGV_Comentarios.RowTemplate.Height = 23
        Me.DGV_Comentarios.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DGV_Comentarios.Size = New System.Drawing.Size(258, 54)
        Me.DGV_Comentarios.TabIndex = 1000
        '
        'Column1
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column1.HeaderText = "Column1"
        Me.Column1.MaxInputLength = 40
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 402
        '
        'Txt_Codigo_Cliente
        '
        Me.Txt_Codigo_Cliente.BackColor = System.Drawing.SystemColors.Window
        Me.Txt_Codigo_Cliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Codigo_Cliente.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Codigo_Cliente.Location = New System.Drawing.Point(144, 16)
        Me.Txt_Codigo_Cliente.MaxLength = 20
        Me.Txt_Codigo_Cliente.Name = "Txt_Codigo_Cliente"
        Me.Txt_Codigo_Cliente.Size = New System.Drawing.Size(258, 23)
        Me.Txt_Codigo_Cliente.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Codigo del Cliente"
        '
        'Lb_Adelantar
        '
        Me.Lb_Adelantar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Adelantar.Image = CType(resources.GetObject("Lb_Adelantar.Image"), System.Drawing.Image)
        Me.Lb_Adelantar.Location = New System.Drawing.Point(474, 18)
        Me.Lb_Adelantar.Name = "Lb_Adelantar"
        Me.Lb_Adelantar.Size = New System.Drawing.Size(83, 49)
        Me.Lb_Adelantar.TabIndex = 1003
        '
        'Lb_Retroceder
        '
        Me.Lb_Retroceder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Retroceder.Image = CType(resources.GetObject("Lb_Retroceder.Image"), System.Drawing.Image)
        Me.Lb_Retroceder.Location = New System.Drawing.Point(411, 20)
        Me.Lb_Retroceder.Name = "Lb_Retroceder"
        Me.Lb_Retroceder.Size = New System.Drawing.Size(83, 49)
        Me.Lb_Retroceder.TabIndex = 1002
        '
        'cb_barcode
        '
        Me.cb_barcode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cb_barcode.Image = CType(resources.GetObject("cb_barcode.Image"), System.Drawing.Image)
        Me.cb_barcode.Location = New System.Drawing.Point(0, 0)
        Me.cb_barcode.Name = "cb_barcode"
        Me.cb_barcode.Size = New System.Drawing.Size(1134, 761)
        Me.cb_barcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cb_barcode.TabIndex = 6
        Me.cb_barcode.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 150
        '
        'Lb_Numero_Linea
        '
        Me.Lb_Numero_Linea.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lb_Numero_Linea.BackColor = System.Drawing.Color.Transparent
        Me.Lb_Numero_Linea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Numero_Linea.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lb_Numero_Linea.Location = New System.Drawing.Point(9, 731)
        Me.Lb_Numero_Linea.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_Numero_Linea.Name = "Lb_Numero_Linea"
        Me.Lb_Numero_Linea.Size = New System.Drawing.Size(1111, 21)
        Me.Lb_Numero_Linea.TabIndex = 7
        Me.Lb_Numero_Linea.Text = "Label1"
        Me.Lb_Numero_Linea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CodPro
        '
        Me.CodPro.HeaderText = "Codigo del Producto"
        Me.CodPro.MaxInputLength = 150
        Me.CodPro.Name = "CodPro"
        Me.CodPro.ReadOnly = True
        Me.CodPro.Width = 95
        '
        'Descrip
        '
        Me.Descrip.HeaderText = "Descripcion"
        Me.Descrip.MaxInputLength = 300
        Me.Descrip.Name = "Descrip"
        Me.Descrip.ReadOnly = True
        Me.Descrip.Width = 302
        '
        'Cant
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Cant.DefaultCellStyle = DataGridViewCellStyle4
        Me.Cant.HeaderText = "Cantidad"
        Me.Cant.MaxInputLength = 50
        Me.Cant.Name = "Cant"
        Me.Cant.ReadOnly = True
        Me.Cant.Width = 79
        '
        'Prec
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Prec.DefaultCellStyle = DataGridViewCellStyle5
        Me.Prec.HeaderText = "Precio"
        Me.Prec.MaxInputLength = 50
        Me.Prec.Name = "Prec"
        Me.Prec.ReadOnly = True
        Me.Prec.Width = 79
        '
        'Column3
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle6
        Me.Column3.HeaderText = "Imp"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 60
        '
        'Tot
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Tot.DefaultCellStyle = DataGridViewCellStyle7
        Me.Tot.HeaderText = "Total"
        Me.Tot.MaxInputLength = 80
        Me.Tot.Name = "Tot"
        Me.Tot.ReadOnly = True
        Me.Tot.Width = 140
        '
        'Column2
        '
        Me.Column2.HeaderText = "id"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Visible = False
        '
        'Column4
        '
        Me.Column4.HeaderText = "fechahora"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Visible = False
        Me.Column4.Width = 200
        '
        'pnlCentral
        '
        Me.pnlCentral.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCentral.BackColor = System.Drawing.Color.LightSteelBlue
        Me.pnlCentral.Controls.Add(Me.Label19)
        Me.pnlCentral.Controls.Add(Me.txtOems)
        Me.pnlCentral.Controls.Add(Me.lbDias)
        Me.pnlCentral.Controls.Add(Me.lbCreditoA)
        Me.pnlCentral.Controls.Add(Me.nudDias)
        Me.pnlCentral.Controls.Add(Me.cb_CondicionVenta)
        Me.pnlCentral.Controls.Add(Me.Label1)
        Me.pnlCentral.Controls.Add(Me.nud_numero_copias)
        Me.pnlCentral.Controls.Add(Me.lv_BusquedaClientes)
        Me.pnlCentral.Controls.Add(Me.Txt_Cedula)
        Me.pnlCentral.Controls.Add(Me.Btn_Solo_Guardar)
        Me.pnlCentral.Controls.Add(Me.Label3)
        Me.pnlCentral.Controls.Add(Me.Lv_Vendedor)
        Me.pnlCentral.Controls.Add(Me.Label2)
        Me.pnlCentral.Controls.Add(Me.Label6)
        Me.pnlCentral.Controls.Add(Me.Btn_Articulo_Nuevo)
        Me.pnlCentral.Controls.Add(Me.Txt_Subtotal)
        Me.pnlCentral.Controls.Add(Me.Txt_Numero_Factura)
        Me.pnlCentral.Controls.Add(Me.Btn_Nueva_Factura)
        Me.pnlCentral.Controls.Add(Me.Dtp_Fecha)
        Me.pnlCentral.Controls.Add(Me.Label7)
        Me.pnlCentral.Controls.Add(Me.Btn_Historial)
        Me.pnlCentral.Controls.Add(Me.Btn_Salir)
        Me.pnlCentral.Controls.Add(Me.Btn_Cliente)
        Me.pnlCentral.Controls.Add(Me.Txt_Descuento_Final)
        Me.pnlCentral.Controls.Add(Me.Label10)
        Me.pnlCentral.Controls.Add(Me.GroupBox1)
        Me.pnlCentral.Controls.Add(Me.Cb_Vendedor)
        Me.pnlCentral.Controls.Add(Me.Txt_Descuento)
        Me.pnlCentral.Controls.Add(Me.DGV_Comentarios)
        Me.pnlCentral.Controls.Add(Me.Lv_Busqueda_Articulos)
        Me.pnlCentral.Controls.Add(Me.Txt_Codigo_Cliente)
        Me.pnlCentral.Controls.Add(Me.Label9)
        Me.pnlCentral.Controls.Add(Me.Label4)
        Me.pnlCentral.Controls.Add(Me.GB_Detalles)
        Me.pnlCentral.Controls.Add(Me.Lb_Adelantar)
        Me.pnlCentral.Controls.Add(Me.Btn_Imprimir)
        Me.pnlCentral.Controls.Add(Me.Lb_Retroceder)
        Me.pnlCentral.Controls.Add(Me.Btn_Eliminar)
        Me.pnlCentral.Controls.Add(Me.Txt_Pago)
        Me.pnlCentral.Controls.Add(Me.Label18)
        Me.pnlCentral.Controls.Add(Me.Label17)
        Me.pnlCentral.Controls.Add(Me.Txt_Cambio)
        Me.pnlCentral.Controls.Add(Me.DGV_Facturas)
        Me.pnlCentral.Controls.Add(Me.lbCondicionVenta)
        Me.pnlCentral.Location = New System.Drawing.Point(12, 12)
        Me.pnlCentral.Name = "pnlCentral"
        Me.pnlCentral.Size = New System.Drawing.Size(1108, 716)
        Me.pnlCentral.TabIndex = 1004
        '
        'lbDias
        '
        Me.lbDias.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbDias.AutoSize = True
        Me.lbDias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDias.Location = New System.Drawing.Point(1000, 126)
        Me.lbDias.Name = "lbDias"
        Me.lbDias.Size = New System.Drawing.Size(34, 16)
        Me.lbDias.TabIndex = 1010
        Me.lbDias.Text = "días"
        Me.lbDias.Visible = False
        '
        'lbCreditoA
        '
        Me.lbCreditoA.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbCreditoA.AutoSize = True
        Me.lbCreditoA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCreditoA.Location = New System.Drawing.Point(848, 126)
        Me.lbCreditoA.Name = "lbCreditoA"
        Me.lbCreditoA.Size = New System.Drawing.Size(65, 16)
        Me.lbCreditoA.TabIndex = 1009
        Me.lbCreditoA.Text = "Credito a:"
        Me.lbCreditoA.Visible = False
        '
        'nudDias
        '
        Me.nudDias.Location = New System.Drawing.Point(927, 126)
        Me.nudDias.Maximum = New Decimal(New Integer() {365, 0, 0, 0})
        Me.nudDias.Name = "nudDias"
        Me.nudDias.Size = New System.Drawing.Size(67, 20)
        Me.nudDias.TabIndex = 1008
        Me.nudDias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudDias.Value = New Decimal(New Integer() {30, 0, 0, 0})
        Me.nudDias.Visible = False
        '
        'cb_CondicionVenta
        '
        Me.cb_CondicionVenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_CondicionVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_CondicionVenta.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_CondicionVenta.FormattingEnabled = True
        Me.cb_CondicionVenta.Items.AddRange(New Object() {"CONTADO", "CREDITO"})
        Me.cb_CondicionVenta.Location = New System.Drawing.Point(927, 97)
        Me.cb_CondicionVenta.Name = "cb_CondicionVenta"
        Me.cb_CondicionVenta.Size = New System.Drawing.Size(151, 23)
        Me.cb_CondicionVenta.TabIndex = 1006
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(371, 658)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 1005
        Me.Label1.Text = "Nro. Copias"
        '
        'nud_numero_copias
        '
        Me.nud_numero_copias.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.nud_numero_copias.Location = New System.Drawing.Point(374, 677)
        Me.nud_numero_copias.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nud_numero_copias.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nud_numero_copias.Name = "nud_numero_copias"
        Me.nud_numero_copias.Size = New System.Drawing.Size(53, 20)
        Me.nud_numero_copias.TabIndex = 1004
        Me.nud_numero_copias.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'DGV_Facturas
        '
        Me.DGV_Facturas.AllowUserToAddRows = False
        Me.DGV_Facturas.AllowUserToResizeRows = False
        Me.DGV_Facturas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV_Facturas.BackgroundColor = System.Drawing.Color.White
        Me.DGV_Facturas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_Facturas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DGV_Facturas.ColumnHeadersHeight = 40
        Me.DGV_Facturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV_Facturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.C_codigo, Me.C_Descripcion, Me.C_Cantidad, Me.C_Precio, Me.C_Impuesto, Me.C_Total, Me.C_id, Me.C_Fecha, Me.col_impuestos})
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_Facturas.DefaultCellStyle = DataGridViewCellStyle14
        Me.DGV_Facturas.Location = New System.Drawing.Point(16, 254)
        Me.DGV_Facturas.MultiSelect = False
        Me.DGV_Facturas.Name = "DGV_Facturas"
        Me.DGV_Facturas.RowHeadersVisible = False
        Me.DGV_Facturas.Size = New System.Drawing.Size(1062, 324)
        Me.DGV_Facturas.TabIndex = 11
        '
        'C_codigo
        '
        Me.C_codigo.HeaderText = "Codigo del Producto"
        Me.C_codigo.Name = "C_codigo"
        Me.C_codigo.ReadOnly = True
        Me.C_codigo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.C_codigo.Width = 150
        '
        'C_Descripcion
        '
        Me.C_Descripcion.HeaderText = "Descripcion"
        Me.C_Descripcion.MaxInputLength = 300
        Me.C_Descripcion.Name = "C_Descripcion"
        Me.C_Descripcion.ReadOnly = True
        Me.C_Descripcion.Width = 495
        '
        'C_Cantidad
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.C_Cantidad.DefaultCellStyle = DataGridViewCellStyle9
        Me.C_Cantidad.HeaderText = "Cantidad"
        Me.C_Cantidad.MaxInputLength = 18
        Me.C_Cantidad.Name = "C_Cantidad"
        Me.C_Cantidad.Width = 118
        '
        'C_Precio
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.C_Precio.DefaultCellStyle = DataGridViewCellStyle10
        Me.C_Precio.HeaderText = "Precio"
        Me.C_Precio.MaxInputLength = 18
        Me.C_Precio.Name = "C_Precio"
        Me.C_Precio.Width = 118
        '
        'C_Impuesto
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.C_Impuesto.DefaultCellStyle = DataGridViewCellStyle11
        Me.C_Impuesto.HeaderText = "Imp"
        Me.C_Impuesto.MaxInputLength = 100
        Me.C_Impuesto.Name = "C_Impuesto"
        Me.C_Impuesto.Width = 60
        '
        'C_Total
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.C_Total.DefaultCellStyle = DataGridViewCellStyle12
        Me.C_Total.HeaderText = "Total"
        Me.C_Total.MaxInputLength = 18
        Me.C_Total.Name = "C_Total"
        Me.C_Total.ReadOnly = True
        Me.C_Total.Width = 118
        '
        'C_id
        '
        Me.C_id.HeaderText = "id"
        Me.C_id.Name = "C_id"
        Me.C_id.ReadOnly = True
        Me.C_id.Visible = False
        '
        'C_Fecha
        '
        DataGridViewCellStyle13.Format = "G"
        DataGridViewCellStyle13.NullValue = Nothing
        Me.C_Fecha.DefaultCellStyle = DataGridViewCellStyle13
        Me.C_Fecha.HeaderText = "Fecha y Hora"
        Me.C_Fecha.MaxInputLength = 100
        Me.C_Fecha.Name = "C_Fecha"
        Me.C_Fecha.ReadOnly = True
        Me.C_Fecha.Visible = False
        Me.C_Fecha.Width = 130
        '
        'col_impuestos
        '
        Me.col_impuestos.HeaderText = "Impuesto"
        Me.col_impuestos.Name = "col_impuestos"
        Me.col_impuestos.Visible = False
        '
        'lbCondicionVenta
        '
        Me.lbCondicionVenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbCondicionVenta.AutoSize = True
        Me.lbCondicionVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCondicionVenta.Location = New System.Drawing.Point(785, 100)
        Me.lbCondicionVenta.Name = "lbCondicionVenta"
        Me.lbCondicionVenta.Size = New System.Drawing.Size(128, 16)
        Me.lbCondicionVenta.TabIndex = 1007
        Me.lbCondicionVenta.Text = "Condición de Venta:"
        '
        'txtOems
        '
        Me.txtOems.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOems.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOems.Location = New System.Drawing.Point(62, 584)
        Me.txtOems.MaxLength = 1000
        Me.txtOems.Name = "txtOems"
        Me.txtOems.Size = New System.Drawing.Size(1016, 26)
        Me.txtOems.TabIndex = 1011
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(15, 590)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(41, 16)
        Me.Label19.TabIndex = 1012
        Me.Label19.Text = "OEM:"
        '
        'Fr_Crear_Facturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1134, 761)
        Me.Controls.Add(Me.pnlCentral)
        Me.Controls.Add(Me.Lb_Numero_Linea)
        Me.Controls.Add(Me.cb_barcode)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(1150, 800)
        Me.Name = "Fr_Crear_Facturas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturacion"
        Me.GB_Detalles.ResumeLayout(False)
        Me.GB_Detalles.PerformLayout()
        CType(Me.nudCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV_Comentarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cb_barcode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCentral.ResumeLayout(False)
        Me.pnlCentral.PerformLayout()
        CType(Me.nudDias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_numero_copias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Facturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cb_barcode As System.Windows.Forms.PictureBox
    Friend WithEvents Factura As System.Drawing.Printing.PrintDocument
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents CodPro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descrip As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cant As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Prec As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tot As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Lb_Numero_Linea As Label
    Friend WithEvents Lv_Vendedor As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents Txt_Cedula As TextBox
    Friend WithEvents Btn_Nueva_Factura As Button
    Friend WithEvents Btn_Salir As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Btn_Solo_Guardar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Btn_Articulo_Nuevo As Button
    Friend WithEvents Txt_Numero_Factura As TextBox
    Friend WithEvents Dtp_Fecha As DateTimePicker
    Friend WithEvents Btn_Historial As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents Txt_Cambio As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Txt_Pago As TextBox
    Friend WithEvents Lv_Busqueda_Articulos As ListView
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ChCod As ColumnHeader
    Friend WithEvents ChDesc As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents GB_Detalles As GroupBox
    Friend WithEvents lv_BusquedaClientes As ListView
    Friend WithEvents CH_Codigo As ColumnHeader
    Friend WithEvents CH_Cliente As ColumnHeader
    Friend WithEvents Label16 As Label
    Friend WithEvents Chb_Por_Mayor As CheckBox
    Friend WithEvents Btn_Añadir As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Txt_Subtotal_Articulo As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Txt_Precio_Articulo As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Txt_Impuesto_Articulo As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Txt_Descripcion_Articulo As TextBox
    Friend WithEvents Txt_Codigo_Articulo As TextBox
    Friend WithEvents Btn_Eliminar As Button
    Friend WithEvents Btn_Cliente As Button
    Friend WithEvents Btn_Imprimir As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Txt_Descuento As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Txt_Total As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Txt_Descuento_Final As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Txt_Subtotal As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Cb_Vendedor As ComboBox
    Friend WithEvents DGV_Comentarios As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Txt_Codigo_Cliente As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DGV_Facturas As MEPDataGridView
    Friend WithEvents Lb_Retroceder As Label
    Friend WithEvents Lb_Adelantar As Label
    Friend WithEvents chb_cantidad As CheckBox
    Friend WithEvents pnlCentral As Panel
    Friend WithEvents txt_barcode As TextBox
    Friend WithEvents chb_barcode As CheckBox
    Friend WithEvents lb_barcode As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents nud_numero_copias As NumericUpDown
    Friend WithEvents cb_CondicionVenta As ComboBox
    Friend WithEvents lbCondicionVenta As Label
    Friend WithEvents nudDias As NumericUpDown
    Friend WithEvents lbDias As Label
    Friend WithEvents lbCreditoA As Label
    Friend WithEvents txt_TotalImpuestos As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_ImpuestoProducto As TextBox
    Friend WithEvents C_codigo As DataGridViewTextBoxColumn
    Friend WithEvents C_Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents C_Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents C_Precio As DataGridViewTextBoxColumn
    Friend WithEvents C_Impuesto As DataGridViewTextBoxColumn
    Friend WithEvents C_Total As DataGridViewTextBoxColumn
    Friend WithEvents C_id As DataGridViewTextBoxColumn
    Friend WithEvents C_Fecha As DataGridViewTextBoxColumn
    Friend WithEvents col_impuestos As DataGridViewTextBoxColumn
    Friend WithEvents nudCantidad As NumericUpDown
    Friend WithEvents Label19 As Label
    Friend WithEvents txtOems As TextBox
End Class
