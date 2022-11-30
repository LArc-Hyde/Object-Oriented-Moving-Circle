<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCanvas
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
        Me.btnMove = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.picCircle = New System.Windows.Forms.PictureBox()
        Me.txtCaution = New System.Windows.Forms.TextBox()
        CType(Me.picCircle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMove
        '
        Me.btnMove.Location = New System.Drawing.Point(59, 32)
        Me.btnMove.Name = "btnMove"
        Me.btnMove.Size = New System.Drawing.Size(389, 40)
        Me.btnMove.TabIndex = 0
        Me.btnMove.Text = "Move and Show Circle"
        Me.btnMove.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(480, 34)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(131, 40)
        Me.btnQuit.TabIndex = 1
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'picCircle
        '
        Me.picCircle.Location = New System.Drawing.Point(70, 111)
        Me.picCircle.Name = "picCircle"
        Me.picCircle.Size = New System.Drawing.Size(967, 534)
        Me.picCircle.TabIndex = 3
        Me.picCircle.TabStop = False
        '
        'txtCaution
        '
        Me.txtCaution.Location = New System.Drawing.Point(665, 41)
        Me.txtCaution.Name = "txtCaution"
        Me.txtCaution.Size = New System.Drawing.Size(434, 35)
        Me.txtCaution.TabIndex = 4
        '
        'frmCanvas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 30.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1135, 682)
        Me.Controls.Add(Me.txtCaution)
        Me.Controls.Add(Me.picCircle)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnMove)
        Me.Name = "frmCanvas"
        Me.Text = "Moving Circle"
        CType(Me.picCircle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnMove As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents picCircle As PictureBox
    Friend WithEvents txtCaution As TextBox
End Class
