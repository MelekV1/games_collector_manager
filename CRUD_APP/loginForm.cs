using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_APP
{
    public partial class loginForm : Form
    {
        //For security concerns configuration manager is used to extract the connection credentials from the config xml file
        SqlConnection con = new SqlConnection(
            ConfigurationManager
            .ConnectionStrings["CRUD_APP.Properties.Settings.ConnectionString"]
            .ConnectionString);
        
        public loginForm()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand($"select * from login where pseudo = '{Username.Text.Trim()}' and pass = '{Password.Text.Trim()}'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                //Ouvrir le dashboard
                con.Close();
                dr.Close();
                Dashboard dashboard = new Dashboard();
                dashboard.ShowDialog();
                //Fermer le login form ...?
                //this.Close();
            }
            else
            {
                //Message d'erreur
                MessageBox.Show("Please check your input , invalide credentials!");
                con.Close();
            }
        }
    }
}
