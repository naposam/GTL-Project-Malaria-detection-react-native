<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AssessmentForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AssessmentForm))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRawScore = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtOverRawMark = New System.Windows.Forms.TextBox()
        Me.TextBox19 = New System.Windows.Forms.TextBox()
        Me.TextBox20 = New System.Windows.Forms.TextBox()
        Me.TextBox21 = New System.Windows.Forms.TextBox()
        Me.TextBox22 = New System.Windows.Forms.TextBox()
        Me.TextBox23 = New System.Windows.Forms.TextBox()
        Me.TextBox24 = New System.Windows.Forms.TextBox()
        Me.TextBox25 = New System.Windows.Forms.TextBox()
        Me.TextBox26 = New System.Windows.Forms.TextBox()
        Me.TextBox27 = New System.Windows.Forms.TextBox()
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnViewRecords = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCGrade = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtConExams = New System.Windows.Forms.TextBox()
        Me.txtRawExams = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtGrade = New System.Windows.Forms.TextBox()
        Me.txtTotalScore = New System.Windows.Forms.TextBox()
        Me.txtExamsTotal = New System.Windows.Forms.TextBox()
        Me.txtTotalCa = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.AutoCompleteCustomSource.AddRange(New String() {"Quiz1", "Quiz2", "Project", "Assignment", "ClassWork", "Presentation", "Class Attendance"})
        Me.TextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextBox1.Location = New System.Drawing.Point(37, 37)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(141, 22)
        Me.TextBox1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.TextBox9)
        Me.GroupBox1.Controls.Add(Me.TextBox8)
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(66, 92)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(219, 448)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ASSESSMENT TYPE"
        '
        'TextBox9
        '
        Me.TextBox9.AutoCompleteCustomSource.AddRange(New String() {"Quiz1", "Quiz2", "Project", "Assignment", "ClassWork", "Presentation", "Class Attendance"})
        Me.TextBox9.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TextBox9.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextBox9.Location = New System.Drawing.Point(37, 371)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(141, 22)
        Me.TextBox9.TabIndex = 25
        '
        'TextBox8
        '
        Me.TextBox8.AutoCompleteCustomSource.AddRange(New String() {"Quiz1", "Quiz2", "Project", "Assignment", "ClassWork", "Presentation", "Class Attendance"})
        Me.TextBox8.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TextBox8.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextBox8.Location = New System.Drawing.Point(37, 331)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(141, 22)
        Me.TextBox8.TabIndex = 22
        '
        'TextBox7
        '
        Me.TextBox7.AutoCompleteCustomSource.AddRange(New String() {"Quiz1", "Quiz2", "Project", "Assignment", "ClassWork", "Presentation", "Class Attendance"})
        Me.TextBox7.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TextBox7.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextBox7.Location = New System.Drawing.Point(37, 291)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(141, 22)
        Me.TextBox7.TabIndex = 19
        '
        'TextBox6
        '
        Me.TextBox6.AutoCompleteCustomSource.AddRange(New String() {"Quiz1", "Quiz2", "Project", "Assignment", "ClassWork", "Presentation", "Class Attendance"})
        Me.TextBox6.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TextBox6.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextBox6.Location = New System.Drawing.Point(37, 245)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(141, 22)
        Me.TextBox6.TabIndex = 16
        '
        'TextBox5
        '
        Me.TextBox5.AutoCompleteCustomSource.AddRange(New String() {"Quiz1", "Quiz2", "Project", "Assignment", "ClassWork", "Presentation", "Class Attendance"})
        Me.TextBox5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TextBox5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextBox5.Location = New System.Drawing.Point(37, 203)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(141, 22)
        Me.TextBox5.TabIndex = 13
        '
        'TextBox4
        '
        Me.TextBox4.AutoCompleteCustomSource.AddRange(New String() {"Quiz1", "Quiz2", "Project", "Assignment", "ClassWork", "Presentation", "Class Attendance"})
        Me.TextBox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TextBox4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextBox4.Location = New System.Drawing.Point(37, 160)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(141, 22)
        Me.TextBox4.TabIndex = 10
        '
        'TextBox3
        '
        Me.TextBox3.AutoCompleteCustomSource.AddRange(New String() {"Quiz1", "Quiz2", "Project", "Assignment", "ClassWork", "Presentation", "Class Attendance"})
        Me.TextBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TextBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextBox3.Location = New System.Drawing.Point(37, 116)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(141, 22)
        Me.TextBox3.TabIndex = 7
        '
        'TextBox2
        '
        Me.TextBox2.AutoCompleteCustomSource.AddRange(New String() {"Quiz1", "Quiz2", "Project", "Assignment", "ClassWork", "Presentation", "Class Attendance"})
        Me.TextBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TextBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextBox2.Location = New System.Drawing.Point(37, 77)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(141, 22)
        Me.TextBox2.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtRawScore)
        Me.GroupBox2.Controls.Add(Me.TextBox10)
        Me.GroupBox2.Controls.Add(Me.TextBox11)
        Me.GroupBox2.Controls.Add(Me.TextBox12)
        Me.GroupBox2.Controls.Add(Me.TextBox13)
        Me.GroupBox2.Controls.Add(Me.TextBox14)
        Me.GroupBox2.Controls.Add(Me.TextBox15)
        Me.GroupBox2.Controls.Add(Me.TextBox16)
        Me.GroupBox2.Controls.Add(Me.TextBox17)
        Me.GroupBox2.Controls.Add(Me.TextBox18)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(311, 92)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(219, 448)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SCORE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 419)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Total"
        '
        'txtRawScore
        '
        Me.txtRawScore.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRawScore.Location = New System.Drawing.Point(127, 397)
        Me.txtRawScore.Multiline = True
        Me.txtRawScore.Name = "txtRawScore"
        Me.txtRawScore.ReadOnly = True
        Me.txtRawScore.Size = New System.Drawing.Size(92, 51)
        Me.txtRawScore.TabIndex = 0
        Me.txtRawScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox10
        '
        Me.TextBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox10.Location = New System.Drawing.Point(37, 364)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(141, 26)
        Me.TextBox10.TabIndex = 26
        Me.TextBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox11
        '
        Me.TextBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox11.Location = New System.Drawing.Point(37, 324)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(141, 26)
        Me.TextBox11.TabIndex = 23
        Me.TextBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox12
        '
        Me.TextBox12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox12.Location = New System.Drawing.Point(37, 284)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(141, 26)
        Me.TextBox12.TabIndex = 20
        Me.TextBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox13
        '
        Me.TextBox13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox13.Location = New System.Drawing.Point(37, 238)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(141, 26)
        Me.TextBox13.TabIndex = 17
        Me.TextBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox14
        '
        Me.TextBox14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox14.Location = New System.Drawing.Point(37, 196)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(141, 26)
        Me.TextBox14.TabIndex = 14
        Me.TextBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox15
        '
        Me.TextBox15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox15.Location = New System.Drawing.Point(37, 153)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(141, 26)
        Me.TextBox15.TabIndex = 11
        Me.TextBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox16
        '
        Me.TextBox16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox16.Location = New System.Drawing.Point(37, 109)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(141, 26)
        Me.TextBox16.TabIndex = 8
        Me.TextBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox17
        '
        Me.TextBox17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox17.Location = New System.Drawing.Point(37, 70)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(141, 26)
        Me.TextBox17.TabIndex = 5
        Me.TextBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox18
        '
        Me.TextBox18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox18.Location = New System.Drawing.Point(37, 30)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(141, 26)
        Me.TextBox18.TabIndex = 2
        Me.TextBox18.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txtOverRawMark)
        Me.GroupBox3.Controls.Add(Me.TextBox19)
        Me.GroupBox3.Controls.Add(Me.TextBox20)
        Me.GroupBox3.Controls.Add(Me.TextBox21)
        Me.GroupBox3.Controls.Add(Me.TextBox22)
        Me.GroupBox3.Controls.Add(Me.TextBox23)
        Me.GroupBox3.Controls.Add(Me.TextBox24)
        Me.GroupBox3.Controls.Add(Me.TextBox25)
        Me.GroupBox3.Controls.Add(Me.TextBox26)
        Me.GroupBox3.Controls.Add(Me.TextBox27)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(570, 92)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(219, 448)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = " OVER All TOTAL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(72, 419)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total"
        '
        'txtOverRawMark
        '
        Me.txtOverRawMark.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOverRawMark.Location = New System.Drawing.Point(135, 397)
        Me.txtOverRawMark.Multiline = True
        Me.txtOverRawMark.Name = "txtOverRawMark"
        Me.txtOverRawMark.ReadOnly = True
        Me.txtOverRawMark.Size = New System.Drawing.Size(84, 51)
        Me.txtOverRawMark.TabIndex = 0
        Me.txtOverRawMark.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox19
        '
        Me.TextBox19.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox19.ForeColor = System.Drawing.Color.Red
        Me.TextBox19.Location = New System.Drawing.Point(37, 364)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(141, 29)
        Me.TextBox19.TabIndex = 27
        Me.TextBox19.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox20
        '
        Me.TextBox20.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox20.ForeColor = System.Drawing.Color.Red
        Me.TextBox20.Location = New System.Drawing.Point(37, 324)
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New System.Drawing.Size(141, 29)
        Me.TextBox20.TabIndex = 24
        Me.TextBox20.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox21
        '
        Me.TextBox21.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox21.ForeColor = System.Drawing.Color.Red
        Me.TextBox21.Location = New System.Drawing.Point(37, 284)
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New System.Drawing.Size(141, 29)
        Me.TextBox21.TabIndex = 21
        Me.TextBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox22
        '
        Me.TextBox22.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox22.ForeColor = System.Drawing.Color.Red
        Me.TextBox22.Location = New System.Drawing.Point(37, 238)
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New System.Drawing.Size(141, 29)
        Me.TextBox22.TabIndex = 18
        Me.TextBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox23
        '
        Me.TextBox23.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox23.ForeColor = System.Drawing.Color.Red
        Me.TextBox23.Location = New System.Drawing.Point(37, 196)
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New System.Drawing.Size(141, 29)
        Me.TextBox23.TabIndex = 15
        Me.TextBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox24
        '
        Me.TextBox24.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox24.ForeColor = System.Drawing.Color.Red
        Me.TextBox24.Location = New System.Drawing.Point(37, 153)
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New System.Drawing.Size(141, 29)
        Me.TextBox24.TabIndex = 12
        Me.TextBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox25
        '
        Me.TextBox25.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox25.ForeColor = System.Drawing.Color.Red
        Me.TextBox25.Location = New System.Drawing.Point(37, 109)
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New System.Drawing.Size(141, 29)
        Me.TextBox25.TabIndex = 9
        Me.TextBox25.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox26
        '
        Me.TextBox26.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox26.ForeColor = System.Drawing.Color.Red
        Me.TextBox26.Location = New System.Drawing.Point(37, 70)
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New System.Drawing.Size(141, 29)
        Me.TextBox26.TabIndex = 6
        Me.TextBox26.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox27
        '
        Me.TextBox27.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox27.ForeColor = System.Drawing.Color.Red
        Me.TextBox27.Location = New System.Drawing.Point(37, 30)
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Size = New System.Drawing.Size(141, 29)
        Me.TextBox27.TabIndex = 3
        Me.TextBox27.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtStudentID
        '
        Me.txtStudentID.Location = New System.Drawing.Point(116, 25)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(178, 20)
        Me.txtStudentID.TabIndex = 23
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Mathematics", "English Language", "Integrated Science", "Social Studies", "Biology", "Chemistry", "History"})
        Me.ComboBox1.Location = New System.Drawing.Point(401, 25)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(192, 21)
        Me.ComboBox1.TabIndex = 33
        '
        'btnViewRecords
        '
        Me.btnViewRecords.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnViewRecords.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnViewRecords.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnViewRecords.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewRecords.ForeColor = System.Drawing.Color.White
        Me.btnViewRecords.Location = New System.Drawing.Point(83, 546)
        Me.btnViewRecords.Name = "btnViewRecords"
        Me.btnViewRecords.Size = New System.Drawing.Size(161, 61)
        Me.btnViewRecords.TabIndex = 4
        Me.btnViewRecords.Text = "VIEW RECORDS"
        Me.btnViewRecords.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(281, 546)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(120, 61)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(438, 546)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(107, 61)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCGrade
        '
        Me.btnCGrade.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCGrade.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCGrade.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCGrade.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCGrade.ForeColor = System.Drawing.Color.White
        Me.btnCGrade.Location = New System.Drawing.Point(607, 546)
        Me.btnCGrade.Name = "btnCGrade"
        Me.btnCGrade.Size = New System.Drawing.Size(143, 61)
        Me.btnCGrade.TabIndex = 4
        Me.btnCGrade.Text = "CALCULATE GRADE"
        Me.btnCGrade.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(27, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Student ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(334, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 18)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Subject"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.txtConExams)
        Me.GroupBox4.Controls.Add(Me.txtRawExams)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(873, 92)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(282, 148)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "EXAMINATION"
        '
        'txtConExams
        '
        Me.txtConExams.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConExams.Location = New System.Drawing.Point(91, 104)
        Me.txtConExams.Name = "txtConExams"
        Me.txtConExams.Size = New System.Drawing.Size(100, 31)
        Me.txtConExams.TabIndex = 0
        Me.txtConExams.Visible = False
        '
        'txtRawExams
        '
        Me.txtRawExams.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRawExams.Location = New System.Drawing.Point(108, 56)
        Me.txtRawExams.Name = "txtRawExams"
        Me.txtRawExams.Size = New System.Drawing.Size(100, 31)
        Me.txtRawExams.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(26, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 20)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "SCORE"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.txtGrade)
        Me.GroupBox5.Controls.Add(Me.txtTotalScore)
        Me.GroupBox5.Controls.Add(Me.txtExamsTotal)
        Me.GroupBox5.Controls.Add(Me.txtTotalCa)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.White
        Me.GroupBox5.Location = New System.Drawing.Point(873, 270)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(282, 331)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "RESULTS DETAILS"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(88, 252)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 18)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "GRADE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(36, 168)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 18)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "TOTAL SCORE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(27, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 18)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "EXAMS SCORE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(46, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 18)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "TOTAL CA"
        '
        'txtGrade
        '
        Me.txtGrade.Location = New System.Drawing.Point(172, 234)
        Me.txtGrade.Multiline = True
        Me.txtGrade.Name = "txtGrade"
        Me.txtGrade.ReadOnly = True
        Me.txtGrade.Size = New System.Drawing.Size(100, 50)
        Me.txtGrade.TabIndex = 0
        '
        'txtTotalScore
        '
        Me.txtTotalScore.Location = New System.Drawing.Point(176, 158)
        Me.txtTotalScore.Multiline = True
        Me.txtTotalScore.Name = "txtTotalScore"
        Me.txtTotalScore.ReadOnly = True
        Me.txtTotalScore.Size = New System.Drawing.Size(100, 45)
        Me.txtTotalScore.TabIndex = 0
        '
        'txtExamsTotal
        '
        Me.txtExamsTotal.Location = New System.Drawing.Point(172, 94)
        Me.txtExamsTotal.Multiline = True
        Me.txtExamsTotal.Name = "txtExamsTotal"
        Me.txtExamsTotal.ReadOnly = True
        Me.txtExamsTotal.Size = New System.Drawing.Size(100, 45)
        Me.txtExamsTotal.TabIndex = 0
        '
        'txtTotalCa
        '
        Me.txtTotalCa.Location = New System.Drawing.Point(172, 25)
        Me.txtTotalCa.Multiline = True
        Me.txtTotalCa.Name = "txtTotalCa"
        Me.txtTotalCa.ReadOnly = True
        Me.txtTotalCa.Size = New System.Drawing.Size(100, 51)
        Me.txtTotalCa.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(521, 92)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 18)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Out Of"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1045, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 36)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "LOG OUT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AssessmentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1199, 613)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCGrade)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnViewRecords)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.txtStudentID)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "AssessmentForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AssessmentForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRawScore As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox18 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtOverRawMark As System.Windows.Forms.TextBox
    Friend WithEvents TextBox19 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox20 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox21 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox22 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox23 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox24 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox25 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox26 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox27 As System.Windows.Forms.TextBox
    Friend WithEvents txtStudentID As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents btnViewRecords As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCGrade As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRawExams As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtGrade As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalScore As System.Windows.Forms.TextBox
    Friend WithEvents txtExamsTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalCa As System.Windows.Forms.TextBox
    Friend WithEvents txtConExams As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
