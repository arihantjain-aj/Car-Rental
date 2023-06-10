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
   
    public partial class Onrent : Form
    {

        public Onrent()
        {
            InitializeComponent();

        }

        
        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Main M = new Main();
            M.Show();
            this.Hide();
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            try
            {
                string conn = "datasource=localhost;port=3306;username=root";
                string Query = "insert into prj_car.rent(car_id,car_name,cust_id,cust_name,rent,no_days,hired_till,ph_no,totalrent,cfn,status) values('" + this.carid.Text + "','" + this.carname.Text + "','" + this.custid.Text + "','" + this.custname.Text + "','" + this.rentperday.Text + "','" + this.days.Text + "','" + this.hdate.Value.ToString("yyyy-MM-dd HH:mm:ss") + "','" + this.pno.Text + "','" + this.Total.Text + "','" + this.cfn.Text + "','" + "Busy" + "');";
                MySqlConnection conn2 = new MySqlConnection(conn);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, conn2);
                MySqlDataReader MyReader2;
                conn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     
                MessageBox.Show("Data Saved");

                while (MyReader2.Read())
                {
                }
                conn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


           
            
            Receipt rpt = new Receipt();
            rpt.crname = carname.Text;
            rpt.cstname = custname.Text;
            rpt.ShowDialog();
        }

        private void hdate_ValueChanged(object sender, EventArgs e)
        {
            //total Code
            int rpt = Convert.ToInt32(rentperday.Text);
            int day = Convert.ToInt32(days.Text);
            Total.Text = Convert.ToString(rpt * day);

        }

        private void days_TextChanged(object sender, EventArgs e)
        {
        
                MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=prj_car");

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM car WHERE car_id=@car_id", conn);
                cmd.Parameters.AddWithValue("@car_id",carid.Text);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                        rentperday.Text = reader.GetString("rent");
                        carname.Text = reader.GetString("car_name");
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
            MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM cust WHERE cust_id = @cust_id", conn);
            cmd1.Parameters.AddWithValue("@cust_id", custid.Text);
            MySqlDataReader reader1 = cmd1.ExecuteReader();
            if (reader1.Read())
            {
                custname.Text = reader1.GetString("cust_name");
                pno.Text = reader1.GetString("ph_no");
                cfn.Text = reader1.GetInt32("cfn").ToString();
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
        }
    }
}

