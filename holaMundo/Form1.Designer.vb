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
        Me.Texto = New System.Windows.Forms.Label()
        Me.Tablas1 = New System.Windows.Forms.ListBox()
        Me.Ctexto = New System.Windows.Forms.TextBox()
        Me.Boton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Texto
        '
        Me.Texto.AutoSize = True
        Me.Texto.Location = New System.Drawing.Point(86, 81)
        Me.Texto.Name = "Texto"
        Me.Texto.Size = New System.Drawing.Size(56, 20)
        Me.Texto.TabIndex = 0
        Me.Texto.Text = "Tabla: "
        '
        'Tablas1
        '
        Me.Tablas1.FormattingEnabled = True
        Me.Tablas1.ItemHeight = 20
        Me.Tablas1.Location = New System.Drawing.Point(280, 81)
        Me.Tablas1.Name = "Tablas1"
        Me.Tablas1.Size = New System.Drawing.Size(359, 244)
        Me.Tablas1.TabIndex = 1
        '
        'Ctexto
        '
        Me.Ctexto.Location = New System.Drawing.Point(139, 81)
        Me.Ctexto.Name = "Ctexto"
        Me.Ctexto.Size = New System.Drawing.Size(100, 26)
        Me.Ctexto.TabIndex = 2
        '
        'Boton
        '
        Me.Boton.Location = New System.Drawing.Point(102, 128)
        Me.Boton.Name = "Boton"
        Me.Boton.Size = New System.Drawing.Size(137, 66)
        Me.Boton.TabIndex = 3
        Me.Boton.Text = "Generar tabla"
        Me.Boton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 403)
        Me.Controls.Add(Me.Boton)
        Me.Controls.Add(Me.Ctexto)
        Me.Controls.Add(Me.Tablas1)
        Me.Controls.Add(Me.Texto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "tablas de duma :U"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Texto As Label
    Friend WithEvents Tablas1 As ListBox
    Friend WithEvents Ctexto As TextBox
    Friend WithEvents Boton As Button
End Class
