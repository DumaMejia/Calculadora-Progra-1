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
        Me.lblnum1 = New System.Windows.Forms.Label()
        Me.txtnum1 = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.lblnum2 = New System.Windows.Forms.Label()
        Me.txtnum2 = New System.Windows.Forms.TextBox()
        Me.lblrespuesta = New System.Windows.Forms.Label()
        Me.optSuma = New System.Windows.Forms.RadioButton()
        Me.optResta = New System.Windows.Forms.RadioButton()
        Me.optMultiplicar = New System.Windows.Forms.RadioButton()
        Me.optDividir = New System.Windows.Forms.RadioButton()
        Me.optPorcentaje = New System.Windows.Forms.RadioButton()
        Me.optExponenciacion = New System.Windows.Forms.RadioButton()
        Me.OptResiduo = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'lblnum1
        '
        Me.lblnum1.AutoSize = True
        Me.lblnum1.Location = New System.Drawing.Point(26, 69)
        Me.lblnum1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblnum1.Name = "lblnum1"
        Me.lblnum1.Size = New System.Drawing.Size(59, 20)
        Me.lblnum1.TabIndex = 0
        Me.lblnum1.Text = "Num 1:"
        '
        'txtnum1
        '
        Me.txtnum1.Location = New System.Drawing.Point(96, 65)
        Me.txtnum1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtnum1.Name = "txtnum1"
        Me.txtnum1.Size = New System.Drawing.Size(82, 26)
        Me.txtnum1.TabIndex = 1
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(159, 297)
        Me.btnCalcular.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(138, 51)
        Me.btnCalcular.TabIndex = 2
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'lblnum2
        '
        Me.lblnum2.AutoSize = True
        Me.lblnum2.Location = New System.Drawing.Point(261, 69)
        Me.lblnum2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblnum2.Name = "lblnum2"
        Me.lblnum2.Size = New System.Drawing.Size(59, 20)
        Me.lblnum2.TabIndex = 3
        Me.lblnum2.Text = "Num 2:"
        '
        'txtnum2
        '
        Me.txtnum2.Location = New System.Drawing.Point(328, 65)
        Me.txtnum2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtnum2.Name = "txtnum2"
        Me.txtnum2.Size = New System.Drawing.Size(82, 26)
        Me.txtnum2.TabIndex = 4
        '
        'lblrespuesta
        '
        Me.lblrespuesta.AutoSize = True
        Me.lblrespuesta.Location = New System.Drawing.Point(422, 69)
        Me.lblrespuesta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblrespuesta.Name = "lblrespuesta"
        Me.lblrespuesta.Size = New System.Drawing.Size(104, 20)
        Me.lblrespuesta.TabIndex = 5
        Me.lblrespuesta.Text = "Respuesta: ?"
        '
        'optSuma
        '
        Me.optSuma.AutoSize = True
        Me.optSuma.Checked = True
        Me.optSuma.Location = New System.Drawing.Point(210, 28)
        Me.optSuma.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.optSuma.Name = "optSuma"
        Me.optSuma.Size = New System.Drawing.Size(43, 24)
        Me.optSuma.TabIndex = 6
        Me.optSuma.TabStop = True
        Me.optSuma.Text = "+"
        Me.optSuma.UseVisualStyleBackColor = True
        '
        'optResta
        '
        Me.optResta.AutoSize = True
        Me.optResta.Location = New System.Drawing.Point(210, 63)
        Me.optResta.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.optResta.Name = "optResta"
        Me.optResta.Size = New System.Drawing.Size(39, 24)
        Me.optResta.TabIndex = 7
        Me.optResta.TabStop = True
        Me.optResta.Text = "-"
        Me.optResta.UseVisualStyleBackColor = True
        '
        'optMultiplicar
        '
        Me.optMultiplicar.AutoSize = True
        Me.optMultiplicar.Location = New System.Drawing.Point(210, 98)
        Me.optMultiplicar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.optMultiplicar.Name = "optMultiplicar"
        Me.optMultiplicar.Size = New System.Drawing.Size(40, 24)
        Me.optMultiplicar.TabIndex = 8
        Me.optMultiplicar.TabStop = True
        Me.optMultiplicar.Text = "*"
        Me.optMultiplicar.UseVisualStyleBackColor = True
        '
        'optDividir
        '
        Me.optDividir.AutoSize = True
        Me.optDividir.Location = New System.Drawing.Point(210, 134)
        Me.optDividir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.optDividir.Name = "optDividir"
        Me.optDividir.Size = New System.Drawing.Size(38, 24)
        Me.optDividir.TabIndex = 9
        Me.optDividir.TabStop = True
        Me.optDividir.Text = "/"
        Me.optDividir.UseVisualStyleBackColor = True
        '
        'optPorcentaje
        '
        Me.optPorcentaje.AutoSize = True
        Me.optPorcentaje.Location = New System.Drawing.Point(212, 169)
        Me.optPorcentaje.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.optPorcentaje.Name = "optPorcentaje"
        Me.optPorcentaje.Size = New System.Drawing.Size(110, 24)
        Me.optPorcentaje.TabIndex = 10
        Me.optPorcentaje.Text = "Porcentaje"
        Me.optPorcentaje.UseVisualStyleBackColor = True
        '
        'optExponenciacion
        '
        Me.optExponenciacion.AutoSize = True
        Me.optExponenciacion.Location = New System.Drawing.Point(212, 205)
        Me.optExponenciacion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.optExponenciacion.Name = "optExponenciacion"
        Me.optExponenciacion.Size = New System.Drawing.Size(41, 24)
        Me.optExponenciacion.TabIndex = 11
        Me.optExponenciacion.Text = "^"
        Me.optExponenciacion.UseVisualStyleBackColor = True
        '
        'OptResiduo
        '
        Me.OptResiduo.AutoSize = True
        Me.OptResiduo.Location = New System.Drawing.Point(212, 240)
        Me.OptResiduo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OptResiduo.Name = "OptResiduo"
        Me.OptResiduo.Size = New System.Drawing.Size(93, 24)
        Me.OptResiduo.TabIndex = 12
        Me.OptResiduo.Text = "Residuo"
        Me.OptResiduo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 403)
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
        Me.Text = "Calculadora Basica"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblnum1 As Label
    Friend WithEvents txtnum1 As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents lblnum2 As Label
    Friend WithEvents txtnum2 As TextBox
    Friend WithEvents lblrespuesta As Label
    Friend WithEvents optSuma As RadioButton
    Friend WithEvents optResta As RadioButton
    Friend WithEvents optMultiplicar As RadioButton
    Friend WithEvents optDividir As RadioButton
    Friend WithEvents optPorcentaje As RadioButton
    Friend WithEvents optExponenciacion As RadioButton
    Friend WithEvents OptResiduo As RadioButton
End Class
