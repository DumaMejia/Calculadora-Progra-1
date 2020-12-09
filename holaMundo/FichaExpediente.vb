Public Class FichaExpediente
    Private Sub ExpedienteBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ExpedienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DBClinicaDataSet)

    End Sub

    Private Sub ExpedienteBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles ExpedienteBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ExpedienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DBClinicaDataSet)

    End Sub

    Private Sub FichaExpediente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DBClinicaDataSet.DetallesEnfermedad' Puede moverla o quitarla según sea necesario.
        Me.DetallesEnfermedadTableAdapter.FillDetallesEnfermedad(Me.DBClinicaDataSet.DetallesEnfermedad)
        'TODO: esta línea de código carga datos en la tabla 'DBClinicaDataSet.expediente' Puede moverla o quitarla según sea necesario.
        Me.ExpedienteTableAdapter.Fill(Me.DBClinicaDataSet.expediente)

    End Sub


End Class