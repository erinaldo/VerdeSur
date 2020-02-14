<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fr_motivo_reimpresion
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
        Me.rbtn_copia = New System.Windows.Forms.RadioButton()
        Me.rbtn_original_extraviada = New System.Windows.Forms.RadioButton()
        Me.btn_otro = New System.Windows.Forms.RadioButton()
        Me.rbtn_cambio_papel = New System.Windows.Forms.RadioButton()
        Me.txt_otro = New System.Windows.Forms.TextBox()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.rbtn_modifficacion_producto = New System.Windows.Forms.RadioButton()
        Me.lb_1 = New System.Windows.Forms.Label()
        Me.lb_2 = New System.Windows.Forms.Label()
        Me.lb_3 = New System.Windows.Forms.Label()
        Me.lb_4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'rbtn_copia
        '
        Me.rbtn_copia.AutoSize = True
        Me.rbtn_copia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_copia.Location = New System.Drawing.Point(122, 26)
        Me.rbtn_copia.Name = "rbtn_copia"
        Me.rbtn_copia.Size = New System.Drawing.Size(152, 20)
        Me.rbtn_copia.TabIndex = 0
        Me.rbtn_copia.TabStop = True
        Me.rbtn_copia.Text = "Copia Para el Cliente"
        Me.rbtn_copia.UseVisualStyleBackColor = True
        '
        'rbtn_original_extraviada
        '
        Me.rbtn_original_extraviada.AutoSize = True
        Me.rbtn_original_extraviada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_original_extraviada.Location = New System.Drawing.Point(122, 68)
        Me.rbtn_original_extraviada.Name = "rbtn_original_extraviada"
        Me.rbtn_original_extraviada.Size = New System.Drawing.Size(139, 20)
        Me.rbtn_original_extraviada.TabIndex = 2
        Me.rbtn_original_extraviada.TabStop = True
        Me.rbtn_original_extraviada.Text = "Original Extraviada"
        Me.rbtn_original_extraviada.UseVisualStyleBackColor = True
        '
        'btn_otro
        '
        Me.btn_otro.AutoSize = True
        Me.btn_otro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_otro.Location = New System.Drawing.Point(49, 123)
        Me.btn_otro.Name = "btn_otro"
        Me.btn_otro.Size = New System.Drawing.Size(127, 20)
        Me.btn_otro.TabIndex = 4
        Me.btn_otro.TabStop = True
        Me.btn_otro.Text = "Otro, especifique"
        Me.btn_otro.UseVisualStyleBackColor = True
        '
        'rbtn_cambio_papel
        '
        Me.rbtn_cambio_papel.AutoSize = True
        Me.rbtn_cambio_papel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_cambio_papel.Location = New System.Drawing.Point(312, 68)
        Me.rbtn_cambio_papel.Name = "rbtn_cambio_papel"
        Me.rbtn_cambio_papel.Size = New System.Drawing.Size(133, 20)
        Me.rbtn_cambio_papel.TabIndex = 3
        Me.rbtn_cambio_papel.TabStop = True
        Me.rbtn_cambio_papel.Text = "Cambio de  papel"
        Me.rbtn_cambio_papel.UseVisualStyleBackColor = True
        '
        'txt_otro
        '
        Me.txt_otro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_otro.Location = New System.Drawing.Point(182, 123)
        Me.txt_otro.Name = "txt_otro"
        Me.txt_otro.Size = New System.Drawing.Size(340, 22)
        Me.txt_otro.TabIndex = 5
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Location = New System.Drawing.Point(184, 177)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(106, 34)
        Me.btn_aceptar.TabIndex = 6
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(296, 177)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(106, 34)
        Me.btn_cancelar.TabIndex = 7
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'rbtn_modifficacion_producto
        '
        Me.rbtn_modifficacion_producto.AutoSize = True
        Me.rbtn_modifficacion_producto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_modifficacion_producto.Location = New System.Drawing.Point(312, 26)
        Me.rbtn_modifficacion_producto.Name = "rbtn_modifficacion_producto"
        Me.rbtn_modifficacion_producto.Size = New System.Drawing.Size(169, 20)
        Me.rbtn_modifficacion_producto.TabIndex = 1
        Me.rbtn_modifficacion_producto.TabStop = True
        Me.rbtn_modifficacion_producto.Text = "Modificación de Factura"
        Me.rbtn_modifficacion_producto.UseVisualStyleBackColor = True
        '
        'lb_1
        '
        Me.lb_1.AutoSize = True
        Me.lb_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_1.Location = New System.Drawing.Point(103, 28)
        Me.lb_1.Name = "lb_1"
        Me.lb_1.Size = New System.Drawing.Size(15, 16)
        Me.lb_1.TabIndex = 8
        Me.lb_1.Text = "1"
        '
        'lb_2
        '
        Me.lb_2.AutoSize = True
        Me.lb_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_2.Location = New System.Drawing.Point(293, 28)
        Me.lb_2.Name = "lb_2"
        Me.lb_2.Size = New System.Drawing.Size(15, 16)
        Me.lb_2.TabIndex = 9
        Me.lb_2.Text = "2"
        '
        'lb_3
        '
        Me.lb_3.AutoSize = True
        Me.lb_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_3.Location = New System.Drawing.Point(103, 68)
        Me.lb_3.Name = "lb_3"
        Me.lb_3.Size = New System.Drawing.Size(15, 16)
        Me.lb_3.TabIndex = 10
        Me.lb_3.Text = "3"
        '
        'lb_4
        '
        Me.lb_4.AutoSize = True
        Me.lb_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_4.Location = New System.Drawing.Point(291, 68)
        Me.lb_4.Name = "lb_4"
        Me.lb_4.Size = New System.Drawing.Size(15, 16)
        Me.lb_4.TabIndex = 11
        Me.lb_4.Text = "4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "5"
        '
        'Fr_motivo_reimpresion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 223)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lb_4)
        Me.Controls.Add(Me.lb_3)
        Me.Controls.Add(Me.lb_2)
        Me.Controls.Add(Me.lb_1)
        Me.Controls.Add(Me.rbtn_modifficacion_producto)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.txt_otro)
        Me.Controls.Add(Me.btn_otro)
        Me.Controls.Add(Me.rbtn_cambio_papel)
        Me.Controls.Add(Me.rbtn_original_extraviada)
        Me.Controls.Add(Me.rbtn_copia)
        Me.Name = "Fr_motivo_reimpresion"
        Me.Text = "Motivo de Reimpresion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rbtn_copia As RadioButton
    Friend WithEvents rbtn_original_extraviada As RadioButton
    Friend WithEvents btn_otro As RadioButton
    Friend WithEvents rbtn_cambio_papel As RadioButton
    Friend WithEvents txt_otro As TextBox
    Friend WithEvents btn_aceptar As Button
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents rbtn_modifficacion_producto As RadioButton
    Friend WithEvents lb_1 As Label
    Friend WithEvents lb_2 As Label
    Friend WithEvents lb_3 As Label
    Friend WithEvents lb_4 As Label
    Friend WithEvents Label5 As Label
End Class
