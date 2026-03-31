Imports System.Runtime.InteropServices
Imports AutoIt.AutoItX
Module GetColor
    '------------ Function ที่ใช้ ในการดึงค่าสี จาก เบื้องหลัง Begin ----------------//
    <DllImport("user32.dll", SetLastError:=True)>
    Public Function GetWindowDC(window As IntPtr) As IntPtr
    End Function

    <DllImport("gdi32.dll", SetLastError:=True)>
    Public Function GetPixel(dc As IntPtr, x As Integer, y As Integer) As UInteger
    End Function

    <DllImport("user32.dll", SetLastError:=True)>
    Public Function ReleaseDC(window As IntPtr, dc As IntPtr) As Integer
    End Function

    Public Function GetColorAt(hwnd As IntPtr, x As Integer, y As Integer) As Color
        Try
            Dim dc As IntPtr = GetWindowDC(hwnd)
            Dim a As Integer = CInt(GetPixel(dc, x, y))
            ReleaseDC(hwnd, dc)
            Return Color.FromArgb(255, (a >> 0) And &HFF, (a >> 8) And &HFF, (a >> 16) And &HFF)
        Catch ex As Exception

        End Try

    End Function

    Public Function HexConverter(c As System.Drawing.Color) As [String]
        Return [String].Format("0x{0}", c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2"))
    End Function

    '------------ Function ที่ใช้ ในการดึงค่าสี จาก เบื้องหลัง Begin ----------------//
    Public Function GETCOLOR(x As Integer, y As Integer)
        Dim appHandle As IntPtr = AutoIt.AutoItX.WinGetHandle("FIFA Online4", "") ''ชื่อเกมส์
        Return HexConverter(GetColorAt(appHandle, Integer.Parse(x), Integer.Parse(y)))
    End Function

End Module
