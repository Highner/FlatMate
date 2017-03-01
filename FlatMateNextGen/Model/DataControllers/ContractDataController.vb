Public Class ContractDataController
    Inherits HynrFramework.DataControllerBase(Of Contract, ContractData, ContractDataContext, Entities)

    Public Sub New(ByVal parentid As Integer)
        Me.ParentID = parentid
    End Sub

    Public Overrides Function GetAllItems() As IEnumerable(Of ContractData)
        Dim items = GetItems("TennantID = " & ParentID)
        Return items
    End Function

    Private Property ParentID As Integer
End Class
