using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inscription_Ocarina
{
    public partial class SortieExcel : Form
    {
        private SQL_Manager _Manager = Program.DP._Manager;
        private Donnees_Partagees ShareData = Program.DP;
       
        public SortieExcel()
        {
            InitializeComponent();
        }


        private void But_Validation_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "")
            {
                if (TB_NomPlaine.Text.Trim() != "")
                {
                    string NomPlaine = TB_NomPlaine.Text.Replace(@"\s", "").Trim();
                    string dateDebut = DTP_Start.Value.Date.ToShortDateString().Trim();
                    string dateFin = DTP_Stop.Value.Date.ToShortDateString().Trim();
                    string path = textBox1.Text;
                    _Manager.ExportEnfantToExcel(path + @"\" + NomPlaine + "_" + dateDebut + "_" + dateFin);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Veuillez remplir tous les champs textes disponibles");
                }
            }
            else
            {
                MessageBox.Show("Désigné d'abord un dossier");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowNewFolderButton = true;
            
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = fbd.SelectedPath;

            }
        }
    }
}
