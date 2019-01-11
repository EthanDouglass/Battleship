Public Class Game
    Dim compBoardmat(12, 12) As Integer
    Dim PictureBox(11, 11) As myPictureBox
    Dim picWidth As Integer = 400
    Dim picHeight As Integer = 100
    Dim gap As Integer = 0
    Dim labels(10) As Label
    Dim bug As Integer = 0
    Dim validClick As Boolean = True


    ' Done with comments

    Private Sub EnterPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Enter Then

            Transition.change()

        End If

    End Sub

    Public Sub Tstart()

        Me.Show()

        For I = 0 To PictureBox.GetLength(0) - 1
            For J = 0 To PictureBox.GetLength(1) - 1

                PictureBox(I, J).Enabled = True ' re-enabling dem pictureboxs

            Next
        Next

    End Sub


    Private Sub guess(sender As PictureBox, e As MouseEventArgs)

        If compBoardmat(Val(sender.Tag.Chars(0)), Val(sender.Tag.substring(1, 2))) = 1 Then ' Player guesses right

            sender.Image = Image.FromFile("fireDot.png") ' change image
            compBoardmat(Val(sender.Tag.Chars(0)), Val(sender.Tag.substring(1, 2))) = 2 ' making the place in the matrix two so I can not guess again
        ElseIf compBoardmat(Val(sender.Tag.Chars(0)), Val(sender.Tag.substring(1, 2))) = 0 Then
            sender.SizeMode = PictureBoxSizeMode.Zoom
            compBoardmat(Val(sender.Tag.Chars(0)), Val(sender.Tag.substring(1, 2))) = 2
            sender.Image = Image.FromFile("splash.png")

        ElseIf compBoardmat(Val(sender.Tag.Chars(0)), Val(sender.Tag.substring(1, 2))) = 2 Then

            validClick = False

        End If
        If validClick = True Then
            Dim countVar As Integer = 0
            For I = 0 To 6
                For J = 0 To 11

                    PictureBox(I, J).Enabled = False ' disabling the pictureboxes
                    If compBoardmat(I, J) <> 1 Then

                        countVar = countVar + 1

                    End If
                Next
            Next
            bug = bug + 1 ' variable I use to make sure that the comp is making the same amount of guesses as me
            If countVar = 84 Then ' if all ships have been guessed then you win
                MessageBox.Show("You Win!")

                BattleShip.My.Forms.compBoard.Close()
                BattleShip.My.Forms.Form1.Close()
                BattleShip.My.Forms.Form2.Close()
                BattleShip.My.Forms.Menu.Close()
                BattleShip.My.Forms.Transition.Close()
                BattleShip.My.Forms.Game.Close()
            End If
        End If
        validClick = True
        ' MessageBox.Show(bug)

    End Sub

    Public Sub graphics() ' creating pictureboxs for game

        Me.BackgroundImage = Image.FromFile("Water.jpg")
        Me.BackgroundImageLayout = ImageLayout.Stretch




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


                    labels(i).Font = New Drawing.Font("Times New Roman",
                               12,
                               FontStyle.Bold)
                    labels(i).BackColor = Color.Transparent
                    Me.Controls.Add(labels(i))

                End If

                Dim thetag As String = ""
                If j < 10 Then
                    thetag = i & "0" & j
                Else
                    thetag = i & j
                End If

                PictureBox(i, j).Tag = thetag

                AddHandler PictureBox(i, j).MouseDown, AddressOf guess
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

    End Sub
    Private Sub Cmatrix()

        For I = 0 To compBoardmat.GetLength(0) - 1
            For j = 0 To compBoardmat.GetLength(1) - 1

                compBoardmat(I, j) = 0 ' clearing the matrix (don't need this, just making sure)

            Next
        Next

    End Sub




    Public Sub putdownship(ByVal sizeVar As Integer)
        ' use coordinates to tell whether or not that piece can fit on the board or not
        ' gernerate random x and y coordinate and then after first ship, make sure none of the coordinates are the same

        Randomize()
        For J = 0 To 1
            Dim valid As Boolean = True

            Do
                valid = True

                Dim direction As Integer = Int(Rnd() * 4 + 1) ' picking random direction
                Dim x As Integer = Int(Rnd() * 7) ' ran starting x
                Dim y As Integer = Int(Rnd() * 11) ' ran starting y



                If direction = 1 Then ' right and big ship

                    For i = y To y + (sizeVar - 1) ' checking to see if the spots for the ship have already been chosen
                        If i < 10 Then ' checking to see if the ship would be out of bounds
                            If (compBoardmat(x, i) = 1) Then
                                Console.WriteLine("d = 1, spot filled")
                                valid = False
                            End If
                        Else
                            Console.WriteLine("d = 1, out of bounds")
                            valid = False
                        End If

                    Next
                    If valid = True Then ' if none of the (valid = falses) get triggered then make the ships
                        For I = 0 To sizeVar - 1
                            compBoardmat(x, y + I) = 1
                            ' compBoardmat(x, y + 1) = 1
                            ' compBoardmat(x, y + 2) = 1
                            ' compBoardmat(x, y + 3) = 1
                            Console.WriteLine("d = 1,************************" & x & ", " & y & " shipsize " & sizeVar)
                        Next
                    End If


                ElseIf direction = 2 Then ' Left and big ship

                    For i = y To y - (sizeVar - 1) Step -1 ' go through the next spaces to see if they are already checked
                        If i > 0 Or i = 0 Then
                            If (compBoardmat(x, i) = 1) Then
                                Console.WriteLine("d = 2, spot filled")
                                valid = False
                            End If
                        Else
                            Console.WriteLine("d = 2, spot out of bounds")
                            valid = False
                        End If

                    Next
                    If valid = True Then ' if none of the valid = falses get triggered then make the ships
                        For I = 0 To sizeVar - 1
                            compBoardmat(x, y - I) = 1
                            ' compBoardmat(x, y - 1) = 1
                            ' compBoardmat(x, y - 2) = 1
                            ' compBoardmat(x, y - 3) = 1
                            Console.WriteLine("d = 2, ************************" & x & ", " & y & " shipsize " & sizeVar)
                        Next
                    End If
                ElseIf direction = 3 Then ' top and big ship

                    For i = x To x - (sizeVar - 1) Step -1
                        If i > 0 Or i = 0 Then
                            If (compBoardmat(i, y) = 1) Then
                                Console.WriteLine("d = 3, spot is filled")
                                valid = False
                            End If
                        Else
                            Console.WriteLine("d = 3, spot's out of bounds")
                            valid = False
                        End If

                    Next
                    If valid = True Then ' if none of the valid = falses get triggered then make the ships
                        For I = 0 To sizeVar - 1
                            compBoardmat(x - I, y) = 1
                            ' compBoardmat(x - 1, y) = 1
                            ' compBoardmat(x - 2, y) = 1
                            ' compBoardmat(x - 3, y) = 1
                            Console.WriteLine("d = 3, ************************" & x & ", " & y & " shipsize " & sizeVar)
                        Next
                    End If
                ElseIf direction = 4 Then ' down and big ship

                    For i = x To x + (sizeVar - 1)
                        If i < 7 Then
                            If (compBoardmat(i, y) = 1) Then
                                Console.WriteLine("d = 4, spot filled")
                                valid = False
                            End If
                        Else
                            Console.WriteLine("d = 4, spot's filled")
                            valid = False
                        End If

                    Next
                    If valid = True Then ' if none of the valid = falses get triggered then make the ships
                        For I = 0 To sizeVar - 1
                            compBoardmat(x + I, y) = 1
                            ' compBoardmat(x + 1, y) = 1
                            ' compBoardmat(x + 2, y) = 1
                            ' compBoardmat(x + 3, y) = 1
                            Console.WriteLine("d = 4, ************************" & x & ", " & y & " shipsize " & sizeVar)
                        Next
                    End If
                End If


            Loop Until valid = True
        Next

        'If you want a graphic Of comp's board, uncomment 

        ' For I = 0 To PictureBox.GetLength(0) - 1
        'For J = 0 To PictureBox.GetLength(1) - 1

        'If compBoardmat(I, J) = 1 Then

        'PictureBox(I, J).Image = Image.FromFile("bDot.png")

        'End If

        'Next
        'Next

    End Sub


    Public Sub compBoard()



        putdownship(4)
        putdownship(3)
        putdownship(2)


    End Sub

    Private Sub Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cmatrix()
        graphics()

    End Sub
End Class