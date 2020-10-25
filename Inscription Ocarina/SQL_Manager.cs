﻿using System;
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
        public void addChildren(string nom, string prenom,int age,DateTime date,string email,int N_national,string adresse,bool mc,string Allergies,string Remarque)
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
                SqlCommand addChild = new SqlCommand( Query,cnn);
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
               
               cnn.Close();
            }   
        }

        
    }
}
