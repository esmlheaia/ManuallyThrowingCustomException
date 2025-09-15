using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace ManuallyThrowingCustomException
{
    public partial class frmAddProduct : Form
    {
        class NumberFormatException : Exception
        {
            public NumberFormatException(string quantity) : base(quantity) { }
        }
        class StringFormatException : Exception
        {
            public StringFormatException(string name) : base(name) { }
        }
        class CurrencyFormatException : Exception
        {
            public CurrencyFormatException(string price) : base(price) { }
        }
        // declare the variable and set an access modifier
        private string _ProductName, _Category, _MfgDate, _ExpDate, _Description;
        private int _Quantity;
        private double _SellPrice;
        public BindingSource showProductList;
        public frmAddProduct()
        {
            InitializeComponent();
            showProductList = new BindingSource();
        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            //array list for list of product category
            string[] ListOfProductCategory = new string[] { 
                "Beverages", 
                "Bread/Bakery", 
                "Canned/ Jarred Goods", 
                "Dairy", 
                "Frozen Goods", 
                "Meat", 
                "Personal Care", 
                "Other" };
            
            foreach (stirng category in ListOfProductCategory)
            {
                cbCategory.Items.Add(category);
            }
        }
            public string Product_Name(string name)
        {
            try
            {
            if (!Regex.IsMatch(name, @"^[a-zA-Z]+$"))
            {
                throw new StringFormatException(name);
            }
        }
            catch (StringFormatException ex)
            {
                MessageBox.Show("Invalid Product Name: " + ex.Message);
            }
                return name;
        }
        public int Quantity(string qty)
        {
            try
            {
                if (!Regex.IsMatch(qty, @"^[0-9]"))
                {
                    throw new StringFormatException(qty);
                }
            }
            catch (NumberFormatException ex)
            {
                MessageBox.Show("Invalid Quantity: " + ex.Message);
            }
                return Convert.ToInt32(qty);
        }
        public double SellingPrice(string price)
        {
            try
            {
                if (!Regex.IsMatch(price.ToString(), @"^(\d*\.)?\d+$"))
                {
                    throw new CurrencyFormatException(price);
                }
            }
            catch (CurrencyFormatException ex)
            {
                MessageBox.Show("Invalid Selling Price: " + ex.Message);
            }
                return Convert.ToDouble(price);
        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            _ProductName = Product_Name(txtProductName.Text);
            _Category = cbCategory.Text;
            _MfgDate = dateTimeMfg.Value.ToString("yyyy-MM-dd");
            _ExpDate = dateTimeExp.Value.ToString("yyyy-MM-dd");
            _Quantity = Quantity(txtQty.Text);
            _SellPrice = SellingPrice(txtSellPrice.Text);
            _Description = richTxtDescription.Text;
            showProductList.Add(new ProductClass(_ProductName, _Category, _MfgDate, _ExpDate, _Quantity, _SellPrice, _Description));
            gridViewProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridViewProductList.DataSource = showProductList;
        }
    }
}

            