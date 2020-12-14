<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteHorario
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
        Me.DBClinicaDataSetFINAL1 = New holaMundo.DBClinicaDataSetFINAL1()
        Me.ReporteHorarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReporteHorarioTableAdapter = New holaMundo.DBClinicaDataSetFINAL1TableAdapters.ReporteHorarioTableAdapter()
        CType(Me.DBClinicaDataSetFINAL1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReporteHorarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "RepoHorario"
        ReportDataSource1.Value = Me.ReporteHorarioBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "holaMundo.ReporteHorario.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(822, 543)
        Me.ReportViewer1.TabIndex = 0
        '
        'DBClinicaDataSetFINAL1
        '
        Me.DBClinicaDataSetFINAL1.DataSetName = "DBClinicaDataSetFINAL1"
        Me.DBClinicaDataSetFINAL1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReporteHorarioBindingSource
        '
        Me.ReporteHorarioBindingSource.DataMember = "ReporteHorario"
        Me.ReporteHorarioBindingSource.DataSource = Me.DBClinicaDataSetFINAL1
        '
        'ReporteHorarioTableAdapter
        '
        Me.ReporteHorarioTableAdapter.ClearBeforeFill = True
        '
        'ReporteHorario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 567)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ReporteHorario"
        Me.Text = "ReporteHorario"
        CType(Me.DBClinicaDataSetFINAL1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReporteHorarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReporteHorarioBindingSource As BindingSource
    Friend WithEvents DBClinicaDataSetFINAL1 As DBClinicaDataSetFINAL1
    Friend WithEvents ReporteHorarioTableAdapter As DBClinicaDataSetFINAL1TableAdapters.ReporteHorarioTableAdapter
End Class
