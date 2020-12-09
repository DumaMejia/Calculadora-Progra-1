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
        Me.IdExpediente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Idedad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.peso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Idalergia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDatos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Idfamiliar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaRe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.edad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nacimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombref = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PanelDatos = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.PanelBuscarDiag = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.modificarBT = New System.Windows.Forms.Button()
        Me.nuevoBT = New System.Windows.Forms.Button()
        Me.eliminarBT = New System.Windows.Forms.Button()
        Me.PanelD = New System.Windows.Forms.Panel()
        Me.PanelBD.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDatos.SuspendLayout()
        Me.PanelD.SuspendLayout()
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdExpediente, Me.nombre, Me.apellido, Me.Idedad, Me.peso, Me.Idalergia, Me.IdDatos, Me.Idfamiliar, Me.fechaRe, Me.edad, Me.nombreA, Me.nacimiento, Me.nombref})
        Me.DataGridView1.Location = New System.Drawing.Point(46, 116)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(529, 375)
        Me.DataGridView1.TabIndex = 45
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
        'IdDatos
        '
        Me.IdDatos.DataPropertyName = "IdDatos"
        Me.IdDatos.HeaderText = "IDDATOS"
        Me.IdDatos.MinimumWidth = 8
        Me.IdDatos.Name = "IdDatos"
        Me.IdDatos.ReadOnly = True
        Me.IdDatos.Visible = False
        Me.IdDatos.Width = 150
        '
        'Idfamiliar
        '
        Me.Idfamiliar.DataPropertyName = "Idfamiliar"
        Me.Idfamiliar.HeaderText = "IDFAMILIAR"
        Me.Idfamiliar.MinimumWidth = 8
        Me.Idfamiliar.Name = "Idfamiliar"
        Me.Idfamiliar.ReadOnly = True
        Me.Idfamiliar.Visible = False
        Me.Idfamiliar.Width = 150
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
        'nacimiento
        '
        Me.nacimiento.DataPropertyName = "nacimiento"
        Me.nacimiento.HeaderText = "DATOS NACIMIENTO"
        Me.nacimiento.MinimumWidth = 8
        Me.nacimiento.Name = "nacimiento"
        Me.nacimiento.ReadOnly = True
        Me.nacimiento.Width = 150
        '
        'nombref
        '
        Me.nombref.DataPropertyName = "nombre2"
        Me.nombref.HeaderText = "FAMILIAR"
        Me.nombref.MinimumWidth = 8
        Me.nombref.Name = "nombref"
        Me.nombref.ReadOnly = True
        Me.nombref.Width = 150
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
        Me.PanelDatos.Controls.Add(Me.PanelD)
        Me.PanelDatos.Controls.Add(Me.Button2)
        Me.PanelDatos.Controls.Add(Me.Button3)
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
        Me.PanelDatos.Controls.Add(Me.Label2)
        Me.PanelDatos.Controls.Add(Me.Label1)
        Me.PanelDatos.Location = New System.Drawing.Point(22, 98)
        Me.PanelDatos.Name = "PanelDatos"
        Me.PanelDatos.Size = New System.Drawing.Size(592, 416)
        Me.PanelDatos.TabIndex = 57
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(445, 218)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(113, 28)
        Me.Button2.TabIndex = 59
        Me.Button2.Text = "AGREGAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(445, 184)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(113, 28)
        Me.Button3.TabIndex = 60
        Me.Button3.Text = "AGREGAR"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 258)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(180, 20)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "FECHA DE REGISTRO"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(221, 252)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(187, 26)
        Me.TextBox5.TabIndex = 29
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(221, 118)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(187, 26)
        Me.TextBox4.TabIndex = 28
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 92)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 20)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "EDAD"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 158)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 20)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "ALERGIA"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 20)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "PESO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 58)
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
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(12, 36)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(187, 28)
        Me.ComboBox4.TabIndex = 22
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(12, 3)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(187, 28)
        Me.ComboBox3.TabIndex = 21
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(221, 150)
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
        Me.ComboBox1.Location = New System.Drawing.Point(221, 84)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(187, 28)
        Me.ComboBox1.TabIndex = 18
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(221, 52)
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 226)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "FAMILIAR"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "DATOS PERSONALES"
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
        'PanelD
        '
        Me.PanelD.Controls.Add(Me.ComboBox3)
        Me.PanelD.Controls.Add(Me.ComboBox4)
        Me.PanelD.Location = New System.Drawing.Point(209, 184)
        Me.PanelD.Name = "PanelD"
        Me.PanelD.Size = New System.Drawing.Size(202, 67)
        Me.PanelD.TabIndex = 61
        '
        'expediente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1251, 871)
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
        Me.PanelD.ResumeLayout(False)
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
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents PanelBuscarDiag As Panel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents modificarBT As Button
    Friend WithEvents nuevoBT As Button
    Friend WithEvents eliminarBT As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents IdExpediente As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents apellido As DataGridViewTextBoxColumn
    Friend WithEvents Idedad As DataGridViewTextBoxColumn
    Friend WithEvents peso As DataGridViewTextBoxColumn
    Friend WithEvents Idalergia As DataGridViewTextBoxColumn
    Friend WithEvents IdDatos As DataGridViewTextBoxColumn
    Friend WithEvents Idfamiliar As DataGridViewTextBoxColumn
    Friend WithEvents fechaRe As DataGridViewTextBoxColumn
    Friend WithEvents edad As DataGridViewTextBoxColumn
    Friend WithEvents nombreA As DataGridViewTextBoxColumn
    Friend WithEvents nacimiento As DataGridViewTextBoxColumn
    Friend WithEvents nombref As DataGridViewTextBoxColumn
    Friend WithEvents PanelD As Panel
End Class
