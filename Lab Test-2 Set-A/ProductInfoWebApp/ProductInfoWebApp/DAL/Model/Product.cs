using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductInfoWebApp.DAL.Model
{
    public class Product
    {
        public string ProductCode { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
    }
}