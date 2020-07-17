<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarInventory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblMake = New System.Windows.Forms.Label()
        Me.cbMake = New System.Windows.Forms.ComboBox()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.cbYear = New System.Windows.Forms.ComboBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.ckState = New System.Windows.Forms.CheckBox()
        Me.lblState = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ttCarInventoryTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.lvCarInventory = New System.Windows.Forms.ListView()
        Me.colNewOrUsed = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colCarID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colCarMake = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colCarModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colCarYear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colCarPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblMake
        '
        Me.lblMake.Location = New System.Drawing.Point(25, 22)
        Me.lblMake.Name = "lblMake"
        Me.lblMake.Size = New System.Drawing.Size(54, 23)
        Me.lblMake.TabIndex = 0
        Me.lblMake.Text = "&Make:"
        Me.lblMake.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbMake
        '
        Me.cbMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMake.FormattingEnabled = True
        Me.cbMake.Items.AddRange(New Object() {"Acura", "Audi", "BMW", "Buick", "Cadillac", "Chevrolet", "Chrysler", "Dodge", "Ferrari", "Ford", "GMC", "Honda", "Hyundai", "Infiniti", "Jeep", "KIA", "Lamborghini", "Lexus", "Mazda", "Mercedes-Benz", "Mitsubishi", "Nissan", "Subaru", "Tesla", "Toyota", "Volkswagen"})
        Me.cbMake.Location = New System.Drawing.Point(85, 22)
        Me.cbMake.Name = "cbMake"
        Me.cbMake.Size = New System.Drawing.Size(121, 21)
        Me.cbMake.Sorted = True
        Me.cbMake.TabIndex = 1
        Me.ttCarInventoryTips.SetToolTip(Me.cbMake, "Select a cars make")
        '
        'lblModel
        '
        Me.lblModel.Location = New System.Drawing.Point(25, 45)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(54, 23)
        Me.lblModel.TabIndex = 2
        Me.lblModel.Text = "M&odel:"
        Me.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(85, 49)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(121, 20)
        Me.txtModel.TabIndex = 3
        Me.ttCarInventoryTips.SetToolTip(Me.txtModel, "Enter the cars model")
        '
        'lblYear
        '
        Me.lblYear.Location = New System.Drawing.Point(25, 75)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(54, 23)
        Me.lblYear.TabIndex = 4
        Me.lblYear.Text = "&Year:"
        Me.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbYear
        '
        Me.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbYear.FormattingEnabled = True
        Me.cbYear.Items.AddRange(New Object() {"1920", "1921", "1922", "1923", "1924", "1925", "1926", "1927", "1928", "1929", "1930", "1931", "1932", "1933", "1934", "1935", "1936", "1937", "1938", "1939", "1940", "1941", "1942", "1943", "1944", "1945", "1946", "1947", "1948", "1949", "1950", "1951", "1952", "1953", "1954", "1955", "1956", "1957", "1958", "1959", "1960", "1961", "1962", "1963", "1964", "1965", "1966", "1967", "1968", "1969", "1970", "1971", "1972", "1973", "1974", "1975", "1976", "1977", "1978", "1979", "1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020"})
        Me.cbYear.Location = New System.Drawing.Point(85, 75)
        Me.cbYear.Name = "cbYear"
        Me.cbYear.Size = New System.Drawing.Size(121, 21)
        Me.cbYear.Sorted = True
        Me.cbYear.TabIndex = 5
        Me.ttCarInventoryTips.SetToolTip(Me.cbYear, "Select a year from 1920-2020")
        '
        'lblPrice
        '
        Me.lblPrice.Location = New System.Drawing.Point(25, 102)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(54, 23)
        Me.lblPrice.TabIndex = 6
        Me.lblPrice.Text = "&Price:"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(85, 102)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(121, 20)
        Me.txtPrice.TabIndex = 7
        Me.ttCarInventoryTips.SetToolTip(Me.txtPrice, "Type to enter a price of the car")
        '
        'ckState
        '
        Me.ckState.AutoSize = True
        Me.ckState.Location = New System.Drawing.Point(85, 130)
        Me.ckState.Name = "ckState"
        Me.ckState.Size = New System.Drawing.Size(15, 14)
        Me.ckState.TabIndex = 9
        Me.ttCarInventoryTips.SetToolTip(Me.ckState, "Check to confirm the car is new, leave unchecked if the car is used.")
        Me.ckState.UseVisualStyleBackColor = True
        '
        'lblState
        '
        Me.lblState.Location = New System.Drawing.Point(41, 125)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(38, 23)
        Me.lblState.TabIndex = 8
        Me.lblState.Text = "&New:"
        Me.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(242, 435)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 12
        Me.btnEnter.Text = "&Enter"
        Me.ttCarInventoryTips.SetToolTip(Me.btnEnter, "Confirms all of the cars information to be added to the car inventory")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(323, 435)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 13
        Me.btnReset.Text = "&Reset"
        Me.ttCarInventoryTips.SetToolTip(Me.btnReset, "Clears all input fields")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(404, 435)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "E&xit"
        Me.ttCarInventoryTips.SetToolTip(Me.btnExit, "Closes the program")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lvCarInventory
        '
        Me.lvCarInventory.CheckBoxes = True
        Me.lvCarInventory.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNewOrUsed, Me.colCarID, Me.colCarMake, Me.colCarModel, Me.colCarYear, Me.colCarPrice})
        Me.lvCarInventory.FullRowSelect = True
        Me.lvCarInventory.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvCarInventory.HideSelection = False
        Me.lvCarInventory.Location = New System.Drawing.Point(12, 151)
        Me.lvCarInventory.MultiSelect = False
        Me.lvCarInventory.Name = "lvCarInventory"
        Me.lvCarInventory.Size = New System.Drawing.Size(467, 154)
        Me.lvCarInventory.TabIndex = 10
        Me.ttCarInventoryTips.SetToolTip(Me.lvCarInventory, "Displays all of the cars' inventory data.")
        Me.lvCarInventory.UseCompatibleStateImageBehavior = False
        Me.lvCarInventory.View = System.Windows.Forms.View.Details
        '
        'colNewOrUsed
        '
        Me.colNewOrUsed.Text = "New"
        '
        'colCarID
        '
        Me.colCarID.Text = "ID"
        '
        'colCarMake
        '
        Me.colCarMake.Text = "Make"
        '
        'colCarModel
        '
        Me.colCarModel.Text = "Model"
        '
        'colCarYear
        '
        Me.colCarYear.Text = "Year"
        '
        'colCarPrice
        '
        Me.colCarPrice.Text = "Price"
        '
        'lblOutput
        '
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput.Location = New System.Drawing.Point(12, 308)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(468, 118)
        Me.lblOutput.TabIndex = 15
        Me.ttCarInventoryTips.SetToolTip(Me.lblOutput, "Displays all error messages, and car info messages.")
        '
        'frmCarInventory
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(492, 465)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.lvCarInventory)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.ckState)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.cbYear)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.cbMake)
        Me.Controls.Add(Me.lblMake)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCarInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car Inventory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMake As Label
    Friend WithEvents cbMake As ComboBox
    Friend WithEvents lblModel As Label
    Friend WithEvents txtModel As TextBox
    Friend WithEvents lblYear As Label
    Friend WithEvents cbYear As ComboBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents ckState As CheckBox
    Friend WithEvents lblState As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents ttCarInventoryTips As ToolTip
    Friend WithEvents lvCarInventory As ListView
    Friend WithEvents colNewOrUsed As ColumnHeader
    Friend WithEvents colCarID As ColumnHeader
    Friend WithEvents colCarMake As ColumnHeader
    Friend WithEvents colCarModel As ColumnHeader
    Friend WithEvents colCarYear As ColumnHeader
    Friend WithEvents colCarPrice As ColumnHeader
    Friend WithEvents lblOutput As Label
End Class
