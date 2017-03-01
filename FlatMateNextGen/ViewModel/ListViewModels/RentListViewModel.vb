Public Class RentListViewModel
    Inherits HynrFramework.ListViewModelBase(Of Rent, RentData, RentDataController, RentItemViewModel, Entities)

    Public Overrides Sub CreateNewItem()
        Dim data As New RentData
        data.Amount = 0
        data.ValidTo = Date.Today
        data.ValidFrom = Date.Today
        data.FlatID = ParentID
        _DataController.CreateNewItem(data)
        GetData()
    End Sub

    Public Sub New(ByVal parentid As Integer)
        MyBase.New(New RentDataController(parentid))
        Me.ParentID = parentid
    End Sub



    Private ParentID As Integer
End Class
