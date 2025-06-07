<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImageModifier
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
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.cboFilter = New System.Windows.Forms.ComboBox()
        Me.picOriginal = New System.Windows.Forms.PictureBox()
        Me.picConverted = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.picOriginal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picConverted, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOpen
        '
        Me.btnOpen.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound
        Me.btnOpen.BackColor = System.Drawing.Color.CadetBlue
        Me.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpen.Font = New System.Drawing.Font("Javanese Text", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpen.ForeColor = System.Drawing.Color.White
        Me.btnOpen.Location = New System.Drawing.Point(29, 137)
        Me.btnOpen.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(168, 32)
        Me.btnOpen.TabIndex = 0
        Me.btnOpen.Text = "Open Image"
        Me.btnOpen.UseVisualStyleBackColor = False
        '
        'btnConvert
        '
        Me.btnConvert.BackColor = System.Drawing.Color.CadetBlue
        Me.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConvert.Font = New System.Drawing.Font("Javanese Text", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvert.ForeColor = System.Drawing.Color.White
        Me.btnConvert.Location = New System.Drawing.Point(29, 242)
        Me.btnConvert.Margin = New System.Windows.Forms.Padding(2)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(168, 32)
        Me.btnConvert.TabIndex = 1
        Me.btnConvert.Text = "Convert To"
        Me.btnConvert.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.CadetBlue
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Javanese Text", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(29, 292)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(168, 32)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'cboFilter
        '
        Me.cboFilter.BackColor = System.Drawing.Color.CadetBlue
        Me.cboFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboFilter.Font = New System.Drawing.Font("Javanese Text", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFilter.ForeColor = System.Drawing.Color.White
        Me.cboFilter.FormattingEnabled = True
        Me.cboFilter.Items.AddRange(New Object() {"   Monochrome", "   Gray - Averaging", "   Luma", "   Desaturation", "   Maximum Decomposition", "   Minimum Decomposition", "   Single Color Channel"})
        Me.cboFilter.Location = New System.Drawing.Point(29, 189)
        Me.cboFilter.Margin = New System.Windows.Forms.Padding(2)
        Me.cboFilter.Name = "cboFilter"
        Me.cboFilter.Size = New System.Drawing.Size(168, 33)
        Me.cboFilter.TabIndex = 3
        Me.cboFilter.Text = "   Please select a filter"
        '
        'picOriginal
        '
        Me.picOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picOriginal.Location = New System.Drawing.Point(222, 78)
        Me.picOriginal.Margin = New System.Windows.Forms.Padding(2)
        Me.picOriginal.Name = "picOriginal"
        Me.picOriginal.Size = New System.Drawing.Size(276, 153)
        Me.picOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picOriginal.TabIndex = 6
        Me.picOriginal.TabStop = False
        '
        'picConverted
        '
        Me.picConverted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picConverted.Location = New System.Drawing.Point(222, 251)
        Me.picConverted.Margin = New System.Windows.Forms.Padding(2)
        Me.picConverted.Name = "picConverted"
        Me.picConverted.Size = New System.Drawing.Size(276, 153)
        Me.picConverted.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picConverted.TabIndex = 7
        Me.picConverted.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Javanese Text", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(24, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(277, 47)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Welcome to GreyScale Filter"
        '
        'frmImageModifier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(521, 429)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.picConverted)
        Me.Controls.Add(Me.picOriginal)
        Me.Controls.Add(Me.cboFilter)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.btnOpen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmImageModifier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "My Image Modifier"
        CType(Me.picOriginal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picConverted, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOpen As Button
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents cboFilter As ComboBox
    Friend WithEvents picOriginal As PictureBox
    Friend WithEvents picConverted As PictureBox
    Friend WithEvents Label4 As Label
End Class
