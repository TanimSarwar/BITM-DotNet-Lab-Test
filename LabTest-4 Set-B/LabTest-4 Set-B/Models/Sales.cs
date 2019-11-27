using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace LabTest_4_Set_B.Models
{
    public class Sales
    {
        public int Quanity { get; set; }
        public int Id { get; set; }
        public int ItemId { get; set; }
        public string CustomerName { get; set; }
    }
}