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
    public partial class SortieExcelRemarque : Form
    {
        private SQL_Manager _Manager = Program.DP._Manager;
        private Donnees_Partagees ShareData = Program.DP;

        public SortieExcelRemarque()
        {
            InitializeComponent();
        }

        private void OpenExistanteFile_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowNewFolderButton = true;

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                TB_.Text = fbd.SelectedPath;
            }
        }

        private void But_Validation_Click(object sender, EventArgs e)
        {
            if(TB_.Text.Trim() != "")
            {
                if (TB_NomPlaine.Text.Trim() != "")
                {
                    string path = TB_.Text;
                    string NomPlaine = TB_NomPlaine.Text.Replace(@"\s", "").Trim();
                    string date = DateTime.Now.Date.ToShortDateString().Trim();
                    _Manager.ExportRemarqueToExcel(path + @"\" + NomPlaine +"_"+date);
                    MessageBox.Show("Fichiers Excel créés , tu peux les trouver ici : " + path + @"\" + NomPlaine + "_" + date);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Insérer le nom de la plaine de jeux");
                }
            }
            else
            {
                MessageBox.Show("Désigné d'abord un dossier");
            }
        }
    }
}
