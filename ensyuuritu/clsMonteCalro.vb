Public Class clsMonteCalro
    Private _TotalCount As Integer
    Public WriteOnly Property TotalCount() As Integer
        Set(ByVal value As Integer)
            _TotalCount = value
            ReDim _BlueXGraph(_TotalCount - 1)
            ReDim _BlueYGraph(_TotalCount - 1)
            ReDim _RedXGraph(_TotalCount - 1)
            ReDim _RedYGraph(_TotalCount - 1)
        End Set
    End Property

    Public _BlueXGraph(_TotalCount - 1) As Double
    Public _BlueYGraph(_TotalCount - 1) As Double
    Public _RedXGraph(_TotalCount - 1) As Double
    Public _RedYGraph(_TotalCount - 1) As Double

    Private InsideCount As Integer
    Private AllCount As Integer
    Private _PI As Double
    Public ReadOnly Property PI() As Double
        Get
            Return _PI
        End Get
    End Property

    Private BlueArrayCount = 0
    Private RedArrayCount = 0

    Public Sub calcSimulate()
        InsideCount = 0
        AllCount = 0
        BlueArrayCount = 0
        RedArrayCount = 0

        Dim x As Double
        Dim y As Double
        While (AllCount <= _TotalCount - 1)
            getRandXY(x, y)
            calcCountDott(x, y)
        End While
    End Sub

    Dim rx As New System.Random(3333333)
    Dim ry As New System.Random(7777777)
    Private Sub getRandXY(ByRef x As Double, ByRef y As Double)
        x = rx.NextDouble()
        y = rx.NextDouble()
        x = xValue(x)
        y = yValue(y)
    End Sub

    Private Sub calcCountDott(ByRef x As Double, ByRef y As Double)
        If x ^ 2 + y ^ 2 <= 1 Then
            InsideCount += 1
            saveBlueXYCoordinate(x, y)
        Else
            saveRedXYCoordinate(x, y)
        End If
        AllCount += 1

        _PI = (InsideCount / AllCount) * 4
    End Sub


    Private Sub saveBlueXYCoordinate(ByRef x As Double, ByRef y As Double)
        _BlueXGraph(BlueArrayCount) = x
        _BlueYGraph(BlueArrayCount) = y
        BlueArrayCount += 1
    End Sub

    Private Sub saveRedXYCoordinate(ByRef x As Double, ByRef y As Double)
        _RedXGraph(RedArrayCount) = x
        _RedYGraph(RedArrayCount) = y
        RedArrayCount += 1
    End Sub

    Dim xpm As New System.Random(5555555) 'p:+,m:-
    Private Function xValue(ByRef x As Double) As Double

        If xpm.NextDouble >= 0.5 Then
            x = -x
        End If

        Return x
    End Function

    Dim ypm As New System.Random(9999999) 'p:+,m:-
    Private Function yValue(ByRef y As Double) As Double

        If ypm.NextDouble >= 0.5 Then
            y = -y
        End If

        Return y
    End Function

End Class
