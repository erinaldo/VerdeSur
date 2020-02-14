<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fr_Facturas
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fr_Facturas))
        Me.Tab_Opciones = New System.Windows.Forms.TabControl()
        Me.TabP_Facturas_Cerradas = New System.Windows.Forms.TabPage()
        Me.lb_tiempo = New System.Windows.Forms.Label()
        Me.btn_revisar = New System.Windows.Forms.Button()
        Me.Dgv_facturas_cerradas = New Facturacion_Esteban.MEPDataGridView()
        Me.c_nro_factura_c = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_fecha_c = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_cliente_c = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_vendedor_c = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_total_c = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_id_cerrada_c = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Btn_Modificar_1 = New System.Windows.Forms.Button()
        Me.Btn_Imprimir_1 = New System.Windows.Forms.Button()
        Me.Btn_Eliminar_1 = New System.Windows.Forms.Button()
        Me.Btn_Salir_1 = New System.Windows.Forms.Button()
        Me.Btn_Crear_1 = New System.Windows.Forms.Button()
        Me.TabP_Facturas_Abiertas = New System.Windows.Forms.TabPage()
        Me.dgv_facturas_abiertas = New Facturacion_Esteban.MEPDataGridView()
        Me.c_cerrar_factura = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.c_nro_factura_a = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_fecha_a = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_cliente_a = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_vendedor_a = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_total_a = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_id_a = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Lb_Mensaje = New System.Windows.Forms.Label()
        Me.Btn_Agregar_2 = New System.Windows.Forms.Button()
        Me.Btn_Cerrar_Factura_2 = New System.Windows.Forms.Button()
        Me.TabP_Reportes = New System.Windows.Forms.TabPage()
        Me.btnTiquete = New System.Windows.Forms.Button()
        Me.btn_productos = New System.Windows.Forms.Button()
        Me.Btn_Reporte_Vendedor_3 = New System.Windows.Forms.Button()
        Me.Lv_Id_Vendedor_3 = New System.Windows.Forms.ListView()
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Btn_Reporte_Cliente_3 = New System.Windows.Forms.Button()
        Me.Btn_Reporte_Fecha_3 = New System.Windows.Forms.Button()
        Me.TabP_Facturas_Cobrar = New System.Windows.Forms.TabPage()
        Me.Btn_Limpiar_FactXCobrar_4 = New System.Windows.Forms.Button()
        Me.Btn_Cargar_4 = New System.Windows.Forms.Button()
        Me.Btn_Eliminar_Fila_4 = New System.Windows.Forms.Button()
        Me.Lb_Total_4 = New System.Windows.Forms.Label()
        Me.Lb_Monto_4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_Total_4 = New System.Windows.Forms.TextBox()
        Me.Lv_Detalle_Fact_X_Cobrar_4 = New System.Windows.Forms.ListView()
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Txt_Monto_4 = New System.Windows.Forms.TextBox()
        Me.Txt_Nombre_Cliente_4 = New System.Windows.Forms.TextBox()
        Me.Txt_Numero_Factura_4 = New System.Windows.Forms.TextBox()
        Me.TabP_Cotizacion = New System.Windows.Forms.TabPage()
        Me.dgv_cotizaciones = New Facturacion_Esteban.MEPDataGridView()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Btn_Convertir_5 = New System.Windows.Forms.Button()
        Me.Btn_Eliminar_Cotizacion_5 = New System.Windows.Forms.Button()
        Me.Btn_Imprimir_Cotizacion_5 = New System.Windows.Forms.Button()
        Me.Btn_Modificar_Cotizacion_5 = New System.Windows.Forms.Button()
        Me.Btn_Crear_Cotizacion_5 = New System.Windows.Forms.Button()
        Me.Txt_Busqueda_Cotizacion_5 = New System.Windows.Forms.TextBox()
        Me.Txt_Busqueda_Nombre = New System.Windows.Forms.TextBox()
        Me.Txt_Busqueda_Numero = New System.Windows.Forms.TextBox()
        Me.lb_vendedor = New System.Windows.Forms.Label()
        Me.Chb_Vendedor = New System.Windows.Forms.ComboBox()
        Me.Btn_Actualizar_Vendedor = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PB_Facturas = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TabFacturasPagadas = New System.Windows.Forms.TabPage()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvPagada = New Facturacion_Esteban.MEPDataGridView()
        Me.Tab_Opciones.SuspendLayout()
        Me.TabP_Facturas_Cerradas.SuspendLayout()
        CType(Me.Dgv_facturas_cerradas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabP_Facturas_Abiertas.SuspendLayout()
        CType(Me.dgv_facturas_abiertas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabP_Reportes.SuspendLayout()
        Me.TabP_Facturas_Cobrar.SuspendLayout()
        Me.TabP_Cotizacion.SuspendLayout()
        CType(Me.dgv_cotizaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_Facturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabFacturasPagadas.SuspendLayout()
        CType(Me.dgvPagada, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tab_Opciones
        '
        Me.Tab_Opciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tab_Opciones.Controls.Add(Me.TabP_Facturas_Cerradas)
        Me.Tab_Opciones.Controls.Add(Me.TabP_Facturas_Abiertas)
        Me.Tab_Opciones.Controls.Add(Me.TabFacturasPagadas)
        Me.Tab_Opciones.Controls.Add(Me.TabP_Reportes)
        Me.Tab_Opciones.Controls.Add(Me.TabP_Facturas_Cobrar)
        Me.Tab_Opciones.Controls.Add(Me.TabP_Cotizacion)
        Me.Tab_Opciones.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab_Opciones.Location = New System.Drawing.Point(22, 80)
        Me.Tab_Opciones.Name = "Tab_Opciones"
        Me.Tab_Opciones.SelectedIndex = 0
        Me.Tab_Opciones.Size = New System.Drawing.Size(838, 372)
        Me.Tab_Opciones.TabIndex = 0
        '
        'TabP_Facturas_Cerradas
        '
        Me.TabP_Facturas_Cerradas.BackColor = System.Drawing.Color.Gainsboro
        Me.TabP_Facturas_Cerradas.Controls.Add(Me.lb_tiempo)
        Me.TabP_Facturas_Cerradas.Controls.Add(Me.btn_revisar)
        Me.TabP_Facturas_Cerradas.Controls.Add(Me.Dgv_facturas_cerradas)
        Me.TabP_Facturas_Cerradas.Controls.Add(Me.Btn_Modificar_1)
        Me.TabP_Facturas_Cerradas.Controls.Add(Me.Btn_Imprimir_1)
        Me.TabP_Facturas_Cerradas.Controls.Add(Me.Btn_Eliminar_1)
        Me.TabP_Facturas_Cerradas.Controls.Add(Me.Btn_Salir_1)
        Me.TabP_Facturas_Cerradas.Controls.Add(Me.Btn_Crear_1)
        Me.TabP_Facturas_Cerradas.Location = New System.Drawing.Point(4, 25)
        Me.TabP_Facturas_Cerradas.Name = "TabP_Facturas_Cerradas"
        Me.TabP_Facturas_Cerradas.Padding = New System.Windows.Forms.Padding(3)
        Me.TabP_Facturas_Cerradas.Size = New System.Drawing.Size(830, 343)
        Me.TabP_Facturas_Cerradas.TabIndex = 0
        Me.TabP_Facturas_Cerradas.Text = "Facturas"
        '
        'lb_tiempo
        '
        Me.lb_tiempo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lb_tiempo.Location = New System.Drawing.Point(6, 313)
        Me.lb_tiempo.Name = "lb_tiempo"
        Me.lb_tiempo.Size = New System.Drawing.Size(75, 16)
        Me.lb_tiempo.TabIndex = 35
        Me.lb_tiempo.Text = "0"
        Me.lb_tiempo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_revisar
        '
        Me.btn_revisar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_revisar.Location = New System.Drawing.Point(6, 281)
        Me.btn_revisar.Name = "btn_revisar"
        Me.btn_revisar.Size = New System.Drawing.Size(75, 29)
        Me.btn_revisar.TabIndex = 9
        Me.btn_revisar.Text = "Revisar"
        Me.btn_revisar.UseVisualStyleBackColor = True
        '
        'Dgv_facturas_cerradas
        '
        Me.Dgv_facturas_cerradas.AllowUserToAddRows = False
        Me.Dgv_facturas_cerradas.AllowUserToDeleteRows = False
        Me.Dgv_facturas_cerradas.AllowUserToOrderColumns = True
        Me.Dgv_facturas_cerradas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dgv_facturas_cerradas.ColumnHeadersHeight = 40
        Me.Dgv_facturas_cerradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Dgv_facturas_cerradas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.c_nro_factura_c, Me.c_fecha_c, Me.c_cliente_c, Me.c_vendedor_c, Me.c_total_c, Me.c_id_cerrada_c})
        Me.Dgv_facturas_cerradas.Location = New System.Drawing.Point(6, 6)
        Me.Dgv_facturas_cerradas.MultiSelect = False
        Me.Dgv_facturas_cerradas.Name = "Dgv_facturas_cerradas"
        Me.Dgv_facturas_cerradas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_facturas_cerradas.Size = New System.Drawing.Size(818, 261)
        Me.Dgv_facturas_cerradas.TabIndex = 8
        '
        'c_nro_factura_c
        '
        Me.c_nro_factura_c.HeaderText = "Nro. Factura"
        Me.c_nro_factura_c.Name = "c_nro_factura_c"
        Me.c_nro_factura_c.ReadOnly = True
        Me.c_nro_factura_c.Width = 95
        '
        'c_fecha_c
        '
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.c_fecha_c.DefaultCellStyle = DataGridViewCellStyle1
        Me.c_fecha_c.HeaderText = "Fecha"
        Me.c_fecha_c.Name = "c_fecha_c"
        Me.c_fecha_c.ReadOnly = True
        Me.c_fecha_c.Width = 98
        '
        'c_cliente_c
        '
        Me.c_cliente_c.HeaderText = "Vendido A:"
        Me.c_cliente_c.Name = "c_cliente_c"
        Me.c_cliente_c.ReadOnly = True
        Me.c_cliente_c.Width = 335
        '
        'c_vendedor_c
        '
        Me.c_vendedor_c.HeaderText = "Vendedor"
        Me.c_vendedor_c.Name = "c_vendedor_c"
        Me.c_vendedor_c.ReadOnly = True
        '
        'c_total_c
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.c_total_c.DefaultCellStyle = DataGridViewCellStyle2
        Me.c_total_c.HeaderText = "Total C."
        Me.c_total_c.Name = "c_total_c"
        Me.c_total_c.ReadOnly = True
        Me.c_total_c.Width = 130
        '
        'c_id_cerrada_c
        '
        Me.c_id_cerrada_c.HeaderText = "factura cerrada id"
        Me.c_id_cerrada_c.Name = "c_id_cerrada_c"
        Me.c_id_cerrada_c.ReadOnly = True
        Me.c_id_cerrada_c.Visible = False
        '
        'Btn_Modificar_1
        '
        Me.Btn_Modificar_1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Btn_Modificar_1.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic)
        Me.Btn_Modificar_1.Image = Global.Facturacion_Esteban.My.Resources.Resources.Modificarof
        Me.Btn_Modificar_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Modificar_1.Location = New System.Drawing.Point(764, 273)
        Me.Btn_Modificar_1.Name = "Btn_Modificar_1"
        Me.Btn_Modificar_1.Size = New System.Drawing.Size(48, 56)
        Me.Btn_Modificar_1.TabIndex = 6
        Me.Btn_Modificar_1.Text = "Modificar"
        Me.Btn_Modificar_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Modificar_1.UseVisualStyleBackColor = True
        Me.Btn_Modificar_1.Visible = False
        '
        'Btn_Imprimir_1
        '
        Me.Btn_Imprimir_1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Btn_Imprimir_1.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Imprimir_1.Image = Global.Facturacion_Esteban.My.Resources.Resources.Print
        Me.Btn_Imprimir_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Imprimir_1.Location = New System.Drawing.Point(222, 274)
        Me.Btn_Imprimir_1.Name = "Btn_Imprimir_1"
        Me.Btn_Imprimir_1.Size = New System.Drawing.Size(129, 56)
        Me.Btn_Imprimir_1.TabIndex = 5
        Me.Btn_Imprimir_1.Text = "Imprimir"
        Me.Btn_Imprimir_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Imprimir_1.UseVisualStyleBackColor = True
        '
        'Btn_Eliminar_1
        '
        Me.Btn_Eliminar_1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Btn_Eliminar_1.Font = New System.Drawing.Font("Calisto MT", 14.25!)
        Me.Btn_Eliminar_1.Image = Global.Facturacion_Esteban.My.Resources.Resources.trashcan
        Me.Btn_Eliminar_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Eliminar_1.Location = New System.Drawing.Point(357, 274)
        Me.Btn_Eliminar_1.Name = "Btn_Eliminar_1"
        Me.Btn_Eliminar_1.Size = New System.Drawing.Size(136, 56)
        Me.Btn_Eliminar_1.TabIndex = 7
        Me.Btn_Eliminar_1.Text = "Eliminar"
        Me.Btn_Eliminar_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Eliminar_1.UseVisualStyleBackColor = True
        '
        'Btn_Salir_1
        '
        Me.Btn_Salir_1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Btn_Salir_1.Font = New System.Drawing.Font("Calisto MT", 14.25!)
        Me.Btn_Salir_1.Image = Global.Facturacion_Esteban.My.Resources.Resources.exit_azul
        Me.Btn_Salir_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Salir_1.Location = New System.Drawing.Point(499, 274)
        Me.Btn_Salir_1.Name = "Btn_Salir_1"
        Me.Btn_Salir_1.Size = New System.Drawing.Size(99, 56)
        Me.Btn_Salir_1.TabIndex = 2
        Me.Btn_Salir_1.Text = "Salir"
        Me.Btn_Salir_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Salir_1.UseVisualStyleBackColor = True
        '
        'Btn_Crear_1
        '
        Me.Btn_Crear_1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Btn_Crear_1.Font = New System.Drawing.Font("Calisto MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Crear_1.Image = Global.Facturacion_Esteban.My.Resources.Resources.InvoiceOff
        Me.Btn_Crear_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Crear_1.Location = New System.Drawing.Point(91, 273)
        Me.Btn_Crear_1.Name = "Btn_Crear_1"
        Me.Btn_Crear_1.Size = New System.Drawing.Size(125, 56)
        Me.Btn_Crear_1.TabIndex = 1
        Me.Btn_Crear_1.Text = "Crear"
        Me.Btn_Crear_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Crear_1.UseVisualStyleBackColor = True
        '
        'TabP_Facturas_Abiertas
        '
        Me.TabP_Facturas_Abiertas.BackColor = System.Drawing.Color.Gainsboro
        Me.TabP_Facturas_Abiertas.Controls.Add(Me.dgv_facturas_abiertas)
        Me.TabP_Facturas_Abiertas.Controls.Add(Me.Button1)
        Me.TabP_Facturas_Abiertas.Controls.Add(Me.Lb_Mensaje)
        Me.TabP_Facturas_Abiertas.Controls.Add(Me.Btn_Agregar_2)
        Me.TabP_Facturas_Abiertas.Controls.Add(Me.Btn_Cerrar_Factura_2)
        Me.TabP_Facturas_Abiertas.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabP_Facturas_Abiertas.Location = New System.Drawing.Point(4, 25)
        Me.TabP_Facturas_Abiertas.Name = "TabP_Facturas_Abiertas"
        Me.TabP_Facturas_Abiertas.Padding = New System.Windows.Forms.Padding(3)
        Me.TabP_Facturas_Abiertas.Size = New System.Drawing.Size(830, 343)
        Me.TabP_Facturas_Abiertas.TabIndex = 1
        Me.TabP_Facturas_Abiertas.Text = "Facturas A Credito"
        '
        'dgv_facturas_abiertas
        '
        Me.dgv_facturas_abiertas.AllowUserToAddRows = False
        Me.dgv_facturas_abiertas.AllowUserToDeleteRows = False
        Me.dgv_facturas_abiertas.AllowUserToOrderColumns = True
        Me.dgv_facturas_abiertas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_facturas_abiertas.ColumnHeadersHeight = 40
        Me.dgv_facturas_abiertas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_facturas_abiertas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.c_cerrar_factura, Me.c_nro_factura_a, Me.c_fecha_a, Me.c_cliente_a, Me.c_vendedor_a, Me.c_total_a, Me.c_id_a})
        Me.dgv_facturas_abiertas.Location = New System.Drawing.Point(6, 11)
        Me.dgv_facturas_abiertas.MultiSelect = False
        Me.dgv_facturas_abiertas.Name = "dgv_facturas_abiertas"
        Me.dgv_facturas_abiertas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_facturas_abiertas.Size = New System.Drawing.Size(818, 268)
        Me.dgv_facturas_abiertas.TabIndex = 19
        '
        'c_cerrar_factura
        '
        Me.c_cerrar_factura.HeaderText = ""
        Me.c_cerrar_factura.Name = "c_cerrar_factura"
        Me.c_cerrar_factura.Width = 40
        '
        'c_nro_factura_a
        '
        Me.c_nro_factura_a.HeaderText = "Nro. Factura"
        Me.c_nro_factura_a.Name = "c_nro_factura_a"
        Me.c_nro_factura_a.ReadOnly = True
        Me.c_nro_factura_a.Width = 87
        '
        'c_fecha_a
        '
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.c_fecha_a.DefaultCellStyle = DataGridViewCellStyle3
        Me.c_fecha_a.HeaderText = "Fecha"
        Me.c_fecha_a.Name = "c_fecha_a"
        Me.c_fecha_a.ReadOnly = True
        Me.c_fecha_a.Width = 98
        '
        'c_cliente_a
        '
        Me.c_cliente_a.HeaderText = "Vendido A:"
        Me.c_cliente_a.Name = "c_cliente_a"
        Me.c_cliente_a.ReadOnly = True
        Me.c_cliente_a.Width = 310
        '
        'c_vendedor_a
        '
        Me.c_vendedor_a.HeaderText = "Vendedor"
        Me.c_vendedor_a.Name = "c_vendedor_a"
        Me.c_vendedor_a.ReadOnly = True
        Me.c_vendedor_a.Width = 95
        '
        'c_total_a
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.c_total_a.DefaultCellStyle = DataGridViewCellStyle4
        Me.c_total_a.HeaderText = "Total C."
        Me.c_total_a.Name = "c_total_a"
        Me.c_total_a.ReadOnly = True
        Me.c_total_a.Width = 120
        '
        'c_id_a
        '
        Me.c_id_a.HeaderText = "factura cerrada id"
        Me.c_id_a.Name = "c_id_a"
        Me.c_id_a.ReadOnly = True
        Me.c_id_a.Visible = False
        Me.c_id_a.Width = 5
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic)
        Me.Button1.Image = Global.Facturacion_Esteban.My.Resources.Resources.candadoOff
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(257, 285)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(169, 54)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Cerrar Con Fecha"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Lb_Mensaje
        '
        Me.Lb_Mensaje.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lb_Mensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Mensaje.ForeColor = System.Drawing.Color.DarkBlue
        Me.Lb_Mensaje.Location = New System.Drawing.Point(437, 298)
        Me.Lb_Mensaje.Name = "Lb_Mensaje"
        Me.Lb_Mensaje.Size = New System.Drawing.Size(371, 21)
        Me.Lb_Mensaje.TabIndex = 17
        Me.Lb_Mensaje.Text = "Label3"
        Me.Lb_Mensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Lb_Mensaje.Visible = False
        '
        'Btn_Agregar_2
        '
        Me.Btn_Agregar_2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Agregar_2.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic)
        Me.Btn_Agregar_2.Image = Global.Facturacion_Esteban.My.Resources.Resources.Addfile
        Me.Btn_Agregar_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Agregar_2.Location = New System.Drawing.Point(128, 283)
        Me.Btn_Agregar_2.Name = "Btn_Agregar_2"
        Me.Btn_Agregar_2.Size = New System.Drawing.Size(123, 54)
        Me.Btn_Agregar_2.TabIndex = 8
        Me.Btn_Agregar_2.Text = "Agregar"
        Me.Btn_Agregar_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Agregar_2.UseVisualStyleBackColor = True
        Me.Btn_Agregar_2.Visible = False
        '
        'Btn_Cerrar_Factura_2
        '
        Me.Btn_Cerrar_Factura_2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Cerrar_Factura_2.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic)
        Me.Btn_Cerrar_Factura_2.Image = Global.Facturacion_Esteban.My.Resources.Resources.candadoOff
        Me.Btn_Cerrar_Factura_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Cerrar_Factura_2.Location = New System.Drawing.Point(16, 283)
        Me.Btn_Cerrar_Factura_2.Name = "Btn_Cerrar_Factura_2"
        Me.Btn_Cerrar_Factura_2.Size = New System.Drawing.Size(106, 54)
        Me.Btn_Cerrar_Factura_2.TabIndex = 7
        Me.Btn_Cerrar_Factura_2.Text = "Pagar"
        Me.Btn_Cerrar_Factura_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Cerrar_Factura_2.UseVisualStyleBackColor = True
        '
        'TabP_Reportes
        '
        Me.TabP_Reportes.BackColor = System.Drawing.Color.Gainsboro
        Me.TabP_Reportes.Controls.Add(Me.btnTiquete)
        Me.TabP_Reportes.Controls.Add(Me.btn_productos)
        Me.TabP_Reportes.Controls.Add(Me.Btn_Reporte_Vendedor_3)
        Me.TabP_Reportes.Controls.Add(Me.Lv_Id_Vendedor_3)
        Me.TabP_Reportes.Controls.Add(Me.Btn_Reporte_Cliente_3)
        Me.TabP_Reportes.Controls.Add(Me.Btn_Reporte_Fecha_3)
        Me.TabP_Reportes.Location = New System.Drawing.Point(4, 25)
        Me.TabP_Reportes.Name = "TabP_Reportes"
        Me.TabP_Reportes.Size = New System.Drawing.Size(830, 343)
        Me.TabP_Reportes.TabIndex = 2
        Me.TabP_Reportes.Text = "Reportes"
        '
        'btnTiquete
        '
        Me.btnTiquete.Location = New System.Drawing.Point(579, 27)
        Me.btnTiquete.Name = "btnTiquete"
        Me.btnTiquete.Size = New System.Drawing.Size(133, 111)
        Me.btnTiquete.TabIndex = 35
        Me.btnTiquete.Text = "Tiquetes"
        Me.btnTiquete.UseVisualStyleBackColor = True
        '
        'btn_productos
        '
        Me.btn_productos.Location = New System.Drawing.Point(415, 160)
        Me.btn_productos.Name = "btn_productos"
        Me.btn_productos.Size = New System.Drawing.Size(133, 111)
        Me.btn_productos.TabIndex = 34
        Me.btn_productos.Text = "Producto Vendido"
        Me.btn_productos.UseVisualStyleBackColor = True
        '
        'Btn_Reporte_Vendedor_3
        '
        Me.Btn_Reporte_Vendedor_3.Location = New System.Drawing.Point(415, 27)
        Me.Btn_Reporte_Vendedor_3.Name = "Btn_Reporte_Vendedor_3"
        Me.Btn_Reporte_Vendedor_3.Size = New System.Drawing.Size(133, 111)
        Me.Btn_Reporte_Vendedor_3.TabIndex = 5
        Me.Btn_Reporte_Vendedor_3.Text = "Vendedor"
        Me.Btn_Reporte_Vendedor_3.UseVisualStyleBackColor = True
        '
        'Lv_Id_Vendedor_3
        '
        Me.Lv_Id_Vendedor_3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader12, Me.ColumnHeader14})
        Me.Lv_Id_Vendedor_3.FullRowSelect = True
        Me.Lv_Id_Vendedor_3.GridLines = True
        Me.Lv_Id_Vendedor_3.Location = New System.Drawing.Point(461, 189)
        Me.Lv_Id_Vendedor_3.Name = "Lv_Id_Vendedor_3"
        Me.Lv_Id_Vendedor_3.Size = New System.Drawing.Size(219, 94)
        Me.Lv_Id_Vendedor_3.TabIndex = 33
        Me.Lv_Id_Vendedor_3.UseCompatibleStateImageBehavior = False
        Me.Lv_Id_Vendedor_3.View = System.Windows.Forms.View.Details
        Me.Lv_Id_Vendedor_3.Visible = False
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Id vendedor"
        Me.ColumnHeader12.Width = 106
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "cod Vendedor"
        Me.ColumnHeader14.Width = 100
        '
        'Btn_Reporte_Cliente_3
        '
        Me.Btn_Reporte_Cliente_3.Location = New System.Drawing.Point(225, 27)
        Me.Btn_Reporte_Cliente_3.Name = "Btn_Reporte_Cliente_3"
        Me.Btn_Reporte_Cliente_3.Size = New System.Drawing.Size(133, 244)
        Me.Btn_Reporte_Cliente_3.TabIndex = 4
        Me.Btn_Reporte_Cliente_3.Text = "Cliente"
        Me.Btn_Reporte_Cliente_3.UseVisualStyleBackColor = True
        '
        'Btn_Reporte_Fecha_3
        '
        Me.Btn_Reporte_Fecha_3.Location = New System.Drawing.Point(32, 27)
        Me.Btn_Reporte_Fecha_3.Name = "Btn_Reporte_Fecha_3"
        Me.Btn_Reporte_Fecha_3.Size = New System.Drawing.Size(133, 244)
        Me.Btn_Reporte_Fecha_3.TabIndex = 3
        Me.Btn_Reporte_Fecha_3.Text = "Por Fecha"
        Me.Btn_Reporte_Fecha_3.UseVisualStyleBackColor = True
        '
        'TabP_Facturas_Cobrar
        '
        Me.TabP_Facturas_Cobrar.BackColor = System.Drawing.Color.LightGray
        Me.TabP_Facturas_Cobrar.Controls.Add(Me.Btn_Limpiar_FactXCobrar_4)
        Me.TabP_Facturas_Cobrar.Controls.Add(Me.Btn_Cargar_4)
        Me.TabP_Facturas_Cobrar.Controls.Add(Me.Btn_Eliminar_Fila_4)
        Me.TabP_Facturas_Cobrar.Controls.Add(Me.Lb_Total_4)
        Me.TabP_Facturas_Cobrar.Controls.Add(Me.Lb_Monto_4)
        Me.TabP_Facturas_Cobrar.Controls.Add(Me.Label2)
        Me.TabP_Facturas_Cobrar.Controls.Add(Me.Label1)
        Me.TabP_Facturas_Cobrar.Controls.Add(Me.Txt_Total_4)
        Me.TabP_Facturas_Cobrar.Controls.Add(Me.Lv_Detalle_Fact_X_Cobrar_4)
        Me.TabP_Facturas_Cobrar.Controls.Add(Me.Txt_Monto_4)
        Me.TabP_Facturas_Cobrar.Controls.Add(Me.Txt_Nombre_Cliente_4)
        Me.TabP_Facturas_Cobrar.Controls.Add(Me.Txt_Numero_Factura_4)
        Me.TabP_Facturas_Cobrar.Location = New System.Drawing.Point(4, 25)
        Me.TabP_Facturas_Cobrar.Name = "TabP_Facturas_Cobrar"
        Me.TabP_Facturas_Cobrar.Padding = New System.Windows.Forms.Padding(3)
        Me.TabP_Facturas_Cobrar.Size = New System.Drawing.Size(830, 343)
        Me.TabP_Facturas_Cobrar.TabIndex = 3
        Me.TabP_Facturas_Cobrar.Text = "Facturas X Cobrar"
        '
        'Btn_Limpiar_FactXCobrar_4
        '
        Me.Btn_Limpiar_FactXCobrar_4.Location = New System.Drawing.Point(554, 48)
        Me.Btn_Limpiar_FactXCobrar_4.Name = "Btn_Limpiar_FactXCobrar_4"
        Me.Btn_Limpiar_FactXCobrar_4.Size = New System.Drawing.Size(120, 26)
        Me.Btn_Limpiar_FactXCobrar_4.TabIndex = 12
        Me.Btn_Limpiar_FactXCobrar_4.Text = "Limpiar"
        Me.Btn_Limpiar_FactXCobrar_4.UseVisualStyleBackColor = True
        '
        'Btn_Cargar_4
        '
        Me.Btn_Cargar_4.Location = New System.Drawing.Point(554, 21)
        Me.Btn_Cargar_4.Name = "Btn_Cargar_4"
        Me.Btn_Cargar_4.Size = New System.Drawing.Size(120, 26)
        Me.Btn_Cargar_4.TabIndex = 11
        Me.Btn_Cargar_4.Text = "Cargar"
        Me.Btn_Cargar_4.UseVisualStyleBackColor = True
        '
        'Btn_Eliminar_Fila_4
        '
        Me.Btn_Eliminar_Fila_4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Eliminar_Fila_4.Location = New System.Drawing.Point(21, 302)
        Me.Btn_Eliminar_Fila_4.Name = "Btn_Eliminar_Fila_4"
        Me.Btn_Eliminar_Fila_4.Size = New System.Drawing.Size(129, 35)
        Me.Btn_Eliminar_Fila_4.TabIndex = 9
        Me.Btn_Eliminar_Fila_4.Text = "Eliminar Fila"
        Me.Btn_Eliminar_Fila_4.UseVisualStyleBackColor = True
        '
        'Lb_Total_4
        '
        Me.Lb_Total_4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lb_Total_4.AutoSize = True
        Me.Lb_Total_4.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Total_4.Location = New System.Drawing.Point(541, 307)
        Me.Lb_Total_4.Name = "Lb_Total_4"
        Me.Lb_Total_4.Size = New System.Drawing.Size(54, 20)
        Me.Lb_Total_4.TabIndex = 8
        Me.Lb_Total_4.Text = "Total"
        '
        'Lb_Monto_4
        '
        Me.Lb_Monto_4.AutoSize = True
        Me.Lb_Monto_4.Location = New System.Drawing.Point(427, 26)
        Me.Lb_Monto_4.Name = "Lb_Monto_4"
        Me.Lb_Monto_4.Size = New System.Drawing.Size(40, 16)
        Me.Lb_Monto_4.TabIndex = 7
        Me.Lb_Monto_4.Text = "Total"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(139, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nombre Cliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Numero"
        '
        'Txt_Total_4
        '
        Me.Txt_Total_4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_Total_4.BackColor = System.Drawing.Color.NavajoWhite
        Me.Txt_Total_4.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Total_4.ForeColor = System.Drawing.Color.DarkRed
        Me.Txt_Total_4.Location = New System.Drawing.Point(599, 302)
        Me.Txt_Total_4.MaxLength = 12
        Me.Txt_Total_4.Name = "Txt_Total_4"
        Me.Txt_Total_4.ReadOnly = True
        Me.Txt_Total_4.Size = New System.Drawing.Size(127, 32)
        Me.Txt_Total_4.TabIndex = 4
        Me.Txt_Total_4.Text = "0"
        Me.Txt_Total_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Lv_Detalle_Fact_X_Cobrar_4
        '
        Me.Lv_Detalle_Fact_X_Cobrar_4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lv_Detalle_Fact_X_Cobrar_4.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader11, Me.ColumnHeader13, Me.ColumnHeader15})
        Me.Lv_Detalle_Fact_X_Cobrar_4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic)
        Me.Lv_Detalle_Fact_X_Cobrar_4.FullRowSelect = True
        Me.Lv_Detalle_Fact_X_Cobrar_4.GridLines = True
        Me.Lv_Detalle_Fact_X_Cobrar_4.Location = New System.Drawing.Point(17, 85)
        Me.Lv_Detalle_Fact_X_Cobrar_4.Name = "Lv_Detalle_Fact_X_Cobrar_4"
        Me.Lv_Detalle_Fact_X_Cobrar_4.Size = New System.Drawing.Size(797, 211)
        Me.Lv_Detalle_Fact_X_Cobrar_4.TabIndex = 3
        Me.Lv_Detalle_Fact_X_Cobrar_4.UseCompatibleStateImageBehavior = False
        Me.Lv_Detalle_Fact_X_Cobrar_4.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Nro. Factura"
        Me.ColumnHeader11.Width = 100
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Vendido A:"
        Me.ColumnHeader13.Width = 550
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Total C."
        Me.ColumnHeader15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader15.Width = 130
        '
        'Txt_Monto_4
        '
        Me.Txt_Monto_4.Location = New System.Drawing.Point(430, 45)
        Me.Txt_Monto_4.MaxLength = 12
        Me.Txt_Monto_4.Name = "Txt_Monto_4"
        Me.Txt_Monto_4.Size = New System.Drawing.Size(118, 27)
        Me.Txt_Monto_4.TabIndex = 101
        Me.Txt_Monto_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txt_Nombre_Cliente_4
        '
        Me.Txt_Nombre_Cliente_4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Nombre_Cliente_4.Location = New System.Drawing.Point(142, 45)
        Me.Txt_Nombre_Cliente_4.MaxLength = 100
        Me.Txt_Nombre_Cliente_4.Name = "Txt_Nombre_Cliente_4"
        Me.Txt_Nombre_Cliente_4.Size = New System.Drawing.Size(282, 27)
        Me.Txt_Nombre_Cliente_4.TabIndex = 100
        '
        'Txt_Numero_Factura_4
        '
        Me.Txt_Numero_Factura_4.BackColor = System.Drawing.Color.Khaki
        Me.Txt_Numero_Factura_4.Location = New System.Drawing.Point(36, 45)
        Me.Txt_Numero_Factura_4.MaxLength = 9
        Me.Txt_Numero_Factura_4.Name = "Txt_Numero_Factura_4"
        Me.Txt_Numero_Factura_4.Size = New System.Drawing.Size(100, 27)
        Me.Txt_Numero_Factura_4.TabIndex = 99
        Me.Txt_Numero_Factura_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TabP_Cotizacion
        '
        Me.TabP_Cotizacion.BackColor = System.Drawing.Color.LightGray
        Me.TabP_Cotizacion.Controls.Add(Me.dgv_cotizaciones)
        Me.TabP_Cotizacion.Controls.Add(Me.Btn_Convertir_5)
        Me.TabP_Cotizacion.Controls.Add(Me.Btn_Eliminar_Cotizacion_5)
        Me.TabP_Cotizacion.Controls.Add(Me.Btn_Imprimir_Cotizacion_5)
        Me.TabP_Cotizacion.Controls.Add(Me.Btn_Modificar_Cotizacion_5)
        Me.TabP_Cotizacion.Controls.Add(Me.Btn_Crear_Cotizacion_5)
        Me.TabP_Cotizacion.Controls.Add(Me.Txt_Busqueda_Cotizacion_5)
        Me.TabP_Cotizacion.Location = New System.Drawing.Point(4, 25)
        Me.TabP_Cotizacion.Name = "TabP_Cotizacion"
        Me.TabP_Cotizacion.Padding = New System.Windows.Forms.Padding(3)
        Me.TabP_Cotizacion.Size = New System.Drawing.Size(830, 343)
        Me.TabP_Cotizacion.TabIndex = 4
        Me.TabP_Cotizacion.Text = "Cotización"
        '
        'dgv_cotizaciones
        '
        Me.dgv_cotizaciones.AllowUserToAddRows = False
        Me.dgv_cotizaciones.AllowUserToDeleteRows = False
        Me.dgv_cotizaciones.AllowUserToOrderColumns = True
        Me.dgv_cotizaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_cotizaciones.ColumnHeadersHeight = 40
        Me.dgv_cotizaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_cotizaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5})
        Me.dgv_cotizaciones.Location = New System.Drawing.Point(9, 47)
        Me.dgv_cotizaciones.MultiSelect = False
        Me.dgv_cotizaciones.Name = "dgv_cotizaciones"
        Me.dgv_cotizaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_cotizaciones.Size = New System.Drawing.Size(815, 226)
        Me.dgv_cotizaciones.TabIndex = 20
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "factura cerrada id"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nro. Cotización"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 110
        '
        'DataGridViewTextBoxColumn2
        '
        DataGridViewCellStyle7.Format = "d"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 395
        '
        'DataGridViewTextBoxColumn5
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn5.HeaderText = "Total C."
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'Btn_Convertir_5
        '
        Me.Btn_Convertir_5.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Btn_Convertir_5.Font = New System.Drawing.Font("Calisto MT", 14.25!)
        Me.Btn_Convertir_5.Image = Global.Facturacion_Esteban.My.Resources.Resources.convert2
        Me.Btn_Convertir_5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Convertir_5.Location = New System.Drawing.Point(469, 278)
        Me.Btn_Convertir_5.Name = "Btn_Convertir_5"
        Me.Btn_Convertir_5.Size = New System.Drawing.Size(127, 56)
        Me.Btn_Convertir_5.TabIndex = 10
        Me.Btn_Convertir_5.Text = "Convertir"
        Me.Btn_Convertir_5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Convertir_5.UseVisualStyleBackColor = True
        '
        'Btn_Eliminar_Cotizacion_5
        '
        Me.Btn_Eliminar_Cotizacion_5.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Btn_Eliminar_Cotizacion_5.Font = New System.Drawing.Font("Calisto MT", 14.25!)
        Me.Btn_Eliminar_Cotizacion_5.Image = Global.Facturacion_Esteban.My.Resources.Resources.trashcan
        Me.Btn_Eliminar_Cotizacion_5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Eliminar_Cotizacion_5.Location = New System.Drawing.Point(602, 278)
        Me.Btn_Eliminar_Cotizacion_5.Name = "Btn_Eliminar_Cotizacion_5"
        Me.Btn_Eliminar_Cotizacion_5.Size = New System.Drawing.Size(136, 56)
        Me.Btn_Eliminar_Cotizacion_5.TabIndex = 9
        Me.Btn_Eliminar_Cotizacion_5.Text = "Eliminar"
        Me.Btn_Eliminar_Cotizacion_5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Eliminar_Cotizacion_5.UseVisualStyleBackColor = True
        '
        'Btn_Imprimir_Cotizacion_5
        '
        Me.Btn_Imprimir_Cotizacion_5.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Btn_Imprimir_Cotizacion_5.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Imprimir_Cotizacion_5.Image = Global.Facturacion_Esteban.My.Resources.Resources.Print
        Me.Btn_Imprimir_Cotizacion_5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Imprimir_Cotizacion_5.Location = New System.Drawing.Point(339, 279)
        Me.Btn_Imprimir_Cotizacion_5.Name = "Btn_Imprimir_Cotizacion_5"
        Me.Btn_Imprimir_Cotizacion_5.Size = New System.Drawing.Size(124, 56)
        Me.Btn_Imprimir_Cotizacion_5.TabIndex = 8
        Me.Btn_Imprimir_Cotizacion_5.Text = "Imprimir"
        Me.Btn_Imprimir_Cotizacion_5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Imprimir_Cotizacion_5.UseVisualStyleBackColor = True
        '
        'Btn_Modificar_Cotizacion_5
        '
        Me.Btn_Modificar_Cotizacion_5.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Btn_Modificar_Cotizacion_5.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic)
        Me.Btn_Modificar_Cotizacion_5.Image = Global.Facturacion_Esteban.My.Resources.Resources.Modificarof
        Me.Btn_Modificar_Cotizacion_5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Modificar_Cotizacion_5.Location = New System.Drawing.Point(207, 278)
        Me.Btn_Modificar_Cotizacion_5.Name = "Btn_Modificar_Cotizacion_5"
        Me.Btn_Modificar_Cotizacion_5.Size = New System.Drawing.Size(126, 56)
        Me.Btn_Modificar_Cotizacion_5.TabIndex = 7
        Me.Btn_Modificar_Cotizacion_5.Text = "Modificar"
        Me.Btn_Modificar_Cotizacion_5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Modificar_Cotizacion_5.UseVisualStyleBackColor = True
        '
        'Btn_Crear_Cotizacion_5
        '
        Me.Btn_Crear_Cotizacion_5.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Btn_Crear_Cotizacion_5.Font = New System.Drawing.Font("Calisto MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Crear_Cotizacion_5.Image = Global.Facturacion_Esteban.My.Resources.Resources.InvoiceOff
        Me.Btn_Crear_Cotizacion_5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Crear_Cotizacion_5.Location = New System.Drawing.Point(86, 278)
        Me.Btn_Crear_Cotizacion_5.Name = "Btn_Crear_Cotizacion_5"
        Me.Btn_Crear_Cotizacion_5.Size = New System.Drawing.Size(115, 56)
        Me.Btn_Crear_Cotizacion_5.TabIndex = 6
        Me.Btn_Crear_Cotizacion_5.Text = "Crear"
        Me.Btn_Crear_Cotizacion_5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Crear_Cotizacion_5.UseVisualStyleBackColor = True
        '
        'Txt_Busqueda_Cotizacion_5
        '
        Me.Txt_Busqueda_Cotizacion_5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Txt_Busqueda_Cotizacion_5.BackColor = System.Drawing.Color.Yellow
        Me.Txt_Busqueda_Cotizacion_5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Busqueda_Cotizacion_5.Font = New System.Drawing.Font("Lucida Fax", 9.75!)
        Me.Txt_Busqueda_Cotizacion_5.Location = New System.Drawing.Point(235, 17)
        Me.Txt_Busqueda_Cotizacion_5.MaxLength = 100
        Me.Txt_Busqueda_Cotizacion_5.Name = "Txt_Busqueda_Cotizacion_5"
        Me.Txt_Busqueda_Cotizacion_5.Size = New System.Drawing.Size(324, 23)
        Me.Txt_Busqueda_Cotizacion_5.TabIndex = 5
        Me.Txt_Busqueda_Cotizacion_5.Text = "BUSQUEDA POR CLIENTE"
        '
        'Txt_Busqueda_Nombre
        '
        Me.Txt_Busqueda_Nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Busqueda_Nombre.Font = New System.Drawing.Font("Lucida Fax", 9.75!)
        Me.Txt_Busqueda_Nombre.Location = New System.Drawing.Point(35, 54)
        Me.Txt_Busqueda_Nombre.MaxLength = 100
        Me.Txt_Busqueda_Nombre.Name = "Txt_Busqueda_Nombre"
        Me.Txt_Busqueda_Nombre.Size = New System.Drawing.Size(159, 23)
        Me.Txt_Busqueda_Nombre.TabIndex = 4
        '
        'Txt_Busqueda_Numero
        '
        Me.Txt_Busqueda_Numero.Font = New System.Drawing.Font("Lucida Fax", 9.75!)
        Me.Txt_Busqueda_Numero.Location = New System.Drawing.Point(208, 54)
        Me.Txt_Busqueda_Numero.MaxLength = 9
        Me.Txt_Busqueda_Numero.Name = "Txt_Busqueda_Numero"
        Me.Txt_Busqueda_Numero.Size = New System.Drawing.Size(148, 23)
        Me.Txt_Busqueda_Numero.TabIndex = 6
        Me.Txt_Busqueda_Numero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lb_vendedor
        '
        Me.lb_vendedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lb_vendedor.AutoSize = True
        Me.lb_vendedor.BackColor = System.Drawing.Color.Transparent
        Me.lb_vendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_vendedor.Location = New System.Drawing.Point(635, 26)
        Me.lb_vendedor.Name = "lb_vendedor"
        Me.lb_vendedor.Size = New System.Drawing.Size(68, 16)
        Me.lb_vendedor.TabIndex = 32
        Me.lb_vendedor.Text = "Vendedor"
        '
        'Chb_Vendedor
        '
        Me.Chb_Vendedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chb_Vendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Chb_Vendedor.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chb_Vendedor.FormattingEnabled = True
        Me.Chb_Vendedor.Location = New System.Drawing.Point(709, 24)
        Me.Chb_Vendedor.Name = "Chb_Vendedor"
        Me.Chb_Vendedor.Size = New System.Drawing.Size(151, 23)
        Me.Chb_Vendedor.TabIndex = 31
        '
        'Btn_Actualizar_Vendedor
        '
        Me.Btn_Actualizar_Vendedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Actualizar_Vendedor.Location = New System.Drawing.Point(709, 50)
        Me.Btn_Actualizar_Vendedor.Name = "Btn_Actualizar_Vendedor"
        Me.Btn_Actualizar_Vendedor.Size = New System.Drawing.Size(151, 23)
        Me.Btn_Actualizar_Vendedor.TabIndex = 34
        Me.Btn_Actualizar_Vendedor.Text = "Actualizar"
        Me.Btn_Actualizar_Vendedor.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.Facturacion_Esteban.My.Resources.Resources.busquedaFacturabla
        Me.PictureBox3.Location = New System.Drawing.Point(208, 29)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(160, 19)
        Me.PictureBox3.TabIndex = 10
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.Facturacion_Esteban.My.Resources.Resources.titulob
        Me.PictureBox2.Location = New System.Drawing.Point(32, 29)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(161, 19)
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'PB_Facturas
        '
        Me.PB_Facturas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PB_Facturas.Image = Global.Facturacion_Esteban.My.Resources.Resources.FondoFactura
        Me.PB_Facturas.Location = New System.Drawing.Point(0, 0)
        Me.PB_Facturas.Name = "PB_Facturas"
        Me.PB_Facturas.Size = New System.Drawing.Size(884, 498)
        Me.PB_Facturas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_Facturas.TabIndex = 8
        Me.PB_Facturas.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'TabFacturasPagadas
        '
        Me.TabFacturasPagadas.BackColor = System.Drawing.Color.Gainsboro
        Me.TabFacturasPagadas.Controls.Add(Me.dgvPagada)
        Me.TabFacturasPagadas.Location = New System.Drawing.Point(4, 25)
        Me.TabFacturasPagadas.Name = "TabFacturasPagadas"
        Me.TabFacturasPagadas.Padding = New System.Windows.Forms.Padding(3)
        Me.TabFacturasPagadas.Size = New System.Drawing.Size(830, 343)
        Me.TabFacturasPagadas.TabIndex = 5
        Me.TabFacturasPagadas.Text = "Facturas Pagadas"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "factura cerrada id"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn10.HeaderText = "Total C."
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 130
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "Vendedor"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Vendido A:"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 335
        '
        'DataGridViewTextBoxColumn7
        '
        DataGridViewCellStyle5.Format = "d"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn7.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 98
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Nro. Factura"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 95
        '
        'dgvPagada
        '
        Me.dgvPagada.AllowUserToAddRows = False
        Me.dgvPagada.AllowUserToDeleteRows = False
        Me.dgvPagada.AllowUserToOrderColumns = True
        Me.dgvPagada.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPagada.ColumnHeadersHeight = 40
        Me.dgvPagada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvPagada.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.dgvPagada.Location = New System.Drawing.Point(6, 6)
        Me.dgvPagada.MultiSelect = False
        Me.dgvPagada.Name = "dgvPagada"
        Me.dgvPagada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPagada.Size = New System.Drawing.Size(818, 313)
        Me.dgvPagada.TabIndex = 9
        '
        'Fr_Facturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(884, 498)
        Me.Controls.Add(Me.Btn_Actualizar_Vendedor)
        Me.Controls.Add(Me.lb_vendedor)
        Me.Controls.Add(Me.Chb_Vendedor)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Txt_Busqueda_Numero)
        Me.Controls.Add(Me.Txt_Busqueda_Nombre)
        Me.Controls.Add(Me.Tab_Opciones)
        Me.Controls.Add(Me.PB_Facturas)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(900, 527)
        Me.Name = "Fr_Facturas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturas"
        Me.Tab_Opciones.ResumeLayout(False)
        Me.TabP_Facturas_Cerradas.ResumeLayout(False)
        CType(Me.Dgv_facturas_cerradas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabP_Facturas_Abiertas.ResumeLayout(False)
        CType(Me.dgv_facturas_abiertas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabP_Reportes.ResumeLayout(False)
        Me.TabP_Facturas_Cobrar.ResumeLayout(False)
        Me.TabP_Facturas_Cobrar.PerformLayout()
        Me.TabP_Cotizacion.ResumeLayout(False)
        Me.TabP_Cotizacion.PerformLayout()
        CType(Me.dgv_cotizaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_Facturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabFacturasPagadas.ResumeLayout(False)
        CType(Me.dgvPagada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Tab_Opciones As System.Windows.Forms.TabControl
    Friend WithEvents TabP_Facturas_Cerradas As System.Windows.Forms.TabPage
    Friend WithEvents TabP_Facturas_Abiertas As System.Windows.Forms.TabPage
    Friend WithEvents Btn_Modificar_1 As System.Windows.Forms.Button
    Friend WithEvents Btn_Imprimir_1 As System.Windows.Forms.Button
    Friend WithEvents Btn_Crear_1 As System.Windows.Forms.Button
    Friend WithEvents Btn_Salir_1 As System.Windows.Forms.Button
    Friend WithEvents Txt_Busqueda_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents TabP_Reportes As System.Windows.Forms.TabPage
    Friend WithEvents Btn_Agregar_2 As System.Windows.Forms.Button
    Friend WithEvents Btn_Cerrar_Factura_2 As System.Windows.Forms.Button
    Friend WithEvents Btn_Reporte_Vendedor_3 As System.Windows.Forms.Button
    Friend WithEvents Btn_Reporte_Cliente_3 As System.Windows.Forms.Button
    Friend WithEvents Btn_Reporte_Fecha_3 As System.Windows.Forms.Button
    Friend WithEvents Txt_Busqueda_Numero As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Eliminar_1 As System.Windows.Forms.Button
    Friend WithEvents PB_Facturas As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents TabP_Facturas_Cobrar As System.Windows.Forms.TabPage
    Friend WithEvents Lb_Total_4 As System.Windows.Forms.Label
    Friend WithEvents Lb_Monto_4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txt_Total_4 As System.Windows.Forms.TextBox
    Friend WithEvents Lv_Detalle_Fact_X_Cobrar_4 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Txt_Monto_4 As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Nombre_Cliente_4 As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Numero_Factura_4 As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Eliminar_Fila_4 As System.Windows.Forms.Button
    Friend WithEvents Btn_Cargar_4 As System.Windows.Forms.Button
    Friend WithEvents Btn_Limpiar_FactXCobrar_4 As System.Windows.Forms.Button
    Friend WithEvents Lv_Id_Vendedor_3 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lb_vendedor As System.Windows.Forms.Label
    Friend WithEvents Chb_Vendedor As System.Windows.Forms.ComboBox
    Friend WithEvents Btn_Actualizar_Vendedor As System.Windows.Forms.Button
    Friend WithEvents TabP_Cotizacion As System.Windows.Forms.TabPage
    Friend WithEvents Btn_Convertir_5 As System.Windows.Forms.Button
    Friend WithEvents Btn_Eliminar_Cotizacion_5 As System.Windows.Forms.Button
    Friend WithEvents Btn_Imprimir_Cotizacion_5 As System.Windows.Forms.Button
    Friend WithEvents Btn_Modificar_Cotizacion_5 As System.Windows.Forms.Button
    Friend WithEvents Btn_Crear_Cotizacion_5 As System.Windows.Forms.Button
    Friend WithEvents Txt_Busqueda_Cotizacion_5 As System.Windows.Forms.TextBox
    Friend WithEvents Lb_Mensaje As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btn_productos As Button
    Friend WithEvents Dgv_facturas_cerradas As MEPDataGridView
    Friend WithEvents dgv_facturas_abiertas As MEPDataGridView
    Friend WithEvents dgv_cotizaciones As MEPDataGridView
    Friend WithEvents c_nro_factura_c As DataGridViewTextBoxColumn
    Friend WithEvents c_fecha_c As DataGridViewTextBoxColumn
    Friend WithEvents c_cliente_c As DataGridViewTextBoxColumn
    Friend WithEvents c_vendedor_c As DataGridViewTextBoxColumn
    Friend WithEvents c_total_c As DataGridViewTextBoxColumn
    Friend WithEvents c_id_cerrada_c As DataGridViewTextBoxColumn
    Friend WithEvents c_cerrar_factura As DataGridViewCheckBoxColumn
    Friend WithEvents c_nro_factura_a As DataGridViewTextBoxColumn
    Friend WithEvents c_fecha_a As DataGridViewTextBoxColumn
    Friend WithEvents c_cliente_a As DataGridViewTextBoxColumn
    Friend WithEvents c_vendedor_a As DataGridViewTextBoxColumn
    Friend WithEvents c_total_a As DataGridViewTextBoxColumn
    Friend WithEvents c_id_a As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btn_revisar As Button
    Friend WithEvents lb_tiempo As Label
    Friend WithEvents btnTiquete As Button
    Friend WithEvents TabFacturasPagadas As TabPage
    Friend WithEvents dgvPagada As MEPDataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
End Class
