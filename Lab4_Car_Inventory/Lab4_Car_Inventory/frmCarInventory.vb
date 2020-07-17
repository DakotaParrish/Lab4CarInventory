'Student Name: Dakota Parrish
'Student Number: 100764512
'Program Name: Lab 4 - Car Inventory
'Date: July 16, 2020
'Description: This purpose of this program is to keep track of a car's inventory. The user is open to entering
'a cars' make, model, year, price, and the status of the car being New or Used. The program will validate the users input
'and if the validation fails, the user will be notified via error messages in an output textbox. Otherwise, if the 
'validation is successful, the information will be added to a list view and a message telling the user that the car's data
'was updated. If there was a mistake in entering the information for the car, the user is given a chance to go back and edit
'the data, with a message telling the user that the information was edited. The user can also clear all input fields from
'via a reset button and of course close the program by clicking on an exit button.

Option Strict On
Public Class frmCarInventory
#Region "Variables and Constants"
    'Declares a MIN_CAR_YEAR constant variable as an integer and assign the value of 1920.
    Const MIN_CAR_YEAR As Integer = 1920
    'Declares a MAX_CAR_YEAR constant variable as an integer and assign the value of 2020.
    Const MAX_CAR_YEAR As Integer = 2020
    'Declares a MIN_CAR_PRICE constant variable as an decimal and assign the value of 0.
    Const MIN_CAR_PRICE As Decimal = 0
    'Declare a new list of cars.
    Dim cars As New List(Of Car)
    'Declare a boolean variable called editMode and assign the value of false to it.
    Dim editMode As Boolean = False
    'Declare a boolean variable called updatingData and assign the value of false to it
    Dim updatingData As Boolean = False
    'Declare an integer varibale called currentSelectedIndex and assign the value of -1 to it.
    Dim currentlySelectedIndex As Integer = -1
#End Region

#Region "Event Handlers"
    ''' <summary>
    ''' ExitButtonClick event handler - Used to gracefully close the program when the exit button is clicked.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ExitButtonClick(sender As Object, e As EventArgs) Handles btnExit.Click
        'Closes the program.
        Application.Exit()
    End Sub
    ''' <summary>
    ''' ResetButtonClick event hander - Used to reset the form and clear all input fields when the reset button is clicked.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ResetButtonClick(sender As Object, e As EventArgs) Handles btnReset.Click
        'Calls the ResetForm() function.
        ResetForm()
    End Sub
    ''' <summary>
    ''' EnterButtonClick event handler - Used to validate and once validated enter the car's information into a listbox with
    ''' a confirmation message in an output textbox once the enter button is clicked.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub EnterButtonClick(sender As Object, e As EventArgs) Handles btnEnter.Click
        'Declares an inputCarMake variable as a string and assign the value to the cbMake controls' text property.
        Dim inputCarMake As String = cbMake.Text
        'Declares an inputCarModel variable as a string and assigns the value to the txtModel controls' text property.
        Dim inputCarModel As String = txtModel.Text
        'Declares an inputCarYear variable as a string and assigns the value to the cbYear controls' text property.
        Dim inputCarYear As String = cbYear.Text
        'Declares an inputCarPrice variable as a string and assigns the value to the txtPrice controls' text property.
        Dim inputCarPrice As String = txtPrice.Text
        'Declares an inputCarStatus variable as a boolean and assigns the value to the ckState controls' checked property.
        Dim inputCarStatus As Boolean = ckState.Checked
        'Declares an errorMessages variable as a string and assigns the value to the ValidateInputs() function.
        Dim errorMessages As String = ValidateInputs(inputCarMake, inputCarModel, inputCarYear, inputCarPrice)
        'Declares a car variable to hold the Car class.
        Dim car As Car

        'Checks to see if the errorMessages string is empty or not.
        If (String.IsNullOrEmpty(errorMessages)) Then
            'Validation Success
            'Checks to see if you are in editMode to edit any data in the listview.
            If (editMode) Then
                'Editing an existing car in the list
                'Edits the cars make.
                cars(currentlySelectedIndex).Make = inputCarMake
                'Edits the car model.
                cars(currentlySelectedIndex).Model = inputCarModel
                'Edits the car year.
                cars(currentlySelectedIndex).Year = inputCarYear
                'Edits the car price.
                cars(currentlySelectedIndex).Price = inputCarPrice
                'Edits the car status.
                cars(currentlySelectedIndex).NewOrUsed = inputCarStatus

                'Calls the UpdateCarList() sub procedure.
                UpdateCarList()
                'Calls the ResetForm() sub procedure.
                ResetForm()
                'Displays a message in the output textbox that says 'updated car data in list'.
                lblOutput.Text = "Updated car data in list"
                'If you are NOT in edit mode.
            Else
                'Adds a new car to the listview control.
                car = New Car(inputCarMake, inputCarModel, inputCarYear, inputCarPrice, inputCarStatus)
                cars.Add(car)

                'Calls the UpdateCarList() sub procedure.
                UpdateCarList()
                'Calls the ResetForm() sub procedure.
                ResetForm()
                'Displays a message in the output textbox that says 'Added new car to list'.
                lblOutput.Text = "Added new car to list"
            End If

        Else
            'Validation failed - Error message(s) is displayed to the user in the output textbox.
            lblOutput.Text = errorMessages
        End If
    End Sub

    Private Sub ListSelectedIndexChanged(sender As Object, e As EventArgs) Handles lvCarInventory.SelectedIndexChanged
        Dim car As Car

        If (Not lvCarInventory.FocusedItem Is Nothing) Then
            currentlySelectedIndex = lvCarInventory.FocusedItem.Index
            car = cars(currentlySelectedIndex)

            editMode = True

            cbMake.Text = car.Make
            txtModel.Text = car.Model
            cbYear.Text = car.Year
            txtPrice.Text = car.Price
            ckState.Checked = car.NewOrUsed

            lblOutput.Text = car.PrintCarData()
        End If
    End Sub

    Private Sub NewOrUsedCheck(sender As Object, e As ItemCheckEventArgs) Handles lvCarInventory.ItemCheck
        If (Not updatingData) Then
            e.NewValue = e.CurrentValue

        End If
    End Sub

#End Region

#Region "Subs and Functions"
    ''' <summary>
    ''' ValidateInputs Function - Used to validate for blank input for the cars' make, model, year, and price. It also
    ''' checks to see if the cars' price and year is a numeric value and falls within the range of 1920 and 2020. 
    ''' Also checks to see if the price is greater than 0.
    ''' </summary>
    ''' <param name="make"></param>
    ''' <param name="model"></param>
    ''' <param name="year"></param>
    ''' <param name="price"></param>
    ''' <returns></returns>
    Function ValidateInputs(make As String, model As String, year As String, price As String) As String
        'Declares an errorMessage variable as a string and assigns it a blank value.
        Dim errorMessage As String = String.Empty
        'Declares a numericCarYear integer variable.
        Dim numericCarYear As Integer
        'Declares a numericCarPrice decimal variable.
        Dim numericCarPrice As Decimal

        'Validates to see if the cars' make is blank.
        If (String.IsNullOrWhiteSpace(make)) Then
            'Displays an error message telling the user to select a car make.
            errorMessage += "Please select a car make " & Environment.NewLine
        End If
        'Validates to see if the cars' model is blank.
        If (String.IsNullOrWhiteSpace(model)) Then
            'Displays an error message telling the user to type a valid car model.
            errorMessage += "Please enter a valid car model " & Environment.NewLine
        End If
        'Validates to see if the cars' year input is an integer value.
        If (Integer.TryParse(year, numericCarYear)) Then
            'Validates to see if the cars' year is within the MIN_CAR_YEAR and MAX_CAR_YEAR range.
            If (numericCarYear < MIN_CAR_YEAR Or numericCarYear > MAX_CAR_YEAR) Then
                'Displays an error message telling the user to select a valid car year.
                errorMessage += "Please select a valid car year from 1920 to 2020 " & Environment.NewLine
            End If
        Else
            'Displays an error message telling the user to select a valid car year.
            errorMessage += "Please select a valid car year from 1920 to 2020 " & Environment.NewLine
        End If
        'Validates to see if the cars' price is a decimal value.
        If (Decimal.TryParse(price, numericCarPrice)) Then
            'Validates to see if the cars' price is less than the MIN_CAR_PRICE value.
            If (numericCarPrice < MIN_CAR_PRICE) Then
                'Displays an error message telling the user to select a valid car price.
                errorMessage += "Please enter a valid car price " & Environment.NewLine
            End If
        Else
            'Displays an error message telling the user to select a valid car price.
            errorMessage += "Please enter a valid car price " & Environment.NewLine
        End If
        'Returns the errorMessage variable.
        Return errorMessage
    End Function
    ''' <summary>
    ''' ResetForm() Sub procedure - Used to clear all input fields and display to the user a message that states
    ''' that the form has been cleared.
    ''' </summary>
    Private Sub ResetForm()
        'Clears the selected indexes from the lvCarInventory control.
        lvCarInventory.SelectedIndices.Clear()

        'Clears the make input field.
        cbMake.SelectedIndex = -1
        'Clears the model input field.
        txtModel.Text = String.Empty
        'Clears the year input field.
        cbYear.SelectedIndex = -1
        'Clears the price input field.
        txtPrice.Text = String.Empty
        'Unchecks the car status input checkbox.
        ckState.Checked = False
        'Sets the edit mode to false.
        editMode = False
        'Displays a message telling the user that the form has been cleared.
        lblOutput.Text = "Form has been cleared for re-entry of car data"
    End Sub
    ''' <summary>
    ''' UpdateCarList() sub procedure - Used to take all of the user's input from the input fields and store it in a listview
    ''' box.
    ''' </summary>
    Private Sub UpdateCarList()
        'Declares a carListItem variable as a list view item.
        Dim carListItem As ListViewItem

        'Sets the updatingData variable to true.
        updatingData = True
        'Clears the list view's items.
        lvCarInventory.Items.Clear()

        'For each used for each 'car' variable in the 'Car' class in the 'cars' list
        For Each car As Car In cars
            'Assigns the carListItem variable as a new list view item.
            carListItem = New ListViewItem()

            'Adds an item for the car status using the 'Car' classes' NewOrUsed property method.
            carListItem.Checked = car.NewOrUsed
            'Adds a sub item for the car ID using the 'Car' classes' ID property method and converts it to a string.
            carListItem.SubItems.Add(car.ID.ToString())
            'Adds a sub item for the car make using the 'Car' classes' Make property method.
            carListItem.SubItems.Add(car.Make)
            'Adds a sub item for the car model using the 'Car' classes' Model property method.
            carListItem.SubItems.Add(car.Model)
            'Adds a sub item for the car year using the 'Car' classes' Year property method.
            carListItem.SubItems.Add(car.Year)
            'Adds a sub item for the car price using the 'Car' classes' Price property method.
            carListItem.SubItems.Add("$" + car.Price)

            'Adds all of the sub items from the list into the list view for the car inventory.
            lvCarInventory.Items.Add(carListItem)
        Next
        'Sets the updatingData variable to false.
        updatingData = False
    End Sub
#End Region
End Class
