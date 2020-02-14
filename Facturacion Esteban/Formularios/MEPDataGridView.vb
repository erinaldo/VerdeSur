' Custom DataGridView
' Copyright (C) 2011 Marvin E. Pineda
'
' This library is free software; you can redistribute it and/or
' modify it under the terms of the GNU Lesser General Public
' License as published by the Free Software Foundation; either
' version 2.1 of the License, or (at your option) any later version.

' This library is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
' Lesser General Public License for more details.

' You should have received a copy of the GNU Lesser General Public
' License along with this library; if not, write to the Free Software
' Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA
'

Imports System.ComponentModel
Imports System.Drawing.Drawing2D

Public Class MEPDataGridView
    Inherits DataGridView

    Private vAutoGenerateColumns As Boolean
    Private vFillEmptyArea As Boolean
    Private ReadOnly Property NeedPaintEmptyArea() As Boolean
        Get
            Dim lastRowDisplayed As Integer = Me.Rows.GetLastRow(DataGridViewElementStates.Displayed)
            Return lastRowDisplayed > -1 Or Me.DesignMode
        End Get
    End Property
    Private ReadOnly Property NeedPaintColumnEmptyArea() As Boolean
        Get

            Dim ajust As Integer = 2
            If Me.BorderStyle = System.Windows.Forms.BorderStyle.None Then _
                ajust = 0
            If Me.VerticalScrollBar.Visible Then _
                ajust += SystemInformation.VerticalScrollBarWidth

            Dim columnsWidth As Integer = _
                Me.Columns.GetColumnsWidth(DataGridViewElementStates.Displayed) + _
                ajust

            If Me.RowHeadersVisible Then : columnsWidth += Me.RowHeadersWidth
            Else : columnsWidth += 1 : End If

            Return columnsWidth < Me.Width

        End Get
    End Property

    Public Sub New()
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        Me.SetStyle(ControlStyles.ResizeRedraw, True)
        Me.DoubleBuffered = True
        Me.vAutoGenerateColumns = True
    End Sub

    <DefaultValue(False)> _
    Public Property FillEmptyArea() As Boolean
        Get
            Return vFillEmptyArea
        End Get
        Set(ByVal value As Boolean)
            vFillEmptyArea = value
            If IsHandleCreated Then _
                Me.Invalidate(True)
        End Set
    End Property
    <Browsable(True), DefaultValue(True)> _
    Public Overloads Property AutoGenerateColumns() As Boolean
        Get
            Return Me.vAutoGenerateColumns
        End Get
        Set(ByVal value As Boolean)
            Me.vAutoGenerateColumns = value
            MyBase.AutoGenerateColumns = value
        End Set
    End Property

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)

        Select Case m.Msg
            Case NativeMethods.WM_SETFOCUS
                Me.WmSetFocus(m)
        End Select

        MyBase.WndProc(m)

    End Sub
    Protected Overrides Sub OnCellPainting(ByVal e As DataGridViewCellPaintingEventArgs)
        MyBase.OnCellPainting(e)

        If e.RowIndex = -1 And e.ColumnIndex = -1 Then
            Me.PaintIndicatorHeader(e)
        ElseIf e.RowIndex = -1 And e.ColumnIndex > -1 Then
            Me.PaintColumnHeader(New PaintingEventArgs(e.Graphics, e.CellBounds, e.RowIndex, e.ColumnIndex))
            e.PaintContent(e.ClipBounds)
            e.Handled = True
        ElseIf e.ColumnIndex = -1 Then
            Me.PaintRowIndicator(New PaintingEventArgs(e.Graphics, e.CellBounds, e.RowIndex, e.ColumnIndex))
            e.PaintContent(e.ClipBounds)
            e.Handled = True
        End If

    End Sub
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)
        If Me.FillEmptyArea Then _
            Me.PaintEmptyArea(e)
    End Sub

    Private Sub WmSetFocus(ByRef m As Message)

        If Me.NeedPaintEmptyArea And Me.FillEmptyArea Then _
            Me.Invalidate(True)

    End Sub
    Private Sub PaintColumnHeader(ByVal e As PaintingEventArgs)

        Using vBrush As LinearGradientBrush = New LinearGradientBrush(e.CellBounds, SystemColors.Window, SystemColors.Control, LinearGradientMode.Vertical)
            Dim vBlend As New Blend()
            With vBlend
                .Factors = New Single() {0.0F, 0.1F, 0.6F, 0.0F, 1.0F}
                .Positions = New Single() {0.0F, 0.25F, 0.1F, 3.0F, 1.0F}
            End With
            vBrush.Blend = vBlend
            e.Graphics.FillRectangle(vBrush, e.CellBounds)
        End Using

        ControlPaint.DrawBorder _
            ( _
                e.Graphics, e.CellBounds, _
                SystemColors.ControlDark, 1, ButtonBorderStyle.None, _
                SystemColors.ControlDark, 1, ButtonBorderStyle.Solid, _
                SystemColors.ControlDark, 1, ButtonBorderStyle.None, _
                SystemColors.ControlDark, 1, ButtonBorderStyle.Solid _
            )

        Dim intCellBounds As Rectangle = e.CellBounds
        intCellBounds.Height -= 2
        Using vPen As Pen = New Pen(Color.FromArgb(50, SystemColors.ControlDark))
            ControlPaint.DrawBorder _
                ( _
                    e.Graphics, intCellBounds, _
                    vPen.Color, 1, ButtonBorderStyle.None, _
                    vPen.Color, 1, ButtonBorderStyle.None, _
                    vPen.Color, 1, ButtonBorderStyle.Solid, _
                    vPen.Color, 1, ButtonBorderStyle.Solid _
                )
        End Using

    End Sub
    Private Sub PaintIndicatorHeader(ByVal e As DataGridViewCellPaintingEventArgs)

        e.Handled = True
        Using vBrush As LinearGradientBrush = New LinearGradientBrush(e.CellBounds, SystemColors.Window, SystemColors.Control, LinearGradientMode.Vertical)
            e.Graphics.FillRectangle(vBrush, e.CellBounds)
        End Using
        ControlPaint.DrawBorder _
            ( _
                e.Graphics, e.CellBounds, _
                SystemColors.ControlDark, 1, ButtonBorderStyle.Solid, _
                SystemColors.ControlDark, 1, ButtonBorderStyle.Solid, _
                SystemColors.ControlDark, 1, ButtonBorderStyle.Solid, _
                SystemColors.ControlDark, 1, ButtonBorderStyle.Solid _
            )

    End Sub
    Private Sub PaintRowIndicator(ByVal e As PaintingEventArgs)

        Dim x As Integer = 1, w As Integer = 0
        If Me.BorderStyle = System.Windows.Forms.BorderStyle.None Then
            x = 0 : w = 1
        End If

        Dim fillRct As New Rectangle(x, e.CellBounds.Y, e.CellBounds.Width, e.CellBounds.Height)
        Using vBrush As New LinearGradientBrush(fillRct, SystemColors.Window, SystemColors.Control, LinearGradientMode.Horizontal)
            Dim vBlend As New Blend With _
            { _
                .Factors = New Single() {0.0F, 0.1F, 0.6F, 0.0F, 1.0F}, _
                .Positions = New Single() {0.0F, 0.23F, 0.1F, 3.0F, 1.0F} _
            }

            vBrush.Blend = vBlend
            e.Graphics.FillRectangle(vBrush, fillRct)
        End Using

        Dim rct0 As New Rectangle(x, e.CellBounds.Y - 1, e.CellBounds.Width, e.CellBounds.Height)
        ' Left border
        e.Graphics.DrawLine(SystemPens.ControlDark, rct0.X, rct0.Y, rct0.X, rct0.Bottom)
        ' Top border
        If e.RowIndex = 0 Then _
            e.Graphics.DrawLine(SystemPens.ControlDark, rct0.X, rct0.Y, rct0.Width, rct0.Y)
        ' Right border
        e.Graphics.DrawLine(SystemPens.ControlDark, rct0.Width - w, rct0.Y, rct0.Width - w, rct0.Bottom)

        Dim rct1 As New Rectangle(x + 1, e.CellBounds.Y, e.CellBounds.Width - 2, e.CellBounds.Height)
        Using vPen As New Pen(Color.FromArgb(50, SystemColors.ControlDark))
            ' Bottom border
            e.Graphics.DrawLine(vPen, rct1.X, rct1.Bottom - 1, rct1.Width, rct1.Bottom - 1)
            ' Right border
            e.Graphics.DrawLine(vPen, rct1.Width - w, rct1.Y, rct1.Width - w, rct1.Bottom)
        End Using



    End Sub
    Private Sub PaintEmptyArea(ByVal e As PaintEventArgs)

        Dim RECT As New NativeMethods.RECT()
        NativeMethods.GetWindowRect(Me.Handle, RECT)

        If Me.FillEmptyArea Then
            If Me.NeedPaintEmptyArea Then

                ' Excluye borde inferior
                e.Graphics.ExcludeClip(New Rectangle(0, RECT.Height - 1, RECT.Width, 1))
                ' Excluye borde derecho
                e.Graphics.ExcludeClip(New Rectangle(RECT.Width - 1, 0, 1, RECT.Height))

                ' obtiene indice de la ultima fila mostrada.
                Dim lastRowVisible As Integer = Me.Rows.GetLastRow(DataGridViewElementStates.Displayed)
                ' rectangulo predeterminado de la ultima fila mostrada, sobre todo
                ' si no hay datos.
                Dim lastRowBounds As New Rectangle(0, Me.ColumnHeadersHeight - Me.RowTemplate.Height + 1, RECT.Width, Me.RowTemplate.Height)
                ' si hay filas mostradas, obtenemos el rectangulo de la ultima.
                If lastRowVisible > -1 Then _
                    lastRowBounds = Me.GetRowDisplayRectangle(lastRowVisible, True)

                ' Alto de las filas.
                Dim rowHeight As Integer = Me.RowTemplate.Height ' lastRowBounds.Height
                ' Alto del control.
                Dim height As Integer = RECT.Height
                ' Calcula la cantidad de filas necesario para llegar el area vacia.
                Dim fillRows As Integer = ((height - lastRowBounds.Bottom) / rowHeight) + 1

                ' Ciclo para pintar las filas.
                For fillRow As Integer = 0 To fillRows
                    Dim y As Integer = lastRowBounds.Bottom + (fillRow * rowHeight)
                    If Me.RowHeadersVisible Then
                        Dim rctRowIndicatorBounds As New Rectangle(0, y, Me.RowHeadersWidth, rowHeight)
                        Me.PaintRowIndicator(New PaintingEventArgs(e.Graphics, rctRowIndicatorBounds, -1, -1))
                    End If

                    For Each col As DataGridViewColumn In Me.Columns
                        Dim colBounds As Rectangle = Me.GetColumnDisplayRectangle(col.Index, True)
                        Dim cellBounds As New Rectangle(colBounds.X, y, colBounds.Width, rowHeight)

                        If Me.Columns.GetLastColumn(DataGridViewElementStates.Displayed, DataGridViewElementStates.None).Equals(col) Then _
                            cellBounds.Width = col.Width

                        Me.PaintCell(New PaintingEventArgs(e.Graphics, cellBounds, -1, -1))

                    Next
                Next

            End If

            If Me.NeedPaintColumnEmptyArea Then

                Dim borderWidth As Integer = 1
                If Me.BorderStyle = System.Windows.Forms.BorderStyle.None Then _
                    borderWidth = 0

                ' Obtiene al ancho de todas las filas mostradas.
                Dim x As Integer = Me.Columns.GetColumnsWidth(DataGridViewElementStates.Displayed) + IIf(Me.RowHeadersVisible, Me.RowHeadersWidth, 1) + borderWidth
                Dim y As Integer = borderWidth

                ' Obtiene rectangulo para pintar encabezado
                Dim rctColumn As New Rectangle(x, y, RECT.Width - x - borderWidth, Me.ColumnHeadersHeight)
                ' Pinta encabezado
                Me.PaintColumnHeader(New PaintingEventArgs(e.Graphics, rctColumn, -1, -1))

                ' Obtiene el indice de la primera fila mostrada.
                Dim firstRowDisplayed As Integer = Me.Rows.GetFirstRow(DataGridViewElementStates.Displayed)

                ' Calcula la cantidad de filas a pintar.
                Dim rowsToPaint As Integer = Math.Ceiling((RECT.Height - Me.ColumnHeadersHeight) / Me.RowTemplate.Height) + 1

                ' Obtiene rectangulo para pintar filas.
                Dim rct1 As Rectangle = Rectangle.Empty
                If firstRowDisplayed > -1 Then
                    rct1 = Me.GetRowDisplayRectangle(firstRowDisplayed, True)
                Else
                    rct1 = New Rectangle(x, Me.ColumnHeadersHeight + borderWidth, RECT.Width - 1, Me.RowTemplate.Height)
                End If

                Dim rowBounds As New Rectangle(x, rct1.Y, RECT.Width - x - borderWidth, rct1.Height)
                For r As Integer = 0 To rowsToPaint
                    Me.PaintCell(New PaintingEventArgs(e.Graphics, rowBounds, -1, -1))

                    Dim rowHeight As Integer = rowBounds.Height
                    Dim nextRowHeight As Integer = Me.RowTemplate.Height
                    If firstRowDisplayed > -1 Then
                        firstRowDisplayed += 1
                        If firstRowDisplayed < Me.Rows.Count Or firstRowDisplayed = Me.NewRowIndex Then _
                            nextRowHeight = Me.GetRowDisplayRectangle(firstRowDisplayed, True).Height
                    End If

                    rowBounds.Y += rowHeight
                    rowBounds.Height = nextRowHeight
                Next

            End If
        End If
    End Sub
    Private Sub PaintCell(ByVal e As PaintingEventArgs)

        e.Graphics.FillRectangle(SystemBrushes.Window, e.CellBounds)
        ControlPaint.DrawBorder _
            ( _
                e.Graphics, e.CellBounds, _
                Me.GridColor, 1, ButtonBorderStyle.None, _
                Me.GridColor, 1, ButtonBorderStyle.None, _
                Me.GridColor, 1, ButtonBorderStyle.Solid, _
                Me.GridColor, 1, ButtonBorderStyle.Solid _
            )

    End Sub

End Class

Friend Class PaintingEventArgs
    Inherits EventArgs

    Private vGraphics As Graphics
    Private vCellBounds As Rectangle
    Private vRowIndex As Integer
    Private vColumnIndex As Integer

    Public Property Graphics() As Graphics
        Get
            Return vGraphics
        End Get
        Private Set(ByVal value As Graphics)
            vGraphics = value
        End Set
    End Property

    Public Property CellBounds() As Rectangle
        Get
            Return vCellBounds
        End Get
        Private Set(ByVal value As Rectangle)
            vCellBounds = value
        End Set
    End Property

    Public Property RowIndex() As Integer
        Get
            Return vRowIndex
        End Get
        Private Set(ByVal value As Integer)
            vRowIndex = value
        End Set
    End Property

    Public Property ColumnIndex() As Integer
        Get
            Return vColumnIndex
        End Get
        Private Set(ByVal value As Integer)
            vColumnIndex = value
        End Set
    End Property

    Friend Sub New(ByVal g As Graphics, ByVal cellBounds As Rectangle, ByVal rowIndex As Integer, ByVal colIndex As Integer)
        Me.Graphics = g
        Me.CellBounds = cellBounds
        Me.RowIndex = rowIndex
        Me.ColumnIndex = colIndex
    End Sub

End Class