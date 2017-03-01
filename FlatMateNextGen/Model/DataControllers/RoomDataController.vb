Public Class RoomDataController
    Inherits HynrFramework.DataControllerBase(Of Room, RoomData, RoomDataContext, Entities)

    Public Sub New(ByVal parentid As Integer)
        Me.ParentID = parentid
    End Sub

    Public Overrides Function GetAllItems() As IEnumerable(Of RoomData)
        Dim items = GetItems("FlatID = " & ParentID)
        Return items
    End Function

    Private Property ParentID As Integer
End Class
