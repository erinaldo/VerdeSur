Public Class Fr_Reporte_Fechas

    Public DG_ReporteFecha As New DataGridView
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btn_Generar.Click

        Btn_Generar.Enabled = False
        Me.Height = 265
        Dim fechaInicio As DateTime = Dt_Inicio.Value.ToString("dd/MM/yyyy") + " " + Dt_Inicio.Value.ToString("00:00:00")
        Dim fechaFin As DateTime = Dt_Fin.Value.ToString("dd/MM/yyyy") + " " + Dt_Fin.Value.ToString("23:59:59")
        PB_Opciones_cargar.Value = 5
        Application.DoEvents()
        REPORTE_FECHA(DG_ReporteFecha, fechaInicio, fechaFin, PB_Opciones_cargar, Lb_Mensaje)
        DG_ReporteFecha.Sort(DG_ReporteFecha.Columns(3), System.ComponentModel.ListSortDirection.Descending)
        Crear_Reporte_Excel(DG_ReporteFecha, "FECHA", Lb_Mensaje, cabeceraFactura)
        DG_ReporteFecha.RowCount = 1
        DG_ReporteFecha.Rows.Clear()

        Me.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Btn_Salir.Click
        Me.Close()
    End Sub

    Private Sub ReporteFechas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        inicio()

    End Sub

    Private Sub inicio()

        SEL_CONFIG_FACTURA(nombre_empresa, numero_factura, usar_impresora_termica, usar_precios_anteriores, cabecera_1,
                           cabecera_2, cabecera_3, cabecera_4, cabecera_5, cabecera_6, pie_pagina)

        cabeceraFactura(0) = cabecera_1
        cabeceraFactura(1) = cabecera_2
        cabeceraFactura(2) = cabecera_3
        cabeceraFactura(3) = cabecera_4
        cabeceraFactura(4) = cabecera_5
        cabeceraFactura(5) = cabecera_6

        Me.Height = 218
        Lb_Mensaje.Visible = True
        Lb_Mensaje.Text = "ESTADO NORMAL..."
        For i As Integer = 0 To 3
            Dim col As New DataGridViewTextBoxColumn
            DG_ReporteFecha.Columns.Add(col)
        Next
        Dt_Inicio.Value = DateSerial(Today.Year, Today.Month - 1, 1)
        Dt_Fin.Value = DateSerial(Today.Year, Today.Month, 0)

    End Sub

End Class