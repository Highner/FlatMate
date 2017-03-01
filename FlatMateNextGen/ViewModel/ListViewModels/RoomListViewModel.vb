Imports HynrFramework

Public Class RoomListViewModel
    Inherits ListViewModelBase(Of Room, RoomData, RoomDataController, RoomItemViewModel, Entities)

    Public Overrides Sub CreateNewItem()
        Dim data As New RoomData
        data.Name = "New room"
        data.Size = 0
        data.CalculationSize = 0
        data.FlatID = ParentID
        _DataController.CreateNewItem(data)
        GetData()
    End Sub

    Public Sub New(ByVal parentid As Integer)
        MyBase.New(New RoomDataController(parentid))
        Me.ParentID = parentid
    End Sub



    Private ParentID As Integer

End Class