using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;


namespace Inscription_Ocarina
{
    public partial class Excel_Impression : Form
    {
        Excel.Application xlapp;
        Excel.Workbooks xlwbooks;
        Excel.Workbook xlwbook;
        Excel._Worksheet xlwsheet;

        public Excel_Impression()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Fichier Excel (*.xls;*.xlsx)|*.xls;*.xlsx";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = ofd.FileName;

            }
        }

        private void TB_textChanged(object sender, EventArgs e)
        {
            NameList.Enabled = button1.Enabled = textBox1.Text != "";

        }

        private void Open_Click(object sender, EventArgs e)
        {
            xlapp = new Excel.Application();
            xlwbooks = xlapp.Workbooks;
            xlwbook = xlwbooks.Add(textBox1.Text);
            xlwsheet = (Excel._Worksheet)xlwbook.Worksheets[1];
            xlapp.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int ligne = 0; ligne <= 8; ligne++)
            {

                try
                {
                    string item = ((Excel.Range)xlwsheet.Cells[ligne, 1]).Value2.ToString() + " " + ((Excel.Range)xlwsheet.Cells[ligne, 2]).Value2.ToString() + " " + ((Excel.Range)xlwsheet.Cells[ligne, 3]).Value2.ToString() + "ans";
                    for (int i = 0; i < NameList.Items.Count; i++)
                    {
                        // if (item != NameList.Items.ToString())
                        NameList.Items.Add(item);
                    }

                }
                catch (Exception et)
                {
                    MessageBox.Show(et.ToString());
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

