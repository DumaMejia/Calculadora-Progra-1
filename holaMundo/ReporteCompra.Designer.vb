<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteCompra
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DBClinicaDataSet3 = New holaMundo.DBClinicaDataSet3()
        Me.ReporteCompraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReporteCompraTableAdapter = New holaMundo.DBClinicaDataSet3TableAdapters.ReporteCompraTableAdapter()
        CType(Me.DBClinicaDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReporteCompraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "ReporteComprads"
        ReportDataSource1.Value = Me.ReporteCompraBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "holaMundo.RCompra.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1277, 693)
        Me.ReportViewer1.TabIndex = 0
        '
        'DBClinicaDataSet3
        '
        Me.DBClinicaDataSet3.DataSetName = "DBClinicaDataSet3"
        Me.DBClinicaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReporteCompraBindingSource
        '
        Me.ReporteCompraBindingSource.DataMember = "ReporteCompra"
        Me.ReporteCompraBindingSource.DataSource = Me.DBClinicaDataSet3
        '
        'ReporteCompraTableAdapter
        '
        Me.ReporteCompraTableAdapter.ClearBeforeFill = True
        '
        'ReporteCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1301, 717)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ReporteCompra"
        Me.Text = "ReporteCompra"
        CType(Me.DBClinicaDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReporteCompraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReporteCompraBindingSource As BindingSource
    Friend WithEvents DBClinicaDataSet3 As DBClinicaDataSet3
    Friend WithEvents ReporteCompraTableAdapter As DBClinicaDataSet3TableAdapters.ReporteCompraTableAdapter
End Class
