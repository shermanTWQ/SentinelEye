<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SetinelEye
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
        Me.btnScan = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtProcess = New System.Windows.Forms.TextBox()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnScan
        '
        Me.btnScan.Location = New System.Drawing.Point(30, 113)
        Me.btnScan.Name = "btnScan"
        Me.btnScan.Size = New System.Drawing.Size(208, 23)
        Me.btnScan.TabIndex = 0
        Me.btnScan.Text = "Scan for Process"
        Me.btnScan.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(80, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Process Name"
        '
        'txtProcess
        '
        Me.txtProcess.Location = New System.Drawing.Point(30, 55)
        Me.txtProcess.Name = "txtProcess"
        Me.txtProcess.Size = New System.Drawing.Size(208, 22)
        Me.txtProcess.TabIndex = 2
        Me.txtProcess.Text = "<Input process name>"
        Me.txtProcess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDisplay
        '
        Me.lblDisplay.AutoSize = True
        Me.lblDisplay.Location = New System.Drawing.Point(27, 80)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(0, 17)
        Me.lblDisplay.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 153)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.txtProcess)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnScan)
        Me.Name = "Form1"
        Me.Text = "SentinelEye - 1.0"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnScan As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtProcess As TextBox
    Friend WithEvents lblDisplay As Label
End Class
