<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form15
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form15))
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        Label5 = New Label()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Panel2 = New Panel()
        Label6 = New Label()
        Label1 = New Label()
        Button2 = New Button()
        Button1 = New Button()
        Label4 = New Label()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Panel1 = New Panel()
        Label3 = New Label()
        Label7 = New Label()
        TextBox3 = New TextBox()
        Label8 = New Label()
        TextBox4 = New TextBox()
        Label9 = New Label()
        TextBox5 = New TextBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        Button3 = New Button()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImage = My.Resources.Resources.Lock_image
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Location = New Point(415, 498)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(53, 40)
        PictureBox3.TabIndex = 25
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = My.Resources.Resources.user_icon
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(415, 421)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(56, 40)
        PictureBox2.TabIndex = 24
        PictureBox2.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(102, 96)
        Label5.Name = "Label5"
        Label5.Size = New Size(184, 31)
        Label5.TabIndex = 12
        Label5.Text = "Company Name"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.Comapny_logo
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(8, 155)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(340, 272)
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(515, 421)
        Label2.Name = "Label2"
        Label2.Size = New Size(106, 28)
        Label2.TabIndex = 15
        Label2.Text = "Username"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Teal
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Location = New Point(-47, 57)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(354, 666)
        Panel2.TabIndex = 14
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(140, 467)
        Label6.Name = "Label6"
        Label6.Size = New Size(91, 31)
        Label6.TabIndex = 13
        Label6.Text = "Tagline"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(0, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(579, 40)
        Label1.TabIndex = 0
        Label1.Text = "Employee information mangement system"
        ' 
        ' Button2
        ' 
        Button2.FlatAppearance.BorderColor = Color.Lime
        Button2.FlatAppearance.BorderSize = 5
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = SystemColors.ButtonHighlight
        Button2.Location = New Point(885, 597)
        Button2.Name = "Button2"
        Button2.Size = New Size(164, 73)
        Button2.TabIndex = 21
        Button2.Text = "Close"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.FlatAppearance.BorderColor = Color.Lime
        Button1.FlatAppearance.BorderSize = 5
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(452, 597)
        Button1.Name = "Button1"
        Button1.Size = New Size(164, 73)
        Button1.TabIndex = 20
        Button1.Text = "Create"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.ButtonHighlight
        Label4.Location = New Point(592, 88)
        Label4.Name = "Label4"
        Label4.Size = New Size(139, 31)
        Label4.TabIndex = 19
        Label4.Text = "Create Page"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(652, 502)
        TextBox2.Name = "TextBox2"
        TextBox2.PasswordChar = "*"c
        TextBox2.PlaceholderText = "Password"
        TextBox2.Size = New Size(334, 27)
        TextBox2.TabIndex = 18
        TextBox2.UseSystemPasswordChar = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(652, 425)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Username"
        TextBox1.Size = New Size(334, 27)
        TextBox1.TabIndex = 17
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.MenuHighlight
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1188, 57)
        Panel1.TabIndex = 13
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(515, 498)
        Label3.Name = "Label3"
        Label3.Size = New Size(101, 28)
        Label3.TabIndex = 16
        Label3.Text = "Password"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = SystemColors.ButtonHighlight
        Label7.Location = New Point(501, 195)
        Label7.Name = "Label7"
        Label7.Size = New Size(120, 28)
        Label7.TabIndex = 26
        Label7.Text = "Enter name"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(652, 196)
        TextBox3.Name = "TextBox3"
        TextBox3.PlaceholderText = "Name"
        TextBox3.Size = New Size(334, 27)
        TextBox3.TabIndex = 27
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.ForeColor = SystemColors.ButtonHighlight
        Label8.Location = New Point(501, 270)
        Label8.Name = "Label8"
        Label8.Size = New Size(124, 28)
        Label8.TabIndex = 28
        Label8.Text = "Contact No."
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(652, 270)
        TextBox4.Name = "TextBox4"
        TextBox4.PlaceholderText = "Contact No."
        TextBox4.Size = New Size(334, 27)
        TextBox4.TabIndex = 29
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.ForeColor = SystemColors.ButtonHighlight
        Label9.Location = New Point(501, 344)
        Label9.Name = "Label9"
        Label9.Size = New Size(127, 28)
        Label9.TabIndex = 30
        Label9.Text = "Department"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(652, 344)
        TextBox5.Name = "TextBox5"
        TextBox5.PlaceholderText = "Department"
        TextBox5.Size = New Size(334, 27)
        TextBox5.TabIndex = 31
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), Image)
        PictureBox4.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox4.Location = New Point(418, 270)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(53, 40)
        PictureBox4.TabIndex = 32
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), Image)
        PictureBox5.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox5.Location = New Point(415, 344)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(56, 40)
        PictureBox5.TabIndex = 33
        PictureBox5.TabStop = False
        ' 
        ' Button3
        ' 
        Button3.FlatAppearance.BorderColor = Color.Lime
        Button3.FlatAppearance.BorderSize = 5
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = SystemColors.ButtonHighlight
        Button3.Location = New Point(665, 597)
        Button3.Name = "Button3"
        Button3.Size = New Size(164, 73)
        Button3.TabIndex = 34
        Button3.Text = "Home"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Form15
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(1188, 723)
        Controls.Add(Button3)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox4)
        Controls.Add(TextBox5)
        Controls.Add(Label9)
        Controls.Add(TextBox4)
        Controls.Add(Label8)
        Controls.Add(TextBox3)
        Controls.Add(Label7)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(Label2)
        Controls.Add(Panel2)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Panel1)
        Controls.Add(Label3)
        Name = "Form15"
        Text = "Form15"
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Button3 As Button
End Class
