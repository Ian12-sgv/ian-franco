<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEjercicio12
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.txtConfirmacion = New System.Windows.Forms.TextBox()
        Me.btnVerificar = New System.Windows.Forms.Button()
        Me.txtAccion = New System.Windows.Forms.TextBox()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(55, 118)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(100, 20)
        Me.txtCedula.TabIndex = 0
        '
        'txtConfirmacion
        '
        Me.txtConfirmacion.Location = New System.Drawing.Point(180, 118)
        Me.txtConfirmacion.Name = "txtConfirmacion"
        Me.txtConfirmacion.Size = New System.Drawing.Size(100, 20)
        Me.txtConfirmacion.TabIndex = 1
        '
        'btnVerificar
        '
        Me.btnVerificar.Location = New System.Drawing.Point(55, 209)
        Me.btnVerificar.Name = "btnVerificar"
        Me.btnVerificar.Size = New System.Drawing.Size(75, 23)
        Me.btnVerificar.TabIndex = 2
        Me.btnVerificar.Text = "Verificar"
        Me.btnVerificar.UseVisualStyleBackColor = True
        '
        'txtAccion
        '
        Me.txtAccion.Location = New System.Drawing.Point(121, 167)
        Me.txtAccion.Name = "txtAccion"
        Me.txtAccion.Size = New System.Drawing.Size(100, 20)
        Me.txtAccion.TabIndex = 3
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(215, 209)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrar.TabIndex = 4
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(324, 87)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Realizar un programa que evalúe una cédula de identidad brindada. Investigar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "cua" & _
    "l es el algoritmo para identificar un número válido." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.UseMnemonic = False
        '
        'FrmEjercicio12
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(361, 265)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.txtAccion)
        Me.Controls.Add(Me.btnVerificar)
        Me.Controls.Add(Me.txtConfirmacion)
        Me.Controls.Add(Me.txtCedula)
        Me.Name = "FrmEjercicio12"
        Me.Text = "12.-Ejercicio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCedula As System.Windows.Forms.TextBox
    Friend WithEvents txtConfirmacion As System.Windows.Forms.TextBox
    Friend WithEvents btnVerificar As System.Windows.Forms.Button
    Friend WithEvents txtAccion As System.Windows.Forms.TextBox
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
