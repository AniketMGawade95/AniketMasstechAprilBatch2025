using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1_webapplication
{
    public partial class curdoperations : System.Web.UI.Page
    {
        string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        SqlConnection conn;
        string query;
             
        

        protected void Page_Load(object sender, EventArgs e)
        {
            
            conn = new SqlConnection(con);
            conn.Open();
            showdata();
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            double salary=double.Parse(txtSalary.Text);
            string dept = txtDepartment.Text;

            query= $"exec addemployee '{name}','{email}','{salary}','{dept}'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();


            showdata();

            Response.Write("<script>alert('Data Entered sucssfully')</script>");
        }


        public void showdata()
        {
            query = "select * from employee";
            SqlCommand cmd = new SqlCommand(query,conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds= new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            string name = txtName.Text;
            string email = txtEmail.Text;
            double salary = double.Parse(txtSalary.Text);
            string dept = txtDepartment.Text;


            query = $"exec updateempdata '{name}','{email}','{salary}','{dept}','{id}' ";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();


            showdata();

            Response.Write("<script>alert('Data Updated sucssfully')</script>");

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {

            int id=int.Parse(txtID.Text);
            string query = $"exec deletedata '{id}'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();

            showdata();

            Response.Write("<script>alert('Data Deleted sucssfully')</script>");
        }

        protected void btnGo_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            query = $"select * from employee where id={id}";

            SqlCommand cmd = new SqlCommand(query,conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            da.Fill(ds);

            txtName.Text = ds.Tables[0].Rows[0][1].ToString();
            txtEmail.Text = ds.Tables[0].Rows[0][2].ToString();
            txtSalary.Text= ds.Tables[0].Rows[0][3].ToString(); 
            txtDepartment.Text= ds.Tables[0].Rows[0][4].ToString();

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            query= $"exec searchemployee '{name}'";
            SqlCommand cmd = new SqlCommand(query,conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();


        }

        protected void btnshowalldata_Click(object sender, EventArgs e)
        {
            showdata();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
            txtEmail.Text = "";
            txtSalary.Text = "";
            txtDepartment.Text = "";
        }
    }
}