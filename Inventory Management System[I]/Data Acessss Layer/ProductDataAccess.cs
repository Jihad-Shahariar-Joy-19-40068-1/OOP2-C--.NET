﻿using Inventory_Management_System_I_.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System_I_.Data_Acessss_Layer
{
    class ProductDataAccess:DataAccess
    {
        public List<Product> GetProducts()
        {
            string sql = "SELECT * FROM Products";
            SqlDataReader reader = this.GetData(sql);
            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product product= new Product();
                product.ProductId = (int)reader["ProductId"];
                product.ProductName = reader["ProductName"].ToString();
                product.Price = Convert.ToDouble(reader["Price"]);
                product.Quantity = (int)reader["Quantity"];
                product.CategoryId = (int)reader["CategoryId"];
                products.Add(product);
            }
            return products;
        }
        public Product GetProductById(int productId)
        {
            string sql = "SELECT * FROM Products WHERE ProductId="+productId;
            SqlDataReader reader = this.GetData(sql);
            if(reader.HasRows)
            {
                reader.Read();
                Product product = new Product();
                product.ProductId = (int)reader["ProductId"];
                product.ProductName = reader["ProductName"].ToString();
                product.Price = Convert.ToDouble(reader["Price"]);
                product.Quantity = (int)reader["Quantity"];
                product.CategoryId = (int)reader["CategoryId"];
                return product;
            }
            return null;
        }

        public bool CreateProduct(string productName,double price, int quantity, int categoryId)
        {
            string sql = "INSERT INTO Products(ProductName,Price,Quantity,CategoryId) VALUES('"+productName+"','"+price+"','"+quantity+"','"+categoryId+"')";
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }
        public bool UpdateProduct(int productId, string productName, double price, int quantity, int categoryId)
        {
            string sql = "UPDATE Products SET ProductName = '"+productName+"',Price="+price+",Quantity="+quantity+",CategoryId="+categoryId+" WHERE ProductId="+productId;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }
        public bool DeleteProduct(int productId)
        {
            string sql = "DELETE FROM Products WHERE ProductId="+productId ;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }
    }
}
