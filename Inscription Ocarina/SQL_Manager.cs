using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inscription_Ocarina
{
    class SQL_Manager
    {

        public SQL_Manager()
        {
            string connetionString = null;
            SqlConnection cnn;
            connetionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Visual Studio\\Inscription Ocarina\\Inscription Ocarina\\IncriptionOcarina.mdf;Integrated Security=True;Connect Timeout=30";
            cnn = new SqlConnection(connetionString);

            try
            {
                cnn.Open();
                MessageBox.Show("Connection Open ! ");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! \n " + ex);
            }
        }
        public void addChildren(string nom, string prenom, int age, DateTime date, string email, int N_national, string adresse, bool mc, string Allergies, string Remarque)
        {
            string connetionString = null;
            SqlConnection cnn;
            connetionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Visual Studio\\Inscription Ocarina\\Inscription Ocarina\\IncriptionOcarina.mdf;Integrated Security=True;Connect Timeout=30";
            cnn = new SqlConnection(connetionString);

            string Query = @"INSERT INTO Enfant  (Nom,Prenom,Email,N_Nationam,Date_Naissance,Age,MC,Remarque,Allergie,Adresse)" +
                "SELECT @NOM,@PRENOM,@EMAIL,@N_NATIONAM,@DATE_NAISSANCE,@AGE,@MC,@REMARQUE,@ALLERGIE,@ADRESSE";

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
                addChild.Parameters.AddWithValue("@REMARQUE", Remarque);
                addChild.Parameters.AddWithValue("@ALLERGIE", Allergies);
                addChild.Parameters.AddWithValue("@ADRESSE", adresse);
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
        public void getChildren(int ID, Inscription_Children inscription_Children)
        {
            string connetionString = null;
            SqlConnection cnn;
            connetionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Visual Studio\\Inscription Ocarina\\Inscription Ocarina\\IncriptionOcarina.mdf;Integrated Security=True;Connect Timeout=30";
            cnn = new SqlConnection(connetionString);

            string Query = "Select * form Enfant";


            try
            {
                cnn.Open();

                SqlCommand getchild = new SqlCommand(Query, cnn);
                inscription_Children.prenom = getchild.Parameters[ID].Value.ToString(); // getchild.Parameters["@Nom"].Value.ToString();
                if (getchild.ExecuteNonQuery() == 0)
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
        public void updateChildren(int ID, string nom, string prenom, int age, DateTime date, string email, int N_national, string adresse, bool mc, string Allergies, string Remarque)
        {
            string connetionString = null;
            SqlConnection cnn;
            connetionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Visual Studio\\Inscription Ocarina\\Inscription Ocarina\\IncriptionOcarina.mdf;Integrated Security=True;Connect Timeout=30";
            cnn = new SqlConnection(connetionString);

            string Query = "UPDATE Enfant SET " +
                "Nom ='" + nom +
                "',Prenom ='" + prenom +
                "',Email ='" + age+
                "',N_Nationam ='" + N_national +
                "',Date_Naissance ='" + date.ToString("dd-MM-yyyy") +
                "',Age ='" + age+
                "',MC ='" + mc+
                "',Remarque ='" + Remarque+
                "',Allergie ='" +Allergies+
                "',Adresse = '" +adresse+
                "' WHERE Id =" + ID +";";

            try
            {
                cnn.Open();

                SqlCommand modifchild = new SqlCommand(Query, cnn);
                if (modifchild.ExecuteNonQuery() == 0)
                    throw new ApplicationException("y a r de modif !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ca marche pas connard car :  "+ ex.Message);
            }
            finally
            {

                cnn.Close();
            }

        }
    }
}
