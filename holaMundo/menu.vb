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

    Private Sub RECETAToolStripMenuItem_Click(sender As Object, e As EventArgs)
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

    Private Sub DATOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DATOSToolStripMenuItem.Click
        Dim objDatosPersonales As New DatosPersonales
        objDatosPersonales.Show()
    End Sub

    Private Sub PruebaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PruebaToolStripMenuItem.Click
        Dim ObjDfamiliar As New DatosFamiliar
        ObjDfamiliar.Show()
    End Sub

    Private Sub PERSONALToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PERSONALToolStripMenuItem.Click
        Dim Objpersonal As New Personal
        Objpersonal.Show()
    End Sub

    Private Sub EXPEDIENTEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXPEDIENTEToolStripMenuItem.Click
        Dim objexpediente As New expediente
        objexpediente.Show()
    End Sub

    Private Sub VENTAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VENTAToolStripMenuItem.Click
        Dim objventa As New FVentas
        objventa.Show()
    End Sub

    Private Sub menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub COMPRADEMEDICAMENTOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles COMPRADEMEDICAMENTOToolStripMenuItem.Click
        Dim objcompra As New compraM
        objcompra.Show()
    End Sub

    Private Sub CITACONSULTAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CITACONSULTAToolStripMenuItem.Click
        Dim objconsulta As New consulta
        objconsulta.Show()
    End Sub

    Private Sub EXAMENESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXAMENESToolStripMenuItem.Click
        Dim objexamen As New examen
        objexamen.Show()
    End Sub

    Private Sub RECETASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RECETASToolStripMenuItem.Click
        Dim objrecetas As New receta
        objrecetas.Show()
    End Sub

    Private Sub ADMINISTRARTARJETASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ADMINISTRARTARJETASToolStripMenuItem.Click
        Dim objtarjetas As New tarjetas
        objtarjetas.Show()
    End Sub

    Private Sub LISTADEPERSONALDECLINICAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LISTADEPERSONALDECLINICAToolStripMenuItem.Click
        Dim objreppersnal As New Listapersonal
        objreppersnal.Show()
    End Sub

    Private Sub LISTAMEDICAMENTOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LISTAMEDICAMENTOSToolStripMenuItem.Click
        Dim objmedlist As New listamed
        objmedlist.Show()
    End Sub

    Private Sub LISTADEUSUARIOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LISTADEUSUARIOSToolStripMenuItem.Click
        Dim Objusuariolist As New ListaDeUsuarios
        Objusuariolist.Show()
    End Sub
End Class