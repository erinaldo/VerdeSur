Imports System.Threading

Public Class Fr_Opciones_cargar

    Public DgRepDia As New DataGridView
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
    Private Sub inicio()

        Lb_Mensaje.Text = "ESTADO NORMAL..."
        Lb_Mensaje.Visible = True
        Me.Height = 293
        For i As Integer = 0 To 3
            Dim col As New DataGridViewTextBoxColumn
            DgRepDia.Columns.Add(col)
        Next

        Dt_Inicio.Format = DateTimePickerFormat.Custom
        Dt_Inicio.CustomFormat = "dd/MM/yyyy"
        Dt_Fin.Format = DateTimePickerFormat.Custom
        Dt_Fin.CustomFormat = "dd/MM/yyyy"

        SEL_CONFIG_FACTURA(nombre_empresa, numero_factura, usar_impresora_termica, usar_precios_anteriores, cabecera_1,
                           cabecera_2, cabecera_3, cabecera_4, cabecera_5, cabecera_6, pie_pagina)

        cabeceraFactura(0) = cabecera_1
        cabeceraFactura(1) = cabecera_2
        cabeceraFactura(2) = cabecera_3
        cabeceraFactura(3) = cabecera_4
        cabeceraFactura(4) = cabecera_5
        cabeceraFactura(5) = cabecera_6
    End Sub

    Private Sub genera_reporte(ByRef p_mensaje As Label, ByRef p_barra_espera As ProgressBar)
        Lb_Mensaje.Visible = True
        Me.Height = 342

        limpiar_boleanos()
        Dim reporte_seleccionado As Boolean = False

        If CB_Abajo.Checked Then
            Reporte_excel.vend_abajo = True
            reporte_seleccionado = True
        End If
        If CB_Arriba.Checked Then
            Reporte_excel.vend_arriba = True
            reporte_seleccionado = True
        End If
        If CB_Feria.Checked Then
            Reporte_excel.vend_feria = True
            reporte_seleccionado = True
        End If
        If CB_Feria_Abajo.Checked Then
            Reporte_excel.vend_feria_abajo = True
            reporte_seleccionado = True
        End If
        If CB_Lista.Checked Then
            Reporte_excel.vend_lista = True
            reporte_seleccionado = True
        End If

        If reporte_seleccionado Then
            Btn_Generar.Enabled = False

            p_barra_espera.Value = 5
            p_mensaje.Text = "Iniciando proceso..."
            Application.DoEvents()
            Thread.Sleep(500)
            p_barra_espera.Value = 10
            p_mensaje.Text = "Generando Reporte"
            Application.DoEvents()

            Dim fechaInicio As DateTime = Dt_Inicio.Value.ToString("dd/MM/yyyy") + " " + Dt_Inicio.Value.ToString("00:00:00")
            Dim fechaFin As DateTime = Dt_Fin.Value.ToString("dd/MM/yyyy") + " " + Dt_Fin.Value.ToString("23:59:59")

            p_mensaje.Text = "Cargando los datos del Reporte..."
            Application.DoEvents()
            Thread.Sleep(500)

            REPORTE_DIA(DgRepDia, fechaInicio, fechaFin, Lb_Mensaje, PB_Opciones_cargar)

            For Each itm In Fr_Facturas.Lv_Detalle_Fact_X_Cobrar_4.Items
                DgRepDia.Rows.Add(itm.SubItems(0).Text, itm.SubItems(1).Text, CDbl(itm.SubItems(2).Text), "LISTA")
            Next

            p_barra_espera.Value = 50
            p_mensaje.Text = "Creando Reporte en Excel..."
            Application.DoEvents()
            Thread.Sleep(500)

            Crear_Reporte_Excel(DgRepDia, "DIA", Lb_Mensaje, cabeceraFactura)
            p_barra_espera.Value = 100
            Application.DoEvents()
            Thread.Sleep(500)
            DgRepDia.RowCount = 1
            DgRepDia.Rows.Clear()
            Me.Close()
        Else
            MsgBox("SELECIONA UNA OPCION DE REPORTE", MsgBoxStyle.Information, "REPORTE")
        End If



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Generar.Click

        genera_reporte(Lb_Mensaje, PB_Opciones_cargar)

    End Sub

    Private Sub Fr_Opciones_cargar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        inicio()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btn_Cancelar.Click

        Me.Close()

    End Sub

    Private Sub limpiar_boleanos()

        Reporte_excel.vend_abajo = False
        Reporte_excel.vend_arriba = False
        Reporte_excel.vend_feria = False
        Reporte_excel.vend_feria_abajo = False
        Reporte_excel.vend_lista = False

    End Sub
End Class