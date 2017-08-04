Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Dim Z As Boolean
    Dim myBrush As New SolidBrush(Color.Black)
    Dim LineStart As Point
    Dim LinePressed As Boolean

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Dim draw As System.Drawing.Graphics
        draw = Me.CreateGraphics
        Dim X As Integer = Form1.MousePosition.X - Me.Location.X - 10
        Dim Y As Integer = Form1.MousePosition.Y - Me.Location.Y - 35

        If Z = True Then
            draw.FillEllipse(myBrush, X, Y, VScrollBar1.Value, VScrollBar1.Value)
        End If
    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        Z = True
        Dim draw As System.Drawing.Graphics
        draw = Me.CreateGraphics
        Dim X As Integer = Form1.MousePosition.X - Me.Location.X - 10
        Dim Y As Integer = Form1.MousePosition.Y - Me.Location.Y - 35
        Linestart = New Point(X, Y)
    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        Z = False
        Dim draw As System.Drawing.Graphics
        draw = Me.CreateGraphics
        Dim X As Integer = Form1.MousePosition.X - Me.Location.X - 10
        Dim Y As Integer = Form1.MousePosition.Y - Me.Location.Y - 35
        Dim LineEnd As Point
        LineEnd = New Point(X, Y)
        If LinePressed = True Then
            draw.DrawLine(New Pen(myBrush.Color, VScrollBar1.Value), LineStart, LineEnd)
        End If
    End Sub

    Private Sub RedButton_Click(sender As Object, e As EventArgs) Handles RedButton.Click
        myBrush.Color = Color.Red
    End Sub

    Private Sub BlueButton_Click(sender As Object, e As EventArgs) Handles BlueButton.Click
        myBrush.Color = Color.Blue
    End Sub

    Private Sub GreenButton_Click(sender As Object, e As EventArgs) Handles GreenButton.Click
        myBrush.Color = Color.Green
    End Sub

    Private Sub OrangeButton_Click(sender As Object, e As EventArgs) Handles OrangeButton.Click
        myBrush.Color = Color.Orange
    End Sub

    Private Sub YellowButton_Click(sender As Object, e As EventArgs) Handles YellowButton.Click
        myBrush.Color = Color.Yellow
    End Sub

    Private Sub GrayButton_Click(sender As Object, e As EventArgs) Handles GrayButton.Click
        myBrush.Color = Color.Gray
    End Sub

    Private Sub BlackButton_Click(sender As Object, e As EventArgs) Handles BlackButton.Click
        myBrush.Color = Color.Black
    End Sub

    Private Sub ClearScreenButton_Click(sender As Object, e As EventArgs) Handles EraserButton.Click
        myBrush.Color = Color.White
    End Sub
    Private Sub PurpleButton_Click(sender As Object, e As EventArgs) Handles PurpleButton.Click
        myBrush.Color = Color.Purple
    End Sub
    Private Sub PinkButton_Click(sender As Object, e As EventArgs) Handles PinkButton.Click
        myBrush.Color = Color.Pink
    End Sub

    Private Sub Form1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Me.MouseDoubleClick
        myBrush.Color = Color.LightGoldenrodYellow
    End Sub

    Private Sub Form1_MouseWheel(sender As Object, e As MouseEventArgs) Handles Me.MouseWheel
        myBrush.Color = Color.LightYellow
    End Sub

    Private Sub LineButton_Click(sender As Object, e As EventArgs) Handles LineButton.Click
        LinePressed = True
        Z = False
    End Sub

    Private Sub BrushButton_Click(sender As Object, e As EventArgs) Handles BrushButton.Click
        LinePressed = False
        Z = True
    End Sub
End Class
