Public Class Fr_Act_Inventario

    Dim barcode_antiguo As String = ""
    Dim _PrecioImpuesto1 As String = "0"
    Dim _PrecioImpuesto2 As String = "0"
    Dim _PrecioImpuesto3 As String = "0"
    Dim _PrecioImpuesto4 As String = "0"

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btn_Salir.Click

        Fr_Detalle_Articulos.Show()
        Me.Close()

    End Sub

    Private Sub txtPrecio1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Precio1.KeyPress

        NumerosyDecimal(Txt_Precio1, e)

    End Sub

    Private Sub txtPrecio2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Precio2.KeyPress

        NumerosyDecimal(Txt_Precio2, e)

    End Sub

    Private Sub txtPrecio3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Precio3.KeyPress

        NumerosyDecimal(Txt_Precio3, e)

    End Sub

    Private Sub txtPrecio4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Precio4.KeyPress

        NumerosyDecimal(Txt_Precio4, e)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Actualizar.Click

        Try

            If Txt_Descripcion.Text <> "" And Txt_Precio1.Text <> "" And Txt_Precio2.Text <> "" And Txt_Precio3.Text <> "" And Txt_Precio4.Text <> "" Then
                UPD_ART(Txt_Codigo.Text, Txt_Descripcion.Text, CDbl(Txt_Precio1.Text), CDbl(Txt_Precio2.Text), CDbl(Txt_Precio3.Text),
                            CDbl(Txt_Precio4.Text), Txt_Tipo.Text, False, 0, txt_barcode.Text.Trim)
                MsgBox("ACTUALIZADO CORRECTAMENTE", MsgBoxStyle.Information, "ACTUALIZACION")
                Fr_Detalle_Articulos.Show()
                Me.Close()
            End If

        Catch ex As Exception
            Logger.e("Error con excepción", ex, New StackFrame(True))
            ex.ToString()
        End Try

    End Sub

    Private Sub txt_barcode_TextChanged(sender As Object, e As EventArgs) Handles txt_barcode.TextChanged



    End Sub

    Private Sub txt_barcode_Leave(sender As Object, e As EventArgs) Handles txt_barcode.Leave
        Dim disponible As Boolean = True

        If (txt_barcode.Text.Trim <> "") And (barcode_antiguo <> txt_barcode.Text) Then
            SEL_BARCODE(txt_barcode.Text.Trim, disponible)
        End If

        If Not disponible Then
            txt_barcode.Clear()
            MsgBox("El barcode ya esta en uso", MsgBoxStyle.Information)
            txt_barcode.Text = barcode_antiguo
            txt_barcode.Select()
            txt_barcode.SelectionStart = 0
            txt_barcode.SelectionLength = txt_barcode.Text.Length
        ElseIf txt_barcode.Text.Trim = "" Then
            txt_barcode.Text = barcode_antiguo
        ElseIf txt_barcode.Text = "NULO" Then
            txt_barcode.Text = ""
        End If

    End Sub

    Private Sub Fr_Act_Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Txt_Precio4_Leave(sender As Object, e As EventArgs) Handles Txt_Precio4.Leave
        Btn_Actualizar.Select()
    End Sub

    Private Sub Fr_Act_Inventario_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

        barcode_antiguo = txt_barcode.Text
        CalcularImpuesto()

    End Sub

    Private Sub CalcularImpuesto()

        Dim _Impuesto As Double = 0
        Dim _Precio As Double = 0
        Dim _PrecioFinal As Double = 0
        Try
            _Impuesto = nud_Impuesto.Value / 100
            _Precio = CDbl(Txt_Precio1.Text)
            _PrecioFinal = (_Impuesto * _Precio) + _Precio
            _PrecioImpuesto1 = convertir_formato_miles_decimales(_PrecioFinal)

            _Precio = CDbl(Txt_Precio2.Text)
            _PrecioFinal = (_Impuesto * _Precio) + _Precio
            _PrecioImpuesto2 = convertir_formato_miles_decimales(_PrecioFinal)


            _Precio = CDbl(Txt_Precio3.Text)
            _PrecioFinal = (_Impuesto * _Precio) + _Precio
            _PrecioImpuesto3 = convertir_formato_miles_decimales(_PrecioFinal)


            _Precio = CDbl(Txt_Precio4.Text)
            _PrecioFinal = (_Impuesto * _Precio) + _Precio
            _PrecioImpuesto4 = convertir_formato_miles_decimales(_PrecioFinal)


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub AyudaMensaje(ByVal globo As ToolTip, ByVal textbox As TextBox, ByVal mensaje As String)
        globo.RemoveAll()
        globo.SetToolTip(textbox, mensaje)
        globo.InitialDelay = 1
        globo.IsBalloon = False

    End Sub

    Private Sub Txt_Precio1_MouseEnter(sender As Object, e As EventArgs) Handles Txt_Precio1.MouseEnter
        AyudaMensaje(ToolTip1, Txt_Precio1, _PrecioImpuesto1)
    End Sub

    Private Sub Txt_Precio2_MouseEnter(sender As Object, e As EventArgs) Handles Txt_Precio2.MouseEnter
        AyudaMensaje(ToolTip1, Txt_Precio2, _PrecioImpuesto2)
    End Sub

    Private Sub Txt_Precio3_MouseEnter(sender As Object, e As EventArgs) Handles Txt_Precio3.MouseEnter
        AyudaMensaje(ToolTip1, Txt_Precio3, _PrecioImpuesto3)
    End Sub

    Private Sub Txt_Precio4_MouseEnter(sender As Object, e As EventArgs) Handles Txt_Precio4.MouseEnter
        AyudaMensaje(ToolTip1, Txt_Precio4, _PrecioImpuesto4)
    End Sub
End Class