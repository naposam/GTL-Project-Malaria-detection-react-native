<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResultView
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
        Me.btnSEARCH = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.SCHOOLDataSet2 = New Our_ProjectWork.SCHOOLDataSet2()
        Me.ScoretableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ScoretableTableAdapter = New Our_ProjectWork.SCHOOLDataSet2TableAdapters.ScoretableTableAdapter()
        Me.TableAdapterManager = New Our_ProjectWork.SCHOOLDataSet2TableAdapters.TableAdapterManager()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.SCHOOLDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ScoretableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSEARCH
        '
        Me.btnSEARCH.Location = New System.Drawing.Point(541, 17)
        Me.btnSEARCH.Name = "btnSEARCH"
        Me.btnSEARCH.Size = New System.Drawing.Size(138, 36)
        Me.btnSEARCH.TabIndex = 0
        Me.btnSEARCH.Text = "SEARCH"
        Me.btnSEARCH.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(302, 26)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(160, 20)
        Me.txtID.TabIndex = 1
        '
        'SCHOOLDataSet2
        '
        Me.SCHOOLDataSet2.DataSetName = "SCHOOLDataSet2"
        Me.SCHOOLDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ScoretableBindingSource
        '
        Me.ScoretableBindingSource.DataMember = "Scoretable"
        Me.ScoretableBindingSource.DataSource = Me.SCHOOLDataSet2
        '
        'ScoretableTableAdapter
        '
        Me.ScoretableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ScoretableTableAdapter = Me.ScoretableTableAdapter
        Me.TableAdapterManager.UpdateOrder = Our_ProjectWork.SCHOOLDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(-7, 68)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(977, 379)
        Me.DataGridView1.TabIndex = 3
        '
        'ResultView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(971, 446)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.btnSEARCH)
        Me.Name = "ResultView"
        Me.Text = "ResultView"
        CType(Me.SCHOOLDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ScoretableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSEARCH As System.Windows.Forms.Button
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents SCHOOLDataSet2 As Our_ProjectWork.SCHOOLDataSet2
    Friend WithEvents ScoretableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ScoretableTableAdapter As Our_ProjectWork.SCHOOLDataSet2TableAdapters.ScoretableTableAdapter
    Friend WithEvents TableAdapterManager As Our_ProjectWork.SCHOOLDataSet2TableAdapters.TableAdapterManager
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
