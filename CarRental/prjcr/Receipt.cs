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
    public partial class Receipt : Form
    {
        public String crname { get; set; }
        public String cstname { get; set; }

        public Receipt()
        {
            InitializeComponent();
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            carname.Text = crname;
            custname.Text = cstname;

            MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=prj_car");

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM rent WHERE car_name=@car_name", conn);
                cmd.Parameters.AddWithValue("@car_name", crname);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    rent.Text = reader.GetString("rent");
                    nof.Text = reader.GetString("no_days");
                    htdate.Text = reader.GetString("hired_till");
                    custph.Text = reader.GetString("ph_no");
                    total.Text = reader.GetString("totalrent");
                    cfn.Text = reader.GetString("cfn");
                    tdate.Text = reader.GetString("date");
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            try
            {
                conn.Open();
                MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM cust WHERE cust_name=@cust_name", conn);
                cmd1.Parameters.AddWithValue("@cust_name", cstname);
                MySqlDataReader reader1 = cmd1.ExecuteReader();
                if (reader1.Read())
                {
                    custadd.Text = reader1.GetString("addr");
                    
                }
                reader1.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            try
            {
                conn.Open();
                MySqlCommand cmd2 = new MySqlCommand("SELECT * FROM car WHERE car_name=@car_name", conn);
                cmd2.Parameters.AddWithValue("@car_name", crname);
                MySqlDataReader reader2 = cmd2.ExecuteReader();
                if (reader2.Read())
                {
                    carcolor.Text = reader2.GetString("color");
                    carno.Text = reader2.GetString("car_no");
                }
                reader2.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
