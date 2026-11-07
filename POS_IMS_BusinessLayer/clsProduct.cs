using POS_IMS_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_IMS_BusinessLayer
{
    public class clsProduct {

        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string SKU { get; set; }
        public string BarCode { get; set; }
        public decimal SellPrice { get; set; }
        public decimal PurchasePrice { get; set; }
        public int QuantityInStock { get; set; }
        public int MinimumStock { get; set; }
        public string ImagePath { get; set; }
        public int BrandID_FK { get; set; }
        public int CategoryID_FK { get; set; }
        public bool IsActive { get; set; }

        public clsCategory CategoryInfo { get; set; }
        public clsBrands BrandInfo { get; set; }
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode _Mode;


        public clsProduct(string ProductName, string SKU, string BarCode, decimal SellPrice, decimal PurchasePrice, int MinimumStock, string ImagePath, int BrandID_FK, int CategoryID_FK, bool IsActive) {
        
            this.ProductName = ProductName;
            this.SKU = SKU;
            this.BarCode = BarCode;
            this.SellPrice = SellPrice;
            this.PurchasePrice = PurchasePrice;
            this.QuantityInStock = 0;
            this.MinimumStock = MinimumStock;
            this.ImagePath = ImagePath;
            this.BrandID_FK = BrandID_FK;
            this.CategoryID_FK = CategoryID_FK;
            this.IsActive = true;
            this._Mode = enMode.AddNew;
        }
        private clsProduct(int ProductID, string ProductName, string SKU, string BarCode, decimal SellPrice, decimal PurchasePrice, int QuantityInStock, int MinimumStock, string ImagePath, int BrandID_FK, int CategoryID_FK, bool IsActive) { 
        
            this.ProductID = ProductID;
            this.ProductName = ProductName;
            this.SKU = SKU;
            this.BarCode = BarCode;
            this.SellPrice = SellPrice;
            this.PurchasePrice = PurchasePrice;
            this.QuantityInStock = QuantityInStock;
            this.MinimumStock = MinimumStock;
            this.ImagePath = ImagePath;
            this.BrandID_FK = BrandID_FK;
            this.CategoryID_FK = CategoryID_FK;
            this.IsActive = IsActive;
            this.CategoryInfo = clsCategory.GetCategoryByID(this.CategoryID_FK);
            this.BrandInfo = clsBrands.GetBrandByID(this.BrandID_FK);
            this._Mode = enMode.Update;
        }



        static public DataTable GetAllProducts() {

            return clsProducts_DataAccess.GetAllProducts();
        }
        static public DataTable DisplayAllProducts()
        {

            return clsProducts_DataAccess.DisplayAllProducts();
        }
        static public bool DeleteProduct(int ProductID) { 
            
            return clsProducts_DataAccess.DeleteProduct(ProductID);
        }
        static public clsProduct GetProductByID(int ProductID) {

            int QuantityInStock = 0, MinimumStock = 0, BrandID_FK = 0, CategoryID_FK = 0;
            string ProductName = "", SKU = "", BarCode = "", ImagePath = "";
            bool IsActive = false;
            decimal SellPrice = 0, PurchasePrice = 0;

            if (clsProducts_DataAccess.GetProductByID(ProductID, ref ProductName, ref SKU, ref BarCode, ref SellPrice, ref PurchasePrice, ref QuantityInStock, ref MinimumStock, ref ImagePath, ref BrandID_FK, ref CategoryID_FK, ref IsActive)) {

                return new clsProduct(ProductID, ProductName, SKU, BarCode, SellPrice, PurchasePrice, QuantityInStock, MinimumStock, ImagePath, BrandID_FK, CategoryID_FK, IsActive);
            }
            else
                return null;
        }
        public bool AddNewProduct() {

            this.ProductID = clsProducts_DataAccess.AddNewProduct(this.ProductName, this.SKU, this.BarCode, this.SellPrice, this.PurchasePrice, this.CategoryID_FK, this.MinimumStock, this.ImagePath, this.BrandID_FK);
            return (this.ProductID != -1);
        }
        public bool UpdateProduct() {

            return clsProducts_DataAccess.UpdateProduct(this.ProductID, this.ProductName, this.SKU, this.BarCode, this.SellPrice, this.PurchasePrice, this.QuantityInStock, this.MinimumStock, this.ImagePath, this.BrandID_FK, this.CategoryID_FK, this.IsActive);
        }
        static public clsProduct GetProductByBarCode(string BarCode)
        {

            int QuantityInStock = 0, MinimumStock = 0, BrandID_FK = 0, CategoryID_FK = 0, ProductID = 0;
            string ProductName = "", SKU = "", ImagePath = "";
            bool IsActive = false;
            decimal SellPrice = 0, PurchasePrice = 0;

            if (clsProducts_DataAccess.GetProductByBarCode(BarCode, ref ProductID, ref ProductName, ref SKU, ref SellPrice, ref PurchasePrice, ref QuantityInStock, ref MinimumStock, ref ImagePath, ref BrandID_FK, ref CategoryID_FK, ref IsActive))
            {

                return new clsProduct(ProductID, ProductName, SKU, BarCode, SellPrice, PurchasePrice, QuantityInStock, MinimumStock, ImagePath, BrandID_FK, CategoryID_FK, IsActive);
            }
            else
                return null;
        }
        static public clsProduct GetProductBySKU(string SKU)
        {

            int QuantityInStock = 0, MinimumStock = 0, BrandID_FK = 0, CategoryID_FK = 0, ProductID = 0;
            string ProductName = "", BarCode = "", ImagePath = "";
            bool IsActive = false;
            decimal SellPrice = 0, PurchasePrice = 0;

            if (clsProducts_DataAccess.GetProductBySKU(SKU, ref ProductID, ref ProductName, ref BarCode, ref SellPrice, ref PurchasePrice, ref QuantityInStock, ref MinimumStock, ref ImagePath, ref BrandID_FK, ref CategoryID_FK, ref IsActive))
            {

                return new clsProduct(ProductID, ProductName, SKU, BarCode, SellPrice, PurchasePrice, QuantityInStock, MinimumStock, ImagePath, BrandID_FK, CategoryID_FK, IsActive);
            }
            else
                return null;
        }
        static public clsProduct GetProductByName(string ProductName)
        {
            int QuantityInStock = 0, MinimumStock = 0, BrandID_FK = 0, CategoryID_FK = 0, ProductID = 0;
            string SKU = "", BarCode = "", ImagePath = "";
            bool IsActive = false;
            decimal SellPrice = 0, PurchasePrice = 0;

            if (clsProducts_DataAccess.GetProductByName(ProductName, ref ProductID, ref SKU, ref BarCode, ref SellPrice, ref PurchasePrice, ref QuantityInStock, ref MinimumStock, ref ImagePath, ref BrandID_FK, ref CategoryID_FK, ref IsActive))
            {

                return new clsProduct(ProductID, ProductName, SKU, BarCode, SellPrice, PurchasePrice, QuantityInStock, MinimumStock, ImagePath, BrandID_FK, CategoryID_FK, IsActive);
            }
            else
                return null;
        }
        public bool Save() {

            switch (_Mode) { 
            
                case enMode.AddNew:

                    if (AddNewProduct()) { 
                        
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                case enMode.Update:
                    return UpdateProduct();
            }
            return false;
        }
        static public bool ReverseActivationStatus(int ProductID) { 
            
            clsProduct Product = GetProductByID(ProductID);

            if (Product.IsActive)
                Product.IsActive = false;
            else
                Product.IsActive = true;

            return Product.Save();
        }
    }
}
