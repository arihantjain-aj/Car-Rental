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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            try
            {
                string conn = "datasource = localhost; port = 3306; username = root";
                //Display query
                string Query = "select * from prj_car.cust;";
                MySqlConnection conn2 = new MySqlConnection(conn);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, conn2);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable; 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            try
            {
                string conn = "datasource=localhost;port=3306;username=root";
                string Query = "insert into prj_car.cust(cust_id,cust_name,age,ph_no,addr,cfn) values('" + this.txtcid.Text + "','" + this.txtname.Text + "','" + this.txtage.Text + "','" + this.txtphone.Text + "','" + this.txtaddr.Text + "','" + this.txtconno.Text + "');";
                MySqlConnection conn2 = new MySqlConnection(conn);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, conn2);
                MySqlDataReader MyReader2;
                conn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     
                MessageBox.Show("Save Data");

                while (MyReader2.Read())
                {
                }
                conn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                string conn = "datasource = localhost; port = 3306; username = root";
                //Display query
                string Query = "select * from prj_car.cust;";
                MySqlConnection conn2 = new MySqlConnection(conn);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, conn2);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable; 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnupdt_Click(object sender, EventArgs e)
        {
            try
            {
                string conn = "datasource=localhost;port=3306;username=root";
                string Query = "update prj_car.cust set cust_id='" + this.txtcid.Text + "', cust_name='" + this.txtname.Text + "',age='" + this.txtage.Text + "',ph_no='" + this.txtphone.Text + "',addr='" + this.txtaddr.Text + "', cfn = '" + this.txtconno.Text + "' where cust_id='" + this.txtcid.Text + "';";
                MySqlConnection conn2 = new MySqlConnection(conn);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, conn2);
                MySqlDataReader MyReader2;
                conn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Updated");
                while (MyReader2.Read())
                {
                }
                conn2.Close();//Connection closed here
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                string conn = "datasource = localhost; port = 3306; username = root";
                //Display query
                string Query = "select * from prj_car.cust;";
                MySqlConnection conn2 = new MySqlConnection(conn);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, conn2);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable; 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                string conn = "datasource = localhost; port = 3306; username = root";
                string Query = "delete from prj_car.cust where cust_id='" + this.txtcid.Text + "';";
                MySqlConnection conn2 = new MySqlConnection(conn);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, conn2);
                MySqlDataReader MyReader2;
                conn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Deleted");
                while (MyReader2.Read())
                {
                }
                conn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                string conn = "datasource = localhost; port = 3306; username = root";
                //Display query
                string Query = "select * from prj_car.cust;";
                MySqlConnection conn2 = new MySqlConnection(conn);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, conn2);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main M = new Main();
            M.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }  
}
