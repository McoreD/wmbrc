Option Strict Off
Option Explicit On 

Friend Class frmWMbrC
    Inherits System.Windows.Forms.Form

    Dim booReady As Boolean = False
    Dim app As New McoreSystem.AppInfo
    Dim strCompressionInfo As String
    Dim strMovieName As String = "Type the movie title here..."
    Dim mWMEncoder As WMEncoderLib.WMEncoder = New WMEncoderLib.WMEncoder
    Dim Pro2 As WMEncoderLib.WMEncProfile2 = New WMEncoderLib.WMEncProfile2
    Dim ProColl As WMEncoderLib.IWMEncProfileCollection
    Dim Pro1 As WMEncoderLib.IWMEncProfile
    Dim mAudnc As WMEncoderLib.IWMEncAudienceObj
    Dim i As Short
    Dim x As Integer, y As Integer
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabSrcDest As System.Windows.Forms.TabPage
    Friend WithEvents gbSummary As System.Windows.Forms.GroupBox
    Friend WithEvents tabWMTypes As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tabCompress As System.Windows.Forms.TabPage
    Friend WithEvents nudCustomCDSize As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileTop As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveProfileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenLogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyVideoBitRateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyVideoBitRateToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEditLog As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TotalFramesCalculatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MovieResolutionCalculatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents WindowsMediaEncoderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowsMediaPlayerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HomePageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupportForumsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miHelpUpdates As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents VersionHistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelpAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents bwCheckUpdate As System.ComponentModel.BackgroundWorker
    Friend WithEvents nudVidHeight As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudVidWidth As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudFrameRate As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkMaintainAR As System.Windows.Forms.CheckBox
    Friend WithEvents btnResetAR As System.Windows.Forms.Button
    Dim intItem As Integer = 0


#Region "Windows Form Designer generated code "
    Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        Application.EnableVisualStyles()
        Application.DoEvents()
        InitializeComponent()
    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txtMovieName As System.Windows.Forms.TextBox
    Public WithEvents lblSeconds As System.Windows.Forms.Label
    Public WithEvents lblMinutes As System.Windows.Forms.Label
    Public WithEvents lblHours As System.Windows.Forms.Label
    Public WithEvents cboSecs As System.Windows.Forms.ComboBox
    Public WithEvents cboMins As System.Windows.Forms.ComboBox
    Public WithEvents cboHours As System.Windows.Forms.ComboBox
    Public WithEvents cboAudMode As System.Windows.Forms.ComboBox
    Public WithEvents cboVidMode As System.Windows.Forms.ComboBox
    Friend WithEvents nudPercent As System.Windows.Forms.NumericUpDown
    Public WithEvents lblKbps As System.Windows.Forms.Label
    Public WithEvents txtVideoQ As System.Windows.Forms.TextBox
    Public WithEvents lblVideoType As System.Windows.Forms.Label
    Friend WithEvents lblPercent As System.Windows.Forms.Label
    Public WithEvents cboAudioFormat As System.Windows.Forms.ComboBox
    Public WithEvents cboAudioCodec As System.Windows.Forms.ComboBox
    Public WithEvents cboVideoCodec As System.Windows.Forms.ComboBox
    Friend WithEvents chkInterlaced As System.Windows.Forms.CheckBox
    Friend WithEvents chkNonsquare As System.Windows.Forms.CheckBox
    Friend WithEvents nudVidQuality As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkSameVidIput As System.Windows.Forms.CheckBox
    Friend WithEvents optCustomFPS As System.Windows.Forms.RadioButton
    Friend WithEvents optPAL As System.Windows.Forms.RadioButton
    Friend WithEvents optNTSC As System.Windows.Forms.RadioButton
    Friend WithEvents lblX As System.Windows.Forms.Label
    Public WithEvents lblFrameRate As System.Windows.Forms.Label
    Public WithEvents lblFPS As System.Windows.Forms.Label
    Public WithEvents cboCustomCDNumber As System.Windows.Forms.ComboBox
    Public WithEvents cboCDCDSize As System.Windows.Forms.ComboBox
    Public WithEvents cboCDCDNumber As System.Windows.Forms.ComboBox
    Public WithEvents lblOf2 As System.Windows.Forms.Label
    Public WithEvents lblMB As System.Windows.Forms.Label
    Public WithEvents lblOf As System.Windows.Forms.Label
    Public WithEvents optCD As System.Windows.Forms.RadioButton
    Public WithEvents optCustomSize As System.Windows.Forms.RadioButton
    Public WithEvents lblMovieTitle As System.Windows.Forms.Label
    Public WithEvents lblKeyFrameInt As System.Windows.Forms.Label
    Friend WithEvents txtKeyFrames As System.Windows.Forms.TextBox
    Friend WithEvents label5 As System.Windows.Forms.Label
    Public WithEvents txtVidBitRate As System.Windows.Forms.TextBox
    Friend WithEvents label4 As System.Windows.Forms.Label
    Public WithEvents txtAudBitRate As System.Windows.Forms.TextBox
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents lblMovieLength As System.Windows.Forms.Label
    Friend WithEvents txtMovieLength As System.Windows.Forms.TextBox
    Friend WithEvents txtFileSize As System.Windows.Forms.TextBox
    Friend WithEvents lblWarning As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWMbrC))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.nudPercent = New System.Windows.Forms.NumericUpDown
        Me.txtVideoQ = New System.Windows.Forms.TextBox
        Me.lblPercent = New System.Windows.Forms.Label
        Me.optCD = New System.Windows.Forms.RadioButton
        Me.optCustomSize = New System.Windows.Forms.RadioButton
        Me.chkMaintainAR = New System.Windows.Forms.CheckBox
        Me.label5 = New System.Windows.Forms.Label
        Me.txtVidBitRate = New System.Windows.Forms.TextBox
        Me.label4 = New System.Windows.Forms.Label
        Me.txtAudBitRate = New System.Windows.Forms.TextBox
        Me.label1 = New System.Windows.Forms.Label
        Me.lblMovieLength = New System.Windows.Forms.Label
        Me.txtMovieLength = New System.Windows.Forms.TextBox
        Me.txtFileSize = New System.Windows.Forms.TextBox
        Me.cboCDCDSize = New System.Windows.Forms.ComboBox
        Me.cboCDCDNumber = New System.Windows.Forms.ComboBox
        Me.lblOf = New System.Windows.Forms.Label
        Me.lblOf2 = New System.Windows.Forms.Label
        Me.lblMB = New System.Windows.Forms.Label
        Me.cboCustomCDNumber = New System.Windows.Forms.ComboBox
        Me.lblMovieTitle = New System.Windows.Forms.Label
        Me.lblSeconds = New System.Windows.Forms.Label
        Me.lblMinutes = New System.Windows.Forms.Label
        Me.lblHours = New System.Windows.Forms.Label
        Me.cboSecs = New System.Windows.Forms.ComboBox
        Me.cboMins = New System.Windows.Forms.ComboBox
        Me.cboHours = New System.Windows.Forms.ComboBox
        Me.txtMovieName = New System.Windows.Forms.TextBox
        Me.lblWarning = New System.Windows.Forms.Label
        Me.chkNonsquare = New System.Windows.Forms.CheckBox
        Me.chkInterlaced = New System.Windows.Forms.CheckBox
        Me.optCustomFPS = New System.Windows.Forms.RadioButton
        Me.optPAL = New System.Windows.Forms.RadioButton
        Me.optNTSC = New System.Windows.Forms.RadioButton
        Me.cboVideoCodec = New System.Windows.Forms.ComboBox
        Me.cboAudioCodec = New System.Windows.Forms.ComboBox
        Me.cboAudMode = New System.Windows.Forms.ComboBox
        Me.cboVidMode = New System.Windows.Forms.ComboBox
        Me.txtKeyFrames = New System.Windows.Forms.TextBox
        Me.lblKeyFrameInt = New System.Windows.Forms.Label
        Me.lblFPS = New System.Windows.Forms.Label
        Me.lblFrameRate = New System.Windows.Forms.Label
        Me.chkSameVidIput = New System.Windows.Forms.CheckBox
        Me.lblX = New System.Windows.Forms.Label
        Me.lblKbps = New System.Windows.Forms.Label
        Me.cboAudioFormat = New System.Windows.Forms.ComboBox
        Me.lblVideoType = New System.Windows.Forms.Label
        Me.nudVidQuality = New System.Windows.Forms.NumericUpDown
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tabSrcDest = New System.Windows.Forms.TabPage
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.nudCustomCDSize = New System.Windows.Forms.NumericUpDown
        Me.tabWMTypes = New System.Windows.Forms.TabPage
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.tabCompress = New System.Windows.Forms.TabPage
        Me.nudFrameRate = New System.Windows.Forms.NumericUpDown
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.btnResetAR = New System.Windows.Forms.Button
        Me.nudVidHeight = New System.Windows.Forms.NumericUpDown
        Me.nudVidWidth = New System.Windows.Forms.NumericUpDown
        Me.gbSummary = New System.Windows.Forms.GroupBox
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFileTop = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CopyVideoBitRateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CopyVideoBitRateToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuEditLog = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TotalFramesCalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MovieResolutionCalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.WindowsMediaEncoderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.WindowsMediaPlayerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HomePageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SupportForumsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.miHelpUpdates = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.VersionHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuHelpAbout = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.bwCheckUpdate = New System.ComponentModel.BackgroundWorker
        CType(Me.nudPercent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudVidQuality, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.tabSrcDest.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.nudCustomCDSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabWMTypes.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.tabCompress.SuspendLayout()
        CType(Me.nudFrameRate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.nudVidHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudVidWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbSummary.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'nudPercent
        '
        Me.nudPercent.BackColor = System.Drawing.SystemColors.Window
        Me.nudPercent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudPercent.Location = New System.Drawing.Point(292, 147)
        Me.nudPercent.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.nudPercent.Minimum = New Decimal(New Integer() {9, 0, 0, -2147483648})
        Me.nudPercent.Name = "nudPercent"
        Me.nudPercent.ReadOnly = True
        Me.nudPercent.Size = New System.Drawing.Size(32, 20)
        Me.nudPercent.TabIndex = 26
        Me.ToolTip1.SetToolTip(Me.nudPercent, " Percentage Error ")
        Me.nudPercent.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtVideoQ
        '
        Me.txtVideoQ.AcceptsReturn = True
        Me.txtVideoQ.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVideoQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVideoQ.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtVideoQ.Location = New System.Drawing.Point(116, 147)
        Me.txtVideoQ.MaxLength = 0
        Me.txtVideoQ.Name = "txtVideoQ"
        Me.txtVideoQ.ReadOnly = True
        Me.txtVideoQ.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtVideoQ.Size = New System.Drawing.Size(116, 20)
        Me.txtVideoQ.TabIndex = 25
        Me.txtVideoQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtVideoQ, " Press Ctrl + C to Copy ")
        '
        'lblPercent
        '
        Me.lblPercent.AutoSize = True
        Me.lblPercent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercent.Location = New System.Drawing.Point(330, 150)
        Me.lblPercent.Name = "lblPercent"
        Me.lblPercent.Size = New System.Drawing.Size(15, 13)
        Me.lblPercent.TabIndex = 30
        Me.lblPercent.Text = "%"
        Me.ToolTip1.SetToolTip(Me.lblPercent, " Percentage Error ")
        '
        'optCD
        '
        Me.optCD.BackColor = System.Drawing.SystemColors.Control
        Me.optCD.Checked = True
        Me.optCD.Cursor = System.Windows.Forms.Cursors.Default
        Me.optCD.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.optCD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optCD.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optCD.Location = New System.Drawing.Point(12, 19)
        Me.optCD.Name = "optCD"
        Me.optCD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optCD.Size = New System.Drawing.Size(145, 16)
        Me.optCD.TabIndex = 40
        Me.optCD.TabStop = True
        Me.optCD.Text = "Disk Size Based"
        Me.ToolTip1.SetToolTip(Me.optCD, " Useful in Data CD/DVD Creation ")
        Me.optCD.UseVisualStyleBackColor = False
        '
        'optCustomSize
        '
        Me.optCustomSize.BackColor = System.Drawing.SystemColors.Control
        Me.optCustomSize.Cursor = System.Windows.Forms.Cursors.Default
        Me.optCustomSize.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.optCustomSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optCustomSize.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optCustomSize.Location = New System.Drawing.Point(241, 18)
        Me.optCustomSize.Name = "optCustomSize"
        Me.optCustomSize.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optCustomSize.Size = New System.Drawing.Size(129, 17)
        Me.optCustomSize.TabIndex = 43
        Me.optCustomSize.Text = "Custom Size Based"
        Me.ToolTip1.SetToolTip(Me.optCustomSize, " Useful in VCD/SVCD Creation ")
        Me.optCustomSize.UseVisualStyleBackColor = False
        '
        'chkMaintainAR
        '
        Me.chkMaintainAR.AutoSize = True
        Me.chkMaintainAR.Location = New System.Drawing.Point(264, 23)
        Me.chkMaintainAR.Name = "chkMaintainAR"
        Me.chkMaintainAR.Size = New System.Drawing.Size(41, 17)
        Me.chkMaintainAR.TabIndex = 41
        Me.chkMaintainAR.Text = "AR"
        Me.ToolTip1.SetToolTip(Me.chkMaintainAR, "Maintain Aspect Ratio")
        Me.chkMaintainAR.UseVisualStyleBackColor = True
        '
        'label5
        '
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(355, 25)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(95, 16)
        Me.label5.TabIndex = 67
        Me.label5.Text = "Video (Kibit/s)"
        '
        'txtVidBitRate
        '
        Me.txtVidBitRate.AcceptsReturn = True
        Me.txtVidBitRate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVidBitRate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVidBitRate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtVidBitRate.Location = New System.Drawing.Point(358, 44)
        Me.txtVidBitRate.MaxLength = 4
        Me.txtVidBitRate.Name = "txtVidBitRate"
        Me.txtVidBitRate.ReadOnly = True
        Me.txtVidBitRate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtVidBitRate.Size = New System.Drawing.Size(84, 20)
        Me.txtVidBitRate.TabIndex = 66
        Me.txtVidBitRate.TabStop = False
        '
        'label4
        '
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(249, 25)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(95, 16)
        Me.label4.TabIndex = 65
        Me.label4.Text = "Audio (Kibit/s)"
        '
        'txtAudBitRate
        '
        Me.txtAudBitRate.AcceptsReturn = True
        Me.txtAudBitRate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAudBitRate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAudBitRate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAudBitRate.Location = New System.Drawing.Point(249, 45)
        Me.txtAudBitRate.MaxLength = 4
        Me.txtAudBitRate.Name = "txtAudBitRate"
        Me.txtAudBitRate.ReadOnly = True
        Me.txtAudBitRate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAudBitRate.Size = New System.Drawing.Size(84, 20)
        Me.txtAudBitRate.TabIndex = 64
        Me.txtAudBitRate.TabStop = False
        '
        'label1
        '
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(119, 25)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(100, 16)
        Me.label1.TabIndex = 63
        Me.label1.Text = "File Size (MiB)"
        '
        'lblMovieLength
        '
        Me.lblMovieLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMovieLength.Location = New System.Drawing.Point(15, 25)
        Me.lblMovieLength.Name = "lblMovieLength"
        Me.lblMovieLength.Size = New System.Drawing.Size(100, 16)
        Me.lblMovieLength.TabIndex = 62
        Me.lblMovieLength.Text = "Length (seconds)"
        '
        'txtMovieLength
        '
        Me.txtMovieLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMovieLength.Location = New System.Drawing.Point(15, 45)
        Me.txtMovieLength.Name = "txtMovieLength"
        Me.txtMovieLength.ReadOnly = True
        Me.txtMovieLength.Size = New System.Drawing.Size(96, 20)
        Me.txtMovieLength.TabIndex = 61
        Me.txtMovieLength.TabStop = False
        '
        'txtFileSize
        '
        Me.txtFileSize.AcceptsReturn = True
        Me.txtFileSize.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFileSize.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFileSize.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFileSize.Location = New System.Drawing.Point(122, 44)
        Me.txtFileSize.MaxLength = 4
        Me.txtFileSize.Name = "txtFileSize"
        Me.txtFileSize.ReadOnly = True
        Me.txtFileSize.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFileSize.Size = New System.Drawing.Size(96, 20)
        Me.txtFileSize.TabIndex = 60
        Me.txtFileSize.TabStop = False
        '
        'cboCDCDSize
        '
        Me.cboCDCDSize.BackColor = System.Drawing.SystemColors.Window
        Me.cboCDCDSize.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboCDCDSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCDCDSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCDCDSize.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboCDCDSize.Location = New System.Drawing.Point(132, 42)
        Me.cboCDCDSize.Name = "cboCDCDSize"
        Me.cboCDCDSize.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboCDCDSize.Size = New System.Drawing.Size(81, 21)
        Me.cboCDCDSize.TabIndex = 42
        '
        'cboCDCDNumber
        '
        Me.cboCDCDNumber.BackColor = System.Drawing.SystemColors.Window
        Me.cboCDCDNumber.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboCDCDNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCDCDNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCDCDNumber.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboCDCDNumber.Location = New System.Drawing.Point(12, 42)
        Me.cboCDCDNumber.Name = "cboCDCDNumber"
        Me.cboCDCDNumber.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboCDCDNumber.Size = New System.Drawing.Size(89, 21)
        Me.cboCDCDNumber.TabIndex = 41
        '
        'lblOf
        '
        Me.lblOf.AutoSize = True
        Me.lblOf.BackColor = System.Drawing.Color.Transparent
        Me.lblOf.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblOf.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOf.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblOf.Location = New System.Drawing.Point(107, 45)
        Me.lblOf.Name = "lblOf"
        Me.lblOf.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblOf.Size = New System.Drawing.Size(18, 16)
        Me.lblOf.TabIndex = 46
        Me.lblOf.Text = "of"
        '
        'lblOf2
        '
        Me.lblOf2.AutoSize = True
        Me.lblOf2.BackColor = System.Drawing.Color.Transparent
        Me.lblOf2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblOf2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOf2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblOf2.Location = New System.Drawing.Point(336, 44)
        Me.lblOf2.Name = "lblOf2"
        Me.lblOf2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblOf2.Size = New System.Drawing.Size(18, 16)
        Me.lblOf2.TabIndex = 50
        Me.lblOf2.Text = "of"
        '
        'lblMB
        '
        Me.lblMB.AutoSize = True
        Me.lblMB.BackColor = System.Drawing.Color.Transparent
        Me.lblMB.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMB.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMB.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMB.Location = New System.Drawing.Point(423, 44)
        Me.lblMB.Name = "lblMB"
        Me.lblMB.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMB.Size = New System.Drawing.Size(24, 14)
        Me.lblMB.TabIndex = 47
        Me.lblMB.Text = "MiB"
        '
        'cboCustomCDNumber
        '
        Me.cboCustomCDNumber.BackColor = System.Drawing.SystemColors.Window
        Me.cboCustomCDNumber.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboCustomCDNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCustomCDNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCustomCDNumber.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboCustomCDNumber.Location = New System.Drawing.Point(241, 41)
        Me.cboCustomCDNumber.Name = "cboCustomCDNumber"
        Me.cboCustomCDNumber.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboCustomCDNumber.Size = New System.Drawing.Size(89, 21)
        Me.cboCustomCDNumber.TabIndex = 44
        '
        'lblMovieTitle
        '
        Me.lblMovieTitle.AutoSize = True
        Me.lblMovieTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblMovieTitle.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMovieTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMovieTitle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMovieTitle.Location = New System.Drawing.Point(243, 25)
        Me.lblMovieTitle.Name = "lblMovieTitle"
        Me.lblMovieTitle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMovieTitle.Size = New System.Drawing.Size(59, 13)
        Me.lblMovieTitle.TabIndex = 19
        Me.lblMovieTitle.Text = "Movie Title"
        '
        'lblSeconds
        '
        Me.lblSeconds.AutoSize = True
        Me.lblSeconds.BackColor = System.Drawing.Color.Transparent
        Me.lblSeconds.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSeconds.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeconds.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSeconds.Location = New System.Drawing.Point(153, 25)
        Me.lblSeconds.Name = "lblSeconds"
        Me.lblSeconds.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSeconds.Size = New System.Drawing.Size(49, 13)
        Me.lblSeconds.TabIndex = 16
        Me.lblSeconds.Text = "Seconds"
        '
        'lblMinutes
        '
        Me.lblMinutes.AutoSize = True
        Me.lblMinutes.BackColor = System.Drawing.Color.Transparent
        Me.lblMinutes.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMinutes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinutes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMinutes.Location = New System.Drawing.Point(81, 25)
        Me.lblMinutes.Name = "lblMinutes"
        Me.lblMinutes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMinutes.Size = New System.Drawing.Size(44, 13)
        Me.lblMinutes.TabIndex = 15
        Me.lblMinutes.Text = "Minutes"
        '
        'lblHours
        '
        Me.lblHours.AutoSize = True
        Me.lblHours.BackColor = System.Drawing.Color.Transparent
        Me.lblHours.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHours.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblHours.Location = New System.Drawing.Point(9, 25)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblHours.Size = New System.Drawing.Size(35, 13)
        Me.lblHours.TabIndex = 14
        Me.lblHours.Text = "Hours"
        '
        'cboSecs
        '
        Me.cboSecs.BackColor = System.Drawing.SystemColors.Window
        Me.cboSecs.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboSecs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSecs.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboSecs.Location = New System.Drawing.Point(156, 41)
        Me.cboSecs.MaxLength = 2
        Me.cboSecs.Name = "cboSecs"
        Me.cboSecs.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboSecs.Size = New System.Drawing.Size(57, 21)
        Me.cboSecs.TabIndex = 2
        '
        'cboMins
        '
        Me.cboMins.BackColor = System.Drawing.SystemColors.Window
        Me.cboMins.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboMins.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMins.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboMins.Location = New System.Drawing.Point(85, 41)
        Me.cboMins.MaxLength = 2
        Me.cboMins.Name = "cboMins"
        Me.cboMins.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboMins.Size = New System.Drawing.Size(56, 21)
        Me.cboMins.TabIndex = 1
        '
        'cboHours
        '
        Me.cboHours.BackColor = System.Drawing.SystemColors.Window
        Me.cboHours.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboHours.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboHours.Location = New System.Drawing.Point(12, 41)
        Me.cboHours.MaxLength = 2
        Me.cboHours.Name = "cboHours"
        Me.cboHours.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboHours.Size = New System.Drawing.Size(58, 21)
        Me.cboHours.TabIndex = 0
        '
        'txtMovieName
        '
        Me.txtMovieName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMovieName.Location = New System.Drawing.Point(249, 41)
        Me.txtMovieName.Name = "txtMovieName"
        Me.txtMovieName.Size = New System.Drawing.Size(198, 20)
        Me.txtMovieName.TabIndex = 18
        '
        'lblWarning
        '
        Me.lblWarning.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWarning.ForeColor = System.Drawing.Color.Red
        Me.lblWarning.Location = New System.Drawing.Point(56, 414)
        Me.lblWarning.Name = "lblWarning"
        Me.lblWarning.Size = New System.Drawing.Size(437, 35)
        Me.lblWarning.TabIndex = 37
        Me.lblWarning.Text = "Label6"
        '
        'chkNonsquare
        '
        Me.chkNonsquare.AutoSize = True
        Me.chkNonsquare.Checked = True
        Me.chkNonsquare.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNonsquare.Location = New System.Drawing.Point(216, 147)
        Me.chkNonsquare.Name = "chkNonsquare"
        Me.chkNonsquare.Size = New System.Drawing.Size(161, 17)
        Me.chkNonsquare.TabIndex = 35
        Me.chkNonsquare.Text = "Allow nons&quare pixel output"
        '
        'chkInterlaced
        '
        Me.chkInterlaced.AutoSize = True
        Me.chkInterlaced.Location = New System.Drawing.Point(18, 147)
        Me.chkInterlaced.Name = "chkInterlaced"
        Me.chkInterlaced.Size = New System.Drawing.Size(154, 17)
        Me.chkInterlaced.TabIndex = 34
        Me.chkInterlaced.Text = "Allow &interlaced processing"
        '
        'optCustomFPS
        '
        Me.optCustomFPS.AutoSize = True
        Me.optCustomFPS.Checked = True
        Me.optCustomFPS.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.optCustomFPS.Location = New System.Drawing.Point(262, 19)
        Me.optCustomFPS.Name = "optCustomFPS"
        Me.optCustomFPS.Size = New System.Drawing.Size(66, 18)
        Me.optCustomFPS.TabIndex = 33
        Me.optCustomFPS.TabStop = True
        Me.optCustomFPS.Text = "C&ustom"
        '
        'optPAL
        '
        Me.optPAL.AutoSize = True
        Me.optPAL.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.optPAL.Location = New System.Drawing.Point(151, 19)
        Me.optPAL.Name = "optPAL"
        Me.optPAL.Size = New System.Drawing.Size(89, 18)
        Me.optPAL.TabIndex = 31
        Me.optPAL.Text = "P&AL (25 fps)"
        '
        'optNTSC
        '
        Me.optNTSC.AutoSize = True
        Me.optNTSC.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.optNTSC.Location = New System.Drawing.Point(15, 19)
        Me.optNTSC.Name = "optNTSC"
        Me.optNTSC.Size = New System.Drawing.Size(130, 18)
        Me.optNTSC.TabIndex = 30
        Me.optNTSC.Text = "NT&SC (29.97/30 fps)"
        '
        'cboVideoCodec
        '
        Me.cboVideoCodec.BackColor = System.Drawing.SystemColors.Window
        Me.cboVideoCodec.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboVideoCodec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVideoCodec.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVideoCodec.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboVideoCodec.Location = New System.Drawing.Point(146, 19)
        Me.cboVideoCodec.Name = "cboVideoCodec"
        Me.cboVideoCodec.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboVideoCodec.Size = New System.Drawing.Size(301, 22)
        Me.cboVideoCodec.TabIndex = 29
        '
        'cboAudioCodec
        '
        Me.cboAudioCodec.BackColor = System.Drawing.SystemColors.Window
        Me.cboAudioCodec.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboAudioCodec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAudioCodec.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAudioCodec.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboAudioCodec.Location = New System.Drawing.Point(146, 19)
        Me.cboAudioCodec.Name = "cboAudioCodec"
        Me.cboAudioCodec.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboAudioCodec.Size = New System.Drawing.Size(301, 22)
        Me.cboAudioCodec.TabIndex = 28
        '
        'cboAudMode
        '
        Me.cboAudMode.BackColor = System.Drawing.SystemColors.Window
        Me.cboAudMode.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboAudMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAudMode.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAudMode.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboAudMode.Location = New System.Drawing.Point(12, 19)
        Me.cboAudMode.Name = "cboAudMode"
        Me.cboAudMode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboAudMode.Size = New System.Drawing.Size(128, 22)
        Me.cboAudMode.TabIndex = 27
        '
        'cboVidMode
        '
        Me.cboVidMode.BackColor = System.Drawing.SystemColors.Window
        Me.cboVidMode.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboVidMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVidMode.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVidMode.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboVidMode.Location = New System.Drawing.Point(12, 19)
        Me.cboVidMode.Name = "cboVidMode"
        Me.cboVidMode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboVidMode.Size = New System.Drawing.Size(128, 22)
        Me.cboVidMode.TabIndex = 26
        '
        'txtKeyFrames
        '
        Me.txtKeyFrames.Location = New System.Drawing.Point(390, 120)
        Me.txtKeyFrames.Name = "txtKeyFrames"
        Me.txtKeyFrames.Size = New System.Drawing.Size(64, 20)
        Me.txtKeyFrames.TabIndex = 42
        Me.txtKeyFrames.Text = "4"
        '
        'lblKeyFrameInt
        '
        Me.lblKeyFrameInt.AutoSize = True
        Me.lblKeyFrameInt.BackColor = System.Drawing.Color.Transparent
        Me.lblKeyFrameInt.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblKeyFrameInt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKeyFrameInt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblKeyFrameInt.Location = New System.Drawing.Point(280, 124)
        Me.lblKeyFrameInt.Name = "lblKeyFrameInt"
        Me.lblKeyFrameInt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblKeyFrameInt.Size = New System.Drawing.Size(94, 13)
        Me.lblKeyFrameInt.TabIndex = 41
        Me.lblKeyFrameInt.Text = "Key frame interval:"
        '
        'lblFPS
        '
        Me.lblFPS.BackColor = System.Drawing.Color.Transparent
        Me.lblFPS.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFPS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFPS.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblFPS.Location = New System.Drawing.Point(186, 124)
        Me.lblFPS.Name = "lblFPS"
        Me.lblFPS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFPS.Size = New System.Drawing.Size(40, 16)
        Me.lblFPS.TabIndex = 40
        Me.lblFPS.Text = "fps"
        '
        'lblFrameRate
        '
        Me.lblFrameRate.AutoSize = True
        Me.lblFrameRate.BackColor = System.Drawing.Color.Transparent
        Me.lblFrameRate.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFrameRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrameRate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblFrameRate.Location = New System.Drawing.Point(18, 124)
        Me.lblFrameRate.Name = "lblFrameRate"
        Me.lblFrameRate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFrameRate.Size = New System.Drawing.Size(60, 13)
        Me.lblFrameRate.TabIndex = 38
        Me.lblFrameRate.Text = "Frame rate:"
        '
        'chkSameVidIput
        '
        Me.chkSameVidIput.AutoSize = True
        Me.chkSameVidIput.Location = New System.Drawing.Point(326, 23)
        Me.chkSameVidIput.Name = "chkSameVidIput"
        Me.chkSameVidIput.Size = New System.Drawing.Size(122, 17)
        Me.chkSameVidIput.TabIndex = 37
        Me.chkSameVidIput.Text = "Same as video i&nput"
        '
        'lblX
        '
        Me.lblX.AutoSize = True
        Me.lblX.Location = New System.Drawing.Point(89, 22)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(12, 13)
        Me.lblX.TabIndex = 36
        Me.lblX.Text = "x"
        '
        'lblKbps
        '
        Me.lblKbps.AutoSize = True
        Me.lblKbps.BackColor = System.Drawing.Color.Transparent
        Me.lblKbps.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblKbps.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKbps.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblKbps.Location = New System.Drawing.Point(238, 149)
        Me.lblKbps.Name = "lblKbps"
        Me.lblKbps.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblKbps.Size = New System.Drawing.Size(36, 14)
        Me.lblKbps.TabIndex = 29
        Me.lblKbps.Text = "Kibit/s"
        '
        'cboAudioFormat
        '
        Me.cboAudioFormat.BackColor = System.Drawing.SystemColors.Window
        Me.cboAudioFormat.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboAudioFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAudioFormat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAudioFormat.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboAudioFormat.Location = New System.Drawing.Point(146, 47)
        Me.cboAudioFormat.Name = "cboAudioFormat"
        Me.cboAudioFormat.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboAudioFormat.Size = New System.Drawing.Size(301, 21)
        Me.cboAudioFormat.TabIndex = 24
        '
        'lblVideoType
        '
        Me.lblVideoType.AutoSize = True
        Me.lblVideoType.BackColor = System.Drawing.Color.Transparent
        Me.lblVideoType.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblVideoType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVideoType.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblVideoType.Location = New System.Drawing.Point(18, 150)
        Me.lblVideoType.Name = "lblVideoType"
        Me.lblVideoType.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblVideoType.Size = New System.Drawing.Size(74, 13)
        Me.lblVideoType.TabIndex = 28
        Me.lblVideoType.Text = "Video bit Rate"
        '
        'nudVidQuality
        '
        Me.nudVidQuality.Location = New System.Drawing.Point(116, 147)
        Me.nudVidQuality.Name = "nudVidQuality"
        Me.nudVidQuality.Size = New System.Drawing.Size(104, 20)
        Me.nudVidQuality.TabIndex = 31
        Me.nudVidQuality.Value = New Decimal(New Integer() {90, 0, 0, 0})
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabSrcDest)
        Me.TabControl1.Controls.Add(Me.tabWMTypes)
        Me.TabControl1.Controls.Add(Me.tabCompress)
        Me.TabControl1.Location = New System.Drawing.Point(12, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(488, 206)
        Me.TabControl1.TabIndex = 19
        '
        'tabSrcDest
        '
        Me.tabSrcDest.Controls.Add(Me.GroupBox3)
        Me.tabSrcDest.Controls.Add(Me.GroupBox2)
        Me.tabSrcDest.Location = New System.Drawing.Point(4, 22)
        Me.tabSrcDest.Name = "tabSrcDest"
        Me.tabSrcDest.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSrcDest.Size = New System.Drawing.Size(480, 180)
        Me.tabSrcDest.TabIndex = 0
        Me.tabSrcDest.Text = "Source/Target File Details"
        Me.tabSrcDest.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblMovieTitle)
        Me.GroupBox3.Controls.Add(Me.cboHours)
        Me.GroupBox3.Controls.Add(Me.lblSeconds)
        Me.GroupBox3.Controls.Add(Me.txtMovieName)
        Me.GroupBox3.Controls.Add(Me.lblMinutes)
        Me.GroupBox3.Controls.Add(Me.lblHours)
        Me.GroupBox3.Controls.Add(Me.cboSecs)
        Me.GroupBox3.Controls.Add(Me.cboMins)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(458, 79)
        Me.GroupBox3.TabIndex = 53
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Movie Information"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.optCD)
        Me.GroupBox2.Controls.Add(Me.cboCDCDNumber)
        Me.GroupBox2.Controls.Add(Me.nudCustomCDSize)
        Me.GroupBox2.Controls.Add(Me.cboCustomCDNumber)
        Me.GroupBox2.Controls.Add(Me.cboCDCDSize)
        Me.GroupBox2.Controls.Add(Me.lblMB)
        Me.GroupBox2.Controls.Add(Me.lblOf2)
        Me.GroupBox2.Controls.Add(Me.lblOf)
        Me.GroupBox2.Controls.Add(Me.optCustomSize)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 91)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(458, 77)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Target File Size"
        '
        'nudCustomCDSize
        '
        Me.nudCustomCDSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudCustomCDSize.Location = New System.Drawing.Point(361, 42)
        Me.nudCustomCDSize.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.nudCustomCDSize.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudCustomCDSize.Name = "nudCustomCDSize"
        Me.nudCustomCDSize.Size = New System.Drawing.Size(56, 20)
        Me.nudCustomCDSize.TabIndex = 51
        Me.nudCustomCDSize.Value = New Decimal(New Integer() {797, 0, 0, 0})
        '
        'tabWMTypes
        '
        Me.tabWMTypes.Controls.Add(Me.GroupBox7)
        Me.tabWMTypes.Controls.Add(Me.GroupBox6)
        Me.tabWMTypes.Controls.Add(Me.chkNonsquare)
        Me.tabWMTypes.Controls.Add(Me.chkInterlaced)
        Me.tabWMTypes.Location = New System.Drawing.Point(4, 22)
        Me.tabWMTypes.Name = "tabWMTypes"
        Me.tabWMTypes.Padding = New System.Windows.Forms.Padding(3)
        Me.tabWMTypes.Size = New System.Drawing.Size(480, 180)
        Me.tabWMTypes.TabIndex = 1
        Me.tabWMTypes.Text = "Compression Settings"
        Me.tabWMTypes.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.cboVidMode)
        Me.GroupBox7.Controls.Add(Me.cboVideoCodec)
        Me.GroupBox7.Location = New System.Drawing.Point(6, 91)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(458, 50)
        Me.GroupBox7.TabIndex = 39
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Video"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.cboAudMode)
        Me.GroupBox6.Controls.Add(Me.cboAudioCodec)
        Me.GroupBox6.Controls.Add(Me.cboAudioFormat)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(458, 79)
        Me.GroupBox6.TabIndex = 38
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Audio"
        '
        'tabCompress
        '
        Me.tabCompress.Controls.Add(Me.nudFrameRate)
        Me.tabCompress.Controls.Add(Me.GroupBox4)
        Me.tabCompress.Controls.Add(Me.GroupBox5)
        Me.tabCompress.Controls.Add(Me.txtKeyFrames)
        Me.tabCompress.Controls.Add(Me.txtVideoQ)
        Me.tabCompress.Controls.Add(Me.lblKeyFrameInt)
        Me.tabCompress.Controls.Add(Me.lblFPS)
        Me.tabCompress.Controls.Add(Me.nudVidQuality)
        Me.tabCompress.Controls.Add(Me.lblPercent)
        Me.tabCompress.Controls.Add(Me.lblFrameRate)
        Me.tabCompress.Controls.Add(Me.lblVideoType)
        Me.tabCompress.Controls.Add(Me.lblKbps)
        Me.tabCompress.Controls.Add(Me.nudPercent)
        Me.tabCompress.Location = New System.Drawing.Point(4, 22)
        Me.tabCompress.Name = "tabCompress"
        Me.tabCompress.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCompress.Size = New System.Drawing.Size(480, 180)
        Me.tabCompress.TabIndex = 2
        Me.tabCompress.Text = "Advanced"
        Me.tabCompress.UseVisualStyleBackColor = True
        '
        'nudFrameRate
        '
        Me.nudFrameRate.Location = New System.Drawing.Point(116, 121)
        Me.nudFrameRate.Name = "nudFrameRate"
        Me.nudFrameRate.Size = New System.Drawing.Size(64, 20)
        Me.nudFrameRate.TabIndex = 40
        Me.nudFrameRate.Value = New Decimal(New Integer() {25, 0, 0, 0})
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.optCustomFPS)
        Me.GroupBox4.Controls.Add(Me.optPAL)
        Me.GroupBox4.Controls.Add(Me.optNTSC)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(458, 46)
        Me.GroupBox4.TabIndex = 38
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Video Format"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.chkMaintainAR)
        Me.GroupBox5.Controls.Add(Me.btnResetAR)
        Me.GroupBox5.Controls.Add(Me.nudVidHeight)
        Me.GroupBox5.Controls.Add(Me.nudVidWidth)
        Me.GroupBox5.Controls.Add(Me.chkSameVidIput)
        Me.GroupBox5.Controls.Add(Me.lblX)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 58)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(458, 56)
        Me.GroupBox5.TabIndex = 43
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Video Size"
        '
        'btnResetAR
        '
        Me.btnResetAR.Location = New System.Drawing.Point(183, 19)
        Me.btnResetAR.Name = "btnResetAR"
        Me.btnResetAR.Size = New System.Drawing.Size(75, 23)
        Me.btnResetAR.TabIndex = 40
        Me.btnResetAR.Text = "Reset AR"
        Me.btnResetAR.UseVisualStyleBackColor = True
        '
        'nudVidHeight
        '
        Me.nudVidHeight.Location = New System.Drawing.Point(107, 21)
        Me.nudVidHeight.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.nudVidHeight.Name = "nudVidHeight"
        Me.nudVidHeight.Size = New System.Drawing.Size(64, 20)
        Me.nudVidHeight.TabIndex = 39
        Me.nudVidHeight.Value = New Decimal(New Integer() {576, 0, 0, 0})
        '
        'nudVidWidth
        '
        Me.nudVidWidth.Location = New System.Drawing.Point(19, 21)
        Me.nudVidWidth.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.nudVidWidth.Minimum = New Decimal(New Integer() {160, 0, 0, 0})
        Me.nudVidWidth.Name = "nudVidWidth"
        Me.nudVidWidth.Size = New System.Drawing.Size(64, 20)
        Me.nudVidWidth.TabIndex = 38
        Me.nudVidWidth.Value = New Decimal(New Integer() {720, 0, 0, 0})
        '
        'gbSummary
        '
        Me.gbSummary.Controls.Add(Me.label5)
        Me.gbSummary.Controls.Add(Me.txtFileSize)
        Me.gbSummary.Controls.Add(Me.txtVidBitRate)
        Me.gbSummary.Controls.Add(Me.txtMovieLength)
        Me.gbSummary.Controls.Add(Me.label4)
        Me.gbSummary.Controls.Add(Me.lblMovieLength)
        Me.gbSummary.Controls.Add(Me.txtAudBitRate)
        Me.gbSummary.Controls.Add(Me.label1)
        Me.gbSummary.Location = New System.Drawing.Point(12, 239)
        Me.gbSummary.Name = "gbSummary"
        Me.gbSummary.Size = New System.Drawing.Size(484, 79)
        Me.gbSummary.TabIndex = 0
        Me.gbSummary.TabStop = False
        Me.gbSummary.Text = "Summary"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileTop, Me.SaveProfileToolStripMenuItem, Me.OpenLogToolStripMenuItem, Me.ToolStripSeparator3, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'mnuFileTop
        '
        Me.mnuFileTop.Name = "mnuFileTop"
        Me.mnuFileTop.Size = New System.Drawing.Size(184, 22)
        Me.mnuFileTop.Text = "Always On &Top"
        '
        'SaveProfileToolStripMenuItem
        '
        Me.SaveProfileToolStripMenuItem.Name = "SaveProfileToolStripMenuItem"
        Me.SaveProfileToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveProfileToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.SaveProfileToolStripMenuItem.Text = "&Save Profile..."
        '
        'OpenLogToolStripMenuItem
        '
        Me.OpenLogToolStripMenuItem.Name = "OpenLogToolStripMenuItem"
        Me.OpenLogToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenLogToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.OpenLogToolStripMenuItem.Text = "&Open Log..."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(181, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyVideoBitRateToolStripMenuItem, Me.CopyVideoBitRateToolStripMenuItem1, Me.mnuEditLog})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'CopyVideoBitRateToolStripMenuItem
        '
        Me.CopyVideoBitRateToolStripMenuItem.Name = "CopyVideoBitRateToolStripMenuItem"
        Me.CopyVideoBitRateToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyVideoBitRateToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.CopyVideoBitRateToolStripMenuItem.Text = "&Copy Video Bit Rate"
        '
        'CopyVideoBitRateToolStripMenuItem1
        '
        Me.CopyVideoBitRateToolStripMenuItem1.Name = "CopyVideoBitRateToolStripMenuItem1"
        Me.CopyVideoBitRateToolStripMenuItem1.Size = New System.Drawing.Size(220, 22)
        Me.CopyVideoBitRateToolStripMenuItem1.Text = "Save to Notepad"
        '
        'mnuEditLog
        '
        Me.mnuEditLog.Checked = True
        Me.mnuEditLog.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuEditLog.Name = "mnuEditLog"
        Me.mnuEditLog.Size = New System.Drawing.Size(220, 22)
        Me.mnuEditLog.Text = "Save to Log"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TotalFramesCalculatorToolStripMenuItem, Me.MovieResolutionCalculatorToolStripMenuItem, Me.ToolStripSeparator1, Me.WindowsMediaEncoderToolStripMenuItem, Me.WindowsMediaPlayerToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'TotalFramesCalculatorToolStripMenuItem
        '
        Me.TotalFramesCalculatorToolStripMenuItem.Name = "TotalFramesCalculatorToolStripMenuItem"
        Me.TotalFramesCalculatorToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.TotalFramesCalculatorToolStripMenuItem.Text = "Total Frames Calculator"
        '
        'MovieResolutionCalculatorToolStripMenuItem
        '
        Me.MovieResolutionCalculatorToolStripMenuItem.Name = "MovieResolutionCalculatorToolStripMenuItem"
        Me.MovieResolutionCalculatorToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.MovieResolutionCalculatorToolStripMenuItem.Text = "Movie Resolution Calculator"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(220, 6)
        '
        'WindowsMediaEncoderToolStripMenuItem
        '
        Me.WindowsMediaEncoderToolStripMenuItem.Name = "WindowsMediaEncoderToolStripMenuItem"
        Me.WindowsMediaEncoderToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.WindowsMediaEncoderToolStripMenuItem.Text = "Windows Media Encoder"
        '
        'WindowsMediaPlayerToolStripMenuItem
        '
        Me.WindowsMediaPlayerToolStripMenuItem.Name = "WindowsMediaPlayerToolStripMenuItem"
        Me.WindowsMediaPlayerToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.WindowsMediaPlayerToolStripMenuItem.Text = "Windows Media Player"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomePageToolStripMenuItem, Me.SupportForumsToolStripMenuItem, Me.miHelpUpdates, Me.ToolStripSeparator2, Me.VersionHistoryToolStripMenuItem, Me.mnuHelpAbout})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'HomePageToolStripMenuItem
        '
        Me.HomePageToolStripMenuItem.Name = "HomePageToolStripMenuItem"
        Me.HomePageToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.HomePageToolStripMenuItem.Text = "Home Page..."
        '
        'SupportForumsToolStripMenuItem
        '
        Me.SupportForumsToolStripMenuItem.Name = "SupportForumsToolStripMenuItem"
        Me.SupportForumsToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.SupportForumsToolStripMenuItem.Text = "Support Forums..."
        '
        'miHelpUpdates
        '
        Me.miHelpUpdates.Name = "miHelpUpdates"
        Me.miHelpUpdates.Size = New System.Drawing.Size(175, 22)
        Me.miHelpUpdates.Text = "&Check for Update..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(172, 6)
        '
        'VersionHistoryToolStripMenuItem
        '
        Me.VersionHistoryToolStripMenuItem.Name = "VersionHistoryToolStripMenuItem"
        Me.VersionHistoryToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.VersionHistoryToolStripMenuItem.Text = "&Version History..."
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Name = "mnuHelpAbout"
        Me.mnuHelpAbout.Size = New System.Drawing.Size(175, 22)
        Me.mnuHelpAbout.Text = "&About..."
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(508, 24)
        Me.MenuStrip1.TabIndex = 18
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'bwCheckUpdate
        '
        '
        'frmWMbrC
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(508, 330)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lblWarning)
        Me.Controls.Add(Me.gbSummary)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmWMbrC"
        Me.Text = "Form1"
        CType(Me.nudPercent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudVidQuality, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.tabSrcDest.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.nudCustomCDSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabWMTypes.ResumeLayout(False)
        Me.tabWMTypes.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.tabCompress.ResumeLayout(False)
        Me.tabCompress.PerformLayout()
        CType(Me.nudFrameRate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.nudVidHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudVidWidth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbSummary.ResumeLayout(False)
        Me.gbSummary.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Const URL_UPDATE_DOWNLOAD As String = "http://wmwiki.com/mcored/downloads/wmbrc"
    ' URL_UPDATE_CHECK has to be a very reliable link
    Const URL_UPDATE_CHECK As String = "http://www.ii.net/~malith/"


    Dim mAspectRatio As Double = 1.0
    Dim mDecimalSymbol As Char = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator


    Private Sub sMcoreCalculation()

        Call sUpdateGuiControls()
        Call sWMAPRO()
        Call sSetWMV9()
        Call sCalculateWithSmartAudio()

    End Sub
    Private Sub frmwm9bc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    
        miHelpUpdates.Text = "Check for " + Application.ProductName + " &Update..."

        ' Application Title
        Dim o As New McoreSystem.AppInfo
        Me.Text = o.GetApplicationTitle(Application.ProductName, Application.ProductVersion, 2)
        mnuHelpAbout.Text = "About " & Application.ProductName & "..."
        Me.txtMovieName.Text = strMovieName
        lblWarning.Hide()
        'picWarning.Hide()

        chkSameVidIput.CheckState = CheckState.Checked

        Pro2 = New WMEncoderLib.WMEncProfile2
        Pro2.ContentType = 17

        ' Retrieve an existing profile to modify.
        ProColl = mWMEncoder.ProfileCollection
        'Item(4) is Windows Media Video 8 for Dial-up Modems or LAN (28.8 to 100 Kbps)
        Pro1 = ProColl.Item(10)

        'Load the profile.
        Pro2.LoadFromIWMProfile(Pro1)

        Call ComboBoxValues()
        Call GetAllSettings()
        'Call sChoose192_48_6_24()
        'Call sWMAPRO()
        If System.IO.File.Exists(Application.ExecutablePath + ".config") = False Then
            Call myWriteXML()
        End If
        '************************ 
        '* Increase startup time
        '************************


    End Sub

    Public Sub myGetLastPostion()

        '***************************
        '* Resolution issue
        '***************************

        Dim app As New McoreSystem.AppSettings.XmlConfig

        Dim booErrorOccured As Boolean = False

        Try
            If app.getAppSettingFromXML("WindowLeft") < 0 Then
                booErrorOccured = True
            End If
            If app.getAppSettingFromXML("WindowTop") < 0 Then
                booErrorOccured = True
            End If
        Catch ex As Exception
            Me.Left = (System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width - Me.Width) / 2
            Me.Top = (System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width - Me.Height) / 2
            Exit Sub
        End Try

        If booErrorOccured = False Then
            Try
                Dim intLastRes As Integer
                intLastRes = app.getAppSettingFromXML("LastRes")

                Dim intCurrentRes As Integer = _
    System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width

                If intCurrentRes < intLastRes Then
                    'Problems start to happen, therefore :
                    Me.Left = (System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width - Me.Width) / 2
                    Me.Top = (System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width - Me.Height) / 2
                Else
                    'No Problems
                    Me.Left = app.getAppSettingFromXML("WindowLeft")
                    Me.Top = app.getAppSettingFromXML("WindowTop")
                End If

            Catch ex As Exception

                Me.Left = (System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width - Me.Width) / 2
                Me.Top = (System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width - Me.Height) / 2

            End Try
        Else

            Me.Left = (System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width - Me.Width) / 2
            Me.Top = (System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width - Me.Height) / 2

        End If


    End Sub

    Sub myWriteXML()

        Dim numItems As Integer = 15

        Dim xmlConfig As New Xml.XmlDocument
        xmlConfig.AppendChild(xmlConfig.CreateXmlDeclaration("1.0", "UTF-8", String.Empty))
        Dim xmlrootConfiguration As Xml.XmlNode = xmlConfig.CreateElement("configuration")
        xmlConfig.AppendChild(xmlrootConfiguration)
        Dim xmlAppSettings As Xml.XmlNode = xmlConfig.CreateElement("appSettings")
        xmlrootConfiguration.AppendChild(xmlAppSettings)
        Dim xmlAdd(numItems) As Xml.XmlElement
        For i As Integer = 1 To numItems
            xmlAdd(i) = xmlConfig.CreateElement("add")
            With xmlAdd(i)
                .Attributes.Append(xmlConfig.CreateAttribute("key"))
                .Attributes.Append(xmlConfig.CreateAttribute("value"))
            End With
            xmlAppSettings.AppendChild(xmlAdd(i))
        Next
        xmlAdd(1).Attributes("key").Value = "WindowLeft"
        xmlAdd(1).Attributes("value").Value = Me.Left
        xmlAdd(2).Attributes("key").Value = "WindowTop"
        xmlAdd(2).Attributes("value").Value = Me.Top
        xmlAdd(3).Attributes("key").Value = "AlwaysOnTop"
        xmlAdd(3).Attributes("value").Value = mnuFileTop.Checked
        xmlAdd(4).Attributes("key").Value = "CustomSizeBased"
        xmlAdd(4).Attributes("value").Value = optCustomSize.Checked
        xmlAdd(5).Attributes("key").Value = "CDSizeBased"
        xmlAdd(5).Attributes("value").Value = "true"
        xmlAdd(6).Attributes("key").Value = "Hours"
        xmlAdd(6).Attributes("value").Value = cboHours.Text
        xmlAdd(7).Attributes("key").Value = "Minutes"
        xmlAdd(7).Attributes("value").Value = cboMins.Text
        xmlAdd(8).Attributes("key").Value = "Seconds"
        xmlAdd(8).Attributes("value").Value = cboSecs.Text
        xmlAdd(9).Attributes("key").Value = "CDCDNumber"
        xmlAdd(9).Attributes("value").Value = cboCDCDNumber.SelectedIndex
        xmlAdd(10).Attributes("key").Value = "CDCDSize"
        xmlAdd(10).Attributes("value").Value = cboCDCDSize.SelectedIndex
        xmlAdd(11).Attributes("key").Value = "CustomCDNumber"
        xmlAdd(11).Attributes("value").Value = cboCustomCDNumber.SelectedIndex
        xmlAdd(12).Attributes("key").Value = "CustomCDSize"
        xmlAdd(12).Attributes("value").Value = nudCustomCDSize.Text
        xmlAdd(13).Attributes("key").Value = "AudioQ"
        xmlAdd(13).Attributes("value").Value = cboAudioFormat.SelectedIndex
        xmlAdd(14).Attributes("key").Value = "SaveToLog"
        xmlAdd(14).Attributes("value").Value = mnuEditLog.Checked
        xmlAdd(15).Attributes("key").Value = "LastRes"
        xmlAdd(15).Attributes("value").Value = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width
        Dim myWriter As New Xml.XmlTextWriter(Application.ExecutablePath + ".config", System.Text.Encoding.UTF8)
        myWriter.Formatting = Xml.Formatting.Indented
        xmlConfig.Save(myWriter)
        myWriter.Close()

    End Sub

    Sub SaveAllSettings()

        Dim app As New McoreSystem.AppSettings.XmlConfig

        If System.IO.File.Exists(Application.ExecutablePath + ".config") = False Then

            Call myWriteXML()

        Else

            Dim intLastRes As Integer = _
                System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width

            app.setAppSettingToXML("WindowLeft", Me.Left)
            app.setAppSettingToXML("WindowTop", Me.Top)
            app.setAppSettingToXML("LastRes", intLastRes)

            'Settings
            app.setAppSettingToXML("AlwaysOnTop", mnuFileTop.Checked)
            app.setAppSettingToXML("CDSizeBased", optCD.Checked)
            app.setAppSettingToXML("CustomSizeBased", optCustomSize.Checked)
            app.setAppSettingToXML("SaveToLog", mnuEditLog.Checked)

            'Movie Length
            app.setAppSettingToXML("Hours", cboHours.Text)
            app.setAppSettingToXML("Minutes", cboMins.Text)
            app.setAppSettingToXML("Seconds", cboSecs.Text)
            'File Size
            app.setAppSettingToXML("CDCDNumber", cboCDCDNumber.SelectedIndex)
            app.setAppSettingToXML("CDCDSize", cboCDCDSize.SelectedIndex)
            app.setAppSettingToXML("CustomCDNumber", cboCustomCDNumber.SelectedIndex)
            app.setAppSettingToXML("CustomCDSize", nudCustomCDSize.Text)
            'Audio Quality
            app.setAppSettingToXML("AudioQ", cboAudioFormat.SelectedIndex)

        End If

    End Sub
    Sub GetAllSettings()

        Dim app As New McoreSystem.AppSettings.XmlConfig

        Try
            myGetLastPostion()
            'Window
            cboHours.Text = app.getAppSettingFromXML("Hours")
            cboMins.Text = app.getAppSettingFromXML("Minutes")
            cboSecs.Text = app.getAppSettingFromXML("Seconds")
            'Settings
            mnuFileTop.Checked = app.getAppSettingFromXML("AlwaysOnTop")
            optCustomSize.Checked = app.getAppSettingFromXML("CustomSizeBased")
            optCD.Checked = app.getAppSettingFromXML("CDSizeBased")
            mnuEditLog.Checked = app.getAppSettingFromXML("SaveToLog")

        Catch ex As Exception

            'Window
            Me.Left = (Screen.PrimaryScreen.Bounds.Width - Me.Width) / 2
            Me.Top = (Screen.PrimaryScreen.Bounds.Width - Me.Height) / 3
            cboHours.Text = 2
            cboMins.Text = 0
            cboSecs.Text = 0
            'Settings
            mnuFileTop.Checked = False
            optCustomSize.Checked = False
            optCD.Checked = True
            mnuEditLog.Checked = True

        End Try

        If mnuFileTop.Checked = True Then Me.TopMost = True Else Me.TopMost = False

    End Sub

    Private Function fIsValidCalc() As Boolean

        Return (cboAudMode.SelectedIndex <> 2 AndAlso cboVidMode.SelectedIndex <> 2 AndAlso _
                 IsNumeric(cboHours.Text) AndAlso Len(cboHours.Text) > 0 AndAlso _
                 IsNumeric(cboMins.Text) = True AndAlso Len(cboMins.Text) > 0 AndAlso _
                 IsNumeric(cboSecs.Text) = True AndAlso Len(cboSecs.Text) > 0 AndAlso nudCustomCDSize.Text <> "")

    End Function

    Private Function fGetFileSizeInBytes() As Single

        Dim sngFileSize As Single
        Dim strNumberOfDisks As String = "1"

        If optCD.Checked = True Then

            Dim strCDCDSize As String = cboCDCDSize.Text
            Dim sngCDCDSize() As String = Split(strCDCDSize, " ")
            Dim strCDCDNumber As String = cboCDCDNumber.Text
            Dim sngCDCDNumber() As String = Split(strCDCDNumber, " ")

            strNumberOfDisks = sngCDCDNumber(0)

            Select Case cboCDCDSize.SelectedIndex
                Case Is > 3
                    ' for DVD                
                    sngFileSize = sngCDCDSize(0) * 1000 * 1000 * 1000 ' Bytes
                Case Else
                    ' for CD
                    sngFileSize = sngCDCDSize(0) * 1024 * 1024 'Bytes      
            End Select

        ElseIf optCustomSize.Checked AndAlso Not nudCustomCDSize.Text = "0" Then

            Dim strCustomCDNumber As String = cboCustomCDNumber.Text
            Dim sngCustomCDNumber() As String = Split(strCustomCDNumber, " ")

            strNumberOfDisks = sngCustomCDNumber(0)

            sngFileSize = nudCustomCDSize.Text * 1024 * 1024

        End If

        If IsNumeric(strNumberOfDisks) Then
            sngFileSize = sngFileSize * strNumberOfDisks
        Else

        End If


        If IsNumeric(strNumberOfDisks) Then
            sngFileSize = sngFileSize * strNumberOfDisks
        Else
            Dim frac() As String = strNumberOfDisks.Split("/")
            sngFileSize = sngFileSize * frac(0) / frac(1)
        End If

        Return sngFileSize

    End Function

    Private Sub sCalcVideoBitRate()

        If booReady AndAlso fIsValidCalc() Then

            My.Forms.frmTotalFrames.MovieLengthCalc()

            Dim sngSecs, sngMins, sngHours, sngLength, _
            sngAudioB, sngVideoB, sngVideoQ As Single

            Dim sngFileSize As Single = fGetFileSizeInBytes() 'Bytes

            txtVideoQ.ForeColor = System.Drawing.Color.Black
            txtVidBitRate.ForeColor = System.Drawing.Color.Black

            Dim strAudioQ As String = cboAudioFormat.Text.Trim
            Dim sngAudioQ() As String = Split(strAudioQ, " ")

            sngSecs = CSng(cboSecs.Text)
            sngMins = CSng(cboMins.Text)
            sngHours = CSng(cboHours.Text)
            sngLength = (sngHours * 3600) + (sngMins * 60) + sngSecs 'Movie length in seconds

            txtMovieLength.Text = sngLength.ToString
            txtFileSize.Text = sngFileSize / (1024 * 1024) ' in MiB

            sngAudioB = (((sngAudioQ(0) * 1024) * sngLength) / 8)  'Audio in B (Kbps * s)/8/1024
            txtAudBitRate.Text = sngAudioQ(0)

            sngVideoB = (sngFileSize - sngAudioB) 'Video in Bytes

            If sngVideoB < 0 Then
                'lblKbps.Visible = False
                txtVideoQ.Text = "0"
                txtVideoQ.ForeColor = System.Drawing.Color.Red
                txtVidBitRate.Text = txtVideoQ.Text
                txtVidBitRate.ForeColor = System.Drawing.Color.Red
                Exit Sub
            End If

            sngVideoQ = ((sngVideoB / 1024) * 8) / sngLength 'Video in Kibit/s

            txtVideoQ.Text = FormatNumber(sngVideoQ - 0.5, 0, , , TriState.False)     'Video in (Kbps - 0.5) to the nearest whole number
            txtVidBitRate.Text = txtVideoQ.Text

            Call sPredictFileQuality(sngVideoQ)

        Else 'Audio is VBR 

            txtVideoQ.ReadOnly = False

            If (Pro2.VBRMode(WMEncoderLib.WMENC_SOURCE_TYPE.WMENC_AUDIO, 0) = _
                WMEncoderLib.WMENC_PROFILE_VBR_MODE.WMENC_PVM_UNCONSTRAINED) Then
                txtAudBitRate.Text = "VBR"
            End If
            If (Pro2.VBRMode(WMEncoderLib.WMENC_SOURCE_TYPE.WMENC_VIDEO, 0) = _
                WMEncoderLib.WMENC_PROFILE_VBR_MODE.WMENC_PVM_UNCONSTRAINED) Then
                txtVidBitRate.Text = "VBR"
            End If
            txtVidBitRate.Text = txtVideoQ.Text

        End If

    End Sub

    Private Sub sPredictFileQuality(ByVal lVideoBitRate As Integer)

        ' PREDICT TARGET FILESIZE QUALITY
        If IsNumeric(nudVidWidth.Text) And IsNumeric(nudVidHeight.Text) Then

            Dim intPixels As Double = nudVidWidth.Text * nudVidHeight.Text * nudFrameRate.Text
            Dim intBits As Double = lVideoBitRate * 1024
            Dim intBitsPerPixel As Double = intBits / intPixels

            Dim strQuality As String = "Poor"

            ' This values are purely guessing based on a 2 hour movie fitting on a 1120 MiB
            If cboVideoCodec.SelectedItem.ToString.IndexOf("Advanced") <> -1 Then
                intBitsPerPixel = intBitsPerPixel * 2.5 ' Just under Near Perfect Quality
            ElseIf cboVideoCodec.SelectedItem.ToString.IndexOf("9") <> -1 Then
                intBitsPerPixel = intBitsPerPixel * 2.2 ' Just under Very Good Quality
            ElseIf cboVideoCodec.SelectedItem.ToString.IndexOf("V8") <> -1 Then
                intBitsPerPixel = intBitsPerPixel * 1.9 ' Just under Good Quality
            ElseIf cboVideoCodec.SelectedItem.ToString.IndexOf("V7") <> -1 Then
                intBitsPerPixel = intBitsPerPixel * 1.6 ' Just under Fair Quality
            End If

            Select Case intBitsPerPixel
                Case Is > 0.299
                    strQuality = "Near Perfect"
                Case Is > 0.269
                    strQuality = "Excellent"
                Case Is > 0.239
                    strQuality = "Very Good"
                Case Is > 0.209
                    strQuality = "Good"
                Case Is > 0.179
                    strQuality = "Fair"
            End Select
            gbSummary.Text = String.Format("Summary of a {0} quality Window Media file:", strQuality)
        End If

    End Sub

    Private Sub cboCDCDNumber_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCDCDNumber.SelectedIndexChanged

        Dim strCDCDNumber As String = cboCDCDNumber.Text
        Dim sngCDCDNumber() As String = Split(strCDCDNumber, " ")

        Select Case cboCDCDNumber.SelectedIndex
            Case Is = 0
                Me.ToolTip1.SetToolTip(Me.cboCDCDNumber, " 3 Movies per Disk ")
            Case Is = 1
                Me.ToolTip1.SetToolTip(Me.cboCDCDNumber, " 2 Movies per Disk ")
            Case Is = 2
                Me.ToolTip1.SetToolTip(Me.cboCDCDNumber, " " + sngCDCDNumber(0) + " Disk per Movie ")
            Case Is > 2
                Me.ToolTip1.SetToolTip(Me.cboCDCDNumber, " " + sngCDCDNumber(0) + " Disks per Movie ")

        End Select

        sCalculateWithSmartAudio()

    End Sub

    Private Sub cboCustomCDNumber_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCustomCDNumber.SelectedIndexChanged

        Dim strCustomCDNumber As String = cboCustomCDNumber.Text
        Dim sngCustomCDNumber() As String = Split(strCustomCDNumber, " ")
        Select Case cboCustomCDNumber.SelectedIndex
            Case Is = 0
                Me.ToolTip1.SetToolTip(Me.cboCustomCDNumber, " 3 Movies per Disk ")
            Case Is = 1
                Me.ToolTip1.SetToolTip(Me.cboCustomCDNumber, " 2 Movies per Disk ")
            Case Is = 2
                Me.ToolTip1.SetToolTip(Me.cboCustomCDNumber, " " + sngCustomCDNumber(0) + " Disk per Movie ")
            Case Is > 2
                Me.ToolTip1.SetToolTip(Me.cboCustomCDNumber, " " + sngCustomCDNumber(0) + " Disks per Movie ")

        End Select

        sCalculateWithSmartAudio()

    End Sub
    Sub ComboBoxValues()

        Dim app As New McoreSystem.AppSettings.XmlConfig

        Dim i As Short
        'Loading values for Minutes
        For i = 0 To 59
            cboMins.Items.Add(i)
        Next

        'Loading values for Seconds
        For i = 0 To 59
            cboSecs.Items.Add(i)
        Next

        'Loading values for Hours
        For i = 0 To 10
            cboHours.Items.Add(i)
        Next

        Dim fFirst, strCD As String
        'Loading values for Compact Disk Sized Based
        'Loading # of CDs
        fFirst = CStr(True)

        Dim lFractions() As String = {"1/24", "1/12", "1/6", "1/4", "1/3", "1/2", "2/3"}

        For Each frac As String In lFractions
            cboCDCDNumber.Items.Add(frac + " Disk")
            cboCustomCDNumber.Items.Add(frac + " Disk")
        Next

        For i = 1 To 5
            If CBool(fFirst) Then
                strCD = " Disk"
                fFirst = CStr(False)
            Else
                strCD = " Disks"
            End If
            cboCDCDNumber.Items.Add(i & strCD)
            cboCustomCDNumber.Items.Add(i & strCD)
        Next

        'Loading CD Sizes
        cboCDCDSize.Items.Add("650 MiB")
        cboCDCDSize.Items.Add("700 MiB")
        cboCDCDSize.Items.Add("800 MiB")
        cboCDCDSize.Items.Add("870 MiB") '0

        cboCDCDSize.Items.Add(String.Format("2{0}60 GB", mDecimalSymbol))
        cboCDCDSize.Items.Add(String.Format("3{0}95 GB", mDecimalSymbol))
        cboCDCDSize.Items.Add(String.Format("4{0}70 GB", mDecimalSymbol))
        cboCDCDSize.Items.Add(String.Format("5{0}20 GB", mDecimalSymbol))
        cboCDCDSize.Items.Add(String.Format("8{0}54 GB", mDecimalSymbol))
        cboCDCDSize.Items.Add(String.Format("9{0}40 GB", mDecimalSymbol))
        cboCDCDSize.Items.Add(String.Format("17{0}08 GB", mDecimalSymbol))

        'Loading values for Audio Bitrate

        cboVidMode.Items.Insert(0, "CBR")
        cboVidMode.Items.Insert(1, "Bit Rate VBR (Peak)")
        cboVidMode.Items.Insert(2, "Quality VBR")
        cboVidMode.Items.Insert(3, "Bit Rate VBR")
        cboVidMode.SelectedIndex = 3
        cboVideoCodec.SelectedIndex = 1

        cboAudMode.Items.Insert(0, "CBR")
        cboAudMode.Items.Insert(1, "Bit Rate VBR (Peak)")
        cboAudMode.Items.Insert(2, "Quality VBR")
        cboAudMode.Items.Insert(3, "Bit Rate VBR")
        cboAudMode.SelectedIndex = 3

        cboAudioCodec.SelectedIndex = 1

        Try
            cboHours.SelectedIndex = app.getAppSettingFromXML("Hours")
            cboMins.SelectedIndex = app.getAppSettingFromXML("Minutes")
            cboSecs.SelectedIndex = app.getAppSettingFromXML("Seconds")
            cboAudioFormat.SelectedIndex = app.getAppSettingFromXML("AudioQ")
            cboCDCDSize.SelectedIndex = app.getAppSettingFromXML("CDCDSize")
            cboCDCDNumber.SelectedIndex = app.getAppSettingFromXML("CDCDNumber")
            cboCustomCDNumber.SelectedIndex = app.getAppSettingFromXML("CustomCDNumber")
            nudCustomCDSize.Text = app.getAppSettingFromXML("CustomCDSize")
        Catch ex As Exception
            cboHours.SelectedIndex = 0
            cboMins.SelectedIndex = 0
            cboSecs.SelectedIndex = 0
            cboAudioFormat.SelectedIndex = 0
            cboCDCDSize.SelectedIndex = 1
            cboCDCDNumber.Text = "1 Disk"
            cboCustomCDNumber.SelectedIndex = 4
            nudCustomCDSize.Text = 797
        End Try

    End Sub

    Private Sub optCD_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optCD.CheckedChanged
        nudPercent.Text = 0
        nudCustomCDSize.ReadOnly = True 'Locks the text box
        cboCustomCDNumber.Enabled = False
        cboCDCDSize.Enabled = True
        cboCDCDNumber.Enabled = True
        sCalculateWithSmartAudio()
    End Sub

    Private Sub optCustom_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optCustomSize.CheckedChanged

        nudPercent.Text = 0
        nudCustomCDSize.ReadOnly = False 'Unlocks the text box
        nudCustomCDSize.Focus()
        cboCustomCDNumber.Enabled = True
        cboCDCDSize.Enabled = False
        cboCDCDNumber.Enabled = False

    End Sub

    Private Sub mnuFileTop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call SaveAllSettings()
        Me.Close()
    End Sub

    Private Sub cboAudioQ_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAudioFormat.SelectedIndexChanged
        nudPercent.Text = 0
        Call sCalcVideoBitRate()
    End Sub

    Private Sub sCalculateWithSmartAudio()

        Call sChoose192_48_6_24()

        'If booReady AndAlso Single.Parse(txtVidBitRate.Text) > 1000 Then
        '    Call sChoose384_48_6_24()
        'Else
        '    Call sChoose192_48_6_24()
        'End If

        nudPercent.Text = 0
        sCalcVideoBitRate()

    End Sub

    Private Sub cboCDCDSize_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles cboCDCDSize.SelectedIndexChanged

        sCalculateWithSmartAudio()

    End Sub
    Private Sub nudCustomCDSize_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles nudCustomCDSize.TextChanged

        nudPercent.Text = 0
        Call sCalcVideoBitRate()
    End Sub

    Private Sub mnuEditSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub mnuHelpZarax_Click(ByVal sender As System.Object, _
    ByVal e As System.EventArgs)

    End Sub

    Private Sub mnuHelpZaraxForums_Click(ByVal sender As System.Object, _
    ByVal e As System.EventArgs)

    End Sub

    Private Sub mnuHelpDoom9_Click(ByVal sender As System.Object, _
    ByVal e As System.EventArgs)
        Process.Start("http://www.doom9.org", AppWinStyle.MaximizedFocus)
    End Sub

    Private Sub mnuHelpDoom9Forums_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("http://forum.doom9.org", AppWinStyle.MaximizedFocus)
    End Sub

    Private Sub nudPercent_textChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudPercent.TextChanged
        If Len(txtVideoQ.Text) > 0 Then
            Call sCalcVideoBitRate()
            txtVideoQ.Text = FormatNumber((txtVideoQ.Text * (100 + nudPercent.Text)) / 100, 0, , , TriState.False)
        End If
    End Sub


    Private Sub fraMovLength_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        nudPercent.Text = 0
    End Sub

    Private Sub fraFileSize_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        nudPercent.Text = 0
    End Sub

    Private Sub fraMovQuality_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        nudPercent.Text = 0
    End Sub

    Private Sub cboSecs_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSecs.SelectedIndexChanged
        Call sCalcVideoBitRate()
    End Sub

    Private Sub cboMins_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMins.SelectedIndexChanged
        Call sCalcVideoBitRate()
    End Sub

    Private Sub cboHours_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboHours.SelectedIndexChanged
        Call sCalcVideoBitRate()
    End Sub

    Private Sub cboMins_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMins.TextChanged
        Call sCalcVideoBitRate()
    End Sub

    Private Sub cboSecs_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSecs.TextChanged
        Call sCalcVideoBitRate()
        'Call frmTotalFrames.MyEvent.MovieLengthCalc()
    End Sub

    Private Sub cboHours_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboHours.TextChanged
        Call sCalcVideoBitRate()

        'Call frmTotalFrames.MyEvent.MovieLengthCalc()
    End Sub



    Private Sub frmWM9BC_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Call SaveAllSettings()
        If mnuEditLog.Checked = True Then
            saveLog()
        End If
    End Sub

    Private Sub saveLog()

        strCompressionInfo = "Movie Length:" + vbTab + vbTab + _
     cboHours.Text + " Hours " + cboMins.Text + " Minutes " + _
     cboSecs.Text + " Seconds"

        If optCD.Checked = True Then
            strCompressionInfo = strCompressionInfo + vbCrLf + _
            "Disk Size Based:" + vbTab + cboCDCDSize.Text + " * " + _
            cboCDCDNumber.Text + vbCrLf + _
            "Audio Codec:" + vbTab + vbTab + cboAudioCodec.Text + vbCrLf + _
            "Audio Format:" + vbTab + vbTab + cboAudioFormat.Text + vbCrLf + _
            "Video Codec:" + vbTab + vbTab + cboVideoCodec.Text + vbCrLf + _
            "Video Bit rate:" + vbTab + vbTab + txtVideoQ.Text + " Kibit/s"
        End If

        If optCustomSize.Checked = True Then
            strCompressionInfo = strCompressionInfo + vbCrLf + _
            "Custom Size Based:" + vbTab + nudCustomCDSize.Text + " MiB * " + _
            cboCustomCDNumber.Text + vbCrLf + _
            "Audio Codec:" + vbTab + vbTab + cboAudioCodec.Text + vbCrLf + _
            "Audio Format:" + vbTab + vbTab + cboAudioFormat.Text + vbCrLf + _
            "Video Codec:" + vbTab + vbTab + cboVideoCodec.Text + vbCrLf + _
            "Video Bit rate:" + vbTab + vbTab + txtVideoQ.Text + " Kibit/s"
        End If

        Try

            If txtMovieName.Text <> strMovieName Then
                FileOpen(1, (Application.StartupPath & "\WM9BC-Log.log"), _
                OpenMode.Append)
                PrintLine(1, Now + vbTab + txtMovieName.Text)
                PrintLine(1, strCompressionInfo)
                PrintLine(1, vbCr)
                FileClose(1)
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtMovieName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMovieName.Click
        txtMovieName.SelectionStart = 0
        txtMovieName.SelectionLength = Len(txtMovieName.Text)
    End Sub


    Private Sub cboAudMode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAudMode.SelectedIndexChanged

        Pro2.VBRMode(WMEncoderLib.WMENC_SOURCE_TYPE.WMENC_AUDIO, 0) = cboAudMode.SelectedIndex + 1

        cboAudioCodec.Items.Clear()
        cboAudioFormat.Items.Clear()

        Dim vAudCodecName As Object = Nothing
        Dim lAud4cc As Integer
        For x = 0 To Pro2.AudioCodecCount - 1
            lAud4cc = Pro2.EnumAudioCodec(x, vAudCodecName)
            cboAudioCodec.Items.Add(vAudCodecName)
        Next x

        'cboAudioCodec.SelectedIndex = 0

        Call sMcoreCalculation()

    End Sub

    Private Sub cboVidMode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboVidMode.SelectedIndexChanged

        Pro2.VBRMode(WMEncoderLib.WMENC_SOURCE_TYPE.WMENC_VIDEO, 0) = cboVidMode.SelectedIndex + 1
        cboVideoCodec.Items.Clear()
        Dim vVidCodecName As Object = Nothing
        Dim lVid4cc As Integer
        For x = 0 To Pro2.VideoCodecCount - 1
            lVid4cc = Pro2.EnumVideoCodec(x, vVidCodecName)
            cboVideoCodec.Items.Add(vVidCodecName)
        Next x
        'cboVideoCodec.SelectedIndex = 0
        Call sMcoreCalculation()

    End Sub

    Private Sub sUpdateGuiControls()

        If cboVidMode.SelectedIndex = 2 Then
            txtVideoQ.Visible = False
            lblPercent.Visible = False
            lblKbps.Visible = False
            nudPercent.Visible = False
            lblVideoType.Text = "Video Quality"
            nudVidQuality.Visible = True
        Else
            txtVideoQ.Visible = True
            lblPercent.Visible = True
            lblKbps.Visible = True
            nudPercent.Visible = True
            lblVideoType.Text = "Video bit rate"
        End If

        If optPAL.Checked Then

            nudFrameRate.Enabled = False
            chkSameVidIput.Enabled = False
            nudVidWidth.Enabled = False
            nudVidHeight.Enabled = False
            nudFrameRate.Text = "25"
            nudVidWidth.Text = "384"
            nudVidHeight.Text = "288"

        ElseIf optNTSC.Checked Then

            nudFrameRate.Enabled = False
            chkSameVidIput.Enabled = False
            nudVidWidth.Enabled = False
            nudVidHeight.Enabled = False
            nudFrameRate.Text = "29.97"
            nudVidWidth.Text = "320"
            nudVidHeight.Text = "240"

        ElseIf optCustomFPS.Checked Then

            nudFrameRate.Text = 25
            nudFrameRate.Enabled = True
            chkSameVidIput.Enabled = True
            chkSameVidIput.Checked = True

        End If

    End Sub

    Private Sub cboAudioCodec_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAudioCodec.SelectedIndexChanged

        cboAudioFormat.Items.Clear()
        Dim vAudFormatName As Object = Nothing
        Dim lAudBRate As Integer
        Dim Channels As Object = Nothing
        Dim SRate As Object = Nothing
        Dim BperSample As Object = Nothing
        For y = 0 To Pro2.AudioFormatCount(cboAudioCodec.SelectedIndex) - 1
            lAudBRate = Pro2.EnumAudioFormat(cboAudioCodec.SelectedIndex, y, vAudFormatName, SRate, Channels, BperSample)
            Dim item As String = vAudFormatName
            cboAudioFormat.Items.Add(item.Replace("kbps", "Kibit/s"))
            'cboAudioFormat.Items.Add(vAudFormatName)
        Next y

        'Call sWMA9PRO()  ' Caused Bug 0090
        Call sChoose192_48_6_24()

        'MessageBox.Show(cboAudioFormat.Items.Count)

    End Sub



    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optNTSC.CheckedChanged

        sUpdateGuiControls()

    End Sub


    Private Sub chkPAL_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optPAL.CheckedChanged

        sUpdateGuiControls()

    End Sub

    Private Sub chkSameVidIput_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSameVidIput.CheckedChanged
        'Same as Video Input
        nudVidHeight.Enabled = Not chkSameVidIput.Checked
        nudVidWidth.Enabled = Not chkSameVidIput.Checked
    End Sub

    Private Sub createPRX()

        Dim Descr As WMEncoderLib.IWMEncAudienceObj
        Descr = mAudnc

        For i = 0 To Pro2.AudienceCount - 1

            mAudnc = Pro2.Audience(i)

            '******************
            '* AUDIO SETTINGS
            '******************
            'Audio Codec
            mAudnc.AudioCodec(0) = cboAudioCodec.SelectedIndex
            'Audio Format
            mAudnc.AudioFormat(0) = cboAudioFormat.SelectedIndex

            '*******************
            '* VIDEO SETTINGS
            '*******************
            'Video Codec
            mAudnc.VideoCodec(0) = cboVideoCodec.SelectedIndex
            'Frame Rate
            mAudnc.VideoFPS(0) = nudFrameRate.Text * 1000
            'Key Frame Interval
            mAudnc.VideoKeyFrameDistance(0) = CInt(txtKeyFrames.Text) * 1000
            'Interlaced Support
            If chkInterlaced.CheckState = CheckState.Checked Then
                Pro2.InterlaceMode(0) = True
            End If
            'Nonsquare pixel output
            If chkNonsquare.CheckState = CheckState.Checked Then
                Pro2.NonSquarePixelMode(0) = True
            End If
            'Same as Video Input
            If chkSameVidIput.Enabled And chkSameVidIput.Checked Then
                mAudnc.VideoHeight(0) = 0
                mAudnc.VideoWidth(0) = 0
                nudVidHeight.Enabled = False
                nudVidWidth.Enabled = False
            Else
                mAudnc.VideoHeight(0) = CInt(nudVidHeight.Text)
                mAudnc.VideoWidth(0) = CInt(nudVidWidth.Text)
                nudVidHeight.Enabled = True
                nudVidWidth.Enabled = True
            End If
            'Video CBR
            If (Pro2.VBRMode(WMEncoderLib.WMENC_SOURCE_TYPE.WMENC_VIDEO, 0) = _
                WMEncoderLib.WMENC_PROFILE_VBR_MODE.WMENC_PVM_NONE) Then
                'Bit Rate
                If (txtVideoQ.Text >= 4 And txtVideoQ.Text <= 20000) Then
                    mAudnc.VideoBitrate(0) = txtVideoQ.Text * 1000
                End If
                'Buffer Size
                mAudnc.VideoBufferSize(0) = 100 * 1000
                'Smoothness
                mAudnc.VideoImageSharpness(0) = 90
            End If
            'Video Bitrate VBR or Video Bit Rate VBR (Peak)
            If (Pro2.VBRMode(WMEncoderLib.WMENC_SOURCE_TYPE.WMENC_VIDEO, 0) = _
                WMEncoderLib.WMENC_PROFILE_VBR_MODE.WMENC_PVM_BITRATE_BASED Or _
                WMEncoderLib.WMENC_PROFILE_VBR_MODE.WMENC_PVM_PEAK) Then
                If (txtVideoQ.Text >= 4 And txtVideoQ.Text <= 20000) Then

                    mAudnc.VideoBitrate(0) = txtVideoQ.Text * 1000
                End If
            End If
            'Video Quality VBR
            If (Pro2.VBRMode(WMEncoderLib.WMENC_SOURCE_TYPE.WMENC_VIDEO, 0) = _
                WMEncoderLib.WMENC_PROFILE_VBR_MODE.WMENC_PVM_UNCONSTRAINED) Then
                If (nudVidQuality.Text >= 0 And nudVidQuality.Text <= 100) Then
                    mAudnc.VideoCompressionQuality(0) = nudVidQuality.Text
                End If
            End If

            '***********************
            '* PROFILE DESCRIPTION
            '***********************
            'Profile Name
            Pro2.ProfileName = txtMovieName.Text
            'Profile Description
            Pro2.ProfileDescription = "Profile created by " + Application.ProductName + _
            " for DVD to " + cboVideoCodec.Text + " conversion."

        Next i


    End Sub

    Private Sub optCustomFPS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optCustomFPS.CheckedChanged

        'MsgBox("PAL/NTSC is buggy")
        sUpdateGuiControls()


    End Sub


    Private Sub sChoose192_48_6_24()

        Console.WriteLine(cboAudioFormat.Items.Count)

        If (cboAudioFormat.Items.Count = 41) Then               'Bitrate VBR, WMP10
            cboAudioFormat.SelectedIndex = 28
        ElseIf (cboAudioFormat.Items.Count = 43) Then           'Bitrate VBR, WMP11
            cboAudioFormat.SelectedIndex = 28
        ElseIf (cboAudioFormat.Items.Count = 59) Then           'CBR, WMP10
            cboAudioFormat.SelectedIndex = 39
        ElseIf (cboAudioFormat.Items.Count = 79) Then           'CBR, WMP11, Vista
            cboAudioFormat.SelectedIndex = 41
        ElseIf (cboAudioFormat.Items.Count = 84) Then           'CBR, WMP11, XP
            cboAudioFormat.SelectedIndex = 41
        ElseIf (cboAudioFormat.Items.Count > 1) Then
            cboAudioFormat.SelectedIndex = 0
        End If

        'WMP11: 43-28, 84-41
        'WMP10: 41-28, 59-39

    End Sub

    Private Sub sChoose384_48_6_24()

        If (cboAudioFormat.Items.Count = 41) Then               'Bitrate VBR
            cboAudioFormat.SelectedIndex = 14
        ElseIf (cboAudioFormat.Items.Count = 59) Then           'CBR
            cboAudioFormat.SelectedIndex = 19
        ElseIf (cboAudioFormat.Items.Count > 1) Then
            cboAudioFormat.SelectedIndex = 0
        End If

    End Sub

    Private Sub cboVideoCodec_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles cboVideoCodec.SelectedIndexChanged

        chkInterlaced.Enabled = (cboVideoCodec.Text.IndexOf("Advanced Profile") <> -1)

        If cboVideoCodec.Text.IndexOf("Advanced Profile") = -1 _
                    And chkInterlaced.Checked Then
            chkInterlaced.Checked = False
            lblWarning.Text = "The selected video codec does not " + _
                   "support interlaced processing."
            lblWarning.Show()
        Else
            lblWarning.Hide()
        End If

        'Call sChoose192_48_6_24()
        If booReady Then
            sPredictFileQuality(Integer.Parse(txtVidBitRate.Text))
        End If

    End Sub


    Private Sub chkNonsquare_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNonsquare.CheckedChanged

    End Sub

    Private Sub TabPage3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub sWMAPRO()

        intItem = 0

        Dim AudioCodec As String

        For Each AudioCodec In cboAudioCodec.Items
            If AudioCodec.IndexOf("Professional") = -1 Then
                intItem += 1
            Else
                cboAudioCodec.SelectedIndex = intItem
            End If
        Next

    End Sub

    Private Sub sSetWMV9()

        intItem = 0
        Dim VideoCodec As String

        For Each VideoCodec In cboVideoCodec.Items

            ' 2.4.2.3 WMbrC incorrectly suggested WMV 9.1 Image instead of WMV 9 Advanced Profile
            ' If VideoCodec.IndexOf("9") = -1 Then
            If VideoCodec.IndexOf("Advanced") = -1 Then
                intItem += 1
            Else
                cboVideoCodec.SelectedIndex = intItem
                Exit Sub
            End If

        Next

        ' Came here means it didn't find Advanced Codec

        intItem = 0

        For Each VideoCodec In cboVideoCodec.Items
            If VideoCodec.IndexOf("9") = -1 Then
                intItem += 1
            Else
                cboVideoCodec.SelectedIndex = intItem
                Exit Sub
            End If
        Next


    End Sub


    Private Sub AlwaysOnTopToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileTop.Click
        mnuFileTop.Checked = Not mnuFileTop.Checked
        If mnuFileTop.Checked = True Then Me.TopMost = True Else Me.TopMost = False

    End Sub

    Private Sub SaveProfileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveProfileToolStripMenuItem.Click
        If txtMovieName.Text = strMovieName Then
            MessageBox.Show("Please type the Movie Title...", _
            Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TabControl1.SelectedTab = tabSrcDest
            txtMovieName.Focus()
        Else
            Call createPRX()
            Dim dlg As New SaveFileDialog
            If txtMovieName.Text.IndexOf(".") = -1 Then
                dlg.FileName = txtMovieName.Text
            Else
                dlg.FileName = txtMovieName.Text + ".prx"
            End If
            dlg.DefaultExt = "prx"
            dlg.AddExtension = True
            dlg.Filter = "Windows Media Encoder Profiles (*.prx)|*.prx"
            If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
                Pro2.SaveToFile(dlg.FileName)
            End If
        End If
    End Sub

    Private Sub OpenLogToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenLogToolStripMenuItem.Click
        Try
            Process.Start(Application.StartupPath + "\WM9BC-Log.log")
        Catch ex As Exception
            MessageBox.Show(ex.Message, _
            Application.ProductName, _
            MessageBoxButtons.OK, _
            MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CopyVideoBitRateToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CopyVideoBitRateToolStripMenuItem.Click
        Dim datobj As New System.Windows.Forms.DataObject
        datobj.SetData(System.Windows.Forms.DataFormats.Text, txtVideoQ.Text)
        System.Windows.Forms.Clipboard.SetDataObject(datobj)
    End Sub

    Private Sub SaveToLogToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditLog.Click
        mnuEditLog.Checked = Not mnuEditLog.Checked
    End Sub

    Private Sub TotalFramesCalculatorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TotalFramesCalculatorToolStripMenuItem.Click

        With My.Forms.frmTotalFrames
            .Show()
            .Focus()
        End With

    End Sub

    Private Sub MovieResolutionCalculatorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MovieResolutionCalculatorToolStripMenuItem.Click
        Dim OpenMovieRes As New frmMovRes
        With OpenMovieRes
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub HomePageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomePageToolStripMenuItem.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Process.Start("http://www.wmwiki.com/", AppWinStyle.MinimizedNoFocus)
    End Sub

    Private Sub SupportForumsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupportForumsToolStripMenuItem.Click
        Process.Start("http://wmwiki.com/forum/", AppWinStyle.MaximizedFocus)
    End Sub

    Private Sub CheckForUpdateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miHelpUpdates.Click

        bwCheckUpdate.RunWorkerAsync()

    End Sub

    Private Sub VersionHistoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VersionHistoryToolStripMenuItem.Click

        Dim version As New frmVer
        version.ShowDialog()

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHelpAbout.Click
        Dim OpenAbout As New frmAboutWM9BC
        OpenAbout.ShowDialog()
    End Sub

    Private Sub frmWM9BC_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        booReady = True
        Call sResetAR()
        sCalculateWithSmartAudio()
    End Sub

    Private Sub WindowsMediaEncoderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WindowsMediaEncoderToolStripMenuItem.Click
        Try
            Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + _
            ("\Windows Media Components\Encoder\wmenc.exe"))
        Catch ex As Exception
            MsgBox("Windows Media Encoder is either not installed or installed in a different location.", _
            MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Error!")
        End Try
    End Sub

    Private Sub WindowsMediaPlayerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WindowsMediaPlayerToolStripMenuItem.Click
        Try
            Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + _
            ("\Windows Media Player\wmplayer.exe"))
        Catch ex As Exception
            MsgBox("Windows Media Player is either not installed or installed in a different location.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Error!")
        End Try

    End Sub

    Private Sub lblVideoType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblVideoType.Click

    End Sub

    Private Sub nudCustomCDSize_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudCustomCDSize.ValueChanged

    End Sub

    Private Sub tabWMTypes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabWMTypes.Click

    End Sub

    Private Sub bwCheckUpdate_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bwCheckUpdate.DoWork


        Dim app As New McoreSystem.AppInfo(Application.ProductName, Application.ProductVersion)
        Dim strUrl As String = URL_UPDATE_CHECK
        If (app.isUpdated(strUrl, "updates.txt") = True) Then
            If (MessageBox.Show(app.getMsgOutdated(Application.ProductName), Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question)) = Windows.Forms.DialogResult.Yes Then
                Process.Start(URL_UPDATE_DOWNLOAD)
            End If
        Else
            MessageBox.Show(app.getMsgUpToDate, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub nudVidHeight_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudVidHeight.ValueChanged

        If chkMaintainAR.Checked Then
            nudVidWidth.Value = nudVidHeight.Value * mAspectRatio
        End If

        If booReady Then
            sCalcVideoBitRate()
        End If

    End Sub

    Private Sub nudVidWidth_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudVidWidth.ValueChanged

        If chkMaintainAR.Checked Then
            nudVidHeight.Value = nudVidWidth.Value / mAspectRatio
        End If

        If booReady Then
            sCalcVideoBitRate()
        End If
    End Sub

    Private Sub nudFrameRate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudFrameRate.ValueChanged

        If booReady Then
            sCalcVideoBitRate()
        End If

    End Sub

    Private Sub sResetAR()
        mAspectRatio = nudVidWidth.Value / nudVidHeight.Value
    End Sub

    Private Sub btnResetAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResetAR.Click
        Call sResetAR()
    End Sub
End Class
