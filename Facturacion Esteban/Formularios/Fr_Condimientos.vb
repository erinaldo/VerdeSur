Public Class Fr_Condimientos

    'LIMPIA LOS CAMPOS DEL FORMULARIO
    Private Sub limpiar()

        Txt_Codigo.Clear()
        Txt_Condimento.Text = "ESCRIBA EL CONDIMENTO"
        Txt_Precio.Text = 0
        Txt_Sugerido.Text = 0
        Txt_Mayor.Text = 0
        Chb_Impuesto.Checked = False
        Num_Mayor.Value = 30
        Num_Sugerido.Value = 80

    End Sub

    'CALCULO LOS PRECIOS SUGERIDOS
    Private Sub calcular_precios(ByVal precio As Double)

        Dim impuestos As Double
        Dim resultado As Double

        If Chb_Impuesto.Checked Then
            impuestos = ((precio * 13 / 100) + precio)
            resultado = (impuestos * Num_Sugerido.Value / 100) + impuestos
            Txt_Sugerido.Text = convertir_formato_miles_decimales(resultado)
            resultado = (impuestos * Num_Mayor.Value / 100) + impuestos
            Txt_Mayor.Text = convertir_formato_miles_decimales(resultado)
        Else
            resultado = (precio * Num_Sugerido.Value / 100) + precio
            Txt_Sugerido.Text = convertir_formato_miles_decimales(resultado)
            resultado = (precio * Num_Mayor.Value / 100) + precio
            Txt_Mayor.Text = convertir_formato_miles_decimales(resultado)
        End If

    End Sub

    'CAMBIA LA APARIENCIA DEL LISTVIEW SIN MOSTRAR EL PRECIO COSTO
    Private Sub TABLA_PRECIOS()

        Lv_Condimentos.Clear()
        Lv_Condimentos.Width = 520
        Lv_Condimentos.View = View.Details
        Lv_Condimentos.Columns.Add("CODIGO", 70, HorizontalAlignment.Left)
        Lv_Condimentos.Columns.Add("CONDIMENTO", 180, HorizontalAlignment.Left)
        Lv_Condimentos.Columns.Add("SUGERIDO", 120, HorizontalAlignment.Right)
        Lv_Condimentos.Columns.Add("POR MAYOR", 120, HorizontalAlignment.Right)
        'SEL_COND_CONS(Lv_Condimentos)
        lbmayor.Visible = False
        Lbprecio.Visible = False
        Txt_Precio.Visible = False
        Txt_Sugerido.Visible = False
        Txt_Mayor.Visible = False
        Chb_Impuesto.Visible = False
        lbsugerido.Visible = False
        Num_Mayor.Visible = False
        Num_Sugerido.Visible = False
        lbcodigo.Visible = False
        Txt_Codigo.Visible = False
        Txt_Nombre_Actualizar.Visible = False
        Chb_Nombre.Visible = False
        limpiar()

    End Sub

    'CAMBIA LA APARIENCIA DEL LISTVIEW MOSTRANDO EL PRECIO COSTO
    Private Sub TABLA_COSTOS()

        Lv_Condimentos.Clear()
        Lv_Condimentos.Width = 620
        Lv_Condimentos.View = View.Details
        Lv_Condimentos.Columns.Add("CODIGO", 70, HorizontalAlignment.Left)
        Lv_Condimentos.Columns.Add("CONDIMENTO", 170, HorizontalAlignment.Left)
        Lv_Condimentos.Columns.Add("COMPRA", 117, HorizontalAlignment.Right)
        Lv_Condimentos.Columns.Add("SUGERIDO", 117, HorizontalAlignment.Right)
        Lv_Condimentos.Columns.Add("POR MAYOR", 117, HorizontalAlignment.Right)
        SEL_COND_COSTOS(Lv_Condimentos)
        lbmayor.Visible = True
        Lbprecio.Visible = True
        Txt_Precio.Visible = True
        Txt_Sugerido.Visible = True
        Txt_Mayor.Visible = True
        Chb_Impuesto.Visible = True
        lbsugerido.Visible = True
        Num_Mayor.Visible = True
        Num_Sugerido.Visible = True
        Txt_Codigo.Visible = True
        lbcodigo.Visible = True
        Txt_Nombre_Actualizar.Visible = True
        Chb_Nombre.Visible = True
        Txt_Nombre_Actualizar.BackColor = Color.Cyan
        Txt_Nombre_Actualizar.Text = "BUSCADOR"
        limpiar()
        Chb_Impuesto.Checked = False
        Chb_Nombre.Checked = False

    End Sub

    'CARGA LAS VARIABLES DE INICIO
    Private Sub inicio()

        Btn_Actualizar.Visible = False
        Btn_Agregar.Visible = False
        Btn_Agregar.Location = New Point(175, 300)
        TABLA_PRECIOS()

    End Sub
    Private Sub CONDIMENTOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        inicio()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Actualizar.Click

        If Txt_Condimento.Text = "" Then
            MsgBox("INGRESE UN NOMBRE", MsgBoxStyle.Information, "ADVERTENCIA")
            Txt_Condimento.Focus()
        ElseIf Txt_Precio.Text = 0 Then
            MsgBox("EL PRECIO TIENE QUE SER MAYOR A CERO", MsgBoxStyle.Information, "ADVERTENCIA")
            Txt_Precio.Focus()
        Else
            UPD_ART(Txt_Codigo.Text, Txt_Condimento.Text, CDbl(Txt_Sugerido.Text),
               CDbl(Txt_Sugerido.Text), CDbl(Txt_Sugerido.Text), CDbl(Txt_Mayor.Text),
                            "CONDIMENTO", Chb_Impuesto.Checked, CDbl(Txt_Precio.Text), "")
            MsgBox("PRODUCTO ACTUALIZADO CORRECTAMENTE")
            TABLA_COSTOS()
            Txt_Condimento.Clear()
            Txt_Condimento.Focus()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btn_Agregar.Click

        If Txt_Codigo.Text = "" Then
            MsgBox("INGRESE UN CODIGO", MsgBoxStyle.Information, "ADVERTENCIA")
            Txt_Codigo.Focus()
        ElseIf Txt_Condimento.Text = "" Then
            MsgBox("INGRESE UN NOMBRE", MsgBoxStyle.Information, "ADVERTENCIA")
            Txt_Condimento.Focus()
        ElseIf Txt_Precio.Text = 0 Then
            MsgBox("EL PRECIO TIENE QUE SER MAYOR A CERO", MsgBoxStyle.Information, "ADVERTENCIA")
            Txt_Precio.Focus()
        Else
            INS_CONDIMENTO(Txt_Codigo.Text, Txt_Condimento.Text, CDbl(Txt_Sugerido.Text), CDbl(Txt_Mayor.Text),
                           Chb_Impuesto.Checked, "CONDIMENTO", CDbl(Txt_Precio.Text))
            TABLA_COSTOS()
            Txt_Condimento.Clear()
            Txt_Nombre_Actualizar.Visible = False
            Chb_Nombre.Visible = False
            Txt_Codigo.Focus()
        End If

    End Sub

    Private Sub txtSugerido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Sugerido.KeyPress

        NumerosyDecimal(Txt_Sugerido, e)

    End Sub

    Private Sub TxtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Precio.KeyPress

        NumerosyDecimal(Txt_Precio, e)

    End Sub

    Private Sub txtMayor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Mayor.KeyPress

        NumerosyDecimal(Txt_Mayor, e)

    End Sub

    Private Sub TxtPrecio_Leave(sender As Object, e As EventArgs) Handles Txt_Precio.Leave

        If Txt_Precio.Text = "" Then
            Txt_Precio.Text = 0
        End If
        calcular_precios(Txt_Precio.Text)

    End Sub

    Private Sub NumSugerido_ValueChanged(sender As Object, e As EventArgs) Handles Num_Sugerido.ValueChanged

        If Txt_Precio.Text <> "" Then
            calcular_precios(CDbl(Txt_Precio.Text))
        End If

    End Sub

    Private Sub NumMayor_ValueChanged(sender As Object, e As EventArgs) Handles Num_Mayor.ValueChanged

        If Txt_Precio.Text <> "" Then
            calcular_precios(CDbl(Txt_Precio.Text))
        End If

    End Sub

    Private Sub txtSugerido_Leave(sender As Object, e As EventArgs) Handles Txt_Sugerido.Leave

        If Txt_Sugerido.Text = "" And Txt_Precio.Text <> "" Then
            calcular_precios(CDbl(Txt_Precio.Text))
            Txt_Mayor.Focus()
        Else
            Txt_Mayor.Focus()
        End If

    End Sub

    Private Sub txtMayor_Leave(sender As Object, e As EventArgs) Handles Txt_Mayor.Leave

        If Txt_Mayor.Text = "" And Txt_Precio.Text <> "" Then
            calcular_precios(CDbl(Txt_Precio.Text))
            If Me.Text = "ACTULIZACION DE CONDIMENTOS" Then
                Btn_Actualizar.Focus()
            ElseIf Me.Text = "INGRESO DE CONDIMENTOS" Then
                Btn_Agregar.Focus()
            End If
        End If

    End Sub

    Private Sub ChbImp_CheckedChanged(sender As Object, e As EventArgs) Handles Chb_Impuesto.CheckedChanged

        If Txt_Precio.Text <> "" Then
            calcular_precios(CDbl(Txt_Precio.Text))
        End If

    End Sub

    Private Sub TxtCondimento_Enter(sender As Object, e As EventArgs) Handles Txt_Condimento.Enter

        If Me.Text <> "ACTULIZACION DE CONDIMENTOS" Then
            If Txt_Condimento.Text = "ESCRIBA EL CONDIMENTO" Then
                Txt_Condimento.BackColor = Color.White
                Txt_Condimento.Clear()
            End If
        End If

    End Sub

    Private Sub TxtCondimento_Leave(sender As Object, e As EventArgs) Handles Txt_Condimento.Leave

        If Me.Text = "CONDIMENTOS CONSULTA" Then
            If Txt_Condimento.Text = "" Then
                Txt_Condimento.Text = "ESCRIBA EL CONDIMENTO"
                Txt_Condimento.BackColor = Color.Cyan
                Txt_Condimento.Focus()
            End If
        Else
            Txt_Precio.Focus()
        End If

    End Sub

    Private Sub TxtCondimento_KeyUp(sender As Object, e As KeyEventArgs) Handles Txt_Condimento.KeyUp

        If Me.Text <> "ACTULIZACION DE CONDIMENTOS" Then
            If Lv_Condimentos.Columns.Count = 5 Then
                Lv_Condimentos.Items.Clear()
                SEL_COND_FILTRO_COSTO(Txt_Condimento.Text, Lv_Condimentos)
            ElseIf Txt_Condimento.Text <> "ESCRIBA EL CONDIMENTO" Then
                Lv_Condimentos.Items.Clear()
                SEL_COND_FILTRO_SUGERIDO(Txt_Condimento.Text, Lv_Condimentos)
            End If
        End If

    End Sub

    Private Sub CONDIMENTOS_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.Control AndAlso e.Alt Then
            Select Case e.KeyCode
                Case Keys.F12
                    Me.Text = "ACTULIZACION DE CONDIMENTOS"
                    TABLA_COSTOS()
                    Txt_Codigo.ReadOnly = True
                    Btn_Actualizar.Visible = True
                    Btn_Agregar.Visible = False
                    Txt_Condimento.BackColor = Color.White
                    Txt_Condimento.ReadOnly = True
                    Txt_Nombre_Actualizar.ForeColor = Color.Black
                    Txt_Condimento.Clear()
                    Txt_Condimento.BackColor = Color.White
                    Txt_Codigo.Focus()
                Case Keys.F11
                    TABLA_PRECIOS()
                    Btn_Actualizar.Visible = False
                    Btn_Agregar.Visible = False
                    Me.Text = "CONDIMENTOS CONSULTA"
                    Txt_Condimento.ReadOnly = False
                    Txt_Condimento.BackColor = Color.Cyan
                Case Keys.F10
                    Me.Text = "INGRESO DE CONDIMENTOS"
                    TABLA_COSTOS()
                    Txt_Condimento.BackColor = Color.White
                    Txt_Condimento.Clear()
                    Txt_Codigo.ReadOnly = False
                    Txt_Condimento.ReadOnly = False
                    Btn_Actualizar.Visible = False
                    Btn_Agregar.Visible = True
                    Txt_Nombre_Actualizar.Visible = False
                    Chb_Nombre.Visible = False
                    Txt_Codigo.Focus()
            End Select
        End If

    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles Btn_Salir.Click

        Fr_Inicio.Show()
        Me.Close()

    End Sub

    Private Sub txt_codigo_Leave(sender As Object, e As EventArgs) Handles Txt_Codigo.Leave

        If Txt_Codigo.Text <> "" And Txt_Condimento.Text <> "" Then
            MsgBox("EL CODIGO YA ESTA EN USO")
            Txt_Codigo.Clear()
            Txt_Codigo.Focus()
        Else
            Txt_Condimento.Focus()
        End If

    End Sub

    Private Sub txt_codigo_KeyUp(sender As Object, e As KeyEventArgs) Handles Txt_Codigo.KeyUp

        If Txt_Codigo.Text <> "" Then
            Txt_Condimento.Clear()
            SEL_COND_ID(Txt_Codigo.Text, Txt_Condimento.Text)
        ElseIf Me.Text = "CONDIMENTOS CONSULTA" Then
            Txt_Condimento.Text = "ESCRIBA EL CONDIMENTO"
            Txt_Condimento.BackColor = Color.Cyan
        End If

    End Sub

    Private Sub Chb_nombre_CheckedChanged(sender As Object, e As EventArgs) Handles Chb_Nombre.CheckedChanged

        If Chb_Nombre.Checked Then
            Txt_Condimento.ReadOnly = False
        Else
            Txt_Condimento.ReadOnly = True
        End If

    End Sub

    Private Sub txt_nombreAct_KeyUp(sender As Object, e As KeyEventArgs) Handles Txt_Nombre_Actualizar.KeyUp

        Lv_Condimentos.Items.Clear()
        SEL_COND_FILTRO_COSTO(Txt_Nombre_Actualizar.Text, Lv_Condimentos)

    End Sub

    Private Sub txt_nombreAct_Enter(sender As Object, e As EventArgs) Handles Txt_Nombre_Actualizar.Enter

        If Txt_Nombre_Actualizar.Text = "BUSCADOR" Then
            Txt_Nombre_Actualizar.Clear()
        End If

    End Sub

    Private Sub txt_nombreAct_Leave(sender As Object, e As EventArgs) Handles Txt_Nombre_Actualizar.Leave

        If Txt_Nombre_Actualizar.Text = "" Then
            Txt_Nombre_Actualizar.Text = "BUSCADOR"
        End If

    End Sub

    Private Sub LvCondimentos_Click(sender As Object, e As EventArgs) Handles Lv_Condimentos.Click

        If Lv_Condimentos.Items.Count > 0 And Me.Text = "ACTULIZACION DE CONDIMENTOS" Then
            SEL_COND(Txt_Codigo.Text, Txt_Condimento.Text, Chb_Impuesto.Checked, Txt_Precio.Text,
                    Lv_Condimentos.Items(Lv_Condimentos.FocusedItem.Index).Text)
            calcular_precios(Txt_Precio.Text)
        End If

    End Sub

    Private Sub TxtCondimento_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Txt_Condimento.PreviewKeyDown

        If Txt_Condimento.Text = "ESCRIBA EL CONDIMENTO" Then
            Txt_Condimento.Clear()
            Txt_Condimento.BackColor = Color.White
        End If

    End Sub

End Class