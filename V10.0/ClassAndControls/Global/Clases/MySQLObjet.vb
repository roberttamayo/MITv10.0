Imports MySqlConnector
Public Class MySQLObjet
    Private ReadOnly Conexion As MySqlConnection
    Private ReadOnly StringBuilder As MySqlConnectionStringBuilder
    Private ReadOnly Comando As MySqlCommand
    Private Lector As MySqlDataReader
    Private Alertas As AlertasPersonalizadas
    'Constructor
    Sub New()
        Alertas = New AlertasPersonalizadas()
        StringBuilder = New MySqlConnectionStringBuilder With {
        .Server = "localhost",
        .UserID = "root",
        .Password = "root",
        .Database = "mit"
        }
        Conexion = New MySqlConnection(StringBuilder.ToString())
        Try
            Conexion.Open()
            Comando = New MySqlCommand With {
            .Connection = Conexion
            }
        Catch ex As Exception
            Alertas.Bug("Error al tratar de conectarse al servidor de datos", "Ocurrio un error al tratar de conectarse al servidor de datos" + ex.Message())
            Application.Exit()
        End Try
    End Sub
    Public Function InsertQuery(query As String) As Boolean
        Comando.CommandText = query
        Try
            Comando.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Alertas.Bug("Ocurrio un error al tratar de insertar en base de datos", "Ocurrio un error al tratar de realizar el insert" + ex.Message())
            Return False
        End Try
    End Function
    Public Function UpdateQuery(query As String) As Boolean
        Comando.CommandText = query
        Try
            Comando.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Alertas.Bug("Ocurrio un error al tratar de actualizar en base de datos", "Ocurrio un error al tratar de realizar la actualizacion" + ex.Message())
            Return False
        End Try
    End Function
    Public Function DeleteQuery(query As String) As Boolean
        Comando.CommandText = query
        Try
            Comando.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Alertas.Bug("Ocurrio un error al tratar de eliminar en base de datos", "Ocurrio un error al tratar de realizar la eliminacion" + ex.Message())
            Return False
        End Try
    End Function
    Public Function SelectQuery(query As String) As MySqlDataReader
        Comando.CommandText = query
        Try
            Lector = Comando.ExecuteReader()
            Return Lector
        Catch ex As Exception
            Alertas.Bug("Error al revisar informacion de la base de datos", "Ocurrio un error al tratar de revisar la informacion de la base de datos" + ex.Message())
            Return Nothing
        End Try
    End Function
    Public Function NumRows(query As String) As Integer
        Dim filas = SelectQuery(query)
        Dim cont = 0
        Try
            While filas.Read()
                cont += 1
            End While
            NextResult()
            Return cont
        Catch ex As Exception
            NextResult()
            Alertas.Bug("Error al contar la informacion obtenida", "ocurrio un problema al realizar el conteo de la informacion obtenida " + ex.Message())
            Return 0
        End Try
    End Function
    'Opcional
    Public Sub NextResult()
        Lector.NextResult()
        Lector.Close()
    End Sub
    Public Function FechaMySQL() As String
        Return Date.Now.ToString("yyyy-MM-dd")
    End Function
    Public Function HoraMySQL() As String
        Return Date.Now.ToString("HH:mm:ss")
    End Function
End Class
