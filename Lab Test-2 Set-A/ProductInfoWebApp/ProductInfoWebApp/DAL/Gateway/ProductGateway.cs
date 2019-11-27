using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using ProductInfoWebApp.DAL.Model;

namespace ProductInfoWebApp.DAL.Gateway
{
    public class ProductGateway:Gateway
    {
        public int Save(Product aProduct)
        {
            Query = "INSERT INTO ProductInfo VALUES ('" + aProduct.ProductCode + "', " +
                    "'" + aProduct.Description + "','" + aProduct.Quantity + "')";
            Command =new SqlCommand(Query,Connection);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }

        public List<Product> GetAllProducts()
        {
            Query = "SELECT * FROM ProductInfo";
            Connection.Open();
            Command = new SqlCommand(Query, Connection);
            Reader = Command.ExecuteReader();
            List<Product> products = new List<Product>();
            while (Reader.Read())
            {
                Product aProduct = new Product();
                aProduct.ProductCode = Reader["ProductCode"].ToString();
                aProduct.Description = Reader["Description"].ToString();
                aProduct.Quantity = Convert.ToInt32(Reader["Quantity"].ToString());
                products.Add(aProduct);
            }
            Connection.Close();
            Reader.Close();
            return products;
        }
        public bool IsProductExists(Product aProduct)
        {
            Query = "SELECT * FROM ProductInfo WHERE ProductCode = '" + aProduct.ProductCode + "' ";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            bool hasRows = false;
            Reader = Command.ExecuteReader();
            if (Reader.HasRows)
            {
                hasRows = true;
            }
            Connection.Close();
            Reader.Close();
            return hasRows;
        }

        public int GetProductSum()
        {
            Query = "SELECT SUM(Quantity) FROM[ProductInfo]";
            Connection.Open();
            Command = new SqlCommand(Query, Connection);
            int sum = (int) Command.ExecuteScalar();
            Connection.Close();
            return sum;
        }
        public void Update(Product aProduct)
        {
            Query = "UPDATE ProductInfo SET Quantity = Quantity+'" + aProduct.Quantity + "' WHERE ProductCode = '" + aProduct.ProductCode + "'";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Command.ExecuteNonQuery();
            Connection.Close();
        }
    }
}