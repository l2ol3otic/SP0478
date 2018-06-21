Imports System.Data
Imports System.Data.SqlClient

Module MasterModule

    Public conStr As String = "server=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Programming\VB\SP0478\SP0478\invenMaster.mdf;Integrated Security=True"
    Public connection As New SqlConnection(conStr)
    Public command As New SqlCommand("", connection)
    Public adapter As New SqlDataAdapter
    Public dataSt As New DataSet
    Public bindingSrc As BindingSource
    Public reader As SqlDataReader
    Public sql As String

End Module
