using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace ResidentialHotelMVCWebApp.Gateway
{
    public class CommonGateway
    {


        public SqlCommand Command;
        public SqlConnection Connection;
        public SqlDataReader Reader;
        public string query;

        public CommonGateway()
        {
            string conString = WebConfigurationManager.ConnectionStrings["ResidentialHotelDB"].ConnectionString;
            Connection = new SqlConnection(conString);
            
        }

    }
}