Imports System.Text.RegularExpressions

Module ImprimeFacturaMatriz

    Public Const eClear As String = Chr(27) + "@"
    Public Const eNegritaOn As String = Chr(27) + Chr(69) + "1"
    Public Const eNegritaOff As String = Chr(27) + Chr(69) + "0"
    Public Const eCentre As String = Chr(27) + Chr(97) + "1"
    Public Const eLeft As String = Chr(27) + Chr(97) + "0"
    Public Const eRight As String = Chr(27) + Chr(97) + "2"
    Public Const eDrawer As String = eClear + Chr(27) + "p" + Chr(0) + ".}"
    Public Const eCut As String = Chr(27) + "i" + vbCrLf
    Public Const eSmlText As String = Chr(27) + "!" + Chr(1)
    Public Const eBigText As String = Chr(27) + "!" + Chr(16)
    Public Const eNmlText As String = Chr(27) + "!" + Chr(0)
    Public Const eInit As String = eNmlText + Chr(13) + Chr(27) +
    "c6" + Chr(1) + Chr(27) + "R3" + vbCrLf
    Public Const eBigCharOn As String = Chr(27) + "!" + Chr(56)
    Public Const eBigCharOff As String = Chr(27) + "!" + Chr(0)
    Public Const eUltimaLinea As String = Chr(27) + Chr(100) + "1"
    Public Const eCol1 As String = Chr(27) + Chr(81) + "3"
    Public Const eCol2 As String = Chr(27) + Chr(92) + " 15" + " 0"
    Public Const eCol3 As String = Chr(27) + Chr(36) + "45L" + "0H"
    Public Const clear As String = Chr(27) + Chr(60)
    Public prn_matriz As New RawPrinterHelper
    Public PrinterNameMatriz As String = ""
    Private PrinterName As String = "EPSON M"
    Dim _LongitudImpresion As Integer = 0

    Public Sub StartPrintMatriz()
        prn_matriz.OpenPrint(PrinterName)
    End Sub

    Public Sub StartPrintTiqueteMatriz(ByVal p_longitudImpresion As Integer)
        prn_matriz.OpenPrint(PrinterNameMatriz)
        _LongitudImpresion = p_longitudImpresion
    End Sub

    Public Sub PrintFooterMatrizBn()
        Print_Matriz(vbLf + vbLf + vbLf + vbLf + vbLf + vbLf + eCut)
    End Sub

    Public Sub PrintTiqueteElectonicoMatriz(ByVal linea1 As TextBox)

        Print_Matriz(eDrawer)
        Print_Matriz(eInit + eSmlText + eCentre + "".PadLeft((_LongitudImpresion), "="))
        Dim _LineaNumero As Integer = 0
        Dim temp As String = ""
        Dim _ImprimirLinea As String = ""
        Dim _TamannoDescripcion As Integer = _LongitudImpresion - 23
        Dim _LineaDetalles As Integer = 0
        Dim _Cantidad As String = ""
        Dim _Descripcion As String = ""
        Dim _Subtotal As String = ""

        For i As Integer = 0 To linea1.Lines().Length - 1
            _ImprimirLinea = linea1.Lines(i).ToString

            If i = 0 Then
                'Imprime Nombre de la empresa
                Print_Matriz(eSmlText + eNegritaOn + eCentre + _ImprimirLinea + eNegritaOff)
                Print_Matriz(eSmlText + "  " + "".PadLeft((_LongitudImpresion - 4), "="))
                'Imprime  Cedula
                temp = linea1.Lines(1).ToString + ": "
                temp += linea1.Lines(2).ToString
                Print_Matriz(eSmlText + eNegritaOff + eCentre + temp + eNegritaOff)
                'Imprime  Telefono
                temp = linea1.Lines(3).ToString + ": "
                temp += linea1.Lines(4).ToString
                Print_Matriz(eSmlText + eCentre + temp + eNegritaOff)
                'Imprime Correo
                _ImprimirLinea = linea1.Lines(5).ToString
                Print_Matriz(eCentre + _ImprimirLinea)
                'Imprime Direccion
                _ImprimirLinea = linea1.Lines(6).ToString & " " & linea1.Lines(7).ToString
                Print_Matriz(eCentre + _ImprimirLinea)
                Print_Matriz(" ")
                'Imprime el Numero de la factura electronica
                _ImprimirLinea = linea1.Lines(8).ToString
                Print_Matriz(eSmlText + eNegritaOn + eLeft + _ImprimirLinea + eNegritaOff)
                'Imprime  el estado (Contado o Credito)
                _ImprimirLinea = linea1.Lines(9).ToString
                Print_Matriz(eSmlText + eNegritaOn + eLeft + _ImprimirLinea + eNegritaOff)
                'Imprime  un espacio en blanco
                _ImprimirLinea = linea1.Lines(10).ToString
                Print_Matriz(eSmlText + eNegritaOff + eLeft + _ImprimirLinea)
                'Imprime la Clave
                temp = linea1.Lines(11).ToString + " "
                temp += linea1.Lines(12).ToString
                Print_Matriz(eSmlText + eLeft + temp + eNegritaOff)
                'Imprime el Numero de Consolidado
                temp = linea1.Lines(13).ToString + " "
                temp += linea1.Lines(14).ToString
                Print_Matriz(eSmlText + temp + eNegritaOff)
                'Imprime  la fecha
                temp = linea1.Lines(15).ToString + " "
                temp += linea1.Lines(16).ToString
                Print_Matriz(eSmlText + temp + eNegritaOff)
                'Imprime  la hora
                temp = linea1.Lines(17).ToString + " "
                temp += linea1.Lines(18).ToString
                Print_Matriz(eSmlText + temp + eNegritaOff)
                'Imprime  el Usuario que creo la factura
                temp = linea1.Lines(19).ToString + " "
                temp += linea1.Lines(20).ToString
                Print_Matriz(eSmlText + temp + eNegritaOff)
                'Imprime  el nombre del cliente
                temp = linea1.Lines(21).ToString + " "
                temp += linea1.Lines(22).ToString
                Print_Matriz(eSmlText + temp + eNegritaOff)
                'Imprime la cedula del cliente
                temp = linea1.Lines(23).ToString + " "
                temp += linea1.Lines(24).ToString
                Print_Matriz(eSmlText + temp)
                Print_Matriz(" ")
            End If

            If i = 25 Then
                Println_Matriz(eSmlText + "  CANT.  ") '9
                Println_Matriz("DESCRIPCION") '11
                Println_Matriz("".PadLeft((_LongitudImpresion - 32), _Espacios))
                Print_Matriz("SUBTOTAL C/.") '12

                Println_Matriz(eSmlText + "  -----  ")
                Println_Matriz("".PadLeft((_TamannoDescripcion - 1), "-"))
                Print_Matriz(" -------------")
            End If

            If i = 28 Then
                _LineaNumero = 28
                Dim _UltimaLinea As Boolean = False

                While Not _UltimaLinea

                    If linea1.Lines(_LineaNumero).ToString = "Sub Total" Then
                        _UltimaLinea = True
                    Else
                        For j As Integer = 0 To 2
                            _Cantidad = linea1.Lines(_LineaNumero).ToString
                            _Cantidad = _Cantidad.Replace(",", "")
                            _Cantidad = _Cantidad.Replace(".", ",")
                            _Descripcion = Regex.Replace(linea1.Lines(_LineaNumero + 1).ToString, "\s{2,}", " ")
                            _Subtotal = linea1.Lines(_LineaNumero + 2).ToString
                        Next
                        PrintTiqueteDetallesMatriz(_Cantidad, _Descripcion, _Subtotal)
                        _LineaNumero = _LineaNumero + 3
                    End If

                End While
            End If


            If linea1.Lines(i).ToString.Equals("Sub Total") Then
                Print_Matriz(" ")
                _ImprimirLinea = linea1.Lines(i).ToString + ": " + linea1.Lines(i + 1).ToString
                Print_Matriz(eLeft + _ImprimirLinea)
            End If

            If linea1.Lines(i).ToString.Equals("I.V.") Then
                _ImprimirLinea = linea1.Lines(i).ToString + ": " + linea1.Lines(i + 1).ToString
                Print_Matriz(eLeft + _ImprimirLinea)
            End If

            If linea1.Lines(i).ToString.Contains("Imp. S") Then
                PrintDashes_Matriz()
                _ImprimirLinea = linea1.Lines(i + 2).ToString + ": " + linea1.Lines(i + 3).ToString + " " + linea1.Lines(i + 4).ToString
                Print_Matriz(eCentre + eBigText + eNegritaOn + _ImprimirLinea + eNegritaOff + eSmlText)
                PrintDashes_Matriz()
            End If

            If linea1.Lines(i).ToString.Contains("Autorizada") Then
                _ImprimirLinea = linea1.Lines(i - 1).ToString
                Print_Matriz(eLeft + _ImprimirLinea)
                _ImprimirLinea = linea1.Lines(i).ToString
                Print_Matriz(eLeft + _ImprimirLinea)
                _ImprimirLinea = linea1.Lines(i + 1).ToString
                Print_Matriz(eLeft + _ImprimirLinea)
                _ImprimirLinea = linea1.Lines(i + 2).ToString
                Print_Matriz(eLeft + _ImprimirLinea)
                Print_Matriz(" ")
            End If

            If linea1.Lines(i).ToString.Contains("Comentarios") Then
                _LineaNumero = i
                _ImprimirLinea = linea1.Lines(i).ToString + " " + linea1.Lines(_LineaNumero + 1).ToString
                Print_Matriz(eLeft + _ImprimirLinea)
                _LineaNumero = i + 2
                While _LineaNumero <> (linea1.Lines().Length)
                    _ImprimirLinea = linea1.Lines(_LineaNumero).ToString
                    Print_Matriz(eLeft + _ImprimirLinea)
                    _LineaNumero += 1
                End While
            End If

            If linea1.Lines(i).ToString.Contains("Vuelto") Then
                _ImprimirLinea = linea1.Lines(i).ToString
                Print_Matriz(eLeft + _ImprimirLinea)
            End If
        Next
    End Sub

    Public Sub PrintTiqueteDetallesMatriz(ByVal p_cantidad As String, ByVal p_descripcion As String, ByVal p_subtotal As String)

        Dim _TamannoDescripcion As Integer = _LongitudImpresion - 23
        Dim _DescripcionTemporal As String = p_descripcion
        Dim _Cantidad As String = convertir_formato_miles_decimales(CDbl(p_cantidad))
        _Cantidad = _Cantidad.Replace(",", ".")
        'IMPRIME LA CANTIDAD DEL ARTICULO
        If _Cantidad.Length <= 7 Then
            Println_Matriz("".PadRight(7 - _Cantidad.Length, _Espacios))
            Println_Matriz(_Cantidad)
            Println_Matriz("  ")
        Else
            Println_Matriz("####.##")
            Println_Matriz("  ")
        End If

        If p_descripcion.Length > _TamannoDescripcion Then
            _DescripcionTemporal = p_descripcion.Substring(0, _TamannoDescripcion - 1) & "_"
        End If

        'IMPRIME LA DESCRIPCION
        If p_descripcion.Length > _TamannoDescripcion Then

            'SI LA DESCRIPCION SOBREPASA LOS 18 CARACTERES IMPRIME UNA PRIMERA PARTE
            'CON EL TOTAL DEL ARTICULO Y PASA A ESCRIBIR LA CONTINUACION EN LA SIGUIENTE LINEA

            Println_Matriz(_DescripcionTemporal)
            Println_Matriz("".PadRight((_TamannoDescripcion + 1) - _DescripcionTemporal.Length, _Espacios))

            'IMPRIME EL TOTAL POR ARTICULO
            If p_subtotal.Length <= 13 Then
                Println_Matriz("".PadRight(13 - p_subtotal.Length, _Espacios))
                Print_Matriz(p_subtotal)
            Else
                Print_Matriz("##.###.###.##")
            End If

            Println_Matriz("".PadRight(9, _Espacios))
            Print_Matriz(p_descripcion.Substring((_TamannoDescripcion - 1), p_descripcion.Length - (_TamannoDescripcion - 1)))

        Else

            Println_Matriz(p_descripcion)
            Println_Matriz("".PadRight((_TamannoDescripcion + 1) - p_descripcion.Length, _Espacios))

            'IMPRIME EL TOTAL POR ARTICULO
            If p_subtotal.Length <= 13 Then
                Println_Matriz("".PadRight(13 - p_subtotal.Length, _Espacios))
                Print_Matriz(p_subtotal)
            Else
                Print_Matriz("##.###.###.##")
            End If
        End If

    End Sub


    Public Sub PrintFooterTiqueteMatriz()

        Print_Matriz(eCentre + "Gracias Por Su Compra!")
        Print_Matriz(vbLf + vbLf + vbLf + vbLf + vbLf + vbLf + eCut)

    End Sub

    Public Sub PrintTiqueteMatrizBn(ByVal linea1 As TextBox)

        Print(eDrawer)
        Dim _LineaNumero As Integer = 0
        Dim temp As String = ""
        Dim _ImprimirLinea As String = ""
        Dim _TamannoDescripcion As Integer = _LongitudImpresion - 23
        Dim _LineaDetalles As Integer = 0
        Dim _Cantidad As String = ""
        Dim _Descripcion As String = ""
        Dim _Subtotal As String = ""

        For i As Integer = 0 To linea1.Lines().Length - 1
            _ImprimirLinea = linea1.Lines(i).ToString

            If i = 0 Then
                'Imprime Nombre de la empresa
                Print_Matriz(eSmlText + eNegritaOn + eCentre + _ImprimirLinea + eNegritaOff)
                Print_Matriz(eSmlText + eCentre + linea1.Lines(1).ToString + eNegritaOff)
                Print_Matriz(" ")
            End If
            If i > 1 Then
                Print_Matriz(eLeft + linea1.Lines(i).ToString)
            End If
        Next


    End Sub

    Public Sub PrintHeaderMatriz(ByVal linea1 As String, ByVal linea2 As Array)

        Print_Matriz(eInit + eSmlText + eCentre + "=======================================")
        Print_Matriz(eNmlText + eNegritaOn + eCentre + linea1 + eNegritaOff)
        Print_Matriz(eSmlText + "===================================")

        Print_Matriz(eSmlText + eCentre)
        For Each Value In linea2
            If Value <> "" Then
                Print_Matriz(Value)
            End If
        Next

        Print_Matriz(eLeft + " ")

    End Sub


    Public Sub PrintHeaderCot_Matriz(ByVal linea1 As String, ByVal linea2 As Array)

        Print_Matriz(eInit + eSmlText + eCentre + "=======================================")
        Print_Matriz(eNmlText + eNegritaOn + eCentre + linea1 + eNegritaOff)
        Print_Matriz(eSmlText + "===================================")

        Print_Matriz(eSmlText + eCentre)
        For Each Value In linea2
            If Value <> "" Then
                Print_Matriz(Value)
            End If
        Next

        Print_Matriz(" ")
        Print_Matriz(" ")

        Print_Matriz(eSmlText + eCentre + "=================================")
        Print_Matriz(eNmlText + eNegritaOn + eCentre + "* PROFORMA *" + eNegritaOff)
        Print_Matriz(eSmlText + "=================================")

        Print_Matriz(" ")
        Print_Matriz(" ")

        Print_Matriz(eLeft + " ")

    End Sub

    Public Sub PrintDetallesMatriz(ByVal fecha As DateTime, ByVal factura As String, ByVal cliente As String,
                             ByVal cod As String, ByVal coment1 As String, ByVal coment2 As String, ByVal dir As String)

        Println_Matriz(eLeft + "FACTURA N")
        Println_Matriz("".PadRight(12 - factura.Length, " "))
        Println_Matriz(factura)
        Println_Matriz("".PadRight(16, " "))
        Print_Matriz(fecha.ToString("dd/MM/yyyy"))

        Print_Matriz(eRight + fecha.ToString("HH:mm"))

        Print_Matriz(eLeft + "CLIENTE:")
        PrintDashes_Matriz()
        Print_Matriz(cliente)

        If coment1 <> "" And coment2 <> "" Then
            Print_Matriz(coment1)
            Print_Matriz(coment2)
        ElseIf coment1 <> "" And coment2 = "" Then
            Print_Matriz(coment1)
        ElseIf coment1 = "" And coment2 <> "" Then
            Print_Matriz(coment2)
        End If

        Print_Matriz("Codigo: " + cod)
        If dir <> "" Then
            Print_Matriz("Dir: " & dir)
        End If
        PrintDashes_Matriz()
        Print_Matriz(vbLf)

    End Sub

    Public Sub PrintDetallesCot_Matriz(ByVal fecha As DateTime, ByVal factura As String, ByVal cliente As String,
                            ByVal cod As String, ByVal coment1 As String, ByVal coment2 As String)

        Println_Matriz(eLeft + "Nº")
        Println_Matriz("".PadRight(12 - factura.Length, " "))
        Println_Matriz(factura)
        Println_Matriz("".PadRight(16, " "))
        Print_Matriz(fecha.ToString("dd/MM/yyyy"))

        Print_Matriz(eLeft + "CLIENTE:")
        PrintDashes_Matriz()
        Print_Matriz(cliente)

        If coment1 <> "" And coment2 <> "" Then
            Print_Matriz(coment1)
            Print_Matriz(coment2)
        ElseIf coment1 <> "" And coment2 = "" Then
            Print_Matriz(coment1)
        ElseIf coment1 = "" And coment2 <> "" Then
            Print_Matriz(coment2)
        End If

        Print_Matriz("Codigo: " + cod)
        PrintDashes_Matriz()
        Print_Matriz(vbLf)

    End Sub

    Public Sub PrintBodyMatriz(ByVal DGV As DataGridView, ByVal total As String, ByVal subt As String,
                         ByVal descu As String, ByVal efectivo As String, ByVal cambio As String, ByVal p_SumaImpuestos As String)

        Dim impt As Double = Nothing
        Dim impSuma As Double = 0
        Dim printImp As String = Nothing
        Dim precioOriginal As Double = Nothing

        Try

            Dim cantpr, descrpr, subtpr, precpr, tempdesc As String

            Println_Matriz(eSmlText + "  CANT.  ")
            Println_Matriz("DESCRIPCION      ")
            Print_Matriz("SUBTOTAL C/.")

            Println_Matriz(eSmlText + "  -----  ")
            Println_Matriz("---------------  ")
            Print_Matriz("-------------")
            Print_Matriz("")

            For Each item As DataGridViewRow In DGV.Rows
                cantpr = CStr(item.Cells(2).Value)
                descrpr = CStr(item.Cells(1).Value)
                tempdesc = CStr(item.Cells(1).Value)
                subtpr = CStr(item.Cells(5).Value)
                precpr = CStr(item.Cells(3).Value)
                impt = CDbl(item.Cells(4).Value)

                If descrpr <> "" Then
                    If descrpr.Length > 18 Then
                        tempdesc = descrpr.Substring(0, 17) & "_"
                    End If
                End If

                'REVISA SI EXISTEN DATOS A IMPRIMIR
                If cantpr <> "" Then

                    If cantpr.Contains(",") Then
                        cantpr = cantpr.Replace(",", "")
                    End If

                    'CHEQUEAR SI PRODUCTOS INCLUYEN IMPUESTOS
                    If impt > 0 Then
                        'precioOriginal = (CDbl(subtpr) / ((impt / 100) + 1))
                        'impSuma += (CDbl(precioOriginal) * (impt / 100))
                        'subtpr = String.Format("{0:n}", (CDbl(subtpr) / ((impt / 100) + 1)))

                        'IMPRIME LA CANTIDAD E INCLUYE ASTERISCO A LA CANTIDAD
                        If cantpr.Length <= 7 Then
                            Println_Matriz("".PadRight(7 - cantpr.Length, " "))
                            Println_Matriz(cantpr)
                            Println_Matriz("* ")
                        Else
                            Println_Matriz("####.##")
                            Println_Matriz("* ")
                        End If

                        'IMPRIME LA DESCRIPCION
                        If descrpr.Length > 18 Then

                            'SI LA DESCRIPCION SOBREPASA LOS 18 CARACTERES IMPRIME UNA PRIMERA PARTE
                            'CON EL TOTAL DEL ARTICULO Y PASA A ESCRIBIR LA CONTINUACION EN LA SIGUIENTE LINEA

                            Println_Matriz(tempdesc)
                            Println_Matriz("".PadRight(19 - tempdesc.Length, " "))

                            'IMPRIME EL TOTAL POR ARTICULO
                            If subtpr.Length <= 12 Then
                                Println_Matriz("".PadRight(12 - subtpr.Length, " "))
                                Print_Matriz(subtpr)
                            Else
                                Print_Matriz("#.###.###.##")
                            End If

                            Println_Matriz("".PadRight(9, " "))
                            Print_Matriz(descrpr.Substring(17, descrpr.Length - 17))

                        Else

                            Println_Matriz(descrpr)
                            Println_Matriz("".PadRight(19 - descrpr.Length, " "))

                            'IMPRIME EL TOTAL POR ARTICULO
                            If subtpr.Length <= 12 Then
                                Println_Matriz("".PadRight(12 - subtpr.Length, " "))
                                Print_Matriz(subtpr)
                            Else
                                Print_Matriz("#.###.###.##")
                            End If

                        End If

                        'CALCULA LOS PRECIOS SIN IMPUESTOS
                    Else

                        'IMPRIME LA CANTIDAD DEL ARTICULO
                        If cantpr.Length <= 7 Then
                            Println_Matriz("".PadRight(7 - cantpr.Length, " "))
                            Println_Matriz(cantpr)
                            Println_Matriz("  ")
                        Else
                            Println_Matriz("####.##")
                            Println_Matriz("  ")
                        End If

                        'IMPRIME LA DESCRIPCION
                        If descrpr.Length > 18 Then

                            'SI LA DESCRIPCION SOBREPASA LOS 18 CARACTERES IMPRIME UNA PRIMERA PARTE
                            'CON EL TOTAL DEL ARTICULO Y PASA A ESCRIBIR LA CONTINUACION EN LA SIGUIENTE LINEA

                            Println_Matriz(tempdesc)
                            Println_Matriz("".PadRight(19 - tempdesc.Length, " "))

                            'IMPRIME EL TOTAL POR ARTICULO
                            If subtpr.Length <= 12 Then
                                Println_Matriz("".PadRight(12 - subtpr.Length, " "))
                                Print_Matriz(subtpr)
                            Else
                                Print_Matriz("#.###.###.##")
                            End If

                            Println_Matriz("".PadRight(9, " "))
                            Print_Matriz(descrpr.Substring(17, descrpr.Length - 17))

                        Else

                            Println_Matriz(descrpr)
                            Println_Matriz("".PadRight(19 - descrpr.Length, " "))

                            'IMPRIME EL TOTAL POR ARTICULO
                            If subtpr.Length <= 12 Then
                                Println_Matriz("".PadRight(12 - subtpr.Length, " "))
                                Print_Matriz(subtpr)
                            Else
                                Print_Matriz("#.###.###.##")
                            End If

                        End If

                    End If


                    'IMPRIME EL PRECIO INDIVIDUAL DEL ARTICULO
                    Println_Matriz("".PadRight(9, " "))
                    Println_Matriz("Precio ")
                    If precpr.Length <= 12 Then
                        Println_Matriz("".PadRight(12 - precpr.Length, " "))
                        Print_Matriz(precpr)
                    Else
                        Print_Matriz("#.###.###.##")
                    End If

                End If
            Next

            Print_Matriz(" ")
            Print_Matriz(" ")

            subt = String.Format("{0:n}", (CDbl(subt) - impSuma))
            'IMPRIME EL SUBTOTAL DE LA COMPRA
            Println_Matriz(eLeft + "".PadRight(12, " "))
            Println_Matriz(eSmlText + "SubTotal: ")
            Println_Matriz("".PadRight(18 - subt.Length, " "))
            Print_Matriz(subt)

            'IMPRIME EL IMPUESTO SI ES MAYOR A O
            If CDbl(p_SumaImpuestos) > 0 Then
                printImp = String.Format("{0:n}", CDbl(p_SumaImpuestos))
                Println_Matriz(eLeft + "".PadRight(12, " "))
                Println_Matriz(eSmlText + "IVA:  ")
                Println_Matriz("".PadRight(22 - printImp.Length, " "))
                Print_Matriz(printImp)
            End If

            'IMPRIME  EL DESCUENTO SI ES MAYOR A CERO
            If descu > 0 Then
                descu = String.Format("{0:n}", CDbl(descu))
                Println_Matriz(eLeft + "".PadRight(12, " "))
                Println_Matriz("Descuento: ")
                Println_Matriz("".PadRight(17 - descu.Length, " "))
                Print_Matriz(descu)
            End If

            Print_Matriz(" ")

            'IMPRIME EL TOTAL
            PrintDashes_Matriz()
            Println_Matriz(eLeft + "".PadRight(7, " "))
            Println_Matriz(eBigText + eNegritaOn + "TOTAL: ")
            Println_Matriz("".PadRight(16 - total.Length, " "))
            Print_Matriz(total + eNegritaOff + eSmlText)
            PrintDashes_Matriz()
            Print_Matriz(" ")

            'IMPRIME EL EFECTIVO RECIVIDO 
            Println_Matriz(eLeft + "".PadRight(12, " "))
            Println_Matriz("Efectivo: ")
            Println_Matriz("".PadRight(18 - efectivo.Length, " "))
            Print_Matriz(efectivo)

            'IMPRIME EL CAMBIO
            cambio = String.Format("{0:n}", CDbl(cambio))
            Println_Matriz(eLeft + "".PadRight(12, " "))
            Println_Matriz("Cambio: ")
            Println_Matriz("".PadRight(20 - cambio.Length, " "))
            Print_Matriz(cambio)
            Print_Matriz("")

        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        End Try

    End Sub

    Public Sub PrintBodyMatriz_wDate(ByVal DGV As DataGridView, ByVal total As String, ByVal subt As String,
                         ByVal descu As String, ByVal efectivo As String, ByVal cambio As String)

        Dim impt As Double = Nothing
        Dim impSuma As Double = 0
        Dim printImp As String = Nothing
        Dim precioOriginal As Double = Nothing
        Dim fecha As String = Nothing
        DGV.Sort(DGV.Columns(7), System.ComponentModel.ListSortDirection.Ascending)
        Try

            Dim cantpr, descrpr, subtpr, precpr, tempdesc As String

            Println_Matriz(eSmlText + "  CANT.  ")
            Println_Matriz("DESCRIPCION      ")
            Print_Matriz("SUBTOTAL C/.")

            Println_Matriz(eSmlText + "  -----  ")
            Println_Matriz("---------------  ")
            Print_Matriz("-------------")
            Print_Matriz("")

            For Each item As DataGridViewRow In DGV.Rows
                cantpr = CStr(item.Cells(2).Value)
                descrpr = CStr(item.Cells(1).Value)
                tempdesc = CStr(item.Cells(1).Value)
                subtpr = CStr(item.Cells(5).Value)
                precpr = CStr(item.Cells(3).Value)
                impt = CDbl(item.Cells(4).Value)
                fecha = CStr(item.Cells(7).Value)
                If descrpr <> "" Then
                    If descrpr.Length > 18 Then
                        tempdesc = descrpr.Substring(0, 17) & "_"
                    End If
                End If

                'REVISA SI EXISTEN DATOS A IMPRIMIR
                If cantpr <> "" Then

                    If cantpr.Contains(".") Then
                        cantpr = cantpr.Replace(".", "")
                    End If

                    'CHEQUEAR SI PRODUCTOS INCLUYEN IMPUESTOS
                    If impt > 0 Then
                        precioOriginal = (CDbl(subtpr) / ((impt / 100) + 1))
                        impSuma += (CDbl(precioOriginal) * (impt / 100))
                        subtpr = String.Format("{0:n}", (CDbl(subtpr) / ((impt / 100) + 1)))

                        'IMPRIME LA CANTIDAD E INCLUYE ASTERISCO A LA CANTIDAD
                        If cantpr.Length <= 7 Then
                            Println_Matriz("".PadRight(7 - cantpr.Length, " "))
                            Println_Matriz(cantpr)
                            Println_Matriz("* ")
                        Else
                            Println_Matriz("####.##")
                            Println_Matriz("* ")
                        End If

                        'IMPRIME LA DESCRIPCION
                        If descrpr.Length > 18 Then

                            'SI LA DESCRIPCION SOBREPASA LOS 18 CARACTERES IMPRIME UNA PRIMERA PARTE
                            'CON EL TOTAL DEL ARTICULO Y PASA A ESCRIBIR LA CONTINUACION EN LA SIGUIENTE LINEA

                            Println_Matriz(tempdesc)
                            Println_Matriz("".PadRight(19 - tempdesc.Length, " "))

                            'IMPRIME EL TOTAL POR ARTICULO
                            If subtpr.Length <= 12 Then
                                Println_Matriz("".PadRight(12 - subtpr.Length, " "))
                                Print_Matriz(subtpr)
                            Else
                                Print_Matriz("#.###.###.##")
                            End If

                            Println_Matriz("".PadRight(9, " "))
                            Print_Matriz(descrpr.Substring(17, descrpr.Length - 17))

                        Else

                            Println_Matriz(descrpr)
                            Println_Matriz("".PadRight(19 - descrpr.Length, " "))

                            'IMPRIME EL TOTAL POR ARTICULO
                            If subtpr.Length <= 12 Then
                                Println_Matriz("".PadRight(12 - subtpr.Length, " "))
                                Print_Matriz(subtpr)
                            Else
                                Print_Matriz("#.###.###.##")
                            End If

                        End If

                        'CALCULA LOS PRECIOS SIN IMPUESTOS
                    Else

                        'IMPRIME LA CANTIDAD DEL ARTICULO
                        If cantpr.Length <= 7 Then
                            Println_Matriz("".PadRight(7 - cantpr.Length, " "))
                            Println_Matriz(cantpr)
                            Println_Matriz("  ")
                        Else
                            Println_Matriz("####.##")
                            Println_Matriz("  ")
                        End If

                        'IMPRIME LA DESCRIPCION
                        If descrpr.Length > 18 Then

                            'SI LA DESCRIPCION SOBREPASA LOS 18 CARACTERES IMPRIME UNA PRIMERA PARTE
                            'CON EL TOTAL DEL ARTICULO Y PASA A ESCRIBIR LA CONTINUACION EN LA SIGUIENTE LINEA

                            Println_Matriz(tempdesc)
                            Println_Matriz("".PadRight(19 - tempdesc.Length, " "))

                            'IMPRIME EL TOTAL POR ARTICULO
                            If subtpr.Length <= 12 Then
                                Println_Matriz("".PadRight(12 - subtpr.Length, " "))
                                Print_Matriz(subtpr)
                            Else
                                Print_Matriz("#.###.###.##")
                            End If

                            Println_Matriz("".PadRight(9, " "))
                            Print_Matriz(descrpr.Substring(17, descrpr.Length - 17))

                        Else

                            Println_Matriz(descrpr)
                            Println_Matriz("".PadRight(19 - descrpr.Length, " "))

                            'IMPRIME EL TOTAL POR ARTICULO
                            If subtpr.Length <= 12 Then
                                Println_Matriz("".PadRight(12 - subtpr.Length, " "))
                                Print_Matriz(subtpr)
                            Else
                                Print_Matriz("#.###.###.##")
                            End If

                        End If

                    End If


                    'IMPRIME EL PRECIO INDIVIDUAL DEL ARTICULO
                    Println_Matriz("".PadRight(9, " "))
                    Println_Matriz("Precio ")
                    If precpr.Length <= 12 Then
                        Println_Matriz("".PadRight(12 - precpr.Length, " "))
                        Print_Matriz(precpr)
                    Else
                        Print_Matriz("#.###.###.##")
                    End If

                    'Imprime la fecha en la que fue ingresado el articulo
                    Println_Matriz("".PadRight(9, " "))
                    Print_Matriz(fecha)

                End If
            Next

            Print_Matriz(" ")
            Print_Matriz(" ")

            subt = String.Format("{0:n}", (CDbl(subt) - impSuma))
            'IMPRIME EL SUBTOTAL DE LA COMPRA
            Println_Matriz(eLeft + "".PadRight(12, " "))
            Println_Matriz(eSmlText + "SubTotal: ")
            Println_Matriz("".PadRight(18 - subt.Length, " "))
            Print_Matriz(subt)

            'IMPRIME EL IMPUESTO SI ES MAYOR A O
            If impSuma > 0 Then
                printImp = String.Format("{0:n}", CDbl(impSuma))
                Println_Matriz(eLeft + "".PadRight(12, " "))
                Println_Matriz(eSmlText + "Impt: ")
                Println_Matriz("".PadRight(22 - printImp.Length, " "))
                Print_Matriz(printImp)
            End If

            'IMPRIME  EL DESCUENTO SI ES MAYOR A CERO
            If descu > 0 Then
                descu = String.Format("{0:n}", CDbl(descu))
                Println_Matriz(eLeft + "".PadRight(12, " "))
                Println_Matriz("Descuento: ")
                Println_Matriz("".PadRight(17 - descu.Length, " "))
                Print_Matriz(descu)
            End If

            Print_Matriz(" ")

            'IMPRIME EL TOTAL
            PrintDashes_Matriz()
            Println_Matriz(eLeft + "".PadRight(7, " "))
            Println_Matriz(eBigText + eNegritaOn + "TOTAL: ")
            Println_Matriz("".PadRight(16 - total.Length, " "))
            Print_Matriz(total + eNegritaOff + eSmlText)
            PrintDashes_Matriz()
            Print_Matriz(" ")

            'IMPRIME EL EFECTIVO RECIVIDO 
            Println_Matriz(eLeft + "".PadRight(12, " "))
            Println_Matriz("Efectivo: ")
            Println_Matriz("".PadRight(18 - efectivo.Length, " "))
            Print_Matriz(efectivo)

            'IMPRIME EL CAMBIO
            cambio = String.Format("{0:n}", CDbl(cambio))
            Println_Matriz(eLeft + "".PadRight(12, " "))
            Println_Matriz("Cambio: ")
            Println_Matriz("".PadRight(20 - cambio.Length, " "))
            Print_Matriz(cambio)
            Print_Matriz("")

        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        End Try

    End Sub


    Public Sub PrintBodyCot_Matriz(ByVal DGV As DataGridView, ByVal total As String, ByVal subt As String,
                        ByVal descu As String)

        Dim impt As Double = Nothing
        Dim impSuma As Double = Nothing
        Dim printImp As String = Nothing
        Dim precioOriginal As Double = Nothing

        Try

            Dim cantpr, descrpr, subtpr, precpr, tempdesc As String

            Println_Matriz(eSmlText + "  CANT.  ")
            Println_Matriz("DESCRIPCION      ")
            Print_Matriz("SUBTOTAL C/.")

            Println_Matriz(eSmlText + "  -----  ")
            Println_Matriz("---------------  ")
            Print_Matriz("-------------")
            Print_Matriz("")

            For Each item As DataGridViewRow In DGV.Rows
                cantpr = CStr(item.Cells(2).Value)
                descrpr = CStr(item.Cells(1).Value)
                tempdesc = CStr(item.Cells(1).Value)
                subtpr = CStr(item.Cells(5).Value)
                precpr = CStr(item.Cells(3).Value)
                impt = CDbl(item.Cells(4).Value)

                If descrpr <> "" Then
                    If descrpr.Length > 18 Then
                        tempdesc = descrpr.Substring(0, 17) & "_"
                    End If
                End If

                'REVISA SI EXISTEN DATOS A IMPRIMIR
                If cantpr <> "" Then

                    If cantpr.Contains(".") Then
                        cantpr = cantpr.Replace(".", "")
                    End If

                    'CHEQUEAR SI PRODUCTOS INCLUYEN IMPUESTOS
                    If impt > 0 Then
                        precioOriginal = (CDbl(subtpr) / ((impt / 100) + 1))
                        impSuma += (CDbl(precioOriginal) * (impt / 100))
                        subtpr = String.Format("{0:n}", (CDbl(subtpr) / ((impt / 100) + 1)))

                        'IMPRIME LA CANTIDAD E INCLUYE ASTERISCO A LA CANTIDAD
                        If cantpr.Length <= 7 Then
                            Println_Matriz("".PadRight(7 - cantpr.Length, " "))
                            Println_Matriz(cantpr)
                            Println_Matriz("* ")
                        Else
                            Println_Matriz("####.##")
                            Println_Matriz("* ")
                        End If

                        'IMPRIME LA DESCRIPCION
                        If descrpr.Length > 18 Then

                            'SI LA DESCRIPCION SOBREPASA LOS 18 CARACTERES IMPRIME UNA PRIMERA PARTE
                            'CON EL TOTAL DEL ARTICULO Y PASA A ESCRIBIR LA CONTINUACION EN LA SIGUIENTE LINEA

                            Println_Matriz(tempdesc)
                            Println_Matriz("".PadRight(19 - tempdesc.Length, " "))

                            'IMPRIME EL TOTAL POR ARTICULO
                            If subtpr.Length <= 12 Then
                                Println_Matriz("".PadRight(12 - subtpr.Length, " "))
                                Print_Matriz(subtpr)
                            Else
                                Print_Matriz("#.###.###.##")
                            End If

                            Println_Matriz("".PadRight(9, " "))
                            Print_Matriz(descrpr.Substring(17, descrpr.Length - 17))

                        Else

                            Println_Matriz(descrpr)
                            Println_Matriz("".PadRight(19 - descrpr.Length, " "))

                            'IMPRIME EL TOTAL POR ARTICULO
                            If subtpr.Length <= 12 Then
                                Println_Matriz("".PadRight(12 - subtpr.Length, " "))
                                Print_Matriz(subtpr)
                            Else
                                Print_Matriz("#.###.###.##")
                            End If

                        End If

                        'CALCULA LOS PRECIOS SIN IMPUESTOS
                    Else

                        'IMPRIME LA CANTIDAD DEL ARTICULO
                        If cantpr.Length <= 7 Then
                            Println_Matriz("".PadRight(7 - cantpr.Length, " "))
                            Println_Matriz(cantpr)
                            Println_Matriz("  ")
                        Else
                            Println_Matriz("####.##")
                            Println_Matriz("  ")
                        End If

                        'IMPRIME LA DESCRIPCION
                        If descrpr.Length > 18 Then

                            'SI LA DESCRIPCION SOBREPASA LOS 18 CARACTERES IMPRIME UNA PRIMERA PARTE
                            'CON EL TOTAL DEL ARTICULO Y PASA A ESCRIBIR LA CONTINUACION EN LA SIGUIENTE LINEA

                            Println_Matriz(tempdesc)
                            Println_Matriz("".PadRight(19 - tempdesc.Length, " "))

                            'IMPRIME EL TOTAL POR ARTICULO
                            If subtpr.Length <= 12 Then
                                Println_Matriz("".PadRight(12 - subtpr.Length, " "))
                                Print_Matriz(subtpr)
                            Else
                                Print_Matriz("#.###.###.##")
                            End If

                            Println_Matriz("".PadRight(9, " "))
                            Print_Matriz(descrpr.Substring(17, descrpr.Length - 17))

                        Else

                            Println_Matriz(descrpr)
                            Println_Matriz("".PadRight(19 - descrpr.Length, " "))

                            'IMPRIME EL TOTAL POR ARTICULO
                            If subtpr.Length <= 12 Then
                                Println_Matriz("".PadRight(12 - subtpr.Length, " "))
                                Print_Matriz(subtpr)
                            Else
                                Print_Matriz("#.###.###.##")
                            End If

                        End If

                    End If


                    'IMPRIME EL PRECIO INDIVIDUAL DEL ARTICULO
                    Println_Matriz("".PadRight(9, " "))
                    Println_Matriz("Precio ")
                    If precpr.Length <= 12 Then
                        Println_Matriz("".PadRight(12 - precpr.Length, " "))
                        Print_Matriz(precpr)
                    Else
                        Print_Matriz("#.###.###.##")
                    End If

                End If
            Next

            Print_Matriz(" ")
            Print_Matriz(" ")

            subt = String.Format("{0:n}", (CDbl(subt) - impSuma))
            'IMPRIME EL SUBTOTAL DE LA COMPRA
            Println_Matriz(eLeft + "".PadRight(12, " "))
            Println_Matriz(eSmlText + "SubTotal: ")
            Println_Matriz("".PadRight(18 - subt.Length, " "))
            Print_Matriz(subt)

            'IMPRIME EL IMPUESTO SI ES MAYOR A O
            If impSuma > 0 Then
                printImp = String.Format("{0:n}", CDbl(impSuma))
                Println_Matriz(eLeft + "".PadRight(12, " "))
                Println_Matriz(eSmlText + "Impt: ")
                Println_Matriz("".PadRight(22 - printImp.Length, " "))
                Print_Matriz(printImp)
            End If

            'IMPRIME  EL DESCUENTO SI ES MAYOR A CERO
            If descu > 0 Then
                descu = String.Format("{0:n}", CDbl(descu))
                Println_Matriz(eLeft + "".PadRight(12, " "))
                Println_Matriz("Descuento: ")
                Println_Matriz("".PadRight(17 - descu.Length, " "))
                Print_Matriz(descu)
            End If

            Print_Matriz(eRight + "----------------------------")
            Println_Matriz(eLeft + "".PadRight(12, " "))

            'IMPRIME EL TOTAL
            Println_Matriz(eBigText + "TOTAL: ")
            Println_Matriz("".PadRight(16 - total.Length, " "))
            Print_Matriz(total + eSmlText)
            Print_Matriz(" ")
            Print_Matriz(" ")

            Print_Matriz(eCentre + eNegritaOn + "* I.V.I. *")
            Print_Matriz("* PRECIOS SUJETOS A CAMBIOS")
            Print_Matriz("SIN PREVIO AVISO *")
            Print_Matriz(" ")
            Print_Matriz(" ")
            Print_Matriz(vbLf + vbLf + vbLf + vbLf + vbLf + vbLf + vbLf)


        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        End Try
    End Sub

    Public Sub PrintBody_rapidoMatriz(ByVal total As String, ByVal Det_art As String)
        Try

            'VARIABLES
            Dim cantpr, descrpr, cambio As String

            Println_Matriz(eSmlText + "  CANT.  ")
            Println_Matriz("DESCRIPCION      ")
            Print_Matriz("TOTAL C/.")

            Println_Matriz(eSmlText + "  -----  ")
            Println_Matriz("---------------  ")
            Print_Matriz("-------------")
            Print_Matriz("")

            'DESCRIPCION RAPIDA DEL ARTICULO QUE APARECERA EN LA FACTURA
            cantpr = "1"
            descrpr = "BOLSA"
            cambio = "0,00"
            total = String.Format("{0:n}", CDbl(total))

            If cantpr <> "" Then
                If cantpr.Length <= 7 Then
                    Println_Matriz("".PadRight(7 - cantpr.Length, " "))
                    Println_Matriz(cantpr)
                    Println_Matriz(" ")
                Else
                    Println_Matriz("####.##")
                    Println_Matriz(" ")
                End If
                If descrpr.Length <= 19 Then
                    Println_Matriz(descrpr)
                    Println_Matriz("".PadRight(20 - descrpr.Length, " "))
                End If
                If total.Length <= 12 Then
                    Println_Matriz("".PadRight(12 - total.Length, " "))
                    Print_Matriz(total)
                Else
                    Print_Matriz("#.###.###.##")
                End If

                Println_Matriz("".PadRight(9, " "))
                Println_Matriz("Precio: ")
                If total.Length <= 12 Then
                    Println_Matriz("".PadRight(12 - total.Length, " "))
                    Print_Matriz(total)
                Else
                    Print_Matriz("#.###.###.##")
                End If

            End If

            Print_Matriz(eClear)
            Print_Matriz(" ")
            Print_Matriz(" ")

            Println_Matriz(eLeft + "".PadRight(12, " "))
            Println_Matriz(eSmlText + "SubTotal: ")
            Println_Matriz("".PadRight(18 - total.Length, " "))
            Print_Matriz(total)

            Print_Matriz(eRight + "----------------------------")
            Println_Matriz(eLeft + "".PadRight(12, " "))

            Println_Matriz(eBigText + "TOTAL: ")
            Println_Matriz("".PadRight(16 - total.Length, " "))
            Print_Matriz(total + eSmlText)
            Print_Matriz(vbLf)

            Println_Matriz(eLeft + "".PadRight(12, " "))
            Println_Matriz("Efectivo: ")
            Println_Matriz("".PadRight(18 - total.Length, " "))
            Print_Matriz(total)

            Println_Matriz(eLeft + "".PadRight(12, " "))
            Println_Matriz("Cambio: ")
            Println_Matriz("".PadRight(20 - cambio.Length, " "))
            Print_Matriz(cambio)
            Print_Matriz("")
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        End Try
    End Sub

    Public Sub PrintFooterMatriz(ByVal p_pie_de_factura)
        Dim leyenda = p_pie_de_factura
        Print_Matriz(eLeft + leyenda)
        Print_Matriz(" ")
        Print_Matriz(eClear)
        Print_Matriz(eCentre + "I.V.I")
        Print_Matriz(" ")
        Print_Matriz(" ")
        Print_Matriz(eClear)

        Print_Matriz(eCentre + "Gracias Por Su Compra!")
        Print_Matriz(" ")
        Print_Matriz(" ")

        Print_Matriz(vbLf + vbLf + vbLf + vbLf + vbLf + vbLf + vbLf + eCut + eDrawer)

    End Sub

    Public Sub Print_Matriz(Line As String)
        prn_matriz.SendStringToPrinter(PrinterName, Line + vbLf)
    End Sub

    Public Sub Println_Matriz(Line As String)
        prn_matriz.SendStringToPrinter(PrinterName, Line)
    End Sub
    Public Sub PrintDashes_Matriz()
        Print_Matriz(eLeft + eSmlText + "-".PadRight(40, "-"))
    End Sub

    Public Sub EndPrintMatriz()
        prn_matriz.ClosePrint()
    End Sub

    Public Sub abrir_caja_matriz()
        Print_Matriz(eDrawer)
    End Sub

End Module
