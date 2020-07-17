'Student Name: Dakota Parrish
'Student Number: 100764512
'Program Name: Car.vb
'Date: July 16, 2020
'Description: The purpose of this file is to hold the Car class. In this file, there are properties, constructors, 
'property methods, and methods used for the frmCarInventory.vb file.
Option Strict On
Public Class Car

#Region "Properties"
    'Declare a carCount shared property with an integer data type and assign the value of 0.
    Shared carCount As Integer = 0
    'Declare a carID private property with an integer data type and assign the value of 0.
    Private carID As Integer = -1
    'Declare a private, blank carMake property with a string data type.
    Private carMake As String = String.Empty
    'Declare a carModel private blank property with a string data type.
    Private carModel As String = String.Empty
    'Declare a carYear private blank property with a string data type.
    Private carYear As String = String.Empty
    'Declare a carPrice private blank property with a string data type.
    Private carPrice As String = String.Empty
    'Declare a carNewOrUsed private blank property with a boolean data type and assign the value of false.
    Private carNewOrUsed As Boolean = False
#End Region

#Region "Constructors"
    ''' <summary>
    ''' Default constructor - Creates a new object for the Car class.
    ''' </summary>
    Public Sub New()
        'Increments the carCount variable by 1.
        carCount += 1
        'Assigns the carID variable to the carCount variable.
        carID = carCount
    End Sub
    ''' <summary>
    ''' Parameterized constructor - Creates a new instantiated object for the car class with parameters.
    ''' </summary>
    ''' <param name="make"></param>
    ''' <param name="model"></param>
    ''' <param name="year"></param>
    ''' <param name="price"></param>
    ''' <param name="carStatus"></param>

    Public Sub New(make As String, model As String, year As String, price As String, carStatus As Boolean)
        'Increments the carCount variable by 1.
        carCount += 1
        'Assigns the carID variable to the carCount variable.
        carID = carCount
        'Assigns the carMake property to the make parameter.
        Me.Make = make
        'Assigns the carModel property to the model parameter.
        Me.Model = model
        'Assigns the carYear property to the year parameter.
        Me.Year = year
        'Assigns the carPrice property to the price parameter.
        Me.Price = price
        'Assigns the carNewOrUsed property to the carStatus parameter.
        Me.NewOrUsed = carStatus
    End Sub
#End Region

#Region "Property Methods"
    ''' <summary>
    ''' Public Make() property method - Gets and sets the cars' make.
    ''' </summary>
    ''' <returns>carMake</returns>
    Public Property Make() As String
        'Gets and returns the carMake variable.
        Get
            Return carMake
        End Get
        'Sets the carMake variable as the value as a string.
        Set(ByVal value As String)
            carMake = value
        End Set
    End Property
    ''' <summary>
    ''' Public Model() property method - Gets and sets the cars' model.
    ''' </summary>
    ''' <returns>carModel</returns>
    Public Property Model() As String
        'Gets and returns the carModel variable.
        Get
            Return carModel
        End Get
        'Sets the carModel variable as the value as a string.
        Set(ByVal value As String)
            carModel = value
        End Set
    End Property
    ''' <summary>
    ''' Public Year() property method - Gets and sets cars' year.
    ''' </summary>
    ''' <returns>carYear</returns>
    Public Property Year() As String
        'Gets and returns the carYear variable.
        Get
            Return carYear
        End Get
        'Sets the carYear variable as the value as a string.
        Set(ByVal value As String)
            carYear = value
        End Set
    End Property
    ''' <summary>
    ''' Public Price() property method - Gets and sets the cars' price.
    ''' </summary>
    ''' <returns>carPrice</returns>
    Public Property Price() As String
        'Gets and returns the carPrice variable.
        Get
            Return carPrice
        End Get
        'Sets the carPrice variable as the value as a string.
        Set(ByVal value As String)
            carPrice = value
        End Set
    End Property
    ''' <summary>
    ''' Public NewOrUsed() property method - Gets and sets the cars status as New Or Used.
    ''' </summary>
    ''' <returns>carNewOrUsed</returns>
    Public Property NewOrUsed() As Boolean
        'Gets and returns the carNewOrUsed variable.
        Get
            Return carNewOrUsed
        End Get
        'Sets the carNewOrUsed variable as the value as a string.
        Set(ByVal value As Boolean)
            carNewOrUsed = value
        End Set
    End Property
    ''' <summary>
    ''' Public ReadOnly ID() property method - Gets and returns the cars ID.
    ''' </summary>
    ''' <returns>carID</returns>
    Public ReadOnly Property ID() As Integer
        'Gets and returns the carID variable.
        Get
            Return carID
        End Get
    End Property
    ''' <summary>
    ''' Public ReadOnly TotalCars() property method - Gets and returns the total amount of cars value.
    ''' </summary>
    ''' <returns>carCount</returns>
    Public ReadOnly Property TotalCars() As Integer
        'Gets and returns the carCount variable.
        Get
            Return carCount
        End Get
    End Property
#End Region

#Region "Methods"
    ''' <summary>
    ''' Public PrintCarData() function - Used to load the car's data including the year, model, make, and price values.
    ''' </summary>
    ''' <returns>String</returns>
    Public Function PrintCarData() As String
        'Returns a string that loads the car data entered in the listview control.
        Return "A " & Me.Year & " " & Me.Make & " " & Me.Model & " was purchased at a price of " & Me.Price
    End Function
#End Region

End Class
