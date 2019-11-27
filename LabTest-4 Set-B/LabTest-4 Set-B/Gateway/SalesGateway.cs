using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using LabTest_4_Set_B.Models;

namespace LabTest_4_Set_B.Gateway
{
    public class SalesGateway:CommonGateway
    {
        public int Save(Sales sales)
        {
            Query = "INSERT INTO SalesTable VALUES (@quantity, @customername, @itemid)";
            Command = new SqlCommand(Query,Connection);
            Connection.Open();
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("quantity", sales.Quanity);
            Command.Parameters.AddWithValue("customername", sales.CustomerName);
            Command.Parameters.AddWithValue("itemid", sales.ItemId);
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }

        public List<Sales> SalesList(Sales sales)
        {
            Query = "SELECT SUM(Quantity) AS Total, CustomerName FROM SalesTable WHERE ItemId = @itemid GROUP BY CustomerName";
            Command= new SqlCommand(Query,Connection);
            Connection.Open();
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("itemid", sales.ItemId);
            Reader = Command.ExecuteReader();
            List<Sales> saleslists = new List<Sales>();

            while (Reader.Read())
            {
                Sales aSales = new Sales();
                aSales.CustomerName = Reader["CustomerName"].ToString();
                aSales.Quanity = (int) Reader["Total"];
                saleslists.Add(aSales);
            }
            Connection.Close();
            Reader.Close();
            return saleslists;

        }
    }
}