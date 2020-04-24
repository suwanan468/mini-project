<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sellPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.inputAmount = New System.Windows.Forms.NumericUpDown()
        Me.inputOrderMenu = New System.Windows.Forms.ComboBox()
        Me.btnSell = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dataSellD = New System.Windows.Forms.DataGridView()
        Me.dataSellM = New System.Windows.Forms.DataGridView()
        Me.dataSellY = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.inputAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataSellD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataSellM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataSellY, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnClose.Location = New System.Drawing.Point(3, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(56, 28)
        Me.btnClose.TabIndex = 24
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.inputAmount)
        Me.Panel1.Controls.Add(Me.inputOrderMenu)
        Me.Panel1.Controls.Add(Me.btnSell)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(343, 272)
        Me.Panel1.TabIndex = 25
        '
        'btnClear
        '
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnClear.Location = New System.Drawing.Point(286, 1)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(56, 28)
        Me.btnClear.TabIndex = 31
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'inputAmount
        '
        Me.inputAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.inputAmount.Location = New System.Drawing.Point(95, 148)
        Me.inputAmount.Name = "inputAmount"
        Me.inputAmount.Size = New System.Drawing.Size(223, 26)
        Me.inputAmount.TabIndex = 30
        '
        'inputOrderMenu
        '
        Me.inputOrderMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.inputOrderMenu.FormattingEnabled = True
        Me.inputOrderMenu.Location = New System.Drawing.Point(95, 73)
        Me.inputOrderMenu.Name = "inputOrderMenu"
        Me.inputOrderMenu.Size = New System.Drawing.Size(223, 28)
        Me.inputOrderMenu.TabIndex = 29
        '
        'btnSell
        '
        Me.btnSell.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSell.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSell.Location = New System.Drawing.Point(110, 203)
        Me.btnSell.Name = "btnSell"
        Me.btnSell.Size = New System.Drawing.Size(123, 46)
        Me.btnSell.TabIndex = 28
        Me.btnSell.Text = "Sell"
        Me.btnSell.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(18, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 20)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Amount"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(18, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 20)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Menu"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(136, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 25)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Sell list"
        '
        'dataSellD
        '
        Me.dataSellD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataSellD.Location = New System.Drawing.Point(361, 12)
        Me.dataSellD.Name = "dataSellD"
        Me.dataSellD.Size = New System.Drawing.Size(343, 537)
        Me.dataSellD.TabIndex = 26
        '
        'dataSellM
        '
        Me.dataSellM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataSellM.Location = New System.Drawing.Point(710, 12)
        Me.dataSellM.Name = "dataSellM"
        Me.dataSellM.Size = New System.Drawing.Size(343, 537)
        Me.dataSellM.TabIndex = 27
        '
        'dataSellY
        '
        Me.dataSellY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataSellY.Location = New System.Drawing.Point(12, 290)
        Me.dataSellY.Name = "dataSellY"
        Me.dataSellY.Size = New System.Drawing.Size(343, 259)
        Me.dataSellY.TabIndex = 28
        '
        'sellPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.ClientSize = New System.Drawing.Size(1064, 561)
        Me.Controls.Add(Me.dataSellY)
        Me.Controls.Add(Me.dataSellM)
        Me.Controls.Add(Me.dataSellD)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "sellPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "sellPage"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.inputAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataSellD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataSellM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataSellY, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dataSellD As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents inputOrderMenu As ComboBox
    Friend WithEvents btnSell As Button
    Friend WithEvents inputAmount As NumericUpDown
    Friend WithEvents btnClear As Button
    Friend WithEvents dataSellM As DataGridView
    Friend WithEvents dataSellY As DataGridView
End Class
