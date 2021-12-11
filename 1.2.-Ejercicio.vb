Public Class frmEjercicio2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Altura, Peso, IMC As Double

        Altura = Val(txtAltura.Text)
        Altura = Math.Round(Altura, 2)

        Peso = Val(txtPeso.Text)
        Peso = Math.Round(Peso, 2)

        IMC = Peso / (Altura ^ 2)
        IMC = Math.Round(IMC)

        If IMC < 18.49 Then
            LabResultado.Text = "IMC: " & IMC & "Tienes Infrapeso"
            LabResultado.BackColor = Color.Red
            picInfrapeso.Show()

        ElseIf IMC > 18.5 And IMC < 24.99 Then
            LabResultado.Text = "IMC: " & IMC & "Su peso es normal"
            LabResultado.Text = " Peso Normal"
            LabResultado.BackColor = Color.Goldenrod
            picPesoNormal.Show()

        ElseIf IMC > 25 And IMC < 29.99 Then

            LabResultado.Text = "IMC: " & IMC & "Tines sobrepeso"
            LabResultado.Text = "Sobrepeso"
            LabResultado.BackColor = Color.LightSkyBlue
            picSobrePeso.Show()

        Else

            LabResultado.Text = "IMC: " & IMC & "Tiene obesidad"
            LabResultado.BackColor = Color.Fuchsia
            picObeso.Show()

        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        txtPeso.Text = String.Empty
        txtAltura.Text = String.Empty
        LabResultado.Text = ""
        picInfrapeso.Hide()
        picPesoNormal.Hide()
        picSobrePeso.Hide()
        picObeso.Hide()

    End Sub

End Class