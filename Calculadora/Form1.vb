Public Class Form1

    ' Calculos
    Dim operacao As String
    Dim valorResultado As Nullable(Of Double) = Nothing 'Iniciando com valor nulo
    Dim valor2 As Nullable(Of Double) = Nothing 'Iniciando com valor nulo
    Dim sePresionarOperador As Boolean

    ' Validar as operacoes

    Private Sub ValidarOperacao()
        sePresionarOperador = True
        valor2 = Val(TextBoxResultado.Text.Replace(",", ".")) 'Convertendo para um numero.
        If valorResultado IsNot Nothing Then
            Select Case operacao
                Case "+"
                    valorResultado = valorResultado + valor2
                Case "-"
                    valorResultado -= valor2
                Case "*"
                    valorResultado *= valor2
                Case "/"
                    If valor2 > 0 Then
                        valorResultado /= valor2
                    Else
                        TextBoxResultado.Text = "Não é possível dividir por zero"
                        Return
                    End If
                Case "%"
                    valorResultado *= valor2 / 100
            End Select
            TextBoxResultado.Text = valorResultado
        Else
            valorResultado = valor2

        End If

    End Sub

    Private Sub Calcular()
        If sePresionarOperador = True Then
            TextBoxResultado.Text = ""
            sePresionarOperador = False
        ElseIf TextBoxResultado.Text = "0" Then
            TextBoxResultado.Text = ""
        End If
    End Sub




    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        Calcular()
        TextBoxResultado.Text &= "0"
        TextResumo.Text &= "0"
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Calcular()
        TextBoxResultado.Text &= "1"

        TextResumo.Text &= "1"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Calcular()
        TextBoxResultado.Text &= "2"

        TextResumo.Text &= "2"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Calcular()
        TextBoxResultado.Text &= "3"
        TextResumo.Text &= "3"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Calcular()
        TextBoxResultado.Text &= "4"
        TextResumo.Text &= "4"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Calcular()
        TextBoxResultado.Text &= "5"
        TextResumo.Text &= "5"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Calcular()
        TextBoxResultado.Text &= "6"
        TextResumo.Text &= "6"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Calcular()
        TextBoxResultado.Text &= "7"
        TextResumo.Text &= "7"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Calcular()
        TextBoxResultado.Text &= "8"
        TextResumo.Text &= "8"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Calcular()
        TextBoxResultado.Text &= "9"
        TextResumo.Text &= "9"
    End Sub

    Private Sub ButtonPonto_Click(sender As Object, e As EventArgs) Handles ButtonPonto.Click
        Calcular()

        If Not TextBoxResultado.Text.Contains(",") Then
            TextBoxResultado.Text &= ","
            TextResumo.Text &= ","
        End If

    End Sub

    Private Sub ButtonSoma_Click(sender As Object, e As EventArgs) Handles ButtonSoma.Click
        ValidarOperacao()
        operacao = "+"
        TextResumo.Text &= "+"

    End Sub

    Private Sub ButtonSubtracao_Click(sender As Object, e As EventArgs) Handles ButtonSubtracao.Click
        ValidarOperacao()
        operacao = "-"
        TextResumo.Text &= "-"
    End Sub

    Private Sub ButtonMultiplicacao_Click(sender As Object, e As EventArgs) Handles ButtonMultiplicacao.Click
        ValidarOperacao()
        operacao = "*"
        TextResumo.Text &= "*"

    End Sub

    Private Sub ButtonDivisao_Click(sender As Object, e As EventArgs) Handles ButtonDivisao.Click
        ValidarOperacao()
        operacao = "/"
        TextResumo.Text &= "/"

    End Sub

    Private Sub ButtonPorcentagem_Click(sender As Object, e As EventArgs) Handles ButtonPorcentagem.Click
        ValidarOperacao()
        operacao = "%"
        TextResumo.Text &= "%"

    End Sub

    Private Sub ButtonCalcular_Click(sender As Object, e As EventArgs) Handles ButtonCalcular.Click
        ValidarOperacao()
        operacao = ""
    End Sub

    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        TextBoxResultado.Text = "0"
        valor2 = Nothing
        valorResultado = Nothing
        TextResumo.Text = ""
    End Sub

    Private Sub TextBoxResultado_TextChanged(sender As Object, e As EventArgs) Handles TextBoxResultado.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextResumo.TextChanged
        ' Aqui é onde vamos por o resumo das operacoes.
    End Sub
End Class
