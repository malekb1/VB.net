<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Trajetbus
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
        Me.components = New System.ComponentModel.Container()
        Me.GB_options = New System.Windows.Forms.GroupBox()
        Me.Chk_etg = New System.Windows.Forms.CheckBox()
        Me.Chk_wifi = New System.Windows.Forms.CheckBox()
        Me.Chk_Clima = New System.Windows.Forms.CheckBox()
        Me.GB_type = New System.Windows.Forms.GroupBox()
        Me.Radio_Noctu = New System.Windows.Forms.RadioButton()
        Me.Radio_exp = New System.Windows.Forms.RadioButton()
        Me.Radio_regu = New System.Windows.Forms.RadioButton()
        Me.GB_formation = New System.Windows.Forms.GroupBox()
        Me.BtnAjouter = New System.Windows.Forms.Button()
        Me.Num_places = New System.Windows.Forms.NumericUpDown()
        Me.DTP_arv = New System.Windows.Forms.DateTimePicker()
        Me.DTP_dep = New System.Windows.Forms.DateTimePicker()
        Me.LstVilleDep = New System.Windows.Forms.ComboBox()
        Me.LstVilleArrivee = New System.Windows.Forms.ComboBox()
        Me.LstLigne = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGV_Reservation = New System.Windows.Forms.DataGridView()
        Me.Ligne = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Départ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Arrivée = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Heure_Départ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Heure_Arrivée = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Places = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Options = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GB_options.SuspendLayout()
        Me.GB_type.SuspendLayout()
        Me.GB_formation.SuspendLayout()
        CType(Me.Num_places, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Reservation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GB_options
        '
        Me.GB_options.Controls.Add(Me.Chk_etg)
        Me.GB_options.Controls.Add(Me.Chk_wifi)
        Me.GB_options.Controls.Add(Me.Chk_Clima)
        Me.GB_options.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_options.ForeColor = System.Drawing.Color.Blue
        Me.GB_options.Location = New System.Drawing.Point(496, 37)
        Me.GB_options.Margin = New System.Windows.Forms.Padding(4)
        Me.GB_options.Name = "GB_options"
        Me.GB_options.Padding = New System.Windows.Forms.Padding(4)
        Me.GB_options.Size = New System.Drawing.Size(220, 172)
        Me.GB_options.TabIndex = 0
        Me.GB_options.TabStop = False
        Me.GB_options.Text = "Options"
        '
        'Chk_etg
        '
        Me.Chk_etg.AutoSize = True
        Me.Chk_etg.Location = New System.Drawing.Point(8, 134)
        Me.Chk_etg.Margin = New System.Windows.Forms.Padding(4)
        Me.Chk_etg.Name = "Chk_etg"
        Me.Chk_etg.Size = New System.Drawing.Size(180, 33)
        Me.Chk_etg.TabIndex = 2
        Me.Chk_etg.Text = "Bus à étage "
        Me.Chk_etg.UseVisualStyleBackColor = True
        '
        'Chk_wifi
        '
        Me.Chk_wifi.AutoSize = True
        Me.Chk_wifi.Location = New System.Drawing.Point(8, 85)
        Me.Chk_wifi.Margin = New System.Windows.Forms.Padding(4)
        Me.Chk_wifi.Name = "Chk_wifi"
        Me.Chk_wifi.Size = New System.Drawing.Size(79, 33)
        Me.Chk_wifi.TabIndex = 1
        Me.Chk_wifi.Text = "Wifi"
        Me.Chk_wifi.UseVisualStyleBackColor = True
        '
        'Chk_Clima
        '
        Me.Chk_Clima.AutoSize = True
        Me.Chk_Clima.Location = New System.Drawing.Point(8, 39)
        Me.Chk_Clima.Margin = New System.Windows.Forms.Padding(4)
        Me.Chk_Clima.Name = "Chk_Clima"
        Me.Chk_Clima.Size = New System.Drawing.Size(199, 33)
        Me.Chk_Clima.TabIndex = 0
        Me.Chk_Clima.Text = "Climatsisation"
        Me.Chk_Clima.UseVisualStyleBackColor = True
        '
        'GB_type
        '
        Me.GB_type.Controls.Add(Me.Radio_Noctu)
        Me.GB_type.Controls.Add(Me.Radio_exp)
        Me.GB_type.Controls.Add(Me.Radio_regu)
        Me.GB_type.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_type.ForeColor = System.Drawing.Color.Blue
        Me.GB_type.Location = New System.Drawing.Point(724, 37)
        Me.GB_type.Margin = New System.Windows.Forms.Padding(4)
        Me.GB_type.Name = "GB_type"
        Me.GB_type.Padding = New System.Windows.Forms.Padding(4)
        Me.GB_type.Size = New System.Drawing.Size(220, 180)
        Me.GB_type.TabIndex = 1
        Me.GB_type.TabStop = False
        Me.GB_type.Text = "Type de trajet"
        '
        'Radio_Noctu
        '
        Me.Radio_Noctu.AutoSize = True
        Me.Radio_Noctu.Location = New System.Drawing.Point(21, 138)
        Me.Radio_Noctu.Margin = New System.Windows.Forms.Padding(4)
        Me.Radio_Noctu.Name = "Radio_Noctu"
        Me.Radio_Noctu.Size = New System.Drawing.Size(140, 33)
        Me.Radio_Noctu.TabIndex = 2
        Me.Radio_Noctu.TabStop = True
        Me.Radio_Noctu.Text = "Nocturne"
        Me.Radio_Noctu.UseVisualStyleBackColor = True
        '
        'Radio_exp
        '
        Me.Radio_exp.AutoSize = True
        Me.Radio_exp.Location = New System.Drawing.Point(21, 82)
        Me.Radio_exp.Margin = New System.Windows.Forms.Padding(4)
        Me.Radio_exp.Name = "Radio_exp"
        Me.Radio_exp.Size = New System.Drawing.Size(128, 33)
        Me.Radio_exp.TabIndex = 1
        Me.Radio_exp.TabStop = True
        Me.Radio_exp.Text = "Express"
        Me.Radio_exp.UseVisualStyleBackColor = True
        '
        'Radio_regu
        '
        Me.Radio_regu.AutoSize = True
        Me.Radio_regu.Location = New System.Drawing.Point(21, 41)
        Me.Radio_regu.Margin = New System.Windows.Forms.Padding(4)
        Me.Radio_regu.Name = "Radio_regu"
        Me.Radio_regu.Size = New System.Drawing.Size(134, 33)
        Me.Radio_regu.TabIndex = 0
        Me.Radio_regu.TabStop = True
        Me.Radio_regu.Text = "Régulier"
        Me.Radio_regu.UseVisualStyleBackColor = True
        '
        'GB_formation
        '
        Me.GB_formation.Controls.Add(Me.BtnAjouter)
        Me.GB_formation.Controls.Add(Me.Num_places)
        Me.GB_formation.Controls.Add(Me.DTP_arv)
        Me.GB_formation.Controls.Add(Me.DTP_dep)
        Me.GB_formation.Controls.Add(Me.LstVilleDep)
        Me.GB_formation.Controls.Add(Me.LstVilleArrivee)
        Me.GB_formation.Controls.Add(Me.LstLigne)
        Me.GB_formation.Controls.Add(Me.Label6)
        Me.GB_formation.Controls.Add(Me.Label5)
        Me.GB_formation.Controls.Add(Me.Label4)
        Me.GB_formation.Controls.Add(Me.Label3)
        Me.GB_formation.Controls.Add(Me.Label2)
        Me.GB_formation.Controls.Add(Me.Label1)
        Me.GB_formation.ForeColor = System.Drawing.Color.Green
        Me.GB_formation.Location = New System.Drawing.Point(31, 43)
        Me.GB_formation.Margin = New System.Windows.Forms.Padding(4)
        Me.GB_formation.Name = "GB_formation"
        Me.GB_formation.Padding = New System.Windows.Forms.Padding(4)
        Me.GB_formation.Size = New System.Drawing.Size(458, 349)
        Me.GB_formation.TabIndex = 2
        Me.GB_formation.TabStop = False
        Me.GB_formation.Text = "Information du trajet"
        '
        'BtnAjouter
        '
        Me.BtnAjouter.Location = New System.Drawing.Point(347, 273)
        Me.BtnAjouter.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAjouter.Name = "BtnAjouter"
        Me.BtnAjouter.Size = New System.Drawing.Size(100, 43)
        Me.BtnAjouter.TabIndex = 12
        Me.BtnAjouter.Text = "Ajouter"
        Me.BtnAjouter.UseVisualStyleBackColor = True
        '
        'Num_places
        '
        Me.Num_places.Location = New System.Drawing.Point(148, 286)
        Me.Num_places.Margin = New System.Windows.Forms.Padding(4)
        Me.Num_places.Name = "Num_places"
        Me.Num_places.Size = New System.Drawing.Size(160, 22)
        Me.Num_places.TabIndex = 11
        '
        'DTP_arv
        '
        Me.DTP_arv.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DTP_arv.Location = New System.Drawing.Point(148, 231)
        Me.DTP_arv.Margin = New System.Windows.Forms.Padding(4)
        Me.DTP_arv.Name = "DTP_arv"
        Me.DTP_arv.Size = New System.Drawing.Size(265, 22)
        Me.DTP_arv.TabIndex = 10
        '
        'DTP_dep
        '
        Me.DTP_dep.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DTP_dep.Location = New System.Drawing.Point(148, 181)
        Me.DTP_dep.Margin = New System.Windows.Forms.Padding(4)
        Me.DTP_dep.Name = "DTP_dep"
        Me.DTP_dep.Size = New System.Drawing.Size(265, 22)
        Me.DTP_dep.TabIndex = 9
        '
        'LstVilleDep
        '
        Me.LstVilleDep.FormattingEnabled = True
        Me.LstVilleDep.Items.AddRange(New Object() {"Bizerte", "Manzel Abd Rahmen", "Manzel Jmil"})
        Me.LstVilleDep.Location = New System.Drawing.Point(148, 80)
        Me.LstVilleDep.Margin = New System.Windows.Forms.Padding(4)
        Me.LstVilleDep.Name = "LstVilleDep"
        Me.LstVilleDep.Size = New System.Drawing.Size(160, 24)
        Me.LstVilleDep.TabIndex = 8
        '
        'LstVilleArrivee
        '
        Me.LstVilleArrivee.FormattingEnabled = True
        Me.LstVilleArrivee.Items.AddRange(New Object() {"Bizerte", "Manzel Abd Rahmen", "manzel Jmil"})
        Me.LstVilleArrivee.Location = New System.Drawing.Point(148, 133)
        Me.LstVilleArrivee.Margin = New System.Windows.Forms.Padding(4)
        Me.LstVilleArrivee.Name = "LstVilleArrivee"
        Me.LstVilleArrivee.Size = New System.Drawing.Size(160, 24)
        Me.LstVilleArrivee.TabIndex = 7
        '
        'LstLigne
        '
        Me.LstLigne.FormattingEnabled = True
        Me.LstLigne.Items.AddRange(New Object() {"Ligne1", "Ligne2", "Ligne3"})
        Me.LstLigne.Location = New System.Drawing.Point(148, 27)
        Me.LstLigne.Margin = New System.Windows.Forms.Padding(4)
        Me.LstLigne.Name = "LstLigne"
        Me.LstLigne.Size = New System.Drawing.Size(160, 24)
        Me.LstLigne.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 286)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Places : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 231)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "heure arrivée : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 181)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "heure depart :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 133)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ville arrivée : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 84)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ville depart : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ligne : "
        '
        'DGV_Reservation
        '
        Me.DGV_Reservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Reservation.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Ligne, Me.Départ, Me.Arrivée, Me.Heure_Départ, Me.Heure_Arrivée, Me.Places, Me.Options})
        Me.DGV_Reservation.Location = New System.Drawing.Point(31, 404)
        Me.DGV_Reservation.Margin = New System.Windows.Forms.Padding(4)
        Me.DGV_Reservation.Name = "DGV_Reservation"
        Me.DGV_Reservation.RowHeadersWidth = 51
        Me.DGV_Reservation.Size = New System.Drawing.Size(1030, 197)
        Me.DGV_Reservation.TabIndex = 3
        '
        'Ligne
        '
        Me.Ligne.HeaderText = "Ligne"
        Me.Ligne.MinimumWidth = 6
        Me.Ligne.Name = "Ligne"
        Me.Ligne.Width = 125
        '
        'Départ
        '
        Me.Départ.HeaderText = "Départ"
        Me.Départ.MinimumWidth = 6
        Me.Départ.Name = "Départ"
        Me.Départ.Width = 125
        '
        'Arrivée
        '
        Me.Arrivée.HeaderText = "Arrivée"
        Me.Arrivée.MinimumWidth = 6
        Me.Arrivée.Name = "Arrivée"
        Me.Arrivée.Width = 125
        '
        'Heure_Départ
        '
        Me.Heure_Départ.HeaderText = "Heure_Départ"
        Me.Heure_Départ.MinimumWidth = 6
        Me.Heure_Départ.Name = "Heure_Départ"
        Me.Heure_Départ.Width = 125
        '
        'Heure_Arrivée
        '
        Me.Heure_Arrivée.HeaderText = "Heure_Arrivée"
        Me.Heure_Arrivée.MinimumWidth = 6
        Me.Heure_Arrivée.Name = "Heure_Arrivée"
        Me.Heure_Arrivée.Width = 125
        '
        'Places
        '
        Me.Places.HeaderText = "Places"
        Me.Places.MinimumWidth = 6
        Me.Places.Name = "Places"
        Me.Places.Width = 125
        '
        'Options
        '
        Me.Options.HeaderText = "Options"
        Me.Options.MinimumWidth = 6
        Me.Options.Name = "Options"
        Me.Options.Width = 125
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(217, 8)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(506, 31)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "GESTION DES HORRAIRES DE BUS"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Trajetbus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(1089, 631)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DGV_Reservation)
        Me.Controls.Add(Me.GB_formation)
        Me.Controls.Add(Me.GB_type)
        Me.Controls.Add(Me.GB_options)
        Me.ForeColor = System.Drawing.Color.LightGray
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Trajetbus"
        Me.RightToLeftLayout = True
        Me.Text = "Trajetbus"
        Me.GB_options.ResumeLayout(False)
        Me.GB_options.PerformLayout()
        Me.GB_type.ResumeLayout(False)
        Me.GB_type.PerformLayout()
        Me.GB_formation.ResumeLayout(False)
        Me.GB_formation.PerformLayout()
        CType(Me.Num_places, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Reservation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GB_options As GroupBox
    Friend WithEvents GB_type As GroupBox
    Friend WithEvents GB_formation As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DTP_arv As DateTimePicker
    Friend WithEvents DTP_dep As DateTimePicker
    Friend WithEvents LstVilleDep As ComboBox
    Friend WithEvents LstVilleArrivee As ComboBox
    Friend WithEvents LstLigne As ComboBox
    Friend WithEvents Chk_etg As CheckBox
    Friend WithEvents Chk_wifi As CheckBox
    Friend WithEvents Chk_Clima As CheckBox
    Friend WithEvents Radio_Noctu As RadioButton
    Friend WithEvents Radio_exp As RadioButton
    Friend WithEvents Radio_regu As RadioButton
    Friend WithEvents Num_places As NumericUpDown
    Friend WithEvents BtnAjouter As Button
    Friend WithEvents DGV_Reservation As DataGridView
    Friend WithEvents Ligne As DataGridViewTextBoxColumn
    Friend WithEvents Départ As DataGridViewTextBoxColumn
    Friend WithEvents Arrivée As DataGridViewTextBoxColumn
    Friend WithEvents Heure_Départ As DataGridViewTextBoxColumn
    Friend WithEvents Heure_Arrivée As DataGridViewTextBoxColumn
    Friend WithEvents Places As DataGridViewTextBoxColumn
    Friend WithEvents Options As DataGridViewTextBoxColumn
    Friend WithEvents Label7 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
