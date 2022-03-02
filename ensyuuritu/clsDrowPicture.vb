Public Class clsPaintingBox
    Private Class Calro
        Inherits Form1
    End Class

    Private AxisLength As Integer = 800
    Private XAxisYposition As Integer = 200
    Private YAxisXposition As Integer = 200

    Private _Box As PictureBox
    Public Property Box() As PictureBox
            Get
                Return _Box
            End Get
            Set(ByVal value As PictureBox)
                _Box = value
            End Set
        End Property

    Public Sub initLine()

        Dim canvas As New Bitmap(_Box.Width, _Box.Height)

        'ImageオブジェクトのGraphicsオブジェクトを作成する
        Dim g As Graphics = Graphics.FromImage(canvas)
        g.DrawLine(Pens.Black, 0, YAxisXposition, AxisLength, YAxisXposition)
        g.DrawLine(Pens.Black, XAxisYposition, 0, XAxisYposition, AxisLength)

        'リソースを解放する
        g.Dispose()

        'PictureBox1に表示する
        Box.Image = canvas

    End Sub

    Public Overloads Sub dotLine(ByRef XData() As Double, ByRef YData() As Double)
        'Dim x As Integer
        'Dim y As Integer

        Dim canvas As New Bitmap(_Box.Width, _Box.Height)

        'ImageオブジェクトのGraphicsオブジェクトを作成する
        Dim g As Graphics = Graphics.FromImage(canvas)
        g.DrawLine(Pens.Black, 0, YAxisXposition, AxisLength, YAxisXposition)
        g.DrawLine(Pens.Black, XAxisYposition, 0, XAxisYposition, AxisLength)

        Dim xPosition As Integer
        Dim yPosition As Integer
        For index = 0 To XData.Length - 1
            If XData(index) = 0 And YData(index) = 0 Then
                Exit For
            End If
            xPosition = xPosi(XData(index))
            yPosition = yPosi(YData(index))
            g.DrawLine(Pens.Blue, xPosition, yPosition, xPosition, yPosition + 1)
        Next

        'リソースを解放する
        g.Dispose()

        'PictureBox1に表示する
        Box.Image = canvas

    End Sub

    Public Overloads Sub dotLine(ByRef XData() As Double, ByRef YData() As Double, ByRef X2Data() As Double, ByRef Y2Data() As Double)
        'Dim x As Integer
        'Dim y As Integer

        Dim canvas As New Bitmap(_Box.Width, _Box.Height)

        'ImageオブジェクトのGraphicsオブジェクトを作成する
        Dim g As Graphics = Graphics.FromImage(canvas)
        g.DrawLine(Pens.Black, 0, YAxisXposition, AxisLength, YAxisXposition)
        g.DrawLine(Pens.Black, XAxisYposition, 0, XAxisYposition, AxisLength)

        Dim xPosition As Integer
        Dim yPosition As Integer
        For index = 0 To XData.Length - 1
            If XData(index) = 0 And YData(index) = 0 Then
                Exit For
            End If
            xPosition = xPosi(XData(index))
            yPosition = yPosi(YData(index))
            g.DrawLine(Pens.Blue, xPosition, yPosition, xPosition, yPosition + 1)
        Next

        For index = 0 To X2Data.Length - 1
            If X2Data(index) = 0 And Y2Data(index) = 0 Then
                Exit For
            End If
            xPosition = xPosi(X2Data(index))
            yPosition = yPosi(Y2Data(index))
            g.DrawLine(Pens.Red, xPosition, yPosition, xPosition, yPosition + 1)
        Next

        'リソースを解放する
        g.Dispose()

        'PictureBox1に表示する
        Box.Image = canvas

    End Sub

    Private Function xPosi(ByRef x As Double) As Integer
        Return XAxisYposition + CInt(x * 200)
    End Function

    Private Function yPosi(ByRef y As Double) As Integer

        Return YAxisXposition - CInt(y * 200)
    End Function

End Class
