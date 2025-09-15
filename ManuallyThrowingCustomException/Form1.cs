using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        public frmAddProduct()
        {
            InitializeComponent();
        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            //array list for list of product category
            string[] ListOfProductCategory  = { "Beverages", "Bread/Bakery", "Canned/ Jarred Goods", "Dairy", "Frozen Goods", "Meat", "Personal Care", "Other" };
        }
    }
}
