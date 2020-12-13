<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRventa
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
        Me.VentasReporteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DBClinicaDataSet3 = New holaMundo.DBClinicaDataSet3()
        Me.VentasReporteTableAdapter = New holaMundo.DBClinicaDataSet3TableAdapters.VentasReporteTableAdapter()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.VentasReporteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBClinicaDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VentasReporteBindingSource
        '
        Me.VentasReporteBindingSource.DataMember = "VentasReporte"
        Me.VentasReporteBindingSource.DataSource = Me.DBClinicaDataSet3
        '
        'DBClinicaDataSet3
        '
        Me.DBClinicaDataSet3.DataSetName = "DBClinicaDataSet3"
        Me.DBClinicaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VentasReporteTableAdapter
        '
        Me.VentasReporteTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "ReporteV"
        ReportDataSource1.Value = Me.VentasReporteBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "holaMundo.InformeVentas.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1372, 687)
        Me.ReportViewer1.TabIndex = 0
        '
        'FRventa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1396, 711)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FRventa"
        Me.Text = "FRventa"
        CType(Me.VentasReporteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBClinicaDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents VentasReporteBindingSource As BindingSource
    Friend WithEvents DBClinicaDataSet3 As DBClinicaDataSet3
    Friend WithEvents VentasReporteTableAdapter As DBClinicaDataSet3TableAdapters.VentasReporteTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
