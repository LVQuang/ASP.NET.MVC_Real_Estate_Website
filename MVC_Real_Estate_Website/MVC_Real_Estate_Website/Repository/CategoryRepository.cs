using BaiTapTuan01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls.Adapters;

namespace BaiTapTuan01.Repository
{
    public class CategoryRepository
    {
        readonly private MyDB myDB;
        public CategoryRepository()
        {
            myDB = new MyDB();
        }
        public List<Category> GetAll()
        {
            return myDB.Categories.Where(category => category.hide == false).OrderBy(category => category.order).ToList();
        }

    }
}