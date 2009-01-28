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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtAspectRatio As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents cmnu16 As System.Windows.Forms.MenuItem
    Friend WithEvents cmnu32 As System.Windows.Forms.MenuItem
    Friend WithEvents cmnu8 As System.Windows.Forms.MenuItem
    Friend WithEvents cmnuExact As System.Windows.Forms.MenuItem
    Friend WithEvents cmnu4 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMovRes))
        Me.cboInWidth = New System.Windows.Forms.ComboBox
        Me.cboInHeight = New System.Windows.Forms.ComboBox
        Me.txtOutHeight = New System.Windows.Forms.TextBox
        Me.cboOutWidth = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtAspectRatio = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.cmnu4 = New System.Windows.Forms.MenuItem
        Me.cmnu8 = New System.Windows.Forms.MenuItem
        Me.cmnu16 = New System.Windows.Forms.MenuItem
        Me.cmnu32 = New System.Windows.Forms.MenuItem
        Me.cmnuExact = New System.Windows.Forms.MenuItem
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboInWidth
        '
        Me.cboInWidth.Location = New System.Drawing.Point(24, 40)
        Me.cboInWidth.MaxLength = 4
        Me.cboInWidth.Name = "cboInWidth"
        Me.cboInWidth.Size = New System.Drawing.Size(80, 21)
        Me.cboInWidth.TabIndex = 0
        '
        'cboInHeight
        '
        Me.cboInHeight.Location = New System.Drawing.Point(144, 40)
        Me.cboInHeight.MaxLength = 4
        Me.cboInHeight.Name = "cboInHeight"
        Me.cboInHeight.Size = New System.Drawing.Size(72, 21)
        Me.cboInHeight.TabIndex = 1
        '
        'txtOutHeight
        '
        Me.txtOutHeight.Location = New System.Drawing.Point(144, 40)
        Me.txtOutHeight.Name = "txtOutHeight"
        Me.txtOutHeight.ReadOnly = True
        Me.txtOutHeight.Size = New System.Drawing.Size(72, 20)
        Me.txtOutHeight.TabIndex = 3
        Me.txtOutHeight.Text = ""
        '
        'cboOutWidth
        '
        Me.cboOutWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOutWidth.Location = New System.Drawing.Point(24, 40)
        Me.cboOutWidth.Name = "cboOutWidth"
        Me.cboOutWidth.Size = New System.Drawing.Size(80, 21)
        Me.cboOutWidth.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtAspectRatio)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cboInWidth)
        Me.GroupBox1.Controls.Add(Me.cboInHeight)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(248, 120)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Source Video Resolution (After Cropped)"
        '
        'txtAspectRatio
        '
        Me.txtAspectRatio.Location = New System.Drawing.Point(144, 80)
        Me.txtAspectRatio.Name = "txtAspectRatio"
        Me.txtAspectRatio.ReadOnly = True
        Me.txtAspectRatio.Size = New System.Drawing.Size(72, 20)
        Me.txtAspectRatio.TabIndex = 9
        Me.txtAspectRatio.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Aspect Ratio :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(144, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Height"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Width"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtOutHeight)
        Me.GroupBox2.Controls.Add(Me.cboOutWidth)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(17, 152)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(248, 80)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Encode the Video at Resolution"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(144, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Height"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Width"
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.cmnu4, Me.cmnu8, Me.cmnu16, Me.cmnu32, Me.cmnuExact})
        '
        'cmnu4
        '
        Me.cmnu4.Index = 0
        Me.cmnu4.RadioCheck = True
        Me.cmnu4.Text = "Multiples of 4"
        '
        'cmnu8
        '
        Me.cmnu8.Index = 1
        Me.cmnu8.RadioCheck = True
        Me.cmnu8.Text = "Multiples of 8"
        '
        'cmnu16
        '
        Me.cmnu16.Checked = True
        Me.cmnu16.Index = 2
        Me.cmnu16.RadioCheck = True
        Me.cmnu16.Text = "Multiples of 16"
        '
        'cmnu32
        '
        Me.cmnu32.Index = 3
        Me.cmnu32.RadioCheck = True
        Me.cmnu32.Text = "Multiples of 32"
        '
        'cmnuExact
        '
        Me.cmnuExact.Index = 4
        Me.cmnuExact.RadioCheck = True
        Me.cmnuExact.Text = "Precise Calculation"
        '
        'frmMovRes
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(282, 248)
        Me.ContextMenu = Me.ContextMenu1
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMovRes"
        Me.Text = "Movie Resolution Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
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
                    Dim intInHeight, intOutHeight, intOutHeightFixed As Single
                    intInWidth = cboInWidth.Text
                    intInHeight = cboInHeight.Text
                    intOutWidth = cboOutWidth.Text
                    intRatio = intOutWidth / intInWidth
                    intOutHeight = intRatio * intInHeight
                    txtOutHeight.Text = (FormatNumber((intOutHeight / 16), 0)) * 16
                    txtAspectRatio.Text = FormatNumber(intInWidth / intInHeight, 4) & " : " & "1"
                ElseIf cmnu32.Checked = True Then
                    Dim intInWidth, intOutWidth, intRatio As Single
                    Dim intInHeight, intOutHeight, intOutHeightFixed As Single
                    intInWidth = cboInWidth.Text
                    intInHeight = cboInHeight.Text
                    intOutWidth = cboOutWidth.Text
                    intRatio = intOutWidth / intInWidth
                    intOutHeight = intRatio * intInHeight
                    txtOutHeight.Text = (FormatNumber((intOutHeight / 32), 0)) * 32
                    txtAspectRatio.Text = FormatNumber(intInWidth / intInHeight, 4) & " : " & "1"
                ElseIf cmnu8.Checked = True Then
                    Dim intInWidth, intOutWidth, intRatio As Single
                    Dim intInHeight, intOutHeight, intOutHeightFixed As Single
                    intInWidth = cboInWidth.Text
                    intInHeight = cboInHeight.Text
                    intOutWidth = cboOutWidth.Text
                    intRatio = intOutWidth / intInWidth
                    intOutHeight = intRatio * intInHeight
                    txtOutHeight.Text = (FormatNumber((intOutHeight / 8), 0)) * 8
                    txtAspectRatio.Text = FormatNumber(intInWidth / intInHeight, 4) & " : " & "1"
                ElseIf cmnu4.Checked = True Then
                    Dim intInWidth, intOutWidth, intRatio As Single
                    Dim intInHeight, intOutHeight, intOutHeightFixed As Single
                    intInWidth = cboInWidth.Text
                    intInHeight = cboInHeight.Text
                    intOutWidth = cboOutWidth.Text
                    intRatio = intOutWidth / intInWidth
                    intOutHeight = intRatio * intInHeight
                    txtOutHeight.Text = (FormatNumber((intOutHeight / 4), 0)) * 4
                    txtAspectRatio.Text = FormatNumber(intInWidth / intInHeight, 4) & " : " & "1"
                ElseIf cmnuExact.Checked = True Then
                    Dim intInWidth, intOutWidth, intRatio As Single
                    Dim intInHeight, intOutHeight, intOutHeightFixed As Single
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

    Private Sub cmnuExact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuExact.Click
        cmnu4.Checked = False
        cmnu8.Checked = False
        cmnu16.Checked = False
        cmnu32.Checked = False
        cmnuExact.Checked = True
        Call Calculation()
    End Sub

    Private Sub cmnu16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnu16.Click
        cmnu4.Checked = False
        cmnu8.Checked = False
        cmnu16.Checked = True
        cmnu32.Checked = False
        cmnuExact.Checked = False
        Call Calculation()
    End Sub

    Private Sub cmnu32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnu32.Click
        cmnu4.Checked = False
        cmnu8.Checked = False
        cmnu16.Checked = False
        cmnu32.Checked = True
        cmnuExact.Checked = False
        Call Calculation()
    End Sub

    Private Sub cmnu8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnu8.Click
        cmnu4.Checked = False
        cmnu8.Checked = True
        cmnu16.Checked = False
        cmnu32.Checked = False
        cmnuExact.Checked = False
        Call Calculation()
    End Sub

    Private Sub cmnu4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnu4.Click
        cmnu4.Checked = True
        cmnu8.Checked = False
        cmnu16.Checked = False
        cmnu32.Checked = False
        cmnuExact.Checked = False
        Call Calculation()
    End Sub
End Class
