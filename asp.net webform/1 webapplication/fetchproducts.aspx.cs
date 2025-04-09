using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1_webapplication
{
    public partial class fetchproducts : System.Web.UI.Page
    {
        string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        SqlConnection conn;
        string query;
        protected void Page_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(con);
            conn.Open();

            fetchproduct();
        }

        public void fetchproduct()
        {
            query = "exec productlist";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader rdr = cmd.ExecuteReader();

            DataList1.DataSource = rdr;
            DataList1.DataBind();
        }
       
    }
}