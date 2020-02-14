Imports MySql.Data.MySqlClient
'Imports Microsoft.PointOfService
Imports System.IO
Imports System.Text.RegularExpressions

Public Class Fr_Crea_Cotizacion

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
    Dim _CedulaCliente As String


    'MANTIENE EL PRODUCTO TEMPORAL QUE ESTABA EN EL GRIDVIEW AL INTENTAR MODIFICARLO EN
    'LOS CAMPOS DE TEXTO
    Private Sub producto_temporal(ByVal temp As Boolean)

        If temp Then
            vp_prod_id_temp = txt_codigo_articulo.Text
            vp_prod_desc_temp = Txt_Descripcion_Articulo.Text
            vp_prod_precio_temp = Txt_Precio_Articulo.Text
            vp_prod_cant_temp = Txt_Cantidad_Articulo.Text
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
            calcular_subtotal(CDbl(Txt_Precio_Articulo.Text), CDbl(Txt_Cantidad_Articulo.Text),
                     CDbl(Txt_Impuesto_Articulo.Text), Txt_Subtotal_Articulo.Text, "")
        Catch ex As Exception
            Logger.e("Error con excepción", ex, New StackFrame(True))
            MsgBox(ex.ToString)
        End Try


    End Sub

    'SELECCONA UN CLIENTE DEL LISTVIEW
    Private Sub seleccionar_cliente(ByVal prioridad_lista As Boolean)

        Try
            'SI HAY UN CODIGO DE CLIENTE ESCRITO Y 
            'EN EL CAMPO NOMBRE ESTA VACIO SE REVISARA CON LA LISTA DE CLIENTES EN CASO DE HABER COINCIDENCIA
            If prioridad_lista Then
                Me.Lv_Clientes.Focus()
                If Lv_Clientes.Items.Count > 1 Then
                    Lv_Clientes.TopItem.Selected = True
                End If
            Else
                If Txt_Codigo_Cliente.Text <> "" And DGV_Comentarios.Rows(0).Cells(0).Value = "" Then
                    If Lv_Clientes.Visible Then
                        Me.Lv_Clientes.Focus()
                        If Lv_Clientes.Items.Count > 1 Then
                            Lv_Clientes.TopItem.Selected = True
                        End If
                    Else
                        Txt_Codigo_Cliente.Focus()
                    End If
                ElseIf Txt_Codigo_Cliente.Text <> "" And DGV_Comentarios.Rows(0).Cells(0).Value <> "" Then
                    Lv_Clientes.Visible = False
                    If vp_advertencia <> "" And vp_advertencia <> "ADVERTENCIA" Then
                        MsgBox(vp_advertencia, MsgBoxStyle.Information, "PRECAUCION")
                    End If
                End If
            End If

        Catch ex As Exception
            Logger.e("Error con excepción", ex, New StackFrame(True))
            MsgBox(ex.ToString)
        End Try

    End Sub

    'CARGA EL PRODUCTO SELECCIONADO DEL LISTVIEW LVBUSQUEDA
    Public Sub seleccionaArticulo()

        If Not IsNothing(Lv_Busqueda_Articulos.FocusedItem) Then
            vp_art_auto = CInt(Lv_Busqueda_Articulos.Items(Lv_Busqueda_Articulos.FocusedItem.Index).Text)
            SEL_ARTICULOS_FAC(vp_art_auto, txt_codigo_articulo.Text, Txt_Descripcion_Articulo.Text, Txt_Precio_Articulo.Text, vp_precio2, vp_precio3, vp_preMayor, Txt_Impuesto_Articulo)
            Txt_Descripcion_Articulo.ReadOnly = True
            vp_precio1 = CDbl(Txt_Precio_Articulo.Text)
            calcular_subtotal(CDbl(Txt_Precio_Articulo.Text), CDbl(Txt_Cantidad_Articulo.Text), CDbl(Txt_Impuesto_Articulo.Text), Txt_Subtotal_Articulo.Text, "")
            Txt_Cantidad_Articulo.Focus()
            Txt_Cantidad_Articulo.SelectAll()
            Lv_Busqueda_Articulos.Visible = False
        End If

    End Sub

    'REDONDEA A ENTERO EL PRECIO Y LA CANTIDAD 
    Private Sub precioYsubt()

        If Txt_Precio_Articulo.Text = "" Then
            Txt_Precio_Articulo.Text = 0
            Txt_Precio_Articulo.SelectionLength() = 1
        End If

        If Txt_Subtotal_Articulo.Text = 0 Then Txt_Subtotal_Articulo.Text = 0

    End Sub

    'CARGA EL CLIENTE SELECCIONADO DEL LISTVIEW LV_CLIENTES
    Public Sub seleccionaCliente()

        Dim vendedor_nombre As String = ""
        If Not IsNothing(Lv_Clientes.FocusedItem) Then

            Txt_Codigo_Cliente.Text = Lv_Clientes.Items(Lv_Clientes.FocusedItem.Index).Text

            SEL_CLIENTE_FACT(Txt_Codigo_Cliente.Text, vp_cli_id, DGV_Comentarios, vp_advertencia, vp_telefono, vp_ticket_matriz, vp_vendedor_auto, _CedulaCliente)
            SEL_CLI_OPEN(vp_cli_id, vp_factura_id)
            If vp_vendedor_auto <> Nothing Then
                SEL_NOMBRE_VENDEDOR(vp_vendedor_auto, vendedor_nombre)
                Cb_Vendedor.SelectedIndex = Cb_Vendedor.FindStringExact(vendedor_nombre)
            Else
                Cb_Vendedor.SelectedIndex = Cb_Vendedor.FindStringExact("CAJA")
            End If
            txt_codigo_articulo.Focus()
            Lv_Clientes.Visible = False

        End If

    End Sub

    'CALCULO DEL TOTAL (PRECIO X PRODUCTO)
    Private Sub calcular(ByVal monto As String)
        Dim desc As Double
        Dim linea As Integer = 0
        Try
            'VARIABLES  NECESARIAS PARA LAS OPERACIONES MATEMATICAS
            Dim suma As Double = Nothing
            Dim subdes As Double = Nothing

            'REALIZA LA SUMA DE EL TOTAL DE TODOS LOS PRODUCTOS
            For Each row As DataGridViewRow In Me.DGV_Facturas.Rows
                suma += (row.Cells(5).Value)
                linea += 1
            Next

            'MUESTRA EL TOTAL Y SUBTOTAL EN SUS RESPECTIVOS CAMPOS SI NO HAY DESCUENTO
            Txt_Subtotal.Text = convertir_formato_miles_decimales(suma)
            If Txt_Descuento.Text = "0,00" Or Txt_Descuento.Text = "" Then
                Txt_Total.Text = convertir_formato_miles_decimales(suma)
            ElseIf Txt_Descuento.Text <> "0,00" And Txt_Descuento.Text <> "" Then
                desc = (CDbl(Txt_Descuento.Text) / 100)
                subdes = desc * CDbl(Txt_Subtotal.Text)
                Txt_Descuento_Final.Text = convertir_formato_miles_decimales(subdes)
                desc = CDbl(Txt_Subtotal.Text) - (CDbl(Txt_Descuento_Final.Text))
                Txt_Total.Text = convertir_formato_miles_decimales(desc)
            End If
            DGV_Facturas.Sort(DGV_Facturas.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
            If linea > 0 Then Lb_Numero_Linea.Text = "Numero de Lineas: " & linea
        Catch ex As Exception
            If ex.ToString.Contains("System.InvalidOperationException") Then
            Else
                MsgBox(ex.ToString)
                Logger.e("Error con excepción", ex, New StackFrame(True))
            End If

        End Try

    End Sub

    'CARGA LAS VARIABLES DE INICIO DEL FORMULARIO
    Private Sub inicio()

        'Inicio la Configuracion por parte del usuario
        limpia_variablesBD_Modulo()
        DGV_Facturas.FillEmptyArea = True
        Lv_Busqueda_Articulos.Visible = False
        Txt_Descripcion_Articulo.ReadOnly = True
        SEL_VENDEDORES(Cb_Vendedor, Lv_Id_Vendedor)
        Cb_Vendedor.SelectedItem = "CAJA"

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
        Txt_Descuento.Text = "0,00"
        Txt_Descuento_Final.Text = "0,00"
        Txt_Total.Text = "0,00"
        Txt_Cantidad_Articulo.Text = "1"
        Txt_Precio_Articulo.Text = "0"

        SEL_CONFIG_FACTURA(nombre_empresa, numero_factura, usar_impresora_termica, usar_precios_anteriores, cabecera_1,
                           cabecera_2, cabecera_3, cabecera_4, cabecera_5, cabecera_6, pie_pagina)
        SEL_CONFIG_COT_NUMERO(numero_factura)
        Txt_Numero_Factura.Text = numero_factura
        Lb_Numero_Linea.Text = "Estado Normal"

        Date_Fecha_Factura.Format = DateTimePickerFormat.Custom
        Date_Fecha_Factura.CustomFormat = "dd/MM/yyyy"
    End Sub

    'LIMPIA EL FORMULARIO
    Private Sub limpiaForm()

        vp_fact_auto = 0
        vp_precio1 = 0
        vp_precio2 = 0
        vp_precio3 = 0
        vp_preMayor = 0
        vp_art_auto = 0
        vp_cli_id = 0

        Txt_Descripcion_Articulo.ReadOnly = True
        Txt_Codigo_Cliente.Text = ""
        Txt_Descuento.Text = "0,00"
        Txt_Descuento_Final.Text = "0,00"
        Txt_Subtotal.Text = "0,00"
        Txt_Total.Text = "0,00"
        Txt_Precio_Articulo.Text = "0"
        Txt_Cantidad_Articulo.Text = "1"
        Txt_Impuesto_Articulo.Text = "0"

        For i As Integer = 0 To 2
            DGV_Comentarios.Rows(i).Cells(0).Value = ""
        Next

        DGV_Facturas.RowCount = 1
        DGV_Facturas.Rows.Clear()
        SEL_CONFIG_COT_NUMERO(numero_factura)
        Txt_Numero_Factura.Text = numero_factura
        Txt_Codigo_Cliente.Focus()
        Txt_Descripcion_Articulo.ReadOnly = True

    End Sub

    'LIMPIA LOS CAMPOS DE TEXTO DONDE SE INGRESAN LOS ARTICULOS
    Private Sub limpiarArt()

        vp_precio1 = 0
        vp_precio2 = 0
        vp_precio3 = 0
        vp_preMayor = 0
        vp_art_auto = 0

        txt_codigo_articulo.Clear()
        Txt_Descripcion_Articulo.Clear()
        Txt_Cantidad_Articulo.Text = "1"
        Txt_Impuesto_Articulo.Text = "0"
        Txt_Precio_Articulo.Text = "0"
        Txt_Subtotal_Articulo.Text = "0,00"
        Chb_Por_Mayor.Checked = False
        txt_barcode.Focus()
    End Sub

    'IMPRIME EN LA IMPRESORA MATRIZ
    Private Sub imprimir_Matriz()

        Dim cabeceraFactura(5) As String
        cabeceraFactura(0) = cabecera_1
        cabeceraFactura(1) = cabecera_2
        cabeceraFactura(2) = cabecera_3
        cabeceraFactura(3) = cabecera_4
        cabeceraFactura(4) = cabecera_5
        cabeceraFactura(5) = cabecera_6

        Dim comet1 As String = DGV_Comentarios.Rows(1).Cells(0).Value
        Dim comet2 As String = DGV_Comentarios.Rows(2).Cells(0).Value

        StartPrintMatriz()
        If prn_matriz.PrinterIsOpen = True Then
            PrintHeaderCot_Matriz(nombre_empresa, cabeceraFactura)
            PrintDetallesCot_Matriz(Date_Fecha_Factura.Value, numero_factura, DGV_Comentarios.Rows(0).Cells(0).Value.ToString,
                      Txt_Codigo_Cliente.Text, comet1, comet2)
            PrintBodyCot_Matriz(DGV_Facturas, Txt_Total.Text, Txt_Subtotal.Text, Txt_Descuento_Final.Text)
            EndPrintMatriz()
        End If

    End Sub

    'CREA LA FACTURA
    Private Sub crea_factura(ByVal estado_fact As Boolean, ByVal imprime_tiquet As Boolean)

        Dim artid As Integer = Nothing
        Dim artcan As Double = Nothing
        Dim artpre As Double = Nothing
        Dim artimp As Double = Nothing
        Dim subtotal As Double = Nothing
        Dim comet1 As String = DGV_Comentarios.Rows(1).Cells(0).Value
        Dim comet2 As String = DGV_Comentarios.Rows(2).Cells(0).Value

        Try
            If Txt_Descuento.Text = "" Then
                Txt_Descuento.Text = "0"
            End If

            If vp_estado = "ADD" Then
                If Txt_Codigo_Cliente.Text = "" Or DGV_Comentarios.Rows(0).Cells(0).Value = "" Then
                    MsgBox("Ingrese un CODIGO de Cliente valido!!", MsgBoxStyle.Critical, "ADVERTENCIA")
                    Txt_Codigo_Cliente.Focus()
                ElseIf DGV_Facturas.Rows.Count > 1 Then

                    Date_Fecha_Factura.Value = Date_Fecha_Factura.Value.ToString("dd/MM/yyyy") + " " + Date.Now.ToString("H:mm:ss")

                    INS_COTIZACION(CInt(Txt_Numero_Factura.Text), vp_cli_id, CInt(Lv_Id_Vendedor.Items.Item(Cb_Vendedor.SelectedIndex).SubItems(0).Text),
                                         comet1, comet2, CDbl(Txt_Subtotal.Text), pie_pagina, CDbl(Txt_Descuento.Text), CDbl(Txt_Total.Text),
                                         Date_Fecha_Factura.Value, CDbl(Txt_Impuesto_Articulo.Text))
                    SEL_CONFIG_COT_NUMERO(numero_factura)
                    SEL_COT_AUTO(CInt(numero_factura), vp_fact_auto, Date_Fecha_Factura.Value)
                    For Each item As DataGridViewRow In DGV_Facturas.Rows

                        artid = CInt(item.Cells(6).Value)
                        artcan = CDbl(item.Cells(2).Value)
                        artpre = CDbl(item.Cells(3).Value)
                        artimp = CDbl(item.Cells(4).Value)
                        subtotal = CDbl(item.Cells(5).Value)

                        If artid <> 0 Then
                            INS_COT_DETALLE(vp_fact_auto, artid, artcan, artpre, artimp, subtotal)
                        End If

                    Next
                    If imprime_tiquet Then
                        Imprimir_Factura("ORIGINAL", "COTIZACION")
                    End If
                    numero_factura = numero_factura + 1
                    UPD_COTIZACION_NUMERO(CInt(numero_factura))
                    Txt_Numero_Factura.Text = numero_factura
                    Date_Fecha_Factura.Value = Today
                    limpiaForm()
                End If
            ElseIf vp_estado = "UPDATE" Or vp_estado = "UPDATEOPEN" Then
                If Txt_Codigo_Cliente.Text = "" Then
                    MsgBox("Ingrese un Nombre de Cliente")
                    Txt_Codigo_Cliente.Focus()

                ElseIf DGV_Facturas.Rows.Count > 1 Then

                    UPD_COTIZACION(CInt(Txt_Numero_Factura.Text), vp_cli_id, CInt(Lv_Id_Vendedor.Items.Item(Cb_Vendedor.SelectedIndex).SubItems(0).Text),
                                            comet1, comet2, CDbl(Txt_Subtotal.Text), pie_pagina,
                                             CDbl(Txt_Descuento.Text), CDbl(Txt_Total.Text), Date_Fecha_Factura.Value,
                                             CDbl(Txt_Impuesto_Articulo.Text), vp_fact_auto)
                    DEL_ART_COT(vp_fact_auto)
                    For Each item As DataGridViewRow In DGV_Facturas.Rows

                        artid = CInt(item.Cells(6).Value)
                        artcan = CDbl(item.Cells(2).Value)
                        artpre = CDbl(item.Cells(3).Value)
                        artimp = CDbl(item.Cells(4).Value)
                        subtotal = CDbl(item.Cells(5).Value)

                        If artid <> 0 Then
                            INS_COT_DETALLE(vp_fact_auto, artid, artcan, artpre, artimp, subtotal)
                        End If

                    Next
                    If imprime_tiquet Then
                        Imprimir_Factura("ORIGINAL", "COTIZACION")
                    End If
                    limpiaForm()
                    limpia_variablesBD_Modulo()
                    Date_Fecha_Factura.Value = Today
                    Fr_Facturas.Show()
                    Me.Close()
                End If
            End If
            producto_temporal(False)
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        End Try

        Fr_Facturas.rellenarFacturasAbiertas()
        Fr_Facturas.rellenarFacturasCerradas()
        Fr_Facturas.rellenaCotizacion()

    End Sub

    'SE ENCARGA DE SELECCIONAR EL TIPO DE IMPRESORA A UTILIZAR
    Private Sub Imprimir_Factura(ByVal tipoFactura As String, ByVal motivo As String)

        If usar_impresora_termica = True Then
            imprimir()
        Else
            imprimir_Matriz()
        End If

    End Sub

    'MARCA DE UN COLOR DIFERENTE EL CAMPO DE TEXTO DONDE EXISTE UNA ADVERTENCIA
    Private Sub color_advertencia(ByVal modo As Boolean)

        If modo Then
            txt_codigo_articulo.BackColor = Color.Red
            Txt_Descripcion_Articulo.BackColor = Color.Red
            Txt_Cantidad_Articulo.BackColor = Color.Red
            Txt_Precio_Articulo.BackColor = Color.Red
            Txt_Impuesto_Articulo.BackColor = Color.Red

            txt_codigo_articulo.ForeColor = Color.White
            Txt_Descripcion_Articulo.ForeColor = Color.White
            Txt_Cantidad_Articulo.ForeColor = Color.White
            Txt_Precio_Articulo.ForeColor = Color.White
            Txt_Impuesto_Articulo.ForeColor = Color.White

        Else
            txt_codigo_articulo.BackColor = Color.White
            Txt_Descripcion_Articulo.BackColor = Color.White
            Txt_Cantidad_Articulo.BackColor = Color.White
            Txt_Precio_Articulo.BackColor = Color.White
            Txt_Impuesto_Articulo.BackColor = Color.White

            txt_codigo_articulo.ForeColor = Color.Black
            Txt_Descripcion_Articulo.ForeColor = Color.Black
            Txt_Cantidad_Articulo.ForeColor = Color.Black
            Txt_Precio_Articulo.ForeColor = Color.Black
            Txt_Impuesto_Articulo.ForeColor = Color.Black
        End If
    End Sub

    'IMPRIME EN IMPRESORA TERMICA
    Private Sub imprimir()

        Dim cabeceraFactura(5) As String
        cabeceraFactura(0) = cabecera_1
        cabeceraFactura(1) = cabecera_2
        cabeceraFactura(2) = cabecera_3
        cabeceraFactura(3) = cabecera_4
        cabeceraFactura(4) = cabecera_5
        cabeceraFactura(5) = cabecera_6

        Dim comet1 As String = DGV_Comentarios.Rows(1).Cells(0).Value
        Dim comet2 As String = DGV_Comentarios.Rows(2).Cells(0).Value
        StartPrint()
        If prn.PrinterIsOpen = True Then
            PrintHeaderCot(nombre_empresa, cabeceraFactura)
            PrintDetallesCot(Date_Fecha_Factura.Value, numero_factura, DGV_Comentarios.Rows(0).Cells(0).Value.ToString,
                          Txt_Codigo_Cliente.Text, comet1, comet2)
            PrintBodyCot(DGV_Facturas, Txt_Total.Text, Txt_Subtotal.Text, Txt_Descuento_Final.Text)
            EndPrint()
        End If
    End Sub

    Private Sub Crea_Cotizacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        inicio()

    End Sub

    Private Sub txtCodigoCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Codigo_Cliente.KeyDown

        If e.KeyData = Keys.Tab Then
            e.SuppressKeyPress = True
            seleccionar_cliente(False)
        ElseIf e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
        ElseIf e.KeyData = Keys.Add And Lv_Clientes.Visible Then
            e.SuppressKeyPress = True
            seleccionar_cliente(True)
            Lv_Clientes.Focus()
        ElseIf Txt_Codigo_Cliente.BackColor = Color.Yellow Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub txtCodigoCliente_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Txt_Codigo_Cliente.PreviewKeyDown

        If e.KeyData = Keys.Tab And DGV_Comentarios.Rows(0).Cells(0).Value = "" Then
            e.IsInputKey = True
        ElseIf e.KeyData = Keys.Tab And DGV_Comentarios.Rows(0).Cells(0).Value <> "" Then
            e.IsInputKey = True
            txt_codigo_articulo.Select()
        ElseIf e.KeyValue = Keys.F9 Then
            btnImprimir_Click(sender, New System.EventArgs())
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
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        End Try

    End Sub


    Private Sub txtTotal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Total.KeyPress

        e.Handled = True

    End Sub


    Private Sub txtDesFinal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Subtotal.KeyPress, Txt_Descuento_Final.KeyPress

        e.Handled = True

    End Sub

    Private Sub LvBusqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Lv_Busqueda_Articulos.KeyPress

        Try
            If e.KeyChar = ChrW(Keys.Enter) Then
                seleccionaArticulo()
            ElseIf e.KeyChar = ChrW(Keys.Escape) And txt_codigo_articulo.Text <> "" Then
                txt_codigo_articulo.Focus()
            ElseIf e.KeyChar = ChrW(Keys.Escape) And Txt_Descripcion_Articulo.Text <> "" Then
                Txt_Descripcion_Articulo.ReadOnly = False
                Txt_Descripcion_Articulo.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        End Try

    End Sub

    Private Sub LvBusqueda_Leave(sender As Object, e As EventArgs) Handles Lv_Busqueda_Articulos.Leave

        Lv_Busqueda_Articulos.Visible = False

    End Sub

    Private Sub DGVComentaris_Leave(sender As Object, e As EventArgs) Handles DGV_Comentarios.Leave

        txt_codigo_articulo.Focus()

    End Sub

    'VALIDACION DE SOLO MAYUSCULAS EN EL DATAGRID COMENTARIOS
    Private Sub DGVComentaris_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DGV_Comentarios.EditingControlShowing

        If TypeOf e.Control Is TextBox Then
            DirectCast(e.Control, TextBox).CharacterCasing = CharacterCasing.Upper
        End If

    End Sub

    Private Sub txtCodigoCliente_KeyUp(sender As Object, e As KeyEventArgs) Handles Txt_Codigo_Cliente.KeyUp

        SEL_CLIENTE_FACT(Txt_Codigo_Cliente.Text, vp_cli_id, DGV_Comentarios, vp_advertencia, vp_telefono, vp_ticket_matriz, vp_vendedor_auto, _CedulaCliente)
        Dim vendedor_nombre As String = ""
        Dim filtro_clientes As String = ""
        Try
            Lv_Clientes.Items.Clear()
            If Txt_Codigo_Cliente.Text.Trim <> "" Then
                filtro_clientes = Regex.Replace(Txt_Codigo_Cliente.Text.Trim, "\s{2,}", " ")
                filtro_clientes = filtro_clientes.Replace(" ", "%")
                SEL_CLIENTE_FAC(filtro_clientes, filtro_clientes, Lv_Clientes)
                If Lv_Clientes.Items.Count > 0 Then
                    Lv_Clientes.Visible = True
                ElseIf Lv_Clientes.Items.Count < 1 Then
                    Lv_Clientes.Visible = False
                End If
            Else
                Lv_Clientes.Visible = False
            End If

            SEL_CLIENTE_FACT(filtro_clientes, vp_cli_id, DGV_Comentarios, vp_advertencia, vp_telefono, vp_ticket_matriz, vp_vendedor_auto, _CedulaCliente)
            SEL_CLI_OPEN(vp_cli_id, vp_factura_id)
            If vp_vendedor_auto <> Nothing Then
                SEL_NOMBRE_VENDEDOR(vp_vendedor_auto, vendedor_nombre)
                Cb_Vendedor.SelectedIndex = Cb_Vendedor.FindStringExact(vendedor_nombre)
            Else
                Cb_Vendedor.SelectedIndex = Cb_Vendedor.FindStringExact("CAJA")
            End If

        Catch ex As Exception
            Logger.e("Error con excepción", ex, New StackFrame(True))
            MsgBox(ex.ToString())
        End Try

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

        Txt_Descuento.SelectAll()

    End Sub

    Private Sub txtDesc_MouseDown(sender As Object, e As MouseEventArgs) Handles Txt_Descuento.MouseDown

        Txt_Descuento.SelectAll()

    End Sub

    Private Sub txtDesc_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Txt_Descuento.PreviewKeyDown

        If Txt_Descuento.Text = "0,00" Then
            Txt_Descuento.Text = ""
        ElseIf e.KeyValue = Keys.F9 Then
            btnImprimir_Click(sender, New System.EventArgs())
        End If

    End Sub

    Private Sub txtDesc_Leave(sender As Object, e As EventArgs) Handles Txt_Descuento.Leave

        Try
            If (Not String.IsNullOrEmpty(Txt_Descuento.Text)) Then
                Txt_Descuento.Text = String.Format("{0:n}", CDbl(Txt_Descuento.Text))
            Else
                Txt_Descuento.Text = "0,00"
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        End Try

    End Sub

    Private Sub txtCodigoArt_KeyUp(sender As Object, e As KeyEventArgs)

        Try
            Lv_Busqueda_Articulos.Items.Clear()
            Dim busqueda As String
            If txt_codigo_articulo.Text.Trim <> "" And Txt_Descripcion_Articulo.ReadOnly Then
                'LLENA LVBUSQUEDA CON LOS ULTIMOS PRODUCTOS COMPRADOS POR EL CLIENTE
                busqueda = Regex.Replace(txt_codigo_articulo.Text.Trim, "\s{2,}", " ")
                busqueda = busqueda.Replace(" ", "%")
                SEL_ARTICULO_COD(busqueda, Lv_Busqueda_Articulos, vp_art_auto)
                If Lv_Busqueda_Articulos.Items.Count > 0 And txt_codigo_articulo.SelectedText.Length = 0 Then
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

    Private Sub txtCodigoArt_Leave(sender As Object, e As EventArgs)

        Try
            If txt_codigo_articulo.Text <> "" Then
                If Lv_Busqueda_Articulos.Visible Then
                    Me.Lv_Busqueda_Articulos.Focus()
                    If Lv_Busqueda_Articulos.Items.Count > 0 Then
                        Lv_Busqueda_Articulos.TopItem.Selected = True
                    End If
                Else
                    txt_barcode.Focus()
                End If
            Else
                txt_barcode.Focus()
            End If

        Catch ex As Exception
            Logger.e("Error con excepción", ex, New StackFrame(True))
            MsgBox(ex.ToString)
        End Try


    End Sub

    Private Sub txtCant_Leave(sender As Object, e As EventArgs) Handles Txt_Cantidad_Articulo.Leave

        Try
            If Txt_Cantidad_Articulo.Text = "" Then
                Txt_Cantidad_Articulo.Text = 1
            Else
                If Txt_Cantidad_Articulo.Text < 1 And Txt_Cantidad_Articulo.Text >= 0.5 Then
                    Txt_Precio_Articulo.Text = vp_precio2.ToString
                ElseIf Txt_Cantidad_Articulo.Text < 0.5 And Txt_Cantidad_Articulo.Text >= 0 Then
                    Txt_Precio_Articulo.Text = vp_precio3.ToString
                End If
            End If
            calcular_subtotal(CDbl(Txt_Precio_Articulo.Text), CDbl(Txt_Cantidad_Articulo.Text), CDbl(Txt_Impuesto_Articulo.Text), Txt_Subtotal_Articulo.Text, "")
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        End Try

    End Sub

    Private Sub txtCant_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Cantidad_Articulo.KeyPress

        If e.KeyChar = "." And Not Txt_Cantidad_Articulo.Text.Contains(",") Then
            e.Handled = True
            Txt_Cantidad_Articulo.Text = Txt_Cantidad_Articulo.Text & ","
            Txt_Cantidad_Articulo.SelectionStart() = Txt_Cantidad_Articulo.Text.Length
        End If
        NumerosyDecimal(Txt_Cantidad_Articulo, e)

    End Sub

    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Precio_Articulo.KeyPress

        If e.KeyChar = "." And Not Txt_Cantidad_Articulo.Text.Contains(",") Then
            e.Handled = True
            Txt_Cantidad_Articulo.Text = Txt_Cantidad_Articulo.Text & ","
            Txt_Cantidad_Articulo.SelectionStart() = Txt_Cantidad_Articulo.Text.Length
        End If
        NumerosyDecimal(Txt_Precio_Articulo, e)

    End Sub

    Private Sub txtPrecio_Leave(sender As Object, e As EventArgs) Handles Txt_Precio_Articulo.Leave

        Try
            If Txt_Precio_Articulo.Text = "" Then
                Txt_Precio_Articulo.Text = "1"
            End If
            calcular_subtotal(CDbl(Txt_Precio_Articulo.Text), CDbl(Txt_Cantidad_Articulo.Text), CDbl(Txt_Impuesto_Articulo.Text), Txt_Subtotal_Articulo.Text, "")
            Btn_Añadir.Focus()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        End Try

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Chb_Por_Mayor.CheckedChanged

        Try
            If Chb_Por_Mayor.Checked Then
                Txt_Precio_Articulo.Text = vp_preMayor.ToString
            Else
                Txt_Precio_Articulo.Text = vp_precio1.ToString
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        End Try

    End Sub

    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles Btn_Añadir.Click

        Try
            If txt_codigo_articulo.Text = "" Then
                MsgBox("INGRESE UN PRODUCTO", MsgBoxStyle.Critical, "ADVERTENCIA")
                txt_codigo_articulo.Focus()
            ElseIf CDbl(Txt_Subtotal_Articulo.Text) <= 0 Then
                MsgBox("EL SUBTOTAL DEBE SER MAYOR A CERO", MsgBoxStyle.Critical, "ADVERTENCIA")
            ElseIf CDbl(Txt_Precio_Articulo.Text) <= 0 Then
                MsgBox("EL PRECIO DEBE SER MAYOR A CERO", MsgBoxStyle.Critical, "ADVERTENCIA")
            Else
                SEL_ART_FACTURA(vp_art_auto, DGV_Facturas, Txt_Descripcion_Articulo.Text, Txt_Cantidad_Articulo.Text,
                                Txt_Precio_Articulo.Text, Txt_Subtotal_Articulo.Text, vp_art_auto.ToString,
                                Txt_Impuesto_Articulo.Text, "")
                calcular(Txt_Descuento.Text)
                limpiarArt()
                txt_codigo_articulo.Focus()
                producto_temporal(False)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        End Try

    End Sub

    Private Sub btnAñadir_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Btn_Añadir.KeyPress

        If Keys.Escape Then
            Txt_Cantidad_Articulo.Focus()
        End If

    End Sub

    Private Sub txtDesc_TextChanged(sender As Object, e As EventArgs) Handles Txt_Descuento.TextChanged

        Try
            If Txt_Descuento.Text <> "" Then
                calcular(CDbl(Txt_Descuento.Text))
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        End Try

    End Sub

    Private Sub txtImp_Leave(sender As Object, e As EventArgs) Handles Txt_Impuesto_Articulo.Leave

        Try
            If Txt_Impuesto_Articulo.Text = "" Then
                Txt_Impuesto_Articulo.Text = "0"
            End If
            If CDbl(Txt_Impuesto_Articulo.Text) > 0 Then
                calcular_subtotal(CDbl(Txt_Precio_Articulo.Text), CDbl(Txt_Cantidad_Articulo.Text), CDbl(Txt_Impuesto_Articulo.Text), Txt_Subtotal_Articulo.Text, "")
            End If
            Btn_Añadir.Focus()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        End Try

    End Sub

    Private Sub txtImp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Impuesto_Articulo.KeyPress

        If e.KeyChar = "." And Not Txt_Cantidad_Articulo.Text.Contains(",") Then
            e.Handled = True
            Txt_Cantidad_Articulo.Text = Txt_Cantidad_Articulo.Text & ","
            Txt_Cantidad_Articulo.SelectionStart() = Txt_Cantidad_Articulo.Text.Length
        End If
        NumerosyDecimal(Txt_Impuesto_Articulo, e)

    End Sub

    Private Sub btnAñadir_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Btn_Añadir.PreviewKeyDown

        If e.KeyData = Keys.Tab Then
            e.IsInputKey = True
        ElseIf e.KeyValue = Keys.F9 Then
            btnImprimir_Click(sender, New System.EventArgs())
        End If

    End Sub

    Private Sub btnAñadir_KeyDown(sender As Object, e As KeyEventArgs) Handles Btn_Añadir.KeyDown

        If e.KeyData = Keys.Tab Then
            e.Handled = True
        End If

    End Sub

    Private Sub DGVFacturas_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Facturas.CellContentDoubleClick

        Try
            If txt_codigo_articulo.Text = "" And Txt_Descripcion_Articulo.Text = "" Then
                txt_codigo_articulo.Text = DGV_Facturas.Item(0, DGV_Facturas.CurrentRow.Index).Value
                Txt_Descripcion_Articulo.Text = DGV_Facturas.Item(1, DGV_Facturas.CurrentRow.Index).Value

                If DGV_Facturas.Item(2, DGV_Facturas.CurrentRow.Index).Value.ToString.Contains(",00") Then
                    Txt_Cantidad_Articulo.Text = DGV_Facturas.Item(2, DGV_Facturas.CurrentRow.Index).Value.ToString.Substring(0, DGV_Facturas.Item(2, DGV_Facturas.CurrentRow.Index).Value.ToString.Length - 3)
                Else
                    Txt_Cantidad_Articulo.Text = DGV_Facturas.Item(2, DGV_Facturas.CurrentRow.Index).Value
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
                calcular_subtotal(CDbl(Txt_Precio_Articulo.Text), CDbl(Txt_Cantidad_Articulo.Text), CDbl(Txt_Impuesto_Articulo.Text), Txt_Subtotal_Articulo.Text, "")
                calcular(Txt_Descuento.Text)
                Txt_Cantidad_Articulo.Focus()
                producto_temporal(True)
            Else
                txt_codigo_articulo.Focus()
                vp_tiempo_contador = 1
                Timer1.Start()

            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        End Try

    End Sub

    Private Sub txtCant_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Cantidad_Articulo.KeyDown

        If e.KeyCode = Keys.Enter Then
            Txt_Precio_Articulo.Focus()
            calcular_subtotal(CDbl(Txt_Precio_Articulo.Text), CDbl(Txt_Cantidad_Articulo.Text), CDbl(Txt_Impuesto_Articulo.Text), Txt_Subtotal_Articulo.Text, "")
            btnAñadir_Click(sender, New System.EventArgs())
        End If

    End Sub

    Private Sub txtPrecio_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Precio_Articulo.KeyDown

        If e.KeyCode = Keys.Enter Then
            calcular_subtotal(CDbl(Txt_Precio_Articulo.Text), CDbl(Txt_Cantidad_Articulo.Text), CDbl(Txt_Impuesto_Articulo.Text), Txt_Subtotal_Articulo.Text, "")
            btnAñadir_Click(sender, New System.EventArgs())
        End If

    End Sub

    Private Sub txtImp_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Impuesto_Articulo.KeyDown

        If e.KeyCode = Keys.Enter Then
            calcular_subtotal(CDbl(Txt_Precio_Articulo.Text), CDbl(Txt_Cantidad_Articulo.Text), CDbl(Txt_Impuesto_Articulo.Text), Txt_Subtotal_Articulo.Text, "")
            btnAñadir_Click(sender, New System.EventArgs())
        End If

    End Sub

    Private Sub btnHistorial_Click(sender As Object, e As EventArgs) Handles Btn_Historial.Click

        If vp_cli_id > 0 Then
            Using historial_form As New Fr_Compra_Cliente(vp_cli_id)
                historial_form.StartPosition = FormStartPosition.CenterParent
                historial_form.ShowDialog()
            End Using
            'Fr_Compra_Cliente.cliente_id = vp_cli_id
            'Fr_Compra_Cliente.Show()
        End If

    End Sub

    Private Sub btnCliente_Click(sender As Object, e As EventArgs) Handles Btn_Nuevo_Cliente.Click

        Fr_Clientes.Show()

    End Sub

    Private Sub btnArticulo_Click(sender As Object, e As EventArgs) Handles Btn_Articulo_Nuevo.Click

        Fr_Agregar_Inventario.Show()

    End Sub

    Private Sub txtCant_KeyUp(sender As Object, e As KeyEventArgs) Handles Txt_Cantidad_Articulo.KeyUp

        If Txt_Cantidad_Articulo.Text = "," Then
            Txt_Cantidad_Articulo.Text = "0,"
            Txt_Cantidad_Articulo.SelectionStart = 2
        End If

    End Sub

    Private Sub txtCodigoArt_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs)

        If e.KeyValue = Keys.F9 Then
            btnImprimir_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.Escape And vp_prod_id_temp <> "" Then
            vp_art_auto = vp_prod_aut_temp
            txt_codigo_articulo.Text = vp_prod_id_temp
            Txt_Descripcion_Articulo.Text = vp_prod_desc_temp
        End If

        If e.Alt AndAlso e.KeyValue = Keys.H And DGV_Comentarios.Rows(0).Cells(0).Value <> "" Then
            btnHistorial_Click(sender, New EventArgs())
        End If

        If e.KeyValue = Keys.F9 And Btn_Imprimir.Enabled Then
            btnImprimir_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.Escape And vp_prod_id_temp <> "" Then
            vp_art_auto = vp_prod_aut_temp
            txt_codigo_articulo.Text = vp_prod_id_temp
            Txt_Descripcion_Articulo.Text = vp_prod_desc_temp
        ElseIf e.KeyValue = Keys.Tab Then
            txt_barcode.Focus()
        End If

    End Sub

    Private Sub LvBusqueda_Enter(sender As Object, e As EventArgs) Handles Lv_Busqueda_Articulos.Enter

        Try
            If Lv_Busqueda_Articulos.Items.Count = 1 Then
                seleccionaArticulo()
            End If
        Catch ex As Exception
            ex.ToString()
            Logger.e("Error con excepción", ex, New StackFrame(True))
        End Try

    End Sub

    Private Sub Button1_Click_3(sender As Object, e As EventArgs) Handles Btn_Solo_Guardar.Click

        crea_factura(False, False)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btn_Salir.Click

        limpia_variablesBD_Modulo()
        Fr_Facturas.Show()
        Fr_Facturas.rellenarFacturasAbiertas()
        Fr_Facturas.rellenarFacturasCerradas()
        Me.Close()

    End Sub

    Private Sub DGVComentaris_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles DGV_Comentarios.PreviewKeyDown

        If e.KeyValue = Keys.F9 Then
            btnImprimir_Click(sender, New System.EventArgs())
        End If

    End Sub

    Private Sub CbVendedor_SelectedValueChanged(sender As Object, e As EventArgs) Handles Cb_Vendedor.SelectedValueChanged

        Txt_Codigo_Cliente.Focus()

    End Sub

    Private Sub DGVFacturas_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles DGV_Facturas.PreviewKeyDown

        If e.KeyValue = Keys.F9 Then
            btnImprimir_Click(sender, New System.EventArgs())
        ElseIf e.Alt AndAlso e.KeyValue = Keys.H And DGV_Comentarios.Rows(0).Cells(0).Value <> "" Then
            btnHistorial_Click(sender, New EventArgs())
        End If

    End Sub

    Private Sub txtPrecio_KeyUp(sender As Object, e As KeyEventArgs) Handles Txt_Precio_Articulo.KeyUp

        precioYsubt()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If vp_tiempo_contador Mod 2 > 0 And vp_tiempo_contador < 4 Then
            color_advertencia(True)
        ElseIf vp_tiempo_contador Mod 2 = 0 And vp_tiempo_contador < 4 Then
            color_advertencia(False)
        Else
            color_advertencia(False)
            Timer1.Stop()
        End If
        vp_tiempo_contador += 1

    End Sub

    Private Sub btnCliente_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Btn_Nuevo_Cliente.PreviewKeyDown

        If e.KeyValue = Keys.F9 Then
            btnImprimir_Click(sender, New System.EventArgs())
        End If

    End Sub

    Private Sub btnHistorial_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Btn_Historial.PreviewKeyDown

        If e.KeyValue = Keys.F9 Then
            btnImprimir_Click(sender, New System.EventArgs())
        End If

    End Sub

    Private Sub btnArticulo_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Btn_Articulo_Nuevo.PreviewKeyDown

        If e.KeyValue = Keys.F9 Then
            btnImprimir_Click(sender, New System.EventArgs())
        End If

    End Sub

    Private Sub CbVendedor_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Cb_Vendedor.PreviewKeyDown

        If e.KeyValue = Keys.F9 Then
            btnImprimir_Click(sender, New System.EventArgs())
        End If

    End Sub

    Private Sub txtNumeroFactura_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Txt_Numero_Factura.PreviewKeyDown

        If e.KeyValue = Keys.F9 Then
            btnImprimir_Click(sender, New System.EventArgs())
        End If

    End Sub

    Private Sub datep_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Date_Fecha_Factura.PreviewKeyDown

        If e.KeyValue = Keys.F9 Then
            btnImprimir_Click(sender, New System.EventArgs())
        End If

    End Sub

    Private Sub CheckBox1_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Chb_Por_Mayor.PreviewKeyDown

        If e.KeyValue = Keys.F9 Then
            btnImprimir_Click(sender, New System.EventArgs())
        End If

    End Sub

    Private Sub txtCant_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Txt_Cantidad_Articulo.PreviewKeyDown

        If e.KeyValue = Keys.F9 Then
            btnImprimir_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.Escape And vp_prod_cant_temp <> "" Then
            Txt_Cantidad_Articulo.Text = vp_prod_cant_temp
        End If

    End Sub

    Private Sub txtPrecio_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Txt_Precio_Articulo.PreviewKeyDown

        If e.KeyValue = Keys.F9 Then
            btnImprimir_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.Escape And vp_prod_precio_temp <> "" Then
            Txt_Precio_Articulo.Text = vp_prod_precio_temp
        End If

    End Sub

    Private Sub txtImp_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Txt_Impuesto_Articulo.PreviewKeyDown

        If e.KeyValue = Keys.F9 Then
            btnImprimir_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.Escape And vp_prod_imp_temp <> "" Then
            Txt_Impuesto_Articulo.Text = vp_prod_imp_temp
        End If

    End Sub

    Private Sub txtSubt_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Txt_Subtotal_Articulo.PreviewKeyDown

        If e.KeyValue = Keys.F9 Then
            btnImprimir_Click(sender, New System.EventArgs())
        End If

    End Sub

    Private Sub Button1_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Btn_Solo_Guardar.PreviewKeyDown

        If e.KeyValue = Keys.F9 Then
            btnImprimir_Click(sender, New System.EventArgs())
        End If

    End Sub

    Private Sub txtSub_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Txt_Subtotal.PreviewKeyDown

        If e.KeyValue = Keys.F9 Then
            btnImprimir_Click(sender, New System.EventArgs())
        End If

    End Sub

    Private Sub txtDesFinal_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Txt_Descuento_Final.PreviewKeyDown

        If e.KeyValue = Keys.F9 Then
            btnImprimir_Click(sender, New System.EventArgs())
        End If

    End Sub

    Private Sub txtTotal_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Txt_Total.PreviewKeyDown

        If e.KeyValue = Keys.F9 Then
            btnImprimir_Click(sender, New System.EventArgs())
        End If

    End Sub

    Private Sub btnEliminar_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Btn_Eliminar.PreviewKeyDown

        If e.KeyValue = Keys.F9 Then
            btnImprimir_Click(sender, New System.EventArgs())
        End If

    End Sub

    Private Sub Button2_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Btn_Salir.PreviewKeyDown

        If e.KeyValue = Keys.F9 Then
            btnImprimir_Click(sender, New System.EventArgs())
        End If

    End Sub

    Private Sub txtCodigoCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Codigo_Cliente.KeyPress

        If e.KeyChar = ChrW(Keys.Add) Then
            e.Handled = True
        End If

    End Sub

    Private Sub Fr_Crea_Cotizacion_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

        If vp_estado = "UPDATEOPEN" Or vp_estado = "UPDATE" Then

            SEL_COT_MOD(vp_factura_id, Txt_Codigo_Cliente.Text, DGV_Comentarios, Cb_Vendedor, Lv_Id_Vendedor, Txt_Descuento.Text, Date_Fecha_Factura,
                         Txt_Numero_Factura.Text, Txt_Subtotal.Text, Txt_Total.Text, Txt_Descuento_Final.Text)
            SEL_CDET_MOD(vp_fact_auto, DGV_Facturas)
            calcular(Txt_Descuento.Text)
            Me.Text = "ACTUALIZACION DE COTIZACION DE CLIENTE: " & DGV_Comentarios.Rows(0).Cells(0).Value
            Txt_Codigo_Cliente.BackColor = Color.Yellow
            txt_codigo_articulo.Focus()
        End If


    End Sub

    Private Sub Lv_Clientes_Enter(sender As Object, e As EventArgs) Handles Lv_Clientes.Enter
        Try
            If Lv_Clientes.Items.Count = 1 Then
                seleccionaCliente()
            End If
        Catch ex As Exception
            Logger.e("Error con excepción", ex, New StackFrame(True))
        End Try
    End Sub

    Private Sub Lv_Clientes_KeyDown(sender As Object, e As KeyEventArgs) Handles Lv_Clientes.KeyDown

        If e.KeyData = Keys.Tab Then
            e.Handled = True
        End If

    End Sub

    Private Sub Lv_Clientes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Lv_Clientes.KeyPress

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

    Private Sub Lv_Clientes_Leave(sender As Object, e As EventArgs) Handles Lv_Clientes.Leave
        Lv_Clientes.Visible = False
    End Sub

    Private Sub Lv_Clientes_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Lv_Clientes.PreviewKeyDown

        If e.KeyData = Keys.Tab Then
            e.IsInputKey = True
        End If

        If e.Alt AndAlso e.KeyValue = Keys.H And DGV_Comentarios.Rows(0).Cells(0).Value <> "" Then
            btnHistorial_Click(sender, New EventArgs())
        End If

    End Sub

    Private Sub txt_barcode_Enter(sender As Object, e As EventArgs) Handles txt_barcode.Enter

        limpiarArt()
        txt_barcode.Clear()

    End Sub

    Private Sub txt_barcode_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_barcode.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
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

    Private Sub txt_barcode_Leave(sender As Object, e As EventArgs) Handles txt_barcode.Leave

        If Txt_Descripcion_Articulo.Text = "" Then
            txt_barcode.Text = "BARCODE"
        End If

    End Sub

    Private Sub txt_barcode_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles txt_barcode.PreviewKeyDown

        If e.Alt AndAlso e.KeyValue = Keys.H And DGV_Comentarios.Rows(0).Cells(0).Value <> "" Then
            btnHistorial_Click(sender, New EventArgs())
        End If

        If e.KeyValue = Keys.F9 And Btn_Imprimir.Enabled Then
            btnImprimir_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.Escape And vp_prod_id_temp <> "" Then
            vp_art_auto = vp_prod_aut_temp
            txt_codigo_articulo.Text = vp_prod_id_temp
            Txt_Descripcion_Articulo.Text = vp_prod_desc_temp
        ElseIf e.KeyData = Keys.Enter Then
            If txt_barcode.Text.Trim.Length > 1 Then
                If txt_barcode.Text.Trim.Substring(0, 2) = "**" Then
                    Dim precio As Double
                    txt_barcode.Text = txt_barcode.Text.Trim.Replace(".", ",")
                    Try
                        If DGV_Facturas.RowCount > 0 And DGV_Facturas.Rows(DGV_Facturas.Rows.Count - 1).Cells("c_descripcion_cot").Value <> "" Then
                            precio = txt_barcode.Text.Trim.Substring(2, txt_barcode.Text.Length - 2)
                            DGV_Facturas.Rows(DGV_Facturas.Rows.Count - 1).Cells("c_precio_cot").Value = convertir_formato_miles_decimales(precio)
                            calcular_subtotal(DGV_Facturas.Rows(DGV_Facturas.Rows.Count - 1).Cells("c_precio_cot").Value, DGV_Facturas.Rows(DGV_Facturas.Rows.Count - 1).Cells("c_cantidad_cot").Value,
                               DGV_Facturas.Rows(DGV_Facturas.Rows.Count - 1).Cells("c_impuesto_cot").Value, DGV_Facturas.Rows(DGV_Facturas.Rows.Count - 1).Cells("c_total_cot").Value, "")
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
                        If DGV_Facturas.RowCount > 0 And DGV_Facturas.Rows(DGV_Facturas.Rows.Count - 1).Cells("c_descripcion_cot").Value <> "" Then
                            cantidad = txt_barcode.Text.Trim.Substring(1, txt_barcode.Text.Length - 1)
                            DGV_Facturas.Rows(DGV_Facturas.Rows.Count - 1).Cells("c_cantidad_cot").Value = convertir_formato_miles_decimales(cantidad)
                            calcular_subtotal(DGV_Facturas.Rows(DGV_Facturas.Rows.Count - 1).Cells("c_precio_cot").Value, DGV_Facturas.Rows(DGV_Facturas.Rows.Count - 1).Cells("c_cantidad_cot").Value,
                             DGV_Facturas.Rows(DGV_Facturas.Rows.Count - 1).Cells("c_impuesto_cot").Value, DGV_Facturas.Rows(DGV_Facturas.Rows.Count - 1).Cells("c_total_cot").Value, "")
                        End If
                        calcular(Txt_Descuento.Text)
                        txt_barcode.Clear()
                    Catch ex As Exception
                        txt_barcode.Clear()
                    End Try
                End If


            End If
            Dim precio_actual As String = Nothing
            If txt_barcode.Text.Trim <> "" And txt_barcode.Text <> "BARCODE" Then
                SEL_BARCODE_FACTURA(txt_barcode.Text.Trim, txt_codigo_articulo.Text, Txt_Descripcion_Articulo.Text, precio_actual, vp_precio2, vp_precio3, vp_preMayor, vp_art_auto)
                Txt_Precio_Articulo.Text = precio_actual

                If Txt_Descripcion_Articulo.Text.Trim <> "" Then
                    Txt_Cantidad_Articulo.Text = convertir_formato_miles_decimales("1")
                    calcular_sub()
                    Dim art_ingresado As Boolean = False
                    For i As Integer = 0 To DGV_Facturas.Rows.Count - 1
                        If DGV_Facturas.Rows(i).Cells("c_id_cot").Value = vp_art_auto Then
                            art_ingresado = True
                            DGV_Facturas.Rows(i).Cells("c_cantidad_cot").Value = convertir_formato_miles_decimales(CDbl(DGV_Facturas.Rows(i).Cells("c_cantidad_cot").Value) + 1)
                            DGV_Facturas.Rows(i).Cells("c_precio_cot").Value = convertir_formato_miles_decimales(Txt_Precio_Articulo.Text)
                            calcular_subtotal(DGV_Facturas.Rows(i).Cells("c_precio_cot").Value, DGV_Facturas.Rows(i).Cells("c_cantidad_cot").Value,
                                DGV_Facturas.Rows(i).Cells("c_impuesto_cot").Value, DGV_Facturas.Rows(i).Cells("c_total_cot").Value, "")
                            calcular(Txt_Descuento.Text)
                            limpiarArt()
                            txt_barcode.Clear()
                            txt_barcode.Focus()
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
                txt_barcode.Focus()
            End If

        End If

    End Sub

    Private Sub Txt_Codigo_Articulo_KeyDown(sender As Object, e As KeyEventArgs)

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        ElseIf e.KeyData = Keys.Tab Then
            e.Handled = True
        End If

    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles txt_codigo_articulo.Leave
        Try
            If txt_codigo_articulo.Text <> "" Then
                If Lv_Busqueda_Articulos.Visible Then
                    Me.Lv_Busqueda_Articulos.Focus()
                    If Lv_Busqueda_Articulos.Items.Count > 0 Then
                        Lv_Busqueda_Articulos.TopItem.Selected = True
                    End If
                Else
                    txt_barcode.Focus()
                End If
            Else
                txt_barcode.Focus()
            End If

        Catch ex As Exception
            Logger.e("Error con excepción", ex, New StackFrame(True))
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub txt_codigo_articulo_Enter(sender As Object, e As EventArgs) Handles txt_codigo_articulo.Enter

        Lv_Clientes.Visible = False
        If DGV_Facturas.Rows.Count > 0 Then
            DGV_Facturas.CurrentCell = DGV_Facturas.Rows(DGV_Facturas.RowCount - 1).Cells(0)
            DGV_Facturas.Rows(DGV_Facturas.RowCount - 1).Selected = True
        End If
    End Sub

    Private Sub txt_codigo_articulo_KeyDown_1(sender As Object, e As KeyEventArgs) Handles txt_codigo_articulo.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub txt_codigo_articulo_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_codigo_articulo.KeyUp

        Try
            Lv_Busqueda_Articulos.Items.Clear()
            Dim busqueda As String
            If txt_codigo_articulo.Text.Trim <> "" And Txt_Descripcion_Articulo.ReadOnly Then
                'LLENA LVBUSQUEDA CON LOS ULTIMOS PRODUCTOS COMPRADOS POR EL CLIENTE
                busqueda = Regex.Replace(txt_codigo_articulo.Text.Trim, "\s{2,}", " ")
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
                If Lv_Busqueda_Articulos.Items.Count > 0 And txt_codigo_articulo.SelectedText.Length = 0 Then
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

    Private Sub txt_codigo_articulo_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles txt_codigo_articulo.PreviewKeyDown


        If e.Alt AndAlso e.KeyValue = Keys.H And DGV_Comentarios.Rows(0).Cells(0).Value <> "" Then
            btnHistorial_Click(sender, New EventArgs())
        End If

        If e.KeyValue = Keys.F9 And Btn_Imprimir.Enabled Then
            btnImprimir_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.Escape And vp_prod_id_temp <> "" Then
            vp_art_auto = vp_prod_aut_temp
            txt_codigo_articulo.Text = vp_prod_id_temp
            Txt_Descripcion_Articulo.Text = vp_prod_desc_temp
        End If


    End Sub

    Private Sub DGV_Facturas_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Facturas.CellEndEdit
        flag_celda_editada = True
        Try

            'Comprueba los valores de la columna precio
            If DGV_Facturas.CurrentCell.ColumnIndex = c_precio_cot.Index Then

                If DGV_Facturas.CurrentRow.Cells("c_descripcion_cot").Value Is Nothing Then
                    DGV_Facturas.CurrentCell.Value = ""
                ElseIf DGV_Facturas.CurrentCell.Value Is Nothing And DGV_Facturas.CurrentRow.Cells("c_descripcion_cot").Value <> "" Then
                    DGV_Facturas.CurrentCell.Value = convertir_formato_miles_decimales("0")
                    calcular_subtotal(DGV_Facturas.Rows(e.RowIndex).Cells("c_precio_cot").Value, DGV_Facturas.Rows(e.RowIndex).Cells("c_cantidad_cot").Value,
                                    DGV_Facturas.Rows(e.RowIndex).Cells("c_impuesto_cot").Value, DGV_Facturas.Rows(e.RowIndex).Cells("c_total_cot").Value, "")
                Else
                    DGV_Facturas.CurrentCell.Value = convertir_formato_miles_decimales(DGV_Facturas.CurrentCell.Value)
                    calcular_subtotal(DGV_Facturas.Rows(e.RowIndex).Cells("c_precio_cot").Value, DGV_Facturas.Rows(e.RowIndex).Cells("c_cantidad_cot").Value,
                                    DGV_Facturas.Rows(e.RowIndex).Cells("c_impuesto_cot").Value, DGV_Facturas.Rows(e.RowIndex).Cells("c_total_cot").Value, "")

                End If

                calcular(Txt_Descuento.Text)

                'Comprueba los valores de la columna cantidad
            ElseIf DGV_Facturas.CurrentCell.ColumnIndex = c_cantidad_cot.Index Then


                If DGV_Facturas.CurrentRow.Cells("c_descripcion_cot").Value Is Nothing Then
                    DGV_Facturas.CurrentCell.Value = ""
                ElseIf DGV_Facturas.CurrentCell.Value Is Nothing And DGV_Facturas.CurrentRow.Cells("c_descripcion_cot").Value <> "" Then
                    DGV_Facturas.CurrentCell.Value = convertir_formato_miles_decimales("0")
                    calcular_subtotal(DGV_Facturas.Rows(e.RowIndex).Cells("c_precio_cot").Value, DGV_Facturas.Rows(e.RowIndex).Cells("c_cantidad_cot").Value,
                                    DGV_Facturas.Rows(e.RowIndex).Cells("c_impuesto_cot").Value, DGV_Facturas.Rows(e.RowIndex).Cells("c_total_cot").Value, "")
                Else
                    DGV_Facturas.CurrentCell.Value = convertir_formato_miles_decimales(DGV_Facturas.CurrentCell.Value)
                    calcular_subtotal(DGV_Facturas.Rows(e.RowIndex).Cells("c_precio_cot").Value, DGV_Facturas.Rows(e.RowIndex).Cells("c_cantidad_cot").Value,
                                    DGV_Facturas.Rows(e.RowIndex).Cells("c_impuesto_cot").Value, DGV_Facturas.Rows(e.RowIndex).Cells("C_Total_cot").Value, "")
                End If
                calcular(Txt_Descuento.Text)

                'Comprueba los valores de la columna impuesto
            ElseIf DGV_Facturas.CurrentCell.ColumnIndex = c_impuesto_cot.Index Then

                If DGV_Facturas.CurrentRow.Cells("c_descripcion_cot").Value Is Nothing Then
                    DGV_Facturas.CurrentCell.Value = ""
                ElseIf DGV_Facturas.CurrentCell.Value Is Nothing And DGV_Facturas.CurrentRow.Cells("c_descripcion_cot").Value <> "" Then
                    DGV_Facturas.CurrentCell.Value = convertir_formato_miles_decimales("0")
                    calcular_subtotal(DGV_Facturas.Rows(e.RowIndex).Cells("c_precio_cot").Value, DGV_Facturas.Rows(e.RowIndex).Cells("c_cantidad_cot").Value,
                                    DGV_Facturas.Rows(e.RowIndex).Cells("c_impuesto_cot").Value, DGV_Facturas.Rows(e.RowIndex).Cells("c_total_cot").Value, "")
                Else
                    DGV_Facturas.CurrentCell.Value = convertir_formato_miles_decimales(DGV_Facturas.CurrentCell.Value)
                    calcular_subtotal(DGV_Facturas.Rows(e.RowIndex).Cells("c_precio_cot").Value, DGV_Facturas.Rows(e.RowIndex).Cells("c_cantidad_cot").Value,
                                    DGV_Facturas.Rows(e.RowIndex).Cells("c_impuesto_cot").Value, DGV_Facturas.Rows(e.RowIndex).Cells("c_total_cot").Value, "")
                End If
                calcular(Txt_Descuento.Text)

            ElseIf Lv_Busqueda_Articulos.Visible Then
                Me.Lv_Busqueda_Articulos.Focus()
                If Lv_Busqueda_Articulos.Items.Count > 0 Then
                    Lv_Busqueda_Articulos.TopItem.Selected = True
                End If
            End If

            DGV_Facturas.CurrentCell = DGV_Facturas.Rows(DGV_Facturas.RowCount - 1).Cells(0)
        Catch ex As Exception
            If ex.ToString.Contains("System.InvalidOperationException") Then
            Else
                MsgBox(ex.ToString)
                Logger.e("Error con excepción", ex, New StackFrame(True))
            End If
        End Try

        txt_barcode.Focus()

    End Sub

    Private Sub DGV_Facturas_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DGV_Facturas.EditingControlShowing
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

    Private WithEvents cellTextBox As DataGridViewTextBoxEditingControl

    Private Sub cellTextBox_KeyDown(
       ByVal sender As Object,
       ByVal e As System.Windows.Forms.KeyEventArgs) Handles cellTextBox.KeyDown

    End Sub

    Private Sub cellTextBox_KeyUp(
        ByVal sender As Object,
        ByVal e As System.Windows.Forms.KeyEventArgs) Handles cellTextBox.KeyUp

    End Sub
    Private Sub Tb_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub

    Private Sub DGV_Facturas_SelectionChanged(sender As Object, e As EventArgs) Handles DGV_Facturas.SelectionChanged
        If flag_celda_editada Then
            DGV_Facturas.CurrentCell = DGV_Facturas.Rows(DGV_Facturas.RowCount - 1).Cells(0)
            DGV_Facturas.Rows(DGV_Facturas.RowCount - 1).Selected = True
            flag_celda_editada = False
        End If
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
        If DGV_Facturas.IsCurrentCellInEditMode And (DGV_Facturas.CurrentCell.ColumnIndex = c_precio_cot.Index Or DGV_Facturas.CurrentCell.ColumnIndex = c_cantidad_cot.Index Or
           DGV_Facturas.CurrentCell.ColumnIndex = c_impuesto_cot.Index) Then

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

    Private Sub Fr_Crea_Cotizacion_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        DGV_Facturas.Columns(1).Width = DGV_Facturas.Size.Width - 697
    End Sub
End Class