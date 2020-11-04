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

                if (TB_Name.Text != "")
                    nom = TB_Name.Text;
                if (TB_Firstname.Text != "")
                    prenom = TB_Firstname.Text;
                if (NUD_Age.Value != 0)
                    age = Convert.ToInt32(NUD_Age.Value);
                date = DTP_Naissance.Value;
                if (TB_Email.Text != "")
                    email = TB_Email.Text;
                if (TB_N_National.Text != "")
                    N_national = Convert.ToInt32(TB_N_National.Text);
                if (TB_Adresse.Text != "")
                    adresse = TB_Adresse.Text;
                mc = CB_MC.Checked;
                Fiche_Sante = CB_Fiche_Sante.Checked;
                if (TB_Allergies.Text != "")
                    Allergies = TB_Allergies.Text;
                if (TB_Remarques.Text != "")
                    Remarque = TB_Remarques.Text;
                _Manager.updateChildren(id, nom, prenom, age, date, email, N_national, adresse, mc,Fiche_Sante, Allergies, Remarque);
            }
            else
            {
                if (TB_Name.Text != "")
                    nom = TB_Name.Text;
                if (TB_Firstname.Text != "")
                    prenom = TB_Firstname.Text;
                if (NUD_Age.Value != 0)
                    age = Convert.ToInt32(NUD_Age.Value);
                date = DTP_Naissance.Value;
                if (TB_Email.Text != "")
                    email = TB_Email.Text;
                if (TB_N_National.Text != "")
                    N_national = Convert.ToInt32(TB_N_National.Text);
                if (TB_Adresse.Text != "")
                    adresse = TB_Adresse.Text;
                mc = CB_MC.Checked;
                Fiche_Sante = CB_Fiche_Sante.Checked;
                if (TB_Allergies.Text != "")
                    Allergies = TB_Allergies.Text;
                if (TB_Remarques.Text != "")
                    Remarque = TB_Remarques.Text;
                _Manager.addChildren(nom, prenom, age, date, email, N_national, adresse, mc,Fiche_Sante, Allergies, Remarque);
            }
           

            this.Close();
        }

        private void Inscription_Children_Load(object sender, EventArgs e)
        {
            
            if (Program.DP.modif)
            {
                try
                {
                    TB_Name.Text = Program.DP.nom;
                    TB_Firstname.Text= Program.DP.prenom;
                    TB_Adresse.Text = Program.DP.adresse;
                    NUD_Age.Value = Program.DP.age;
                    TB_Email.Text = Program.DP.email;
                    TB_Allergies.Text = Program.DP.Allergies;
                    TB_N_National.Text = Program.DP.N_national.ToString();
                    TB_Remarques.Text = Program.DP.Remarque;
                    DTP_Naissance.Value = Program.DP.date;
                    CB_MC.Checked = Program.DP.mc;
                    CB_Fiche_Sante.Checked = Program.DP.Fiche_Sante;   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
