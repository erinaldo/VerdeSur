<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fr_Clientes
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fr_Clientes))
        Me.Txt_Cod_Nombre = New System.Windows.Forms.TextBox()
        Me.Txt_Nombre = New System.Windows.Forms.TextBox()
        Me.DGV_Direcion = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Txt_Telefono = New System.Windows.Forms.TextBox()
        Me.Btn_Agregar = New System.Windows.Forms.Button()
        Me.Btn_Salir = New System.Windows.Forms.Button()
        Me.LvClientes = New System.Windows.Forms.ListView()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Txt_Busqueda_Nombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txt_Busqueda_Id = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Btn_Seleccionar = New System.Windows.Forms.Button()
        Me.Txt_Advertencia = New System.Windows.Forms.TextBox()
        Me.Chb_Tipo_Impresora = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Cb_Vendedor = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Lv_Vendedor = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lb_cedula = New System.Windows.Forms.Label()
        Me.txt_cedula = New System.Windows.Forms.TextBox()
        Me.lb_correo = New System.Windows.Forms.Label()
        Me.txt_correo = New System.Windows.Forms.TextBox()
        CType(Me.DGV_Direcion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Txt_Cod_Nombre
        '
        Me.Txt_Cod_Nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Cod_Nombre.Location = New System.Drawing.Point(136, 12)
        Me.Txt_Cod_Nombre.MaxLength = 20
        Me.Txt_Cod_Nombre.Name = "Txt_Cod_Nombre"
        Me.Txt_Cod_Nombre.Size = New System.Drawing.Size(204, 20)
        Me.Txt_Cod_Nombre.TabIndex = 1
        '
        'Txt_Nombre
        '
        Me.Txt_Nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Nombre.Location = New System.Drawing.Point(136, 38)
        Me.Txt_Nombre.MaxLength = 100
        Me.Txt_Nombre.Name = "Txt_Nombre"
        Me.Txt_Nombre.Size = New System.Drawing.Size(365, 20)
        Me.Txt_Nombre.TabIndex = 2
        '
        'DGV_Direcion
        '
        Me.DGV_Direcion.AllowUserToAddRows = False
        Me.DGV_Direcion.AllowUserToResizeColumns = False
        Me.DGV_Direcion.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Direcion.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_Direcion.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGV_Direcion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Direcion.ColumnHeadersVisible = False
        Me.DGV_Direcion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        Me.DGV_Direcion.Location = New System.Drawing.Point(136, 142)
        Me.DGV_Direcion.Name = "DGV_Direcion"
        Me.DGV_Direcion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_Direcion.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_Direcion.RowHeadersVisible = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Direcion.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DGV_Direcion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DGV_Direcion.Size = New System.Drawing.Size(365, 69)
        Me.DGV_Direcion.TabIndex = 4
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
        'Txt_Telefono
        '
        Me.Txt_Telefono.Location = New System.Drawing.Point(136, 116)
        Me.Txt_Telefono.MaxLength = 20
        Me.Txt_Telefono.Name = "Txt_Telefono"
        Me.Txt_Telefono.Size = New System.Drawing.Size(365, 20)
        Me.Txt_Telefono.TabIndex = 3
        '
        'Btn_Agregar
        '
        Me.Btn_Agregar.Location = New System.Drawing.Point(41, 540)
        Me.Btn_Agregar.Name = "Btn_Agregar"
        Me.Btn_Agregar.Size = New System.Drawing.Size(119, 23)
        Me.Btn_Agregar.TabIndex = 10
        Me.Btn_Agregar.Text = "Agregar"
        Me.Btn_Agregar.UseVisualStyleBackColor = True
        '
        'Btn_Salir
        '
        Me.Btn_Salir.Location = New System.Drawing.Point(337, 540)
        Me.Btn_Salir.Name = "Btn_Salir"
        Me.Btn_Salir.Size = New System.Drawing.Size(137, 23)
        Me.Btn_Salir.TabIndex = 12
        Me.Btn_Salir.Text = "Salir"
        Me.Btn_Salir.UseVisualStyleBackColor = True
        '
        'LvClientes
        '
        Me.LvClientes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7})
        Me.LvClientes.FullRowSelect = True
        Me.LvClientes.GridLines = True
        Me.LvClientes.Location = New System.Drawing.Point(23, 352)
        Me.LvClientes.Name = "LvClientes"
        Me.LvClientes.Size = New System.Drawing.Size(478, 182)
        Me.LvClientes.TabIndex = 9
        Me.LvClientes.UseCompatibleStateImageBehavior = False
        Me.LvClientes.View = System.Windows.Forms.View.Details
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
        Me.Txt_Busqueda_Nombre.Location = New System.Drawing.Point(166, 327)
        Me.Txt_Busqueda_Nombre.MaxLength = 100
        Me.Txt_Busqueda_Nombre.Name = "Txt_Busqueda_Nombre"
        Me.Txt_Busqueda_Nombre.Size = New System.Drawing.Size(154, 20)
        Me.Txt_Busqueda_Nombre.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(166, 311)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Busqueda por Nombre"
        '
        'Txt_Busqueda_Id
        '
        Me.Txt_Busqueda_Id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Busqueda_Id.Location = New System.Drawing.Point(23, 327)
        Me.Txt_Busqueda_Id.MaxLength = 20
        Me.Txt_Busqueda_Id.Name = "Txt_Busqueda_Id"
        Me.Txt_Busqueda_Id.Size = New System.Drawing.Size(116, 20)
        Me.Txt_Busqueda_Id.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 311)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Busqueda por Codigo:"
        '
        'Btn_Seleccionar
        '
        Me.Btn_Seleccionar.Location = New System.Drawing.Point(190, 540)
        Me.Btn_Seleccionar.Name = "Btn_Seleccionar"
        Me.Btn_Seleccionar.Size = New System.Drawing.Size(119, 23)
        Me.Btn_Seleccionar.TabIndex = 11
        Me.Btn_Seleccionar.Text = "Seleccionar"
        Me.Btn_Seleccionar.UseVisualStyleBackColor = True
        '
        'Txt_Advertencia
        '
        Me.Txt_Advertencia.BackColor = System.Drawing.Color.Yellow
        Me.Txt_Advertencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Advertencia.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Advertencia.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Txt_Advertencia.Location = New System.Drawing.Point(136, 247)
        Me.Txt_Advertencia.MaxLength = 250
        Me.Txt_Advertencia.Name = "Txt_Advertencia"
        Me.Txt_Advertencia.Size = New System.Drawing.Size(258, 23)
        Me.Txt_Advertencia.TabIndex = 5
        Me.Txt_Advertencia.Text = "ADVERTENCIA"
        Me.Txt_Advertencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Chb_Tipo_Impresora
        '
        Me.Chb_Tipo_Impresora.AutoSize = True
        Me.Chb_Tipo_Impresora.Location = New System.Drawing.Point(136, 275)
        Me.Chb_Tipo_Impresora.Margin = New System.Windows.Forms.Padding(2)
        Me.Chb_Tipo_Impresora.Name = "Chb_Tipo_Impresora"
        Me.Chb_Tipo_Impresora.Size = New System.Drawing.Size(167, 17)
        Me.Chb_Tipo_Impresora.TabIndex = 6
        Me.Chb_Tipo_Impresora.Text = "Usar siempre Impresora Matriz"
        Me.Chb_Tipo_Impresora.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(14, 223)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 16)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Vendedor"
        '
        'Cb_Vendedor
        '
        Me.Cb_Vendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Vendedor.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_Vendedor.FormattingEnabled = True
        Me.Cb_Vendedor.Location = New System.Drawing.Point(136, 217)
        Me.Cb_Vendedor.Name = "Cb_Vendedor"
        Me.Cb_Vendedor.Size = New System.Drawing.Size(151, 23)
        Me.Cb_Vendedor.TabIndex = 25
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label8.Location = New System.Drawing.Point(13, 119)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 16)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Telefono"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label9.Location = New System.Drawing.Point(13, 145)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 16)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Direccion"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label11.Location = New System.Drawing.Point(13, 41)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 16)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Nombre"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label12.Location = New System.Drawing.Point(13, 13)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(117, 16)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Codigo De Cliente"
        '
        'Lv_Vendedor
        '
        Me.Lv_Vendedor.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.Lv_Vendedor.FullRowSelect = True
        Me.Lv_Vendedor.GridLines = True
        Me.Lv_Vendedor.Location = New System.Drawing.Point(270, 428)
        Me.Lv_Vendedor.Name = "Lv_Vendedor"
        Me.Lv_Vendedor.Size = New System.Drawing.Size(219, 94)
        Me.Lv_Vendedor.TabIndex = 31
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
        'lb_cedula
        '
        Me.lb_cedula.AutoSize = True
        Me.lb_cedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lb_cedula.Location = New System.Drawing.Point(13, 67)
        Me.lb_cedula.Name = "lb_cedula"
        Me.lb_cedula.Size = New System.Drawing.Size(51, 16)
        Me.lb_cedula.TabIndex = 33
        Me.lb_cedula.Text = "Cedula"
        '
        'txt_cedula
        '
        Me.txt_cedula.Location = New System.Drawing.Point(136, 64)
        Me.txt_cedula.MaxLength = 20
        Me.txt_cedula.Name = "txt_cedula"
        Me.txt_cedula.Size = New System.Drawing.Size(365, 20)
        Me.txt_cedula.TabIndex = 32
        '
        'lb_correo
        '
        Me.lb_correo.AutoSize = True
        Me.lb_correo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lb_correo.Location = New System.Drawing.Point(13, 93)
        Me.lb_correo.Name = "lb_correo"
        Me.lb_correo.Size = New System.Drawing.Size(64, 16)
        Me.lb_correo.TabIndex = 35
        Me.lb_correo.Text = "Correo E."
        '
        'txt_correo
        '
        Me.txt_correo.Location = New System.Drawing.Point(136, 90)
        Me.txt_correo.MaxLength = 500
        Me.txt_correo.Name = "txt_correo"
        Me.txt_correo.Size = New System.Drawing.Size(365, 20)
        Me.txt_correo.TabIndex = 34
        '
        'Fr_Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 601)
        Me.ControlBox = False
        Me.Controls.Add(Me.lb_correo)
        Me.Controls.Add(Me.txt_correo)
        Me.Controls.Add(Me.lb_cedula)
        Me.Controls.Add(Me.txt_cedula)
        Me.Controls.Add(Me.Lv_Vendedor)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Cb_Vendedor)
        Me.Controls.Add(Me.Chb_Tipo_Impresora)
        Me.Controls.Add(Me.Txt_Advertencia)
        Me.Controls.Add(Me.Btn_Seleccionar)
        Me.Controls.Add(Me.Txt_Busqueda_Nombre)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Txt_Busqueda_Id)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LvClientes)
        Me.Controls.Add(Me.Btn_Salir)
        Me.Controls.Add(Me.Btn_Agregar)
        Me.Controls.Add(Me.Txt_Telefono)
        Me.Controls.Add(Me.DGV_Direcion)
        Me.Controls.Add(Me.Txt_Nombre)
        Me.Controls.Add(Me.Txt_Cod_Nombre)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(527, 800)
        Me.MinimumSize = New System.Drawing.Size(527, 617)
        Me.Name = "Fr_Clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        Me.TopMost = True
        CType(Me.DGV_Direcion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txt_Cod_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents DGV_Direcion As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Txt_Telefono As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents Btn_Salir As System.Windows.Forms.Button
    Friend WithEvents LvClientes As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Txt_Busqueda_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Txt_Busqueda_Id As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Btn_Seleccionar As System.Windows.Forms.Button
    Friend WithEvents Txt_Advertencia As System.Windows.Forms.TextBox
    Friend WithEvents Chb_Tipo_Impresora As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Cb_Vendedor As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Lv_Vendedor As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents lb_cedula As Label
    Friend WithEvents txt_cedula As TextBox
    Friend WithEvents lb_correo As Label
    Friend WithEvents txt_correo As TextBox
End Class
