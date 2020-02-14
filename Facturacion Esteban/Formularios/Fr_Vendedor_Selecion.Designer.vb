<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fr_Vendedor_Selecion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fr_Vendedor_Selecion))
        Me.Lv_Vendedores = New System.Windows.Forms.ListView()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Btn_Seleccionar = New System.Windows.Forms.Button()
        Me.Btn_Salir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lv_Vendedores
        '
        Me.Lv_Vendedores.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7})
        Me.Lv_Vendedores.GridLines = True
        Me.Lv_Vendedores.Location = New System.Drawing.Point(12, 12)
        Me.Lv_Vendedores.Name = "Lv_Vendedores"
        Me.Lv_Vendedores.Size = New System.Drawing.Size(478, 204)
        Me.Lv_Vendedores.TabIndex = 12
        Me.Lv_Vendedores.UseCompatibleStateImageBehavior = False
        Me.Lv_Vendedores.View = System.Windows.Forms.View.Details
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
        'Btn_Seleccionar
        '
        Me.Btn_Seleccionar.Location = New System.Drawing.Point(147, 222)
        Me.Btn_Seleccionar.Name = "Btn_Seleccionar"
        Me.Btn_Seleccionar.Size = New System.Drawing.Size(107, 32)
        Me.Btn_Seleccionar.TabIndex = 14
        Me.Btn_Seleccionar.Text = "Seleccionar"
        Me.Btn_Seleccionar.UseVisualStyleBackColor = True
        '
        'Btn_Salir
        '
        Me.Btn_Salir.Location = New System.Drawing.Point(269, 222)
        Me.Btn_Salir.Name = "Btn_Salir"
        Me.Btn_Salir.Size = New System.Drawing.Size(107, 32)
        Me.Btn_Salir.TabIndex = 13
        Me.Btn_Salir.Text = "Salir"
        Me.Btn_Salir.UseVisualStyleBackColor = True
        '
        'Fr_Vendedor_Selecion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 261)
        Me.ControlBox = False
        Me.Controls.Add(Me.Btn_Seleccionar)
        Me.Controls.Add(Me.Btn_Salir)
        Me.Controls.Add(Me.Lv_Vendedores)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(539, 300)
        Me.Name = "Fr_Vendedor_Selecion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vendedor"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Lv_Vendedores As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Btn_Seleccionar As System.Windows.Forms.Button
    Friend WithEvents Btn_Salir As System.Windows.Forms.Button
End Class
