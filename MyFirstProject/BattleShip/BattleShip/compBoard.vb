Public Class compBoard
    Dim PictureBox(11, 11) As myPictureBox
    Dim picWidth As Integer = 400
    Dim picHeight As Integer = 100
    Dim gap As Integer = 0
    Dim labels(10) As Label
    Private Sub compBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picWidth = (Me.Width - (gap * (PictureBox.GetLength(1) + 1))) / PictureBox.GetLength(1)

        picHeight = picWidth ' adjust height according to width

        For j = 0 To PictureBox.GetLength(0) - 1 ' Making the matrix of pictureboxes
            For i = 0 To PictureBox.GetLength(1) - 1

                PictureBox(i, j) = New myPictureBox


                PictureBox(i, j).Width = picWidth


                PictureBox(i, j).Height = picHeight

                PictureBox(i, j).Top = gap + ((picHeight + gap) * i) ' top property dependent on row #

                PictureBox(i, j).Left = gap + ((picWidth + gap) * j) ' left property dependent on column number


                PictureBox(i, j).BorderStyle = BorderStyle.FixedSingle
                ' ControlPaint.DrawBorder(.Graphics, pe.ClipRectangle, Color.Gray, ButtonBorderStyle.Solid)
                PictureBox(i, j).BackColor = Color.Transparent
                If i = 0 Then

                    labels(i) = New Label
                    labels(i).Text = j + 1
                    labels(i).Width = 39
                    labels(i).Height = 19

                    labels(i).Top = PictureBox(i, j).Top
                    labels(i).Left = PictureBox(i, j).Left


                    labels(i).Font = New Drawing.Font("Times New Roman", _
                               12, _
                               FontStyle.Bold)
                    labels(i).BackColor = Color.Transparent
                    Me.Controls.Add(labels(i))

                End If



                PictureBox(i, j).Tag = i & j


                PictureBox(i, j).SizeMode = PictureBoxSizeMode.Zoom
                Me.Controls.Add(PictureBox(i, j))








            Next


        Next

        Me.Width = 620
        Me.Height = 420
        Me.Top = 100
        Me.Left = 470

        Me.MaximumSize = New Size(620, 420)
        Me.MinimumSize = Me.MaximumSize
        Me.ResizeRedraw = False
    End Sub

    Private Sub makeBoard()
       

    End Sub

End Class