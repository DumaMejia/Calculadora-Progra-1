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
        Me.lblRespuestaRomano = New System.Windows.Forms.Label()
        Me.txtnumero = New System.Windows.Forms.TextBox()
        Me.lblnumero = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblRespuestaRomano
        '
        Me.lblRespuestaRomano.AutoSize = True
        Me.lblRespuestaRomano.Location = New System.Drawing.Point(257, 33)
        Me.lblRespuestaRomano.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRespuestaRomano.Name = "lblRespuestaRomano"
        Me.lblRespuestaRomano.Size = New System.Drawing.Size(147, 20)
        Me.lblRespuestaRomano.TabIndex = 11
        Me.lblRespuestaRomano.Text = "Numero Romano: ?"
        '
        'txtnumero
        '
        Me.txtnumero.Location = New System.Drawing.Point(95, 28)
        Me.txtnumero.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.Size = New System.Drawing.Size(151, 26)
        Me.txtnumero.TabIndex = 10
        '
        'lblnumero
        '
        Me.lblnumero.AutoSize = True
        Me.lblnumero.Location = New System.Drawing.Point(28, 33)
        Me.lblnumero.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblnumero.Name = "lblnumero"
        Me.lblnumero.Size = New System.Drawing.Size(62, 20)
        Me.lblnumero.TabIndex = 9
        Me.lblnumero.Text = "Capital:"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(166, 167)
        Me.btnCalcular.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(80, 52)
        Me.btnCalcular.TabIndex = 8
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 282)
        Me.Controls.Add(Me.lblRespuestaRomano)
        Me.Controls.Add(Me.txtnumero)
        Me.Controls.Add(Me.lblnumero)
        Me.Controls.Add(Me.btnCalcular)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Convertidor de unidades"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRespuestaRomano As Label
    Friend WithEvents txtnumero As TextBox
    Friend WithEvents lblnumero As Label
    Friend WithEvents btnCalcular As Button
End Class
