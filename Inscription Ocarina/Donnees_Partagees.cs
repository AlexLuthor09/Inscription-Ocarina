using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inscription_Ocarina
{
    class Donnees_Partagees
    {
        internal Form_Manager FM { get; set; }
        public string nom = null;
        public string prenom = null;
        public int age =0;
        public DateTime date =DateTime.Now;
        public string email =null;
        public int N_national=0;
        public string adresse =null;
        public bool mc = false;
        public bool Fiche_Sante = false;
        public string Allergies = null;
        public string Remarque = null;
        public bool modif;
        public int id;
        
    }

}
