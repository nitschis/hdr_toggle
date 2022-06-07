Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Public Module SendWinKey

    Const KEYEVENTF_KEYDOWN As Integer = &H0
    Const KEYEVENTF_KEYUP As Integer = &H2

    Declare Sub keybd_event Lib "User32" (ByVal bVk As Byte, ByVal bScan As Byte, ByVal dwFlags As UInteger, ByVal dwExtraInfo As UInteger)

       Public Sub Main()    
           keybd_event(CByte(Keys.LWin), 0, KEYEVENTF_KEYDOWN, 0) 'press left Win key
           keybd_event(CByte(Keys.Menu), 0, KEYEVENTF_KEYDOWN, 0) 'press alt key
           keybd_event(CByte(Keys.B), 0, KEYEVENTF_KEYDOWN, 0) 'press B key
           keybd_event(CByte(Keys.B), 0, KEYEVENTF_KEYUP, 0) 'release B key
           keybd_event(CByte(Keys.Menu), 0, KEYEVENTF_KEYUP, 0) 'release left alt key
           keybd_event(CByte(Keys.LWin), 0, KEYEVENTF_KEYUP, 0) 'release left Win key
       End Sub
End Module

