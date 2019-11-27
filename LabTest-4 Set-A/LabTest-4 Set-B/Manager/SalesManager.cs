using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LabTest_4_Set_B.Gateway;
using LabTest_4_Set_B.Models;

namespace LabTest_4_Set_B.Manager
{
    public class SalesManager
    {
        SalesGateway aSalesGateway = new SalesGateway();

        public string Save(Sales sales)
        {
            int rowAffected = aSalesGateway.Save(sales);
            if (rowAffected>0)
            {
                return "Sales Information Saved";    
            }
            return "Sales Information Not Saved";
        }

        public List<Sales> SalesList(Sales sales)
        {
            return aSalesGateway.SalesList(sales);
        }
    }
}