using System;
using Microsoft.Data.SqlClient;
using System.Data.Common;
using System.Data;
using BAIS3150_DemoApplication.Domain;

namespace BAIS3150_DemoApplication.TechnicalServices
{
    internal class Categories
    {
        public List<Category> ViewCategories()
        {
            List<Category> MyCategories = new();

            //connection
            SqlConnection MyDataSource = new();
            MyDataSource.ConnectionString = @"Persist Security Info=False;Database=Northwind;Server=dev1.baist.ca;User ID=emallo1;Password=Dalu21";
            MyDataSource.Open();

            //command
            SqlCommand MyCommand = new()
            {
                Connection = MyDataSource,
                CommandType = CommandType.StoredProcedure,
                CommandText = "emallo1.GetNorthwindCategories"
            };

            SqlDataReader MyDataReader =  MyCommand.ExecuteReader();

            

            if (MyDataReader.HasRows)
            {

                while (MyDataReader.Read())
                {
                    Category MyProduct = new()
                    {
                        CategoryName = (string)MyDataReader["CategoryName"],
                        Description = (string)MyDataReader["Description"],
                        Picture = (byte[])MyDataReader["Picture"]
                    };
                    Console.WriteLine(MyProduct);
                    MyCategories.Add(MyProduct);                  

                }
            }
            MyDataReader.Close();
            MyDataSource.Close();

            return MyCategories;

        }
    }
}
