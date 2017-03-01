Imports HynrFramework

Partial Class Tennant
    Implements IHasID

    Public Property ID As Integer Implements IHasID.ID
        Get
            Return TennantID
        End Get
        Set(value As Integer)
            TennantID = value
        End Set
    End Property
End Class

Partial Class Contract
    Implements IHasID

    Public Property ID As Integer Implements IHasID.ID
        Get
            Return ContractID
        End Get
        Set(value As Integer)
            ContractID = value
        End Set
    End Property
End Class

Partial Class Room
    Implements IHasID

    Public Property ID As Integer Implements IHasID.ID
        Get
            Return RoomID
        End Get
        Set(value As Integer)
            RoomID = value
        End Set
    End Property
End Class

Partial Class RunningCost
    Implements IHasID

    Public Property ID As Integer Implements IHasID.ID
        Get
            Return RunningCostID
        End Get
        Set(value As Integer)
            RunningCostID = value
        End Set
    End Property
End Class

Partial Class Flat
    Implements IHasID

    Public Property ID As Integer Implements IHasID.ID
        Get
            Return FlatID
        End Get
        Set(value As Integer)
            FlatID = value
        End Set
    End Property
End Class

Partial Class Rent
    Implements IHasID

    Public Property ID As Integer Implements IHasID.ID
        Get
            Return RentID
        End Get
        Set(value As Integer)
            RentID = value
        End Set
    End Property
End Class

Partial Class FlatIncome
    Implements IHasID

    Public Property ID As Integer Implements IHasID.ID
        Get
            Return FlatID
        End Get
        Set(value As Integer)
            FlatID = value
        End Set
    End Property
End Class

Partial Class Payment
    Implements IHasID

    Public Property ID As Integer Implements IHasID.ID
        Get
            Return PaymentID
        End Get
        Set(value As Integer)
            PaymentID = value
        End Set
    End Property
End Class