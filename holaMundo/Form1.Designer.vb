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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.respuesta = New System.Windows.Forms.TextBox()
        Me.unidades = New System.Windows.Forms.TextBox()
        Me.cantidad = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtA = New System.Windows.Forms.TextBox()
        Me.TxtCON = New System.Windows.Forms.TextBox()
        Me.ComCA = New System.Windows.Forms.ComboBox()
        Me.ComCD = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(14, 12)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(764, 471)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.respuesta)
        Me.TabPage1.Controls.Add(Me.unidades)
        Me.TabPage1.Controls.Add(Me.cantidad)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage1.Size = New System.Drawing.Size(756, 438)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Universal"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(289, 261)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(180, 49)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Convertir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(166, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "respuesta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(325, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Unidades"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Cantidad"
        '
        'respuesta
        '
        Me.respuesta.Location = New System.Drawing.Point(253, 169)
        Me.respuesta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.respuesta.Name = "respuesta"
        Me.respuesta.Size = New System.Drawing.Size(120, 26)
        Me.respuesta.TabIndex = 2
        '
        'unidades
        '
        Me.unidades.Location = New System.Drawing.Point(404, 59)
        Me.unidades.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.unidades.Name = "unidades"
        Me.unidades.Size = New System.Drawing.Size(120, 26)
        Me.unidades.TabIndex = 1
        '
        'cantidad
        '
        Me.cantidad.Location = New System.Drawing.Point(98, 59)
        Me.cantidad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cantidad.Name = "cantidad"
        Me.cantidad.Size = New System.Drawing.Size(120, 26)
        Me.cantidad.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.TxtA)
        Me.TabPage2.Controls.Add(Me.TxtCON)
        Me.TabPage2.Controls.Add(Me.ComCA)
        Me.TabPage2.Controls.Add(Me.ComCD)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage2.Size = New System.Drawing.Size(756, 438)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Area"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(372, 106)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(20, 20)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "A"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 20)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "DE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(296, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Respuesta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Cantidad"
        '
        'TxtA
        '
        Me.TxtA.Location = New System.Drawing.Point(410, 32)
        Me.TxtA.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtA.Name = "TxtA"
        Me.TxtA.Size = New System.Drawing.Size(148, 26)
        Me.TxtA.TabIndex = 4
        '
        'TxtCON
        '
        Me.TxtCON.Location = New System.Drawing.Point(119, 35)
        Me.TxtCON.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtCON.Name = "TxtCON"
        Me.TxtCON.Size = New System.Drawing.Size(148, 26)
        Me.TxtCON.TabIndex = 3
        '
        'ComCA
        '
        Me.ComCA.FormattingEnabled = True
        Me.ComCA.Items.AddRange(New Object() {" Pie Cuadrado ", "Vara Cuadrada ", " Yarda Cuadrada ", " Metro Cuadrado ", "Tareas ", " Manzana ", " Hectárea  "})
        Me.ComCA.Location = New System.Drawing.Point(460, 98)
        Me.ComCA.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComCA.Name = "ComCA"
        Me.ComCA.Size = New System.Drawing.Size(180, 28)
        Me.ComCA.TabIndex = 2
        '
        'ComCD
        '
        Me.ComCD.FormattingEnabled = True
        Me.ComCD.Items.AddRange(New Object() {" Pie Cuadrado ", "Vara Cuadrada ", " Yarda Cuadrada ", " Metro Cuadrado ", "Tareas ", " Manzana ", " Hectárea  "})
        Me.ComCD.Location = New System.Drawing.Point(138, 102)
        Me.ComCD.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComCD.Name = "ComCD"
        Me.ComCD.Size = New System.Drawing.Size(180, 28)
        Me.ComCD.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(271, 278)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 35)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "CONVERTIR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 500)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Convensor Parcial"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents respuesta As TextBox
    Friend WithEvents unidades As TextBox
    Friend WithEvents cantidad As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TxtA As TextBox
    Friend WithEvents TxtCON As TextBox
    Friend WithEvents ComCA As ComboBox
    Friend WithEvents ComCD As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
End Class
