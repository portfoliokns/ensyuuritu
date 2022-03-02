Imports System.Windows.Forms
Public Class Form1

    Private PaintingBox As New clsPaintingBox()
    Private MonteCalro As New clsMonteCalro()
    Private defTrials As Integer = 7777

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPi.Text = ""
        txtTrials.Text = defTrials
        PaintingBox.Box = PictureBox1
        PaintingBox.initLine()
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        Dim Trials As Integer = txtTrials.Text
        MonteCalro.TotalCount() = Trials
        MonteCalro.calcSimulate()
        txtPi.Text = MonteCalro.PI()

        Dim BlueXGraph() As Double = MonteCalro._BlueXGraph
        Dim BlueYGraph() As Double = MonteCalro._BlueYGraph
        Dim RedXGraph() As Double = MonteCalro._RedXGraph
        Dim RedYGraph() As Double = MonteCalro._RedYGraph

        'PaintingBox.dotLine(Xgraph, Ygraph)
        PaintingBox.dotLine(BlueXGraph, BlueYGraph, RedXGraph, RedYGraph)

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtPi.Text = ""
        txtTrials.Text = defTrials
        PaintingBox.initLine()
    End Sub

    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        Clipboard.SetText(txtPi.Text)
    End Sub
End Class
