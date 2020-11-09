using System;
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
        public void addChildren(string nom, string prenom, int age, DateTime date, string email, int N_national, string adresse, bool mc, bool Fiche_Sante, string Allergies, string Remarque)
        {

            using (cnn = new SqlConnection(connetionString))
            {

                string Query = @"INSERT INTO Enfant  (Nom,Prenom,Email,N_Nationam,Date_Naissance,Age,MC,Fiche_Sante,Remarque,Allergie,Adresse,Prix,Nbr_Jour)" +
                "SELECT @NOM,@PRENOM,@EMAIL,@N_NATIONAM,@DATE_NAISSANCE,@AGE,@MC,@FICHE_SANTE,@REMARQUE,@ALLERGIE,@ADRESSE,@PRIX,@NBR_JOUR";


                SqlDateTime da = date;

                try
                {

                    cnn.Open();
                    SqlCommand addChild = new SqlCommand(Query, cnn);
                    addChild.Parameters.AddWithValue("@NOM", nom);
                    addChild.Parameters.AddWithValue("@PRENOM", prenom);
                    addChild.Parameters.AddWithValue("@EMAIL", email);
                    addChild.Parameters.AddWithValue("@N_NATIONAM", N_national);
                    addChild.Parameters.AddWithValue("@DATE_NAISSANCE", date);
                    addChild.Parameters.AddWithValue("@AGE", age);
                    addChild.Parameters.AddWithValue("@MC", mc);
                    addChild.Parameters.AddWithValue("@FICHE_SANTE", Fiche_Sante);
                    addChild.Parameters.AddWithValue("@REMARQUE", Remarque);                   
                    addChild.Parameters.AddWithValue("@ALLERGIE", Allergies);
                    addChild.Parameters.AddWithValue("@ADRESSE", adresse);
                    if (mc)
                        addChild.Parameters.AddWithValue("@PRIX", prixmc);

                    else
                        addChild.Parameters.AddWithValue("@PRIX", nprixmc);
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
        public void updateChildren(int ID, string nom, string prenom, int age, DateTime date, string email, int N_national, string adresse, bool mc, bool Fiche_Sante, string Allergies, string Remarque)
        {

            using (cnn = new SqlConnection(connetionString))
            {
                SqlDouble p;
                if (mc)
                    p = prixmc;

                else
                    p = nprixmc;

                SqlDateTime da = date;
                string Query = "UPDATE Enfant SET " +
                    "Nom ='" + nom +
                    "',Prenom ='" + prenom +
                    "',Email ='" + age +
                    "',N_Nationam ='" + N_national +
                    "',Date_Naissance ='" + da +
                    "',Age ='" + age +
                    "',MC ='" + mc +
                    "',Fiche_Sante ='" + Fiche_Sante +
                    "',Prix ='" + p.ToSqlDecimal() +
                    "',Remarque ='" + Remarque +
                    "',Allergie ='" + Allergies +
                    "',Adresse = '" + adresse +
                    "' WHERE Id =" + ID + ";";

                try
                {
                    cnn.Open();

                    SqlCommand modifchild = new SqlCommand(Query, cnn);
                    if (modifchild.ExecuteNonQuery() == 0)
                        throw new ApplicationException("y a r de modif !");
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
                    IncriptionOcarinaDataSet ds = new IncriptionOcarinaDataSet();
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
                string Query = "DELETE from Enfant where Id =" + Id;


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
            ShareData.adresse = Convert.ToString(((DataRowView)(ComboBox_ListOfChildren.SelectedItem))["Adresse"].ToString().Trim());
            ShareData.Allergies = Convert.ToString(((DataRowView)(ComboBox_ListOfChildren.SelectedItem))["Allergie"].ToString().Trim());
            ShareData.age = Convert.ToInt32(((DataRowView)(ComboBox_ListOfChildren.SelectedItem))["Age"].ToString().Trim());
            ShareData.date = Convert.ToDateTime(((DataRowView)(ComboBox_ListOfChildren.SelectedItem))["Date_Naissance"].ToString().Trim());
            ShareData.email = Convert.ToString(((DataRowView)(ComboBox_ListOfChildren.SelectedItem))["Email"].ToString().Trim());
            ShareData.Fiche_Sante = Convert.ToBoolean(((DataRowView)(ComboBox_ListOfChildren.SelectedItem))["Fiche_Sante"].ToString().Trim());

            ShareData.modif = true;
        }
        public void ExportDataSetToExcel(string xlFile) //en dévelloppement
        {
            
            using (cnn = new SqlConnection(connetionString))
            {
                string Query = "SELECT * from Enfant";
                SqlDataAdapter da = new SqlDataAdapter(Query, cnn);
                IncriptionOcarinaDataSet ds = new IncriptionOcarinaDataSet();
                da.Fill(ds, "Enfant");
                DataSet dp = ds;
                //Creae an Excel application instance
                Excel.Application excelApp = new Excel.Application();

                //Create an Excel workbook instance and open it from the predefined location
                Excel.Workbook excelWorkBook = excelApp.Workbooks.Open(xlFile);

                foreach (DataTable table in dp.Tables)
                {
                    //Add a new worksheet to workbook with the Datatable name
                    Excel.Worksheet excelWorkSheet = excelWorkBook.Sheets.Add();

                    excelWorkSheet.Name = table.TableName;

                    for (int i = 1; i < table.Columns.Count + 1; i++)
                    {
                        excelWorkSheet.Cells[1, i] = table.Columns[i - 1].ColumnName;
                    }

                    for (int j = 0; j < table.Rows.Count; j++)
                    {
                        for (int k = 0; k < table.Columns.Count; k++)
                        {
                            excelWorkSheet.Cells[j + 2, k + 1] = table.Rows[j].ItemArray[k].ToString();
                        }
                    }
                }
                excelWorkBook.Save();
                excelWorkBook.Close();
                excelApp.Quit();
            }
        }

    }
}
