using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuallyThrowingCustomException
{
    internal class ProductClass
    {
        private int _Quantity;
        private double _SellingPrice;
        private string _ProductName, _ProductCategory, _ManufacturingDate, _ExpirationDate, _Description;

        public ProductClass(string ProductName, string Category, string MfgDate, string ExpDate, int Quantity, double Price, string Description)
        {
            this._ProductName = ProductName;
            this._ProductCategory = Category;
            this._ManufacturingDate = MfgDate;
            this._ExpirationDate = ExpDate;
            this._Quantity = Quantity;
            this._SellingPrice = Price;
            this._Description = Description;
        }
        public string productName
        {
            get
            {
                return this._ProductName;
            }
            set
            {
                this._ProductName = value;
            }
        }
        public string category
        {
            get
            {
                return this._ProductCategory;
            }
            set
            {
                this._ProductCategory = value;
            }
        }
        public string manufacturingDate
        {
            get
            {
                return this._ManufacturingDate;
            }
            set
            {
                this._ManufacturingDate = value;
            }
        }
        public string expirationDate
        {
            get
            {
                return this._ExpirationDate;
            }
            set
            {
                this._ExpirationDate = value;
            }
        }
        public int quantity
        {
            get
            {
                return this._Quantity;
            }
            set
            {
                this._Quantity = value;
            }
        }
        public double sellingPrice
        {
            get
            {
                return this._SellingPrice;
            }
            set
            {
                this._SellingPrice = value;
            }
        }
        public string description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this._Description = value;
            }
        }
    }
}


