Option Explicit On 
Imports System.IO
Friend Class frmWM9BC
    Inherits System.Windows.Forms.Form

    Dim strMovieName As String = "Movie Title here..."

#Region "Windows Form Designer generated code "
    Public Sub New()
        MyBase.New()
        If MyForm Is Nothing Then
            If InitializeForm Then
                MyForm = Me
            Else
                Try
                    'For the start-up form, the first instance created is the default instance.
                    If System.Reflection.Assembly.GetExecutingAssembly.EntryPoint.DeclaringType Is Me.GetType Then
                        MyForm = Me
                    End If
                Catch
                End Try
            End If
        End If
        'This call is required by the Windows Form Designer.
        InitializeComponent()
        Application.EnableVisualStyles()
        Application.DoEvents()

    End Sub
    Private Shared MyForm As frmWM9BC
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileTop As System.Windows.Forms.ToolStripMenuItem
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
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAudioMode As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuVideoMode As System.Windows.Forms.ToolStripMenuItem
    Private Shared InitializeForm As Boolean
    Public Shared Property MyEvent() As frmWM9BC
        Get
            If MyForm Is Nothing OrElse MyForm.IsDisposed Then
                InitializeForm = True
                MyForm = New frmWM9BC
                InitializeForm = False
            End If
            MyEvent = MyForm
        End Get
        Set(ByVal Value As frmWM9BC)
            MyForm = Value
        End Set
    End Property

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
    Public WithEvents fraFileSize As System.Windows.Forms.GroupBox
    Public WithEvents txtFileSize As System.Windows.Forms.TextBox
    Public WithEvents lblMB As System.Windows.Forms.Label
    Public WithEvents lblOf As System.Windows.Forms.Label
    Public WithEvents optCD As System.Windows.Forms.RadioButton
    Public WithEvents fraMovQuality As System.Windows.Forms.GroupBox
    Public WithEvents txtVideoQ As System.Windows.Forms.TextBox
    Public WithEvents cboAudioQ As System.Windows.Forms.ComboBox
    Public WithEvents lblKbps As System.Windows.Forms.Label
    Public WithEvents lblVideoBitRate As System.Windows.Forms.Label
    Public WithEvents lblAudioBitRate As System.Windows.Forms.Label
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents fraMovLength As System.Windows.Forms.GroupBox
    Public WithEvents lblSeconds As System.Windows.Forms.Label
    Public WithEvents lblMinutes As System.Windows.Forms.Label
    Public WithEvents lblHours As System.Windows.Forms.Label
    Public WithEvents imgCDR As System.Windows.Forms.PictureBox
    Public WithEvents imgDisk As System.Windows.Forms.PictureBox
    Public WithEvents lblOf2 As System.Windows.Forms.Label
    Public WithEvents cboCustomCDNumber As System.Windows.Forms.ComboBox
    Public WithEvents cboCDCDNumber As System.Windows.Forms.ComboBox
    Public WithEvents cboCDCDSize As System.Windows.Forms.ComboBox
    Public WithEvents optCustom As System.Windows.Forms.RadioButton
    Friend WithEvents nudCustomCDSize As System.Windows.Forms.NumericUpDown
    Public WithEvents imgDVDR As System.Windows.Forms.PictureBox
    Friend WithEvents lblPercent As System.Windows.Forms.Label
    Friend WithEvents nudPercent As System.Windows.Forms.NumericUpDown
    Public WithEvents cboSecs As System.Windows.Forms.ComboBox
    Public WithEvents cboMins As System.Windows.Forms.ComboBox
    Public WithEvents cboHours As System.Windows.Forms.ComboBox
    Public WithEvents picCamcorder As System.Windows.Forms.PictureBox
    Public WithEvents picCDAudio As System.Windows.Forms.PictureBox
    Friend WithEvents txtMovieName As System.Windows.Forms.TextBox
    Friend WithEvents hpHelp As System.Windows.Forms.HelpProvider
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWM9BC))
        Me.fraFileSize = New System.Windows.Forms.GroupBox
        Me.nudCustomCDSize = New System.Windows.Forms.NumericUpDown
        Me.cboCustomCDNumber = New System.Windows.Forms.ComboBox
        Me.txtFileSize = New System.Windows.Forms.TextBox
        Me.cboCDCDSize = New System.Windows.Forms.ComboBox
        Me.cboCDCDNumber = New System.Windows.Forms.ComboBox
        Me.imgDisk = New System.Windows.Forms.PictureBox
        Me.lblOf2 = New System.Windows.Forms.Label
        Me.lblMB = New System.Windows.Forms.Label
        Me.lblOf = New System.Windows.Forms.Label
        Me.optCD = New System.Windows.Forms.RadioButton
        Me.optCustom = New System.Windows.Forms.RadioButton
        Me.imgCDR = New System.Windows.Forms.PictureBox
        Me.imgDVDR = New System.Windows.Forms.PictureBox
        Me.fraMovQuality = New System.Windows.Forms.GroupBox
        Me.lblPercent = New System.Windows.Forms.Label
        Me.nudPercent = New System.Windows.Forms.NumericUpDown
        Me.txtVideoQ = New System.Windows.Forms.TextBox
        Me.cboAudioQ = New System.Windows.Forms.ComboBox
        Me.lblKbps = New System.Windows.Forms.Label
        Me.lblVideoBitRate = New System.Windows.Forms.Label
        Me.lblAudioBitRate = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.fraMovLength = New System.Windows.Forms.GroupBox
        Me.txtMovieName = New System.Windows.Forms.TextBox
        Me.lblSeconds = New System.Windows.Forms.Label
        Me.lblMinutes = New System.Windows.Forms.Label
        Me.lblHours = New System.Windows.Forms.Label
        Me.cboSecs = New System.Windows.Forms.ComboBox
        Me.cboMins = New System.Windows.Forms.ComboBox
        Me.cboHours = New System.Windows.Forms.ComboBox
        Me.picCamcorder = New System.Windows.Forms.PictureBox
        Me.picCDAudio = New System.Windows.Forms.PictureBox
        Me.hpHelp = New System.Windows.Forms.HelpProvider
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFileTop = New System.Windows.Forms.ToolStripMenuItem
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
        Me.ModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuAudioMode = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuVideoMode = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HomePageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SupportForumsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.miHelpUpdates = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.VersionHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.fraFileSize.SuspendLayout()
        CType(Me.nudCustomCDSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgDisk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgCDR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgDVDR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraMovQuality.SuspendLayout()
        CType(Me.nudPercent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraMovLength.SuspendLayout()
        CType(Me.picCamcorder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCDAudio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'fraFileSize
        '
        Me.fraFileSize.BackColor = System.Drawing.SystemColors.Control
        Me.fraFileSize.Controls.Add(Me.nudCustomCDSize)
        Me.fraFileSize.Controls.Add(Me.cboCustomCDNumber)
        Me.fraFileSize.Controls.Add(Me.txtFileSize)
        Me.fraFileSize.Controls.Add(Me.cboCDCDSize)
        Me.fraFileSize.Controls.Add(Me.cboCDCDNumber)
        Me.fraFileSize.Controls.Add(Me.imgDisk)
        Me.fraFileSize.Controls.Add(Me.lblOf2)
        Me.fraFileSize.Controls.Add(Me.lblMB)
        Me.fraFileSize.Controls.Add(Me.lblOf)
        Me.fraFileSize.Controls.Add(Me.optCD)
        Me.fraFileSize.Controls.Add(Me.optCustom)
        Me.fraFileSize.Controls.Add(Me.imgCDR)
        Me.fraFileSize.Controls.Add(Me.imgDVDR)
        Me.fraFileSize.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.fraFileSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraFileSize.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraFileSize.Location = New System.Drawing.Point(4, 104)
        Me.fraFileSize.Name = "fraFileSize"
        Me.fraFileSize.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraFileSize.Size = New System.Drawing.Size(273, 137)
        Me.fraFileSize.TabIndex = 16
        Me.fraFileSize.TabStop = False
        Me.fraFileSize.Text = "Target File Size"
        '
        'nudCustomCDSize
        '
        Me.nudCustomCDSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudCustomCDSize.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.nudCustomCDSize.Location = New System.Drawing.Point(176, 104)
        Me.nudCustomCDSize.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.nudCustomCDSize.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudCustomCDSize.Name = "nudCustomCDSize"
        Me.nudCustomCDSize.Size = New System.Drawing.Size(56, 20)
        Me.nudCustomCDSize.TabIndex = 25
        Me.nudCustomCDSize.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'cboCustomCDNumber
        '
        Me.cboCustomCDNumber.BackColor = System.Drawing.SystemColors.Window
        Me.cboCustomCDNumber.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboCustomCDNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCustomCDNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCustomCDNumber.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboCustomCDNumber.Location = New System.Drawing.Point(56, 104)
        Me.cboCustomCDNumber.Name = "cboCustomCDNumber"
        Me.cboCustomCDNumber.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboCustomCDNumber.Size = New System.Drawing.Size(89, 21)
        Me.cboCustomCDNumber.TabIndex = 7
        '
        'txtFileSize
        '
        Me.txtFileSize.AcceptsReturn = True
        Me.txtFileSize.BackColor = System.Drawing.SystemColors.Window
        Me.txtFileSize.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFileSize.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFileSize.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFileSize.Location = New System.Drawing.Point(56, 104)
        Me.txtFileSize.MaxLength = 4
        Me.txtFileSize.Name = "txtFileSize"
        Me.txtFileSize.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFileSize.Size = New System.Drawing.Size(57, 20)
        Me.txtFileSize.TabIndex = 8
        Me.txtFileSize.Visible = False
        '
        'cboCDCDSize
        '
        Me.cboCDCDSize.BackColor = System.Drawing.SystemColors.Window
        Me.cboCDCDSize.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboCDCDSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCDCDSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCDCDSize.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboCDCDSize.Location = New System.Drawing.Point(176, 48)
        Me.cboCDCDSize.Name = "cboCDCDSize"
        Me.cboCDCDSize.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboCDCDSize.Size = New System.Drawing.Size(81, 21)
        Me.cboCDCDSize.TabIndex = 5
        '
        'cboCDCDNumber
        '
        Me.cboCDCDNumber.BackColor = System.Drawing.SystemColors.Window
        Me.cboCDCDNumber.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboCDCDNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCDCDNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCDCDNumber.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboCDCDNumber.Location = New System.Drawing.Point(56, 48)
        Me.cboCDCDNumber.Name = "cboCDCDNumber"
        Me.cboCDCDNumber.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboCDCDNumber.Size = New System.Drawing.Size(89, 21)
        Me.cboCDCDNumber.TabIndex = 4
        '
        'imgDisk
        '
        Me.imgDisk.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgDisk.Image = CType(resources.GetObject("imgDisk.Image"), System.Drawing.Image)
        Me.imgDisk.Location = New System.Drawing.Point(8, 88)
        Me.imgDisk.Name = "imgDisk"
        Me.imgDisk.Size = New System.Drawing.Size(32, 32)
        Me.imgDisk.TabIndex = 24
        Me.imgDisk.TabStop = False
        '
        'lblOf2
        '
        Me.lblOf2.AutoSize = True
        Me.lblOf2.BackColor = System.Drawing.SystemColors.Control
        Me.lblOf2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblOf2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOf2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblOf2.Location = New System.Drawing.Point(155, 104)
        Me.lblOf2.Name = "lblOf2"
        Me.lblOf2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblOf2.Size = New System.Drawing.Size(18, 16)
        Me.lblOf2.TabIndex = 24
        Me.lblOf2.Text = "of"
        '
        'lblMB
        '
        Me.lblMB.BackColor = System.Drawing.SystemColors.Control
        Me.lblMB.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMB.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMB.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMB.Location = New System.Drawing.Point(239, 106)
        Me.lblMB.Name = "lblMB"
        Me.lblMB.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMB.Size = New System.Drawing.Size(25, 16)
        Me.lblMB.TabIndex = 23
        Me.lblMB.Text = "MiB"
        '
        'lblOf
        '
        Me.lblOf.AutoSize = True
        Me.lblOf.BackColor = System.Drawing.SystemColors.Control
        Me.lblOf.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblOf.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOf.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblOf.Location = New System.Drawing.Point(155, 52)
        Me.lblOf.Name = "lblOf"
        Me.lblOf.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblOf.Size = New System.Drawing.Size(18, 16)
        Me.lblOf.TabIndex = 17
        Me.lblOf.Text = "of"
        '
        'optCD
        '
        Me.optCD.BackColor = System.Drawing.SystemColors.Control
        Me.optCD.Cursor = System.Windows.Forms.Cursors.Default
        Me.optCD.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.optCD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optCD.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optCD.Location = New System.Drawing.Point(56, 24)
        Me.optCD.Name = "optCD"
        Me.optCD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optCD.Size = New System.Drawing.Size(145, 17)
        Me.optCD.TabIndex = 3
        Me.optCD.TabStop = True
        Me.optCD.Text = "Disk Size Based"
        Me.ToolTip1.SetToolTip(Me.optCD, " Useful in Data CD/DVD Creation ")
        Me.optCD.UseVisualStyleBackColor = False
        '
        'optCustom
        '
        Me.optCustom.BackColor = System.Drawing.SystemColors.Control
        Me.optCustom.Cursor = System.Windows.Forms.Cursors.Default
        Me.optCustom.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.optCustom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optCustom.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optCustom.Location = New System.Drawing.Point(56, 80)
        Me.optCustom.Name = "optCustom"
        Me.optCustom.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optCustom.Size = New System.Drawing.Size(129, 17)
        Me.optCustom.TabIndex = 6
        Me.optCustom.TabStop = True
        Me.optCustom.Text = "Custom Size Based"
        Me.ToolTip1.SetToolTip(Me.optCustom, " Useful in VCD/SVCD Creation ")
        Me.optCustom.UseVisualStyleBackColor = False
        '
        'imgCDR
        '
        Me.imgCDR.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgCDR.Image = CType(resources.GetObject("imgCDR.Image"), System.Drawing.Image)
        Me.imgCDR.Location = New System.Drawing.Point(8, 32)
        Me.imgCDR.Name = "imgCDR"
        Me.imgCDR.Size = New System.Drawing.Size(32, 32)
        Me.imgCDR.TabIndex = 23
        Me.imgCDR.TabStop = False
        '
        'imgDVDR
        '
        Me.imgDVDR.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgDVDR.Image = CType(resources.GetObject("imgDVDR.Image"), System.Drawing.Image)
        Me.imgDVDR.Location = New System.Drawing.Point(8, 32)
        Me.imgDVDR.Name = "imgDVDR"
        Me.imgDVDR.Size = New System.Drawing.Size(32, 32)
        Me.imgDVDR.TabIndex = 26
        Me.imgDVDR.TabStop = False
        Me.imgDVDR.Visible = False
        '
        'fraMovQuality
        '
        Me.fraMovQuality.BackColor = System.Drawing.SystemColors.Control
        Me.fraMovQuality.Controls.Add(Me.lblPercent)
        Me.fraMovQuality.Controls.Add(Me.nudPercent)
        Me.fraMovQuality.Controls.Add(Me.txtVideoQ)
        Me.fraMovQuality.Controls.Add(Me.cboAudioQ)
        Me.fraMovQuality.Controls.Add(Me.lblKbps)
        Me.fraMovQuality.Controls.Add(Me.lblVideoBitRate)
        Me.fraMovQuality.Controls.Add(Me.lblAudioBitRate)
        Me.fraMovQuality.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.fraMovQuality.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraMovQuality.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraMovQuality.Location = New System.Drawing.Point(4, 247)
        Me.fraMovQuality.Name = "fraMovQuality"
        Me.fraMovQuality.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraMovQuality.Size = New System.Drawing.Size(273, 75)
        Me.fraMovQuality.TabIndex = 15
        Me.fraMovQuality.TabStop = False
        Me.fraMovQuality.Text = "Movie Quality"
        '
        'lblPercent
        '
        Me.lblPercent.AutoSize = True
        Me.lblPercent.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblPercent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercent.Location = New System.Drawing.Point(252, 16)
        Me.lblPercent.Name = "lblPercent"
        Me.lblPercent.Size = New System.Drawing.Size(15, 13)
        Me.lblPercent.TabIndex = 23
        Me.lblPercent.Text = "%"
        Me.ToolTip1.SetToolTip(Me.lblPercent, " Percentage Error ")
        '
        'nudPercent
        '
        Me.nudPercent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudPercent.Location = New System.Drawing.Point(218, 16)
        Me.nudPercent.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.nudPercent.Minimum = New Decimal(New Integer() {9, 0, 0, -2147483648})
        Me.nudPercent.Name = "nudPercent"
        Me.nudPercent.ReadOnly = True
        Me.nudPercent.Size = New System.Drawing.Size(32, 20)
        Me.nudPercent.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.nudPercent, " Percentage Error ")
        '
        'txtVideoQ
        '
        Me.txtVideoQ.AcceptsReturn = True
        Me.txtVideoQ.BackColor = System.Drawing.SystemColors.Control
        Me.txtVideoQ.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVideoQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVideoQ.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtVideoQ.Location = New System.Drawing.Point(114, 43)
        Me.txtVideoQ.MaxLength = 0
        Me.txtVideoQ.Name = "txtVideoQ"
        Me.txtVideoQ.ReadOnly = True
        Me.txtVideoQ.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtVideoQ.Size = New System.Drawing.Size(111, 20)
        Me.txtVideoQ.TabIndex = 10
        Me.txtVideoQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtVideoQ, " Press Ctrl + C to Copy ")
        '
        'cboAudioQ
        '
        Me.cboAudioQ.BackColor = System.Drawing.SystemColors.Window
        Me.cboAudioQ.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboAudioQ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAudioQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAudioQ.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboAudioQ.Location = New System.Drawing.Point(16, 43)
        Me.cboAudioQ.Name = "cboAudioQ"
        Me.cboAudioQ.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboAudioQ.Size = New System.Drawing.Size(86, 21)
        Me.cboAudioQ.TabIndex = 9
        '
        'lblKbps
        '
        Me.lblKbps.AutoSize = True
        Me.lblKbps.BackColor = System.Drawing.SystemColors.Control
        Me.lblKbps.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblKbps.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKbps.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblKbps.Location = New System.Drawing.Point(231, 46)
        Me.lblKbps.Name = "lblKbps"
        Me.lblKbps.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblKbps.Size = New System.Drawing.Size(36, 14)
        Me.lblKbps.TabIndex = 21
        Me.lblKbps.Text = "Kibit/s"
        '
        'lblVideoBitRate
        '
        Me.lblVideoBitRate.BackColor = System.Drawing.SystemColors.Control
        Me.lblVideoBitRate.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblVideoBitRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVideoBitRate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblVideoBitRate.Location = New System.Drawing.Point(114, 24)
        Me.lblVideoBitRate.Name = "lblVideoBitRate"
        Me.lblVideoBitRate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblVideoBitRate.Size = New System.Drawing.Size(104, 17)
        Me.lblVideoBitRate.TabIndex = 19
        Me.lblVideoBitRate.Text = "Video bit Rate"
        '
        'lblAudioBitRate
        '
        Me.lblAudioBitRate.BackColor = System.Drawing.SystemColors.Control
        Me.lblAudioBitRate.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAudioBitRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAudioBitRate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAudioBitRate.Location = New System.Drawing.Point(16, 24)
        Me.lblAudioBitRate.Name = "lblAudioBitRate"
        Me.lblAudioBitRate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAudioBitRate.Size = New System.Drawing.Size(92, 15)
        Me.lblAudioBitRate.TabIndex = 18
        Me.lblAudioBitRate.Text = "Audio bit Rate"
        '
        'fraMovLength
        '
        Me.fraMovLength.BackColor = System.Drawing.SystemColors.Control
        Me.fraMovLength.Controls.Add(Me.txtMovieName)
        Me.fraMovLength.Controls.Add(Me.lblSeconds)
        Me.fraMovLength.Controls.Add(Me.lblMinutes)
        Me.fraMovLength.Controls.Add(Me.lblHours)
        Me.fraMovLength.Controls.Add(Me.cboSecs)
        Me.fraMovLength.Controls.Add(Me.cboMins)
        Me.fraMovLength.Controls.Add(Me.cboHours)
        Me.fraMovLength.Controls.Add(Me.picCamcorder)
        Me.fraMovLength.Controls.Add(Me.picCDAudio)
        Me.fraMovLength.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.fraMovLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraMovLength.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraMovLength.Location = New System.Drawing.Point(4, 27)
        Me.fraMovLength.Name = "fraMovLength"
        Me.fraMovLength.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraMovLength.Size = New System.Drawing.Size(273, 71)
        Me.fraMovLength.TabIndex = 14
        Me.fraMovLength.TabStop = False
        Me.fraMovLength.Text = "Movie Length"
        '
        'txtMovieName
        '
        Me.txtMovieName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hpHelp.SetHelpString(Me.txtMovieName, "Type the Name of the Movie you are Encoding")
        Me.txtMovieName.Location = New System.Drawing.Point(128, 0)
        Me.txtMovieName.Name = "txtMovieName"
        Me.hpHelp.SetShowHelp(Me.txtMovieName, True)
        Me.txtMovieName.Size = New System.Drawing.Size(128, 20)
        Me.txtMovieName.TabIndex = 18
        '
        'lblSeconds
        '
        Me.lblSeconds.AutoSize = True
        Me.lblSeconds.BackColor = System.Drawing.SystemColors.Control
        Me.lblSeconds.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSeconds.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeconds.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSeconds.Location = New System.Drawing.Point(200, 24)
        Me.lblSeconds.Name = "lblSeconds"
        Me.lblSeconds.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSeconds.Size = New System.Drawing.Size(49, 13)
        Me.lblSeconds.TabIndex = 16
        Me.lblSeconds.Text = "Seconds"
        '
        'lblMinutes
        '
        Me.lblMinutes.AutoSize = True
        Me.lblMinutes.BackColor = System.Drawing.SystemColors.Control
        Me.lblMinutes.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMinutes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinutes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMinutes.Location = New System.Drawing.Point(128, 24)
        Me.lblMinutes.Name = "lblMinutes"
        Me.lblMinutes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMinutes.Size = New System.Drawing.Size(44, 13)
        Me.lblMinutes.TabIndex = 15
        Me.lblMinutes.Text = "Minutes"
        '
        'lblHours
        '
        Me.lblHours.AutoSize = True
        Me.lblHours.BackColor = System.Drawing.SystemColors.Control
        Me.lblHours.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHours.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblHours.Location = New System.Drawing.Point(56, 24)
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
        Me.cboSecs.Location = New System.Drawing.Point(200, 40)
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
        Me.cboMins.Location = New System.Drawing.Point(128, 40)
        Me.cboMins.MaxLength = 2
        Me.cboMins.Name = "cboMins"
        Me.cboMins.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboMins.Size = New System.Drawing.Size(57, 21)
        Me.cboMins.TabIndex = 1
        '
        'cboHours
        '
        Me.cboHours.BackColor = System.Drawing.SystemColors.Window
        Me.cboHours.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboHours.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboHours.Location = New System.Drawing.Point(56, 40)
        Me.cboHours.MaxLength = 2
        Me.cboHours.Name = "cboHours"
        Me.cboHours.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboHours.Size = New System.Drawing.Size(57, 21)
        Me.cboHours.TabIndex = 0
        '
        'picCamcorder
        '
        Me.picCamcorder.Cursor = System.Windows.Forms.Cursors.Default
        Me.picCamcorder.Image = CType(resources.GetObject("picCamcorder.Image"), System.Drawing.Image)
        Me.picCamcorder.Location = New System.Drawing.Point(8, 24)
        Me.picCamcorder.Name = "picCamcorder"
        Me.picCamcorder.Size = New System.Drawing.Size(32, 32)
        Me.picCamcorder.TabIndex = 3
        Me.picCamcorder.TabStop = False
        '
        'picCDAudio
        '
        Me.picCDAudio.Cursor = System.Windows.Forms.Cursors.Default
        Me.picCDAudio.Image = CType(resources.GetObject("picCDAudio.Image"), System.Drawing.Image)
        Me.picCDAudio.Location = New System.Drawing.Point(8, 24)
        Me.picCDAudio.Name = "picCDAudio"
        Me.picCDAudio.Size = New System.Drawing.Size(32, 32)
        Me.picCDAudio.TabIndex = 17
        Me.picCDAudio.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.ModeToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(292, 24)
        Me.MenuStrip1.TabIndex = 19
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileTop, Me.OpenLogToolStripMenuItem, Me.ToolStripSeparator3, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'mnuFileTop
        '
        Me.mnuFileTop.Name = "mnuFileTop"
        Me.mnuFileTop.Size = New System.Drawing.Size(183, 22)
        Me.mnuFileTop.Text = "Always On &Top"
        '
        'OpenLogToolStripMenuItem
        '
        Me.OpenLogToolStripMenuItem.Name = "OpenLogToolStripMenuItem"
        Me.OpenLogToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenLogToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.OpenLogToolStripMenuItem.Text = "&Open Log..."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(180, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyVideoBitRateToolStripMenuItem, Me.CopyVideoBitRateToolStripMenuItem1, Me.mnuEditLog})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'CopyVideoBitRateToolStripMenuItem
        '
        Me.CopyVideoBitRateToolStripMenuItem.Name = "CopyVideoBitRateToolStripMenuItem"
        Me.CopyVideoBitRateToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyVideoBitRateToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.CopyVideoBitRateToolStripMenuItem.Text = "&Copy Video Bit Rate"
        '
        'CopyVideoBitRateToolStripMenuItem1
        '
        Me.CopyVideoBitRateToolStripMenuItem1.Name = "CopyVideoBitRateToolStripMenuItem1"
        Me.CopyVideoBitRateToolStripMenuItem1.Size = New System.Drawing.Size(219, 22)
        Me.CopyVideoBitRateToolStripMenuItem1.Text = "Save to Notepad"
        '
        'mnuEditLog
        '
        Me.mnuEditLog.Checked = True
        Me.mnuEditLog.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuEditLog.Name = "mnuEditLog"
        Me.mnuEditLog.Size = New System.Drawing.Size(219, 22)
        Me.mnuEditLog.Text = "Save to Log"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TotalFramesCalculatorToolStripMenuItem, Me.MovieResolutionCalculatorToolStripMenuItem, Me.ToolStripSeparator1, Me.WindowsMediaEncoderToolStripMenuItem, Me.WindowsMediaPlayerToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'TotalFramesCalculatorToolStripMenuItem
        '
        Me.TotalFramesCalculatorToolStripMenuItem.Name = "TotalFramesCalculatorToolStripMenuItem"
        Me.TotalFramesCalculatorToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.TotalFramesCalculatorToolStripMenuItem.Text = "Total Frames Calculator"
        '
        'MovieResolutionCalculatorToolStripMenuItem
        '
        Me.MovieResolutionCalculatorToolStripMenuItem.Name = "MovieResolutionCalculatorToolStripMenuItem"
        Me.MovieResolutionCalculatorToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.MovieResolutionCalculatorToolStripMenuItem.Text = "Movie Resolution Calculator"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(214, 6)
        '
        'WindowsMediaEncoderToolStripMenuItem
        '
        Me.WindowsMediaEncoderToolStripMenuItem.Name = "WindowsMediaEncoderToolStripMenuItem"
        Me.WindowsMediaEncoderToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.WindowsMediaEncoderToolStripMenuItem.Text = "Windows Media Encoder"
        '
        'WindowsMediaPlayerToolStripMenuItem
        '
        Me.WindowsMediaPlayerToolStripMenuItem.Name = "WindowsMediaPlayerToolStripMenuItem"
        Me.WindowsMediaPlayerToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.WindowsMediaPlayerToolStripMenuItem.Text = "Windows Media Player"
        '
        'ModeToolStripMenuItem
        '
        Me.ModeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAudioMode, Me.mnuVideoMode})
        Me.ModeToolStripMenuItem.Name = "ModeToolStripMenuItem"
        Me.ModeToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.ModeToolStripMenuItem.Text = "&Mode"
        '
        'mnuAudioMode
        '
        Me.mnuAudioMode.Name = "mnuAudioMode"
        Me.mnuAudioMode.Size = New System.Drawing.Size(141, 22)
        Me.mnuAudioMode.Text = "&Audio Mode"
        '
        'mnuVideoMode
        '
        Me.mnuVideoMode.Name = "mnuVideoMode"
        Me.mnuVideoMode.Size = New System.Drawing.Size(141, 22)
        Me.mnuVideoMode.Text = "&Video Mode"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomePageToolStripMenuItem, Me.SupportForumsToolStripMenuItem, Me.miHelpUpdates, Me.ToolStripSeparator2, Me.VersionHistoryToolStripMenuItem, Me.ToolStripMenuItem3})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'HomePageToolStripMenuItem
        '
        Me.HomePageToolStripMenuItem.Name = "HomePageToolStripMenuItem"
        Me.HomePageToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.HomePageToolStripMenuItem.Text = "Home Page..."
        '
        'SupportForumsToolStripMenuItem
        '
        Me.SupportForumsToolStripMenuItem.Name = "SupportForumsToolStripMenuItem"
        Me.SupportForumsToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.SupportForumsToolStripMenuItem.Text = "Support Forums..."
        '
        'miHelpUpdates
        '
        Me.miHelpUpdates.Name = "miHelpUpdates"
        Me.miHelpUpdates.Size = New System.Drawing.Size(181, 22)
        Me.miHelpUpdates.Text = "&Check for Update..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(178, 6)
        '
        'VersionHistoryToolStripMenuItem
        '
        Me.VersionHistoryToolStripMenuItem.Name = "VersionHistoryToolStripMenuItem"
        Me.VersionHistoryToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.VersionHistoryToolStripMenuItem.Text = "&Version History..."
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(181, 22)
        Me.ToolStripMenuItem3.Text = "&About..."
        '
        'frmWM9BC
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 333)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.fraMovLength)
        Me.Controls.Add(Me.fraFileSize)
        Me.Controls.Add(Me.fraMovQuality)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmWM9BC"
        Me.Text = "Form1"
        Me.fraFileSize.ResumeLayout(False)
        Me.fraFileSize.PerformLayout()
        CType(Me.nudCustomCDSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgDisk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgCDR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgDVDR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraMovQuality.ResumeLayout(False)
        Me.fraMovQuality.PerformLayout()
        CType(Me.nudPercent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraMovLength.ResumeLayout(False)
        Me.fraMovLength.PerformLayout()
        CType(Me.picCamcorder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCDAudio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmwm9bc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.ClientSize = New System.Drawing.Size(296, 339)
        Me.Text = Application.ProductName + " " + Application.ProductVersion.Substring(0, 3)
        Me.txtMovieName.Text = strMovieName
        Call ComboBoxValues()
        Call GetAllSettings()
        Call Calculation()
    End Sub

    Private Sub mnuHelpAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim OpenAbout As New frmAboutWM9BC
        OpenAbout.ShowDialog()
    End Sub

    Private Sub mnuHelpVersionHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim version As New frmVer
        version.ShowDialog()

    End Sub


    Private Sub mnuToolsTotalFrames_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'MsgBox("Sorry, the feature you requested is not available in this version.", MsgBoxStyle.Exclamation, Application.ProductName)
        frmTotalFrames.MyEvent.Show()
    End Sub

    Private Sub mnuToolsMovieRes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim OpenMovieRes As New frmMovRes
        With OpenMovieRes
            .Show()
        End With
    End Sub

    Sub SaveAllSettings()
        Try
            'Window
            AppSettingsManager.LoadAndSetValue("WindowLeft", Me.Left)
            AppSettingsManager.LoadAndSetValue("WindowTop", Me.Top)
            'Settings
            AppSettingsManager.LoadAndSetValue("AlwaysOnTop", mnuFileTop.Checked)
            AppSettingsManager.LoadAndSetValue("CDSizeBased", optCD.Checked)
            AppSettingsManager.LoadAndSetValue("CustomSizeBased", optCustom.Checked)
            AppSettingsManager.LoadAndSetValue("SaveToLog", mnuEditLog.Checked)

            'Movie Length
            AppSettingsManager.LoadAndSetValue("Hours", cboHours.Text)
            AppSettingsManager.LoadAndSetValue("Minutes", cboMins.Text)
            AppSettingsManager.LoadAndSetValue("Seconds", cboSecs.Text)
            'File Size
            AppSettingsManager.LoadAndSetValue("CDCDNumber", cboCDCDNumber.SelectedIndex)
            AppSettingsManager.LoadAndSetValue("CDCDSize", cboCDCDSize.SelectedIndex)
            AppSettingsManager.LoadAndSetValue("CustomCDNumber", cboCustomCDNumber.SelectedIndex)
            AppSettingsManager.LoadAndSetValue("CustomCDSize", nudCustomCDSize.Text)
            'Audio Quality
            AppSettingsManager.LoadAndSetValue("AudioQ", cboAudioQ.SelectedIndex)
        Catch ex As Exception
            Try
                Dim xmlConfig As New Xml.XmlDocument
                xmlConfig.AppendChild(xmlConfig.CreateXmlDeclaration("1.0", "UTF-8", String.Empty))
                Dim xmlrootConfiguration As Xml.XmlNode = xmlConfig.CreateElement("configuration")
                xmlConfig.AppendChild(xmlrootConfiguration)
                Dim xmlAppSettings As Xml.XmlNode = xmlConfig.CreateElement("appSettings")
                xmlrootConfiguration.AppendChild(xmlAppSettings)
                Dim xmlAdd(14) As Xml.XmlElement
                For i As Integer = 1 To 14
                    xmlAdd(i) = xmlConfig.CreateElement("add")
                    With xmlAdd(i)
                        .Attributes.Append(xmlConfig.CreateAttribute("key"))
                        .Attributes.Append(xmlConfig.CreateAttribute("value"))
                    End With
                    xmlAppSettings.AppendChild(xmlAdd(i))
                Next
                xmlAdd(1).Attributes("key").Value = "WindowLeft"
                xmlAdd(1).Attributes("value").Value = "-100"
                xmlAdd(2).Attributes("key").Value = "WindowTop"
                xmlAdd(2).Attributes("value").Value = "-100"
                xmlAdd(3).Attributes("key").Value = "AlwaysOnTop"
                xmlAdd(3).Attributes("value").Value = "False"
                xmlAdd(4).Attributes("key").Value = "CustomSizeBased"
                xmlAdd(4).Attributes("value").Value = "true"
                xmlAdd(5).Attributes("key").Value = "CDSizeBased"
                xmlAdd(5).Attributes("value").Value = "true"
                xmlAdd(6).Attributes("key").Value = "Hours"
                xmlAdd(6).Attributes("value").Value = "2"
                xmlAdd(7).Attributes("key").Value = "Minutes"
                xmlAdd(7).Attributes("value").Value = "0"
                xmlAdd(8).Attributes("key").Value = "Seconds"
                xmlAdd(8).Attributes("value").Value = "0"
                xmlAdd(9).Attributes("key").Value = "CDCDNumber"
                xmlAdd(9).Attributes("value").Value = "2"
                xmlAdd(10).Attributes("key").Value = "CDCDSize"
                xmlAdd(10).Attributes("value").Value = "1"
                xmlAdd(11).Attributes("key").Value = "CustomCDNumber"
                xmlAdd(11).Attributes("value").Value = "2"
                xmlAdd(12).Attributes("key").Value = "CustomCDSize"
                xmlAdd(12).Attributes("value").Value = "797"
                xmlAdd(13).Attributes("key").Value = "AudioQ"
                xmlAdd(13).Attributes("value").Value = "0"
                xmlAdd(14).Attributes("key").Value = "SaveToLog"
                xmlAdd(14).Attributes("value").Value = "True"
                Dim myWriter As New Xml.XmlTextWriter(Application.ExecutablePath + ".config", System.Text.Encoding.UTF8)
                myWriter.Formatting = Xml.Formatting.Indented
                xmlConfig.Save(myWriter)
                myWriter.Close()
            Catch e As Exception

            End Try

        End Try

    End Sub
    Sub GetAllSettings()
        Try
            'Window
            Me.Left = AppSettingsManager.LoadAndGetValue("WindowLeft")
            Me.Top = AppSettingsManager.LoadAndGetValue("WindowTop")
            If Me.Left = -100 Or Me.Left = -100 Then 'Out of Screen at Resolution 1280 * 1024
                Me.Left = (System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width - Me.Width) / 2
                Me.Top = (System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width - Me.Height) / 3
            End If
            cboHours.Text = AppSettingsManager.LoadAndGetValue("Hours")
            cboMins.Text = AppSettingsManager.LoadAndGetValue("Minutes")
            cboSecs.Text = AppSettingsManager.LoadAndGetValue("Seconds")
            'Settings
            mnuFileTop.Checked = AppSettingsManager.LoadAndGetValue("AlwaysOnTop")
            optCustom.Checked = AppSettingsManager.LoadAndGetValue("CustomSizeBased")
            optCD.Checked = AppSettingsManager.LoadAndGetValue("CDSizeBased")
            mnuEditLog.Checked = AppSettingsManager.LoadAndGetValue("SaveToLog")
        Catch ex As Exception
            'Window
            Me.Left = (System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width - Me.Width) / 2
            Me.Top = (System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width - Me.Height) / 3
            cboHours.Text = 2
            cboMins.Text = 0
            cboSecs.Text = 0
            'Settings
            mnuFileTop.Checked = False
            optCustom.Checked = False
            optCD.Checked = True
            mnuEditLog.Checked = True
        End Try

        If mnuFileTop.Checked = True Then Me.TopMost = True Else Me.TopMost = False
        'Movie Length
        'The rest are loaded in ComboValues
    End Sub

    Private Function fGetFileSizeInBits() As Single

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

        ElseIf optCustom.Checked AndAlso Not nudCustomCDSize.Text = "0" Then

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

        Return sngFileSize * 8

    End Function

    Sub Calculation()
        If IsNumeric(cboHours.Text) = True AndAlso Len(cboHours.Text) > 0 AndAlso _
        IsNumeric(cboMins.Text) = True AndAlso Len(cboMins.Text) > 0 AndAlso _
        IsNumeric(cboSecs.Text) = True AndAlso Len(cboSecs.Text) > 0 AndAlso _
        optCD.Checked OrElse optCustom.Checked Then
            Try
                Call frmTotalFrames.MyEvent.MovieLengthCalc()
                'MsgBox("count")
                Dim sngSecs, sngMins, sngHours, sngLength, sngAudioBits, sngVideoBits, sngVideoQ As Single

                Dim sngFileSizeInBits As Single = fGetFileSizeInBits() 'Bits

                lblKbps.Visible = True
                txtVideoQ.ForeColor = System.Drawing.Color.Black

                Dim strCDCDNumber As String = cboCDCDNumber.Text
                Dim sngCDCDNumber() As String = Split(strCDCDNumber, " ")
                Dim strCDCDSize As String = cboCDCDSize.Text
                Dim sngCDCDSize() As String = Split(strCDCDSize, " ")

                Dim strCustomCDNumber As String = cboCustomCDNumber.Text
                Dim sngCustomCDNumber() As String = Split(strCustomCDNumber, " ")

                Dim strAudioQ As String = cboAudioQ.Text
                Dim sngAudioQ() As String = Split(strAudioQ, " ")

                sngSecs = CSng(cboSecs.Text)
                sngMins = CSng(cboMins.Text)
                sngHours = CSng(cboHours.Text)
                sngLength = (sngHours * 3600) + (sngMins * 60) + sngSecs 'Movie length in seconds
                If sngLength = 0 Then
                    txtVideoQ.Text = "000"
                    Exit Sub
                End If

                sngAudioBits = sngAudioQ(0) * sngLength * 1024 'Audio in Bits
                'Console.WriteLine(sngAudioBits)
                sngVideoBits = sngFileSizeInBits - sngAudioBits 'Video in Bits
                'Console.WriteLine(sngFileSizeInBits / (1024 * 1024 * 8))

                If sngVideoBits < 0 Then
                    lblKbps.Visible = False
                    txtVideoQ.Text = "Increase File Size!"
                    txtVideoQ.ForeColor = System.Drawing.Color.Red
                    Exit Sub
                End If

                sngVideoQ = (sngVideoBits / sngLength) / (1024) 'Video in Kibps

                txtVideoQ.Text = FormatNumber(sngVideoQ - 0.5, 0, , , TriState.False)     'Video in (Kbps - 0.5) to the nearest whole number
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, Application.ProductName)
                Exit Try
            End Try
        End If
    End Sub

    Private Sub cboCDCDNumber_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCDCDNumber.SelectedIndexChanged

        nudPercent.Text = 0
        Call Calculation()

    End Sub

    Private Sub cboCustomCDNumber_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCustomCDNumber.SelectedIndexChanged

        nudPercent.Text = 0
        Call Calculation()

    End Sub
    Sub ComboBoxValues()

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

        Dim lFractions() As String = {"1/24", "1/12", "1/6", "1/3", "1/4", "1/2", "2/3"}

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
        cboCDCDSize.Items.Add("2.60 GB")
        cboCDCDSize.Items.Add("3.95 GB")
        cboCDCDSize.Items.Add("4.70 GB")

        'Loading values for Audio Bitrate

        cboAudioQ.Items.Add("192 Kibit/s")
        cboAudioQ.Items.Add("384 Kibit/s")
        cboAudioQ.Items.Add("000 Kibit/s")
        cboAudioQ.Items.Add("048 Kibit/s")
        cboAudioQ.Items.Add("064 Kibit/s")
        cboAudioQ.Items.Add("096 Kibit/s")
        cboAudioQ.Items.Add("128 Kibit/s")
        cboAudioQ.Items.Add("160 Kibit/s")
        cboAudioQ.Items.Add("224 Kibit/s")
        cboAudioQ.Items.Add("256 Kibit/s")
        cboAudioQ.Items.Add("320 Kibit/s")
        cboAudioQ.Items.Add("440 Kibit/s")
        cboAudioQ.Items.Add("640 Kibit/s")
        cboAudioQ.Items.Add("768 Kibit/s")

        Try
            cboAudioQ.SelectedIndex = AppSettingsManager.LoadAndGetValue("AudioQ")
            cboCDCDSize.SelectedIndex = AppSettingsManager.LoadAndGetValue("CDCDSize")
            cboCDCDNumber.SelectedIndex = AppSettingsManager.LoadAndGetValue("CDCDNumber")
            cboCustomCDNumber.SelectedIndex = AppSettingsManager.LoadAndGetValue("CustomCDNumber")
            nudCustomCDSize.Text = AppSettingsManager.LoadAndGetValue("CustomCDSize")
        Catch ex As Exception
            cboAudioQ.SelectedIndex = 0
            cboCDCDSize.SelectedIndex = 1
            cboCDCDNumber.SelectedIndex = 2
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
        Call Calculation()
    End Sub

    Private Sub optCustom_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optCustom.CheckedChanged
        nudPercent.Text = 0
        nudCustomCDSize.ReadOnly = False 'Unlocks the text box
        nudCustomCDSize.Focus()
        cboCustomCDNumber.Enabled = True
        cboCDCDSize.Enabled = False
        cboCDCDNumber.Enabled = False
        'Call Calculation()
    End Sub

    Private Sub mnuToolsWME9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If File.Exists(Environ("SystemDrive") & ("\Program Files\Windows Media Components\Encoder\wmenc.exe")) Then
            Shell(Environ("SystemDrive") & ("\Program Files\Windows Media Components\Encoder\wmenc.exe"))
        Else
            MsgBox("Windows Media Encoder 9 is either not installed or installed in a different location.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Error!")
        End If
    End Sub

    Private Sub mnuFileTop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileTop.Click
        mnuFileTop.Checked = Not mnuFileTop.Checked
        If mnuFileTop.Checked = True Then Me.TopMost = True Else Me.TopMost = False
    End Sub

    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call SaveAllSettings()
        Me.Close()
    End Sub

    Private Sub mnuEditCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim datobj As New System.Windows.Forms.DataObject
        datobj.SetData(System.Windows.Forms.DataFormats.Text, txtVideoQ.Text)
        System.Windows.Forms.Clipboard.SetDataObject(datobj)
    End Sub

    Private Sub mnuToolsWMP9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If File.Exists(Environ("SystemDrive") & ("\Program Files\Windows Media Player\wmplayer.exe")) Then
            Shell(Environ("SystemDrive") & ("\Program Files\Windows Media Player\wmplayer.exe"))
        Else
            MsgBox("Windows Media Player is either not installed or installed in a different location.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Error!")
        End If
    End Sub

    Private Sub mnuHelpHomePage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Process.Start("http://www.betaone.net", AppWinStyle.MaximizedFocus)
    End Sub

    Private Sub cboAudioQ_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAudioQ.SelectedIndexChanged
        nudPercent.Text = 0
        Call Calculation()
    End Sub

    Private Sub cboCDCDSize_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCDCDSize.SelectedIndexChanged
        nudPercent.Text = 0
        If cboCDCDSize.SelectedIndex > 3 Then
            imgCDR.Visible = False
            imgDVDR.Visible = True
            cboAudioQ.SelectedIndex = 1
        Else
            imgCDR.Visible = True
            imgDVDR.Visible = False
            cboAudioQ.SelectedIndex = 0
        End If
        Call Calculation()
    End Sub
    Private Sub nudCustomCDSize_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles nudCustomCDSize.TextChanged
        nudPercent.Text = 0
        Call Calculation()
    End Sub

    Private Sub mnuEditSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'Dim datobj As New System.Windows.Forms.DataObject
        'datobj.SetData(System.Windows.Forms.DataFormats.Text, (StrCompressionInfo))
        'System.Windows.Forms.Clipboard.SetDataObject(datobj)
        Shell("notepad", AppWinStyle.NormalFocus)
        System.Windows.Forms.SendKeys.Send(fGetMovieInfo)
    End Sub

    Private Function fGetMovieInfo() As String

        Dim lCompressionInfo As String = "Movie Length:" + vbTab + vbTab + cboHours.Text + " Hours " + cboMins.Text + " Minutes " + cboSecs.Text + " Seconds"

        If optCD.Checked = True Then
            lCompressionInfo = lCompressionInfo + vbCr + _
            "Disk Size Based:" + vbTab + cboCDCDSize.Text + " * " + cboCDCDNumber.Text + vbCr + _
            "Audio bit rate:" + vbTab + vbTab + cboAudioQ.Text + vbCr + _
            "Video bit rate:" + vbTab + vbTab + txtVideoQ.Text + " Kibit/s"
        End If
        If optCustom.Checked = True Then
            lCompressionInfo = lCompressionInfo + vbCr + _
            "Custom Size Based:" + vbTab + nudCustomCDSize.Text + " MiB * " + cboCustomCDNumber.Text + vbCr + _
            "Audio bit rate:" + vbTab + vbTab + cboAudioQ.Text + vbCr + _
            "Video bit rate:" + vbTab + vbTab + txtVideoQ.Text + " Kibit/s"
        End If
        Return lCompressionInfo

    End Function

    Private Sub mnuHelpZarax_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("http://www.microsoftusernetwork.com/", AppWinStyle.MaximizedFocus)
    End Sub

    Private Sub mnuHelpZaraxForums_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("http://www.microsoftusernetwork.com/forum/", AppWinStyle.MaximizedFocus)
    End Sub

    Private Sub mnuHelpDoom9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("http://www.doom9.org", AppWinStyle.MaximizedFocus)
    End Sub

    Private Sub mnuHelpDoom9Forums_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("http://forum.doom9.org", AppWinStyle.MaximizedFocus)
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'frmTotalFrames.MyEvent.txtTotalFrames.Text = Me.TextBox1.Text
    End Sub

    Private Sub nudPercent_textChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudPercent.TextChanged
        If Len(txtVideoQ.Text) > 0 Then
            Call Calculation()
            txtVideoQ.Text = FormatNumber((txtVideoQ.Text * (100 + nudPercent.Text)) / 100, 0, , , TriState.False)
        End If
    End Sub

    Private Sub nudPercent_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudPercent.ValueChanged

    End Sub

    Private Sub fraMovLength_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fraMovLength.Enter
        nudPercent.Text = 0
    End Sub

    Private Sub fraFileSize_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fraFileSize.Enter
        nudPercent.Text = 0
    End Sub

    Private Sub fraMovQuality_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fraMovQuality.Enter
        nudPercent.Text = 0
    End Sub

    Private Sub cboHours_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboHours.SelectedIndexChanged
        Call Calculation()
        Call frmTotalFrames.MyEvent.MovieLengthCalc()
    End Sub

    Private Sub cboSecs_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSecs.SelectedIndexChanged
        Call Calculation()
        Call frmTotalFrames.MyEvent.MovieLengthCalc()
    End Sub

    Private Sub cboMins_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMins.SelectedIndexChanged
        Call Calculation()
        Call frmTotalFrames.MyEvent.MovieLengthCalc()
    End Sub

    Private Sub cboMins_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboMins.TextChanged
        Call Calculation()
    End Sub

    Private Sub cboSecs_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSecs.TextChanged
        Call Calculation()
        'Call frmTotalFrames.MyEvent.MovieLengthCalc()
    End Sub

    Private Sub cboHours_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboHours.TextChanged
        Call Calculation()
        'Call frmTotalFrames.MyEvent.MovieLengthCalc()
    End Sub

    Private Sub mnuAudioMode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAudioMode.Click
        cboAudioQ.SelectedIndex = 2
        cboAudioQ.Enabled = False
        fraMovLength.Text = "Audio Length"
        picCamcorder.Visible = False
        picCDAudio.Visible = True
        fraMovQuality.Text = "Audio Quality"
        lblVideoBitRate.Text = "Audio bit Rate"
        lblAudioBitRate.Text = "Video bit Rate"
        mnuAudioMode.Checked = True
        mnuVideoMode.Checked = False
        lblMB.Text = "KiB"
        Calculation()
    End Sub

    Private Sub mnuVideoMode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuVideoMode.Click
        cboAudioQ.SelectedIndex = 0
        fraMovLength.Text = "Movie Length"
        picCamcorder.Visible = True
        picCDAudio.Visible = False
        fraMovQuality.Text = "Movie Quality"
        lblVideoBitRate.Text = "Video bit Rate"
        lblAudioBitRate.Text = "Audio bit Rate"
        cboAudioQ.Enabled = True
        mnuAudioMode.Checked = False
        mnuVideoMode.Checked = True
        lblMB.Text = "MiB"
        Calculation()
    End Sub

    Private Sub frmWM9BC_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Call SaveAllSettings()
        If mnuEditLog.Checked = True Then
            saveLog()
        End If
    End Sub

    Private Sub mnuEditLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub saveLog()

        Try

            If txtMovieName.Text <> strMovieName Then
                FileOpen(1, (Application.StartupPath & "\WM9BC-Log.log"), _
                OpenMode.Append)
                PrintLine(1, Now + vbTab + txtMovieName.Text)
                PrintLine(1, fGetMovieInfo)
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



    Private Sub OpenLogToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenLogToolStripMenuItem.Click

    End Sub

    Private Sub mnuEditLog_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditLog.Click
        mnuEditLog.Checked = Not mnuEditLog.Checked
    End Sub

    Private Sub WindowsMediaEncoderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WindowsMediaEncoderToolStripMenuItem.Click

    End Sub

    Private Sub HomePageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomePageToolStripMenuItem.Click
        sOpenHomePage()
    End Sub

    Private Sub sOpenHomePage()
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Process.Start("http://www.wmwiki.com/", AppWinStyle.MinimizedNoFocus)
    End Sub

    Private Sub SupportForumsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupportForumsToolStripMenuItem.Click
        Process.Start("http://microsoftuse.temp.powweb.com/forum/", AppWinStyle.MaximizedFocus)
    End Sub

    Private Sub miHelpUpdates_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miHelpUpdates.Click

        Const URL_UPDATE_DOWNLOAD As String = "http://microsoftuse.temp.powweb.com/mcored/downloads/"
        Process.Start(URL_UPDATE_DOWNLOAD)

    End Sub

    Private Sub VersionHistoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VersionHistoryToolStripMenuItem.Click
        Dim version As New frmVer
        version.ShowDialog()
    End Sub

    Private Sub MovieResolutionCalculatorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MovieResolutionCalculatorToolStripMenuItem.Click

    End Sub

    Private Sub TotalFramesCalculatorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TotalFramesCalculatorToolStripMenuItem.Click

    End Sub
End Class
