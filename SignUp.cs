using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PLUG_3._0
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txtComPassword.Text == txtPassword.Text )
            {
                this.Hide();
                Verification verification = new Verification();
                verification.Show();
            }
            else if (txtComPassword.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("Password entry empty, please fill in", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
            
            else
            {
                MessageBox.Show("Password incorrect or does not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
