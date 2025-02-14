<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditCountry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditCountry))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.txt_name = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.CustomGroupBox1 = New Cornea.CustomGroupBox
        Me.btn_save = New System.Windows.Forms.Button
        Me.btn_close = New System.Windows.Forms.Button
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.CustomGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(431, 117)
        Me.TabControl1.TabIndex = 8
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txt_name)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(423, 91)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Country Details"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txt_name
        '
        Me.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_name.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_name.Location = New System.Drawing.Point(143, 19)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(264, 21)
        Me.txt_name.TabIndex = 85
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(11, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 18)
        Me.Label10.TabIndex = 84
        Me.Label10.Text = "Country *"
        '
        'CustomGroupBox1
        '
        Me.CustomGroupBox1.BorderColor = System.Drawing.Color.DarkGray
        Me.CustomGroupBox1.Controls.Add(Me.btn_save)
        Me.CustomGroupBox1.Controls.Add(Me.btn_close)
        Me.CustomGroupBox1.Location = New System.Drawing.Point(0, 123)
        Me.CustomGroupBox1.Name = "CustomGroupBox1"
        Me.CustomGroupBox1.Size = New System.Drawing.Size(431, 43)
        Me.CustomGroupBox1.TabIndex = 9
        Me.CustomGroupBox1.TabStop = False
        '
        'btn_save
        '
        Me.btn_save.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.ForeColor = System.Drawing.Color.Black
        Me.btn_save.Image = Global.Cornea.My.Resources.Resources.save_16
        Me.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_save.Location = New System.Drawing.Point(189, 10)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(115, 27)
        Me.btn_save.TabIndex = 75
        Me.btn_save.Text = "Save "
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_close
        '
        Me.btn_close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_close.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_close.ForeColor = System.Drawing.Color.Black
        Me.btn_close.Image = Global.Cornea.My.Resources.Resources.cancel_16
        Me.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_close.Location = New System.Drawing.Point(310, 10)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(115, 27)
        Me.btn_close.TabIndex = 74
        Me.btn_close.Text = "Cancel"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'EditCountry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(435, 172)
        Me.Controls.Add(Me.CustomGroupBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EditCountry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Country"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.CustomGroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents CustomGroupBox1 As Cornea.CustomGroupBox
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btn_save As System.Windows.Forms.Button
End Class
