Public Class FrTiquete

    Dim _TipoImpresaTermica As Boolean = False
    Dim _TiqueteBn As Boolean = False
    Dim _TiqueteFacturaElectronica As Boolean = False

    Private _ImprimeLinea As Integer = 0

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Try

            If txtTiquete.Lines().Length > 10 Then
                ComprobarTiquete()
                If _TiqueteFacturaElectronica Then
                    ImprimirFacturaElectronica()
                ElseIf _TiqueteBn Then
                    ImprimirBnServicios()
                Else
                    MsgBox("Formato No Reconocido")
                End If
            Else
                txtTiquete.Clear()
            End If
        Catch ex As Exception
            MsgBox("Formato No Reconocido")
            Logger.e("Error con excepción", ex, New StackFrame(True), txtTiquete.Text)
        End Try
    End Sub

    Private Sub FrTiquete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SEL_IMPRESORA(PrinterNameTermica, PrinterNameMatriz, _TipoImpresaTermica, _ImprimeLinea)
    End Sub

    Private Sub ImprimirBnServicios()

        Dim tempArray() As String
        Dim _ListaLineas As New List(Of String)
        Dim _GuardarLineas As Boolean = False
        tempArray = txtTiquete.Lines

        For i = 0 To tempArray.Length - 1

            If txtTiquete.Lines(i).Contains("BANCO NACIONAL") Then
                _GuardarLineas = True
            ElseIf txtTiquete.Lines(i).Contains("BN-SERVICIOS") Then
                _GuardarLineas = False
            End If
            If _GuardarLineas Then
                _ListaLineas.Add(tempArray(i))
            End If

        Next
        tempArray = _ListaLineas.ToArray
        txtTiquete.Lines = tempArray
        FormateoBnServicios()
        If _TipoImpresaTermica Then
            StartPrintTiquete(_ImprimeLinea)
            If prn.PrinterIsOpen = True Then
                PrintTiqueteBn(txtTiquete)
                PrintFooterBn()
                EndPrint()
            End If
        Else
            StartPrintTiqueteMatriz(_ImprimeLinea)
            If prn_matriz.PrinterIsOpen = True Then
                PrintTiqueteMatrizBn(txtTiquete)
                PrintFooterMatrizBn()
                EndPrintMatriz()
            End If

        End If
        txtTiquete.Clear()

    End Sub

    Private Sub ImprimirFacturaElectronica()

        Dim tempArray() As String
        Dim _ListaLineas As New List(Of String)
        Dim _GuardarLineas As Boolean = False
        tempArray = txtTiquete.Lines

        For i = 0 To tempArray.Length - 1

            If txtTiquete.Lines(i).Contains("VERDESUR") Then
                _GuardarLineas = True
            ElseIf txtTiquete.Lines(i).Contains("Factura506 ") Then
                _GuardarLineas = False
            End If
            If _GuardarLineas Then
                _ListaLineas.Add(tempArray(i))
            End If

        Next
        tempArray = _ListaLineas.ToArray
        txtTiquete.Lines = tempArray

        If _TipoImpresaTermica Then
            StartPrintTiquete(_ImprimeLinea)
            If prn.PrinterIsOpen = True Then
                PrintTiqueteElectonico(txtTiquete)
                PrintFooterTiquete()
                EndPrint()
            End If
        Else
            StartPrintTiqueteMatriz(_ImprimeLinea)
            If prn_matriz.PrinterIsOpen = True Then
                PrintTiqueteElectonicoMatriz(txtTiquete)
                PrintFooterTiqueteMatriz()
                EndPrintMatriz()
            End If
        End If
        txtTiquete.Clear()

    End Sub

    Private Sub FormateoBnServicios()

        Dim tempArray() As String
        Dim _FinalArray() As String
        Dim _ListaLineas As New List(Of String)()
        Try
            tempArray = txtTiquete.Lines
            For i = 0 To tempArray.Count - 1
                If tempArray(i).Length > 0 Then
                    If tempArray(i).Substring(tempArray(i).Length - 1, 1) = ":" Then
                        _ListaLineas.Add(tempArray(i) + " " + tempArray(i + 1))
                        i += 1
                    ElseIf tempArray(i).Contains("_____________________") And i < (tempArray.Length - 1) Then
                        If tempArray(i + 1) = "_______________________________" Then
                            i += 1
                        Else
                            _ListaLineas.Add(tempArray(i).ToString)
                        End If
                    Else
                        _ListaLineas.Add(tempArray(i).ToString)
                    End If

                End If
            Next
            _FinalArray = _ListaLineas.ToArray()
            txtTiquete.Lines = _FinalArray
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True), txtTiquete.Text)
        End Try
    End Sub

    Private Sub ComprobarTiquete()

        _TiqueteBn = False
        _TiqueteFacturaElectronica = True

        Dim tempArray() As String
        tempArray = txtTiquete.Lines
        For i = 0 To tempArray.Count - 1

            tempArray(i) = tempArray(i).Replace("á", "a")
            tempArray(i) = tempArray(i).Replace("é", "e")
            tempArray(i) = tempArray(i).Replace("í", "i")
            tempArray(i) = tempArray(i).Replace("ó", "o")
            tempArray(i) = tempArray(i).Replace("ú", "u")
            'If tempArray(i).Contains("BN-SERVICIOS") Then
            '    _TiqueteBn = True
            'ElseIf tempArray(i).Contains("GERARDO ALBERTO MORA SOLANO") Then
            '    _TiqueteFacturaElectronica = True
            'End If
        Next
        txtTiquete.Lines = tempArray
    End Sub
End Class