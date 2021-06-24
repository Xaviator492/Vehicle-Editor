Public Class Form1

    Dim Control As Controller 'Reference to Controller class
    Dim currentRecord As Integer 'Reference to the current vehicle index
    Dim maxRecord As Integer 'Reference to the maximum index

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Instantiate the colour database
        Control = New Controller
        lblStatus.Text = Control.SetUpColours() + vbNewLine + Control.SetUpCars
        currentRecord = 0

        'Set the maximum count index for number of vehicles
        maxRecord = Control.ReturnCount()

        'Call the display procedure to populate the UI
        displayData()
    End Sub

    Private Sub displayData()
        'Calls the controller class to return attributes from the vehicle objects
        Dim record As String

        record = Control.displayStats(currentRecord)
        Dim split As String() = record.Split(New Char() {","c})
        txtName.Text = Convert.ToString(split(0))
        txtLength.Text = Convert.ToString(split(1))
        txtWidth.Text = Convert.ToString(split(2))
        txtHeight.Text = Convert.ToString(split(3))
        txtCapacity.Text = Convert.ToString(split(4))
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'Adds 1 to index value and calls the display function
        If currentRecord < maxRecord Then
            currentRecord = currentRecord + 1
            Control.displayStats(currentRecord)
        End If

        displayData()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        'Subtracts 1 from index value and calls the display function
        If currentRecord > 0 Then
            currentRecord = currentRecord - 1
            Control.displayStats(currentRecord)
        End If

        displayData()
    End Sub
End Class
