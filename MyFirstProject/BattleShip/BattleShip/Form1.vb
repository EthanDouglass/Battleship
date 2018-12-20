Public Class Form1
    Dim boardVar(11, 11) As Integer
    Dim PictureBox2(3) As myPictureBox
    Dim PictureBox(11, 11) As myPictureBox
    Dim picWidth As Integer = 400
    Dim picHeight As Integer = 100
    Dim gap As Integer = 0
    Dim labels(10) As Label
    Dim shipVar As Integer = 0
    Dim countVar As Integer = 0
    Dim posVar As Integer = 0
    Dim AVar As Integer = 0
    Dim BVar As Integer = 0
    Dim countVar2 As Integer = 0
    Dim count As Integer = 0
    Dim x2 As Integer
    Dim y2 As Integer
    Dim x As Integer
    Dim y As Integer
    Dim inGame As Boolean = False
    Dim shipVar2 As Integer = 0
    Dim bug As Integer = 0
    Dim hitTwice As Boolean = False
    Dim direction As String = ""
    Dim hit As Boolean = False
    Public Sub gameStart()

        inGame = True ' Variable to tell if ingame or not

    End Sub
    Public Sub compGuess()
        Console.WriteLine("compboard")
        Randomize()
        Dim countVar3 As Integer = 0
        Dim Var15 = 1

        If count = 0 Then ' Count is the variable telling whether a ship was hit last round
            x = 0
            y = 0
            Do
                x = Int(Rnd() * 7)  ' Generating random numbers until it gets 2 that have not already been guessed
                y = Int(Rnd() * 11)
            Loop While boardVar(x, y) = 2
            Console.WriteLine("x = " & x & " and y = " & y)


            If boardVar(x, y) = 1 Then ' if my board matrix has a one in the corresponding spot then show that you are hit

                Console.WriteLine("hit " & "1 b = " & boardVar(x, y))
                PictureBox(x, y).Image = Image.FromFile("fireDot.png") ' change image to hit
                MessageBox.Show("The Computer hit you at (" & x & ", " & y & ")")
                hit = True ' variables to keep the computer knowing whether it hit me or not
                boardVar(x, y) = 2 ' change matrix to say that it has already guessed there
                count = 1

            ElseIf boardVar(x, y) = 0 Then  ' if my board matrix has a zero in the corresponding spot then show that it missed

                Console.WriteLine("miss " & "0 b = " & boardVar(x, y))
                PictureBox(x, y).Image = Image.FromFile("splash.png") ' change image to miss
                MessageBox.Show("The Computer missed at (" & x & ", " & y & ")")
                boardVar(x, y) = 2
                hit = False
                count = 0

            End If

            If hit = True Then ' if hit then store the starting position for later
                count = 1
                y2 = y
                x2 = x

                Console.WriteLine("hit saved, " & "x2 = " & x2 & " , y2 = " & y2)
            End If
            bug = bug + 1
        ElseIf count = 1 Then ' if was hit last turn then
            ' use the stored variables
            Console.WriteLine("count = 1")

            Dim flag As Boolean = False
            If hitTwice = False Then
                Do
                    Dim ranVar2 As Integer = Int(Rnd() * 2)
                    If ranVar2 = 0 Then ' the comp chooses which direction to guess in
                        Console.WriteLine("RanVar2 = 0")
                        Dim ranVar As Integer = Int(Rnd() * 2)
                        If ranVar = 0 Then

                            x = x2 + 1  ' down
                            direction = "Down"
                            Console.WriteLine("The computer has chosen to guess down " & x2 & " + 1 and x =" & x)
                        ElseIf ranVar = 1 Then

                            x = x2 - 1 ' up
                            direction = "Up"
                            Console.WriteLine("The computer has chosen to guess up " & x2 & " - 1 and x =" & x)
                        End If
                    ElseIf ranVar2 = 1 Then
                        Console.WriteLine("RanVar2 = 1")
                        Dim ranVar As Integer = Int(Rnd() * 2)
                        If ranVar = 0 Then

                            y = y2 + 1 ' right
                            direction = "Right"
                            Console.WriteLine("The computer has chosen to guess right " & y2 & " + 1 and  y = " & y)
                        ElseIf ranVar = 1 Then

                            y = y2 - 1 ' left
                            direction = "Left"
                            Console.WriteLine("The computer has chosen to guess left " & y2 & "- 1 and y = " & y)
                        End If
                    End If





                    If x < 7 And x >= 0 And y < 11 And y >= 0 Then ' checking to see if in bounds 
                        If boardVar(x, y) <> 2 Then ' checking to see if already chosen
                            flag = True ' if nothing was found wrong with the spot then change flag or valid is true
                            Var15 = 0
                        End If
                    End If
                    Var15 = Var15 + 1 ' var to say if it has guessed five times and not found a valid spot, to move on with hit as false
                Loop Until flag = True Or Var15 = 5 ' loop until in bounds and not already chosen

            ElseIf hitTwice = True Then
                If direction = "Left" Then

                    y = y2 - 1 ' left
                    Console.WriteLine("The computer has chosen to guess left " & y2 & "- 1 and y = " & y)

                ElseIf direction = "Right" Then

                    y = y2 + 1 ' right
                    Console.WriteLine("The computer has chosen to guess right " & y2 & " + 1 and  y = " & y)

                ElseIf direction = "Up" Then

                    x = x2 - 1 ' up
                    Console.WriteLine("The computer has chosen to guess up " & x2 & " - 1 and x =" & x)

                ElseIf direction = "Down" Then

                    x = x2 + 1  ' down
                    Console.WriteLine("The computer has chosen to guess down " & x2 & " + 1 and x =" & x)

                End If


                If x < 7 And x >= 0 And y < 11 And y >= 0 Then ' checking to see if in bounds 
                    If boardVar(x, y) <> 2 Then ' checking to see if already chosen
                        flag = True ' if nothing was found wrong with the spot then change flag or valid is true
                        Var15 = 0
                    End If
                End If

            End If
            If flag = True Then
                If Var15 <> 5 Then
                    bug = bug + 1
                    Console.WriteLine("x = " & x & "  y = " & y)
                    If boardVar(x, y) = 1 Then

                        ' computer has hit the player and I am changing all variables to reflect that

                        Console.WriteLine(x & y & boardVar(x, y))
                        PictureBox(x, y).Image = Image.FromFile("fireDot.png")
                        MessageBox.Show("The Computer hit you at (" & x & ", " & y & ")")
                        boardVar(x, y) = 2
                        hit = True
                        hitTwice = True
                        count = 1
                        x2 = x
                        y2 = y

                    ElseIf boardVar(x, y) = 0 Then

                        ' computer has missed the player, resetting variables

                        Console.WriteLine(x & y & boardVar(x, y))
                        PictureBox(x, y).Image = Image.FromFile("splash.png")
                        MessageBox.Show("The Computer missed at (" & x & ", " & y & ")")
                        boardVar(x, y) = 2
                        count = 0
                        hitTwice = False
                        hit = False
                        x2 = 0
                        y2 = 0


                    End If
                ElseIf Var15 = 5 Then
                    count = 0
                    hit = False
                    hitTwice = False
                    compGuess()
                End If
            ElseIf flag = False Then
                count = 0
                hitTwice = False
                hit = False
                compGuess()
            End If
        End If
        For I = 0 To 6
            For J = 0 To 11


                If boardVar(I, J) <> 1 Then ' check if I had lost yet

                    countVar3 = countVar3 + 1

                End If
            Next
        Next
        If countVar3 = 84 Then
            MessageBox.Show("You Lose!")

            BattleShip.My.Forms.compBoard.Close()
            BattleShip.My.Forms.Form2.Close()
            BattleShip.My.Forms.Menu.Close()
            BattleShip.My.Forms.Transition.Close()
            BattleShip.My.Forms.Game.Close()
            BattleShip.My.Forms.Form1.Close()

        End If

        ' MessageBox.Show(bug)

    End Sub
    Private Sub EnterPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Enter Then

            Transition.change()

        End If

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()

        Me.Top = 100
        Me.Left = 470
        Me.BackgroundImage = Image.FromFile("Water.jpg")
        Me.BackgroundImageLayout = ImageLayout.Stretch




        picWidth = (Me.Width - (gap * (PictureBox.GetLength(1) + 1))) / PictureBox.GetLength(1)

        picHeight = picWidth

        makeBoard() ' make picturebox board

        Me.Width = 857
        Me.Height = 575
        Form2.Show()

    End Sub

    Public Sub autoBoard(ByVal sizeVar As Integer)


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
                            If (boardVar(x, i) = 1) Then
                                Console.WriteLine("d = 1, spot filled")
                                valid = False
                            End If
                        Else
                            Console.WriteLine("d = 1, out of bounds")
                            valid = False
                        End If

                    Next
                    If valid = True Then ' if none of the valid = falses get triggered then make the ships
                        For I = 0 To sizeVar - 1
                            boardVar(x, y + I) = 1
                            ' compBoardmat(x, y + 1) = 1
                            ' compBoardmat(x, y + 2) = 1
                            ' compBoardmat(x, y + 3) = 1
                            Console.WriteLine("d = 1,************************" & x & ", " & y & " shipsize " & sizeVar)
                        Next
                    End If


                ElseIf direction = 2 Then ' Left and big ship

                    For i = y To y - (sizeVar - 1) Step -1 ' go through the next spaces to see if they are already checked
                        If i > 0 Or i = 0 Then
                            If (boardVar(x, i) = 1) Then
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
                            boardVar(x, y - I) = 1
                            ' compBoardmat(x, y - 1) = 1
                            ' compBoardmat(x, y - 2) = 1
                            ' compBoardmat(x, y - 3) = 1
                            Console.WriteLine("d = 2, ************************" & x & ", " & y & " shipsize " & sizeVar)
                        Next
                    End If
                ElseIf direction = 3 Then ' top and big ship

                    For i = x To x - (sizeVar - 1) Step -1
                        If i > 0 Or i = 0 Then
                            If (boardVar(i, y) = 1) Then
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
                            boardVar(x - I, y) = 1
                            ' compBoardmat(x - 1, y) = 1
                            ' compBoardmat(x - 2, y) = 1
                            ' compBoardmat(x - 3, y) = 1
                            Console.WriteLine("d = 3, ************************" & x & ", " & y & " shipsize " & sizeVar)
                        Next
                    End If
                ElseIf direction = 4 Then ' down and big ship

                    For i = x To x + (sizeVar - 1)
                        If i < 7 Then
                            If (boardVar(i, y) = 1) Then
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
                            boardVar(x + I, y) = 1
                            ' compBoardmat(x + 1, y) = 1
                            ' compBoardmat(x + 2, y) = 1
                            ' compBoardmat(x + 3, y) = 1
                            Console.WriteLine("d = 4, ************************" & x & ", " & y & " shipsize " & sizeVar)
                        Next
                    End If
                End If


            Loop Until valid = True
        Next

        'If you Then want a graphic Of comp's board, uncomment 

        For I = 0 To PictureBox.GetLength(0) - 1
            For J = 0 To PictureBox.GetLength(1) - 1

                If boardVar(I, J) = 1 Then

                    PictureBox(I, J).Image = Image.FromFile("bDot.png")

                End If

            Next
        Next

    End Sub
    Public Sub Clear()
        Dim i2 As Integer = 0
        Dim j2 As Integer = 0

        For I = 0 To PictureBox.GetLength(0) - 1
            For J = 0 To PictureBox.GetLength(1) - 1

                If boardVar(I, J) = 0 Then
                    i2 = I
                    j2 = J

                End If

            Next
        Next

        For I = 0 To PictureBox.GetLength(0) - 1
            For J = 0 To PictureBox.GetLength(1) - 1

                If boardVar(I, J) = 1 Then
                    boardVar(I, J) = 0
                    PictureBox(I, J).Image = PictureBox(i2, j2).Image

                End If

            Next
        Next

    End Sub

    Public Sub makeBoard()


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


                Dim thetag As String = ""
                If j < 10 Then
                    thetag = i & "0" & j
                Else
                    thetag = i & j
                End If

                PictureBox(i, j).Tag = thetag


                PictureBox(i, j).SizeMode = PictureBoxSizeMode.Zoom
                Me.Controls.Add(PictureBox(i, j))



                AddHandler PictureBox(i, j).MouseDown, AddressOf placeShip
                AddHandler PictureBox(i, j).MouseDown, AddressOf inGameSub



            Next


        Next

    End Sub
    Private Sub inGameSub(sender As Object, e As MouseEventArgs)
        If inGame = True Then
            Dim senI As Integer
            Dim senj As Integer

            If sender.tag.length < 3 Then
                senj = "0" & Val(sender.tag.Chars(1))
                senI = Val(sender.tag.Chars(0))
            Else
                senj = Val(sender.tag.Chars(1)) & Val(sender.tag.Chars(2))
                senI = Val(sender.tag.Chars(0))
            End If
            Console.WriteLine("This spot is " & boardVar(senI, senj))
        End If
    End Sub
    Public Sub medShip()
        posVar = 1
        shipVar = 2
        countVar = 0
        shipVar2 = 3
    End Sub

    Public Sub medShip2()
        posVar = 1
        shipVar = 2
        countVar = 0
        shipVar2 = 4
    End Sub
    Public Sub smllShip()
        posVar = 1
        shipVar = 1
        countVar = 0
        shipVar2 = 5
    End Sub

    Public Sub smllShip2()
        posVar = 1
        shipVar = 1
        countVar = 0
        shipVar2 = 6
    End Sub
    Public Sub bigShip()
        posVar = 1
        shipVar = 3
        countVar = 0
        shipVar2 = 1
    End Sub
    Public Sub bigShip2()
        posVar = 1
        shipVar = 3
        countVar = 0
        shipVar2 = 2
    End Sub
    Private Sub makeShip(sender As Object, e As MouseEventArgs)
        BVar = 0 ' add BVar = 1's to the following for next loops
        Dim create As Boolean = True
        Dim senI As Integer
        Dim senj As Integer
        Dim thetag As String = ""
        If sender.tag.length < 3 Then
            senj = "0" & Val(sender.tag.Chars(1))
            senI = Val(sender.tag.Chars(0))
        Else
            senj = Val(sender.tag.Chars(1)) & Val(sender.tag.Chars(2))
            senI = Val(sender.tag.Chars(0))
        End If
        Console.WriteLine(senI & " " & senj)
        If sender.name = 0 Then

            AVar = 1

        ElseIf sender.name = 1 Then

            AVar = 2

        ElseIf sender.name = 2 Then

            AVar = 3

        ElseIf sender.name = 3 Then

            AVar = 4

        End If

        For I = 0 To 3 ' Hide the arrows 

            PictureBox2(I).Hide()

        Next

        If AVar = 1 Then ' Var for which arrow
            For I = 0 To shipVar - 1 ' Right arrow clicked
                BVar = 0

                ' need to check if it is okay before changing image to dot
                If I = 0 And create = True Then
                    If senI < 7 And senI >= 0 And senj < 11 And senj >= 0 Then
                        If boardVar(Val(senI), Val(senj)) = 1 Or create = False Then

                            PictureBox(senI, senj - 1).Image = Nothing
                            boardVar(Val(senI), Val(senj) - 1) = 0
                            Form2.ShowShip(shipVar2)
                            MessageBox.Show("You can not overlap ships")
                            create = False

                        Else
                            BVar = 1

                            PictureBox(senI, senj).Image = Image.FromFile("bDot.png")
                            boardVar(Val(senI), Val(senj)) = 1
                        End If
                    Else

                        PictureBox(senI, senj - 1).Image = Nothing
                        boardVar(Val(senI), Val(senj) - 1) = 0
                        Form2.ShowShip(shipVar2)

                        create = False

                        MessageBox.Show("Ship must be in bounds")
                    End If

                ElseIf I = 1 And create = True Then
                    If senI < 7 And senI >= 0 And senj + 1 < 11 And senj + 1 >= 0 Then
                        If boardVar(Val(senI), (Val(senj) + 1)) = 1 Or create = False Then

                            PictureBox(senI, senj - 1).Image = Nothing
                            boardVar(Val(senI), Val(senj) - 1) = 0

                            create = False

                            PictureBox(senI, senj).Image = Nothing
                            boardVar(Val(senI), Val(senj)) = 0
                            Form2.ShowShip(shipVar2)
                            MessageBox.Show("You can not overlap ships")

                        Else

                            BVar = 1

                            PictureBox(senI, senj + 1).Image = Image.FromFile("bDot.png")
                            boardVar(Val(senI), (Val(senj) + 1)) = 1
                        End If
                    Else

                        PictureBox(senI, senj - 1).Image = Nothing
                        boardVar(Val(senI), Val(senj) - 1) = 0

                        create = False

                        PictureBox(senI, senj).Image = Nothing
                        boardVar(Val(senI), Val(senj)) = 0
                        Form2.ShowShip(shipVar2)


                        MessageBox.Show("Ship must be in bounds")

                    End If

                ElseIf I = 2 And create = True Then
                    If senI < 7 And senI >= 0 And senj + 2 < 11 And senj + 2 >= 0 Then
                        If boardVar(Val(senI), (Val(senj) + 2)) = 1 Or create = False Then
                            PictureBox(senI, senj - 1).Image = Nothing
                            boardVar(Val(senI), Val(senj) - 1) = 0

                            create = False

                            PictureBox(senI, senj).Image = Nothing
                            boardVar(Val(senI), Val(senj)) = 0

                            PictureBox(senI, senj + 1).Image = Nothing
                            boardVar(Val(senI), (Val(senj) + 1)) = 0
                            Form2.ShowShip(shipVar2)
                            MessageBox.Show("You can not overlap ships")

                        Else

                            BVar = 1
                            PictureBox(senI, senj + 2).Image = Image.FromFile("bDot.png")
                            boardVar(Val(senI), (Val(senj) + 2)) = 1

                        End If
                    Else

                        PictureBox(senI, senj - 1).Image = Nothing
                        boardVar(Val(senI), Val(senj) - 1) = 0

                        create = False

                        PictureBox(senI, senj).Image = Nothing
                        boardVar(Val(senI), Val(senj)) = 0

                        PictureBox(senI, senj + 1).Image = Nothing
                        boardVar(Val(senI), (Val(senj) + 1)) = 0
                        Form2.ShowShip(shipVar2)


                        MessageBox.Show("Ship must be in bounds")

                    End If
                End If








            Next

        ElseIf AVar = 2 Then
            BVar = 0
            For I = 0 To shipVar - 1 ' left arrow clicked




                If I = 0 And create = True Then
                    If senI < 7 And senI >= 0 And senj < 11 And senj >= 0 Then
                        If boardVar(Val(senI), Val(senj)) = 1 Or create = False Then

                            PictureBox(senI, senj + 1).Image = Nothing
                            boardVar(Val(senI), Val(senj) + 1) = 0
                            Form2.ShowShip(shipVar2)
                            MessageBox.Show("You can not overlap ships")
                            create = False

                        Else
                            BVar = 1
                            PictureBox(senI, senj).Image = Image.FromFile("bDot.png")
                            boardVar(Val(senI), Val(senj)) = 1
                        End If
                    Else


                        PictureBox(senI, senj + 1).Image = Nothing
                        boardVar(Val(senI), Val(senj) + 1) = 0
                        Form2.ShowShip(shipVar2)

                        create = False

                        MessageBox.Show("Ship must be in bounds")

                    End If
                ElseIf I = 1 And create = True Then
                    If senI < 7 And senI >= 0 And senj - 1 < 11 And senj - 1 >= 0 Then
                        If boardVar(Val(senI), (Val(senj) - 1)) = 1 Or create = False Then

                            PictureBox(senI, senj + 1).Image = Nothing
                            boardVar(Val(senI), Val(senj) + 1) = 0
                            Form2.ShowShip(shipVar2)

                            create = False

                            PictureBox(senI, senj).Image = Nothing
                            boardVar(Val(senI), Val(senj)) = 0
                            MessageBox.Show("You can not overlap ships")

                        Else
                            BVar = 1
                            PictureBox(senI, senj - 1).Image = Image.FromFile("bDot.png")
                            boardVar(Val(senI), (Val(senj) - 1)) = 1
                        End If
                    Else

                        PictureBox(senI, senj + 1).Image = Nothing
                        boardVar(Val(senI), Val(senj) + 1) = 0
                        Form2.ShowShip(shipVar2)

                        create = False

                        PictureBox(senI, senj).Image = Nothing
                        boardVar(Val(senI), Val(senj)) = 0

                        MessageBox.Show("Ship must be in bounds")

                    End If
                ElseIf I = 2 And create = True Then
                    If senI < 7 And senI >= 0 And senj - 2 < 11 And senj - 2 >= 0 Then
                        If boardVar(Val(senI), (Val(senj) - 2)) = 1 Or create = False Then

                            PictureBox(senI, senj + 1).Image = Nothing
                            boardVar(Val(senI), Val(senj) + 1) = 0
                            Form2.ShowShip(shipVar2)

                            create = False

                            PictureBox(senI, senj).Image = Nothing
                            boardVar(Val(senI), Val(senj)) = 0

                            PictureBox(senI, senj - 1).Image = Nothing
                            boardVar(Val(senI), (Val(senj) - 1)) = 0
                            MessageBox.Show("You can not overlap ships")
                        Else
                            BVar = 1
                            PictureBox(senI, senj - 2).Image = Image.FromFile("bDot.png")
                            boardVar(Val(senI), (Val(senj) - 2)) = 1
                        End If
                    Else

                        PictureBox(senI, senj + 1).Image = Nothing
                        boardVar(Val(senI), Val(senj) + 1) = 0
                        Form2.ShowShip(shipVar2)

                        create = False

                        PictureBox(senI, senj).Image = Nothing
                        boardVar(Val(senI), Val(senj)) = 0

                        PictureBox(senI, senj - 1).Image = Nothing
                        boardVar(Val(senI), (Val(senj) - 1)) = 0

                        MessageBox.Show("Ship must be in bounds")

                    End If
                End If


            Next

        ElseIf AVar = 3 Then
            BVar = 0
            For I = 0 To shipVar - 1 ' Up arrow clicked

                If I = 0 And create = True Then
                    If senI < 7 And senI >= 0 And senj < 11 And senj >= 0 Then
                        If boardVar(Val(senI), Val(senj)) = 1 Or create = False Then

                            PictureBox(senI + 1, senj).Image = Nothing
                            boardVar((Val(senI) + 1), Val(senj)) = 0
                            Form2.ShowShip(shipVar2)
                            MessageBox.Show("You can not overlap ships")
                            create = False

                        Else
                            BVar = 1
                            PictureBox(senI, senj).Image = Image.FromFile("bDot.png")
                            boardVar(Val(senI), Val(senj)) = 1
                        End If
                    Else

                        PictureBox(senI + 1, senj).Image = Nothing
                        boardVar((Val(senI) + 1), Val(senj)) = 0
                        Form2.ShowShip(shipVar2)

                        create = False
                        MessageBox.Show("Ship must be in bounds")

                    End If
                ElseIf I = 1 And create = True Then
                    If senI - 1 < 7 And senI - 1 >= 0 And senj < 11 And senj >= 0 Then
                        If boardVar((Val(senI) - 1), senj) = 1 Or create = False Then

                            PictureBox(senI + 1, senj).Image = Nothing
                            boardVar((Val(senI) + 1), Val(senj)) = 0
                            Form2.ShowShip(shipVar2)

                            create = False

                            PictureBox(senI, senj).Image = Nothing
                            boardVar(Val(senI), Val(senj)) = 0
                            MessageBox.Show("You can not overlap ships")
                        Else
                            BVar = 1
                            PictureBox(senI - 1, senj).Image = Image.FromFile("bDot.png")
                            boardVar((Val(senI) - 1), senj) = 1

                        End If
                    Else

                        PictureBox(senI + 1, senj).Image = Nothing
                        boardVar((Val(senI) + 1), Val(senj)) = 0
                        Form2.ShowShip(shipVar2)

                        create = False

                        PictureBox(senI, senj).Image = Nothing
                        boardVar(Val(senI), Val(senj)) = 0

                        MessageBox.Show("Ship must be in bounds")

                    End If
                ElseIf I = 2 And create = True Then
                    If senI - 2 < 7 And senI - 2 >= 0 And senj < 11 And senj >= 0 Then
                        If boardVar((Val(senI) - 2), senj) = 1 And create = False Then

                            PictureBox(senI + 1, senj).Image = Nothing
                            boardVar((Val(senI) + 1), Val(senj)) = 0
                            Form2.ShowShip(shipVar2)

                            create = False

                            PictureBox(senI, senj).Image = Nothing
                            boardVar(Val(senI), Val(senj)) = 0

                            PictureBox(senI - 1, senj).Image = Nothing
                            boardVar((Val(senI) - 1), senj) = 0
                            MessageBox.Show("You can not overlap ships")
                        Else
                            BVar = 1
                            PictureBox(senI - 2, senj).Image = Image.FromFile("bDot.png")
                            boardVar((Val(senI) - 2), senj) = 1
                        End If
                    Else

                        PictureBox(senI + 1, senj).Image = Nothing
                        boardVar((Val(senI) + 1), Val(senj)) = 0
                        Form2.ShowShip(shipVar2)

                        create = False

                        PictureBox(senI, senj).Image = Nothing
                        boardVar(Val(senI), Val(senj)) = 0

                        PictureBox(senI - 1, senj).Image = Nothing
                        boardVar((Val(senI) - 1), senj) = 0

                        MessageBox.Show("Ship must be in bounds")

                    End If
                End If






            Next
        ElseIf AVar = 4 Then
            BVar = 0
            For I = 0 To shipVar - 1 ' Down arrow clicked

                If I = 0 And create = True Then
                    If senI < 7 And senI >= 0 And senj < 11 And senj >= 0 Then
                        If boardVar(Val(senI), Val(senj)) = 1 Or create = False Then

                            PictureBox(senI - 1, senj).Image = Nothing
                            boardVar((Val(senI) - 1), Val(senj)) = 0
                            Form2.ShowShip(shipVar2)
                            MessageBox.Show("You can not overlap ships")
                            create = False

                        Else
                            BVar = 1
                            PictureBox(senI, senj).Image = Image.FromFile("bDot.png")
                            boardVar(Val(senI), Val(senj)) = 1
                        End If
                    Else
                        PictureBox(senI - 1, senj).Image = Nothing
                        boardVar((Val(senI) - 1), Val(senj)) = 0
                        Form2.ShowShip(shipVar2)

                        create = False
                        MessageBox.Show("Ship must be in bounds")

                    End If
                ElseIf I = 1 And create = True Then
                    If senI + 1 < 7 And senI + 1 >= 0 And senj < 11 And senj >= 0 Then
                        If boardVar((Val(senI) + 1), senj) = 1 Or create = False Then

                            PictureBox(senI - 1, senj).Image = Nothing
                            boardVar((Val(senI) - 1), Val(senj)) = 0
                            Form2.ShowShip(shipVar2)

                            create = False

                            PictureBox(senI, senj).Image = Nothing
                            boardVar(Val(senI), Val(senj)) = 0
                            MessageBox.Show("You can not overlap ships")
                        Else
                            BVar = 1
                            PictureBox(senI + 1, senj).Image = Image.FromFile("bDot.png")
                            boardVar((Val(senI) + 1), senj) = 1
                        End If
                    Else
                        PictureBox(senI - 1, senj).Image = Nothing
                        boardVar((Val(senI) - 1), Val(senj)) = 0
                        Form2.ShowShip(shipVar2)

                        create = False

                        PictureBox(senI, senj).Image = Nothing
                        boardVar(Val(senI), Val(senj)) = 0

                        MessageBox.Show("Ship must be in bounds")

                    End If
                ElseIf I = 2 And create = True Then
                    If senI + 2 < 7 And senI + 2 >= 0 And senj < 11 And senj >= 0 Then
                        If boardVar((Val(senI) + 2), senj) = 1 Or create = False Then

                            PictureBox(senI - 1, senj).Image = Nothing
                            boardVar((Val(senI) - 1), Val(senj)) = 0
                            Form2.ShowShip(shipVar2)

                            create = False

                            PictureBox(senI, senj).Image = Nothing
                            boardVar(Val(senI), Val(senj)) = 0

                            PictureBox(senI + 1, senj).Image = Nothing
                            boardVar((Val(senI) + 1), senj) = 0
                            MessageBox.Show("You can not overlap ships")
                        Else
                            BVar = 1
                            PictureBox(senI + 2, senj).Image = Image.FromFile("bDot.png")
                            boardVar((Val(senI) + 2), senj) = 1
                        End If
                    Else
                        PictureBox(senI - 1, senj).Image = Nothing
                        boardVar((Val(senI) - 1), Val(senj)) = 0
                        Form2.ShowShip(shipVar2)

                        create = False

                        PictureBox(senI, senj).Image = Nothing
                        boardVar(Val(senI), Val(senj)) = 0

                        PictureBox(senI + 1, senj).Image = Nothing
                        boardVar((Val(senI) + 1), senj) = 0

                        MessageBox.Show("Ship must be in bounds")

                    End If
                End If







            Next

        End If
        shipVar2 = 0

    End Sub

    Public Sub placeShip(sender As Object, e As MouseEventArgs)

        Dim senI As String
        Dim senj As String
        Dim thetag As String = ""
        If sender.tag.length < 3 Then
            senj = "0" & sender.tag.Chars(1)
            senI = sender.tag.Chars(0)
        Else
            senj = sender.tag.Chars(1) & sender.tag.Chars(2)
            senI = sender.tag.Chars(0)
        End If
        Console.WriteLine(senI & " " & senj)
        If inGame = False Then
            If shipVar <> 0 And posVar <> 0 Then ' Making the arrows
                For I = 0 To 3
                    PictureBox2(I) = New myPictureBox



                    PictureBox2(I).Width = picWidth


                    PictureBox2(I).Height = picHeight
                    If I = 0 Then ' right arrow

                        PictureBox2(I).Top = sender.Top
                        PictureBox2(I).Name = 0
                        PictureBox2(I).Left = sender.Left + 75

                        PictureBox2(I).Tag = senI & senj + 1
                        PictureBox2(I).Image = Image.FromFile("rightA.png")
                    ElseIf I = 1 Then ' left arrow

                        PictureBox2(I).Top = sender.Top
                        PictureBox2(I).Name = 1
                        PictureBox2(I).Left = sender.Left - 75
                        PictureBox2(I).Tag = senI & senj - 1
                        PictureBox2(I).Image = Image.FromFile("leftA.png")

                    ElseIf I = 2 Then ' up arrow

                        PictureBox2(I).Top = sender.Top - 75

                        PictureBox2(I).Left = sender.Left
                        PictureBox2(I).Tag = senI - 1 & senj
                        PictureBox2(I).Image = Image.FromFile("upA.png")

                    ElseIf I = 3 Then ' down arrow

                        PictureBox2(I).Top = sender.Top + 75

                        PictureBox2(I).Left = sender.Left
                        PictureBox2(I).Tag = senI + 1 & senj
                        PictureBox2(I).Image = Image.FromFile("downA.png")

                    End If

                    PictureBox2(I).BorderStyle = BorderStyle.None
                    ' ControlPaint.DrawBorder(.Graphics, pe.ClipRectangle, Color.Gray, ButtonBorderStyle.Solid)
                    PictureBox2(I).BackColor = Color.Transparent

                    PictureBox2(I).Name = I

                    PictureBox2(I).SizeMode = PictureBoxSizeMode.Zoom


                    Me.Controls.Add(PictureBox2(I))
                    PictureBox2(I).BringToFront()
                    AddHandler PictureBox2(I).MouseDown, AddressOf makeShip


                Next
            End If

            BVar = 0

            If shipVar = 1 Then
                If countVar <> 1 Then

                    sender.Image = Image.FromFile("bDot.png")
                    countVar = 1
                    posVar = 0
                    BVar = 1
                End If

            ElseIf shipVar = 2 Then
                If countVar <> 1 Then

                    sender.Image = Image.FromFile("bDot.png")
                    countVar = 1
                    posVar = 0
                    BVar = 1
                End If
            ElseIf shipVar = 3 Then
                If countVar <> 1 Then

                    sender.Image = Image.FromFile("bDot.png")
                    countVar = 1
                    posVar = 0
                    BVar = 1
                End If
            End If
            If BVar = 1 Then

                boardVar(Val(senI), Val(senj)) = 1


            End If
        End If

    End Sub
End Class
