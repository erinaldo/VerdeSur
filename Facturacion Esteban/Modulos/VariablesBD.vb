Imports MySql.Data.MySqlClient

Module VariablesBD

    Dim MysqlCon As MySqlConnection
    Dim cmd As MySqlCommand
    Dim dr As MySqlDataReader

    'vp = variable publica

    'VARIABLES DE FACTURAS
    Public vp_fact_auto As Integer = Nothing
    Public vp_factura_id As Integer = Nothing
    Public vp_factura_numero As Integer = Nothing

    Public vp_tiempo_contador As Integer
    Public vp_estado As String = Nothing
    Public vp_totalin As String
    Public vp_subtotalin As String
    Public vp_descuentoin As String
    Public vp_pagoin As String
    Public vp_cambioin As Double
    Public vp_factImpin As Integer
    Public vp_fechain As Date
    Public vp_facturain As String
    Public vp_ticket_matriz As Boolean = False

    Public vp_prod_id_temp As String
    Public vp_prod_desc_temp As String
    Public vp_prod_cant_temp As String
    Public vp_prod_precio_temp As String
    Public vp_prod_imp_temp As String
    Public vp_prod_aut_temp As Integer

    'VARIABLES DE ARTICULOS
    Public vp_art_id As String
    Public vp_art_Cod As String
    Public vp_art_Nombre As String
    Public vp_art_precio1 As String
    Public vp_art_precio2 As String
    Public vp_art_precio3 As String
    Public vp_art_precio4 As String
    Public vp_precio1 As Double = Nothing
    Public vp_precio2 As Double = Nothing
    Public vp_precio3 As Double = Nothing
    Public vp_preMayor As Double = Nothing
    Public vp_art_auto As Integer = Nothing

    'VARIABLES DE CLIENTES
    Public vp_cli_id As Integer = Nothing
    Public vp_telefono As String = ""
    Public vp_clientein As String
    Public vp_codCliente As String
    Public vp_advertencia As String = ""
    Public vp_coment1in As String
    Public vp_coment2in As String
    Public vp_vendedor_auto As Integer = Nothing

    'VARIABLE QUE GUARDA EL MOTIVO DE LA IMPRESION
    Public motivo_impresion As String = Nothing

    Public Sub limpiaVariablesPrint()
        vp_factImpin = 0
        vp_fechain = Nothing
        vp_facturain = ""
        vp_clientein = ""
        vp_codCliente = ""
        vp_coment1in = ""
        vp_coment2in = ""
        vp_totalin = ""
        vp_subtotalin = 0
        vp_descuentoin = 0
        vp_pagoin = ""
        vp_cambioin = 0
    End Sub

    Public Sub limpia_variablesBD_Modulo()

        vp_fact_auto = Nothing
        vp_factura_id = Nothing
        vp_precio1 = Nothing
        vp_precio2 = Nothing
        vp_precio3 = Nothing
        vp_preMayor = Nothing
        vp_art_auto = Nothing
        vp_cli_id = Nothing
        vp_tiempo_contador = Nothing
        vp_estado = Nothing
        vp_telefono = Nothing

        vp_prod_id_temp = Nothing
        vp_prod_desc_temp = Nothing
        vp_prod_cant_temp = Nothing
        vp_prod_precio_temp = Nothing
        vp_prod_imp_temp = Nothing
        vp_prod_aut_temp = Nothing

    End Sub

End Module
