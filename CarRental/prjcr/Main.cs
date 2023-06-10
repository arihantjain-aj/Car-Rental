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
    public partial class Main : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=prj_car");
        public Main()
        {
            InitializeComponent();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Admin a1 = new Admin();
            Car a2 = new Car();
            Customer a3 = new Customer();
            Login Lg = new Login();
            a1.Close();
            a2.Close();
            a3.Close();
            Lg.Show();
            this.Close();

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Admin a1 = new Admin();
            Car a2 = new Car();
            Customer a3 = new Customer();
            Login a4 = new Login();
            a1.Close();
            a2.Close();
            a3.Close();
            a4.Close();
            this.Close();
        }


        private void btnadmin_Click(object sender, EventArgs e)
        {
            Admin Ad = new Admin();
            Ad.Show();
            this.Hide();
        }


        private void btncust_Click(object sender, EventArgs e)
        {
            Customer Cust = new Customer();
            Cust.Show();
            this.Hide();
        }

        private void btnrent_Click(object sender, EventArgs e)
        {
            Onrent Rnt = new Onrent();
            Rnt.Show();
            this.Hide();
        }

        private void btnaddcars_Click(object sender, EventArgs e)
        {
            Car C = new Car();
            C.Show();
            this.Hide();
        }
    }
}
