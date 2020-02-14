Public Class Fr_Inicio

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Btn_Salir.Click

        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Facturacion.Click

        Fr_Facturas.Show()
        Me.Hide()

    End Sub

    Private Sub Inicio_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyValue = Keys.F5 Then
            Try
                Fr_Crear_Facturas.Show()
                Fr_Crear_Facturas.Txt_Codigo_Cliente.Focus()
                Me.Hide()
            Catch ex As Exception
                MsgBox(ex.ToString)
                Logger.e("Error con excepción", ex, New StackFrame(True))
            End Try
        End If

    End Sub


    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conectarse()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btn_Clientes.Click

        Fr_Detalle_Clientes.Show()
        Me.Hide()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Btn_Vendedores.Click

        Fr_Vendedores.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Btn_Inventarios.Click

        Fr_Detalle_Articulos.Show()
        Me.Hide()

    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Btn_Configuracion.Click

        Fr_Config.Show()
        Me.Hide()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Btn_Condimentos.Click

        Fr_Condimientos.Show()
        Me.Hide()

    End Sub

    Private Sub Fr_Inicio_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

        Lb_Version.Parent = PictureBox1
        Lb_Version.Text = "Version: " & My.Application.Info.Version.ToString

    End Sub
End Class
