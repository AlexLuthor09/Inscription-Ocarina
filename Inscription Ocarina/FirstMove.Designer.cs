namespace Inscription_Ocarina
{
    partial class FirstMove
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
            this.Butt_New_week = new System.Windows.Forms.Button();
            this.Butt_Current_week = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Butt_New_week
            // 
            this.Butt_New_week.Location = new System.Drawing.Point(12, 12);
            this.Butt_New_week.Name = "Butt_New_week";
            this.Butt_New_week.Size = new System.Drawing.Size(213, 125);
            this.Butt_New_week.TabIndex = 0;
            this.Butt_New_week.Text = "Nouvelle Semaine";
            this.Butt_New_week.UseVisualStyleBackColor = true;
            // 
            // Butt_Current_week
            // 
            this.Butt_Current_week.Location = new System.Drawing.Point(343, 12);
            this.Butt_Current_week.Name = "Butt_Current_week";
            this.Butt_Current_week.Size = new System.Drawing.Size(213, 125);
            this.Butt_Current_week.TabIndex = 1;
            this.Butt_Current_week.Text = "Même semaine";
            this.Butt_Current_week.UseVisualStyleBackColor = true;
            // 
            // FirstMove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 164);
            this.Controls.Add(this.Butt_Current_week);
            this.Controls.Add(this.Butt_New_week);
            this.Name = "FirstMove";
            this.Text = "FirstMove";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Butt_New_week;
        private System.Windows.Forms.Button Butt_Current_week;
    }
}