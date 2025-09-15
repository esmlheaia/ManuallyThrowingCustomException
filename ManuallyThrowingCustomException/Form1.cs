using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManuallyThrowingCustomException
{
    public partial class frmAddProduct : Form
    {
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
            string[] ListOfProductCategory = { "Beverages", "Bread/Bakery", "Canned/ Jarred Goods", "Dairy", "Frozen Goods", "Meat", "Personal Care", "Other" };
        }
        foreach(string category in ListOfProductCategory)
        {
            cmbCategory.Items.Add(category);
        }
}
public string Product_Name(string name)
{
    if (!Regex.IsMatch(name, @"^[a-zA-Z]+$"))
        //Exception here
        return name;
}
public int Quantity(string qty)
{
    if (!Regex.IsMatch(qty, @"^[0-9]"))
        //Exception here
        return Convert.ToInt32(qty);
}
public double SellingPrice(string price)
{
    if (!Regex.IsMatch(price.ToString(), @"^(\d*\.)?\d+$"))
        //Exception here
        return Convert.ToDouble(price);
}
}
