Public Class RentedRoomDataController
    Inherits HynrFramework.DataControllerBase(Of Room, RoomData, RentedRoomDataContext, Entities)

    Public Sub New(ByVal parentid As Integer)
        Me.ParentID = parentid
    End Sub

    Public Overrides Function GetAllItems() As IEnumerable(Of RoomData)
        Dim list As New List(Of RoomData)
        Dim cont As New RentedRoomDataContext
        Dim rooms = cont.GetContractRooms(ParentID)
        If Not IsNothing(rooms) Then
            For Each entityitem In rooms
                Dim newdataitem As RoomData = ToData(entityitem)
                list.Add(newdataitem)
            Next
        End If
        Return list
    End Function

    Private Property ParentID As Integer
End Class