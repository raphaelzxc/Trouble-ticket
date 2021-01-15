Imports System.Data.SqlClient
Imports System.Data.Sql
Imports Microsoft.Office.Interop
Public Class SqlControl
    'Public DbCon As New SqlConnection("Server=192.168.30.10,1433;Initial Catalog = NewRequest;User ID=sa;Password=accmarex0907;Integrated security=true;")
    'Public DbCon As New SqlConnection("Server=192.168.201.19\VPCONTROLLER\SQLEXPRESS;Initial Catalog = Request;Integrated security=true;")
    'Public DbCon As New SqlConnection("Server=MARCSERVER01\SQL2008;Database = NewRequest;Trusted_Connection=True;")


    Public DbCon As New SqlConnection("Server=VPCONTROLLER\SQLEXPRESS;Database = Request;Integrated security=true;")
    Public Dbcmd As SqlCommand
    'db adapter
    Public DBDA As SqlDataAdapter
    Public DBDT As DataTable
    Public SQLDA As SqlDataAdapter
    Public SQLDS As DataSet
    'query parametr
    Public Params As New List(Of SqlParameter)
    'query paramaters
    Public RecordCount As Integer
    Public Exception As String





    Public Function HasConnection() As Boolean
        Try
            DbCon.Open()
            DbCon.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return True
    End Function

    Public Sub RunQuery(Query As String)
        Try
            DbCon.Open()

            Dbcmd = New SqlCommand(Query, DbCon)

            SQLDA = New SqlDataAdapter(Dbcmd)
            SQLDS = New DataSet
            SQLDA.Fill(SQLDS)

            DbCon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub New()


    End Sub

    'allow coonection override
    Public Sub New(Connectionstring As String)
        DbCon = New SqlConnection(Connectionstring)
    End Sub

    ' Execute query Sub
    Public Sub ExecQuery(Query As String, Optional ReturnIdentity As Boolean = False)
        RecordCount = 0
        Exception = ""

        Try
            DbCon.Open()

            'Create db Command

            Dbcmd = New SqlCommand(Query, DbCon)

            ' load my params in databsecommand
            Params.ForEach(Sub(p) Dbcmd.Parameters.Add(p))
            'clear paramslist

            Params.Clear()
            'execute the command and fill our data set
            DBDT = New DataTable
            DBDA = New SqlDataAdapter(Dbcmd)
            RecordCount = DBDA.Fill(DBDT)


            If ReturnIdentity = True Then
                Dim ReturnQuery As String = "select @@IDENTITY as LastId;"
                '@@IDENTITY SESSION
                'SCOPE_IDENTITY() = SESSION AND SCOPE'
                'IDENT_CURRENT(TABLENAME) - LAST IDENTITY IN TABLE
                Dbcmd = New SqlCommand(ReturnQuery, DbCon)
                DBDT = New DataTable
                DBDA = New SqlDataAdapter(Dbcmd)
                RecordCount = DBDA.Fill(DBDT)
            End If

        Catch ex As Exception
            ' capture error
            Exception = "ExecQuery Error:" & vbNewLine & ex.Message
        Finally
            'close connection
            If DbCon.State = ConnectionState.Open Then DbCon.Close()
        End Try
    End Sub
    'ADD PARAMS

    Public Sub AddParam(Name As String, Value As Object)
        Dim newParam As New SqlParameter(Name, Value)
        Params.Add(newParam)
    End Sub
    'ERROR CHECKING


    Public Function HasExCeption(Optional Report As Boolean = False) As Boolean
        If String.IsNullOrEmpty(Exception) Then Return False
        If Report = True Then MsgBox(Exception, MsgBoxStyle.Critical, "Exception:")
        Return True

    End Function
End Class
