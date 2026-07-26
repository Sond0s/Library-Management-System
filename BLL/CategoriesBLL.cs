using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CategoriesBLL
    {

        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        public CategoriesBLL() { }

        public CategoriesBLL(int ID , string Name)
        {
            CategoryID = ID;
            CategoryName = Name;
        }

        public static DataTable ListAllCategories()
        {
            return CategoriesDAL.ListAllCategories();
        }

        public static CategoriesBLL FindCategoryByID(int ID)
        {
            string Name = "";
          if(CategoriesDAL.FindCategoryByID(ID ,ref Name))
            {
                return new CategoriesBLL(ID,Name);
            }
          else
            {
                return null;
            }
        }

        public static CategoriesBLL FindCategoryByName(string Name)
        {
            int ID = 0;

            if(CategoriesDAL.FindCategoryByName(ref ID , Name))
            {
                return new CategoriesBLL(ID,Name);

            }
            else
            {
                return null;
            }
        }


    }
}
