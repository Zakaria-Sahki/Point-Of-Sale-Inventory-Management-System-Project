using POS_IMS_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_IMS_BusinessLayer
{
    public class clsCategory {


        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public bool IsActive { get; set; }

        public enum enMode { Add = 1, Update = 2 }
        public enMode Mode = enMode.Add;

        public clsCategory(string CategoryName, string CategoryDescription) { 
            
            this.CategoryName = CategoryName;
            this.CategoryDescription = CategoryDescription;
            this.IsActive = true;
            Mode = enMode.Add;
        }
        private clsCategory(int CategoryID, string CategoryName, string CategoryDescription, bool IsActive) { 
        
            this.CategoryID = CategoryID;
            this.CategoryName = CategoryName;
            this.CategoryDescription = CategoryDescription;
            this.IsActive = IsActive;
            Mode = enMode.Update;
        }


        public bool AddNewCategory() {

            this.CategoryID = clsCategories_DataAccess.AddNewCategory(this.CategoryName, this.CategoryDescription);
            return (this.CategoryID != -1);
        }
        public bool UpdateCategory() {

            return clsCategories_DataAccess.UpdateCategory(this.CategoryID, this.CategoryName, this.CategoryDescription, this.IsActive);
        }
        static public DataTable GetAllCategories() {

            return clsCategories_DataAccess.GetAllCategories();
        }
        static public bool DeleteCategory(int CategoryID) { 
        
            return clsCategories_DataAccess.DeleteCategory(CategoryID);
        }
        static public clsCategory GetCategoryByID(int CategoryID) {

            string CategoryName = "", CategoryDescription = "";
            bool IsActive = false;
            if (clsCategories_DataAccess.GetCategoryByID(CategoryID, ref CategoryName, ref CategoryDescription, ref IsActive)) { 
            
                return new clsCategory(CategoryID, CategoryName, CategoryDescription, IsActive);    
            }
            else
                return null;
        }
        static public clsCategory GetCategoryByCategoryName(string CategoryName)
        {
            int CategoryID = 0;
            string CategoryDescription = "";
            bool IsActive = false;
            if (clsCategories_DataAccess.GetCategoryByCategoryName(CategoryName, ref CategoryID, ref CategoryDescription, ref IsActive))
            {

                return new clsCategory(CategoryID, CategoryName, CategoryDescription, IsActive);
            }
            else
                return null;
        }
        public bool Save() {


            switch (Mode) {

                case enMode.Add:
                    if (AddNewCategory())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                case enMode.Update:
                    return UpdateCategory();
            }
            return false;
        }
    }
}
