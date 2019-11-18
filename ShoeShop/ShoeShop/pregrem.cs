using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoeShop
{
    public partial class pregrem : Form
    {
        public pregrem()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void logoPicBox_Click_1(object sender, EventArgs e)
        {
            catalog catalog = new catalog();
            this.Hide();
            catalog.Show();
        }
    }
}
