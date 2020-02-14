Public Class RP_Fecha
    Public inicio As Date
    Public fin As Date
      Private Sub RP_Fecha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Dim impReporte As New CR_FECHAS

            impReporte.SetParameterValue("p_fechain", inicio)
            impReporte.SetParameterValue("p_fechaout", fin)

            CrystalReportViewer1.ReportSource = impReporte
        Catch ex As Exception
            MsgBox(ex.ToString)
            Logger.e("Error con excepción", ex, New StackFrame(True))
        End Try



    End Sub
End Class