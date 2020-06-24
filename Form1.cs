using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Username.Text.Equals("admin") && Password.Text.Equals("pass"))
            {
                Dashboard ds = new Dashboard();
                ds.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("Incorrect username or password", "Mesage Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
