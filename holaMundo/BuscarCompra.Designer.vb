<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarCompra
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
        Me.IdCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdPersonal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdTfactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.forma = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Idproveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nfactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cancelar
        '
        Me.cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cancelar.Location = New System.Drawing.Point(557, 561)
        Me.cancelar.Name = "cancelar"
        Me.cancelar.Size = New System.Drawing.Size(190, 35)
        Me.cancelar.TabIndex = 25
        Me.cancelar.Text = "Cancelar"
        Me.cancelar.UseVisualStyleBackColor = True
        '
        'seleccionar
        '
        Me.seleccionar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.seleccionar.Location = New System.Drawing.Point(775, 561)
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCompra, Me.nombre, Me.IdPersonal, Me.IdTfactura, Me.tipo, Me.IdPago, Me.forma, Me.Idproveedor, Me.nombre2, Me.Nfactura, Me.fecha})
        Me.DataGridView1.Location = New System.Drawing.Point(45, 166)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(964, 374)
        Me.DataGridView1.TabIndex = 23
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(140, 111)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(501, 26)
        Me.TextBox1.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(359, 475)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 20)
        Me.Label2.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 20)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "FILTRAR:"
        '
        'IdCompra
        '
        Me.IdCompra.DataPropertyName = "IdCompra"
        Me.IdCompra.HeaderText = "ID"
        Me.IdCompra.MinimumWidth = 8
        Me.IdCompra.Name = "IdCompra"
        Me.IdCompra.ReadOnly = True
        Me.IdCompra.Visible = False
        Me.IdCompra.Width = 150
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "FACTURA HECHA POR"
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
        'IdTfactura
        '
        Me.IdTfactura.DataPropertyName = "IdTfactura"
        Me.IdTfactura.HeaderText = "IDTFACTURA"
        Me.IdTfactura.MinimumWidth = 8
        Me.IdTfactura.Name = "IdTfactura"
        Me.IdTfactura.ReadOnly = True
        Me.IdTfactura.Visible = False
        Me.IdTfactura.Width = 150
        '
        'tipo
        '
        Me.tipo.DataPropertyName = "tipo"
        Me.tipo.HeaderText = "TIPO DE FACTURA"
        Me.tipo.MinimumWidth = 8
        Me.tipo.Name = "tipo"
        Me.tipo.ReadOnly = True
        Me.tipo.Width = 150
        '
        'IdPago
        '
        Me.IdPago.DataPropertyName = "IdPago"
        Me.IdPago.HeaderText = "IDPAGO"
        Me.IdPago.MinimumWidth = 8
        Me.IdPago.Name = "IdPago"
        Me.IdPago.ReadOnly = True
        Me.IdPago.Visible = False
        Me.IdPago.Width = 150
        '
        'forma
        '
        Me.forma.DataPropertyName = "forma"
        Me.forma.HeaderText = "FORMA DE PAGO "
        Me.forma.MinimumWidth = 8
        Me.forma.Name = "forma"
        Me.forma.ReadOnly = True
        Me.forma.Width = 150
        '
        'Idproveedor
        '
        Me.Idproveedor.DataPropertyName = "Idproveedor"
        Me.Idproveedor.HeaderText = "IDPROVEEDOR"
        Me.Idproveedor.MinimumWidth = 8
        Me.Idproveedor.Name = "Idproveedor"
        Me.Idproveedor.ReadOnly = True
        Me.Idproveedor.Visible = False
        Me.Idproveedor.Width = 150
        '
        'nombre2
        '
        Me.nombre2.DataPropertyName = "nombre1"
        Me.nombre2.HeaderText = "PROVEEDOR"
        Me.nombre2.MinimumWidth = 8
        Me.nombre2.Name = "nombre2"
        Me.nombre2.ReadOnly = True
        Me.nombre2.Width = 150
        '
        'Nfactura
        '
        Me.Nfactura.DataPropertyName = "Nfactura"
        Me.Nfactura.HeaderText = "Nº FACTURA"
        Me.Nfactura.MinimumWidth = 8
        Me.Nfactura.Name = "Nfactura"
        Me.Nfactura.ReadOnly = True
        Me.Nfactura.Width = 150
        '
        'fecha
        '
        Me.fecha.DataPropertyName = "fecha"
        Me.fecha.HeaderText = "FECHA"
        Me.fecha.MinimumWidth = 8
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        Me.fecha.Width = 150
        '
        'BuscarCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1048, 706)
        Me.Controls.Add(Me.cancelar)
        Me.Controls.Add(Me.seleccionar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "BuscarCompra"
        Me.Text = "BuscarCompra"
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
    Friend WithEvents IdCompra As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents IdPersonal As DataGridViewTextBoxColumn
    Friend WithEvents IdTfactura As DataGridViewTextBoxColumn
    Friend WithEvents tipo As DataGridViewTextBoxColumn
    Friend WithEvents IdPago As DataGridViewTextBoxColumn
    Friend WithEvents forma As DataGridViewTextBoxColumn
    Friend WithEvents Idproveedor As DataGridViewTextBoxColumn
    Friend WithEvents nombre2 As DataGridViewTextBoxColumn
    Friend WithEvents Nfactura As DataGridViewTextBoxColumn
    Friend WithEvents fecha As DataGridViewTextBoxColumn
End Class
