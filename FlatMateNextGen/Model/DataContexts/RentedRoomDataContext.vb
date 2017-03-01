Imports FlatMateNextGen

Public Class RentedRoomDataContext
    Inherits HynrFramework.DataContextBase(Of Room, Entities)

    Public Function GetContractRooms(ByVal contractid As Integer) As IEnumerable(Of Room)
        Dim cont = (From c In DBContext.Contracts Where c.ContractID = contractid Select c)
        If cont.Any Then
            Return cont.FirstOrDefault.Rooms
        Else
            Return Nothing
        End If
    End Function
End Class
