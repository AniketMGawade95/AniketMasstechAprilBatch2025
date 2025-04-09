using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.WebRequestMethods;

namespace _3_session_using_mail
{
    public partial class verify : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string ootp = Session["OTP"].ToString();

            if (ootp.Equals(TextBox1.Text))
            {
                Response.Write("<script>alert('Verified Succecfully')</script>");
            }
            else
            {
                Response.Write("<script>alert('Invalid OTP')</script>");
            }
        }
    }
}