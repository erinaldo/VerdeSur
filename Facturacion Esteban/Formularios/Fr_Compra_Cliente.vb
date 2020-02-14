Public Class Fr_Compra_Cliente

    Public cliente_id As Integer

    Public Sub New(ByVal p_cliente_id As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        cliente_id = p_cliente_id

    End Sub
    Private Sub CompraCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SEL_HIST_CLI(cliente_id, dgv_historial)

    End Sub

    Private Sub TextBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles Txt_Busqueda_Codigo.KeyUp

        SEL_HIST_CLI_IDF(cliente_id, Txt_Busqueda_Codigo.Text, dgv_historial)

    End Sub

    Private Sub TextBox2_KeyUp(sender As Object, e As KeyEventArgs) Handles Txt_Busqueda_Producto.KeyUp

        Dim busqueda_producto As String = Txt_Busqueda_Producto.Text.Trim.Replace(" ", "%")
        SEL_HIST_CLI_NOMF(cliente_id, busqueda_producto, dgv_historial)

    End Sub

    'EL EVENTO SHOW CARGA VARIABLES DESPUES DE CARGAR EL FORMULARIO
    ' EN CAMBIO EL LOAD CARGA VARIABLES ANTES DE INICIAR EL FORMULARIO
    Private Sub Fr_Compra_Cliente_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

        Txt_Busqueda_Producto.Focus()

    End Sub

    Private Sub Fr_Compra_Cliente_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize

        dgv_historial.Columns(3).Width = dgv_historial.Width - 665

    End Sub

End Class