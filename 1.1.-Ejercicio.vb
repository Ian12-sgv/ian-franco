Public Class frmEjercicio1

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        labResultado.Text = "El areas es: " & (Val(txtBase.Text) * Val(txtAltura.Text) / 2)

    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click

        txtBase.Text = String.Empty
        txtAltura.Text = String.Empty
        labResultado.Text = ""

    End Sub
End Class