using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using CityInformationWebApp_3layer_Arch_LT_.DAL.Gateway;
using CityInformationWebApp_3layer_Arch_LT_.DAL.Model;

namespace CityInformationWebApp_3layer_Arch_LT_.BLL
{
    public class CityManager
    {
        CityGateWay aCityGateWay = new CityGateWay();
        public string Save(City aCity)
        {
            if (aCity.Name =="" || aCity.Country == "" || aCity.About == "")
            {
                return "You Must Put All The Information";
            }
            if (aCity.Name.Length<4)
            {
                return "City Name Must Be 4 Characters Long!!!";
            }
            if (aCityGateWay.isCityExists(aCity.Name))
            {
                return "City: "+aCity.Name+" Is Already Exists!!";
            }
            int rowaffected = aCityGateWay.Save(aCity);
            if (rowaffected > 0)
            {
                return "City Information Saved";
            }
            return "City Informatio Not Saved";
        }

        public List<City> GetAllCities(string searchCity)
        {
            return aCityGateWay.GetAllCities(searchCity);
        }

        public List<City> GetAllCitiesByCountry(string searchCountry)
        {
            return aCityGateWay.GetAllCitiesByCountry(searchCountry);
        }
    }
}