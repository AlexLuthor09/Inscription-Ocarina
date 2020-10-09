namespace Inscription_Ocarina
{
    partial class Inscription_Children
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.TB_Firstname = new System.Windows.Forms.TextBox();
            this.Butt_Validating = new System.Windows.Forms.Button();
            this.ComboBox_TAge = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_Remarques = new System.Windows.Forms.TextBox();
            this.TB_Allergies = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prénom";
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(10, 48);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(383, 22);
            this.TB_Name.TabIndex = 2;
            // 
            // TB_Firstname
            // 
            this.TB_Firstname.Location = new System.Drawing.Point(10, 93);
            this.TB_Firstname.Name = "TB_Firstname";
            this.TB_Firstname.Size = new System.Drawing.Size(383, 22);
            this.TB_Firstname.TabIndex = 3;
            // 
            // Butt_Validating
            // 
            this.Butt_Validating.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Butt_Validating.Location = new System.Drawing.Point(249, 697);
            this.Butt_Validating.Name = "Butt_Validating";
            this.Butt_Validating.Size = new System.Drawing.Size(236, 84);
            this.Butt_Validating.TabIndex = 4;
            this.Butt_Validating.Text = "Valider";
            this.Butt_Validating.UseVisualStyleBackColor = true;
            // 
            // ComboBox_TAge
            // 
            this.ComboBox_TAge.FormattingEnabled = true;
            this.ComboBox_TAge.Location = new System.Drawing.Point(10, 146);
            this.ComboBox_TAge.Name = "ComboBox_TAge";
            this.ComboBox_TAge.Size = new System.Drawing.Size(383, 24);
            this.ComboBox_TAge.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tranche d\'âge";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Remarques";
            // 
            // TB_Remarques
            // 
            this.TB_Remarques.Location = new System.Drawing.Point(407, 48);
            this.TB_Remarques.Multiline = true;
            this.TB_Remarques.Name = "TB_Remarques";
            this.TB_Remarques.Size = new System.Drawing.Size(381, 431);
            this.TB_Remarques.TabIndex = 8;
            // 
            // TB_Allergies
            // 
            this.TB_Allergies.Location = new System.Drawing.Point(12, 193);
            this.TB_Allergies.Multiline = true;
            this.TB_Allergies.Name = "TB_Allergies";
            this.TB_Allergies.Size = new System.Drawing.Size(381, 286);
            this.TB_Allergies.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Allergies";
            // 
            // Inscription_Children
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 793);
            this.Controls.Add(this.TB_Allergies);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_Remarques);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ComboBox_TAge);
            this.Controls.Add(this.Butt_Validating);
            this.Controls.Add(this.TB_Firstname);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Inscription_Children";
            this.Text = "Inscription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.TextBox TB_Firstname;
        private System.Windows.Forms.Button Butt_Validating;
        private System.Windows.Forms.ComboBox ComboBox_TAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_Remarques;
        private System.Windows.Forms.TextBox TB_Allergies;
        private System.Windows.Forms.Label label5;
    }
}