Public Class frmAboutWM9BC
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

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
    Friend WithEvents llblEmail As System.Windows.Forms.LinkLabel
    Public WithEvents Picture1 As System.Windows.Forms.PictureBox
    Public WithEvents cmdOK As System.Windows.Forms.Button
    Public WithEvents lblDisclaimer As System.Windows.Forms.Label
    Public WithEvents lblDescription As System.Windows.Forms.Label
    Public WithEvents lblTitle As System.Windows.Forms.Label
    Public WithEvents lblVersion As System.Windows.Forms.Label
    Public WithEvents cmdZaraxOnline As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmAboutWM9BC))
        Me.llblEmail = New System.Windows.Forms.LinkLabel
        Me.Picture1 = New System.Windows.Forms.PictureBox
        Me.cmdZaraxOnline = New System.Windows.Forms.Button
        Me.cmdOK = New System.Windows.Forms.Button
        Me.lblDisclaimer = New System.Windows.Forms.Label
        Me.lblDescription = New System.Windows.Forms.Label
        Me.lblTitle = New System.Windows.Forms.Label
        Me.lblVersion = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'llblEmail
        '
        Me.llblEmail.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.llblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblEmail.Location = New System.Drawing.Point(16, 200)
        Me.llblEmail.Name = "llblEmail"
        Me.llblEmail.Size = New System.Drawing.Size(211, 16)
        Me.llblEmail.TabIndex = 20
        Me.llblEmail.TabStop = True
        Me.llblEmail.Text = "mcored@microsoftusernetwork.com"
        '
        'Picture1
        '
        Me.Picture1.BackColor = System.Drawing.SystemColors.Control
        Me.Picture1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Picture1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Picture1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Picture1.Image = CType(resources.GetObject("Picture1.Image"), System.Drawing.Image)
        Me.Picture1.Location = New System.Drawing.Point(16, 16)
        Me.Picture1.Name = "Picture1"
        Me.Picture1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Picture1.Size = New System.Drawing.Size(48, 48)
        Me.Picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Picture1.TabIndex = 18
        Me.Picture1.TabStop = False
        '
        'cmdZaraxOnline
        '
        Me.cmdZaraxOnline.BackColor = System.Drawing.SystemColors.Control
        Me.cmdZaraxOnline.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdZaraxOnline.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdZaraxOnline.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdZaraxOnline.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdZaraxOnline.Location = New System.Drawing.Point(272, 168)
        Me.cmdZaraxOnline.Name = "cmdZaraxOnline"
        Me.cmdZaraxOnline.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdZaraxOnline.Size = New System.Drawing.Size(88, 24)
        Me.cmdZaraxOnline.TabIndex = 16
        Me.cmdZaraxOnline.Text = "&MSUN Online"
        '
        'cmdOK
        '
        Me.cmdOK.BackColor = System.Drawing.SystemColors.Control
        Me.cmdOK.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdOK.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdOK.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdOK.Location = New System.Drawing.Point(272, 200)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdOK.Size = New System.Drawing.Size(88, 24)
        Me.cmdOK.TabIndex = 12
        Me.cmdOK.Text = "&OK"
        '
        'lblDisclaimer
        '
        Me.lblDisclaimer.BackColor = System.Drawing.SystemColors.Control
        Me.lblDisclaimer.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDisclaimer.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblDisclaimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisclaimer.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDisclaimer.Location = New System.Drawing.Point(16, 184)
        Me.lblDisclaimer.Name = "lblDisclaimer"
        Me.lblDisclaimer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDisclaimer.Size = New System.Drawing.Size(231, 17)
        Me.lblDisclaimer.TabIndex = 17
        Me.lblDisclaimer.Text = "Please send any bug reports/feedback to: "
        '
        'lblDescription
        '
        Me.lblDescription.BackColor = System.Drawing.SystemColors.Control
        Me.lblDescription.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDescription.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.ForeColor = System.Drawing.Color.Black
        Me.lblDescription.Location = New System.Drawing.Point(16, 80)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDescription.Size = New System.Drawing.Size(352, 72)
        Me.lblDescription.TabIndex = 13
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.SystemColors.Control
        Me.lblTitle.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTitle.Location = New System.Drawing.Point(72, 16)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitle.Size = New System.Drawing.Size(291, 32)
        Me.lblTitle.TabIndex = 14
        Me.lblTitle.Text = "Application Title"
        '
        'lblVersion
        '
        Me.lblVersion.BackColor = System.Drawing.SystemColors.Control
        Me.lblVersion.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblVersion.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblVersion.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblVersion.Location = New System.Drawing.Point(72, 48)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblVersion.Size = New System.Drawing.Size(291, 24)
        Me.lblVersion.TabIndex = 15
        Me.lblVersion.Text = "Version"
        '
        'frmAboutWM9BC
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(378, 237)
        Me.Controls.Add(Me.llblEmail)
        Me.Controls.Add(Me.Picture1)
        Me.Controls.Add(Me.cmdZaraxOnline)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.lblDisclaimer)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblVersion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAboutWM9BC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmAboutWM9BC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "About " + Application.ProductName
        lblTitle.Text = Application.ProductName + vbCrLf + "Coded by: ~*McoreD*~" ' And Kar_mds
        lblVersion.Text = "Version " + Application.ProductVersion
        lblDescription.Text = "The video bitrate you will get from this calculator will be a bit less (about 1 Kbps) than the bitrate you will get from other calculators. This is done intentionally and is not a fault of the program code." + vbCr + "It is  to avoid the risk of having a bigger file than you expect."
    End Sub

    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click
        Me.Close()
    End Sub

    Private Sub llblEmail_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llblEmail.LinkClicked
        llblEmail.LinkVisited = True
        System.Diagnostics.Process.Start("mailto:mcored@microsoftusernetwork.com?subject=WM9%20Bitrate%20Calculator%20" + Application.ProductVersion)
        Me.Close()
    End Sub

    Private Sub cmdZaraxOnline_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdZaraxOnline.Click
        Process.Start("http://www.microsoftusernetwork.com/", AppWinStyle.MaximizedFocus)
    End Sub
End Class
