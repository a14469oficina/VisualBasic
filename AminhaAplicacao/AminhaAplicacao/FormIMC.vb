Public Class FormIMC
    Private Sub Button19_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Form1.frm3 = Nothing

        Form1.Show()

        Me.Close()   ' este comando faz com que o Form2 se feche mas o Form1 não sabe que este foi fechado e se não o informarmos vai dar a mensagem que já está aberto

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub botCalcularIMC_Click(sender As Object, e As EventArgs) Handles botCalcularIMC.Click
        Dim val1, val2 As Double
        val1 = textPeso.Text
        val2 = textAltura.Text
        TextIMC.Text = val1 / ((val2 / 100) * (val2 / 100))
    End Sub
End Class