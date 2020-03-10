Imports System.Globalization
Imports System.Threading
Imports MySql.Data.MySqlClient

Module MysqlCon

    Dim MysqlCon As MySqlConnection
    Dim cmd As MySqlCommand
    Dim dr As MySqlDataReader
    Public _ClienteServidor = ""

    'REVISA INGRESO DE DETALLE DE FACTURA SATISFACORIO
    Dim fdet_resultado As Double = False

    Public Sub conectarse()

        'CONNECCION DE LA VERSION DE PRUEBAS
        'MysqlCon = New MySqlConnection
        'MysqlCon.ConnectionString = "server=localhost;userid=root;password=BDFERIA;database=FERIA_TEST;Allow Zero Datetime=True;Convert Zero Datetime=True;"

        'CONECCION DE LA VERSION FINAL
        MysqlCon = New MySqlConnection

        'MysqlCon.ConnectionString = "server=localhost;userid=root;password=BDFERIA;database=BDFERIA;Allow Zero Datetime=True;Convert Zero Datetime=True;"
        '_ClienteServidor = " SERVIDOR"

        MysqlCon.ConnectionString = "server=186.15.40.161;userid=root;password=BDFERIA;database=BDFERIA;Allow Zero Datetime=True;Convert Zero Datetime=True;"
        _ClienteServidor = " CLIENTE"

    End Sub

    '*************************************************** FUNCIONES DE INSERTAR MYSQL ****************************************************************** 

    'INSERTA UN NUEVO VENDEDOR
    Public Sub INS_VENDEDOR(ByVal p_codigo As String, ByVal p_nombre As String, ByRef p_resultado As String)

        Dim consulta As String = "INS_VENDEDOR"
        Try
            MysqlCon.Open()
            cmd = New MySqlCommand(consulta, MysqlCon)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@p_id", p_codigo)
            cmd.Parameters.AddWithValue("@p_nombre", p_nombre)
            cmd.ExecuteNonQuery()
            p_resultado = "Vendedor Guardado"
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
            p_resultado = "Error al guardar los datos"
        Finally
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'INGRESO DE CLIENTE
    Public Sub INS_CLIENTE(ByVal p_codigo As String, ByVal p_nombre As String, ByVal p_direccion_1 As String,
                           ByVal p_direccion_2 As String, ByVal p_direccion_3 As String, ByVal p_telefono As String,
                           ByVal p_advertencia As String, ByVal p_tipo_printer As Boolean, ByVal p_vendedor As Integer,
                           ByVal p_cedula_cliente As String, ByVal p_correo As String)

        Dim consulta As String = "INS_CLIENTE"
        Try
            MysqlCon.Open()
            cmd = New MySqlCommand(consulta, MysqlCon)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@p_id", p_codigo)
            cmd.Parameters.AddWithValue("@p_nombre", p_nombre)
            cmd.Parameters.AddWithValue("@p_direc", p_direccion_1)
            'cmd.Parameters.AddWithValue("@dir2", dir2)
            'cmd.Parameters.AddWithValue("@dir3", dir3)
            cmd.Parameters.AddWithValue("@p_tel", p_telefono)
            cmd.Parameters.AddWithValue("@p_adv", p_advertencia)
            cmd.Parameters.AddWithValue("@p_printer", p_tipo_printer)
            cmd.Parameters.AddWithValue("@p_vendedor", p_vendedor)
            cmd.Parameters.AddWithValue("@p_cedula_cliente", p_cedula_cliente)
            cmd.Parameters.AddWithValue("@p_correo_cliente", p_correo)
            cmd.ExecuteNonQuery()
            MsgBox("CLIENTE AGREGADO", MsgBoxStyle.Information, "CLIENTE")
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'INGRESA UN NUEVO ARTICULO
    Public Sub INS_ARTICULO(ByVal p_codigo As String, ByVal p_descripcion As String, ByVal p_precio1 As Double,
                           ByVal p_precio2 As Double, ByVal p_precio3 As Double, ByVal p_precio4 As Double,
                            ByVal p_barcode As String, ByVal p_impuesto As Double)

        Dim consulta As String = "INS_ARTICULO"

        Try
            MysqlCon.Open()
            cmd = New MySqlCommand(consulta, MysqlCon)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@p_id", p_codigo)
            cmd.Parameters.AddWithValue("@p_nombre", p_descripcion)
            cmd.Parameters.AddWithValue("@p_pre1", p_precio1)
            cmd.Parameters.AddWithValue("@p_pre2", p_precio2)
            cmd.Parameters.AddWithValue("@p_pre3", p_precio3)
            cmd.Parameters.AddWithValue("@p_pre4", p_precio4)
            cmd.Parameters.AddWithValue("@p_tipo", "SIN CATEGORIA")
            cmd.Parameters.AddWithValue("@p_costo", 0)
            cmd.Parameters.AddWithValue("@p_barcode", p_barcode)
            cmd.Parameters.AddWithValue("@p_imp", False)
            cmd.Parameters.AddWithValue("@p_impuesto", p_impuesto)
            cmd.ExecuteNonQuery()

            MsgBox("Articulo Agregado")
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'INGRESA UN NUEVO CONDIMENTO
    Public Sub INS_CONDIMENTO(ByVal p_codigo As String, ByVal p_descripcion As String, ByVal p_precio1 As Double,
                          ByVal p_precio4 As Double, ByVal p_impuesto As Boolean, ByVal p_tipo As String,
                              ByVal p_costo As Double)

        Dim consulta As String = "INS_ARTICULO"

        Try
            MysqlCon.Open()
            cmd = New MySqlCommand(consulta, MysqlCon)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@p_id", p_codigo)
            cmd.Parameters.AddWithValue("@p_nombre", p_descripcion)
            cmd.Parameters.AddWithValue("@p_pre1", p_precio1)
            cmd.Parameters.AddWithValue("@p_pre2", p_precio1)
            cmd.Parameters.AddWithValue("@p_pre3", p_precio1)
            cmd.Parameters.AddWithValue("@p_pre4", p_precio4)
            cmd.Parameters.AddWithValue("@p_imp", p_impuesto)
            cmd.Parameters.AddWithValue("@p_costo", p_costo)
            cmd.Parameters.AddWithValue("@p_tipo", p_tipo)
            cmd.ExecuteNonQuery()
            MsgBox("Articulo Agregado")
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'INGRESO DE FACTURA CANCELADA
    Public Sub INS_FACTURA_CERRADA(ByVal p_numero_factura As Integer, ByVal p_id_cliente As Integer,
                                   ByVal p_id_vendedor As Integer, ByVal p_comentario_1 As String,
                                   ByVal p_comentario_2 As String, ByVal p_subtotal As Double, ByVal p_leyenda As String,
                                   ByVal p_descuento As Double, ByVal p_total As Double, ByVal p_fecha As DateTime, ByVal p_impuesto As Double,
                                   ByVal p_pago As Double, ByVal p_open As Boolean, ByVal p_cedula_cliente As String, ByVal p_tipo_factura As String,
                                   ByVal p_medio_pago As String, ByVal p_fecha_vencimiento As String, ByVal p_Iva As Double,
                                   ByVal p_Oems As String)

        Dim consulta As String = "INS_FACTURA"
        Try
            MysqlCon.Open()
            cmd = New MySqlCommand(consulta, MysqlCon)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@p_num", p_numero_factura)
            cmd.Parameters.AddWithValue("@p_ven", p_id_vendedor)
            cmd.Parameters.AddWithValue("@p_cli", p_id_cliente)
            cmd.Parameters.AddWithValue("@p_leyenda", p_leyenda)
            cmd.Parameters.AddWithValue("@p_com1", p_comentario_1)
            cmd.Parameters.AddWithValue("@p_com2", p_comentario_2)
            cmd.Parameters.AddWithValue("@p_sub", p_subtotal)
            cmd.Parameters.AddWithValue("@p_desc", p_descuento)
            cmd.Parameters.AddWithValue("@p_total", p_total)
            cmd.Parameters.AddWithValue("@p_fecha", p_fecha)
            cmd.Parameters.AddWithValue("@p_imp", p_impuesto)
            cmd.Parameters.AddWithValue("@p_pago", p_pago)
            cmd.Parameters.AddWithValue("@p_open", p_open)
            cmd.Parameters.AddWithValue("@p_cedula_cliente", p_cedula_cliente)
            cmd.Parameters.AddWithValue("@p_tipo_factura", p_tipo_factura)
            cmd.Parameters.AddWithValue("@p_medio_pago", p_medio_pago)
            cmd.Parameters.AddWithValue("@p_fecha_vencimiento", p_fecha_vencimiento)
            cmd.Parameters.AddWithValue("@p_Iva", p_Iva)
            cmd.Parameters.AddWithValue("@p_Oems", p_Oems)

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'INGRESA LA FACTURA EN EL HISTORIAL DE CAMBIOS
    Public Sub INS_CAMBIO_FACTURA(ByVal p_numero_factura As Integer, ByVal p_id_cliente As Integer,
                                   ByVal p_id_vendedor As Integer, ByVal p_comentario_1 As String,
                                   ByVal p_comentario_2 As String, ByVal p_subtotal As Double, ByVal p_leyenda As String,
                           ByVal p_descuento As Double, ByVal p_total As Double, ByVal p_fecha As DateTime, ByVal p_impuesto As Double,
                           ByVal p_pago As Double, ByVal p_open As Boolean, ByVal p_numero_cambio As Integer, ByVal p_fact_id As Integer)
        Dim consulta As String = "INS_CAMBIO_FACTURA"
        Try
            MysqlCon.Open()
            cmd = New MySqlCommand(consulta, MysqlCon)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@p_num", p_numero_factura)
            cmd.Parameters.AddWithValue("@p_ven", p_id_vendedor)
            cmd.Parameters.AddWithValue("@p_cli", p_id_cliente)
            cmd.Parameters.AddWithValue("@p_leyenda", p_leyenda)
            cmd.Parameters.AddWithValue("@p_com1", p_comentario_1)
            cmd.Parameters.AddWithValue("@p_com2", p_comentario_2)
            cmd.Parameters.AddWithValue("@p_sub", p_subtotal)
            cmd.Parameters.AddWithValue("@p_desc", p_descuento)
            cmd.Parameters.AddWithValue("@p_total", p_total)
            cmd.Parameters.AddWithValue("@p_fecha", p_fecha)
            cmd.Parameters.AddWithValue("@p_imp", p_impuesto)
            cmd.Parameters.AddWithValue("@p_pago", p_pago)
            cmd.Parameters.AddWithValue("@p_open", p_open)
            cmd.Parameters.AddWithValue("@p_cambio", p_numero_cambio)
            cmd.Parameters.AddWithValue("@p_fact_id", p_fact_id)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'INGRESA UNA NUEVA COTIZACION
    Public Sub INS_COTIZACION(ByVal p_numero_factura As Integer, ByVal p_id_cliente As Integer,
                                  ByVal p_id_vendedor As Integer, ByVal p_comentario_1 As String,
                                  ByVal p_comentario_2 As String, ByVal p_subtotal As Double, ByVal p_leyenda As String,
                          ByVal p_descuento As Double, ByVal p_total As Double, ByVal p_fecha As DateTime, ByVal p_impuesto As Double)
        Dim consulta As String = "INS_COTIZACION"
        Try
            MysqlCon.Open()
            cmd = New MySqlCommand(consulta, MysqlCon)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@p_num", p_numero_factura)
            cmd.Parameters.AddWithValue("@p_ven", p_id_vendedor)
            cmd.Parameters.AddWithValue("@p_cli", p_id_cliente)
            cmd.Parameters.AddWithValue("@p_leyenda", p_leyenda)
            cmd.Parameters.AddWithValue("@p_com1", p_comentario_1)
            cmd.Parameters.AddWithValue("@p_com2", p_comentario_2)
            cmd.Parameters.AddWithValue("@p_sub", p_subtotal)
            cmd.Parameters.AddWithValue("@p_desc", p_descuento)
            cmd.Parameters.AddWithValue("@p_total", p_total)
            cmd.Parameters.AddWithValue("@p_fecha", p_fecha)
            cmd.Parameters.AddWithValue("@p_imp", p_impuesto)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'INGRESO DE FACTURA ABIERTA
    Public Sub INS_FACTURA_ABIERTA(ByVal p_numero_factura As Integer, ByVal p_vendedor As Integer, ByVal p_cliente As Integer,
                           ByVal p_comentario1 As String, ByVal p_comentario2 As String, ByVal p_subtotal As Double, ByVal p_leyenda As String,
                           ByVal p_descuento As Double, ByVal p_total As Double, ByVal p_fecha As DateTime, ByVal p_impuesto As Double,
                                   ByVal p_isOpen As Integer)

        Dim consulta As String = "INS_FACTURA"
        Try
            MysqlCon.Open()
            cmd = New MySqlCommand(consulta, MysqlCon)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@consecutivo", p_numero_factura)
            cmd.Parameters.AddWithValue("@vend", p_vendedor)
            cmd.Parameters.AddWithValue("@cliente", p_cliente)
            cmd.Parameters.AddWithValue("@leyenda", p_leyenda)
            cmd.Parameters.AddWithValue("@coment1", p_comentario1)
            cmd.Parameters.AddWithValue("@coment2", p_comentario2)
            cmd.Parameters.AddWithValue("@subtotal", p_subtotal)
            cmd.Parameters.AddWithValue("@descu", p_descuento)
            cmd.Parameters.AddWithValue("@total", p_total)
            cmd.Parameters.AddWithValue("@isOpen", p_isOpen)
            cmd.Parameters.AddWithValue("@fecha", p_fecha)
            cmd.Parameters.AddWithValue("@imp", p_impuesto)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'INGRESO DE FACTURA DETALLE
    Public Sub INS_FACT_DETALLE(ByVal p_numero_factura As Integer, ByVal p_articulo_id As Integer, ByVal p_cantidad As Double,
                           ByVal p_precio As Double, ByVal p_impuesto As Double, ByVal p_subtotal As Double, ByVal p_fecha As DateTime)

        Dim consulta As String = "INS_FACT_DETALLE"

        Try
            MysqlCon.Open()
            cmd = New MySqlCommand(consulta, MysqlCon)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@p_fac_id", p_numero_factura)
            cmd.Parameters.AddWithValue("@p_art_id", p_articulo_id)
            cmd.Parameters.AddWithValue("@p_cant", p_cantidad)
            cmd.Parameters.AddWithValue("@p_precio", p_precio)
            cmd.Parameters.AddWithValue("@p_imp", p_impuesto)
            cmd.Parameters.AddWithValue("@p_sub", p_subtotal)
            cmd.Parameters.AddWithValue("@p_fecha", p_fecha)
            cmd.ExecuteNonQuery()
            fdet_resultado = True
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'INGRESO DE CAMBIOS EN FACTURA DETALLE DEL HISTORIAL
    Public Sub INS_CAMBIO_FACT_DETALLE(ByVal p_numero_factura As Integer, ByVal p_articulo_id As Integer, ByVal p_cantidad As Double,
                           ByVal p_precio As Double, ByVal p_impuesto As Double, ByVal p_subtotal As Double, ByVal p_fecha As DateTime)

        Dim consulta As String = "INS_CAMBIO_FACT_DETALLE"

        Try
            MysqlCon.Open()
            cmd = New MySqlCommand(consulta, MysqlCon)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@p_fac_id", p_numero_factura)
            cmd.Parameters.AddWithValue("@p_art_id", p_articulo_id)
            cmd.Parameters.AddWithValue("@p_cant", p_cantidad)
            cmd.Parameters.AddWithValue("@p_precio", p_precio)
            cmd.Parameters.AddWithValue("@p_imp", p_impuesto)
            cmd.Parameters.AddWithValue("@p_sub", p_subtotal)
            cmd.Parameters.AddWithValue("@p_fecha", p_fecha)
            cmd.ExecuteNonQuery()
            fdet_resultado = True
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'INGRESA LOS DETALLES DE LA COTIZACION
    Public Sub INS_COT_DETALLE(ByVal p_numero_cotizacion As Integer, ByVal p_articulo_id As Integer, ByVal p_cantidad As Double,
                           ByVal p_precio As Double, ByVal p_impuesto As Double, ByVal p_subtotal As Double)

        Dim consulta As String = "INS_COT_DETALLE"
        Try
            MysqlCon.Open()
            cmd = New MySqlCommand(consulta, MysqlCon)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@p_fac_id", p_numero_cotizacion)
            cmd.Parameters.AddWithValue("@p_art_id", p_articulo_id)
            cmd.Parameters.AddWithValue("@p_cant", p_cantidad)
            cmd.Parameters.AddWithValue("@p_precio", p_precio)
            cmd.Parameters.AddWithValue("@p_imp", p_impuesto)
            cmd.Parameters.AddWithValue("@p_sub", p_subtotal)
            cmd.ExecuteNonQuery()
            fdet_resultado = True
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'INSERCION DE HISTORICO DE IMPRESIONES
    Public Sub INS_HIST_PRINT(ByVal p_numero_factura As Integer, ByVal p_fecha As DateTime, ByVal p_cantidad As Integer,
                              ByVal p_tipo As String, ByVal p_comentario As String, ByVal p_impresora As String)

        Dim consulta As String = "INS_PRINT"

        Try
            MysqlCon.Open()
            cmd = New MySqlCommand(consulta, MysqlCon)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@p_fact", p_numero_factura)
            cmd.Parameters.AddWithValue("@p_fecha", p_fecha)
            cmd.Parameters.AddWithValue("@p_cant", p_cantidad)
            cmd.Parameters.AddWithValue("@p_comentario", p_comentario)
            cmd.Parameters.AddWithValue("@p_tipo", p_tipo)
            cmd.Parameters.AddWithValue("@p_tipo_impresora", p_impresora)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'Ingresa la configuracion inicial del sistema
    Public Sub INS_CONFIG(ByVal p_nombre_empresa As String)

        Dim consulta As String = "INS_CONFIG"

        Try
            MysqlCon.Open()
            cmd = New MySqlCommand(consulta, MysqlCon)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@p_nombre_empresa", p_nombre_empresa)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    '*************************************************** FUNCIONES DE CONSULTA MYSQL ****************************************************************** 

    'REVISO SI EXISTE UN CLIENTE
    Public Sub SEL_CLIENTE(ByVal p_id_cliente As String, ByRef p_nombre_cliente As String)

        cmd = New MySqlCommand("SEL_CLIENTE", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_id", p_id_cliente)
        cmd.Parameters.Add("@p_resp", MySqlDbType.VarChar, 100)
        cmd.Parameters("@p_resp").Direction = ParameterDirection.Output
        Try
            MysqlCon.Open()
            cmd.ExecuteNonQuery()
            p_nombre_cliente = cmd.Parameters("@p_resp").Value
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'REVISO EL NOMBRE DEL VENDEDOR
    Public Sub SEL_VENDEDOR(ByVal p_id_vendedor As String, ByRef p_nombre_vendedor As String)

        cmd = New MySqlCommand("SEL_VENDEDOR", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_id", p_id_vendedor)
        cmd.Parameters.Add("@p_resp", MySqlDbType.VarChar, 30)
        cmd.Parameters("@p_resp").Direction = ParameterDirection.Output
        Try
            MysqlCon.Open()
            cmd.ExecuteNonQuery()
            p_nombre_vendedor = cmd.Parameters("@p_resp").Value
        Catch ex As Exception
            Logger.e("Error con excepción", ex, New StackFrame(True))
            MsgBox(ex.ToString)
        Finally
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'REVISO SI EXISTE UN ARTICULO
    Public Sub SEL_ARTICULO(ByVal p_id_articulo As String, ByRef p_nombre_articulo As String)

        cmd = New MySqlCommand("SEL_ARTICULO", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_id", p_id_articulo)
        cmd.Parameters.Add("@p_resp", MySqlDbType.VarChar, 50)
        cmd.Parameters("@p_resp").Direction = ParameterDirection.Output
        Try
            MysqlCon.Open()
            cmd.ExecuteNonQuery()
            p_nombre_articulo = cmd.Parameters("@p_resp").Value
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    Public Sub SEL_CLIENTE_AUTO(ByVal p_id_factura As Integer, ByRef p_cliente_id As Integer)

        cmd = New MySqlCommand("SEL_CLIENTE_AUTO", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_id", p_id_factura)
        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            While (dr.Read)
                p_cliente_id = dr(0)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'CUENTA LA CANTIDAD DE PEDIDOS PENDIENTES DE CONVERTIR A FACTURA
    Public Sub SEL_CUENTA_PEDIDOS_PENDIENTES(ByRef p_cantidad As Integer)

        cmd = New MySqlCommand("SEL_CUENTA_PEDIDOS_PENDIENTES", MysqlCon)
        dr = Nothing
        p_cantidad = 0
        cmd.CommandType = CommandType.StoredProcedure
        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            While (dr.Read)
                p_cantidad = dr(0)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally

            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    Public Sub SEL_PEDIDOS_ID(ByRef p_cantidad As List(Of Integer))

        cmd = New MySqlCommand("SEL_PEDIDOS_ID", MysqlCon)
        dr = Nothing
        p_cantidad.Clear()
        cmd.CommandType = CommandType.StoredProcedure
        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            While (dr.Read)
                p_cantidad.Add(dr(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally

            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    Public Sub SEL_PEDIDO_DATOS(ByVal p_id As Integer, ByRef p_cliente_id As Integer, ByRef p_fecha As DateTimePicker, ByRef p_direccion As String, ByRef p_total As Double)

        cmd = New MySqlCommand("SEL_PEDIDO_DATOS", MysqlCon)
        dr = Nothing
        cmd.Parameters.AddWithValue("p_id", p_id)
        cmd.CommandType = CommandType.StoredProcedure
        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            While (dr.Read)
                p_cliente_id = dr(0)
                p_fecha.Value = dr(1).ToString
                If Not IsDBNull(dr(2)) Then p_direccion = dr(2)
                p_total = dr(3)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'SELECCIONA EL NUMERO DE FACTURA
    Public Sub SEL_FACT_AUTO(ByVal p_id_factura As Integer, ByRef p_auto_factura As Integer, ByVal p_fecha As DateTime)

        cmd = New MySqlCommand("SEL_FACT_AUTO", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_id", p_id_factura)
        cmd.Parameters.AddWithValue("@p_fecha", p_fecha)
        cmd.Parameters.Add("@p_resp", MySqlDbType.Int32)
        cmd.Parameters("@p_resp").Direction = ParameterDirection.Output
        Try
            MysqlCon.Open()
            cmd.ExecuteNonQuery()
            p_auto_factura = cmd.Parameters("@p_resp").Value
        Catch ex As Exception
            MsgBox(ex.ToString)
            p_auto_factura = 0
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'SELECCIONA EL NUMERO DE FACTURA DEL HISTORIAL
    Public Sub SEL_CAMBIO_FACT_AUTO(ByVal p_id_factura As Integer, ByRef p_auto_factura As Integer, ByVal p_cambio As Integer)

        cmd = New MySqlCommand("SEL_CAMBIO_FACT_AUTO", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_id", p_id_factura)
        cmd.Parameters.AddWithValue("@p_cambio", p_cambio)
        cmd.Parameters.Add("@p_resp", MySqlDbType.Int32)
        cmd.Parameters("@p_resp").Direction = ParameterDirection.Output
        Try
            MysqlCon.Open()
            cmd.ExecuteNonQuery()
            p_auto_factura = cmd.Parameters("@p_resp").Value
        Catch ex As Exception
            MsgBox(ex.ToString)
            p_auto_factura = 0
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'SELECCIONA EL NOMBRE DE LAS IMPRESORAS
    Public Sub SEL_IMPRESORA(ByRef p_impresoraTermica As String, ByRef p_impresoraMatriz As String,
                             ByRef p_usarImpresoraTermica As Boolean, ByRef p_ImprimeLinea As Integer)

        cmd = New MySqlCommand("SEL_IMPRESORA", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                While (dr.Read)
                    p_usarImpresoraTermica = dr(0)
                    p_impresoraMatriz = dr(1)
                    p_impresoraTermica = dr(2)
                    p_ImprimeLinea = dr(3)
                End While
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            If Not IsNothing(dr) Then dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'SELECCIONA EL ID DE LA COTIZACION
    Public Sub SEL_COT_AUTO(ByVal p_id As Integer, ByRef p_auto As Integer, ByVal p_fecha As DateTime)

        cmd = New MySqlCommand("SEL_COT_AUTO", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_id", p_id)
        cmd.Parameters.AddWithValue("@p_fecha", p_fecha)
        cmd.Parameters.Add("@p_resp", MySqlDbType.Int32)
        cmd.Parameters("@p_resp").Direction = ParameterDirection.Output
        Try
            MysqlCon.Open()
            cmd.ExecuteNonQuery()
            p_auto = cmd.Parameters("@p_resp").Value
        Catch ex As Exception
            MsgBox(ex.ToString)
            p_auto = 0
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'SELECCIONA EL VENDEDOR POR FECHAS
    Public Sub SEL_FACT_VEND_BUSQ(ByVal p_fecha_inicio As Date, ByVal p_fecha_final As Date)

        cmd = New MySqlCommand("SEL_FACT_VEND_BUSQ", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_fechaIn", p_fecha_inicio)
        cmd.Parameters.AddWithValue("@p_fechaOut", p_fecha_final)

        Try
            MysqlCon.Open()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'SELECCIONO TODOS LOS VENDEDORES ACTIVOS
    'FORM CREARFACTURAS
    Public Sub SEL_VENDEDORES(ByRef p_CB As ComboBox, ByRef p_LV As ListView)

        cmd = New MySqlCommand("SEL_VENDEDORES", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure

        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            While (dr.Read)

                With p_LV.Items.Add(dr(0).ToString)
                    .SubItems.Add(dr(1).ToString)
                End With
                p_CB.Items.Add(dr(2).ToString)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'RELLENA UN COMBOBOX CON LA LISTA DE NOMBRE DE LOS VENDEDORES
    Public Sub SEL_VENDEDORES(ByRef p_CB As ComboBox)

        cmd = New MySqlCommand("SEL_VENDEDORES", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure

        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            While (dr.Read)
                p_CB.Items.Add(dr(2).ToString)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'REPORTE POR DIA EN EXCEL
    Public Sub REPORTE_DIA(ByRef p_DG As DataGridView, ByVal p_fecha_inicio As Date, ByVal p_fecha_final As Date, ByRef p_mensaje As Label, ByRef p_barra_progreso As ProgressBar)

        cmd = New MySqlCommand("RP_DIA", MysqlCon)
        dr = Nothing
        Dim contador As Integer = 0
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_fechain", p_fecha_inicio)
        cmd.Parameters.AddWithValue("@p_fechaout", p_fecha_final)
        p_barra_progreso.Value = 20
        Application.DoEvents()
        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            p_mensaje.Text = "Cargando Consulta..."
            p_barra_progreso.Value = 30
            Thread.Sleep(500)
            While (dr.Read)
                contador += 1
                p_mensaje.Text = "Cargando dato: " & contador
                Application.DoEvents()
                p_DG.Rows.Add(dr(0).ToString, dr(1).ToString, dr(2).ToString, dr(3).ToString)
            End While
            p_mensaje.Text = "Datos cargados..."
            p_barra_progreso.Value = 40
            Application.DoEvents()
            Thread.Sleep(500)
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'REPORTE POR FECHA EN EXCEL
    Public Sub REPORTE_FECHA(ByRef p_DG As DataGridView, ByVal p_fecha_inicio As Date, ByVal p_fecha_final As Date, ByRef p_barra_progreso As ProgressBar, ByRef p_mensaje As Label)

        Dim contador As Integer = 0
        Dim fecha As Date
        Dim newDate As Date = Nothing
        cmd = New MySqlCommand("RP_FECHAS", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_fechain", p_fecha_inicio)
        cmd.Parameters.AddWithValue("@p_fechaout", p_fecha_final)
        p_barra_progreso.Value = 10
        p_mensaje.Text = "Cargando Datos..."
        Application.DoEvents()
        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            While (dr.Read)
                contador += 1
                fecha = dr(3).ToString
                p_DG.Rows.Add(dr(0).ToString, dr(1), dr(2), fecha.ToString("MM/dd/yyyy HH:mm:ss"))
                p_mensaje.Text = "Leyendo dato: " & contador
                Application.DoEvents()
            End While
            p_barra_progreso.Value = 40
            Application.DoEvents()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'SELECCIONA TODOS LOS VENDEDORES
    Public Sub SEL_VENDEDORES_TODOS(ByRef p_lv As ListView)

        cmd = New MySqlCommand("SEL_VENDEDORES", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure

        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            While (dr.Read)

                With p_lv.Items.Add(dr(0).ToString)
                    .SubItems.Add(dr(2).ToString)
                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try
    End Sub

    'RELLENO LA LISTA DEL HISTORIAL DE IMPRESIONES
    Public Sub SEL_HIST_PRINT(ByRef p_lv As ListView)

        cmd = New MySqlCommand("SEL_HIST_PRINT", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure

        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            While (dr.Read)

                With p_lv.Items.Add(dr(0).ToString)
                    .SubItems.Add(dr(1).ToString)
                    .SubItems.Add(dr(2).ToString)
                    .SubItems.Add(convertir_formato_miles_decimales(dr(3).ToString))
                    .SubItems.Add(dr(4).ToString)
                End With

            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'FILTRO DE IMPRESIONES POR NOMBRE DE CLIENTE
    Public Sub SEL_HIST_PRINT_FILTRO_NOMBRE(ByRef p_lv As ListView, ByVal p_nombre As String)

        cmd = New MySqlCommand("SEL_HISTORIAL_IMPRESION_FILTRO_NOMBRE", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_nombre", p_nombre)
        p_lv.Items.Clear()

        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            While (dr.Read)

                With p_lv.Items.Add(dr(0).ToString)
                    .SubItems.Add(dr(1).ToString)
                    .SubItems.Add(dr(2).ToString)
                    .SubItems.Add(convertir_formato_miles_decimales(dr(3).ToString))
                    .SubItems.Add(dr(4).ToString)
                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'FILTRO DE IMPRESIONES POR NUMERO DE FACTURA
    Public Sub SEL_HIST_PRINT_FILTRO_ID(ByRef p_lv As ListView, ByVal p_id As String)

        cmd = New MySqlCommand("SEL_HISTORIAL_IMPRESION_FILTRO_ID", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_id", p_id)

        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            While (dr.Read)

                With p_lv.Items.Add(dr(0).ToString)
                    .SubItems.Add(dr(1).ToString)
                    .SubItems.Add(dr(2).ToString)
                    .SubItems.Add(convertir_formato_miles_decimales(dr(3).ToString))
                    .SubItems.Add(dr(4).ToString)
                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'SELECCIONA EL DETALLE DE LA IMPRESION
    Public Sub SEL_FACT_TO_PRINT(ByVal p_numero_factura As Integer, ByRef p_detalle As String)

        cmd = New MySqlCommand("SEL_FACT_TO_PRINT", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_num", p_numero_factura)

        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            While (dr.Read)
                p_detalle = dr(0).ToString & " " &
                      dr(1).ToString & " " &
                convertir_formato_miles_decimales((dr(2).ToString))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'SELECCIONA LOS CONDIMENTOS
    Public Sub SEL_COND_CONS(ByRef p_lv As ListView)

        cmd = New MySqlCommand("SEL_COND_CONS", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure

        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            While (dr.Read)

                With p_lv.Items.Add(dr(0).ToString)
                    .SubItems.Add(dr(1).ToString)
                    .SubItems.Add(convertir_formato_miles_decimales(dr(2).ToString))
                    .SubItems.Add(convertir_formato_miles_decimales(dr(3).ToString))
                End With

            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'SELECCIONA LOS CONDIMENTOS
    Public Sub SEL_COND(ByRef p_codigo As String, ByRef p_nombre As String, ByRef p_impuesto As Boolean,
                        ByRef p_precio As String, ByVal p_id_condimentos As String)

        cmd = New MySqlCommand("SEL_COND", MysqlCon)
        dr = Nothing
        cmd.Parameters.AddWithValue("@p_cond", p_id_condimentos)
        cmd.CommandType = CommandType.StoredProcedure

        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            While (dr.Read)
                p_codigo = dr(0).ToString
                p_nombre = dr(1).ToString
                'imp = dr(2)
                If dr(2) Is Nothing OrElse IsDBNull(dr(2)) Then
                    p_impuesto = False
                Else
                    p_impuesto = dr(2)
                End If
                p_precio = convertir_formato_miles_decimales(dr(3).ToString)

            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try
    End Sub

    'SELECCIONA TODA LA CONFIGURACION GUARDADDA
    Public Sub SEL_CONGIFURACION(ByRef p_nombre_empresa As String, ByRef p_numero_factura As String, ByRef p_nombre_impresora As String,
                                 ByRef p_usar_impresora_termica As Boolean, ByRef p_usar_precios_anteriores As Boolean, ByRef p_cabecera_1 As String,
                                 ByRef p_cabecera_2 As String, ByRef p_cabecera_3 As String, ByRef p_cabecera_4 As String,
                                 ByRef p_cabecera_5 As String, ByRef p_cabecera_6 As String, ByRef p_pie_factura As String,
                                 ByRef p_numero_cotizacion As String, ByRef p_filas As Integer)

        cmd = New MySqlCommand("SEL_CONFIGURACION", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure

        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            While (dr.Read)
                p_filas += 1
                If Not IsDBNull(dr(0)) Then p_nombre_empresa = dr(0)
                If Not IsDBNull(dr(1)) Then p_numero_factura = dr(1)
                If Not IsDBNull(dr(2)) Then p_nombre_impresora = dr(2)
                If Not IsDBNull(dr(3)) Then p_usar_impresora_termica = dr(3)
                If Not IsDBNull(dr(4)) Then p_usar_precios_anteriores = dr(4)
                If Not IsDBNull(dr(5)) Then p_cabecera_1 = dr(5)
                If Not IsDBNull(dr(6)) Then p_cabecera_2 = dr(6)
                If Not IsDBNull(dr(7)) Then p_cabecera_3 = dr(7)
                If Not IsDBNull(dr(8)) Then p_cabecera_4 = dr(8)
                If Not IsDBNull(dr(9)) Then p_cabecera_5 = dr(9)
                If Not IsDBNull(dr(10)) Then p_cabecera_6 = dr(10)
                If Not IsDBNull(dr(11)) Then p_pie_factura = dr(11)
                If Not IsDBNull(dr(12)) Then p_numero_cotizacion = dr(12)

            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try
    End Sub

    'SELECCIONA TODA LA CONFIGURACION GUARDADDA
    Public Sub SEL_CONFIG_FACTURA(ByRef p_nombre_empresa As String, ByRef p_numero_factura As String,
                                  ByRef p_usar_impresora_termica As Boolean, ByRef p_usar_precios_anteriores As Boolean,
                                  ByRef p_cabecera_1 As String, ByRef p_cabecera_2 As String, ByRef p_cabecera_3 As String,
                                  ByRef p_cabecera_4 As String, ByRef p_cabecera_5 As String, ByRef p_cabecera_6 As String,
                                  ByRef p_pie_factura As String)

        cmd = New MySqlCommand("SEL_CONFIG_FACTURA", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure

        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            While (dr.Read)
                If Not IsDBNull(dr(0)) Then p_nombre_empresa = dr(0)
                If Not IsDBNull(dr(1)) Then p_numero_factura = dr(1)
                If Not IsDBNull(dr(2)) Then p_usar_impresora_termica = dr(2)
                If Not IsDBNull(dr(3)) Then p_usar_precios_anteriores = dr(3)
                If Not IsDBNull(dr(4)) Then p_cabecera_1 = dr(4)
                If Not IsDBNull(dr(5)) Then p_cabecera_2 = dr(5)
                If Not IsDBNull(dr(6)) Then p_cabecera_3 = dr(6)
                If Not IsDBNull(dr(7)) Then p_cabecera_4 = dr(7)
                If Not IsDBNull(dr(8)) Then p_cabecera_5 = dr(8)
                If Not IsDBNull(dr(9)) Then p_cabecera_6 = dr(9)
                If Not IsDBNull(dr(10)) Then p_pie_factura = dr(10)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try
    End Sub

    'SELECCIONA EL NUMERO DE COTIZACION ACTUAL
    Public Sub SEL_CONFIG_COT_NUMERO(ByRef p_numero)

        cmd = New MySqlCommand("SEL_CONFIG_COT_NUMERO", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure

        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            While (dr.Read)
                If Not IsDBNull(dr(0)) Then p_numero = dr(0)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try
    End Sub

    'SELECCIONA EL NUMERO DE FACTURA ACTUAL
    Public Sub SEL_CONFIG_FACTURA_NUMERO(ByRef p_numero)

        cmd = New MySqlCommand("SEL_CONFIG_FACTURA_NUMERO", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure

        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            While (dr.Read)
                If Not IsDBNull(dr(0)) Then p_numero = dr(0)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try
    End Sub

    'SELECCIONA LOS CONDIMENTOS CON LOS PRECIOS COSTOS
    Public Sub SEL_COND_COSTOS(ByRef p_LV As ListView)

        cmd = New MySqlCommand("SEL_COND_COSTOS", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure

        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            While (dr.Read)

                With p_LV.Items.Add(dr(0).ToString)
                    .SubItems.Add(dr(1).ToString)
                    .SubItems.Add(convertir_formato_miles_decimales(dr(2).ToString))
                    .SubItems.Add(convertir_formato_miles_decimales(dr(3).ToString))
                    .SubItems.Add(convertir_formato_miles_decimales(dr(4).ToString))
                End With

            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'SELECCIONA LOS CONDIMENTOS CON PRECIO COSTO
    Public Sub SEL_COND_FILTRO_COSTO(ByVal p_codigo As String, ByRef p_lv As ListView)

        cmd = New MySqlCommand("SEL_COND_FILTRO_COSTO", MysqlCon)
        dr = Nothing
        cmd.Parameters.AddWithValue("@p_cond", p_codigo)
        cmd.CommandType = CommandType.StoredProcedure

        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()

            While (dr.Read)
                With p_lv.Items.Add(dr(0).ToString)
                    .SubItems.Add(dr(1).ToString)
                    .SubItems.Add(convertir_formato_miles_decimales(dr(2).ToString))
                    .SubItems.Add(convertir_formato_miles_decimales(dr(3).ToString))
                    .SubItems.Add(convertir_formato_miles_decimales(dr(4).ToString))
                End With
            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'SELECCIONA EL CONDIMENTO POR CODIGO
    Public Sub SEL_COND_FILTRO_SUGERIDO(ByVal p_codigo As String, ByRef p_lv As ListView)

        cmd = New MySqlCommand("SEL_COND_FILTRO_SUGERIDO", MysqlCon)
        dr = Nothing
        cmd.Parameters.AddWithValue("@p_cond", p_codigo)
        cmd.CommandType = CommandType.StoredProcedure

        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()

            While (dr.Read)
                With p_lv.Items.Add(dr(0).ToString)
                    .SubItems.Add(dr(1).ToString)
                    .SubItems.Add(convertir_formato_miles_decimales(dr(2).ToString))
                    .SubItems.Add(convertir_formato_miles_decimales(dr(3).ToString))
                End With
            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'MUESTRA TODOS LOS CLIENTES DE LA TABLA
    Public Sub SEL_CLIENTE_TODOS(ByRef p_lv As ListView)

        cmd = New MySqlCommand("SEL_CLIENTE_TODOS", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure

        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            While (dr.Read)
                With p_lv.Items.Add(dr(0).ToString)
                    .SubItems.Add(dr(1).ToString)
                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'SELECCIONA EL CLIENTE POR ID
    Public Sub SEL_CLIENTE_IDF(ByVal p_codigo As String, ByRef p_lv As ListView)

        cmd = New MySqlCommand("SEL_CLIENTE_IDF", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_id", p_codigo)

        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            While (dr.Read)

                With p_lv.Items.Add(dr(0).ToString)
                    .SubItems.Add(dr(1).ToString)
                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'SELECCIONA EL CONDIMENTO POR ID
    Public Sub SEL_COND_ID(ByVal p_codigo As String, ByRef p_condimento As String)

        cmd = New MySqlCommand("SEL_COND_ID", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_cond", p_codigo)

        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            While (dr.Read)
                p_condimento = dr(0).ToString
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'SELECCIONA EL CLIENTE POR NOMBRE
    Public Sub SEL_CLIENTE_NOMF(ByVal p_nombre As String, ByRef p_lv As ListView)

        cmd = New MySqlCommand("SEL_CLIENTE_NOMF", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_nom", p_nombre)
        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            While (dr.Read)

                With p_lv.Items.Add(dr(0).ToString)
                    .SubItems.Add(dr(1).ToString)
                End With

            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'SELECCIONA EL CLIENTE POR CODIGO
    Public Sub SEL_CLIENTE_COB(ByVal p_codigo As Integer, ByRef p_cliente As String, ByRef p_total As String)

        cmd = New MySqlCommand("SEL_CLIENTE_COB", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_num", p_codigo)

        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            While (dr.Read)
                p_cliente = dr(0).ToString
                p_total = dr(1).ToString
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'SELECCIONA EL ARTICULO POR NOMBRE
    Public Sub SEL_ART_NOMF(ByVal p_nombre As String, ByRef p_lv As ListView)

        cmd = New MySqlCommand("SEL_ART_NOMF", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_nom", p_nombre)

        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            While (dr.Read)
                With p_lv.Items.Add(dr(0).ToString)
                    .SubItems.Add(dr(1).ToString)
                    .SubItems.Add(dr(2).ToString)
                    .SubItems.Add(convertir_formato_miles_decimales(dr(3).ToString))
                    .SubItems.Add(convertir_formato_miles_decimales(dr(4).ToString))
                End With
            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'SELECCIONA LOS ARTICULOS POR ID
    Public Sub SEL_ART_IDF(ByVal p_nombre As String, ByRef p_lv As ListView)

        cmd = New MySqlCommand("SEL_ART_IDF", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_id", p_nombre)
        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            While (dr.Read)
                With p_lv.Items.Add(dr(0).ToString)
                    .SubItems.Add(dr(1).ToString)
                    .SubItems.Add(dr(2).ToString)
                    .SubItems.Add(convertir_formato_miles_decimales(dr(3).ToString))
                    .SubItems.Add(convertir_formato_miles_decimales(dr(4).ToString))
                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'SELECCIONA LOS ARTICULOS POR EL BARCODE
    Public Sub SEL_ART_BARCODE(ByVal p_nombre As String, ByRef p_lv As ListView)

        cmd = New MySqlCommand("SEL_ART_BARCODE", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_id", p_nombre)
        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            While (dr.Read)
                With p_lv.Items.Add(dr(0).ToString)
                    .SubItems.Add(dr(1).ToString)
                    .SubItems.Add(dr(2).ToString)
                    .SubItems.Add(convertir_formato_miles_decimales(dr(3).ToString))
                    .SubItems.Add(convertir_formato_miles_decimales(dr(4).ToString))
                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'SELECCIONAR CLIENTE FORM CREARFACTURA
    Public Sub SEL_CLIENTE_FACT(ByVal p_codigo As String, ByRef p_id As Integer, ByRef p_dgv As DataGridView,
                                ByRef p_advertencia As String, ByRef p_telefono As String, ByRef p_tipo_printer As Boolean,
                                ByRef p_vendedor As Integer, ByRef p_cedula_cliente As String)
        p_cedula_cliente = ""
        cmd = New MySqlCommand("SEL_CLIENTE_FACT", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_idc", p_codigo)
        cmd.Parameters.Add("@p_cli_id", MySqlDbType.Int32)
        cmd.Parameters.Add("@p_cli_nombre", MySqlDbType.VarChar, 100)
        cmd.Parameters.Add("@p_cli_direcc", MySqlDbType.VarChar, 80)
        cmd.Parameters.Add("@p_cli_adv", MySqlDbType.VarChar, 250)
        cmd.Parameters.Add("@p_cli_tel", MySqlDbType.VarChar, 80)
        cmd.Parameters.Add("@p_printer", MySqlDbType.Bit)
        cmd.Parameters.Add("@p_vendedor", MySqlDbType.Int32)
        cmd.Parameters.Add("@p_cedula_cliente", MySqlDbType.VarChar, 20)
        cmd.Parameters("@p_vendedor").Direction = ParameterDirection.Output
        cmd.Parameters("@p_printer").Direction = ParameterDirection.Output
        cmd.Parameters("@p_cli_adv").Direction = ParameterDirection.Output
        cmd.Parameters("@p_cli_tel").Direction = ParameterDirection.Output
        cmd.Parameters("@p_cli_id").Direction = ParameterDirection.Output
        cmd.Parameters("@p_cli_nombre").Direction = ParameterDirection.Output
        cmd.Parameters("@p_cli_direcc").Direction = ParameterDirection.Output
        cmd.Parameters("@p_cedula_cliente").Direction = ParameterDirection.Output
        Try
            MysqlCon.Open()
            cmd.ExecuteNonQuery()
            p_id = cmd.Parameters("@p_cli_id").Value
            p_dgv.Rows(0).Cells(0).Value = cmd.Parameters("@p_cli_nombre").Value.ToString
            p_dgv.Rows(1).Cells(0).Value = cmd.Parameters("@p_cli_direcc").Value.ToString
            p_advertencia = cmd.Parameters("@p_cli_adv").Value.ToString
            p_telefono = cmd.Parameters("@p_cli_tel").Value.ToString
            p_tipo_printer = cmd.Parameters("@p_printer").Value
            p_vendedor = cmd.Parameters("@p_vendedor").Value
            p_cedula_cliente = cmd.Parameters("@p_cedula_cliente").Value.ToString
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    Public Sub SEL_CLIENTE_TICKET(ByVal p_codigo As String, ByRef p_tipo_printer As Boolean)

        cmd = New MySqlCommand("SEL_CLIENTE_TICKET", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_idc", p_codigo)
        cmd.Parameters.Add("@p_printer", MySqlDbType.Bit)
        cmd.Parameters("@p_printer").Direction = ParameterDirection.Output

        Try
            MysqlCon.Open()
            cmd.ExecuteNonQuery()
            p_tipo_printer = cmd.Parameters("@p_printer").Value
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    Public Sub SEL_CLI_OPEN(ByVal p_codigo As Integer, ByRef p_factura As Integer)

        cmd = New MySqlCommand("SEL_CLI_OPEN", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_id", p_codigo)
        cmd.Parameters.Add("@p_fact", MySqlDbType.Int32)
        cmd.Parameters("@p_fact").Direction = ParameterDirection.Output

        Try
            MysqlCon.Open()
            cmd.ExecuteNonQuery()
            p_factura = cmd.Parameters("@p_fact").Value

        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'CONSULTA EL NUMERO DE CAMBIOS DE UNA FACTURA
    Public Sub SEL_CAMBIOS_FACTURA(ByVal p_codigo As Integer, ByRef p_cambios As Integer)

        cmd = New MySqlCommand("SEL_CAMBIOS_FACTURA ", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_id", p_codigo)
        cmd.Parameters.Add("@p_resp", MySqlDbType.Int32)
        cmd.Parameters("@p_resp").Direction = ParameterDirection.Output

        Try
            MysqlCon.Open()
            cmd.ExecuteNonQuery()
            p_cambios = cmd.Parameters("@p_resp").Value

        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'SELECCIONA EL NOMBRE DEL VENDEDOR
    Public Sub SEL_NOMBRE_VENDEDOR(ByVal p_id As Integer, ByRef p_nombre As String)

        cmd = New MySqlCommand("SEL_NOMBRE_VENDEDOR", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_id", p_id)

        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            While (dr.Read)
                p_nombre = dr(0).ToString
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'SELECCIONA EL CLIENTE CON LOS DATOS
    Public Sub SEL_CLIENTE_ACT(ByVal p_codigo As String, ByRef p_nombre As String,
                               ByRef p_direcion As String, ByRef p_telefono As String, ByRef p_advertencia As String,
                               ByRef p_printer As Boolean, ByRef p_vendedores As ComboBox, ByRef p_lv_vendedores As ListView,
                               ByRef p_cedula_cliente As TextBox, ByRef p_cliente_correo As TextBox)


        cmd = New MySqlCommand("SEL_CLIENTE_ACT", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_codigo", p_codigo)

        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()

            While (dr.Read)

                p_nombre = dr(0).ToString
                p_telefono = dr(1).ToString
                p_direcion = dr(2).ToString
                p_vendedores.Items.Add(dr(3).ToString & " Actual ")

                With p_lv_vendedores.Items.Add(dr(4).ToString)
                    .SubItems.Add("Vacio")
                End With

                p_vendedores.SelectedIndex = p_vendedores.Items.Count - 1
                p_printer = dr(5).ToString
                p_advertencia = dr(6).ToString
                p_cedula_cliente.Text = dr(7).ToString
                p_cliente_correo.Text = dr(8).ToString
            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'SELECCIONA LA LLAVE DEL ARTICULO
    Public Sub SEL_ARTICULO_RAP(ByVal p_id As String, ByRef p_auto As Integer)

        cmd = New MySqlCommand("SEL_ARTICULO_RAP", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_id", p_id)

        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            While (dr.Read)
                p_auto = dr(0)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'SELECCIONA LOS DATOS DEL ARTICULO
    Public Sub SEL_ARTICULO_ACT(ByVal p_id As String, ByRef p_descrípcion As String, ByRef p_precio1 As String,
                                ByRef p_precio2 As String, ByRef p_precio3 As String, ByRef p_precio4 As String,
                                ByRef p_barcode As String, ByRef p_impuesto As Double)
        cmd = New MySqlCommand("SEL_ARTICULO_ACT", MysqlCon)
        dr = Nothing
        cmd.Parameters.AddWithValue("@p_id", p_id)
        cmd.CommandType = CommandType.StoredProcedure
        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            While (dr.Read)
                p_descrípcion = dr(0).ToString
                p_precio1 = dr(1).ToString
                p_precio2 = dr(2).ToString
                p_precio3 = dr(3).ToString
                p_precio4 = dr(4).ToString
                p_barcode = dr(5).ToString
                p_impuesto = dr(6)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'Muestra si el barcode esta utilizado
    Public Sub SEL_BARCODE(ByVal p_barcode As String, ByRef p_disponible As Boolean)
        cmd = New MySqlCommand("SEL_BARCODE", MysqlCon)
        dr = Nothing
        cmd.Parameters.AddWithValue("@p_barcode", p_barcode)
        cmd.CommandType = CommandType.StoredProcedure
        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            While (dr.Read)

                If dr(0) = 1 Then
                    p_disponible = False
                Else
                    p_disponible = True
                End If

            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'REVISO CUAL ES LA ULTIMA FACTURA
    Public Sub SEL_FACTURA_MAX(ByRef p_numero_factura As String)

        cmd = New MySqlCommand("Sel_factura_MAX", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            While (dr.Read)
                p_numero_factura = dr(0).ToString
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'INTRODUCE TODOS LOS DATOS DE FACTURAS CERRADAS EN LA LISTA DE FACTURAS CERRADAS
    Public Sub SEL_FACT_CLOSED(ByRef p_facturas_cerradas As DataGridView)

        Dim fecha As Date
        cmd = New MySqlCommand("SEL_FACT_CLOSED", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            p_facturas_cerradas.Rows.Clear()
            While (dr.Read)
                fecha = dr(1).ToString
                p_facturas_cerradas.Rows.Add(dr(0).ToString,
                                             fecha.ToString("dd/MM/yyyy"),
                                             dr(2).ToString,
                                             dr(3).ToString,
                                             dr(4),
                                             dr(5))
                'convertir_formato_miles_decimales(dr(4).ToString),
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'SELECCIONA LOS DATOS DE LA FACTURA ABIERTA
    Public Sub SEL_FACT_OPEN(ByRef p_facturas_abiertas As DataGridView)

        Dim fecha As Date
        cmd = New MySqlCommand("SEL_FACT_OPEN", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            p_facturas_abiertas.Rows.Clear()
            While (dr.Read)
                fecha = dr(1).ToString
                p_facturas_abiertas.Rows.Add(False,
                                             dr(0).ToString,
                                             fecha.ToString("dd/MM/yyyy"),
                                             dr(2).ToString,
                                             dr(3).ToString,
                                             dr(4),
                                             dr(5))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'SELECCIONA LOS DATOS DE LA FACTURA ABIERTA
    Public Sub SEL_FACT_PAGADA(ByRef p_facturas_abiertas As DataGridView)

        Dim fecha As Date
        cmd = New MySqlCommand("SEL_FACT_PAGADA", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            p_facturas_abiertas.Rows.Clear()
            While (dr.Read)
                fecha = dr(1).ToString
                p_facturas_abiertas.Rows.Add(dr(0).ToString,
                                             fecha.ToString("dd/MM/yyyy"),
                                             dr(2).ToString,
                                             dr(3).ToString,
                                             dr(4),
                                             dr(5))

            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'MUESTRA LOS DETALLES DE UNA COTIZACION
    Public Sub SEL_COTIZACION(ByRef p_cotizacion As DataGridView)

        Dim fecha As Date
        cmd = New MySqlCommand("SEL_COTIZACION", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        p_cotizacion.Rows.Clear()

        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()

            While (dr.Read)
                fecha = dr(2).ToString
                p_cotizacion.Rows.Add(dr(0),
                                 dr(1),
                                 fecha.ToString("dd/MM/yyyy"),
                                 dr(3),
                                 dr(4))
            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'SELECCIONA LAS FACTURAS CERRADAS
    Public Sub SEL_FACT_CLOSED_BUSQ(ByVal p_busqueda As String, ByRef p_facturas_cerradas As DataGridView)

        Dim fecha As Date
        cmd = New MySqlCommand("SEL_FACT_CLOSED_BUSQ", MysqlCon)
        dr = Nothing
        cmd.Parameters.AddWithValue("@p_nombre", p_busqueda)
        cmd.CommandType = CommandType.StoredProcedure
        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            p_facturas_cerradas.Rows.Clear()
            While (dr.Read)
                fecha = dr(1).ToString
                p_facturas_cerradas.Rows.Add(dr(0).ToString,
                                             fecha.ToString("dd/MM/yyyy"),
                                             dr(2).ToString,
                                             dr(3).ToString,
                                             dr(4),
                                             dr(5))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'SELECCIONA LA FACTURA ABIERTA POR NOMBRE
    Public Sub SEL_FACT_OPEN_BUSQ(ByVal p_busqueda As String, ByRef p_facturas_abiertas As DataGridView)

        Dim fecha As Date
        cmd = New MySqlCommand("SEL_FACT_OPEN_BUSQ", MysqlCon)
        dr = Nothing
        cmd.Parameters.AddWithValue("@p_nombre", p_busqueda)
        cmd.CommandType = CommandType.StoredProcedure
        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            p_facturas_abiertas.Rows.Clear()
            While (dr.Read)
                fecha = dr(1).ToString
                p_facturas_abiertas.Rows.Add(False,
                                             dr(0).ToString,
                                             fecha.ToString("dd/MM/yyyy"),
                                             dr(2).ToString,
                                             dr(3).ToString,
                                             dr(4),
                                             dr(5))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'SELECCIONA LA FACTURA ABIERTA POR NUMERO DE FACTURA
    Public Sub SEL_FACT_OPEN_BUSQF(ByVal p_busqueda As String, ByRef p_facturas_abiertas As DataGridView)

        Dim fecha As Date
        cmd = New MySqlCommand("SEL_FACT_OPEN_BUSQF", MysqlCon)
        dr = Nothing
        cmd.Parameters.AddWithValue("@p_fact", p_busqueda)
        cmd.CommandType = CommandType.StoredProcedure
        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            p_facturas_abiertas.Rows.Clear()
            While (dr.Read)
                fecha = dr(1).ToString
                p_facturas_abiertas.Rows.Add(False,
                                             dr(0).ToString,
                                             fecha.ToString("dd/MM/yyyy"),
                                             dr(2).ToString,
                                             dr(3).ToString,
                                             dr(4),
                                             dr(5))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'SELECCIONA LA FACTURA CERRADA POR NUMERO DE FACTURA
    Public Sub SEL_FACT_CLOSED_BUSQF(ByVal p_busqueda As String, ByRef p_facturas_cerradas As DataGridView)

        Dim fecha As Date
        cmd = New MySqlCommand("SEL_FACT_CLOSED_BUSQF", MysqlCon)
        dr = Nothing
        cmd.Parameters.AddWithValue("@p_fact", p_busqueda)
        cmd.CommandType = CommandType.StoredProcedure
        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            p_facturas_cerradas.Rows.Clear()
            While (dr.Read)
                fecha = dr(1).ToString
                p_facturas_cerradas.Rows.Add(dr(0).ToString,
                                             fecha.ToString("dd/MM/yyyy"),
                                             dr(2).ToString,
                                             dr(3).ToString,
                                             dr(4),
                                             dr(5))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'SELECCIONA LA COTIZACION POR NOMBRE DEL CLIENTE
    Public Sub SEL_COT_BUSQ(ByVal p_busqueda As String, ByRef p_cotizacion As DataGridView)

        Dim fecha As Date
        cmd = New MySqlCommand("SEL_COT_BUSQ", MysqlCon)
        dr = Nothing
        cmd.Parameters.AddWithValue("@p_nombre", p_busqueda)
        cmd.CommandType = CommandType.StoredProcedure
        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            p_cotizacion.Rows.Clear()
            While (dr.Read)
                fecha = dr(2).ToString
                p_cotizacion.Rows.Add(dr(0),
                                      dr(1),
                                      fecha.ToString("dd/MM/yyyy"),
                                      dr(3),
                                      dr(4))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'SELECCIONO TODOS LOS ARTICULOS CON UN FILTRO
    'FORM CREARFACTURAS
    Public Sub SEL_ARTICULO_COD(ByVal p_codigo As String, ByRef p_LV As ListView, ByRef p_id As Integer)

        cmd = New MySqlCommand("SEL_ARTICULO_COD", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_id", p_codigo)
        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()

            While (dr.Read)
                With p_LV.Items.Add(dr(2).ToString)
                    .SubItems.Add(dr(0).ToString)
                    .SubItems.Add(dr(1).ToString)
                    p_id = dr(2)
                    .SubItems.Add(convertir_formato_miles(dr(3)))
                    .SubItems.Add(convertir_formato_miles(dr(4)))
                End With
            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    Public Sub SEL_ART_CLIENTE_COD(ByVal p_codigo As String, ByRef p_LV As ListView, ByRef p_id As Integer, ByVal p_cliente As Integer)

        cmd = New MySqlCommand("SEL_ARTICULO_COD_HIST", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_id", p_codigo)
        cmd.Parameters.AddWithValue("@p_cliente", p_cliente)
        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()

            While (dr.Read)
                With p_LV.Items.Add(dr(2).ToString)
                    .SubItems.Add(dr(0).ToString)
                    .SubItems.Add(dr(1).ToString)
                    p_id = dr(2)
                    .SubItems.Add(convertir_formato_miles(dr(3)))
                    .SubItems.Add(convertir_formato_miles(dr(4)))
                End With
            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'SELECCIONA EL ARTICULO POR NOMBRE
    Public Sub SEL_ARTICULO_NOM(ByVal p_codigo As String, ByRef p_LV As ListView)

        cmd = New MySqlCommand("SEL_ARTICULO_NOM", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_id", p_codigo)
        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()

            While (dr.Read)
                With p_LV.Items.Add(dr(2).ToString)
                    .SubItems.Add(dr(0).ToString)
                    .SubItems.Add(dr(1).ToString)
                    .SubItems.Add(dr(3).ToString)
                    .SubItems.Add(dr(4).ToString)
                End With
            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub


    'INGRESA LOS DATOS DEL LVBUSQUEDA EN EL DATAGRIDVIEW
    'DESPUES DE LA PULSACION DE ENTER
    Public Sub SEL_ARTICULOS_FAC(ByVal p_id As Integer, ByRef p_codigo As String, ByRef p_descripcion As String,
                                     ByRef p_precio1 As String, ByRef p_precio2 As Double,
                                 ByRef p_precio3 As Double, ByRef p_precio4 As Double, ByRef p_impuesto As TextBox)

        cmd = New MySqlCommand("SEL_ARTICULOS_FAC", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_id", p_id)
        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                While (dr.Read)

                    p_codigo = dr(0).ToString
                    p_descripcion = dr(1).ToString
                    p_precio1 = dr(2)
                    p_precio2 = dr(3)
                    p_precio3 = dr(4)
                    p_precio4 = dr(5)
                    p_impuesto.Text = dr(6)
                End While
            Else
                vp_art_id = ""
                vp_art_Cod = ""
                vp_art_Nombre = ""
                vp_art_precio1 = ""
                vp_art_precio2 = ""
                vp_art_precio3 = ""
                vp_art_precio4 = ""
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'INGRESA LOS DATOS DEL LVBUSQUEDA EN EL DATAGRIDVIEW
    'DESPUES DE LA PULSACION DE ENTER
    Public Sub SEL_BARCODE_FACTURA(ByVal p_barcode As String, ByRef p_codigo As String, ByRef p_descripcion As String,
                                     ByRef p_precio1 As String, ByRef p_precio2 As Double,
                                 ByRef p_precio3 As Double, ByRef p_precio4 As Double, ByRef p_articulo_id As Integer)

        cmd = New MySqlCommand("SEL_BARCODE_FACTURA", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_barcode", p_barcode)
        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                While (dr.Read)
                    p_codigo = dr(0).ToString
                    p_descripcion = dr(1).ToString
                    p_precio1 = dr(2)
                    p_precio2 = dr(3)
                    p_precio3 = dr(4)
                    p_precio4 = dr(5)
                    p_articulo_id = dr(6)
                End While
            Else
                vp_art_id = ""
                vp_art_Cod = ""
                vp_art_Nombre = ""
                vp_art_precio1 = ""
                vp_art_precio2 = ""
                vp_art_precio3 = ""
                vp_art_precio4 = ""
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub
    ' TRAE EL PRECIO DEL ARTICULO ANTERIOR VENDIDO A UN CLIENTE ESPECIFICO
    Public Sub SEL_ARTICULOS_FAC_ANT(ByVal p_id As Integer, ByVal p_id_cliente As Integer, ByRef p_precio As String)

        cmd = New MySqlCommand("SEL_ARTICULOS_FAC_ANT", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_id_art", p_id)
        cmd.Parameters.AddWithValue("@p_id_cli", p_id_cliente)
        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                While (dr.Read)
                    p_precio = dr(0).ToString
                End While
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    ' TRAE EL PRECIO DEL ARTICULO ANTERIOR VENDIDO A UN CLIENTE ESPECIFICO
    Public Sub SEL_BARCODE_FACTURA_ANT(ByVal p_barcode As String, ByVal p_id_cliente As Integer, ByRef p_precio As String)

        cmd = New MySqlCommand("SEL_BARCODE_FACTURA_ANT", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_barcode", p_barcode)
        cmd.Parameters.AddWithValue("@p_id_cli", p_id_cliente)
        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                While (dr.Read)
                    p_precio = dr(0).ToString
                End While
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            If Not IsNothing(dr) Then dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub
    'SELECCIONA EL CLIENTE
    Public Sub SEL_CLIENTE_FAC(ByVal p_id As String, ByVal p_nombre As String, ByRef p_LV As ListView)

        cmd = New MySqlCommand("SEL_CLIENTES_FAC", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_id", p_id)
        cmd.Parameters.AddWithValue("@p_nombre", p_nombre)
        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                While (dr.Read)
                    With p_LV.Items.Add(dr(1).ToString)
                        .SubItems.Add(dr(2).ToString)
                    End With
                End While
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            If Not IsNothing(dr) Then dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'SELECCIONA EL ARTICULO
    Public Sub SEL_ART_FACTURA(ByVal p_codigo As Integer, ByRef p_LV As DataGridView, ByVal p_nombre As String,
                               ByVal p_cantidad As String, ByVal p_precio As String, ByVal p_subtotal As String,
                               ByVal p_id As String, ByVal p_impuesto As String, ByVal p_ProductoImpuesto As String)

        cmd = New MySqlCommand("SEL_ART_FACTURA", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_id", p_codigo)
        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            While (dr.Read)
                p_LV.Rows.Add(dr(0).ToString,
                              dr(1).ToString,
                              convertir_formato_miles_decimales(CDbl(p_cantidad)),
                              convertir_formato_miles_decimales(CDbl(p_precio)),
                              convertir_formato_miles_decimales(CDbl(p_impuesto)),
                              convertir_formato_miles_decimales(CDbl(p_subtotal)),
                              p_id,
                            (Date.Now.ToString("dd/MM/yyyy") + " " + Date.Now.ToString("HH:mm:ss")),
                              p_ProductoImpuesto)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            If Not IsNothing(dr) Then dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'SELECCIONA LA FACTURA A MODIFICAR
    Public Sub SEL_FACT_MOD(ByVal p_codigo As Integer, ByRef p_codigo_cliente As String, ByRef p_dg_comentarios As DataGridView, ByRef p_vendedores As ComboBox,
                            ByRef p_lv_vendedores As ListView, ByRef p_descuento As String, ByRef p_fecha As DateTimePicker, ByRef p_numero_factura As String,
                            ByRef p_pago As String, ByRef p_subtotal As String, ByRef p_total As String, ByRef p_cambio As String)

        cmd = New MySqlCommand("SEL_FACT_MOD", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_id", p_codigo)

        Dim total As Double = 0

        Try

            MysqlCon.Open()
            dr = cmd.ExecuteReader()

            While (dr.Read)
                p_codigo_cliente = dr(0).ToString
                p_dg_comentarios.Rows(0).Cells(0).Value = dr(1).ToString
                vp_cli_id = dr(2)
                p_vendedores.Items.Add(dr(3).ToString & " Actual ")

                With p_lv_vendedores.Items.Add(dr(4).ToString)
                    .SubItems.Add("Vacio")
                End With

                p_vendedores.SelectedIndex = p_vendedores.Items.Count - 1
                vp_fact_auto = dr(5)
                p_dg_comentarios.Rows(1).Cells(0).Value = dr(6).ToString
                p_dg_comentarios.Rows(2).Cells(0).Value = dr(7).ToString
                p_descuento = convertir_formato_miles_decimales(CDbl(dr(8).ToString))
                p_fecha.Value = dr(9).ToString
                p_numero_factura = dr(11).ToString
                p_pago = convertir_formato_miles_decimales(CDbl(dr(12).ToString))
                p_subtotal = convertir_formato_miles_decimales(CDbl(dr(13).ToString))
                p_total = convertir_formato_miles_decimales(CDbl(dr(14).ToString))

            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'SELECCIONA LA FACTURA A MODIFICAR
    Public Sub SEL_FACT_CAMBIOS(ByVal p_codigo As Integer, ByRef p_codigo_cliente As String, ByRef p_dg_comentarios As DataGridView,
                                ByRef p_vendedores As ComboBox, ByRef p_lv_vendedores As ListView, ByRef p_descuento As String,
                                ByRef p_fecha As DateTimePicker, ByRef p_numero_factura As String, ByRef p_pago As String,
                                ByRef p_subtotal As String, ByRef p_total As String, ByRef p_cambio As String,
                                ByVal p_numero_cambio As Integer, ByRef p_id_cambios As Integer)

        cmd = New MySqlCommand("SEL_FACT_CAMBIOS", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_id", p_codigo)
        cmd.Parameters.AddWithValue("@p_cambio", p_numero_cambio)

        Dim total As Double = 0

        Try

            MysqlCon.Open()
            dr = cmd.ExecuteReader()

            While (dr.Read)
                p_codigo_cliente = dr(0).ToString
                p_dg_comentarios.Rows(0).Cells(0).Value = dr(1).ToString
                vp_cli_id = dr(2)
                p_vendedores.Items.Add(dr(3).ToString & " Actual ")

                With p_lv_vendedores.Items.Add(dr(4).ToString)
                    .SubItems.Add("Vacio")
                End With

                p_vendedores.SelectedIndex = p_vendedores.Items.Count - 1
                p_id_cambios = dr(5)
                p_dg_comentarios.Rows(1).Cells(0).Value = dr(6).ToString
                p_dg_comentarios.Rows(2).Cells(0).Value = dr(7).ToString
                p_descuento = convertir_formato_miles_decimales(CDbl(dr(8).ToString))
                p_fecha.Value = dr(9).ToString
                p_numero_factura = dr(11).ToString
                p_pago = convertir_formato_miles_decimales(CDbl(dr(12).ToString))
                p_subtotal = convertir_formato_miles_decimales(CDbl(dr(13).ToString))
                p_total = convertir_formato_miles_decimales(CDbl(dr(14).ToString))

            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'SELECCIONA LOS DETALLES DE LAS COTIZACIONES
    Public Sub SEL_COT_MOD(ByVal p_codigo As Integer, ByRef p_codigo_cliente As String, ByRef p_dg_comentarios As DataGridView, ByRef p_vendedores As ComboBox,
                            ByRef p_lv_vendedores As ListView, ByRef p_descuento As String, ByRef p_fecha As DateTimePicker, ByRef p_numero_factura As String,
                             ByRef p_subtotal As String, ByRef p_total As String, ByRef p_descuento_final As String)


        cmd = New MySqlCommand("SEL_COT_MOD", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_id", p_codigo)
        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            While (dr.Read)

                p_codigo_cliente = dr(0).ToString
                p_dg_comentarios.Rows(0).Cells(0).Value = dr(1).ToString()
                vp_cli_id = dr(2)
                p_vendedores.Items.Add(dr(3).ToString & " Actual ")
                With p_lv_vendedores.Items.Add(dr(4).ToString)
                    .SubItems.Add("Vacio")
                End With
                p_vendedores.SelectedIndex = p_vendedores.Items.Count - 1
                vp_fact_auto = dr(5)
                p_dg_comentarios.Rows(1).Cells(0).Value = dr(6).ToString()
                p_dg_comentarios.Rows(2).Cells(0).Value = dr(7).ToString()
                p_descuento = convertir_formato_miles_decimales(CDbl(dr(8).ToString()))
                p_fecha.Value = dr(9).ToString()
                p_numero_factura = dr(11).ToString()
                p_subtotal = convertir_formato_miles_decimales(CDbl(dr(12).ToString()))
                p_total = convertir_formato_miles_decimales(CDbl(dr(13).ToString()))
            End While

            p_descuento_final = convertir_formato_miles_decimales(CDbl(p_descuento) / 100 * CDbl(p_subtotal))

        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'PASA UNA COTIZACION A FACTURA TRAYENDO CLIENTE Y DETALLE DE PRODUCTOS COTIZADOS
    Public Sub SEL_COT_TO_FACT(ByVal p_codigo As Integer, ByRef p_codigo_cliente As String, ByRef p_dg_comentarios As DataGridView, ByRef p_vendedores As ComboBox,
                            ByRef p_lv_vendedores As ListView, ByRef p_descuento As String,
                             ByRef p_subtotal As String, ByRef p_total As String, ByRef p_descuento_final As String)

        cmd = New MySqlCommand("SEL_COT_MOD", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_id", p_codigo)
        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            While (dr.Read)

                p_codigo_cliente = dr(0).ToString
                p_dg_comentarios.Rows(0).Cells(0).Value = dr(1).ToString
                vp_cli_id = dr(2)
                p_vendedores.Items.Add(dr(3).ToString & " Actual ")
                With p_lv_vendedores.Items.Add(dr(4).ToString)
                    .SubItems.Add("Vacio")
                End With
                p_vendedores.SelectedIndex = p_vendedores.Items.Count - 1
                vp_fact_auto = dr(5)
                p_dg_comentarios.Rows(1).Cells(0).Value = dr(6).ToString()
                p_dg_comentarios.Rows(2).Cells(0).Value = dr(7).ToString()
                p_descuento = convertir_formato_miles_decimales(CDbl(dr(8).ToString()))
                p_subtotal = convertir_formato_miles_decimales(CDbl(dr(12).ToString()))
                p_total = convertir_formato_miles_decimales(CDbl(dr(13).ToString()))

            End While

            p_descuento_final = convertir_formato_miles_decimales(CDbl(p_descuento) / 100 * CDbl(p_subtotal))

        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try


    End Sub

    'SELECCIONA LOS DETALLES DE LOS ARTICULOS COMPRADOS EN FACTURA
    Public Sub SEL_FDET_MOD(ByVal p_codigo As Integer, ByRef p_DG As DataGridView)

        Dim fecha As DateTime
        cmd = New MySqlCommand("SEL_FDET_MOD", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_id", p_codigo)
        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            While (dr.Read)
                fecha = dr(7).ToString
                p_DG.Rows.Add(dr(0).ToString, dr(1).ToString, convertir_formato_miles_decimales(CDbl(dr(2).ToString)), convertir_formato_miles_decimales(CDbl(dr(3).ToString)),
                              convertir_formato_miles_decimales(CDbl(dr(4).ToString)), convertir_formato_miles_decimales(CDbl(dr(5).ToString)), dr(6).ToString,
                             fecha.ToString("dd/MM/yyyy HH:mm:ss"))
                p_DG.Sort(p_DG.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'SELECCIONA LOS DETALLES DE LOS ARTICULOS COMPRADOS EN LOS CAMBIOS DE FACTURA 
    Public Sub SEL_FDET_CAMBIOS(ByVal p_codigo As Integer, ByRef p_DG As DataGridView)

        cmd = New MySqlCommand("SEL_FDET_CAMBIOS", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_id", p_codigo)
        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            While (dr.Read)
                p_DG.Rows.Add(dr(0).ToString, dr(1).ToString, convertir_formato_miles_decimales(CDbl(dr(2).ToString)), convertir_formato_miles_decimales(CDbl(dr(3).ToString)),
                              convertir_formato_miles_decimales(CDbl(dr(4).ToString)), convertir_formato_miles_decimales(CDbl(dr(5).ToString)), dr(6).ToString, dr(7).ToString)
                p_DG.Sort(p_DG.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'SELECCIONA LOS DETALLES DE LOS ARTICULOS COMPRADOS EN COTIZACION
    Public Sub SEL_CDET_MOD(ByVal p_codigo As Integer, ByRef p_DG As DataGridView)

        cmd = New MySqlCommand("SEL_CDET_MOD", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_id", p_codigo)
        p_DG.Rows.Clear()
        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            While (dr.Read)
                p_DG.Rows.Add(dr(0).ToString, dr(1).ToString, convertir_formato_miles_decimales(CDbl(dr(2).ToString)), convertir_formato_miles_decimales(CDbl(dr(3).ToString)),
                            convertir_formato_miles_decimales(CDbl(dr(4).ToString)), convertir_formato_miles_decimales(CDbl(dr(5).ToString)), dr(6).ToString,
                            (Date.Now.ToString("dd/MM/yyyy") + " " + Date.Now.ToString("HH:mm:ss")))
                p_DG.Sort(p_DG.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'SELECCIONA LOS DETALLES DE LOS ARTICULOS COMPRADOS EN COTIZACION PARA PASARLOS A FACTURA
    Public Sub SEL_CDET_TO_FACT(ByVal p_codigo As Integer, ByRef p_DG As DataGridView)

        cmd = New MySqlCommand("SEL_CDET_MOD", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_id", p_codigo)
        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            While (dr.Read)
                p_DG.Rows.Add(dr(0).ToString, dr(1).ToString, convertir_formato_miles_decimales(CDbl(dr(2).ToString)), convertir_formato_miles_decimales(CDbl(dr(3).ToString)),
                              convertir_formato_miles_decimales(CDbl(dr(4).ToString)), convertir_formato_miles_decimales(CDbl(dr(5).ToString)), dr(6).ToString)
                p_DG.Sort(p_DG.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'SELECCIONA EL HISTORIAL DE COMPRAS DEL CLIENTE
    Public Sub SEL_HIST_CLI(ByVal p_codigo As Integer, ByRef p_historial_cliente As DataGridView)

        Dim fecha As Date
        cmd = New MySqlCommand("SEL_HIST_CLI", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_id", p_codigo)
        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            p_historial_cliente.Rows.Clear()
            While (dr.Read)
                fecha = dr(1).ToString
                p_historial_cliente.Rows.Add(dr(0),
                                             fecha.ToString("dd/MM/yyyy"),
                                             dr(2),
                                             dr(3),
                                             dr(4),
                                             dr(5))
            End While
        Catch ex As Exception
            Logger.e("Error con excepción", ex, New StackFrame(True))
            MsgBox(ex.ToString)
        Finally
            dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    Public Sub SEL_HIST_CLI_NOMF(ByVal p_codigo As Integer, ByVal p_nombre As String, ByRef p_historial_cliente As DataGridView)

        Dim fecha As Date
        cmd = New MySqlCommand("SEL_HIST_CLI_NOMF", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_auto", p_codigo)
        cmd.Parameters.AddWithValue("@p_nombre", p_nombre)
        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            p_historial_cliente.Rows.Clear()
            While (dr.Read)
                fecha = dr(1).ToString
                p_historial_cliente.Rows.Add(dr(0),
                                             fecha.ToString("dd/MM/yyyy"),
                                             dr(2),
                                             dr(3),
                                             dr(4),
                                             dr(5))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    Public Sub SEL_HIST_CLI_IDF(ByVal p_codigo As Integer, ByVal p_nombre As String, ByRef p_historial_cliente As DataGridView)

        Dim fecha As Date
        cmd = New MySqlCommand("SEL_HIST_CLI_IDF", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_auto", p_codigo)
        cmd.Parameters.AddWithValue("@p_id", p_nombre)
        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            p_historial_cliente.Rows.Clear()
            While (dr.Read)
                fecha = dr(1).ToString
                p_historial_cliente.Rows.Add(dr(0),
                                             fecha.ToString("dd/MM/yyyy"),
                                             dr(2),
                                             dr(3),
                                             dr(4),
                                             dr(5))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub


    'SELECCIONA LOS DETALLES DE LOS PRODUCTOS VENDIDOS
    Public Sub SEL_HISTORIAL_PRODUCTO_VENDIDO(ByVal p_codigo As String, ByRef p_dg_detalles As DataGridView, ByVal p_fecha_inicio As DateTime,
                                              ByVal p_fecha_fin As DateTime, ByRef p_cantidad As TextBox, ByRef p_estado As Label, ByVal p_cliente As String)

        If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
        p_estado.Text = "Realizando Consulta, por favor espere..."
        Application.DoEvents()
        cmd = New MySqlCommand("SEL_HISTORIAL_PRODUCTO_VENDIDO", MysqlCon)
        dr = Nothing
        Dim cantidad As Double = 0
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_nombre", p_codigo)
        cmd.Parameters.AddWithValue("@p_fecha_inicio", p_fecha_inicio)
        cmd.Parameters.AddWithValue("@p_fecha_fin", p_fecha_fin)
        cmd.Parameters.AddWithValue("@p_cliente", p_cliente)
        p_estado.Text = "Leyendo datos."
        Application.DoEvents()
        Dim fecha As Date
        p_dg_detalles.Rows.Clear()
        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            While (dr.Read)
                cantidad += dr(5)
                p_estado.Text = "Cargando datos   "
                Application.DoEvents()
                fecha = dr(1).ToString
                p_dg_detalles.Rows.Add(dr(0),
                                       fecha.ToString("dd/MM/yyyy"),
                                       dr(2),
                                       dr(3),
                                       dr(4),
                                       dr(5),
                                       dr(6))

                p_estado.Text = "Cargando datos..."
                p_cantidad.Text = convertir_formato_miles_decimales(cantidad)
                Application.DoEvents()
            End While
            p_cantidad.Text = convertir_formato_miles_decimales(cantidad)
            p_estado.Text = "Estado Normal..."
            Application.DoEvents()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            If Not IsNothing(dr) Then dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'SELECCIONA LOS DETALLES DE LOS PRODUCTOS VENDIDOS
    Public Sub SEL_HISTORIAL_PRODUCTO_VENDIDO_SIN_FILTRO(ByRef p_dg_detalles As DataGridView, ByVal p_fecha_inicio As DateTime,
                                              ByVal p_fecha_fin As DateTime, ByRef p_cantidad As String, ByRef p_estado As String)

        cmd = New MySqlCommand("SEL_HISTORIAL_PRODUCTO_VENDIDO_SIN_FILTRO", MysqlCon)
        dr = Nothing
        p_cantidad = 0
        Dim cantidad As Double = 0
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_fecha_inicio", p_fecha_inicio)
        cmd.Parameters.AddWithValue("@p_fecha_fin", p_fecha_fin)
        Dim fecha As Date
        p_dg_detalles.Rows.Clear()
        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            While (dr.Read)
                cantidad += dr(5)
                p_estado = "Leyendo datos...."
                fecha = dr(1).ToString
                p_dg_detalles.Rows.Add(dr(0),
                                       fecha.ToString("dd/MM/yyyy"),
                                       dr(2),
                                       dr(3),
                                       dr(4),
                                       dr(5),
                                       dr(6))
                p_estado = "Cargando datos..."
                Application.DoEvents()
            End While
            p_cantidad = convertir_formato_miles_decimales(cantidad)
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            If Not IsNothing(dr) Then dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub


    '*************************************************** FUNCIONES DE ACTUALIZAR MYSQL ******************************************************************

    'ACTUALIZA UNA FACTURA DE ESTADO ABIERTA A ESTADO CERRADA
    Public Sub UPD_CLOSE_FACT(ByVal p_codigo As Integer)

        cmd = New MySqlCommand("UPD_CLOSE_FACT", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_id", p_codigo)
        Try
            MysqlCon.Open()
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try
    End Sub

    Public Sub UPD_PEDIDO_PENDIENTE(ByVal p_codigo As Integer)

        cmd = New MySqlCommand("UPD_PEDIDO_PENDIENTE", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_id", p_codigo)
        Try
            MysqlCon.Open()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try
    End Sub

    'ACTUALIZA EL NUMERO DE COTIZACON
    Public Sub UPD_COTIZACION_NUMERO(ByVal p_numero As Integer)

        cmd = New MySqlCommand("UPD_COTIZACION_NUMERO", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_numero", p_numero)
        Try
            MysqlCon.Open()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try
    End Sub

    'ACTUALIZA EL NUMERO DE FACTURA
    Public Sub UPD_FACTURA_NUMERO(ByVal p_numero As Integer)

        cmd = New MySqlCommand("UPD_FACTURA_NUMERO", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_numero", p_numero)
        Try
            MysqlCon.Open()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try
    End Sub

    'ACTUALIZA LA TABLA FACTURA CON LOS NUEVOS DATOS
    Public Sub UPD_FACT_CLOSED(ByVal p_consecutivo As Integer, ByVal p_id_cliente As Integer,
                                   ByVal p_id_vendedor As Integer, ByVal p_comentario As String,
                                   ByVal p_comentario2 As String, ByVal p_subtotal As Double, ByVal p_leyenda As String,
                           ByVal p_descuento As Double, ByVal p_total As Double, ByVal p_fecha As DateTime, ByVal p_impuesto As Double,
                           ByVal p_pago As Double, ByVal p_open As Boolean, ByVal p_fauto As Integer, ByVal p_Oems As String)

        Dim consulta As String = "UPD_FACT_CLOSED"
        Try
            MysqlCon.Open()
            cmd = New MySqlCommand(consulta, MysqlCon)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@p_num", p_consecutivo)
            cmd.Parameters.AddWithValue("@p_ven", p_id_vendedor)
            cmd.Parameters.AddWithValue("@p_cli", p_id_cliente)
            cmd.Parameters.AddWithValue("@p_leyenda", p_leyenda)
            cmd.Parameters.AddWithValue("@p_com1", p_comentario)
            cmd.Parameters.AddWithValue("@p_com2", p_comentario2)
            cmd.Parameters.AddWithValue("@p_sub", p_subtotal)
            cmd.Parameters.AddWithValue("@p_desc", p_descuento)
            cmd.Parameters.AddWithValue("@p_total", p_total)
            cmd.Parameters.AddWithValue("@p_fecha", p_fecha)
            cmd.Parameters.AddWithValue("@p_imp", p_impuesto)
            cmd.Parameters.AddWithValue("@p_pago", p_pago)
            cmd.Parameters.AddWithValue("@p_open", p_open)
            cmd.Parameters.AddWithValue("@p_auto", p_fauto)
            cmd.Parameters.AddWithValue("@p_oems", p_Oems)

            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'ACTUALIZA UNA COTIZACION
    Public Sub UPD_COTIZACION(ByVal p_numero_cotizacion As Integer, ByVal p_id_cliente As Integer,
                                   ByVal p_id_vendedor As Integer, ByVal p_comentario1 As String,
                                   ByVal p_comentario2 As String, ByVal p_subtotal As Double, ByVal p_leyenda As String,
                           ByVal p_descuento As Double, ByVal p_total As Double, ByVal p_fecha As DateTime, ByVal p_impuesto As Double,
                           ByVal p_fauto As Integer)

        Dim consulta As String = "UPD_COTIZACION"
        Try
            MysqlCon.Open()
            cmd = New MySqlCommand(consulta, MysqlCon)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@p_num", p_numero_cotizacion)
            cmd.Parameters.AddWithValue("@p_ven", p_id_vendedor)
            cmd.Parameters.AddWithValue("@p_cli", p_id_cliente)
            cmd.Parameters.AddWithValue("@p_leyenda", p_leyenda)
            cmd.Parameters.AddWithValue("@p_com1", p_comentario1)
            cmd.Parameters.AddWithValue("@p_com2", p_comentario2)
            cmd.Parameters.AddWithValue("@p_sub", p_subtotal)
            cmd.Parameters.AddWithValue("@p_desc", p_descuento)
            cmd.Parameters.AddWithValue("@p_total", p_total)
            cmd.Parameters.AddWithValue("@p_fecha", p_fecha)
            cmd.Parameters.AddWithValue("@p_imp", p_impuesto)
            cmd.Parameters.AddWithValue("@p_auto", p_fauto)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'ACTUALIZA LA TABLA FACTURA CON LOS NUEVOS DATOS
    Public Sub UPD_ART(ByVal p_codigo As String, ByVal p_descripcion As String, ByVal p_precio1 As Double,
                           ByVal p_precio2 As Double, ByVal p_precio3 As Double, ByVal p_precio4 As Double,
                           ByVal p_tipo As String, ByVal p_impuesto As Boolean, ByVal p_compra As Double, ByVal p_barcode As String)

        Dim consulta As String = "UPD_ART"
        Try
            MysqlCon.Open()
            cmd = New MySqlCommand(consulta, MysqlCon)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@p_id", p_codigo)
            cmd.Parameters.AddWithValue("@p_desc", p_descripcion)
            cmd.Parameters.AddWithValue("@p_pre1", p_precio1)
            cmd.Parameters.AddWithValue("@p_pre2", p_precio2)
            cmd.Parameters.AddWithValue("@p_pre3", p_precio3)
            cmd.Parameters.AddWithValue("@p_pre4", p_precio4)
            cmd.Parameters.AddWithValue("@p_tipo", p_tipo)
            cmd.Parameters.AddWithValue("@p_imp", p_impuesto)
            cmd.Parameters.AddWithValue("@p_compra", p_compra)
            cmd.Parameters.AddWithValue("@p_barcode", p_barcode)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'ACTUALIZA UN CLIENTE
    Public Sub UPD_CLI(ByVal p_codigo As String, ByVal p_nombre As String, ByVal p_telefono As String,
                          ByVal p_direccion As String, ByVal p_advertencia As String, ByVal p_printer As Boolean,
                          ByVal p_vendedor As Integer, ByVal p_correo As String)

        Dim consulta As String = "UPD_CLI"
        Try
            MysqlCon.Open()
            cmd = New MySqlCommand(consulta, MysqlCon)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@p_nombre", p_nombre)
            cmd.Parameters.AddWithValue("@p_tel", p_telefono)
            cmd.Parameters.AddWithValue("@p_direccion", p_direccion)
            cmd.Parameters.AddWithValue("@p_id", p_codigo)
            cmd.Parameters.AddWithValue("@p_adv", p_advertencia)
            cmd.Parameters.AddWithValue("@p_printer", p_printer)
            cmd.Parameters.AddWithValue("@p_vendedor", p_vendedor)
            cmd.Parameters.AddWithValue("@p_correo", p_correo)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'ACTUALIZA EL CLIENTE DE UNA FACTURA
    Public Sub UPD_CLI_FACT(ByVal p_id As Integer, ByVal p_vendedor As Integer)

        Dim consulta As String = "UPD_CLI_FACT"
        Try
            MysqlCon.Open()
            cmd = New MySqlCommand(consulta, MysqlCon)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@p_id", p_id)
            cmd.Parameters.AddWithValue("@p_vend", p_vendedor)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'ACTUALIZA EL CLIENTE DE UNA FACTURA
    Public Sub UPD_CONFIGURACION(ByVal p_nombre_empresa As String, ByVal p_numero_factura As String, ByVal p_nombre_impresora As String,
                                 ByVal p_usar_impresora_termica As Boolean, ByVal p_usar_precios_anteriores As Boolean, ByVal p_cabecera_1 As String,
                                 ByVal p_cabecera_2 As String, ByVal p_cabecera_3 As String, ByVal p_cabecera_4 As String,
                                 ByVal p_cabecera_5 As String, ByVal p_cabecera_6 As String, ByVal p_pie_factura As String, ByVal p_numero_cotizacion As String,
                                 ByRef p_respuesta As String)

        Dim consulta As String = "UPD_CONFIGURACION"
        Try
            MysqlCon.Open()
            cmd = New MySqlCommand(consulta, MysqlCon)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@p_nombre_empresa", p_nombre_empresa)
            cmd.Parameters.AddWithValue("@p_numero_factura", p_numero_factura)
            cmd.Parameters.AddWithValue("@p_nombre_impresora", p_nombre_impresora)
            cmd.Parameters.AddWithValue("@p_usar_impresora_termica", p_usar_impresora_termica)
            cmd.Parameters.AddWithValue("@p_usar_precios_anteriores", p_usar_precios_anteriores)
            cmd.Parameters.AddWithValue("@p_cabecera_1", p_cabecera_1)
            cmd.Parameters.AddWithValue("@p_cabecera_2", p_cabecera_2)
            cmd.Parameters.AddWithValue("@p_cabecera_3", p_cabecera_3)
            cmd.Parameters.AddWithValue("@p_cabecera_4", p_cabecera_4)
            cmd.Parameters.AddWithValue("@p_cabecera_5", p_cabecera_5)
            cmd.Parameters.AddWithValue("@p_cabecera_6", p_cabecera_6)
            cmd.Parameters.AddWithValue("@p_pie_factura", p_pie_factura)
            cmd.Parameters.AddWithValue("@p_numero_cotizacion", p_numero_cotizacion)
            cmd.ExecuteNonQuery()
            p_respuesta = "Datos Guardados Correctamente"
        Catch ex As Exception
            p_respuesta = ex.ToString
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    '*************************************************** FUNCIONES DE BORRADO MYSQL ****************************************************************** 

    'BORRA LOS ARTICULOS DE UNA FACTURA
    Public Sub DEL_ART_FACT(ByVal p_fauto As Integer)

        Dim consulta As String = "DEL_ART_FACT"
        Try
            MysqlCon.Open()
            cmd = New MySqlCommand(consulta, MysqlCon)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@p_auto", p_fauto)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'BORRA TODOS! LOS DATOS DE LA TABLA TEMPORAL EN LA BASE DE DATOS 
    Public Sub DEL_TEMP_TODOS()

        Dim consulta As String = "DEL_TEMP"
        Try
            MysqlCon.Open()
            cmd = New MySqlCommand(consulta, MysqlCon)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'BORRA TODOS LOS DETALLES DE LOS ARTICULOS DE UNA COTIZACION
    Public Sub DEL_ART_COT(ByVal p_fauto As Integer)

        Dim consulta As String = "DEL_ART_COT"
        Try
            MysqlCon.Open()
            cmd = New MySqlCommand(consulta, MysqlCon)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@p_auto", p_fauto)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'BORRA UNA FACTURA
    Public Sub DEL_FACT(ByVal p_codigo As Integer)

        Dim consulta As String = "DEL_FACT"
        Try
            MysqlCon.Open()
            cmd = New MySqlCommand(consulta, MysqlCon)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@p_id", p_codigo)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'BORRA UNA COTIZACION
    Public Sub DEL_COT(ByVal p_codigo As Integer)

        Dim consulta As String = "DEL_COT"
        Try
            MysqlCon.Open()
            cmd = New MySqlCommand(consulta, MysqlCon)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@p_id", p_codigo)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'BORRA UN ARTICULO
    Public Sub DEL_ART(ByVal p_codigo As String)

        Dim consulta As String = "DEL_ART"
        Try
            MysqlCon.Open()
            cmd = New MySqlCommand(consulta, MysqlCon)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@p_id", p_codigo)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'BORRA UN CLIENTE
    Public Sub DEL_CLI(ByVal p_codigo As String)

        Dim consulta As String = "DEL_CLI"
        Try
            MysqlCon.Open()
            cmd = New MySqlCommand(consulta, MysqlCon)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@p_id", p_codigo)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    '*************************************************** FUNCIONES PARA DATOS DE IMPRESION DE FACTURAS MYSQL ******************************************************************

    'SELECCIONA LOS DATOS DE CABECERA DE UNA IMPRECION
    Public Sub Datos_Cabecera(ByVal p_codigo As Integer, ByRef p_printer As Boolean)

        cmd = New MySqlCommand("SEL_FACT_MOD", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_id", p_codigo)
        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            While (dr.Read)

                vp_codCliente = dr(0).ToString()
                vp_clientein = dr(1).ToString()
                vp_factImpin = dr(5)
                vp_coment1in = dr(6).ToString()
                vp_coment2in = dr(7).ToString()
                vp_descuentoin = (convertir_formato_miles_decimales(CDbl(dr(8).ToString)))
                vp_fechain = dr(9).ToString()
                vp_facturain = dr(11).ToString()
                vp_pagoin = (convertir_formato_miles_decimales(CDbl(dr(12).ToString)))
                vp_subtotalin = (convertir_formato_miles_decimales(CDbl(dr(13).ToString)))
                vp_totalin = (convertir_formato_miles_decimales(CDbl(dr(14).ToString)))
                p_printer = dr(15)

            End While

            vp_descuentoin = (convertir_formato_miles_decimales(CDbl(vp_descuentoin) / 100 * CDbl(vp_subtotalin)))
            vp_cambioin = CDbl(vp_pagoin) - CDbl(vp_totalin)

        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            If Not IsNothing(dr) Then dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'SELECCIONA LOS DATOS DE LA CABECERA DE UNA COTIZACION
    Public Sub Datos_Cabecera_Cot(ByVal p_codigo As Integer)

        cmd = New MySqlCommand("SEL_COT_MOD", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_id", p_codigo)
        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            While (dr.Read)

                vp_codCliente = dr(0).ToString()
                vp_clientein = dr(1).ToString()
                vp_factImpin = dr(5)
                vp_coment1in = dr(6).ToString()
                vp_coment2in = dr(7).ToString()
                vp_descuentoin = (convertir_formato_miles_decimales(CDbl(dr(8).ToString)))
                vp_fechain = dr(9).ToString()
                vp_facturain = dr(11).ToString()
                vp_subtotalin = (convertir_formato_miles_decimales(CDbl(dr(12).ToString)))
                vp_totalin = (convertir_formato_miles_decimales(CDbl(dr(13).ToString)))
            End While
            vp_descuentoin = (convertir_formato_miles_decimales(CDbl(vp_descuentoin) / 100 * CDbl(vp_subtotalin)))

        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            If Not IsNothing(dr) Then dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'SELECCIONA LOS DETALLES DE UNA IMPRESION DE FACTURA
    Public Sub Datos_Detalle(ByVal p_codigo As Integer, ByRef p_DG As DataGridView)

        Dim fecha As Date
        cmd = New MySqlCommand("SEL_FDET_MOD", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_id", p_codigo)
        p_DG.Rows.Clear()
        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            While (dr.Read)
                fecha = dr(7).ToString
                p_DG.Rows.Add(dr(0).ToString, dr(1).ToString, convertir_formato_miles_decimales(CDbl(dr(2).ToString)),
                            convertir_formato_miles_decimales(CDbl(dr(3).ToString)), convertir_formato_miles_decimales(CDbl(dr(4).ToString)),
                            convertir_formato_miles_decimales(CDbl(dr(5).ToString)), dr(6).ToString, fecha.ToString("dd/MM/yyyy HH:mm:ss"))
            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            If Not IsNothing(dr) Then dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'SELECCIONA LOS DETALLES DE UNA IMPRESION DE FACTURA
    Public Sub Datos_Detalle_PEDIDO(ByVal p_codigo As Integer, ByRef p_DG As DataGridView)

        Dim fecha As Date
        cmd = New MySqlCommand("SEL_DETALLE_PEDIDO", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_id", p_codigo)
        p_DG.Rows.Clear()

        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            While (dr.Read)
                fecha = dr(5).ToString
                p_DG.Rows.Add(dr(0).ToString,
                              "articulo_temporal",
                              convertir_formato_miles_decimales(CDbl(dr(1).ToString)),
                              convertir_formato_miles_decimales(CDbl(dr(2).ToString)),
                              convertir_formato_miles_decimales(CDbl("0")),
                              convertir_formato_miles_decimales(CDbl(dr(3).ToString)),
                              dr(4).ToString,
                              fecha.ToString("dd/MM/yyyy HH:mm:ss"))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            If Not IsNothing(dr) Then dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

    'SELECCIONA LOS DETALLES DE UNA COTIZACION PARA IMPRIMIR
    Public Sub Datos_Detalle_Cot(ByVal p_codigo As Integer, ByRef p_DG As DataGridView)

        cmd = New MySqlCommand("SEL_CDET_MOD", MysqlCon)
        dr = Nothing
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_id", p_codigo)
        Try
            MysqlCon.Open()
            dr = cmd.ExecuteReader()
            While (dr.Read)
                p_DG.Rows.Add(dr(0).ToString, dr(1).ToString, convertir_formato_miles_decimales(CDbl(dr(2).ToString)),
                              convertir_formato_miles_decimales(CDbl(dr(3).ToString)), convertir_formato_miles_decimales(CDbl(dr(4).ToString)),
                              convertir_formato_miles_decimales(CDbl(dr(5).ToString)), dr(6).ToString)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        Finally
            If Not IsNothing(dr) Then dr.Close()
            If MysqlCon.State = ConnectionState.Open Then MysqlCon.Close()
            If MysqlCon IsNot Nothing Then MysqlCon.Dispose()
            If cmd IsNot Nothing Then cmd.Dispose()
        End Try

    End Sub

End Module
