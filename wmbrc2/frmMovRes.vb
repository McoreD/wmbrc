Public Class frmMovRes
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
    Friend WithEvents cboInWidth As System.Windows.Forms.ComboBox
    Friend WithEvents cboInHeight As System.Windows.Forms.ComboBox
    Friend WithEvents cboOutWidth As System.Windows.Forms.ComboBox
    Friend WithEvents txtOutHeight As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtAspectRatio As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmnu4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmnu8 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmnu16 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmnu32 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmnuExact As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMovRes))
        Me.cboInWidth = New System.Windows.Forms.ComboBox
        Me.cboInHeight = New System.Windows.Forms.ComboBox
        Me.txtOutHeight = New System.Windows.Forms.TextBox
        Me.cboOutWidth = New System.Windows.Forms.ComboBox
        Me.txtAspectRatio = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmnu4 = New System.Windows.Forms.ToolStripMenuItem
        Me.cmnu8 = New System.Windows.Forms.ToolStripMenuItem
        Me.cmnu16 = New System.Windows.Forms.ToolStripMenuItem
        Me.cmnu32 = New System.Windows.Forms.ToolStripMenuItem
        Me.cmnuExact = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboInWidth
        '
        Me.cboInWidth.Location = New System.Drawing.Point(19, 41)
        Me.cboInWidth.MaxLength = 4
        Me.cboInWidth.Name = "cboInWidth"
        Me.cboInWidth.Size = New System.Drawing.Size(80, 21)
        Me.cboInWidth.TabIndex = 0
        '
        'cboInHeight
        '
        Me.cboInHeight.Location = New System.Drawing.Point(139, 41)
        Me.cboInHeight.MaxLength = 4
        Me.cboInHeight.Name = "cboInHeight"
        Me.cboInHeight.Size = New System.Drawing.Size(72, 21)
        Me.cboInHeight.TabIndex = 1
        '
        'txtOutHeight
        '
        Me.txtOutHeight.Location = New System.Drawing.Point(139, 42)
        Me.txtOutHeight.Name = "txtOutHeight"
        Me.txtOutHeight.ReadOnly = True
        Me.txtOutHeight.Size = New System.Drawing.Size(72, 20)
        Me.txtOutHeight.TabIndex = 3
        '
        'cboOutWidth
        '
        Me.cboOutWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOutWidth.Location = New System.Drawing.Point(19, 42)
        Me.cboOutWidth.Name = "cboOutWidth"
        Me.cboOutWidth.Size = New System.Drawing.Size(80, 21)
        Me.cboOutWidth.TabIndex = 2
        '
        'txtAspectRatio
        '
        Me.txtAspectRatio.Location = New System.Drawing.Point(139, 73)
        Me.txtAspectRatio.Name = "txtAspectRatio"
        Me.txtAspectRatio.ReadOnly = True
        Me.txtAspectRatio.Size = New System.Drawing.Size(72, 20)
        Me.txtAspectRatio.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Aspect Ratio :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(139, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Height"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Width"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(139, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Height"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Width"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtAspectRatio)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.cboInHeight)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.cboInWidth)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(232, 112)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Source Video Resolution (After Cropped)"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.cboOutWidth)
        Me.GroupBox4.Controls.Add(Me.txtOutHeight)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 130)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(231, 81)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Encode the Video at Resolution"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmnu4, Me.cmnu8, Me.cmnu16, Me.cmnu32, Me.cmnuExact})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(155, 136)
        '
        'cmnu4
        '
        Me.cmnu4.Name = "cmnu4"
        Me.cmnu4.Size = New System.Drawing.Size(154, 22)
        Me.cmnu4.Text = "Multiples of 4"
        '
        'cmnu8
        '
        Me.cmnu8.Name = "cmnu8"
        Me.cmnu8.Size = New System.Drawing.Size(154, 22)
        Me.cmnu8.Text = "Multiples of 8"
        '
        'cmnu16
        '
        Me.cmnu16.Checked = True
        Me.cmnu16.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cmnu16.Name = "cmnu16"
        Me.cmnu16.Size = New System.Drawing.Size(154, 22)
        Me.cmnu16.Text = "Multiples of 16"
        '
        'cmnu32
        '
        Me.cmnu32.Name = "cmnu32"
        Me.cmnu32.Size = New System.Drawing.Size(154, 22)
        Me.cmnu32.Text = "Multiples of 32"
        '
        'cmnuExact
        '
        Me.cmnuExact.Name = "cmnuExact"
        Me.cmnuExact.Size = New System.Drawing.Size(154, 22)
        Me.cmnuExact.Text = "Precise"
        '
        'frmMovRes
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(259, 226)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMovRes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Movie Resolution Calculator"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        For i = 22 To 64
            cboInWidth.Items.Add(16 * i)
            cboOutWidth.Items.Add(16 * i)
        Next
        cboInWidth.SelectedIndex = 23
        cboOutWidth.SelectedIndex = 18
        For i = 19 To 36
            cboInHeight.Items.Add(16 * i)
        Next
        cboInHeight.SelectedIndex = 17
    End Sub

    Private Sub cboOutWidth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboOutWidth.SelectedIndexChanged
        Call Calculation()
    End Sub
    Sub Calculation()

        If Len(cboInWidth.Text) > 0 And Len(cboInHeight.Text) > 0 And Len(cboOutWidth.Text) > 0 Then
            If IsNumeric(cboInWidth.Text) = True And IsNumeric(cboInHeight.Text) = True And IsNumeric(cboOutWidth.Text) = True Then
                If cmnu16.Checked = True Then
                    Dim intInWidth, intOutWidth, intRatio As Single
                    Dim intInHeight, intOutHeight As Single
                    intInWidth = cboInWidth.Text
                    intInHeight = cboInHeight.Text
                    intOutWidth = cboOutWidth.Text
                    intRatio = intOutWidth / intInWidth
                    intOutHeight = intRatio * intInHeight
                    txtOutHeight.Text = (FormatNumber((intOutHeight / 16), 0)) * 16
                    txtAspectRatio.Text = FormatNumber(intInWidth / intInHeight, 4) & " : " & "1"
                ElseIf cmnu32.Checked = True Then
                    Dim intInWidth, intOutWidth, intRatio As Single
                    Dim intInHeight, intOutHeight As Single
                    intInWidth = cboInWidth.Text
                    intInHeight = cboInHeight.Text
                    intOutWidth = cboOutWidth.Text
                    intRatio = intOutWidth / intInWidth
                    intOutHeight = intRatio * intInHeight
                    txtOutHeight.Text = (FormatNumber((intOutHeight / 32), 0)) * 32
                    txtAspectRatio.Text = FormatNumber(intInWidth / intInHeight, 4) & " : " & "1"
                ElseIf cmnu8.Checked = True Then
                    Dim intInWidth, intOutWidth, intRatio As Single
                    Dim intInHeight, intOutHeight As Single
                    intInWidth = cboInWidth.Text
                    intInHeight = cboInHeight.Text
                    intOutWidth = cboOutWidth.Text
                    intRatio = intOutWidth / intInWidth
                    intOutHeight = intRatio * intInHeight
                    txtOutHeight.Text = (FormatNumber((intOutHeight / 8), 0)) * 8
                    txtAspectRatio.Text = FormatNumber(intInWidth / intInHeight, 4) & " : " & "1"
                ElseIf cmnu4.Checked = True Then
                    Dim intInWidth, intOutWidth, intRatio As Single
                    Dim intInHeight, intOutHeight As Single
                    intInWidth = cboInWidth.Text
                    intInHeight = cboInHeight.Text
                    intOutWidth = cboOutWidth.Text
                    intRatio = intOutWidth / intInWidth
                    intOutHeight = intRatio * intInHeight
                    txtOutHeight.Text = (FormatNumber((intOutHeight / 4), 0)) * 4
                    txtAspectRatio.Text = FormatNumber(intInWidth / intInHeight, 4) & " : " & "1"
                ElseIf cmnuExact.Checked = True Then
                    Dim intInWidth, intOutWidth, intRatio As Single
                    Dim intInHeight, intOutHeight As Single
                    intInWidth = cboInWidth.Text
                    intInHeight = cboInHeight.Text
                    intOutWidth = cboOutWidth.Text
                    intRatio = intOutWidth / intInWidth
                    intOutHeight = FormatNumber(intRatio, 4) * intInHeight
                    txtOutHeight.Text = FormatNumber(intOutHeight, 0)
                    txtAspectRatio.Text = FormatNumber(intInWidth / intInHeight, 4) & " : " & "1"
                Else
                    txtOutHeight.Text = "Invalid"
                End If

            End If
        End If
    End Sub

    Private Sub cboInWidth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboInWidth.SelectedIndexChanged
        Call Calculation()
    End Sub

    Private Sub cboInHeight_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboInHeight.SelectedIndexChanged
        Call Calculation()
    End Sub

    Private Sub cboInWidth_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboInWidth.TextChanged
        Call Calculation()
    End Sub

    Private Sub cboInHeight_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboInHeight.TextChanged
        Call Calculation()
    End Sub

    Private Sub cmnu4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnu4.Click
        cmnu4.Checked = True
        cmnu8.Checked = False
        cmnu16.Checked = False
        cmnu32.Checked = False
        cmnuExact.Checked = False
        Call Calculation()
    End Sub

    Private Sub cmnu8_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnu8.Click
        cmnu4.Checked = False
        cmnu8.Checked = True
        cmnu16.Checked = False
        cmnu32.Checked = False
        cmnuExact.Checked = False
        Call Calculation()
    End Sub

    Private Sub cmnu16_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnu16.Click
        cmnu4.Checked = False
        cmnu8.Checked = False
        cmnu16.Checked = True
        cmnu32.Checked = False
        cmnuExact.Checked = False
        Call Calculation()
    End Sub

    Private Sub cmnu32_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnu32.Click
        cmnu4.Checked = False
        cmnu8.Checked = False
        cmnu16.Checked = False
        cmnu32.Checked = True
        cmnuExact.Checked = False
        Call Calculation()
    End Sub

    Private Sub cmnuExact_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuExact.Click
        cmnu4.Checked = False
        cmnu8.Checked = False
        cmnu16.Checked = False
        cmnu32.Checked = False
        cmnuExact.Checked = True
        Call Calculation()
    End Sub
End Class
