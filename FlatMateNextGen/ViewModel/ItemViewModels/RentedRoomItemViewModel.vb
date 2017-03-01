<Serializable>
Public Class RentedRoomItemViewModel
    Inherits HynrFramework.ItemViewModelBase(Of RoomData)

    Public ReadOnly Property Name As String
        Get
            Return Data.Name
        End Get
    End Property
End Class
