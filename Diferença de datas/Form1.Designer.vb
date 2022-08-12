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
        Me.Titulo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Selectdata = New System.Windows.Forms.Label()
        Me.Data = New System.Windows.Forms.MaskedTextBox()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.Anos = New System.Windows.Forms.RadioButton()
        Me.Meses = New System.Windows.Forms.RadioButton()
        Me.Dias = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Titulo
        '
        Me.Titulo.AutoSize = True
        Me.Titulo.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Titulo.Location = New System.Drawing.Point(204, 33)
        Me.Titulo.Name = "Titulo"
        Me.Titulo.Size = New System.Drawing.Size(0, 19)
        Me.Titulo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(39, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "INTERVALO DE TEMPO"
        '
        'Selectdata
        '
        Me.Selectdata.AutoSize = True
        Me.Selectdata.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Selectdata.Location = New System.Drawing.Point(32, 79)
        Me.Selectdata.Name = "Selectdata"
        Me.Selectdata.Size = New System.Drawing.Size(108, 19)
        Me.Selectdata.TabIndex = 2
        Me.Selectdata.Text = "Selecione a data"
        '
        'Data
        '
        Me.Data.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Data.Location = New System.Drawing.Point(175, 75)
        Me.Data.Mask = "00/00/0000"
        Me.Data.Name = "Data"
        Me.Data.Size = New System.Drawing.Size(69, 23)
        Me.Data.TabIndex = 3
        '
        'Calcular
        '
        Me.Calcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Calcular.Location = New System.Drawing.Point(96, 176)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(89, 49)
        Me.Calcular.TabIndex = 5
        Me.Calcular.Text = "Calcular"
        Me.Calcular.UseVisualStyleBackColor = True
        Me.Calcular.UseWaitCursor = True
        '
        'Anos
        '
        Me.Anos.AutoSize = True
        Me.Anos.Location = New System.Drawing.Point(32, 125)
        Me.Anos.Name = "Anos"
        Me.Anos.Size = New System.Drawing.Size(52, 19)
        Me.Anos.TabIndex = 6
        Me.Anos.TabStop = True
        Me.Anos.Text = "Anos"
        Me.Anos.UseVisualStyleBackColor = True
        '
        'Meses
        '
        Me.Meses.AutoSize = True
        Me.Meses.Location = New System.Drawing.Point(113, 125)
        Me.Meses.Name = "Meses"
        Me.Meses.Size = New System.Drawing.Size(58, 19)
        Me.Meses.TabIndex = 7
        Me.Meses.TabStop = True
        Me.Meses.Text = "Meses"
        Me.Meses.UseVisualStyleBackColor = True
        '
        'Dias
        '
        Me.Dias.AutoSize = True
        Me.Dias.Location = New System.Drawing.Point(204, 125)
        Me.Dias.Name = "Dias"
        Me.Dias.Size = New System.Drawing.Size(47, 19)
        Me.Dias.TabIndex = 8
        Me.Dias.TabStop = True
        Me.Dias.Text = "Dias"
        Me.Dias.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(275, 268)
        Me.Controls.Add(Me.Dias)
        Me.Controls.Add(Me.Meses)
        Me.Controls.Add(Me.Anos)
        Me.Controls.Add(Me.Calcular)
        Me.Controls.Add(Me.Data)
        Me.Controls.Add(Me.Selectdata)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Titulo)
        Me.Name = "Form1"
        Me.Text = "Intervalo de Tempo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Titulo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Selectdata As Label
    Public WithEvents Data As MaskedTextBox
    Friend WithEvents Calcular As Button
    Friend WithEvents Anos As RadioButton
    Friend WithEvents Meses As RadioButton
    Friend WithEvents Dias As RadioButton
End Class
