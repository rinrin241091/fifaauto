Public Class Form1
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        While Not BackgroundWorker1.CancellationPending

            If GetColor.GETCOLOR(575, 361) = "0x10348F" Then
                AutoIt.AutoItX.ControlClick("FIFA Online4", "", "", "left", 1, 300, 402)
                AutoIt.AutoItX.Sleep(500)
            End If 'Click Manager in Home

            If GetColor.GETCOLOR(1006, 666) = "0xA4EA0D" Then
                'AutoIt.AutoItX.MouseMove(1006, 666)
                'AutoIt.AutoItX.MouseClick("left",)
            End If 'Click Manager in Manager Menu

            If GetColor.GETCOLOR(981, 482) = "0x446C1E" Then
                AutoIt.AutoItX.MouseMove(1068, 718)
                AutoIt.AutoItX.MouseClick("left",)
                AutoIt.AutoItX.Sleep(500)
            End If 'Click Manager in Manager Menu2

            'If GetColor.GETCOLOR(308, 725) = "0xA4EA0D" Then
            'Else
            '    AutoIt.AutoItX.ControlSend("FIFA Online4", "", "", "s")
            '    AutoIt.AutoItX.Sleep(500)
            'End If 'Skip Replay

            'If GetColor.GETCOLOR(294, 650) = "0x151532" Then
            '    AutoIt.AutoItX.ControlSend("FIFA Online4", "", "", "{SPACE}")
            '    AutoIt.AutoItX.Sleep(500)
            'End If 'Spacebar END

            If GetColor.GETCOLOR(1066, 718) = "0xA3E90C" Then
                AutoIt.AutoItX.MouseMove(1066, 718)
                AutoIt.AutoItX.MouseClick("left",)
                AutoIt.AutoItX.Sleep(500)
            End If 'manager rank , level up , etc

            If GetColor.GETCOLOR(1075, 719) = "0xA3E90C" Then
                AutoIt.AutoItX.MouseMove(1075, 719)
                AutoIt.AutoItX.MouseClick("left",)
                AutoIt.AutoItX.Sleep(500)
            End If 'END
        End While
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            BackgroundWorker1.RunWorkerAsync()
        Catch ex As Exception

        End Try
        Button1.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BackgroundWorker1.CancelAsync()
        Button2.Enabled = False
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("1280x720 (16:9)")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Application.Restart()
        Application.Exit()
    End Sub
End Class
