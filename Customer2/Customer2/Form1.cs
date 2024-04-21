using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Customer2.ServiceReference1;
namespace Customer2
{
    public partial class Form1 : Form
    {
        ServiceReference1.RestaurantServiceClient obj = new RestaurantServiceClient("secondendpoint");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int x = obj.eat();
            MessageBox.Show(x.ToString());
            int y = obj.eat();
            textBox1.Text = y.ToString();
        }
    }
}
