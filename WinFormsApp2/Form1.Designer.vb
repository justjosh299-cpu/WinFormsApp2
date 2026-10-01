<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        tbname = New TextBox()
        regbtn = New Button()
        lname = New Label()
        lreg = New Label()
        tbreg = New TextBox()
        SuspendLayout()
        ' 
        ' tbname
        ' 
        tbname.Location = New Point(243, 73)
        tbname.Name = "tbname"
        tbname.Size = New Size(196, 27)
        tbname.TabIndex = 0
        ' 
        ' regbtn
        ' 
        regbtn.AccessibleName = "l"
        regbtn.FlatAppearance.MouseOverBackColor = SystemColors.MenuHighlight
        regbtn.ForeColor = SystemColors.MenuHighlight
        regbtn.Location = New Point(172, 206)
        regbtn.Name = "regbtn"
        regbtn.Size = New Size(182, 51)
        regbtn.TabIndex = 1
        regbtn.Text = "Register"
        regbtn.UseVisualStyleBackColor = True
        ' 
        ' lname
        ' 
        lname.AutoSize = True
        lname.Location = New Point(172, 76)
        lname.Name = "lname"
        lname.Size = New Size(52, 20)
        lname.TabIndex = 2
        lname.Text = "Name:"
        ' 
        ' lreg
        ' 
        lreg.AutoSize = True
        lreg.Location = New Point(74, 140)
        lreg.Name = "lreg"
        lreg.Size = New Size(150, 20)
        lreg.TabIndex = 3
        lreg.Text = "Registration Number:"
        ' 
        ' tbreg
        ' 
        tbreg.Location = New Point(243, 140)
        tbreg.Name = "tbreg"
        tbreg.Size = New Size(196, 27)
        tbreg.TabIndex = 4
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1045, 603)
        Controls.Add(tbreg)
        Controls.Add(lreg)
        Controls.Add(lname)
        Controls.Add(regbtn)
        Controls.Add(tbname)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tbname As TextBox
    Friend WithEvents regbtn As Button
    Friend WithEvents lname As Label
    Friend WithEvents lreg As Label
    Friend WithEvents tbreg As TextBox

End Class
