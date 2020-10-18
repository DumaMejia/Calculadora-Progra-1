<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proveedor
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
        Me.PanelDatos = New System.Windows.Forms.Panel()
        Me.txtPropietario = New System.Windows.Forms.TextBox()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.modificarBT = New System.Windows.Forms.Button()
        Me.nuevoBT = New System.Windows.Forms.Button()
        Me.eliminarBT = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txtcorreo = New System.Windows.Forms.TextBox()
        Me.PanelDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelDatos
        '
        Me.PanelDatos.Controls.Add(Me.Txtcorreo)
        Me.PanelDatos.Controls.Add(Me.Label6)
        Me.PanelDatos.Controls.Add(Me.txtPropietario)
        Me.PanelDatos.Controls.Add(Me.txtdireccion)
        Me.PanelDatos.Controls.Add(Me.txttelefono)
        Me.PanelDatos.Controls.Add(Me.txtnombre)
        Me.PanelDatos.Controls.Add(Me.Label4)
        Me.PanelDatos.Controls.Add(Me.Label3)
        Me.PanelDatos.Controls.Add(Me.Label2)
        Me.PanelDatos.Controls.Add(Me.Label1)
        Me.PanelDatos.Location = New System.Drawing.Point(65, 33)
        Me.PanelDatos.Name = "PanelDatos"
        Me.PanelDatos.Size = New System.Drawing.Size(722, 333)
        Me.PanelDatos.TabIndex = 20
        '
        'txtPropietario
        '
        Me.txtPropietario.Location = New System.Drawing.Point(298, 119)
        Me.txtPropietario.Name = "txtPropietario"
        Me.txtPropietario.Size = New System.Drawing.Size(293, 26)
        Me.txtPropietario.TabIndex = 16
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(298, 172)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(293, 26)
        Me.txtdireccion.TabIndex = 15
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(298, 219)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(293, 26)
        Me.txttelefono.TabIndex = 14
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(298, 40)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(293, 26)
        Me.txtnombre.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(132, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "DIRECCION"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(132, 219)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "TELEFONO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(132, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "PROPIETARIO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(132, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "NOMBRE"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(545, 372)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 44)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(321, 384)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 20)
        Me.Label5.TabIndex = 18
        '
        'modificarBT
        '
        Me.modificarBT.Location = New System.Drawing.Point(175, 372)
        Me.modificarBT.Name = "modificarBT"
        Me.modificarBT.Size = New System.Drawing.Size(113, 44)
        Me.modificarBT.TabIndex = 17
        Me.modificarBT.Text = "Modificar"
        Me.modificarBT.UseVisualStyleBackColor = True
        '
        'nuevoBT
        '
        Me.nuevoBT.Location = New System.Drawing.Point(55, 372)
        Me.nuevoBT.Name = "nuevoBT"
        Me.nuevoBT.Size = New System.Drawing.Size(113, 44)
        Me.nuevoBT.TabIndex = 16
        Me.nuevoBT.Text = "Nuevo"
        Me.nuevoBT.UseVisualStyleBackColor = True
        '
        'eliminarBT
        '
        Me.eliminarBT.Location = New System.Drawing.Point(664, 372)
        Me.eliminarBT.Name = "eliminarBT"
        Me.eliminarBT.Size = New System.Drawing.Size(113, 44)
        Me.eliminarBT.TabIndex = 15
        Me.eliminarBT.Text = "Eliminar"
        Me.eliminarBT.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(132, 261)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 20)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "CORREO"
        '
        'Txtcorreo
        '
        Me.Txtcorreo.Location = New System.Drawing.Point(298, 261)
        Me.Txtcorreo.Name = "Txtcorreo"
        Me.Txtcorreo.Size = New System.Drawing.Size(293, 26)
        Me.Txtcorreo.TabIndex = 18
        '
        'Proveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 497)
        Me.Controls.Add(Me.PanelDatos)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.modificarBT)
        Me.Controls.Add(Me.nuevoBT)
        Me.Controls.Add(Me.eliminarBT)
        Me.Name = "Proveedor"
        Me.Text = "Proveedor"
        Me.PanelDatos.ResumeLayout(False)
        Me.PanelDatos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelDatos As Panel
    Friend WithEvents Txtcorreo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPropietario As TextBox
    Friend WithEvents txtdireccion As TextBox
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents modificarBT As Button
    Friend WithEvents nuevoBT As Button
    Friend WithEvents eliminarBT As Button
End Class
