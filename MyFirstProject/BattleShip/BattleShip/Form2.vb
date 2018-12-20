Public Class Form2
    Dim PictureBox(12, 12) As myPictureBox
    Dim picWidth As Integer = 400
    Dim picHeight As Integer = 100
    Dim gap As Integer = 0

    ' Done with comments

    Public Sub ShowShip(ByVal ship As Integer)

        ' If user made a mistake in choosing their ships, will call this procedure to let them choose another spot

        If ship = 1 Then

            PBXBig.Show()
            PBXBig.Enabled = True
        ElseIf ship = 2 Then

            PBXBig2.Show()
            PBXBig2.Enabled = True
        ElseIf ship = 3 Then

            PBXMed.Show()
            PBXMed.Enabled = True
        ElseIf ship = 4 Then

            PBXMed2.Show()
            PBXMed2.Enabled = True
        ElseIf ship = 5 Then

            PBXSmll.Show()
            PBXSmll.Enabled = True
        ElseIf ship = 6 Then

            PBXSmll2.Show()
            PBXSmll2.Enabled = True
        End If

    End Sub

    Private Sub PBXBig_Click(sender As Object, e As EventArgs) Handles PBXBig.Click

        Form1.bigShip()
        PBXBig.Hide()
        PBXBig.Enabled = False
    End Sub

    Private Sub PBXBig2_Click(sender As Object, e As EventArgs) Handles PBXBig2.Click

        Form1.bigShip2()
        PBXBig2.Hide()
        PBXBig2.Enabled = False
    End Sub

    Private Sub PBXMed_Click(sender As Object, e As EventArgs) Handles PBXMed.Click

        Form1.medShip()
        PBXMed.Hide()
        PBXMed.Enabled = False

    End Sub

    Private Sub PBXMed2_Click(sender As Object, e As EventArgs) Handles PBXMed2.Click

        Form1.medShip2()
        PBXMed2.Hide()
        PBXMed2.Enabled = False
    End Sub

    Private Sub PBXSmll_Click(sender As Object, e As EventArgs) Handles PBXSmll.Click

        Form1.smllShip()
        PBXSmll.Hide()
        PBXSmll.Enabled = False
    End Sub

    Private Sub PBXSmll2_Click(sender As Object, e As EventArgs) Handles PBXSmll2.Click

        Form1.smllShip2()
        PBXSmll2.Hide()
        PBXSmll2.Enabled = False
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) 
        ' call the player's board procedure
        Form1.makeBoard()

    End Sub


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        Me.Top = 50
        Me.Left = 75
    End Sub

    Private Sub BTNDone_Click(sender As Object, e As EventArgs) Handles BTNDone.Click
        ' when all ships are placed and the done button is pressed

        Form1.Hide()
        Game.Show()
        Transition.Show()
        Game.compBoard()
        Form1.gameStart()

        Me.Hide()



    End Sub

    Private Sub BTNAuto_Click(sender As Object, e As EventArgs) Handles BTNAuto.Click
        Form1.Clear()

        PBXBig.Hide()
        PBXBig.Enabled = False

        PBXBig2.Hide()
        PBXBig2.Enabled = False

        PBXMed.Hide()
        PBXMed.Enabled = False

        PBXMed2.Hide()
        PBXMed2.Enabled = False

        PBXSmll.Hide()
        PBXSmll.Enabled = False

        PBXSmll2.Hide()
        PBXSmll2.Enabled = False

        Form1.autoBoard(4)
        Form1.autoBoard(3)
        Form1.autoBoard(2)
    End Sub

    Private Sub BTNReset_Click(sender As Object, e As EventArgs) Handles BTNReset.Click
        Form1.Clear()
        PBXBig.Show()
        PBXBig.Enabled = True

        PBXBig2.Show()
        PBXBig2.Enabled = True

        PBXMed.Show()
        PBXMed.Enabled = True

        PBXMed2.Show()
        PBXMed2.Enabled = True

        PBXSmll.Show()
        PBXSmll.Enabled = True

        PBXSmll2.Show()
        PBXSmll2.Enabled = True

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AboutBoxBattleship.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        ' close all forms
        BattleShip.My.Forms.compBoard.Close()
        BattleShip.My.Forms.Form1.Close()
        BattleShip.My.Forms.Form2.Close()
        BattleShip.My.Forms.Game.Close()
        BattleShip.My.Forms.Menu.Close()
        BattleShip.My.Forms.Transition.Close()

    End Sub
End Class