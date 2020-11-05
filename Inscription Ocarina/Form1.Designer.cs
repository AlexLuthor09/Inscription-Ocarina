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
            this.incriptionOcarinaDataSet = new Inscription_Ocarina.IncriptionOcarinaDataSet();
            this.enfantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Butt_Modifier_Participant = new System.Windows.Forms.Button();
            this.Butt_Validation = new System.Windows.Forms.Button();
            this.CB_Fin_Plaine = new System.Windows.Forms.CheckBox();
            this.CB_Payer = new System.Windows.Forms.CheckBox();
            this.enfantTableAdapter = new Inscription_Ocarina.IncriptionOcarinaDataSetTableAdapters.EnfantTableAdapter();
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
            this.remarqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allergieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.But_Supp_Enfant = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.BUT_Refresh = new System.Windows.Forms.Button();
            this.CB_Present = new System.Windows.Forms.CheckBox();
            this.BUT_Quitter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.incriptionOcarinaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enfantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Butt_Add_Children
            // 
            this.Butt_Add_Children.Location = new System.Drawing.Point(794, 15);
            this.Butt_Add_Children.Name = "Butt_Add_Children";
            this.Butt_Add_Children.Size = new System.Drawing.Size(158, 71);
            this.Butt_Add_Children.TabIndex = 0;
            this.Butt_Add_Children.Text = "Ajouter Participant";
            this.Butt_Add_Children.UseVisualStyleBackColor = true;
            this.Butt_Add_Children.Click += new System.EventHandler(this.Butt_Add_Children_Click);
            // 
            // ComboBox_ListOfChildren
            // 
            this.ComboBox_ListOfChildren.DataSource = this.incriptionOcarinaDataSet;
            this.ComboBox_ListOfChildren.DisplayMember = "Enfant.Nom";
            this.ComboBox_ListOfChildren.FormattingEnabled = true;
            this.ComboBox_ListOfChildren.Location = new System.Drawing.Point(15, 39);
            this.ComboBox_ListOfChildren.Name = "ComboBox_ListOfChildren";
            this.ComboBox_ListOfChildren.Size = new System.Drawing.Size(309, 24);
            this.ComboBox_ListOfChildren.TabIndex = 1;
            this.ComboBox_ListOfChildren.ValueMember = "Enfant.Id";
            // 
            // incriptionOcarinaDataSet
            // 
            this.incriptionOcarinaDataSet.DataSetName = "IncriptionOcarinaDataSet";
            this.incriptionOcarinaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // enfantBindingSource
            // 
            this.enfantBindingSource.DataMember = "Enfant";
            this.enfantBindingSource.DataSource = this.incriptionOcarinaDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Liste de particiant :";
            // 
            // Butt_Modifier_Participant
            // 
            this.Butt_Modifier_Participant.Location = new System.Drawing.Point(794, 92);
            this.Butt_Modifier_Participant.Name = "Butt_Modifier_Participant";
            this.Butt_Modifier_Participant.Size = new System.Drawing.Size(158, 71);
            this.Butt_Modifier_Participant.TabIndex = 5;
            this.Butt_Modifier_Participant.Text = "Modifier Participant";
            this.Butt_Modifier_Participant.UseVisualStyleBackColor = true;
            this.Butt_Modifier_Participant.Click += new System.EventHandler(this.Butt_Modifier_Participant_Click);
            // 
            // Butt_Validation
            // 
            this.Butt_Validation.Location = new System.Drawing.Point(831, 346);
            this.Butt_Validation.Name = "Butt_Validation";
            this.Butt_Validation.Size = new System.Drawing.Size(121, 84);
            this.Butt_Validation.TabIndex = 6;
            this.Butt_Validation.Text = "Valider";
            this.Butt_Validation.UseVisualStyleBackColor = true;
            this.Butt_Validation.Click += new System.EventHandler(this.Butt_Validation_Click);
            // 
            // CB_Fin_Plaine
            // 
            this.CB_Fin_Plaine.AutoSize = true;
            this.CB_Fin_Plaine.Location = new System.Drawing.Point(831, 319);
            this.CB_Fin_Plaine.Name = "CB_Fin_Plaine";
            this.CB_Fin_Plaine.Size = new System.Drawing.Size(111, 21);
            this.CB_Fin_Plaine.TabIndex = 7;
            this.CB_Fin_Plaine.Text = "Fin de plaine";
            this.CB_Fin_Plaine.UseVisualStyleBackColor = true;
            // 
            // CB_Payer
            // 
            this.CB_Payer.AutoSize = true;
            this.CB_Payer.Location = new System.Drawing.Point(813, 246);
            this.CB_Payer.Name = "CB_Payer";
            this.CB_Payer.Size = new System.Drawing.Size(67, 21);
            this.CB_Payer.TabIndex = 8;
            this.CB_Payer.Text = "Payer";
            this.CB_Payer.UseVisualStyleBackColor = true;
            this.CB_Payer.CheckedChanged += new System.EventHandler(this.CB_Payer_CheckedChanged);
            // 
            // enfantTableAdapter
            // 
            this.enfantTableAdapter.ClearBeforeFill = true;
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
            this.remarqueDataGridViewTextBoxColumn,
            this.allergieDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.enfantBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 69);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(773, 369);
            this.dataGridView1.TabIndex = 9;
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
            this.nbrJourDataGridViewTextBoxColumn.Visible = false;
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
            // But_Supp_Enfant
            // 
            this.But_Supp_Enfant.Location = new System.Drawing.Point(794, 169);
            this.But_Supp_Enfant.Name = "But_Supp_Enfant";
            this.But_Supp_Enfant.Size = new System.Drawing.Size(158, 71);
            this.But_Supp_Enfant.TabIndex = 11;
            this.But_Supp_Enfant.Text = "Supprimer Participant";
            this.But_Supp_Enfant.UseVisualStyleBackColor = true;
            this.But_Supp_Enfant.Click += new System.EventHandler(this.But_Supp_Enfant_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(330, 41);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Jour Actuel";
            // 
            // BUT_Refresh
            // 
            this.BUT_Refresh.Location = new System.Drawing.Point(536, 39);
            this.BUT_Refresh.Name = "BUT_Refresh";
            this.BUT_Refresh.Size = new System.Drawing.Size(88, 27);
            this.BUT_Refresh.TabIndex = 14;
            this.BUT_Refresh.Text = "Refresh";
            this.BUT_Refresh.UseVisualStyleBackColor = true;
            this.BUT_Refresh.Click += new System.EventHandler(this.BUT_Refresh_Click);
            // 
            // CB_Present
            // 
            this.CB_Present.AutoSize = true;
            this.CB_Present.Location = new System.Drawing.Point(813, 273);
            this.CB_Present.Name = "CB_Present";
            this.CB_Present.Size = new System.Drawing.Size(79, 21);
            this.CB_Present.TabIndex = 15;
            this.CB_Present.Text = "Present";
            this.CB_Present.UseVisualStyleBackColor = true;
            this.CB_Present.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // BUT_Quitter
            // 
            this.BUT_Quitter.Location = new System.Drawing.Point(629, 6);
            this.BUT_Quitter.Name = "BUT_Quitter";
            this.BUT_Quitter.Size = new System.Drawing.Size(159, 57);
            this.BUT_Quitter.TabIndex = 16;
            this.BUT_Quitter.Text = "Quitter";
            this.BUT_Quitter.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 450);
            this.Controls.Add(this.BUT_Quitter);
            this.Controls.Add(this.CB_Present);
            this.Controls.Add(this.BUT_Refresh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.But_Supp_Enfant);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CB_Payer);
            this.Controls.Add(this.CB_Fin_Plaine);
            this.Controls.Add(this.Butt_Validation);
            this.Controls.Add(this.Butt_Modifier_Participant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboBox_ListOfChildren);
            this.Controls.Add(this.Butt_Add_Children);
            this.Name = "MainForm";
            this.Text = "Inscription";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.incriptionOcarinaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enfantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Butt_Add_Children;
        private System.Windows.Forms.ComboBox ComboBox_ListOfChildren;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Butt_Modifier_Participant;
        private System.Windows.Forms.Button Butt_Validation;
        private System.Windows.Forms.CheckBox CB_Fin_Plaine;
        private System.Windows.Forms.CheckBox CB_Payer;
        private IncriptionOcarinaDataSet incriptionOcarinaDataSet;
        private System.Windows.Forms.BindingSource enfantBindingSource;
        private IncriptionOcarinaDataSetTableAdapters.EnfantTableAdapter enfantTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button But_Supp_Enfant;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BUT_Refresh;
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
        private System.Windows.Forms.CheckBox CB_Present;
        private System.Windows.Forms.Button BUT_Quitter;
    }
}

