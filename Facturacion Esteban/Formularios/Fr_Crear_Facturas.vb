Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Text.RegularExpressions

Public Class Fr_Crear_Facturas

    'PRECIOS DEL PRODUCTO VS EL PRECIO OFRECIDO AL CLIENTE
    Dim precio_actual As String = Nothing
    Dim precio_antiguo As String = Nothing
    'BOOLEANO QUE IMPRIME POR DEFECTO EN IMPRESORA DE MATRIZ
    Dim imprime_matriz As Boolean = False
    'VARIABLE QUE GUARGA LA CANTIDAD DE NUMEROS EN EL TXT_PAGO PARA CALCULAR EL CAMBIO
    Dim ceros As Integer = 0
    'VARIALBES QUE GUARDAN EL TOTAL DE CAMBIOS, EL NUMERO DE CAMBIO EN QUE SE ENCUENTRA
    'Y LA ID DEL CAMBIO DE FACTURA
    Dim fact_modificada As Integer = 0
    Dim fact_actual As Integer = 0
    Dim fact_id_cambios As Integer = 0

    Private flag_celda_editada As Boolean = False

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
    Private _FechaVencimiento As String

    Dim _CedulaCliente As String
    Dim _MedioPago As String = "04"
    Dim _TipoFactura As String = "CONTADO"


    'MANTIENE EL PRODUCTO TEMPORAL QUE ESTABA EN EL GRIDVIEW AL INTENTAR MODIFICARLO EN
    'LOS CAMPOS DE TEXTO
    Private Sub producto_temporal(ByVal temp As Boolean)

        If temp Then

            vp_prod_id_temp = Txt_Codigo_Articulo.Text
            vp_prod_desc_temp = Txt_Descripcion_Articulo.Text
            vp_prod_precio_temp = Txt_Precio_Articulo.Text
            vp_prod_cant_temp = nudCantidad.Value
            vp_prod_imp_temp = Txt_Impuesto_Articulo.Text
            vp_prod_aut_temp = vp_art_auto
        Else

            vp_prod_id_temp = ""
            vp_prod_desc_temp = ""
            vp_prod_precio_temp = ""
            vp_prod_cant_temp = ""
            vp_prod_imp_temp = ""
            vp_prod_aut_temp = -1

        End If

    End Sub

    'Reproduce un sonido de advertencia
    Private Sub sonido_advertencia()

        Try
            Dim appPath As String = Application.StartupPath & "\Sound_error.wav"
            My.Computer.Audio.Play(appPath, AudioPlayMode.Background)
        Catch ex As Exception
            MsgBox("Archivo Sound_error no encontrado en la carpeta del programa " & ex.ToString)
        End Try
    End Sub

    'ABRIR CAJA
    Private Sub abrir_caja()

        StartPrint()
        If prn.PrinterIsOpen = True Then
            abrir_caja_termica()
            EndPrint()
        End If

        StartPrintMatriz()
        If prn_matriz.PrinterIsOpen = True Then
            abrir_caja_matriz()
            EndPrintMatriz()
        End If


    End Sub

    'CARGA EL PRODUCTO SELECCIONADO DEL LISTVIEW LVBUSQUEDA
    Public Sub seleccionaArticulo()

        If Not IsNothing(Lv_Busqueda_Articulos.FocusedItem) Then
            vp_art_auto = CInt(Lv_Busqueda_Articulos.Items(Lv_Busqueda_Articulos.FocusedItem.Index).Text)
            SEL_ARTICULOS_FAC(vp_art_auto, Txt_Codigo_Articulo.Text, Txt_Descripcion_Articulo.Text,
                              precio_actual, vp_precio2, vp_precio3, vp_preMayor, Txt_Impuesto_Articulo)
            If Txt_Codigo_Cliente.Text <> "" And Txt_Codigo_Cliente.Text <> "00" Then
                SEL_ARTICULOS_FAC_ANT(vp_art_auto, vp_cli_id, precio_antiguo)
                If precio_actual <> precio_antiguo And precio_antiguo > 0 And Txt_Descripcion_Articulo.Text <> "" Then
                    Txt_Precio_Articulo.BackColor = Color.Red
                    Txt_Precio_Articulo.ForeColor = Color.White
                    Txt_Precio_Articulo.Text = precio_antiguo
                Else
                    Txt_Precio_Articulo.BackColor = Color.White
                    Txt_Precio_Articulo.ForeColor = Color.Black
                    Txt_Precio_Articulo.Text = precio_actual
                End If
            Else
                Txt_Precio_Articulo.Text = precio_actual
                Txt_Precio_Articulo.BackColor = Color.White
                Txt_Precio_Articulo.ForeColor = Color.Black
            End If
            vp_precio1 = CDbl(Txt_Precio_Articulo.Text)
            calcular_sub()
            nudCantidad.Focus()
            Lv_Busqueda_Articulos.Visible = False

        End If

    End Sub

    'CARGA EL CLIENTE SELECCIONADO DEL LISTVIEW LV_CLIENTES
    Public Sub seleccionaCliente()

        Dim vendedor_nombre As String = ""
        If Not IsNothing(lv_BusquedaClientes.FocusedItem) Then

            Txt_Codigo_Cliente.Text = lv_BusquedaClientes.Items(lv_BusquedaClientes.FocusedItem.Index).Text

            SEL_CLIENTE_FACT(Txt_Codigo_Cliente.Text, vp_cli_id, DGV_Comentarios, vp_advertencia, vp_telefono, vp_ticket_matriz, vp_vendedor_auto, _CedulaCliente)
            Txt_Cedula.Text = _CedulaCliente
            SEL_CLI_OPEN(vp_cli_id, vp_factura_id)
            If vp_vendedor_auto <> Nothing Then
                SEL_NOMBRE_VENDEDOR(vp_vendedor_auto, vendedor_nombre)
                Cb_Vendedor.SelectedIndex = Cb_Vendedor.FindStringExact(vendedor_nombre)
            Else
                Cb_Vendedor.SelectedIndex = Cb_Vendedor.FindStringExact("CAJA")
            End If
            'If vp_factura_id > 0 Then
            '    If MsgBox("CARGAR FACTURA ABIERTA", MsgBoxStyle.YesNo, "INFORMACION") = MsgBoxResult.Yes Then
            '        cargar_factura_actual()
            '        vp_estado = "UPDATEOPEN"
            '        Lv_Clientes.Visible = False
            '        If chb_cantidad.Checked Then
            '            Txt_Cantidad_Articulo.Focus()
            '        ElseIf chb_barcode.Checked Then
            '            txt_barcode.Focus()
            '        Else
            '            Txt_Codigo_Articulo.Focus()
            '        End If
            '    End If
            'End If

            If chb_cantidad.Checked Then
                nudCantidad.Focus()
            ElseIf chb_barcode.Checked Then
                txt_barcode.Focus()
            Else
                Txt_Codigo_Articulo.Focus()
            End If
            Lv_Busqueda_Articulos.Visible = False

        End If

    End Sub


    'REDONDEA A ENTERO EL PRECIO Y LA CANTIDAD 
    Private Sub precioYsubt()

        If Txt_Precio_Articulo.Text = "" Then
            Txt_Precio_Articulo.Text = "0"
            Txt_Subtotal_Articulo.Text = "0"
            Txt_Precio_Articulo.SelectionLength() = 1
        End If

    End Sub


    'CALCULA EL PRECIO DEPENDIENDO DE LA CANTIDAD DE PRODUCTO COMPRADA
    Private Sub precio_x_cantidad()

        Try

            If nudCantidad.Text < 1 And nudCantidad.Text >= 0.5 Then
                Txt_Precio_Articulo.BackColor = Color.White
                Txt_Precio_Articulo.ForeColor = Color.Black
                Txt_Precio_Articulo.Text = vp_precio2.ToString
            ElseIf nudCantidad.Text < 0.5 And nudCantidad.Text >= 0 Then
                Txt_Precio_Articulo.BackColor = Color.White
                Txt_Precio_Articulo.ForeColor = Color.Black
                Txt_Precio_Articulo.Text = vp_precio3.ToString
            ElseIf nudCantidad.Text >= 1 Then
                If precio_actual <> Txt_Precio_Articulo.Text And precio_antiguo > 0 And Txt_Descripcion_Articulo.Text <> "" Then
                        Txt_Precio_Articulo.BackColor = Color.Red
                        Txt_Precio_Articulo.ForeColor = Color.White
                    End If
                End If



        Catch ex As Exception
            Logger.e("Error con excepción", ex, New StackFrame(True))
            MsgBox(ex.ToString)
        End Try
    End Sub

    'CALCULO DEL SUBTOTAL EN EL INGRESO DEL PRODUCTO
    Private Sub calcular_sub()

        If Txt_Precio_Articulo.Text.Substring(0, 1) = "." Then
            Txt_Precio_Articulo.Text = Txt_Precio_Articulo.Text.Substring(1, Txt_Precio_Articulo.Text.Length - 1)
        End If

        'VARIABLES  NECESARIAS PARA LAS OPERACIONES MATEMATICAS
        If Txt_Precio_Articulo.Text = "" Then
            Txt_Precio_Articulo.Text = "1"
        ElseIf Txt_Precio_Articulo.Text = "," Then
            Txt_Precio_Articulo.Text = "0,"
            Txt_Precio_Articulo.SelectionStart = Txt_Precio_Articulo.Text.Length
        End If
        Try
            calcular_subtotal(CDbl(Txt_Precio_Articulo.Text), CDbl(nudCantidad.Text),
                     CDbl(Txt_Impuesto_Articulo.Text), Txt_Subtotal_Articulo.Text, txt_ImpuestoProducto.Text)
        Catch ex As Exception
            Logger.e("Error con excepción", ex, New StackFrame(True))
            MsgBox(ex.ToString)
        End Try


    End Sub

    'CALCULO DEL TOTAL (PRECIO X PRODUCTO)
    Private Sub calcular(ByVal monto As String)

        'VARIABLES  NECESARIAS PARA LAS OPERACIONES MATEMATICAS
        Dim suma As Double = Nothing
        Dim sub_desuento As Double = Nothing
        Dim resultado As Double
        Dim sumalineas As Integer = 0
        Dim _SumaImpuesto As Double = 0
        Try
            For i As Integer = DGV_Facturas.Rows.Count - 1 To 0 Step -1
                If Me.DGV_Facturas.Rows(i).Cells(1).Value = Nothing Then
                    If Not (Me.DGV_Facturas.Rows(i).IsNewRow) Then
                        Me.DGV_Facturas.Rows.Remove(Me.DGV_Facturas.Rows(i))
                    End If
                End If
            Next

            'REALIZA LA SUMA DE EL TOTAL DE TODOS LOS PRODUCTOS
            For Each row As DataGridViewRow In Me.DGV_Facturas.Rows
                suma += (row.Cells(5).Value)
                _SumaImpuesto += (row.Cells(8).Value)
                sumalineas += 1
            Next

            suma = suma + _SumaImpuesto

            If Lb_Numero_Linea.Text.Contains("NORMAL...") Then
                Lb_Numero_Linea.Text = "ESTADO NORMAL... " + "TOTAL DE LINEAS " & sumalineas.ToString
            ElseIf Lb_Numero_Linea.Text.Contains("FACTURA") Then
                Lb_Numero_Linea.Text = "ACTUALIZA FACTURA: " + "TOTAL DE LINEAS " & sumalineas.ToString
            ElseIf Lb_Numero_Linea.Text.Contains("HISTORIAL") Then
                Lb_Numero_Linea.Text = "HISTORIAL DE CAMBIOS: " + "TOTAL DE LINEAS " & sumalineas.ToString
            End If

            'MUESTRA EL TOTAL Y SUBTOTAL EN SUS RESPECTIVOS CAMPOS SI NO HAY DESCUENTO
            Txt_Subtotal.Text = convertir_formato_miles_decimales(suma - _SumaImpuesto)
            If Txt_Descuento.Text = "0,00" Or Txt_Descuento.Text = "" Then
                Txt_Total.Text = convertir_formato_miles_decimales(suma)
            ElseIf Txt_Descuento.Text <> "0,00" And Txt_Descuento.Text <> "" Then
                resultado = (CDbl(Txt_Descuento.Text) / 100)
                sub_desuento = resultado * CDbl(Txt_Subtotal.Text)
                Txt_Descuento_Final.Text = convertir_formato_miles_decimales(sub_desuento)
                resultado = CDbl(Txt_Subtotal.Text) - (CDbl(Txt_Descuento_Final.Text)) + _SumaImpuesto
                Txt_Total.Text = convertir_formato_miles_decimales(resultado)
            End If
            txt_TotalImpuestos.Text = convertir_formato_miles_decimales(_SumaImpuesto)
            Txt_Pago.Text = Txt_Total.Text
            Txt_Cambio.Text = "0,00"

            If Txt_Total.Text = "0,00" Then
                DGV_Facturas.Rows.Add()
            End If

        Catch ex As Exception
            If ex.ToString.Contains("SetCurrentCellAddressCore") Then
            Else
                Logger.e("Error con excepción", ex, New StackFrame(True))
                MsgBox(ex.ToString)
            End If

        End Try

    End Sub

    'SE ENCARGA DE SELECCIONAR EL TIPO DE IMPRESORA A UTILIZAR
    Private Sub Imprimir_Factura(ByVal motivo As String)

        'SELECIONA EL TIPO DE IMPRESORA A UTILIZAR
        If imprime_matriz And usar_impresora_termica Then
            If usar_impresora_termica Then
                MsgBox("ENCIENDA LA IMPRESORA", MsgBoxStyle.Information, "ADVERTENCIA")
            End If
            imprimir_Matriz()
        Else
            If usar_impresora_termica = True And vp_ticket_matriz = False Then
                INS_HIST_PRINT(vp_fact_auto, DateTime.Now, 2, "AMBAS", motivo, "TERMICA")
                imprimir("ORIGINAL")
                imprimir("COPIA")
            Else
                If usar_impresora_termica Then
                    MsgBox("ENCIENDA LA IMPRESORA", MsgBoxStyle.Information, "ADVERTENCIA")
                End If
                INS_HIST_PRINT(vp_fact_auto, DateTime.Now, 1, "AMBAS", motivo, "MATRIZ")
                imprimir_Matriz()
            End If
        End If

    End Sub

    'SELECCONA UN CLIENTE DEL LISTVIEW
    Private Sub seleccionar_cliente(ByVal prioridad_lista As Boolean)

        Try
            'SI HAY UN CODIGO DE CLIENTE ESCRITO Y 
            'EN EL CAMPO NOMBRE ESTA VACIO SE REVISARA CON LA LISTA DE CLIENTES EN CASO DE HABER COINCIDENCIA
            If prioridad_lista Then
                Me.lv_BusquedaClientes.Focus()
                If lv_BusquedaClientes.Items.Count > 1 Then
                    lv_BusquedaClientes.TopItem.Selected = True
                End If
            Else
                If Txt_Codigo_Cliente.Text <> "" And DGV_Comentarios.Rows(0).Cells(0).Value = "" Then
                    If lv_BusquedaClientes.Visible Then
                        Me.lv_BusquedaClientes.Focus()
                        If lv_BusquedaClientes.Items.Count > 1 Then
                            lv_BusquedaClientes.TopItem.Selected = True
                        End If
                    Else
                        Txt_Codigo_Cliente.Focus()
                    End If
                ElseIf Txt_Codigo_Cliente.Text <> "" And DGV_Comentarios.Rows(0).Cells(0).Value <> "" Then
                    lv_BusquedaClientes.Visible = False
                    If vp_advertencia <> "" And vp_advertencia <> "ADVERTENCIA" Then
                        MsgBox(vp_advertencia, MsgBoxStyle.Information, "PRECAUCION")
                    End If
                    If chb_cantidad.Checked Then
                        nudCantidad.Focus()
                    ElseIf chb_barcode.Checked Then
                        txt_barcode.Focus()
                    Else
                        Txt_Codigo_Articulo.Focus()
                    End If
                End If
            End If

        Catch ex As Exception
            Logger.e("Error con excepción", ex, New StackFrame(True))
            MsgBox(ex.ToString)
        End Try

    End Sub

    'CARGA LAS VARIABLES DE INICO
    Private Sub inicio()

        'Inicio la Configuracion por parte del usuario

        limpia_variablesBD_Modulo()
        DGV_Facturas.FillEmptyArea = True
        Lb_Numero_Linea.Parent = cb_barcode
        Lb_Numero_Linea.Text = "ESTADO NORMAL..."
        Lb_Numero_Linea.Visible = True
        Lv_Busqueda_Articulos.Visible = False
        lv_BusquedaClientes.Visible = False
        Txt_Descripcion_Articulo.ReadOnly = True
        SEL_CONFIG_FACTURA(nombre_empresa, numero_factura, usar_impresora_termica, usar_precios_anteriores, cabecera_1,
                           cabecera_2, cabecera_3, cabecera_4, cabecera_5, cabecera_6, pie_pagina)
        Txt_Numero_Factura.Text = numero_factura
        SEL_VENDEDORES(Cb_Vendedor, Lv_Vendedor)
        Cb_Vendedor.SelectedItem = "CAJA"
        vp_ticket_matriz = False
        imprime_matriz = False

        DGV_Comentarios.Rows.Add()
        DGV_Comentarios.Rows.Add()
        DGV_Comentarios.Rows.Add()

        Me.DGV_Comentarios.Rows(0).Height = 17
        Me.DGV_Comentarios.Rows(1).Height = 17
        Me.DGV_Comentarios.Rows(2).Height = 17

        Me.DGV_Comentarios.Rows(0).Cells(0).Style.BackColor = Color.PaleGreen
        DGV_Comentarios.Rows(0).ReadOnly = True
        Me.DGV_Comentarios.CurrentCell = Nothing
        Txt_Subtotal.Text = "0,00"
        Txt_Subtotal_Articulo.Text = "0,00"
        Txt_Descuento.Text = "0,00"
        Txt_Descuento_Final.Text = "0,00"
        Txt_Total.Text = "0,00"
        nudCantidad.Value = "1"
        Txt_Precio_Articulo.Text = "0"

        cabeceraFactura(0) = cabecera_1
        cabeceraFactura(1) = cabecera_2
        cabeceraFactura(2) = cabecera_3
        cabeceraFactura(3) = cabecera_4
        cabeceraFactura(4) = cabecera_5
        cabeceraFactura(5) = cabecera_6

        precio_actual = "0"
        precio_antiguo = "0"

        fact_actual = 0
        fact_modificada = 0
        fact_id_cambios = 0

        Lb_Adelantar.Visible = False
        Lb_Retroceder.Visible = False
        'Header centrado
        DGV_Facturas.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGV_Facturas.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGV_Facturas.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGV_Facturas.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGV_Facturas.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        'Header en negrita
        DGV_Facturas.Columns(0).HeaderCell.Style.Font = New Font("Arial", 10, FontStyle.Regular)
        DGV_Facturas.Columns(1).HeaderCell.Style.Font = New Font("Arial", 10, FontStyle.Regular)
        DGV_Facturas.Columns(2).HeaderCell.Style.Font = New Font("Arial", 10, FontStyle.Regular)
        DGV_Facturas.Columns(3).HeaderCell.Style.Font = New Font("Arial", 10, FontStyle.Regular)
        DGV_Facturas.Columns(4).HeaderCell.Style.Font = New Font("Arial", 10, FontStyle.Regular)
        DGV_Facturas.Columns(5).HeaderCell.Style.Font = New Font("Arial", 10, FontStyle.Regular)

        Dtp_Fecha.Format = DateTimePickerFormat.Custom
        Dtp_Fecha.CustomFormat = "dd/MM/yyyy"

        DGV_Facturas.DefaultCellStyle.SelectionBackColor = Color.Aquamarine
        DGV_Facturas.DefaultCellStyle.SelectionForeColor = Color.Black

        nudDias.Value = 0

    End Sub

    'LIMPIA LAS VARIABLES DEL FORMULARIO
    Private Sub limpiaForm()

        vp_fact_auto = 0
        vp_precio1 = 0
        vp_precio2 = 0
        vp_precio3 = 0
        vp_preMayor = 0
        vp_art_auto = 0
        vp_cli_id = 0

        precio_actual = "0"
        precio_antiguo = "0"

        Txt_Descripcion_Articulo.ReadOnly = True
        Txt_Codigo_Cliente.Text = ""
        Txt_Descuento.Text = "0,00"
        Txt_Descuento_Final.Text = "0,00"
        Txt_Subtotal.Text = "0,00"
        Txt_Total.Text = "0,00"
        Txt_Precio_Articulo.Text = "0"
        nudCantidad.Value = "1"
        Txt_Impuesto_Articulo.Text = "0"
        Txt_Cambio.Text = "0"
        vp_estado = "ADD"
        vp_ticket_matriz = False
        imprime_matriz = False
        nud_numero_copias.Value = 1
        txtOems.Clear()

        For i As Integer = 0 To 2
            DGV_Comentarios.Rows(i).Cells(0).Value = ""
        Next
        DGV_Facturas.RowCount = 1
        DGV_Facturas.Rows.Clear()
        DGV_Facturas.Rows.Add()
        SEL_CONFIG_FACTURA_NUMERO(numero_factura)
        Txt_Numero_Factura.Text = numero_factura
        Txt_Pago.Text = "0,00"
        Txt_Codigo_Cliente.Focus()
        Txt_Descripcion_Articulo.ReadOnly = True

        Me.Text = "FACTURACION"
        Cb_Vendedor.Items.Clear()
        SEL_VENDEDORES(Cb_Vendedor, Lv_Vendedor)
        Cb_Vendedor.SelectedItem = "CAJA"
        Txt_Codigo_Cliente.BackColor = Color.White
        Fr_Facturas.rellenarFacturasAbiertas()
        Fr_Facturas.rellenarFacturasCerradas()
        vp_advertencia = ""
        Txt_Cedula.Clear()

        fact_actual = 0
        fact_modificada = 0
        fact_id_cambios = 0

        Lb_Retroceder.Visible = False
        Lb_Adelantar.Visible = False
        desbloqueo_controles()
        Lb_Numero_Linea.Text = "ESTADO NORMAL..."

        Dtp_Fecha.Format = DateTimePickerFormat.Custom
        Dtp_Fecha.CustomFormat = "dd/MM/yyyy"

    End Sub

    'LIMPIA LOS CAMPOS DE LOS ARTICULOS
    Private Sub limpiarArt()

        vp_precio1 = 0
        vp_precio2 = 0
        vp_precio3 = 0
        vp_preMayor = 0
        vp_art_auto = 0
        Txt_Codigo_Articulo.Clear()
        Txt_Descripcion_Articulo.Clear()
        nudCantidad.Value = "1"
        Txt_Impuesto_Articulo.Text = "0"
        Txt_Precio_Articulo.Text = "0"
        Txt_Subtotal_Articulo.Text = "0,00"
        Chb_Por_Mayor.Checked = False
        If chb_cantidad.Checked Then
            nudCantidad.Focus()
        ElseIf chb_barcode.Checked Then
            txt_barcode.Focus()
        Else
            Txt_Codigo_Articulo.Focus()
        End If
        txt_ImpuestoProducto.Text = "0"
        Txt_Precio_Articulo.BackColor = Color.White
        Txt_Precio_Articulo.ForeColor = Color.Black
        precio_actual = 0
        precio_antiguo = 0
        txt_barcode.Text = "BARCODE"
        If DGV_Facturas.Rows.Count > 0 Then
            Try
                DGV_Facturas.CurrentCell = DGV_Facturas.Rows(DGV_Facturas.RowCount - 1).Cells(0)
                DGV_Facturas.Rows(DGV_Facturas.RowCount - 1).Selected = True
            Catch ex As Exception

            End Try

        End If

    End Sub

    'LIMPIA LOS CAMPOS PARA MOSTRAR DATOS DE LAS FACTURAS ANTIGUAS
    Private Sub limpia_campos()

        Txt_Codigo_Cliente.Text = ""
        Txt_Descuento.Text = "0,00"
        Txt_Descuento_Final.Text = "0,00"
        Txt_Subtotal.Text = "0,00"
        Txt_Total.Text = "0,00"
        nudCantidad.Value = "1"
        Txt_Impuesto_Articulo.Text = "0"
        Txt_Cambio.Text = "0"
        Txt_Codigo_Articulo.Clear()
        Txt_Descripcion_Articulo.Clear()
        Txt_Precio_Articulo.Text = "0"
        Txt_Subtotal_Articulo.Text = "0,00"
        Chb_Por_Mayor.Checked = False
        Lv_Vendedor.Items.Clear()

        For i As Integer = 0 To 2
            DGV_Comentarios.Rows(i).Cells(0).Value = ""
        Next

        DGV_Facturas.RowCount = 1
        DGV_Facturas.Rows.Clear()
        Txt_Pago.Text = "0,00"
        Cb_Vendedor.Items.Clear()
        SEL_VENDEDORES(Cb_Vendedor, Lv_Vendedor)
        Txt_Cedula.Clear()

    End Sub

    'INGRESA LOS DATOS DE LA FACTURA ANTES DE QUE SE MODIFIQUE PARA GUARDARLA EN EL HISTORIAL
    Private Sub crea_historial(ByVal estado As Boolean)

        Try
            Dim artid As Integer = Nothing
            Dim artcan As Double = Nothing
            Dim artpre As Double = Nothing
            Dim artimp As Double = Nothing
            Dim subtotal As Double = Nothing
            Dim comet1 As String = DGV_Comentarios.Rows(1).Cells(0).Value
            Dim comet2 As String = DGV_Comentarios.Rows(2).Cells(0).Value
            Dim fechaArt As DateTime = Nothing
            Dim fecha_factura As DateTime = Now

            fecha_factura = fecha_factura.ToString("dd/MM/yyyy") + " " + Date.Now.ToString("H:mm:ss")
            fact_modificada += 1
            SEL_FACT_AUTO(CInt(Txt_Numero_Factura.Text), vp_fact_auto, Dtp_Fecha.Value)

            INS_CAMBIO_FACTURA(CInt(Txt_Numero_Factura.Text), vp_cli_id, CInt(Lv_Vendedor.Items.Item(Cb_Vendedor.SelectedIndex).SubItems(0).Text),
                                comet1, comet2, CDbl(Txt_Subtotal.Text), pie_pagina, CDbl(Txt_Descuento.Text), CDbl(Txt_Total.Text),
                                fecha_factura.ToString, CDbl(Txt_Impuesto_Articulo.Text), CDbl(Txt_Pago.Text), estado, fact_modificada, vp_fact_auto)
            SEL_CAMBIO_FACT_AUTO(vp_fact_auto, fact_id_cambios, fact_modificada)
            For Each item As DataGridViewRow In DGV_Facturas.Rows

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
        Catch ex As Exception
            Logger.e("Error con excepción", ex, New StackFrame(True))
            MsgBox(ex.ToString)
        End Try


    End Sub

    'CREA UNA FACTURA ABIERTA O CERRADA SEGUN SE NECESITE
    Private Sub crea_factura(ByVal estado_fact As Boolean, ByVal imprime_tiquet As Boolean)

        Dim artid As Integer = Nothing
        Dim artcan As Double = Nothing
        Dim artpre As Double = Nothing
        Dim artimp As Double = Nothing
        Dim subtotal As Double = Nothing
        Dim comet1 As String = DGV_Comentarios.Rows(1).Cells(0).Value
        Dim comet2 As String = DGV_Comentarios.Rows(2).Cells(0).Value
        Dim _Oems As String = txtOems.Text
        Dim fechaArt As DateTime = Nothing
        Dim _TiempoPlazo As Integer = nudDias.Value
        Dim DT_Fecha_Vencimiento As DateTime
        Dtp_Fecha.Value = Dtp_Fecha.Value.ToString("dd/MM/yyyy") + " " + Date.Now.ToString("HH:mm:ss")
        DT_Fecha_Vencimiento = Dtp_Fecha.Value.AddDays(nudDias.Value)
        Dim _FormatDate As String = "yyyy-MM-dd HH:mm:ss"
        Dim _FechaVencimiento As String = DT_Fecha_Vencimiento.ToString(_FormatDate)

        If cb_CondicionVenta.SelectedIndex = -1 Then
            MsgBox("Seleccione una condición de venta primero")
            Exit Sub
        End If

        'Si el numero de dias de credito es igual a 0 entonces la factura es a contado
        'y se cambia el estado de la factura
        If nudDias.Value = 0 Then
            estado_fact = False
        Else
            estado_fact = True
        End If

        Try
            If Txt_Descuento.Text = "" Then
                Txt_Descuento.Text = "0"
            End If
            Dim _Iva As Double = (txt_TotalImpuestos.Text)
            If vp_estado = "ADD" Then

                If Txt_Codigo_Cliente.Text = "" Or DGV_Comentarios.Rows(0).Cells(0).Value = "" Or vp_cli_id = 0 Then
                    MsgBox("Ingrese un CODIGO de Cliente valido!!", MsgBoxStyle.Critical, "ADVERTENCIA")
                    Txt_Codigo_Cliente.Clear()
                    Txt_Codigo_Cliente.Focus()
                ElseIf Txt_Codigo_Articulo.Text <> "" And Txt_Descripcion_Articulo.Text <> "" And Txt_Subtotal_Articulo.Text <> "" Then
                    MsgBox("Hay un articulo no ingresado", MsgBoxStyle.Information, "ADVERTENCIA")
                ElseIf DGV_Facturas.Rows.Count > 0 And DGV_Facturas.Rows(0).Cells(1).Value <> "" Then
                    Dtp_Fecha.Value = Dtp_Fecha.Value.ToString("dd/MM/yyyy") + " " + Date.Now.ToString("H:mm:ss")
                    DGV_Facturas.Sort(DGV_Facturas.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
                    SEL_CONFIG_FACTURA_NUMERO(numero_factura)
                    Txt_Numero_Factura.Text = numero_factura
                    INS_FACTURA_CERRADA(CInt(Txt_Numero_Factura.Text), vp_cli_id, CInt(Lv_Vendedor.Items.Item(Cb_Vendedor.SelectedIndex).SubItems(0).Text),
                                        comet1, comet2, CDbl(Txt_Subtotal.Text), pie_pagina, CDbl(Txt_Descuento.Text), CDbl(Txt_Total.Text),
                                        Dtp_Fecha.Value, CDbl(Txt_Impuesto_Articulo.Text), CDbl(Txt_Pago.Text), estado_fact,
                                        _CedulaCliente, _TipoFactura, _MedioPago, _FechaVencimiento, _Iva, _Oems)
                    SEL_FACT_AUTO(CInt(Txt_Numero_Factura.Text), vp_fact_auto, Dtp_Fecha.Value)
                    For Each item As DataGridViewRow In DGV_Facturas.Rows

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
                    crea_historial(estado_fact)
                    If imprime_tiquet Then
                        For i As Integer = 1 To nud_numero_copias.Value
                            Imprimir_Factura("FACTURA ORIGINAL")
                        Next
                    End If
                    numero_factura = numero_factura + 1
                    UPD_FACTURA_NUMERO(numero_factura)
                    My.Settings.Save()
                    Txt_Numero_Factura.Text = numero_factura
                    Dtp_Fecha.Value = Today
                    limpiaForm()

                End If

            ElseIf vp_estado = "UPDATE" Or vp_estado = "UPDATEOPEN" Then

                If Txt_Codigo_Cliente.Text = "" Then
                    MsgBox("Ingrese un Nombre de Cliente")
                    Txt_Codigo_Cliente.Focus()
                ElseIf Txt_Codigo_Articulo.Text <> "" And Txt_Descripcion_Articulo.Text <> "" And Txt_Subtotal_Articulo.Text <> "" Then
                    MsgBox("Hay un articulo no ingresado", MsgBoxStyle.Information, "ADVERTENCIA")
                ElseIf DGV_Facturas.Rows.Count > 0 Then
                    crea_historial(estado_fact)
                    UPD_FACT_CLOSED(CInt(Txt_Numero_Factura.Text), vp_cli_id, CInt(Lv_Vendedor.Items.Item(Cb_Vendedor.SelectedIndex).SubItems(0).Text),
                                            comet1, comet2, CDbl(Txt_Subtotal.Text), numero_factura,
                                             CDbl(Txt_Descuento.Text), CDbl(Txt_Total.Text), Dtp_Fecha.Value,
                                             CDbl(Txt_Impuesto_Articulo.Text), CDbl(Txt_Pago.Text), estado_fact, vp_fact_auto, _Oems)
                    DEL_ART_FACT(vp_fact_auto)
                    DGV_Facturas.Sort(DGV_Facturas.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
                    For Each item As DataGridViewRow In DGV_Facturas.Rows

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

                    If imprime_tiquet Then

                        Using pantalla_imprimir As New Fr_motivo_reimpresion
                            pantalla_imprimir.StartPosition = FormStartPosition.CenterScreen
                            pantalla_imprimir.ShowDialog()
                        End Using

                        If motivo_impresion = "Impresion cancelada" Then
                            MsgBox("La impresion fue cancelada")
                        Else
                            For i As Integer = 1 To nud_numero_copias.Value
                                Imprimir_Factura(motivo_impresion)
                                motivo_impresion = Nothing
                            Next
                        End If
                    End If
                    limpiaForm()
                    Dtp_Fecha.Value = Today
                    SEL_CONFIG_FACTURA_NUMERO(numero_factura)
                    Txt_Numero_Factura.Text = numero_factura

                End If
            End If

            producto_temporal(False)

        Catch ex As Exception
            Logger.e("Error con excepción", ex, New StackFrame(True))
            MsgBox(ex.ToString)
        End Try

    End Sub

    'CAMBIA EL COLOR DE LOS TEXTBOX PARA MOSTRAR UNA ADVERTENCIA
    Private Sub color_advertencia(ByVal modo As Boolean)

        If modo Then
            Txt_Codigo_Articulo.BackColor = Color.Red
            Txt_Descripcion_Articulo.BackColor = Color.Red
            nudCantidad.BackColor = Color.Red
            Txt_Precio_Articulo.BackColor = Color.Red
            Txt_Impuesto_Articulo.BackColor = Color.Red
            txt_barcode.BackColor = Color.Red

            Txt_Codigo_Articulo.ForeColor = Color.White
            Txt_Descripcion_Articulo.ForeColor = Color.White
            nudCantidad.ForeColor = Color.White
            Txt_Precio_Articulo.ForeColor = Color.White
            Txt_Impuesto_Articulo.ForeColor = Color.White
            txt_barcode.ForeColor = Color.White

        Else
            Txt_Codigo_Articulo.BackColor = Color.White
            Txt_Descripcion_Articulo.BackColor = Color.White
            nudCantidad.BackColor = Color.White
            Txt_Precio_Articulo.BackColor = Color.White
            Txt_Impuesto_Articulo.BackColor = Color.White
            txt_barcode.BackColor = Color.White

            Txt_Codigo_Articulo.ForeColor = Color.Black
            Txt_Descripcion_Articulo.ForeColor = Color.Black
            nudCantidad.ForeColor = Color.Black
            Txt_Precio_Articulo.ForeColor = Color.Black
            Txt_Impuesto_Articulo.ForeColor = Color.Black
            txt_barcode.ForeColor = Color.Black

        End If

    End Sub

    'CARGA LA FACTURA ACTUAL PARA MODIFICAR
    Private Sub cargar_factura_actual()

        limpia_campos()
        SEL_FACT_MOD(vp_factura_id, Txt_Codigo_Cliente.Text, DGV_Comentarios, Cb_Vendedor, Lv_Vendedor, Txt_Descuento.Text, Dtp_Fecha,
                      Txt_Numero_Factura.Text, Txt_Pago.Text, Txt_Subtotal.Text, Txt_Total.Text, Txt_Cambio.Text)
        SEL_FDET_MOD(vp_fact_auto, DGV_Facturas)
        SEL_CLIENTE_TICKET(Txt_Codigo_Cliente.Text, vp_ticket_matriz)
        Lb_Numero_Linea.Text = "ACTUALIZA FACTURA: "
        calcular(CDbl(Txt_Descuento.Text))
        Me.Text = "ACTUALIZACION DE FACTURA CLIENTE: " & DGV_Comentarios.Rows(0).Cells(0).Value
        Txt_Codigo_Cliente.BackColor = Color.Yellow

        'CONSULTA LA CANTIDAD DE VECES QUE A SIDO MODIFICADA LA FACTURA
        SEL_CAMBIOS_FACTURA(vp_fact_auto, fact_modificada)
        If fact_modificada > 1 Then
            Lb_Adelantar.Visible = True
            Lb_Retroceder.Visible = True
        End If
        DGV_Facturas.Columns(7).Visible = False
        DGV_Facturas.CurrentCell = DGV_Facturas.Rows(DGV_Facturas.RowCount - 1).Cells(0)
        DGV_Facturas.Rows(DGV_Facturas.RowCount - 1).Selected = True
        desbloqueo_controles()
        If chb_cantidad.Checked Then
            nudCantidad.Focus()
        ElseIf chb_barcode.Checked Then
            txt_barcode.Text = ""
            txt_barcode.Focus()
        Else
            Txt_Codigo_Articulo.Focus()
        End If
    End Sub

    'CARGA LAS FACTURAS QUE HAN SIDO MODIFICADAS
    Private Sub cargar_factura_antigua()

        limpia_campos()
        Dim dia As String = ""

        Dtp_Fecha.Value.ToString()
        Lb_Numero_Linea.Text = "HISTORIAL DE CAMBIOS: "
        SEL_FACT_CAMBIOS(vp_fact_auto, Txt_Codigo_Cliente.Text, DGV_Comentarios, Cb_Vendedor, Lv_Vendedor, Txt_Descuento.Text, Dtp_Fecha,
        Txt_Numero_Factura.Text, Txt_Pago.Text, Txt_Subtotal.Text, Txt_Total.Text, Txt_Cambio.Text, fact_actual, fact_id_cambios)
        SEL_FDET_CAMBIOS(fact_id_cambios, DGV_Facturas)
        DGV_Facturas.Sort(DGV_Facturas.Columns(7), System.ComponentModel.ListSortDirection.Ascending)
        calcular(CDbl(Txt_Descuento.Text))

        If Dtp_Fecha.Value.DayOfWeek = DayOfWeek.Monday Then
            dia = " LUNES "
        ElseIf Dtp_Fecha.Value.DayOfWeek = DayOfWeek.Tuesday Then
            dia = " MARTES "
        ElseIf Dtp_Fecha.Value.DayOfWeek = DayOfWeek.Wednesday Then
            dia = " MIERCOLES "
        ElseIf Dtp_Fecha.Value.DayOfWeek = DayOfWeek.Thursday Then
            dia = " JUEVES "
        ElseIf Dtp_Fecha.Value.DayOfWeek = DayOfWeek.Friday Then
            dia = " VIERNES "
        ElseIf Dtp_Fecha.Value.DayOfWeek = DayOfWeek.Saturday Then
            dia = " SABADO "
        ElseIf Dtp_Fecha.Value.DayOfWeek = DayOfWeek.Sunday Then
            dia = " DOMINGO "
        End If

        Me.Text = "Numero de Cambio de Factura: " & fact_actual & " --->" & dia & Dtp_Fecha.Value.ToString
        DGV_Facturas.Columns(7).Visible = True
        bloqueo_controles()

    End Sub

    'BLOQUEA CONTROLES DE CAMBIOS
    Private Sub bloqueo_controles()

        Txt_Codigo_Cliente.Enabled = False
        Txt_Codigo_Articulo.Enabled = False
        Txt_Cambio.Enabled = False
        nudCantidad.Enabled = False
        Txt_Descripcion_Articulo.Enabled = False
        Txt_Descuento.Enabled = False
        Txt_Descuento_Final.Enabled = False
        Txt_Cedula.Enabled = False
        Txt_Impuesto_Articulo.Enabled = False
        Txt_Numero_Factura.Enabled = False
        Txt_Pago.Enabled = False
        Txt_Precio_Articulo.Enabled = False
        Txt_Subtotal.Enabled = False
        Txt_Subtotal_Articulo.Enabled = False
        Txt_Total.Enabled = False
        DGV_Comentarios.Enabled = False
        Btn_Articulo_Nuevo.Enabled = False
        Btn_Añadir.Enabled = False
        Btn_Cliente.Enabled = False
        Btn_Eliminar.Enabled = False
        Btn_Historial.Enabled = False
        Btn_Imprimir.Enabled = False
        Btn_Solo_Guardar.Enabled = False
        Dtp_Fecha.Enabled = False
        Chb_Por_Mayor.Enabled = False

        For i As Integer = 0 To Me.DGV_Facturas.Rows.Count - 1
            DGV_Facturas.Rows(i).DefaultCellStyle.BackColor = Color.LightGray
        Next

    End Sub

    'DESBLOQUEA CONTROLES DE CAMBIOS
    Private Sub desbloqueo_controles()

        Txt_Codigo_Cliente.Enabled = True
        Txt_Codigo_Articulo.Enabled = True
        Txt_Cambio.Enabled = True
        nudCantidad.Enabled = True
        Txt_Descripcion_Articulo.Enabled = True
        Txt_Descuento.Enabled = True
        Txt_Descuento_Final.Enabled = True
        Txt_Cedula.Enabled = True
        Txt_Impuesto_Articulo.Enabled = True
        Txt_Numero_Factura.Enabled = True
        Txt_Pago.Enabled = True
        Txt_Precio_Articulo.Enabled = True
        Txt_Subtotal.Enabled = True
        Txt_Subtotal_Articulo.Enabled = True
        Txt_Total.Enabled = True
        DGV_Comentarios.Enabled = True
        DGV_Facturas.Enabled = True
        Btn_Articulo_Nuevo.Enabled = True
        Btn_Añadir.Enabled = True
        Btn_Cliente.Enabled = True
        Btn_Eliminar.Enabled = True
        Btn_Historial.Enabled = True
        Btn_Imprimir.Enabled = True
        Btn_Solo_Guardar.Enabled = True
        Dtp_Fecha.Enabled = True
        Chb_Por_Mayor.Enabled = True

        For i As Integer = 0 To Me.DGV_Facturas.Rows.Count - 2
            DGV_Facturas.Rows(i).DefaultCellStyle.BackColor = Color.White
        Next

    End Sub

    Private Sub CrearFacturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        inicio()

    End Sub

    Private Sub txtCodigoCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Codigo_Cliente.KeyDown

        If e.KeyData = Keys.Tab Then
            e.SuppressKeyPress = True
            seleccionar_cliente(False)
        ElseIf e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
        ElseIf e.KeyData = Keys.Add And lv_BusquedaClientes.Visible Then
            e.SuppressKeyPress = True
            seleccionar_cliente(True)
            lv_BusquedaClientes.Focus()
        ElseIf Txt_Codigo_Cliente.BackColor = Color.Yellow Then
            e.SuppressKeyPress = True
        End If

    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles Btn_Imprimir.Click

        crea_factura(False, True)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Btn_Eliminar.Click

        Try
            If DGV_Facturas.RowCount > 0 Then
                DGV_Facturas.Rows.RemoveAt(DGV_Facturas.CurrentRow.Index)
                calcular(Txt_Descuento.Text)
            End If

        Catch ex As Exception
            Logger.e("Error con excepción", ex, New StackFrame(True))
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub txtTotal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Total.KeyPress

        e.Handled = True

    End Sub


    Private Sub txtDesFinal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Descuento_Final.KeyPress

        e.Handled = True

    End Sub

    Private Sub LvBusqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Lv_Busqueda_Articulos.KeyPress

        Try
            If e.KeyChar = ChrW(Keys.Enter) Then
                seleccionaArticulo()
            ElseIf e.KeyChar = ChrW(Keys.Escape) Then
                'DataGridCell    cell = DataGridView1
                'Me.DGV_Facturas.ClearSelection()
                'Me.DGV_Facturas.Rows(0).Cells(0).Selected = True
                'Me.DGV_Facturas.BeginEdit(True)
                'DGV_Facturas.Focus()
                'DGV_Facturas.CurrentCell = Me.DGV_Facturas.Rows(Me.DGV_Facturas.CurrentRow.Index).Cells(0)
                'SendKeys.Send("{F2}")
                If chb_cantidad.Checked Then
                    nudCantidad.Focus()
                Else
                    Txt_Codigo_Articulo.Focus()
                End If

            End If
        Catch ex As Exception
            Logger.e("Error con excepción", ex, New StackFrame(True))
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub LvBusqueda_Leave(sender As Object, e As EventArgs) Handles Lv_Busqueda_Articulos.Leave

        Lv_Busqueda_Articulos.Visible = False

    End Sub


    Private Sub DGVComentaris_Leave(sender As Object, e As EventArgs) Handles DGV_Comentarios.Leave

        If chb_cantidad.Checked Then
            nudCantidad.Focus()
        ElseIf chb_barcode.Checked Then
            txt_barcode.Focus()
        Else
            Txt_Codigo_Articulo.Focus()
        End If

    End Sub

    'VALIDACION DE SOLO MAYUSCULAS EN EL DATAGRID COMENTARIOS
    Private Sub DGVComentaris_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DGV_Comentarios.EditingControlShowing

        If TypeOf e.Control Is TextBox Then
            DirectCast(e.Control, TextBox).CharacterCasing = CharacterCasing.Upper
        End If

    End Sub

    Private Sub txtCodigoCliente_KeyUp(sender As Object, e As KeyEventArgs) Handles Txt_Codigo_Cliente.KeyUp

        Dim vendedor_nombre As String = ""
        Dim filtro_clientes As String = ""
        If Txt_Codigo_Cliente.BackColor = Color.White Then
            Try
                lv_BusquedaClientes.Items.Clear()
                If Txt_Codigo_Cliente.Text.Trim <> "" Then
                    filtro_clientes = Regex.Replace(Txt_Codigo_Cliente.Text.Trim, "\s{2,}", " ")
                    filtro_clientes = filtro_clientes.Replace(" ", "%")
                    SEL_CLIENTE_FAC(filtro_clientes, filtro_clientes, lv_BusquedaClientes)
                    If lv_BusquedaClientes.Items.Count > 0 Then
                        lv_BusquedaClientes.Visible = True
                    ElseIf lv_BusquedaClientes.Items.Count < 1 Then
                        lv_BusquedaClientes.Visible = False
                    End If
                Else
                    lv_BusquedaClientes.Visible = False
                End If

                SEL_CLIENTE_FACT(filtro_clientes, vp_cli_id, DGV_Comentarios, vp_advertencia, vp_telefono, vp_ticket_matriz, vp_vendedor_auto, _CedulaCliente)
                SEL_CLI_OPEN(vp_cli_id, vp_factura_id)
                Txt_Cedula.Text = _CedulaCliente
                If vp_vendedor_auto <> Nothing Then
                    SEL_NOMBRE_VENDEDOR(vp_vendedor_auto, vendedor_nombre)
                    Cb_Vendedor.SelectedIndex = Cb_Vendedor.FindStringExact(vendedor_nombre)
                Else
                    Cb_Vendedor.SelectedIndex = Cb_Vendedor.FindStringExact("CAJA")
                End If

                'If vp_factura_id > 0 Then
                '    If MsgBox("CARGAR FACTURA ABIERTA", MsgBoxStyle.YesNo, "INFORMACION") = MsgBoxResult.Yes Then
                '        cargar_factura_actual()
                '        vp_estado = "UPDATEOPEN"
                '        Lv_Clientes.Visible = False
                '        If chb_cantidad.Checked Then
                '            Txt_Cantidad_Articulo.Focus()
                '        ElseIf chb_barcode.Checked Then
                '            txt_barcode.Focus()
                '        Else
                '            Txt_Codigo_Articulo.Focus()
                '        End If
                '    End If
                'End If

            Catch ex As Exception
                Logger.e("Error con excepción", ex, New StackFrame(True))
                MsgBox(ex.ToString())
            End Try
        End If

    End Sub

    Private Sub txtDesc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Descuento.KeyPress

        If Txt_Descuento.TextLength >= 0 Then
            NumerosyDecimal(Txt_Descuento, e)
        End If

    End Sub

    Private Sub LvBusqueda_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Lv_Busqueda_Articulos.PreviewKeyDown

        If e.KeyData = Keys.Tab Then
            e.IsInputKey = True
        End If

    End Sub

    Private Sub LvBusqueda_KeyDown(sender As Object, e As KeyEventArgs) Handles Lv_Busqueda_Articulos.KeyDown

        If e.KeyData = Keys.Tab Then
            e.Handled = True
        End If

    End Sub


    Private Sub txtDesc_Enter(sender As Object, e As EventArgs) Handles Txt_Descuento.Enter

        lv_BusquedaClientes.Visible = False
        Txt_Descuento.SelectAll()

    End Sub

    Private Sub txtDesc_MouseDown(sender As Object, e As MouseEventArgs) Handles Txt_Descuento.MouseDown

        Txt_Descuento.SelectAll()

    End Sub

    Private Sub txtDesc_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Txt_Descuento.PreviewKeyDown

        If Txt_Descuento.Text = "0,00" Then
            Txt_Descuento.Text = ""
        ElseIf e.KeyValue = Keys.F9 And Btn_Imprimir.Enabled Then
            btnImprimir_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.F5 And Btn_Imprimir.Enabled Then
            imprime_matriz = True
            btnImprimir_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.F1 Then
            abrir_caja()
        End If

        If e.Alt AndAlso e.KeyValue = Keys.H And DGV_Comentarios.Rows(0).Cells(0).Value <> "" Then
            btnHistorial_Click(sender, New EventArgs())
        End If

    End Sub

    Private Sub txtDesc_Leave(sender As Object, e As EventArgs) Handles Txt_Descuento.Leave

        Try
            If (Not String.IsNullOrEmpty(Txt_Descuento.Text)) Then
                Txt_Descuento.Text = convertir_formato_miles_decimales(CDbl(Txt_Descuento.Text))
            Else
                Txt_Descuento.Text = "0,00"
            End If
        Catch ex As Exception
            Logger.e("Error con excepción", ex, New StackFrame(True))
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub txtCodigoArt_KeyUp(sender As Object, e As KeyEventArgs) Handles Txt_Codigo_Articulo.KeyUp

        Try
            Lv_Busqueda_Articulos.Items.Clear()
            Dim busqueda As String
            If Txt_Codigo_Articulo.Text.Trim <> "" And Txt_Descripcion_Articulo.ReadOnly Then
                'LLENA LVBUSQUEDA CON LOS ULTIMOS PRODUCTOS COMPRADOS POR EL CLIENTE
                busqueda = Regex.Replace(Txt_Codigo_Articulo.Text.Trim, "\s{2,}", " ")
                busqueda = busqueda.Replace(" ", "%")
                If Txt_Codigo_Cliente.Text <> "00" And Txt_Codigo_Cliente.Text <> "" And usar_precios_anteriores Then
                    Lv_Busqueda_Articulos.ForeColor = Color.Purple
                    SEL_ART_CLIENTE_COD(busqueda, Lv_Busqueda_Articulos, vp_art_auto, vp_cli_id)
                    Lv_Busqueda_Articulos.ForeColor = Color.Black
                    For Each lvi As ListViewItem In Lv_Busqueda_Articulos.Items
                        lvi.ForeColor = Color.Purple
                    Next
                End If
                SEL_ARTICULO_COD(busqueda, Lv_Busqueda_Articulos, vp_art_auto)
                If Lv_Busqueda_Articulos.Items.Count > 0 And Txt_Codigo_Articulo.SelectedText.Length = 0 Then
                    Lv_Busqueda_Articulos.Visible = True
                ElseIf Lv_Busqueda_Articulos.Items.Count = 0 Then
                    Lv_Busqueda_Articulos.Visible = False
                End If
            Else
                Lv_Busqueda_Articulos.Visible = False
            End If
        Catch ex As Exception
            Logger.e("Error con excepción", ex, New StackFrame(True))
            ex.ToString()
        End Try

    End Sub

    Private Sub txtCodigoArt_Leave(sender As Object, e As EventArgs) Handles Txt_Codigo_Articulo.Leave

        Try
            If Txt_Codigo_Articulo.Text <> "" Then
                If Lv_Busqueda_Articulos.Visible Then
                    Me.Lv_Busqueda_Articulos.Focus()
                    If Lv_Busqueda_Articulos.Items.Count > 0 Then
                        Lv_Busqueda_Articulos.TopItem.Selected = True
                    End If
                ElseIf chb_barcode.Checked Then
                    txt_barcode.Focus()
                    Txt_Codigo_Articulo.Clear()
                End If
            ElseIf Txt_Codigo_Articulo.Text = "" And chb_cantidad.Checked Then
                nudCantidad.Focus()
            ElseIf Txt_Codigo_Articulo.Text.Trim = "" And Not Lv_Busqueda_Articulos.Visible And chb_barcode.Checked Then
                txt_barcode.Focus()
            End If

        Catch ex As Exception
            Logger.e("Error con excepción", ex, New StackFrame(True))
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub txtDescArt_KeyUp(sender As Object, e As KeyEventArgs) Handles Txt_Descripcion_Articulo.KeyUp

        Try
            If Txt_Codigo_Articulo.Text = "" And Not Txt_Descripcion_Articulo.ReadOnly Then
                Lv_Busqueda_Articulos.Items.Clear()
                If Txt_Descripcion_Articulo.Text <> "" Then
                    SEL_ARTICULO_NOM(Txt_Descripcion_Articulo.Text, Lv_Busqueda_Articulos)
                    If Lv_Busqueda_Articulos.Items.Count > 0 Then
                        Lv_Busqueda_Articulos.Visible = True
                    ElseIf Lv_Busqueda_Articulos.Items.Count = 0 Then
                        Lv_Busqueda_Articulos.Visible = False
                    End If
                Else
                    Lv_Busqueda_Articulos.Visible = False
                End If
            Else
                Lv_Busqueda_Articulos.Visible = False
            End If
        Catch ex As Exception
            Logger.e("Error con excepción", ex, New StackFrame(True))
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Precio_Articulo.KeyPress

        Try
            If e.KeyChar = "." And Not Txt_Precio_Articulo.Text.Contains(".") Then
                e.Handled = True
                Txt_Precio_Articulo.Text = Txt_Precio_Articulo.Text & "."
                Txt_Precio_Articulo.SelectionStart() = Txt_Precio_Articulo.Text.Length
            End If
            NumerosyDecimal(Txt_Precio_Articulo, e)
        Catch ex As Exception
            Logger.e("Error con excepción", ex, New StackFrame(True))
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub txtPrecio_Leave(sender As Object, e As EventArgs) Handles Txt_Precio_Articulo.Leave

        Try
            calcular_sub()
            'Btn_Añadir.Focus()
        Catch ex As Exception
            Logger.e("Error con excepción", ex, New StackFrame(True))
            MsgBox(ex.ToString)
        End Try

    End Sub


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Chb_Por_Mayor.CheckedChanged

        Try
            If Chb_Por_Mayor.Checked Then
                Txt_Precio_Articulo.Text = vp_preMayor.ToString
            Else
                Txt_Precio_Articulo.Text = vp_precio1.ToString
            End If
            calcular_sub()
        Catch ex As Exception
            Logger.e("Error con excepción", ex, New StackFrame(True))
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles Btn_Añadir.Click
        If Txt_Total.Text = "0,00" Then
            DGV_Facturas.Rows.Clear()
            DGV_Facturas.Rows.Add()
        End If

        Try
            If Txt_Codigo_Articulo.Text = "" Then
                MsgBox("INGRESE UN PRODUCTO", MsgBoxStyle.Critical, "ADVERTENCIA")
                Txt_Codigo_Articulo.Focus()
            ElseIf CDbl(Txt_Subtotal_Articulo.Text) <= 0 Then
                MsgBox("EL SUBTOTAL DEBE SER MAYOR A CERO", MsgBoxStyle.Critical, "ADVERTENCIA")
            ElseIf CDbl(Txt_Precio_Articulo.Text) <= 0 Then
                MsgBox("EL PRECIO DEBE SER MAYOR A CERO", MsgBoxStyle.Critical, "ADVERTENCIA")
            Else
                If Txt_Impuesto_Articulo.Text = "" Then
                    Txt_Impuesto_Articulo.Text = 0
                End If


                SEL_ART_FACTURA(vp_art_auto, DGV_Facturas, Txt_Descripcion_Articulo.Text,
                                nudCantidad.Value, Txt_Precio_Articulo.Text,
                                Txt_Subtotal_Articulo.Text, vp_art_auto.ToString, Txt_Impuesto_Articulo.Text,
                               txt_ImpuestoProducto.Text)

                calcular(Txt_Descuento.Text)
                limpiarArt()
                DGV_Facturas.CurrentCell = DGV_Facturas.Rows(DGV_Facturas.RowCount - 1).Cells(0)
                If chb_cantidad.Checked Then
                    nudCantidad.Focus()
                Else
                    Txt_Codigo_Articulo.Focus()
                End If
                producto_temporal(False)
                If chb_barcode.Checked Then
                    txt_barcode.Clear()
                    txt_barcode.Focus()
                End If
            End If
        Catch ex As Exception
            Logger.e("Error con excepción", ex, New StackFrame(True))
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub txtDesc_TextChanged(sender As Object, e As EventArgs) Handles Txt_Descuento.TextChanged

        Try
            If Txt_Descuento.Text <> "" Then
                calcular(CDbl(Txt_Descuento.Text))
            End If
        Catch ex As Exception
            Logger.e("Error con excepción", ex, New StackFrame(True))
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub txtImp_Leave(sender As Object, e As EventArgs) Handles Txt_Impuesto_Articulo.Leave

        If Txt_Impuesto_Articulo.Text = "" Then
            Txt_Impuesto_Articulo.Text = "0"
        End If
        Try
            calcular_sub()
            'Btn_Añadir.Focus()
        Catch ex As Exception
            Logger.e("Error con excepción", ex, New StackFrame(True))
            MsgBox(ex.ToString)
        End Try


    End Sub

    Private Sub txtPago_Leave(sender As Object, e As EventArgs) Handles Txt_Pago.Leave

        Try
            If Txt_Pago.Text <> "" Then
                If CDbl(Txt_Pago.Text) < 0 Then
                    MsgBox("PAGO INSUFICIENTE")
                    Txt_Pago.Focus()
                End If
            Else
                Txt_Pago.Text = Txt_Total.Text
                Txt_Cambio.ForeColor = Color.Black
                Txt_Cambio.Text = "0,00"
            End If

            Txt_Pago.Text = convertir_formato_miles_decimales(Txt_Pago.Text)

        Catch ex As Exception
            Logger.e("Error con excepción", ex, New StackFrame(True))
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub txtPago_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Pago.KeyPress

        NumerosyDecimal(Txt_Pago, e)

    End Sub

    Private Sub txtImp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Impuesto_Articulo.KeyPress

        If e.KeyChar = "." And Not Txt_Impuesto_Articulo.Text.Contains(",") Then
            e.Handled = True
            Txt_Impuesto_Articulo.Text = Txt_Impuesto_Articulo.Text & ","
            Txt_Impuesto_Articulo.SelectionStart() = Txt_Impuesto_Articulo.Text.Length
        End If
        NumerosyDecimal(Txt_Impuesto_Articulo, e)

    End Sub


    Private Sub btnAñadir_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Btn_Añadir.PreviewKeyDown

        If e.KeyData = Keys.Tab Then
            e.IsInputKey = True
        ElseIf e.KeyValue = Keys.F9 And Btn_Imprimir.Enabled Then
            btnImprimir_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.F5 And Btn_Imprimir.Enabled Then
            imprime_matriz = True
            btnImprimir_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.F1 Then
            abrir_caja()
        End If


        If e.Alt AndAlso e.KeyValue = Keys.H And DGV_Comentarios.Rows(0).Cells(0).Value <> "" Then
            btnHistorial_Click(sender, New EventArgs())
        End If

    End Sub

    Private Sub btnAñadir_KeyDown(sender As Object, e As KeyEventArgs) Handles Btn_Añadir.KeyDown

        If e.KeyData = Keys.Tab Then
            e.Handled = True
        End If

    End Sub

    Private Sub DGVFacturas_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Facturas.CellContentDoubleClick

        Try
            If Txt_Codigo_Articulo.Text = "" And Txt_Descripcion_Articulo.Text = "" And Txt_Codigo_Articulo.Enabled Then
                Txt_Codigo_Articulo.Text = DGV_Facturas.Item(0, DGV_Facturas.CurrentRow.Index).Value
                Txt_Descripcion_Articulo.Text = DGV_Facturas.Item(1, DGV_Facturas.CurrentRow.Index).Value

                If DGV_Facturas.Item(2, DGV_Facturas.CurrentRow.Index).Value.ToString.Contains(",00") Then
                    nudCantidad.Value = DGV_Facturas.Item(2, DGV_Facturas.CurrentRow.Index).Value.ToString.Substring(0, DGV_Facturas.Item(2, DGV_Facturas.CurrentRow.Index).Value.ToString.Length - 3)
                Else
                    nudCantidad.Value = DGV_Facturas.Item(2, DGV_Facturas.CurrentRow.Index).Value
                End If

                If DGV_Facturas.Item(3, DGV_Facturas.CurrentRow.Index).Value.ToString.Contains(",00") Then
                    Txt_Precio_Articulo.Text = DGV_Facturas.Item(3, DGV_Facturas.CurrentRow.Index).Value.ToString.Substring(0, DGV_Facturas.Item(3, DGV_Facturas.CurrentRow.Index).Value.ToString.Length - 3)
                    vp_precio1 = CDbl(Txt_Precio_Articulo.Text)
                    vp_precio2 = CDbl(Txt_Precio_Articulo.Text)
                    vp_precio3 = CDbl(Txt_Precio_Articulo.Text)
                Else
                    Txt_Precio_Articulo.Text = DGV_Facturas.Item(3, DGV_Facturas.CurrentRow.Index).Value
                    vp_precio1 = CDbl(Txt_Precio_Articulo.Text)
                    vp_precio2 = CDbl(Txt_Precio_Articulo.Text)
                    vp_precio3 = CDbl(Txt_Precio_Articulo.Text)
                End If

                Txt_Impuesto_Articulo.Text = DGV_Facturas.Item(4, DGV_Facturas.CurrentRow.Index).Value
                Txt_Subtotal_Articulo.Text = DGV_Facturas.Item(5, DGV_Facturas.CurrentRow.Index).Value
                vp_art_auto = CInt(DGV_Facturas.Item(6, DGV_Facturas.CurrentRow.Index).Value)
                DGV_Facturas.Rows.Remove(DGV_Facturas.Rows(DGV_Facturas.CurrentRow.Index))
                calcular_sub()
                calcular(Txt_Descuento.Text)
                nudCantidad.Focus()
                producto_temporal(True)
            Else
                If chb_cantidad.Checked Then
                    nudCantidad.Focus()
                ElseIf chb_barcode.Checked Then
                    txt_barcode.Focus()
                Else
                    Txt_Codigo_Articulo.Focus()
                End If
                vp_tiempo_contador = 1
                Timer1.Start()
            End If
        Catch ex As Exception
            If ex.ToString.Contains("SetCurrentCellAddressCore") Then
            Else
                Logger.e("Error con excepción", ex, New StackFrame(True))
                MsgBox(ex.ToString)
            End If

        End Try

    End Sub

    Private Sub txtPrecio_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Precio_Articulo.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            calcular_sub()
            btnAñadir_Click(sender, New System.EventArgs())
        End If

    End Sub

    Private Sub txtImp_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Impuesto_Articulo.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            If Txt_Impuesto_Articulo.Text = "" Then
                Txt_Impuesto_Articulo.Text = "0"
            End If
            calcular_sub()
            btnAñadir_Click(sender, New System.EventArgs())
        End If

    End Sub

    Private Sub btnHistorial_Click(sender As Object, e As EventArgs) Handles Btn_Historial.Click

        If vp_cli_id > 0 Then
            Using historial_form As New Fr_Compra_Cliente(vp_cli_id)
                historial_form.StartPosition = FormStartPosition.CenterParent
                historial_form.ShowDialog()
            End Using
        End If

    End Sub

    Private Sub btnCliente_Click(sender As Object, e As EventArgs) Handles Btn_Cliente.Click

        Fr_Clientes.Show()

    End Sub

    Private Sub btnArticulo_Click(sender As Object, e As EventArgs) Handles Btn_Articulo_Nuevo.Click

        Fr_Agregar_Inventario.Show()

    End Sub

    Private Sub imprimir(ByVal tipoFac As String)

        Dim comet1 As String = DGV_Comentarios.Rows(1).Cells(0).Value
        Dim comet2 As String = DGV_Comentarios.Rows(2).Cells(0).Value
        StartPrint()
        If prn.PrinterIsOpen = True Then
            PrintHeader(nombre_empresa, cabeceraFactura)
            PrintDetalles(Dtp_Fecha.Value, Txt_Numero_Factura.Text, DGV_Comentarios.Rows(0).Cells(0).Value.ToString,
                         Txt_Codigo_Cliente.Text, comet1, comet2, tipoFac, Txt_Cedula.Text)
            PrintBody(DGV_Facturas, Txt_Total.Text, Txt_Subtotal.Text, Txt_Descuento_Final.Text, Txt_Pago.Text, Txt_Cambio.Text)
            PrintFooter(pie_pagina)
            EndPrint()
        End If

    End Sub


    Private Sub imprimir_Matriz()

        Dim comet1 As String = DGV_Comentarios.Rows(1).Cells(0).Value
        Dim comet2 As String = DGV_Comentarios.Rows(2).Cells(0).Value
        StartPrintMatriz()
        If prn_matriz.PrinterIsOpen = True Then
            PrintHeaderMatriz(nombre_empresa, cabeceraFactura)
            PrintDetallesMatriz(Dtp_Fecha.Value, Txt_Numero_Factura.Text, DGV_Comentarios.Rows(0).Cells(0).Value.ToString,
                          Txt_Codigo_Cliente.Text, comet1, comet2, Txt_Cedula.Text)
            PrintBodyMatriz(DGV_Facturas, Txt_Total.Text, Txt_Subtotal.Text, Txt_Descuento_Final.Text, Txt_Pago.Text, Txt_Cambio.Text, txt_TotalImpuestos.Text)
            PrintFooterMatriz(pie_pagina)

            EndPrintMatriz()
        End If

    End Sub

    Private Sub txtCodigoArt_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Txt_Codigo_Articulo.PreviewKeyDown


        If e.Alt AndAlso e.KeyValue = Keys.H And DGV_Comentarios.Rows(0).Cells(0).Value <> "" Then
            btnHistorial_Click(sender, New EventArgs())
        End If

        If e.KeyValue = Keys.F9 And Btn_Imprimir.Enabled Then
            btnImprimir_Click(sender, New System.EventArgs())
            Txt_Codigo_Cliente.Focus()
        ElseIf e.KeyValue = Keys.F5 And Btn_Imprimir.Enabled Then
            imprime_matriz = True
            btnImprimir_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.Escape And vp_prod_id_temp <> "" Then
            vp_art_auto = vp_prod_aut_temp
            Txt_Codigo_Articulo.Text = vp_prod_id_temp
            Txt_Descripcion_Articulo.Text = vp_prod_desc_temp
        ElseIf e.KeyData = Keys.F2 Then
            DGV_Facturas.Columns(7).DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss"
            If DGV_Facturas.Columns(7).Visible Then
                DGV_Facturas.Columns(7).Visible = False
            Else
                DGV_Facturas.Columns(7).Visible = True
            End If
            tamanno_listas_dgv_lv()
        ElseIf e.KeyValue = Keys.F1 Then
            abrir_caja()
        End If

    End Sub

    Private Sub LvBusqueda_Enter(sender As Object, e As EventArgs) Handles Lv_Busqueda_Articulos.Enter

        Try
            If Lv_Busqueda_Articulos.Items.Count = 1 Then
                seleccionaArticulo()
            End If
        Catch ex As Exception
            Logger.e("Error con excepción", ex, New StackFrame(True))
        End Try

    End Sub

    Private Sub Button1_Click_3(sender As Object, e As EventArgs) Handles Btn_Solo_Guardar.Click

        crea_factura(False, False)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btn_Salir.Click


        Fr_Facturas.Show()
        Fr_Facturas.rellenarFacturasAbiertas()
        Fr_Facturas.rellenarFacturasCerradas()
        limpia_variablesBD_Modulo()
        Me.Close()

    End Sub

    Private Sub DGVComentaris_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles DGV_Comentarios.PreviewKeyDown

        If e.KeyValue = Keys.F9 And Btn_Imprimir.Enabled Then
            btnImprimir_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.F5 And Btn_Imprimir.Enabled Then
            imprime_matriz = True
            btnImprimir_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.F1 Then
            abrir_caja()
        End If

        If e.Alt AndAlso e.KeyValue = Keys.H And DGV_Comentarios.Rows(0).Cells(0).Value <> "" Then
            btnHistorial_Click(sender, New EventArgs())
        End If

    End Sub

    Private Sub CbVendedor_SelectedValueChanged(sender As Object, e As EventArgs) Handles Cb_Vendedor.SelectedValueChanged

    End Sub

    Private Sub DGVFacturas_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles DGV_Facturas.PreviewKeyDown

        If e.KeyValue = Keys.F9 And Btn_Imprimir.Enabled Then
            btnImprimir_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.F5 And Btn_Imprimir.Enabled Then
            imprime_matriz = True
            btnImprimir_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.F1 Then
            abrir_caja()
        End If

        If e.Alt AndAlso e.KeyValue = Keys.H And DGV_Comentarios.Rows(0).Cells(0).Value <> "" Then
            btnHistorial_Click(sender, New EventArgs())
        End If

    End Sub


    Private Sub txtPrecio_KeyUp(sender As Object, e As KeyEventArgs) Handles Txt_Precio_Articulo.KeyUp

        precioYsubt()
        calcular_sub()

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If vp_tiempo_contador = 1 Then
            sonido_advertencia()
        End If

        If vp_tiempo_contador Mod 2 > 0 And vp_tiempo_contador < 4 Then
            color_advertencia(True)
        ElseIf vp_tiempo_contador Mod 2 = 0 And vp_tiempo_contador < 4 Then
            color_advertencia(False)
        Else
            color_advertencia(False)
            txt_barcode.Clear()
            Timer1.Stop()
        End If
        vp_tiempo_contador += 1

    End Sub

    Private Sub btnCliente_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Btn_Cliente.PreviewKeyDown

        If e.KeyValue = Keys.F9 And Btn_Imprimir.Enabled Then
            btnImprimir_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.F5 And Btn_Imprimir.Enabled Then
            imprime_matriz = True
            btnImprimir_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.F1 Then
            abrir_caja()
        End If

        If e.Alt AndAlso e.KeyValue = Keys.H And DGV_Comentarios.Rows(0).Cells(0).Value <> "" Then
            btnHistorial_Click(sender, New EventArgs())
        End If

    End Sub

    Private Sub btnHistorial_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Btn_Historial.PreviewKeyDown

        If e.KeyValue = Keys.F9 And Btn_Imprimir.Enabled Then
            btnImprimir_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.F5 And Btn_Imprimir.Enabled Then
            imprime_matriz = True
            btnImprimir_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.F1 Then
            abrir_caja()
        End If

        If e.Alt AndAlso e.KeyValue = Keys.H And DGV_Comentarios.Rows(0).Cells(0).Value <> "" Then
            btnHistorial_Click(sender, New EventArgs())
        End If

    End Sub

    Private Sub btnArticulo_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Btn_Articulo_Nuevo.PreviewKeyDown

        If e.KeyValue = Keys.F9 And Btn_Imprimir.Enabled Then
            btnImprimir_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.F5 And Btn_Imprimir.Enabled Then
            imprime_matriz = True
            btnImprimir_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.F1 Then
            abrir_caja()
        End If

        If e.Alt AndAlso e.KeyValue = Keys.H And DGV_Comentarios.Rows(0).Cells(0).Value <> "" Then
            btnHistorial_Click(sender, New EventArgs())
        End If

    End Sub

    Private Sub CbVendedor_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Cb_Vendedor.PreviewKeyDown

        If e.KeyValue = Keys.F9 And Btn_Imprimir.Enabled Then
            btnImprimir_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.F5 And Btn_Imprimir.Enabled Then
            imprime_matriz = True
            btnImprimir_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.F1 Then
            abrir_caja()
        End If

        If e.Alt AndAlso e.KeyValue = Keys.H And DGV_Comentarios.Rows(0).Cells(0).Value <> "" Then
            btnHistorial_Click(sender, New EventArgs())
        End If

    End Sub

    Private Sub txtNumeroFactura_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Txt_Numero_Factura.PreviewKeyDown

        If e.KeyValue = Keys.F9 And Btn_Imprimir.Enabled Then
            btnImprimir_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.F5 And Btn_Imprimir.Enabled Then
            imprime_matriz = True
            btnImprimir_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.F1 Then
            abrir_caja()
        End If

        If e.Alt AndAlso e.KeyValue = Keys.H And DGV_Comentarios.Rows(0).Cells(0).Value <> "" Then
            btnHistorial_Click(sender, New EventArgs())
        End If

    End Sub

    Private Sub datep_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Dtp_Fecha.PreviewKeyDown

        If e.KeyValue = Keys.F9 And Btn_Imprimir.Enabled Then
            btnImprimir_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.F5 And Btn_Imprimir.Enabled Then
            imprime_matriz = True
            btnImprimir_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.F1 Then
            abrir_caja()
        End If

        If e.Alt AndAlso e.KeyValue = Keys.H And DGV_Comentarios.Rows(0).Cells(0).Value <> "" Then
            btnHistorial_Click(sender, New EventArgs())
        End If

    End Sub

    Private Sub CheckBox1_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Chb_Por_Mayor.PreviewKeyDown

        If e.KeyValue = Keys.F9 And Btn_Imprimir.Enabled Then
            btnImprimir_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.F5 And Btn_Imprimir.Enabled Then
            imprime_matriz = True
            btnImprimir_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.F1 Then
            abrir_caja()
        End If

        If e.Alt AndAlso e.KeyValue = Keys.H And DGV_Comentarios.Rows(0).Cells(0).Value <> "" Then
            btnHistorial_Click(sender, New EventArgs())
        End If

    End Sub

    Private Sub txtCant_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs)

        If e.KeyValue = Keys.F9 And Btn_Imprimir.Enabled Then
            btnImprimir_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.F5 And Btn_Imprimir.Enabled Then
            imprime_matriz = True
            btnImprimir_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.Escape And vp_prod_cant_temp <> "" Then
            nudCantidad.Value = vp_prod_cant_temp
        ElseIf e.KeyValue = Keys.F1 Then
            abrir_caja()
        End If

        If e.Alt AndAlso e.KeyValue = Keys.H And DGV_Comentarios.Rows(0).Cells(0).Value <> "" Then
            btnHistorial_Click(sender, New EventArgs())
        End If

    End Sub

    Private Sub txtPrecio_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Txt_Precio_Articulo.PreviewKeyDown

        Try
            If e.KeyValue = Keys.F9 And Btn_Imprimir.Enabled Then
                btnImprimir_Click(sender, New System.EventArgs())
            ElseIf e.KeyValue = Keys.F5 And Btn_Imprimir.Enabled Then
                imprime_matriz = True
                btnImprimir_Click(sender, New System.EventArgs())
            ElseIf e.KeyValue = Keys.Escape And vp_prod_precio_temp <> "" Then
                Txt_Precio_Articulo.Text = vp_prod_precio_temp
            ElseIf e.KeyValue = Keys.F1 Then
                abrir_caja()
            End If

            If e.Alt AndAlso e.KeyValue = Keys.H And DGV_Comentarios.Rows(0).Cells(0).Value <> "" Then
                btnHistorial_Click(sender, New EventArgs())
            End If
        Catch ex As Exception
            Logger.e("Error con excepción", ex, New StackFrame(True))
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub txtImp_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Txt_Impuesto_Articulo.PreviewKeyDown

        If e.KeyValue = Keys.F9 And Btn_Imprimir.Enabled Then
            btnImprimir_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.F5 And Btn_Imprimir.Enabled Then
            imprime_matriz = True
            btnImprimir_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.F1 Then
            abrir_caja()
        ElseIf e.KeyValue = Keys.Escape And vp_prod_imp_temp <> "" Then
            Txt_Impuesto_Articulo.Text = vp_prod_imp_temp
        End If

        If e.Alt AndAlso e.KeyValue = Keys.H And DGV_Comentarios.Rows(0).Cells(0).Value <> "" Then
            btnHistorial_Click(sender, New EventArgs())
        End If

    End Sub

    Private Sub txtSubt_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Txt_Subtotal_Articulo.PreviewKeyDown

        If e.KeyValue = Keys.F9 And Btn_Imprimir.Enabled Then
            btnImprimir_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.F5 And Btn_Imprimir.Enabled Then
            imprime_matriz = True
            btnImprimir_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.F1 Then
            abrir_caja()
        End If

        If e.Alt AndAlso e.KeyValue = Keys.H And DGV_Comentarios.Rows(0).Cells(0).Value <> "" Then
            btnHistorial_Click(sender, New EventArgs())
        End If

    End Sub

    Private Sub Button1_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Btn_Solo_Guardar.PreviewKeyDown

        If e.KeyValue = Keys.F9 And Btn_Imprimir.Enabled Then
            btnImprimir_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.F5 And Btn_Imprimir.Enabled Then
            imprime_matriz = True
            btnImprimir_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.F1 Then
            abrir_caja()
        End If

        If e.Alt AndAlso e.KeyValue = Keys.H And DGV_Comentarios.Rows(0).Cells(0).Value <> "" Then
            btnHistorial_Click(sender, New EventArgs())
        End If

    End Sub

    Private Sub TabPage1_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs)

        If e.KeyValue = Keys.F9 And Btn_Imprimir.Enabled Then
            btnImprimir_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.F5 And Btn_Imprimir.Enabled Then
            imprime_matriz = True
            btnImprimir_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.F1 Then
            abrir_caja()
        End If

        If e.Alt AndAlso e.KeyValue = Keys.H And DGV_Comentarios.Rows(0).Cells(0).Value <> "" Then
            btnHistorial_Click(sender, New EventArgs())
        End If

    End Sub

    Private Sub txtPago_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Txt_Pago.PreviewKeyDown

        If e.KeyValue = Keys.F9 And Btn_Imprimir.Enabled Then
            Try
                If Txt_Pago.Text <> "" Then
                    If CDbl(Txt_Pago.Text) < 0 Then
                        MsgBox("PAGO INSUFICIENTE")
                        Txt_Pago.Focus()
                    Else
                        Txt_Pago.Text = convertir_formato_miles_decimales(Txt_Pago.Text)
                        btnImprimir_Click(sender, New System.EventArgs())
                    End If
                Else
                    Txt_Pago.Text = Txt_Total.Text
                    Txt_Cambio.Text = "0,00"
                End If

            Catch ex As Exception
                Logger.e("Error con excepción", ex, New StackFrame(True))
                MsgBox(ex.ToString)
            End Try

        ElseIf e.KeyValue = Keys.F12 And Btn_Imprimir.Enabled Then
            Try
                If Txt_Pago.Text <> "" Then
                    If CDbl(Txt_Pago.Text) < 0 Then
                        MsgBox("PAGO INSUFICIENTE")
                        Txt_Pago.Focus()
                    End If
                Else
                    Txt_Pago.Text = Txt_Total.Text
                    Txt_Cambio.Text = "0,00"
                End If
            Catch ex As Exception
                Logger.e("Error con excepción", ex, New StackFrame(True))
                MsgBox(ex.ToString)
            End Try
        ElseIf e.KeyValue = Keys.F5 And Btn_Imprimir.Enabled Then
            Try
                If Txt_Pago.Text <> "" Then
                    If CDbl(Txt_Pago.Text) < 0 Then
                        MsgBox("PAGO INSUFICIENTE")
                        Txt_Pago.Focus()
                    Else
                        imprime_matriz = True
                        btnImprimir_Click(sender, New System.EventArgs())
                    End If
                Else
                    Txt_Pago.Text = Txt_Total.Text
                    Txt_Cambio.Text = "0,00"
                End If
            Catch ex As Exception
                Logger.e("Error con excepción", ex, New StackFrame(True))
                MsgBox(ex.ToString)
            End Try
        ElseIf e.KeyValue = Keys.F1 Then
            abrir_caja()
        End If

        If e.Alt AndAlso e.KeyValue = Keys.H And DGV_Comentarios.Rows(0).Cells(0).Value <> "" Then
            btnHistorial_Click(sender, New EventArgs())
        End If

    End Sub

    Private Sub txtCambio_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Txt_Cambio.PreviewKeyDown

        If e.KeyValue = Keys.F9 And Btn_Imprimir.Enabled Then
            btnImprimir_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.F5 And Btn_Imprimir.Enabled Then
            imprime_matriz = True
            btnImprimir_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.F1 Then
            abrir_caja()
        End If

        If e.Alt AndAlso e.KeyValue = Keys.H And DGV_Comentarios.Rows(0).Cells(0).Value <> "" Then
            btnHistorial_Click(sender, New EventArgs())
        End If

    End Sub

    Private Sub txtSub_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Txt_Subtotal.PreviewKeyDown

        If e.KeyValue = Keys.F9 And Btn_Imprimir.Enabled Then
            btnImprimir_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.F5 And Btn_Imprimir.Enabled Then
            imprime_matriz = True
            btnImprimir_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.F1 Then
            abrir_caja()
        End If

        If e.Alt AndAlso e.KeyValue = Keys.H And DGV_Comentarios.Rows(0).Cells(0).Value <> "" Then
            btnHistorial_Click(sender, New EventArgs())
        End If

    End Sub

    Private Sub txtDesFinal_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Txt_Descuento_Final.PreviewKeyDown

        If e.KeyValue = Keys.F9 And Btn_Imprimir.Enabled Then
            btnImprimir_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.F5 And Btn_Imprimir.Enabled Then
            imprime_matriz = True
            btnImprimir_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.F1 Then
            abrir_caja()
        End If

        If e.Alt AndAlso e.KeyValue = Keys.H And DGV_Comentarios.Rows(0).Cells(0).Value <> "" Then
            btnHistorial_Click(sender, New EventArgs())
        End If

    End Sub

    Private Sub txtTotal_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Txt_Total.PreviewKeyDown

        If e.KeyValue = Keys.F9 And Btn_Imprimir.Enabled Then
            btnImprimir_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.F5 And Btn_Imprimir.Enabled Then
            imprime_matriz = True
            btnImprimir_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.F1 Then
            abrir_caja()
        End If

        If e.Alt AndAlso e.KeyValue = Keys.H And DGV_Comentarios.Rows(0).Cells(0).Value <> "" Then
            btnHistorial_Click(sender, New EventArgs())
        End If

    End Sub

    Private Sub btnEliminar_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Btn_Eliminar.PreviewKeyDown

        If e.Alt AndAlso e.KeyValue = Keys.H And DGV_Comentarios.Rows(0).Cells(0).Value <> "" Then
            btnHistorial_Click(sender, New EventArgs())
        End If

        If e.KeyValue = Keys.F9 And Btn_Imprimir.Enabled Then
            btnImprimir_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.F5 And Btn_Imprimir.Enabled Then
            imprime_matriz = True
            btnImprimir_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.F1 Then
            abrir_caja()
        End If

    End Sub

    Private Sub Button2_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Btn_Salir.PreviewKeyDown

        If e.KeyValue = Keys.F9 And Btn_Imprimir.Enabled Then
            btnImprimir_Click(sender, New System.EventArgs())
        End If

        If e.Alt AndAlso e.KeyValue = Keys.H And DGV_Comentarios.Rows(0).Cells(0).Value <> "" Then
            btnHistorial_Click(sender, New EventArgs())
        End If

    End Sub

    Private Sub txtDescArt_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Txt_Descripcion_Articulo.PreviewKeyDown

        If e.Alt AndAlso e.KeyValue = Keys.H And DGV_Comentarios.Rows(0).Cells(0).Value <> "" Then
            btnHistorial_Click(sender, New EventArgs())
        End If

        If e.KeyValue = Keys.Escape And vp_prod_desc_temp <> "" Then

            Txt_Descripcion_Articulo.Text = vp_prod_desc_temp
            Txt_Codigo_Articulo.Text = vp_prod_id_temp
            vp_art_auto = vp_prod_aut_temp

        ElseIf e.KeyValue = Keys.Escape And Not Txt_Descripcion_Articulo.ReadOnly Then

            Lv_Busqueda_Articulos.Visible = False
            Txt_Descripcion_Articulo.Clear()
            Txt_Codigo_Articulo.Focus()

        End If

    End Sub


    Private Sub txtCodigoArt_Enter(sender As Object, e As EventArgs) Handles Txt_Codigo_Articulo.Enter

        lv_BusquedaClientes.Visible = False
        If DGV_Facturas.Rows.Count > 0 Then
            DGV_Facturas.CurrentCell = DGV_Facturas.Rows(DGV_Facturas.RowCount - 1).Cells(0)
            DGV_Facturas.Rows(DGV_Facturas.RowCount - 1).Selected = True
        End If

    End Sub

    Private Sub txtDescArt_Enter(sender As Object, e As EventArgs) Handles Txt_Descripcion_Articulo.Enter

        If Txt_Descripcion_Articulo.Text = "" Then
            If chb_cantidad.Checked Then
                nudCantidad.Focus()
            ElseIf chb_barcode.Checked Then
                txt_barcode.Focus()
            Else
                Txt_Codigo_Articulo.Focus()
            End If
        Else
            nudCantidad.Focus()
        End If


    End Sub


    Private Sub lv_Clientes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles lv_BusquedaClientes.KeyPress

        Try
            If e.KeyChar = ChrW(Keys.Enter) Then
                seleccionaCliente()
            ElseIf e.KeyChar = ChrW(Keys.Escape) And Txt_Codigo_Cliente.Text <> "" Then
                Txt_Codigo_Cliente.Focus()
            End If
        Catch ex As Exception
            Logger.e("Error con excepción", ex, New StackFrame(True))
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub lv_Clientes_Leave(sender As Object, e As EventArgs) Handles lv_BusquedaClientes.Leave

        lv_BusquedaClientes.Visible = False

    End Sub

    Private Sub lv_Clientes_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles lv_BusquedaClientes.PreviewKeyDown

        If e.KeyData = Keys.Tab Then
            e.IsInputKey = True
        End If

        If e.Alt AndAlso e.KeyValue = Keys.H And DGV_Comentarios.Rows(0).Cells(0).Value <> "" Then
            btnHistorial_Click(sender, New EventArgs())
        End If

    End Sub

    Private Sub lv_Clientes_KeyDown(sender As Object, e As KeyEventArgs) Handles lv_BusquedaClientes.KeyDown

        If e.KeyData = Keys.Tab Then
            e.Handled = True
        End If

    End Sub

    Private Sub lv_Clientes_Enter(sender As Object, e As EventArgs) Handles lv_BusquedaClientes.Enter

        Try
            If Lv_Busqueda_Articulos.Items.Count = 1 Then
                seleccionaCliente()
            End If
        Catch ex As Exception
            Logger.e("Error con excepción", ex, New StackFrame(True))
        End Try

    End Sub

    Private Sub txtCodigoCliente_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Txt_Codigo_Cliente.PreviewKeyDown

        If e.Alt AndAlso e.KeyValue = Keys.H And DGV_Comentarios.Rows(0).Cells(0).Value <> "" Then
            btnHistorial_Click(sender, New EventArgs())
        End If

        If e.KeyValue = Keys.F9 And Btn_Imprimir.Enabled Then
            btnImprimir_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.F5 And Btn_Imprimir.Enabled Then
            imprime_matriz = True
            btnImprimir_Click(sender, New System.EventArgs())
        ElseIf e.KeyData = Keys.Tab Then
            e.IsInputKey = True
        ElseIf e.KeyValue = Keys.F1 Then
            abrir_caja()
        End If

    End Sub

    Private Sub txtImp_KeyUp(sender As Object, e As KeyEventArgs) Handles Txt_Impuesto_Articulo.KeyUp

        Try
            If Txt_Impuesto_Articulo.Text = "," Then
                Txt_Impuesto_Articulo.Text = "0,"
                Txt_Impuesto_Articulo.SelectionStart = Txt_Impuesto_Articulo.Text.Length
            End If
            If Txt_Impuesto_Articulo.Text <> "" Then
                If CDbl(Txt_Impuesto_Articulo.Text) > 0 Then
                    calcular_sub()
                End If
            End If
        Catch ex As Exception
            Logger.e("Error con excepción", ex, New StackFrame(True))
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub txtPago_KeyUp(sender As Object, e As KeyEventArgs) Handles Txt_Pago.KeyUp


        If Txt_Pago.Text = "" Then
            Txt_Pago.Text = CStr(CDbl(Txt_Total.Text))
            Txt_Pago.SelectionLength() = Txt_Pago.Text.Length
        End If

        Txt_Cambio.Text = convertir_formato_miles_decimales(CStr(CDbl(Txt_Pago.Text) - CDbl(Txt_Total.Text)))
        ceros = Txt_Pago.Text.Length

        While CDbl(Txt_Cambio.Text) < 0
            Txt_Pago.Text += "0"
            Txt_Cambio.Text = convertir_formato_miles_decimales(CStr(CDbl(Txt_Pago.Text) - CDbl(Txt_Total.Text)))
        End While

        Txt_Pago.SelectionStart = ceros
        Txt_Pago.SelectionLength() = Txt_Pago.Text.Length - ceros

        If CDbl(Txt_Cambio.Text) < 0 Then
            Txt_Cambio.ForeColor = Color.Red
        Else
            Txt_Cambio.ForeColor = Color.Black
        End If

    End Sub

    Private Sub txtCambio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Cambio.KeyPress

        e.Handled = True

    End Sub

    Private Sub txtPago_Enter(sender As Object, e As EventArgs) Handles Txt_Pago.Enter

        lv_BusquedaClientes.Visible = False
        Txt_Pago.Text = CStr(CDbl(Txt_Pago.Text))
        Txt_Pago.SelectionLength() = Txt_Pago.Text.Length
        ceros = 0

    End Sub

    Private Sub txtPago_MouseUp(sender As Object, e As MouseEventArgs) Handles Txt_Pago.MouseUp

        Txt_Pago.SelectionStart = 0
        Txt_Pago.SelectionLength() = Txt_Pago.Text.Length

    End Sub

    Private Sub txtPrecio_MouseClick(sender As Object, e As MouseEventArgs) Handles Txt_Precio_Articulo.MouseClick

        Txt_Precio_Articulo.SelectionStart = 0
        Txt_Precio_Articulo.SelectionLength = Txt_Precio_Articulo.Text.Length

    End Sub

    Private Sub BtnNuevaF_Click(sender As Object, e As EventArgs) Handles Btn_Nueva_Factura.Click

        If vp_estado = "UPDATEOPEN" Then
            If MsgBox("NO SE GUARDARAN LOS CAMBIOS, DESEA CONTINUAR", MsgBoxStyle.YesNo, "CRITICO") = MsgBoxResult.Yes Then
                limpiaForm()
                limpiarArt()
            End If
        Else
            limpiaForm()
            limpiarArt()
            Txt_Codigo_Cliente.Focus()
        End If

    End Sub

    Private Sub txtCodigoCliente_DoubleClick(sender As Object, e As EventArgs) Handles Txt_Codigo_Cliente.DoubleClick

        If Txt_Codigo_Cliente.BackColor = Color.Yellow And vp_estado = "UPDATEOPEN" Then
            If MsgBox("DESEA CAMBIAR EL NOMBRE DE CLIENTE A LA FACTURA ABIERTA", MsgBoxStyle.YesNo, "CRITICO") = MsgBoxResult.Yes Then
                Txt_Codigo_Cliente.BackColor = Color.White
                Txt_Codigo_Cliente.Text = ""
            End If
        ElseIf Txt_Codigo_Cliente.BackColor = Color.Yellow And vp_estado = "UPDATE" Then
            If MsgBox("DESEA CAMBIAR EL NOMBRE DE CLIENTE A LA MODIFICACION DE ESTA FACTURA", MsgBoxStyle.YesNo, "CRITICO") = MsgBoxResult.Yes Then
                Txt_Codigo_Cliente.BackColor = Color.White
                Txt_Codigo_Cliente.Text = ""
            End If
        End If

    End Sub

    Private Sub CrearFacturas_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

        Txt_Codigo_Cliente.BackColor = Color.White
        chb_barcode.Checked = True
        If vp_estado = "UPDATEOPEN" Or vp_estado = "UPDATE" Then
            cargar_factura_actual()
        ElseIf vp_estado = "COTIZACION A FACTURA" Then
            SEL_COT_TO_FACT(vp_factura_id, Txt_Codigo_Cliente.Text, DGV_Comentarios, Cb_Vendedor, Lv_Vendedor, Txt_Descuento.Text,
                               Txt_Subtotal.Text, Txt_Total.Text, Txt_Descuento_Final.Text)
            SEL_CDET_MOD(vp_fact_auto, DGV_Facturas)
            SEL_CLIENTE_TICKET(Txt_Codigo_Cliente.Text, vp_ticket_matriz)
            vp_estado = "ADD"
            calcular(CDbl(Txt_Descuento.Text))
        Else
            Lb_Numero_Linea.Text = "ESTADO NORMAL..."
            Lb_Numero_Linea.Visible = True
            txt_barcode.Text = "BARCODE"
        End If

        DGV_Facturas.DefaultCellStyle.SelectionBackColor = Color.Aquamarine
        DGV_Facturas.DefaultCellStyle.SelectionForeColor = Color.Black
        tamanno_listas_dgv_lv()
    End Sub

    Private Sub Txt_Precio_Articulo_Enter(sender As Object, e As EventArgs) Handles Txt_Precio_Articulo.Enter

        lv_BusquedaClientes.Visible = False

    End Sub

    Private Sub Txt_Impuesto_Articulo_Enter(sender As Object, e As EventArgs) Handles Txt_Impuesto_Articulo.Enter

        lv_BusquedaClientes.Visible = False

    End Sub

    Private Sub Txt_Subtotal_Articulo_Enter(sender As Object, e As EventArgs) Handles Txt_Subtotal_Articulo.Enter

        lv_BusquedaClientes.Visible = False

    End Sub

    Private Sub txtCambio_Enter(sender As Object, e As EventArgs) Handles Txt_Cambio.Enter

        lv_BusquedaClientes.Visible = False

    End Sub

    Private Sub txtSub_Enter(sender As Object, e As EventArgs) Handles Txt_Subtotal.Enter

        lv_BusquedaClientes.Visible = False

    End Sub

    Private Sub txtDesFinal_Enter(sender As Object, e As EventArgs) Handles Txt_Descuento_Final.Enter

        lv_BusquedaClientes.Visible = False

    End Sub

    Private Sub txtTotal_Enter(sender As Object, e As EventArgs) Handles Txt_Total.Enter

        lv_BusquedaClientes.Visible = False

    End Sub

    Private Sub Btn_Atras_Click(sender As Object, e As EventArgs)

        If fact_actual = 0 Then
            fact_actual = fact_modificada
            cargar_factura_antigua()
            Lb_Numero_Linea.Text = Lb_Numero_Linea.Text
        ElseIf fact_actual = 1 Then
            fact_actual = 0
            cargar_factura_actual()
        Else
            fact_actual -= 1
            cargar_factura_antigua()
            Lb_Numero_Linea.Text = Lb_Numero_Linea.Text
        End If

    End Sub

    Private Sub Btn_adelante_Click(sender As Object, e As EventArgs)

        If fact_actual = fact_modificada Then
            fact_actual = 0
            cargar_factura_actual()
        Else
            fact_actual += 1
            cargar_factura_antigua()
            Lb_Numero_Linea.Text = Lb_Numero_Linea.Text
        End If


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Lb_Retroceder.Click

        If fact_actual = 0 Then
            fact_actual = fact_modificada
            cargar_factura_antigua()
            Lb_Numero_Linea.Text = Lb_Numero_Linea.Text
        ElseIf fact_actual = 1 Then
            fact_actual = 0
            cargar_factura_actual()
        Else
            fact_actual -= 1
            cargar_factura_antigua()
            Lb_Numero_Linea.Text = Lb_Numero_Linea.Text
        End If

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Lb_Adelantar.Click

        If fact_actual = fact_modificada Then
            fact_actual = 0
            cargar_factura_actual()
        Else
            fact_actual += 1
            cargar_factura_antigua()
            Lb_Numero_Linea.Text = Lb_Numero_Linea.Text
        End If

    End Sub

    Private WithEvents cellTextBox As DataGridViewTextBoxEditingControl

    Private Sub cellTextBox_KeyDown(
        ByVal sender As Object,
        ByVal e As System.Windows.Forms.KeyEventArgs) Handles cellTextBox.KeyDown

    End Sub

    Private Sub cellTextBox_KeyUp(
        ByVal sender As Object,
        ByVal e As System.Windows.Forms.KeyEventArgs) Handles cellTextBox.KeyUp

    End Sub


    Private Sub DataGridView1_EditingControlShowing(
                    ByVal sender As Object,
                    ByVal e As DataGridViewEditingControlShowingEventArgs) _
                    Handles DGV_Facturas.EditingControlShowing

        ' Este evento se producirá cuando la celda pasa a modo de edición.

        ' Referenciamos el control DataGridViewTextBoxEditingControl actual.
        '
        cellTextBox = TryCast(e.Control, DataGridViewTextBoxEditingControl)

        Dim tb As TextBox = TryCast(e.Control, TextBox)

        If (tb IsNot Nothing) Then

            RemoveHandler tb.KeyUp, AddressOf Tb_KeyUp
            AddHandler tb.KeyUp, AddressOf Tb_KeyUp

        End If
        ' Obtenemos el estilo de la celda actual
        '
        Dim style As DataGridViewCellStyle = e.CellStyle

        ' Mientras se edita la celda, aumentaremos la fuente
        ' y rellenaremos el color de fondo de la celda actual.
        '
        With style
            .Font = New Font(style.Font.FontFamily, 10, FontStyle.Bold)
            .ForeColor = Color.Blue
            .BackColor = Color.Beige
        End With

    End Sub


    Private Sub Tb_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub

    Private Sub cellTextBox_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles cellTextBox.KeyPress

        ' Referenciamos el control TextBox subyacente.
        '
        Dim tb As TextBox = TryCast(sender, TextBox)

        ' Si la conversión ha fallado, abandonamos el procedimiento.
        '
        If (tb Is Nothing) Then
            e.Handled = True
            Return
        End If
        If DGV_Facturas.IsCurrentCellInEditMode And (DGV_Facturas.CurrentCell.ColumnIndex = C_Precio.Index Or DGV_Facturas.CurrentCell.ColumnIndex = C_Cantidad.Index Or
           DGV_Facturas.CurrentCell.ColumnIndex = C_Impuesto.Index) Then

            Dim isDecimal, isSign, isValidChar As Boolean
            Dim decimalSeparator As String = Nothing

            Select Case e.KeyChar
                Case "."c, ","c
                    ' Obtenemos el carácter separador decimal existente
                    ' actualmente en la configuración regional de Windows. 
                    ' 
                    decimalSeparator = Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator

                    ' Hacemos que el carácter tecleado coincida con el
                    ' carácter separador existentente en la configuración
                    ' regional.
                    '
                    e.KeyChar = decimalSeparator.Chars(0)

                    ' Si el primer carácter que se teclea es el separador decimal,
                    ' o si bien, existe un signo en el primer carácter, envío la
                    ' combinación '0,'.
                    '
                    If (((tb.TextLength = 0) OrElse (tb.SelectionLength = tb.TextLength)) OrElse
                        ((tb.TextLength = 1) AndAlso ((tb.Text.Contains("-")) OrElse
                        (Text.Contains("+"))))) Then

                        ' NOTA: Envío la combinación "0," mediante el método Send,
                        ' para que en el código cliente se desencadenen los
                        ' eventos de teclado.
                        '
                        SendKeys.Send("{0}")
                        SendKeys.Send("{" & decimalSeparator & "}")
                        e.Handled = True
                        Return
                    End If

                    ' Es un carácter válido.
                    '
                    isDecimal = True
                    isValidChar = True

                Case "-"c, "+"c    ' Signos negativo y positivo
                    ' Es un carácter válido.
                    '
                    isSign = True
                    isValidChar = True

                Case Else
                    ' Sólo se admitirán números y la tecla de retroceso.
                    '
                    Dim isDigit As Boolean = Char.IsDigit(e.KeyChar)
                    Dim isControl As Boolean = Char.IsControl(e.KeyChar)

                    If ((isDigit) OrElse (isControl)) Then
                        isValidChar = True

                    Else
                        e.Handled = True
                        Return

                    End If

            End Select

            ' Si es un carácter válido, y el texto del control
            ' se encuentra totalmente seleccionado, elimino
            ' el valor actual del control.
            '
            If ((isValidChar) And (tb.SelectionLength = tb.TextLength)) Then
                tb.Text = String.Empty
            End If

            If (isSign) Then
                ' Admitimos los caracteres positivo y negativo, siempre y cuando
                ' sea el primer carácter del texto, y no exista ya ningún otro
                ' signo escrito en el control.
                '
                If ((tb.SelectionStart <> 0) OrElse
                    (tb.Text.IndexOf("-") >= 0) OrElse
                    (tb.Text.IndexOf("+") >= 0)) Then
                    e.Handled = True
                    Return
                End If
            End If

            If (isDecimal) Then
                ' Si en el control hay ya escrito un separador decimal, 
                ' deshechamos insertar otro separador más. 
                ' 
                If (tb.Text.IndexOf(decimalSeparator) >= 0) Then
                    e.Handled = True
                End If
            End If

        End If


    End Sub

    Private Sub DGV_Facturas_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Facturas.CellEndEdit

        flag_celda_editada = True
        'Comprueba los valores de la columna precio
        If DGV_Facturas.CurrentCell.ColumnIndex = C_Precio.Index Then

            If DGV_Facturas.CurrentRow.Cells("C_Descripcion").Value Is Nothing Then
                DGV_Facturas.CurrentCell.Value = ""
            ElseIf DGV_Facturas.CurrentCell.Value Is Nothing And DGV_Facturas.CurrentRow.Cells("C_Descripcion").Value <> "" Then
                DGV_Facturas.CurrentCell.Value = convertir_formato_miles_decimales("0")
                calcular_subtotal(DGV_Facturas.Rows(e.RowIndex).Cells("C_Precio").Value, DGV_Facturas.Rows(e.RowIndex).Cells("C_Cantidad").Value,
                                DGV_Facturas.Rows(e.RowIndex).Cells("C_Impuesto").Value, DGV_Facturas.Rows(e.RowIndex).Cells("C_Total").Value,
                                  DGV_Facturas.Rows(e.RowIndex).Cells(8).Value)
            Else
                DGV_Facturas.CurrentCell.Value = convertir_formato_miles_decimales(DGV_Facturas.CurrentCell.Value)
                calcular_subtotal(DGV_Facturas.Rows(e.RowIndex).Cells("C_Precio").Value, DGV_Facturas.Rows(e.RowIndex).Cells("C_Cantidad").Value,
                                DGV_Facturas.Rows(e.RowIndex).Cells("C_Impuesto").Value, DGV_Facturas.Rows(e.RowIndex).Cells("C_Total").Value,
                                  DGV_Facturas.Rows(e.RowIndex).Cells(8).Value)

            End If

            calcular(Txt_Descuento.Text)

            'Comprueba los valores de la columna cantidad
        ElseIf DGV_Facturas.CurrentCell.ColumnIndex = C_Cantidad.Index Then


            If DGV_Facturas.CurrentRow.Cells("C_Descripcion").Value Is Nothing Then
                DGV_Facturas.CurrentCell.Value = ""
            ElseIf DGV_Facturas.CurrentCell.Value Is Nothing And DGV_Facturas.CurrentRow.Cells("C_Descripcion").Value <> "" Then
                DGV_Facturas.CurrentCell.Value = convertir_formato_miles_decimales("0")
                calcular_subtotal(DGV_Facturas.Rows(e.RowIndex).Cells("C_Precio").Value, DGV_Facturas.Rows(e.RowIndex).Cells("C_Cantidad").Value,
                                DGV_Facturas.Rows(e.RowIndex).Cells("C_Impuesto").Value, DGV_Facturas.Rows(e.RowIndex).Cells("C_Total").Value,
                                  DGV_Facturas.Rows(e.RowIndex).Cells(8).Value)
            Else
                DGV_Facturas.CurrentCell.Value = convertir_formato_miles_decimales(DGV_Facturas.CurrentCell.Value)
                calcular_subtotal(DGV_Facturas.Rows(e.RowIndex).Cells("C_Precio").Value, DGV_Facturas.Rows(e.RowIndex).Cells("C_Cantidad").Value,
                                DGV_Facturas.Rows(e.RowIndex).Cells("C_Impuesto").Value, DGV_Facturas.Rows(e.RowIndex).Cells("C_Total").Value,
                                  DGV_Facturas.Rows(e.RowIndex).Cells(8).Value)
            End If
            calcular(Txt_Descuento.Text)

            'Comprueba los valores de la columna impuesto
        ElseIf DGV_Facturas.CurrentCell.ColumnIndex = C_Impuesto.Index Then

            If DGV_Facturas.CurrentRow.Cells("C_Descripcion").Value Is Nothing Then
                DGV_Facturas.CurrentCell.Value = ""
            ElseIf DGV_Facturas.CurrentCell.Value Is Nothing And DGV_Facturas.CurrentRow.Cells("C_Descripcion").Value <> "" Then
                DGV_Facturas.CurrentCell.Value = convertir_formato_miles_decimales("0")
                calcular_subtotal(DGV_Facturas.Rows(e.RowIndex).Cells("C_Precio").Value, DGV_Facturas.Rows(e.RowIndex).Cells("C_Cantidad").Value,
                                DGV_Facturas.Rows(e.RowIndex).Cells("C_Impuesto").Value, DGV_Facturas.Rows(e.RowIndex).Cells("C_Total").Value,
                                  DGV_Facturas.Rows(e.RowIndex).Cells(8).Value)
            Else
                DGV_Facturas.CurrentCell.Value = convertir_formato_miles_decimales(DGV_Facturas.CurrentCell.Value)
                calcular_subtotal(DGV_Facturas.Rows(e.RowIndex).Cells("C_Precio").Value, DGV_Facturas.Rows(e.RowIndex).Cells("C_Cantidad").Value,
                                DGV_Facturas.Rows(e.RowIndex).Cells("C_Impuesto").Value, DGV_Facturas.Rows(e.RowIndex).Cells("C_Total").Value,
                                  DGV_Facturas.Rows(e.RowIndex).Cells(8).Value)
            End If
            calcular(Txt_Descuento.Text)

        ElseIf Lv_Busqueda_Articulos.Visible Then
            Me.Lv_Busqueda_Articulos.Focus()
            If Lv_Busqueda_Articulos.Items.Count > 0 Then
                Lv_Busqueda_Articulos.TopItem.Selected = True
            End If
        End If

    End Sub

    Private Sub chb_cantidad_CheckedChanged(sender As Object, e As EventArgs) Handles chb_cantidad.CheckedChanged

        If chb_cantidad.Checked Then
            nudCantidad.Focus()
        Else
            Txt_Codigo_Articulo.Focus()
        End If
    End Sub

    Private Sub Txt_Direccion_Enter(sender As Object, e As EventArgs) Handles Txt_Cedula.Enter

        lv_BusquedaClientes.Visible = False
        If cb_CondicionVenta.SelectedIndex = -1 Then
            MsgBox("Seleccione una condicion de venta")
        End If

    End Sub

    Private Sub Txt_Direccion_Leave(sender As Object, e As EventArgs) Handles Txt_Cedula.Leave
        If chb_barcode.Checked Then
            txt_barcode.Focus()
        Else
            Txt_Codigo_Articulo.Select()
        End If
    End Sub

    Private Sub Txt_Direccion_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Txt_Cedula.PreviewKeyDown
        If e.KeyValue = Keys.F1 Then
            abrir_caja()
        End If
    End Sub

    Private Sub Fr_Crear_Facturas_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        Fr_Facturas.Show()
        Fr_Facturas.rellenarFacturasAbiertas()
        Fr_Facturas.rellenarFacturasCerradas()
        limpia_variablesBD_Modulo()

    End Sub

    Private Sub txt_barcode_Enter(sender As Object, e As EventArgs) Handles txt_barcode.Enter

        limpiarArt()
        txt_barcode.Clear()

    End Sub

    Private Sub txt_barcode_Leave(sender As Object, e As EventArgs) Handles txt_barcode.Leave
        If Txt_Descripcion_Articulo.Text = "" Then
            txt_barcode.Text = "BARCODE"
        End If
    End Sub

    Private Sub Txt_Codigo_Cliente_Leave(sender As Object, e As EventArgs) Handles Txt_Codigo_Cliente.Leave
        If Txt_Codigo_Cliente.Text.Trim = "00" And Txt_Codigo_Cliente.BackColor <> Color.Yellow Then
            Txt_Cedula.Select()
        End If
    End Sub

    Private Sub chb_barcode_CheckedChanged(sender As Object, e As EventArgs) Handles chb_barcode.CheckedChanged
        If chb_barcode.Checked Then
            txt_barcode.Clear()
            If DGV_Comentarios.Rows(0).Cells(0).Value = "" Then
                Txt_Codigo_Cliente.Select()
            Else
                txt_barcode.Focus()
            End If
        Else
            txt_barcode.Text = "BARCODE"
            If DGV_Comentarios.Rows(0).Cells(0).Value = "" Then
                Txt_Codigo_Cliente.Select()
            Else
                Txt_Codigo_Articulo.Select()
            End If
        End If
    End Sub

    Private Sub txt_barcode_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles txt_barcode.PreviewKeyDown

        If e.Alt AndAlso e.KeyValue = Keys.H And DGV_Comentarios.Rows(0).Cells(0).Value <> "" Then
            btnHistorial_Click(sender, New EventArgs())
        End If

        If e.KeyValue = Keys.F9 And Btn_Imprimir.Enabled Then
            btnImprimir_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.F5 And Btn_Imprimir.Enabled Then
            imprime_matriz = True
            btnImprimir_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.Escape And vp_prod_id_temp <> "" Then
            vp_art_auto = vp_prod_aut_temp
            Txt_Codigo_Articulo.Text = vp_prod_id_temp
            Txt_Descripcion_Articulo.Text = vp_prod_desc_temp
        ElseIf e.KeyData = Keys.F2 Then
            DGV_Facturas.Columns(7).DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss"
            If DGV_Facturas.Columns(7).Visible Then
                DGV_Facturas.Columns(7).Visible = False
            Else
                DGV_Facturas.Columns(7).Visible = True
            End If
            tamanno_listas_dgv_lv()
        ElseIf e.KeyValue = Keys.F1 Then
            abrir_caja()
        ElseIf e.KeyData = Keys.Enter Then

            If txt_barcode.Text.Trim.Length > 1 Then
                If txt_barcode.Text.Trim.Substring(0, 2) = "**" Then
                    Dim precio As Double
                    txt_barcode.Text = txt_barcode.Text.Trim.Replace(".", ",")
                    Try
                        If DGV_Facturas.RowCount > 0 And DGV_Facturas.Rows(DGV_Facturas.Rows.Count - 1).Cells("C_Descripcion").Value <> "" Then
                            precio = txt_barcode.Text.Trim.Substring(2, txt_barcode.Text.Length - 2)
                            DGV_Facturas.Rows(DGV_Facturas.Rows.Count - 1).Cells("C_Precio").Value = convertir_formato_miles_decimales(precio)
                            calcular_subtotal(DGV_Facturas.Rows(DGV_Facturas.Rows.Count - 1).Cells("C_Precio").Value, DGV_Facturas.Rows(DGV_Facturas.Rows.Count - 1).Cells("C_Cantidad").Value,
                               DGV_Facturas.Rows(DGV_Facturas.Rows.Count - 1).Cells("C_Impuesto").Value, DGV_Facturas.Rows(DGV_Facturas.Rows.Count - 1).Cells("C_Total").Value,
                               DGV_Facturas.Rows(DGV_Facturas.Rows.Count - 1).Cells(8).Value)
                        End If
                        calcular(Txt_Descuento.Text)
                        txt_barcode.Clear()
                    Catch ex As Exception
                        txt_barcode.Clear()
                    End Try
                ElseIf txt_barcode.Text.Trim.Substring(0, 1) = "*" Then
                    Dim cantidad As Double
                    txt_barcode.Text = txt_barcode.Text.Trim.Replace(".", ",")
                    Try
                        If DGV_Facturas.RowCount > 0 And DGV_Facturas.Rows(DGV_Facturas.Rows.Count - 1).Cells("C_Descripcion").Value <> "" Then
                            cantidad = txt_barcode.Text.Trim.Substring(1, txt_barcode.Text.Length - 1)
                            DGV_Facturas.Rows(DGV_Facturas.Rows.Count - 1).Cells("C_Cantidad").Value = convertir_formato_miles_decimales(cantidad)
                            calcular_subtotal(DGV_Facturas.Rows(DGV_Facturas.Rows.Count - 1).Cells("C_Precio").Value, DGV_Facturas.Rows(DGV_Facturas.Rows.Count - 1).Cells("C_Cantidad").Value,
                             DGV_Facturas.Rows(DGV_Facturas.Rows.Count - 1).Cells("C_Impuesto").Value, DGV_Facturas.Rows(DGV_Facturas.Rows.Count - 1).Cells("C_Total").Value,
                             DGV_Facturas.Rows(DGV_Facturas.Rows.Count - 1).Cells(8).Value)
                        End If
                        calcular(Txt_Descuento.Text)
                        txt_barcode.Clear()
                    Catch ex As Exception
                        txt_barcode.Clear()
                    End Try
                End If


            End If
            If txt_barcode.Text.Trim <> "" And txt_barcode.Text <> "BARCODE" Then
                SEL_BARCODE_FACTURA(txt_barcode.Text.Trim, Txt_Codigo_Articulo.Text, Txt_Descripcion_Articulo.Text, precio_actual, vp_precio2, vp_precio3, vp_preMayor, vp_art_auto)
                Txt_Precio_Articulo.Text = precio_actual
                'Revisa si hay alguna compra anterior
                If Txt_Codigo_Cliente.Text <> "" And Txt_Codigo_Cliente.Text <> "00" Then
                    SEL_BARCODE_FACTURA_ANT(txt_barcode.Text.Trim, vp_cli_id, Txt_Precio_Articulo.Text)
                    precio_antiguo = Txt_Precio_Articulo.Text
                    If precio_actual <> precio_antiguo And precio_antiguo > 0 And Txt_Descripcion_Articulo.Text <> "" Then
                        Txt_Precio_Articulo.BackColor = Color.Red
                        Txt_Precio_Articulo.ForeColor = Color.White
                        Txt_Precio_Articulo.Text = precio_antiguo
                    Else
                        Txt_Precio_Articulo.BackColor = Color.White
                        Txt_Precio_Articulo.ForeColor = Color.Black
                        Txt_Precio_Articulo.Text = precio_actual
                    End If
                Else
                    Txt_Precio_Articulo.Text = precio_actual
                    Txt_Precio_Articulo.BackColor = Color.White
                    Txt_Precio_Articulo.ForeColor = Color.Black
                End If
                If Txt_Descripcion_Articulo.Text.Trim <> "" Then
                    nudCantidad.Value = 1
                    calcular_sub()
                    Dim art_ingresado As Boolean = False
                    For i As Integer = 0 To DGV_Facturas.Rows.Count - 1
                        If DGV_Facturas.Rows(i).Cells("C_id").Value = vp_art_auto Then
                            art_ingresado = True
                            DGV_Facturas.Rows(i).Cells("C_Cantidad").Value = convertir_formato_miles_decimales(CDbl(DGV_Facturas.Rows(i).Cells("C_Cantidad").Value) + 1)
                            DGV_Facturas.Rows(i).Cells("C_Precio").Value = convertir_formato_miles_decimales(Txt_Precio_Articulo.Text)
                            calcular_subtotal(DGV_Facturas.Rows(i).Cells("C_Precio").Value, DGV_Facturas.Rows(i).Cells("C_Cantidad").Value,
                                DGV_Facturas.Rows(i).Cells("C_Impuesto").Value, DGV_Facturas.Rows(i).Cells("C_Total").Value,
                                DGV_Facturas.Rows(i).Cells(8).Value)
                            calcular(Txt_Descuento.Text)
                            limpiarArt()
                            If chb_cantidad.Checked Then
                                nudCantidad.Focus()
                            Else
                                Txt_Codigo_Articulo.Focus()
                            End If
                            producto_temporal(False)
                            If chb_barcode.Checked Then
                                txt_barcode.Clear()
                                txt_barcode.Focus()
                            End If
                            Exit For
                        End If
                    Next
                    If Not art_ingresado Then
                        btnAñadir_Click(sender, New System.EventArgs())
                    End If

                End If
                If txt_barcode.Text.Trim <> "" Then
                    txt_barcode.Text = "Codigo No Registrado"
                    vp_tiempo_contador = 1
                    Timer1.Start()

                End If
            End If

        End If

    End Sub

    Private Sub cb_barcode_Click(sender As Object, e As EventArgs) Handles cb_barcode.Click

    End Sub

    Private Sub txt_barcode_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_barcode.KeyUp

        If txt_barcode.Text.Length > 0 Then
            If txt_barcode.Text.Substring(0, 1) = "*" Then
                lb_barcode.Text = "CANTIDAD"
                lb_barcode.Visible = True
            Else
                lb_barcode.Visible = False
            End If
            If txt_barcode.Text.Length > 1 Then
                If txt_barcode.Text.Substring(0, 2) = "**" Then
                    lb_barcode.Text = "PRECIO"
                    lb_barcode.Visible = True
                ElseIf txt_barcode.Text.Substring(0, 1) = "*" Then
                    lb_barcode.Text = "CANTIDAD"
                    lb_barcode.Visible = True
                Else
                    lb_barcode.Visible = False
                End If
            End If
        ElseIf txt_barcode.Text.Trim = "" Then
            lb_barcode.Visible = False
        End If
    End Sub

    Private Sub txt_barcode_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_barcode.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub Txt_Codigo_Articulo_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Codigo_Articulo.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub Txt_Direccion_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Cedula.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub Txt_Descuento_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Descuento.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub Txt_Pago_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Pago.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub DGV_Facturas_SelectionChanged(sender As Object, e As EventArgs) Handles DGV_Facturas.SelectionChanged

    End Sub

    Private Sub Txt_Direccion_KeyUp(sender As Object, e As KeyEventArgs) Handles Txt_Cedula.KeyUp
        If Txt_Cedula.Text.Length > 0 Then
            If Txt_Cedula.Text.Trim.Substring(0, 1) = "-" Then
                Cb_Vendedor.SelectedItem = "ABAJO"
            ElseIf Txt_Cedula.Text.Trim.Substring(0, 1) = "*" Then
                Cb_Vendedor.SelectedItem = "ARRIBA"
            End If
        End If

    End Sub

    Private Sub tamanno_listas_dgv_lv()
        If DGV_Facturas.Columns(7).Visible Then
            DGV_Facturas.Columns(1).Width = DGV_Facturas.Size.Width - (583 + 130)
        Else
            DGV_Facturas.Columns(1).Width = DGV_Facturas.Size.Width - 583
        End If

    End Sub

    Private Sub txt_barcode_QueryAccessibilityHelp(sender As Object, e As QueryAccessibilityHelpEventArgs) Handles txt_barcode.QueryAccessibilityHelp

    End Sub

    Private Sub Fr_Crear_Facturas_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        tamanno_listas_dgv_lv()
    End Sub

    Private Sub Fr_Crear_Facturas_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        tamanno_listas_dgv_lv()
    End Sub

    Private Sub Txt_Cedula_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Cedula.KeyPress
        e.Handled = True
    End Sub

    Private Sub cb_CondicionVenta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_CondicionVenta.SelectedIndexChanged

        If cb_CondicionVenta.SelectedIndex = 0 Then
            _TipoFactura = "CONTADO"
            CreditoSeleccionado(False)
            nudDias.Value = 0
        ElseIf cb_CondicionVenta.SelectedIndex = 1 Then
            _TipoFactura = "CREDITO"
            CreditoSeleccionado(True)
            nudDias.Value = 30
        End If
    End Sub

    Private Sub CreditoSeleccionado(ByVal _Estado As Boolean)

        lbDias.Visible = _Estado
        lbCreditoA.Visible = _Estado
        nudDias.Visible = _Estado
    End Sub

    Private Sub txt_TotalImpuestos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_TotalImpuestos.KeyPress
        e.Handled = True
    End Sub

    Private Sub nudCantidad_ValueChanged(sender As Object, e As EventArgs) Handles nudCantidad.ValueChanged

        Dim _Subtotal As Double = 0
        Dim _ImpuestoSuma As Double = 0
        Dim _PrecioProducto As Double = 0
        Dim _ImpuestoPorcentaje As Double = 0
        Dim _CantidadProducto As Double = 0

        Try
            _ImpuestoPorcentaje = CDbl(Txt_Impuesto_Articulo.Text)
            _CantidadProducto = nudCantidad.Value
            _PrecioProducto = CDbl(Txt_Precio_Articulo.Text)

            _Subtotal = _CantidadProducto * _PrecioProducto
            _ImpuestoSuma = (_Subtotal * _ImpuestoPorcentaje)

            Txt_Subtotal_Articulo.Text = convertir_formato_miles_decimales(_Subtotal)
            txt_ImpuestoProducto.Text = convertir_formato_miles_decimales(_ImpuestoSuma)
        Catch ex As Exception

        End Try


    End Sub

    Private Sub nudCantidad_Enter(sender As Object, e As EventArgs) Handles nudCantidad.Enter
        nudCantidad.Select(0, nudCantidad.Text.Length)
    End Sub

    Private Sub nudCantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles nudCantidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            calcular_sub()
            btnAñadir_Click(sender, New System.EventArgs())
        End If
    End Sub

    Private Sub pnlCentral_Paint(sender As Object, e As PaintEventArgs) Handles pnlCentral.Paint

    End Sub
End Class