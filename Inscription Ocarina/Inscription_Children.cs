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
        
        SQL_Manager _Manager;

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
        public bool Fiche_Sante;


        public Inscription_Children()
        {
            InitializeComponent();
   
        }
    

        private void Butt_Validating_Click(object sender, EventArgs e)
        {
           _Manager = new SQL_Manager();
            
           
            if (Program.DP.modif)
            {
                int id = Program.DP.id;

               
                nom = TB_Name.Text.Trim();
                prenom = TB_Firstname.Text.Trim();              
                age = Convert.ToInt32(NUD_Age.Value);
                if (date.Date == DateTime.Now.Date)
                    date = DateTime.MinValue;
                else
                date = DTP_Naissance.Value;               
                email = TB_Email.Text.Trim();
                if (TB_N_National.Text.Trim() == "")
                    N_national = 101;
                else
                N_national = Convert.ToInt32(TB_N_National.Text.Trim());             
                adresse = TB_Adresse.Text.Trim();
                mc = CB_MC.Checked;
                Fiche_Sante = CB_Fiche_Sante.Checked;
                Allergies = TB_Allergies.Text.Trim();                
                Remarque = TB_Remarques.Text.Trim();
               

                _Manager.updateChildren(id, nom, prenom, age, date, email, N_national, adresse, mc,Fiche_Sante, Allergies, Remarque);
            }
            else
            {
                nom = TB_Name.Text.Trim();
                prenom = TB_Firstname.Text.Trim();
                age = Convert.ToInt32(NUD_Age.Value);
                if (date.Date == DateTime.Now.Date)
                    date = DateTime.MinValue;
                else
                date = DTP_Naissance.Value;
                email = TB_Email.Text.Trim();
                if (TB_N_National.Text.Trim() == "")
                    N_national = 101;
                else
                N_national = Convert.ToInt32(TB_N_National.Text.Trim());
                adresse = TB_Adresse.Text.Trim();
                mc = CB_MC.Checked;
                Fiche_Sante = CB_Fiche_Sante.Checked;
                Allergies = TB_Allergies.Text.Trim();
                Remarque = TB_Remarques.Text.Trim();

                _Manager.addChildren(nom, prenom, age, date, email, N_national, adresse, mc,Fiche_Sante, Allergies, Remarque);
            }
           

            this.Close();
        }

        private void Inscription_Children_Load(object sender, EventArgs e)
        {

            try
            {
                TB_Name.Text = Program.DP.nom;
                TB_Firstname.Text = Program.DP.prenom;
                TB_Adresse.Text = Program.DP.adresse;
                NUD_Age.Value = Program.DP.age;
                TB_Email.Text = Program.DP.email;
                TB_Allergies.Text = Program.DP.Allergies;
                TB_N_National.Text = Program.DP.N_national.ToString();
                TB_Remarques.Text = Program.DP.Remarque;
                DTP_Naissance.Value = Program.DP.date;
                CB_MC.Checked = Program.DP.mc;
                CB_Fiche_Sante.Checked = Program.DP.Fiche_Sante;
                Program.DP.modif = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
