Imports System.Windows.Forms
Imports System.Drawing
Public Class myPictureBox
    Inherits PictureBox
    Protected Overrides Sub OnPaint(ByVal pe As System.Windows.Forms.PaintEventArgs)
       
        ControlPaint.DrawBorder(pe.Graphics, pe.ClipRectangle, Color.Red, ButtonBorderStyle.Outset)

        MyBase.OnPaint(pe)
    End Sub
    
End Class