using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzle_Ionescu_Oana
{
    public partial class Form1 : Form
    {
        string a;
        public Form1()
        {
            InitializeComponent();
        }
        public void Textbox()
        {
            TextBox parolaJucator = new TextBox();
            TextBox parolaAdministrator = new TextBox();
        }

        private void btn_Login1_Click(object sender, EventArgs e)
        {
            a = parolaJucator.Text;
            if (a == "jucator")
            {
                Form1 f = new Form1();
                f.Close();
                jucatorMenu jucator = new jucatorMenu();
                jucator.Show();
            }
        }

        private void btn_Login2_Click(object sender, EventArgs e)
        {
            a = parolaAdministrator.Text;
            if (a == "administrator")
            {
                this.Close();
                administratorMenu administrator = new administratorMenu();
                administrator.Show();
            }
        }
    }
}
