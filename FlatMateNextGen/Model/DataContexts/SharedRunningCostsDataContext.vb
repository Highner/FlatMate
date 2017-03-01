Public Class SharedRunningCostsDataContext
    Inherits HynrFramework.DataContextBase(Of RunningCost, Entities)

    Public Function GetContractCosts(ByVal contractid As Integer) As IEnumerable(Of RunningCost)
        Dim cont = (From c In DBContext.Contracts Where c.ContractID = contractid Select c)
        If cont.Any Then
            Return cont.FirstOrDefault.RunningCosts
        Else
            Return Nothing
        End If
    End Function
End Class
