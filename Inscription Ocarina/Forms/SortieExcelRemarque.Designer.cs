namespace Inscription_Ocarina
{
    partial class SortieExcelRemarque
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
            this.But_Validation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_ = new System.Windows.Forms.TextBox();
            this.OpenExistanteFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_NomPlaine = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // But_Validation
            // 
            this.But_Validation.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But_Validation.Location = new System.Drawing.Point(173, 217);
            this.But_Validation.Name = "But_Validation";
            this.But_Validation.Size = new System.Drawing.Size(344, 61);
            this.But_Validation.TabIndex = 17;
            this.But_Validation.Text = "Valider / Exporter";
            this.But_Validation.UseVisualStyleBackColor = true;
            this.But_Validation.Click += new System.EventHandler(this.But_Validation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "Chemin du fichier";
            // 
            // TB_
            // 
            this.TB_.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_.Enabled = false;
            this.TB_.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_.Location = new System.Drawing.Point(19, 71);
            this.TB_.Name = "TB_";
            this.TB_.Size = new System.Drawing.Size(575, 39);
            this.TB_.TabIndex = 15;
            // 
            // OpenExistanteFile
            // 
            this.OpenExistanteFile.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenExistanteFile.Location = new System.Drawing.Point(615, 44);
            this.OpenExistanteFile.Name = "OpenExistanteFile";
            this.OpenExistanteFile.Size = new System.Drawing.Size(173, 93);
            this.OpenExistanteFile.TabIndex = 14;
            this.OpenExistanteFile.Text = "Rechercher";
            this.OpenExistanteFile.UseVisualStyleBackColor = true;
            this.OpenExistanteFile.Click += new System.EventHandler(this.OpenExistanteFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 32);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nom de la Plaine";
            // 
            // TB_NomPlaine
            // 
            this.TB_NomPlaine.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_NomPlaine.Location = new System.Drawing.Point(19, 148);
            this.TB_NomPlaine.Name = "TB_NomPlaine";
            this.TB_NomPlaine.Size = new System.Drawing.Size(572, 39);
            this.TB_NomPlaine.TabIndex = 18;
            // 
            // SortieExcelRemarque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 320);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_NomPlaine);
            this.Controls.Add(this.But_Validation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_);
            this.Controls.Add(this.OpenExistanteFile);
            this.Name = "SortieExcelRemarque";
            this.Text = "SotrieExcelRemarque";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button But_Validation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_;
        private System.Windows.Forms.Button OpenExistanteFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_NomPlaine;
    }
}