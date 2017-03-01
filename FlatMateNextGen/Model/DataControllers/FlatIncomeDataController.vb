Public Class FlatIncomeDataController
    Inherits HynrFramework.DataControllerBase(Of FlatIncome, FlatIncomeData, FlatIncomeDataContext, Entities)

    Public Sub New(ByVal parentid As Integer)
        Me.ParentID = parentid
    End Sub

    Public Overrides Function GetAllItems() As IEnumerable(Of FlatIncomeData)
        Dim items = GetItems("FlatID = " & ParentID)
        Return items
    End Function

    Private Property ParentID As Integer
End Class
