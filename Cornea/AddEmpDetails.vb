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

Public Class AddEmpDetails



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

    Private emp_design As String = Nothing
    Private emp_workstation As String = Nothing
    Private emp_gender As String = Nothing
    Private emp_contracttype As String = Nothing
    Private emp_branch As String = Nothing
    Private emp_dept As String = Nothing
    Private emp_status As String = Nothing
    Private emp_country As String = Nothing
    Private emp_bloodgrp As String = Nothing
    Private emp_religion As String = Nothing
    Private emp_marital As String = Nothing
    Private emp_nationality As String = Nothing
    Private emp_recruit As String = Nothing
    Private emp_shift As String = Nothing
    Dim str_dtdob As String = Nothing
    Dim str_dtjoin As String = Nothing
    Dim str_dtconfirm As String = Nothing
    Dim str_dtpromotion As String = Nothing




End Class