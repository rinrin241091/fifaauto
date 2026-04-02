Imports System.Runtime.InteropServices
Imports AutoIt.AutoItX
Module GetColor

    <DllImport("user32.dll")>
    Public Function PrintWindow(hwnd As IntPtr, hdcBlt As IntPtr, nFlags As UInteger) As Boolean
    End Function

    <DllImport("user32.dll")>
    Public Function GetClientRect(hwnd As IntPtr, ByRef lpRect As RECT) As Boolean
    End Function

    <DllImport("user32.dll")>
    Public Function GetDC(hwnd As IntPtr) As IntPtr
    End Function

    <DllImport("user32.dll")>
    Public Function ReleaseDC(hwnd As IntPtr, hdc As IntPtr) As Integer
    End Function

    <DllImport("gdi32.dll")>
    Public Function CreateCompatibleDC(hdc As IntPtr) As IntPtr
    End Function

    <DllImport("gdi32.dll")>
    Public Function CreateCompatibleBitmap(hdc As IntPtr, nWidth As Integer, nHeight As Integer) As IntPtr
    End Function

    <DllImport("gdi32.dll")>
    Public Function SelectObject(hdc As IntPtr, hgdiobj As IntPtr) As IntPtr
    End Function

    <DllImport("gdi32.dll")>
    Public Function DeleteDC(hdc As IntPtr) As Boolean
    End Function

    <DllImport("gdi32.dll")>
    Public Function DeleteObject(hObject As IntPtr) As Boolean
    End Function

    <DllImport("gdi32.dll")>
    Public Function GetPixel(hdc As IntPtr, x As Integer, y As Integer) As UInteger
    End Function

    <DllImport("user32.dll")>
    Public Function IsIconic(hwnd As IntPtr) As Boolean
    End Function

    <DllImport("user32.dll")>
    Public Function ShowWindow(hwnd As IntPtr, nCmdShow As Integer) As Boolean
    End Function

    <StructLayout(LayoutKind.Sequential)>
    Public Structure RECT
        Public Left As Integer
        Public Top As Integer
        Public Right As Integer
        Public Bottom As Integer
    End Structure

    Public Function HexConverter(c As System.Drawing.Color) As String
        If c = Color.Empty Then Return String.Empty
        Return String.Format("0x{0}", c.R.ToString("X2") & c.G.ToString("X2") & c.B.ToString("X2"))
    End Function

    ' Đọc màu pixel từ game kể cả khi game chạy nền (không cần focus)
    Public Function GETCOLOR(x As Integer, y As Integer) As String
        Dim hwnd As IntPtr = AutoIt.AutoItX.WinGetHandle("FC ONLINE", "")
        If hwnd = IntPtr.Zero Then Return String.Empty

        Try
            ' Nếu game đang minimize thì restore lại để PrintWindow hoạt động
            If IsIconic(hwnd) Then
                ShowWindow(hwnd, 9) ' SW_RESTORE = 9
                System.Threading.Thread.Sleep(300)
            End If

            Dim rect As RECT
            GetClientRect(hwnd, rect)
            Dim w As Integer = rect.Right
            Dim h As Integer = rect.Bottom
            If w <= 0 OrElse h <= 0 Then Return String.Empty

            Dim hdcScreen As IntPtr = GetDC(IntPtr.Zero)
            Dim hdcMem As IntPtr = CreateCompatibleDC(hdcScreen)
            Dim hBmp As IntPtr = CreateCompatibleBitmap(hdcScreen, w, h)
            Dim hOld As IntPtr = SelectObject(hdcMem, hBmp)

            ' PW_RENDERFULLCONTENT (2) = render kể cả DirectX, hoạt động khi game ở nền
            PrintWindow(hwnd, hdcMem, 2UI)

            Dim pixel As UInteger = GetPixel(hdcMem, x, y)

            SelectObject(hdcMem, hOld)
            DeleteObject(hBmp)
            DeleteDC(hdcMem)
            ReleaseDC(IntPtr.Zero, hdcScreen)

            Dim a As Integer = CInt(pixel)
            Dim c As Color = Color.FromArgb(255, (a >> 0) And &HFF, (a >> 8) And &HFF, (a >> 16) And &HFF)
            Return HexConverter(c)
        Catch ex As Exception
            Return String.Empty
        End Try
    End Function

End Module
