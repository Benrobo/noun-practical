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
        Me.calcBtn = New System.Windows.Forms.Button()
        Me.initialInp = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.output = New System.Windows.Forms.Label()
        Me.outputValue = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'calcBtn
        '
        Me.calcBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calcBtn.Location = New System.Drawing.Point(21, 158)
        Me.calcBtn.Name = "calcBtn"
        Me.calcBtn.Size = New System.Drawing.Size(523, 65)
        Me.calcBtn.TabIndex = 0
        Me.calcBtn.Text = "Calculate Expected Amount"
        Me.calcBtn.UseVisualStyleBackColor = True
        '
        'initialInp
        '
        Me.initialInp.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.initialInp.Location = New System.Drawing.Point(21, 74)
        Me.initialInp.Name = "initialInp"
        Me.initialInp.Size = New System.Drawing.Size(235, 44)
        Me.initialInp.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Initial Amount"
        '
        'output
        '
        Me.output.AutoSize = True
        Me.output.Location = New System.Drawing.Point(306, 48)
        Me.output.Name = "output"
        Me.output.Size = New System.Drawing.Size(91, 13)
        Me.output.TabIndex = 3
        Me.output.Text = "Expected Amount"
        '
        'outputValue
        '
        Me.outputValue.Enabled = False
        Me.outputValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outputValue.Location = New System.Drawing.Point(309, 74)
        Me.outputValue.Name = "outputValue"
        Me.outputValue.Size = New System.Drawing.Size(235, 44)
        Me.outputValue.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 258)
        Me.Controls.Add(Me.outputValue)
        Me.Controls.Add(Me.output)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.initialInp)
        Me.Controls.Add(Me.calcBtn)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents calcBtn As Button
    Friend WithEvents initialInp As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents output As Label
    Friend WithEvents outputValue As TextBox
End Class
