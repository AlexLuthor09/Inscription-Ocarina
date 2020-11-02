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
        public string nom;
        public string prenom;
        public int age;
        public DateTime date;
        public string email;
        public int N_national;
        public string adresse;
        public bool mc;
        public string Allergies;
        public string Remarque;
        public bool modif;
        public int id;
    }

}
