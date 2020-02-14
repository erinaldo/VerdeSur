<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fr_Condimientos
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
        Me.Lv_Condimentos = New System.Windows.Forms.ListView()
        Me.Txt_Condimento = New System.Windows.Forms.TextBox()
        Me.Num_Sugerido = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lbprecio = New System.Windows.Forms.Label()
        Me.Txt_Precio = New System.Windows.Forms.TextBox()
        Me.Chb_Impuesto = New System.Windows.Forms.CheckBox()
        Me.Txt_Mayor = New System.Windows.Forms.TextBox()
        Me.lbmayor = New System.Windows.Forms.Label()
        Me.lbsugerido = New System.Windows.Forms.Label()
        Me.Txt_Sugerido = New System.Windows.Forms.TextBox()
        Me.Num_Mayor = New System.Windows.Forms.NumericUpDown()
        Me.Btn_Actualizar = New System.Windows.Forms.Button()
        Me.Btn_Agregar = New System.Windows.Forms.Button()
        Me.Txt_Codigo = New System.Windows.Forms.TextBox()
        Me.lbcodigo = New System.Windows.Forms.Label()
        Me.Btn_Salir = New System.Windows.Forms.Button()
        Me.Txt_Nombre_Actualizar = New System.Windows.Forms.TextBox()
        Me.Chb_Nombre = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.Num_Sugerido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Num_Mayor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lv_Condimentos
        '
        Me.Lv_Condimentos.FullRowSelect = True
        Me.Lv_Condimentos.GridLines = True
        Me.Lv_Condimentos.Location = New System.Drawing.Point(12, 135)
        Me.Lv_Condimentos.Name = "Lv_Condimentos"
        Me.Lv_Condimentos.Size = New System.Drawing.Size(622, 143)
        Me.Lv_Condimentos.TabIndex = 11
        Me.Lv_Condimentos.UseCompatibleStateImageBehavior = False
        '
        'Txt_Condimento
        '
        Me.Txt_Condimento.BackColor = System.Drawing.Color.Cyan
        Me.Txt_Condimento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Condimento.Location = New System.Drawing.Point(12, 75)
        Me.Txt_Condimento.MaxLength = 50
        Me.Txt_Condimento.Name = "Txt_Condimento"
        Me.Txt_Condimento.Size = New System.Drawing.Size(152, 20)
        Me.Txt_Condimento.TabIndex = 2
        Me.Txt_Condimento.Text = "ESCRIBA EL CONDIMENTO"
        '
        'Num_Sugerido
        '
        Me.Num_Sugerido.Location = New System.Drawing.Point(398, 101)
        Me.Num_Sugerido.Name = "Num_Sugerido"
        Me.Num_Sugerido.Size = New System.Drawing.Size(57, 20)
        Me.Num_Sugerido.TabIndex = 9
        Me.Num_Sugerido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Num_Sugerido.Value = New Decimal(New Integer() {80, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Condimento"
        '
        'Lbprecio
        '
        Me.Lbprecio.AutoSize = True
        Me.Lbprecio.Location = New System.Drawing.Point(194, 59)
        Me.Lbprecio.Name = "Lbprecio"
        Me.Lbprecio.Size = New System.Drawing.Size(37, 13)
        Me.Lbprecio.TabIndex = 4
        Me.Lbprecio.Text = "Precio"
        '
        'Txt_Precio
        '
        Me.Txt_Precio.Location = New System.Drawing.Point(170, 75)
        Me.Txt_Precio.MaxLength = 12
        Me.Txt_Precio.Name = "Txt_Precio"
        Me.Txt_Precio.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Precio.TabIndex = 3
        Me.Txt_Precio.Text = "0"
        Me.Txt_Precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Chb_Impuesto
        '
        Me.Chb_Impuesto.AutoSize = True
        Me.Chb_Impuesto.Location = New System.Drawing.Point(276, 77)
        Me.Chb_Impuesto.Name = "Chb_Impuesto"
        Me.Chb_Impuesto.Size = New System.Drawing.Size(74, 17)
        Me.Chb_Impuesto.TabIndex = 4
        Me.Chb_Impuesto.Text = "Impuestos"
        Me.Chb_Impuesto.UseVisualStyleBackColor = True
        '
        'Txt_Mayor
        '
        Me.Txt_Mayor.Location = New System.Drawing.Point(462, 75)
        Me.Txt_Mayor.MaxLength = 12
        Me.Txt_Mayor.Name = "Txt_Mayor"
        Me.Txt_Mayor.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Mayor.TabIndex = 6
        Me.Txt_Mayor.Text = "0"
        Me.Txt_Mayor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbmayor
        '
        Me.lbmayor.AutoSize = True
        Me.lbmayor.Location = New System.Drawing.Point(487, 59)
        Me.lbmayor.Name = "lbmayor"
        Me.lbmayor.Size = New System.Drawing.Size(55, 13)
        Me.lbmayor.TabIndex = 9
        Me.lbmayor.Text = "Por Mayor"
        '
        'lbsugerido
        '
        Me.lbsugerido.AutoSize = True
        Me.lbsugerido.Location = New System.Drawing.Point(380, 59)
        Me.lbsugerido.Name = "lbsugerido"
        Me.lbsugerido.Size = New System.Drawing.Size(49, 13)
        Me.lbsugerido.TabIndex = 8
        Me.lbsugerido.Text = "Sugerido"
        '
        'Txt_Sugerido
        '
        Me.Txt_Sugerido.Location = New System.Drawing.Point(356, 75)
        Me.Txt_Sugerido.MaxLength = 12
        Me.Txt_Sugerido.Name = "Txt_Sugerido"
        Me.Txt_Sugerido.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Sugerido.TabIndex = 5
        Me.Txt_Sugerido.Text = "0"
        Me.Txt_Sugerido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Num_Mayor
        '
        Me.Num_Mayor.Location = New System.Drawing.Point(503, 101)
        Me.Num_Mayor.Name = "Num_Mayor"
        Me.Num_Mayor.Size = New System.Drawing.Size(57, 20)
        Me.Num_Mayor.TabIndex = 10
        Me.Num_Mayor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Num_Mayor.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'Btn_Actualizar
        '
        Me.Btn_Actualizar.Location = New System.Drawing.Point(175, 300)
        Me.Btn_Actualizar.Name = "Btn_Actualizar"
        Me.Btn_Actualizar.Size = New System.Drawing.Size(140, 35)
        Me.Btn_Actualizar.TabIndex = 13
        Me.Btn_Actualizar.Text = "Actualizar"
        Me.Btn_Actualizar.UseVisualStyleBackColor = True
        '
        'Btn_Agregar
        '
        Me.Btn_Agregar.Location = New System.Drawing.Point(24, 301)
        Me.Btn_Agregar.Name = "Btn_Agregar"
        Me.Btn_Agregar.Size = New System.Drawing.Size(140, 35)
        Me.Btn_Agregar.TabIndex = 12
        Me.Btn_Agregar.Text = "Agregar"
        Me.Btn_Agregar.UseVisualStyleBackColor = True
        '
        'Txt_Codigo
        '
        Me.Txt_Codigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Codigo.Location = New System.Drawing.Point(12, 36)
        Me.Txt_Codigo.MaxLength = 20
        Me.Txt_Codigo.Name = "Txt_Codigo"
        Me.Txt_Codigo.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Codigo.TabIndex = 1
        '
        'lbcodigo
        '
        Me.lbcodigo.AutoSize = True
        Me.lbcodigo.Location = New System.Drawing.Point(36, 20)
        Me.lbcodigo.Name = "lbcodigo"
        Me.lbcodigo.Size = New System.Drawing.Size(40, 13)
        Me.lbcodigo.TabIndex = 14
        Me.lbcodigo.Text = "Codigo"
        '
        'Btn_Salir
        '
        Me.Btn_Salir.Location = New System.Drawing.Point(331, 300)
        Me.Btn_Salir.Name = "Btn_Salir"
        Me.Btn_Salir.Size = New System.Drawing.Size(140, 35)
        Me.Btn_Salir.TabIndex = 14
        Me.Btn_Salir.Text = "Salir"
        Me.Btn_Salir.UseVisualStyleBackColor = True
        '
        'Txt_Nombre_Actualizar
        '
        Me.Txt_Nombre_Actualizar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Nombre_Actualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Nombre_Actualizar.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Txt_Nombre_Actualizar.Location = New System.Drawing.Point(12, 101)
        Me.Txt_Nombre_Actualizar.MaxLength = 50
        Me.Txt_Nombre_Actualizar.Name = "Txt_Nombre_Actualizar"
        Me.Txt_Nombre_Actualizar.Size = New System.Drawing.Size(152, 20)
        Me.Txt_Nombre_Actualizar.TabIndex = 7
        '
        'Chb_Nombre
        '
        Me.Chb_Nombre.AutoSize = True
        Me.Chb_Nombre.Location = New System.Drawing.Point(174, 103)
        Me.Chb_Nombre.Name = "Chb_Nombre"
        Me.Chb_Nombre.Size = New System.Drawing.Size(112, 17)
        Me.Chb_Nombre.TabIndex = 8
        Me.Chb_Nombre.Text = "Actualizar Nombre"
        Me.Chb_Nombre.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.Facturacion_Esteban.My.Resources.Resources.images1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(643, 349)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'Fr_Condimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 349)
        Me.ControlBox = False
        Me.Controls.Add(Me.Chb_Nombre)
        Me.Controls.Add(Me.Txt_Nombre_Actualizar)
        Me.Controls.Add(Me.Btn_Salir)
        Me.Controls.Add(Me.Txt_Codigo)
        Me.Controls.Add(Me.lbcodigo)
        Me.Controls.Add(Me.Btn_Agregar)
        Me.Controls.Add(Me.Btn_Actualizar)
        Me.Controls.Add(Me.Num_Mayor)
        Me.Controls.Add(Me.Txt_Mayor)
        Me.Controls.Add(Me.lbmayor)
        Me.Controls.Add(Me.lbsugerido)
        Me.Controls.Add(Me.Txt_Sugerido)
        Me.Controls.Add(Me.Chb_Impuesto)
        Me.Controls.Add(Me.Txt_Precio)
        Me.Controls.Add(Me.Lbprecio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Num_Sugerido)
        Me.Controls.Add(Me.Txt_Condimento)
        Me.Controls.Add(Me.Lv_Condimentos)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Name = "Fr_Condimientos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONDIMENTOS"
        CType(Me.Num_Sugerido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Num_Mayor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lv_Condimentos As System.Windows.Forms.ListView
    Friend WithEvents Txt_Condimento As System.Windows.Forms.TextBox
    Friend WithEvents Num_Sugerido As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Lbprecio As System.Windows.Forms.Label
    Friend WithEvents Txt_Precio As System.Windows.Forms.TextBox
    Friend WithEvents Chb_Impuesto As System.Windows.Forms.CheckBox
    Friend WithEvents Txt_Mayor As System.Windows.Forms.TextBox
    Friend WithEvents lbmayor As System.Windows.Forms.Label
    Friend WithEvents lbsugerido As System.Windows.Forms.Label
    Friend WithEvents Txt_Sugerido As System.Windows.Forms.TextBox
    Friend WithEvents Num_Mayor As System.Windows.Forms.NumericUpDown
    Friend WithEvents Btn_Actualizar As System.Windows.Forms.Button
    Friend WithEvents Btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents Txt_Codigo As System.Windows.Forms.TextBox
    Friend WithEvents lbcodigo As System.Windows.Forms.Label
    Friend WithEvents Btn_Salir As System.Windows.Forms.Button
    Friend WithEvents Txt_Nombre_Actualizar As System.Windows.Forms.TextBox
    Friend WithEvents Chb_Nombre As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
