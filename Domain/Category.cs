using System;
using BAIS3150_DemoApplication.TechnicalServices;

namespace BAIS3150_DemoApplication.Domain
{
    public class Category
    {
        private string _categoryName = string.Empty;
        private string _description = string.Empty;
        private byte[]? _picture;



        public string CategoryName
        {
            get { return _categoryName; }
            set { _categoryName = value; }
        }


        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public byte[] Picture
        {
            get { return _picture; }
            set { _picture = value; }
        }
    }
}
