<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lstResult = New System.Windows.Forms.ListBox()
        Me.lblHighest = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Solve"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lstResult
        '
        Me.lstResult.FormattingEnabled = True
        Me.lstResult.ItemHeight = 15
        Me.lstResult.Location = New System.Drawing.Point(93, 12)
        Me.lstResult.MultiColumn = True
        Me.lstResult.Name = "lstResult"
        Me.lstResult.Size = New System.Drawing.Size(695, 424)
        Me.lstResult.Sorted = True
        Me.lstResult.TabIndex = 1
        '
        'lblHighest
        '
        Me.lblHighest.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblHighest.Location = New System.Drawing.Point(13, 146)
        Me.lblHighest.Name = "lblHighest"
        Me.lblHighest.Size = New System.Drawing.Size(64, 17)
        Me.lblHighest.TabIndex = 2
        Me.lblHighest.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(13, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 98)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "The highest palindromic product of two three-digit numbers is:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblHighest)
        Me.Controls.Add(Me.lstResult)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Project Euler Problem 4"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents lstResult As ListBox
    Friend WithEvents lblHighest As Label
    Friend WithEvents Label1 As Label
End Class
