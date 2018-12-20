<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.PBXBig = New System.Windows.Forms.PictureBox()
        Me.PBXMed = New System.Windows.Forms.PictureBox()
        Me.PBXBig2 = New System.Windows.Forms.PictureBox()
        Me.PBXMed2 = New System.Windows.Forms.PictureBox()
        Me.PBXSmll2 = New System.Windows.Forms.PictureBox()
        Me.PBXSmll = New System.Windows.Forms.PictureBox()
        Me.BTNDone = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTNAuto = New System.Windows.Forms.Button()
        Me.BTNReset = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.PBXBig, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBXMed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBXBig2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBXMed2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBXSmll2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBXSmll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBXBig
        '
        Me.PBXBig.Image = CType(resources.GetObject("PBXBig.Image"), System.Drawing.Image)
        Me.PBXBig.Location = New System.Drawing.Point(16, 15)
        Me.PBXBig.Margin = New System.Windows.Forms.Padding(4)
        Me.PBXBig.Name = "PBXBig"
        Me.PBXBig.Size = New System.Drawing.Size(253, 101)
        Me.PBXBig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBXBig.TabIndex = 0
        Me.PBXBig.TabStop = False
        '
        'PBXMed
        '
        Me.PBXMed.Image = CType(resources.GetObject("PBXMed.Image"), System.Drawing.Image)
        Me.PBXMed.Location = New System.Drawing.Point(16, 231)
        Me.PBXMed.Margin = New System.Windows.Forms.Padding(4)
        Me.PBXMed.Name = "PBXMed"
        Me.PBXMed.Size = New System.Drawing.Size(253, 101)
        Me.PBXMed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBXMed.TabIndex = 1
        Me.PBXMed.TabStop = False
        '
        'PBXBig2
        '
        Me.PBXBig2.Image = CType(resources.GetObject("PBXBig2.Image"), System.Drawing.Image)
        Me.PBXBig2.Location = New System.Drawing.Point(16, 123)
        Me.PBXBig2.Margin = New System.Windows.Forms.Padding(4)
        Me.PBXBig2.Name = "PBXBig2"
        Me.PBXBig2.Size = New System.Drawing.Size(253, 101)
        Me.PBXBig2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBXBig2.TabIndex = 2
        Me.PBXBig2.TabStop = False
        '
        'PBXMed2
        '
        Me.PBXMed2.Image = CType(resources.GetObject("PBXMed2.Image"), System.Drawing.Image)
        Me.PBXMed2.Location = New System.Drawing.Point(16, 340)
        Me.PBXMed2.Margin = New System.Windows.Forms.Padding(4)
        Me.PBXMed2.Name = "PBXMed2"
        Me.PBXMed2.Size = New System.Drawing.Size(253, 101)
        Me.PBXMed2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBXMed2.TabIndex = 3
        Me.PBXMed2.TabStop = False
        '
        'PBXSmll2
        '
        Me.PBXSmll2.Image = CType(resources.GetObject("PBXSmll2.Image"), System.Drawing.Image)
        Me.PBXSmll2.Location = New System.Drawing.Point(16, 556)
        Me.PBXSmll2.Margin = New System.Windows.Forms.Padding(4)
        Me.PBXSmll2.Name = "PBXSmll2"
        Me.PBXSmll2.Size = New System.Drawing.Size(253, 101)
        Me.PBXSmll2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBXSmll2.TabIndex = 4
        Me.PBXSmll2.TabStop = False
        '
        'PBXSmll
        '
        Me.PBXSmll.Image = CType(resources.GetObject("PBXSmll.Image"), System.Drawing.Image)
        Me.PBXSmll.Location = New System.Drawing.Point(16, 448)
        Me.PBXSmll.Margin = New System.Windows.Forms.Padding(4)
        Me.PBXSmll.Name = "PBXSmll"
        Me.PBXSmll.Size = New System.Drawing.Size(253, 101)
        Me.PBXSmll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBXSmll.TabIndex = 5
        Me.PBXSmll.TabStop = False
        '
        'BTNDone
        '
        Me.BTNDone.Location = New System.Drawing.Point(297, 123)
        Me.BTNDone.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNDone.Name = "BTNDone"
        Me.BTNDone.Size = New System.Drawing.Size(133, 50)
        Me.BTNDone.TabIndex = 6
        Me.BTNDone.Text = "Done"
        Me.BTNDone.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(328, 4)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 24)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Set Up Phase"
        '
        'BTNAuto
        '
        Me.BTNAuto.Location = New System.Drawing.Point(329, 31)
        Me.BTNAuto.Name = "BTNAuto"
        Me.BTNAuto.Size = New System.Drawing.Size(101, 50)
        Me.BTNAuto.TabIndex = 9
        Me.BTNAuto.Text = "Automatic Placement"
        Me.BTNAuto.UseVisualStyleBackColor = True
        '
        'BTNReset
        '
        Me.BTNReset.Location = New System.Drawing.Point(329, 87)
        Me.BTNReset.Name = "BTNReset"
        Me.BTNReset.Size = New System.Drawing.Size(101, 29)
        Me.BTNReset.TabIndex = 10
        Me.BTNReset.Text = "Reset"
        Me.BTNReset.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(370, 656)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 26)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button3.Location = New System.Drawing.Point(390, 624)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(63, 26)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "About"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 694)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BTNReset)
        Me.Controls.Add(Me.BTNAuto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTNDone)
        Me.Controls.Add(Me.PBXSmll)
        Me.Controls.Add(Me.PBXSmll2)
        Me.Controls.Add(Me.PBXMed2)
        Me.Controls.Add(Me.PBXBig2)
        Me.Controls.Add(Me.PBXMed)
        Me.Controls.Add(Me.PBXBig)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form2"
        Me.Text = "Setup Phase"
        CType(Me.PBXBig, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBXMed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBXBig2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBXMed2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBXSmll2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBXSmll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PBXBig As System.Windows.Forms.PictureBox
    Friend WithEvents PBXMed As System.Windows.Forms.PictureBox
    Friend WithEvents PBXBig2 As System.Windows.Forms.PictureBox
    Friend WithEvents PBXMed2 As System.Windows.Forms.PictureBox
    Friend WithEvents PBXSmll2 As System.Windows.Forms.PictureBox
    Friend WithEvents PBXSmll As System.Windows.Forms.PictureBox
    Friend WithEvents BTNDone As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BTNAuto As Button
    Friend WithEvents BTNReset As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
End Class
