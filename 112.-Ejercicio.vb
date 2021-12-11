Public Class FrmEjercicio12

    Private Sub btnVerificar_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click

        Dim cedula, confirmacion, accion As Long

        cedula = Val(txtCedula.Text)

        confirmacion = Val(txtConfirmacion.Text)

        accion = Val(txtAccion.Text)


        If (confirmacion = cedula) Then

            txtAccion.Text = "Aprobada"

        ElseIf (confirmacion <> cedula) Then

            txtAccion.Text = "Incorecta"


        End If




    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click

        txtCedula.Text = String.Empty
        txtConfirmacion.Text = String.Empty
        txtAccion.Text = String.Empty


    End Sub
End Class