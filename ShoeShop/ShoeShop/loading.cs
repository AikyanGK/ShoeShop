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
    public partial class loading : Form
    {
        public loading()
        {
            InitializeComponent();
        }
        private void loading_Load(object sender, EventArgs e)
        {
            loadTimer.Start();
        }
        private void loadTimer_Tick(object sender, EventArgs e)
        {
            loadingBar.Increment(1);
            loadingBar.Maximum = 170;
            if(loadingBar.Value == 170)
            {
                pregrem pregrem = new pregrem();
                pregrem.Show();
                loadTimer.Stop();
                this.Hide();
            }
        }

    }
}
