Public Class Fr_Agregar_Inventario

    Dim precio As Double
    Dim _PrecioImpuesto1 As String = "0"
    Dim _PrecioImpuesto2 As String = "0"
    Dim _PrecioImpuesto3 As String = "0"
    Dim _PrecioImpuesto4 As String = "0"


    'SELECCIONA EL PRIMER ARTICULO EN EL LISTVIEW
    Private Sub seleccion()

        If LV_Articulos.Items.Count > 0 Then
            LV_Articulos.Select()
            LV_Articulos.TopItem.Selected = True
        End If

    End Sub

    Private Sub AgregarInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        inicio()
        seleccion()

    End Sub

    'COMPROBADOR DE PRECIOS
    Private Sub compPrecio(ByVal pre1 As String, ByRef pre2 As String, ByRef pre3 As String, ByRef pre4 As String)

        Try
            If pre2 = 0 Then
                pre2 = pre1
                pre3 = pre1
                pre4 = pre1
            ElseIf pre3 = 0 Then
                pre3 = pre1
                pre4 = pre1
            ElseIf pre4 = 0 Then
                pre4 = pre1
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        End Try

    End Sub

    'CARGA LAS VARIABLES DE INICIO
    Private Sub inicio()

        Txt_Codigo.Clear()
        Txt_Descripcion.Clear()
        Txt_Precio1.Text = 0
        Txt_Precio2.Text = 0
        Txt_Precio3.Text = 0
        Txt_Precio4.Text = 0
        Txt_Codigo.Focus()
        txt_barcode.Clear()
        LV_Articulos.Items.Clear()
        SEL_ART_NOMF("", LV_Articulos)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Agregar.Click

        Try
            compPrecio(Txt_Precio1.Text, Txt_Precio2.Text, Txt_Precio3.Text, Txt_Precio4.Text)
            If (Txt_Codigo.Text = "") Then
                MsgBox("Ingrese un codigo de producto")
                Txt_Codigo.Focus()
            ElseIf (Txt_Descripcion.Text = "") Then
                MsgBox("Ingrese una descripcion")
                Txt_Descripcion.Focus()
            Else
                INS_ARTICULO(Txt_Codigo.Text, Txt_Descripcion.Text, CDbl(Txt_Precio1.Text),
                             CDbl(Txt_Precio2.Text), CDbl(Txt_Precio3.Text),
                             CDbl(Txt_Precio4.Text), txt_barcode.Text.Trim, CDbl(nud_Impuesto.Value))
                If Fr_Crear_Facturas.Visible Then
                    Fr_Crear_Facturas.Txt_Codigo_Articulo.Text = Txt_Codigo.Text
                    Fr_Crear_Facturas.Txt_Descripcion_Articulo.Text = Txt_Descripcion.Text
                    Fr_Crear_Facturas.Txt_Precio_Articulo.Text = Txt_Precio1.Text
                    SEL_ARTICULO_COD(Txt_Codigo.Text, Fr_Crear_Facturas.Lv_Busqueda_Articulos, vp_art_auto)
                    Fr_Crear_Facturas.nudCantidad.Focus()
                    Me.Close()
                ElseIf Fr_Crea_Cotizacion.Visible Then
                    Fr_Crea_Cotizacion.Txt_Codigo_Articulo.Text = Txt_Codigo.Text
                    Fr_Crea_Cotizacion.Txt_Descripcion_Articulo.Text = Txt_Descripcion.Text
                    Fr_Crea_Cotizacion.Txt_Precio_Articulo.Text = Txt_Precio1.Text
                    SEL_ARTICULO_COD(Txt_Codigo.Text, Fr_Crea_Cotizacion.Lv_Busqueda_Articulos, vp_art_auto)
                    Fr_Crea_Cotizacion.Txt_Cantidad_Articulo.Focus()
                    Me.Close()
                End If
                inicio()
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        End Try

    End Sub

    Private Sub txtCod_KeyUp(sender As Object, e As KeyEventArgs) Handles Txt_Codigo.KeyUp

        SEL_ARTICULO(Txt_Codigo.Text, Txt_Descripcion.Text)

    End Sub

    Private Sub txtCod_Leave(sender As Object, e As EventArgs) Handles Txt_Codigo.Leave

        If (Txt_Descripcion.Text <> "") Then
            MsgBox("El codigo ya esta en uso")
            Txt_Codigo.Text = ""
            Txt_Codigo.Focus()
        End If

    End Sub

    Private Sub txtPrecio1_Leave(sender As Object, e As EventArgs) Handles Txt_Precio1.Leave

        Try
            If (Txt_Precio1.Text = "") Then
                Txt_Precio1.Text = "0"
            End If
            precio = CDbl(Txt_Precio1.Text)
            Txt_Precio1.Text = precio.ToString("N0")
            CalcularImpuesto()

        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btn_Salir.Click

        Me.Close()

    End Sub

    Private Sub txtPrecio2_Leave(sender As Object, e As EventArgs) Handles Txt_Precio2.Leave

        Try
            If (Txt_Precio2.Text = "") Then
                Txt_Precio2.Text = "0"
            End If
            precio = CDbl(Txt_Precio2.Text)
            Txt_Precio2.Text = precio.ToString("N0")
            CalcularImpuesto()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        End Try

    End Sub

    Private Sub txtPrecio3_Leave(sender As Object, e As EventArgs) Handles Txt_Precio3.Leave

        Try
            If (Txt_Precio3.Text = "") Then
                Txt_Precio3.Text = "0"
            End If
            precio = CDbl(Txt_Precio3.Text)
            Txt_Precio3.Text = precio.ToString("N0")
            CalcularImpuesto()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        End Try

    End Sub

    Private Sub txtPrecio4_Leave(sender As Object, e As EventArgs) Handles Txt_Precio4.Leave

        Try
            If (Txt_Precio4.Text = "") Then
                Txt_Precio4.Text = "0"
            End If
            precio = CDbl(Txt_Precio4.Text)
                Txt_Precio4.Text = precio.ToString("N0")
                CalcularImpuesto()
            Btn_Agregar.Focus()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        End Try

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

    Private Sub txtDescrip_KeyUp(sender As Object, e As KeyEventArgs) Handles Txt_Descripcion.KeyUp

        LV_Articulos.Items.Clear()
        SEL_ART_NOMF(Txt_Descripcion.Text, LV_Articulos)

    End Sub

    Private Sub txt_barcode_Leave(sender As Object, e As EventArgs) Handles txt_barcode.Leave

        Dim disponible As Boolean = True

        If txt_barcode.Text.Trim <> "" Then
            SEL_BARCODE(txt_barcode.Text.Trim, disponible)
        End If

        If Not disponible Then
            txt_barcode.Clear()
            MsgBox("El barcode ya esta en uso", MsgBoxStyle.Information)
            txt_barcode.Select()
        End If

    End Sub

    Private Sub nud_Impuesto_ValueChanged(sender As Object, e As EventArgs) Handles nud_Impuesto.ValueChanged
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

    Private Sub Txt_Precio1_MouseHover(sender As Object, e As EventArgs) Handles Txt_Precio1.MouseHover
        'AyudaMensaje(ToolTip1, Txt_Precio1, _PrecioImpuesto1)
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