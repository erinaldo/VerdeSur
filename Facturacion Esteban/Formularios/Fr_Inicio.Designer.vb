<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fr_Inicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fr_Inicio))
        Me.Btn_Clientes = New System.Windows.Forms.Button()
        Me.Btn_Inventarios = New System.Windows.Forms.Button()
        Me.Btn_Salir = New System.Windows.Forms.Button()
        Me.Btn_Vendedores = New System.Windows.Forms.Button()
        Me.Btn_Configuracion = New System.Windows.Forms.Button()
        Me.Btn_Facturacion = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Btn_Condimentos = New System.Windows.Forms.Button()
        Me.Lb_Version = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_Clientes
        '
        Me.Btn_Clientes.Font = New System.Drawing.Font("Lucida Sans", 16.0!)
        Me.Btn_Clientes.Location = New System.Drawing.Point(361, 147)
        Me.Btn_Clientes.Name = "Btn_Clientes"
        Me.Btn_Clientes.Size = New System.Drawing.Size(163, 76)
        Me.Btn_Clientes.TabIndex = 1
        Me.Btn_Clientes.Text = "&Clientes"
        Me.Btn_Clientes.UseVisualStyleBackColor = True
        '
        'Btn_Inventarios
        '
        Me.Btn_Inventarios.Font = New System.Drawing.Font("Lucida Sans", 16.0!)
        Me.Btn_Inventarios.Location = New System.Drawing.Point(530, 147)
        Me.Btn_Inventarios.Name = "Btn_Inventarios"
        Me.Btn_Inventarios.Size = New System.Drawing.Size(172, 76)
        Me.Btn_Inventarios.TabIndex = 2
        Me.Btn_Inventarios.Text = "&Inventarios"
        Me.Btn_Inventarios.UseVisualStyleBackColor = True
        '
        'Btn_Salir
        '
        Me.Btn_Salir.Font = New System.Drawing.Font("Lucida Sans", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Salir.Location = New System.Drawing.Point(361, 348)
        Me.Btn_Salir.Name = "Btn_Salir"
        Me.Btn_Salir.Size = New System.Drawing.Size(163, 76)
        Me.Btn_Salir.TabIndex = 3
        Me.Btn_Salir.Text = "&Salir"
        Me.Btn_Salir.UseVisualStyleBackColor = True
        '
        'Btn_Vendedores
        '
        Me.Btn_Vendedores.Font = New System.Drawing.Font("Lucida Sans", 16.0!)
        Me.Btn_Vendedores.Location = New System.Drawing.Point(361, 234)
        Me.Btn_Vendedores.Name = "Btn_Vendedores"
        Me.Btn_Vendedores.Size = New System.Drawing.Size(163, 76)
        Me.Btn_Vendedores.TabIndex = 5
        Me.Btn_Vendedores.Text = "&Vendedores"
        Me.Btn_Vendedores.UseVisualStyleBackColor = True
        '
        'Btn_Configuracion
        '
        Me.Btn_Configuracion.Font = New System.Drawing.Font("Lucida Sans", 16.0!)
        Me.Btn_Configuracion.Location = New System.Drawing.Point(530, 234)
        Me.Btn_Configuracion.Name = "Btn_Configuracion"
        Me.Btn_Configuracion.Size = New System.Drawing.Size(172, 76)
        Me.Btn_Configuracion.TabIndex = 6
        Me.Btn_Configuracion.Text = "Configuracion"
        Me.Btn_Configuracion.UseVisualStyleBackColor = True
        '
        'Btn_Facturacion
        '
        Me.Btn_Facturacion.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Facturacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Btn_Facturacion.Font = New System.Drawing.Font("Lucida Sans", 16.0!)
        Me.Btn_Facturacion.Location = New System.Drawing.Point(199, 147)
        Me.Btn_Facturacion.Name = "Btn_Facturacion"
        Me.Btn_Facturacion.Size = New System.Drawing.Size(157, 76)
        Me.Btn_Facturacion.TabIndex = 0
        Me.Btn_Facturacion.Text = "&Facturacion"
        Me.Btn_Facturacion.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(900, 454)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Btn_Condimentos
        '
        Me.Btn_Condimentos.Font = New System.Drawing.Font("Lucida Sans", 14.0!)
        Me.Btn_Condimentos.Location = New System.Drawing.Point(198, 234)
        Me.Btn_Condimentos.Name = "Btn_Condimentos"
        Me.Btn_Condimentos.Size = New System.Drawing.Size(157, 76)
        Me.Btn_Condimentos.TabIndex = 7
        Me.Btn_Condimentos.Text = "Condimentos"
        Me.Btn_Condimentos.UseVisualStyleBackColor = True
        '
        'Lb_Version
        '
        Me.Lb_Version.AutoSize = True
        Me.Lb_Version.BackColor = System.Drawing.Color.Transparent
        Me.Lb_Version.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Version.Location = New System.Drawing.Point(15, 424)
        Me.Lb_Version.Name = "Lb_Version"
        Me.Lb_Version.Size = New System.Drawing.Size(49, 16)
        Me.Lb_Version.TabIndex = 8
        Me.Lb_Version.Text = "Label1"
        '
        'Fr_Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 454)
        Me.Controls.Add(Me.Lb_Version)
        Me.Controls.Add(Me.Btn_Condimentos)
        Me.Controls.Add(Me.Btn_Configuracion)
        Me.Controls.Add(Me.Btn_Vendedores)
        Me.Controls.Add(Me.Btn_Salir)
        Me.Controls.Add(Me.Btn_Inventarios)
        Me.Controls.Add(Me.Btn_Clientes)
        Me.Controls.Add(Me.Btn_Facturacion)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(900, 454)
        Me.MinimumSize = New System.Drawing.Size(900, 454)
        Me.Name = "Fr_Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturacion Esteban"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_Facturacion As System.Windows.Forms.Button
    Friend WithEvents Btn_Clientes As System.Windows.Forms.Button
    Friend WithEvents Btn_Inventarios As System.Windows.Forms.Button
    Friend WithEvents Btn_Salir As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Btn_Vendedores As System.Windows.Forms.Button
    Friend WithEvents Btn_Configuracion As System.Windows.Forms.Button
    Friend WithEvents Btn_Condimentos As System.Windows.Forms.Button
    Friend WithEvents Lb_Version As Label
End Class
