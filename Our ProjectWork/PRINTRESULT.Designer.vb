<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PRINTRESULT
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PRINTRESULT))
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRINTDataSet1 = New Our_ProjectWork.PRINTDataSet1()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataTable1TableAdapter = New Our_ProjectWork.PRINTDataSet1TableAdapters.DataTable1TableAdapter()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRINTDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataTable1BindingSource
        '
        Me.DataTable1BindingSource.DataMember = "DataTable1"
        Me.DataTable1BindingSource.DataSource = Me.PRINTDataSet1
        '
        'PRINTDataSet1
        '
        Me.PRINTDataSet1.DataSetName = "PRINTDataSet1"
        Me.PRINTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(436, 21)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(174, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(250, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ENTER STUDENT ID"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(637, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 31)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "SEARCH"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.DataTable1BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Our_ProjectWork.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(-1, 56)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(955, 490)
        Me.ReportViewer1.TabIndex = 3
        '
        'DataTable1TableAdapter
        '
        Me.DataTable1TableAdapter.ClearBeforeFill = True
        '
        'PRINTRESULT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(952, 543)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "PRINTRESULT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PRINTRESULT"
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRINTDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DataTable1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PRINTDataSet1 As Our_ProjectWork.PRINTDataSet1
    Friend WithEvents DataTable1TableAdapter As Our_ProjectWork.PRINTDataSet1TableAdapters.DataTable1TableAdapter
End Class
