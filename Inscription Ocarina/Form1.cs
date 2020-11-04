﻿using System;
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
        Donnees_Partagees ShareData = Program.DP;
        SQL_Manager _Manager;
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void Butt_Add_Children_Click(object sender, EventArgs e)
        {
            ShareData.modif = false;
            Program.DP.FM.OpenInscription_Children(ShareData.modif);
            
        }

        private void Butt_Validation_Click(object sender, EventArgs e)
        {
          
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'incriptionOcarinaDataSet.Enfant'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.enfantTableAdapter.Fill(this.incriptionOcarinaDataSet.Enfant);
            Program.DP.FM.OpenFirstMove();

        }
 
        private void Butt_Modifier_Participant_Click(object sender, EventArgs e)
        {
            try
            {
                
                //faire attention au string qui sont entre[] car ils font appelle au nom des collone dans la table

                ShareData.id = Convert.ToInt32(((DataRowView)(ComboBox_ListOfChildren.SelectedItem))["Id"].ToString().Trim()); // on récupère l'id
                ShareData.nom = Convert.ToString(((DataRowView)(ComboBox_ListOfChildren.SelectedItem))["Nom"].ToString().Trim());
                ShareData.prenom = Convert.ToString(((DataRowView)(ComboBox_ListOfChildren.SelectedItem))["Prenom"].ToString().Trim());
                ShareData.N_national = Convert.ToInt32(((DataRowView)(ComboBox_ListOfChildren.SelectedItem))["N_Nationam"].ToString().Trim());
                ShareData.Remarque = Convert.ToString(((DataRowView)(ComboBox_ListOfChildren.SelectedItem))["Remarque"].ToString().Trim());
                ShareData.mc = Convert.ToBoolean(((DataRowView)(ComboBox_ListOfChildren.SelectedItem))["MC"].ToString().Trim());
                ShareData.adresse = Convert.ToString(((DataRowView)(ComboBox_ListOfChildren.SelectedItem))["Adresse"].ToString().Trim());
                ShareData.Allergies = Convert.ToString(((DataRowView)(ComboBox_ListOfChildren.SelectedItem))["Allergie"].ToString().Trim());
                ShareData.age = Convert.ToInt32(((DataRowView)(ComboBox_ListOfChildren.SelectedItem))["Age"].ToString().Trim());
                ShareData.date = Convert.ToDateTime(((DataRowView)(ComboBox_ListOfChildren.SelectedItem))["Date_Naissance"].ToString().Trim());
                ShareData.email = Convert.ToString(((DataRowView)(ComboBox_ListOfChildren.SelectedItem))["Email"].ToString().Trim());
                ShareData.Fiche_Sante = Convert.ToBoolean(((DataRowView)(ComboBox_ListOfChildren.SelectedItem))["Fiche_Sante"].ToString().Trim());

                ShareData.FM.OpenInscription_Children(ShareData.modif = true);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Veuillez Rééssayer : ERRROR : " + ex.Message);
            }

        }

        private void But_Supp_Enfant_Click(object sender, EventArgs e)
        {
            _Manager = new SQL_Manager();
            _Manager.suppChild(Convert.ToInt32(((DataRowView)(ComboBox_ListOfChildren.SelectedItem))["Id"].ToString().Trim()));
        }

        

        private void BUT_Refresh_Click(object sender, EventArgs e)
        {
            _Manager = new SQL_Manager();
            _Manager.refresh(dataGridView1,ComboBox_ListOfChildren);
          
        }

        private void CB_Payer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            _Manager = new SQL_Manager();
            _Manager.refresh(dataGridView1, ComboBox_ListOfChildren);
        }
    }
}
