using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using LabTest_4_Set_B.Models;

namespace LabTest_4_Set_B.Gateway
{
    public class ItemGateway:CommonGateway
    {
        public List<Item> GetAllItems()
        {
            Query = "SELECT * FROM ItemTable";
            Command = new SqlCommand(Query,Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            List<Item> items = new List<Item>();

            while (Reader.Read())
            {
                Item aItem = new Item();

                aItem.Id = (int) Reader["Id"];
                aItem.Name = Reader["Name"].ToString();

                items.Add(aItem);
            }
            Reader.Close();
            Connection.Close();
            return items;
        }
    }
}