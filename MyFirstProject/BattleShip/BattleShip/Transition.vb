Public Class Transition
    Dim transVar As Boolean = False

    ' Done with comments

    Private Sub Transition_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 50
        Me.Left = 75
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Me.KeyDown

        change()

    End Sub
    Private Sub EnterPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Enter Then

            change()

        End If

    End Sub
    Public Sub change()

        transVar = Not transVar ' do the opposite everytime the button is pressed

        If transVar = False Then
            Label1.Text = "Your Turn!" ' tell the user it is their turn
            Form1.Hide()
            Game.Tstart()


        ElseIf transVar = True Then
            Label1.Text = "Comp's Turn!" ' call the computer's guess
            Form1.Show()
            Form1.compGuess()
            Game.Hide()


        End If



    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' close all forms
        BattleShip.My.Forms.compBoard.Close()
        BattleShip.My.Forms.Form1.Close()
        BattleShip.My.Forms.Form2.Close()
        BattleShip.My.Forms.Game.Close()
        BattleShip.My.Forms.Menu.Close()
        BattleShip.My.Forms.Transition.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' about box to show
        AboutBoxBattleship.Show()

    End Sub
End Class