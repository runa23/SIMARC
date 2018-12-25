Imports System
Imports System.Data
Imports System.Data.SqlClient
Module Conection
    Public sql As String
    Public con As SqlClient.SqlConnection
    Public cmd As SqlCommand
    Public da As SqlDataAdapter
    Public rdr As SqlDataReader
    Public ds As DataSet
    Public dt As DataTable
    Public ServerName As String
    Public DatabaseName As String
    Public MARS As Boolean
    Public userID As String
    Public Password As String
    Public ConnString As String
    Public Sub OpenConnection()

        ServerName = "simarc.southeastasia.cloudapp.azure.com,1433"
        DatabaseName = "SIMARC"
        MARS = True
        userID = "usersimarc"
        Password = "user!@#123"

        ConnString = "server = " & ServerName & ";"
        ConnString = ConnString & "database = " & DatabaseName & ";"
        ConnString = ConnString & "MultipleActiveResultSets = " & MARS & ";"
        ConnString = ConnString & "User ID = " & userID & ";"
        ConnString = ConnString & "Password = " & Password & "" & ""

        con = New SqlClient.SqlConnection(ConnString)
        'con = New SqlClient.SqlConnection("server=.;database=SIMARF;MultipleActiveResultSets=true;user ID=user;password=user12345")
        'con = New SqlClient.SqlConnection("Server=192.168.1.201,1433;Database=SIMARF;MultipleActiveResultSets=True;User ID=user;Password=user12345;")
        'con = New SqlClient.SqlConnection("Network Library=DBMSSOCN; Data Source=192.168.1.2,1433;" & _
        '                   "MultipleActiveResultSets=True;Initial Catalog=SIMARF; User ID=user; Password=user12345")
        Try
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
            End
        End Try
    End Sub
    Public Sub CloseConnection()
        If Not IsNothing(con) Then
            con.Close()
        End If
    End Sub

End Module
