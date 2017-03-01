Public Class SharedRunningCostListViewModel
    Inherits HynrFramework.ListViewModelBase(Of RunningCost, RunningCostData, SharedRunningCostsDataController, SharedRunningCostsItemViewModel, Entities)

    Public Sub New(ByVal parentid As Integer)
        MyBase.New(New SharedRunningCostsDataController(parentid))
        Me.ParentID = parentid
    End Sub

    Private ParentID As Integer
End Class
