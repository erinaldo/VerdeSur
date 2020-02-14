Public Class Fr_Reporte_Clientes


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btn_Aceptar.Click

        RP_CLIENTES.inicio = Dt_Inicio.Value.ToString("dd/MM/yyyy") + " " + Dt_Inicio.Value.ToString("00:00:00")
        RP_CLIENTES.fin = Dt_Fin.Value.ToString("dd/MM/yyyy") + " " + Dt_Fin.Value.ToString("23:59:59")
        RP_CLIENTES.id = Txt_Vendedor.Text
        RP_CLIENTES.Show()
        Me.Close()

    End Sub

    Private Sub ReporteClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class