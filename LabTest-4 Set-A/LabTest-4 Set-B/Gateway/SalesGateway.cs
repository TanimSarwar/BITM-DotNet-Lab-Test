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
            Query = "INSERT INTO SalesTable VALUES (@stationaryName, @itemId, @price, @purpose)";
            Command = new SqlCommand(Query,Connection);
            Connection.Open();
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("stationaryName", sales.StationaryName);
            Command.Parameters.AddWithValue("itemId", sales.ItemId);
            Command.Parameters.AddWithValue("price", sales.Price);
            Command.Parameters.AddWithValue("purpose", sales.Purpose);
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }

        public List<Sales> SalesList(Sales sales)
        {
            Query = "SELECT * FROM SalesTable WHERE ItemId = @itemid";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("itemid", sales.ItemId);
            Reader = Command.ExecuteReader();
            List<Sales> saleslists = new List<Sales>();

            while (Reader.Read())
            {
                Sales aSales = new Sales();
                aSales.StationaryName = Reader["StationaryName"].ToString();
                aSales.Price = (int)Reader["Price"];
                aSales.Purpose = Reader["Purpose"].ToString();
                saleslists.Add(aSales);
            }
            Connection.Close();
            Reader.Close();
            return saleslists;

        }
    }
}