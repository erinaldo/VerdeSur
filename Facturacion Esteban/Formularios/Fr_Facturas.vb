Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO

Public Class Fr_Facturas
    'DECLARACIONES DE BARIABLES GLOBALES

    Public dataGin As New DataGridView
    Public DgRepDia As New DataGridView
    Public tipo_impresion As String
    Public imprimir_con_fecha As Boolean

    Dim ex, ey As Integer
    Dim arrastre As Boolean
    Dim tabactive As Integer
    Dim tapposition As Integer
    'VARIABLE QUE GUARDA LA CANTIDAD DE FACTURAS SELECCIONADAS
    Dim facturas_seleccionadas As Integer = Nothing

    Private nombre_empresa As String
    Private usar_impresora_termica As Boolean
    Private usar_precios_anteriores As Boolean
    Private cabecera_1 As String
    Private cabecera_2 As String
    Private cabecera_3 As String
    Private cabecera_4 As String
    Private cabecera_5 As String
    Private cabecera_6 As String
    Private pie_pagina As String
    Private numero_factura As String
    Public cabeceraFactura(5) As String
    Private lista_pedidos_id As New List(Of Integer)

    Dim _CedulaCliente As String
    Dim _MedioPago As String = "04"
    Dim _TipoFactura As String = "CREDITO"

    Private tiempo As Integer = 0

    'CAMBIA DE COLOR SEGUN EL VENDEDOR
    Private Sub coloreaVendedor()

        For Each Row As DataGridViewRow In Dgv_facturas_cerradas.Rows

            If Row.Cells("c_vendedor_c").Value = "ARRIBA" And Row.Cells("c_fecha_c").Value = Today Then
                Row.DefaultCellStyle.ForeColor = Color.Red
            ElseIf Row.Cells("c_vendedor_c").Value = "ABAJO" And Row.Cells("c_fecha_c").Value = Today Then
                Row.DefaultCellStyle.ForeColor = Color.Blue
            ElseIf Row.Cells("c_vendedor_c").Value = "FERIA ABAJO" And Row.Cells("c_fecha_c").Value = Today Then
                Row.DefaultCellStyle.ForeColor = Color.Purple
            End If

        Next

        For Each Row As DataGridViewRow In dgv_facturas_abiertas.Rows

            If Row.Cells(c_vendedor_a.Index).Value = "ARRIBA" And Row.Cells(c_fecha_a.Index).Value = Today Then
                Row.DefaultCellStyle.ForeColor = Color.Red
            ElseIf Row.Cells(c_vendedor_a.Index).Value = "ABAJO" And Row.Cells(c_fecha_a.Index).Value = Today Then
                Row.DefaultCellStyle.ForeColor = Color.Blue
            ElseIf Row.Cells(c_vendedor_a.Index).Value = "FERIA ABAJO" And Row.Cells(c_fecha_a.Index).Value = Today Then
                Row.DefaultCellStyle.ForeColor = Color.Purple
            End If

        Next

    End Sub

    'CAMBIA EL COLOR DEL VENDEDOR EN LA TABLA FACTURAS
    Private Sub coloreaVendedorActFact()

        If Dgv_facturas_cerradas.Rows(tapposition).Cells("c_vendedor_c").Value = "ARRIBA" And Dgv_facturas_cerradas.Rows(tapposition).Cells("c_fecha_c").Value = Today Then
            Dgv_facturas_cerradas.Rows(tapposition).DefaultCellStyle.ForeColor = Color.Red
        ElseIf Dgv_facturas_cerradas.Rows(tapposition).Cells("c_vendedor_c").Value = "ABAJO" And Dgv_facturas_cerradas.Rows(tapposition).Cells("c_fecha_c").Value = Today Then
            Dgv_facturas_cerradas.Rows(tapposition).DefaultCellStyle.ForeColor = Color.Blue
        ElseIf Dgv_facturas_cerradas.Rows(tapposition).Cells("c_vendedor_c").Value = "FERIA ABAJO" And Dgv_facturas_cerradas.Rows(tapposition).Cells("c_fecha_c").Value = Today Then
            Dgv_facturas_cerradas.Rows(tapposition).DefaultCellStyle.ForeColor = Color.Purple
        Else
            Dgv_facturas_cerradas.Rows(tapposition).DefaultCellStyle.ForeColor = Color.Black
        End If

    End Sub

    'CAMBIA EL COLOR DEL VENDEDOR EN LA TABLA FACTURAS ABIERTAS
    Private Sub coloreaVendedorActFactOpen()

        If dgv_facturas_abiertas.Rows(tapposition).Cells("c_vendedor_a").Value = "ARRIBA" And dgv_facturas_abiertas.Rows(tapposition).Cells("c_fecha_a").Value = Today Then
            dgv_facturas_abiertas.Rows(tapposition).DefaultCellStyle.ForeColor = Color.Red
        ElseIf dgv_facturas_abiertas.Rows(tapposition).Cells("c_vendedor_a").Value = "ABAJO" And dgv_facturas_abiertas.Rows(tapposition).Cells("c_fecha_a").Value = Today Then
            dgv_facturas_abiertas.Rows(tapposition).DefaultCellStyle.ForeColor = Color.Blue
        ElseIf dgv_facturas_abiertas.Rows(tapposition).Cells("c_vendedor_a").Value = "FERIA ABAJO" And dgv_facturas_abiertas.Rows(tapposition).Cells("c_fecha_a").Value = Today Then
            dgv_facturas_abiertas.Rows(tapposition).DefaultCellStyle.ForeColor = Color.Purple
        Else
            dgv_facturas_abiertas.Rows(tapposition).DefaultCellStyle.ForeColor = Color.Black
        End If


    End Sub

    'COMPRUEBA DUPLICADOS
    Private Function compruebaDupli() As Boolean

        Dim numFactura As String = Dgv_facturas_cerradas.CurrentRow.Cells("c_nro_factura_c").Value
        Dim respu As Boolean = False
        For i As Integer = 0 To Lv_Detalle_Fact_X_Cobrar_4.Items.Count - 1
            If numFactura = Lv_Detalle_Fact_X_Cobrar_4.Items(i).Text Then
                respu = True
            End If
        Next
        Return respu

    End Function

    'AÑADE ARTICULOS A LA PESTAÑA DE FACTURAS POR COBRAR
    Private Sub añadir()

        'INS_TEMP(Txt_Numero_Factura_4.Text, Txt_Nombre_Cliente_4.Text, CDbl(Txt_Monto_4.Text))
        Try
            With Lv_Detalle_Fact_X_Cobrar_4.Items.Add(Txt_Numero_Factura_4.Text)
                .SubItems.Add(Txt_Nombre_Cliente_4.Text)
                .SubItems.Add(convertir_formato_miles(CDbl(Txt_Monto_4.Text)))
            End With
            If Txt_Numero_Factura_4.Text.Length > 3 Then
                Txt_Numero_Factura_4.Text = Txt_Numero_Factura_4.Text.Substring(0, 3)
            Else
                Txt_Numero_Factura_4.Clear()
            End If

            Txt_Nombre_Cliente_4.Clear()
            Txt_Monto_4.Text = 0
            Txt_Numero_Factura_4.Focus()
            suma()
        Catch ex As Exception
            Logger.e("Error con excepción", ex, New StackFrame(True))
            MsgBox(ex.ToString)
        End Try

    End Sub

    'SUMA LOS MONTOS DEL LISTVIEW FACTURAS POR COBRAR
    Private Sub suma()

        Dim total As Double = 0
        Dim itm As ListViewItem
        For Each itm In Lv_Detalle_Fact_X_Cobrar_4.Items
            total += CDbl(itm.SubItems(2).Text)
        Next
        Txt_Total_4.Text = String.Format("{0:n}", total)

    End Sub

    'IMPRIME LA FACTURA TERMICA
    Private Sub imprimir(ByVal tipoFact As String)

        StartPrint()
        If prn.PrinterIsOpen = True Then
            PrintHeader(nombre_empresa, cabeceraFactura)
            PrintDetalles(vp_fechain, vp_facturain, vp_clientein,
                          vp_codCliente, vp_coment1in, vp_coment2in, tipoFact, "")
            PrintBody(dataGin, vp_totalin, vp_subtotalin, vp_descuentoin, vp_pagoin, vp_cambioin)
            PrintFooter(pie_pagina)
            EndPrint()
        End If

    End Sub

    'IMPRIME LA FACTURA TERMICA
    Private Sub imprimir_fecha(ByVal tipoFact As String)

        StartPrint()
        If prn.PrinterIsOpen = True Then
            PrintHeader(nombre_empresa, cabeceraFactura)
            PrintDetalles(vp_fechain, vp_facturain, vp_clientein,
                          vp_codCliente, vp_coment1in, vp_coment2in, tipoFact, "")
            PrintBody_wDate(dataGin, vp_totalin, vp_subtotalin, vp_descuentoin, vp_pagoin, vp_cambioin)
            PrintFooter(pie_pagina)
            EndPrint()
        End If

    End Sub

    'IMPRIME LA FACTURA MATRIZ
    Private Sub imprimir_Matriz()

        StartPrintMatriz()
        If prn_matriz.PrinterIsOpen = True Then
            PrintHeaderMatriz(nombre_empresa, cabeceraFactura)
            PrintDetallesMatriz(vp_fechain, vp_facturain, vp_clientein,
                          vp_codCliente, vp_coment1in, vp_coment2in, "")
            PrintBodyMatriz(dataGin, vp_totalin, vp_subtotalin, vp_descuentoin, vp_pagoin, vp_cambioin, "0")
            PrintFooterMatriz(pie_pagina)
            EndPrintMatriz()
        End If

    End Sub

    'IMPRIME LA FACTURA MATRIZ CON FECHA
    Private Sub imprimir_Matriz_fecha()

        StartPrintMatriz()
        If prn_matriz.PrinterIsOpen = True Then
            PrintHeaderMatriz(nombre_empresa, cabeceraFactura)
            PrintDetallesMatriz(vp_fechain, vp_facturain, vp_clientein,
                          vp_codCliente, vp_coment1in, vp_coment2in, "")
            PrintBodyMatriz_wDate(dataGin, vp_totalin, vp_subtotalin, vp_descuentoin, vp_pagoin, vp_cambioin)
            PrintFooterMatriz(pie_pagina)
            EndPrintMatriz()
        End If

    End Sub

    ' IMPRIME LA COTIZACION
    Private Sub imprimir_cot()

        StartPrint()
        If prn.PrinterIsOpen = True Then
            PrintHeaderCot(nombre_empresa, cabeceraFactura)
            PrintDetallesCot(vp_fechain, vp_facturain, vp_clientein,
                          vp_codCliente, vp_coment1in, vp_coment2in)
            PrintBodyCot(dataGin, vp_totalin, vp_subtotalin, vp_descuentoin)
            EndPrint()
            limpiaVariablesPrint()
        End If
    End Sub

    'IMPRIME EN LA IMPRESORA MATRIZ
    Private Sub imprimir_cot_Matriz()

        StartPrintMatriz()
        If prn_matriz.PrinterIsOpen = True Then
            PrintHeaderCot_Matriz(nombre_empresa, cabeceraFactura)
            PrintDetallesCot_Matriz(vp_fechain, vp_facturain, vp_clientein,
                          vp_codCliente, vp_coment1in, vp_coment2in)
            PrintBodyCot_Matriz(dataGin, vp_totalin, vp_subtotalin, vp_descuentoin)
            EndPrintMatriz()
            limpiaVariablesPrint()
        End If

    End Sub

    'IMPRIME LOS DATOS DE LA COTIZACION
    Public Sub imprimirDatosCot(ByVal numeroFactura As Integer)

        Try
            If dgv_cotizaciones.Rows.Count > 0 Then
                Datos_Cabecera_Cot(numeroFactura)
                Datos_Detalle_Cot(vp_factImpin, dataGin)
                If usar_impresora_termica = True Then
                    imprimir_cot()
                Else
                    imprimir_cot_Matriz()
                End If
                dataGin.RowCount = 1
                dataGin.Rows.Clear()
            End If
        Catch ex As Exception
            If ex.ToString.Contains("NullReference") Then
                MsgBox("SELECIONE UNA COTIZACION")
            Else
                Logger.e("Error con excepción", ex, New StackFrame(True))
                MsgBox(ex.ToString())
            End If
        End Try

    End Sub

    'IMPRIME UNA FACTURA CERRADA O ABIERTA
    Public Sub imprimirDatos(ByVal numeroFactura As Integer, ByVal tipo As String, ByVal motivo As String, ByVal p_imprimir_fecha As Boolean)

        Try
            Dim printerType As Boolean = False
            If Dgv_facturas_cerradas.Rows.Count > 0 Or dgv_facturas_abiertas.Rows.Count > 0 Then
                Datos_Cabecera(numeroFactura, printerType)
                Datos_Detalle(vp_factImpin, dataGin)
                dataGin.Sort(dataGin.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
                If printerType = False And usar_impresora_termica = True Then

                    If p_imprimir_fecha Then
                        If tipo = "ORIGINAL" Then
                            INS_HIST_PRINT(vp_factImpin.ToString, DateTime.Now, 1, tipo, motivo, "TERMICA")
                            imprimir("ORIGINAL")
                        ElseIf tipo = "COPIA" Then
                            INS_HIST_PRINT(vp_factImpin.ToString, DateTime.Now, 1, tipo, motivo, "TERMICA")
                            imprimir_fecha("COPIA")

                        ElseIf tipo = "AMBAS" Then
                            INS_HIST_PRINT(vp_factImpin.ToString, DateTime.Now, 2, tipo, motivo, "TERMICA")
                            imprimir_fecha("ORIGINAL")
                            imprimir_fecha("COPIA")
                        End If
                    Else
                        If tipo = "ORIGINAL" Then
                            INS_HIST_PRINT(vp_factImpin.ToString, DateTime.Now, 1, tipo, motivo, "TERMICA")
                            imprimir("ORIGINAL")

                        ElseIf tipo = "COPIA" Then
                            INS_HIST_PRINT(vp_factImpin.ToString, DateTime.Now, 1, tipo, motivo, "TERMICA")
                            imprimir("COPIA")

                        ElseIf tipo = "AMBAS" Then
                            INS_HIST_PRINT(vp_factImpin.ToString, DateTime.Now, 2, tipo, motivo, "TERMICA")
                            imprimir("ORIGINAL")
                            imprimir("COPIA")

                        End If
                    End If

                Else
                    If usar_impresora_termica Then
                        MsgBox("ENCIENDA LA IMPRESORA", MsgBoxStyle.Information, "ADVERTENCIA")
                    End If
                    INS_HIST_PRINT(vp_factImpin.ToString, DateTime.Now, 1, "AMBAS", motivo, "MATRIZ")
                    If p_imprimir_fecha Then
                        imprimir_Matriz_fecha()
                    Else
                        imprimir_Matriz()
                    End If

                End If
                'LIMPIA LA TABLA DE DETALLES TEMPORAL
                dataGin.RowCount = 1
                dataGin.Rows.Clear()
            End If

        Catch ex As Exception
            If ex.ToString.Contains("NullReference") Then
                MsgBox("SELECIONE UNA FACTURA")
            Else
                MsgBox(ex.ToString())
                Logger.e("Error con excepción", ex, New StackFrame(True))
            End If

        End Try

    End Sub

    'LLENA EL LISTVIEW DE FACTURAS CERRADAS
    Public Sub rellenarFacturasCerradas()

        SEL_FACT_CLOSED(Dgv_facturas_cerradas)
        Txt_Busqueda_Nombre.Clear()
        Txt_Busqueda_Numero.Clear()
        coloreaVendedor()
        If Dgv_facturas_cerradas.Rows.Count > 0 Then
            Dgv_facturas_cerradas.Rows(0).Selected = True
        End If

    End Sub

    'LLENA EL LISTVIEW DE FACTURAS ABIERTAS
    Public Sub rellenarFacturasAbiertas()

        SEL_FACT_OPEN(dgv_facturas_abiertas)
        Txt_Busqueda_Nombre.Clear()
        Txt_Busqueda_Numero.Clear()
        coloreaVendedor()
        If dgv_facturas_abiertas.Rows.Count > 0 Then
            dgv_facturas_abiertas.Rows(0).Selected = True
        End If

    End Sub

    'LLENA EL LISTVIEW DE FACTURAS ABIERTAS
    Public Sub rellenarFacturasPAGADA()

        SEL_FACT_PAGADA(dgvPagada)
        Txt_Busqueda_Nombre.Clear()
        Txt_Busqueda_Numero.Clear()
        coloreaVendedor()
        If dgvPagada.Rows.Count > 0 Then
            dgvPagada.Rows(0).Selected = True
        End If

    End Sub

    'LLENA EL LISTVIEW DE LAS COTIZACIONES
    Public Sub rellenaCotizacion()

        SEL_COTIZACION(dgv_cotizaciones)

    End Sub

    'CARGA LAS VARIABLES DE INICIO
    Private Sub inicio()

        limpia_variablesBD_Modulo()
        tipo_impresion = "NULA"
        SEL_CONFIG_FACTURA(nombre_empresa, numero_factura, usar_impresora_termica, usar_precios_anteriores, cabecera_1,
            cabecera_2, cabecera_3, cabecera_4, cabecera_5, cabecera_6, pie_pagina)
        Timer1.Start()
        cabeceraFactura(0) = cabecera_1
        cabeceraFactura(1) = cabecera_2
        cabeceraFactura(2) = cabecera_3
        cabeceraFactura(3) = cabecera_4
        cabeceraFactura(4) = cabecera_5
        cabeceraFactura(5) = cabecera_6

        tapposition = 0
        Lb_Mensaje.Text = "ESTADO NORMAL..."

        If Fr_Crear_Facturas.Visible Then
            Fr_Crear_Facturas.Close()
        End If

        SEL_VENDEDORES(Chb_Vendedor, Lv_Id_Vendedor_3)
        Chb_Vendedor.SelectedItem = "CAJA"
        PictureBox2.Parent = PB_Facturas
        PictureBox3.Parent = PB_Facturas
        lb_vendedor.Parent = PB_Facturas
        SEL_FACT_OPEN(dgv_facturas_abiertas)

        For i As Integer = 0 To 7
            Dim col As New DataGridViewTextBoxColumn
            dataGin.Columns.Add(col)
        Next

        For i As Integer = 0 To 3
            Dim col As New DataGridViewTextBoxColumn
            DgRepDia.Columns.Add(col)
        Next

        coloreaVendedor()

    End Sub

    Private Sub Facturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        inicio()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btn_Salir_1.Click

        Fr_Inicio.Show()
        Me.Dispose()

    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles Btn_Crear_1.Click

        Fr_Crear_Facturas.Show()
        vp_estado = "ADD"
        Fr_Crear_Facturas.Txt_Codigo_Cliente.Focus()
        Me.Hide()

    End Sub

    Private Sub Facturas_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyValue = Keys.F5 Then
            Fr_Crear_Facturas.Show()
            Fr_Crear_Facturas.Txt_Codigo_Cliente.Focus()
            Me.Hide()
        End If

    End Sub

    Private Sub txtBusquedaNombre_KeyUp(sender As Object, e As KeyEventArgs) Handles Txt_Busqueda_Nombre.KeyUp
        Dim busqueda As String = Nothing
        Try
            If Txt_Busqueda_Nombre.Text.Length > 2 Then
                busqueda = Txt_Busqueda_Nombre.Text.Trim.Replace(" ", "%")
                If Tab_Opciones.SelectedIndex = 0 Then
                    SEL_FACT_CLOSED_BUSQ(busqueda, Dgv_facturas_cerradas)
                Else
                    SEL_FACT_OPEN_BUSQ(busqueda, dgv_facturas_abiertas)
                End If
            ElseIf Txt_Busqueda_Nombre.Text.Length = 0 Then
                Dgv_facturas_cerradas.Rows.Clear()
                SEL_FACT_CLOSED(Dgv_facturas_cerradas)
                SEL_FACT_OPEN(dgv_facturas_abiertas)
            End If

        Catch ex As Exception
            Logger.e("Error con excepción", ex, New StackFrame(True))
            MsgBox(ex.ToString)
        End Try


    End Sub

    Private Sub txtFacturaB_KeyUp(sender As Object, e As KeyEventArgs) Handles Txt_Busqueda_Numero.KeyUp

        If Txt_Busqueda_Numero.Text.Length > 2 Then
            If Tab_Opciones.SelectedIndex = 0 Then
                SEL_FACT_CLOSED_BUSQF(Txt_Busqueda_Numero.Text, Dgv_facturas_cerradas)
            Else
                SEL_FACT_OPEN_BUSQF(Txt_Busqueda_Numero.Text, dgv_facturas_abiertas)
            End If
        ElseIf Txt_Busqueda_Numero.Text.Length = 0 Then
            SEL_FACT_CLOSED(Dgv_facturas_cerradas)
            SEL_FACT_OPEN(dgv_facturas_abiertas)
        End If

    End Sub

    Private Sub txtFacturaB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Busqueda_Numero.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnCerrarFac_Click(sender As Object, e As EventArgs) Handles Btn_Cerrar_Factura_2.Click

        Dim numero As Integer = 0
        Dim contador As Integer = 0
        If facturas_seleccionadas = 0 Then
            MsgBox("SELECCIONE LAS FACTURAS QUE QUIERE CERRAR", MsgBoxStyle.Information, "INFORMACION")
        Else
            If facturas_seleccionadas > 5 Then
                MsgBox("REVISE QUE CUENTE CON SUFICIENTE ROLLO PARA IMPRIMIR VARIAS FACTURAS A LA VEZ", MsgBoxStyle.Information, "INFORMACION")
            End If

            For i = dgv_facturas_abiertas.Rows.Count - 1 To 0 Step -1
                If dgv_facturas_abiertas.Rows(i).Cells(0).Value = True Then
                    contador += 1
                    Try

                        'CADA 7 FACTURAS IMPRESAS GENERA UNA PAUSA
                        If contador = 7 Then
                            MsgBox("PAUSA, PRESIONE ACEPTAR PARA CONTINUAR")
                            numero = CInt(dgv_facturas_abiertas.Rows(i).Cells(c_id_a.Index).Value)
                            UPD_CLOSE_FACT(numero)
                            imprimirDatos(numero, "AMBAS", "FACTURA ORIGINAL", imprimir_con_fecha)
                            contador = 0
                        Else
                            numero = CInt(dgv_facturas_abiertas.Rows(i).Cells(c_id_a.Index).Value)
                            UPD_CLOSE_FACT(numero)
                            imprimirDatos(numero, "AMBAS", "FACTURA ORIGINAL", imprimir_con_fecha)
                        End If

                    Catch ex As Exception
                        If ex.ToString.Contains("NullReference") Then
                            MsgBox("SELECCIONE UNA FACTURA")
                        Else
                            MsgBox(ex.ToString)
                            Logger.e("Error con excepción", ex, New StackFrame(True))
                        End If
                    End Try
                End If
            Next

            SEL_FACT_CLOSED(Dgv_facturas_cerradas)
            SEL_FACT_OPEN(dgv_facturas_abiertas)
            imprimir_con_fecha = False

        End If


    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles Btn_Modificar_1.Click

        Try
            If Dgv_facturas_cerradas.Rows.Count > 0 Then
                Fr_Crear_Facturas.Show()
                vp_factura_id = CInt(Dgv_facturas_cerradas.CurrentRow.Cells(c_id_cerrada_c.Index).Value)
                vp_estado = "UPDATE"
                Me.Hide()
            End If

        Catch ex As Exception
            If ex.ToString.Contains("NullReference") Then
                MsgBox("SELECCIONE UNA FACTURA", MsgBoxStyle.Information, "ADVERTENCIA")
                Me.Visible = True
                Fr_Crear_Facturas.Close()
            Else
                MsgBox(ex.ToString)
                Logger.e("Error con excepción", ex, New StackFrame(True))
            End If
        End Try

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Tab_Opciones.SelectedIndexChanged

        tamanno_listas_dgv_lv()

        'EVITA QUE A LA HORA DE CAMBIAR DE TAB SE REFERENCIE UN OBJETO NULO
        Tab_Opciones.Focus()


        If Tab_Opciones.SelectedIndex = 0 Then
            rellenarFacturasCerradas()
            Try
                If Dgv_facturas_cerradas.CurrentRow IsNot Nothing Then
                    tapposition = Dgv_facturas_cerradas.CurrentRow.Index
                Else
                    tapposition = -1
                End If
            Catch ex As Exception
                Logger.e("Error con excepción", ex, New StackFrame(True))
                MsgBox(ex.ToString)
            End Try

        ElseIf Tab_Opciones.SelectedIndex = 1 Then

            rellenarFacturasAbiertas()
            tabactive = 1
            Try
                If dgv_facturas_abiertas.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0 Then
                    tapposition = dgv_facturas_abiertas.CurrentRow.Index
                Else
                    tapposition = -1
                End If
            Catch ex As Exception
                Logger.e("Error con excepción", ex, New StackFrame(True))
                MsgBox(ex.ToString)
            End Try

        ElseIf Tab_Opciones.SelectedIndex = 2 Then

            rellenarFacturasPAGADA()
            tabactive = 1
            Try
                If dgvPagada.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0 Then
                    tapposition = dgvPagada.CurrentRow.Index
                Else
                    tapposition = -1
                End If
            Catch ex As Exception
                Logger.e("Error con excepción", ex, New StackFrame(True))
                MsgBox(ex.ToString)
            End Try


        ElseIf Tab_Opciones.SelectedIndex = 4 Then

            Txt_Numero_Factura_4.Focus()

        ElseIf Tab_Opciones.SelectedIndex = 5 Then
            SEL_COTIZACION(dgv_cotizaciones)
        Else
            tapposition = -1
            tabactive = -1
        End If
        Txt_Monto_4.Text = "0"

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles Btn_Agregar_2.Click

        'COMPRUEVO QUE HAIGAN FACTURAS ABIERTAS
        Try
            If dgv_facturas_abiertas.CurrentRow IsNot Nothing Then
                If dgv_facturas_abiertas.Rows.Count > 0 Then
                    Fr_Crear_Facturas.Show()
                    vp_factura_id = CInt(dgv_facturas_abiertas.CurrentRow.Cells(c_id_a.Index).Value)
                    vp_estado = "UPDATEOPEN"
                    Me.Hide()
                End If
            End If
        Catch ex As Exception
            If ex.ToString.Contains("NullReference") Then
                MsgBox("PRIMERO SELECCIONE UNA FACTURA", MsgBoxStyle.Critical, "ADVERTENCIA")
                Me.Visible = True
                Fr_Crear_Facturas.Close()
            Else
                Logger.e("Error con excepción", ex, New StackFrame(True))
                MsgBox(ex.ToString)
            End If
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Eliminar_1.Click

        Dim numero As Integer = 0
        Try
            If Tab_Opciones.SelectedIndex = 0 And Dgv_facturas_cerradas.Rows.Count > 0 Then
                numero = CInt(Dgv_facturas_cerradas.CurrentRow.Cells(c_nro_factura_c.Index).Value)
                vp_factura_id = CInt(Dgv_facturas_cerradas.CurrentRow.Cells(c_id_cerrada_c.Index).Value)
                If MsgBox("BORRAR LA FACTURA # " + numero.ToString, MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "CUIDADO") = MsgBoxResult.Yes Then
                    DEL_FACT(vp_factura_id)
                    SEL_FACT_CLOSED(Dgv_facturas_cerradas)
                End If
            ElseIf dgv_facturas_abiertas.Rows.Count > 0 Then
                numero = CInt(dgv_facturas_abiertas.CurrentRow.Cells(c_nro_factura_a.Index).Value)
                vp_factura_id = CInt(dgv_facturas_abiertas.CurrentRow.Cells(c_id_a.Index).Value)
                If MsgBox("BORRAR LA FACTURA # " + numero.ToString, MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "CUIDADO") = MsgBoxResult.Yes Then
                    DEL_FACT(vp_factura_id)
                    SEL_FACT_OPEN(dgv_facturas_abiertas)
                End If
            End If
        Catch ex As Exception
            Logger.e("Error con excepción", ex, New StackFrame(True))
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles Btn_Imprimir_1.Click

        Try
            If Dgv_facturas_cerradas.CurrentRow.Cells(c_nro_factura_c.Index).Value <> "" Then
                vp_factura_id = CInt(Dgv_facturas_cerradas.CurrentRow.Cells(c_id_cerrada_c.Index).Value)
                Fr_Opciones_Impresion.Show()
            End If
        Catch ex As Exception
            MsgBox("SELECCIONE UNA FACTURA", MsgBoxStyle.Information, "ADVERTENCIA")
        End Try

    End Sub

    Private Sub btnRFecha_Click(sender As Object, e As EventArgs) Handles Btn_Reporte_Fecha_3.Click

        Fr_Reporte_Fechas.Show()

    End Sub

    Private Sub btnVendedor_Click(sender As Object, e As EventArgs) Handles Btn_Reporte_Vendedor_3.Click

        Fr_Opciones_cargar.Show()

    End Sub

    Private Sub btnRCliente_Click(sender As Object, e As EventArgs) Handles Btn_Reporte_Cliente_3.Click

        Fr_Reporte_Clientes.Show()

    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PB_Facturas.MouseUp

        arrastre = False

    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PB_Facturas.MouseMove

        If arrastre Then
            Me.Location = Me.PointToScreen(New Point(MousePosition.X - Me.Location.X - ex, MousePosition.Y - Me.Location.Y - ey))
        End If

    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PB_Facturas.MouseDown

        ex = e.X
        ey = e.Y
        arrastre = True

    End Sub

    Private Sub btnCrear_MouseEnter(sender As Object, e As EventArgs) Handles Btn_Crear_1.MouseEnter

        Btn_Crear_1.Image = My.Resources.InvoiceOn

    End Sub

    Private Sub btnCrear_MouseLeave(sender As Object, e As EventArgs) Handles Btn_Crear_1.MouseLeave

        Btn_Crear_1.Image = My.Resources.InvoiceOff

    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Btn_Eliminar_1.MouseEnter

        Btn_Eliminar_1.Image = My.Resources.trashcanOn

    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Btn_Eliminar_1.MouseLeave

        Btn_Eliminar_1.Image = My.Resources.trashcan

    End Sub

    Private Sub btnSalir_MouseEnter(sender As Object, e As EventArgs) Handles Btn_Salir_1.MouseEnter

        Btn_Salir_1.Image = My.Resources.exit_rojo

    End Sub

    Private Sub btnSalir_MouseLeave(sender As Object, e As EventArgs) Handles Btn_Salir_1.MouseLeave

        Btn_Salir_1.Image = My.Resources.exit_azul

    End Sub

    Private Sub btnImprimir_MouseEnter(sender As Object, e As EventArgs) Handles Btn_Imprimir_1.MouseEnter

        Btn_Imprimir_1.Image = My.Resources.PrintOn

    End Sub

    Private Sub btnImprimir_MouseLeave(sender As Object, e As EventArgs) Handles Btn_Imprimir_1.MouseLeave

        Btn_Imprimir_1.Image = My.Resources.Print

    End Sub

    Private Sub btnModificar_MouseEnter(sender As Object, e As EventArgs) Handles Btn_Modificar_1.MouseEnter

        Btn_Modificar_1.Image = My.Resources.ModificarOn

    End Sub

    Private Sub btnModificar_MouseLeave(sender As Object, e As EventArgs) Handles Btn_Modificar_1.MouseLeave

        Btn_Modificar_1.Image = My.Resources.Modificarof

    End Sub

    Private Sub btnAgregar_MouseEnter(sender As Object, e As EventArgs) Handles Btn_Agregar_2.MouseEnter

        Btn_Agregar_2.Image = My.Resources.AddfileOn

    End Sub

    Private Sub btnAgregar_MouseLeave(sender As Object, e As EventArgs) Handles Btn_Agregar_2.MouseLeave

        Btn_Agregar_2.Image = My.Resources.Addfile

    End Sub

    Private Sub btnCerrarFac_MouseEnter(sender As Object, e As EventArgs) Handles Btn_Cerrar_Factura_2.MouseEnter

        Btn_Cerrar_Factura_2.Image = My.Resources.candadoOn

    End Sub

    Private Sub btnCerrarFac_MouseLeave(sender As Object, e As EventArgs) Handles Btn_Cerrar_Factura_2.MouseLeave

        Btn_Cerrar_Factura_2.Image = My.Resources.candadoOff

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Numero_Factura_4.KeyPress

        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtTotalF_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Monto_4.KeyPress

        If e.KeyChar = "-" And (Txt_Monto_4.Text <> "" And Txt_Monto_4.Text <> "-") Then
            Txt_Monto_4.Text = CStr(CDbl(Txt_Monto_4.Text) * -1)
            Txt_Monto_4.SelectionStart = Txt_Monto_4.Text.Length
        End If

        NumerosyDecimal(Txt_Monto_4, e)

        If Txt_Monto_4.Text <> "" And Txt_Monto_4.Text <> "-" And Txt_Monto_4.Text <> "," Then
            If e.KeyChar = ChrW(Keys.Enter) Then
                añadir()
                Txt_Numero_Factura_4.Focus()
                Txt_Numero_Factura_4.Select(Txt_Numero_Factura_4.Text.Length, 1)
            End If
        End If

    End Sub

    Private Sub txtnumF_Leave(sender As Object, e As EventArgs) Handles Txt_Numero_Factura_4.Leave

        If Txt_Numero_Factura_4.Text <> "" Then
            Try
                SEL_CLIENTE_COB(CInt(Txt_Numero_Factura_4.Text), Txt_Nombre_Cliente_4.Text, Txt_Monto_4.Text)
            Catch ex As Exception
                MsgBox(ex.ToString)
                Logger.e("Error con excepción", ex, New StackFrame(True))
            End Try
        End If

    End Sub

    Private Sub txtClienteF_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Nombre_Cliente_4.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) And CDbl(Txt_Monto_4.Text) > 0 Then
            añadir()
            Txt_Numero_Factura_4.Select(Txt_Numero_Factura_4.Text.Length, 1)
        End If

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Btn_Eliminar_Fila_4.Click

        Try
            Lv_Detalle_Fact_X_Cobrar_4.Items.RemoveAt(Lv_Detalle_Fact_X_Cobrar_4.SelectedIndices(0))
            suma()
        Catch ex As Exception
            If ex.ToString.Contains("ArgumentOut") Then
                MsgBox("SELECCIONE LA FILA A ELIMINAR", MsgBoxStyle.Critical, "ADVERTENCIA")
            Else
                Logger.e("Error con excepción", ex, New StackFrame(True))
                MsgBox(ex.ToString)
            End If
        End Try

    End Sub

    Private Sub txtTotal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Total_4.KeyPress

        e.Handled = True

    End Sub


    Private Sub LvFacturas_DoubleClick(sender As Object, e As EventArgs)

        If Not compruebaDupli() Then
            SEL_CLIENTE_COB(CInt(Dgv_facturas_cerradas.CurrentRow.Cells("c_numero_factura_c").Value), Txt_Nombre_Cliente_4.Text, Txt_Monto_4.Text)
            Txt_Numero_Factura_4.Text = Dgv_facturas_cerradas.CurrentRow.Cells("c_numero_factura_c").Value
            añadir()
        End If
        Using vista_previa As New Fr_vista_previa_factura(Dgv_facturas_cerradas.CurrentRow.Cells("c_id_cerrada_c").Value,
                                                          Dgv_facturas_cerradas.CurrentRow.Cells("c_cliente_c").Value)
            vista_previa.StartPosition = FormStartPosition.CenterParent
            vista_previa.ShowDialog()
        End Using

    End Sub

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles Btn_Cargar_4.Click

        Fr_Opciones_cargar.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Btn_Limpiar_FactXCobrar_4.Click

        Lv_Detalle_Fact_X_Cobrar_4.Items.Clear()
        DEL_TEMP_TODOS()
        Txt_Total_4.Text = "0,00"

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Btn_Actualizar_Vendedor.Click

        Try
            If Tab_Opciones.TabPages(Me.Tab_Opciones.SelectedIndex).Text = "Facturas" Then
                Dim numero As Integer = CInt(Dgv_facturas_cerradas.CurrentRow.Cells(c_nro_factura_c.Index).Value)
                Dim vendedor As Integer = CInt(Lv_Id_Vendedor_3.Items.Item(Chb_Vendedor.SelectedIndex).SubItems(0).Text)
                UPD_CLI_FACT(numero, vendedor)
                Dgv_facturas_cerradas.CurrentRow.Cells(c_vendedor_c.Index).Value = Chb_Vendedor.SelectedItem
                Dgv_facturas_cerradas.Focus()
                coloreaVendedorActFact()
                Dgv_facturas_cerradas.Rows(tapposition).Selected = True
                Dgv_facturas_cerradas.CurrentCell = Dgv_facturas_cerradas.Rows(tapposition).Cells(0)

            ElseIf Tab_Opciones.TabPages(Me.Tab_Opciones.SelectedIndex).Text = "Facturas Abiertas" Then
                Dim numero As Integer = CInt(dgv_facturas_abiertas.CurrentRow.Cells(c_nro_factura_a.Index).Value)
                Dim vendedor As Integer = CInt(Lv_Id_Vendedor_3.Items.Item(Chb_Vendedor.SelectedIndex).SubItems(0).Text)
                UPD_CLI_FACT(numero, vendedor)
                dgv_facturas_abiertas.CurrentRow.Cells(c_vendedor_a.Index).Value = Chb_Vendedor.SelectedItem
                dgv_facturas_abiertas.Focus()
                dgv_facturas_abiertas.CurrentCell = dgv_facturas_abiertas.Rows(tapposition).Cells(0)
                coloreaVendedorActFactOpen()

            End If

            If Txt_Busqueda_Numero.Text.Length = 6 Then
                Txt_Busqueda_Numero.Text = Txt_Busqueda_Numero.Text.Substring(0, 3)
                Txt_Busqueda_Numero.Focus()
                Txt_Busqueda_Numero.SelectionStart = 3
            End If
        Catch ex As Exception
            If ex.ToString.Contains("NullReference") Then
                MsgBox("SELECCIONE UNA FACTURA")
            Else
                MsgBox(ex.ToString)
                Logger.e("Error con excepción", ex, New StackFrame(True))
            End If
        Finally
            If Txt_Busqueda_Numero.Text.Length = 6 Then
                Txt_Busqueda_Numero.Text = Txt_Busqueda_Numero.Text.Substring(0, 3)
                Txt_Busqueda_Numero.Focus()
                Txt_Busqueda_Numero.SelectionStart = 3
            End If
        End Try

    End Sub

    Private Sub CbVendedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Chb_Vendedor.SelectedIndexChanged

        Try
            If (tabactive = 0 And Dgv_facturas_cerradas.Rows.Count > 0) And
                (tapposition >= 0 And Dgv_facturas_cerradas.Rows.Count < tapposition) Then
                Dgv_facturas_cerradas.Focus()
                Dgv_facturas_cerradas.Rows(tapposition).Selected = True
            ElseIf (tabactive = 1 And dgv_facturas_abiertas.Rows.Count > 0) And
                (tapposition >= 0 And dgv_facturas_abiertas.Rows.Count < tapposition) Then
                dgv_facturas_abiertas.Focus()
                dgv_facturas_abiertas.Rows(tapposition).Selected = True
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Btn_Modificar_Cotizacion_5.Click

        Try
            vp_factura_id = CInt(dgv_cotizaciones.CurrentRow.Cells(0).Value)
            If dgv_cotizaciones.Rows.Count > 0 And vp_factura_id > 0 Then
                Fr_Crea_Cotizacion.Show()
                vp_factura_id = CInt(dgv_cotizaciones.CurrentRow.Cells(0).Value)
                vp_estado = "UPDATEOPEN"
                Me.Hide()
            End If
        Catch ex As Exception
            If ex.ToString.Contains("NullReference") Then
                MsgBox("SELECIONE UNA COTIZACION", MsgBoxStyle.Information, "ADVERTENCIA")
            Else
                Logger.e("Error con excepción", ex, New StackFrame(True))
                MsgBox(ex.ToString)
            End If

        End Try

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Btn_Crear_Cotizacion_5.Click

        Fr_Crea_Cotizacion.Show()
        vp_estado = "ADD"
        Fr_Crea_Cotizacion.Txt_Codigo_Cliente.Focus()
        Me.Hide()

    End Sub

    Private Sub txt_filtroCot_Enter(sender As Object, e As EventArgs) Handles Txt_Busqueda_Cotizacion_5.Enter

        If Txt_Busqueda_Cotizacion_5.Text = "BUSQUEDA POR CLIENTE" Then
            Txt_Busqueda_Cotizacion_5.Clear()
            Txt_Busqueda_Cotizacion_5.BackColor = Color.White
        End If

    End Sub

    Private Sub txt_filtroCot_Leave(sender As Object, e As EventArgs) Handles Txt_Busqueda_Cotizacion_5.Leave

        Txt_Busqueda_Cotizacion_5.Text = "BUSQUEDA POR CLIENTE"
        Txt_Busqueda_Cotizacion_5.BackColor = Color.Yellow

    End Sub

    Private Sub txt_filtroCot_KeyUp(sender As Object, e As KeyEventArgs) Handles Txt_Busqueda_Cotizacion_5.KeyUp

        If Txt_Busqueda_Cotizacion_5.Text.Length > 2 Then
            SEL_COT_BUSQ(Txt_Busqueda_Cotizacion_5.Text, dgv_cotizaciones)
        Else
            SEL_COTIZACION(dgv_cotizaciones)
        End If

    End Sub

    Private Sub btn_imp_cot_Click(sender As Object, e As EventArgs) Handles Btn_Imprimir_Cotizacion_5.Click

        Try
            Dim numero As Integer = CInt(dgv_cotizaciones.CurrentRow.Cells(0).Value)
            imprimirDatosCot(numero)
        Catch ex As Exception
            If ex.ToString.Contains("NullReference") Then
                MsgBox("SELECCIONE UNA COTIZACION")
            Else
                MsgBox(ex.ToString)
                Logger.e("Error con excepción", ex, New StackFrame(True))
            End If
        End Try

    End Sub

    Private Sub btn_convertir_Click(sender As Object, e As EventArgs) Handles Btn_Convertir_5.Click

        Try
            If dgv_cotizaciones.Rows.Count > 0 Then
                Fr_Crear_Facturas.Show()
                vp_estado = "COTIZACION A FACTURA"
                vp_factura_id = CInt(dgv_cotizaciones.CurrentRow.Cells(0).Value)
                Me.Hide()
            End If
        Catch ex As Exception
            If ex.ToString.Contains("NullReference") Then
                MsgBox("SELECCIONE UNA COTIZACION", MsgBoxStyle.Information, "ADVERTENCIA")
                Me.Visible = True
                Fr_Crear_Facturas.Close()
            Else
                Logger.e("Error con excepción", ex, New StackFrame(True))
                MsgBox(ex.ToString)
            End If
        End Try

    End Sub

    Private Sub btn_elimCot_Click(sender As Object, e As EventArgs) Handles Btn_Eliminar_Cotizacion_5.Click

        Dim numero As Integer = 0
        Try

            If dgv_cotizaciones.Rows.Count > 0 Then
                numero = CInt(dgv_cotizaciones.CurrentRow.Cells(0).Value)
                If MsgBox("BORRAR LA COTIZACION # " + numero.ToString, MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "CUIDADO") = MsgBoxResult.Yes Then
                    DEL_COT(numero)
                    rellenaCotizacion()
                End If
            End If
        Catch ex As Exception
            If ex.ToString.Contains("NullReference") Then
                MsgBox("Seleccione la cotización que desea borrar")
            Else
                MsgBox(ex.ToString)
                Logger.e("Error con excepción", ex, New StackFrame(True))
            End If
        End Try

    End Sub

    Private Sub btn_crearCotizacion_MouseEnter(sender As Object, e As EventArgs) Handles Btn_Crear_Cotizacion_5.MouseEnter

        Btn_Crear_Cotizacion_5.Image = My.Resources.InvoiceOn

    End Sub

    Private Sub btn_mod_cot_MouseEnter(sender As Object, e As EventArgs) Handles Btn_Modificar_Cotizacion_5.MouseEnter

        Btn_Modificar_Cotizacion_5.Image = My.Resources.ModificarOn

    End Sub

    Private Sub btn_mod_cot_MouseLeave(sender As Object, e As EventArgs) Handles Btn_Modificar_Cotizacion_5.MouseLeave

        Btn_Modificar_Cotizacion_5.Image = My.Resources.Modificarof

    End Sub

    Private Sub btn_imp_cot_MouseEnter(sender As Object, e As EventArgs) Handles Btn_Imprimir_Cotizacion_5.MouseEnter

        Btn_Imprimir_Cotizacion_5.Image = My.Resources.PrintOn

    End Sub

    Private Sub btn_imp_cot_MouseLeave(sender As Object, e As EventArgs) Handles Btn_Imprimir_Cotizacion_5.MouseLeave

        Btn_Imprimir_Cotizacion_5.Image = My.Resources.Print

    End Sub

    Private Sub btn_crearCotizacion_MouseLeave(sender As Object, e As EventArgs) Handles Btn_Crear_Cotizacion_5.MouseLeave

        Btn_Crear_Cotizacion_5.Image = My.Resources.InvoiceOff

    End Sub

    Private Sub btn_elimCot_MouseEnter(sender As Object, e As EventArgs) Handles Btn_Eliminar_Cotizacion_5.MouseEnter

        Btn_Eliminar_Cotizacion_5.Image = My.Resources.trashcanOn

    End Sub

    Private Sub btn_elimCot_MouseLeave(sender As Object, e As EventArgs) Handles Btn_Eliminar_Cotizacion_5.MouseLeave

        Btn_Eliminar_Cotizacion_5.Image = My.Resources.trashcan

    End Sub

    Private Sub btn_convertir_MouseEnter(sender As Object, e As EventArgs) Handles Btn_Convertir_5.MouseEnter

        Btn_Convertir_5.Image = My.Resources.convert1

    End Sub

    Private Sub btn_convertir_MouseLeave(sender As Object, e As EventArgs) Handles Btn_Convertir_5.MouseLeave

        Btn_Convertir_5.Image = My.Resources.convert2

    End Sub

    Private Sub Txt_Monto_4_Leave(sender As Object, e As EventArgs) Handles Txt_Monto_4.Leave

        Txt_Numero_Factura_4.Focus()

    End Sub

    Private Sub Fr_Facturas_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

        rellenarFacturasAbiertas()
        rellenarFacturasCerradas()

    End Sub

    Private Sub TabP_Facturas_Abiertas_DoubleClick(sender As Object, e As EventArgs) Handles TabP_Facturas_Abiertas.DoubleClick

        Try
            If facturas_seleccionadas = 0 Then
                For i = 0 To Me.dgv_facturas_abiertas.Rows.Count - 1
                    dgv_facturas_abiertas.Rows(i).Cells(c_cerrar_factura.Index).Value = True
                Next
            Else
                'SELECCIONA INVERSA DE LOS ITEMS
                For i = 0 To Me.dgv_facturas_abiertas.Rows.Count - 1
                    If dgv_facturas_abiertas.Rows(i).Cells(c_cerrar_factura.Index).Value = True Then
                        dgv_facturas_abiertas.Rows(i).Cells(c_cerrar_factura.Index).Value = False
                    Else
                        dgv_facturas_abiertas.Rows(i).Cells(c_cerrar_factura.Index).Value = True
                    End If
                Next
            End If
        Catch ex As Exception
            Logger.e("Error con excepción", ex, New StackFrame(True))
            MsgBox(ex.ToString, MsgBoxStyle.Information, "LV_FACTURAS_ABIERTAS_2.ITEMCHECKED")
        End Try

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        imprimir_con_fecha = True
        btnCerrarFac_Click(sender, New System.EventArgs())
        Lb_Mensaje.Visible = False

    End Sub

    Private Sub Txt_Busqueda_Nombre_Enter(sender As Object, e As EventArgs) Handles Txt_Busqueda_Nombre.Enter
        tapposition = -1
    End Sub

    Private Sub Txt_Busqueda_Numero_Enter(sender As Object, e As EventArgs) Handles Txt_Busqueda_Numero.Enter
        tapposition = -1
    End Sub

    Private Sub Txt_Numero_Factura_4_TextChanged(sender As Object, e As EventArgs) Handles Txt_Numero_Factura_4.TextChanged

    End Sub

    Private Sub btn_productos_Click(sender As Object, e As EventArgs) Handles btn_productos.Click
        Using historial_productos As New fr_historial_productos_vendidos
            historial_productos.StartPosition = FormStartPosition.CenterParent
            historial_productos.ShowDialog()
        End Using
    End Sub

    Private Sub Fr_Facturas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Fr_Inicio.Show()
        Me.Dispose()
    End Sub

    Private Sub Dgv_facturas_cerradas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_facturas_cerradas.CellClick
        tapposition = Dgv_facturas_cerradas.CurrentRow.Index
    End Sub

    Private Sub Dgv_facturas_cerradas_SelectionChanged(sender As Object, e As EventArgs) Handles Dgv_facturas_cerradas.SelectionChanged
        tapposition = Dgv_facturas_cerradas.CurrentRow.Index
    End Sub

    Private Sub Dgv_facturas_cerradas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_facturas_cerradas.CellDoubleClick
        If Not compruebaDupli() Then
            SEL_CLIENTE_COB(CInt(Dgv_facturas_cerradas.CurrentRow.Cells(c_nro_factura_c.Index).Value), Txt_Nombre_Cliente_4.Text, Txt_Monto_4.Text)
            Txt_Numero_Factura_4.Text = Dgv_facturas_cerradas.CurrentRow.Cells(c_nro_factura_c.Index).Value
            añadir()
        End If
        Using vista_previa As New Fr_vista_previa_factura(Dgv_facturas_cerradas.CurrentRow.Cells(c_id_cerrada_c.Index).Value,
                                                          Dgv_facturas_cerradas.CurrentRow.Cells("c_cliente_c").Value)
            vista_previa.StartPosition = FormStartPosition.CenterParent
            vista_previa.ShowDialog()
        End Using
    End Sub

    Private Sub dgv_facturas_abiertas_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgv_facturas_abiertas.CurrentCellDirtyStateChanged
        facturas_seleccionadas = 0
        Dim cuenta As Integer = 0

        Try
            'VALIDACION DE QUE EL OBJETO TIENE EL FOCO Y ES ACCESIBLE
            If dgv_facturas_abiertas.Rows.Count > 0 Then

                For i = 0 To dgv_facturas_abiertas.Rows.Count - 1
                    If dgv_facturas_abiertas.Rows(i).Cells(0).Value = True Then
                        facturas_seleccionadas += 1
                    End If
                Next

                If facturas_seleccionadas > 0 Then
                    Lb_Mensaje.Text = "FACTURAS SELECCIONADAS = " & facturas_seleccionadas
                    Lb_Mensaje.Visible = True
                Else
                    Lb_Mensaje.Visible = False
                End If
            End If

        Catch ex As Exception
            Logger.e("Error con excepción", ex, New StackFrame(True))
            MsgBox(ex.ToString, MsgBoxStyle.Information, "LV_FACTURAS_ABIERTAS_2.ITEMCHECKED")

        End Try
    End Sub

    Private Sub dgv_facturas_abiertas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_facturas_abiertas.CellClick

    End Sub

    Private Sub dgv_facturas_abiertas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_facturas_abiertas.CellContentClick
        dgv_facturas_abiertas.CurrentCell = dgv_facturas_abiertas.CurrentRow.Cells(1)
    End Sub

    Private Sub dgv_facturas_abiertas_Leave(sender As Object, e As EventArgs) Handles dgv_facturas_abiertas.Leave
        Try
            If Me.Visible Then

                If Dgv_facturas_cerradas.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0 And Tab_Opciones.TabPages(Me.Tab_Opciones.SelectedIndex).Text = "Facturas" Then
                    tapposition = Dgv_facturas_cerradas.CurrentRow.Index
                ElseIf dgv_facturas_abiertas.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0 And Tab_Opciones.TabPages(Me.Tab_Opciones.SelectedIndex).Text = "Facturas Abiertas" Then
                    tapposition = dgv_facturas_abiertas.CurrentRow.Index
                End If
            End If
        Catch ex As Exception
            Logger.e("Error con excepción", ex, New StackFrame(True))
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub Dgv_facturas_cerradas_Leave(sender As Object, e As EventArgs) Handles Dgv_facturas_cerradas.Leave

        Try
            If Me.Visible Then
                If Dgv_facturas_cerradas.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0 And Tab_Opciones.TabPages(Me.Tab_Opciones.SelectedIndex).Text = "Facturas" Then
                    tapposition = Dgv_facturas_cerradas.CurrentRow.Index
                ElseIf dgv_facturas_abiertas.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0 And Tab_Opciones.TabPages(Me.Tab_Opciones.SelectedIndex).Text = "Facturas Abiertas" Then
                    tapposition = dgv_facturas_abiertas.CurrentRow.Index
                End If
            End If
        Catch ex As Exception
            If ex.ToString.Contains("NullReference") Then
                MsgBox("SELECCIONE UNA FACTURA", MsgBoxStyle.Information, "FACTURA NO SELECIONADA")
            Else
                Logger.e("Error con excepción", ex, New StackFrame(True))
                MsgBox(ex.ToString)
            End If
        End Try

    End Sub

    Private Sub Lv_Detalle_Fact_X_Cobrar_4_SizeChanged(sender As Object, e As EventArgs) Handles Lv_Detalle_Fact_X_Cobrar_4.SizeChanged

    End Sub

    Private Sub Fr_Facturas_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        tamanno_listas_dgv_lv()
    End Sub

    Private Sub releaseObject(ByVal obj As Object)

        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    'Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    '    tiempo += 1
    '    lb_tiempo.Text = tiempo.ToString
    '    If tiempo = 300 Then
    '        tiempo = 0
    '        Dim pedidos_pendientes As Integer = 0
    '        SEL_CUENTA_PEDIDOS_PENDIENTES(pedidos_pendientes)
    '        If pedidos_pendientes > 0 Then
    '            SEL_PEDIDOS_ID(lista_pedidos_id)
    '            For i As Integer = 0 To lista_pedidos_id.Count - 1
    '                pedido_a_factura(lista_pedidos_id.Item(i))
    '                UPD_PEDIDO_PENDIENTE(lista_pedidos_id.Item(i))
    '                imprimirDatos(vp_fact_auto, "AMBAS", "IMPRESION AUTOMATICA", False)
    '                motivo_impresion = Nothing
    '            Next
    '            rellenarFacturasAbiertas()
    '            rellenarFacturasCerradas()
    '        End If
    '    End If

    'End Sub

    Private Sub pedido_a_factura(ByVal pedido_id As Integer)

        Dim cliente_id As Integer
        Dim fecha As New DateTimePicker
        Dim direccion_pedido As String = ""
        Dim total As Double
        Chb_Vendedor.SelectedItem = "CAJA"

        SEL_PEDIDO_DATOS(pedido_id, cliente_id, fecha, direccion_pedido, total)

        Dim artid As Integer = Nothing
        Dim artcan As Double = Nothing
        Dim artpre As Double = Nothing
        Dim artimp As Double = Nothing
        Dim subtotal As Double = Nothing
        Dim fechaArt As DateTime = Nothing

        If direccion_pedido.Length > 0 Then
            If direccion_pedido.Trim.Substring(0, 1) = "-" Then
                Chb_Vendedor.SelectedItem = "ABAJO"
            ElseIf direccion_pedido.Trim.Substring(0, 1) = "*" Then
                Chb_Vendedor.SelectedItem = "ARRIBA"
            Else
                Chb_Vendedor.SelectedItem = "CAJA"
            End If
        End If

        Try
            fecha.Value = fecha.Value.ToString("dd/MM/yyyy") + " " + fecha.Value.ToString("H:mm:ss")
            SEL_CONFIG_FACTURA_NUMERO(numero_factura)

            'INS_FACTURA_CERRADA(CInt(numero_factura), cliente_id, CInt(Lv_Id_Vendedor_3.Items.Item(Chb_Vendedor.SelectedIndex).SubItems(0).Text),
            '                                direccion_pedido, "", total, pie_pagina, CDbl(0), total,
            '                                fecha.Value, CDbl(0), total, False, _CedulaCliente, _TipoFactura, _MedioPago, )

            SEL_FACT_AUTO(CInt(numero_factura), vp_fact_auto, fecha.Value)
            Datos_Detalle_PEDIDO(pedido_id, dataGin)

            For Each item As DataGridViewRow In dataGin.Rows

                artid = CInt(item.Cells(6).Value)
                artcan = CDbl(item.Cells(2).Value)
                artpre = CDbl(item.Cells(3).Value)
                artimp = CDbl(item.Cells(4).Value)
                subtotal = CDbl(item.Cells(5).Value)
                fechaArt = item.Cells(7).Value

                If artid <> 0 Then
                    INS_FACT_DETALLE(vp_fact_auto, artid, artcan, artpre, artimp, subtotal, fechaArt)
                End If

            Next

            Dim fact_id_cambios = 0
            INS_CAMBIO_FACTURA(CInt(numero_factura), cliente_id, CInt(Lv_Id_Vendedor_3.Items.Item(Chb_Vendedor.SelectedIndex).SubItems(0).Text),
                                            direccion_pedido, "", total, pie_pagina, CDbl(0), total,
                                            fecha.Value, CDbl(0), CDbl(0), False, 0, vp_fact_auto)
            SEL_CAMBIO_FACT_AUTO(vp_fact_auto, fact_id_cambios, 0)
            For Each item As DataGridViewRow In dataGin.Rows

                artid = CInt(item.Cells(6).Value)
                artcan = CDbl(item.Cells(2).Value)
                artpre = CDbl(item.Cells(3).Value)
                artimp = CDbl(item.Cells(4).Value)
                subtotal = CDbl(item.Cells(5).Value)
                fechaArt = item.Cells(7).Value
                If artid <> 0 Then
                    INS_CAMBIO_FACT_DETALLE(fact_id_cambios, artid, artcan, artpre, artimp, subtotal, fechaArt)
                End If

            Next

            numero_factura = numero_factura + 1
            UPD_FACTURA_NUMERO(numero_factura)
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub

    Private Sub Button2_Click_2(sender As Object, e As EventArgs) Handles btn_revisar.Click
        tiempo = 298
    End Sub

    Private Sub btnTiquete_Click(sender As Object, e As EventArgs) Handles btnTiquete.Click
        FrTiquete.Show()
    End Sub

    Private Sub tamanno_listas_dgv_lv()
        Dgv_facturas_cerradas.Columns(2).Width = Dgv_facturas_cerradas.Size.Width - 483
        dgv_facturas_abiertas.Columns(3).Width = dgv_facturas_abiertas.Size.Width - 500
        dgv_cotizaciones.Columns(3).Width = dgv_cotizaciones.Size.Width - 420
        Lv_Detalle_Fact_X_Cobrar_4.Columns(1).Width = Lv_Detalle_Fact_X_Cobrar_4.Size.Width - 255

    End Sub

End Class