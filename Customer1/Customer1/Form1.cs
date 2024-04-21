using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Customer1.ServiceReference1;
namespace Customer1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.RestaurantServiceClient obj = new RestaurantServiceClient("firstendpoint");
            int x = obj.eat();
            MessageBox.Show(x.ToString());
            int y = obj.eat();
            textBox1.Text = y.ToString();
        }
    }
}
