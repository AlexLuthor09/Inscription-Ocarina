using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inscription_Ocarina
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void Butt_Add_Children_Click(object sender, EventArgs e)
        {
            Inscription_Children IC = new Inscription_Children();
            IC.Show();

        }

        private void Butt_Validation_Click(object sender, EventArgs e)
        {
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'incriptionOcarinaDataSet.Enfant'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.enfantTableAdapter.Fill(this.incriptionOcarinaDataSet.Enfant);

        }

        private void ComboBox_ListOfChildren_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
