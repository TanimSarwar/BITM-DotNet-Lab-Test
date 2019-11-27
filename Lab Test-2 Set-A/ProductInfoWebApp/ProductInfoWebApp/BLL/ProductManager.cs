using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProductInfoWebApp.DAL.Gateway;
using ProductInfoWebApp.DAL.Model;

namespace ProductInfoWebApp.BLL
{
    public class ProductManager
    {
        ProductGateway aProductGateway=new ProductGateway();

        public string Save(Product aProduct)
        {

            if (aProduct.ProductCode.Length<3)
            {
                return "Put at least 3 characters";
            }
            if (aProduct.Quantity<0)
            {
                return "Quantity must be positive";
            }
            if (aProductGateway.IsProductExists(aProduct))
            {
                aProductGateway.Update(aProduct);
                return "" + aProduct.ProductCode + " is updated";
            }
            int rowAffected = aProductGateway.Save(aProduct);
            if (rowAffected>0)
            {
                return "Product saved";
            }
            return "Product not saved";
        }

        public List<Product> GetAllProducts()
        {
            return aProductGateway.GetAllProducts();
        }

        public int GetProductSum()
        {
            return aProductGateway.GetProductSum();
        }
        
    }
}