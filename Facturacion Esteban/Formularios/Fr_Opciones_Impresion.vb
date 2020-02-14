Public Class Fr_Opciones_Impresion
    Private Sub Btn_Original_Click(sender As Object, e As EventArgs) Handles Btn_Original.Click

        Using pantalla_imprimir As New Fr_motivo_reimpresion
            pantalla_imprimir.StartPosition = FormStartPosition.CenterScreen
            pantalla_imprimir.ShowDialog()
        End Using

        If motivo_impresion = "Impresion cancelada" Then
            MsgBox("La impresion fue cancelada")
        Else
            Fr_Facturas.tipo_impresion = "ORIGINAL"
            Fr_Facturas.imprimirDatos(vp_factura_id, Fr_Facturas.tipo_impresion, motivo_impresion, False)
            motivo_impresion = Nothing
            Me.Close()
        End If

    End Sub

    Private Sub Btn_Copia_Click(sender As Object, e As EventArgs) Handles Btn_Copia.Click

        Using pantalla_imprimir As New Fr_motivo_reimpresion
            pantalla_imprimir.StartPosition = FormStartPosition.CenterScreen
            pantalla_imprimir.ShowDialog()
        End Using

        If motivo_impresion = "Impresion cancelada" Then
            MsgBox("La impresion fue cancelada")
        Else
            Fr_Facturas.tipo_impresion = "COPIA"
            Fr_Facturas.imprimirDatos(vp_factura_id, Fr_Facturas.tipo_impresion, motivo_impresion, True)
            motivo_impresion = Nothing
            Me.Close()
        End If

    End Sub

    Private Sub Btn_Ambas_Click(sender As Object, e As EventArgs) Handles Btn_Ambas.Click

        Using pantalla_imprimir As New Fr_motivo_reimpresion
            pantalla_imprimir.StartPosition = FormStartPosition.CenterScreen
            pantalla_imprimir.ShowDialog()
        End Using

        If motivo_impresion = "Impresion cancelada" Then
            MsgBox("La impresion fue cancelada")
        Else
            Fr_Facturas.tipo_impresion = "AMBAS"
            Fr_Facturas.imprimirDatos(vp_factura_id, Fr_Facturas.tipo_impresion, motivo_impresion, False)
            motivo_impresion = Nothing
            Me.Close()
        End If

    End Sub

    Private Sub Opciones_Impresion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SEL_HIST_PRINT(Lv_Historial)
        SEL_FACT_TO_PRINT(vp_factura_id, Lb_Factura.Text)

    End Sub

    Private Sub Txt_Nombre_KeyUp(sender As Object, e As KeyEventArgs) Handles Txt_Nombre.KeyUp

        If Txt_Nombre.Text = "" Then
            SEL_HIST_PRINT(Lv_Historial)
        Else
            SEL_HIST_PRINT_FILTRO_NOMBRE(Lv_Historial, Txt_Nombre.Text)
        End If

    End Sub

    Private Sub Txt_Num_Factura_KeyUp(sender As Object, e As KeyEventArgs) Handles Txt_Numero_Factura.KeyUp

        If Txt_Numero_Factura.Text = "" Then
            SEL_HIST_PRINT(Lv_Historial)
        Else
            If Txt_Numero_Factura.Text.Length > 2 Then
                Lv_Historial.Items.Clear()
                SEL_HIST_PRINT_FILTRO_ID(Lv_Historial, Txt_Numero_Factura.Text)
            End If

        End If

    End Sub

    Private Sub Txt_Num_Factura_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Numero_Factura.KeyPress

        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If

    End Sub

End Class