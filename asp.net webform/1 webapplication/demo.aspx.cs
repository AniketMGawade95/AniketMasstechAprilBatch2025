using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1_webapplication
{
    public partial class demo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            Label1.Text = "Waiting for inputs";
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //for using this event we have to change the autopostback in dropdownlist property to true

            Button1.Text = DropDownList1.SelectedItem.ToString();
            String operation = DropDownList1.SelectedValue;

            int a = int.Parse(TextBox1.Text);

            int b = int.Parse(TextBox2.Text);
            int c;

            if (operation.Equals("+"))
            {
                c = a + b;
                Label1.Text = c.ToString();
            }
            if (operation.Equals("-"))
            {
                c = a - b;
                Label1.Text = c.ToString();
            }
            if (operation.Equals("*"))
            {
                c = a * b;
                Label1.Text = c.ToString();
            }
            if (operation.Equals("/"))
            {
                c = a / b;
                Label1.Text = c.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String operation = DropDownList1.SelectedValue;

            int a = int.Parse(TextBox1.Text);
            int b = int.Parse(TextBox2.Text);
            int c;

            if (operation.Equals("+"))
            {
                c = a + b;
                Label1.Text = c.ToString();
            }
            if (operation.Equals("-"))
            {
                c = a - b;
                Label1.Text = c.ToString();
            }
            if (operation.Equals("*"))
            {
                c = a * b;
                Label1.Text = c.ToString();
            }
            if (operation.Equals("/"))
            {
                c = a / b;
                Label1.Text = c.ToString();
            }

        }
    }
}