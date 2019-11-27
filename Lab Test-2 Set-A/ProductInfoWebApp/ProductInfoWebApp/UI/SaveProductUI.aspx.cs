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
    public partial class SaveProductUI : System.Web.UI.Page
    {
        ProductManager aProductManager=new ProductManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            if (productCodeTextBox.Text == ""||descriptionTextBox.Text==""||quantityTextBox.Text=="")
            {
                messageLabel.Text="Put all information";
            }
            else
            {
                Product aProduct = new Product();
                aProduct.ProductCode = productCodeTextBox.Text;
                aProduct.Description = descriptionTextBox.Text;
                aProduct.Quantity = Convert.ToInt32(quantityTextBox.Text);
                messageLabel.Text = aProductManager.Save(aProduct);
            }
           

        }

        protected void clearButton_Click(object sender, EventArgs e)
        {
            productCodeTextBox.Text=String.Empty;
            descriptionTextBox.Text=String.Empty;
            quantityTextBox.Text=String.Empty;
        }

    }
}