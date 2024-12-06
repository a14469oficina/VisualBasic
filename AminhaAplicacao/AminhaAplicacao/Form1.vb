Public Class Form1
    Public frm2 As FormCalculador
    Public frm3 As FormIMC
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If IsNothing(frm2) = False Then

            'o formulário esta ativo

            MsgBox("O formulário já esta aberto !", MsgBoxStyle.Exclamation)

        Else

            frm2 = New FormCalculador()

            frm2.Show()

            Me.Hide()   ' esconde-me .. também podia ser apenas Hide() sem o Me.

        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If IsNothing(frm3) = False Then

            'o formulário esta ativo

            MsgBox("O formulário já esta aberto !", MsgBoxStyle.Exclamation)

        Else

            frm3 = New FormIMC()

            frm3.Show()

            Me.Hide()   ' esconde-me .. também podia ser apenas Hide() sem o Me.

        End If
    End Sub
End Class
