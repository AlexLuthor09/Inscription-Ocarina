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



        public Inscription_Children()
        {
            InitializeComponent();

            nom = null;
            prenom = null;
            age = 0;
            N_national = 0;
            email = null;
            adresse = null;
            Allergies = null;
            Remarque = null;
            date = DateTime.Now;
        }
    

        private void Butt_Validating_Click(object sender, EventArgs e)
        {
           _Manager = new SQL_Manager();
            
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
            bool mc = CB_MC.Checked;
            if (TB_Allergies.Text != "")
                Allergies = TB_Allergies.Text;
            if (TB_Remarques.Text != "")
                Remarque = TB_Remarques.Text;
        
            _Manager.addChildren( nom, prenom,age,date,email,N_national,adresse, mc, Allergies,Remarque);

            this.Close();
        }

        private void Inscription_Children_Load(object sender, EventArgs e)
        {
            
            try
            {
                TB_Name.Text = nom;
                TB_Firstname.Text = prenom;
                NUD_Age.Value = age;
                DTP_Naissance.Value = date;
                TB_Email.Text = email;
                TB_N_National.Text = N_national.ToString();
                TB_Adresse.Text = adresse;
                TB_Allergies.Text = Allergies;
                TB_Remarques.Text = Remarque;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
