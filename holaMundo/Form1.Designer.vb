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
        Me.lbltotalx21xf1 = New System.Windows.Forms.Label()
        Me.lbltotalx1xf1 = New System.Windows.Forms.Label()
        Me.lbltotalf1 = New System.Windows.Forms.Label()
        Me.grdEstadistica = New System.Windows.Forms.DataGridView()
        Me.x1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.f1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.n1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.x1xf1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.x21xf1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblRespuestaDesvTipica = New System.Windows.Forms.Label()
        Me.lbldesvtipica = New System.Windows.Forms.Label()
        Me.lblVarianza = New System.Windows.Forms.Label()
        Me.lblMedia = New System.Windows.Forms.Label()
        Me.lblRespuestaVarianza = New System.Windows.Forms.Label()
        Me.lblRespuestaMedia = New System.Windows.Forms.Label()
        Me.lblserie = New System.Windows.Forms.Label()
        Me.txtserie = New System.Windows.Forms.TextBox()
        Me.btnMediaAritmetica = New System.Windows.Forms.Button()
        CType(Me.grdEstadistica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbltotalx21xf1
        '
        Me.lbltotalx21xf1.AutoSize = True
        Me.lbltotalx21xf1.Location = New System.Drawing.Point(1175, 657)
        Me.lbltotalx21xf1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltotalx21xf1.Name = "lbltotalx21xf1"
        Me.lbltotalx21xf1.Size = New System.Drawing.Size(31, 20)
        Me.lbltotalx21xf1.TabIndex = 25
        Me.lbltotalx21xf1.Text = "0.0"
        '
        'lbltotalx1xf1
        '
        Me.lbltotalx1xf1.AutoSize = True
        Me.lbltotalx1xf1.Location = New System.Drawing.Point(1025, 657)
        Me.lbltotalx1xf1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltotalx1xf1.Name = "lbltotalx1xf1"
        Me.lbltotalx1xf1.Size = New System.Drawing.Size(31, 20)
        Me.lbltotalx1xf1.TabIndex = 24
        Me.lbltotalx1xf1.Text = "0.0"
        '
        'lbltotalf1
        '
        Me.lbltotalf1.AutoSize = True
        Me.lbltotalf1.Location = New System.Drawing.Point(716, 657)
        Me.lbltotalf1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltotalf1.Name = "lbltotalf1"
        Me.lbltotalf1.Size = New System.Drawing.Size(31, 20)
        Me.lbltotalf1.TabIndex = 23
        Me.lbltotalf1.Text = "0.0"
        '
        'grdEstadistica
        '
        Me.grdEstadistica.AllowUserToDeleteRows = False
        Me.grdEstadistica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdEstadistica.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.x1, Me.f1, Me.n1, Me.x1xf1, Me.x21xf1})
        Me.grdEstadistica.Location = New System.Drawing.Point(408, 36)
        Me.grdEstadistica.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grdEstadistica.Name = "grdEstadistica"
        Me.grdEstadistica.RowHeadersWidth = 62
        Me.grdEstadistica.Size = New System.Drawing.Size(814, 605)
        Me.grdEstadistica.TabIndex = 22
        '
        'x1
        '
        Me.x1.HeaderText = "X1"
        Me.x1.MinimumWidth = 8
        Me.x1.Name = "x1"
        Me.x1.Width = 150
        '
        'f1
        '
        Me.f1.HeaderText = "F1"
        Me.f1.MinimumWidth = 8
        Me.f1.Name = "f1"
        Me.f1.Width = 150
        '
        'n1
        '
        Me.n1.HeaderText = "N1"
        Me.n1.MinimumWidth = 8
        Me.n1.Name = "n1"
        Me.n1.Width = 150
        '
        'x1xf1
        '
        Me.x1xf1.HeaderText = "X1 x F1"
        Me.x1xf1.MinimumWidth = 8
        Me.x1xf1.Name = "x1xf1"
        Me.x1xf1.Width = 150
        '
        'x21xf1
        '
        Me.x21xf1.HeaderText = "X21 x F1"
        Me.x21xf1.MinimumWidth = 8
        Me.x21xf1.Name = "x21xf1"
        Me.x21xf1.Width = 150
        '
        'lblRespuestaDesvTipica
        '
        Me.lblRespuestaDesvTipica.AutoSize = True
        Me.lblRespuestaDesvTipica.Location = New System.Drawing.Point(166, 185)
        Me.lblRespuestaDesvTipica.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRespuestaDesvTipica.Name = "lblRespuestaDesvTipica"
        Me.lblRespuestaDesvTipica.Size = New System.Drawing.Size(18, 20)
        Me.lblRespuestaDesvTipica.TabIndex = 21
        Me.lblRespuestaDesvTipica.Text = "?"
        '
        'lbldesvtipica
        '
        Me.lbldesvtipica.AutoSize = True
        Me.lbldesvtipica.Location = New System.Drawing.Point(52, 185)
        Me.lbldesvtipica.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldesvtipica.Name = "lbldesvtipica"
        Me.lbldesvtipica.Size = New System.Drawing.Size(98, 20)
        Me.lbldesvtipica.TabIndex = 20
        Me.lbldesvtipica.Text = "Desv. Tipica:"
        '
        'lblVarianza
        '
        Me.lblVarianza.AutoSize = True
        Me.lblVarianza.Location = New System.Drawing.Point(52, 140)
        Me.lblVarianza.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVarianza.Name = "lblVarianza"
        Me.lblVarianza.Size = New System.Drawing.Size(76, 20)
        Me.lblVarianza.TabIndex = 19
        Me.lblVarianza.Text = "Varianza:"
        '
        'lblMedia
        '
        Me.lblMedia.AutoSize = True
        Me.lblMedia.Location = New System.Drawing.Point(52, 102)
        Me.lblMedia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMedia.Name = "lblMedia"
        Me.lblMedia.Size = New System.Drawing.Size(56, 20)
        Me.lblMedia.TabIndex = 18
        Me.lblMedia.Text = "Media:"
        '
        'lblRespuestaVarianza
        '
        Me.lblRespuestaVarianza.AutoSize = True
        Me.lblRespuestaVarianza.Location = New System.Drawing.Point(166, 140)
        Me.lblRespuestaVarianza.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRespuestaVarianza.Name = "lblRespuestaVarianza"
        Me.lblRespuestaVarianza.Size = New System.Drawing.Size(18, 20)
        Me.lblRespuestaVarianza.TabIndex = 17
        Me.lblRespuestaVarianza.Text = "?"
        '
        'lblRespuestaMedia
        '
        Me.lblRespuestaMedia.AutoSize = True
        Me.lblRespuestaMedia.Location = New System.Drawing.Point(166, 102)
        Me.lblRespuestaMedia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRespuestaMedia.Name = "lblRespuestaMedia"
        Me.lblRespuestaMedia.Size = New System.Drawing.Size(18, 20)
        Me.lblRespuestaMedia.TabIndex = 16
        Me.lblRespuestaMedia.Text = "?"
        '
        'lblserie
        '
        Me.lblserie.AutoSize = True
        Me.lblserie.Location = New System.Drawing.Point(52, 40)
        Me.lblserie.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblserie.Name = "lblserie"
        Me.lblserie.Size = New System.Drawing.Size(50, 20)
        Me.lblserie.TabIndex = 15
        Me.lblserie.Text = "Serie:"
        '
        'txtserie
        '
        Me.txtserie.Location = New System.Drawing.Point(112, 36)
        Me.txtserie.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtserie.Name = "txtserie"
        Me.txtserie.Size = New System.Drawing.Size(260, 26)
        Me.txtserie.TabIndex = 14
        Me.txtserie.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnMediaAritmetica
        '
        Me.btnMediaAritmetica.Location = New System.Drawing.Point(56, 634)
        Me.btnMediaAritmetica.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnMediaAritmetica.Name = "btnMediaAritmetica"
        Me.btnMediaAritmetica.Size = New System.Drawing.Size(318, 65)
        Me.btnMediaAritmetica.TabIndex = 13
        Me.btnMediaAritmetica.Text = "Calculos estadisticos"
        Me.btnMediaAritmetica.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1274, 734)
        Me.Controls.Add(Me.lbltotalx21xf1)
        Me.Controls.Add(Me.lbltotalx1xf1)
        Me.Controls.Add(Me.lbltotalf1)
        Me.Controls.Add(Me.grdEstadistica)
        Me.Controls.Add(Me.lblRespuestaDesvTipica)
        Me.Controls.Add(Me.lbldesvtipica)
        Me.Controls.Add(Me.lblVarianza)
        Me.Controls.Add(Me.lblMedia)
        Me.Controls.Add(Me.lblRespuestaVarianza)
        Me.Controls.Add(Me.lblRespuestaMedia)
        Me.Controls.Add(Me.lblserie)
        Me.Controls.Add(Me.txtserie)
        Me.Controls.Add(Me.btnMediaAritmetica)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Convertidor de unidades"
        CType(Me.grdEstadistica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbltotalx21xf1 As Label
    Friend WithEvents lbltotalx1xf1 As Label
    Friend WithEvents lbltotalf1 As Label
    Friend WithEvents grdEstadistica As DataGridView
    Friend WithEvents x1 As DataGridViewTextBoxColumn
    Friend WithEvents f1 As DataGridViewTextBoxColumn
    Friend WithEvents n1 As DataGridViewTextBoxColumn
    Friend WithEvents x1xf1 As DataGridViewTextBoxColumn
    Friend WithEvents x21xf1 As DataGridViewTextBoxColumn
    Friend WithEvents lblRespuestaDesvTipica As Label
    Friend WithEvents lbldesvtipica As Label
    Friend WithEvents lblVarianza As Label
    Friend WithEvents lblMedia As Label
    Friend WithEvents lblRespuestaVarianza As Label
    Friend WithEvents lblRespuestaMedia As Label
    Friend WithEvents lblserie As Label
    Friend WithEvents txtserie As TextBox
    Friend WithEvents btnMediaAritmetica As Button
End Class
