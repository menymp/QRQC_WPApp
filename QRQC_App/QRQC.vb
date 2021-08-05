Public Class QRQC
    ''' <summary>
    ''' identificador
    ''' </summary>
    Dim _ID As Integer
    ''' <summary>
    ''' Representa la fecha de apertura
    ''' </summary>
    Dim _OpenDate As String
    ''' <summary>
    ''' Breve descripcion del problema
    ''' </summary>
    Dim _ProblemBrief As String
    ''' <summary>
    ''' Obtiene o establece el ID 
    ''' </summary>
    ''' <returns></returns>
    Public Property ID
        Get
            Return _ID
        End Get
        Set(value)
            _ID = value
        End Set
    End Property
    ''' <summary>
    ''' Obtiene o establece la fecha de carga
    ''' </summary>
    ''' <returns></returns>
    Public Property OpenDate
        Get
            Return _OpenDate
        End Get
        Set(value)
            _OpenDate = value
        End Set
    End Property
    ''' <summary>
    ''' Obtiene o establece la causa raiz
    ''' </summary>
    ''' <returns></returns>
    Public Property ProblemBrief
        Get
            Return _ProblemBrief
        End Get
        Set(value)
            _ProblemBrief = value
        End Set
    End Property
    ''' <summary>
    ''' Obtiene o establece la representacion del objeto
    ''' </summary>
    ''' <returns></returns>
    Public Overrides Function ToString() As String
        Return _ID & vbTab & _ProblemBrief & vbTab & "Abierto " & _OpenDate
    End Function

End Class
