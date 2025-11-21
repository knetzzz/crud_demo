<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Me.ButtonConnect = New System.Windows.Forms.Button()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.TextBoxAge = New System.Windows.Forms.TextBox()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.ButtonInsert = New System.Windows.Forms.Button()
        Me.ButtonRead = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(247, 120)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(38, 13)
        Label1.TabIndex = 2
        Label1.Text = "Name:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(247, 146)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(29, 13)
        Label2.TabIndex = 4
        Label2.Text = "Age:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(247, 171)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(35, 13)
        Label3.TabIndex = 6
        Label3.Text = "Email:"
        '
        'ButtonConnect
        '
        Me.ButtonConnect.Location = New System.Drawing.Point(246, 53)
        Me.ButtonConnect.Name = "ButtonConnect"
        Me.ButtonConnect.Size = New System.Drawing.Size(254, 54)
        Me.ButtonConnect.TabIndex = 0
        Me.ButtonConnect.Text = "Connect MySQL"
        Me.ButtonConnect.UseVisualStyleBackColor = True
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(302, 113)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(198, 20)
        Me.TextBoxName.TabIndex = 1
        '
        'TextBoxAge
        '
        Me.TextBoxAge.Location = New System.Drawing.Point(302, 139)
        Me.TextBoxAge.Name = "TextBoxAge"
        Me.TextBoxAge.Size = New System.Drawing.Size(198, 20)
        Me.TextBoxAge.TabIndex = 3
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Location = New System.Drawing.Point(302, 165)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(198, 20)
        Me.TextBoxEmail.TabIndex = 5
        '
        'ButtonInsert
        '
        Me.ButtonInsert.Location = New System.Drawing.Point(246, 191)
        Me.ButtonInsert.Name = "ButtonInsert"
        Me.ButtonInsert.Size = New System.Drawing.Size(254, 27)
        Me.ButtonInsert.TabIndex = 7
        Me.ButtonInsert.Text = "CREATE (Insert Data)"
        Me.ButtonInsert.UseVisualStyleBackColor = True
        '
        'ButtonRead
        '
        Me.ButtonRead.Location = New System.Drawing.Point(246, 224)
        Me.ButtonRead.Name = "ButtonRead"
        Me.ButtonRead.Size = New System.Drawing.Size(254, 27)
        Me.ButtonRead.TabIndex = 8
        Me.ButtonRead.Text = "READ (Retrive Data)"
        Me.ButtonRead.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(246, 257)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(254, 150)
        Me.DataGridView1.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ButtonRead)
        Me.Controls.Add(Me.ButtonInsert)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.TextBoxEmail)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.TextBoxAge)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.ButtonConnect)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonConnect As Button
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents TextBoxAge As TextBox
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents ButtonInsert As Button
    Friend WithEvents ButtonRead As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
