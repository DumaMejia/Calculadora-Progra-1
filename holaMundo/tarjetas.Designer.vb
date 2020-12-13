<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tarjetas
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PanelBuscarDiag = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.modificarBT = New System.Windows.Forms.Button()
        Me.nuevoBT = New System.Windows.Forms.Button()
        Me.eliminarBT = New System.Windows.Forms.Button()
        Me.Idtarjeta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdPersonal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Idacceso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ntarjeta = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.PanelBD.Location = New System.Drawing.Point(634, 34)
        Me.PanelBD.Name = "PanelBD"
        Me.PanelBD.Size = New System.Drawing.Size(598, 409)
        Me.PanelBD.TabIndex = 64
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Idtarjeta, Me.IdPersonal, Me.Idacceso, Me.nombre, Me.tipo, Me.Ntarjeta})
        Me.DataGridView1.Location = New System.Drawing.Point(46, 117)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(528, 265)
        Me.DataGridView1.TabIndex = 45
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(136, 58)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(441, 26)
        Me.TextBox3.TabIndex = 44
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 20)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "BUSCAR:"
        '
        'PanelDatos
        '
        Me.PanelDatos.Controls.Add(Me.ComboBox2)
        Me.PanelDatos.Controls.Add(Me.ComboBox1)
        Me.PanelDatos.Controls.Add(Me.TextBox1)
        Me.PanelDatos.Controls.Add(Me.PanelBuscarDiag)
        Me.PanelDatos.Controls.Add(Me.Label3)
        Me.PanelDatos.Controls.Add(Me.Label2)
        Me.PanelDatos.Controls.Add(Me.Label1)
        Me.PanelDatos.Location = New System.Drawing.Point(35, 34)
        Me.PanelDatos.Name = "PanelDatos"
        Me.PanelDatos.Size = New System.Drawing.Size(591, 332)
        Me.PanelDatos.TabIndex = 63
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(270, 231)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(240, 28)
        Me.ComboBox2.TabIndex = 22
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(270, 46)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(240, 28)
        Me.ComboBox1.TabIndex = 21
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(270, 143)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(240, 26)
        Me.TextBox1.TabIndex = 20
        '
        'PanelBuscarDiag
        '
        Me.PanelBuscarDiag.Location = New System.Drawing.Point(596, -9)
        Me.PanelBuscarDiag.Name = "PanelBuscarDiag"
        Me.PanelBuscarDiag.Size = New System.Drawing.Size(580, 620)
        Me.PanelBuscarDiag.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(67, 248)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "NIVEL DE ACCESO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(182, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "NUMERO DE TARJETA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "PERSONAL MEDICO"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(487, 372)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 43)
        Me.Button1.TabIndex = 62
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'modificarBT
        '
        Me.modificarBT.Location = New System.Drawing.Point(172, 372)
        Me.modificarBT.Name = "modificarBT"
        Me.modificarBT.Size = New System.Drawing.Size(112, 43)
        Me.modificarBT.TabIndex = 61
        Me.modificarBT.Text = "Modificar"
        Me.modificarBT.UseVisualStyleBackColor = True
        '
        'nuevoBT
        '
        Me.nuevoBT.Location = New System.Drawing.Point(35, 372)
        Me.nuevoBT.Name = "nuevoBT"
        Me.nuevoBT.Size = New System.Drawing.Size(112, 43)
        Me.nuevoBT.TabIndex = 60
        Me.nuevoBT.Text = "Nuevo"
        Me.nuevoBT.UseVisualStyleBackColor = True
        '
        'eliminarBT
        '
        Me.eliminarBT.Location = New System.Drawing.Point(328, 372)
        Me.eliminarBT.Name = "eliminarBT"
        Me.eliminarBT.Size = New System.Drawing.Size(112, 43)
        Me.eliminarBT.TabIndex = 59
        Me.eliminarBT.Text = "Eliminar"
        Me.eliminarBT.UseVisualStyleBackColor = True
        '
        'Idtarjeta
        '
        Me.Idtarjeta.DataPropertyName = "Idtarjeta"
        Me.Idtarjeta.HeaderText = "IDTARJETA"
        Me.Idtarjeta.MinimumWidth = 8
        Me.Idtarjeta.Name = "Idtarjeta"
        Me.Idtarjeta.ReadOnly = True
        Me.Idtarjeta.Visible = False
        Me.Idtarjeta.Width = 150
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
        'Idacceso
        '
        Me.Idacceso.DataPropertyName = "Idacceso"
        Me.Idacceso.HeaderText = "IDACCESO"
        Me.Idacceso.MinimumWidth = 8
        Me.Idacceso.Name = "Idacceso"
        Me.Idacceso.ReadOnly = True
        Me.Idacceso.Visible = False
        Me.Idacceso.Width = 150
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
        'tipo
        '
        Me.tipo.DataPropertyName = "tipo"
        Me.tipo.HeaderText = "TIPO DE ACCESO"
        Me.tipo.MinimumWidth = 8
        Me.tipo.Name = "tipo"
        Me.tipo.ReadOnly = True
        Me.tipo.Width = 150
        '
        'Ntarjeta
        '
        Me.Ntarjeta.DataPropertyName = "Ntarjeta"
        Me.Ntarjeta.HeaderText = "Nº DE TARJETA"
        Me.Ntarjeta.MinimumWidth = 8
        Me.Ntarjeta.Name = "Ntarjeta"
        Me.Ntarjeta.ReadOnly = True
        Me.Ntarjeta.Width = 150
        '
        'tarjetas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1247, 476)
        Me.Controls.Add(Me.PanelBD)
        Me.Controls.Add(Me.PanelDatos)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.modificarBT)
        Me.Controls.Add(Me.nuevoBT)
        Me.Controls.Add(Me.eliminarBT)
        Me.Name = "tarjetas"
        Me.Text = "tarjetas"
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
    Friend WithEvents PanelBuscarDiag As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents modificarBT As Button
    Friend WithEvents nuevoBT As Button
    Friend WithEvents eliminarBT As Button
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Idtarjeta As DataGridViewTextBoxColumn
    Friend WithEvents IdPersonal As DataGridViewTextBoxColumn
    Friend WithEvents Idacceso As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents tipo As DataGridViewTextBoxColumn
    Friend WithEvents Ntarjeta As DataGridViewTextBoxColumn
End Class
