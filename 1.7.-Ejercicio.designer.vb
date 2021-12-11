<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEjercicio7
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtPalabra = New System.Windows.Forms.TextBox()
        Me.cbxpalguardadas = New System.Windows.Forms.ComboBox()
        Me.Guardar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese una palabra"
        '
        'TxtPalabra
        '
        Me.TxtPalabra.Location = New System.Drawing.Point(117, 152)
        Me.TxtPalabra.Name = "TxtPalabra"
        Me.TxtPalabra.Size = New System.Drawing.Size(141, 20)
        Me.TxtPalabra.TabIndex = 1
        '
        'cbxpalguardadas
        '
        Me.cbxpalguardadas.FormattingEnabled = True
        Me.cbxpalguardadas.Location = New System.Drawing.Point(117, 207)
        Me.cbxpalguardadas.Name = "cbxpalguardadas"
        Me.cbxpalguardadas.Size = New System.Drawing.Size(141, 21)
        Me.cbxpalguardadas.TabIndex = 2
        '
        'Guardar
        '
        Me.Guardar.Location = New System.Drawing.Point(22, 207)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(75, 23)
        Me.Guardar.TabIndex = 3
        Me.Guardar.Text = "Guardar"
        Me.Guardar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(2, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(256, 69)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Realizar un programa que permita nutrir un ComboBox con valores ingresados" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "en un" & _
    "a caja de texto. Validar que no permita el ingreso de elementos vacíos." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label2.UseMnemonic = False
        '
        'frmEjercicio7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(302, 309)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Guardar)
        Me.Controls.Add(Me.cbxpalguardadas)
        Me.Controls.Add(Me.TxtPalabra)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmEjercicio7"
        Me.Text = "Formejercicio17"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtPalabra As System.Windows.Forms.TextBox
    Friend WithEvents cbxpalguardadas As System.Windows.Forms.ComboBox
    Friend WithEvents Guardar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
