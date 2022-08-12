Public Class Form1
    Sub Clean()
        Data.Text = ""
    End Sub

    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click

        Try

            If Anos.Checked = True Then

                Dim resultado = DateDiff("yyyy", Data.Text, Today())
                MessageBox.Show("O intervalo de anos é: " & resultado)

            End If

            If Meses.Checked = True Then

                Dim resultado = DateDiff("m", Data.Text, Today())
                MessageBox.Show("O intervalo de meses é: " & resultado)

            End If

            If Dias.Checked = True Then

                Dim resultado = DateDiff("d", Data.Text, Today())
                MessageBox.Show("O intervalo de dias é: " & resultado)

            End If

        Catch
            MessageBox.Show("Entrada inválida")
            Clean()
        End Try

    End Sub


End Class
