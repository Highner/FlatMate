Public Class SharedRunningCostsDataController
    Inherits HynrFramework.DataControllerBase(Of RunningCost, RunningCostData, SharedRunningCostsDataContext, Entities)

    Public Sub New(ByVal parentid As Integer)
        Me.ParentID = parentid
    End Sub

    Public Overrides Function GetAllItems() As IEnumerable(Of RunningCostData)
        Dim list As New List(Of RunningCostData)
        Dim cont As New SharedRunningCostsDataContext
        For Each entityitem In cont.GetContractCosts(ParentID)
            Dim newdataitem As RunningCostData = ToData(entityitem)
            list.Add(newdataitem)
        Next
        Return list
    End Function

    Private Property ParentID As Integer
End Class