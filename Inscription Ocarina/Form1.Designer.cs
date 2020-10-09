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
            this.Butt_Add_Children = new System.Windows.Forms.Button();
            this.ComboBox_ListOfChildren = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_Fiche_Sante = new System.Windows.Forms.CheckBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.Butt_Modifier_Participant = new System.Windows.Forms.Button();
            this.Butt_Validation = new System.Windows.Forms.Button();
            this.CB_Fin_Plaine = new System.Windows.Forms.CheckBox();
            this.CB_Payer = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Butt_Add_Children
            // 
            this.Butt_Add_Children.Location = new System.Drawing.Point(346, 15);
            this.Butt_Add_Children.Name = "Butt_Add_Children";
            this.Butt_Add_Children.Size = new System.Drawing.Size(158, 71);
            this.Butt_Add_Children.TabIndex = 0;
            this.Butt_Add_Children.Text = "Ajouter Participant";
            this.Butt_Add_Children.UseVisualStyleBackColor = true;
            this.Butt_Add_Children.Click += new System.EventHandler(this.Butt_Add_Children_Click);
            // 
            // ComboBox_ListOfChildren
            // 
            this.ComboBox_ListOfChildren.FormattingEnabled = true;
            this.ComboBox_ListOfChildren.Location = new System.Drawing.Point(31, 35);
            this.ComboBox_ListOfChildren.Name = "ComboBox_ListOfChildren";
            this.ComboBox_ListOfChildren.Size = new System.Drawing.Size(309, 24);
            this.ComboBox_ListOfChildren.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Liste de particiant :";
            // 
            // CB_Fiche_Sante
            // 
            this.CB_Fiche_Sante.AutoSize = true;
            this.CB_Fiche_Sante.Location = new System.Drawing.Point(346, 169);
            this.CB_Fiche_Sante.Name = "CB_Fiche_Sante";
            this.CB_Fiche_Sante.Size = new System.Drawing.Size(103, 21);
            this.CB_Fiche_Sante.TabIndex = 3;
            this.CB_Fiche_Sante.Text = "Fiche santé";
            this.CB_Fiche_Sante.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(520, 18);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            // 
            // Butt_Modifier_Participant
            // 
            this.Butt_Modifier_Participant.Location = new System.Drawing.Point(346, 92);
            this.Butt_Modifier_Participant.Name = "Butt_Modifier_Participant";
            this.Butt_Modifier_Participant.Size = new System.Drawing.Size(158, 71);
            this.Butt_Modifier_Participant.TabIndex = 5;
            this.Butt_Modifier_Participant.Text = "Modifier Participant";
            this.Butt_Modifier_Participant.UseVisualStyleBackColor = true;
            // 
            // Butt_Validation
            // 
            this.Butt_Validation.Location = new System.Drawing.Point(667, 343);
            this.Butt_Validation.Name = "Butt_Validation";
            this.Butt_Validation.Size = new System.Drawing.Size(121, 84);
            this.Butt_Validation.TabIndex = 6;
            this.Butt_Validation.Text = "Valider";
            this.Butt_Validation.UseVisualStyleBackColor = true;
            // 
            // CB_Fin_Plaine
            // 
            this.CB_Fin_Plaine.AutoSize = true;
            this.CB_Fin_Plaine.Location = new System.Drawing.Point(667, 316);
            this.CB_Fin_Plaine.Name = "CB_Fin_Plaine";
            this.CB_Fin_Plaine.Size = new System.Drawing.Size(111, 21);
            this.CB_Fin_Plaine.TabIndex = 7;
            this.CB_Fin_Plaine.Text = "Fin de plaine";
            this.CB_Fin_Plaine.UseVisualStyleBackColor = true;
            // 
            // CB_Payer
            // 
            this.CB_Payer.AutoSize = true;
            this.CB_Payer.Location = new System.Drawing.Point(346, 196);
            this.CB_Payer.Name = "CB_Payer";
            this.CB_Payer.Size = new System.Drawing.Size(67, 21);
            this.CB_Payer.TabIndex = 8;
            this.CB_Payer.Text = "Payer";
            this.CB_Payer.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CB_Payer);
            this.Controls.Add(this.CB_Fin_Plaine);
            this.Controls.Add(this.Butt_Validation);
            this.Controls.Add(this.Butt_Modifier_Participant);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.CB_Fiche_Sante);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboBox_ListOfChildren);
            this.Controls.Add(this.Butt_Add_Children);
            this.Name = "MainForm";
            this.Text = "Inscription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Butt_Add_Children;
        private System.Windows.Forms.ComboBox ComboBox_ListOfChildren;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CB_Fiche_Sante;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button Butt_Modifier_Participant;
        private System.Windows.Forms.Button Butt_Validation;
        private System.Windows.Forms.CheckBox CB_Fin_Plaine;
        private System.Windows.Forms.CheckBox CB_Payer;
    }
}

