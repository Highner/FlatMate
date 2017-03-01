Public Class RunningCostListViewModel
    Inherits HynrFramework.ListViewModelBase(Of RunningCost, RunningCostData, RunningCostDataController, RunningCostItemViewModel, Entities)


    Public Overrides Sub CreateNewItem()
        Dim data As New RunningCostData
        data.Name = "New room"
        data.Amount = 0
        data.ValidFrom = Date.Today
        data.ValidTo = Date.Today
        data.FlatID = ParentID
        _DataController.CreateNewItem(data)
        GetData()
    End Sub

    Public Sub New(ByVal parentid As Integer)
        MyBase.New(New RunningCostDataController(parentid))
        Me.ParentID = parentid
    End Sub



    Private ParentID As Integer
End Class
