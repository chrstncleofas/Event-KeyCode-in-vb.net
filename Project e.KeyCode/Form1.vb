Public Class Form1

    Private Sub txtNum2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNum2.KeyDown
        If e.KeyCode = Keys.F1 Then
            lblAnswer.Text = Val(txtNum1.Text) + Val(txtNum2.Text)
        ElseIf e.KeyCode = Keys.F12 Then
            lblAnswer.Text = Val(txtNum1.Text) - Val(txtNum2.Text)
        ElseIf e.KeyCode = Keys.Enter Then
            lblAnswer.Text = Val(txtNum1.Text) * Val(txtNum2.Text)
        ElseIf e.KeyCode = Keys.Escape Then
            lblAnswer.Text = Val(txtNum1.Text) / Val(txtNum2.Text)
            If txtNum2.Text = 0 Then
                MsgBox("Cannot divide by Zero", vbCritical, "Error")
                txtNum1.Clear()
                txtNum1.Focus()
                txtNum2.Clear()
                lblAnswer.Text = ""
                lblAve.Text = ""
            End If
        ElseIf e.KeyCode = Keys.Delete Then
            lblAve.Text = Val(lblAnswer.Text) / 2
        ElseIf e.KeyCode = Keys.Back Then
            txtNum1.Clear()
            txtNum1.Focus()
            txtNum2.Clear()
            lblAnswer.Text = ""
            lblAve.Text = ""
        ElseIf e.KeyCode = Keys.F2 Then
            If MsgBox("Do you want to close this window?", vbQuestion + vbYesNo, "E.KeyCode") = vbYes Then
                Me.Close()
            Else
                Me.Focus()
            End If
        End If
    End Sub

End Class

