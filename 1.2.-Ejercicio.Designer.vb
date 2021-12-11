<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEjercicio2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEjercicio2))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LabResultado = New System.Windows.Forms.Label()
        Me.txtAltura = New System.Windows.Forms.TextBox()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picObeso = New System.Windows.Forms.PictureBox()
        Me.picSobrePeso = New System.Windows.Forms.PictureBox()
        Me.picPesoNormal = New System.Windows.Forms.PictureBox()
        Me.picInfrapeso = New System.Windows.Forms.PictureBox()
        CType(Me.picObeso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSobrePeso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPesoNormal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInfrapeso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Button2.Location = New System.Drawing.Point(131, 286)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 32)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Reiniciar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Button1.Location = New System.Drawing.Point(21, 286)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 32)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Medir IMC"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'LabResultado
        '
        Me.LabResultado.AutoSize = True
        Me.LabResultado.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabResultado.Location = New System.Drawing.Point(7, 254)
        Me.LabResultado.Name = "LabResultado"
        Me.LabResultado.Size = New System.Drawing.Size(100, 20)
        Me.LabResultado.TabIndex = 12
        Me.LabResultado.Text = "Peso corporal:"
        '
        'txtAltura
        '
        Me.txtAltura.Location = New System.Drawing.Point(92, 202)
        Me.txtAltura.Name = "txtAltura"
        Me.txtAltura.Size = New System.Drawing.Size(76, 20)
        Me.txtAltura.TabIndex = 11
        '
        'txtPeso
        '
        Me.txtPeso.Location = New System.Drawing.Point(92, 144)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(76, 20)
        Me.txtPeso.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 199)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Altura(Cm)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Peso(Kg)"
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(445, 120)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = resources.GetString("Label1.Text")
        Me.Label1.UseMnemonic = False
        '
        'picObeso
        '
        Me.picObeso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picObeso.Image = Global.formulario.My.Resources.Resources.obeso
        Me.picObeso.Location = New System.Drawing.Point(240, 228)
        Me.picObeso.Name = "picObeso"
        Me.picObeso.Size = New System.Drawing.Size(78, 63)
        Me.picObeso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picObeso.TabIndex = 23
        Me.picObeso.TabStop = False
        Me.picObeso.Visible = False
        '
        'picSobrePeso
        '
        Me.picSobrePeso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picSobrePeso.Image = Global.formulario.My.Resources.Resources.sobre_peso
        Me.picSobrePeso.Location = New System.Drawing.Point(324, 228)
        Me.picSobrePeso.Name = "picSobrePeso"
        Me.picSobrePeso.Size = New System.Drawing.Size(100, 63)
        Me.picSobrePeso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSobrePeso.TabIndex = 22
        Me.picSobrePeso.TabStop = False
        Me.picSobrePeso.Visible = False
        '
        'picPesoNormal
        '
        Me.picPesoNormal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPesoNormal.Image = Global.formulario.My.Resources.Resources.peso_normal
        Me.picPesoNormal.Location = New System.Drawing.Point(218, 159)
        Me.picPesoNormal.Name = "picPesoNormal"
        Me.picPesoNormal.Size = New System.Drawing.Size(100, 63)
        Me.picPesoNormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPesoNormal.TabIndex = 21
        Me.picPesoNormal.TabStop = False
        Me.picPesoNormal.Visible = False
        '
        'picInfrapeso
        '
        Me.picInfrapeso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picInfrapeso.Image = Global.formulario.My.Resources.Resources.infrapeso
        Me.picInfrapeso.Location = New System.Drawing.Point(324, 159)
        Me.picInfrapeso.Name = "picInfrapeso"
        Me.picInfrapeso.Size = New System.Drawing.Size(100, 63)
        Me.picInfrapeso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picInfrapeso.TabIndex = 20
        Me.picInfrapeso.TabStop = False
        Me.picInfrapeso.Visible = False
        '
        'frmEjercicio2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(481, 357)
        Me.Controls.Add(Me.picObeso)
        Me.Controls.Add(Me.picSobrePeso)
        Me.Controls.Add(Me.picPesoNormal)
        Me.Controls.Add(Me.picInfrapeso)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LabResultado)
        Me.Controls.Add(Me.txtAltura)
        Me.Controls.Add(Me.txtPeso)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmEjercicio2"
        Me.Text = "2.-Ejercicio"
        CType(Me.picObeso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSobrePeso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPesoNormal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInfrapeso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents LabResultado As System.Windows.Forms.Label
    Friend WithEvents txtAltura As System.Windows.Forms.TextBox
    Friend WithEvents txtPeso As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents picObeso As System.Windows.Forms.PictureBox
    Friend WithEvents picSobrePeso As System.Windows.Forms.PictureBox
    Friend WithEvents picPesoNormal As System.Windows.Forms.PictureBox
    Friend WithEvents picInfrapeso As System.Windows.Forms.PictureBox
End Class
