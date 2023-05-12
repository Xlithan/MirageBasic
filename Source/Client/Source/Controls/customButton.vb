Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.ComponentModel

Public Class CustomButton
    Inherits Button

    Private iBorderSize As Integer = 0
    Private iBorderRadius As Integer = 0
    Private cBorderColor As Color = Color.PaleVioletRed

    <Category("CustomButton Advance")>
    Public Property BorderSize As Integer
        Get
            Return iBorderSize
        End Get
        Set(ByVal value As Integer)
            iBorderSize = value
            Me.Invalidate()
        End Set
    End Property

    <Category("CustomButton Advance")>
    Public Property BorderRadius As Integer
        Get
            Return iBorderRadius
        End Get
        Set(ByVal value As Integer)
            iBorderRadius = value
            Me.Invalidate()
        End Set
    End Property

    <Category("CustomButton Advance")>
    Public Property BorderColor As Color
        Get
            Return cBorderColor
        End Get
        Set(ByVal value As Color)
            cBorderColor = value
            Me.Invalidate()
        End Set
    End Property

    <Category("CustomButton Advance")>
    Public Property BackgroundColor As Color
        Get
            Return Me.BackColor
        End Get
        Set(ByVal value As Color)
            Me.BackColor = value
        End Set
    End Property

    <Category("CustomButton Advance")>
    Public Property TextColor As Color
        Get
            Return Me.ForeColor
        End Get
        Set(ByVal value As Color)
            Me.ForeColor = value
        End Set
    End Property

    Public Sub New()
        Me.FlatStyle = FlatStyle.Flat
        Me.FlatAppearance.BorderSize = 0
        Me.Size = New Size(150, 40)
        Me.BackColor = Color.MediumSlateBlue
        Me.ForeColor = Color.White
        AddHandler Me.Resize, New EventHandler(AddressOf Button_Resize)
    End Sub

    Private Function GetFigurePath(ByVal rect As Rectangle, ByVal radius As Integer) As GraphicsPath
        Dim path As GraphicsPath = New GraphicsPath()
        Dim curveSize As Single = radius * 2.0F
        path.StartFigure()
        path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90)
        path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90)
        path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90)
        path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90)
        path.CloseFigure()
        Return path
    End Function

    Protected Overrides Sub OnPaint(ByVal pevent As PaintEventArgs)
        MyBase.OnPaint(pevent)
        Dim rectSurface As Rectangle = Me.ClientRectangle
        Dim rectBorder As Rectangle = Rectangle.Inflate(rectSurface, -iBorderSize, -iBorderSize)
        Dim smoothSize As Integer = 2
        If iBorderSize > 0 Then smoothSize = iBorderSize

        If iBorderRadius > 2 Then

            Using pathSurface As GraphicsPath = GetFigurePath(rectSurface, iBorderRadius)

                Using pathBorder As GraphicsPath = GetFigurePath(rectBorder, iBorderRadius - iBorderSize)

                    Using penSurface As Pen = New Pen(Me.Parent.BackColor, smoothSize)

                        Using penBorder As Pen = New Pen(cBorderColor, iBorderSize)
                            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias
                            Me.Region = New Region(pathSurface)
                            pevent.Graphics.DrawPath(penSurface, pathSurface)
                            If iBorderSize >= 1 Then pevent.Graphics.DrawPath(penBorder, pathBorder)
                        End Using
                    End Using
                End Using
            End Using
        Else
            pevent.Graphics.SmoothingMode = SmoothingMode.None
            Me.Region = New Region(rectSurface)

            If iBorderSize >= 1 Then

                Using penBorder As Pen = New Pen(cBorderColor, iBorderSize)
                    penBorder.Alignment = PenAlignment.Inset
                    pevent.Graphics.DrawRectangle(penBorder, 0, 0, Me.Width - 1, Me.Height - 1)
                End Using
            End If
        End If
    End Sub

    Protected Overrides Sub OnHandleCreated(ByVal e As EventArgs)
        MyBase.OnHandleCreated(e)
        AddHandler Me.Parent.BackColorChanged, New EventHandler(AddressOf Container_BackColorChanged)
    End Sub

    Private Sub Container_BackColorChanged(ByVal sender As Object, ByVal e As EventArgs)
        Me.Invalidate()
    End Sub

    Private Sub Button_Resize(ByVal sender As Object, ByVal e As EventArgs)
        If iBorderRadius > Me.Height Then iBorderRadius = Me.Height
    End Sub
End Class
