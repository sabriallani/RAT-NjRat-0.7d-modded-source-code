<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Builder
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
        Me.host = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.port = New System.Windows.Forms.NumericUpDown()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.VN = New System.Windows.Forms.TextBox()
        Me.bsod = New System.Windows.Forms.CheckBox()
        Me.T1 = New System.Windows.Forms.TextBox()
        Me.Isf = New System.Windows.Forms.CheckBox()
        Me.Isu = New System.Windows.Forms.CheckBox()
        Me.klen = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Anti_CH = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.exe = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dir = New System.Windows.Forms.ComboBox()
        Me.Idr = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.USB_SP = New System.Windows.Forms.CheckBox()
        Me.CKOBF = New System.Windows.Forms.CheckBox()
        Me.CKUpx = New System.Windows.Forms.CheckBox()
        CType(Me.port, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.klen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'host
        '
        Me.host.BackColor = System.Drawing.Color.Black
        Me.host.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.host.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.host.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.host.Location = New System.Drawing.Point(6, 38)
        Me.host.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.host.Name = "host"
        Me.host.Size = New System.Drawing.Size(278, 26)
        Me.host.TabIndex = 0
        Me.host.Text = "127.0.0.1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label1.Location = New System.Drawing.Point(10, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Host"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label2.Location = New System.Drawing.Point(290, 14)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Port"
        '
        'port
        '
        Me.port.BackColor = System.Drawing.Color.Black
        Me.port.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.port.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.port.Location = New System.Drawing.Point(294, 38)
        Me.port.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.port.Maximum = New Decimal(New Integer() {60000, 0, 0, 0})
        Me.port.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.port.Name = "port"
        Me.port.Size = New System.Drawing.Size(104, 26)
        Me.port.TabIndex = 3
        Me.port.Value = New Decimal(New Integer() {1177, 0, 0, 0})
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Button1.Location = New System.Drawing.Point(394, 261)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(244, 67)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Build"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label5.Location = New System.Drawing.Point(10, 74)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 19)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "VicTim Name"
        '
        'VN
        '
        Me.VN.BackColor = System.Drawing.Color.Black
        Me.VN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.VN.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VN.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.VN.Location = New System.Drawing.Point(6, 100)
        Me.VN.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.VN.Name = "VN"
        Me.VN.Size = New System.Drawing.Size(378, 26)
        Me.VN.TabIndex = 10
        Me.VN.Text = "MyBot"
        '
        'bsod
        '
        Me.bsod.AutoSize = True
        Me.bsod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bsod.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bsod.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.bsod.Location = New System.Drawing.Point(411, 17)
        Me.bsod.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.bsod.Name = "bsod"
        Me.bsod.Size = New System.Drawing.Size(227, 23)
        Me.bsod.TabIndex = 11
        Me.bsod.Text = "Protect Process [BSOD]"
        Me.bsod.UseVisualStyleBackColor = True
        '
        'T1
        '
        Me.T1.BackColor = System.Drawing.Color.Black
        Me.T1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.T1.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.T1.Location = New System.Drawing.Point(156, 349)
        Me.T1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.T1.Multiline = True
        Me.T1.Name = "T1"
        Me.T1.Size = New System.Drawing.Size(149, 30)
        Me.T1.TabIndex = 12
        Me.T1.Visible = False
        '
        'Isf
        '
        Me.Isf.AutoSize = True
        Me.Isf.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Isf.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Isf.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Isf.Location = New System.Drawing.Point(411, 48)
        Me.Isf.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Isf.Name = "Isf"
        Me.Isf.Size = New System.Drawing.Size(166, 23)
        Me.Isf.TabIndex = 13
        Me.Isf.Text = "Copy To StartUp"
        Me.Isf.UseVisualStyleBackColor = True
        '
        'Isu
        '
        Me.Isu.AutoSize = True
        Me.Isu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Isu.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Isu.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Isu.Location = New System.Drawing.Point(411, 79)
        Me.Isu.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Isu.Name = "Isu"
        Me.Isu.Size = New System.Drawing.Size(154, 23)
        Me.Isu.TabIndex = 14
        Me.Isu.Text = "Registy StarUp"
        Me.Isu.UseVisualStyleBackColor = True
        '
        'klen
        '
        Me.klen.BackColor = System.Drawing.Color.Black
        Me.klen.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.klen.Location = New System.Drawing.Point(557, 209)
        Me.klen.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.klen.Maximum = New Decimal(New Integer() {512, 0, 0, 0})
        Me.klen.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.klen.Name = "klen"
        Me.klen.Size = New System.Drawing.Size(81, 26)
        Me.klen.TabIndex = 15
        Me.klen.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label6.Location = New System.Drawing.Point(407, 215)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(145, 19)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "KeyLogs Size KB"
        '
        'Anti_CH
        '
        Me.Anti_CH.AutoSize = True
        Me.Anti_CH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Anti_CH.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Anti_CH.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Anti_CH.Location = New System.Drawing.Point(411, 112)
        Me.Anti_CH.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Anti_CH.Name = "Anti_CH"
        Me.Anti_CH.Size = New System.Drawing.Size(79, 23)
        Me.Anti_CH.TabIndex = 17
        Me.Anti_CH.Text = "Anti's"
        Me.Anti_CH.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label3.Location = New System.Drawing.Point(4, 25)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ExeName"
        '
        'exe
        '
        Me.exe.BackColor = System.Drawing.Color.Black
        Me.exe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.exe.Enabled = False
        Me.exe.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exe.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.exe.Location = New System.Drawing.Point(9, 49)
        Me.exe.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.exe.Name = "exe"
        Me.exe.Size = New System.Drawing.Size(360, 26)
        Me.exe.TabIndex = 5
        Me.exe.Text = "WindowsServices.exe"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label4.Location = New System.Drawing.Point(4, 88)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Directory"
        '
        'dir
        '
        Me.dir.BackColor = System.Drawing.Color.Black
        Me.dir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dir.Enabled = False
        Me.dir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dir.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dir.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.dir.FormattingEnabled = True
        Me.dir.Items.AddRange(New Object() {"%TEMP%", "%AppData%", "%UserProfile%", "%AllUsersProfile%", "%WinDir%"})
        Me.dir.Location = New System.Drawing.Point(9, 112)
        Me.dir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dir.Name = "dir"
        Me.dir.Size = New System.Drawing.Size(360, 27)
        Me.dir.TabIndex = 7
        '
        'Idr
        '
        Me.Idr.AutoSize = True
        Me.Idr.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Idr.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Idr.Location = New System.Drawing.Point(294, 18)
        Me.Idr.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Idr.Name = "Idr"
        Me.Idr.Size = New System.Drawing.Size(71, 24)
        Me.Idr.TabIndex = 14
        Me.Idr.Text = "Copy"
        Me.Idr.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CKUpx)
        Me.GroupBox1.Controls.Add(Me.Idr)
        Me.GroupBox1.Controls.Add(Me.dir)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.exe)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 149)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(380, 179)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'USB_SP
        '
        Me.USB_SP.AutoSize = True
        Me.USB_SP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.USB_SP.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.USB_SP.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.USB_SP.Location = New System.Drawing.Point(411, 145)
        Me.USB_SP.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.USB_SP.Name = "USB_SP"
        Me.USB_SP.Size = New System.Drawing.Size(131, 23)
        Me.USB_SP.TabIndex = 18
        Me.USB_SP.Text = "Spread USB"
        Me.USB_SP.UseVisualStyleBackColor = True
        '
        'CKOBF
        '
        Me.CKOBF.AutoSize = True
        Me.CKOBF.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CKOBF.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CKOBF.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.CKOBF.Location = New System.Drawing.Point(411, 178)
        Me.CKOBF.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CKOBF.Name = "CKOBF"
        Me.CKOBF.Size = New System.Drawing.Size(130, 23)
        Me.CKOBF.TabIndex = 19
        Me.CKOBF.Text = "Obfuscation"
        Me.CKOBF.UseVisualStyleBackColor = True
        '
        'CKUpx
        '
        Me.CKUpx.AutoSize = True
        Me.CKUpx.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CKUpx.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CKUpx.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.CKUpx.Location = New System.Drawing.Point(9, 149)
        Me.CKUpx.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CKUpx.Name = "CKUpx"
        Me.CKUpx.Size = New System.Drawing.Size(202, 23)
        Me.CKUpx.TabIndex = 20
        Me.CKUpx.Text = "MPress Compression"
        Me.CKUpx.UseVisualStyleBackColor = True
        '
        'Builder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(645, 342)
        Me.Controls.Add(Me.CKOBF)
        Me.Controls.Add(Me.USB_SP)
        Me.Controls.Add(Me.Anti_CH)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.klen)
        Me.Controls.Add(Me.Isu)
        Me.Controls.Add(Me.Isf)
        Me.Controls.Add(Me.T1)
        Me.Controls.Add(Me.bsod)
        Me.Controls.Add(Me.VN)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.port)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.host)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Builder"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Builder"
        CType(Me.port, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.klen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents host As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents port As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents VN As System.Windows.Forms.TextBox
    Friend WithEvents bsod As System.Windows.Forms.CheckBox
    Friend WithEvents T1 As System.Windows.Forms.TextBox
    Friend WithEvents Isf As System.Windows.Forms.CheckBox
    Friend WithEvents Isu As System.Windows.Forms.CheckBox
    Friend WithEvents klen As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Anti_CH As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents exe As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dir As ComboBox
    Friend WithEvents Idr As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents USB_SP As CheckBox
    Friend WithEvents CKOBF As CheckBox
    Friend WithEvents CKUpx As CheckBox
End Class
