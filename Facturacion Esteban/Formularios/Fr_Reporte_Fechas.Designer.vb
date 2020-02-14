<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fr_Reporte_Fechas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fr_Reporte_Fechas))
        Me.Btn_Salir = New System.Windows.Forms.Button()
        Me.Btn_Generar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Dt_Fin = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Dt_Inicio = New System.Windows.Forms.DateTimePicker()
        Me.PB_Opciones_cargar = New System.Windows.Forms.ProgressBar()
        Me.Lb_Mensaje = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_Salir
        '
        Me.Btn_Salir.Location = New System.Drawing.Point(272, 96)
        Me.Btn_Salir.Name = "Btn_Salir"
        Me.Btn_Salir.Size = New System.Drawing.Size(223, 36)
        Me.Btn_Salir.TabIndex = 17
        Me.Btn_Salir.Text = "Salir"
        Me.Btn_Salir.UseVisualStyleBackColor = True
        '
        'Btn_Generar
        '
        Me.Btn_Generar.Location = New System.Drawing.Point(27, 96)
        Me.Btn_Generar.Name = "Btn_Generar"
        Me.Btn_Generar.Size = New System.Drawing.Size(227, 36)
        Me.Btn_Generar.TabIndex = 16
        Me.Btn_Generar.Text = "Aceptar"
        Me.Btn_Generar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Dt_Fin)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Dt_Inicio)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(501, 77)
        Me.GroupBox1.TabIndex = 14
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
        'Dt_Inicio
        '
        Me.Dt_Inicio.Location = New System.Drawing.Point(53, 29)
        Me.Dt_Inicio.Name = "Dt_Inicio"
        Me.Dt_Inicio.Size = New System.Drawing.Size(143, 20)
        Me.Dt_Inicio.TabIndex = 0
        '
        'PB_Opciones_cargar
        '
        Me.PB_Opciones_cargar.Location = New System.Drawing.Point(12, 193)
        Me.PB_Opciones_cargar.Name = "PB_Opciones_cargar"
        Me.PB_Opciones_cargar.Size = New System.Drawing.Size(503, 23)
        Me.PB_Opciones_cargar.TabIndex = 19
        '
        'Lb_Mensaje
        '
        Me.Lb_Mensaje.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lb_Mensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Mensaje.ForeColor = System.Drawing.Color.DarkBlue
        Me.Lb_Mensaje.Location = New System.Drawing.Point(12, 153)
        Me.Lb_Mensaje.Name = "Lb_Mensaje"
        Me.Lb_Mensaje.Size = New System.Drawing.Size(503, 21)
        Me.Lb_Mensaje.TabIndex = 18
        Me.Lb_Mensaje.Text = "Label3"
        Me.Lb_Mensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Lb_Mensaje.Visible = False
        '
        'Fr_Reporte_Fechas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 179)
        Me.Controls.Add(Me.PB_Opciones_cargar)
        Me.Controls.Add(Me.Lb_Mensaje)
        Me.Controls.Add(Me.Btn_Salir)
        Me.Controls.Add(Me.Btn_Generar)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(545, 265)
        Me.Name = "Fr_Reporte_Fechas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Por Fechas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Btn_Salir As System.Windows.Forms.Button
    Friend WithEvents Btn_Generar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Dt_Fin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Dt_Inicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents PB_Opciones_cargar As ProgressBar
    Friend WithEvents Lb_Mensaje As Label
End Class
