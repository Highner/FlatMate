Imports HynrFramework
<Serializable>
Public Class TennantData
    Implements IHasID

    Public Property ID As Integer Implements IHasID.ID
    Public Property Name As String
    Public Property FlatID As Integer
    Public Property Settled As Boolean?
End Class
<Serializable>
Public Class ContractData
    Implements IHasID

    Public Property ID As Integer Implements IHasID.ID
    Public Property TennantID As Integer
    Public Property ValidFrom As Date?
    Public Property ValidTo As Date?
    Public Property RentModifier As Decimal?
    Public Property FixedRent As Boolean?
    Public Property FixedRentAmount As Decimal?
    Public Property Settled As Boolean?
End Class
<Serializable>
Public Class RoomData
    Implements IHasID

    Public Property ID As Integer Implements IHasID.ID
    Public Property FlatID As Integer
    Public Property Size As Decimal?
    Public Property CalculationSize As Decimal?
    Public Property Name As String
End Class
<Serializable>
Public Class RunningCostData
    Implements IHasID

    Public Property ID As Integer Implements IHasID.ID
    Public Property FlatID As Integer
    Public Property Name As String
    Public Property Amount As Decimal?
    Public Property ValidFrom As Date?
    Public Property ValidTo As Date?
End Class
<Serializable>
Public Class FlatData
    Implements IHasID

    Public Property ID As Integer Implements IHasID.ID
    Public Property FlatName As String
End Class
<Serializable>
Public Class RentData
    Implements IHasID

    Public Property ID As Integer Implements IHasID.ID
    Public Property FlatID As Integer
    Public Property ValidFrom As Date?
    Public Property ValidTo As Date?
    Public Property Amount As Decimal?
End Class
<Serializable>
Public Class FlatIncomeData
    Implements IHasID

    Public Property ID As Integer Implements IHasID.ID
    Public Property Name As String
    Public Property [Date] As Date?
    Public Property Amount As Decimal?
    Public Property Remarks As String
    Public Property FlatID As Integer
End Class
<Serializable>
Public Class PaymentData
    Implements IHasID

    Public Property ID As Integer Implements IHasID.ID
    Public Property TennantID As Integer
    Public Property Amount As Decimal
    Public Property PaymentDate As Date
End Class