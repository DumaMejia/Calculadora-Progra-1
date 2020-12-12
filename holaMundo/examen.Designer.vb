<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class examen
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
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PanelBuscarDiag = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.modificarBT = New System.Windows.Forms.Button()
        Me.nuevoBT = New System.Windows.Forms.Button()
        Me.eliminarBT = New System.Windows.Forms.Button()
        Me.Idexamen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdPersonal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Idhab = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.habitacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.PanelBD.Location = New System.Drawing.Point(610, 21)
        Me.PanelBD.Name = "PanelBD"
        Me.PanelBD.Size = New System.Drawing.Size(608, 357)
        Me.PanelBD.TabIndex = 58
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Idexamen, Me.IdPersonal, Me.Idhab, Me.nombre, Me.habitacion, Me.Tipo, Me.descripcion})
        Me.DataGridView1.Location = New System.Drawing.Point(46, 116)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(529, 216)
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
        Me.PanelDatos.Controls.Add(Me.ComboBox2)
        Me.PanelDatos.Controls.Add(Me.Label5)
        Me.PanelDatos.Controls.Add(Me.PanelBuscarDiag)
        Me.PanelDatos.Controls.Add(Me.ComboBox1)
        Me.PanelDatos.Controls.Add(Me.TextBox2)
        Me.PanelDatos.Controls.Add(Me.TextBox1)
        Me.PanelDatos.Controls.Add(Me.Label3)
        Me.PanelDatos.Controls.Add(Me.Label2)
        Me.PanelDatos.Controls.Add(Me.Label1)
        Me.PanelDatos.Location = New System.Drawing.Point(12, 21)
        Me.PanelDatos.Name = "PanelDatos"
        Me.PanelDatos.Size = New System.Drawing.Size(592, 250)
        Me.PanelDatos.TabIndex = 57
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(324, 48)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(187, 28)
        Me.ComboBox2.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(99, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 20)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "ENCARGADO:"
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
        Me.ComboBox1.Location = New System.Drawing.Point(324, 14)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(187, 28)
        Me.ComboBox1.TabIndex = 18
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(324, 114)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(187, 105)
        Me.TextBox2.TabIndex = 17
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(324, 82)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(187, 26)
        Me.TextBox1.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(99, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "DESCRIPCION:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(99, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "EXAMEN:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(99, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "CONSULTORIO:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(457, 302)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 44)
        Me.Button1.TabIndex = 56
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'modificarBT
        '
        Me.modificarBT.Location = New System.Drawing.Point(149, 302)
        Me.modificarBT.Name = "modificarBT"
        Me.modificarBT.Size = New System.Drawing.Size(113, 44)
        Me.modificarBT.TabIndex = 55
        Me.modificarBT.Text = "Modificar"
        Me.modificarBT.UseVisualStyleBackColor = True
        '
        'nuevoBT
        '
        Me.nuevoBT.Location = New System.Drawing.Point(16, 302)
        Me.nuevoBT.Name = "nuevoBT"
        Me.nuevoBT.Size = New System.Drawing.Size(113, 44)
        Me.nuevoBT.TabIndex = 54
        Me.nuevoBT.Text = "Nuevo"
        Me.nuevoBT.UseVisualStyleBackColor = True
        '
        'eliminarBT
        '
        Me.eliminarBT.Location = New System.Drawing.Point(295, 302)
        Me.eliminarBT.Name = "eliminarBT"
        Me.eliminarBT.Size = New System.Drawing.Size(113, 44)
        Me.eliminarBT.TabIndex = 53
        Me.eliminarBT.Text = "Eliminar"
        Me.eliminarBT.UseVisualStyleBackColor = True
        '
        'Idexamen
        '
        Me.Idexamen.DataPropertyName = "Idexamen"
        Me.Idexamen.HeaderText = "IDEXAMEN"
        Me.Idexamen.MinimumWidth = 8
        Me.Idexamen.Name = "Idexamen"
        Me.Idexamen.ReadOnly = True
        Me.Idexamen.Visible = False
        Me.Idexamen.Width = 150
        '
        'IdPersonal
        '
        Me.IdPersonal.DataPropertyName = "IdPersonal"
        Me.IdPersonal.HeaderText = "IDPERSONAL"
        Me.IdPersonal.MinimumWidth = 8
        Me.IdPersonal.Name = "IdPersonal"
        Me.IdPersonal.ReadOnly = True
        Me.IdPersonal.Visible = False
        Me.IdPersonal.Width = 150
        '
        'Idhab
        '
        Me.Idhab.DataPropertyName = "Idhab"
        Me.Idhab.HeaderText = "IDHAB"
        Me.Idhab.MinimumWidth = 8
        Me.Idhab.Name = "Idhab"
        Me.Idhab.ReadOnly = True
        Me.Idhab.Visible = False
        Me.Idhab.Width = 150
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.FillWeight = 200.0!
        Me.nombre.HeaderText = "ENCARGADO"
        Me.nombre.MinimumWidth = 8
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 150
        '
        'habitacion
        '
        Me.habitacion.DataPropertyName = "habitacion"
        Me.habitacion.HeaderText = "CONSULTORIO"
        Me.habitacion.MinimumWidth = 8
        Me.habitacion.Name = "habitacion"
        Me.habitacion.ReadOnly = True
        Me.habitacion.Width = 150
        '
        'Tipo
        '
        Me.Tipo.DataPropertyName = "Tipo"
        Me.Tipo.HeaderText = "TIPO"
        Me.Tipo.MinimumWidth = 8
        Me.Tipo.Name = "Tipo"
        Me.Tipo.ReadOnly = True
        Me.Tipo.Width = 150
        '
        'descripcion
        '
        Me.descripcion.DataPropertyName = "descripcion"
        Me.descripcion.HeaderText = "DESCRIPCION"
        Me.descripcion.MinimumWidth = 8
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        Me.descripcion.Width = 150
        '
        'examen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1258, 397)
        Me.Controls.Add(Me.PanelBD)
        Me.Controls.Add(Me.PanelDatos)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.modificarBT)
        Me.Controls.Add(Me.nuevoBT)
        Me.Controls.Add(Me.eliminarBT)
        Me.Name = "examen"
        Me.Text = "examen"
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
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PanelBuscarDiag As Panel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents modificarBT As Button
    Friend WithEvents nuevoBT As Button
    Friend WithEvents eliminarBT As Button
    Friend WithEvents Idexamen As DataGridViewTextBoxColumn
    Friend WithEvents IdPersonal As DataGridViewTextBoxColumn
    Friend WithEvents Idhab As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents habitacion As DataGridViewTextBoxColumn
    Friend WithEvents Tipo As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
End Class
