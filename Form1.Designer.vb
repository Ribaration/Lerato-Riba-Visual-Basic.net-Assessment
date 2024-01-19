<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        textBox = New TextBox()
        addButton = New Button()
        listBox = New ListBox()
        label = New Label()
        toUpperRadioButton = New RadioButton()
        toLowerRadioButton = New RadioButton()
        purpleRadioButton = New RadioButton()
        blueRadioButton = New RadioButton()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' textBox
        ' 
        textBox.Location = New Point(21, 27)
        textBox.Name = "textBox"
        textBox.Size = New Size(249, 23)
        textBox.TabIndex = 0
        ' 
        ' addButton
        ' 
        addButton.Location = New Point(54, 78)
        addButton.Name = "addButton"
        addButton.Size = New Size(187, 23)
        addButton.TabIndex = 1
        addButton.Text = "Add"
        addButton.UseVisualStyleBackColor = True
        ' 
        ' listBox
        ' 
        listBox.FormattingEnabled = True
        listBox.ItemHeight = 15
        listBox.Location = New Point(27, 118)
        listBox.Name = "listBox"
        listBox.Size = New Size(243, 124)
        listBox.TabIndex = 2
        ' 
        ' label
        ' 
        label.AutoSize = True
        label.Location = New Point(83, 275)
        label.Name = "label"
        label.Size = New Size(41, 15)
        label.TabIndex = 3
        label.Text = "Label1"
        ' 
        ' toUpperRadioButton
        ' 
        toUpperRadioButton.AutoSize = True
        toUpperRadioButton.Location = New Point(6, 22)
        toUpperRadioButton.Name = "toUpperRadioButton"
        toUpperRadioButton.Size = New Size(72, 19)
        toUpperRadioButton.TabIndex = 4
        toUpperRadioButton.TabStop = True
        toUpperRadioButton.Text = "To Upper"
        toUpperRadioButton.UseVisualStyleBackColor = True
        ' 
        ' toLowerRadioButton
        ' 
        toLowerRadioButton.AutoSize = True
        toLowerRadioButton.Location = New Point(6, 62)
        toLowerRadioButton.Name = "toLowerRadioButton"
        toLowerRadioButton.Size = New Size(72, 19)
        toLowerRadioButton.TabIndex = 5
        toLowerRadioButton.TabStop = True
        toLowerRadioButton.Text = "To Lower"
        toLowerRadioButton.UseVisualStyleBackColor = True
        ' 
        ' purpleRadioButton
        ' 
        purpleRadioButton.AutoSize = True
        purpleRadioButton.Location = New Point(15, 22)
        purpleRadioButton.Name = "purpleRadioButton"
        purpleRadioButton.Size = New Size(59, 19)
        purpleRadioButton.TabIndex = 6
        purpleRadioButton.TabStop = True
        purpleRadioButton.Text = "Purple"
        purpleRadioButton.UseVisualStyleBackColor = True
        ' 
        ' blueRadioButton
        ' 
        blueRadioButton.AutoSize = True
        blueRadioButton.Location = New Point(15, 62)
        blueRadioButton.Name = "blueRadioButton"
        blueRadioButton.Size = New Size(48, 19)
        blueRadioButton.TabIndex = 7
        blueRadioButton.TabStop = True
        blueRadioButton.Text = "Blue"
        blueRadioButton.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(21, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(76, 15)
        Label1.TabIndex = 8
        Label1.Text = "Enter a word:"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(toUpperRadioButton)
        GroupBox1.Controls.Add(toLowerRadioButton)
        GroupBox1.Location = New Point(21, 320)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(132, 103)
        GroupBox1.TabIndex = 9
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(purpleRadioButton)
        GroupBox2.Controls.Add(blueRadioButton)
        GroupBox2.Location = New Point(178, 320)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(133, 103)
        GroupBox2.TabIndex = 0
        GroupBox2.TabStop = False
        GroupBox2.Text = "Colour"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Controls.Add(label)
        Controls.Add(listBox)
        Controls.Add(addButton)
        Controls.Add(textBox)
        Name = "Form1"
        Text = "Words"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents textBox As TextBox
    Friend WithEvents addButton As Button
    Friend WithEvents listBox As ListBox
    Friend WithEvents label As Label
    Friend WithEvents toUpperRadioButton As RadioButton
    Friend WithEvents toLowerRadioButton As RadioButton
    Friend WithEvents purpleRadioButton As RadioButton
    Friend WithEvents blueRadioButton As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox

End Class
