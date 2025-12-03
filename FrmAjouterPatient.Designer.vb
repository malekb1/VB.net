<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAjouterPatient
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
        components = New ComponentModel.Container()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Lbldate = New Label()
        Numage = New NumericUpDown()
        Txtprenom = New TextBox()
        Txtnom = New TextBox()
        BtnAjouter = New Button()
        Btnannuler = New Button()
        DgvListePatients = New DataGridView()
        Code = New DataGridViewTextBoxColumn()
        Nom = New DataGridViewTextBoxColumn()
        Prénom = New DataGridViewTextBoxColumn()
        Age = New DataGridViewTextBoxColumn()
        ErrorProvider1 = New ErrorProvider(components)
        CType(Numage, ComponentModel.ISupportInitialize).BeginInit()
        CType(DgvListePatients, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Palatino Linotype", 12F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.MidnightBlue
        Label1.Location = New Point(50, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(255, 27)
        Label1.TabIndex = 0
        Label1.Text = "Ajouter un nouveau patient"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Sitka Text", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.MediumBlue
        Label2.Location = New Point(50, 73)
        Label2.Name = "Label2"
        Label2.Size = New Size(42, 21)
        Label2.TabIndex = 1
        Label2.Text = "Nom"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Sitka Text", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.MediumBlue
        Label3.Location = New Point(50, 105)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 21)
        Label3.TabIndex = 2
        Label3.Text = "Prénom"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Sitka Text", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.MediumBlue
        Label4.Location = New Point(50, 135)
        Label4.Name = "Label4"
        Label4.Size = New Size(35, 21)
        Label4.TabIndex = 3
        Label4.Text = "Age"
        ' 
        ' Lbldate
        ' 
        Lbldate.AutoSize = True
        Lbldate.Font = New Font("Sitka Text", 13.7999992F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Lbldate.ForeColor = Color.DarkSlateGray
        Lbldate.Location = New Point(545, 19)
        Lbldate.Name = "Lbldate"
        Lbldate.Size = New Size(0, 33)
        Lbldate.TabIndex = 4
        ' 
        ' Numage
        ' 
        Numage.Location = New Point(114, 139)
        Numage.Name = "Numage"
        Numage.Size = New Size(150, 27)
        Numage.TabIndex = 5
        ' 
        ' Txtprenom
        ' 
        Txtprenom.Location = New Point(114, 106)
        Txtprenom.Name = "Txtprenom"
        Txtprenom.Size = New Size(125, 27)
        Txtprenom.TabIndex = 6
        ' 
        ' Txtnom
        ' 
        Txtnom.Location = New Point(114, 73)
        Txtnom.Name = "Txtnom"
        Txtnom.Size = New Size(125, 27)
        Txtnom.TabIndex = 7
        ' 
        ' BtnAjouter
        ' 
        BtnAjouter.BackColor = SystemColors.ButtonHighlight
        BtnAjouter.Location = New Point(16, 251)
        BtnAjouter.Name = "BtnAjouter"
        BtnAjouter.Size = New Size(94, 29)
        BtnAjouter.TabIndex = 8
        BtnAjouter.Text = "Ajouter"
        BtnAjouter.UseVisualStyleBackColor = False
        ' 
        ' Btnannuler
        ' 
        Btnannuler.BackColor = SystemColors.ButtonHighlight
        Btnannuler.Location = New Point(145, 251)
        Btnannuler.Name = "Btnannuler"
        Btnannuler.Size = New Size(94, 29)
        Btnannuler.TabIndex = 9
        Btnannuler.Text = "Annuler"
        Btnannuler.UseVisualStyleBackColor = False
        ' 
        ' DgvListePatients
        ' 
        DgvListePatients.BackgroundColor = SystemColors.ScrollBar
        DgvListePatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvListePatients.Columns.AddRange(New DataGridViewColumn() {Code, Nom, Prénom, Age})
        DgvListePatients.GridColor = SystemColors.ActiveCaptionText
        DgvListePatients.Location = New Point(308, 60)
        DgvListePatients.Name = "DgvListePatients"
        DgvListePatients.RowHeadersWidth = 51
        DgvListePatients.Size = New Size(652, 328)
        DgvListePatients.TabIndex = 10
        ' 
        ' Code
        ' 
        Code.HeaderText = "Code"
        Code.MinimumWidth = 6
        Code.Name = "Code"
        Code.Width = 125
        ' 
        ' Nom
        ' 
        Nom.HeaderText = "Nom"
        Nom.MinimumWidth = 6
        Nom.Name = "Nom"
        Nom.Width = 125
        ' 
        ' Prénom
        ' 
        Prénom.HeaderText = "Prénom"
        Prénom.MinimumWidth = 6
        Prénom.Name = "Prénom"
        Prénom.Width = 125
        ' 
        ' Age
        ' 
        Age.HeaderText = "Age"
        Age.MinimumWidth = 6
        Age.Name = "Age"
        Age.Width = 125
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' FrmAjouterPatient
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientActiveCaption
        ClientSize = New Size(1001, 400)
        Controls.Add(DgvListePatients)
        Controls.Add(Btnannuler)
        Controls.Add(BtnAjouter)
        Controls.Add(Txtnom)
        Controls.Add(Txtprenom)
        Controls.Add(Numage)
        Controls.Add(Lbldate)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "FrmAjouterPatient"
        Text = "Ajouter Patient"
        CType(Numage, ComponentModel.ISupportInitialize).EndInit()
        CType(DgvListePatients, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Lbldate As Label
    Friend WithEvents Numage As NumericUpDown
    Friend WithEvents Txtprenom As TextBox
    Friend WithEvents Txtnom As TextBox
    Friend WithEvents BtnAjouter As Button
    Friend WithEvents Btnannuler As Button
    Friend WithEvents DgvListePatients As DataGridView
    Friend WithEvents Code As DataGridViewTextBoxColumn
    Friend WithEvents Nom As DataGridViewTextBoxColumn
    Friend WithEvents Prénom As DataGridViewTextBoxColumn
    Friend WithEvents Age As DataGridViewTextBoxColumn
    Friend WithEvents ErrorProvider1 As ErrorProvider

End Class
