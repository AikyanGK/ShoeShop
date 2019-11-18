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
    public partial class receipt : Form
    {
        public receipt()
        {
            InitializeComponent();
        }

        private void receipt_Load(object sender, EventArgs e)
        {
            deliverTo.Text = cashout.name;
            at.Text = cashout.address;
            on.Text = Convert.ToString(cashout.dateOnly);
            contact.Text = cashout.contact;
            methodLbl.Text = cashout.paymentMethod;

            beijingQ.Text = cashout.beijingReceipt;
            taipeiQ.Text = cashout.taipeiReceipt;
            tokyoQ.Text = cashout.tokyoReceipt;
            shanghaiQ.Text = cashout.shanghaiReceipt;
            guangzhouQ.Text = cashout.guangzhouReceipt;
            houstonQ.Text = cashout.houstonReceipt;
            losAngelesQ.Text = cashout.losAngelesReceipt;
            manilaQ.Text = cashout.manilaReceipt;
            newYorkQ.Text = cashout.newYorkReceipt;
            berlinQ.Text = cashout.berlinReceipt;
            miamiQ.Text = cashout.miamiReceipt;
            totalQ.Text = cashout.totalQuantityReceipt;

            beijingP.Text = cashout.beijingPriceReceipt;
            taipeiP.Text = cashout.taipeiPriceReceipt;
            tokyoP.Text = cashout.tokyoPriceReceipt;
            shanghaiP.Text = cashout.shanghaiPriceReceipt;
            guangzhouP.Text = cashout.guangzhouPriceReceipt;
            houstonP.Text = cashout.houstonPriceReceipt;
            losAngelesP.Text = cashout.losAngelesPriceReceipt;
            manilaP.Text = cashout.manilaPriceReceipt;
            newYorkP.Text = cashout.newYorkPriceReceipt;
            berlinP.Text = cashout.berlinPriceReceipt;
            miamiP.Text = cashout.miamiPriceReceipt;
            totalP.Text = cashout.totalReceipt;
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            pregrem pregrem = new pregrem();
            pregrem.Show();
        }

    }
    
}
