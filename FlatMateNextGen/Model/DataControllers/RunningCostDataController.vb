Public Class RunningCostDataController
    Inherits HynrFramework.DataControllerBase(Of RunningCost, RunningCostData, RunningCostDataContext, Entities)

    Public Sub New(ByVal parentid As Integer)
        Me.ParentID = parentid
    End Sub

    Public Overrides Function GetAllItems() As IEnumerable(Of RunningCostData)
        Dim items = GetItems("FlatID = " & ParentID)
        Return items
    End Function

    Private Property ParentID As Integer
End Class
