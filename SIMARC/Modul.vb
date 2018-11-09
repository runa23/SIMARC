Imports System.Diagnostics
Imports System
Imports System.Windows.Forms
Imports System.Collections
Imports System.Drawing
Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Collections.Generic
Imports Microsoft.Win32
Imports Microsoft.VisualBasic.CompilerServices
Imports System.Text

Public Class Modul
    Public Shared Sub HanyaAngka(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If StringType.StrLike(e.KeyChar.ToString(), "[0-9]", CompareMethod.Binary) OrElse e.KeyChar = Chr(8) OrElse e.KeyChar = ("."c) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class
