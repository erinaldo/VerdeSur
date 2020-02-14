Public Class Fr_Vendedores

    Public Sub limpiar()
        Txt_Codigo.Clear()
        Txt_Nombre.Clear()
        Txt_Codigo.Focus()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Salir.Click
        Fr_Inicio.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btn_Agregar.Click
        Dim respuesta As String = Nothing
        If Txt_Codigo.Text = "" Then
            MsgBox("INGRESE UN CODIGO")
            Txt_Codigo.Focus()
        ElseIf (Txt_Nombre.Text = "") Then
            MsgBox("INGRESE UN NOMBRE")
            Txt_Nombre.Focus()
        Else
            INS_VENDEDOR(Txt_Codigo.Text, Txt_Nombre.Text, respuesta)
            MsgBox(respuesta)
            limpiar()
        End If
       
    End Sub

    Private Sub Vendedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SEL_VENDEDORES_TODOS(Lv_Vendedores)
    End Sub

    Private Sub txtCodigo_KeyUp(sender As Object, e As KeyEventArgs) Handles Txt_Codigo.KeyUp
        Txt_Nombre.Clear()
        SEL_VENDEDOR(Txt_Codigo.Text, Txt_Nombre.Text)
    End Sub


    Private Sub txtCodigo_Leave(sender As Object, e As EventArgs) Handles Txt_Codigo.Leave
        If Txt_Nombre.Text <> "" And Txt_Codigo.Text <> "" Then
            MsgBox("El cliente ya existe")
            Txt_Codigo.Clear()
            Txt_Codigo.Focus()
        End If
    End Sub
End Class