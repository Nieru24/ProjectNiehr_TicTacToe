Public Class Form1


    Dim x_o As Boolean = True
    Dim flag As Integer = 0
    Dim array(2, 2) As String
    Dim Xscore As Integer = 0
    Dim Oscore As Integer = 0

    Sub UpdateButton(ByVal btn As Button)
        If btn.Text = "" And x_o Then
            btn.Text = "X"
            x_o = False
            flag = flag + 1
        ElseIf btn.Text = "" And Not x_o Then
            btn.Text = "O"
            x_o = True
            flag = flag + 1
        Else
            MessageBox.Show("Player has already entered!", "Tic Tac toe")
        End If
    End Sub

    Sub WinCheck()
        For i As Integer = 0 To 2
            If array(i, 0) <> "" And array(i, 0) = array(i, 1) And array(i, 1) = array(i, 2) Then
                If array(i, 0) = "X" Then
                    Xscore += 1
                Else
                    Oscore += 1
                End If
                MessageBox.Show(array(i, 0) & " has won!")
                GameReset()
                Exit Sub
            End If
        Next

        For i As Integer = 0 To 2
            If array(0, i) <> "" And array(0, i) = array(1, i) And array(1, i) = array(2, i) Then
                If array(i, 0) = "X" Then
                    Xscore += 1
                Else
                    Oscore += 1
                End If
                MessageBox.Show(array(0, i) & " has won!")
                GameReset()
                Exit Sub
            End If
        Next

        If array(0, 0) <> "" And array(0, 0) = array(1, 1) And array(1, 1) = array(2, 2) Then
            If array(0, 0) = "X" Then
                Xscore += 1
            Else
                Oscore += 1
            End If
            MessageBox.Show(array(0, 0) & " has won!")
            GameReset()
        ElseIf array(0, 2) <> "" And array(0, 2) = array(1, 1) And array(1, 1) = array(2, 0) Then
            If array(0, 2) = "X" Then
                Xscore += 1
            Else
                Oscore += 1
            End If
            MessageBox.Show(array(0, 2) & " has won!")
            GameReset()
        End If

        If flag = 9 Then
            MessageBox.Show("Game is Tied!")
            GameReset()
        End If
    End Sub

    Sub GameReset()
        x_o = True
        flag = 0
        array = New String(2, 2) {}

        btn_1.Text = ""
        btn_2.Text = ""
        btn_3.Text = ""
        btn_4.Text = ""
        btn_5.Text = ""
        btn_6.Text = ""
        btn_7.Text = ""
        btn_8.Text = ""
        btn_9.Text = ""
        lbl_score.Text = Xscore & ": X    O :" & Oscore
    End Sub


    Private Sub btn_1_Click(sender As Object, e As EventArgs) Handles btn_1.Click
        UpdateButton(btn_1)
        array(0, 0) = btn_1.Text
        WinCheck()
    End Sub

    Private Sub btn_2_Click(sender As Object, e As EventArgs) Handles btn_2.Click
        UpdateButton(btn_2)
        array(0, 1) = btn_2.Text
        WinCheck()
    End Sub

    Private Sub btn_3_Click(sender As Object, e As EventArgs) Handles btn_3.Click
        UpdateButton(btn_3)
        array(0, 2) = btn_3.Text
        WinCheck()
    End Sub

    Private Sub btn_4_Click(sender As Object, e As EventArgs) Handles btn_4.Click
        UpdateButton(btn_4)
        array(1, 0) = btn_4.Text
        WinCheck()
    End Sub

    Private Sub btn_5_Click(sender As Object, e As EventArgs) Handles btn_5.Click
        UpdateButton(btn_5)
        array(1, 1) = btn_5.Text
        WinCheck()
    End Sub

    Private Sub btn_6_Click(sender As Object, e As EventArgs) Handles btn_6.Click
        UpdateButton(btn_6)
        array(1, 2) = btn_6.Text
        WinCheck()
    End Sub

    Private Sub btn_7_Click(sender As Object, e As EventArgs) Handles btn_7.Click
        UpdateButton(btn_7)
        array(2, 0) = btn_7.Text
        WinCheck()
    End Sub

    Private Sub btn_8_Click(sender As Object, e As EventArgs) Handles btn_8.Click
        UpdateButton(btn_8)
        array(2, 1) = btn_8.Text
        WinCheck()
    End Sub

    Private Sub btn_9_Click(sender As Object, e As EventArgs) Handles btn_9.Click
        UpdateButton(btn_9)
        array(2, 2) = btn_9.Text
        WinCheck()
    End Sub

    Private Sub test_Click(sender As Object, e As EventArgs)
        MessageBox.Show(array(0, 0))
    End Sub

End Class
