using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using CityInformationWebApp_3layer_Arch_LT_.DAL.Model;
using CityInformationWebApp_3layer_Arch_LT_.UI;

namespace CityInformationWebApp_3layer_Arch_LT_.DAL.Gateway
{
    public class CityGateWay :Gateway
    {
        public bool isCityExists(string cityName)
        {
            Query = "SELECT * FROM CityInfo WHERE CityName = '" + cityName + "' ";
            Command = new SqlCommand(Query,Connection);
            Connection.Open();
            bool hasRows = false;
            Reader = Command.ExecuteReader();
            if (Reader.HasRows)
            {
                hasRows = true;
            }
            Connection.Close();
            Reader.Close();
            return hasRows;
        }

        public int Save(City aCity)
        {
            Query = "INSERT INTO CityInfo VALUES('" + aCity.Name + "','" + aCity.About + "','" + aCity.Country + "')";
            Command = new SqlCommand(Query,Connection);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }

        public List<City> GetAllCities(string searchCity)
        {

            if (searchCity == "")
            {
                Query = "SELECT * FROM CityInfo";
            }
            Query = "SELECT * FROM CityInfo WHERE CityName LIKE '"+searchCity+"%'";
            Connection.Open();
            Command= new SqlCommand(Query,Connection);
            Reader = Command.ExecuteReader();
            List<City> cities = new List<City>();
            while (Reader.Read())
            {
                City aCity = new City();
                aCity.Name = Reader["CityName"].ToString();
                aCity.About = Reader["About"].ToString();
                aCity.Country = Reader["Country"].ToString();
                cities.Add(aCity);
            }
            Connection.Close();
            Reader.Close();
            return cities;
        }

        public List<City> GetAllCitiesByCountry(string searchCountry)
        {
            Query = "SELECT * FROM CityInfo WHERE Country LIKE '" + searchCountry + "%'";
            Connection.Open();
            Command = new SqlCommand(Query, Connection);
            Reader = Command.ExecuteReader();
            List<City> cities = new List<City>();
            while (Reader.Read())
            {
                City aCity = new City();
                aCity.Name = Reader["CityName"].ToString();
                aCity.About = Reader["About"].ToString();
                aCity.Country = Reader["Country"].ToString();
                cities.Add(aCity);
            }
            Connection.Close();
            Reader.Close();
            return cities;
        }
    }
}