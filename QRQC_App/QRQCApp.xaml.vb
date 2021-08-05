Class MainWindow
    'Private ListQRQC As New List(Of QRQC)
    ''' <summary>
    ''' Crea un nuevo QRQC
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnNewQRQC_Click(sender As Object, e As RoutedEventArgs) Handles BtnNewQRQC.Click
        Dim OpenScreen As New QRQC_InfoFill
        OpenScreen.ParentScreen = Me
        OpenScreen.Show()
        Me.Hide()
    End Sub
    ''' <summary>
    ''' Añade un nuevo objeto QRQC a la coleccion de despliegue
    ''' </summary>
    ''' <param name="QRQC_Obj"></param>
    Public Sub AddListItem(QRQC_Obj As QRQC)
        Dim TmpItemList As New ListViewItem
        Dim tmpcolor As New SolidColorBrush(Colors.DarkSlateGray)
        Dim tmpcolor2 As New SolidColorBrush(Colors.White)
        tmpcolor.Opacity = 1
        TmpItemList.Content = QRQC_Obj
        TmpItemList.Background = tmpcolor
        tmpcolor2.Color = Colors.White
        tmpcolor2.Opacity = 1
        TmpItemList.Foreground = tmpcolor2
        QRQCList.Items.Add(TmpItemList)
        'ListQRQC.Add(QRQC_Obj)
    End Sub
    ''' <summary>
    ''' Ocurre cuando se da doble click sobre un evento
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub QRQCList_MouseDoubleClick(sender As Object, e As MouseButtonEventArgs) Handles QRQCList.MouseDoubleClick
        Dim OpenScreen As New QRQC_InfoFill
        OpenScreen.ParentScreen = Me
        OpenScreen.LoadQRQC(QRQCList.SelectedItem)
        OpenScreen.Show()
        Me.Hide()
    End Sub
    ''' <summary>
    ''' Actualiza los componentes a desplegar
    ''' </summary>
    Public Sub UpdateScreen()
        QRQCList.Items.Refresh()
    End Sub
    ''' <summary>
    ''' Carga los datos de QRQC desde la base de datos
    ''' </summary>
    Private Sub LoadComponents()

    End Sub
End Class
