<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Listapersonal
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
        Me.personalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.personalTableAdapter = New holaMundo.DBClinicaDataSet3TableAdapters.personalTableAdapter()
        CType(Me.DBClinicaDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.personalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "ListaPersonal"
        ReportDataSource1.Value = Me.personalBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "holaMundo.Personallis.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 22)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1261, 697)
        Me.ReportViewer1.TabIndex = 0
        '
        'DBClinicaDataSet3
        '
        Me.DBClinicaDataSet3.DataSetName = "DBClinicaDataSet3"
        Me.DBClinicaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'personalBindingSource
        '
        Me.personalBindingSource.DataMember = "personal"
        Me.personalBindingSource.DataSource = Me.DBClinicaDataSet3
        '
        'personalTableAdapter
        '
        Me.personalTableAdapter.ClearBeforeFill = True
        '
        'Listapersonal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1285, 731)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Listapersonal"
        Me.Text = "Listapersonal"
        CType(Me.DBClinicaDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.personalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents personalBindingSource As BindingSource
    Friend WithEvents DBClinicaDataSet3 As DBClinicaDataSet3
    Friend WithEvents personalTableAdapter As DBClinicaDataSet3TableAdapters.personalTableAdapter
End Class
