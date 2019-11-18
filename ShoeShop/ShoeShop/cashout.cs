using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ShoeShop
{
    public partial class cashout : Form
    {
        string source = @"Data Source = DESKTOP-OJCK1M3\SQLEXPRESS ; Initial Catalog = ShoeShop; Integrated Security = True";
        public cashout()
        {
            InitializeComponent();
        }
        private void cashout_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(source);
            dateTimePicker1.Value = DateTime.Today;

            //shows bought items
            if (catalog.beijing == 0)
            {
                beijingQ.Text = string.Empty;
                beijingCount = 0;
            }
            else
            {
                beijingQ.Text = Convert.ToString(catalog.beijing);
                beijingReceipt = beijingQ.Text;
                beijingCount = catalog.beijing;
            }

            if (catalog.taipei == 0)
            {
                taipeiQ.Text = string.Empty;
                taipeiCount = 0;
            }
            else
            {
                taipeiQ.Text = Convert.ToString(catalog.taipei);
                taipeiReceipt = taipeiQ.Text;
                taipeiCount = catalog.taipei;
            }

            if (catalog.tokyo == 0)
            {
                tokyoQ.Text = string.Empty;
                tokyoCount = 0;
            }
            else
            {
                tokyoQ.Text = Convert.ToString(catalog.tokyo);
                tokyoReceipt = tokyoQ.Text;
                tokyoCount = catalog.tokyo;
            }

            if (catalog.shanghai == 0)
            {
                shanghaiQ.Text = string.Empty;
                shanghaiCount = 0;
            }
            else
            {
                shanghaiQ.Text = Convert.ToString(catalog.shanghai);
                shanghaiReceipt = shanghaiQ.Text;
                shanghaiCount = catalog.shanghai;
            }

            if (catalog.guangzhou == 0)
            {
                guangzhouQ.Text = string.Empty;
                guangzhouCount = 0;
            }
            else
            {
                guangzhouQ.Text = Convert.ToString(catalog.guangzhou);
                guangzhouReceipt = guangzhouQ.Text;
                guangzhouCount = catalog.guangzhou;
            }

            if (catalog.houston == 0)
            {
                houstonQ.Text = string.Empty;
                houstonCount = 0;
            }
            else
            {
                houstonQ.Text = Convert.ToString(catalog.houston);
                houstonReceipt = houstonQ.Text;
                houstonCount = catalog.houston;
            }

            if (catalog.losAngeles == 0)
            {
                losAngelesQ.Text = string.Empty;
                losAngelesCount = 0;
            }
            else
            {
                losAngelesQ.Text = Convert.ToString(catalog.losAngeles);
                losAngelesReceipt = losAngelesQ.Text;
                losAngelesCount = catalog.losAngeles;
            }

            if (catalog.manila == 0)
            {
                manilaQ.Text = string.Empty;
                manilaCount = 0;
            }
            else
            {
                manilaQ.Text = Convert.ToString(catalog.manila);
                manilaReceipt = manilaQ.Text;
                manilaCount = catalog.manila;
            }

            if (catalog.newYork == 0)
            {
                newYorkQ.Text = string.Empty;
                newYorkCount = 0;
            }
            else
            {
                newYorkQ.Text = Convert.ToString(catalog.newYork);
                newYorkReceipt = newYorkQ.Text;
                newYorkCount = catalog.newYork;
            }

            if (catalog.berlin == 0)
            {
                berlinQ.Text = string.Empty;
                berlinCount = 0;
            }
            else
            {
                berlinQ.Text = Convert.ToString(catalog.berlin);
                berlinReceipt = berlinQ.Text;
                berlinCount = catalog.berlin;
            }

            if (catalog.miami == 0)
            {
                miamiQ.Text = string.Empty;
                miamiCount = 0;
            }
            else
            {
                miamiQ.Text = Convert.ToString(catalog.miami);
                miamiReceipt = miamiQ.Text;
                miamiCount = catalog.miami;
            }

            //calculates quantity
            totalQ.Text = Convert.ToString(catalog.beijing + catalog.taipei + catalog.tokyo + catalog.shanghai + catalog.guangzhou + catalog.houston + catalog.losAngeles + catalog.manila + catalog.newYork + catalog.berlin + catalog.miami);
            totalQuantityReceipt = totalQ.Text;

            //calculates price

            connection.Open();
            string getBeijingPrice;
            double beijingPrice, beijingQuantity;
            SqlCommand getBeijingPriceCommand = new SqlCommand (getBeijingPrice = "SELECT price from dbo.Shoes where productCode = 0", connection);
            SqlDataReader readBeijingPrice = getBeijingPriceCommand.ExecuteReader();
            //reads price
            if(readBeijingPrice.Read())
            {
                beijingPrice = Convert.ToDouble(readBeijingPrice.GetValue(0));
                beijingQuantity = Convert.ToDouble(beijingCount);
                totalBeijingPrice = beijingPrice * beijingQuantity;
                beijingP.Text = "P " + Convert.ToString(totalBeijingPrice);
                beijingPriceReceipt = beijingP.Text;
            }
            connection.Close();

            connection.Open();
            string getTaipeiPrice;
            double taipeiQuantity, taipeiPrice;
            SqlCommand getTaipeiPriceCommand = new SqlCommand(getTaipeiPrice = "SELECT price from dbo.Shoes where productCode = 1", connection);
            SqlDataReader readTaipeiPrice = getTaipeiPriceCommand.ExecuteReader();
            //reads price
            if (readTaipeiPrice.Read())
            {
                taipeiPrice = Convert.ToDouble(readTaipeiPrice.GetValue(0));
                taipeiQuantity = Convert.ToDouble(taipeiCount);
                totalTaipeiPrice = taipeiPrice * taipeiQuantity;
                taipeiP.Text = "P " + Convert.ToString(totalTaipeiPrice);
                taipeiPriceReceipt = taipeiP.Text;
            }
            connection.Close();

            connection.Open();
            string getTokyoPrice;
            double tokyoQuantity, tokyoPrice;
            SqlCommand getTokyoPriceCommand = new SqlCommand(getTokyoPrice = "SELECT price from dbo.Shoes where productCode = 2", connection);
            SqlDataReader readTokyoPrice = getTokyoPriceCommand.ExecuteReader();
            //reads price
            if (readTokyoPrice.Read())
            {
                tokyoPrice = Convert.ToDouble(readTokyoPrice.GetValue(0));
                tokyoQuantity = Convert.ToDouble(tokyoCount);
                totalTokyoPrice = tokyoPrice * tokyoQuantity;
                tokyoP.Text = "P " + Convert.ToString(totalTokyoPrice);
                tokyoPriceReceipt = tokyoP.Text;
            }
            connection.Close();

            connection.Open();
            string getShanghaiPrice;
            double shanghaiQuantity, shanghaiPrice;
            SqlCommand getShanghaiPriceCommand = new SqlCommand(getShanghaiPrice = "SELECT price from dbo.Shoes where productCode = 3", connection);
            SqlDataReader readShanghaiPrice = getShanghaiPriceCommand.ExecuteReader();
            //reads price
            if (readShanghaiPrice.Read())
            {
                shanghaiPrice = Convert.ToDouble(readShanghaiPrice.GetValue(0));
                shanghaiQuantity = Convert.ToDouble(shanghaiCount);
                totalShanghaiPrice = shanghaiPrice * shanghaiQuantity;
                shanghaiP.Text = "P " + Convert.ToString(totalShanghaiPrice);
                shanghaiPriceReceipt = shanghaiP.Text;
            }
            connection.Close();

            connection.Open();
            string getGuangzhouPrice;
            double guangzhouQuantity, guangzhouPrice;
            SqlCommand getGuangzhouPriceCommand = new SqlCommand(getGuangzhouPrice = "SELECT price from dbo.Shoes where productCode = 4", connection);
            SqlDataReader readGuangzhouPrice = getGuangzhouPriceCommand.ExecuteReader();
            //reads price
            if (readGuangzhouPrice.Read())
            {
                guangzhouPrice = Convert.ToDouble(readGuangzhouPrice.GetValue(0));
                guangzhouQuantity = Convert.ToDouble(guangzhouCount);
                totalGuangzhouPrice = guangzhouPrice * guangzhouQuantity;
                guangzhouP.Text = "P " + Convert.ToString(totalGuangzhouPrice);
                guangzhouPriceReceipt = guangzhouP.Text;
            }
            connection.Close();

            connection.Open();
            string getHoustonPrice;
            double houstonQuantity, houstonPrice;
            SqlCommand getHoustonPriceCommand = new SqlCommand(getHoustonPrice = "SELECT price from dbo.Shoes where productCode = 5", connection);
            SqlDataReader readHoustonPrice = getHoustonPriceCommand.ExecuteReader();
            //reads price
            if (readHoustonPrice.Read())
            {
                houstonPrice = Convert.ToDouble(readHoustonPrice.GetValue(0));
                houstonQuantity = Convert.ToDouble(houstonCount);
                totalHoustonPrice = houstonPrice * houstonQuantity;
                houstonP.Text = "P " + Convert.ToString(totalHoustonPrice);
                houstonPriceReceipt = houstonP.Text;
            }
            connection.Close();

            connection.Open();
            string getlosAngelesPrice;
            double losAngelesQuantity, losAngelesPrice;
            SqlCommand getlosAngelesPriceCommand = new SqlCommand(getlosAngelesPrice = "SELECT price from dbo.Shoes where productCode = 6", connection);
            SqlDataReader readlosAngelesPrice = getlosAngelesPriceCommand.ExecuteReader();
            //reads price
            if (readlosAngelesPrice.Read())
            {
                losAngelesPrice = Convert.ToDouble(readlosAngelesPrice.GetValue(0));
                losAngelesQuantity = Convert.ToDouble(losAngelesCount);
                totalLosAngelesPrice = losAngelesPrice * losAngelesQuantity;
                losAngelesP.Text = "P " + Convert.ToString(totalLosAngelesPrice);
                losAngelesPriceReceipt = losAngelesP.Text;
            }
            connection.Close();

            connection.Open();
            string getmanilaPrice;
            double manilaQuantity, manilaPrice;
            SqlCommand getmanilaPriceCommand = new SqlCommand(getmanilaPrice = "SELECT price from dbo.Shoes where productCode = 7", connection);
            SqlDataReader readmanilaPrice = getmanilaPriceCommand.ExecuteReader();
            //reads price
            if (readmanilaPrice.Read())
            {
                manilaPrice = Convert.ToDouble(readmanilaPrice.GetValue(0));
                manilaQuantity = Convert.ToDouble(manilaCount);
                totalManilaPrice = manilaPrice * manilaQuantity;
                manilaP.Text = "P " + Convert.ToString(totalManilaPrice);
                manilaPriceReceipt = manilaP.Text;
            }
            connection.Close();

            connection.Open();
            string getnewYorkPrice;
            double newYorkQuantity, newYorkPrice;
            SqlCommand getnewYorkPriceCommand = new SqlCommand(getnewYorkPrice = "SELECT price from dbo.Shoes where productCode = 8", connection);
            SqlDataReader readnewYorkPrice = getnewYorkPriceCommand.ExecuteReader();
            //reads price
            if (readnewYorkPrice.Read())
            {
                newYorkPrice = Convert.ToDouble(readnewYorkPrice.GetValue(0));
                newYorkQuantity = Convert.ToDouble(newYorkCount);
                totalNewYorkPrice = newYorkPrice * newYorkQuantity;
                newYorkP.Text = "P " + Convert.ToString(totalNewYorkPrice);
                newYorkPriceReceipt = newYorkP.Text;
            }
            connection.Close();

            connection.Open();
            string getBerlinPrice;
            double BerlinQuantity, BerlinPrice;
            SqlCommand getBerlinPriceCommand = new SqlCommand(getBerlinPrice = "SELECT price from dbo.Shoes where productCode = 9", connection);
            SqlDataReader readBerlinPrice = getBerlinPriceCommand.ExecuteReader();
            //reads price
            if (readBerlinPrice.Read())
            {
                BerlinPrice = Convert.ToDouble(readBerlinPrice.GetValue(0));
                BerlinQuantity = Convert.ToDouble(berlinCount);
                totalBerlinPrice = BerlinPrice * BerlinQuantity;
                berlinP.Text = "P " + Convert.ToString(totalBerlinPrice);
                berlinPriceReceipt = berlinP.Text;
            }
            connection.Close();

            connection.Open();
            string getmiamiPrice;
            double miamiQuantity, miamiPrice;
            SqlCommand getmiamiPriceCommand = new SqlCommand(getmiamiPrice = "SELECT price from dbo.Shoes where productCode = 10", connection);
            SqlDataReader readmiamiPrice = getmiamiPriceCommand.ExecuteReader();
            //reads price
            if (readmiamiPrice.Read())
            {
                miamiPrice = Convert.ToDouble(readmiamiPrice.GetValue(0));
                miamiQuantity = Convert.ToDouble(miamiCount);
                totalMiamiPrice = miamiPrice * miamiQuantity;
                miamiP.Text = "P " + Convert.ToString(totalMiamiPrice);
                miamiPriceReceipt = miamiP.Text;
            }
            connection.Close();
            totalP.Text = Convert.ToString(totalBeijingPrice + totalTaipeiPrice + totalTokyoPrice + totalShanghaiPrice + totalGuangzhouPrice + totalHoustonPrice + totalLosAngelesPrice + totalManilaPrice + totalNewYorkPrice + totalBerlinPrice + totalMiamiPrice);
            totalReceipt = totalP.Text;


        }

        private void backbtn_Click(object sender, EventArgs e)
        {
           //returns cancelled order
            SqlConnection connection = new SqlConnection(source);
            connection.Open();
            string getBeijingQuantity;
            int beijing = Convert.ToInt32(beijingCount);
            SqlCommand getbeijing = new SqlCommand(getBeijingQuantity = "Update dbo.Shoes set stocks = stocks + '" + beijing + "' where productCode = 0",connection);
            getbeijing.ExecuteNonQuery();
            connection.Close();

            connection.Open();
            string getTaipeiQuantity;
            int taipei = Convert.ToInt32(taipeiCount);
            SqlCommand getTaipei = new SqlCommand(getTaipeiQuantity = "Update dbo.Shoes set stocks = stocks + '" + taipei + "' where productCode = 1", connection);
            getTaipei.ExecuteNonQuery();
            connection.Close();

            connection.Open();
            string getTokyoQuantity;
            int tokyo = Convert.ToInt32(tokyoCount);
            SqlCommand getTokyo = new SqlCommand(getTokyoQuantity = "Update dbo.Shoes set stocks = stocks + '" + tokyo + "' where productCode = 2", connection);
            getTokyo.ExecuteNonQuery();
            connection.Close();

            connection.Open();
            string getShanghaiQuantity;
            int shanghai= Convert.ToInt32(shanghaiCount);
            SqlCommand getShanghai = new SqlCommand(getShanghaiQuantity = "Update dbo.Shoes set stocks = stocks + '" + shanghai + "' where productCode = 3", connection);
            getShanghai.ExecuteNonQuery();
            connection.Close();

            connection.Open();
            string getGuangzhouQuantity;
            int guangzhou = Convert.ToInt32(guangzhouCount);
            SqlCommand getGuangzhou = new SqlCommand(getGuangzhouQuantity = "Update dbo.Shoes set stocks = stocks + '" + guangzhou + "' where productCode = 4", connection);
            getGuangzhou.ExecuteNonQuery();
            connection.Close();

            connection.Open();
            string getHoustonQuantity;
            int houston = Convert.ToInt32(houstonCount);
            SqlCommand getHouston = new SqlCommand(getHoustonQuantity = "Update dbo.Shoes set stocks = stocks + '" + houston + "' where productCode = 5", connection);
            getHouston.ExecuteNonQuery();
            connection.Close();

            connection.Open();
            string getLosAngelesQuantity;
            int losAngeles = Convert.ToInt32(losAngelesCount);
            SqlCommand getLosAngeles = new SqlCommand(getLosAngelesQuantity = "Update dbo.Shoes set stocks = stocks + '" + losAngeles + "' where productCode = 6", connection);
            getLosAngeles.ExecuteNonQuery();
            connection.Close();

            connection.Open();
            string getManilaQuantity;
            int manila = Convert.ToInt32(manilaCount);
            SqlCommand getManila = new SqlCommand(getManilaQuantity = "Update dbo.Shoes set stocks = stocks + '" + manila + "' where productCode = 7", connection);
            getManila.ExecuteNonQuery();
            connection.Close();

            connection.Open();
            string getNewYorkQuantity;
            int newYork = Convert.ToInt32(newYorkCount);
            SqlCommand getNewYork = new SqlCommand(getNewYorkQuantity = "Update dbo.Shoes set stocks = stocks + '" + newYork + "' where productCode = 8", connection);
            getNewYork.ExecuteNonQuery();
            connection.Close();

            connection.Open();
            string getBerlinQuantity;
            int berlin = Convert.ToInt32(berlinCount);
            SqlCommand getBerlin = new SqlCommand(getBerlinQuantity = "Update dbo.Shoes set stocks = stocks + '" + berlin + "' where productCode = 9", connection);
            getBerlin.ExecuteNonQuery();
            connection.Close();

            connection.Open();
            string getMiamiQuantity;
            int miami = Convert.ToInt32(miamiCount);
            SqlCommand getMiami = new SqlCommand(getMiamiQuantity = "Update dbo.Shoes set stocks = stocks + '" + miami + "' where productCode = 10", connection);
            getMiami.ExecuteNonQuery();
            connection.Close();

            catalog catalog = new catalog();
            this.Hide();
            catalog.Show();
            

        }
        public static double beijingCount, totalBeijingPrice;
        public static double taipeiCount, totalTaipeiPrice;
        public static double tokyoCount, totalTokyoPrice;
        public static double shanghaiCount, totalShanghaiPrice;
        public static double guangzhouCount, totalGuangzhouPrice;
        public static double houstonCount, totalHoustonPrice;

        private void receipt_Click(object sender, EventArgs e)
        {
            name = nameTxtBox.Text;
            address = addressTxtBox.Text;
            contact = contactTxtBox.Text;
            DateTime date = dateTimePicker1.Value;
            dateOnly = date.Date;
            receipt receipt = new receipt();
            this.Hide();
            receipt.Show();

        }

        public static double losAngelesCount, totalLosAngelesPrice;

        private void remittanceRadio_CheckedChanged(object sender, EventArgs e)
        {
            paymentMethod = "Remittance";
        }

        private void codRadio_CheckedChanged(object sender, EventArgs e)
        {
            paymentMethod = "Cash on Delivery";
        }

        public static double manilaCount, totalManilaPrice;
        public static double newYorkCount, totalNewYorkPrice;
        public static double berlinCount, totalBerlinPrice;
        public static double miamiCount, totalMiamiPrice;

        public static string name, address, contact;
        public static DateTime dateOnly;
        public static string paymentMethod;

        public static string beijingReceipt;
        public static string taipeiReceipt;
        public static string tokyoReceipt;
        public static string shanghaiReceipt;
        public static string guangzhouReceipt;
        public static string houstonReceipt;
        public static string losAngelesReceipt;
        public static string manilaReceipt;
        public static string newYorkReceipt;
        public static string berlinReceipt;
        public static string miamiReceipt;
        public static string totalReceipt;

        public static string beijingPriceReceipt;
        public static string taipeiPriceReceipt;
        public static string tokyoPriceReceipt;
        public static string shanghaiPriceReceipt;
        public static string guangzhouPriceReceipt;
        public static string houstonPriceReceipt;
        public static string losAngelesPriceReceipt;
        public static string manilaPriceReceipt;
        public static string newYorkPriceReceipt;
        public static string berlinPriceReceipt;
        public static string miamiPriceReceipt;
        public static string totalQuantityReceipt;


    }
}
