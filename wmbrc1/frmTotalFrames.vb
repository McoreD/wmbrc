Option Strict Off
Option Explicit On 
Friend Class frmTotalFrames
    Inherits System.Windows.Forms.Form
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
    End Sub
    Private Shared MyForm As frmTotalFrames
    Private Shared InitializeForm As Boolean
    Public Shared Property MyEvent() As frmTotalFrames
        Get
            If MyForm Is Nothing OrElse MyForm.IsDisposed Then
                InitializeForm = True
                MyForm = New frmTotalFrames
                InitializeForm = False
            End If
            MyEvent = MyForm
        End Get
        Set(ByVal Value As frmTotalFrames)
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
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Public WithEvents txtTotalFrames As System.Windows.Forms.TextBox
    Public WithEvents cboMType As System.Windows.Forms.ComboBox
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents txtMovieL As System.Windows.Forms.TextBox
    Public WithEvents cboUnit As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmTotalFrames))
        Me.Frame2 = New System.Windows.Forms.GroupBox
        Me.txtTotalFrames = New System.Windows.Forms.TextBox
        Me.cboMType = New System.Windows.Forms.ComboBox
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.txtMovieL = New System.Windows.Forms.TextBox
        Me.cboUnit = New System.Windows.Forms.ComboBox
        Me.Frame2.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.txtTotalFrames)
        Me.Frame2.Controls.Add(Me.cboMType)
        Me.Frame2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Frame2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(12, 95)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(281, 73)
        Me.Frame2.TabIndex = 5
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "Total Frames"
        '
        'txtTotalFrames
        '
        Me.txtTotalFrames.AcceptsReturn = True
        Me.txtTotalFrames.AutoSize = False
        Me.txtTotalFrames.BackColor = System.Drawing.SystemColors.Window
        Me.txtTotalFrames.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTotalFrames.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalFrames.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTotalFrames.Location = New System.Drawing.Point(168, 32)
        Me.txtTotalFrames.MaxLength = 0
        Me.txtTotalFrames.Name = "txtTotalFrames"
        Me.txtTotalFrames.ReadOnly = True
        Me.txtTotalFrames.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTotalFrames.Size = New System.Drawing.Size(81, 21)
        Me.txtTotalFrames.TabIndex = 5
        Me.txtTotalFrames.Text = ""
        Me.txtTotalFrames.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboMType
        '
        Me.cboMType.BackColor = System.Drawing.SystemColors.Window
        Me.cboMType.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboMType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMType.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMType.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboMType.Location = New System.Drawing.Point(32, 32)
        Me.cboMType.Name = "cboMType"
        Me.cboMType.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboMType.Size = New System.Drawing.Size(97, 22)
        Me.cboMType.TabIndex = 4
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.txtMovieL)
        Me.Frame1.Controls.Add(Me.cboUnit)
        Me.Frame1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Frame1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(12, 15)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(281, 65)
        Me.Frame1.TabIndex = 4
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Movie Length"
        '
        'txtMovieL
        '
        Me.txtMovieL.AcceptsReturn = True
        Me.txtMovieL.AutoSize = False
        Me.txtMovieL.BackColor = System.Drawing.SystemColors.Window
        Me.txtMovieL.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMovieL.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMovieL.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMovieL.Location = New System.Drawing.Point(168, 24)
        Me.txtMovieL.MaxLength = 0
        Me.txtMovieL.Name = "txtMovieL"
        Me.txtMovieL.ReadOnly = True
        Me.txtMovieL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMovieL.Size = New System.Drawing.Size(81, 21)
        Me.txtMovieL.TabIndex = 2
        Me.txtMovieL.Text = ""
        Me.txtMovieL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboUnit
        '
        Me.cboUnit.BackColor = System.Drawing.SystemColors.Window
        Me.cboUnit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUnit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUnit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboUnit.Location = New System.Drawing.Point(32, 24)
        Me.cboUnit.Name = "cboUnit"
        Me.cboUnit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboUnit.Size = New System.Drawing.Size(97, 22)
        Me.cboUnit.TabIndex = 1
        '
        'frmTotalFrames
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(304, 182)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Frame1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTotalFrames"
        Me.Text = "Total Frames Calculator"
        Me.Frame2.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub frmTotalFrames_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboUnit.Items.Add("in Minutes")
        cboUnit.Items.Add("in Seconds")
        cboUnit.SelectedIndex = 1
        cboMType.Items.Add("PAL")
        cboMType.Items.Add("NTSC")
        cboMType.SelectedIndex = 0
        Call MovieLengthCalc()
    End Sub
    Function MovieLengthCalc() As Object
        Dim sngLengthMin As Object
        Dim sngLengthSec As Object
        Dim sngMovieFrames As Single
        If IsNumeric(frmWM9BC.MyEvent.cboHours.Text) = True AndAlso Len(frmWM9BC.MyEvent.cboHours.Text) > 0 _
        AndAlso IsNumeric(frmWM9BC.MyEvent.cboMins.Text) = True AndAlso Len(frmWM9BC.MyEvent.cboMins.Text) > 0 _
        AndAlso IsNumeric(frmWM9BC.MyEvent.cboSecs.Text) = True AndAlso Len(frmWM9BC.MyEvent.cboSecs.Text) > 0 Then
            sngLengthSec = frmWM9BC.MyEvent.cboHours.Text * 3600 + frmWM9BC.MyEvent.cboMins.Text * 60 + frmWM9BC.MyEvent.cboSecs.Text
            sngLengthMin = frmWM9BC.MyEvent.cboHours.Text * 60 + frmWM9BC.MyEvent.cboMins.Text + (frmWM9BC.MyEvent.cboSecs.Text) / 60
            If (cboUnit.SelectedIndex = 1) Then
                txtMovieL.Text = sngLengthSec
            Else
                txtMovieL.Text = FormatNumber(sngLengthMin, 0, , , TriState.False)
            End If
            If (cboMType.SelectedIndex = 0) Then
                sngMovieFrames = sngLengthSec * 25
            ElseIf (cboMType.SelectedIndex = 1) Then
                sngMovieFrames = sngLengthSec * 29.97
            End If
            txtTotalFrames.Text = FormatNumber(sngMovieFrames, 0, , , TriState.False)
        Else
            txtMovieL.Text = "Invalid"
            txtTotalFrames.Text = "Invalid"
        End If

    End Function
    Private Sub cboMType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMType.SelectedIndexChanged
        Call MovieLengthCalc()
    End Sub
    Private Sub cboUnit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboUnit.SelectedIndexChanged
        Call MovieLengthCalc()
    End Sub
    Private Sub txtTotalFrames_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotalFrames.TextChanged
        'frmWM9BC.MyEvent.TextBox1.Text = Me.txtTotalFrames.Text
    End Sub
End Class
