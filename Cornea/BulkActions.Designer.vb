<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BulkActions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BulkActions))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.bkgnd_conn = New System.ComponentModel.BackgroundWorker
        Me.cmb_contracttype = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.dt_join = New System.Windows.Forms.DateTimePicker
        Me.CustomGroupBox1 = New Cornea.CustomGroupBox
        Me.btn_save = New System.Windows.Forms.Button
        Me.btn_close = New System.Windows.Forms.Button
        Me.TabControl1.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.CustomGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(6, 5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(431, 140)
        Me.TabControl1.TabIndex = 8
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.White
        Me.TabPage5.Controls.Add(Me.dt_join)
        Me.TabPage5.Controls.Add(Me.ComboBox1)
        Me.TabPage5.Controls.Add(Me.cmb_contracttype)
        Me.TabPage5.Controls.Add(Me.Label4)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(423, 114)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Action Details"
        '
        'bkgnd_conn
        '
        Me.bkgnd_conn.WorkerReportsProgress = True
        '
        'cmb_contracttype
        '
        Me.cmb_contracttype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_contracttype.FormattingEnabled = True
        Me.cmb_contracttype.Items.AddRange(New Object() {"Change Designation", "Change Gender", "Change Contract Type", "Change Branch", "Change Department", "Change Status", "Change Country", "Change Blood Group", "Change Religion", "Change Marital Status", "Change Recruitment Mode", "Change Joining Date", "Change Confirmation Date", "Change Promotional Date", "Change Shift"})
        Me.cmb_contracttype.Location = New System.Drawing.Point(138, 19)
        Me.cmb_contracttype.Name = "cmb_contracttype"
        Me.cmb_contracttype.Size = New System.Drawing.Size(264, 21)
        Me.cmb_contracttype.TabIndex = 152
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(6, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 18)
        Me.Label4.TabIndex = 151
        Me.Label4.Text = "Select Action"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Item Code", "Item Description"})
        Me.ComboBox1.Location = New System.Drawing.Point(138, 46)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(264, 21)
        Me.ComboBox1.TabIndex = 154
        '
        'dt_join
        '
        Me.dt_join.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.dt_join.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_join.Location = New System.Drawing.Point(138, 73)
        Me.dt_join.Name = "dt_join"
        Me.dt_join.Size = New System.Drawing.Size(128, 21)
        Me.dt_join.TabIndex = 241
        '
        'CustomGroupBox1
        '
        Me.CustomGroupBox1.BorderColor = System.Drawing.Color.DarkGray
        Me.CustomGroupBox1.Controls.Add(Me.btn_save)
        Me.CustomGroupBox1.Controls.Add(Me.btn_close)
        Me.CustomGroupBox1.Location = New System.Drawing.Point(6, 149)
        Me.CustomGroupBox1.Name = "CustomGroupBox1"
        Me.CustomGroupBox1.Size = New System.Drawing.Size(431, 43)
        Me.CustomGroupBox1.TabIndex = 10
        Me.CustomGroupBox1.TabStop = False
        '
        'btn_save
        '
        Me.btn_save.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.ForeColor = System.Drawing.Color.Black
        Me.btn_save.Image = Global.Cornea.My.Resources.Resources.checkmark_16
        Me.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_save.Location = New System.Drawing.Point(189, 10)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(115, 27)
        Me.btn_save.TabIndex = 75
        Me.btn_save.Text = "Apply"
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
        'BulkActions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(441, 199)
        Me.Controls.Add(Me.CustomGroupBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BulkActions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bulk Actions"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.CustomGroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents bkgnd_conn As System.ComponentModel.BackgroundWorker
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents CustomGroupBox1 As Cornea.CustomGroupBox
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents cmb_contracttype As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents dt_join As System.Windows.Forms.DateTimePicker
End Class
