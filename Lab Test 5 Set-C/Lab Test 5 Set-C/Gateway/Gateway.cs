using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace Lab_Test_5_Set_C.Gateway
{
    public class Gateway
    {
        private string ConnectionString = WebConfigurationManager.ConnectionStrings["VehicleDBConnection"].ConnectionString;
        public SqlCommand Command { get; set; }
        public SqlDataReader Reader { get; set; }
        public SqlConnection Connection { get; set; }

        public string Query { get; set; }

        public Gateway()
        {
            Connection = new SqlConnection(ConnectionString);
        }
    }
}