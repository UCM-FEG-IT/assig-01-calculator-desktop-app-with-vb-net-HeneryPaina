Public Class frmCalculadora
    Private resultado As Double = 0
    Private numero As Double = 0
    Private operador As String = String.Empty
    Private strNumero As String = "1"
    Private Limpar As Boolean = True
    Private Ponto As Boolean = False
    Private blnoperador As Boolean = False

    Private Sub btnDividir_Click(sender As Object, e As EventArgs) Handles btnDividir.Click

        If strNumero = "1" And blnoperador = True Then
            resultado = Convert.ToDouble(txtResultado.Text)
        ElseIf strNumero = "2" And blnoperador = True Then
            resultado = Convert.ToDouble(txtResultado.Text)
            resultado = resultado / numero
            txtResultado.Text = numero
            numero = 0
        End If
        operador = "/"
        Limpar = True
        Ponto = False
        blnoperador = False
    End Sub
    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click, btnIgual.Click
        numero = 0
        resultado = 0
        operador = String.Empty
        txtResultado.Text = ""
        Limpar = True
    End Sub
    Private Sub btnMultiplicar_Click(sender As Object, e As EventArgs) Handles btnMultiplicar.Click
        If strNumero = "1" And blnoperador = True Then
            resultado = Convert.ToDouble(txtResultado.Text)

        ElseIf strNumero = "2" And blnoperador = True Then
            resultado = Convert.ToDouble(txtResultado.Text)
            resultado = resultado * numero
            txtResultado.Text = numero
            numero = 0
        End If
        operador = "*"
        Limpar = True
        Ponto = False
        blnoperador = False
    End Sub
    Private Sub btnSubtrair_Click(sender As Object, e As EventArgs) Handles btnSubtrair.Click
        If strNumero = "1" And blnoperador = True Then


            resultado = Convert.ToDouble(txtResultado.Text)

        ElseIf strNumero = "2" And blnoperador = True Then
            resultado = Convert.ToDouble(txtResultado.Text)
            resultado = resultado - numero
            txtResultado.Text = numero
            numero = 0
        End If
        operador = "-"
        Limpar = True
        Ponto = False
        blnoperador = False
    End Sub
    Private Sub btnSomar_Click(sender As Object, e As EventArgs) Handles btnSomar.Click
        If strNumero = "1" And blnoperador = True Then
            resultado = Convert.ToDouble(txtResultado.Text)

        ElseIf strNumero = "2" And blnoperador = True Then
            resultado = Convert.ToDouble(txtResultado.Text)
            resultado = resultado + numero
            txtResultado.Text = numero
            numero = 0
        End If
        operador = "+"
        Limpar = True
        Ponto = False
        blnoperador = False
    End Sub
    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        If Limpar Then
            txtResultado.Text = "0"
            Limpar = False
        Else
            txtResultado.Text = txtResultado.Text & "0"
        End If
        blnoperador = True
    End Sub
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If Limpar Then
            txtResultado.Text = "1"
            Limpar = False
        Else
            txtResultado.Text = txtResultado.Text & "1"
        End If
        blnoperador = True
    End Sub
    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If Limpar Then
            txtResultado.Text = "2"
            Limpar = False
        Else
            txtResultado.Text = txtResultado.Text & "2"
        End If
        blnoperador = True
    End Sub
    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If Limpar Then
            txtResultado.Text = "3"
            Limpar = False
        Else
            txtResultado.Text = txtResultado.Text & "3"
        End If
        blnoperador = True
    End Sub
    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If Limpar Then
            txtResultado.Text = "4"
            Limpar = False
        Else
            txtResultado.Text = txtResultado.Text & "4"
        End If
        blnoperador = True
    End Sub
    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If Limpar Then
            txtResultado.Text = "5"
            Limpar = False
        Else
            txtResultado.Text = txtResultado.Text & "5"
        End If
        blnoperador = True
    End Sub
    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If Limpar Then
            txtResultado.Text = "6"
            Limpar = False
        Else
            txtResultado.Text = txtResultado.Text & "6"
        End If
        blnoperador = True
    End Sub
    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If Limpar Then
            txtResultado.Text = "7"
            Limpar = False
        Else
            txtResultado.Text = txtResultado.Text & "7"
        End If
        blnoperador = True
    End Sub
    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If Limpar Then
            txtResultado.Text = "8"
            Limpar = False
        Else
            txtResultado.Text = txtResultado.Text & "8"
        End If
        blnoperador = True
    End Sub
    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If Limpar Then
            txtResultado.Text = "9"
            Limpar = False
        Else
            txtResultado.Text = txtResultado.Text & "9"
        End If
        blnoperador = True
    End Sub
    Private Sub btnPonto_Click(sender As Object, e As EventArgs) Handles btnPonto.Click
        If Ponto = False Then
            txtResultado.Text = txtResultado.Text & "."
            Ponto = True
        End If
    End Sub

    Private Sub btnIgual_Click(sender As Object, e As EventArgs) Handles btnPonto.Click
        If operador = "+" And numero = 0 Then
            resultado = resultado + Convert.ToDouble(txtResultado.Text)
        ElseIf operador = "-" And numero = 0 Then
            resultado = resultado - Convert.ToDouble(txtResultado.Text)
        ElseIf operador = "*" And numero = 0 Then
            resultado = resultado * Convert.ToDouble(txtResultado.Text)
        ElseIf operador = "/" And numero = 0 Then
            resultado = resultado / Convert.ToDouble(txtResultado.Text)
        End If
        txtResultado.Text = resultado
        Limpar = True
        blnoperador = False
    End Sub
End Class
