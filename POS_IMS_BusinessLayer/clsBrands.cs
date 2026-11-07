using POS_IMS_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_IMS_BusinessLayer
{
    public class clsBrands {


        public int BrandID { get; set; }
        public string BrandName { get; set; }
        public string BrandDescription { get; set; }
        public bool IsActive { get; set; }

        public enum enMode { Add = 1, Update = 2 }
        public enMode _Mode = enMode.Add;

        public clsBrands(string BrandName, string BrandDescription, bool IsActive) { 
            
            this.BrandName = BrandName;
            this.BrandDescription = BrandDescription;
            this.IsActive = IsActive;
            _Mode = enMode.Add;
        }
        private clsBrands(int BrandID, string BrandName, string BrandDescription, bool IsActive) { 
            
            this.BrandID = BrandID;
            this.BrandName = BrandName;
            this.BrandDescription = BrandDescription;
            this.IsActive = IsActive;
            _Mode = enMode.Update;
        }

        public bool AddNewBrand() {

            this.BrandID = clsBrands_DataAccess.AddNewBrand(this.BrandName, this.BrandDescription, this.IsActive);
            return (this.BrandID != -1);
        }
        public bool UpdateBrand() {

            return clsBrands_DataAccess.UpdateBrand(this.BrandID, this.BrandName, this.BrandDescription, this.IsActive);
        }
        static public DataTable GetAllBrands() {

            return clsBrands_DataAccess.GetAllBrands();
        }
        static public bool DeleteBrand(int BrandID) { 
            
            return clsBrands_DataAccess.DeleteBrand(BrandID);
        }
        static public clsBrands GetBrandByID(int BrandID)
        {

            string BrandName = "", BrandDescription = "";
            bool IsActive = false;

            if (clsBrands_DataAccess.GetBrandByID(BrandID, ref BrandName, ref BrandDescription, ref IsActive))
            {
                return new clsBrands(BrandID, BrandName, BrandDescription, IsActive);
            }
            else
                return null;
        }
        static public clsBrands GetBrandByName(string BrandName)
        {
            int BrandID = 0;
            string BrandDescription = "";
            bool IsActive = false;

            if (clsBrands_DataAccess.GetBrandByName(BrandName, ref BrandID, ref BrandDescription, ref IsActive))
            {
                return new clsBrands(BrandID, BrandName, BrandDescription, IsActive);
            }
            else
                return null;
        }
        public bool Save() {

            switch (_Mode)
            {

                case enMode.Add:
                    if (AddNewBrand())
                    {

                        return true;
                    }
                    else
                    {

                        return false;
                    }
                case enMode.Update:
                    return UpdateBrand();

                default:
                    return false;
            }
            

        }
    }
}
