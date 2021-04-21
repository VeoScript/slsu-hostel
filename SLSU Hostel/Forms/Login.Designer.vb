<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnlTitleHolder = New System.Windows.Forms.Panel()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.btnClose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnMinimize = New Bunifu.Framework.UI.BunifuImageButton()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.btnSettingsLink = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnAboutLink = New Bunifu.Framework.UI.BunifuImageButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnLoginLink = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BunifuSeparator2 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.pnlLoginUserControlContainer = New System.Windows.Forms.Panel()
        Me.UserLogin1 = New SLSU_Hostel.UserLogin()
        Me.About1 = New SLSU_Hostel.About()
        Me.Settings1 = New SLSU_Hostel.Settings()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTitleHolder.SuspendLayout()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSettingsLink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAboutLink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnLoginLink, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLoginUserControlContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(65, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "HOSTEL"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(13, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(52, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(65, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Southern Leyte State University"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Corbel", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(67, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Hotel Management System"
        '
        'pnlTitleHolder
        '
        Me.pnlTitleHolder.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.pnlTitleHolder.Controls.Add(Me.Label3)
        Me.pnlTitleHolder.Controls.Add(Me.Label1)
        Me.pnlTitleHolder.Controls.Add(Me.PictureBox1)
        Me.pnlTitleHolder.Controls.Add(Me.Label2)
        Me.pnlTitleHolder.Location = New System.Drawing.Point(-4, 0)
        Me.pnlTitleHolder.Name = "pnlTitleHolder"
        Me.pnlTitleHolder.Size = New System.Drawing.Size(257, 83)
        Me.pnlTitleHolder.TabIndex = 5
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 8
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 10
        Me.BunifuElipse2.TargetControl = Me.pnlTitleHolder
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me
        Me.BunifuDragControl1.Vertical = True
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageActive = CType(resources.GetObject("btnClose.ImageActive"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(640, 7)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(28, 23)
        Me.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnClose.TabIndex = 6
        Me.btnClose.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnClose, "Close")
        Me.btnClose.Zoom = 10
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimize.Image = CType(resources.GetObject("btnMinimize.Image"), System.Drawing.Image)
        Me.btnMinimize.ImageActive = CType(resources.GetObject("btnMinimize.ImageActive"), System.Drawing.Image)
        Me.btnMinimize.Location = New System.Drawing.Point(613, 7)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(28, 23)
        Me.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMinimize.TabIndex = 7
        Me.btnMinimize.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnMinimize, "Minimize")
        Me.btnMinimize.Zoom = 10
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.lblTime.Location = New System.Drawing.Point(49, 156)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(148, 33)
        Me.lblTime.TabIndex = 13
        Me.lblTime.Text = "Clock"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 2
        Me.BunifuSeparator1.Location = New System.Drawing.Point(247, 94)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(10, 267)
        Me.BunifuSeparator1.TabIndex = 14
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(48, 127)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 16
        Me.PictureBox3.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(6, 398)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(203, 16)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Designed and Developed by VEOSCRIPT"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(71, 131)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 17)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Clock"
        '
        'Timer1
        '
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(76, 382)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(304, 16)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "HOSTEL Hotel Management System, All rights reserved 2018"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(6, 381)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 16)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Copyright"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(56, 379)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 21
        Me.PictureBox4.TabStop = False
        '
        'btnSettingsLink
        '
        Me.btnSettingsLink.BackColor = System.Drawing.Color.Transparent
        Me.btnSettingsLink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnSettingsLink.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSettingsLink.Image = CType(resources.GetObject("btnSettingsLink.Image"), System.Drawing.Image)
        Me.btnSettingsLink.ImageActive = CType(resources.GetObject("btnSettingsLink.ImageActive"), System.Drawing.Image)
        Me.btnSettingsLink.Location = New System.Drawing.Point(100, 254)
        Me.btnSettingsLink.Name = "btnSettingsLink"
        Me.btnSettingsLink.Size = New System.Drawing.Size(50, 50)
        Me.btnSettingsLink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnSettingsLink.TabIndex = 22
        Me.btnSettingsLink.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnSettingsLink, "Connection Settings")
        Me.btnSettingsLink.Zoom = 10
        '
        'btnAboutLink
        '
        Me.btnAboutLink.BackColor = System.Drawing.Color.Transparent
        Me.btnAboutLink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnAboutLink.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAboutLink.Image = CType(resources.GetObject("btnAboutLink.Image"), System.Drawing.Image)
        Me.btnAboutLink.ImageActive = CType(resources.GetObject("btnAboutLink.ImageActive"), System.Drawing.Image)
        Me.btnAboutLink.Location = New System.Drawing.Point(150, 254)
        Me.btnAboutLink.Name = "btnAboutLink"
        Me.btnAboutLink.Size = New System.Drawing.Size(50, 50)
        Me.btnAboutLink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnAboutLink.TabIndex = 23
        Me.btnAboutLink.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnAboutLink, "About Us")
        Me.btnAboutLink.Zoom = 10
        '
        'btnLoginLink
        '
        Me.btnLoginLink.BackColor = System.Drawing.Color.Transparent
        Me.btnLoginLink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnLoginLink.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoginLink.Image = CType(resources.GetObject("btnLoginLink.Image"), System.Drawing.Image)
        Me.btnLoginLink.ImageActive = CType(resources.GetObject("btnLoginLink.ImageActive"), System.Drawing.Image)
        Me.btnLoginLink.Location = New System.Drawing.Point(50, 254)
        Me.btnLoginLink.Name = "btnLoginLink"
        Me.btnLoginLink.Size = New System.Drawing.Size(50, 50)
        Me.btnLoginLink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnLoginLink.TabIndex = 24
        Me.btnLoginLink.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnLoginLink, "Login")
        Me.btnLoginLink.Zoom = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(48, 224)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 17)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Menu"
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 2
        Me.BunifuSeparator2.Location = New System.Drawing.Point(50, 239)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Size = New System.Drawing.Size(150, 10)
        Me.BunifuSeparator2.TabIndex = 26
        Me.BunifuSeparator2.Transparency = 255
        Me.BunifuSeparator2.Vertical = False
        '
        'pnlLoginUserControlContainer
        '
        Me.pnlLoginUserControlContainer.Controls.Add(Me.UserLogin1)
        Me.pnlLoginUserControlContainer.Controls.Add(Me.About1)
        Me.pnlLoginUserControlContainer.Controls.Add(Me.Settings1)
        Me.pnlLoginUserControlContainer.Location = New System.Drawing.Point(255, 87)
        Me.pnlLoginUserControlContainer.Name = "pnlLoginUserControlContainer"
        Me.pnlLoginUserControlContainer.Size = New System.Drawing.Size(408, 292)
        Me.pnlLoginUserControlContainer.TabIndex = 27
        '
        'UserLogin1
        '
        Me.UserLogin1.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.UserLogin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UserLogin1.Location = New System.Drawing.Point(0, 0)
        Me.UserLogin1.Name = "UserLogin1"
        Me.UserLogin1.Size = New System.Drawing.Size(408, 292)
        Me.UserLogin1.TabIndex = 22
        '
        'About1
        '
        Me.About1.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.About1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.About1.Location = New System.Drawing.Point(0, 0)
        Me.About1.Name = "About1"
        Me.About1.Size = New System.Drawing.Size(408, 292)
        Me.About1.TabIndex = 21
        Me.About1.Visible = False
        '
        'Settings1
        '
        Me.Settings1.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Settings1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Settings1.Location = New System.Drawing.Point(0, 0)
        Me.Settings1.Name = "Settings1"
        Me.Settings1.Size = New System.Drawing.Size(408, 292)
        Me.Settings1.TabIndex = 20
        Me.Settings1.Visible = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(675, 423)
        Me.Controls.Add(Me.pnlLoginUserControlContainer)
        Me.Controls.Add(Me.BunifuSeparator2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnLoginLink)
        Me.Controls.Add(Me.btnAboutLink)
        Me.Controls.Add(Me.btnSettingsLink)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.btnMinimize)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.pnlTitleHolder)
        Me.Controls.Add(Me.PictureBox4)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTitleHolder.ResumeLayout(False)
        Me.pnlTitleHolder.PerformLayout()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSettingsLink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAboutLink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnLoginLink, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLoginUserControlContainer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents pnlTitleHolder As Panel
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents btnMinimize As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnClose As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents lblTime As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents btnAboutLink As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnSettingsLink As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnLoginLink As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuSeparator2 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Label11 As Label
    Friend WithEvents pnlLoginUserControlContainer As Panel
    Friend WithEvents Settings1 As Settings
    Friend WithEvents About1 As About
    Friend WithEvents UserLogin1 As UserLogin
End Class
