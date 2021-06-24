Public Class Vehicle

    Dim name As String 'Vehicle name
    Dim length As Integer 'Vehicle length in mm
    Dim width As Integer 'Vehicle width in mm
    Dim height As Integer 'Vehicle height in mm
    Dim capacity As Integer 'Engine capacity in cc
    Dim colours As ArrayList 'List of vehicle colours for this model

    Public Sub CreateVehicles(n As String, l As Integer, w As Integer, h As Integer, c As Double)
        name = n
        length = Convert.ToInt32(l)
        width = Convert.ToInt32(w)
        height = Convert.ToInt32(h)
        capacity = Convert.ToInt32(c)

    End Sub

    Public Function ReturnName()
        Return name
    End Function
    Public Function ReturnLength()
        Return length
    End Function
    Public Function ReturnWidth()
        Return width
    End Function
    Public Function ReturnHeight()
        Return height
    End Function
    Public Function ReturnCapacity()
        Return capacity
    End Function
End Class
