using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace blogPatricio
{
    public class conexion
    {
        public static SqlConnection connection()
        {

            SqlConnection cn = new SqlConnection("server=LAPTOP-5TE215TP; DATABASE = blog; integrated security=true");

            cn.Open();

            return cn;
        }
    }
}