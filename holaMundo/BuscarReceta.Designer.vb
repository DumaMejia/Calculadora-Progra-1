<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarReceta
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
        Me.cancelar = New System.Windows.Forms.Button()
        Me.seleccionar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Idreceta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdPersonal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdExpediente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdEnfermedad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nreceta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cancelar
        '
        Me.cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cancelar.Location = New System.Drawing.Point(277, 487)
        Me.cancelar.Name = "cancelar"
        Me.cancelar.Size = New System.Drawing.Size(190, 35)
        Me.cancelar.TabIndex = 25
        Me.cancelar.Text = "Cancelar"
        Me.cancelar.UseVisualStyleBackColor = True
        '
        'seleccionar
        '
        Me.seleccionar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.seleccionar.Location = New System.Drawing.Point(498, 487)
        Me.seleccionar.Name = "seleccionar"
        Me.seleccionar.Size = New System.Drawing.Size(190, 35)
        Me.seleccionar.TabIndex = 24
        Me.seleccionar.Text = "Seleccionar "
        Me.seleccionar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Idreceta, Me.nombre, Me.IdPersonal, Me.IdExpediente, Me.nombre1, Me.IdEnfermedad, Me.nombre2, Me.Nreceta})
        Me.DataGridView1.Location = New System.Drawing.Point(23, 85)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(665, 374)
        Me.DataGridView1.TabIndex = 23
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(105, 39)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(583, 26)
        Me.TextBox1.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(324, 403)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 20)
        Me.Label2.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 20)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "FILTRAR:"
        '
        'Idreceta
        '
        Me.Idreceta.DataPropertyName = "Idreceta"
        Me.Idreceta.HeaderText = "ID"
        Me.Idreceta.MinimumWidth = 8
        Me.Idreceta.Name = "Idreceta"
        Me.Idreceta.ReadOnly = True
        Me.Idreceta.Visible = False
        Me.Idreceta.Width = 150
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "RECETA HECHA POR"
        Me.nombre.MinimumWidth = 8
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 150
        '
        'IdPersonal
        '
        Me.IdPersonal.DataPropertyName = "IdPersonal"
        Me.IdPersonal.HeaderText = "IDPERSONAL"
        Me.IdPersonal.MinimumWidth = 8
        Me.IdPersonal.Name = "IdPersonal"
        Me.IdPersonal.ReadOnly = True
        Me.IdPersonal.Visible = False
        Me.IdPersonal.Width = 250
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
        'nombre1
        '
        Me.nombre1.DataPropertyName = "nombre1"
        Me.nombre1.HeaderText = "TIPO DE FACTURA"
        Me.nombre1.MinimumWidth = 8
        Me.nombre1.Name = "nombre1"
        Me.nombre1.ReadOnly = True
        Me.nombre1.Width = 150
        '
        'IdEnfermedad
        '
        Me.IdEnfermedad.DataPropertyName = "IdEnfermedad"
        Me.IdEnfermedad.HeaderText = "IDENFERMEDAD"
        Me.IdEnfermedad.MinimumWidth = 8
        Me.IdEnfermedad.Name = "IdEnfermedad"
        Me.IdEnfermedad.ReadOnly = True
        Me.IdEnfermedad.Visible = False
        Me.IdEnfermedad.Width = 150
        '
        'nombre2
        '
        Me.nombre2.DataPropertyName = "nombre2"
        Me.nombre2.HeaderText = "PADECE:"
        Me.nombre2.MinimumWidth = 8
        Me.nombre2.Name = "nombre2"
        Me.nombre2.ReadOnly = True
        Me.nombre2.Width = 150
        '
        'Nreceta
        '
        Me.Nreceta.DataPropertyName = "Nreceta"
        Me.Nreceta.HeaderText = "RECETA Nº"
        Me.Nreceta.MinimumWidth = 8
        Me.Nreceta.Name = "Nreceta"
        Me.Nreceta.ReadOnly = True
        Me.Nreceta.Width = 150
        '
        'BuscarReceta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 563)
        Me.Controls.Add(Me.cancelar)
        Me.Controls.Add(Me.seleccionar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "BuscarReceta"
        Me.Text = "BuscarReceta"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cancelar As Button
    Friend WithEvents seleccionar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Idreceta As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents IdPersonal As DataGridViewTextBoxColumn
    Friend WithEvents IdExpediente As DataGridViewTextBoxColumn
    Friend WithEvents nombre1 As DataGridViewTextBoxColumn
    Friend WithEvents IdEnfermedad As DataGridViewTextBoxColumn
    Friend WithEvents nombre2 As DataGridViewTextBoxColumn
    Friend WithEvents Nreceta As DataGridViewTextBoxColumn
End Class
