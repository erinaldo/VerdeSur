Public Class Fr_Busca_Cliente

    'VARIABLE QUE GUARDA EL NUMERO DE TELEFONO
    'PODRIA BORRAR ESTA VARIABLE?
    'Public tel As String

    Dim _CedulaCliente As String

    'SELECCIONA EL PRIMER CLIENTE DEL LISTVIEW CLIENTES
    Private Sub compuevaLista()
        If LV_Clientes.Items.Count > 0 Then
            LV_Clientes.Select()
            LV_Clientes.TopItem.Selected = True
        End If
    End Sub


    Private Sub BuscaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SEL_CLIENTE_TODOS(LV_Clientes)
        compuevaLista()

    End Sub

    Private Sub txtBusquedaId_KeyUp(sender As Object, e As KeyEventArgs) Handles Txt_Busqueda_Id.KeyUp

        LV_Clientes.Items.Clear()
        SEL_CLIENTE_IDF(Txt_Busqueda_Id.Text, LV_Clientes)

    End Sub

    Private Sub txtBusquedaNom_KeyUp(sender As Object, e As KeyEventArgs) Handles Txt_Busqueda_Nombre.KeyUp

        LV_Clientes.Items.Clear()
        SEL_CLIENTE_NOMF(Txt_Busqueda_Nombre.Text, LV_Clientes)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Seleccionar_Cliente.Click

        Try
            If Fr_Crear_Facturas.Visible = True Then
                Fr_Crear_Facturas.Txt_Codigo_Cliente.Text = LV_Clientes.FocusedItem.Text
                SEL_CLIENTE_FACT(LV_Clientes.FocusedItem.Text, vp_cli_id, Fr_Crear_Facturas.DGV_Comentarios, vp_advertencia, vp_telefono, vp_ticket_matriz, vp_vendedor_auto, _CedulaCliente)
                Fr_Crear_Facturas.Txt_Codigo_Cliente.Focus()
                Me.Close()
            End If
        Catch ex As Exception
            If ex.ToString.Contains("NullReference") Then
                MsgBox("SELECCIONE UN CLIENTE", MsgBoxStyle.Information, "CUIDADO")
            Else
                MsgBox(ex.ToString)
                Logger.e("Error con excepción", ex, New StackFrame(True))
            End If
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btn_Salir.Click

        Me.Close()

    End Sub

End Class