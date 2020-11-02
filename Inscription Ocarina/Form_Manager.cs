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
        public void OpenInscription_Children(bool modify)
        {
            
            if (modify)
            {
                this.inscription_children.nom = Program.DP.nom;
                this.inscription_children.prenom = Program.DP.prenom;
                this.inscription_children.adresse = Program.DP.adresse;
                this.inscription_children.age = Program.DP.age;
                this.inscription_children.email = Program.DP.email;
                this.inscription_children.Allergies = Program.DP.Allergies;
                this.inscription_children.N_national= Program.DP.N_national;
                this.inscription_children.Remarque= Program.DP.Remarque;
                this.inscription_children.date = Program.DP.date;
                this.inscription_children.mc = Program.DP.mc;


            }
            this.Current_form = this.inscription_children;
            Current_form.ShowDialog();
        }
        public void OpenFirstMove()
        {
            this.Current_form = this.firstmove;
            Current_form.ShowDialog();
        }
    }
}
