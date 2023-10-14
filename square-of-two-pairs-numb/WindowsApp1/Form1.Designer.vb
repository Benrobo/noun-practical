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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.firstNumber = New System.Windows.Forms.TextBox()
        Me.lastNumber = New System.Windows.Forms.TextBox()
        Me.output = New System.Windows.Forms.RichTextBox()
        Me.solveBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Last Number"
        '
        'firstNumber
        '
        Me.firstNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstNumber.Location = New System.Drawing.Point(179, 58)
        Me.firstNumber.Name = "firstNumber"
        Me.firstNumber.Size = New System.Drawing.Size(127, 47)
        Me.firstNumber.TabIndex = 2
        '
        'lastNumber
        '
        Me.lastNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastNumber.Location = New System.Drawing.Point(176, 126)
        Me.lastNumber.Name = "lastNumber"
        Me.lastNumber.Size = New System.Drawing.Size(127, 47)
        Me.lastNumber.TabIndex = 3
        '
        'output
        '
        Me.output.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.output.Location = New System.Drawing.Point(327, 58)
        Me.output.MinimumSize = New System.Drawing.Size(10, 10)
        Me.output.Name = "output"
        Me.output.ReadOnly = True
        Me.output.Size = New System.Drawing.Size(267, 115)
        Me.output.TabIndex = 10
        Me.output.Text = "(0,0)"
        '
        'solveBtn
        '
        Me.solveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.solveBtn.Location = New System.Drawing.Point(46, 217)
        Me.solveBtn.Name = "solveBtn"
        Me.solveBtn.Size = New System.Drawing.Size(548, 87)
        Me.solveBtn.TabIndex = 5
        Me.solveBtn.Text = "Solve"
        Me.solveBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 350)
        Me.Controls.Add(Me.solveBtn)
        Me.Controls.Add(Me.output)
        Me.Controls.Add(Me.lastNumber)
        Me.Controls.Add(Me.firstNumber)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents firstNumber As TextBox
    Friend WithEvents lastNumber As TextBox
    Friend WithEvents output As RichTextBox
    Friend WithEvents solveBtn As Button
End Class
