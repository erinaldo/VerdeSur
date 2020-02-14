Public Class Fr_Vendedor_Selecion

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Salir.Click

        Me.Close()

    End Sub

    Private Sub VendedorSelecion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SEL_VENDEDORES_TODOS(Lv_Vendedores)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btn_Seleccionar.Click

    End Sub

End Class