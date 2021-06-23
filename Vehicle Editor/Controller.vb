Public Class Controller
    'Controller class for the program. This will handle all functions.

    Dim allColours As ArrayList 'Stores every colour
    Dim allCars As ArrayList 'Stores every car
    Dim colours As Colour 'Reference to a colour class
    Dim vehicles

    Public Function SetUpColours()
        'Function to read colours from the file and return a confirmation string when completed
        Dim File As String = "C:\Users\rb25d\Documents\Visual Studio 2015\Projects\Vehicle Editor\Vehicle Editor\bin\Debug\Carcols.txt"
        If System.IO.File.Exists(File) = True Then
            'If the file exists then read all lines
            Dim fileReader As System.IO.StreamReader
            Dim stringReader As String
            allColours = New ArrayList

            fileReader = My.Computer.FileSystem.OpenTextFileReader(File)

            'Read each line from the Carcol file
            Do Until fileReader.EndOfStream
                colours = New Colour
                stringReader = fileReader.ReadLine()
                Dim words As String() = stringReader.Split(New Char() {","c})
                colours.CreateColours(words(0), words(1), words(2), words(3), words(4), words(5))
                'Add to arraylist
                allColours.Add(colours)
            Loop
            Return "Colours loaded successfully!"
        Else
            'If file is not loaded properly
            MsgBox("File Does Not Exist")
            Return "Error loading file!"
        End If
    End Function

    Public Function SetUpCars()
        'Function to read vehicles from the file and return confirmation string when completed
        Dim File As String = "C:\Users\rb25d\Documents\Visual Studio 2015\Projects\Vehicle Editor\Vehicle Editor\bin\Debug\Vehicles.txt"
        If System.IO.File.Exists(File) = True Then
            Dim filereader As System.IO.StreamReader
            Dim stringReader As String
            allCars = New ArrayList

            filereader = My.Computer.FileSystem.OpenTextFileReader(File)

            Do Until filereader.EndOfStream
                vehicles = New Vehicle
                stringReader = filereader.ReadLine()
                Dim words As String() = stringReader.Split(New Char() {","c})
                vehicles.CreateVehicles(words(0), words(1), words(2), words(3), words(4))

                allCars.Add(vehicles)
            Loop

            Return "Vehicles loaded successfully!"
        Else

            Return "Error loading file!"
        End If


    End Function
End Class
