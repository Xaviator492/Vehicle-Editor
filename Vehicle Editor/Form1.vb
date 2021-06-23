Public Class Form1

    Dim Control As Controller 'Reference to Controller class

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Instantiate the colour database
        Control = New Controller
        lblStatus.Text = Control.SetUpColours() + vbNewLine + Control.SetUpCars


    End Sub

    Private Sub displayData()

    End Sub

End Class
