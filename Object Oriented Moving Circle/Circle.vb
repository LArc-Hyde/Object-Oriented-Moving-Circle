Public Class Circle
    Private m_x As Integer 'Distance from left
    ' side of picture box to circle 
    Private m_y As Integer 'Distance from top
    '                  of picture box to circle 
    Private m_d As Integer 'Diameter of circle

    Public Property Xcoord() As Integer
        Get
            Return m_x
        End Get
        Set(value As Integer)
            m_x = value
        End Set
    End Property
    Public Property Ycoord() As Integer
        Get
            Return m_y
        End Get
        Set(value As Integer)
            m_y = value
        End Set
    End Property
    Public Property Diameter() As Integer
        Get
            Return m_d
        End Get
        Set(value As Integer)
            m_d = value
        End Set
    End Property

    Public Sub New()
        'Set the initial location of the
        'circle to the upper left corner of
        'the picture box, and set its
        'diameter to 40 pixels.    
        Xcoord = 0
        Ycoord = 0
        Diameter = 400
    End Sub

    Public Sub New(Dia As Integer)
        'Set the initial location of the
        'circle to the upper left corner of
        'the picture box, and set its
        'diameter to user specified pixels.    
        Xcoord = 0
        Ycoord = 0
        Diameter = Dia
    End Sub

    Sub Show(g As Graphics)
        'Draw a circle with given specifications
        g.DrawEllipse(Pens.Black, Xcoord,
                 Ycoord, Diameter, Diameter)
    End Sub
    Sub Move(distance As Integer)
        Xcoord += distance
        Ycoord += distance
        RaiseEvent PositionChanged(Xcoord, Ycoord, Diameter)

    End Sub

    Public Event PositionChanged(x As Integer, y As Integer, d As Integer)



End Class
