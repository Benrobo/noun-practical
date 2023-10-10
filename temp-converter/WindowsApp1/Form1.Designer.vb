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
        Me.Title = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.celciusInput = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fahrenheitInput = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.fahRadioInput = New System.Windows.Forms.RadioButton()
        Me.celRadioInput = New System.Windows.Forms.RadioButton()
        Me.convertBtn = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.Color.White
        Me.Title.Location = New System.Drawing.Point(118, 8)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(262, 23)
        Me.Title.TabIndex = 0
        Me.Title.Text = "Temperature Converter"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.Location = New System.Drawing.Point(28, 153)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Celcius"
        '
        'celciusInput
        '
        Me.celciusInput.BackColor = System.Drawing.Color.Black
        Me.celciusInput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.celciusInput.Font = New System.Drawing.Font("Verdana", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.celciusInput.ForeColor = System.Drawing.Color.White
        Me.celciusInput.HideSelection = False
        Me.celciusInput.Location = New System.Drawing.Point(31, 174)
        Me.celciusInput.Name = "celciusInput"
        Me.celciusInput.Size = New System.Drawing.Size(199, 44)
        Me.celciusInput.TabIndex = 2
        Me.celciusInput.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label2.Location = New System.Drawing.Point(399, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fahrenheit"
        '
        'fahrenheitInput
        '
        Me.fahrenheitInput.BackColor = System.Drawing.Color.Black
        Me.fahrenheitInput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.fahrenheitInput.Font = New System.Drawing.Font("Verdana", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fahrenheitInput.ForeColor = System.Drawing.Color.White
        Me.fahrenheitInput.Location = New System.Drawing.Point(296, 174)
        Me.fahrenheitInput.Name = "fahrenheitInput"
        Me.fahrenheitInput.Size = New System.Drawing.Size(199, 43)
        Me.fahrenheitInput.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.fahRadioInput)
        Me.Panel2.Controls.Add(Me.celRadioInput)
        Me.Panel2.Location = New System.Drawing.Point(31, 58)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(249, 81)
        Me.Panel2.TabIndex = 5
        '
        'fahRadioInput
        '
        Me.fahRadioInput.AutoSize = True
        Me.fahRadioInput.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fahRadioInput.ForeColor = System.Drawing.Color.White
        Me.fahRadioInput.Location = New System.Drawing.Point(16, 49)
        Me.fahRadioInput.Name = "fahRadioInput"
        Me.fahRadioInput.Size = New System.Drawing.Size(163, 17)
        Me.fahRadioInput.TabIndex = 1
        Me.fahRadioInput.TabStop = True
        Me.fahRadioInput.Text = "Fahrenheit to Celcius"
        Me.fahRadioInput.UseVisualStyleBackColor = True
        '
        'celRadioInput
        '
        Me.celRadioInput.AutoSize = True
        Me.celRadioInput.Checked = True
        Me.celRadioInput.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.celRadioInput.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.celRadioInput.Location = New System.Drawing.Point(16, 15)
        Me.celRadioInput.Name = "celRadioInput"
        Me.celRadioInput.Size = New System.Drawing.Size(163, 17)
        Me.celRadioInput.TabIndex = 0
        Me.celRadioInput.TabStop = True
        Me.celRadioInput.Text = "Celcius to Fahrenheit"
        Me.celRadioInput.UseVisualStyleBackColor = True
        '
        'convertBtn
        '
        Me.convertBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.convertBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.convertBtn.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.convertBtn.ForeColor = System.Drawing.Color.White
        Me.convertBtn.Location = New System.Drawing.Point(32, 228)
        Me.convertBtn.Name = "convertBtn"
        Me.convertBtn.Size = New System.Drawing.Size(462, 56)
        Me.convertBtn.TabIndex = 6
        Me.convertBtn.Text = "Convert"
        Me.convertBtn.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(527, 311)
        Me.Controls.Add(Me.convertBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.fahrenheitInput)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.celciusInput)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Title As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents celciusInput As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents fahrenheitInput As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents celRadioInput As RadioButton
    Friend WithEvents fahRadioInput As RadioButton
    Friend WithEvents convertBtn As Button
End Class
