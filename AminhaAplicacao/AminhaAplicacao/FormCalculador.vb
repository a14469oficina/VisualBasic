Public Class FormCalculador
    Private Sub ButtonFechar_Click(sender As Object, e As EventArgs) Handles botFechar.Click

        Form1.frm2 = Nothing

        Form1.Show()

        Me.Close()   ' este comando faz com que o Form2 se feche mas o Form1 não sabe que este foi fechado e se não o informarmos vai dar a mensagem que já está aberto

    End Sub

    Private Sub FormCalculador_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextFinal.TextChanged

    End Sub
    Public Sub insireNum(numero As String)
        If (TextFinal.Text = "0") Then
            TextFinal.Text = numero
        Else
            TextFinal.Text = TextFinal.Text & numero
        End If
    End Sub
    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        insireNum(0)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        insireNum(1)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        insireNum(2)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        insireNum(3)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        insireNum(4)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        insireNum(5)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        insireNum(6)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        insireNum(7)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        insireNum(8)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        insireNum(9)
    End Sub

    Private Sub somar_Click(sender As Object, e As EventArgs) Handles botSomar.Click

    End Sub

    Private Sub botInverterSinal_Click(sender As Object, e As EventArgs) Handles botInverterSinal.Click

    End Sub

    Private Sub botLimpar_Click(sender As Object, e As EventArgs) Handles botLimpar.Click
        TextFinal.Text = "0"
    End Sub
End Class