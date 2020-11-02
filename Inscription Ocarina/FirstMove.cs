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
    public partial class FirstMove : Form
    {
        public FirstMove()
        {
            InitializeComponent();
        }

        private void Butt_New_week_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Butt_Current_week_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
