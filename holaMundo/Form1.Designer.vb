<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.OptResiduo = New System.Windows.Forms.RadioButton()
        Me.optExponenciacion = New System.Windows.Forms.RadioButton()
        Me.optPorcentaje = New System.Windows.Forms.RadioButton()
        Me.optDividir = New System.Windows.Forms.RadioButton()
        Me.optMultiplicar = New System.Windows.Forms.RadioButton()
        Me.optResta = New System.Windows.Forms.RadioButton()
        Me.optSuma = New System.Windows.Forms.RadioButton()
        Me.lblrespuesta = New System.Windows.Forms.Label()
        Me.txtnum2 = New System.Windows.Forms.TextBox()
        Me.lblnum2 = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.txtnum1 = New System.Windows.Forms.TextBox()
        Me.lblnum1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Suma", "Resta", "Multiplicacion", "Division", "Porcentaje", "exponente", "Residuo"})
        Me.ComboBox2.Location = New System.Drawing.Point(519, 125)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 28)
        Me.ComboBox2.TabIndex = 29
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(56, 27)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 28)
        Me.ComboBox1.TabIndex = 28
        '
        'OptResiduo
        '
        Me.OptResiduo.AutoSize = True
        Me.OptResiduo.Location = New System.Drawing.Point(268, 267)
        Me.OptResiduo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OptResiduo.Name = "OptResiduo"
        Me.OptResiduo.Size = New System.Drawing.Size(93, 24)
        Me.OptResiduo.TabIndex = 27
        Me.OptResiduo.Text = "Residuo"
        Me.OptResiduo.UseVisualStyleBackColor = True
        '
        'optExponenciacion
        '
        Me.optExponenciacion.AutoSize = True
        Me.optExponenciacion.Location = New System.Drawing.Point(268, 232)
        Me.optExponenciacion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.optExponenciacion.Name = "optExponenciacion"
        Me.optExponenciacion.Size = New System.Drawing.Size(41, 24)
        Me.optExponenciacion.TabIndex = 26
        Me.optExponenciacion.Text = "^"
        Me.optExponenciacion.UseVisualStyleBackColor = True
        '
        'optPorcentaje
        '
        Me.optPorcentaje.AutoSize = True
        Me.optPorcentaje.Location = New System.Drawing.Point(268, 196)
        Me.optPorcentaje.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.optPorcentaje.Name = "optPorcentaje"
        Me.optPorcentaje.Size = New System.Drawing.Size(110, 24)
        Me.optPorcentaje.TabIndex = 25
        Me.optPorcentaje.Text = "Porcentaje"
        Me.optPorcentaje.UseVisualStyleBackColor = True
        '
        'optDividir
        '
        Me.optDividir.AutoSize = True
        Me.optDividir.Location = New System.Drawing.Point(266, 161)
        Me.optDividir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.optDividir.Name = "optDividir"
        Me.optDividir.Size = New System.Drawing.Size(38, 24)
        Me.optDividir.TabIndex = 24
        Me.optDividir.TabStop = True
        Me.optDividir.Text = "/"
        Me.optDividir.UseVisualStyleBackColor = True
        '
        'optMultiplicar
        '
        Me.optMultiplicar.AutoSize = True
        Me.optMultiplicar.Location = New System.Drawing.Point(266, 125)
        Me.optMultiplicar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.optMultiplicar.Name = "optMultiplicar"
        Me.optMultiplicar.Size = New System.Drawing.Size(40, 24)
        Me.optMultiplicar.TabIndex = 23
        Me.optMultiplicar.TabStop = True
        Me.optMultiplicar.Text = "*"
        Me.optMultiplicar.UseVisualStyleBackColor = True
        '
        'optResta
        '
        Me.optResta.AutoSize = True
        Me.optResta.Location = New System.Drawing.Point(266, 90)
        Me.optResta.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.optResta.Name = "optResta"
        Me.optResta.Size = New System.Drawing.Size(39, 24)
        Me.optResta.TabIndex = 22
        Me.optResta.TabStop = True
        Me.optResta.Text = "-"
        Me.optResta.UseVisualStyleBackColor = True
        '
        'optSuma
        '
        Me.optSuma.AutoSize = True
        Me.optSuma.Checked = True
        Me.optSuma.Location = New System.Drawing.Point(266, 55)
        Me.optSuma.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.optSuma.Name = "optSuma"
        Me.optSuma.Size = New System.Drawing.Size(43, 24)
        Me.optSuma.TabIndex = 21
        Me.optSuma.TabStop = True
        Me.optSuma.Text = "+"
        Me.optSuma.UseVisualStyleBackColor = True
        '
        'lblrespuesta
        '
        Me.lblrespuesta.AutoSize = True
        Me.lblrespuesta.Location = New System.Drawing.Point(478, 96)
        Me.lblrespuesta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblrespuesta.Name = "lblrespuesta"
        Me.lblrespuesta.Size = New System.Drawing.Size(104, 20)
        Me.lblrespuesta.TabIndex = 20
        Me.lblrespuesta.Text = "Respuesta: ?"
        '
        'txtnum2
        '
        Me.txtnum2.Location = New System.Drawing.Point(384, 92)
        Me.txtnum2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtnum2.Name = "txtnum2"
        Me.txtnum2.Size = New System.Drawing.Size(82, 26)
        Me.txtnum2.TabIndex = 19
        '
        'lblnum2
        '
        Me.lblnum2.AutoSize = True
        Me.lblnum2.Location = New System.Drawing.Point(317, 96)
        Me.lblnum2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblnum2.Name = "lblnum2"
        Me.lblnum2.Size = New System.Drawing.Size(59, 20)
        Me.lblnum2.TabIndex = 18
        Me.lblnum2.Text = "Num 2:"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(215, 324)
        Me.btnCalcular.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(138, 51)
        Me.btnCalcular.TabIndex = 17
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'txtnum1
        '
        Me.txtnum1.Location = New System.Drawing.Point(152, 92)
        Me.txtnum1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtnum1.Name = "txtnum1"
        Me.txtnum1.Size = New System.Drawing.Size(82, 26)
        Me.txtnum1.TabIndex = 16
        '
        'lblnum1
        '
        Me.lblnum1.AutoSize = True
        Me.lblnum1.Location = New System.Drawing.Point(82, 96)
        Me.lblnum1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblnum1.Name = "lblnum1"
        Me.lblnum1.Size = New System.Drawing.Size(59, 20)
        Me.lblnum1.TabIndex = 15
        Me.lblnum1.Text = "Num 1:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 403)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.OptResiduo)
        Me.Controls.Add(Me.optExponenciacion)
        Me.Controls.Add(Me.optPorcentaje)
        Me.Controls.Add(Me.optDividir)
        Me.Controls.Add(Me.optMultiplicar)
        Me.Controls.Add(Me.optResta)
        Me.Controls.Add(Me.optSuma)
        Me.Controls.Add(Me.lblrespuesta)
        Me.Controls.Add(Me.txtnum2)
        Me.Controls.Add(Me.lblnum2)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtnum1)
        Me.Controls.Add(Me.lblnum1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Convertidor de unidades"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents OptResiduo As RadioButton
    Friend WithEvents optExponenciacion As RadioButton
    Friend WithEvents optPorcentaje As RadioButton
    Friend WithEvents optDividir As RadioButton
    Friend WithEvents optMultiplicar As RadioButton
    Friend WithEvents optResta As RadioButton
    Friend WithEvents optSuma As RadioButton
    Friend WithEvents lblrespuesta As Label
    Friend WithEvents txtnum2 As TextBox
    Friend WithEvents lblnum2 As Label
    Friend WithEvents btnCalcular As Button
    Friend WithEvents txtnum1 As TextBox
    Friend WithEvents lblnum1 As Label
End Class
