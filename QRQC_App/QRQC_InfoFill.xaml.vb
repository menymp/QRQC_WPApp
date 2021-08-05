Public Class QRQC_InfoFill
    ''' <summary>
    ''' Ventana padre
    ''' </summary>
    Dim _ParentScreen As Object
    ''' <summary>
    ''' Objeto qrqc
    ''' </summary>
    Dim QRQCObj As QRQC
    ''' <summary>
    ''' Obtiene o establece la ventana padre original
    ''' </summary>
    ''' <returns></returns>
    Public Property ParentScreen
        Get
            Return _ParentScreen
        End Get
        Set(value)
            _ParentScreen = value
        End Set
    End Property

    ''' <summary>
    ''' Vuelve a la pantalla principal
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnCancelar_Click(sender As Object, e As RoutedEventArgs) Handles BtnCancelar.Click
        _ParentScreen.Show()
        Me.Close()
    End Sub
    ''' <summary>
    ''' Guarda QRQC y vuelve al dashboard principal
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnGuardar_Click(sender As Object, e As RoutedEventArgs) Handles BtnGuardar.Click
        If QRQCObj Is Nothing Then
            QRQCObj = New QRQC
            QRQCObj.ProblemBrief = TxtDescription.Text
            QRQCObj.OpenDate = TxtOpenDate.Text
            QRQCObj.ID = TxtID.Text
            _ParentScreen.AddListItem(QRQCObj)
        Else
            QRQCObj.ProblemBrief = TxtDescription.Text
            QRQCObj.OpenDate = TxtOpenDate.Text
            QRQCObj.ID = TxtID.Text
        End If
        _ParentScreen.Show()
        _ParentScreen.UpdateScreen()
        Me.Close()
    End Sub
    ''' <summary>
    ''' Establece como fecha el instante actual
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnGetDate_Click(sender As Object, e As RoutedEventArgs) Handles BtnGetDate.Click
        TxtOpenDate.Text = System.DateTime.Now()
    End Sub
    ''' <summary>
    ''' Despliega la informacion de un QRQC existente
    ''' </summary>
    ''' <param name="QRQCObj"></param>
    Public Sub LoadQRQC(QRQCObjRef As QRQC)
        QRQCObj = QRQCObjRef
        TxtDescription.Text = QRQCObj.ProblemBrief
        TxtID.Text = QRQCObj.ID
        TxtOpenDate.Text = QRQCObj.OpenDate
    End Sub
End Class
