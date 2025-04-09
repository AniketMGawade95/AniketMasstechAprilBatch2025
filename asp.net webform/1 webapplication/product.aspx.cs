using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1_webapplication
{
    public partial class product : System.Web.UI.Page
    {
        string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        SqlConnection conn;
        string query;
        protected void Page_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(con);
            conn.Open();
           
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            string pcat = DropDownList1.SelectedValue;
            string pic;
            double price = double.Parse(txtprice.Text);

            FileUpload1.SaveAs(Server.MapPath("img/") + Path.GetFileName(FileUpload1.FileName));
            pic = "img/" + Path.GetFileName(FileUpload1.FileName);

            query = $" exec insertproductdata '{name}','{pcat}','{price}','{pic}'";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
           


            Response.Write("<script>alert('Product Entered sucssfully')</script>");
        }
    }
}