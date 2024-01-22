using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Puzzle_Ionescu_Oana.Jucator
{
    
    public partial class Form2 : Form
    {
        public int nr;
        public Form2()
        {
            InitializeComponent();
        }

        private void selectareImg_Click(object sender, EventArgs e)
        {
            
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.ShowDialog();
                openFileDialog1.Title = "Alege imaginea";
                openFileDialog1.InitialDirectory = @"E:\cex\csarp 2013.zip\c#\OTI_2013_C#\Resurse\Img";
                if (openFileDialog1.CheckFileExists == true)
                {
                    jucatorMenu jucator = new jucatorMenu();
                    jucator.Close();
                    Form jocNou = new Form();
                    jocNou.Show();
                }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                nr = 4;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                nr = 9;
            }
        }
    }
}
