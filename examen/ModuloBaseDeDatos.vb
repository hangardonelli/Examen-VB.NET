Imports System.Data.SqlClient

Module DBSubs

    ''' <summary>
    ''' Devuelve la conexión de la base de datos
    ''' </summary>
    ''' <returns>Un SqlConnection que representa la conexión</returns>
    Private Function DbConnection() As SqlConnection
        Dim con As SqlConnection
        con = New SqlConnection
        'Obtenemos el connection string desde el XML de App.Config
        con.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("connection_string").ConnectionString
        Return con
    End Function





    ''' <summary>
    ''' Dada una consulta T-SQL a la base de datos, devuelve el resultado de la consulta como DataTable
    ''' </summary>
    ''' <param name="query">La consulta T-SQL</param>
    ''' <returns>Un DataTable, donde se almacena la consulta</returns>
    Public Function DbQueryAsDataTable(query As String) As DataTable

        Dim connection As SqlConnection
        connection = DbConnection()

        Dim DataInTable As New DataTable

        Try
            connection.Open()


            Dim adapter = New SqlDataAdapter(query, connection)
            adapter.Fill(DataInTable)

            connection.Close()
            connection.Dispose()

            Return DataInTable
        Catch ex As SqlException
            'Para depurar
            MsgBox($"error + {ex.Message}")

            Return Nothing
        End Try

    End Function

    ''' <summary>
    ''' Ejecuta una consulta T-SQL y devuelve las columnas afectadas
    ''' </summary>
    ''' <param name="query">La consulta T-SQL</param>
    ''' <returns>Un entero, que denota la cantidad de filas afectadas</returns>
    Public Function DbQuery(query As String) As Integer

        '
        Dim command = New SqlCommand()
        command.CommandText = query

        Dim connection As SqlConnection
        connection = DbConnection()

        Try
            connection.Open()
            command.Connection = connection

            Dim Resultado As Integer
            Resultado = command.ExecuteNonQuery()

            connection.Close()
            connection.Dispose()

            Return Resultado
        Catch ex As SqlException
            MsgBox("error " + ex.Message)
            'En caso de que haya habido algún error, devolvemos -1
            Return -1
        End Try
    End Function


    'Constante util con el TIMESTAMP para usarlo
    Public Const CURRENT_TIMESTAMP As String = "CURRENT_TIMESTAMP WHERE"

    ''' <summary>
    ''' Devuelve la primer columna de la primer fila de una consulta T-SQL
    ''' </summary>
    ''' <param name="query">Una consulta T-SQL</param>
    ''' <returns>Un objeto, que es el valor de la primer columna de la primera fila.</returns>
    Public Function DbQueryAsValue(query As String) As Object

        Dim command = New SqlCommand()
        command.CommandText = query

        Dim connection As SqlConnection
        connection = DbConnection()



        Try
            connection.Open()

            command.Connection = connection

            Dim reader As Object = command.ExecuteScalar()


            connection.Close()
            connection.Dispose()

            Return reader

        Catch ex As SqlException
            MessageBox.Show(ex.Message)
            Return False
        End Try

    End Function



End Module
