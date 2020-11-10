using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inscription_Ocarina
{
    public partial class Inscription_Children : Form
    {
        
        private SQL_Manager _Manager = Program.DP._Manager;
        private Donnees_Partagees ShareData = Program.DP;

        public string nom ;
        public string prenom ;
        public int age ;
        public int N_national ;
        public string email ;
        public string adresse;
        public string Allergies;
        public string Remarque ;
        public DateTime date;
        public bool mc;
        public bool bim;
        public bool Fiche_Sante;


        public Inscription_Children()
        {
            InitializeComponent();
   
        }
    

        private void Butt_Validating_Click(object sender, EventArgs e)
        {

           
            if (ShareData.modif)
            {
                int id = ShareData.id;

               
                nom = TB_Name.Text.Trim();
                prenom = TB_Firstname.Text.Trim();              
                age = Convert.ToInt32(NUD_Age.Value);
                if (date.Date == DateTime.Now.Date)
                    date = DateTime.Now;
                else
                date = DTP_Naissance.Value;               
                email = TB_Email.Text.Trim();
                if (TB_N_National.Text.Trim() == "")
                    N_national = 101;
                else
                N_national = Convert.ToInt32(TB_N_National.Text.Trim());             
                adresse = TB_Adresse.Text.Trim();
                mc = CB_MC.Checked;
                bim = CB_BIM.Checked;
                Fiche_Sante = CB_Fiche_Sante.Checked;
                Allergies = TB_Allergies.Text.Trim();                
                Remarque = TB_Remarques.Text.Trim();
               

                _Manager.updateChildren(id, nom, prenom, age, date, email, N_national, adresse, mc,bim,Fiche_Sante, Allergies, Remarque);
            }
            else
            {
                nom = TB_Name.Text.Trim();
                prenom = TB_Firstname.Text.Trim();
                age = Convert.ToInt32(NUD_Age.Value);
                if (date.Date == DateTime.Now.Date)
                    date = DateTime.Now;
                else
                date = DTP_Naissance.Value;
                email = TB_Email.Text.Trim();
                if (TB_N_National.Text.Trim() == "")
                    N_national = 101;
                else
                N_national = Convert.ToInt32(TB_N_National.Text.Trim());
                adresse = TB_Adresse.Text.Trim();
                mc = CB_MC.Checked;
                bim = CB_BIM.Checked;
                Fiche_Sante = CB_Fiche_Sante.Checked;
                Allergies = TB_Allergies.Text.Trim();
                Remarque = TB_Remarques.Text.Trim();

                _Manager.addChildren(nom, prenom, age, date, email, N_national, adresse, mc,bim,Fiche_Sante, Allergies, Remarque);
            }

            ShareData.modif = false;
            this.Close();
        }

        private void Inscription_Children_Load(object sender, EventArgs e)
        {

            try
            {
                TB_Name.Text = ShareData.nom;
                TB_Firstname.Text = ShareData.prenom;
                TB_Adresse.Text = ShareData.adresse;
                NUD_Age.Value = ShareData.age;
                TB_Email.Text = ShareData.email;
                TB_Allergies.Text = ShareData.Allergies;
                TB_N_National.Text = ShareData.N_national.ToString();
                TB_Remarques.Text = ShareData.Remarque;
                DTP_Naissance.Value = ShareData.date;
                CB_MC.Checked = ShareData.mc;
                CB_BIM.Checked = ShareData.bim;
                CB_Fiche_Sante.Checked = ShareData.Fiche_Sante;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void TB_N_National_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )    
            {
                e.Handled = true;
            }
        }

        private void TB_Remarques_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void TB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

       
    }
}
