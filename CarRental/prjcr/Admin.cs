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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
            
            string conn = "datasource=localhost;port=3306;username=root";
            string Query = "insert into prj_car.admin(username,password) values('" + this.txtuname.Text + "','" + this.txtpass.Text + "');";
            MySqlConnection conn2 = new MySqlConnection(conn);
            MySqlCommand MyCommand2 = new MySqlCommand(Query, conn2);
            MySqlDataReader MyReader2;
            conn2.Open();
            MyReader2 = MyCommand2.ExecuteReader();     
            MessageBox.Show("Are You Sure To Save Data?");
            while (MyReader2.Read())
            {
            }
            conn2.Close();
            }
            catch (Exception ex)
            {
            MessageBox.Show(ex.Message);

            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Main M = new Main();
            this.Hide();
            M.Show();
        }
    }
}
