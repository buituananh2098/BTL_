using QLLichBay.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLLichBay.DAO;
using System.Data.SqlClient;

namespace QLLichBay
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {

            if(txtUserName.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Username or password is null.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                UsersController lg = new UsersController();
                if(lg.CheckLogin(txtUserName.Text.Trim(),txtPassword.Text.Trim()) == true)
                {
                    ManageFlightSchedules mg = new ManageFlightSchedules();
                    this.Hide();
                    mg.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Username or password incorrected.","Error", MessageBoxButtons.OK,MessageBoxIcon.Warning); 
                }
            }
        }
        private void Button2_Click(object sender, EventArgs e )
        {
            this.Close();
        }
    }
}
