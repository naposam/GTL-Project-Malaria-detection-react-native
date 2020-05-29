<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ASSESSMENT
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.cboSelectSUB = New System.Windows.Forms.ComboBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnAddCA = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTotalCA = New System.Windows.Forms.TextBox()
        Me.txtCA2 = New System.Windows.Forms.TextBox()
        Me.txtCA1 = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnCaculate = New System.Windows.Forms.Button()
        Me.cboSub2 = New System.Windows.Forms.ComboBox()
        Me.lblGrade = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTotalScore = New System.Windows.Forms.TextBox()
        Me.txtExams = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnViewrecord = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(793, 535)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.cboSelectSUB)
        Me.TabPage1.Controls.Add(Me.txtID)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.btnAddCA)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtTotalCA)
        Me.TabPage1.Controls.Add(Me.txtCA2)
        Me.TabPage1.Controls.Add(Me.txtCA1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(785, 509)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ASSESSMENT"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'cboSelectSUB
        '
        Me.cboSelectSUB.FormattingEnabled = True
        Me.cboSelectSUB.Items.AddRange(New Object() {"Integrated Science", "English Language", "Social Studies", "Mathematics"})
        Me.cboSelectSUB.Location = New System.Drawing.Point(517, 20)
        Me.cboSelectSUB.Name = "cboSelectSUB"
        Me.cboSelectSUB.Size = New System.Drawing.Size(198, 21)
        Me.cboSelectSUB.TabIndex = 15
        Me.cboSelectSUB.Text = ".......Select Subject........."
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(129, 22)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(228, 29)
        Me.txtID.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 22)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "STUDENT ID"
        '
        'btnAddCA
        '
        Me.btnAddCA.Location = New System.Drawing.Point(114, 197)
        Me.btnAddCA.Name = "btnAddCA"
        Me.btnAddCA.Size = New System.Drawing.Size(45, 21)
        Me.btnAddCA.TabIndex = 12
        Me.btnAddCA.Text = "Add"
        Me.btnAddCA.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 22)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "CA2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 305)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 22)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "TOTAL"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 22)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "CA1"
        '
        'txtTotalCA
        '
        Me.txtTotalCA.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCA.Location = New System.Drawing.Point(114, 275)
        Me.txtTotalCA.Multiline = True
        Me.txtTotalCA.Name = "txtTotalCA"
        Me.txtTotalCA.ReadOnly = True
        Me.txtTotalCA.Size = New System.Drawing.Size(228, 52)
        Me.txtTotalCA.TabIndex = 10
        Me.txtTotalCA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCA2
        '
        Me.txtCA2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCA2.Location = New System.Drawing.Point(129, 141)
        Me.txtCA2.Multiline = True
        Me.txtCA2.Name = "txtCA2"
        Me.txtCA2.Size = New System.Drawing.Size(156, 52)
        Me.txtCA2.TabIndex = 10
        Me.txtCA2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCA1
        '
        Me.txtCA1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCA1.Location = New System.Drawing.Point(129, 74)
        Me.txtCA1.Multiline = True
        Me.txtCA1.Name = "txtCA1"
        Me.txtCA1.Size = New System.Drawing.Size(156, 52)
        Me.txtCA1.TabIndex = 10
        Me.txtCA1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnCaculate)
        Me.TabPage2.Controls.Add(Me.cboSub2)
        Me.TabPage2.Controls.Add(Me.lblGrade)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.txtTotalScore)
        Me.TabPage2.Controls.Add(Me.txtExams)
        Me.TabPage2.Controls.Add(Me.btnExit)
        Me.TabPage2.Controls.Add(Me.btnViewrecord)
        Me.TabPage2.Controls.Add(Me.btnClear)
        Me.TabPage2.Controls.Add(Me.btnSave)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(785, 509)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "EXAMINATION"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnCaculate
        '
        Me.btnCaculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCaculate.Location = New System.Drawing.Point(31, 320)
        Me.btnCaculate.Name = "btnCaculate"
        Me.btnCaculate.Size = New System.Drawing.Size(127, 36)
        Me.btnCaculate.TabIndex = 4
        Me.btnCaculate.Text = "Calculate "
        Me.btnCaculate.UseVisualStyleBackColor = True
        '
        'cboSub2
        '
        Me.cboSub2.FormattingEnabled = True
        Me.cboSub2.Items.AddRange(New Object() {"Integrated Science", "English Language", "Social Studies", "Mathematics"})
        Me.cboSub2.Location = New System.Drawing.Point(526, 40)
        Me.cboSub2.Name = "cboSub2"
        Me.cboSub2.Size = New System.Drawing.Size(121, 21)
        Me.cboSub2.TabIndex = 3
        Me.cboSub2.Text = ".......Select Subject........."
        '
        'lblGrade
        '
        Me.lblGrade.AutoSize = True
        Me.lblGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGrade.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrade.Location = New System.Drawing.Point(154, 224)
        Me.lblGrade.Name = "lblGrade"
        Me.lblGrade.Size = New System.Drawing.Size(92, 34)
        Me.lblGrade.TabIndex = 2
        Me.lblGrade.Text = "Grade"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(36, 224)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 22)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Grade"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 22)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "TOTAL"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(27, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 22)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "EXAM"
        '
        'txtTotalScore
        '
        Me.txtTotalScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalScore.Location = New System.Drawing.Point(118, 133)
        Me.txtTotalScore.Multiline = True
        Me.txtTotalScore.Name = "txtTotalScore"
        Me.txtTotalScore.ReadOnly = True
        Me.txtTotalScore.Size = New System.Drawing.Size(197, 48)
        Me.txtTotalScore.TabIndex = 1
        Me.txtTotalScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtExams
        '
        Me.txtExams.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExams.Location = New System.Drawing.Point(118, 40)
        Me.txtExams.Multiline = True
        Me.txtExams.Name = "txtExams"
        Me.txtExams.Size = New System.Drawing.Size(197, 48)
        Me.txtExams.TabIndex = 1
        Me.txtExams.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(561, 404)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(97, 32)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnViewrecord
        '
        Me.btnViewrecord.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewrecord.Location = New System.Drawing.Point(413, 404)
        Me.btnViewrecord.Name = "btnViewrecord"
        Me.btnViewrecord.Size = New System.Drawing.Size(131, 32)
        Me.btnViewrecord.TabIndex = 0
        Me.btnViewrecord.Text = "View Record"
        Me.btnViewrecord.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(270, 404)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(97, 32)
        Me.btnClear.TabIndex = 0
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(127, 404)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(97, 32)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'ASSESSMENT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(793, 535)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "ASSESSMENT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "STUDENT ASSESSMENT RECORDS KEEPING"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCA1 As System.Windows.Forms.TextBox
    Friend WithEvents btnAddCA As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTotalCA As System.Windows.Forms.TextBox
    Friend WithEvents txtCA2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtExams As System.Windows.Forms.TextBox
    Friend WithEvents btnViewrecord As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTotalScore As System.Windows.Forms.TextBox
    Friend WithEvents cboSelectSUB As System.Windows.Forms.ComboBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblGrade As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents cboSub2 As System.Windows.Forms.ComboBox
    Friend WithEvents btnCaculate As System.Windows.Forms.Button
End Class
