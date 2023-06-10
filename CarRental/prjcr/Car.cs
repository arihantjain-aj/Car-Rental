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
    public partial class Car : Form
    {
        string stat;

        

        public Car()
        {
            InitializeComponent();
        }

        private void Car_Load(object sender, EventArgs e)
        {
            
            try
            {
                    string conn = "datasource = localhost; port = 3306; username = root";
                    //Display query
                    string Query = "select * from prj_car.car;";
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
                    string Query = "insert into prj_car.car(car_id,car_name,car_no,color,rent,status) values('" + this.txtcid.Text + "','" + this.txtname.Text + "','" + this.txtcarno.Text + "','" + this.txtcolor.Text + "','"+ this.txtrpd.Text + "','" + this.txtstat.Text + "');";
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
                string Query = "select * from prj_car.car;";
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
                    string Query = "update prj_car.car set car_id='" + this.txtcid.Text + "', car_name='" + this.txtname.Text + "',car_no='" + this.txtcarno.Text + "',color='" + this.txtcolor.Text + "',rent='" + this.txtrpd.Text + "', status = '" + this.txtstat.Text+ "' where car_id='" + this.txtcid.Text + "';";
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
                string Query = "select * from prj_car.car;";
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main M = new Main();
            M.Show();
            this.Hide();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            
                try
                {
                    string conn = "datasource = localhost; port = 3306; username = root";
                    string Query = "delete from prj_car.car where car_id='" + this.txtcid.Text + "';";
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
                string Query = "select * from prj_car.car;";
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            stat = "Available";
            txtstat.Text = stat;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            stat = "Busy";
            txtstat.Text = stat;
        }

      
    }
}
