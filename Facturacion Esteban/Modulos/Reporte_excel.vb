Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO
Imports System.Threading

Module Reporte_excel

    Public vend_arriba As Boolean = False
    Public vend_abajo As Boolean = False
    Public vend_feria_abajo As Boolean = False
    Public vend_feria As Boolean = False
    Public vend_lista As Boolean = False

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


    Public Sub Crear_Reporte_Excel(ByVal datos As DataGridView, ByVal tipo_reporte As String, ByRef p_estado As Label, ByVal p_cabecera_impresion As Array)

        Dim carpeta As String = "C:\Reportes"
        Dim dia As String = Date.Now.Day & "D" & Date.Now.Month & "M"
        dia += Date.Now.Year & "A_" & Date.Now.Hour & "H" & Date.Now.Minute & "M"
        Dim file_report As String = carpeta & "\Facturas_" & dia & ".xlsx"

        eliminar_archivos_viejos(carpeta)
        Crea_ficheros(carpeta, file_report)

        Dim oExcel As Object
        oExcel = CreateObject("Excel.Application")
        Dim oBook As Excel.Workbook
        Dim oSheet As Excel.Worksheet
        Dim chartRange As Excel.Range

        oBook = oExcel.Workbooks.Add
        oSheet = oExcel.Worksheets(1)
        chartRange = Nothing

        cabecera_reporte(oSheet, chartRange, p_cabecera_impresion)
        p_estado.Text = "Guardando los datos en Excel"
        Application.DoEvents()
        If tipo_reporte = "DIA" Then
            report_dia(oSheet, chartRange, datos)
        ElseIf tipo_reporte Like "FECHA" Then
            report_fecha(oSheet, chartRange, datos, Fr_Reporte_Fechas.Lb_Mensaje, Fr_Reporte_Fechas.PB_Opciones_cargar)
        End If

        Try

            oBook.SaveAs(file_report)
            oBook.Close()
            oExcel.Quit
            releaseObject(oExcel)
            releaseObject(oBook)
            releaseObject(oSheet)
            releaseObject(chartRange)

            GC.Collect()
            GC.WaitForPendingFinalizers()
            GC.Collect()
            GC.WaitForPendingFinalizers()
            If tipo_reporte = "DIA" Then

                p_estado.Text = "Abriendo el Archivo"
                Application.DoEvents()
            ElseIf tipo_reporte Like "FECHA" Then
                p_estado.Text = "Abriendo el Archivo"
                Application.DoEvents()
            End If

            Process.Start("Excel.exe", file_report)

        Catch ex As Exception
            MsgBox(ex.ToString)

        Finally

        End Try


    End Sub

    Public Sub Crea_ficheros(ByVal folder As String, ByVal file As String)

        Dim archivo As String = folder & file
        Dim oExcel As Object
        oExcel = CreateObject("Excel.Application")

        Try
            If (Not System.IO.Directory.Exists(folder)) Then
                System.IO.Directory.CreateDirectory(folder)
            End If

            If System.IO.File.Exists(archivo) Then
                System.IO.File.Delete(archivo)
                MsgBox("Archivo Borrado")
            End If
        Catch ex As Exception
            MsgBox("PUEDE QUE EL REPORTE QUE INTENTA CREAR YA ESTE ABIERTO, CIERRE CUALQUIER ARCHIVO DE EXCEL")
            Return
        End Try

    End Sub

    Public Sub cabecera_reporte(ByVal libro As Object, ByVal rango As Object, ByVal p_cabecera As Array)

        libro.Name = "Reporte"
        rango = libro.Range("A1", "D1")
        rango.Merge()
        libro.Cells(1, 1).Value = "BOLSAS PLASTICAS EL MERCADITO"
        rango.BorderAround(Excel.XlLineStyle.xlDouble,
        Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.
        xlColorIndexAutomatic)
        rango.HorizontalAlignment = 3
        rango.VerticalAlignment = 3
        rango.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow)
        rango.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red)
        rango.Font.Size = 20
        rango = libro.Range("A2", "C2")
        rango.Merge()
        libro.Cells(2, 1).Value = p_cabecera(0)
        rango = libro.Range("A3", "C3")
        rango.Merge()
        libro.Cells(3, 1).Value = p_cabecera(1)
        rango = libro.Range("A4", "C4")
        rango.Merge()
        libro.Cells(4, 1).Value = p_cabecera(2)
        rango = libro.Range("A5", "C5")
        rango.Merge()
        libro.Cells(5, 1).Value = p_cabecera(3)
        rango = libro.Range("A6", "C6")
        rango.Merge()
        libro.Cells(6, 1).Value = p_cabecera(4)
        rango = libro.Range("A7", "C7")
        rango.Merge()
        libro.Cells(7, 1).Value = p_cabecera(5)


    End Sub

    Public Sub report_dia(ByVal libro As Object, ByVal rango As Object, ByVal DG As DataGridView)

        Dim fila As Integer = 0
        Dim inicio As Integer = 11
        Dim fin As Integer = 0
        Dim celdaI As String = ""
        Dim celdaF As String = ""

        'TITUTLOS DE LOS ENCABEZADOS DE LAS CELDAS

        libro.Cells(10, 1).Value = "NUMERO DE FACTURA"
        libro.Cells(10, 2).Value = "CLIENTE"
        libro.Cells(10, 3).Value = "TOTAL"
        libro.Cells(10, 4).Value = "VENDEDOR"

        With libro.Range("A10", "D10")
            .Font.Bold = True
            .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            .HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter
        End With

        If vend_arriba Then
            vendedor(fila, libro, DG, fin, inicio, "ARRIBA", Fr_Opciones_cargar.Lb_Mensaje)
        End If
        If vend_abajo Then
            vendedor(fila, libro, DG, fin, inicio, "ABAJO", Fr_Opciones_cargar.Lb_Mensaje)
        End If
        If vend_feria Then
            vendedor(fila, libro, DG, fin, inicio, "FERIA", Fr_Opciones_cargar.Lb_Mensaje)
        End If
        If vend_feria_abajo Then
            vendedor(fila, libro, DG, fin, inicio, "FERIA ABAJO", Fr_Opciones_cargar.Lb_Mensaje)
        End If
        If vend_lista Then
            vendedor(fila, libro, DG, fin, inicio, "LISTA", Fr_Opciones_cargar.Lb_Mensaje)
        End If

        With libro.Range("C11", "C" & fin)
            .NumberFormat = "#,###,###"
        End With

        libro.Cells(10, 1).ColumnWidth = 30
        libro.Cells(10, 2).ColumnWidth = 50
        libro.Cells(10, 3).ColumnWidth = 30
        libro.Cells(10, 4).ColumnWidth = 50

    End Sub

    Public Sub report_fecha(ByVal libro As Object, ByVal rango As Object, ByVal DG As DataGridView, ByRef p_mensaje As Label, p_bara_progreso As ProgressBar)


        Dim fila As Integer = 0
        Dim inicio As Integer = 11
        Dim fin As Integer = 0
        Dim celdaI As String = ""
        Dim celdaF As String = ""

        'TITUTLOS DE LOS ENCABEZADOS DE LAS CELDAS

        libro.Cells(10, 1).Value = "CLIENTE"
        libro.Cells(10, 2).Value = "FACTURA N°"
        libro.Cells(10, 3).Value = "TOTAL"
        libro.Cells(10, 4).Value = "FECHA"

        With libro.Range("A10", "D10")
            .Font.Bold = True
            .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            .HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter
        End With

        detalle_fecha_excel(fila, libro, DG, fin, inicio, p_mensaje, p_bara_progreso)

        With libro.Range("C11", "C" & fin)
            .NumberFormat = "#,###,###"
        End With
        With libro.Range("D11", "D" & fin)
            .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            .HorizontalAlignment = Excel.Constants.xlRight
            .NumberFormat = "dd/MM/yyyy HH:MM:ss"
        End With

        libro.Cells(10, 1).ColumnWidth = 50
        libro.Cells(10, 2).ColumnWidth = 20
        libro.Cells(10, 3).ColumnWidth = 30
        libro.Cells(10, 4).ColumnWidth = 20

    End Sub

    Public Sub vendedor(ByRef num_fila As Integer, ByVal libro1 As Object, ByVal DG1 As DataGridView,
               ByRef fin1 As Integer, ByRef inicio1 As Integer, ByVal tipo_vendedor As String, ByRef p_mensaje As Label)

        Const linea As Integer = 11

        'IMPRIME EL VENDEDOR DE ABAJO
        For i = 0 To DG1.Rows.Count - 1

            If DG1.Rows(i).Cells(3).Value = tipo_vendedor Then
                libro1.Cells(num_fila + linea, 1) = DG1.Rows(i).Cells(0).Value
                libro1.Cells(num_fila + linea, 2) = DG1.Rows(i).Cells(1).Value
                libro1.Cells(num_fila + linea, 3) = DG1.Rows(i).Cells(2).Value
                libro1.Cells(num_fila + linea, 4) = DG1.Rows(i).Cells(3).Value
                num_fila += 1
                p_mensaje.Text = "Ingresando datos: " & i + 1
                Application.DoEvents()
            End If
            progressBar_Opciones_Cargar(porcentaje_guardado_excel(porcentaje(i + 1, DG1.Rows.Count)) + 50)

        Next

        libro1.Cells(num_fila + linea, 3) = 5500
        libro1.Cells(num_fila + linea, 2) = "VUELTOS"
        num_fila += 1

        libro1.Cells(num_fila + linea, 2) = "TRAE EN 20.000 Y 10.000"
        num_fila += 1
        libro1.Cells(num_fila + linea, 2) = "TRAE EN 5.000"
        num_fila += 1
        libro1.Cells(num_fila + linea, 2) = "TRAE EN 2.000"
        num_fila += 1
        libro1.Cells(num_fila + linea, 2) = "TRAE EN 1.000"
        num_fila += 1
        libro1.Cells(num_fila + linea, 2) = "TRAE EN MONEDAS"
        num_fila += 1

        'IMPRIME EL TOTAL DEL VENDEDOR
        fin1 = num_fila + linea
        If fin1 <> inicio1 Then
            libro1.Range("C" & fin1).Formula = "=SUM(C" & inicio1 & ":C" & fin1 - 1 & ")"
            libro1.Range("C" & fin1).Font.Bold = True
        End If

        'DEJA DOS FILAS VACIAS
        num_fila += 2
        inicio1 = num_fila + linea


    End Sub

    Public Sub detalle_fecha_excel(ByRef num_fila As Integer, ByVal libro1 As Object, ByVal DG1 As DataGridView,
               ByRef fin1 As Integer, ByRef inicio1 As Integer, ByRef p_mensaje_detalle As Label, ByRef p_barra_estado As ProgressBar)

        Const linea As Integer = 11

        'IMPRIME EL VENDEDOR DE ABAJO
        For i = 0 To DG1.Rows.Count - 1
            p_barra_estado.Value = porcentaje_guardado_excel(porcentaje(i + 1, DG1.Rows.Count) + 50)
            p_mensaje_detalle.Text = "Cargando dato en Excel: " & i + 1
            Application.DoEvents()
            libro1.Cells(num_fila + linea, 1) = DG1.Rows(i).Cells(0).Value
            libro1.Cells(num_fila + linea, 2) = DG1.Rows(i).Cells(1).Value
            libro1.Cells(num_fila + linea, 3) = DG1.Rows(i).Cells(2).Value
            libro1.Cells(num_fila + linea, 4) = DG1.Rows(i).Cells(3).Value
            num_fila += 1

            porcentaje(i + 1, DG1.Rows.Count)

        Next

        'IMPRIME EL TOTAL DEL VENDEDOR
        fin1 = num_fila + linea

    End Sub

    'ELIMINA LOS ARCHIVOS MAS ANTIGUOS DESPUES DE 10 EN UNA CARPETA
    Private Sub eliminar_archivos_viejos(ByVal Directorio As String)

        '
        For Each file As IO.FileInfo In New IO.DirectoryInfo(Directorio).GetFiles("*.xlsx")
            If (Now - file.CreationTime).Days > 10 Then file.Delete()
        Next

        '*****************    CODIGO FUNCIONAL QUE ELIMINA LOS ARCHIVOS CUANDO EXISTEN MAS DE X **********************'

        'Dim files As IO.FileInfo() = (New IO.DirectoryInfo(Directorio)).GetFiles("*.xlsx")
        'Try
        '    If files.Length > 9 Then
        '        Array.Sort(files, New Comparison(Of IO.FileInfo)(AddressOf CompareFileInfosByDescendingCreationTime))
        '        For index As Integer = 9 To files.GetUpperBound(0) Step 1
        '            'File.SetAttributes(files(index).ToString, FileAttributes.Normal)
        '            files(index).Delete()

        '        Next index
        '    End If

        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'End Try

    End Sub

    Private Function CompareFileInfosByDescendingCreationTime(ByVal file1 As IO.FileInfo,
                                                          ByVal file2 As IO.FileInfo) As Integer
        Return -Date.Compare(file1.CreationTime, file2.CreationTime)

    End Function

End Module
