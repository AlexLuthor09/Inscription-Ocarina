using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inscription_Ocarina
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        static public Donnees_Partagees DP = new Donnees_Partagees();
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form_Manager form_manager = new Form_Manager();

            DP.FM = form_manager;
            DP.FM.Creation();

            Application.Run(DP.FM.Current_form);
            
        }
    }
}
