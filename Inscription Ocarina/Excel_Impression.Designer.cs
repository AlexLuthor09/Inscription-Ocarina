namespace Inscription_Ocarina
{
    partial class Excel_Impression
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
            this.button2 = new System.Windows.Forms.Button();
            this.NameList = new System.Windows.Forms.ComboBox();
            this.Open = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(646, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 37);
            this.button2.TabIndex = 9;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // NameList
            // 
            this.NameList.Enabled = false;
            this.NameList.FormattingEnabled = true;
            this.NameList.Location = new System.Drawing.Point(122, 183);
            this.NameList.Name = "NameList";
            this.NameList.Size = new System.Drawing.Size(556, 24);
            this.NameList.TabIndex = 8;
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(122, 146);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(556, 31);
            this.Open.TabIndex = 7;
            this.Open.Text = "open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(412, 22);
            this.textBox1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(540, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Excel_Impression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.NameList);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Excel_Impression";
            this.Text = "Excel_Impression";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox NameList;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}