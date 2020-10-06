Imports System.Data
Imports System.Data.SqlClient
Public Class db_conexion
    Dim miconexion As New SqlConnection
    Dim micomand As New SqlCommand
    Dim miadapter As New SqlDataAdapter
    Dim ds As DataSet

    Public Sub New()
        Dim c_conexion As String
        c_conexion = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DBClinica.mdf;Integrated Security=True"
        miconexion.ConnectionString = c_conexion

        miconexion.Open()
    End Sub

    Public Function obtenerdatos()
        ds.Clear()
        micomand.Connection = miconexion

        micomand.CommandText = "select * from medicina"
        miadapter.SelectCommand = micomand
        miadapter.Fill(ds, "medicina")
        Return ds
    End Function


End Class
