Imports HynrFramework

Public Class FlatListViewModel
    Inherits ListViewModelBase(Of Flat, FlatData, FlatDataController, FlatItemViewModel, Entities)

    Public Overrides Sub CreateNewItem()
        Dim fltdata As New FlatData
        fltdata.FlatName = "New flat"
        _DataController.CreateNewItem(fltdata)
        GetData()
    End Sub

    Public Property Header As String
        Get
            If Not IsNothing(SelectedItem) Then
                Return "Selected flat: " + SelectedItem.Name
            Else
                Return "No flat selected"
            End If
        End Get
        Set(value As String)
        End Set
    End Property

    Private Property _NameFilter As String
    <ListViewModelFilterAttribute("Name", "string", False)>
    Property NameFilter As String
        Get
            Return _NameFilter
        End Get
        Set(value As String)
            _NameFilter = value
            ApplyFilter()
        End Set
    End Property
End Class