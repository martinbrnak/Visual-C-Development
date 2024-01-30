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
        Me.textbox = New System.Windows.Forms.TextBox()
        Me.button_hello = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'textbox
        '
        Me.textbox.Location = New System.Drawing.Point(337, 209)
        Me.textbox.Name = "textbox"
        Me.textbox.Size = New System.Drawing.Size(100, 20)
        Me.textbox.TabIndex = 0
        '
        'button_hello
        '
        Me.button_hello.Location = New System.Drawing.Point(337, 125)
        Me.button_hello.Name = "button_hello"
        Me.button_hello.Size = New System.Drawing.Size(97, 23)
        Me.button_hello.TabIndex = 1
        Me.button_hello.Text = "Say Hello World"
        Me.button_hello.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.button_hello)
        Me.Controls.Add(Me.textbox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents textbox As TextBox
    Friend WithEvents button_hello As Button
End Class
