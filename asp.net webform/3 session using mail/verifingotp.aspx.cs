using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _3_session_using_mail
{
    public partial class verifingotp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string email=TextBox1.Text;
            int otpp = opt();
            Session["OTP"] = otpp;
            sendmail(email,otpp);
            Response.Redirect("verify.aspx");
        }

        public int opt()
        {
            Random rnd = new Random();
            return rnd.Next(1000, 9999);
        }

        public void sendmail(string rmail,int otp)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("aniketmgawade2019@gmail.com");
            mail.To.Add(TextBox1.Text);
            mail.Subject = "Regarding OTP Verification";
            mail.Body = $"Your OTP = {otp}";

            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.Credentials = new NetworkCredential("aniketmgawade2019@gmail.com", "dpdivxmqwngsrgvk");
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.Send(mail);
            
        }
    }
}