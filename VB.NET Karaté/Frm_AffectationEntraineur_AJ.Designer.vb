<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_AffectationEntraineur_AJ
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_NumEntraineur = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_Nom = New System.Windows.Forms.TextBox()
        Me.PRENOM = New System.Windows.Forms.Label()
        Me.Txt_Prenom = New System.Windows.Forms.TextBox()
        Me.Grid_Competition = New System.Windows.Forms.DataGridView()
        Me.NumCompétition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateCompétition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Cmd_Fermer = New System.Windows.Forms.Button()
        Me.Cmd_Ajouter = New System.Windows.Forms.Button()
        Me.Panel4.SuspendLayout()
        CType(Me.Grid_Competition, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Location = New System.Drawing.Point(54, 12)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(666, 68)
        Me.Panel4.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(662, 31)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "AFFECTATION DES ENTRAINEURS (AJOUTER)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(69, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(195, 24)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "NUM ENTRAINEUR : "
        '
        'Txt_NumEntraineur
        '
        Me.Txt_NumEntraineur.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_NumEntraineur.Location = New System.Drawing.Point(270, 19)
        Me.Txt_NumEntraineur.Name = "Txt_NumEntraineur"
        Me.Txt_NumEntraineur.Size = New System.Drawing.Size(295, 29)
        Me.Txt_NumEntraineur.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(69, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 24)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "NOM : "
        '
        'Txt_Nom
        '
        Me.Txt_Nom.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Nom.Location = New System.Drawing.Point(270, 62)
        Me.Txt_Nom.Name = "Txt_Nom"
        Me.Txt_Nom.Size = New System.Drawing.Size(295, 29)
        Me.Txt_Nom.TabIndex = 18
        '
        'PRENOM
        '
        Me.PRENOM.AutoSize = True
        Me.PRENOM.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PRENOM.Location = New System.Drawing.Point(69, 104)
        Me.PRENOM.Name = "PRENOM"
        Me.PRENOM.Size = New System.Drawing.Size(103, 24)
        Me.PRENOM.TabIndex = 19
        Me.PRENOM.Text = "PRENOM :"
        '
        'Txt_Prenom
        '
        Me.Txt_Prenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Prenom.Location = New System.Drawing.Point(270, 104)
        Me.Txt_Prenom.Name = "Txt_Prenom"
        Me.Txt_Prenom.Size = New System.Drawing.Size(295, 29)
        Me.Txt_Prenom.TabIndex = 20
        '
        'Grid_Competition
        '
        Me.Grid_Competition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid_Competition.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumCompétition, Me.DateCompétition})
        Me.Grid_Competition.Location = New System.Drawing.Point(19, 164)
        Me.Grid_Competition.Name = "Grid_Competition"
        Me.Grid_Competition.Size = New System.Drawing.Size(611, 215)
        Me.Grid_Competition.TabIndex = 21
        '
        'NumCompétition
        '
        Me.NumCompétition.HeaderText = "Numéro de la Compétition"
        Me.NumCompétition.Name = "NumCompétition"
        Me.NumCompétition.Width = 200
        '
        'DateCompétition
        '
        Me.DateCompétition.HeaderText = "Date de la Compétition"
        Me.DateCompétition.Name = "DateCompétition"
        Me.DateCompétition.Width = 200
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Grid_Competition)
        Me.Panel1.Controls.Add(Me.Txt_Prenom)
        Me.Panel1.Controls.Add(Me.PRENOM)
        Me.Panel1.Controls.Add(Me.Txt_Nom)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Txt_NumEntraineur)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(61, 95)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(649, 402)
        Me.Panel1.TabIndex = 24
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Cmd_Fermer)
        Me.Panel2.Controls.Add(Me.Cmd_Ajouter)
        Me.Panel2.Location = New System.Drawing.Point(111, 520)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(539, 68)
        Me.Panel2.TabIndex = 22
        '
        'Cmd_Fermer
        '
        Me.Cmd_Fermer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Fermer.Location = New System.Drawing.Point(323, 12)
        Me.Cmd_Fermer.Name = "Cmd_Fermer"
        Me.Cmd_Fermer.Size = New System.Drawing.Size(143, 42)
        Me.Cmd_Fermer.TabIndex = 8
        Me.Cmd_Fermer.Text = "FERMER"
        Me.Cmd_Fermer.UseVisualStyleBackColor = True
        '
        'Cmd_Ajouter
        '
        Me.Cmd_Ajouter.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Ajouter.Location = New System.Drawing.Point(77, 12)
        Me.Cmd_Ajouter.Name = "Cmd_Ajouter"
        Me.Cmd_Ajouter.Size = New System.Drawing.Size(143, 42)
        Me.Cmd_Ajouter.TabIndex = 7
        Me.Cmd_Ajouter.Text = "AJOUTER"
        Me.Cmd_Ajouter.UseVisualStyleBackColor = True
        '
        'Frm_AffectationEntraineur_AJ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(774, 600)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "Frm_AffectationEntraineur_AJ"
        Me.Text = "Frm_AffectationEntraineur_AJ"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.Grid_Competition, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_NumEntraineur As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_Nom As TextBox
    Friend WithEvents PRENOM As Label
    Friend WithEvents Txt_Prenom As TextBox
    Friend WithEvents Grid_Competition As DataGridView
    Friend WithEvents NumCompétition As DataGridViewTextBoxColumn
    Friend WithEvents DateCompétition As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Cmd_Fermer As Button
    Friend WithEvents Cmd_Ajouter As Button
End Class
