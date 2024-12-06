Public Class Form2
    Private gender As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Form1.frm2 = Nothing

        Form1.Show()

        Me.Close()   ' este comando faz com que o Form2 se feche mas o Form1 não sabe que este foi fechado e se não o informarmos vai dar a mensagem que já está aberto

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles calcular.Click
        Dim val1, val2 As Double
        val1 = peso.Text
        val2 = altura.Text
        resultado.Text = val1 / ((val2 / 100) * (val2 / 100))
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        RadioButton1.BackColor = Color.Aquamarine
        RadioButton2.BackColor = Color.DeepPink
        gender = "Homem"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        RadioButton1.BackColor = Color.DeepPink
        RadioButton2.BackColor = Color.Aquamarine
        gender = "Mulher"
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub mostraResultado(valorXX As Double)
        If (valorXX < 18.5) Then
            resultadomsg.Text = "Magreza : Deves comer a comida da tua mae toda"
        ElseIf (valorXX >= 18.5 And valorXX < 24.9) Then
            resultadomsg.Text = "Normal : Éstas no peso certo"
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles resultadomsg.TextChanged

    End Sub
End Class