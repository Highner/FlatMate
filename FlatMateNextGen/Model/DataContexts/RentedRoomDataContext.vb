Imports FlatMateNextGen

Public Class RentedRoomDataContext
    Inherits HynrFramework.DataContextBase(Of Room, Entities)

    Public Function GetContractRooms(ByVal contractid As Integer) As IEnumerable(Of Room)
        Return (From c In DBContext.Contracts Where c.ContractID = contractid Select c).FirstOrDefault.Rooms
    End Function
End Class
