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
            this.SuspendLayout();
            // 
            // Butt_Add_Children
            // 
            this.Butt_Add_Children.Location = new System.Drawing.Point(573, 35);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

