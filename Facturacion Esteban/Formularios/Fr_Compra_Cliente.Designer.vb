<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fr_Compra_Cliente
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fr_Compra_Cliente))
        Me.Txt_Busqueda_Codigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_Busqueda_Producto = New System.Windows.Forms.TextBox()
        Me.dgv_historial = New Facturacion_Esteban.MEPDataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_historial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Txt_Busqueda_Codigo
        '
        Me.Txt_Busqueda_Codigo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Txt_Busqueda_Codigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Busqueda_Codigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Busqueda_Codigo.Location = New System.Drawing.Point(308, 34)
        Me.Txt_Busqueda_Codigo.MaxLength = 20
        Me.Txt_Busqueda_Codigo.Name = "Txt_Busqueda_Codigo"
        Me.Txt_Busqueda_Codigo.Size = New System.Drawing.Size(127, 22)
        Me.Txt_Busqueda_Codigo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(251, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Codigo:"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(446, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 16)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Producto:"
        '
        'Txt_Busqueda_Producto
        '
        Me.Txt_Busqueda_Producto.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Txt_Busqueda_Producto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Busqueda_Producto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Busqueda_Producto.Location = New System.Drawing.Point(517, 35)
        Me.Txt_Busqueda_Producto.MaxLength = 50
        Me.Txt_Busqueda_Producto.Name = "Txt_Busqueda_Producto"
        Me.Txt_Busqueda_Producto.Size = New System.Drawing.Size(285, 22)
        Me.Txt_Busqueda_Producto.TabIndex = 2
        '
        'dgv_historial
        '
        Me.dgv_historial.AllowUserToAddRows = False
        Me.dgv_historial.AllowUserToDeleteRows = False
        Me.dgv_historial.AllowUserToOrderColumns = True
        Me.dgv_historial.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_historial.ColumnHeadersHeight = 40
        Me.dgv_historial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_historial.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.dgv_historial.Location = New System.Drawing.Point(12, 70)
        Me.dgv_historial.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.dgv_historial.MultiSelect = False
        Me.dgv_historial.Name = "dgv_historial"
        Me.dgv_historial.Size = New System.Drawing.Size(1010, 320)
        Me.dgv_historial.TabIndex = 15
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.FillWeight = 1.0!
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nro Factura"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 121
        '
        'DataGridViewTextBoxColumn2
        '
        DataGridViewCellStyle1.Format = "M"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn2.FillWeight = 1.0!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 121
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.FillWeight = 1.0!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 121
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.FillWeight = 3.0!
        Me.DataGridViewTextBoxColumn4.HeaderText = "Producto"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 362
        '
        'DataGridViewTextBoxColumn5
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn5.FillWeight = 1.0!
        Me.DataGridViewTextBoxColumn5.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 121
        '
        'DataGridViewTextBoxColumn6
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn6.FillWeight = 1.0!
        Me.DataGridViewTextBoxColumn6.HeaderText = "Precio"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 121
        '
        'Fr_Compra_Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1034, 411)
        Me.Controls.Add(Me.dgv_historial)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txt_Busqueda_Producto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txt_Busqueda_Codigo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1050, 450)
        Me.Name = "Fr_Compra_Cliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Historial Compras Cliente"
        Me.TopMost = True
        CType(Me.dgv_historial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txt_Busqueda_Codigo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txt_Busqueda_Producto As System.Windows.Forms.TextBox
    Friend WithEvents dgv_historial As MEPDataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
End Class
