Public Class Fr_motivo_reimpresion

    Dim motivo As String = Nothing
    Private Sub Fr_motivo_reimpresion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_otro.ReadOnly = True
        rbtn_copia.Checked = True
        motivo = "Copia para el cliente"
    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click

        If txt_otro.ReadOnly Then
            motivo_impresion = motivo
            Me.Close()
        ElseIf txt_otro.ReadOnly = False And txt_otro.Text.Trim <> "" Then
            motivo = "Otro, " & txt_otro.Text
            motivo_impresion = motivo
            Me.Close()
        Else
            MsgBox("Especifique el motivo")
            txt_otro.Select()
        End If

    End Sub

    Private Sub rbtn_copia_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_copia.CheckedChanged
        motivo = "Copia para el cliente"
    End Sub

    Private Sub rbtn_original_extraviada_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_original_extraviada.CheckedChanged
        motivo = "Original Extraviada"
    End Sub

    Private Sub rbtn_modifficacion_producto_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_modifficacion_producto.CheckedChanged
        motivo = "Modificación de factura"
    End Sub

    Private Sub rbtn_cambio_papel_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_cambio_papel.CheckedChanged
        motivo = "Cambio de papel"
    End Sub

    Private Sub btn_otro_CheckedChanged(sender As Object, e As EventArgs) Handles btn_otro.CheckedChanged
        If btn_otro.Checked Then
            txt_otro.ReadOnly = False
        Else
            txt_otro.ReadOnly = True
            txt_otro.Select()
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        motivo = "Impresion cancelada"
        motivo_impresion = motivo
        Me.Close()
    End Sub

    Private Sub Fr_motivo_reimpresion_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Me.PreviewKeyDown

        If e.KeyValue = Keys.D1 Then
            rbtn_copia.Checked = True
            btn_aceptar_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.D2 Then
            rbtn_modifficacion_producto.Checked = True
            btn_aceptar_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.D3 Then
            rbtn_original_extraviada.Checked = True
            btn_aceptar_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.D4 Then
            rbtn_cambio_papel.Checked = True
            btn_aceptar_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.D5 Then
            btn_otro.Checked = True
        End If

    End Sub

    Private Sub Fr_motivo_reimpresion_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyValue = Keys.D1 Then
            rbtn_copia.Checked = True
            btn_aceptar_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.D2 Then
            rbtn_modifficacion_producto.Checked = True
            btn_aceptar_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.D3 Then
            rbtn_original_extraviada.Checked = True
            btn_aceptar_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.D4 Then
            rbtn_cambio_papel.Checked = True
            btn_aceptar_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.D5 Then
            btn_otro.Checked = True
        End If

    End Sub

    Private Sub rbtn_copia_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles rbtn_copia.PreviewKeyDown

        If e.KeyValue = Keys.D1 Then
            rbtn_copia.Checked = True
            btn_aceptar_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.D2 Then
            rbtn_modifficacion_producto.Checked = True
            btn_aceptar_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.D3 Then
            rbtn_original_extraviada.Checked = True
            btn_aceptar_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.D4 Then
            rbtn_cambio_papel.Checked = True
            btn_aceptar_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.D5 Then
            btn_otro.Checked = True
        End If

    End Sub

    Private Sub rbtn_modifficacion_producto_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles rbtn_modifficacion_producto.PreviewKeyDown

        If e.KeyValue = Keys.D1 Then
            rbtn_copia.Checked = True
            btn_aceptar_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.D2 Then
            rbtn_modifficacion_producto.Checked = True
            btn_aceptar_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.D3 Then
            rbtn_original_extraviada.Checked = True
            btn_aceptar_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.D4 Then
            rbtn_cambio_papel.Checked = True
            btn_aceptar_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.D5 Then
            btn_otro.Checked = True
        End If

    End Sub

    Private Sub rbtn_original_extraviada_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles rbtn_original_extraviada.PreviewKeyDown

        If e.KeyValue = Keys.D1 Then
            rbtn_copia.Checked = True
            btn_aceptar_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.D2 Then
            rbtn_modifficacion_producto.Checked = True
            btn_aceptar_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.D3 Then
            rbtn_original_extraviada.Checked = True
            btn_aceptar_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.D4 Then
            rbtn_cambio_papel.Checked = True
            btn_aceptar_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.D5 Then
            btn_otro.Checked = True
        End If

    End Sub

    Private Sub rbtn_cambio_papel_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles rbtn_cambio_papel.PreviewKeyDown

        If e.KeyValue = Keys.D1 Then
            rbtn_copia.Checked = True
            btn_aceptar_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.D2 Then
            rbtn_modifficacion_producto.Checked = True
            btn_aceptar_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.D3 Then
            rbtn_original_extraviada.Checked = True
            btn_aceptar_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.D4 Then
            rbtn_cambio_papel.Checked = True
            btn_aceptar_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.D5 Then
            btn_otro.Checked = True
        End If

    End Sub

    Private Sub btn_otro_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles btn_otro.PreviewKeyDown

        If e.KeyValue = Keys.D1 Then
            rbtn_copia.Checked = True
            btn_aceptar_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.D2 Then
            rbtn_modifficacion_producto.Checked = True
            btn_aceptar_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.D3 Then
            rbtn_original_extraviada.Checked = True
            btn_aceptar_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.D4 Then
            rbtn_cambio_papel.Checked = True
            btn_aceptar_Click(sender, New System.EventArgs())
        ElseIf e.KeyValue = Keys.D5 Then
            btn_otro.Checked = True
        End If

    End Sub
End Class