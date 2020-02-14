Module Mensajes

    'CAMBIA EL TEXTO DEL LABEL DE ESTADO EN EL FORMULARIO FR_OPCIONES_CARGAR
    Public Sub msj_opciones_cargar(ByVal mensaje As String)

        Fr_Opciones_cargar.Lb_Mensaje.Text = mensaje
        Application.DoEvents()

    End Sub


    Public Sub msj_reporte_fechas(ByVal mensaje As String)

        Fr_Reporte_Fechas.Lb_Mensaje.Text = mensaje
        Application.DoEvents()

    End Sub


End Module
