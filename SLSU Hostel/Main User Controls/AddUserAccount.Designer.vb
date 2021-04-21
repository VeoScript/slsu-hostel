<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddUserAccount
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnDeleteUserAccount = New System.Windows.Forms.Button()
        Me.btnCreateUserAccount = New System.Windows.Forms.Button()
        Me.pnlCreateAccountContainer = New System.Windows.Forms.Panel()
        Me.CreateAccount1 = New SLSU_Hostel.CreateAccount()
        Me.DeleteAccount1 = New SLSU_Hostel.DeleteAccount()
        Me.Panel3.SuspendLayout()
        Me.pnlCreateAccountContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btnDeleteUserAccount)
        Me.Panel3.Controls.Add(Me.btnCreateUserAccount)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(968, 57)
        Me.Panel3.TabIndex = 16
        '
        'btnDeleteUserAccount
        '
        Me.btnDeleteUserAccount.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.btnDeleteUserAccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteUserAccount.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDeleteUserAccount.FlatAppearance.BorderSize = 0
        Me.btnDeleteUserAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnDeleteUserAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnDeleteUserAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteUserAccount.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteUserAccount.ForeColor = System.Drawing.Color.White
        Me.btnDeleteUserAccount.Location = New System.Drawing.Point(483, 0)
        Me.btnDeleteUserAccount.Name = "btnDeleteUserAccount"
        Me.btnDeleteUserAccount.Size = New System.Drawing.Size(485, 57)
        Me.btnDeleteUserAccount.TabIndex = 30
        Me.btnDeleteUserAccount.Text = "Delete User Account"
        Me.btnDeleteUserAccount.UseVisualStyleBackColor = False
        '
        'btnCreateUserAccount
        '
        Me.btnCreateUserAccount.BackColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.btnCreateUserAccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCreateUserAccount.FlatAppearance.BorderSize = 0
        Me.btnCreateUserAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnCreateUserAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnCreateUserAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreateUserAccount.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateUserAccount.ForeColor = System.Drawing.Color.White
        Me.btnCreateUserAccount.Location = New System.Drawing.Point(0, 0)
        Me.btnCreateUserAccount.Name = "btnCreateUserAccount"
        Me.btnCreateUserAccount.Size = New System.Drawing.Size(477, 57)
        Me.btnCreateUserAccount.TabIndex = 29
        Me.btnCreateUserAccount.Text = "Create User Account"
        Me.btnCreateUserAccount.UseVisualStyleBackColor = False
        '
        'pnlCreateAccountContainer
        '
        Me.pnlCreateAccountContainer.Controls.Add(Me.CreateAccount1)
        Me.pnlCreateAccountContainer.Controls.Add(Me.DeleteAccount1)
        Me.pnlCreateAccountContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCreateAccountContainer.Location = New System.Drawing.Point(0, 57)
        Me.pnlCreateAccountContainer.Name = "pnlCreateAccountContainer"
        Me.pnlCreateAccountContainer.Size = New System.Drawing.Size(968, 598)
        Me.pnlCreateAccountContainer.TabIndex = 17
        '
        'CreateAccount1
        '
        Me.CreateAccount1.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.CreateAccount1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CreateAccount1.Location = New System.Drawing.Point(0, 0)
        Me.CreateAccount1.Name = "CreateAccount1"
        Me.CreateAccount1.Size = New System.Drawing.Size(968, 598)
        Me.CreateAccount1.TabIndex = 0
        '
        'DeleteAccount1
        '
        Me.DeleteAccount1.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.DeleteAccount1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DeleteAccount1.Location = New System.Drawing.Point(0, 0)
        Me.DeleteAccount1.Name = "DeleteAccount1"
        Me.DeleteAccount1.Size = New System.Drawing.Size(968, 598)
        Me.DeleteAccount1.TabIndex = 1
        Me.DeleteAccount1.Visible = False
        '
        'AddUserAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Controls.Add(Me.pnlCreateAccountContainer)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "AddUserAccount"
        Me.Size = New System.Drawing.Size(968, 655)
        Me.Panel3.ResumeLayout(False)
        Me.pnlCreateAccountContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnDeleteUserAccount As Button
    Friend WithEvents btnCreateUserAccount As Button
    Friend WithEvents pnlCreateAccountContainer As Panel
    Friend WithEvents CreateAccount1 As CreateAccount
    Friend WithEvents DeleteAccount1 As DeleteAccount
End Class
