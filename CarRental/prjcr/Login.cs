using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace prjcr
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtpass.PasswordChar = '*';
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

            //Connection And Validation
            MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=prj_car");
            string connectionString = "server=localhost;user id=root;database=prj_car";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM admin WHERE username=@username AND password=@password";
            cmd.Parameters.AddWithValue("@username", txtuname.Text);
            cmd.Parameters.AddWithValue("@password", txtpass.Text);

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                // login successful
                MessageBox.Show("Login successful!");
                Main M = new Main();
                M.Show();
                this.Hide();
            }
            else
            {
                // login failed
                MessageBox.Show("Invalid username or password!");
            }

            // close the data reader, the command, and the connection
            reader.Close();
            cmd.Dispose();
            connection.Close();

        }
    }
}
