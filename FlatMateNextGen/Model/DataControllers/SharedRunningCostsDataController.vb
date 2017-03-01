Public Class SharedRunningCostsDataController
    Inherits HynrFramework.DataControllerBase(Of RunningCost, RunningCostData, SharedRunningCostsDataContext, Entities)

    Public Sub New(ByVal parentid As Integer)
        Me.ParentID = parentid
    End Sub

    Public Overrides Function GetAllItems() As IEnumerable(Of RunningCostData)
        Dim list As New List(Of RunningCostData)
        Dim cont As New SharedRunningCostsDataContext
        Dim costs = cont.GetContractCosts(ParentID)
        If Not IsNothing(costs) Then
            For Each entityitem In costs
                Dim newdataitem As RunningCostData = ToData(entityitem)
                list.Add(newdataitem)
            Next
        End If
        Return list
    End Function

    Private Property ParentID As Integer
End Class