using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace CityInformationWebApp_3layer_Arch_LT_.DAL.Gateway
{
    public class Gateway
    {
        public SqlCommand Command { get; set; }
        public SqlDataReader Reader { get; set; }
        public SqlConnection Connection { get; set; }

        private string ConnectionString = WebConfigurationManager.ConnectionStrings["CityDBConnection"].ConnectionString;

        public Gateway()
        {
            Connection = new SqlConnection(ConnectionString);
        }

        public string Query { get; set; }
    }
}