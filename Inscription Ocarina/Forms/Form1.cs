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
        private Donnees_Partagees ShareData = Program.DP;
        private Form_Manager form_manager = Program.DP.FM;
        private SQL_Manager _Manager=Program.DP._Manager;
        
        private void date_change()
        {
            switch (dateTimePicker1.Value.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    {
                        ShareData.jour = 1;
                        break;
                    }
                case DayOfWeek.Tuesday:
                    {
                        ShareData.jour = 2;
                        break;
                    }
                case DayOfWeek.Wednesday:
                    {
                        ShareData.jour = 3;
                        break;
                    }
                case DayOfWeek.Thursday:
                    {
                        ShareData.jour = 4;
                        break;
                    }
                case DayOfWeek.Friday:
                    {
                        ShareData.jour = 5;
                        break;
                    }
                default:
                    {
                        ShareData.jour = 1;
                        break;
                    }


            }//initialise le jour qu'on est dans la semaine
        }

        public MainForm()
        {
            InitializeComponent();
            
        }
        private void MainForm_Load(object sender, EventArgs e)
        {          
            this.enfantTableAdapter1.Fill(this.incriptionOcarinaDataSet1.Enfant);
            form_manager.OpenFirstMove();
            date_change();
        }
        private void Butt_Add_Children_Click(object sender, EventArgs e)
        {
            ShareData.modif = false;
            form_manager.OpenInscription_Children();           
        }

        private void Butt_Modifier_Participant_Click(object sender, EventArgs e)
        {
            try
            {

                //faire attention au string qui sont entre[] car ils font appelle au nom des collone dans la table
                _Manager.chargementDATA(ComboBox_ListOfChildren);
                form_manager.OpenInscription_Children();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Veuillez Rééssayer : ERRROR : " + ex.Message);
            }

        }

        private void But_Supp_Enfant_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Es-tu sûr de vouloir supprimer cet enfant ? ", "Supprimer", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                _Manager.suppChild(Convert.ToInt32(((DataRowView)(ComboBox_ListOfChildren.SelectedItem))["Id"].ToString().Trim()));
            }
        }

       
        private void BUT_Refresh_Click(object sender, EventArgs e)
        {            
            _Manager.refresh(dataGridView1,ComboBox_ListOfChildren);         
        }

        

        private void MainForm_Activated(object sender, EventArgs e)
        {
            _Manager.refresh(dataGridView1, ComboBox_ListOfChildren);
        }

        private void BUT_Export_to_excel_Click(object sender, EventArgs e)
        {
            _Manager.ExportToExcel("test");
        }

        private void But_apayer_Click(object sender, EventArgs e)
        {
            if(Convert.ToBoolean(((DataRowView)(ComboBox_ListOfChildren.SelectedItem))["jour"+ShareData.jour].ToString().Trim()))
            _Manager.child_payer(ComboBox_ListOfChildren, false);
            else _Manager.child_payer(ComboBox_ListOfChildren, true);
            _Manager.refresh(dataGridView1, ComboBox_ListOfChildren);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            date_change();
        }

        private void BUT_Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
