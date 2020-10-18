<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PACIENTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MEDICAMENTOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PACIENTEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ENFERMEDADESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PROVEEDORToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PACIENTESToolStripMenuItem, Me.PACIENTEToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1185, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PACIENTESToolStripMenuItem
        '
        Me.PACIENTESToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MEDICAMENTOSToolStripMenuItem, Me.PROVEEDORToolStripMenuItem})
        Me.PACIENTESToolStripMenuItem.Name = "PACIENTESToolStripMenuItem"
        Me.PACIENTESToolStripMenuItem.Size = New System.Drawing.Size(112, 29)
        Me.PACIENTESToolStripMenuItem.Text = "MEDICINA"
        '
        'MEDICAMENTOSToolStripMenuItem
        '
        Me.MEDICAMENTOSToolStripMenuItem.Name = "MEDICAMENTOSToolStripMenuItem"
        Me.MEDICAMENTOSToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.MEDICAMENTOSToolStripMenuItem.Text = "MEDICAMENTOS"
        '
        'PACIENTEToolStripMenuItem
        '
        Me.PACIENTEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ENFERMEDADESToolStripMenuItem})
        Me.PACIENTEToolStripMenuItem.Name = "PACIENTEToolStripMenuItem"
        Me.PACIENTEToolStripMenuItem.Size = New System.Drawing.Size(105, 29)
        Me.PACIENTEToolStripMenuItem.Text = "PACIENTE"
        '
        'ENFERMEDADESToolStripMenuItem
        '
        Me.ENFERMEDADESToolStripMenuItem.Name = "ENFERMEDADESToolStripMenuItem"
        Me.ENFERMEDADESToolStripMenuItem.Size = New System.Drawing.Size(247, 34)
        Me.ENFERMEDADESToolStripMenuItem.Text = "ENFERMEDADES"
        '
        'PROVEEDORToolStripMenuItem
        '
        Me.PROVEEDORToolStripMenuItem.Name = "PROVEEDORToolStripMenuItem"
        Me.PROVEEDORToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.PROVEEDORToolStripMenuItem.Text = "PROVEEDOR"
        '
        'menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1185, 706)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "menu"
        Me.Text = "menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PACIENTESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MEDICAMENTOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PACIENTEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ENFERMEDADESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PROVEEDORToolStripMenuItem As ToolStripMenuItem
End Class
