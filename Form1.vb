Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Size = New Size(0, 0)
        NoticeIcon.Text = My.Application.Info.Title
        NoticeIcon.BalloonTipTitle = My.Application.Info.Title
        NoticeIcon.BalloonTipText = String.Format(NoticeIcon.BalloonTipText, My.Application.Info.Title)
        NoticeIcon.ShowBalloonTip(10)
        Dim regSuccessUp As Integer = RegisterHotKey(Me.Handle.ToInt32, WM_MyHotkeyUp, MyModifilerFlag, Keys.Up)
        Dim regSuccessDown As Integer = RegisterHotKey(Me.Handle.ToInt32, WM_MyHotKeyDown, MyModifilerFlag, Keys.Down)
        Dim regSuccessLeft As Integer = RegisterHotKey(Me.Handle.ToInt32, WM_MyHotKeyLeft, MyModifilerFlag, Keys.Left)
        Dim regSuccessRight As Integer = RegisterHotKey(Me.Handle.ToInt32, WM_MyHotkeyRight, MyModifilerFlag, Keys.Right)
        Dim regSuccessEnd As Integer = RegisterHotKey(Me.Handle.ToInt32, WM_MyHotKeyEnd, MyModifilerFlag, Keys.Delete)
    End Sub

    ' ホットキーメッセージ
    Private Const WM_HOTKEY As Integer = &H312
    ' 修飾キー
    Private Enum ModifierFlags As Integer

        None = 0
        ALT = &H1
        CONTROL = &H2
        SHIFT = &H4
        WIN = &H8

        CONTROL_ALT = CONTROL Or ALT
        CONTROL_SHIFT = CONTROL Or SHIFT
        CONTROL_ALT_SHIFT = CONTROL Or ALT Or SHIFT
        ALT_SHIFT = ALT Or SHIFT

    End Enum
    ' 登録ID
    Private Const WM_USER As Integer = &H3BC0
    Private Const WM_MyHotkeyUp As Integer = WM_USER + 1
    Private Const WM_MyHotKeyDown As Integer = WM_USER + 2
    Private Const WM_MyHotKeyLeft As Integer = WM_USER + 3
    Private Const WM_MyHotkeyRight As Integer = WM_USER + 4
    Private Const WM_MyHotKeyEnd As Integer = WM_USER + 5

    Private Const MyModifilerFlag As ModifierFlags = ModifierFlags.CONTROL_SHIFT

    Private Declare Function RegisterHotKey Lib "user32" (ByVal hwnd As Integer, ByVal id As Integer, ByVal fsModifiers As Integer, ByVal vk As Integer) As Integer
    Private Declare Function UnregisterHotKey Lib "user32" (ByVal hwnd As Integer, ByVal id As Integer) As Integer

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim unregSuccessUp As Integer = UnregisterHotKey(Me.Handle.ToInt32, WM_MyHotkeyUp)
        Dim unregSuccessDown As Integer = UnregisterHotKey(Me.Handle.ToInt32, WM_MyHotKeyDown)
        Dim unregSuccessLeft As Integer = UnregisterHotKey(Me.Handle.ToInt32, WM_MyHotKeyLeft)
        Dim unregSuccessRight As Integer = UnregisterHotKey(Me.Handle.ToInt32, WM_MyHotkeyRight)
        Dim unregSuccessEnd As Integer = UnregisterHotKey(Me.Handle.ToInt32, WM_MyHotKeyEnd)
    End Sub

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        Select Case m.Msg
            Case WM_HOTKEY
                Select Case m.WParam.ToInt32
                    Case WM_MyHotkeyUp
                        Dim x As Integer = System.Windows.Forms.Cursor.Position.X
                        Dim y As Integer = System.Windows.Forms.Cursor.Position.Y
                        System.Windows.Forms.Cursor.Position = New System.Drawing.Point(x, y - 2)
                    Case WM_MyHotKeyDown
                        Dim x As Integer = System.Windows.Forms.Cursor.Position.X
                        Dim y As Integer = System.Windows.Forms.Cursor.Position.Y
                        System.Windows.Forms.Cursor.Position = New System.Drawing.Point(x, y + 2)
                    Case WM_MyHotKeyLeft
                        Dim x As Integer = System.Windows.Forms.Cursor.Position.X
                        Dim y As Integer = System.Windows.Forms.Cursor.Position.Y
                        System.Windows.Forms.Cursor.Position = New System.Drawing.Point(x - 2, y)
                    Case WM_MyHotkeyRight
                        Dim x As Integer = System.Windows.Forms.Cursor.Position.X
                        Dim y As Integer = System.Windows.Forms.Cursor.Position.Y
                        System.Windows.Forms.Cursor.Position = New System.Drawing.Point(x + 2, y)
                    Case WM_MyHotKeyEnd
                        Me.Close()
                End Select
        End Select
        MyBase.WndProc(m)
    End Sub

    Private Sub ライセンスToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ライセンスToolStripMenuItem.Click
        license.Show()
    End Sub

    Private Sub 終了ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 終了ToolStripMenuItem.Click
        Me.Close()
        End
    End Sub
End Class