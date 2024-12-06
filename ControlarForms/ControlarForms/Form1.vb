Public Class Form1
    Public frm2 As Form2
    Public frm3 As Form3
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If IsNothing(frm2) = False Then

            'o formulário esta ativo

            MsgBox("O formulário já esta aberto !", MsgBoxStyle.Exclamation)

        Else

            frm2 = New Form2()

            frm2.Show()

            Me.Hide()   ' esconde-me .. também podia ser apenas Hide() sem o Me.

        End If


    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If IsNothing(frm3) = False Then

            'o formulário esta ativo

            MsgBox("O formulário já esta aberto !", MsgBoxStyle.Exclamation)

        Else

            frm3 = New Form3()

            frm3.Show()

            Me.Hide()   ' esconde-me .. também podia ser apenas Hide() sem o Me.

        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'Close()  ' Close ou Me.Close  fecha o Form1 que é o nosso 'Main' 

        Application.Exit() ' este fecha a App Toda

    End Sub

End Class
