<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Button1 = New Button()
        Button2 = New Button()
        txt_A = New Label()
        txt_B = New Label()
        btn_plus = New Button()
        btn_minus = New Button()
        btn_mult = New Button()
        btn_div = New Button()
        btn_equal = New Button()
        btn_res = New Button()
        lbl_reslt = New Label()
        lbl_res = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(130, 24)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 0
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(130, 84)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 1
        Button2.UseVisualStyleBackColor = True
        ' 
        ' txt_A
        ' 
        txt_A.AutoSize = True
        txt_A.Location = New Point(71, 28)
        txt_A.Name = "txt_A"
        txt_A.Size = New Size(19, 20)
        txt_A.TabIndex = 2
        txt_A.Text = "A"
        ' 
        ' txt_B
        ' 
        txt_B.AutoSize = True
        txt_B.Location = New Point(71, 88)
        txt_B.Name = "txt_B"
        txt_B.Size = New Size(18, 20)
        txt_B.TabIndex = 3
        txt_B.Text = "B"
        ' 
        ' btn_plus
        ' 
        btn_plus.Location = New Point(130, 166)
        btn_plus.Name = "btn_plus"
        btn_plus.Size = New Size(94, 29)
        btn_plus.TabIndex = 4
        btn_plus.Text = "+"
        btn_plus.UseVisualStyleBackColor = True
        ' 
        ' btn_minus
        ' 
        btn_minus.Location = New Point(275, 166)
        btn_minus.Name = "btn_minus"
        btn_minus.Size = New Size(94, 29)
        btn_minus.TabIndex = 5
        btn_minus.Text = "-"
        btn_minus.UseVisualStyleBackColor = True
        ' 
        ' btn_mult
        ' 
        btn_mult.Location = New Point(459, 166)
        btn_mult.Name = "btn_mult"
        btn_mult.Size = New Size(94, 29)
        btn_mult.TabIndex = 6
        btn_mult.Text = "*"
        btn_mult.UseVisualStyleBackColor = True
        ' 
        ' btn_div
        ' 
        btn_div.Location = New Point(636, 166)
        btn_div.Name = "btn_div"
        btn_div.Size = New Size(94, 29)
        btn_div.TabIndex = 7
        btn_div.Text = "/"
        btn_div.UseVisualStyleBackColor = True
        ' 
        ' btn_equal
        ' 
        btn_equal.Location = New Point(275, 233)
        btn_equal.Name = "btn_equal"
        btn_equal.Size = New Size(94, 29)
        btn_equal.TabIndex = 8
        btn_equal.Text = "="
        btn_equal.UseVisualStyleBackColor = True
        ' 
        ' btn_res
        ' 
        btn_res.Location = New Point(459, 233)
        btn_res.Name = "btn_res"
        btn_res.Size = New Size(94, 29)
        btn_res.TabIndex = 9
        btn_res.Text = "reset"
        btn_res.UseVisualStyleBackColor = True
        ' 
        ' lbl_reslt
        ' 
        lbl_reslt.AutoSize = True
        lbl_reslt.Location = New Point(130, 378)
        lbl_reslt.Name = "lbl_reslt"
        lbl_reslt.Size = New Size(58, 20)
        lbl_reslt.TabIndex = 10
        lbl_reslt.Text = "resultat"
        ' 
        ' lbl_res
        ' 
        lbl_res.AutoSize = True
        lbl_res.Location = New Point(275, 378)
        lbl_res.Name = "lbl_res"
        lbl_res.Size = New Size(15, 20)
        lbl_res.TabIndex = 11
        lbl_res.Text = ".."
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(821, 450)
        Controls.Add(lbl_res)
        Controls.Add(lbl_reslt)
        Controls.Add(btn_res)
        Controls.Add(btn_equal)
        Controls.Add(btn_div)
        Controls.Add(btn_mult)
        Controls.Add(btn_minus)
        Controls.Add(btn_plus)
        Controls.Add(txt_B)
        Controls.Add(txt_A)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txt_A As Label
    Friend WithEvents txt_B As Label
    Friend WithEvents btn_plus As Button
    Friend WithEvents btn_minus As Button
    Friend WithEvents btn_mult As Button
    Friend WithEvents btn_div As Button
    Friend WithEvents btn_equal As Button
    Friend WithEvents btn_res As Button
    Friend WithEvents lbl_reslt As Label
    Friend WithEvents lbl_res As Label

End Class
