Public Class Fr_Detalle_Clientes

    Private Sub DetalleClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SEL_CLIENTE_TODOS(Lv_Clientes)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Añadir.Click

        Fr_Clientes.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btn_Actualizar.Click

        Dim num As Integer = 0
        Try
            Fr_Act_Cliente.Show()
            vp_codCliente = Lv_Clientes.FocusedItem.Text
            Me.Close()
        Catch ex As Exception
            Fr_Act_Cliente.Close()
            If ex.ToString.Contains("NullReference") Then
                MsgBox("SELECIONE UN REGISTRO", MsgBoxStyle.Critical, "ADVERTENCIA")
            Else
                MsgBox(ex.ToString)
                Logger.e("Error con excepción", ex, New StackFrame(True))
            End If
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Btn_Eliminar.Click

        Dim cod As String = Nothing
        Try
            If Lv_Clientes.Items.Count > 0 Then
                cod = Lv_Clientes.FocusedItem.Text
                If MsgBox("BORRAR EL CLIENTE: " + Lv_Clientes.FocusedItem.SubItems(1).Text,
                          MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "CUIDADO") = MsgBoxResult.Yes Then
                    DEL_CLI(cod)
                    Lv_Clientes.Items.Clear()
                    SEL_CLIENTE_TODOS(Lv_Clientes)
                End If
            End If

        Catch ex As Exception
            If ex.ToString.Contains("NullReference") Then
                MsgBox("SELECCIONE UN CLIENTE", MsgBoxStyle.Critical, "ADVERTENCIA")
            Else
                ex.ToString()
                Logger.e("Error con excepción", ex, New StackFrame(True))
            End If
        End Try

    End Sub

    Private Sub txtBusquedaId_KeyUp(sender As Object, e As KeyEventArgs) Handles Txt_Busqueda_Id.KeyUp

        If Txt_Busqueda_Id.Text <> "" Then
            Lv_Clientes.Items.Clear()
            SEL_CLIENTE_IDF(Txt_Busqueda_Id.Text, Lv_Clientes)
        Else
            Lv_Clientes.Items.Clear()
            SEL_CLIENTE_TODOS(Lv_Clientes)
        End If
        
    End Sub

    Private Sub txtBusquedaNom_KeyUp(sender As Object, e As KeyEventArgs) Handles Txt_Busqueda_Nombre.KeyUp
        Dim busqueda As String = Nothing
        If Txt_Busqueda_Nombre.Text.Trim <> "" Then
            Lv_Clientes.Items.Clear()
            busqueda = Txt_Busqueda_Nombre.Text.Trim.Replace(" ", "%")
            SEL_CLIENTE_NOMF(busqueda, Lv_Clientes)
        Else
            Lv_Clientes.Items.Clear()
            SEL_CLIENTE_TODOS(Lv_Clientes)
        End If
        
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Btn_Salir.Click

        Fr_Inicio.Show()
        Me.Close()

    End Sub

    Private Sub txtBusquedaId_Enter(sender As Object, e As EventArgs) Handles Txt_Busqueda_Id.Enter

        Txt_Busqueda_Nombre.Clear()

    End Sub

    Private Sub txtBusquedaNom_Enter(sender As Object, e As EventArgs) Handles Txt_Busqueda_Nombre.Enter

        Txt_Busqueda_Id.Clear()

    End Sub

End Class