<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fr_vista_previa_factura
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGV_Facturas = New Facturacion_Esteban.MEPDataGridView()
        Me.C_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_Impuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lb_cliente = New System.Windows.Forms.Label()
        Me.btn_historial = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        CType(Me.DGV_Facturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(0, 519)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1000, 50)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Cerrar"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DGV_Facturas
        '
        Me.DGV_Facturas.AllowUserToAddRows = False
        Me.DGV_Facturas.AllowUserToResizeRows = False
        Me.DGV_Facturas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV_Facturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_Facturas.BackgroundColor = System.Drawing.Color.White
        Me.DGV_Facturas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_Facturas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_Facturas.ColumnHeadersHeight = 40
        Me.DGV_Facturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV_Facturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.C_codigo, Me.C_Descripcion, Me.C_Cantidad, Me.C_Precio, Me.C_Impuesto, Me.C_Total, Me.C_id, Me.C_Fecha})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_Facturas.DefaultCellStyle = DataGridViewCellStyle7
        Me.DGV_Facturas.Location = New System.Drawing.Point(12, 88)
        Me.DGV_Facturas.MultiSelect = False
        Me.DGV_Facturas.Name = "DGV_Facturas"
        Me.DGV_Facturas.RowHeadersVisible = False
        Me.DGV_Facturas.Size = New System.Drawing.Size(976, 428)
        Me.DGV_Facturas.TabIndex = 12
        '
        'C_codigo
        '
        Me.C_codigo.FillWeight = 1.0!
        Me.C_codigo.HeaderText = "Codigo del Producto"
        Me.C_codigo.Name = "C_codigo"
        Me.C_codigo.ReadOnly = True
        Me.C_codigo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'C_Descripcion
        '
        Me.C_Descripcion.FillWeight = 4.0!
        Me.C_Descripcion.HeaderText = "Descripcion"
        Me.C_Descripcion.MaxInputLength = 300
        Me.C_Descripcion.Name = "C_Descripcion"
        Me.C_Descripcion.ReadOnly = True
        '
        'C_Cantidad
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.C_Cantidad.DefaultCellStyle = DataGridViewCellStyle2
        Me.C_Cantidad.FillWeight = 1.0!
        Me.C_Cantidad.HeaderText = "Cantidad"
        Me.C_Cantidad.MaxInputLength = 18
        Me.C_Cantidad.Name = "C_Cantidad"
        Me.C_Cantidad.ReadOnly = True
        '
        'C_Precio
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.C_Precio.DefaultCellStyle = DataGridViewCellStyle3
        Me.C_Precio.FillWeight = 1.0!
        Me.C_Precio.HeaderText = "Precio"
        Me.C_Precio.MaxInputLength = 18
        Me.C_Precio.Name = "C_Precio"
        Me.C_Precio.ReadOnly = True
        '
        'C_Impuesto
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.C_Impuesto.DefaultCellStyle = DataGridViewCellStyle4
        Me.C_Impuesto.FillWeight = 1.0!
        Me.C_Impuesto.HeaderText = "Imp"
        Me.C_Impuesto.MaxInputLength = 100
        Me.C_Impuesto.Name = "C_Impuesto"
        Me.C_Impuesto.ReadOnly = True
        '
        'C_Total
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.C_Total.DefaultCellStyle = DataGridViewCellStyle5
        Me.C_Total.FillWeight = 1.0!
        Me.C_Total.HeaderText = "Total"
        Me.C_Total.MaxInputLength = 18
        Me.C_Total.Name = "C_Total"
        Me.C_Total.ReadOnly = True
        '
        'C_id
        '
        Me.C_id.FillWeight = 1.0!
        Me.C_id.HeaderText = "id"
        Me.C_id.Name = "C_id"
        Me.C_id.ReadOnly = True
        Me.C_id.Visible = False
        '
        'C_Fecha
        '
        DataGridViewCellStyle6.Format = "G"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.C_Fecha.DefaultCellStyle = DataGridViewCellStyle6
        Me.C_Fecha.FillWeight = 1.0!
        Me.C_Fecha.HeaderText = "Fecha y Hora"
        Me.C_Fecha.MaxInputLength = 100
        Me.C_Fecha.Name = "C_Fecha"
        Me.C_Fecha.ReadOnly = True
        Me.C_Fecha.Visible = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(0, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1000, 30)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Vista Previa"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_cliente
        '
        Me.lb_cliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lb_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_cliente.Location = New System.Drawing.Point(0, 42)
        Me.lb_cliente.Name = "lb_cliente"
        Me.lb_cliente.Size = New System.Drawing.Size(1000, 30)
        Me.lb_cliente.TabIndex = 15
        Me.lb_cliente.Text = "Vista Previa"
        Me.lb_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_historial
        '
        Me.btn_historial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_historial.Location = New System.Drawing.Point(835, 9)
        Me.btn_historial.Name = "btn_historial"
        Me.btn_historial.Size = New System.Drawing.Size(153, 43)
        Me.btn_historial.TabIndex = 16
        Me.btn_historial.Text = "Historial"
        Me.btn_historial.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Fr_vista_previa_factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(1000, 567)
        Me.Controls.Add(Me.btn_historial)
        Me.Controls.Add(Me.lb_cliente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGV_Facturas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Fr_vista_previa_factura"
        Me.Text = "Vista Previa"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        CType(Me.DGV_Facturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGV_Facturas As MEPDataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents C_codigo As DataGridViewTextBoxColumn
    Friend WithEvents C_Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents C_Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents C_Precio As DataGridViewTextBoxColumn
    Friend WithEvents C_Impuesto As DataGridViewTextBoxColumn
    Friend WithEvents C_Total As DataGridViewTextBoxColumn
    Friend WithEvents C_id As DataGridViewTextBoxColumn
    Friend WithEvents C_Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents lb_cliente As Label
    Friend WithEvents btn_historial As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
End Class
