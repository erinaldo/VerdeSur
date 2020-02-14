Public Class Fr_Act_Cliente

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btn_Salir.Click

        Fr_Detalle_Clientes.Show()
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Actualizar.Click

        Try
            If Txt_Nombre.Text <> "" Then
                If Txt_Advertencia.Text = "ADVERTENCIA" Then
                    Txt_Advertencia.Text = ""
                End If
                Txt_Nombre.Text = Txt_Nombre.Text.Replace("'", "`")
                UPD_CLI(Txt_Cod_Nombre.Text, Txt_Nombre.Text, Txt_Telefono.Text, Txt_Direccion.Text, Txt_Advertencia.Text,
                        Chb_Tipo_Impresora.Checked, CInt(Lv_Vendedor.Items.Item(Cb_Vendedor.SelectedIndex).SubItems(0).Text),
                        txt_correo.Text.Trim)
            End If
                MsgBox("ACTUALIZADO CORRECTAMENTE", MsgBoxStyle.Information, "ACTUALIZACION")
            Fr_Detalle_Clientes.Show()
            Me.Close()
        Catch ex As Exception
            Logger.e("Error con excepción", ex, New StackFrame(True))
            ex.ToString()
        End Try

    End Sub

    Private Sub txt_advertencia_Enter(sender As Object, e As EventArgs) Handles Txt_Advertencia.Enter

        If Txt_Advertencia.Text = "ADVERTENCIA" Then
            Txt_Advertencia.Clear()
        End If

    End Sub

    Private Sub txt_advertencia_Leave(sender As Object, e As EventArgs) Handles Txt_Advertencia.Leave

        If Txt_Advertencia.Text = "" Then
            Txt_Advertencia.Text = "ADVERTENCIA"
        End If

    End Sub

    Private Sub Act_Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SEL_VENDEDORES(Cb_Vendedor, Lv_Vendedor)
        Cb_Vendedor.SelectedItem = "CAJA"

    End Sub

    Private Sub Fr_Act_Cliente_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

        Txt_Cod_Nombre.Text = vp_codCliente
        SEL_CLIENTE_ACT(vp_codCliente, Txt_Nombre.Text,
                       Txt_Direccion.Text, Txt_Telefono.Text,
                       Txt_Advertencia.Text, Chb_Tipo_Impresora.Checked,
                       Cb_Vendedor, Lv_Vendedor, txt_cedula, txt_correo)
        If Txt_Advertencia.Text = "" Then
            Txt_Advertencia.Text = "ADVERTENCIA"
        End If

    End Sub

    Private Sub txt_cedula_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cedula.KeyPress
        e.Handled = True
    End Sub
End Class