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
    public partial class catalog : Form
    {
        string source = @"Data Source = DESKTOP-OJCK1M3\SQLEXPRESS ; Initial Catalog = ShoeShop; Integrated Security = True";
        public catalog()
        {
            InitializeComponent();
        }

        private void catalog_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(source);
            connection.Open();
            string selectStock;

            SqlCommand getBeijingStocks = new SqlCommand(selectStock = "SELECT stocks from dbo.Shoes where productCode = 0", connection);
            SqlDataReader beijingStocksRead = getBeijingStocks.ExecuteReader();
            if (beijingStocksRead.Read())
            {
                //displays the stocks
                string beijingStocksText = Convert.ToString(beijingStocksRead.GetValue(0));
                int beijingStocks = Convert.ToInt32(beijingStocksRead.GetValue(0));
                beijingStockLbl.Text = beijingStocksText + " Left";
                if (beijingStocks == 0)
                {
                    //disables soldout product
                    beijingSoldOut.Image = Properties.Resources.soldout;
                    //disables quantity selector
                    beijingQ.Enabled = false;
                }
            }
            connection.Close();

            //re-open connection to avoid error
            connection.Open();
            SqlCommand getTaipeiStocks = new SqlCommand(selectStock = "SELECT stocks from dbo.Shoes where productCode = 1", connection);
            SqlDataReader taipeiStocksRead = getTaipeiStocks.ExecuteReader();
            if (taipeiStocksRead.Read())
            {
                //displays the stocks
                string taipeiStocksText = Convert.ToString(taipeiStocksRead.GetValue(0));
                int taipeiStocks = Convert.ToInt32(taipeiStocksRead.GetValue(0));
                taipeiStockLbl.Text = taipeiStocks + " Left";
                if (taipeiStocks == 0)
                {
                    //disables soldout product
                    taipeiSoldOut.Image = Properties.Resources.soldout;
                    //disables quantity selector
                    taipeiQ.Enabled = false;
                }
            }
            connection.Close();

            //re-open connection to avoid error
            connection.Open();
            SqlCommand getTokyoStocks = new SqlCommand(selectStock = "SELECT stocks from dbo.Shoes where productCode = 2", connection);
            SqlDataReader tokyoStocksRead = getTokyoStocks.ExecuteReader();
            if (tokyoStocksRead.Read())
            {
                //displays the stocks
                string tokyoStocksText = Convert.ToString(tokyoStocksRead.GetValue(0));
                int tokyoStocks = Convert.ToInt32(tokyoStocksRead.GetValue(0));
                tokyoStockLbl.Text = tokyoStocks + " Left";
                if (tokyoStocks == 0)
                {
                    //disables soldout product
                    tokyoSoldOut.Image = Properties.Resources.soldout;
                    //disables quantity selector
                    tokyoQ.Enabled = false;
                }
            }
            connection.Close();

            //re-open connection to avoid error
            connection.Open();
            SqlCommand getShanghaiStocks = new SqlCommand(selectStock = "SELECT stocks from dbo.Shoes where productCode = 3", connection);
            SqlDataReader shanghaiStocksRead = getShanghaiStocks.ExecuteReader();
            if (shanghaiStocksRead.Read())
            {
                //displays the stocks
                string shanghaiStocksText = Convert.ToString(shanghaiStocksRead.GetValue(0));
                int shanghaiStocks = Convert.ToInt32(shanghaiStocksRead.GetValue(0));
                shanghaiStockLbl.Text = shanghaiStocks + " Left";
                if (shanghaiStocks == 0)
                {
                    //disables soldout product
                    shanghaiSoldOut.Image = Properties.Resources.soldout;
                    //disables quantity selector
                    shanghaiQ.Enabled = false;
                }
            }
            connection.Close();

            connection.Open();
            SqlCommand getGuangzhouStocks = new SqlCommand(selectStock = "SELECT stocks from dbo.Shoes where productCode = 4", connection);
            SqlDataReader guangzhouStocksRead = getGuangzhouStocks.ExecuteReader();
            if (guangzhouStocksRead.Read())
            {
                //displays the stocks
                string guangzhouStocksText = Convert.ToString(guangzhouStocksRead.GetValue(0));
                int guangzhouStocks = Convert.ToInt32(guangzhouStocksRead.GetValue(0));
                guangzhouStockLbl.Text = guangzhouStocks + " Left";
                if (guangzhouStocks == 0)
                {
                    //disables soldout product
                    guangzhouSoldOut.Image = Properties.Resources.soldout;
                    //disables quantity selector
                    guangzhouQ.Enabled = false;
                }
            }
            connection.Close();

            connection.Open();
            SqlCommand getHoustonStocks = new SqlCommand(selectStock = "SELECT stocks from dbo.Shoes where productCode = 5", connection);
            SqlDataReader houstonStocksRead = getHoustonStocks.ExecuteReader();
            if (houstonStocksRead.Read())
            {
                //displays the stocks
                string houstonStocksText = Convert.ToString(houstonStocksRead.GetValue(0));
                int houstonStocks = Convert.ToInt32(houstonStocksRead.GetValue(0));
                houstonStockLbl.Text = houstonStocks + " Left";
                if (houstonStocks == 0)
                {
                    //disables soldout product
                    houstonSoldOut.Image = Properties.Resources.soldout;
                    //disables quantity selector
                    houstonQ.Enabled = false;
                }
            }
            connection.Close();

            connection.Open();
            SqlCommand getLosAngelesStocks = new SqlCommand(selectStock = "SELECT stocks from dbo.Shoes where productCode = 6", connection);
            SqlDataReader losAngelesStocksRead = getLosAngelesStocks.ExecuteReader();
            if (losAngelesStocksRead.Read())
            {
                //displays the stocks
                string losAngelesStocksText = Convert.ToString(losAngelesStocksRead.GetValue(0));
                int losAngelesStocks = Convert.ToInt32(losAngelesStocksRead.GetValue(0));
                losAngelesStockLbl.Text = losAngelesStocks + " Left";
                if (losAngelesStocks == 0)
                {
                    //disables soldout product
                    losAngelesSoldOut.Image = Properties.Resources.soldout;
                    //disables quantity selector
                    losAngelesQ.Enabled = false;
                }
            }
            connection.Close();

            connection.Open();
            SqlCommand getManilaStocks = new SqlCommand(selectStock = "SELECT stocks from dbo.Shoes where productCode = 7", connection);
            SqlDataReader manilaStocksRead = getManilaStocks.ExecuteReader();
            if (manilaStocksRead.Read())
            {
                //displays the stocks
                string manilaStocksText = Convert.ToString(manilaStocksRead.GetValue(0));
                int manilaStocks = Convert.ToInt32(manilaStocksRead.GetValue(0));
                manilaStockLbl.Text = manilaStocks + " Left";
                if (manilaStocks == 0)
                {
                    //disables soldout product
                    manilaSoldOut.Image = Properties.Resources.soldout;
                    //disables quantity selector
                    manilaQ.Enabled = false;
                }
            }
            connection.Close();

            connection.Open();
            SqlCommand getNewYorkStocks = new SqlCommand(selectStock = "SELECT stocks from dbo.Shoes where productCode = 8", connection);
            SqlDataReader newYorkStocksRead = getNewYorkStocks.ExecuteReader();
            if (newYorkStocksRead.Read())
            {
                //displays the stocks
                string newYorkStocksText = Convert.ToString(newYorkStocksRead.GetValue(0));
                int newYorkStocks = Convert.ToInt32(newYorkStocksRead.GetValue(0));
                newYorkStockLbl.Text = newYorkStocks + " Left";
                if (newYorkStocks == 0)
                {
                    //disables soldout product
                    newYorkSoldOut.Image = Properties.Resources.soldout;
                    //disables quantity selector
                    newYorkQ.Enabled = false;
                }
            }
            connection.Close();

            connection.Open();
            SqlCommand getBerlinStocks = new SqlCommand(selectStock = "SELECT stocks from dbo.Shoes where productCode = 9", connection);
            SqlDataReader berlinStocksRead = getBerlinStocks.ExecuteReader();
            if (berlinStocksRead.Read())
            {
                //displays the stocks
                string berlinStocksText = Convert.ToString(berlinStocksRead.GetValue(0));
                int berlinStocks = Convert.ToInt32(berlinStocksRead.GetValue(0));
                berlinStockLbl.Text = berlinStocks + " Left";
                if (berlinStocks == 0)
                {
                    //disables soldout product
                    berlinSoldOut.Image = Properties.Resources.soldout;
                    //disables quantity selector
                    berlinQ.Enabled = false;
                }
            }
            connection.Close();

            connection.Open();
            SqlCommand getMiamiStocks = new SqlCommand(selectStock = "SELECT stocks from dbo.Shoes where productCode = 10", connection);
            SqlDataReader miamiStocksRead = getMiamiStocks.ExecuteReader();
            if (miamiStocksRead.Read())
            {
                //displays the stocks
                string miamiStocksText = Convert.ToString(miamiStocksRead.GetValue(0));
                int miamiStocks = Convert.ToInt32(miamiStocksRead.GetValue(0));
                miamiStockLbl.Text = miamiStocks + " Left";
                if (miamiStocks == 0)
                {
                    //disables soldout product
                    miamiSoldOut.Image = Properties.Resources.soldout;
                    //disables quantity selector
                    miamiQ.Enabled = false;
                }
            }
            connection.Close();
        }
        private void checkOutBtn_Click(object sender, EventArgs e)
        {
            //gets the value of NumericUpDown
            beijing = Convert.ToInt32(beijingQ.Value);
            taipei = Convert.ToInt32(taipeiQ.Value);
            tokyo = Convert.ToInt32(tokyoQ.Value);
            shanghai = Convert.ToInt32(shanghaiQ.Value);
            guangzhou = Convert.ToInt32(guangzhouQ.Value);
            houston = Convert.ToInt32(houstonQ.Value);
            losAngeles = Convert.ToInt32(losAngelesQ.Value);
            manila = Convert.ToInt32(manilaQ.Value);
            newYork = Convert.ToInt32(newYorkQ.Value);
            berlin = Convert.ToInt32(berlinQ.Value);
            miami = Convert.ToInt32(miamiQ.Value);

            //selects needed variables
            SqlConnection connection = new SqlConnection(source);
            connection.Open();
            string selectBeijingStocks = "SELECT stocks from dbo.Shoes where productCode = 0";
            string updateBeijingStocks = "Update dbo.Shoes set stocks = stocks - '" + beijing + "' where productCode = 0";
            SqlCommand updateBeijingStock = new SqlCommand(updateBeijingStocks, connection);
            updateBeijingStock.ExecuteNonQuery();

            //reads variables
            SqlCommand getBeijingStocks = new SqlCommand(selectBeijingStocks, connection);
            SqlDataReader beijingStocksRead = getBeijingStocks.ExecuteReader();

            if (beijingStocksRead.Read())
            {

                int beijingStocks = Convert.ToInt32(beijingStocksRead.GetValue(0));
                beijingQ.Value = 0;
                beijingStockLbl.Text = beijingStocks + " Left";
                beijingQ.Maximum = Convert.ToInt32(beijingStocks);
                if (beijingStocks == 0)
                {
                    //disables soldout product
                    beijingSoldOut.Image = Properties.Resources.soldout;   
                    //disables quantity selector
                    beijingQ.Enabled = false;
                }
                else
                {
                    //checks if product is bought
                    beijingPrice = "Y";

                }
            }          
            connection.Close();

            connection.Open();            
            string selectTaipeiStocks = "SELECT stocks from dbo.Shoes where productCode = 1";
            string updateTaipeiStocks = "Update dbo.Shoes set stocks = stocks - '" + taipei + "' where productCode = 1";
            SqlCommand updateTaipeiStock = new SqlCommand(updateTaipeiStocks, connection);
            updateTaipeiStock.ExecuteNonQuery();
            
            SqlCommand getTaipeiStocks = new SqlCommand(selectTaipeiStocks, connection);
            SqlDataReader taipeiStocksRead = getTaipeiStocks.ExecuteReader();

            if (taipeiStocksRead.Read())
            {

                int taipeiStocks = Convert.ToInt32(taipeiStocksRead.GetValue(0));
                taipeiQ.Value = 0;
                taipeiStockLbl.Text = taipeiStocks + " Left";
                taipeiQ.Maximum = Convert.ToInt32(taipeiStocks);
                if (taipeiStocks == 0)
                {
                    //disables soldout product
                    taipeiSoldOut.Image = Properties.Resources.soldout;
                }
                else
                {
                    //checks if product is bought
                    taipeiPrice = "Y";
                }
            }
            connection.Close();

            connection.Open();
            string selectTokyoStocks = "SELECT stocks from dbo.Shoes where productCode = 2";
            string updateTokyoStocks = "Update dbo.Shoes set stocks = stocks - '" + tokyo + "' where productCode = 2";
            SqlCommand updateTokyoStock = new SqlCommand(updateTokyoStocks, connection);
            updateTokyoStock.ExecuteNonQuery();

            SqlCommand getTokyoStocks = new SqlCommand(selectTokyoStocks, connection);
            SqlDataReader tokyoStocksRead = getTokyoStocks.ExecuteReader();

            if (tokyoStocksRead.Read())
            {

                int tokyoStocks = Convert.ToInt32(tokyoStocksRead.GetValue(0));
                tokyoQ.Value = 0;
                tokyoStockLbl.Text = tokyoStocks + " Left";
                tokyoQ.Maximum = Convert.ToInt32(tokyoStocks);
                if (tokyoStocks == 0)
                {
                    //disables soldout product
                    tokyoSoldOut.Image = Properties.Resources.soldout;
                }
                else
                {
                    //checks if product is bought
                    tokyoPrice = "Y";
                }
            }
            connection.Close();

            connection.Open();
            string selectShanghaiStocks = "SELECT stocks from dbo.Shoes where productCode = 3";
            string updateShanghaiStocks = "Update dbo.Shoes set stocks = stocks - '" + shanghai + "' where productCode = 3";
            SqlCommand updateShanghaiStock = new SqlCommand(updateShanghaiStocks, connection);
            updateShanghaiStock.ExecuteNonQuery();

            SqlCommand getShanghaiStocks = new SqlCommand(selectShanghaiStocks, connection);
            SqlDataReader shanghaiStocksRead = getShanghaiStocks.ExecuteReader();

            if (shanghaiStocksRead.Read())
            {

                int shanghaiStocks = Convert.ToInt32(shanghaiStocksRead.GetValue(0));
                shanghaiQ.Value = 0;
                shanghaiStockLbl.Text = shanghaiStocks + " Left";
                shanghaiQ.Maximum = Convert.ToInt32(shanghaiStocks);
                if (shanghaiStocks == 0)
                {
                    //disables soldout product
                    shanghaiSoldOut.Image = Properties.Resources.soldout;
                }
                else
                {
                    //checks if product is bought
                    shanghaiPrice = "Y";
                }
            }
            connection.Close();

            connection.Open();
            string selectGuangzhouStocks = "SELECT stocks from dbo.Shoes where productCode = 4";
            string updateGuangzhouStocks = "Update dbo.Shoes set stocks = stocks - '" + guangzhou + "' where productCode = 4";
            SqlCommand updateGuangzhouStock = new SqlCommand(updateGuangzhouStocks, connection);
            updateGuangzhouStock.ExecuteNonQuery();

            SqlCommand getGuangzhouStocks = new SqlCommand(selectGuangzhouStocks, connection);
            SqlDataReader guangzhouStocksRead = getGuangzhouStocks.ExecuteReader();

            if (guangzhouStocksRead.Read())
            {

                int guangzhouStocks = Convert.ToInt32(guangzhouStocksRead.GetValue(0));
                guangzhouQ.Value = 0;
                guangzhouStockLbl.Text = guangzhouStocks + " Left";
                guangzhouQ.Maximum = Convert.ToInt32(guangzhouStocks);
                if (guangzhouStocks == 0)
                {
                    //disables soldout product
                    guangzhouSoldOut.Image = Properties.Resources.soldout;
                }
                else
                {
                    //checks if product is bought
                    guangzhouPrice = "Y";
                }
            }
            connection.Close();

            connection.Open();
            string selectHoustonStocks = "SELECT stocks from dbo.Shoes where productCode = 5";
            string updateHoustonStocks = "Update dbo.Shoes set stocks = stocks - '" + houston + "' where productCode = 5";
            SqlCommand updateHoustonStock = new SqlCommand(updateHoustonStocks, connection);
            updateHoustonStock.ExecuteNonQuery();

            SqlCommand getHoustonStocks = new SqlCommand(selectHoustonStocks, connection);
            SqlDataReader houstonStocksRead = getHoustonStocks.ExecuteReader();

            if (houstonStocksRead.Read())
            {

                int houstonStocks = Convert.ToInt32(houstonStocksRead.GetValue(0));
                houstonQ.Value = 0;
                houstonStockLbl.Text = houstonStocks + " Left";
                houstonQ.Maximum = Convert.ToInt32(houstonStocks);
                if (houstonStocks == 0)
                {
                    //disables soldout product
                    houstonSoldOut.Image = Properties.Resources.soldout;
                }
                else
                {
                    //checks if product is bought
                    houstonPrice = "Y";
                }
            }
            connection.Close();

            connection.Open();
            string selectLosAngelesStocks = "SELECT stocks from dbo.Shoes where productCode = 6";
            string updateLosAngelesStocks = "Update dbo.Shoes set stocks = stocks - '" + losAngeles + "' where productCode = 6";
            SqlCommand updateLosAngelesStock = new SqlCommand(updateLosAngelesStocks, connection);
            updateLosAngelesStock.ExecuteNonQuery();

            SqlCommand getLosAngelesStocks = new SqlCommand(selectLosAngelesStocks, connection);
            SqlDataReader losAngelesStocksRead = getLosAngelesStocks.ExecuteReader();

            if (losAngelesStocksRead.Read())
            {

                int losAngelesStocks = Convert.ToInt32(losAngelesStocksRead.GetValue(0));
                losAngelesQ.Value = 0;
                losAngelesStockLbl.Text = losAngelesStocks + " Left";
                losAngelesQ.Maximum = Convert.ToInt32(losAngelesStocks);
                if (losAngelesStocks == 0)
                {
                    //disables soldout product
                    losAngelesSoldOut.Image = Properties.Resources.soldout;
                }
                else
                {
                    //checks if product is bought
                    losAngelesPrice = "Y";
                }
            }
            connection.Close();


            connection.Open();
            string selectManilaStocks = "SELECT stocks from dbo.Shoes where productCode = 7";
            string updateManilaStocks = "Update dbo.Shoes set stocks = stocks - '" + manila + "' where productCode = 7";
            SqlCommand updateManilaStock = new SqlCommand(updateManilaStocks, connection);
            updateManilaStock.ExecuteNonQuery();

            SqlCommand getManilaStocks = new SqlCommand(selectManilaStocks, connection);
            SqlDataReader manilaStocksRead = getManilaStocks.ExecuteReader();

            if (manilaStocksRead.Read())
            {

                int manilaStocks = Convert.ToInt32(manilaStocksRead.GetValue(0));
                manilaQ.Value = 0;
                manilaStockLbl.Text = manilaStocks + " Left";
                manilaQ.Maximum = Convert.ToInt32(manilaStocks);
                if (manilaStocks == 0)
                {
                    //disables soldout product
                    manilaSoldOut.Image = Properties.Resources.soldout;
                }
                else
                {
                    //checks if product is bought
                    manilaPrice = "Y";
                }
            }
            connection.Close();

            connection.Open();
            string selectNewYorkStocks = "SELECT stocks from dbo.Shoes where productCode = 8";
            string updateNewYorkStocks = "Update dbo.Shoes set stocks = stocks - '" + newYork + "' where productCode = 8";
            SqlCommand updateNewYorkStock = new SqlCommand(updateNewYorkStocks, connection);
            updateNewYorkStock.ExecuteNonQuery();

            SqlCommand getNewYorkStocks = new SqlCommand(selectNewYorkStocks, connection);
            SqlDataReader newYorkStocksRead = getNewYorkStocks.ExecuteReader();

            if (newYorkStocksRead.Read())
            {

                int newYorkStocks = Convert.ToInt32(newYorkStocksRead.GetValue(0));
                newYorkQ.Value = 0;
                newYorkStockLbl.Text = newYorkStocks + " Left";
                newYorkQ.Maximum = Convert.ToInt32(newYorkStocks);
                if (newYorkStocks == 0)
                {
                    //disables soldout product
                    newYorkSoldOut.Image = Properties.Resources.soldout;
                }
                else
                {
                    //checks if product is bought
                    newYorkPrice = "Y";
                }
            }
            connection.Close();

            connection.Open();
            string selectBerlinStocks = "SELECT stocks from dbo.Shoes where productCode = 9";
            string updateBerlinStocks = "Update dbo.Shoes set stocks = stocks - '" + berlin + "' where productCode = 9";
            SqlCommand updateBerlinStock = new SqlCommand(updateBerlinStocks, connection);
            updateBerlinStock.ExecuteNonQuery();

            SqlCommand getBerlinStocks = new SqlCommand(selectBerlinStocks, connection);
            SqlDataReader berlinStocksRead = getBerlinStocks.ExecuteReader();

            if (berlinStocksRead.Read())
            {

                int berlinStocks = Convert.ToInt32(berlinStocksRead.GetValue(0));
                berlinQ.Value = 0;
                berlinStockLbl.Text = berlinStocks + " Left";
                berlinQ.Maximum = Convert.ToInt32(berlinStocks);
                if (berlinStocks == 0)
                {
                    //disables soldout product
                    berlinSoldOut.Image = Properties.Resources.soldout;
                }
                else
                {
                    //checks if product is bought
                    berlinPrice = "Y";
                }
            }
            connection.Close();

            connection.Open();
            string selectMiamiStocks = "SELECT stocks from dbo.Shoes where productCode = 10";
            string updateMiamiStocks = "Update dbo.Shoes set stocks = stocks - '" + miami + "' where productCode = 10";
            SqlCommand updateMiamiStock = new SqlCommand(updateMiamiStocks, connection);
            updateMiamiStock.ExecuteNonQuery();

            SqlCommand getMiamiStocks = new SqlCommand(selectMiamiStocks, connection);
            SqlDataReader miamiStocksRead = getMiamiStocks.ExecuteReader();

            if (miamiStocksRead.Read())
            {

                int miamiStocks = Convert.ToInt32(miamiStocksRead.GetValue(0));
                miamiQ.Value = 0;
                miamiStockLbl.Text = miamiStocks + " Left";
                miamiQ.Maximum = Convert.ToInt32(miamiStocks);
                if (miamiStocks == 0)
                {
                    //disables soldout product
                    miamiSoldOut.Image = Properties.Resources.soldout;
                }
                else
                {
                    //checks if product is bought
                    miamiPrice = "Y";
                }
            }

            connection.Close();

            cashout cashout = new cashout();
            this.Hide();
            cashout.Show();
        }
      
        private void beijingQ_ValueChanged(object sender, EventArgs e)
        {
            string selectStock;
            int beijingValue;
           

            SqlConnection connection = new SqlConnection(source);
            connection.Open();
            SqlCommand getBeijingStocks = new SqlCommand(selectStock = "SELECT stocks from dbo.Shoes where productCode = 0", connection);
            SqlDataReader beijingReader = getBeijingStocks.ExecuteReader(); ;

            if (beijingReader.Read())
            {
                //sets the maximmum value for NumericUpDown tool equal to total stocks of the item
                beijingValue = Convert.ToInt32(beijingReader.GetValue(0));
                beijingQ.Maximum = Convert.ToInt32(beijingReader.GetValue(0));
                if(beijingValue == 0)
                {
                    beijingSoldOut.Image = Properties.Resources.soldout;
                }
            }
            connection.Close();

        }

        private void taipeiQ_ValueChanged(object sender, EventArgs e)
        {
            string selectStock;
            int taipeiValue;

            SqlConnection connection = new SqlConnection(source);
            connection.Open();
            SqlCommand getTaipeiStocks = new SqlCommand(selectStock = "SELECT stocks from dbo.Shoes where productCode = 1", connection);
            SqlDataReader taipeiReader = getTaipeiStocks.ExecuteReader(); ;

            if (taipeiReader.Read())
            {
                //sets the maximmum value for NumericUpDown tool equal to total stocks of the item
                taipeiValue = Convert.ToInt32(taipeiReader.GetValue(0));
                taipeiQ.Maximum = Convert.ToInt32(taipeiReader.GetValue(0));
                if (taipeiValue == 0)
                {
                    taipeiSoldOut.Image = Properties.Resources.soldout;
                }
            }
            connection.Close();
        }

        private void tokyoQ_ValueChanged(object sender, EventArgs e)
        {
            string selectStock;
            int tokyoValue;

            SqlConnection connection = new SqlConnection(source);
            connection.Open();
            SqlCommand getTokyoStocks = new SqlCommand(selectStock = "SELECT stocks from dbo.Shoes where productCode = 2", connection);
            SqlDataReader tokyoReader = getTokyoStocks.ExecuteReader(); ;

            if (tokyoReader.Read())
            {
                //sets the maximmum value for NumericUpDown tool equal to total stocks of the item
                tokyoValue = Convert.ToInt32(tokyoReader.GetValue(0));
                tokyoQ.Maximum = Convert.ToInt32(tokyoReader.GetValue(0));
                if (tokyoValue == 0)
                {
                    tokyoSoldOut.Image = Properties.Resources.soldout;
                }
            }
            connection.Close();


        }

        private void shanghaiQ_ValueChanged(object sender, EventArgs e)
        {
            string selectStock;
            int shanghaiValue;

            SqlConnection connection = new SqlConnection(source);
            connection.Open();
            SqlCommand getShanghaiStocks = new SqlCommand(selectStock = "SELECT stocks from dbo.Shoes where productCode = 3", connection);
            SqlDataReader shanghaiReader = getShanghaiStocks.ExecuteReader(); ;

            if (shanghaiReader.Read())
            {
                //sets the maximmum value for NumericUpDown tool equal to total stocks of the item
                shanghaiValue = Convert.ToInt32(shanghaiReader.GetValue(0));
                shanghaiQ.Maximum = Convert.ToInt32(shanghaiReader.GetValue(0));
                if (shanghaiValue == 0)
                {
                    shanghaiSoldOut.Image = Properties.Resources.soldout;
                }
            }
            connection.Close();

        }

        private void guangzhouQ_ValueChanged(object sender, EventArgs e)
        {
            string selectStock;
            int guangzhouValue;

            SqlConnection connection = new SqlConnection(source);
            connection.Open();
            SqlCommand getGuangzhouStocks = new SqlCommand(selectStock = "SELECT stocks from dbo.Shoes where productCode = 4", connection);
            SqlDataReader guangzhouReader = getGuangzhouStocks.ExecuteReader(); ;

            if (guangzhouReader.Read())
            {
                //sets the maximmum value for NumericUpDown tool equal to total stocks of the item
                guangzhouValue = Convert.ToInt32(guangzhouReader.GetValue(0));
                guangzhouQ.Maximum = Convert.ToInt32(guangzhouReader.GetValue(0));
                if (guangzhouValue == 0)
                {
                    guangzhouSoldOut.Image = Properties.Resources.soldout;
                }
            }
            connection.Close();
        }

        private void houstonQ_ValueChanged(object sender, EventArgs e)
        {
            string selectStock;
            int houstonValue;

            SqlConnection connection = new SqlConnection(source);
            connection.Open();
            SqlCommand getHoustonStocks = new SqlCommand(selectStock = "SELECT stocks from dbo.Shoes where productCode = 5", connection);
            SqlDataReader houstonReader = getHoustonStocks.ExecuteReader(); ;

            if (houstonReader.Read())
            {
                //sets the maximmum value for NumericUpDown tool equal to total stocks of the item
                houstonValue = Convert.ToInt32(houstonReader.GetValue(0));
                houstonQ.Maximum = Convert.ToInt32(houstonReader.GetValue(0));
                if (houstonValue == 0)
                {
                    houstonSoldOut.Image = Properties.Resources.soldout;
                }
            }
            connection.Close();
        }

    
        private void losAngelesQ_ValueChanged(object sender, EventArgs e)
        {
            string selectStock;
            int losAngelesValue;

            SqlConnection connection = new SqlConnection(source);
            connection.Open();
            SqlCommand getLosAngelesStocks = new SqlCommand(selectStock = "SELECT stocks from dbo.Shoes where productCode = 6", connection);
            SqlDataReader losAngelesReader = getLosAngelesStocks.ExecuteReader(); ;

            if (losAngelesReader.Read())
            {
                //sets the maximmum value for NumericUpDown tool equal to total stocks of the item
                losAngelesValue = Convert.ToInt32(losAngelesReader.GetValue(0));
                losAngelesQ.Maximum = Convert.ToInt32(losAngelesReader.GetValue(0));
                if (losAngelesValue == 0)
                {
                    losAngelesSoldOut.Image = Properties.Resources.soldout;
                }
            }
            connection.Close();
        }

        private void manilaQ_ValueChanged(object sender, EventArgs e)
        {
            string selectStock;
            int manilaValue;

            SqlConnection connection = new SqlConnection(source);
            connection.Open();
            SqlCommand getManilaStocks = new SqlCommand(selectStock = "SELECT stocks from dbo.Shoes where productCode = 7", connection);
            SqlDataReader manilaReader = getManilaStocks.ExecuteReader(); ;

            if (manilaReader.Read())
            {
                //sets the maximmum value for NumericUpDown tool equal to total stocks of the item
                manilaValue = Convert.ToInt32(manilaReader.GetValue(0));
                manilaQ.Maximum = Convert.ToInt32(manilaReader.GetValue(0));
                if (manilaValue == 0)
                {
                    manilaSoldOut.Image = Properties.Resources.soldout;
                }
            }
            connection.Close();
        }

        private void newYorkQ_ValueChanged(object sender, EventArgs e)
        {
            string selectStock;
            int newYorkValue;

            SqlConnection connection = new SqlConnection(source);
            connection.Open();
            SqlCommand getNewYorkStocks = new SqlCommand(selectStock = "SELECT stocks from dbo.Shoes where productCode = 8", connection);
            SqlDataReader newYorkReader = getNewYorkStocks.ExecuteReader(); ;

            if (newYorkReader.Read())
            {
                //sets the maximmum value for NumericUpDown tool equal to total stocks of the item
                newYorkValue = Convert.ToInt32(newYorkReader.GetValue(0));
                newYorkQ.Maximum = Convert.ToInt32(newYorkReader.GetValue(0));
                if (newYorkValue == 0)
                {
                    newYorkSoldOut.Image = Properties.Resources.soldout;
                }
            }
            connection.Close();
        }

        private void berlinQ_ValueChanged(object sender, EventArgs e)
        {
            string selectStock;
            int berlinValue;

            SqlConnection connection = new SqlConnection(source);
            connection.Open();
            SqlCommand getBerlinStocks = new SqlCommand(selectStock = "SELECT stocks from dbo.Shoes where productCode = 9", connection);
            SqlDataReader berlinReader = getBerlinStocks.ExecuteReader(); ;

            if (berlinReader.Read())
            {
                //sets the maximmum value for NumericUpDown tool equal to total stocks of the item
                berlinValue = Convert.ToInt32(berlinReader.GetValue(0));
                berlinQ.Maximum = Convert.ToInt32(berlinReader.GetValue(0));
                if (berlinValue == 0)
                {
                    berlinSoldOut.Image = Properties.Resources.soldout;
                }
            }
            connection.Close();
        }

        private void miamiQ_ValueChanged(object sender, EventArgs e)
        {
            string selectStock;
            int miamiValue;

            SqlConnection connection = new SqlConnection(source);
            connection.Open();
            SqlCommand getMiamiStocks = new SqlCommand(selectStock = "SELECT stocks from dbo.Shoes where productCode = 10", connection);
            SqlDataReader miamiReader = getMiamiStocks.ExecuteReader(); ;

            if (miamiReader.Read())
            {
                //sets the maximmum value for NumericUpDown tool equal to total stocks of the item
                miamiValue = Convert.ToInt32(miamiReader.GetValue(0));
                miamiQ.Maximum = Convert.ToInt32(miamiReader.GetValue(0));
                if (miamiValue == 0)
                {
                    miamiSoldOut.Image = Properties.Resources.soldout;
                }
            }
            connection.Close();
        }







        public static string beijingPrice;
        public static string taipeiPrice;
        public static string tokyoPrice;
        public static string shanghaiPrice;
        public static string guangzhouPrice;
        public static string houstonPrice;
        public static string losAngelesPrice;
        public static string manilaPrice;
        public static string newYorkPrice;
        public static string berlinPrice;
        public static string miamiPrice;

        public static int beijing;
        public static int taipei;
        public static int tokyo;
        public static int shanghai;
        public static int guangzhou;
        public static int houston;
        public static int losAngeles;
        public static int manila;
        public static int newYork;
        public static int berlin;
        public static int miami;

    }
}
