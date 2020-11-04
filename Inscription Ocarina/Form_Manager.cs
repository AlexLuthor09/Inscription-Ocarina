using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inscription_Ocarina
{
    class Form_Manager
    {
        public Form Current_form;

        private MainForm mainform ;
        private Inscription_Children inscription_children ;
        private FirstMove firstmove;

        public Form_Manager()
        {
            
        }
        public void Creation()
        {
            this.mainform = new MainForm();
            this.inscription_children = new Inscription_Children();
            this.firstmove = new FirstMove();
            this.Current_form = mainform;  
        }
        public void OpenMainF()
        {
            this.Current_form = this.mainform;
            Current_form.Show();
        }
        private void OpenInscription_Children_modif()
        {
            inscription_children.nom = Program.DP.nom;
            inscription_children.prenom = Program.DP.prenom;
            inscription_children.adresse = Program.DP.adresse;
            inscription_children.age = Program.DP.age;
            inscription_children.email = Program.DP.email;
            inscription_children.Allergies = Program.DP.Allergies;
            inscription_children.N_national= Program.DP.N_national;
            inscription_children.Remarque= Program.DP.Remarque;
            inscription_children.date = Program.DP.date;
            inscription_children.mc = Program.DP.mc;
            inscription_children.Fiche_Sante = Program.DP.Fiche_Sante;
            
        }
        private void OpenInscription_Children_Add()
        {

            Program.DP.nom  = "";
            Program.DP.prenom = "";
            Program.DP.adresse = "";
            Program.DP.age  = 0;
            Program.DP.email = "";
            Program.DP.Allergies = "";
            Program.DP.N_national = 0;
            Program.DP.Remarque  = "";
            Program.DP.date = DateTime.Now;
            Program.DP.mc = false;
            Program.DP.Fiche_Sante  = false;
           
            
        }
        public void OpenInscription_Children(bool modif)
        {

            if(modif)
            {
                OpenInscription_Children_modif();
                modif = false;
            }
            else
            {
                OpenInscription_Children_Add();
            }
            this.Current_form = inscription_children;
            Current_form.ShowDialog();
        }
        public void OpenFirstMove()
        {
            this.Current_form = this.firstmove;
            Current_form.ShowDialog();
        }
    }
}
