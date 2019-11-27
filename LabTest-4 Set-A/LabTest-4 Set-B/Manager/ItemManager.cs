using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LabTest_4_Set_B.Gateway;
using LabTest_4_Set_B.Models;

namespace LabTest_4_Set_B.Manager
{
    public class ItemManager
    {
        ItemGateway aItemGateway = new ItemGateway();

        public List<Item> GetAllItems()
        {
            return aItemGateway.GetAllItems();
        }
    }
}