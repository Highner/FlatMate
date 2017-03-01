Public Class RentedRoomListViewModel
    Inherits HynrFramework.ListViewModelBase(Of Room, RoomData, RentedRoomDataController, RentedRoomItemViewModel, Entities)

    Public Sub New(ByVal parentid As Integer)
        MyBase.New(New RentedRoomDataController(parentid))
        Me.ParentID = parentid
    End Sub

    Private ParentID As Integer
End Class
