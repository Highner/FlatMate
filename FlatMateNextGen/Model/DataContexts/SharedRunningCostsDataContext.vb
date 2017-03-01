Public Class SharedRunningCostsDataContext
    Inherits HynrFramework.DataContextBase(Of RunningCost, Entities)

    Public Function GetContractCosts(ByVal contractid As Integer) As IEnumerable(Of RunningCost)
        Return (From c In DBContext.Contracts Where c.ContractID = contractid Select c).FirstOrDefault.RunningCosts
    End Function
End Class
