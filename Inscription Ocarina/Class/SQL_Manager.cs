﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
using Excel = Microsoft.Office.Interop.Excel;
using System.Text;
using System.Threading.Tasks;
using System.Configuration.Install;
using System.Configuration;
using System.Windows.Forms;
using System.IO;

namespace Inscription_Ocarina
{
    class SQL_Manager
    {
        private Donnees_Partagees ShareData = Program.DP;
        SqlDouble prixmc = 1.5;
        SqlDouble nprixmc = 6.5;
        SqlDouble nprixBIM= 1;
        string TA_bleu = "Bleu 9 12";
        string TA_vert = "Vert 6 9";
        string TA_jaune = "Jaune 3 6";

        SqlConnection cnn;
        //attention ["  "] voir name du connectionString dans App.config 
        //activer Sql server 2012 Express dans les propriété dans l'app -> publish -> composant requis 
        //verif si .mdf inclu dans l'app
        string connetionString = ConfigurationManager.ConnectionStrings["IncriptionOcarinaConnectionString"].ConnectionString; 
        
        public SQL_Manager() //test de connection
        {
            using (cnn = new SqlConnection(connetionString))
            {

                try
                {
                    cnn.Open();
                    //MessageBox.Show("Lancement application");                
                    cnn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("On a pas pu ce connecter a la database ! \n " + ex);
                }
            }
        }
        public void addChildren(string nom, string prenom, int age, DateTime date, string email, int N_national, string adresse, bool mc,bool bim, bool Fiche_Sante, string Allergies, string Remarque)
        {

            using (cnn = new SqlConnection(connetionString))
            {

                string Query = @"INSERT INTO Enfant  (Nom,Prenom,Email,N_Nationam,Date_Naissance,Age,Tranche_age,MC,BIM,Fiche_Sante,Remarque,Allergie,Adresse,Prix,Nbr_Jour)" +
                "SELECT @NOM,@PRENOM,@EMAIL,@N_NATIONAM,@DATE_NAISSANCE,@AGE,@TRANCHE_AGE,@MC,@BIM,@FICHE_SANTE,@REMARQUE,@ALLERGIE,@ADRESSE,@PRIX,@NBR_JOUR";


                SqlDateTime da = date;
                
                try
                {

                    cnn.Open();
                    SqlCommand addChild = new SqlCommand(Query, cnn);                    
                    addChild.Parameters.AddWithValue("@NOM", nom);
                    addChild.Parameters.AddWithValue("@PRENOM", prenom);
                    addChild.Parameters.AddWithValue("@EMAIL", email);
                    addChild.Parameters.AddWithValue("@N_NATIONAM", N_national);
                    addChild.Parameters.AddWithValue("@DATE_NAISSANCE", da);
                    addChild.Parameters.AddWithValue("@AGE", age);
                    if(age >=9)
                        addChild.Parameters.AddWithValue("@TRANCHE_AGE", TA_bleu);
                    if(age < 9 && age >=6)
                        addChild.Parameters.AddWithValue("@TRANCHE_AGE",TA_vert);
                    if(age<6)
                        addChild.Parameters.AddWithValue("@TRANCHE_AGE", TA_jaune);
                    addChild.Parameters.AddWithValue("@MC", mc);
                    addChild.Parameters.AddWithValue("@BIM", bim);
                    addChild.Parameters.AddWithValue("@FICHE_SANTE", Fiche_Sante);
                    addChild.Parameters.AddWithValue("@REMARQUE", Remarque);                   
                    addChild.Parameters.AddWithValue("@ALLERGIE", Allergies);
                    addChild.Parameters.AddWithValue("@ADRESSE", adresse);

                    if (mc && !bim)
                        addChild.Parameters.AddWithValue("@PRIX", prixmc.ToSqlMoney());

                    else if(bim)
                        addChild.Parameters.AddWithValue("@PRIX", nprixBIM.ToSqlMoney());
                    else if(!bim && !mc)
                        addChild.Parameters.AddWithValue("@PRIX", nprixmc.ToSqlMoney());

                    addChild.Parameters.AddWithValue("@NBR_JOUR", 0);
                    if (addChild.ExecuteNonQuery() == 0)
                        throw new ApplicationException("Aucune ligne insérée, vérifiez les paramètres!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {

                    cnn.Close();
                }
            }
        }
        public void updateChildren(int ID, string nom, string prenom, int age, DateTime date, string email, int N_national, string adresse, bool mc,bool bim, bool Fiche_Sante, string Allergies, string Remarque)
        {
            using (cnn = new SqlConnection(connetionString))
            {

                string Query = @"UPDATE Enfant  SET Nom = @NOM,Prenom= @PRENOM,Email= @EMAIL,N_Nationam = @N_NATIONAM,Date_Naissance = @DATE_NAISSANCE,Age = @AGE,Tranche_age= @TRANCHE_AGE,
                   MC =@MC,BIM= @BIM,Fiche_Sante =@FICHE_SANTE,Remarque = @REMARQUE,Allergie=@ALLERGIE,Adresse=@ADRESSE,Prix=@PRIX" +
                " Where ID = '"+ID+"';";


                SqlDateTime da = date;

                try
                {

                    cnn.Open();
                    SqlCommand addChild = new SqlCommand(Query, cnn);
                    addChild.Parameters.AddWithValue("@NOM", nom);
                    addChild.Parameters.AddWithValue("@PRENOM", prenom);
                    addChild.Parameters.AddWithValue("@EMAIL", email);
                    addChild.Parameters.AddWithValue("@N_NATIONAM", N_national);
                    addChild.Parameters.AddWithValue("@DATE_NAISSANCE", da);
                    addChild.Parameters.AddWithValue("@AGE", age);
                    if (age >= 9)
                        addChild.Parameters.AddWithValue("@TRANCHE_AGE", TA_bleu);
                    if (age < 9 && age >= 6)
                        addChild.Parameters.AddWithValue("@TRANCHE_AGE", TA_vert);
                    if (age < 6)
                        addChild.Parameters.AddWithValue("@TRANCHE_AGE", TA_jaune);
                    addChild.Parameters.AddWithValue("@MC", mc);
                    addChild.Parameters.AddWithValue("@BIM", bim);
                    addChild.Parameters.AddWithValue("@FICHE_SANTE", Fiche_Sante);
                    addChild.Parameters.AddWithValue("@REMARQUE", Remarque);
                    addChild.Parameters.AddWithValue("@ALLERGIE", Allergies);
                    addChild.Parameters.AddWithValue("@ADRESSE", adresse);

                    if (mc && !bim)
                        addChild.Parameters.AddWithValue("@PRIX", prixmc.ToSqlMoney());

                    else if (bim)
                        addChild.Parameters.AddWithValue("@PRIX", nprixBIM.ToSqlMoney());
                    else if (!bim && !mc)
                        addChild.Parameters.AddWithValue("@PRIX", nprixmc.ToSqlMoney());

                    
                    if (addChild.ExecuteNonQuery() == 0)
                        throw new ApplicationException("Aucune ligne insérée, vérifiez les paramètres!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {

                    cnn.Close();
                }
            }
             
        }
        public void child_payer(ComboBox combobox,bool here)
        {
            using (cnn = new SqlConnection(connetionString))
            {
                int id = Convert.ToInt32(((DataRowView)(combobox.SelectedItem))["Id"].ToString().Trim());
                int jour = ShareData.jour;
                string Query = "UPDATE Enfant SET " + "jour"+ jour+" ='" + here+ "' WHERE Id =" + id + ";";
                try
                {
                    
                    cnn.Open();
                    SqlCommand set = new SqlCommand(Query, cnn);
                    
                    if (set.ExecuteNonQuery() == 0)
                        throw new ApplicationException("y a r de modif !");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("child_payer Ca marche pas connard car :  " + ex.Message);
                }
                finally
                {
                    this.nbrjour(combobox, here);
                    cnn.Close();
                }
            }
        }

        public void nbrjour(ComboBox combobox,bool here)
        {
            using (cnn = new SqlConnection(connetionString))
            {
                string Query;
                int j = Convert.ToInt32(((DataRowView)(combobox.SelectedItem))["Nbr_Jour"].ToString().Trim());
                int plus = j+ 1;
                int moins = j - 1;
                int id = Convert.ToInt32(((DataRowView)(combobox.SelectedItem))["Id"].ToString().Trim());
                if (here)
                Query = "UPDATE Enfant SET Nbr_Jour ='" + plus + "' WHERE Id =" + id + ";";
                else
                  Query = "UPDATE Enfant SET Nbr_Jour ='" + moins + "' WHERE Id =" + id + ";";

                try
                {
                    cnn.Open();
                    SqlCommand set = new SqlCommand(Query, cnn);
                    if (set.ExecuteNonQuery() == 0)
                        throw new ApplicationException("y a r de modif !");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("nbr jour Ca marche pas connard car :  " + ex.Message);
                }
                finally
                {

                    cnn.Close();
                }
            }
        }
        public void refresh(DataGridView datagridview, ComboBox combobox)
        {

            using (cnn = new SqlConnection(connetionString))
            {
                string Query = "SELECT * from Enfant";

                try
                {
                    cnn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(Query, cnn);
                    IncriptionOcarinaDataSet1 ds = new IncriptionOcarinaDataSet1();
                    da.Fill(ds, "Enfant");

                    combobox.DataBindings.Clear();
                    combobox.DataSource = null;
                    combobox.DataSource = ds.Enfant; //attention c'est pour savoir ou aller chercher le .Enfant pour acceder a la table Enfant
                    combobox.DisplayMember = "Nom";
                    combobox.ValueMember = "Id";

                    datagridview.DataSource = ds.Enfant;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ca marche pas connard car :  " + ex.Message);
                }
                finally
                {

                    cnn.Close();
                }
            }
        }
        public void ClearDataBase()
        {
            using (cnn = new SqlConnection(connetionString))
            {
                string Query = "TRUNCATE TABLE Enfant";


                try
                {
                    cnn.Open();
                    SqlCommand clear = new SqlCommand(Query, cnn);
                    if (clear.ExecuteNonQuery() == 0)
                        throw new ApplicationException("y a r de modif !");
                    else MessageBox.Show("Suppression confirmed");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ca marche pas connard car :  " + ex.Message);
                }
                finally
                {

                    cnn.Close();
                }

            }
        }
        public void suppChild(int Id)
        {
            using (cnn = new SqlConnection(connetionString))
            {
                string Query = "DELETE from Enfant where ID =" + Id;


                try
                {
                    cnn.Open();
                    SqlCommand clear = new SqlCommand(Query, cnn);
                    if (clear.ExecuteNonQuery() == 0)
                        throw new ApplicationException("y a r de modif !");
                    else MessageBox.Show("Suppression de l'Id : " + Id + " confirmed");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ca marche pas connard car :  " + ex.Message);
                }
                finally
                {

                    cnn.Close();
                }

            }
        }
        public void chargementDATA(ComboBox ComboBox_ListOfChildren)
        {
            ShareData.id = Convert.ToInt32(((DataRowView)(ComboBox_ListOfChildren.SelectedItem))["Id"].ToString().Trim()); // on récupère l'id
            ShareData.nom = Convert.ToString(((DataRowView)(ComboBox_ListOfChildren.SelectedItem))["Nom"].ToString().Trim());
            ShareData.prenom = Convert.ToString(((DataRowView)(ComboBox_ListOfChildren.SelectedItem))["Prenom"].ToString().Trim());
            ShareData.N_national = Convert.ToInt32(((DataRowView)(ComboBox_ListOfChildren.SelectedItem))["N_Nationam"].ToString().Trim());
            ShareData.Remarque = Convert.ToString(((DataRowView)(ComboBox_ListOfChildren.SelectedItem))["Remarque"].ToString().Trim());
            ShareData.mc = Convert.ToBoolean(((DataRowView)(ComboBox_ListOfChildren.SelectedItem))["MC"].ToString().Trim());
            ShareData.bim = Convert.ToBoolean(((DataRowView)(ComboBox_ListOfChildren.SelectedItem))["BIM"].ToString().Trim());
            ShareData.adresse = Convert.ToString(((DataRowView)(ComboBox_ListOfChildren.SelectedItem))["Adresse"].ToString().Trim());
            ShareData.Allergies = Convert.ToString(((DataRowView)(ComboBox_ListOfChildren.SelectedItem))["Allergie"].ToString().Trim());
            ShareData.age = Convert.ToInt32(((DataRowView)(ComboBox_ListOfChildren.SelectedItem))["Age"].ToString().Trim());
            ShareData.date = Convert.ToDateTime(((DataRowView)(ComboBox_ListOfChildren.SelectedItem))["Date_Naissance"].ToString().Trim());
            ShareData.email = Convert.ToString(((DataRowView)(ComboBox_ListOfChildren.SelectedItem))["Email"].ToString().Trim());
            ShareData.Fiche_Sante = Convert.ToBoolean(((DataRowView)(ComboBox_ListOfChildren.SelectedItem))["Fiche_Sante"].ToString().Trim());

            ShareData.modif = true;
        }
        
        private void ExportToExcel(string nom,string Query)
        {
            Exel_Manager exel_ = new Exel_Manager();
            using (cnn = new SqlConnection(connetionString))
            {
                try
                {
                    cnn.Open();
                    SqlDataAdapter export = new SqlDataAdapter(Query, cnn);
                    DataSet ds = new DataSet();
                    export.Fill(ds);
                    ShareData.xlFile = nom;
                    exel_.HelloWorldExcel(ds);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("nbr jour Ca marche pas connard car :  " + ex.Message);
                }
                finally
                {

                    cnn.Close();
                }
            }
        }
        public void ExportRemarqueToExcel(string nom)
        {
            string Query = "SELECT Nom,Prenom,Remarque,Allergie FROM Enfant where Tranche_age ='";

            try
            {
                string Query1 = Query + TA_bleu + "';";
                this.ExportToExcel(nom + "_" + TA_bleu, Query1);
                string Query2 = Query + TA_vert + "';";
                this.ExportToExcel(nom + "_" + TA_vert, Query2);
                string Query3 = Query + TA_jaune + "';";
                this.ExportToExcel(nom + "_" + TA_jaune, Query3);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ca marche pas connard car :  " + ex.Message);
            }
           
        }
        public void ExportEnfantToExcel(string nom)
        {
            string Query = "SELECT Nom,Prenom,Tranche_age,Age,Date_Naissance,Email,N_Nationam,Adresse,MC,BIM,Prix,Nbr_jour,jour1,jour2,jour3,jour4,jour5 FROM Enfant";

            try
            {
                this.ExportToExcel(nom, Query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ca marche pas connard car :  " + ex.Message);
            }
        }
    }
}
