<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.TimerDebug = New System.Windows.Forms.Timer(Me.components)
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.TabControlMain = New System.Windows.Forms.TabControl()
        Me.TabPageDashboard = New System.Windows.Forms.TabPage()
        Me.GroupBoxStatus = New System.Windows.Forms.GroupBox()
        Me.lblDebugColorValue = New System.Windows.Forms.Label()
        Me.lblDebugColorTitle = New System.Windows.Forms.Label()
        Me.lblDebugPointValue = New System.Windows.Forms.Label()
        Me.lblDebugPointTitle = New System.Windows.Forms.Label()
        Me.lblDetectedColorValue = New System.Windows.Forms.Label()
        Me.lblDetectedColorTitle = New System.Windows.Forms.Label()
        Me.lblLastActionValue = New System.Windows.Forms.Label()
        Me.lblLastActionTitle = New System.Windows.Forms.Label()
        Me.lblRunStateValue = New System.Windows.Forms.Label()
        Me.lblRunStateTitle = New System.Windows.Forms.Label()
        Me.GroupBoxAutomation = New System.Windows.Forms.GroupBox()
        Me.chkEndMatchSpace = New System.Windows.Forms.CheckBox()
        Me.chkConfirmSecondary = New System.Windows.Forms.CheckBox()
        Me.chkConfirmPrimary = New System.Windows.Forms.CheckBox()
        Me.chkManagerMenu2 = New System.Windows.Forms.CheckBox()
        Me.chkHomeManager = New System.Windows.Forms.CheckBox()
        Me.GroupBoxSession = New System.Windows.Forms.GroupBox()
        Me.chkDebugRealtime = New System.Windows.Forms.CheckBox()
        Me.btnSaveCoordinate = New System.Windows.Forms.Button()
        Me.cmbCoordinateTarget = New System.Windows.Forms.ComboBox()
        Me.lblCoordinateTarget = New System.Windows.Forms.Label()
        Me.numTargetMatchCount = New System.Windows.Forms.NumericUpDown()
        Me.lblTargetMatchHint = New System.Windows.Forms.Label()
        Me.lblTargetMatchTitle = New System.Windows.Forms.Label()
        Me.btnCheckWindow = New System.Windows.Forms.Button()
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lblResolutionValue = New System.Windows.Forms.Label()
        Me.lblResolutionTitle = New System.Windows.Forms.Label()
        Me.lblGameTitleValue = New System.Windows.Forms.Label()
        Me.lblGameTitleTitle = New System.Windows.Forms.Label()
        Me.TabPageSettings = New System.Windows.Forms.TabPage()
        Me.GroupBoxNotes = New System.Windows.Forms.GroupBox()
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.GroupBoxWindow = New System.Windows.Forms.GroupBox()
        Me.chkAlwaysOnTop = New System.Windows.Forms.CheckBox()
        Me.GroupBoxTiming = New System.Windows.Forms.GroupBox()
        Me.lblClickDelay = New System.Windows.Forms.Label()
        Me.numClickDelay = New System.Windows.Forms.NumericUpDown()
        Me.lblLoopDelay = New System.Windows.Forms.Label()
        Me.numLoopDelay = New System.Windows.Forms.NumericUpDown()
        Me.TabPageAbout = New System.Windows.Forms.TabPage()
        Me.txtAbout = New System.Windows.Forms.TextBox()
        Me.pnlHeader.SuspendLayout()
        Me.TabControlMain.SuspendLayout()
        Me.TabPageDashboard.SuspendLayout()
        Me.GroupBoxStatus.SuspendLayout()
        Me.GroupBoxAutomation.SuspendLayout()
        Me.GroupBoxSession.SuspendLayout()
        Me.TabPageSettings.SuspendLayout()
        Me.GroupBoxNotes.SuspendLayout()
        Me.GroupBoxWindow.SuspendLayout()
        Me.GroupBoxTiming.SuspendLayout()
        CType(Me.numTargetMatchCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numClickDelay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numLoopDelay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageAbout.SuspendLayout()
        Me.SuspendLayout()
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'TimerDebug
        '
        Me.TimerDebug.Interval = 400
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblSubtitle)
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(784, 84)
        Me.pnlHeader.TabIndex = 0
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lblSubtitle.Location = New System.Drawing.Point(24, 49)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(366, 17)
        Me.lblSubtitle.TabIndex = 1
        Me.lblSubtitle.Text = "Giao diện điều khiển cho auto click FO4, ưu tiên dễ nhìn và dễ dùng"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(21, 15)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(243, 32)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "FO4 Auto Click Panel"
        '
        'TabControlMain
        '
        Me.TabControlMain.Controls.Add(Me.TabPageDashboard)
        Me.TabControlMain.Controls.Add(Me.TabPageSettings)
        Me.TabControlMain.Controls.Add(Me.TabPageAbout)
        Me.TabControlMain.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlMain.Location = New System.Drawing.Point(12, 96)
        Me.TabControlMain.Name = "TabControlMain"
        Me.TabControlMain.SelectedIndex = 0
        Me.TabControlMain.Size = New System.Drawing.Size(760, 452)
        Me.TabControlMain.TabIndex = 1
        '
        'TabPageDashboard
        '
        Me.TabPageDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.TabPageDashboard.Controls.Add(Me.GroupBoxStatus)
        Me.TabPageDashboard.Controls.Add(Me.GroupBoxAutomation)
        Me.TabPageDashboard.Controls.Add(Me.GroupBoxSession)
        Me.TabPageDashboard.Location = New System.Drawing.Point(4, 24)
        Me.TabPageDashboard.Name = "TabPageDashboard"
        Me.TabPageDashboard.Padding = New System.Windows.Forms.Padding(12)
        Me.TabPageDashboard.Size = New System.Drawing.Size(752, 424)
        Me.TabPageDashboard.TabIndex = 0
        Me.TabPageDashboard.Text = "Chức năng chính"
        '
        'GroupBoxStatus
        '
        Me.GroupBoxStatus.Controls.Add(Me.lblDebugColorValue)
        Me.GroupBoxStatus.Controls.Add(Me.lblDebugColorTitle)
        Me.GroupBoxStatus.Controls.Add(Me.lblDebugPointValue)
        Me.GroupBoxStatus.Controls.Add(Me.lblDebugPointTitle)
        Me.GroupBoxStatus.Controls.Add(Me.lblDetectedColorValue)
        Me.GroupBoxStatus.Controls.Add(Me.lblDetectedColorTitle)
        Me.GroupBoxStatus.Controls.Add(Me.lblLastActionValue)
        Me.GroupBoxStatus.Controls.Add(Me.lblLastActionTitle)
        Me.GroupBoxStatus.Controls.Add(Me.lblRunStateValue)
        Me.GroupBoxStatus.Controls.Add(Me.lblRunStateTitle)
        Me.GroupBoxStatus.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBoxStatus.Location = New System.Drawing.Point(15, 239)
        Me.GroupBoxStatus.Name = "GroupBoxStatus"
        Me.GroupBoxStatus.Size = New System.Drawing.Size(722, 240)
        Me.GroupBoxStatus.TabIndex = 2
        Me.GroupBoxStatus.TabStop = False
        Me.GroupBoxStatus.Text = "Trạng thái"
        '
        'lblDebugColorValue
        '
        Me.lblDebugColorValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDebugColorValue.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDebugColorValue.Location = New System.Drawing.Point(141, 183)
        Me.lblDebugColorValue.Name = "lblDebugColorValue"
        Me.lblDebugColorValue.Size = New System.Drawing.Size(548, 27)
        Me.lblDebugColorValue.TabIndex = 9
        Me.lblDebugColorValue.Text = "Tat"
        Me.lblDebugColorValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDebugColorTitle
        '
        Me.lblDebugColorTitle.AutoSize = True
        Me.lblDebugColorTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblDebugColorTitle.Location = New System.Drawing.Point(26, 189)
        Me.lblDebugColorTitle.Name = "lblDebugColorTitle"
        Me.lblDebugColorTitle.Size = New System.Drawing.Size(94, 15)
        Me.lblDebugColorTitle.TabIndex = 8
        Me.lblDebugColorTitle.Text = "Debug màu đọc :"
        '
        'lblDebugPointValue
        '
        Me.lblDebugPointValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDebugPointValue.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDebugPointValue.Location = New System.Drawing.Point(141, 145)
        Me.lblDebugPointValue.Name = "lblDebugPointValue"
        Me.lblDebugPointValue.Size = New System.Drawing.Size(548, 27)
        Me.lblDebugPointValue.TabIndex = 7
        Me.lblDebugPointValue.Text = "Tat"
        Me.lblDebugPointValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDebugPointTitle
        '
        Me.lblDebugPointTitle.AutoSize = True
        Me.lblDebugPointTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblDebugPointTitle.Location = New System.Drawing.Point(26, 151)
        Me.lblDebugPointTitle.Name = "lblDebugPointTitle"
        Me.lblDebugPointTitle.Size = New System.Drawing.Size(103, 15)
        Me.lblDebugPointTitle.TabIndex = 6
        Me.lblDebugPointTitle.Text = "Debug điểm đọc :"
        '
        'lblDetectedColorValue
        '
        Me.lblDetectedColorValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDetectedColorValue.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetectedColorValue.Location = New System.Drawing.Point(141, 107)
        Me.lblDetectedColorValue.Name = "lblDetectedColorValue"
        Me.lblDetectedColorValue.Size = New System.Drawing.Size(548, 27)
        Me.lblDetectedColorValue.TabIndex = 5
        Me.lblDetectedColorValue.Text = "Chưa đọc màu"
        Me.lblDetectedColorValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDetectedColorTitle
        '
        Me.lblDetectedColorTitle.AutoSize = True
        Me.lblDetectedColorTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblDetectedColorTitle.Location = New System.Drawing.Point(26, 113)
        Me.lblDetectedColorTitle.Name = "lblDetectedColorTitle"
        Me.lblDetectedColorTitle.Size = New System.Drawing.Size(86, 15)
        Me.lblDetectedColorTitle.TabIndex = 4
        Me.lblDetectedColorTitle.Text = "Màu vừa đọc :"
        '
        'lblLastActionValue
        '
        Me.lblLastActionValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLastActionValue.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastActionValue.Location = New System.Drawing.Point(141, 69)
        Me.lblLastActionValue.Name = "lblLastActionValue"
        Me.lblLastActionValue.Size = New System.Drawing.Size(548, 27)
        Me.lblLastActionValue.TabIndex = 3
        Me.lblLastActionValue.Text = "Chưa có thao tác nào"
        Me.lblLastActionValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLastActionTitle
        '
        Me.lblLastActionTitle.AutoSize = True
        Me.lblLastActionTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblLastActionTitle.Location = New System.Drawing.Point(26, 75)
        Me.lblLastActionTitle.Name = "lblLastActionTitle"
        Me.lblLastActionTitle.Size = New System.Drawing.Size(99, 15)
        Me.lblLastActionTitle.TabIndex = 2
        Me.lblLastActionTitle.Text = "Hành động cuối :"
        '
        'lblRunStateValue
        '
        Me.lblRunStateValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRunStateValue.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRunStateValue.Location = New System.Drawing.Point(141, 31)
        Me.lblRunStateValue.Name = "lblRunStateValue"
        Me.lblRunStateValue.Size = New System.Drawing.Size(548, 27)
        Me.lblRunStateValue.TabIndex = 1
        Me.lblRunStateValue.Text = "Đang dừng"
        Me.lblRunStateValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRunStateTitle
        '
        Me.lblRunStateTitle.AutoSize = True
        Me.lblRunStateTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblRunStateTitle.Location = New System.Drawing.Point(26, 37)
        Me.lblRunStateTitle.Name = "lblRunStateTitle"
        Me.lblRunStateTitle.Size = New System.Drawing.Size(67, 15)
        Me.lblRunStateTitle.TabIndex = 0
        Me.lblRunStateTitle.Text = "Trạng thái :"
        '
        'GroupBoxAutomation
        '
        Me.GroupBoxAutomation.Controls.Add(Me.chkEndMatchSpace)
        Me.GroupBoxAutomation.Controls.Add(Me.chkConfirmSecondary)
        Me.GroupBoxAutomation.Controls.Add(Me.chkConfirmPrimary)
        Me.GroupBoxAutomation.Controls.Add(Me.chkManagerMenu2)
        Me.GroupBoxAutomation.Controls.Add(Me.chkHomeManager)
        Me.GroupBoxAutomation.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBoxAutomation.Location = New System.Drawing.Point(376, 15)
        Me.GroupBoxAutomation.Name = "GroupBoxAutomation"
        Me.GroupBoxAutomation.Size = New System.Drawing.Size(361, 206)
        Me.GroupBoxAutomation.TabIndex = 1
        Me.GroupBoxAutomation.TabStop = False
        Me.GroupBoxAutomation.Text = "Luồng tự động"
        '
        'chkEndMatchSpace
        '
        Me.chkEndMatchSpace.AutoSize = True
        Me.chkEndMatchSpace.Checked = True
        Me.chkEndMatchSpace.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEndMatchSpace.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.chkEndMatchSpace.Location = New System.Drawing.Point(24, 179)
        Me.chkEndMatchSpace.Name = "chkEndMatchSpace"
        Me.chkEndMatchSpace.Size = New System.Drawing.Size(256, 19)
        Me.chkEndMatchSpace.TabIndex = 4
        Me.chkEndMatchSpace.Text = "Bấm Space khi hiện màn hình cuối trận"
        Me.chkEndMatchSpace.UseVisualStyleBackColor = True
        '
        'chkConfirmSecondary
        '
        Me.chkConfirmSecondary.AutoSize = True
        Me.chkConfirmSecondary.Checked = True
        Me.chkConfirmSecondary.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkConfirmSecondary.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.chkConfirmSecondary.Location = New System.Drawing.Point(24, 145)
        Me.chkConfirmSecondary.Name = "chkConfirmSecondary"
        Me.chkConfirmSecondary.Size = New System.Drawing.Size(276, 19)
        Me.chkConfirmSecondary.TabIndex = 3
        Me.chkConfirmSecondary.Text = "Bấm nút xác nhận phụ ở vị trí cuối màn hình"
        Me.chkConfirmSecondary.UseVisualStyleBackColor = True
        '
        'chkConfirmPrimary
        '
        Me.chkConfirmPrimary.AutoSize = True
        Me.chkConfirmPrimary.Checked = True
        Me.chkConfirmPrimary.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkConfirmPrimary.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.chkConfirmPrimary.Location = New System.Drawing.Point(24, 111)
        Me.chkConfirmPrimary.Name = "chkConfirmPrimary"
        Me.chkConfirmPrimary.Size = New System.Drawing.Size(286, 19)
        Me.chkConfirmPrimary.TabIndex = 2
        Me.chkConfirmPrimary.Text = "Bấm nút xác nhận chính khi màu xanh xuất hiện"
        Me.chkConfirmPrimary.UseVisualStyleBackColor = True
        '
        'chkManagerMenu2
        '
        Me.chkManagerMenu2.AutoSize = True
        Me.chkManagerMenu2.Checked = True
        Me.chkManagerMenu2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkManagerMenu2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.chkManagerMenu2.Location = New System.Drawing.Point(24, 77)
        Me.chkManagerMenu2.Name = "chkManagerMenu2"
        Me.chkManagerMenu2.Size = New System.Drawing.Size(269, 19)
        Me.chkManagerMenu2.TabIndex = 1
        Me.chkManagerMenu2.Text = "Đi tiếp ở menu HLV khi nút màu xanh hiện ra"
        Me.chkManagerMenu2.UseVisualStyleBackColor = True
        '
        'chkHomeManager
        '
        Me.chkHomeManager.AutoSize = True
        Me.chkHomeManager.Checked = True
        Me.chkHomeManager.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkHomeManager.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.chkHomeManager.Location = New System.Drawing.Point(24, 43)
        Me.chkHomeManager.Name = "chkHomeManager"
        Me.chkHomeManager.Size = New System.Drawing.Size(279, 19)
        Me.chkHomeManager.TabIndex = 0
        Me.chkHomeManager.Text = "Mở khu vực HLV từ màn hình chính của game"
        Me.chkHomeManager.UseVisualStyleBackColor = True
        '
        'GroupBoxSession
        '
        Me.GroupBoxSession.Controls.Add(Me.chkDebugRealtime)
        Me.GroupBoxSession.Controls.Add(Me.btnSaveCoordinate)
        Me.GroupBoxSession.Controls.Add(Me.cmbCoordinateTarget)
        Me.GroupBoxSession.Controls.Add(Me.lblCoordinateTarget)
        Me.GroupBoxSession.Controls.Add(Me.numTargetMatchCount)
        Me.GroupBoxSession.Controls.Add(Me.lblTargetMatchHint)
        Me.GroupBoxSession.Controls.Add(Me.lblTargetMatchTitle)
        Me.GroupBoxSession.Controls.Add(Me.btnCheckWindow)
        Me.GroupBoxSession.Controls.Add(Me.btnRestart)
        Me.GroupBoxSession.Controls.Add(Me.btnStop)
        Me.GroupBoxSession.Controls.Add(Me.btnStart)
        Me.GroupBoxSession.Controls.Add(Me.lblResolutionValue)
        Me.GroupBoxSession.Controls.Add(Me.lblResolutionTitle)
        Me.GroupBoxSession.Controls.Add(Me.lblGameTitleValue)
        Me.GroupBoxSession.Controls.Add(Me.lblGameTitleTitle)
        Me.GroupBoxSession.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBoxSession.Location = New System.Drawing.Point(15, 15)
        Me.GroupBoxSession.Name = "GroupBoxSession"
        Me.GroupBoxSession.Size = New System.Drawing.Size(341, 252)
        Me.GroupBoxSession.TabIndex = 0
        Me.GroupBoxSession.TabStop = False
        Me.GroupBoxSession.Text = "Phiên làm việc"
        '
        'chkDebugRealtime
        '
        Me.chkDebugRealtime.AutoSize = True
        Me.chkDebugRealtime.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.chkDebugRealtime.Location = New System.Drawing.Point(28, 221)
        Me.chkDebugRealtime.Name = "chkDebugRealtime"
        Me.chkDebugRealtime.Size = New System.Drawing.Size(181, 19)
        Me.chkDebugRealtime.TabIndex = 13
        Me.chkDebugRealtime.Text = "Debug tọa độ/màu realtime"
        Me.chkDebugRealtime.UseVisualStyleBackColor = True
        '
        'btnSaveCoordinate
        '
        Me.btnSaveCoordinate.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnSaveCoordinate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveCoordinate.Location = New System.Drawing.Point(258, 188)
        Me.btnSaveCoordinate.Name = "btnSaveCoordinate"
        Me.btnSaveCoordinate.Size = New System.Drawing.Size(49, 27)
        Me.btnSaveCoordinate.TabIndex = 12
        Me.btnSaveCoordinate.Text = "Lưu"
        Me.btnSaveCoordinate.UseVisualStyleBackColor = False
        '
        'cmbCoordinateTarget
        '
        Me.cmbCoordinateTarget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCoordinateTarget.Font = New System.Drawing.Font("Segoe UI", 8.75!)
        Me.cmbCoordinateTarget.FormattingEnabled = True
        Me.cmbCoordinateTarget.Location = New System.Drawing.Point(114, 189)
        Me.cmbCoordinateTarget.Name = "cmbCoordinateTarget"
        Me.cmbCoordinateTarget.Size = New System.Drawing.Size(138, 23)
        Me.cmbCoordinateTarget.TabIndex = 11
        '
        'lblCoordinateTarget
        '
        Me.lblCoordinateTarget.AutoSize = True
        Me.lblCoordinateTarget.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblCoordinateTarget.Location = New System.Drawing.Point(25, 193)
        Me.lblCoordinateTarget.Name = "lblCoordinateTarget"
        Me.lblCoordinateTarget.Size = New System.Drawing.Size(80, 15)
        Me.lblCoordinateTarget.TabIndex = 10
        Me.lblCoordinateTarget.Text = "Lưu tọa độ  :"
        '
        'numTargetMatchCount
        '
        Me.numTargetMatchCount.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.numTargetMatchCount.Location = New System.Drawing.Point(132, 81)
        Me.numTargetMatchCount.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.numTargetMatchCount.Name = "numTargetMatchCount"
        Me.numTargetMatchCount.Size = New System.Drawing.Size(70, 23)
        Me.numTargetMatchCount.TabIndex = 6
        Me.numTargetMatchCount.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblTargetMatchHint
        '
        Me.lblTargetMatchHint.AutoSize = True
        Me.lblTargetMatchHint.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblTargetMatchHint.ForeColor = System.Drawing.Color.DimGray
        Me.lblTargetMatchHint.Location = New System.Drawing.Point(210, 86)
        Me.lblTargetMatchHint.Name = "lblTargetMatchHint"
        Me.lblTargetMatchHint.Size = New System.Drawing.Size(98, 13)
        Me.lblTargetMatchHint.TabIndex = 5
        Me.lblTargetMatchHint.Text = "0 = treo không giới hạn"
        '
        'lblTargetMatchTitle
        '
        Me.lblTargetMatchTitle.AutoSize = True
        Me.lblTargetMatchTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTargetMatchTitle.Location = New System.Drawing.Point(25, 84)
        Me.lblTargetMatchTitle.Name = "lblTargetMatchTitle"
        Me.lblTargetMatchTitle.Size = New System.Drawing.Size(97, 15)
        Me.lblTargetMatchTitle.TabIndex = 4
        Me.lblTargetMatchTitle.Text = "Số trận cần treo :"
        '
        'btnCheckWindow
        '
        Me.btnCheckWindow.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnCheckWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheckWindow.Location = New System.Drawing.Point(175, 151)
        Me.btnCheckWindow.Name = "btnCheckWindow"
        Me.btnCheckWindow.Size = New System.Drawing.Size(132, 34)
        Me.btnCheckWindow.TabIndex = 9
        Me.btnCheckWindow.Text = "Kiểm tra game"
        Me.btnCheckWindow.UseVisualStyleBackColor = False
        '
        'btnRestart
        '
        Me.btnRestart.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestart.Location = New System.Drawing.Point(28, 151)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(132, 34)
        Me.btnRestart.TabIndex = 8
        Me.btnRestart.Text = "Khởi động lại tool"
        Me.btnRestart.UseVisualStyleBackColor = False
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnStop.Enabled = False
        Me.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStop.Location = New System.Drawing.Point(175, 109)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(132, 34)
        Me.btnStop.TabIndex = 7
        Me.btnStop.Text = "Dừng"
        Me.btnStop.UseVisualStyleBackColor = False
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.Location = New System.Drawing.Point(28, 109)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(132, 34)
        Me.btnStart.TabIndex = 6
        Me.btnStart.Text = "Bắt đầu"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'lblResolutionValue
        '
        Me.lblResolutionValue.AutoSize = True
        Me.lblResolutionValue.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblResolutionValue.Location = New System.Drawing.Point(132, 57)
        Me.lblResolutionValue.Name = "lblResolutionValue"
        Me.lblResolutionValue.Size = New System.Drawing.Size(126, 15)
        Me.lblResolutionValue.TabIndex = 3
        Me.lblResolutionValue.Text = "1280 x 720 (16:9 toàn)"
        '
        'lblResolutionTitle
        '
        Me.lblResolutionTitle.AutoSize = True
        Me.lblResolutionTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblResolutionTitle.Location = New System.Drawing.Point(25, 57)
        Me.lblResolutionTitle.Name = "lblResolutionTitle"
        Me.lblResolutionTitle.Size = New System.Drawing.Size(80, 15)
        Me.lblResolutionTitle.TabIndex = 2
        Me.lblResolutionTitle.Text = "Độ phân giải :"
        '
        'lblGameTitleValue
        '
        Me.lblGameTitleValue.AutoSize = True
        Me.lblGameTitleValue.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblGameTitleValue.Location = New System.Drawing.Point(132, 31)
        Me.lblGameTitleValue.Name = "lblGameTitleValue"
        Me.lblGameTitleValue.Size = New System.Drawing.Size(76, 15)
        Me.lblGameTitleValue.TabIndex = 1
        Me.lblGameTitleValue.Text = "FC ONLINE"
        '
        'lblGameTitleTitle
        '
        Me.lblGameTitleTitle.AutoSize = True
        Me.lblGameTitleTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblGameTitleTitle.Location = New System.Drawing.Point(25, 31)
        Me.lblGameTitleTitle.Name = "lblGameTitleTitle"
        Me.lblGameTitleTitle.Size = New System.Drawing.Size(79, 15)
        Me.lblGameTitleTitle.TabIndex = 0
        Me.lblGameTitleTitle.Text = "Cửa sổ game :"
        '
        'TabPageSettings
        '
        Me.TabPageSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.TabPageSettings.Controls.Add(Me.GroupBoxNotes)
        Me.TabPageSettings.Controls.Add(Me.GroupBoxWindow)
        Me.TabPageSettings.Controls.Add(Me.GroupBoxTiming)
        Me.TabPageSettings.Location = New System.Drawing.Point(4, 24)
        Me.TabPageSettings.Name = "TabPageSettings"
        Me.TabPageSettings.Padding = New System.Windows.Forms.Padding(12)
        Me.TabPageSettings.Size = New System.Drawing.Size(752, 424)
        Me.TabPageSettings.TabIndex = 1
        Me.TabPageSettings.Text = "Cài đặt khác"
        '
        'GroupBoxNotes
        '
        Me.GroupBoxNotes.Controls.Add(Me.lblNotes)
        Me.GroupBoxNotes.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBoxNotes.Location = New System.Drawing.Point(15, 214)
        Me.GroupBoxNotes.Name = "GroupBoxNotes"
        Me.GroupBoxNotes.Size = New System.Drawing.Size(722, 187)
        Me.GroupBoxNotes.TabIndex = 2
        Me.GroupBoxNotes.TabStop = False
        Me.GroupBoxNotes.Text = "Lưu ý sử dụng"
        '
        'lblNotes
        '
        Me.lblNotes.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblNotes.Location = New System.Drawing.Point(24, 31)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(671, 135)
        Me.lblNotes.TabIndex = 0
        Me.lblNotes.Text = "1. Chạy game ở đúng độ phân giải 1280 x 720.  2. Không thay đổi vị trí cửa sổ game trong lúc tool đang chạy.  3. Nếu màu nhận diện lệch, giảm tốc độ quét hoặc kiểm tra lại giao diện game.  4. Bắt đầu chỉ bật vòng lặp auto, không tự mở game."
        '
        'GroupBoxWindow
        '
        Me.GroupBoxWindow.Controls.Add(Me.chkAlwaysOnTop)
        Me.GroupBoxWindow.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBoxWindow.Location = New System.Drawing.Point(390, 15)
        Me.GroupBoxWindow.Name = "GroupBoxWindow"
        Me.GroupBoxWindow.Size = New System.Drawing.Size(347, 179)
        Me.GroupBoxWindow.TabIndex = 1
        Me.GroupBoxWindow.TabStop = False
        Me.GroupBoxWindow.Text = "Hiển thị"
        '
        'chkAlwaysOnTop
        '
        Me.chkAlwaysOnTop.AutoSize = True
        Me.chkAlwaysOnTop.Checked = True
        Me.chkAlwaysOnTop.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAlwaysOnTop.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.chkAlwaysOnTop.Location = New System.Drawing.Point(24, 38)
        Me.chkAlwaysOnTop.Name = "chkAlwaysOnTop"
        Me.chkAlwaysOnTop.Size = New System.Drawing.Size(177, 19)
        Me.chkAlwaysOnTop.TabIndex = 0
        Me.chkAlwaysOnTop.Text = "Luôn ghim tool ở phía trên"
        Me.chkAlwaysOnTop.UseVisualStyleBackColor = True
        '
        'GroupBoxTiming
        '
        Me.GroupBoxTiming.Controls.Add(Me.lblClickDelay)
        Me.GroupBoxTiming.Controls.Add(Me.numClickDelay)
        Me.GroupBoxTiming.Controls.Add(Me.lblLoopDelay)
        Me.GroupBoxTiming.Controls.Add(Me.numLoopDelay)
        Me.GroupBoxTiming.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBoxTiming.Location = New System.Drawing.Point(15, 15)
        Me.GroupBoxTiming.Name = "GroupBoxTiming"
        Me.GroupBoxTiming.Size = New System.Drawing.Size(347, 179)
        Me.GroupBoxTiming.TabIndex = 0
        Me.GroupBoxTiming.TabStop = False
        Me.GroupBoxTiming.Text = "Tốc độ"
        '
        'lblClickDelay
        '
        Me.lblClickDelay.AutoSize = True
        Me.lblClickDelay.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblClickDelay.Location = New System.Drawing.Point(24, 93)
        Me.lblClickDelay.Name = "lblClickDelay"
        Me.lblClickDelay.Size = New System.Drawing.Size(140, 15)
        Me.lblClickDelay.TabIndex = 3
        Me.lblClickDelay.Text = "Nghỉ sau mỗi lần click (ms)"
        '
        'numClickDelay
        '
        Me.numClickDelay.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.numClickDelay.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.numClickDelay.Location = New System.Drawing.Point(195, 90)
        Me.numClickDelay.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.numClickDelay.Minimum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.numClickDelay.Name = "numClickDelay"
        Me.numClickDelay.Size = New System.Drawing.Size(120, 23)
        Me.numClickDelay.TabIndex = 2
        Me.numClickDelay.Value = New Decimal(New Integer() {500, 0, 0, 0})
        '
        'lblLoopDelay
        '
        Me.lblLoopDelay.AutoSize = True
        Me.lblLoopDelay.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblLoopDelay.Location = New System.Drawing.Point(24, 45)
        Me.lblLoopDelay.Name = "lblLoopDelay"
        Me.lblLoopDelay.Size = New System.Drawing.Size(117, 15)
        Me.lblLoopDelay.TabIndex = 1
        Me.lblLoopDelay.Text = "Chu kỳ quét màu (ms)"
        '
        'numLoopDelay
        '
        Me.numLoopDelay.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.numLoopDelay.Increment = New Decimal(New Integer() {50, 0, 0, 0})
        Me.numLoopDelay.Location = New System.Drawing.Point(195, 42)
        Me.numLoopDelay.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.numLoopDelay.Minimum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.numLoopDelay.Name = "numLoopDelay"
        Me.numLoopDelay.Size = New System.Drawing.Size(120, 23)
        Me.numLoopDelay.TabIndex = 0
        Me.numLoopDelay.Value = New Decimal(New Integer() {300, 0, 0, 0})
        '
        'TabPageAbout
        '
        Me.TabPageAbout.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.TabPageAbout.Controls.Add(Me.txtAbout)
        Me.TabPageAbout.Location = New System.Drawing.Point(4, 24)
        Me.TabPageAbout.Name = "TabPageAbout"
        Me.TabPageAbout.Padding = New System.Windows.Forms.Padding(12)
        Me.TabPageAbout.Size = New System.Drawing.Size(752, 424)
        Me.TabPageAbout.TabIndex = 2
        Me.TabPageAbout.Text = "Thông tin"
        '
        'txtAbout
        '
        Me.txtAbout.BackColor = System.Drawing.Color.White
        Me.txtAbout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAbout.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtAbout.Location = New System.Drawing.Point(18, 18)
        Me.txtAbout.Multiline = True
        Me.txtAbout.Name = "txtAbout"
        Me.txtAbout.ReadOnly = True
        Me.txtAbout.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAbout.Size = New System.Drawing.Size(716, 387)
        Me.txtAbout.TabIndex = 0
        Me.txtAbout.Text = "FO4 Auto Click Panel" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bản này được chỉnh lại theo hướng giao diện điều khiển rõ ràng hơn, giống mô hình tool nhiều tab ở ảnh mẫu." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Các bước sử dụng:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Mở FIFA Online4 và vào đúng màn hình cần auto." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Đảm bảo game chạy 1280 x 720." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Kiểm tra các hành động tự động muốn bật ở tab Chức năng chính." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Chỉnh tốc độ quét và tốc độ click ở tab Cài đặt khác nếu cần." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Bấm Bắt đầu để chạy, và theo dõi trạng thái ở cuối tab." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Lưu ý: logic auto hiện tại vẫn dùng nhận diện màu theo tọa độ tuyệt đối, nên nếu UI game đổi bố cục thì cần sửa lại điểm màu tương ứng."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.TabControlMain)
        Me.Controls.Add(Me.pnlHeader)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = True
        Me.MinimizeBox = True
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FO4 Auto Click Panel"
        Me.TopMost = True
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.TabControlMain.ResumeLayout(False)
        Me.TabPageDashboard.ResumeLayout(False)
        Me.GroupBoxStatus.ResumeLayout(False)
        Me.GroupBoxStatus.PerformLayout()
        Me.GroupBoxAutomation.ResumeLayout(False)
        Me.GroupBoxAutomation.PerformLayout()
        Me.GroupBoxSession.ResumeLayout(False)
        Me.GroupBoxSession.PerformLayout()
        Me.TabPageSettings.ResumeLayout(False)
        Me.GroupBoxNotes.ResumeLayout(False)
        Me.GroupBoxWindow.ResumeLayout(False)
        Me.GroupBoxWindow.PerformLayout()
        Me.GroupBoxTiming.ResumeLayout(False)
        Me.GroupBoxTiming.PerformLayout()
        CType(Me.numTargetMatchCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numClickDelay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numLoopDelay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageAbout.ResumeLayout(False)
        Me.TabPageAbout.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents TimerDebug As Timer
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents TabControlMain As TabControl
    Friend WithEvents TabPageDashboard As TabPage
    Friend WithEvents GroupBoxStatus As GroupBox
    Friend WithEvents lblDebugColorValue As Label
    Friend WithEvents lblDebugColorTitle As Label
    Friend WithEvents lblDebugPointValue As Label
    Friend WithEvents lblDebugPointTitle As Label
    Friend WithEvents lblDetectedColorValue As Label
    Friend WithEvents lblDetectedColorTitle As Label
    Friend WithEvents lblLastActionValue As Label
    Friend WithEvents lblLastActionTitle As Label
    Friend WithEvents lblRunStateValue As Label
    Friend WithEvents lblRunStateTitle As Label
    Friend WithEvents GroupBoxAutomation As GroupBox
    Friend WithEvents chkEndMatchSpace As CheckBox
    Friend WithEvents chkConfirmSecondary As CheckBox
    Friend WithEvents chkConfirmPrimary As CheckBox
    Friend WithEvents chkManagerMenu2 As CheckBox
    Friend WithEvents chkHomeManager As CheckBox
    Friend WithEvents GroupBoxSession As GroupBox
    Friend WithEvents chkDebugRealtime As CheckBox
    Friend WithEvents btnSaveCoordinate As Button
    Friend WithEvents cmbCoordinateTarget As ComboBox
    Friend WithEvents lblCoordinateTarget As Label
    Friend WithEvents numTargetMatchCount As NumericUpDown
    Friend WithEvents lblTargetMatchHint As Label
    Friend WithEvents lblTargetMatchTitle As Label
    Friend WithEvents btnCheckWindow As Button
    Friend WithEvents btnRestart As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents lblResolutionValue As Label
    Friend WithEvents lblResolutionTitle As Label
    Friend WithEvents lblGameTitleValue As Label
    Friend WithEvents lblGameTitleTitle As Label
    Friend WithEvents TabPageSettings As TabPage
    Friend WithEvents GroupBoxNotes As GroupBox
    Friend WithEvents lblNotes As Label
    Friend WithEvents GroupBoxWindow As GroupBox
    Friend WithEvents chkAlwaysOnTop As CheckBox
    Friend WithEvents GroupBoxTiming As GroupBox
    Friend WithEvents lblClickDelay As Label
    Friend WithEvents numClickDelay As NumericUpDown
    Friend WithEvents lblLoopDelay As Label
    Friend WithEvents numLoopDelay As NumericUpDown
    Friend WithEvents TabPageAbout As TabPage
    Friend WithEvents txtAbout As TextBox
End Class
