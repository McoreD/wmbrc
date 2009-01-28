Imports System.IO
Public Class frmVer
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
    Friend WithEvents txtVersionHistory As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVer))
        Me.txtVersionHistory = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'txtVersionHistory
        '
        Me.txtVersionHistory.Location = New System.Drawing.Point(16, 16)
        Me.txtVersionHistory.Multiline = True
        Me.txtVersionHistory.Name = "txtVersionHistory"
        Me.txtVersionHistory.ReadOnly = True
        Me.txtVersionHistory.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtVersionHistory.Size = New System.Drawing.Size(416, 360)
        Me.txtVersionHistory.TabIndex = 0
        Me.txtVersionHistory.TabStop = False
        Me.txtVersionHistory.Text = "TextBox1"
        Me.txtVersionHistory.WordWrap = False
        '
        'frmVer
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(448, 390)
        Me.Controls.Add(Me.txtVersionHistory)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVer"
        Me.ShowInTaskbar = False
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles MyBase.Load

        Me.Text = "Version History"
        txtVersionHistory.Text = getText("VersionHistory.txt")

    End Sub

    Private Function getText(ByVal strName As String) As String

        Try
            ' get the current assembly
            Dim oAsm As System.Reflection.Assembly = _
            System.Reflection.Assembly.GetExecutingAssembly()
            Dim oStrm As Stream = _
            oAsm.GetManifestResourceStream(oAsm.GetName.Name + "." + strName)
            ' read contents of embedded file
            Dim oRdr As StreamReader = New StreamReader(oStrm)
            Return oRdr.ReadToEnd

        Catch ex As Exception
            Throw ex
        End Try

    End Function

End Class
