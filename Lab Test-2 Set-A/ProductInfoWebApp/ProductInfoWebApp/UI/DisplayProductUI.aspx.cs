using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProductInfoWebApp.BLL;
using ProductInfoWebApp.DAL.Model;

namespace ProductInfoWebApp.UI
{
    public partial class DisplayProductUI : System.Web.UI.Page
    {
        ProductManager aProductManager=new ProductManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            PopulateGridView();
            int productQuantitySum = aProductManager.GetProductSum();
            countTextBox.Text = productQuantitySum.ToString();
        }

        private void PopulateGridView()
        {
            List<Product> products = aProductManager.GetAllProducts();
            productGridView.DataSource = products;
            productGridView.DataBind();
        }
    }
}