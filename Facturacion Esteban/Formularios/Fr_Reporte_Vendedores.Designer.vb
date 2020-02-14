<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fr_Reporte_Vendedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fr_Reporte_Vendedores))
        Me.Dt_Inicio = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Dt_Fin = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_Vendedor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Btn_Buscar = New System.Windows.Forms.Button()
        Me.Btn_Aceptar = New System.Windows.Forms.Button()
        Me.Btn_Salir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Dt_Inicio
        '
        Me.Dt_Inicio.Location = New System.Drawing.Point(53, 29)
        Me.Dt_Inicio.Name = "Dt_Inicio"
        Me.Dt_Inicio.Size = New System.Drawing.Size(143, 20)
        Me.Dt_Inicio.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Dt_Fin)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Dt_Inicio)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(501, 77)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fechas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(202, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Hasta"
        '
        'Dt_Fin
        '
        Me.Dt_Fin.Location = New System.Drawing.Point(243, 29)
        Me.Dt_Fin.Name = "Dt_Fin"
        Me.Dt_Fin.Size = New System.Drawing.Size(143, 20)
        Me.Dt_Fin.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Desde:"
        '
        'Txt_Vendedor
        '
        Me.Txt_Vendedor.BackColor = System.Drawing.SystemColors.Info
        Me.Txt_Vendedor.Location = New System.Drawing.Point(65, 31)
        Me.Txt_Vendedor.Name = "Txt_Vendedor"
        Me.Txt_Vendedor.ReadOnly = True
        Me.Txt_Vendedor.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Vendedor.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Vendedor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(252, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(219, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "* Dejar en Blanco Para todos los vendedores"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Btn_Buscar)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Txt_Vendedor)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 95)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(501, 64)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Vendedor"
        '
        'Btn_Buscar
        '
        Me.Btn_Buscar.Location = New System.Drawing.Point(171, 29)
        Me.Btn_Buscar.Name = "Btn_Buscar"
        Me.Btn_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Buscar.TabIndex = 7
        Me.Btn_Buscar.Text = "Buscar"
        Me.Btn_Buscar.UseVisualStyleBackColor = True
        '
        'Btn_Aceptar
        '
        Me.Btn_Aceptar.Location = New System.Drawing.Point(33, 174)
        Me.Btn_Aceptar.Name = "Btn_Aceptar"
        Me.Btn_Aceptar.Size = New System.Drawing.Size(227, 36)
        Me.Btn_Aceptar.TabIndex = 8
        Me.Btn_Aceptar.Text = "Aceptar"
        Me.Btn_Aceptar.UseVisualStyleBackColor = True
        '
        'Btn_Salir
        '
        Me.Btn_Salir.Location = New System.Drawing.Point(278, 174)
        Me.Btn_Salir.Name = "Btn_Salir"
        Me.Btn_Salir.Size = New System.Drawing.Size(223, 36)
        Me.Btn_Salir.TabIndex = 9
        Me.Btn_Salir.Text = "Salir"
        Me.Btn_Salir.UseVisualStyleBackColor = True
        '
        'Fr_Reporte_Vendedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 234)
        Me.Controls.Add(Me.Btn_Salir)
        Me.Controls.Add(Me.Btn_Aceptar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(545, 273)
        Me.Name = "Fr_Reporte_Vendedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Vendedores"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Dt_Inicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Dt_Fin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txt_Vendedor As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents Btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents Btn_Salir As System.Windows.Forms.Button
End Class
