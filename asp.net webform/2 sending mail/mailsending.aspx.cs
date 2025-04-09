using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2_sending_mail
{
    public partial class mailsending : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("aniketmgawade2019@gmail.com");
            //mail.From = new MailAddress("kstesterjune@gmail.com");
            mail.To.Add(txtrecivermail.Text);
            mail.Subject = txtsubject.Text;
            mail.Body = txtbody.Text;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.Credentials = new NetworkCredential("aniketmgawade2019@gmail.com", "dpdivxmqwngsrgvk");
            //smtp.Credentials = new NetworkCredential("kstesterjune@gmail.com", "dfmjyqbqfmuqqqdm");
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.Send(mail);
            Response.Write("<script>alert('Mail send Succecfully')</script>");
        }
    }
}