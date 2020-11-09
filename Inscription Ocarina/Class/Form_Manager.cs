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

        private Donnees_Partagees ShareData = Program.DP;
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
            inscription_children.nom = ShareData.nom;
            inscription_children.prenom = ShareData.prenom;
            inscription_children.adresse = ShareData.adresse;
            inscription_children.age = ShareData.age;
            inscription_children.email = ShareData.email;
            inscription_children.Allergies = ShareData.Allergies;
            inscription_children.N_national= ShareData.N_national;
            inscription_children.Remarque= ShareData.Remarque;
            inscription_children.date = ShareData.date;
            inscription_children.mc = ShareData.mc;
            inscription_children.Fiche_Sante = ShareData.Fiche_Sante;
            
        }
        private void OpenInscription_Children_Add()
        {

            ShareData.nom  = "";
            ShareData.prenom = "";
            ShareData.adresse = "";
            ShareData.age = 0;
            ShareData.email = "";
            ShareData.Allergies = "";
            ShareData.N_national = 0;
            ShareData.Remarque  = "";
            ShareData.date = DateTime.Now;
            ShareData.mc = false;
            ShareData.Fiche_Sante = false;
           
            
        }
        public void OpenInscription_Children()
        {

            if(ShareData.modif)
            {
                OpenInscription_Children_modif();    
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
