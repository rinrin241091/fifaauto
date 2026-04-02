Imports System.IO

Public Class Form1
    <Runtime.InteropServices.StructLayout(Runtime.InteropServices.LayoutKind.Sequential)>
    Private Structure WinPoint
        Public X As Integer
        Public Y As Integer
    End Structure

    <Runtime.InteropServices.DllImport("user32.dll")>
    Private Shared Function ClientToScreen(hWnd As IntPtr, ByRef lpPoint As WinPoint) As Boolean
    End Function

    <Runtime.InteropServices.DllImport("user32.dll")>
    Private Shared Function ScreenToClient(hWnd As IntPtr, ByRef lpPoint As WinPoint) As Boolean
    End Function

    <Runtime.InteropServices.DllImport("user32.dll")>
    Private Shared Function PostMessage(hWnd As IntPtr, msg As UInteger, wParam As IntPtr, lParam As IntPtr) As Boolean
    End Function

    Private Const WM_LBUTTONDOWN As UInteger = &H201UI
    Private Const WM_LBUTTONUP As UInteger = &H202UI
    Private Const WM_KEYDOWN As UInteger = &H100UI
    Private Const WM_KEYUP As UInteger = &H101UI
    Private Const MK_LBUTTON As Integer = &H1

    Private loopDelayMs As Integer = 300
    Private clickDelayMs As Integer = 500
    Private sKeyIntervalMs As Integer = 1500
    Private targetMatchCount As Integer = 0
    Private completedMatchCount As Integer = 0
    Private isMatchInProgress As Boolean = False
    Private lastSKeyPressUtc As DateTime = DateTime.MinValue
    Private lastSpaceKeyPressUtc As DateTime = DateTime.MinValue
    Private lastSimModeClickUtc As DateTime = DateTime.MinValue
    Private lastGreenActionClickUtc As DateTime = DateTime.MinValue

    Private coordsFilePath As String = Path.Combine(Application.StartupPath, "fo4_coords.ini")
    Private homeButtonX As Integer = 300
    Private homeButtonY As Integer = 402
    Private endMatchSpaceIntervalMs As Integer = 1200
    Private simModeClickIntervalMs As Integer = 3500
    Private greenActionClickIntervalMs As Integer = 1200
    Private simModeX As Integer = 330
    Private simModeY As Integer = 294
    Private greenButtonX As Integer = 1145
    Private greenButtonY As Integer = 694
    Private confirmPrimaryX As Integer = 1066
    Private confirmPrimaryY As Integer = 718
    Private confirmSecondaryX As Integer = 1075
    Private confirmSecondaryY As Integer = 719
    Private endMatchColorX As Integer = 638
    Private endMatchColorY As Integer = 175
    Private debugRealtimeEnabled As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ClientSize = New Size(460, 560)
        Me.MinimumSize = New Size(460, 560)
        InitializeCoordinateTargets()
        LoadCoordinateProfile()
        ApplyCompactLayout()
        ApplyWindowSettings()
        chkHomeManager.Checked = True
        chkManagerMenu2.Checked = True
        chkConfirmPrimary.Checked = True
        chkConfirmSecondary.Checked = True
        chkEndMatchSpace.Checked = True
        chkHomeManager.Enabled = False
        chkManagerMenu2.Enabled = False
        chkConfirmPrimary.Enabled = False
        chkConfirmSecondary.Enabled = False
        chkEndMatchSpace.Enabled = False
        targetMatchCount = CInt(numTargetMatchCount.Value)
        debugRealtimeEnabled = chkDebugRealtime.Checked
        TimerDebug.Enabled = debugRealtimeEnabled
        UpdateUiState(False)
        UpdateStatus("Đang dừng", "Sẵn sàng để chạy", "Chưa đọc màu")
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If Not IsHandleCreated OrElse WindowState = FormWindowState.Minimized Then
            Return
        End If

        ApplyCompactLayout()
    End Sub

    Private Sub ApplyCompactLayout()
        GroupBoxAutomation.Visible = False

        If TabControlMain.TabPages.Contains(TabPageSettings) Then
            TabControlMain.TabPages.Remove(TabPageSettings)
        End If

        If TabControlMain.TabPages.Contains(TabPageAbout) Then
            TabControlMain.TabPages.Remove(TabPageAbout)
        End If

        TabControlMain.Location = New Point(10, 96)
        TabControlMain.Size = New Size(Me.ClientSize.Width - 20, Me.ClientSize.Height - 106)

        lblSubtitle.AutoSize = False
        lblSubtitle.Width = Me.ClientSize.Width - 48

        Dim contentWidth As Integer = Math.Max(300, TabPageDashboard.ClientSize.Width - 24)
        GroupBoxSession.Location = New Point(12, 12)
        GroupBoxSession.Size = New Size(contentWidth, 252)

        Dim buttonWidth As Integer = btnStart.Width
        Dim buttonGap As Integer = 14
        Dim leftButtonX As Integer = (GroupBoxSession.ClientSize.Width - ((buttonWidth * 2) + buttonGap)) \ 2
        Dim rightButtonX As Integer = leftButtonX + buttonWidth + buttonGap
        btnStart.Left = leftButtonX
        btnStop.Left = rightButtonX
        btnRestart.Left = leftButtonX
        btnCheckWindow.Left = rightButtonX

        GroupBoxStatus.Location = New Point(12, GroupBoxSession.Bottom + 10)
        Dim statusHeight As Integer = Math.Max(240, TabPageDashboard.ClientSize.Height - GroupBoxSession.Bottom - 22)
        GroupBoxStatus.Size = New Size(contentWidth, statusHeight)

        Dim valueWidth As Integer = Math.Max(140, GroupBoxStatus.ClientSize.Width - lblRunStateValue.Left - 18)
        lblRunStateValue.Width = valueWidth
        lblLastActionValue.Width = valueWidth
        lblDetectedColorValue.Width = valueWidth
        lblDebugPointValue.Width = valueWidth
        lblDebugColorValue.Width = valueWidth
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        While Not BackgroundWorker1.CancellationPending
            If targetMatchCount > 0 AndAlso completedMatchCount >= targetMatchCount Then
                UpdateStatus("Hoàn thành", String.Format("Đã đủ {0}/{1} trận theo yêu cầu", completedMatchCount, targetMatchCount), lblDetectedColorValue.Text)
                Exit While
            End If

            If AutoIt.AutoItX.WinExists("FC ONLINE", "") = 0 Then
                UpdateStatus("Đang chờ game", "Không tìm thấy cửa sổ FC ONLINE", "N/A")
                System.Threading.Thread.Sleep(loopDelayMs)
                Continue While
            End If

            Dim homeColor As String = ReadColorAt("Mau nut Home HLV", 575, 361)
            UpdateDetectedColor(homeColor)
            If String.Equals(homeColor, "0x10348F", StringComparison.OrdinalIgnoreCase) Then
                ClickGameClient(homeButtonX, homeButtonY)
                UpdateStatus("Đang chạy", "Đã mở khu vực HLV từ màn hình chính", homeColor)
                System.Threading.Thread.Sleep(clickDelayMs)
                Continue While
            End If

            If Not isMatchInProgress AndAlso DateTime.UtcNow.Subtract(lastSimModeClickUtc).TotalMilliseconds >= simModeClickIntervalMs Then
                ClickGameClient(simModeX, simModeY)
                System.Threading.Thread.Sleep(70)
                ClickGameClient(simModeX, simModeY)
                lastSimModeClickUtc = DateTime.UtcNow
                UpdateStatus("Đang chạy", String.Format("Đã chọn chế độ Giả lập XH ({0}/{1})", completedMatchCount, FormatTargetMatchCount()), lblDetectedColorValue.Text)
                System.Threading.Thread.Sleep(160)
            End If

            Dim managerMenuColor As String = ReadColorAt("Mau nut xanh", greenButtonX, greenButtonY)
            UpdateDetectedColor(managerMenuColor)
            If IsLikelyGreenActionButton(managerMenuColor) AndAlso DateTime.UtcNow.Subtract(lastGreenActionClickUtc).TotalMilliseconds >= greenActionClickIntervalMs Then
                ClickGameClient(greenButtonX, greenButtonY)
                lastGreenActionClickUtc = DateTime.UtcNow
                If Not isMatchInProgress Then
                    isMatchInProgress = True
                    lastSKeyPressUtc = DateTime.MinValue
                    lastSpaceKeyPressUtc = DateTime.MinValue
                End If

                UpdateStatus("Đang chạy", String.Format("Đã bấm nút xanh (Xếp hạng/Tiếp tục) ({0}/{1})", completedMatchCount, FormatTargetMatchCount()), managerMenuColor)
                System.Threading.Thread.Sleep(clickDelayMs)
                Continue While
            End If

            If isMatchInProgress AndAlso DateTime.UtcNow.Subtract(lastSKeyPressUtc).TotalMilliseconds >= sKeyIntervalMs Then
                SendGameKey("s")
                lastSKeyPressUtc = DateTime.UtcNow
                UpdateStatus("Đang chạy", String.Format("Đang trong trận, gửi phím S ({0}/{1})", completedMatchCount, FormatTargetMatchCount()), lblDetectedColorValue.Text)
                System.Threading.Thread.Sleep(150)
            End If

            If isMatchInProgress AndAlso DateTime.UtcNow.Subtract(lastSpaceKeyPressUtc).TotalMilliseconds >= endMatchSpaceIntervalMs Then
                Dim endMatchColor As String = ReadColorAt("Mau cuoi tran", endMatchColorX, endMatchColorY)
                UpdateDetectedColor(endMatchColor)
                If IsNearWhiteHex(endMatchColor) Then
                    SendGameKey("{SPACE}")
                    lastSpaceKeyPressUtc = DateTime.UtcNow
                    UpdateStatus("Đang chạy", String.Format("Phát hiện màn hình cuối trận, đã bấm Space ({0}/{1})", completedMatchCount, FormatTargetMatchCount()), endMatchColor)
                    System.Threading.Thread.Sleep(150)
                    Continue While
                End If
            End If

            Dim confirmPrimaryColor As String = ReadColorAt("Mau xac nhan chinh", confirmPrimaryX, confirmPrimaryY)
            UpdateDetectedColor(confirmPrimaryColor)
            If String.Equals(confirmPrimaryColor, "0xA3E90C", StringComparison.OrdinalIgnoreCase) Then
                ClickGameClient(confirmPrimaryX, confirmPrimaryY)
                ProcessPostMatchIfNeeded("Đã bấm nút xác nhận chính", confirmPrimaryColor)
                System.Threading.Thread.Sleep(clickDelayMs)
                Continue While
            End If

            Dim confirmSecondaryColor As String = ReadColorAt("Mau xac nhan phu", confirmSecondaryX, confirmSecondaryY)
            UpdateDetectedColor(confirmSecondaryColor)
            If String.Equals(confirmSecondaryColor, "0xA3E90C", StringComparison.OrdinalIgnoreCase) Then
                ClickGameClient(confirmSecondaryX, confirmSecondaryY)
                ProcessPostMatchIfNeeded("Đã bấm nút xác nhận phụ", confirmSecondaryColor)
                System.Threading.Thread.Sleep(clickDelayMs)
                Continue While
            End If

            UpdateStatus("Đang chạy", String.Format("Chưa phát hiện màu mục tiêu ({0}/{1})", completedMatchCount, FormatTargetMatchCount()), lblDetectedColorValue.Text)
            System.Threading.Thread.Sleep(loopDelayMs)
        End While

        e.Cancel = True
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        UpdateUiState(False)
        If targetMatchCount > 0 AndAlso completedMatchCount >= targetMatchCount Then
            UpdateStatus("Hoàn thành", String.Format("Đã treo xong {0}/{1} trận", completedMatchCount, targetMatchCount), lblDetectedColorValue.Text)
        Else
            UpdateStatus("Đang dừng", String.Format("Đã dừng auto ({0}/{1})", completedMatchCount, FormatTargetMatchCount()), lblDetectedColorValue.Text)
        End If
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If BackgroundWorker1.IsBusy Then
            Return
        End If

        SyncOptionsFromUi()
        completedMatchCount = 0
        isMatchInProgress = False
        lastSKeyPressUtc = DateTime.MinValue
        lastSpaceKeyPressUtc = DateTime.MinValue
        lastSimModeClickUtc = DateTime.MinValue
        lastGreenActionClickUtc = DateTime.MinValue
        UpdateUiState(True)
        UpdateStatus("Đang chạy", String.Format("Bắt đầu treo trận, mục tiêu: {0}", FormatTargetMatchCount()), lblDetectedColorValue.Text)

        Try
            BackgroundWorker1.RunWorkerAsync()
        Catch ex As Exception
            UpdateUiState(False)
            MessageBox.Show("Không thể khởi động auto: " & ex.Message, "FO4 Auto Click Panel", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        If BackgroundWorker1.IsBusy Then
            BackgroundWorker1.CancelAsync()
            UpdateStatus("Đang dừng", String.Format("Đang gửi yêu cầu dừng ({0}/{1})", completedMatchCount, FormatTargetMatchCount()), lblDetectedColorValue.Text)
        End If
    End Sub

    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        Application.Restart()
        Application.Exit()
    End Sub

    Private Sub btnCheckWindow_Click(sender As Object, e As EventArgs) Handles btnCheckWindow.Click
        Dim exists As Boolean = AutoIt.AutoItX.WinExists("FC ONLINE", "") <> 0

        If exists Then
            UpdateStatus("Đang dừng", "Đã tìm thấy cửa sổ FC ONLINE", lblDetectedColorValue.Text)
            MessageBox.Show("Đã tìm thấy cửa sổ FC ONLINE.", "FO4 Auto Click Panel", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            UpdateStatus("Đang dừng", "Chưa tìm thấy cửa sổ FC ONLINE", lblDetectedColorValue.Text)
            MessageBox.Show("Chưa tìm thấy cửa sổ FC ONLINE.", "FO4 Auto Click Panel", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub chkAlwaysOnTop_CheckedChanged(sender As Object, e As EventArgs) Handles chkAlwaysOnTop.CheckedChanged
        ApplyWindowSettings()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If BackgroundWorker1.IsBusy Then
            BackgroundWorker1.CancelAsync()
        End If

        Application.Exit()
    End Sub

    Private Sub SyncOptionsFromUi()
        loopDelayMs = CInt(numLoopDelay.Value)
        clickDelayMs = CInt(numClickDelay.Value)
        targetMatchCount = CInt(numTargetMatchCount.Value)
        ApplyWindowSettings()
    End Sub

    Private Sub ApplyWindowSettings()
        Me.TopMost = chkAlwaysOnTop.Checked
    End Sub

    Private Sub UpdateUiState(isRunning As Boolean)
        If InvokeRequired Then
            Invoke(New Action(Of Boolean)(AddressOf UpdateUiState), isRunning)
            Return
        End If

        btnStart.Enabled = Not isRunning
        btnStop.Enabled = isRunning
        btnCheckWindow.Enabled = Not isRunning
        btnRestart.Enabled = Not isRunning
        chkHomeManager.Enabled = False
        chkManagerMenu2.Enabled = False
        chkConfirmPrimary.Enabled = False
        chkConfirmSecondary.Enabled = False
        chkEndMatchSpace.Enabled = False
        numTargetMatchCount.Enabled = Not isRunning
        cmbCoordinateTarget.Enabled = Not isRunning
        btnSaveCoordinate.Enabled = Not isRunning
        chkDebugRealtime.Enabled = Not isRunning
        numLoopDelay.Enabled = Not isRunning
        numClickDelay.Enabled = Not isRunning
    End Sub

    Private Sub UpdateStatus(runState As String, lastAction As String, detectedColor As String)
        If InvokeRequired Then
            Invoke(New Action(Of String, String, String)(AddressOf UpdateStatus), runState, lastAction, detectedColor)
            Return
        End If

        lblRunStateValue.Text = runState
        lblLastActionValue.Text = lastAction
        lblDetectedColorValue.Text = If(String.IsNullOrWhiteSpace(detectedColor), "N/A", detectedColor)
    End Sub

    Private Sub UpdateDetectedColor(detectedColor As String)
        If InvokeRequired Then
            Invoke(New Action(Of String)(AddressOf UpdateDetectedColor), detectedColor)
            Return
        End If

        lblDetectedColorValue.Text = If(String.IsNullOrWhiteSpace(detectedColor), "N/A", detectedColor)
    End Sub

    Private Sub InitializeCoordinateTargets()
        cmbCoordinateTarget.Items.Clear()
        cmbCoordinateTarget.Items.Add("Click mo khu HLV")
        cmbCoordinateTarget.Items.Add("Click Gia lap XH")
        cmbCoordinateTarget.Items.Add("Click nut xanh Xep hang/Tiep tuc")
        cmbCoordinateTarget.Items.Add("Click xac nhan chinh")
        cmbCoordinateTarget.Items.Add("Click xac nhan phu")
        cmbCoordinateTarget.Items.Add("Diem doc mau cuoi tran")
        cmbCoordinateTarget.SelectedIndex = 1
    End Sub

    Private Sub LoadCoordinateProfile()
        If Not File.Exists(coordsFilePath) Then
            Return
        End If

        Try
            For Each line As String In File.ReadAllLines(coordsFilePath)
                Dim trimmed As String = line.Trim()
                If String.IsNullOrWhiteSpace(trimmed) OrElse Not trimmed.Contains("=") Then
                    Continue For
                End If

                Dim kv As String() = trimmed.Split("="c)
                If kv.Length <> 2 Then
                    Continue For
                End If

                Dim parts As String() = kv(1).Split(","c)
                If parts.Length <> 2 Then
                    Continue For
                End If

                Dim x As Integer
                Dim y As Integer
                If Not Integer.TryParse(parts(0), x) OrElse Not Integer.TryParse(parts(1), y) Then
                    Continue For
                End If

                ApplyCoordinateByKey(kv(0).Trim(), x, y)
            Next
        Catch
            ' Ignore malformed coordinate profile and keep defaults.
        End Try
    End Sub

    Private Sub SaveCoordinateProfile()
        Dim lines As New List(Of String) From {
            String.Format("homeClick={0},{1}", homeButtonX, homeButtonY),
            String.Format("simModeClick={0},{1}", simModeX, simModeY),
            String.Format("greenButton={0},{1}", greenButtonX, greenButtonY),
            String.Format("confirmPrimary={0},{1}", confirmPrimaryX, confirmPrimaryY),
            String.Format("confirmSecondary={0},{1}", confirmSecondaryX, confirmSecondaryY),
            String.Format("endMatchColor={0},{1}", endMatchColorX, endMatchColorY)
        }

        File.WriteAllLines(coordsFilePath, lines)
    End Sub

    Private Sub ApplyCoordinateByKey(key As String, x As Integer, y As Integer)
        Select Case key.ToLowerInvariant()
            Case "homeclick"
                homeButtonX = x
                homeButtonY = y
            Case "simmodeclick"
                simModeX = x
                simModeY = y
            Case "greenbutton"
                greenButtonX = x
                greenButtonY = y
            Case "confirmprimary"
                confirmPrimaryX = x
                confirmPrimaryY = y
            Case "confirmsecondary"
                confirmSecondaryX = x
                confirmSecondaryY = y
            Case "endmatchcolor"
                endMatchColorX = x
                endMatchColorY = y
        End Select
    End Sub

    Private Sub btnSaveCoordinate_Click(sender As Object, e As EventArgs) Handles btnSaveCoordinate.Click
        Dim hWnd As IntPtr = IntPtr.Zero
        If Not TryGetGameHandle(hWnd) Then
            MessageBox.Show("Chưa tìm thấy cửa sổ FC ONLINE để lưu tọa độ.", "FO4 Auto Click Panel", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim key As String = String.Empty
        If Not TryResolveSelectedCoordinateKey(key) Then
            MessageBox.Show("Vui lòng chọn loại tọa độ cần lưu.", "FO4 Auto Click Panel", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim p As WinPoint
        p.X = Cursor.Position.X
        p.Y = Cursor.Position.Y
        If Not ScreenToClient(hWnd, p) Then
            MessageBox.Show("Không lấy được tọa độ chuột theo cửa sổ game.", "FO4 Auto Click Panel", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ApplyCoordinateByKey(key, p.X, p.Y)
        SaveCoordinateProfile()
        UpdateStatus("Đang dừng", String.Format("Da luu {0}: ({1},{2})", cmbCoordinateTarget.Text, p.X, p.Y), lblDetectedColorValue.Text)
    End Sub

    Private Function TryResolveSelectedCoordinateKey(ByRef key As String) As Boolean
        key = String.Empty
        Select Case cmbCoordinateTarget.SelectedIndex
            Case 0
                key = "homeClick"
            Case 1
                key = "simModeClick"
            Case 2
                key = "greenButton"
            Case 3
                key = "confirmPrimary"
            Case 4
                key = "confirmSecondary"
            Case 5
                key = "endMatchColor"
        End Select

        Return Not String.IsNullOrWhiteSpace(key)
    End Function

    Private Sub chkDebugRealtime_CheckedChanged(sender As Object, e As EventArgs) Handles chkDebugRealtime.CheckedChanged
        debugRealtimeEnabled = chkDebugRealtime.Checked
        TimerDebug.Enabled = debugRealtimeEnabled
        If Not debugRealtimeEnabled Then
            lblDebugPointValue.Text = "Tat"
            lblDebugColorValue.Text = "Tat"
        End If
    End Sub

    Private Sub TimerDebug_Tick(sender As Object, e As EventArgs) Handles TimerDebug.Tick
        If Not debugRealtimeEnabled Then
            Return
        End If

        Dim x As Integer = simModeX
        Dim y As Integer = simModeY
        Dim pointName As String = "Gia lap XH"

        Select Case cmbCoordinateTarget.SelectedIndex
            Case 0
                x = homeButtonX
                y = homeButtonY
                pointName = "Click mo khu HLV"
            Case 1
                x = simModeX
                y = simModeY
                pointName = "Click Gia lap XH"
            Case 2
                x = greenButtonX
                y = greenButtonY
                pointName = "Click nut xanh"
            Case 3
                x = confirmPrimaryX
                y = confirmPrimaryY
                pointName = "Click xac nhan chinh"
            Case 4
                x = confirmSecondaryX
                y = confirmSecondaryY
                pointName = "Click xac nhan phu"
            Case 5
                x = endMatchColorX
                y = endMatchColorY
                pointName = "Diem doc mau cuoi tran"
        End Select

        Dim color As String = GetColor.GETCOLOR(x, y)
        UpdateDebugRealtime(pointName, x, y, color)
    End Sub

    Private Function ReadColorAt(pointName As String, x As Integer, y As Integer) As String
        Dim color As String = GetColor.GETCOLOR(x, y)
        If debugRealtimeEnabled Then
            UpdateDebugRealtime(pointName, x, y, color)
        End If

        Return color
    End Function

    Private Sub UpdateDebugRealtime(pointName As String, x As Integer, y As Integer, color As String)
        If InvokeRequired Then
            Invoke(New Action(Of String, Integer, Integer, String)(AddressOf UpdateDebugRealtime), pointName, x, y, color)
            Return
        End If

        lblDebugPointValue.Text = String.Format("{0} -> ({1},{2})", pointName, x, y)
        lblDebugColorValue.Text = If(String.IsNullOrWhiteSpace(color), "N/A", color)
    End Sub

    Private Function FormatTargetMatchCount() As String
        If targetMatchCount <= 0 Then
            Return "Vo han"
        End If

        Return targetMatchCount.ToString()
    End Function

    Private Sub ProcessPostMatchIfNeeded(actionName As String, detectedColor As String)
        If isMatchInProgress Then
            completedMatchCount += 1
            isMatchInProgress = False
            UpdateStatus("Đang chạy", String.Format("{0} - hoàn thành {1}/{2} trận", actionName, completedMatchCount, FormatTargetMatchCount()), detectedColor)
            Return
        End If

        UpdateStatus("Đang chạy", String.Format("{0} ({1}/{2})", actionName, completedMatchCount, FormatTargetMatchCount()), detectedColor)
    End Sub

    Private Function IsNearWhiteHex(colorHex As String) As Boolean
        If String.IsNullOrWhiteSpace(colorHex) Then
            Return False
        End If

        Dim normalized As String = colorHex.Trim()
        If normalized.StartsWith("0x", StringComparison.OrdinalIgnoreCase) Then
            normalized = normalized.Substring(2)
        End If

        If normalized.Length <> 6 Then
            Return False
        End If

        Try
            Dim r As Integer = Convert.ToInt32(normalized.Substring(0, 2), 16)
            Dim g As Integer = Convert.ToInt32(normalized.Substring(2, 2), 16)
            Dim b As Integer = Convert.ToInt32(normalized.Substring(4, 2), 16)

            Return r >= 220 AndAlso g >= 220 AndAlso b >= 220
        Catch
            Return False
        End Try
    End Function

    Private Function IsLikelyGreenActionButton(colorHex As String) As Boolean
        If String.IsNullOrWhiteSpace(colorHex) Then
            Return False
        End If

        Dim normalized As String = colorHex.Trim()
        If normalized.StartsWith("0x", StringComparison.OrdinalIgnoreCase) Then
            normalized = normalized.Substring(2)
        End If

        If normalized.Length <> 6 Then
            Return False
        End If

        Try
            Dim r As Integer = Convert.ToInt32(normalized.Substring(0, 2), 16)
            Dim g As Integer = Convert.ToInt32(normalized.Substring(2, 2), 16)
            Dim b As Integer = Convert.ToInt32(normalized.Substring(4, 2), 16)

            Return g >= 170 AndAlso r <= 120 AndAlso b <= 120
        Catch
            Return False
        End Try
    End Function

    Private Sub ClickGameClient(x As Integer, y As Integer)
        Dim hWnd As IntPtr = IntPtr.Zero
        If Not TryGetGameHandle(hWnd) Then
            Return
        End If

        Dim lParam As IntPtr = MakeLParam(x, y)
        PostMessage(hWnd, WM_LBUTTONDOWN, CType(MK_LBUTTON, IntPtr), lParam)
        System.Threading.Thread.Sleep(20)
        PostMessage(hWnd, WM_LBUTTONUP, IntPtr.Zero, lParam)
    End Sub

    Private Sub SendGameKey(keys As String)
        Dim hWnd As IntPtr = IntPtr.Zero
        If Not TryGetGameHandle(hWnd) Then
            Return
        End If

        Dim vk As Integer
        If Not TryResolveVirtualKey(keys, vk) Then
            AutoIt.AutoItX.ControlSend("FC ONLINE", "", "", keys)
            Return
        End If

        PostMessage(hWnd, WM_KEYDOWN, CType(vk, IntPtr), IntPtr.Zero)
        System.Threading.Thread.Sleep(20)
        PostMessage(hWnd, WM_KEYUP, CType(vk, IntPtr), IntPtr.Zero)
    End Sub

    Private Function TryGetGameHandle(ByRef hWnd As IntPtr) As Boolean
        If AutoIt.AutoItX.WinExists("FC ONLINE", "") = 0 Then
            Return False
        End If

        hWnd = AutoIt.AutoItX.WinGetHandle("FC ONLINE", "")
        Return hWnd <> IntPtr.Zero
    End Function

    Private Function TryResolveVirtualKey(keys As String, ByRef vk As Integer) As Boolean
        Dim normalized As String = keys.Trim().ToUpperInvariant()
        If normalized = "S" Then
            vk = &H53
            Return True
        End If

        If normalized = "{SPACE}" Then
            vk = &H20
            Return True
        End If

        vk = 0
        Return False
    End Function

    Private Function MakeLParam(x As Integer, y As Integer) As IntPtr
        Dim value As Integer = (y << 16) Or (x And &HFFFF)
        Return CType(value, IntPtr)
    End Function
End Class
