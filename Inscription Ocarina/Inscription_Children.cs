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
        public Inscription_Children()
        {
            InitializeComponent();
        }

        private void Butt_Validating_Click(object sender, EventArgs e)
        {
            SQL_Manager _Manager = new SQL_Manager();
            string nom = null;
            string prenom = null;
            int age=0;
            int N_national = 0;
            string email = null;
            string adresse = null;
            string Allergies = null;
            string Remarque = null;

            if (TB_Name.Text != "")
                nom = TB_Name.Text;
            if (TB_Firstname.Text != "")
                prenom = TB_Firstname.Text;
            if (NUD_Age.Value != 0)
                age = Convert.ToInt32(NUD_Age.Value);
            DateTime date = DTP_Naissance.Value;
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
    }
}
