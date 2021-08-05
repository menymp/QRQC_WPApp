Imports System.Data.OleDb
''' <summary>
''' Controlador de acceso para base de datos
''' </summary>
Public Class DatabaseDriver
    ''' <summary>
    ''' Cadena de conexiones
    ''' </summary>
    Dim _ConnString As String
    ''' <summary>
    ''' Adaptador de conexion
    ''' </summary>
    Dim Db_ConnObj As OleDbDataAdapter
    ''' <summary>
    ''' Obtiene o establece la cadena de coneccion con la base de datos
    ''' </summary>
    ''' <returns></returns>
    Public Property ConnectionString
        Get
            Return _ConnString
        End Get
        Set(value)
            _ConnString = value
        End Set
    End Property
    ''' <summary>
    ''' Crea un intento de conexion a la base de datos
    ''' </summary>
    ''' <returns></returns>
    Public Function connect() As String
        Try
            Dim sql As String
            Dim cmd As New OleDbCommand


            Return "True"
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function
    ''' <summary>
    ''' Cierra la conexion
    ''' </summary>
    ''' <returns></returns>
    Public Function closeConn() As String
        Return "True"
    End Function
    ''' <summary>
    ''' Ejecutar un comando
    ''' </summary>
    ''' <returns>resultado</returns>
    Public Function ExecuteQUERY() As Object
        Return Nothing
    End Function
End Class
