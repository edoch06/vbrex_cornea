<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddEmpDetails
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddEmpDetails))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.cmb_workstation = New System.Windows.Forms.ComboBox
        Me.txt_staffnames = New System.Windows.Forms.TextBox
        Me.Label46 = New System.Windows.Forms.Label
        Me.cmb_status = New System.Windows.Forms.ComboBox
        Me.cmb_department = New System.Windows.Forms.ComboBox
        Me.cmb_branch = New System.Windows.Forms.ComboBox
        Me.cmb_contracttype = New System.Windows.Forms.ComboBox
        Me.cmb_gender = New System.Windows.Forms.ComboBox
        Me.cmb_design = New System.Windows.Forms.ComboBox
        Me.txt_phcode = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txt_phnumber = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_staffid = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.cmb_country = New System.Windows.Forms.ComboBox
        Me.txt_altno = New System.Windows.Forms.TextBox
        Me.txt_phcode0 = New System.Windows.Forms.TextBox
        Me.txt_email = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txt_phnumber0 = New System.Windows.Forms.TextBox
        Me.txt_province = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txt_altcode = New System.Windows.Forms.TextBox
        Me.txt_city = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txt_street = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.cmb_nationality = New System.Windows.Forms.ComboBox
        Me.cmb_marital = New System.Windows.Forms.ComboBox
        Me.dt_dob = New System.Windows.Forms.DateTimePicker
        Me.cmb_religion = New System.Windows.Forms.ComboBox
        Me.cmb_blgroup = New System.Windows.Forms.ComboBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.cmb_shift = New System.Windows.Forms.ComboBox
        Me.dt_promotion = New System.Windows.Forms.DateTimePicker
        Me.dt_confirm = New System.Windows.Forms.DateTimePicker
        Me.dt_join = New System.Windows.Forms.DateTimePicker
        Me.txt_dept = New System.Windows.Forms.TextBox
        Me.txt_branch = New System.Windows.Forms.TextBox
        Me.cmb_recruit = New System.Windows.Forms.ComboBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.txt_design = New System.Windows.Forms.TextBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.txt_acno = New System.Windows.Forms.TextBox
        Me.Label38 = New System.Windows.Forms.Label
        Me.bkgnd_conn = New System.ComponentModel.BackgroundWorker
        Me.btn_next = New System.Windows.Forms.Button
        Me.btn_save = New System.Windows.Forms.Button
        Me.btn_close = New System.Windows.Forms.Button
        Me.load_tmr = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(4, 69)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(997, 330)
        Me.TabControl1.TabIndex = 8
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.cmb_workstation)
        Me.TabPage1.Controls.Add(Me.txt_staffnames)
        Me.TabPage1.Controls.Add(Me.Label46)
        Me.TabPage1.Controls.Add(Me.cmb_status)
        Me.TabPage1.Controls.Add(Me.cmb_department)
        Me.TabPage1.Controls.Add(Me.cmb_branch)
        Me.TabPage1.Controls.Add(Me.cmb_contracttype)
        Me.TabPage1.Controls.Add(Me.cmb_gender)
        Me.TabPage1.Controls.Add(Me.cmb_design)
        Me.TabPage1.Controls.Add(Me.txt_phcode)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.txt_phnumber)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txt_staffid)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(989, 304)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Basic Details"
        '
        'cmb_workstation
        '
        Me.cmb_workstation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_workstation.FormattingEnabled = True
        Me.cmb_workstation.Location = New System.Drawing.Point(147, 113)
        Me.cmb_workstation.Name = "cmb_workstation"
        Me.cmb_workstation.Size = New System.Drawing.Size(264, 21)
        Me.cmb_workstation.TabIndex = 156
        '
        'txt_staffnames
        '
        Me.txt_staffnames.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_staffnames.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_staffnames.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_staffnames.Location = New System.Drawing.Point(147, 59)
        Me.txt_staffnames.Name = "txt_staffnames"
        Me.txt_staffnames.Size = New System.Drawing.Size(264, 21)
        Me.txt_staffnames.TabIndex = 155
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.ForeColor = System.Drawing.Color.Black
        Me.Label46.Location = New System.Drawing.Point(15, 61)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(103, 18)
        Me.Label46.TabIndex = 154
        Me.Label46.Text = "Staff Full Names *"
        '
        'cmb_status
        '
        Me.cmb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_status.FormattingEnabled = True
        Me.cmb_status.Items.AddRange(New Object() {"Trainee", "Confimed", "Suspended", "Interdicted", "Terminated"})
        Me.cmb_status.Location = New System.Drawing.Point(615, 139)
        Me.cmb_status.Name = "cmb_status"
        Me.cmb_status.Size = New System.Drawing.Size(264, 21)
        Me.cmb_status.TabIndex = 153
        '
        'cmb_department
        '
        Me.cmb_department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_department.FormattingEnabled = True
        Me.cmb_department.Location = New System.Drawing.Point(615, 112)
        Me.cmb_department.Name = "cmb_department"
        Me.cmb_department.Size = New System.Drawing.Size(264, 21)
        Me.cmb_department.TabIndex = 152
        '
        'cmb_branch
        '
        Me.cmb_branch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_branch.FormattingEnabled = True
        Me.cmb_branch.Location = New System.Drawing.Point(615, 86)
        Me.cmb_branch.Name = "cmb_branch"
        Me.cmb_branch.Size = New System.Drawing.Size(264, 21)
        Me.cmb_branch.TabIndex = 151
        '
        'cmb_contracttype
        '
        Me.cmb_contracttype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_contracttype.FormattingEnabled = True
        Me.cmb_contracttype.Location = New System.Drawing.Point(615, 30)
        Me.cmb_contracttype.Name = "cmb_contracttype"
        Me.cmb_contracttype.Size = New System.Drawing.Size(264, 21)
        Me.cmb_contracttype.TabIndex = 150
        '
        'cmb_gender
        '
        Me.cmb_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_gender.FormattingEnabled = True
        Me.cmb_gender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmb_gender.Location = New System.Drawing.Point(147, 140)
        Me.cmb_gender.Name = "cmb_gender"
        Me.cmb_gender.Size = New System.Drawing.Size(264, 21)
        Me.cmb_gender.TabIndex = 149
        '
        'cmb_design
        '
        Me.cmb_design.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_design.FormattingEnabled = True
        Me.cmb_design.Location = New System.Drawing.Point(147, 86)
        Me.cmb_design.Name = "cmb_design"
        Me.cmb_design.Size = New System.Drawing.Size(264, 21)
        Me.cmb_design.TabIndex = 148
        '
        'txt_phcode
        '
        Me.txt_phcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_phcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_phcode.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_phcode.Location = New System.Drawing.Point(615, 57)
        Me.txt_phcode.Name = "txt_phcode"
        Me.txt_phcode.Size = New System.Drawing.Size(81, 21)
        Me.txt_phcode.TabIndex = 122
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(483, 140)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 18)
        Me.Label6.TabIndex = 102
        Me.Label6.Text = "Status"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(483, 113)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 18)
        Me.Label7.TabIndex = 100
        Me.Label7.Text = "Department"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(483, 86)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 18)
        Me.Label8.TabIndex = 98
        Me.Label8.Text = "Branch"
        '
        'txt_phnumber
        '
        Me.txt_phnumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_phnumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_phnumber.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_phnumber.Location = New System.Drawing.Point(702, 57)
        Me.txt_phnumber.Name = "txt_phnumber"
        Me.txt_phnumber.Size = New System.Drawing.Size(177, 21)
        Me.txt_phnumber.TabIndex = 97
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(483, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 18)
        Me.Label3.TabIndex = 96
        Me.Label3.Text = "Phone No "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(483, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 18)
        Me.Label4.TabIndex = 94
        Me.Label4.Text = "Contract Type "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(15, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 18)
        Me.Label5.TabIndex = 92
        Me.Label5.Text = "Gender "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(15, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 18)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "WorkStation *"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(15, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 18)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Designation "
        '
        'txt_staffid
        '
        Me.txt_staffid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_staffid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_staffid.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_staffid.Location = New System.Drawing.Point(147, 30)
        Me.txt_staffid.Name = "txt_staffid"
        Me.txt_staffid.Size = New System.Drawing.Size(264, 21)
        Me.txt_staffid.TabIndex = 87
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(15, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 18)
        Me.Label10.TabIndex = 86
        Me.Label10.Text = "Staff ID *"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.cmb_country)
        Me.TabPage2.Controls.Add(Me.txt_altno)
        Me.TabPage2.Controls.Add(Me.txt_phcode0)
        Me.TabPage2.Controls.Add(Me.txt_email)
        Me.TabPage2.Controls.Add(Me.Label18)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.txt_phnumber0)
        Me.TabPage2.Controls.Add(Me.txt_province)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.txt_altcode)
        Me.TabPage2.Controls.Add(Me.txt_city)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.txt_street)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(989, 304)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Contact Details"
        '
        'cmb_country
        '
        Me.cmb_country.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_country.FormattingEnabled = True
        Me.cmb_country.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmb_country.Location = New System.Drawing.Point(610, 93)
        Me.cmb_country.Name = "cmb_country"
        Me.cmb_country.Size = New System.Drawing.Size(264, 21)
        Me.cmb_country.TabIndex = 222
        '
        'txt_altno
        '
        Me.txt_altno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_altno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_altno.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_altno.Location = New System.Drawing.Point(263, 93)
        Me.txt_altno.Name = "txt_altno"
        Me.txt_altno.Size = New System.Drawing.Size(166, 21)
        Me.txt_altno.TabIndex = 221
        '
        'txt_phcode0
        '
        Me.txt_phcode0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_phcode0.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_phcode0.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_phcode0.Location = New System.Drawing.Point(165, 68)
        Me.txt_phcode0.Name = "txt_phcode0"
        Me.txt_phcode0.ReadOnly = True
        Me.txt_phcode0.Size = New System.Drawing.Size(92, 21)
        Me.txt_phcode0.TabIndex = 220
        '
        'txt_email
        '
        Me.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_email.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_email.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_email.Location = New System.Drawing.Point(165, 41)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(264, 21)
        Me.txt_email.TabIndex = 203
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(33, 43)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(35, 18)
        Me.Label18.TabIndex = 202
        Me.Label18.Text = "Email"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(33, 70)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(62, 18)
        Me.Label17.TabIndex = 204
        Me.Label17.Text = "Phone No"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(477, 97)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 18)
        Me.Label11.TabIndex = 216
        Me.Label11.Text = "Country"
        '
        'txt_phnumber0
        '
        Me.txt_phnumber0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_phnumber0.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_phnumber0.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_phnumber0.Location = New System.Drawing.Point(263, 68)
        Me.txt_phnumber0.Name = "txt_phnumber0"
        Me.txt_phnumber0.ReadOnly = True
        Me.txt_phnumber0.Size = New System.Drawing.Size(166, 21)
        Me.txt_phnumber0.TabIndex = 205
        '
        'txt_province
        '
        Me.txt_province.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_province.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_province.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_province.Location = New System.Drawing.Point(609, 68)
        Me.txt_province.Name = "txt_province"
        Me.txt_province.Size = New System.Drawing.Size(264, 21)
        Me.txt_province.TabIndex = 215
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(33, 97)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(85, 18)
        Me.Label16.TabIndex = 206
        Me.Label16.Text = "Alt. Phone No"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(477, 70)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(109, 18)
        Me.Label12.TabIndex = 214
        Me.Label12.Text = "County / Province"
        '
        'txt_altcode
        '
        Me.txt_altcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_altcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_altcode.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_altcode.Location = New System.Drawing.Point(165, 93)
        Me.txt_altcode.Name = "txt_altcode"
        Me.txt_altcode.Size = New System.Drawing.Size(92, 21)
        Me.txt_altcode.TabIndex = 207
        '
        'txt_city
        '
        Me.txt_city.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_city.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_city.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_city.Location = New System.Drawing.Point(609, 41)
        Me.txt_city.Name = "txt_city"
        Me.txt_city.Size = New System.Drawing.Size(264, 21)
        Me.txt_city.TabIndex = 213
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(477, 43)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(118, 18)
        Me.Label13.TabIndex = 212
        Me.Label13.Text = "City /Town / Village"
        '
        'txt_street
        '
        Me.txt_street.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_street.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_street.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_street.Location = New System.Drawing.Point(165, 123)
        Me.txt_street.Name = "txt_street"
        Me.txt_street.Size = New System.Drawing.Size(264, 21)
        Me.txt_street.TabIndex = 211
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(33, 125)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(77, 18)
        Me.Label14.TabIndex = 210
        Me.Label14.Text = "Street Name"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.cmb_nationality)
        Me.TabPage3.Controls.Add(Me.cmb_marital)
        Me.TabPage3.Controls.Add(Me.dt_dob)
        Me.TabPage3.Controls.Add(Me.cmb_religion)
        Me.TabPage3.Controls.Add(Me.cmb_blgroup)
        Me.TabPage3.Controls.Add(Me.Label20)
        Me.TabPage3.Controls.Add(Me.Label21)
        Me.TabPage3.Controls.Add(Me.Label23)
        Me.TabPage3.Controls.Add(Me.Label25)
        Me.TabPage3.Controls.Add(Me.Label27)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(989, 304)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Personal Details"
        '
        'cmb_nationality
        '
        Me.cmb_nationality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_nationality.FormattingEnabled = True
        Me.cmb_nationality.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmb_nationality.Location = New System.Drawing.Point(610, 53)
        Me.cmb_nationality.Name = "cmb_nationality"
        Me.cmb_nationality.Size = New System.Drawing.Size(264, 21)
        Me.cmb_nationality.TabIndex = 245
        '
        'cmb_marital
        '
        Me.cmb_marital.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_marital.FormattingEnabled = True
        Me.cmb_marital.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmb_marital.Location = New System.Drawing.Point(610, 26)
        Me.cmb_marital.Name = "cmb_marital"
        Me.cmb_marital.Size = New System.Drawing.Size(264, 21)
        Me.cmb_marital.TabIndex = 244
        '
        'dt_dob
        '
        Me.dt_dob.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.dt_dob.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_dob.Location = New System.Drawing.Point(168, 24)
        Me.dt_dob.Name = "dt_dob"
        Me.dt_dob.Size = New System.Drawing.Size(128, 21)
        Me.dt_dob.TabIndex = 243
        '
        'cmb_religion
        '
        Me.cmb_religion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_religion.FormattingEnabled = True
        Me.cmb_religion.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmb_religion.Location = New System.Drawing.Point(168, 80)
        Me.cmb_religion.Name = "cmb_religion"
        Me.cmb_religion.Size = New System.Drawing.Size(264, 21)
        Me.cmb_religion.TabIndex = 231
        '
        'cmb_blgroup
        '
        Me.cmb_blgroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_blgroup.FormattingEnabled = True
        Me.cmb_blgroup.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmb_blgroup.Location = New System.Drawing.Point(168, 53)
        Me.cmb_blgroup.Name = "cmb_blgroup"
        Me.cmb_blgroup.Size = New System.Drawing.Size(264, 21)
        Me.cmb_blgroup.TabIndex = 230
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(36, 27)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(31, 18)
        Me.Label20.TabIndex = 220
        Me.Label20.Text = "DOB"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(36, 54)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(77, 18)
        Me.Label21.TabIndex = 222
        Me.Label21.Text = "Blood Group"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(36, 81)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(51, 18)
        Me.Label23.TabIndex = 224
        Me.Label23.Text = "Religion"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(478, 27)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(84, 18)
        Me.Label25.TabIndex = 226
        Me.Label25.Text = "Marital Status"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(478, 54)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(67, 18)
        Me.Label27.TabIndex = 228
        Me.Label27.Text = "Nationality"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TabPage4.Controls.Add(Me.cmb_shift)
        Me.TabPage4.Controls.Add(Me.dt_promotion)
        Me.TabPage4.Controls.Add(Me.dt_confirm)
        Me.TabPage4.Controls.Add(Me.dt_join)
        Me.TabPage4.Controls.Add(Me.txt_dept)
        Me.TabPage4.Controls.Add(Me.txt_branch)
        Me.TabPage4.Controls.Add(Me.cmb_recruit)
        Me.TabPage4.Controls.Add(Me.Label29)
        Me.TabPage4.Controls.Add(Me.txt_design)
        Me.TabPage4.Controls.Add(Me.Label30)
        Me.TabPage4.Controls.Add(Me.Label31)
        Me.TabPage4.Controls.Add(Me.Label32)
        Me.TabPage4.Controls.Add(Me.Label33)
        Me.TabPage4.Controls.Add(Me.Label34)
        Me.TabPage4.Controls.Add(Me.Label35)
        Me.TabPage4.Controls.Add(Me.Label36)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(989, 304)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Job Information"
        '
        'cmb_shift
        '
        Me.cmb_shift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_shift.FormattingEnabled = True
        Me.cmb_shift.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmb_shift.Location = New System.Drawing.Point(688, 29)
        Me.cmb_shift.Name = "cmb_shift"
        Me.cmb_shift.Size = New System.Drawing.Size(264, 21)
        Me.cmb_shift.TabIndex = 243
        '
        'dt_promotion
        '
        Me.dt_promotion.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.dt_promotion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_promotion.Location = New System.Drawing.Point(211, 110)
        Me.dt_promotion.Name = "dt_promotion"
        Me.dt_promotion.Size = New System.Drawing.Size(128, 21)
        Me.dt_promotion.TabIndex = 242
        '
        'dt_confirm
        '
        Me.dt_confirm.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.dt_confirm.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_confirm.Location = New System.Drawing.Point(211, 83)
        Me.dt_confirm.Name = "dt_confirm"
        Me.dt_confirm.Size = New System.Drawing.Size(128, 21)
        Me.dt_confirm.TabIndex = 241
        '
        'dt_join
        '
        Me.dt_join.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.dt_join.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_join.Location = New System.Drawing.Point(211, 56)
        Me.dt_join.Name = "dt_join"
        Me.dt_join.Size = New System.Drawing.Size(128, 21)
        Me.dt_join.TabIndex = 240
        '
        'txt_dept
        '
        Me.txt_dept.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_dept.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_dept.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_dept.Location = New System.Drawing.Point(688, 84)
        Me.txt_dept.Name = "txt_dept"
        Me.txt_dept.ReadOnly = True
        Me.txt_dept.Size = New System.Drawing.Size(264, 21)
        Me.txt_dept.TabIndex = 239
        '
        'txt_branch
        '
        Me.txt_branch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_branch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_branch.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_branch.Location = New System.Drawing.Point(688, 57)
        Me.txt_branch.Name = "txt_branch"
        Me.txt_branch.ReadOnly = True
        Me.txt_branch.Size = New System.Drawing.Size(264, 21)
        Me.txt_branch.TabIndex = 238
        '
        'cmb_recruit
        '
        Me.cmb_recruit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_recruit.FormattingEnabled = True
        Me.cmb_recruit.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmb_recruit.Location = New System.Drawing.Point(211, 31)
        Me.cmb_recruit.Name = "cmb_recruit"
        Me.cmb_recruit.Size = New System.Drawing.Size(264, 21)
        Me.cmb_recruit.TabIndex = 236
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(39, 32)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(112, 18)
        Me.Label29.TabIndex = 220
        Me.Label29.Text = "Recruitment Mode"
        '
        'txt_design
        '
        Me.txt_design.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_design.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_design.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_design.Location = New System.Drawing.Point(688, 111)
        Me.txt_design.Name = "txt_design"
        Me.txt_design.ReadOnly = True
        Me.txt_design.Size = New System.Drawing.Size(264, 21)
        Me.txt_design.TabIndex = 235
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Black
        Me.Label30.Location = New System.Drawing.Point(39, 59)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(93, 18)
        Me.Label30.TabIndex = 222
        Me.Label30.Text = "Date Of Joining"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(516, 113)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(71, 18)
        Me.Label31.TabIndex = 234
        Me.Label31.Text = "Designation"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(39, 86)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(124, 18)
        Me.Label32.TabIndex = 224
        Me.Label32.Text = "Date Of Confirmation"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Black
        Me.Label33.Location = New System.Drawing.Point(516, 86)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(73, 18)
        Me.Label33.TabIndex = 232
        Me.Label33.Text = "Department"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.Black
        Me.Label34.Location = New System.Drawing.Point(39, 113)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(137, 18)
        Me.Label34.TabIndex = 226
        Me.Label34.Text = "Date Of Last Promotion"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Black
        Me.Label35.Location = New System.Drawing.Point(516, 59)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(51, 18)
        Me.Label35.TabIndex = 230
        Me.Label35.Text = "Branch "
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.Black
        Me.Label36.Location = New System.Drawing.Point(516, 32)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(33, 18)
        Me.Label36.TabIndex = 228
        Me.Label36.Text = "Shift"
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TabPage5.Controls.Add(Me.txt_acno)
        Me.TabPage5.Controls.Add(Me.Label38)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(989, 304)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Benefits & Renumeration Information"
        '
        'txt_acno
        '
        Me.txt_acno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_acno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_acno.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_acno.Location = New System.Drawing.Point(170, 26)
        Me.txt_acno.Name = "txt_acno"
        Me.txt_acno.Size = New System.Drawing.Size(264, 21)
        Me.txt_acno.TabIndex = 221
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Black
        Me.Label38.Location = New System.Drawing.Point(38, 28)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(104, 18)
        Me.Label38.TabIndex = 220
        Me.Label38.Text = "Bank Account No"
        '
        'bkgnd_conn
        '
        Me.bkgnd_conn.WorkerReportsProgress = True
        '
        'btn_next
        '
        Me.btn_next.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_next.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_next.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_next.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.btn_next.Image = Global.Cornea.My.Resources.Resources.saveall_24
        Me.btn_next.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_next.Location = New System.Drawing.Point(650, 12)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(113, 57)
        Me.btn_next.TabIndex = 199
        Me.btn_next.Text = "Save && Next"
        Me.btn_next.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_next.UseVisualStyleBackColor = False
        '
        'btn_save
        '
        Me.btn_save.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_save.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.btn_save.Image = Global.Cornea.My.Resources.Resources.save_24
        Me.btn_save.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_save.Location = New System.Drawing.Point(769, 12)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(113, 57)
        Me.btn_save.TabIndex = 200
        Me.btn_save.Text = "Save"
        Me.btn_save.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'btn_close
        '
        Me.btn_close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_close.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_close.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_close.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.btn_close.Image = Global.Cornea.My.Resources.Resources.cancel_24
        Me.btn_close.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_close.Location = New System.Drawing.Point(888, 12)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(113, 57)
        Me.btn_close.TabIndex = 201
        Me.btn_close.Text = "Cancel"
        Me.btn_close.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'load_tmr
        '
        Me.load_tmr.Interval = 200
        '
        'AddEmpDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1005, 399)
        Me.Controls.Add(Me.btn_next)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddEmpDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Employee Detail"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents bkgnd_conn As System.ComponentModel.BackgroundWorker
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_next As System.Windows.Forms.Button
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_phnumber As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_staffid As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_phnumber0 As System.Windows.Forms.TextBox
    Friend WithEvents txt_province As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_altcode As System.Windows.Forms.TextBox
    Friend WithEvents txt_city As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_street As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txt_design As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txt_acno As System.Windows.Forms.TextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents txt_phcode As System.Windows.Forms.TextBox
    Friend WithEvents cmb_status As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_department As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_branch As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_contracttype As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_gender As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_design As System.Windows.Forms.ComboBox
    Friend WithEvents txt_staffnames As System.Windows.Forms.TextBox
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents txt_phcode0 As System.Windows.Forms.TextBox
    Friend WithEvents txt_altno As System.Windows.Forms.TextBox
    Friend WithEvents cmb_country As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_religion As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_blgroup As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_recruit As System.Windows.Forms.ComboBox
    Friend WithEvents txt_dept As System.Windows.Forms.TextBox
    Friend WithEvents txt_branch As System.Windows.Forms.TextBox
    Friend WithEvents dt_promotion As System.Windows.Forms.DateTimePicker
    Friend WithEvents dt_confirm As System.Windows.Forms.DateTimePicker
    Friend WithEvents dt_join As System.Windows.Forms.DateTimePicker
    Friend WithEvents dt_dob As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmb_marital As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_nationality As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_shift As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_workstation As System.Windows.Forms.ComboBox
    Friend WithEvents load_tmr As System.Windows.Forms.Timer
End Class
