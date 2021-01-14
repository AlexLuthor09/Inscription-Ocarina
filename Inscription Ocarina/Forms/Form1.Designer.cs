namespace Inscription_Ocarina
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Butt_Add_Children = new System.Windows.Forms.Button();
            this.ComboBox_ListOfChildren = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Butt_Modifier_Participant = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nNationamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateNaissanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mCDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.prixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbrJourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fiche_Sante = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.remarqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allergieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.jour4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.jour5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.enfantBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.incriptionOcarinaDataSet1 = new Inscription_Ocarina.IncriptionOcarinaDataSet1();
            this.But_Supp_Enfant = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.BUT_Refresh = new System.Windows.Forms.Button();
            this.BUT_Quitter = new System.Windows.Forms.Button();
            this.BUT_Export_to_excel = new System.Windows.Forms.Button();
            this.But_Remarque = new System.Windows.Forms.Button();
            this.enfantTableAdapter1 = new Inscription_Ocarina.IncriptionOcarinaDataSet1TableAdapters.EnfantTableAdapter();
            this.But_apayer = new System.Windows.Forms.Button();
            this.incriptionOcarinaDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enfantBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incriptionOcarinaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incriptionOcarinaDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Butt_Add_Children
            // 
            this.Butt_Add_Children.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Butt_Add_Children.Location = new System.Drawing.Point(1331, 99);
            this.Butt_Add_Children.Margin = new System.Windows.Forms.Padding(4);
            this.Butt_Add_Children.Name = "Butt_Add_Children";
            this.Butt_Add_Children.Size = new System.Drawing.Size(217, 102);
            this.Butt_Add_Children.TabIndex = 0;
            this.Butt_Add_Children.Text = "Ajouter Participant";
            this.Butt_Add_Children.UseVisualStyleBackColor = true;
            this.Butt_Add_Children.Click += new System.EventHandler(this.Butt_Add_Children_Click);
            // 
            // ComboBox_ListOfChildren
            // 
            this.ComboBox_ListOfChildren.DisplayMember = "Enfant.Id";
            this.ComboBox_ListOfChildren.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_ListOfChildren.FormattingEnabled = true;
            this.ComboBox_ListOfChildren.Location = new System.Drawing.Point(19, 58);
            this.ComboBox_ListOfChildren.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBox_ListOfChildren.Name = "ComboBox_ListOfChildren";
            this.ComboBox_ListOfChildren.Size = new System.Drawing.Size(423, 31);
            this.ComboBox_ListOfChildren.TabIndex = 1;
            this.ComboBox_ListOfChildren.ValueMember = "Enfant.Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Liste de particiant :";
            // 
            // Butt_Modifier_Participant
            // 
            this.Butt_Modifier_Participant.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Butt_Modifier_Participant.Location = new System.Drawing.Point(1331, 210);
            this.Butt_Modifier_Participant.Margin = new System.Windows.Forms.Padding(4);
            this.Butt_Modifier_Participant.Name = "Butt_Modifier_Participant";
            this.Butt_Modifier_Participant.Size = new System.Drawing.Size(217, 102);
            this.Butt_Modifier_Participant.TabIndex = 5;
            this.Butt_Modifier_Participant.Text = "Modifier Participant";
            this.Butt_Modifier_Participant.UseVisualStyleBackColor = true;
            this.Butt_Modifier_Participant.Click += new System.EventHandler(this.Butt_Modifier_Participant_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.nNationamDataGridViewTextBoxColumn,
            this.dateNaissanceDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.mCDataGridViewCheckBoxColumn,
            this.prixDataGridViewTextBoxColumn,
            this.nbrJourDataGridViewTextBoxColumn,
            this.Fiche_Sante,
            this.remarqueDataGridViewTextBoxColumn,
            this.allergieDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewCheckBoxColumn3,
            this.jour4,
            this.jour5});
            this.dataGridView1.DataSource = this.enfantBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(21, 99);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1302, 866);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "Prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "Prenom";
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            this.prenomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Visible = false;
            // 
            // nNationamDataGridViewTextBoxColumn
            // 
            this.nNationamDataGridViewTextBoxColumn.DataPropertyName = "N_Nationam";
            this.nNationamDataGridViewTextBoxColumn.HeaderText = "N_Nationam";
            this.nNationamDataGridViewTextBoxColumn.Name = "nNationamDataGridViewTextBoxColumn";
            this.nNationamDataGridViewTextBoxColumn.ReadOnly = true;
            this.nNationamDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateNaissanceDataGridViewTextBoxColumn
            // 
            this.dateNaissanceDataGridViewTextBoxColumn.DataPropertyName = "Date_Naissance";
            this.dateNaissanceDataGridViewTextBoxColumn.HeaderText = "Date_Naissance";
            this.dateNaissanceDataGridViewTextBoxColumn.Name = "dateNaissanceDataGridViewTextBoxColumn";
            this.dateNaissanceDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateNaissanceDataGridViewTextBoxColumn.Visible = false;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mCDataGridViewCheckBoxColumn
            // 
            this.mCDataGridViewCheckBoxColumn.DataPropertyName = "MC";
            this.mCDataGridViewCheckBoxColumn.HeaderText = "MC";
            this.mCDataGridViewCheckBoxColumn.Name = "mCDataGridViewCheckBoxColumn";
            this.mCDataGridViewCheckBoxColumn.ReadOnly = true;
            this.mCDataGridViewCheckBoxColumn.Visible = false;
            // 
            // prixDataGridViewTextBoxColumn
            // 
            this.prixDataGridViewTextBoxColumn.DataPropertyName = "Prix";
            this.prixDataGridViewTextBoxColumn.HeaderText = "Prix";
            this.prixDataGridViewTextBoxColumn.Name = "prixDataGridViewTextBoxColumn";
            this.prixDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nbrJourDataGridViewTextBoxColumn
            // 
            this.nbrJourDataGridViewTextBoxColumn.DataPropertyName = "Nbr_Jour";
            this.nbrJourDataGridViewTextBoxColumn.HeaderText = "Nbr_Jour";
            this.nbrJourDataGridViewTextBoxColumn.Name = "nbrJourDataGridViewTextBoxColumn";
            this.nbrJourDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Fiche_Sante
            // 
            this.Fiche_Sante.DataPropertyName = "Fiche_Sante";
            this.Fiche_Sante.HeaderText = "Fiche_Sante";
            this.Fiche_Sante.Name = "Fiche_Sante";
            this.Fiche_Sante.ReadOnly = true;
            // 
            // remarqueDataGridViewTextBoxColumn
            // 
            this.remarqueDataGridViewTextBoxColumn.DataPropertyName = "Remarque";
            this.remarqueDataGridViewTextBoxColumn.HeaderText = "Remarque";
            this.remarqueDataGridViewTextBoxColumn.Name = "remarqueDataGridViewTextBoxColumn";
            this.remarqueDataGridViewTextBoxColumn.ReadOnly = true;
            this.remarqueDataGridViewTextBoxColumn.Visible = false;
            // 
            // allergieDataGridViewTextBoxColumn
            // 
            this.allergieDataGridViewTextBoxColumn.DataPropertyName = "Allergie";
            this.allergieDataGridViewTextBoxColumn.HeaderText = "Allergie";
            this.allergieDataGridViewTextBoxColumn.Name = "allergieDataGridViewTextBoxColumn";
            this.allergieDataGridViewTextBoxColumn.ReadOnly = true;
            this.allergieDataGridViewTextBoxColumn.Visible = false;
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "Adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "Adresse";
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            this.adresseDataGridViewTextBoxColumn.ReadOnly = true;
            this.adresseDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "jour1";
            this.dataGridViewCheckBoxColumn1.HeaderText = "lundi";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "jour2";
            this.dataGridViewCheckBoxColumn2.HeaderText = "mardi";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "jour3";
            this.dataGridViewCheckBoxColumn3.HeaderText = "mercredi";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            this.dataGridViewCheckBoxColumn3.ReadOnly = true;
            // 
            // jour4
            // 
            this.jour4.DataPropertyName = "jour4";
            this.jour4.HeaderText = "jeudi";
            this.jour4.Name = "jour4";
            this.jour4.ReadOnly = true;
            // 
            // jour5
            // 
            this.jour5.DataPropertyName = "jour5";
            this.jour5.HeaderText = "vendredi";
            this.jour5.Name = "jour5";
            this.jour5.ReadOnly = true;
            // 
            // enfantBindingSource1
            // 
            this.enfantBindingSource1.DataMember = "Enfant";
            this.enfantBindingSource1.DataSource = this.incriptionOcarinaDataSet1;
            // 
            // incriptionOcarinaDataSet1
            // 
            this.incriptionOcarinaDataSet1.DataSetName = "IncriptionOcarinaDataSet1";
            this.incriptionOcarinaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // But_Supp_Enfant
            // 
            this.But_Supp_Enfant.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But_Supp_Enfant.Location = new System.Drawing.Point(1331, 321);
            this.But_Supp_Enfant.Margin = new System.Windows.Forms.Padding(4);
            this.But_Supp_Enfant.Name = "But_Supp_Enfant";
            this.But_Supp_Enfant.Size = new System.Drawing.Size(217, 102);
            this.But_Supp_Enfant.TabIndex = 11;
            this.But_Supp_Enfant.Text = "Supprimer Participant";
            this.But_Supp_Enfant.UseVisualStyleBackColor = true;
            this.But_Supp_Enfant.Click += new System.EventHandler(this.But_Supp_Enfant_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(564, 55);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(314, 30);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(558, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "Jour Actuel";
            // 
            // BUT_Refresh
            // 
            this.BUT_Refresh.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUT_Refresh.Location = new System.Drawing.Point(941, 17);
            this.BUT_Refresh.Margin = new System.Windows.Forms.Padding(4);
            this.BUT_Refresh.Name = "BUT_Refresh";
            this.BUT_Refresh.Size = new System.Drawing.Size(157, 78);
            this.BUT_Refresh.TabIndex = 14;
            this.BUT_Refresh.Text = "Refresh";
            this.BUT_Refresh.UseVisualStyleBackColor = true;
            this.BUT_Refresh.Click += new System.EventHandler(this.BUT_Refresh_Click);
            // 
            // BUT_Quitter
            // 
            this.BUT_Quitter.BackColor = System.Drawing.Color.Maroon;
            this.BUT_Quitter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUT_Quitter.ForeColor = System.Drawing.Color.White;
            this.BUT_Quitter.Location = new System.Drawing.Point(1331, 883);
            this.BUT_Quitter.Margin = new System.Windows.Forms.Padding(4);
            this.BUT_Quitter.Name = "BUT_Quitter";
            this.BUT_Quitter.Size = new System.Drawing.Size(219, 82);
            this.BUT_Quitter.TabIndex = 16;
            this.BUT_Quitter.Text = "Quitter";
            this.BUT_Quitter.UseVisualStyleBackColor = false;
            this.BUT_Quitter.Click += new System.EventHandler(this.BUT_Quitter_Click);
            // 
            // BUT_Export_to_excel
            // 
            this.BUT_Export_to_excel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUT_Export_to_excel.Location = new System.Drawing.Point(1331, 690);
            this.BUT_Export_to_excel.Margin = new System.Windows.Forms.Padding(4);
            this.BUT_Export_to_excel.Name = "BUT_Export_to_excel";
            this.BUT_Export_to_excel.Size = new System.Drawing.Size(219, 82);
            this.BUT_Export_to_excel.TabIndex = 17;
            this.BUT_Export_to_excel.Text = "Export to Excel";
            this.BUT_Export_to_excel.UseVisualStyleBackColor = true;
            this.BUT_Export_to_excel.Click += new System.EventHandler(this.BUT_Export_to_excel_Click);
            // 
            // But_Remarque
            // 
            this.But_Remarque.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But_Remarque.Location = new System.Drawing.Point(1331, 599);
            this.But_Remarque.Margin = new System.Windows.Forms.Padding(4);
            this.But_Remarque.Name = "But_Remarque";
            this.But_Remarque.Size = new System.Drawing.Size(219, 82);
            this.But_Remarque.TabIndex = 18;
            this.But_Remarque.Text = "Remarques / Allergies";
            this.But_Remarque.UseVisualStyleBackColor = true;
            this.But_Remarque.Click += new System.EventHandler(this.But_Remarque_Click);
            // 
            // enfantTableAdapter1
            // 
            this.enfantTableAdapter1.ClearBeforeFill = true;
            // 
            // But_apayer
            // 
            this.But_apayer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But_apayer.Location = new System.Drawing.Point(1106, 17);
            this.But_apayer.Margin = new System.Windows.Forms.Padding(4);
            this.But_apayer.Name = "But_apayer";
            this.But_apayer.Size = new System.Drawing.Size(217, 78);
            this.But_apayer.TabIndex = 19;
            this.But_apayer.Text = "A payer";
            this.But_apayer.UseVisualStyleBackColor = true;
            this.But_apayer.Click += new System.EventHandler(this.But_apayer_Click);
            // 
            // incriptionOcarinaDataSet1BindingSource
            // 
            this.incriptionOcarinaDataSet1BindingSource.DataSource = this.incriptionOcarinaDataSet1;
            this.incriptionOcarinaDataSet1BindingSource.Position = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1557, 972);
            this.ControlBox = false;
            this.Controls.Add(this.But_apayer);
            this.Controls.Add(this.But_Remarque);
            this.Controls.Add(this.BUT_Export_to_excel);
            this.Controls.Add(this.BUT_Quitter);
            this.Controls.Add(this.BUT_Refresh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.But_Supp_Enfant);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Butt_Modifier_Participant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboBox_ListOfChildren);
            this.Controls.Add(this.Butt_Add_Children);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscription";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enfantBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incriptionOcarinaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incriptionOcarinaDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Butt_Add_Children;
        private System.Windows.Forms.ComboBox ComboBox_ListOfChildren;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Butt_Modifier_Participant;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button But_Supp_Enfant;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BUT_Refresh;
        private System.Windows.Forms.Button BUT_Quitter;
        private System.Windows.Forms.Button BUT_Export_to_excel;
        private System.Windows.Forms.Button But_Remarque;
        private IncriptionOcarinaDataSet1 incriptionOcarinaDataSet1;
        private System.Windows.Forms.BindingSource enfantBindingSource1;
        private IncriptionOcarinaDataSet1TableAdapters.EnfantTableAdapter enfantTableAdapter1;
        private System.Windows.Forms.Button But_apayer;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Fiche_Sante;
        private System.Windows.Forms.DataGridViewCheckBoxColumn jour4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn jour5;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nNationamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateNaissanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn mCDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbrJourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn allergieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.BindingSource incriptionOcarinaDataSet1BindingSource;
    }
}

