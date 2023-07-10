using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOSPITAL_Nurse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Nurse n = new Nurse();
        private void button14_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            n.Show();
        }
    }
}
