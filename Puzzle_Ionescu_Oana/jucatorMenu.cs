using Puzzle_Ionescu_Oana.Jucator;
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
    public partial class jucatorMenu : Form
    {
        
        public jucatorMenu()
        {
            
            InitializeComponent();
        }

        private void jocNou_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
        }

        
    }
}
