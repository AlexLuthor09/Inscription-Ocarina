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
    public partial class FirstMove : Form
    {
        private Donnees_Partagees ShareData = Program.DP;
         private Form_Manager form_manager = Program.DP.FM;

        public FirstMove()
        {
            InitializeComponent();
        }

        private void Butt_New_week_Click(object sender, EventArgs e)
        {
            
            SQL_Manager sql = new SQL_Manager();
            sql.ClearDataBase();

            Program.DP.FM.OpenMainF();
           
            this.Hide();
        }

        private void Butt_Current_week_Click(object sender, EventArgs e)
        {
            Program.DP.FM.OpenMainF();
            
            this.Hide();
        }
    }
}
