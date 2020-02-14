<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrTiquete
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
        Me.txtTiquete = New System.Windows.Forms.TextBox()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtTiquete
        '
        Me.txtTiquete.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTiquete.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTiquete.Location = New System.Drawing.Point(12, 21)
        Me.txtTiquete.Multiline = True
        Me.txtTiquete.Name = "txtTiquete"
        Me.txtTiquete.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtTiquete.Size = New System.Drawing.Size(754, 460)
        Me.txtTiquete.TabIndex = 0
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Location = New System.Drawing.Point(290, 487)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(195, 38)
        Me.btnImprimir.TabIndex = 1
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'FrTiquete
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(783, 537)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.txtTiquete)
        Me.Name = "FrTiquete"
        Me.Text = "Impresion Tiquete"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTiquete As TextBox
    Friend WithEvents btnImprimir As Button
End Class
