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
        Me.components = New System.ComponentModel.Container
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.DisplayTextBox = New System.Windows.Forms.TextBox
        Me.Button7 = New System.Windows.Forms.Button
        Me.Clipboard_GroupBox = New System.Windows.Forms.GroupBox
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.ClearButton = New System.Windows.Forms.Button
        Me.KeyboardGroupBox = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.HandleKeyboardCheckBox = New System.Windows.Forms.CheckBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.MouseGroupBox = New System.Windows.Forms.GroupBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.ClickCheckBox = New System.Windows.Forms.CheckBox
        Me.MouseLocationTextBox = New System.Windows.Forms.TextBox
        Me.HandleMouseCheckBox = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.KeyboardHook1 = New WindowsHookLib.KeyboardHook
        Me.MouseHook1 = New WindowsHookLib.MouseHook
        Me.ClipboardHook1 = New WindowsHookLib.ClipboardHook
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Clipboard_GroupBox.SuspendLayout()
        Me.KeyboardGroupBox.SuspendLayout()
        Me.MouseGroupBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.DisplayTextBox)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button7)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Clipboard_GroupBox)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ClearButton)
        Me.SplitContainer1.Panel2.Controls.Add(Me.KeyboardGroupBox)
        Me.SplitContainer1.Panel2.Controls.Add(Me.MouseGroupBox)
        Me.SplitContainer1.Size = New System.Drawing.Size(635, 618)
        Me.SplitContainer1.SplitterDistance = 455
        Me.SplitContainer1.TabIndex = 11
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(-4, -2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(171, 20)
        Me.TextBox1.TabIndex = 10
        Me.TextBox1.Text = "g:\dailybakup\bak.txt"
        '
        'DisplayTextBox
        '
        Me.DisplayTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.DisplayTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DisplayTextBox.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayTextBox.Location = New System.Drawing.Point(0, 0)
        Me.DisplayTextBox.Multiline = True
        Me.DisplayTextBox.Name = "DisplayTextBox"
        Me.DisplayTextBox.ReadOnly = True
        Me.DisplayTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DisplayTextBox.Size = New System.Drawing.Size(455, 618)
        Me.DisplayTextBox.TabIndex = 9
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(17, 543)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 15
        Me.Button7.Text = "Button7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Clipboard_GroupBox
        '
        Me.Clipboard_GroupBox.Controls.Add(Me.Button6)
        Me.Clipboard_GroupBox.Controls.Add(Me.Button5)
        Me.Clipboard_GroupBox.Location = New System.Drawing.Point(3, 437)
        Me.Clipboard_GroupBox.Name = "Clipboard_GroupBox"
        Me.Clipboard_GroupBox.Size = New System.Drawing.Size(167, 100)
        Me.Clipboard_GroupBox.TabIndex = 15
        Me.Clipboard_GroupBox.TabStop = False
        Me.Clipboard_GroupBox.Text = "Clipboard"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(6, 57)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(145, 23)
        Me.Button6.TabIndex = 16
        Me.Button6.Text = "Uninstall Clipboard Hook"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(6, 28)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(145, 23)
        Me.Button5.TabIndex = 14
        Me.Button5.Text = "Install Clipboard Hook"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClearButton.Location = New System.Drawing.Point(64, 583)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(106, 23)
        Me.ClearButton.TabIndex = 13
        Me.ClearButton.Text = "Clear Display"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'KeyboardGroupBox
        '
        Me.KeyboardGroupBox.Controls.Add(Me.Button1)
        Me.KeyboardGroupBox.Controls.Add(Me.HandleKeyboardCheckBox)
        Me.KeyboardGroupBox.Controls.Add(Me.Button2)
        Me.KeyboardGroupBox.Location = New System.Drawing.Point(3, 278)
        Me.KeyboardGroupBox.Name = "KeyboardGroupBox"
        Me.KeyboardGroupBox.Size = New System.Drawing.Size(167, 143)
        Me.KeyboardGroupBox.TabIndex = 12
        Me.KeyboardGroupBox.TabStop = False
        Me.KeyboardGroupBox.Text = "Keyboard"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 68)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(145, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Install Keyboard Hook"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'HandleKeyboardCheckBox
        '
        Me.HandleKeyboardCheckBox.AutoSize = True
        Me.HandleKeyboardCheckBox.Location = New System.Drawing.Point(15, 32)
        Me.HandleKeyboardCheckBox.Name = "HandleKeyboardCheckBox"
        Me.HandleKeyboardCheckBox.Size = New System.Drawing.Size(108, 17)
        Me.HandleKeyboardCheckBox.TabIndex = 11
        Me.HandleKeyboardCheckBox.Text = "Handle Keyboard"
        Me.HandleKeyboardCheckBox.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(6, 97)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(145, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Uninstall Keyboard Hook"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MouseGroupBox
        '
        Me.MouseGroupBox.Controls.Add(Me.TextBox1)
        Me.MouseGroupBox.Controls.Add(Me.GroupBox1)
        Me.MouseGroupBox.Controls.Add(Me.MouseLocationTextBox)
        Me.MouseGroupBox.Controls.Add(Me.HandleMouseCheckBox)
        Me.MouseGroupBox.Controls.Add(Me.Label1)
        Me.MouseGroupBox.Controls.Add(Me.Button4)
        Me.MouseGroupBox.Controls.Add(Me.Button3)
        Me.MouseGroupBox.Location = New System.Drawing.Point(3, 12)
        Me.MouseGroupBox.Name = "MouseGroupBox"
        Me.MouseGroupBox.Size = New System.Drawing.Size(167, 244)
        Me.MouseGroupBox.TabIndex = 9
        Me.MouseGroupBox.TabStop = False
        Me.MouseGroupBox.Text = "Mouse"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ClickCheckBox)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 171)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(155, 63)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Synthesize Mouse Click"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "My Handle is:"
        '
        'ClickCheckBox
        '
        Me.ClickCheckBox.AutoSize = True
        Me.ClickCheckBox.Location = New System.Drawing.Point(6, 19)
        Me.ClickCheckBox.Name = "ClickCheckBox"
        Me.ClickCheckBox.Size = New System.Drawing.Size(146, 17)
        Me.ClickCheckBox.TabIndex = 15
        Me.ClickCheckBox.Text = "Press Shift+C to click me."
        Me.ClickCheckBox.UseVisualStyleBackColor = True
        '
        'MouseLocationTextBox
        '
        Me.MouseLocationTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.MouseLocationTextBox.Location = New System.Drawing.Point(58, 24)
        Me.MouseLocationTextBox.Name = "MouseLocationTextBox"
        Me.MouseLocationTextBox.ReadOnly = True
        Me.MouseLocationTextBox.Size = New System.Drawing.Size(96, 20)
        Me.MouseLocationTextBox.TabIndex = 1
        '
        'HandleMouseCheckBox
        '
        Me.HandleMouseCheckBox.AutoSize = True
        Me.HandleMouseCheckBox.Location = New System.Drawing.Point(14, 59)
        Me.HandleMouseCheckBox.Name = "HandleMouseCheckBox"
        Me.HandleMouseCheckBox.Size = New System.Drawing.Size(95, 17)
        Me.HandleMouseCheckBox.TabIndex = 10
        Me.HandleMouseCheckBox.Text = "Handle Mouse"
        Me.HandleMouseCheckBox.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Locatint:"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(9, 126)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(145, 23)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Uninstall Mouse Hook"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(9, 97)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(145, 23)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Install Mouse Hook"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'KeyboardHook1
        '
        '
        'MouseHook1
        '
        '
        'ClipboardHook1
        '
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 618)
        Me.Controls.Add(Me.SplitContainer1)
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.Clipboard_GroupBox.ResumeLayout(False)
        Me.KeyboardGroupBox.ResumeLayout(False)
        Me.KeyboardGroupBox.PerformLayout()
        Me.MouseGroupBox.ResumeLayout(False)
        Me.MouseGroupBox.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents DisplayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KeyboardGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents HandleKeyboardCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents MouseGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents MouseLocationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HandleMouseCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents ClickCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Clipboard_GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents KeyboardHook1 As WindowsHookLib.KeyboardHook
    Friend WithEvents MouseHook1 As WindowsHookLib.MouseHook
    Friend WithEvents ClipboardHook1 As WindowsHookLib.ClipboardHook
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
