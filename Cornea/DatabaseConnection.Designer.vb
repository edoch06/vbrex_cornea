﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DatabaseConnection
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DatabaseConnection))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.txt_string = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.CustomGroupBox1 = New Cornea.CustomGroupBox
        Me.lbl_connect = New System.Windows.Forms.Label
        Me.btn_close = New System.Windows.Forms.Button
        Me.btn_connect = New System.Windows.Forms.Button
        Me.bkgnd_conn = New System.ComponentModel.BackgroundWorker
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.CustomGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(507, 51)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(73, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 25)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "Database Connections"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Cornea.My.Resources.Resources.link_48
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkGray
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 50)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(507, 1)
        Me.Panel2.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(0, 57)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(509, 117)
        Me.TabControl1.TabIndex = 8
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txt_string)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(501, 91)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Connections Details "
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txt_string
        '
        Me.txt_string.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_string.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_string.Location = New System.Drawing.Point(125, 21)
        Me.txt_string.Name = "txt_string"
        Me.txt_string.Size = New System.Drawing.Size(357, 22)
        Me.txt_string.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(11, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 13)
        Me.Label10.TabIndex = 82
        Me.Label10.Text = "Connection String"
        '
        'CustomGroupBox1
        '
        Me.CustomGroupBox1.BorderColor = System.Drawing.Color.DarkGray
        Me.CustomGroupBox1.Controls.Add(Me.lbl_connect)
        Me.CustomGroupBox1.Controls.Add(Me.btn_close)
        Me.CustomGroupBox1.Controls.Add(Me.btn_connect)
        Me.CustomGroupBox1.Location = New System.Drawing.Point(0, 180)
        Me.CustomGroupBox1.Name = "CustomGroupBox1"
        Me.CustomGroupBox1.Size = New System.Drawing.Size(505, 43)
        Me.CustomGroupBox1.TabIndex = 9
        Me.CustomGroupBox1.TabStop = False
        '
        'lbl_connect
        '
        Me.lbl_connect.AutoSize = True
        Me.lbl_connect.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_connect.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.lbl_connect.Location = New System.Drawing.Point(15, 16)
        Me.lbl_connect.Name = "lbl_connect"
        Me.lbl_connect.Size = New System.Drawing.Size(83, 13)
        Me.lbl_connect.TabIndex = 75
        Me.lbl_connect.Text = "Not Connected"
        '
        'btn_close
        '
        Me.btn_close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_close.ForeColor = System.Drawing.Color.Black
        Me.btn_close.Image = Global.Cornea.My.Resources.Resources.unavailable_16
        Me.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_close.Location = New System.Drawing.Point(370, 9)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(124, 27)
        Me.btn_close.TabIndex = 74
        Me.btn_close.Text = "Cancel"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'btn_connect
        '
        Me.btn_connect.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_connect.ForeColor = System.Drawing.Color.Black
        Me.btn_connect.Image = Global.Cornea.My.Resources.Resources.link_16
        Me.btn_connect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_connect.Location = New System.Drawing.Point(240, 9)
        Me.btn_connect.Name = "btn_connect"
        Me.btn_connect.Size = New System.Drawing.Size(124, 27)
        Me.btn_connect.TabIndex = 73
        Me.btn_connect.Text = "Connect"
        Me.btn_connect.UseVisualStyleBackColor = True
        '
        'bkgnd_conn
        '
        Me.bkgnd_conn.WorkerReportsProgress = True
        '
        'DatabaseConnection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(507, 224)
        Me.Controls.Add(Me.CustomGroupBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DatabaseConnection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DatabaseConnection"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.CustomGroupBox1.ResumeLayout(False)
        Me.CustomGroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents txt_string As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CustomGroupBox1 As Cornea.CustomGroupBox
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents btn_connect As System.Windows.Forms.Button
    Friend WithEvents lbl_connect As System.Windows.Forms.Label
    Friend WithEvents bkgnd_conn As System.ComponentModel.BackgroundWorker
End Class
