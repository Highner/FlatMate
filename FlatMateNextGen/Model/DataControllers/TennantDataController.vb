Public Class TennantDataController
    Inherits HynrFramework.DataControllerBase(Of Tennant, TennantData, TennantDataContext, Entities)

    Public Sub New(ByVal parentid As Integer)
        Me.ParentID = parentid
    End Sub

    Public Overrides Function GetAllItems() As IEnumerable(Of TennantData)
        Dim items = GetItems("FlatID = " & ParentID)
        Return items
    End Function

    Private Property ParentID As Integer
End Class
