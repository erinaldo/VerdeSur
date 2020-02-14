<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fr_Opciones_Impresion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fr_Opciones_Impresion))
        Me.Btn_Original = New System.Windows.Forms.Button()
        Me.Btn_Copia = New System.Windows.Forms.Button()
        Me.Btn_Ambas = New System.Windows.Forms.Button()
        Me.Lv_Historial = New System.Windows.Forms.ListView()
        Me.Fecha = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Nro_Factura = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Cliente = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Total = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Lb_Factura = New System.Windows.Forms.Label()
        Me.Txt_Nombre = New System.Windows.Forms.TextBox()
        Me.Txt_Numero_Factura = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Btn_Original
        '
        Me.Btn_Original.Location = New System.Drawing.Point(111, 54)
        Me.Btn_Original.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Original.Name = "Btn_Original"
        Me.Btn_Original.Size = New System.Drawing.Size(103, 40)
        Me.Btn_Original.TabIndex = 0
        Me.Btn_Original.Text = "Imprimir Original"
        Me.Btn_Original.UseVisualStyleBackColor = True
        '
        'Btn_Copia
        '
        Me.Btn_Copia.Location = New System.Drawing.Point(218, 54)
        Me.Btn_Copia.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Copia.Name = "Btn_Copia"
        Me.Btn_Copia.Size = New System.Drawing.Size(103, 40)
        Me.Btn_Copia.TabIndex = 1
        Me.Btn_Copia.Text = "Imprimir Copia"
        Me.Btn_Copia.UseVisualStyleBackColor = True
        '
        'Btn_Ambas
        '
        Me.Btn_Ambas.Location = New System.Drawing.Point(326, 54)
        Me.Btn_Ambas.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Ambas.Name = "Btn_Ambas"
        Me.Btn_Ambas.Size = New System.Drawing.Size(103, 40)
        Me.Btn_Ambas.TabIndex = 2
        Me.Btn_Ambas.Text = "Imprimir Ambas"
        Me.Btn_Ambas.UseVisualStyleBackColor = True
        '
        'Lv_Historial
        '
        Me.Lv_Historial.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Fecha, Me.Nro_Factura, Me.Cliente, Me.Total, Me.ColumnHeader1})
        Me.Lv_Historial.FullRowSelect = True
        Me.Lv_Historial.GridLines = True
        Me.Lv_Historial.Location = New System.Drawing.Point(10, 99)
        Me.Lv_Historial.Name = "Lv_Historial"
        Me.Lv_Historial.Size = New System.Drawing.Size(688, 197)
        Me.Lv_Historial.TabIndex = 10
        Me.Lv_Historial.UseCompatibleStateImageBehavior = False
        Me.Lv_Historial.View = System.Windows.Forms.View.Details
        '
        'Fecha
        '
        Me.Fecha.Text = "Fecha"
        Me.Fecha.Width = 126
        '
        'Nro_Factura
        '
        Me.Nro_Factura.Text = "Nro. Factura"
        Me.Nro_Factura.Width = 90
        '
        'Cliente
        '
        Me.Cliente.Text = "Vendido A:"
        Me.Cliente.Width = 200
        '
        'Total
        '
        Me.Total.Text = "Total C."
        Me.Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Total.Width = 100
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Detalle"
        Me.ColumnHeader1.Width = 164
        '
        'Lb_Factura
        '
        Me.Lb_Factura.AutoSize = True
        Me.Lb_Factura.Font = New System.Drawing.Font("MS Reference Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Factura.Location = New System.Drawing.Point(35, 16)
        Me.Lb_Factura.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lb_Factura.Name = "Lb_Factura"
        Me.Lb_Factura.Size = New System.Drawing.Size(114, 28)
        Me.Lb_Factura.TabIndex = 11
        Me.Lb_Factura.Text = "lbFactura"
        '
        'Txt_Nombre
        '
        Me.Txt_Nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Nombre.Location = New System.Drawing.Point(543, 67)
        Me.Txt_Nombre.MaxLength = 100
        Me.Txt_Nombre.Name = "Txt_Nombre"
        Me.Txt_Nombre.Size = New System.Drawing.Size(139, 20)
        Me.Txt_Nombre.TabIndex = 12
        '
        'Txt_Numero_Factura
        '
        Me.Txt_Numero_Factura.Location = New System.Drawing.Point(543, 25)
        Me.Txt_Numero_Factura.MaxLength = 9
        Me.Txt_Numero_Factura.Name = "Txt_Numero_Factura"
        Me.Txt_Numero_Factura.Size = New System.Drawing.Size(139, 20)
        Me.Txt_Numero_Factura.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(540, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Numero Factura"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(540, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Nombre Cliente"
        '
        'Fr_Opciones_Impresion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 310)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txt_Numero_Factura)
        Me.Controls.Add(Me.Txt_Nombre)
        Me.Controls.Add(Me.Lb_Factura)
        Me.Controls.Add(Me.Lv_Historial)
        Me.Controls.Add(Me.Btn_Ambas)
        Me.Controls.Add(Me.Btn_Copia)
        Me.Controls.Add(Me.Btn_Original)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(720, 353)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(720, 353)
        Me.Name = "Fr_Opciones_Impresion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Opciones de Impresion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Original As Button
    Friend WithEvents Btn_Copia As Button
    Friend WithEvents Btn_Ambas As Button
    Friend WithEvents Lv_Historial As ListView
    Friend WithEvents Fecha As ColumnHeader
    Friend WithEvents Nro_Factura As ColumnHeader
    Friend WithEvents Cliente As ColumnHeader
    Friend WithEvents Total As ColumnHeader
    Friend WithEvents Lb_Factura As Label
    Friend WithEvents Txt_Nombre As TextBox
    Friend WithEvents Txt_Numero_Factura As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ColumnHeader1 As ColumnHeader
End Class
