Imports System
Imports System.Data
Imports System.Data.Common
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.IO
Imports System.Text
Imports System.Media
Imports System.Windows.Forms

Public Class AddCountry



    Private Const WM_SYSCOMMAND As Integer = &H112
    Private Const SC_MAXIMIZE As Integer = &HF030
    Private Const WM_NCLBUTTONDBLCLK As Integer = &HA3
    Private Const HTCAPTION As Integer = &H2
    Private widthint As Integer = 498
    Private heightint As Integer = 286
    Private init_widthint As Integer = 0
    Private init_heightint As Integer = 0
    '498, 286

    Private clsCornea As New ClassCornea
    Private max_Flag As Boolean = False

End Class