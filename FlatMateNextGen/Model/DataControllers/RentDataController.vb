Public Class RentDataController
    Inherits HynrFramework.DataControllerBase(Of Rent, RentData, RentDataContext, Entities)

    Public Sub New(ByVal parentid As Integer)
        Me.ParentID = parentid
    End Sub

    Public Overrides Function GetAllItems() As IEnumerable(Of RentData)
        Dim items = GetItems("FlatID = " & ParentID)
        Return items
    End Function

    Private Property ParentID As Integer
End Class
