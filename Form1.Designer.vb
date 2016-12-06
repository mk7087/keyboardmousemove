<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NoticeIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.終了ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.バージョン情報ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ライセンスToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.製品名ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.バージョンToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.著作権ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.バージョン情報ToolStripMenuItem, Me.ライセンスToolStripMenuItem, Me.ToolStripSeparator1, Me.終了ToolStripMenuItem})
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(153, 98)
        '
        'NoticeIcon
        '
        Me.NoticeIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NoticeIcon.BalloonTipText = "{0} を起動しました"
        Me.NoticeIcon.ContextMenuStrip = Me.MenuStrip
        Me.NoticeIcon.Icon = CType(resources.GetObject("NoticeIcon.Icon"), System.Drawing.Icon)
        Me.NoticeIcon.Visible = True
        '
        '終了ToolStripMenuItem
        '
        Me.終了ToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem"
        Me.終了ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.終了ToolStripMenuItem.Text = "終了"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'バージョン情報ToolStripMenuItem
        '
        Me.バージョン情報ToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.バージョン情報ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.製品名ToolStripMenuItem, Me.バージョンToolStripMenuItem, Me.著作権ToolStripMenuItem})
        Me.バージョン情報ToolStripMenuItem.Name = "バージョン情報ToolStripMenuItem"
        Me.バージョン情報ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.バージョン情報ToolStripMenuItem.Text = "バージョン情報"
        '
        'ライセンスToolStripMenuItem
        '
        Me.ライセンスToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ライセンスToolStripMenuItem.Name = "ライセンスToolStripMenuItem"
        Me.ライセンスToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ライセンスToolStripMenuItem.Text = "ライセンス"
        '
        '製品名ToolStripMenuItem
        '
        Me.製品名ToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.製品名ToolStripMenuItem.Name = "製品名ToolStripMenuItem"
        Me.製品名ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.製品名ToolStripMenuItem.Text = "製品名"
        '
        'バージョンToolStripMenuItem
        '
        Me.バージョンToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.バージョンToolStripMenuItem.Name = "バージョンToolStripMenuItem"
        Me.バージョンToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.バージョンToolStripMenuItem.Text = "バージョン"
        '
        '著作権ToolStripMenuItem
        '
        Me.著作権ToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.著作権ToolStripMenuItem.Name = "著作権ToolStripMenuItem"
        Me.著作権ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.著作権ToolStripMenuItem.Text = "著作権"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(385, 304)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.ShowInTaskbar = False
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.White
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.MenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuStrip As ContextMenuStrip
    Friend WithEvents NoticeIcon As NotifyIcon
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents 終了ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents バージョン情報ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ライセンスToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 製品名ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents バージョンToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 著作権ToolStripMenuItem As ToolStripMenuItem
End Class
