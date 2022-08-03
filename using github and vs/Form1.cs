using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace using_github_and_vs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool btnClick;
        int userTemp;
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            userTemp = Convert.ToInt32(txtUserTemp.Text);
            btnClick = true;

            if (userTemp == 38 || userTemp > 38)
                {
                    MessageBox.Show("FEVER ALERT", "ALERT", MessageBoxButtons.OK);

                }
            else if (txtUserTemp.Text.Length == 0) 
                {
                    MessageBox.Show("PLEASE ENTER A TEMPERATURE", "ERROR", MessageBoxButtons.OK);
                }

            else
                {
                     MessageBox.Show("SLAY", "SLAY", MessageBoxButtons.OK);
                }
        }
    }
}
