Public Class Colour

    'This class is used to store the colour of the vehicle in RGB
    Dim name As String 'Colour name e.g. "Garnet Red"
    Dim Rc As Integer 'Red value
    Dim Gc As Integer 'Green value
    Dim Bc As Integer 'Blue value
    Public Id As Integer 'Identifier
    Dim shade As String 'basic colour e.g. "Red"

    Public Sub CreateColours(r As String, g As String, b As String, i As String, n As String, s As String)
        Rc = Convert.ToInt32(r)
        Gc = Convert.ToInt32(g)
        Bc = Convert.ToInt32(b)
        Id = Convert.ToInt32(i)
        name = n
        shade = s

    End Sub

    Public Function ReturnRGB()
        Return Rc
        Return Bc
        Return Gc
    End Function
End Class
