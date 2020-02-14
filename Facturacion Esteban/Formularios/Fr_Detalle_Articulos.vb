Public Class Fr_Detalle_Articulos

    Private Sub DetalleArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Lv_Detalles.Items.Clear()
        SEL_ART_NOMF("", Lv_Detalles)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Añadir.Click

        Fr_Agregar_Inventario.Show()

    End Sub

    Private Sub txtBusquedaId_KeyUp(sender As Object, e As KeyEventArgs) Handles Txt_Busqueda_Id.KeyUp

        Lv_Detalles.Items.Clear()
        Dim busqueda As String = Txt_Busqueda_Id.Text.Trim.Replace(" ", "%")
        SEL_ART_IDF(busqueda, Lv_Detalles)

    End Sub

    Private Sub txtBusquedaNom_KeyUp(sender As Object, e As KeyEventArgs) Handles Txt_Busqueda_Nombre.KeyUp

        Lv_Detalles.Items.Clear()
        Dim busqueda As String = Txt_Busqueda_Nombre.Text.Trim.Replace(" ", "%")
        SEL_ART_NOMF(busqueda, Lv_Detalles)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btn_Actualizar.Click

        Try
            Fr_Act_Inventario.Show()
            Fr_Act_Inventario.Txt_Codigo.Text = Lv_Detalles.FocusedItem.Text

            SEL_ARTICULO_ACT(Lv_Detalles.FocusedItem.Text, Fr_Act_Inventario.Txt_Descripcion.Text, Fr_Act_Inventario.Txt_Precio1.Text,
                             Fr_Act_Inventario.Txt_Precio2.Text, Fr_Act_Inventario.Txt_Precio3.Text,
                             Fr_Act_Inventario.Txt_Precio4.Text, Fr_Act_Inventario.txt_barcode.Text, Fr_Act_Inventario.nud_Impuesto.Value)
            Me.Close()
        Catch ex As Exception
            Fr_Act_Inventario.Close()
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
            If Lv_Detalles.Items.Count > 0 Then
                cod = Lv_Detalles.FocusedItem.Text
                If MsgBox("BORRAR EL ARTICULO: " + Lv_Detalles.FocusedItem.SubItems(1).Text,
                          MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "CUIDADO") = MsgBoxResult.Yes Then
                    DEL_ART(cod)
                    Lv_Detalles.Items.Clear()
                    SEL_ART_NOMF("", Lv_Detalles)
                End If
            End If

        Catch ex As Exception
            If ex.ToString.Contains("NullReference") Then
                MsgBox("SELECCIONE UN ARTICULO", MsgBoxStyle.Critical, "ADVERTENCIA")
            Else
                ex.ToString()
                Logger.e("Error con excepción", ex, New StackFrame(True))
            End If

        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Btn_Salir.Click

        Fr_Inicio.Show()
        Me.Close()

    End Sub

    Private Sub txt_barcode_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_barcode.KeyUp



    End Sub

    Private Sub txt_barcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_barcode.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then
            Dim busqueda As String = txt_barcode.Text.Trim.Replace(" ", "%")
            If busqueda <> "" Then
                Lv_Detalles.Items.Clear()
                SEL_ART_BARCODE(busqueda, Lv_Detalles)
                If Lv_Detalles.Items.Count = 0 Then
                    txt_barcode.Text = "CODIGO NO EXISTE"
                    Application.DoEvents()
                    Threading.Thread.Sleep(1000)
                    txt_barcode.Text = ""
                Else
                    txt_barcode.Clear()
                End If
            End If
        End If
    End Sub
End Class