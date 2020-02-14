<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fr_Crea_Cotizacion
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fr_Crea_Cotizacion))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Lb_Numero_Linea = New System.Windows.Forms.Label()
        Me.Lv_Clientes = New System.Windows.Forms.ListView()
        Me.CH_Codigo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CH_Cliente = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Btn_Salir = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Btn_Solo_Guardar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_Articulo_Nuevo = New System.Windows.Forms.Button()
        Me.Txt_Numero_Factura = New System.Windows.Forms.TextBox()
        Me.Date_Fecha_Factura = New System.Windows.Forms.DateTimePicker()
        Me.Btn_Historial = New System.Windows.Forms.Button()
        Me.Lv_Busqueda_Articulos = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChCod = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChDesc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_codigo_articulo = New System.Windows.Forms.TextBox()
        Me.lb_barcode = New System.Windows.Forms.Label()
        Me.txt_barcode = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Chb_Por_Mayor = New System.Windows.Forms.CheckBox()
        Me.Btn_Añadir = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Txt_Subtotal_Articulo = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Txt_Precio_Articulo = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Txt_Impuesto_Articulo = New System.Windows.Forms.TextBox()
        Me.Txt_Cantidad_Articulo = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Txt_Descripcion_Articulo = New System.Windows.Forms.TextBox()
        Me.Lv_Id_Vendedor = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Btn_Eliminar = New System.Windows.Forms.Button()
        Me.Btn_Nuevo_Cliente = New System.Windows.Forms.Button()
        Me.Btn_Imprimir = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Txt_Descuento = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
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
        Me.DGV_Facturas = New Facturacion_Esteban.MEPDataGridView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CodPro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_descripcion_cot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_cantidad_cot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_precio_cot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_impuesto_cot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_total_cot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_id_cot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV_Comentarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Facturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.Facturacion_Esteban.My.Resources.Resources.Fondo2
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1134, 657)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel1.Controls.Add(Me.Lb_Numero_Linea)
        Me.Panel1.Controls.Add(Me.Lv_Clientes)
        Me.Panel1.Controls.Add(Me.Btn_Salir)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Btn_Solo_Guardar)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Btn_Articulo_Nuevo)
        Me.Panel1.Controls.Add(Me.Txt_Numero_Factura)
        Me.Panel1.Controls.Add(Me.Date_Fecha_Factura)
        Me.Panel1.Controls.Add(Me.Btn_Historial)
        Me.Panel1.Controls.Add(Me.Lv_Busqueda_Articulos)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.Lv_Id_Vendedor)
        Me.Panel1.Controls.Add(Me.Btn_Eliminar)
        Me.Panel1.Controls.Add(Me.Btn_Nuevo_Cliente)
        Me.Panel1.Controls.Add(Me.Btn_Imprimir)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Txt_Descuento)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Txt_Descuento_Final)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Txt_Subtotal)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Cb_Vendedor)
        Me.Panel1.Controls.Add(Me.DGV_Comentarios)
        Me.Panel1.Controls.Add(Me.Txt_Codigo_Cliente)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.DGV_Facturas)
        Me.Panel1.Location = New System.Drawing.Point(8, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1118, 641)
        Me.Panel1.TabIndex = 1000
        '
        'Lb_Numero_Linea
        '
        Me.Lb_Numero_Linea.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lb_Numero_Linea.BackColor = System.Drawing.Color.Transparent
        Me.Lb_Numero_Linea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Numero_Linea.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lb_Numero_Linea.Location = New System.Drawing.Point(5, 610)
        Me.Lb_Numero_Linea.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_Numero_Linea.Name = "Lb_Numero_Linea"
        Me.Lb_Numero_Linea.Size = New System.Drawing.Size(1111, 21)
        Me.Lb_Numero_Linea.TabIndex = 1002
        Me.Lb_Numero_Linea.Text = "Label1"
        Me.Lb_Numero_Linea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lv_Clientes
        '
        Me.Lv_Clientes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CH_Codigo, Me.CH_Cliente})
        Me.Lv_Clientes.FullRowSelect = True
        Me.Lv_Clientes.GridLines = True
        Me.Lv_Clientes.Location = New System.Drawing.Point(405, 11)
        Me.Lv_Clientes.Name = "Lv_Clientes"
        Me.Lv_Clientes.Size = New System.Drawing.Size(510, 111)
        Me.Lv_Clientes.TabIndex = 1001
        Me.Lv_Clientes.UseCompatibleStateImageBehavior = False
        Me.Lv_Clientes.View = System.Windows.Forms.View.Details
        Me.Lv_Clientes.Visible = False
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
        'Btn_Salir
        '
        Me.Btn_Salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Salir.Location = New System.Drawing.Point(187, 584)
        Me.Btn_Salir.Name = "Btn_Salir"
        Me.Btn_Salir.Size = New System.Drawing.Size(68, 23)
        Me.Btn_Salir.TabIndex = 15
        Me.Btn_Salir.Text = "Salir"
        Me.Btn_Salir.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(825, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 13)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Numero De Cotizacion:"
        '
        'Btn_Solo_Guardar
        '
        Me.Btn_Solo_Guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Solo_Guardar.Location = New System.Drawing.Point(20, 555)
        Me.Btn_Solo_Guardar.Name = "Btn_Solo_Guardar"
        Me.Btn_Solo_Guardar.Size = New System.Drawing.Size(161, 23)
        Me.Btn_Solo_Guardar.TabIndex = 12
        Me.Btn_Solo_Guardar.Text = "Solo Guardar"
        Me.Btn_Solo_Guardar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(888, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Fecha:"
        '
        'Btn_Articulo_Nuevo
        '
        Me.Btn_Articulo_Nuevo.Location = New System.Drawing.Point(20, 98)
        Me.Btn_Articulo_Nuevo.Name = "Btn_Articulo_Nuevo"
        Me.Btn_Articulo_Nuevo.Size = New System.Drawing.Size(115, 23)
        Me.Btn_Articulo_Nuevo.TabIndex = 25
        Me.Btn_Articulo_Nuevo.Text = "Articulo Nuevo"
        Me.Btn_Articulo_Nuevo.UseVisualStyleBackColor = True
        '
        'Txt_Numero_Factura
        '
        Me.Txt_Numero_Factura.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_Numero_Factura.BackColor = System.Drawing.Color.DarkCyan
        Me.Txt_Numero_Factura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Numero_Factura.ForeColor = System.Drawing.SystemColors.Window
        Me.Txt_Numero_Factura.Location = New System.Drawing.Point(942, 72)
        Me.Txt_Numero_Factura.Name = "Txt_Numero_Factura"
        Me.Txt_Numero_Factura.ReadOnly = True
        Me.Txt_Numero_Factura.Size = New System.Drawing.Size(151, 22)
        Me.Txt_Numero_Factura.TabIndex = 21
        Me.Txt_Numero_Factura.Text = "54564"
        Me.Txt_Numero_Factura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Date_Fecha_Factura
        '
        Me.Date_Fecha_Factura.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Date_Fecha_Factura.CustomFormat = "dd/MM/yyyy hh:mm:ss"
        Me.Date_Fecha_Factura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Date_Fecha_Factura.Location = New System.Drawing.Point(942, 43)
        Me.Date_Fecha_Factura.Name = "Date_Fecha_Factura"
        Me.Date_Fecha_Factura.Size = New System.Drawing.Size(151, 20)
        Me.Date_Fecha_Factura.TabIndex = 20
        '
        'Btn_Historial
        '
        Me.Btn_Historial.Location = New System.Drawing.Point(20, 73)
        Me.Btn_Historial.Name = "Btn_Historial"
        Me.Btn_Historial.Size = New System.Drawing.Size(115, 23)
        Me.Btn_Historial.TabIndex = 24
        Me.Btn_Historial.Text = "Historial"
        Me.Btn_Historial.UseVisualStyleBackColor = True
        '
        'Lv_Busqueda_Articulos
        '
        Me.Lv_Busqueda_Articulos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ChCod, Me.ChDesc, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.Lv_Busqueda_Articulos.FullRowSelect = True
        Me.Lv_Busqueda_Articulos.GridLines = True
        Me.Lv_Busqueda_Articulos.Location = New System.Drawing.Point(220, 220)
        Me.Lv_Busqueda_Articulos.Name = "Lv_Busqueda_Articulos"
        Me.Lv_Busqueda_Articulos.Size = New System.Drawing.Size(614, 161)
        Me.Lv_Busqueda_Articulos.TabIndex = 70
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
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.Aquamarine
        Me.GroupBox2.Controls.Add(Me.txt_codigo_articulo)
        Me.GroupBox2.Controls.Add(Me.lb_barcode)
        Me.GroupBox2.Controls.Add(Me.txt_barcode)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Chb_Por_Mayor)
        Me.GroupBox2.Controls.Add(Me.Btn_Añadir)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Txt_Subtotal_Articulo)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Txt_Precio_Articulo)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Txt_Impuesto_Articulo)
        Me.GroupBox2.Controls.Add(Me.Txt_Cantidad_Articulo)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Txt_Descripcion_Articulo)
        Me.GroupBox2.Location = New System.Drawing.Point(20, 129)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1076, 100)
        Me.GroupBox2.TabIndex = 73
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalles"
        '
        'txt_codigo_articulo
        '
        Me.txt_codigo_articulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_codigo_articulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_codigo_articulo.Location = New System.Drawing.Point(200, 63)
        Me.txt_codigo_articulo.MaxLength = 20
        Me.txt_codigo_articulo.Name = "txt_codigo_articulo"
        Me.txt_codigo_articulo.Size = New System.Drawing.Size(100, 22)
        Me.txt_codigo_articulo.TabIndex = 1001
        '
        'lb_barcode
        '
        Me.lb_barcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_barcode.ForeColor = System.Drawing.Color.DarkBlue
        Me.lb_barcode.Location = New System.Drawing.Point(12, 42)
        Me.lb_barcode.Name = "lb_barcode"
        Me.lb_barcode.Size = New System.Drawing.Size(179, 17)
        Me.lb_barcode.TabIndex = 45
        Me.lb_barcode.Text = "DESCRIPCION"
        Me.lb_barcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lb_barcode.Visible = False
        '
        'txt_barcode
        '
        Me.txt_barcode.BackColor = System.Drawing.SystemColors.Window
        Me.txt_barcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_barcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_barcode.Location = New System.Drawing.Point(12, 63)
        Me.txt_barcode.MaxLength = 50
        Me.txt_barcode.Name = "txt_barcode"
        Me.txt_barcode.Size = New System.Drawing.Size(182, 22)
        Me.txt_barcode.TabIndex = 44
        Me.txt_barcode.Text = "BARCODE"
        Me.txt_barcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(810, 42)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(31, 16)
        Me.Label16.TabIndex = 39
        Me.Label16.Text = "IMP"
        '
        'Chb_Por_Mayor
        '
        Me.Chb_Por_Mayor.AutoSize = True
        Me.Chb_Por_Mayor.Location = New System.Drawing.Point(15, 17)
        Me.Chb_Por_Mayor.Name = "Chb_Por_Mayor"
        Me.Chb_Por_Mayor.Size = New System.Drawing.Size(74, 17)
        Me.Chb_Por_Mayor.TabIndex = 3
        Me.Chb_Por_Mayor.Text = "Por Mayor"
        Me.Chb_Por_Mayor.UseVisualStyleBackColor = True
        '
        'Btn_Añadir
        '
        Me.Btn_Añadir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Añadir.Location = New System.Drawing.Point(977, 61)
        Me.Btn_Añadir.Name = "Btn_Añadir"
        Me.Btn_Añadir.Size = New System.Drawing.Size(89, 23)
        Me.Btn_Añadir.TabIndex = 10
        Me.Btn_Añadir.Text = "Añadir"
        Me.Btn_Añadir.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(869, 42)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 16)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "SUBTOTAL"
        '
        'Txt_Subtotal_Articulo
        '
        Me.Txt_Subtotal_Articulo.BackColor = System.Drawing.Color.Yellow
        Me.Txt_Subtotal_Articulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Subtotal_Articulo.Location = New System.Drawing.Point(872, 63)
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
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(710, 42)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 16)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "PRECIO"
        '
        'Txt_Precio_Articulo
        '
        Me.Txt_Precio_Articulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Precio_Articulo.Location = New System.Drawing.Point(706, 63)
        Me.Txt_Precio_Articulo.MaxLength = 12
        Me.Txt_Precio_Articulo.Name = "Txt_Precio_Articulo"
        Me.Txt_Precio_Articulo.Size = New System.Drawing.Size(100, 22)
        Me.Txt_Precio_Articulo.TabIndex = 7
        Me.Txt_Precio_Articulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(627, 42)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 16)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "CANTIDAD"
        '
        'Txt_Impuesto_Articulo
        '
        Me.Txt_Impuesto_Articulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Impuesto_Articulo.Location = New System.Drawing.Point(813, 63)
        Me.Txt_Impuesto_Articulo.MaxLength = 3
        Me.Txt_Impuesto_Articulo.Name = "Txt_Impuesto_Articulo"
        Me.Txt_Impuesto_Articulo.Size = New System.Drawing.Size(53, 22)
        Me.Txt_Impuesto_Articulo.TabIndex = 8
        Me.Txt_Impuesto_Articulo.Text = "0"
        Me.Txt_Impuesto_Articulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txt_Cantidad_Articulo
        '
        Me.Txt_Cantidad_Articulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Cantidad_Articulo.Location = New System.Drawing.Point(626, 63)
        Me.Txt_Cantidad_Articulo.MaxLength = 12
        Me.Txt_Cantidad_Articulo.Name = "Txt_Cantidad_Articulo"
        Me.Txt_Cantidad_Articulo.Size = New System.Drawing.Size(73, 22)
        Me.Txt_Cantidad_Articulo.TabIndex = 6
        Me.Txt_Cantidad_Articulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(308, 42)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(99, 16)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "DESCRIPCION"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(197, 42)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 16)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "CODIGO"
        '
        'Txt_Descripcion_Articulo
        '
        Me.Txt_Descripcion_Articulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Descripcion_Articulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Descripcion_Articulo.Location = New System.Drawing.Point(306, 63)
        Me.Txt_Descripcion_Articulo.MaxLength = 100
        Me.Txt_Descripcion_Articulo.Name = "Txt_Descripcion_Articulo"
        Me.Txt_Descripcion_Articulo.ReadOnly = True
        Me.Txt_Descripcion_Articulo.Size = New System.Drawing.Size(314, 22)
        Me.Txt_Descripcion_Articulo.TabIndex = 5
        '
        'Lv_Id_Vendedor
        '
        Me.Lv_Id_Vendedor.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.Lv_Id_Vendedor.FullRowSelect = True
        Me.Lv_Id_Vendedor.GridLines = True
        Me.Lv_Id_Vendedor.Location = New System.Drawing.Point(356, 522)
        Me.Lv_Id_Vendedor.Name = "Lv_Id_Vendedor"
        Me.Lv_Id_Vendedor.Size = New System.Drawing.Size(219, 94)
        Me.Lv_Id_Vendedor.TabIndex = 72
        Me.Lv_Id_Vendedor.UseCompatibleStateImageBehavior = False
        Me.Lv_Id_Vendedor.View = System.Windows.Forms.View.Details
        Me.Lv_Id_Vendedor.Visible = False
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
        'Btn_Eliminar
        '
        Me.Btn_Eliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Eliminar.Location = New System.Drawing.Point(187, 555)
        Me.Btn_Eliminar.Name = "Btn_Eliminar"
        Me.Btn_Eliminar.Size = New System.Drawing.Size(68, 23)
        Me.Btn_Eliminar.TabIndex = 13
        Me.Btn_Eliminar.Text = "Eliminar"
        Me.Btn_Eliminar.UseVisualStyleBackColor = True
        '
        'Btn_Nuevo_Cliente
        '
        Me.Btn_Nuevo_Cliente.Location = New System.Drawing.Point(20, 47)
        Me.Btn_Nuevo_Cliente.Name = "Btn_Nuevo_Cliente"
        Me.Btn_Nuevo_Cliente.Size = New System.Drawing.Size(115, 23)
        Me.Btn_Nuevo_Cliente.TabIndex = 23
        Me.Btn_Nuevo_Cliente.Text = "Nuevo Cliente"
        Me.Btn_Nuevo_Cliente.UseVisualStyleBackColor = True
        '
        'Btn_Imprimir
        '
        Me.Btn_Imprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Imprimir.Location = New System.Drawing.Point(20, 584)
        Me.Btn_Imprimir.Name = "Btn_Imprimir"
        Me.Btn_Imprimir.Size = New System.Drawing.Size(161, 23)
        Me.Btn_Imprimir.TabIndex = 14
        Me.Btn_Imprimir.Text = "IMPRIMIR F9"
        Me.Btn_Imprimir.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(868, 106)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 16)
        Me.Label10.TabIndex = 66
        Me.Label10.Text = "Vendedor"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(751, 573)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(15, 13)
        Me.Label9.TabIndex = 65
        Me.Label9.Text = "%"
        '
        'Txt_Descuento
        '
        Me.Txt_Descuento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_Descuento.ForeColor = System.Drawing.Color.DarkBlue
        Me.Txt_Descuento.Location = New System.Drawing.Point(686, 570)
        Me.Txt_Descuento.Name = "Txt_Descuento"
        Me.Txt_Descuento.Size = New System.Drawing.Size(59, 20)
        Me.Txt_Descuento.TabIndex = 15
        Me.Txt_Descuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Txt_Total)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(872, 527)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(221, 68)
        Me.GroupBox1.TabIndex = 1000
        Me.GroupBox1.TabStop = False
        '
        'Txt_Total
        '
        Me.Txt_Total.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Total.ForeColor = System.Drawing.Color.Red
        Me.Txt_Total.Location = New System.Drawing.Point(57, 29)
        Me.Txt_Total.Name = "Txt_Total"
        Me.Txt_Total.Size = New System.Drawing.Size(158, 26)
        Me.Txt_Total.TabIndex = 2000
        Me.Txt_Total.Text = "0,00"
        Me.Txt_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "TOTAL:"
        '
        'Txt_Descuento_Final
        '
        Me.Txt_Descuento_Final.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_Descuento_Final.Location = New System.Drawing.Point(766, 570)
        Me.Txt_Descuento_Final.Name = "Txt_Descuento_Final"
        Me.Txt_Descuento_Final.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Descuento_Final.TabIndex = 18
        Me.Txt_Descuento_Final.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(643, 573)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "Desc:"
        '
        'Txt_Subtotal
        '
        Me.Txt_Subtotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_Subtotal.Location = New System.Drawing.Point(766, 541)
        Me.Txt_Subtotal.Name = "Txt_Subtotal"
        Me.Txt_Subtotal.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Subtotal.TabIndex = 17
        Me.Txt_Subtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(694, 541)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "SubTotal:"
        '
        'Cb_Vendedor
        '
        Me.Cb_Vendedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cb_Vendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Vendedor.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_Vendedor.FormattingEnabled = True
        Me.Cb_Vendedor.Location = New System.Drawing.Point(942, 100)
        Me.Cb_Vendedor.Name = "Cb_Vendedor"
        Me.Cb_Vendedor.Size = New System.Drawing.Size(151, 23)
        Me.Cb_Vendedor.TabIndex = 22
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
        Me.DGV_Comentarios.Location = New System.Drawing.Point(141, 47)
        Me.DGV_Comentarios.Name = "DGV_Comentarios"
        Me.DGV_Comentarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_Comentarios.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_Comentarios.RowHeadersVisible = False
        Me.DGV_Comentarios.RowTemplate.Height = 23
        Me.DGV_Comentarios.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DGV_Comentarios.Size = New System.Drawing.Size(258, 76)
        Me.DGV_Comentarios.TabIndex = 2
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
        Me.Txt_Codigo_Cliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Codigo_Cliente.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Codigo_Cliente.Location = New System.Drawing.Point(141, 17)
        Me.Txt_Codigo_Cliente.MaxLength = 20
        Me.Txt_Codigo_Cliente.Name = "Txt_Codigo_Cliente"
        Me.Txt_Codigo_Cliente.Size = New System.Drawing.Size(258, 23)
        Me.Txt_Codigo_Cliente.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 16)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Codigo del Cliente"
        '
        'DGV_Facturas
        '
        Me.DGV_Facturas.AllowUserToAddRows = False
        Me.DGV_Facturas.AllowUserToResizeRows = False
        Me.DGV_Facturas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV_Facturas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGV_Facturas.ColumnHeadersHeight = 40
        Me.DGV_Facturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodPro, Me.c_descripcion_cot, Me.c_cantidad_cot, Me.c_precio_cot, Me.c_impuesto_cot, Me.c_total_cot, Me.c_id_cot, Me.Column4})
        Me.DGV_Facturas.Location = New System.Drawing.Point(20, 236)
        Me.DGV_Facturas.MultiSelect = False
        Me.DGV_Facturas.Name = "DGV_Facturas"
        Me.DGV_Facturas.RowHeadersVisible = False
        Me.DGV_Facturas.Size = New System.Drawing.Size(1076, 285)
        Me.DGV_Facturas.TabIndex = 11
        '
        'Timer1
        '
        '
        'CodPro
        '
        Me.CodPro.FillWeight = 1.0!
        Me.CodPro.HeaderText = "Codigo del Producto"
        Me.CodPro.MaxInputLength = 150
        Me.CodPro.Name = "CodPro"
        Me.CodPro.ReadOnly = True
        Me.CodPro.Width = 150
        '
        'c_descripcion_cot
        '
        Me.c_descripcion_cot.FillWeight = 1.0!
        Me.c_descripcion_cot.HeaderText = "Descripcion"
        Me.c_descripcion_cot.MaxInputLength = 300
        Me.c_descripcion_cot.Name = "c_descripcion_cot"
        Me.c_descripcion_cot.ReadOnly = True
        Me.c_descripcion_cot.Width = 379
        '
        'c_cantidad_cot
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.c_cantidad_cot.DefaultCellStyle = DataGridViewCellStyle4
        Me.c_cantidad_cot.FillWeight = 1.0!
        Me.c_cantidad_cot.HeaderText = "Cantidad"
        Me.c_cantidad_cot.MaxInputLength = 50
        Me.c_cantidad_cot.Name = "c_cantidad_cot"
        Me.c_cantidad_cot.Width = 118
        '
        'c_precio_cot
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.c_precio_cot.DefaultCellStyle = DataGridViewCellStyle5
        Me.c_precio_cot.FillWeight = 1.0!
        Me.c_precio_cot.HeaderText = "Precio"
        Me.c_precio_cot.MaxInputLength = 50
        Me.c_precio_cot.Name = "c_precio_cot"
        Me.c_precio_cot.Width = 118
        '
        'c_impuesto_cot
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.c_impuesto_cot.DefaultCellStyle = DataGridViewCellStyle6
        Me.c_impuesto_cot.FillWeight = 1.0!
        Me.c_impuesto_cot.HeaderText = "Imp"
        Me.c_impuesto_cot.Name = "c_impuesto_cot"
        Me.c_impuesto_cot.Width = 60
        '
        'c_total_cot
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.c_total_cot.DefaultCellStyle = DataGridViewCellStyle7
        Me.c_total_cot.FillWeight = 1.0!
        Me.c_total_cot.HeaderText = "Total"
        Me.c_total_cot.MaxInputLength = 80
        Me.c_total_cot.Name = "c_total_cot"
        Me.c_total_cot.ReadOnly = True
        Me.c_total_cot.Width = 118
        '
        'c_id_cot
        '
        Me.c_id_cot.HeaderText = "id"
        Me.c_id_cot.Name = "c_id_cot"
        Me.c_id_cot.ReadOnly = True
        Me.c_id_cot.Visible = False
        '
        'Column4
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle8
        Me.Column4.FillWeight = 1.0!
        Me.Column4.HeaderText = "Fecha y Hora"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 130
        '
        'Fr_Crea_Cotizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1134, 657)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(1150, 680)
        Me.Name = "Fr_Crea_Cotizacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cotizaciones"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV_Comentarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Facturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Btn_Salir As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Btn_Solo_Guardar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Btn_Articulo_Nuevo As System.Windows.Forms.Button
    Friend WithEvents Txt_Numero_Factura As System.Windows.Forms.TextBox
    Friend WithEvents Date_Fecha_Factura As System.Windows.Forms.DateTimePicker
    Friend WithEvents Btn_Historial As System.Windows.Forms.Button
    Friend WithEvents Lv_Busqueda_Articulos As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ChCod As System.Windows.Forms.ColumnHeader
    Friend WithEvents ChDesc As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Chb_Por_Mayor As System.Windows.Forms.CheckBox
    Friend WithEvents Btn_Añadir As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Txt_Subtotal_Articulo As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Txt_Precio_Articulo As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Txt_Impuesto_Articulo As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Cantidad_Articulo As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Txt_Descripcion_Articulo As System.Windows.Forms.TextBox
    Friend WithEvents Lv_Id_Vendedor As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents Btn_Nuevo_Cliente As System.Windows.Forms.Button
    Friend WithEvents Btn_Imprimir As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Txt_Descuento As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Txt_Total As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Txt_Descuento_Final As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Txt_Subtotal As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Cb_Vendedor As System.Windows.Forms.ComboBox
    Friend WithEvents DGV_Comentarios As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Txt_Codigo_Cliente As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DGV_Facturas As Facturacion_Esteban.MEPDataGridView
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lb_barcode As Label
    Friend WithEvents txt_barcode As TextBox
    Friend WithEvents Lv_Clientes As ListView
    Friend WithEvents CH_Codigo As ColumnHeader
    Friend WithEvents CH_Cliente As ColumnHeader
    Friend WithEvents txt_codigo_articulo As TextBox
    Friend WithEvents Lb_Numero_Linea As Label
    Friend WithEvents CodPro As DataGridViewTextBoxColumn
    Friend WithEvents c_descripcion_cot As DataGridViewTextBoxColumn
    Friend WithEvents c_cantidad_cot As DataGridViewTextBoxColumn
    Friend WithEvents c_precio_cot As DataGridViewTextBoxColumn
    Friend WithEvents c_impuesto_cot As DataGridViewTextBoxColumn
    Friend WithEvents c_total_cot As DataGridViewTextBoxColumn
    Friend WithEvents c_id_cot As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
