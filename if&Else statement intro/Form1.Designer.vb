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
        greetbtn = New Button()
        SALanguageLabel = New Label()
        txttypeLanguage = New TextBox()
        typeLaguagelabel = New Label()
        SuspendLayout()
        ' 
        ' greetbtn
        ' 
        greetbtn.Location = New Point(530, 134)
        greetbtn.Name = "greetbtn"
        greetbtn.Size = New Size(75, 23)
        greetbtn.TabIndex = 0
        greetbtn.Text = "Greet"
        greetbtn.UseVisualStyleBackColor = True
        ' 
        ' SALanguageLabel
        ' 
        SALanguageLabel.AutoSize = True
        SALanguageLabel.Location = New Point(267, 43)
        SALanguageLabel.Name = "SALanguageLabel"
        SALanguageLabel.Size = New Size(224, 15)
        SALanguageLabel.TabIndex = 1
        SALanguageLabel.Text = "How to greet in South African Languages"
        ' 
        ' txttypeLanguage
        ' 
        txttypeLanguage.Location = New Point(530, 43)
        txttypeLanguage.Name = "txttypeLanguage"
        txttypeLanguage.Size = New Size(112, 23)
        txttypeLanguage.TabIndex = 2
        ' 
        ' typeLaguagelabel
        ' 
        typeLaguagelabel.AutoSize = True
        typeLaguagelabel.Location = New Point(530, 25)
        typeLaguagelabel.Name = "typeLaguagelabel"
        typeLaguagelabel.Size = New Size(112, 15)
        typeLaguagelabel.TabIndex = 3
        typeLaguagelabel.Text = "Type languge below"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(typeLaguagelabel)
        Controls.Add(txttypeLanguage)
        Controls.Add(SALanguageLabel)
        Controls.Add(greetbtn)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents greetbtn As Button
    Friend WithEvents SALanguageLabel As Label
    Friend WithEvents txttypeLanguage As TextBox
    Friend WithEvents typeLaguagelabel As Label
End Class
