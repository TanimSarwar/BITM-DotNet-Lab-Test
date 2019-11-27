using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CityInformationWebApp_3layer_Arch_LT_.BLL;
using CityInformationWebApp_3layer_Arch_LT_.DAL.Model;

namespace CityInformationWebApp_3layer_Arch_LT_.UI
{
    public partial class SaveCityUI : System.Web.UI.Page
    {
        CityManager aCityManager = new CityManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            City aCity = new City();
            aCity.Name = cityNameTextBox.Text;
            aCity.Country = countryTextBox.Text;
            aCity.About = aboutTextBox.Text;
            messageLabel.Text=aCityManager.Save(aCity);

        }

        protected void clearButton_Click(object sender, EventArgs e)
        {
            cityNameTextBox.Text = "";
            aboutTextBox.Text = "";
            countryTextBox.Text = "";
            messageLabel.Text = "";
        }
    }
}