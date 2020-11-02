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
    public partial class MainForm : Form
    {
        Donnees_Partagees ShareData;
        
        public static int DATA_id_current;
        public bool Modify = false;

        public MainForm()
        {
            InitializeComponent();
            
        }

        private void Butt_Add_Children_Click(object sender, EventArgs e)
        {
            Program.DP.FM.OpenInscription_Children(false);                     
        }

        private void Butt_Validation_Click(object sender, EventArgs e)
        {
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'incriptionOcarinaDataSet.Enfant'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.enfantTableAdapter.Fill(this.incriptionOcarinaDataSet.Enfant);
            Program.DP.FM.OpenFirstMove();

        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        
    
        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void Butt_Modifier_Participant_Click(object sender, EventArgs e)
        {
            ShareData = Program.DP;

            //ShareData.nom = ;
            //ShareData.prenom = ;
            //ShareData.N_national =;
            //ShareData.Remarque = ;
            //ShareData.mc = ;
            //ShareData.adresse = ;
            //ShareData.Allergies = ;
            //ShareData.age =;
            //ShareData.date = ;
            //ShareData.email =;
            
            ShareData.FM.OpenInscription_Children(true);

        }

        private void But_Supp_Enfant_Click(object sender, EventArgs e)
        {

        }
    }
}
