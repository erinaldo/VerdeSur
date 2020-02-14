Public Class Fr_Reporte_Vendedores


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btn_Aceptar.Click

        RP_Vendedores.inicio = Dt_Inicio.Value.ToString("dd/MM/yyyy") + " " + Dt_Inicio.Value.ToString("00:00:00")
        RP_Vendedores.fin = Dt_Fin.Value.ToString("dd/MM/yyyy") + " " + Dt_Fin.Value.ToString("23:59:59")
        RP_Vendedores.id = Txt_Vendedor.Text
        RP_Vendedores.Show()
        Me.Close()

    End Sub

    Private Sub ReporteVendedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Btn_Salir.Click

        Me.Close()

    End Sub

End Class