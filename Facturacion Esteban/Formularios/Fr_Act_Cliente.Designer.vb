<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Fr_Act_Cliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fr_Act_Cliente))
        Me.Btn_Salir = New System.Windows.Forms.Button()
        Me.Btn_Actualizar = New System.Windows.Forms.Button()
        Me.Txt_Telefono = New System.Windows.Forms.TextBox()
        Me.Txt_Nombre = New System.Windows.Forms.TextBox()
        Me.Txt_Cod_Nombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_Direccion = New System.Windows.Forms.TextBox()
        Me.Txt_Advertencia = New System.Windows.Forms.TextBox()
        Me.Chb_Tipo_Impresora = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Cb_Vendedor = New System.Windows.Forms.ComboBox()
        Me.Lv_Vendedor = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lb_correo = New System.Windows.Forms.Label()
        Me.txt_correo = New System.Windows.Forms.TextBox()
        Me.lb_cedula = New System.Windows.Forms.Label()
        Me.txt_cedula = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Btn_Salir
        '
        Me.Btn_Salir.Location = New System.Drawing.Point(265, 281)
        Me.Btn_Salir.Name = "Btn_Salir"
        Me.Btn_Salir.Size = New System.Drawing.Size(127, 34)
        Me.Btn_Salir.TabIndex = 8
        Me.Btn_Salir.Text = "Salir"
        Me.Btn_Salir.UseVisualStyleBackColor = True
        '
        'Btn_Actualizar
        '
        Me.Btn_Actualizar.Location = New System.Drawing.Point(134, 281)
        Me.Btn_Actualizar.Name = "Btn_Actualizar"
        Me.Btn_Actualizar.Size = New System.Drawing.Size(119, 34)
        Me.Btn_Actualizar.TabIndex = 7
        Me.Btn_Actualizar.Text = "Actualizar"
        Me.Btn_Actualizar.UseVisualStyleBackColor = True
        '
        'Txt_Telefono
        '
        Me.Txt_Telefono.Location = New System.Drawing.Point(134, 117)
        Me.Txt_Telefono.MaxLength = 15
        Me.Txt_Telefono.Name = "Txt_Telefono"
        Me.Txt_Telefono.Size = New System.Drawing.Size(365, 20)
        Me.Txt_Telefono.TabIndex = 3
        '
        'Txt_Nombre
        '
        Me.Txt_Nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Nombre.Location = New System.Drawing.Point(134, 39)
        Me.Txt_Nombre.MaxLength = 100
        Me.Txt_Nombre.Name = "Txt_Nombre"
        Me.Txt_Nombre.Size = New System.Drawing.Size(258, 20)
        Me.Txt_Nombre.TabIndex = 2
        '
        'Txt_Cod_Nombre
        '
        Me.Txt_Cod_Nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Cod_Nombre.Location = New System.Drawing.Point(134, 13)
        Me.Txt_Cod_Nombre.MaxLength = 20
        Me.Txt_Cod_Nombre.Name = "Txt_Cod_Nombre"
        Me.Txt_Cod_Nombre.ReadOnly = True
        Me.Txt_Cod_Nombre.Size = New System.Drawing.Size(136, 20)
        Me.Txt_Cod_Nombre.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(12, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 16)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Telefono"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(12, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 16)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Direccion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(12, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 16)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 16)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Codigo De Cliente"
        '
        'Txt_Direccion
        '
        Me.Txt_Direccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Direccion.Location = New System.Drawing.Point(134, 143)
        Me.Txt_Direccion.MaxLength = 80
        Me.Txt_Direccion.Multiline = True
        Me.Txt_Direccion.Name = "Txt_Direccion"
        Me.Txt_Direccion.Size = New System.Drawing.Size(365, 42)
        Me.Txt_Direccion.TabIndex = 4
        '
        'Txt_Advertencia
        '
        Me.Txt_Advertencia.BackColor = System.Drawing.Color.Yellow
        Me.Txt_Advertencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Advertencia.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Advertencia.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Txt_Advertencia.Location = New System.Drawing.Point(134, 252)
        Me.Txt_Advertencia.MaxLength = 250
        Me.Txt_Advertencia.Name = "Txt_Advertencia"
        Me.Txt_Advertencia.Size = New System.Drawing.Size(258, 23)
        Me.Txt_Advertencia.TabIndex = 6
        Me.Txt_Advertencia.Text = "ADVERTENCIA"
        Me.Txt_Advertencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Chb_Tipo_Impresora
        '
        Me.Chb_Tipo_Impresora.AutoSize = True
        Me.Chb_Tipo_Impresora.Location = New System.Drawing.Point(134, 229)
        Me.Chb_Tipo_Impresora.Margin = New System.Windows.Forms.Padding(2)
        Me.Chb_Tipo_Impresora.Name = "Chb_Tipo_Impresora"
        Me.Chb_Tipo_Impresora.Size = New System.Drawing.Size(167, 17)
        Me.Chb_Tipo_Impresora.TabIndex = 5
        Me.Chb_Tipo_Impresora.Text = "Usar siempre Impresora Matriz"
        Me.Chb_Tipo_Impresora.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 197)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 16)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Vendedor"
        '
        'Cb_Vendedor
        '
        Me.Cb_Vendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Vendedor.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_Vendedor.FormattingEnabled = True
        Me.Cb_Vendedor.Location = New System.Drawing.Point(134, 191)
        Me.Cb_Vendedor.Name = "Cb_Vendedor"
        Me.Cb_Vendedor.Size = New System.Drawing.Size(151, 23)
        Me.Cb_Vendedor.TabIndex = 23
        '
        'Lv_Vendedor
        '
        Me.Lv_Vendedor.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.Lv_Vendedor.FullRowSelect = True
        Me.Lv_Vendedor.GridLines = True
        Me.Lv_Vendedor.Location = New System.Drawing.Point(12, 257)
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
        'lb_correo
        '
        Me.lb_correo.AutoSize = True
        Me.lb_correo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lb_correo.Location = New System.Drawing.Point(11, 94)
        Me.lb_correo.Name = "lb_correo"
        Me.lb_correo.Size = New System.Drawing.Size(64, 16)
        Me.lb_correo.TabIndex = 39
        Me.lb_correo.Text = "Correo E."
        '
        'txt_correo
        '
        Me.txt_correo.Location = New System.Drawing.Point(134, 91)
        Me.txt_correo.MaxLength = 500
        Me.txt_correo.Name = "txt_correo"
        Me.txt_correo.Size = New System.Drawing.Size(365, 20)
        Me.txt_correo.TabIndex = 38
        '
        'lb_cedula
        '
        Me.lb_cedula.AutoSize = True
        Me.lb_cedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lb_cedula.Location = New System.Drawing.Point(11, 68)
        Me.lb_cedula.Name = "lb_cedula"
        Me.lb_cedula.Size = New System.Drawing.Size(51, 16)
        Me.lb_cedula.TabIndex = 37
        Me.lb_cedula.Text = "Cedula"
        '
        'txt_cedula
        '
        Me.txt_cedula.Location = New System.Drawing.Point(134, 65)
        Me.txt_cedula.MaxLength = 20
        Me.txt_cedula.Name = "txt_cedula"
        Me.txt_cedula.Size = New System.Drawing.Size(365, 20)
        Me.txt_cedula.TabIndex = 36
        '
        'Fr_Act_Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 365)
        Me.ControlBox = False
        Me.Controls.Add(Me.lb_correo)
        Me.Controls.Add(Me.txt_correo)
        Me.Controls.Add(Me.lb_cedula)
        Me.Controls.Add(Me.txt_cedula)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Cb_Vendedor)
        Me.Controls.Add(Me.Chb_Tipo_Impresora)
        Me.Controls.Add(Me.Txt_Advertencia)
        Me.Controls.Add(Me.Txt_Direccion)
        Me.Controls.Add(Me.Btn_Salir)
        Me.Controls.Add(Me.Btn_Actualizar)
        Me.Controls.Add(Me.Txt_Telefono)
        Me.Controls.Add(Me.Txt_Nombre)
        Me.Controls.Add(Me.Txt_Cod_Nombre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Lv_Vendedor)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1000, 800)
        Me.MinimumSize = New System.Drawing.Size(434, 350)
        Me.Name = "Fr_Act_Cliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actualizar Cliente"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_Salir As System.Windows.Forms.Button
    Friend WithEvents Btn_Actualizar As System.Windows.Forms.Button
    Friend WithEvents Txt_Telefono As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Cod_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txt_Direccion As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Advertencia As System.Windows.Forms.TextBox
    Friend WithEvents Chb_Tipo_Impresora As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Cb_Vendedor As ComboBox
    Friend WithEvents Lv_Vendedor As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents lb_correo As Label
    Friend WithEvents txt_correo As TextBox
    Friend WithEvents lb_cedula As Label
    Friend WithEvents txt_cedula As TextBox
End Class
