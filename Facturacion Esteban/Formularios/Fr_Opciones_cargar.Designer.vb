<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fr_Opciones_cargar
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
        Me.CB_Arriba = New System.Windows.Forms.CheckBox()
        Me.CB_Abajo = New System.Windows.Forms.CheckBox()
        Me.CB_Feria_Abajo = New System.Windows.Forms.CheckBox()
        Me.CB_Feria = New System.Windows.Forms.CheckBox()
        Me.CB_Lista = New System.Windows.Forms.CheckBox()
        Me.Btn_Generar = New System.Windows.Forms.Button()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Dt_Fin = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Dt_Inicio = New System.Windows.Forms.DateTimePicker()
        Me.Opciones = New System.Windows.Forms.GroupBox()
        Me.Lb_Mensaje = New System.Windows.Forms.Label()
        Me.PB_Opciones_cargar = New System.Windows.Forms.ProgressBar()
        Me.GroupBox1.SuspendLayout()
        Me.Opciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'CB_Arriba
        '
        Me.CB_Arriba.AutoSize = True
        Me.CB_Arriba.Location = New System.Drawing.Point(41, 43)
        Me.CB_Arriba.Name = "CB_Arriba"
        Me.CB_Arriba.Size = New System.Drawing.Size(56, 17)
        Me.CB_Arriba.TabIndex = 0
        Me.CB_Arriba.Text = "Arrriba"
        Me.CB_Arriba.UseVisualStyleBackColor = True
        '
        'CB_Abajo
        '
        Me.CB_Abajo.AutoSize = True
        Me.CB_Abajo.Location = New System.Drawing.Point(103, 43)
        Me.CB_Abajo.Name = "CB_Abajo"
        Me.CB_Abajo.Size = New System.Drawing.Size(53, 17)
        Me.CB_Abajo.TabIndex = 1
        Me.CB_Abajo.Text = "Abajo"
        Me.CB_Abajo.UseVisualStyleBackColor = True
        '
        'CB_Feria_Abajo
        '
        Me.CB_Feria_Abajo.AutoSize = True
        Me.CB_Feria_Abajo.Location = New System.Drawing.Point(162, 43)
        Me.CB_Feria_Abajo.Name = "CB_Feria_Abajo"
        Me.CB_Feria_Abajo.Size = New System.Drawing.Size(79, 17)
        Me.CB_Feria_Abajo.TabIndex = 2
        Me.CB_Feria_Abajo.Text = "Feria Abajo"
        Me.CB_Feria_Abajo.UseVisualStyleBackColor = True
        '
        'CB_Feria
        '
        Me.CB_Feria.AutoSize = True
        Me.CB_Feria.Location = New System.Drawing.Point(247, 43)
        Me.CB_Feria.Name = "CB_Feria"
        Me.CB_Feria.Size = New System.Drawing.Size(49, 17)
        Me.CB_Feria.TabIndex = 3
        Me.CB_Feria.Text = "Feria"
        Me.CB_Feria.UseVisualStyleBackColor = True
        '
        'CB_Lista
        '
        Me.CB_Lista.AutoSize = True
        Me.CB_Lista.Location = New System.Drawing.Point(302, 43)
        Me.CB_Lista.Name = "CB_Lista"
        Me.CB_Lista.Size = New System.Drawing.Size(48, 17)
        Me.CB_Lista.TabIndex = 4
        Me.CB_Lista.Text = "Lista"
        Me.CB_Lista.UseVisualStyleBackColor = True
        '
        'Btn_Generar
        '
        Me.Btn_Generar.Location = New System.Drawing.Point(115, 187)
        Me.Btn_Generar.Name = "Btn_Generar"
        Me.Btn_Generar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Generar.TabIndex = 5
        Me.Btn_Generar.Text = "Generar Reporte"
        Me.Btn_Generar.UseVisualStyleBackColor = True
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.Location = New System.Drawing.Point(208, 187)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Cancelar.TabIndex = 6
        Me.Btn_Cancelar.Text = "Cancelar"
        Me.Btn_Cancelar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Dt_Fin)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Dt_Inicio)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(395, 77)
        Me.GroupBox1.TabIndex = 15
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
        Me.Dt_Fin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
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
        Me.Dt_Inicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dt_Inicio.Location = New System.Drawing.Point(53, 29)
        Me.Dt_Inicio.Name = "Dt_Inicio"
        Me.Dt_Inicio.Size = New System.Drawing.Size(143, 20)
        Me.Dt_Inicio.TabIndex = 0
        '
        'Opciones
        '
        Me.Opciones.Controls.Add(Me.CB_Lista)
        Me.Opciones.Controls.Add(Me.CB_Feria)
        Me.Opciones.Controls.Add(Me.CB_Feria_Abajo)
        Me.Opciones.Controls.Add(Me.CB_Abajo)
        Me.Opciones.Controls.Add(Me.CB_Arriba)
        Me.Opciones.Location = New System.Drawing.Point(12, 95)
        Me.Opciones.Name = "Opciones"
        Me.Opciones.Size = New System.Drawing.Size(395, 86)
        Me.Opciones.TabIndex = 4
        Me.Opciones.TabStop = False
        Me.Opciones.Text = "Opciones"
        '
        'Lb_Mensaje
        '
        Me.Lb_Mensaje.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lb_Mensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Mensaje.ForeColor = System.Drawing.Color.DarkBlue
        Me.Lb_Mensaje.Location = New System.Drawing.Point(1, 214)
        Me.Lb_Mensaje.Name = "Lb_Mensaje"
        Me.Lb_Mensaje.Size = New System.Drawing.Size(415, 21)
        Me.Lb_Mensaje.TabIndex = 16
        Me.Lb_Mensaje.Text = "Label3"
        Me.Lb_Mensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Lb_Mensaje.Visible = False
        '
        'PB_Opciones_cargar
        '
        Me.PB_Opciones_cargar.Location = New System.Drawing.Point(0, 252)
        Me.PB_Opciones_cargar.Name = "PB_Opciones_cargar"
        Me.PB_Opciones_cargar.Size = New System.Drawing.Size(415, 23)
        Me.PB_Opciones_cargar.TabIndex = 17
        '
        'Fr_Opciones_cargar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 278)
        Me.ControlBox = False
        Me.Controls.Add(Me.PB_Opciones_cargar)
        Me.Controls.Add(Me.Opciones)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Btn_Cancelar)
        Me.Controls.Add(Me.Btn_Generar)
        Me.Controls.Add(Me.Lb_Mensaje)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(442, 342)
        Me.MinimumSize = New System.Drawing.Size(400, 293)
        Me.Name = "Fr_Opciones_cargar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Opciones"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Opciones.ResumeLayout(False)
        Me.Opciones.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CB_Arriba As CheckBox
    Friend WithEvents CB_Abajo As CheckBox
    Friend WithEvents CB_Feria_Abajo As CheckBox
    Friend WithEvents CB_Feria As CheckBox
    Friend WithEvents CB_Lista As CheckBox
    Friend WithEvents Btn_Generar As Button
    Friend WithEvents Btn_Cancelar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Dt_Fin As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Dt_Inicio As DateTimePicker
    Friend WithEvents Opciones As GroupBox
    Friend WithEvents Lb_Mensaje As Label
    Friend WithEvents PB_Opciones_cargar As ProgressBar
End Class
