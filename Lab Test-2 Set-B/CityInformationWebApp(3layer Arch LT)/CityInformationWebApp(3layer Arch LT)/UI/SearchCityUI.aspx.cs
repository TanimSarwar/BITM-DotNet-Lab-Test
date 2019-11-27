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
    public partial class SearchCityUI : System.Web.UI.Page
    {
        CityManager aCityManager = new CityManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            PopulateGridView("");
            searchByCityRadioButton.Checked = true;
        }

        private void PopulateGridView(string searchCity)
        {
            List<City> cities = aCityManager.GetAllCities(searchCity);
            cityGridView.DataSource = cities;
            cityGridView.DataBind();
        }
        private void PopulateGridViewForCountrySearch(string searchCountry)
        {
            List<City> cities = aCityManager.GetAllCitiesByCountry(searchCountry);
            cityGridView.DataSource = cities;
            cityGridView.DataBind();
        }
        protected void searchButton_Click(object sender, EventArgs e)
        {
            if (searchByCityRadioButton.Checked)
            {
                string name = searchTextBox.Text;
                PopulateGridView(name);
                
            }
            if (searchByCountryRadioButton.Checked)
            {
                string name = searchTextBox.Text;
                PopulateGridViewForCountrySearch(name);
            }
            if (searchByCityRadioButton.Checked == false && searchByCountryRadioButton.Checked == false)
            {
                messageLabel.Text = "Search By Either Checking City or Country!!!";
            }
        }

        protected void clearButton_Click(object sender, EventArgs e)
        {
            searchByCityRadioButton.Checked = false;
            searchByCountryRadioButton.Checked = false;
            searchTextBox.Text = "";
            messageLabel.Text = "";
        }

       
    }
}