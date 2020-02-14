Public Class Fr_vista_previa_factura
    Dim id_factura As Integer
    Public Sub New(ByVal p_id_factura As String, ByVal p_cliente As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        If Not (String.IsNullOrEmpty(p_id_factura)) Then
            id_factura = CInt(p_id_factura)
            lb_cliente.Text = p_cliente
            SEL_FDET_MOD(id_factura, DGV_Facturas)
        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

        Me.Close()

    End Sub

    Private Sub Fr_vista_previa_factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_historial_Click(sender As Object, e As EventArgs) Handles btn_historial.Click
        Dim cliente_auto As Integer = Nothing
        SEL_CLIENTE_AUTO(id_factura, cliente_auto)

        Using historial_form As New Fr_Compra_Cliente(cliente_auto)
            historial_form.StartPosition = FormStartPosition.CenterParent
            historial_form.ShowDialog()
        End Using
    End Sub
End Class