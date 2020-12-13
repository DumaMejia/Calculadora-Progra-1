<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class receta
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
        Me.eliminarBT = New System.Windows.Forms.Button()
        Me.nuevoBT = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PanelDatos = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.modificarBT = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PanelBD = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDreceta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Idreceta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nreceta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DosisD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PanelDatos.SuspendLayout()
        Me.PanelBD.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'eliminarBT
        '
        Me.eliminarBT.Location = New System.Drawing.Point(281, 620)
        Me.eliminarBT.Name = "eliminarBT"
        Me.eliminarBT.Size = New System.Drawing.Size(113, 44)
        Me.eliminarBT.TabIndex = 72
        Me.eliminarBT.Text = "Eliminar"
        Me.eliminarBT.UseVisualStyleBackColor = True
        '
        'nuevoBT
        '
        Me.nuevoBT.Location = New System.Drawing.Point(34, 620)
        Me.nuevoBT.Name = "nuevoBT"
        Me.nuevoBT.Size = New System.Drawing.Size(113, 44)
        Me.nuevoBT.TabIndex = 73
        Me.nuevoBT.Text = "Nuevo"
        Me.nuevoBT.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "HECHO POR: "
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(192, 14)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(187, 28)
        Me.ComboBox1.TabIndex = 18
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(500, 14)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(187, 28)
        Me.ComboBox2.TabIndex = 20
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(500, 60)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(187, 28)
        Me.ComboBox3.TabIndex = 21
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(192, 63)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(187, 81)
        Me.TextBox1.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 20)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "DESCRIPCION"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(398, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 20)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "PADECE:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(400, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 20)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "PARA:"
        '
        'PanelDatos
        '
        Me.PanelDatos.Controls.Add(Me.Label8)
        Me.PanelDatos.Controls.Add(Me.Label7)
        Me.PanelDatos.Controls.Add(Me.Label6)
        Me.PanelDatos.Controls.Add(Me.Label5)
        Me.PanelDatos.Controls.Add(Me.TextBox1)
        Me.PanelDatos.Controls.Add(Me.ComboBox3)
        Me.PanelDatos.Controls.Add(Me.ComboBox2)
        Me.PanelDatos.Controls.Add(Me.ComboBox1)
        Me.PanelDatos.Controls.Add(Me.TextBox2)
        Me.PanelDatos.Controls.Add(Me.Label3)
        Me.PanelDatos.Location = New System.Drawing.Point(43, 40)
        Me.PanelDatos.Name = "PanelDatos"
        Me.PanelDatos.Size = New System.Drawing.Size(712, 147)
        Me.PanelDatos.TabIndex = 76
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(398, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 20)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Nº RECETA:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(500, 105)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(187, 26)
        Me.TextBox2.TabIndex = 17
        '
        'modificarBT
        '
        Me.modificarBT.Location = New System.Drawing.Point(162, 620)
        Me.modificarBT.Name = "modificarBT"
        Me.modificarBT.Size = New System.Drawing.Size(113, 44)
        Me.modificarBT.TabIndex = 74
        Me.modificarBT.Text = "Modificar"
        Me.modificarBT.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(16, 369)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(298, 44)
        Me.Button2.TabIndex = 66
        Me.Button2.Text = "EDITAR MEDICAMENTOS"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PanelBD
        '
        Me.PanelBD.Controls.Add(Me.DataGridView1)
        Me.PanelBD.Controls.Add(Me.Button2)
        Me.PanelBD.Location = New System.Drawing.Point(43, 193)
        Me.PanelBD.Name = "PanelBD"
        Me.PanelBD.Size = New System.Drawing.Size(712, 421)
        Me.PanelBD.TabIndex = 77
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDreceta, Me.Idreceta, Me.Nreceta, Me.Id, Me.nombre, Me.cantidad, Me.DosisD})
        Me.DataGridView1.Location = New System.Drawing.Point(16, 13)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(671, 350)
        Me.DataGridView1.TabIndex = 67
        '
        'IdDreceta
        '
        Me.IdDreceta.DataPropertyName = "IdDreceta"
        Me.IdDreceta.HeaderText = "IDDRECETA"
        Me.IdDreceta.MinimumWidth = 8
        Me.IdDreceta.Name = "IdDreceta"
        Me.IdDreceta.ReadOnly = True
        Me.IdDreceta.Visible = False
        Me.IdDreceta.Width = 150
        '
        'Idreceta
        '
        Me.Idreceta.DataPropertyName = "Idreceta"
        Me.Idreceta.HeaderText = "IDRECETA"
        Me.Idreceta.MinimumWidth = 8
        Me.Idreceta.Name = "Idreceta"
        Me.Idreceta.ReadOnly = True
        Me.Idreceta.Visible = False
        Me.Idreceta.Width = 150
        '
        'Nreceta
        '
        Me.Nreceta.DataPropertyName = "Nreceta"
        Me.Nreceta.HeaderText = "NRECETA"
        Me.Nreceta.MinimumWidth = 8
        Me.Nreceta.Name = "Nreceta"
        Me.Nreceta.ReadOnly = True
        Me.Nreceta.Width = 150
        '
        'Id
        '
        Me.Id.DataPropertyName = "Id"
        Me.Id.HeaderText = "IDMEDICAMENTO"
        Me.Id.MinimumWidth = 8
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Visible = False
        Me.Id.Width = 150
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "MEDICAMENTO"
        Me.nombre.MinimumWidth = 8
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 150
        '
        'cantidad
        '
        Me.cantidad.DataPropertyName = "Cantidad"
        Me.cantidad.HeaderText = "CANTIDAD"
        Me.cantidad.MinimumWidth = 8
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        Me.cantidad.Width = 150
        '
        'DosisD
        '
        Me.DosisD.DataPropertyName = "DosisD"
        Me.DosisD.HeaderText = "DOSIS"
        Me.DosisD.MinimumWidth = 8
        Me.DosisD.Name = "DosisD"
        Me.DosisD.ReadOnly = True
        Me.DosisD.Width = 150
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(400, 620)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 44)
        Me.Button1.TabIndex = 75
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(519, 620)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(113, 44)
        Me.Button3.TabIndex = 78
        Me.Button3.Text = "Imprimir"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'receta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 716)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PanelBD)
        Me.Controls.Add(Me.modificarBT)
        Me.Controls.Add(Me.PanelDatos)
        Me.Controls.Add(Me.nuevoBT)
        Me.Controls.Add(Me.eliminarBT)
        Me.Name = "receta"
        Me.Text = "receta"
        Me.PanelDatos.ResumeLayout(False)
        Me.PanelDatos.PerformLayout()
        Me.PanelBD.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents eliminarBT As Button
    Friend WithEvents nuevoBT As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PanelDatos As Panel
    Friend WithEvents modificarBT As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PanelBD As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents IdDreceta As DataGridViewTextBoxColumn
    Friend WithEvents Idreceta As DataGridViewTextBoxColumn
    Friend WithEvents Nreceta As DataGridViewTextBoxColumn
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents DosisD As DataGridViewTextBoxColumn
    Friend WithEvents Button3 As Button
End Class
