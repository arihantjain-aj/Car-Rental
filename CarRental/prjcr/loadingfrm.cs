using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjcr
{
    public partial class loadingfrm : Form
    {
        public loadingfrm()
        {
            InitializeComponent();
        }

        private void loadingform_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Welcome wel = new Welcome();
            if(prgbr.Value < 100)
            {
                prgbr.Value += 1;
                lblpro.Text = prgbr.Value.ToString() + "%";
            }
            else
            {
                timer1.Stop();
                wel.Show();
                this.Hide();
            }
        }

       
    }
}
