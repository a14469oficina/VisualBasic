Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim val1, val2 As Integer
        val1 = valor1.Text
        val2 = valor2.Text
        resultado.Text = val1 + val2
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Form1.frm3 = Nothing

        Form1.Show()

        Me.Close()   ' este comando faz com que o Form2 se feche mas o Form1 não sabe que este foi fechado e se não o informarmos vai dar a mensagem que já está aberto

    End Sub
End Class