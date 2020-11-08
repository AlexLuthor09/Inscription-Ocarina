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
        internal SQL_Manager _Manager { get; set; }

        public string nom = null;
        public string prenom = null;
        public int age =0;
        public DateTime date =DateTime.Now.Date;       
        public string email =null;
        public int N_national=0;
        public string adresse =null;
        public bool mc = false;
        public bool Fiche_Sante = false;
        public string Allergies = null;
        public string Remarque = null;
        public int id;

        public bool modif;

        public DateTime jour_actuel= DateTime.Now.Date;
        public bool present = false;
        public bool payer = false;
        public int jour=0;
        public string xlFile = null;


    }

}
