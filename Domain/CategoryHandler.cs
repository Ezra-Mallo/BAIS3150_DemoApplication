using System;
using System.Collections.Generic;
using BAIS3150_DemoApplication.TechnicalServices;

namespace BAIS3150_DemoApplication.Domain
{
    public class CategoryHandler
    {
        public List<Category> GetCategories()
        {
            Categories CategoryManager = new();
            List<Category> MyCategories =  CategoryManager.ViewCategories();
            return MyCategories;
        }

    }
}
