Public Class menu
    Private Sub MEDICAMENTOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MEDICAMENTOSToolStripMenuItem.Click
        Dim objmedicina As New Form1
        objmedicina.Show()
    End Sub

    Private Sub ENFERMEDADESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ENFERMEDADESToolStripMenuItem.Click
        Dim objEnfermedades As New Form4
        objEnfermedades.Show()
    End Sub

    Private Sub PROVEEDORToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PROVEEDORToolStripMenuItem.Click
        Dim objProveedor As New Proveedor
        objProveedor.Show()
    End Sub

    Private Sub CARGOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CARGOToolStripMenuItem.Click
        Dim objCargo As New FormCargo
        objCargo.Show()
    End Sub

    Private Sub DIAGNOSTICOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DIAGNOSTICOToolStripMenuItem.Click
        Dim objDiagnostico As New diagnostico
        objDiagnostico.Show()
    End Sub

    Private Sub USUARIOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles USUARIOSToolStripMenuItem.Click
        Dim objUsuario As New usuario
        objUsuario.Show()
    End Sub

    Private Sub RECETAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RECETAToolStripMenuItem.Click
        Dim objreceta As New receta
        objreceta.Show()
    End Sub

    Private Sub HORARIOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HORARIOToolStripMenuItem.Click
        Dim objhorario As New horario
        objhorario.Show()
    End Sub

    Private Sub TRASLADOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TRASLADOToolStripMenuItem.Click
        Dim objtraslado As New traslado
        objtraslado.Show()
    End Sub

    Private Sub ALERGIAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ALERGIAToolStripMenuItem.Click
        Dim objalergia As New alergia
        objalergia.Show()
    End Sub
End Class