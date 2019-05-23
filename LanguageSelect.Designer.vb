<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LanguageSelect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LanguageSelect))
        Me.buttonEnglish = New System.Windows.Forms.Button()
        Me.buttonFrench = New System.Windows.Forms.Button()
        Me.buttonGerman = New System.Windows.Forms.Button()
        Me.buttonItalian = New System.Windows.Forms.Button()
        Me.buttonPortuguese = New System.Windows.Forms.Button()
        Me.buttonSpanish = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'buttonEnglish
        '
        Me.buttonEnglish.AutoSize = True
        Me.buttonEnglish.Font = New System.Drawing.Font("OCR A Extended", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonEnglish.Location = New System.Drawing.Point(75, 61)
        Me.buttonEnglish.Name = "buttonEnglish"
        Me.buttonEnglish.Size = New System.Drawing.Size(150, 30)
        Me.buttonEnglish.TabIndex = 0
        Me.buttonEnglish.Text = "English"
        Me.buttonEnglish.UseVisualStyleBackColor = True
        '
        'buttonFrench
        '
        Me.buttonFrench.AutoSize = True
        Me.buttonFrench.Font = New System.Drawing.Font("OCR A Extended", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonFrench.Location = New System.Drawing.Point(75, 133)
        Me.buttonFrench.Name = "buttonFrench"
        Me.buttonFrench.Size = New System.Drawing.Size(150, 30)
        Me.buttonFrench.TabIndex = 0
        Me.buttonFrench.Text = "Français"
        Me.buttonFrench.UseVisualStyleBackColor = True
        '
        'buttonGerman
        '
        Me.buttonGerman.AutoSize = True
        Me.buttonGerman.Font = New System.Drawing.Font("OCR A Extended", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonGerman.Location = New System.Drawing.Point(75, 25)
        Me.buttonGerman.Name = "buttonGerman"
        Me.buttonGerman.Size = New System.Drawing.Size(150, 30)
        Me.buttonGerman.TabIndex = 0
        Me.buttonGerman.Text = "Deusch"
        Me.buttonGerman.UseVisualStyleBackColor = True
        '
        'buttonItalian
        '
        Me.buttonItalian.AutoSize = True
        Me.buttonItalian.Font = New System.Drawing.Font("OCR A Extended", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonItalian.Location = New System.Drawing.Point(75, 169)
        Me.buttonItalian.Name = "buttonItalian"
        Me.buttonItalian.Size = New System.Drawing.Size(150, 30)
        Me.buttonItalian.TabIndex = 0
        Me.buttonItalian.Text = "Italiano"
        Me.buttonItalian.UseVisualStyleBackColor = True
        '
        'buttonPortuguese
        '
        Me.buttonPortuguese.AutoSize = True
        Me.buttonPortuguese.Font = New System.Drawing.Font("OCR A Extended", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonPortuguese.Location = New System.Drawing.Point(75, 205)
        Me.buttonPortuguese.Name = "buttonPortuguese"
        Me.buttonPortuguese.Size = New System.Drawing.Size(150, 30)
        Me.buttonPortuguese.TabIndex = 0
        Me.buttonPortuguese.Text = "Português"
        Me.buttonPortuguese.UseVisualStyleBackColor = True
        '
        'buttonSpanish
        '
        Me.buttonSpanish.AutoSize = True
        Me.buttonSpanish.Font = New System.Drawing.Font("OCR A Extended", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonSpanish.Location = New System.Drawing.Point(75, 97)
        Me.buttonSpanish.Name = "buttonSpanish"
        Me.buttonSpanish.Size = New System.Drawing.Size(150, 30)
        Me.buttonSpanish.TabIndex = 0
        Me.buttonSpanish.Text = "Español"
        Me.buttonSpanish.UseVisualStyleBackColor = True
        '
        'LanguageSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.buttonEnglish)
        Me.Controls.Add(Me.buttonFrench)
        Me.Controls.Add(Me.buttonGerman)
        Me.Controls.Add(Me.buttonItalian)
        Me.Controls.Add(Me.buttonPortuguese)
        Me.Controls.Add(Me.buttonSpanish)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LanguageSelect"
        Me.Text = "ABC123"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents buttonEnglish As Button
    Friend WithEvents buttonFrench As Button
    Friend WithEvents buttonGerman As Button
    Friend WithEvents buttonItalian As Button
    Friend WithEvents buttonPortuguese As Button
    Friend WithEvents buttonSpanish As Button
End Class
