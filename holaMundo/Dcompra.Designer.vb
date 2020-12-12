<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dcompra
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
        Me.finalizarBtn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.modificarBT = New System.Windows.Forms.Button()
        Me.nuevoBT = New System.Windows.Forms.Button()
        Me.eliminarBT = New System.Windows.Forms.Button()
        Me.PanelDatos = New System.Windows.Forms.Panel()
        Me.IdVentaLbl = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.PanelBuscarDiag = New System.Windows.Forms.Panel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PanelBD = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDcompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nfactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelDatos.SuspendLayout()
        Me.PanelBD.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'finalizarBtn
        '
        Me.finalizarBtn.Location = New System.Drawing.Point(477, 453)
        Me.finalizarBtn.Name = "finalizarBtn"
        Me.finalizarBtn.Size = New System.Drawing.Size(113, 44)
        Me.finalizarBtn.TabIndex = 75
        Me.finalizarBtn.Text = "Finalizar"
        Me.finalizarBtn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(358, 453)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 44)
        Me.Button1.TabIndex = 74
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'modificarBT
        '
        Me.modificarBT.Location = New System.Drawing.Point(120, 453)
        Me.modificarBT.Name = "modificarBT"
        Me.modificarBT.Size = New System.Drawing.Size(113, 44)
        Me.modificarBT.TabIndex = 73
        Me.modificarBT.Text = "Modificar"
        Me.modificarBT.UseVisualStyleBackColor = True
        '
        'nuevoBT
        '
        Me.nuevoBT.Location = New System.Drawing.Point(1, 453)
        Me.nuevoBT.Name = "nuevoBT"
        Me.nuevoBT.Size = New System.Drawing.Size(113, 44)
        Me.nuevoBT.TabIndex = 72
        Me.nuevoBT.Text = "Nuevo"
        Me.nuevoBT.UseVisualStyleBackColor = True
        '
        'eliminarBT
        '
        Me.eliminarBT.Location = New System.Drawing.Point(239, 453)
        Me.eliminarBT.Name = "eliminarBT"
        Me.eliminarBT.Size = New System.Drawing.Size(113, 44)
        Me.eliminarBT.TabIndex = 71
        Me.eliminarBT.Text = "Eliminar"
        Me.eliminarBT.UseVisualStyleBackColor = True
        '
        'PanelDatos
        '
        Me.PanelDatos.Controls.Add(Me.IdVentaLbl)
        Me.PanelDatos.Controls.Add(Me.TextBox3)
        Me.PanelDatos.Controls.Add(Me.Label8)
        Me.PanelDatos.Controls.Add(Me.Label6)
        Me.PanelDatos.Controls.Add(Me.Label5)
        Me.PanelDatos.Controls.Add(Me.TextBox1)
        Me.PanelDatos.Controls.Add(Me.ComboBox2)
        Me.PanelDatos.Controls.Add(Me.PanelBuscarDiag)
        Me.PanelDatos.Controls.Add(Me.TextBox2)
        Me.PanelDatos.Controls.Add(Me.Label3)
        Me.PanelDatos.Location = New System.Drawing.Point(12, 12)
        Me.PanelDatos.Name = "PanelDatos"
        Me.PanelDatos.Size = New System.Drawing.Size(578, 416)
        Me.PanelDatos.TabIndex = 70
        '
        'IdVentaLbl
        '
        Me.IdVentaLbl.AutoSize = True
        Me.IdVentaLbl.Location = New System.Drawing.Point(113, 21)
        Me.IdVentaLbl.Name = "IdVentaLbl"
        Me.IdVentaLbl.Size = New System.Drawing.Size(21, 20)
        Me.IdVentaLbl.TabIndex = 29
        Me.IdVentaLbl.Text = "id"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(337, 155)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(187, 26)
        Me.TextBox3.TabIndex = 28
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(113, 126)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 20)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "CANTIDAD"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(113, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 20)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "PRECIO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(113, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 20)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "MEDIAMENTO"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(337, 54)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(187, 26)
        Me.TextBox1.TabIndex = 16
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(337, 86)
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
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(337, 120)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(187, 26)
        Me.TextBox2.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(113, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "FACTURA Nº:"
        '
        'PanelBD
        '
        Me.PanelBD.Controls.Add(Me.DataGridView1)
        Me.PanelBD.Location = New System.Drawing.Point(607, 12)
        Me.PanelBD.Name = "PanelBD"
        Me.PanelBD.Size = New System.Drawing.Size(642, 523)
        Me.PanelBD.TabIndex = 69
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDcompra, Me.IdCompra, Me.Nfactura, Me.Id, Me.nombre, Me.cantidad, Me.precio})
        Me.DataGridView1.Location = New System.Drawing.Point(15, 21)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(612, 464)
        Me.DataGridView1.TabIndex = 46
        '
        'IdDcompra
        '
        Me.IdDcompra.DataPropertyName = "IdDcompra"
        Me.IdDcompra.HeaderText = "IDDCOMPRA"
        Me.IdDcompra.MinimumWidth = 8
        Me.IdDcompra.Name = "IdDcompra"
        Me.IdDcompra.ReadOnly = True
        Me.IdDcompra.Visible = False
        Me.IdDcompra.Width = 150
        '
        'IdCompra
        '
        Me.IdCompra.DataPropertyName = "IdCompra"
        Me.IdCompra.HeaderText = "IDVENTAS"
        Me.IdCompra.MinimumWidth = 8
        Me.IdCompra.Name = "IdCompra"
        Me.IdCompra.ReadOnly = True
        Me.IdCompra.Visible = False
        Me.IdCompra.Width = 150
        '
        'Nfactura
        '
        Me.Nfactura.DataPropertyName = "Nfactura"
        Me.Nfactura.HeaderText = "NFACTURA"
        Me.Nfactura.MinimumWidth = 8
        Me.Nfactura.Name = "Nfactura"
        Me.Nfactura.ReadOnly = True
        Me.Nfactura.Width = 150
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
        Me.cantidad.DataPropertyName = "cantidad"
        Me.cantidad.HeaderText = "CANTIDAD"
        Me.cantidad.MinimumWidth = 8
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        Me.cantidad.Width = 150
        '
        'precio
        '
        Me.precio.DataPropertyName = "precio"
        Me.precio.HeaderText = "PRECIO"
        Me.precio.MinimumWidth = 8
        Me.precio.Name = "precio"
        Me.precio.ReadOnly = True
        Me.precio.Width = 150
        '
        'Dcompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1252, 544)
        Me.Controls.Add(Me.finalizarBtn)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.modificarBT)
        Me.Controls.Add(Me.nuevoBT)
        Me.Controls.Add(Me.eliminarBT)
        Me.Controls.Add(Me.PanelDatos)
        Me.Controls.Add(Me.PanelBD)
        Me.Name = "Dcompra"
        Me.Text = "Dcompra"
        Me.PanelDatos.ResumeLayout(False)
        Me.PanelDatos.PerformLayout()
        Me.PanelBD.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents finalizarBtn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents modificarBT As Button
    Friend WithEvents nuevoBT As Button
    Friend WithEvents eliminarBT As Button
    Friend WithEvents PanelDatos As Panel
    Friend WithEvents IdVentaLbl As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents PanelBuscarDiag As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PanelBD As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents IdDcompra As DataGridViewTextBoxColumn
    Friend WithEvents IdCompra As DataGridViewTextBoxColumn
    Friend WithEvents Nfactura As DataGridViewTextBoxColumn
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents precio As DataGridViewTextBoxColumn
End Class
