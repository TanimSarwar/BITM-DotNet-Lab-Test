using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace ProductInfoWebApp.DAL.Gateway
{
    public class Gateway
    {
        public string Query { get; set; }
        public SqlConnection Connection { get; set; }
        public SqlDataReader Reader { get; set; }
        public SqlCommand Command { get; set; }

        private string ConnectionString =
            WebConfigurationManager.ConnectionStrings["ProductInfoDBConnection"].ConnectionString;
        public Gateway()
        {
            Connection = new SqlConnection(ConnectionString);
        }
    }
}