Public Class Form1
    Private Flats As FlatListViewModel

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Flats = New FlatListViewModel
        Flats.GetData()
        FlatGrid.BindToListViewModel(Flats)
    End Sub
End Class
