Imports WindowsHookLib
Imports System.Reflection
Imports System.IO
<Assembly: CLSCompliant(False)> 
Public Class Form1

    'Intptr list object for alowed handles
    Dim mList As New List(Of IntPtr)

#Region " Methods "

    Private Sub CleareDisplay()
        Me.DisplayTextBox.Clear()
        'Print WindowsHooksLib information
        Dim nameAssmb As AssemblyTitleAttribute = Attribute.GetCustomAttribute(MouseHook.AssemblyInfo, GetType(AssemblyTitleAttribute))
        Me.DisplayTextBox.AppendText("Assembly Name: " & nameAssmb.Title)
        Me.DisplayTextBox.AppendText(System.Environment.NewLine)
        Dim compAssmb As AssemblyCompanyAttribute = Attribute.GetCustomAttribute(MouseHook.AssemblyInfo, GetType(AssemblyCompanyAttribute))
        Me.DisplayTextBox.AppendText("Company Name: " & compAssmb.Company)
        Me.DisplayTextBox.AppendText(System.Environment.NewLine)
        Dim versAssmb As AssemblyVersionAttribute = Attribute.GetCustomAttribute(MouseHook.AssemblyInfo, GetType(AssemblyVersionAttribute))
        Me.DisplayTextBox.AppendText("Assembly Version: " & MouseHook.AssemblyInfo.GetName.Version.ToString)
        Me.DisplayTextBox.AppendText(System.Environment.NewLine)
        Dim fileVersAssmb As AssemblyFileVersionAttribute = Attribute.GetCustomAttribute(MouseHook.AssemblyInfo, GetType(AssemblyFileVersionAttribute))
        Me.DisplayTextBox.AppendText("Assembly File Version: " & fileVersAssmb.Version)
        Me.DisplayTextBox.AppendText(System.Environment.NewLine)
        Me.DisplayTextBox.AppendText(System.Environment.NewLine)

    End Sub

#End Region

    '**************** Low Level Keyboard Hook ****************

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            'Install the keyboard hook
            Me.KeyboardHook1.InstallHook()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            'Remove the mouse hook
            Me.KeyboardHook1.RemoveHook()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub KeyboardHook1_KeyDown(ByVal sender As Object, ByVal e As WindowsHookLib.KeyboardEventArgs) Handles KeyboardHook1.KeyDown
        'Set the key down Handled property
        e.Handled = Me.HandleKeyboardCheckBox.Checked
        'Print the key down data
        Select Case (e.KeyCode.ToString)
            Case "NumPad1"
                Me.DisplayTextBox.AppendText("1")
            Case "NumPad2"
                Me.DisplayTextBox.AppendText("2")
            Case "NumPad3"
                Me.DisplayTextBox.AppendText("3")
            Case "NumPad4"
                Me.DisplayTextBox.AppendText("4")
            Case "NumPad5"
                Me.DisplayTextBox.AppendText("5")
            Case "NumPad6"
                Me.DisplayTextBox.AppendText("6")
            Case "NumPad7"
                Me.DisplayTextBox.AppendText("7")
            Case "NumPad8"
                Me.DisplayTextBox.AppendText("8")
            Case "NumPad9"
                Me.DisplayTextBox.AppendText("9")
            Case "NumPad0"
                Me.DisplayTextBox.AppendText("0")
            Case Else
                Me.DisplayTextBox.AppendText(e.KeyCode.ToString)
        End Select
        If e.KeyCode = Keys.Enter Then
            Me.DisplayTextBox.AppendText(vbCrLf)
        End If
        

    End Sub



    Private Sub KeyboardHook1_StateChanged(ByVal sender As Object, ByVal e As WindowsHookLib.StateChangedEventArgs) Handles KeyboardHook1.StateChanged
        'Print the keyboard hook state in the KeyboardGroupBox name 
        Me.KeyboardGroupBox.Text = "Keyboard Hook " & e.State.ToString & "!"
        If e.State = HookState.Uninstalled Then
            'Clear the Handle Keyboard checkbox
            Me.HandleKeyboardCheckBox.Checked = False
        End If
    End Sub

    '*******************************************************
    '*********** End Low Level Keyboard Hook ***************
    '*******************************************************


    '**************** Low Level Mouse Hook *****************

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            'Install the mouse hook
            Me.MouseHook1.InstallHook()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            'Remove the mouse hook
            Me.MouseHook1.RemoveHook()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub MouseHook1_MouseDown(ByVal sender As Object, ByVal e As WindowsHookLib.MouseEventArgs) Handles MouseHook1.MouseDown

        'Set the mouse down Handled property
        e.Handled = Me.HandleMouseCheckBox.Checked And Not Me.mList.Contains(CType(sender, IntPtr))
        'Print the mouse down data
        Me.DisplayTextBox.AppendText(System.Environment.NewLine)
        Me.DisplayTextBox.AppendText("===================== MouseDown")
        Me.DisplayTextBox.AppendText(System.Environment.NewLine)
        Me.DisplayTextBox.AppendText("Handled: " & e.Handled)
        Me.DisplayTextBox.AppendText(System.Environment.NewLine)
        Me.DisplayTextBox.AppendText("Button: " & e.Button.ToString)
        Me.DisplayTextBox.AppendText(System.Environment.NewLine)
        Me.DisplayTextBox.AppendText("Clicks: " & e.Clicks)
        Me.DisplayTextBox.AppendText(System.Environment.NewLine)
        Me.DisplayTextBox.AppendText("Delta: " & e.Delta)
        Me.DisplayTextBox.AppendText(System.Environment.NewLine)
        Me.DisplayTextBox.AppendText("Location: " & e.Location.ToString)
        Me.DisplayTextBox.AppendText(System.Environment.NewLine)
        Me.DisplayTextBox.AppendText("Control Handle: " & sender.ToString)
        Me.DisplayTextBox.AppendText(System.Environment.NewLine)
        Me.DisplayTextBox.AppendText("===================== End MouseDown")

    End Sub

    Private Sub MouseHook1_MouseUp(ByVal sender As Object, ByVal e As WindowsHookLib.MouseEventArgs) Handles MouseHook1.MouseUp

        'Set the mouse up Handled property
        e.Handled = Me.HandleMouseCheckBox.Checked And Not Me.mList.Contains(CType(sender, IntPtr))
        'Print the mouse up data
        Me.DisplayTextBox.AppendText(System.Environment.NewLine)
        Me.DisplayTextBox.AppendText("===================== MouseUp")
        Me.DisplayTextBox.AppendText(System.Environment.NewLine)
        Me.DisplayTextBox.AppendText("Handled: " & e.Handled)
        Me.DisplayTextBox.AppendText(System.Environment.NewLine)
        Me.DisplayTextBox.AppendText("Button: " & e.Button.ToString)
        Me.DisplayTextBox.AppendText(System.Environment.NewLine)
        Me.DisplayTextBox.AppendText("Clicks: " & e.Clicks)
        Me.DisplayTextBox.AppendText(System.Environment.NewLine)
        Me.DisplayTextBox.AppendText("Delta: " & e.Delta)
        Me.DisplayTextBox.AppendText(System.Environment.NewLine)
        Me.DisplayTextBox.AppendText("Location: " & e.Location.ToString)
        Me.DisplayTextBox.AppendText(System.Environment.NewLine)
        Me.DisplayTextBox.AppendText("Control Handle: " & sender.ToString)
        Me.DisplayTextBox.AppendText(System.Environment.NewLine)
        Me.DisplayTextBox.AppendText("===================== End MouseUp")

    End Sub

    Private Sub MouseHook1_MouseClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MouseHook1.MouseClick

        'Print the mouse click data
        Me.DisplayTextBox.AppendText(System.Environment.NewLine)
        Me.DisplayTextBox.AppendText("===================== MouseClick")
        Me.DisplayTextBox.AppendText(System.Environment.NewLine)
        Me.DisplayTextBox.AppendText("Button: " & e.Button.ToString)
        Me.DisplayTextBox.AppendText(System.Environment.NewLine)
        Me.DisplayTextBox.AppendText("Clicks: " & e.Clicks)
        Me.DisplayTextBox.AppendText(System.Environment.NewLine)
        Me.DisplayTextBox.AppendText("Delta: " & e.Delta)
        Me.DisplayTextBox.AppendText(System.Environment.NewLine)
        Me.DisplayTextBox.AppendText("Location: " & e.Location.ToString)
        Me.DisplayTextBox.AppendText(System.Environment.NewLine)
        Me.DisplayTextBox.AppendText("Control Handle: " & sender.ToString)
        Me.DisplayTextBox.AppendText(System.Environment.NewLine)
        Me.DisplayTextBox.AppendText("===================== End MouseClick")

    End Sub

    Private Sub MouseHook1_MouseDoubleClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MouseHook1.MouseDoubleClick

        'Print the mouse double click data
        Me.DisplayTextBox.AppendText(System.Environment.NewLine)
        Me.DisplayTextBox.AppendText("===================== MouseDoubleClick")
        Me.DisplayTextBox.AppendText(System.Environment.NewLine)
        Me.DisplayTextBox.AppendText("Button: " & e.Button.ToString)
        Me.DisplayTextBox.AppendText(System.Environment.NewLine)
        Me.DisplayTextBox.AppendText("Clicks: " & e.Clicks)
        Me.DisplayTextBox.AppendText(System.Environment.NewLine)
        Me.DisplayTextBox.AppendText("Delta: " & e.Delta)
        Me.DisplayTextBox.AppendText(System.Environment.NewLine)
        Me.DisplayTextBox.AppendText("Location: " & e.Location.ToString)
        Me.DisplayTextBox.AppendText(System.Environment.NewLine)
        Me.DisplayTextBox.AppendText("Control Handle: " & sender.ToString)
        Me.DisplayTextBox.AppendText(System.Environment.NewLine)
        Me.DisplayTextBox.AppendText("===================== End MouseDoubleClick")

    End Sub

    Private Sub MouseHook1_MouseWheel(ByVal sender As Object, ByVal e As WindowsHookLib.MouseEventArgs) Handles MouseHook1.MouseWheel

        'Set the mouse wheel Handled property
        e.Handled = Me.HandleMouseCheckBox.Checked
        'Print the mouse wheel data
        Me.DisplayTextBox.AppendText(System.Environment.NewLine)
        Me.DisplayTextBox.AppendText("===================== MouseWheel")
        Me.DisplayTextBox.AppendText(System.Environment.NewLine)
        Me.DisplayTextBox.AppendText("Handled: " & e.Handled)
        Me.DisplayTextBox.AppendText(System.Environment.NewLine)
        Me.DisplayTextBox.AppendText("Button: " & e.Button.ToString)
        Me.DisplayTextBox.AppendText(System.Environment.NewLine)
        Me.DisplayTextBox.AppendText("Clicks: " & e.Clicks)
        Me.DisplayTextBox.AppendText(System.Environment.NewLine)
        Me.DisplayTextBox.AppendText("Delta: " & e.Delta)
        Me.DisplayTextBox.AppendText(System.Environment.NewLine)
        Me.DisplayTextBox.AppendText("Location: " & e.Location.ToString)
        Me.DisplayTextBox.AppendText(System.Environment.NewLine)
        Me.DisplayTextBox.AppendText("===================== End MouseWheel")

    End Sub

    Private Sub MouseHook1_MouseMove(ByVal sender As Object, ByVal e As WindowsHookLib.MouseEventArgs) Handles MouseHook1.MouseMove

        'Print the mouse location in the MouseLocationTextBox
        Me.MouseLocationTextBox.Text = e.Location.ToString
        ''Print the mouse move data
        'Me.DisplayTextBox.AppendText(Environment.NewLine)
        'Me.DisplayTextBox.AppendText("===================== MouseMove")
        'Me.DisplayTextBox.AppendText(Environment.NewLine)
        'Me.DisplayTextBox.AppendText("Button: " & e.Button.ToString)
        'Me.DisplayTextBox.AppendText(Environment.NewLine)
        'Me.DisplayTextBox.AppendText("Clicks: " & e.Clicks)
        'Me.DisplayTextBox.AppendText(Environment.NewLine)
        'Me.DisplayTextBox.AppendText("Delta: " & e.Delta)
        'Me.DisplayTextBox.AppendText(Environment.NewLine)
        'Me.DisplayTextBox.AppendText("Location: " & e.Location.ToString)
        'Me.DisplayTextBox.AppendText(Environment.NewLine)
        'Me.DisplayTextBox.AppendText("Control Handle: " & sender.ToString)
        'Me.DisplayTextBox.AppendText(Environment.NewLine)
        'Me.DisplayTextBox.AppendText("===================== End MouseMove")

    End Sub

    Private Sub MouseHook1_StateChanged(ByVal sender As Object, ByVal e As WindowsHookLib.StateChangedEventArgs) Handles MouseHook1.StateChanged
        'Print the mouse hook state in the MouseGroupBox name 
        Me.MouseGroupBox.Text = "Mouse Hook " & e.State.ToString & "!"
        If e.State = HookState.Uninstalled Then
            'Clear the mouse location and the Handle Mouse checkbox
            Me.MouseLocationTextBox.Text = String.Empty
            Me.HandleMouseCheckBox.Checked = False
        End If
    End Sub

    '*******************************************************
    '*************** End Low Level Mouse Hook **************
    '*******************************************************


    '**************** Synthesize Mouse Event *****************

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If (e.Modifiers And Keys.Shift) = Keys.Shift And e.KeyCode = Keys.C Then
            Dim p As Point = Me.GroupBox1.PointToScreen(Me.ClickCheckBox.Location)
            p.X += 6
            p.Y += 10
            MouseHook.SynthesizeMouseMove(p, MapOn.PrimaryMonitor, IntPtr.Zero)
            Me.ClickCheckBox.Focus()
            MouseHook.SynthesizeMouseDown(Windows.Forms.MouseButtons.Left, IntPtr.Zero)
            MouseHook.SynthesizeMouseUp(Windows.Forms.MouseButtons.Left, IntPtr.Zero)
        End If
    End Sub

    '*******************************************************
    '************** End Synthesize Mouse Event *************
    '*******************************************************


    '**************** Window Clipboard Hook ****************

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            'Install the clipboard hook
            Me.ClipboardHook1.InstallHook(Me)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Try
            'Remove the clipboard hook
            Me.ClipboardHook1.RemoveHook()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ClipboardHook1_ClipboardChanged(ByVal sender As Object, ByVal e As WindowsHookLib.ClipboardEventArgs) Handles ClipboardHook1.ClipboardChanged
        'Print the mouse wheel data
        Me.DisplayTextBox.AppendText(System.Environment.NewLine)
        Me.DisplayTextBox.AppendText("===================== ClipboardChanged")
        Me.DisplayTextBox.AppendText(System.Environment.NewLine)
        Me.DisplayTextBox.AppendText("Hooked Window: " & Me.ClipboardHook1.HookedWindow.ToString)
        Me.DisplayTextBox.AppendText(System.Environment.NewLine)
        Me.DisplayTextBox.AppendText("Source Window : " & e.SourceWindow.ToString)
        Me.DisplayTextBox.AppendText(System.Environment.NewLine)
        Me.DisplayTextBox.AppendText("Contains Audio: " & My.Computer.Clipboard.ContainsAudio)
        Me.DisplayTextBox.AppendText(System.Environment.NewLine)
        Me.DisplayTextBox.AppendText("Contains Image: " & My.Computer.Clipboard.ContainsImage)
        Me.DisplayTextBox.AppendText(System.Environment.NewLine)
        Me.DisplayTextBox.AppendText("Contains Text: " & My.Computer.Clipboard.ContainsText)
        Me.DisplayTextBox.AppendText(System.Environment.NewLine)
        Me.DisplayTextBox.AppendText("Contains FileDropList: " & My.Computer.Clipboard.ContainsFileDropList)
        Me.DisplayTextBox.AppendText(System.Environment.NewLine)
        Me.DisplayTextBox.AppendText("===================== End ClipboardChanged")
    End Sub


    Private Sub ClipboardHook1_StateChanged(ByVal sender As Object, ByVal e As WindowsHookLib.StateChangedEventArgs) Handles ClipboardHook1.StateChanged
        'Print the mouse hook state in the MouseGroupBox name 
        Me.Clipboard_GroupBox.Text = "Clipboard Hook " & e.State.ToString & "!"
    End Sub

    '*******************************************************
    '************** End Window Clipboard Hook *************
    '*******************************************************


    '******************* Form's Events *********************

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
      
        For Each ctr As Control In Me.MouseGroupBox.Controls
            Me.mList.Add(ctr.Handle)
        Next
        Button1.PerformClick()
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.KeyboardHook1.Dispose()
        Me.MouseHook1.Dispose()
        Me.ClipboardHook1.Dispose()
        e.Cancel = True
        Me.Hide()
    End Sub

    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        Me.CleareDisplay()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Try

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        File.WriteAllText(TextBox1.Text, DisplayTextBox.Text)
    End Sub
End Class