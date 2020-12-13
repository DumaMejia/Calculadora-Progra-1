<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class expediente
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
        Me.PanelBD = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PanelDatos = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.PanelBuscarDiag = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.modificarBT = New System.Windows.Forms.Button()
        Me.nuevoBT = New System.Windows.Forms.Button()
        Me.eliminarBT = New System.Windows.Forms.Button()
        Me.IdExpediente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Idedad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.peso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Idalergia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaRe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.edad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelBD.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelBD
        '
        Me.PanelBD.Controls.Add(Me.DataGridView1)
        Me.PanelBD.Controls.Add(Me.TextBox3)
        Me.PanelBD.Controls.Add(Me.Label4)
        Me.PanelBD.Location = New System.Drawing.Point(620, 98)
        Me.PanelBD.Name = "PanelBD"
        Me.PanelBD.Size = New System.Drawing.Size(608, 523)
        Me.PanelBD.TabIndex = 58
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdExpediente, Me.nombre, Me.apellido, Me.Idedad, Me.peso, Me.Idalergia, Me.fechaRe, Me.edad, Me.nombreA})
        Me.DataGridView1.Location = New System.Drawing.Point(46, 116)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(529, 375)
        Me.DataGridView1.TabIndex = 45
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(140, 57)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(391, 26)
        Me.TextBox3.TabIndex = 44
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 20)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "BUSCAR:"
        '
        'PanelDatos
        '
        Me.PanelDatos.Controls.Add(Me.Label9)
        Me.PanelDatos.Controls.Add(Me.TextBox5)
        Me.PanelDatos.Controls.Add(Me.TextBox4)
        Me.PanelDatos.Controls.Add(Me.Label8)
        Me.PanelDatos.Controls.Add(Me.Label7)
        Me.PanelDatos.Controls.Add(Me.Label6)
        Me.PanelDatos.Controls.Add(Me.Label5)
        Me.PanelDatos.Controls.Add(Me.TextBox1)
        Me.PanelDatos.Controls.Add(Me.ComboBox2)
        Me.PanelDatos.Controls.Add(Me.PanelBuscarDiag)
        Me.PanelDatos.Controls.Add(Me.ComboBox1)
        Me.PanelDatos.Controls.Add(Me.TextBox2)
        Me.PanelDatos.Controls.Add(Me.Label3)
        Me.PanelDatos.Location = New System.Drawing.Point(22, 98)
        Me.PanelDatos.Name = "PanelDatos"
        Me.PanelDatos.Size = New System.Drawing.Size(592, 416)
        Me.PanelDatos.TabIndex = 57
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 309)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(180, 20)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "FECHA DE REGISTRO"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(221, 303)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(187, 26)
        Me.TextBox5.TabIndex = 29
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(221, 187)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(187, 26)
        Me.TextBox4.TabIndex = 28
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(25, 129)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 20)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "EDAD"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 249)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 20)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "ALERGIA"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 193)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 20)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "PESO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 20)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "APELLIDO"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(221, 20)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(187, 26)
        Me.TextBox1.TabIndex = 16
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(221, 241)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(187, 28)
        Me.ComboBox2.TabIndex = 20
        '
        'PanelBuscarDiag
        '
        Me.PanelBuscarDiag.Location = New System.Drawing.Point(595, -9)
        Me.PanelBuscarDiag.Name = "PanelBuscarDiag"
        Me.PanelBuscarDiag.Size = New System.Drawing.Size(581, 620)
        Me.PanelBuscarDiag.TabIndex = 19
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(221, 116)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(187, 28)
        Me.ComboBox1.TabIndex = 18
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(221, 63)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(187, 26)
        Me.TextBox2.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "NOMBRE"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(467, 545)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 44)
        Me.Button1.TabIndex = 56
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'modificarBT
        '
        Me.modificarBT.Location = New System.Drawing.Point(159, 545)
        Me.modificarBT.Name = "modificarBT"
        Me.modificarBT.Size = New System.Drawing.Size(113, 44)
        Me.modificarBT.TabIndex = 55
        Me.modificarBT.Text = "Modificar"
        Me.modificarBT.UseVisualStyleBackColor = True
        '
        'nuevoBT
        '
        Me.nuevoBT.Location = New System.Drawing.Point(26, 545)
        Me.nuevoBT.Name = "nuevoBT"
        Me.nuevoBT.Size = New System.Drawing.Size(113, 44)
        Me.nuevoBT.TabIndex = 54
        Me.nuevoBT.Text = "Nuevo"
        Me.nuevoBT.UseVisualStyleBackColor = True
        '
        'eliminarBT
        '
        Me.eliminarBT.Location = New System.Drawing.Point(305, 545)
        Me.eliminarBT.Name = "eliminarBT"
        Me.eliminarBT.Size = New System.Drawing.Size(113, 44)
        Me.eliminarBT.TabIndex = 53
        Me.eliminarBT.Text = "Eliminar"
        Me.eliminarBT.UseVisualStyleBackColor = True
        '
        'IdExpediente
        '
        Me.IdExpediente.DataPropertyName = "IdExpediente"
        Me.IdExpediente.HeaderText = "IDEXPEDIENTE"
        Me.IdExpediente.MinimumWidth = 8
        Me.IdExpediente.Name = "IdExpediente"
        Me.IdExpediente.ReadOnly = True
        Me.IdExpediente.Visible = False
        Me.IdExpediente.Width = 150
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "NOMBRE"
        Me.nombre.MinimumWidth = 8
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 150
        '
        'apellido
        '
        Me.apellido.DataPropertyName = "apellido"
        Me.apellido.HeaderText = "APELLIDO"
        Me.apellido.MinimumWidth = 8
        Me.apellido.Name = "apellido"
        Me.apellido.ReadOnly = True
        Me.apellido.Width = 150
        '
        'Idedad
        '
        Me.Idedad.DataPropertyName = "Idedad"
        Me.Idedad.HeaderText = "IDEDAD"
        Me.Idedad.MinimumWidth = 8
        Me.Idedad.Name = "Idedad"
        Me.Idedad.ReadOnly = True
        Me.Idedad.Visible = False
        Me.Idedad.Width = 150
        '
        'peso
        '
        Me.peso.DataPropertyName = "peso"
        Me.peso.HeaderText = "PESO"
        Me.peso.MinimumWidth = 8
        Me.peso.Name = "peso"
        Me.peso.ReadOnly = True
        Me.peso.Width = 150
        '
        'Idalergia
        '
        Me.Idalergia.DataPropertyName = "Idalergia"
        Me.Idalergia.HeaderText = "IDALERGIA"
        Me.Idalergia.MinimumWidth = 8
        Me.Idalergia.Name = "Idalergia"
        Me.Idalergia.ReadOnly = True
        Me.Idalergia.Visible = False
        Me.Idalergia.Width = 150
        '
        'fechaRe
        '
        Me.fechaRe.DataPropertyName = "fechaRe"
        Me.fechaRe.FillWeight = 200.0!
        Me.fechaRe.HeaderText = "FECHA"
        Me.fechaRe.MinimumWidth = 8
        Me.fechaRe.Name = "fechaRe"
        Me.fechaRe.ReadOnly = True
        Me.fechaRe.Width = 150
        '
        'edad
        '
        Me.edad.DataPropertyName = "edad"
        Me.edad.HeaderText = "EDAD"
        Me.edad.MinimumWidth = 8
        Me.edad.Name = "edad"
        Me.edad.ReadOnly = True
        Me.edad.Width = 150
        '
        'nombreA
        '
        Me.nombreA.DataPropertyName = "nombre1"
        Me.nombreA.HeaderText = "NOMBREALERGIA"
        Me.nombreA.MinimumWidth = 8
        Me.nombreA.Name = "nombreA"
        Me.nombreA.ReadOnly = True
        Me.nombreA.Width = 150
        '
        'expediente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1251, 678)
        Me.Controls.Add(Me.PanelBD)
        Me.Controls.Add(Me.PanelDatos)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.modificarBT)
        Me.Controls.Add(Me.nuevoBT)
        Me.Controls.Add(Me.eliminarBT)
        Me.Name = "expediente"
        Me.Text = "expediente"
        Me.PanelBD.ResumeLayout(False)
        Me.PanelBD.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDatos.ResumeLayout(False)
        Me.PanelDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelBD As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PanelDatos As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents PanelBuscarDiag As Panel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents modificarBT As Button
    Friend WithEvents nuevoBT As Button
    Friend WithEvents eliminarBT As Button
    Friend WithEvents IdExpediente As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents apellido As DataGridViewTextBoxColumn
    Friend WithEvents Idedad As DataGridViewTextBoxColumn
    Friend WithEvents peso As DataGridViewTextBoxColumn
    Friend WithEvents Idalergia As DataGridViewTextBoxColumn
    Friend WithEvents fechaRe As DataGridViewTextBoxColumn
    Friend WithEvents edad As DataGridViewTextBoxColumn
    Friend WithEvents nombreA As DataGridViewTextBoxColumn
End Class
