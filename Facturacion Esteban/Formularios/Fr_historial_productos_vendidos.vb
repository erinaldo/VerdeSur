Public Class fr_historial_productos_vendidos

    Private Sub inicio()

        Dtp_Fecha_inicio.CustomFormat = "dd/MM/yyyy"
        Dtp_Fecha_fin.CustomFormat = "dd/MM/yyyy"
        MepDataGridView1.Columns(1).DefaultCellStyle.Format = "dd/MM/YYYY"
        Dtp_Fecha_fin.Value = Now
        Dtp_Fecha_inicio.Value = Now
        Dim fechaInicio As DateTime = Dtp_Fecha_inicio.Value.ToString("dd/MM/yyyy") + " " + Dtp_Fecha_inicio.Value.ToString("00:00:00")
        Dim fechaFin As DateTime = Dtp_Fecha_fin.Value.ToString("dd/MM/yyyy") + " " + Dtp_Fecha_fin.Value.ToString("23:59:59")
        SEL_HISTORIAL_PRODUCTO_VENDIDO_SIN_FILTRO(MepDataGridView1, fechaInicio, fechaFin, txt_cantidad.Text, lb_estado.Text)
        ToolTip1.SetToolTip(txt_clientes, "Dejar vacio para buscar todos los clientes")
        ToolTip1.SetToolTip(txt_producto, "Dejar vacio para buscar todos los productos")
    End Sub

    Private Sub Fr_historial_productos_vendidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txt_producto_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_producto.KeyUp

    End Sub

    Private Sub btn_busqueda_Click(sender As Object, e As EventArgs) Handles btn_busqueda.Click

        Dim fechaInicio As DateTime = Dtp_Fecha_inicio.Value.ToString("dd/MM/yyyy") + " " + Dtp_Fecha_inicio.Value.ToString("00:00:00")
        Dim fechaFin As DateTime = Dtp_Fecha_fin.Value.ToString("dd/MM/yyyy") + " " + Dtp_Fecha_fin.Value.ToString("23:59:59")
        Dim busqueda_producto As String = txt_producto.Text.Trim.Replace(" ", "%")
        Dim busqueda_cliente As String = txt_clientes.Text.Trim.Replace(" ", "%")
        If fechaInicio.AddDays(30) < fechaFin Then
            If MsgBox("Esta Consulta puede tarder un poco, es mayor a 30 días.... Desea continuar", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                SEL_HISTORIAL_PRODUCTO_VENDIDO(busqueda_producto, MepDataGridView1, fechaInicio, fechaFin, txt_cantidad, lb_estado, busqueda_cliente)
            End If
        Else
            SEL_HISTORIAL_PRODUCTO_VENDIDO(busqueda_producto, MepDataGridView1, fechaInicio, fechaFin, txt_cantidad, lb_estado, busqueda_cliente)
        End If

    End Sub

    Private Sub Dtp_Fecha_fin_ValueChanged(sender As Object, e As EventArgs) Handles Dtp_Fecha_fin.ValueChanged
        If Dtp_Fecha_fin.Value > Now Then
            Dtp_Fecha_fin.Value = Now
        ElseIf Dtp_Fecha_fin.Value < Dtp_Fecha_inicio.Value Then
            Dtp_Fecha_fin.Value = Now
        End If
    End Sub

    Private Sub Dtp_Fecha_inicio_ValueChanged(sender As Object, e As EventArgs) Handles Dtp_Fecha_inicio.ValueChanged
        If Dtp_Fecha_inicio.Value > Now Then
            Dtp_Fecha_inicio.Value = Now
        ElseIf Dtp_Fecha_inicio.Value > Dtp_Fecha_fin.Value Then
            Dtp_Fecha_inicio.Value = Dtp_Fecha_fin.Value
        End If
    End Sub

    Private Sub txt_cantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cantidad.KeyPress
        e.Handled = True
    End Sub

    Private Sub fr_historial_productos_vendidos_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        inicio()
    End Sub
End Class