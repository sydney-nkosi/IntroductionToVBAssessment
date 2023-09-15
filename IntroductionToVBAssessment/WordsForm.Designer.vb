<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WordsForm
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
        Label1 = New Label()
        txtWordBox = New TextBox()
        btnAdd = New Button()
        lbWords = New ListBox()
        lblText = New Label()
        gbCase = New GroupBox()
        rbToLower = New RadioButton()
        rbToUpper = New RadioButton()
        gbColor = New GroupBox()
        rbBlue = New RadioButton()
        rbPurple = New RadioButton()
        btnClear = New Button()
        gbCase.SuspendLayout()
        gbColor.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(114, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(116, 25)
        Label1.TabIndex = 0
        Label1.Text = "Enter a word:"
        ' 
        ' txtWordBox
        ' 
        txtWordBox.Location = New Point(114, 67)
        txtWordBox.MinimumSize = New Size(562, 40)
        txtWordBox.Name = "txtWordBox"
        txtWordBox.Size = New Size(562, 40)
        txtWordBox.TabIndex = 1
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(105, 136)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(231, 34)
        btnAdd.TabIndex = 2
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' lbWords
        ' 
        lbWords.FormattingEnabled = True
        lbWords.ItemHeight = 25
        lbWords.Location = New Point(117, 199)
        lbWords.Name = "lbWords"
        lbWords.Size = New Size(559, 329)
        lbWords.TabIndex = 3
        ' 
        ' lblText
        ' 
        lblText.BackColor = Color.Transparent
        lblText.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point)
        lblText.Location = New Point(-2, 563)
        lblText.Name = "lblText"
        lblText.Size = New Size(804, 50)
        lblText.TabIndex = 4
        lblText.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' gbCase
        ' 
        gbCase.Controls.Add(rbToLower)
        gbCase.Controls.Add(rbToUpper)
        gbCase.Location = New Point(57, 687)
        gbCase.Name = "gbCase"
        gbCase.Size = New Size(300, 150)
        gbCase.TabIndex = 5
        gbCase.TabStop = False
        gbCase.Text = "Case"
        ' 
        ' rbToLower
        ' 
        rbToLower.AutoSize = True
        rbToLower.Location = New Point(14, 88)
        rbToLower.Name = "rbToLower"
        rbToLower.Size = New Size(107, 29)
        rbToLower.TabIndex = 1
        rbToLower.TabStop = True
        rbToLower.Text = "To Lower"
        rbToLower.UseVisualStyleBackColor = True
        ' 
        ' rbToUpper
        ' 
        rbToUpper.AutoSize = True
        rbToUpper.Location = New Point(14, 43)
        rbToUpper.Name = "rbToUpper"
        rbToUpper.Size = New Size(109, 29)
        rbToUpper.TabIndex = 0
        rbToUpper.TabStop = True
        rbToUpper.Text = "To Upper"
        rbToUpper.UseVisualStyleBackColor = True
        ' 
        ' gbColor
        ' 
        gbColor.Controls.Add(rbBlue)
        gbColor.Controls.Add(rbPurple)
        gbColor.Location = New Point(452, 687)
        gbColor.Name = "gbColor"
        gbColor.Size = New Size(300, 150)
        gbColor.TabIndex = 6
        gbColor.TabStop = False
        gbColor.Text = "Color"
        ' 
        ' rbBlue
        ' 
        rbBlue.AutoSize = True
        rbBlue.Location = New Point(6, 88)
        rbBlue.Name = "rbBlue"
        rbBlue.Size = New Size(70, 29)
        rbBlue.TabIndex = 3
        rbBlue.TabStop = True
        rbBlue.Text = "Blue"
        rbBlue.UseVisualStyleBackColor = True
        ' 
        ' rbPurple
        ' 
        rbPurple.AutoSize = True
        rbPurple.Location = New Point(6, 43)
        rbPurple.Name = "rbPurple"
        rbPurple.Size = New Size(87, 29)
        rbPurple.TabIndex = 2
        rbPurple.TabStop = True
        rbPurple.Text = "Purple"
        rbPurple.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(445, 136)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(231, 34)
        btnClear.TabIndex = 7
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' WordsForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 938)
        Controls.Add(btnClear)
        Controls.Add(gbColor)
        Controls.Add(gbCase)
        Controls.Add(lblText)
        Controls.Add(lbWords)
        Controls.Add(btnAdd)
        Controls.Add(txtWordBox)
        Controls.Add(Label1)
        Name = "WordsForm"
        Text = "Words"
        gbCase.ResumeLayout(False)
        gbCase.PerformLayout()
        gbColor.ResumeLayout(False)
        gbColor.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtWordBox As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents lbWords As ListBox
    Friend WithEvents lblText As Label
    Friend WithEvents gbCase As GroupBox
    Friend WithEvents rbToLower As RadioButton
    Friend WithEvents rbToUpper As RadioButton
    Friend WithEvents gbColor As GroupBox
    Friend WithEvents rbBlue As RadioButton
    Friend WithEvents rbPurple As RadioButton
    Friend WithEvents btnClear As Button
End Class
