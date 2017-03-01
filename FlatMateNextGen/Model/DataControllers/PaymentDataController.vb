Public Class PaymentDataController
    Inherits HynrFramework.DataControllerBase(Of Payment, PaymentData, PaymentDataContext, Entities)

    Public Sub New(ByVal parentid As Integer)
        Me.ParentID = parentid
    End Sub

    Public Overrides Function GetAllItems() As IEnumerable(Of PaymentData)
        Dim items = GetItems("TennantID = " & ParentID)
        Return items
    End Function

    Private Property ParentID As Integer
End Class
