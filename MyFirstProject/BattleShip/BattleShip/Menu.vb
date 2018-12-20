Public Class Menu

    ' Done with comments

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Form1.Show() ' start the game in the right order
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Top = 150
        Me.Left = 300
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AboutBoxBattleship.Show()
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
End Class