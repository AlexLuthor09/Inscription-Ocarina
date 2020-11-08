using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
using Excel = Microsoft.Office.Interop.Excel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Inscription_Ocarina
{
    class SQL_Manager
    {
        private Donnees_Partagees ShareData = Program.DP;
        SqlDouble prixmc = 1.5;
        SqlDouble nprixmc = 6.5;

        private string connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\Visual Studio\Inscription Ocarina\Inscription Ocarina\IncriptionOcarina.mdf; Integrated Security = True; Connect Timeout = 30";
        SqlConnection cnn;
       
        public SQL_Manager() //test de connection
        {

            cnn = new SqlConnection(connetionString);

            try
            {
                cnn.Open();
                //MessageBox.Show("Connection Open ! ");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("On a pas pu ce connecter a la database ! \n " + ex);
            }
        }
        public void addChildren(string nom, string prenom, int age, DateTime date, string email, int N_national, string adresse, bool mc, bool Fiche_Sante, string Allergies, string Remarque)
        {

            cnn = new SqlConnection(connetionString);

            string Query = @"INSERT INTO Enfant  (Nom,Prenom,Email,N_Nationam,Date_Naissance,Age,MC,Fiche_Sante,Remarque,Allergie,Adresse,Prix)" +
                "SELECT @NOM,@PRENOM,@EMAIL,@N_NATIONAM,@DATE_NAISSANCE,@AGE,@MC,@FICHE_SANTE,@REMARQUE,@ALLERGIE,@ADRESSE,@PRIX";
            

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
                addChild.Parameters.AddWithValue("@MC", mc);               
                addChild.Parameters.AddWithValue("@FICHE_SANTE", Fiche_Sante);
                addChild.Parameters.AddWithValue("@REMARQUE", Remarque);
                addChild.Parameters.AddWithValue("@ALLERGIE", Allergies);
                addChild.Parameters.AddWithValue("@ADRESSE", adresse);
                if (mc)
                    addChild.Parameters.AddWithValue("@PRIX", prixmc);

                else
                    addChild.Parameters.AddWithValue("@PRIX", nprixmc);
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
        public void updateChildren(int ID, string nom, string prenom, int age, DateTime date, string email, int N_national, string adresse, bool mc, bool Fiche_Sante, string Allergies, string Remarque)
        {

            cnn = new SqlConnection(connetionString);        
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
                "',Prix ='"+ p.ToSqlDecimal() +
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
        public void refresh(DataGridView datagridview, ComboBox combobox)
        {

            cnn = new SqlConnection(connetionString);
            string Query = "SELECT * from Enfant";
            
            try
            {
                cnn.Open();
                SqlDataAdapter da = new SqlDataAdapter(Query, cnn);
                IncriptionOcarinaDataSet ds = new IncriptionOcarinaDataSet();
                da.Fill(ds, "Enfant");

                combobox.DataBindings.Clear();
                combobox.DataSource = null;
                combobox.DataSource = ds.Enfant; //attention c'est pour savoir ou aller chercher
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
        public void ClearDataBase()
        {
            cnn = new SqlConnection(connetionString);
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
        public void suppChild(int Id)
        {
            cnn = new SqlConnection(connetionString);
            string Query = "DELETE from Enfant where Id ="+Id;


            try
            {
                cnn.Open();
                SqlCommand clear = new SqlCommand(Query, cnn);
                if (clear.ExecuteNonQuery() == 0)
                    throw new ApplicationException("y a r de modif !");
                else MessageBox.Show("Suppression de l'Id : "+Id+" confirmed");
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
      
        //public void ExportDataSetToExcel()
        //{
        //    cnn = new SqlConnection(connetionString);
        //    string Query = "SELECT * from Enfant";
        //    SqlDataAdapter da = new SqlDataAdapter(Query, cnn);
        //    IncriptionOcarinaDataSet ds = new IncriptionOcarinaDataSet();
        //    da.Fill(ds, "Enfant");
        //    DataSet dp = ds;
        //    //Creae an Excel application instance
        //    Excel.Application excelApp = new Excel.Application();

        //    //Create an Excel workbook instance and open it from the predefined location
        //    Excel.Workbook excelWorkBook = excelApp.Workbooks.Open(ShareData.xlFile);
            
        //    foreach (DataTable table in dp.Tables)
        //    {
        //        //Add a new worksheet to workbook with the Datatable name
        //        Excel.Worksheet excelWorkSheet = excelWorkBook.Sheets.Add();
                    
        //            excelWorkSheet.Name = table.TableName;

        //            for (int i = 1; i < table.Columns.Count + 1; i++)
        //            {
        //                excelWorkSheet.Cells[1, i] = table.Columns[i - 1].ColumnName;
        //            }

        //            for (int j = 0; j < table.Rows.Count; j++)
        //            {
        //                for (int k = 0; k < table.Columns.Count; k++)
        //                {
        //                    excelWorkSheet.Cells[j + 2, k + 1] = table.Rows[j].ItemArray[k].ToString();
        //                }
        //            }
        //    }
        //    excelWorkBook.Save();
        //    excelWorkBook.Close();
        //    excelApp.Quit();
        //}

    }
}
