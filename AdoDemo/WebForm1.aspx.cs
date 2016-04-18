using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


namespace AdoDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=szpital.mssql.somee.com;Initial Catalog=szpital;User Id=magda9_SQLLogin_1;Password=sakto5xhk1;");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        protected void Page_Load(object sender, EventArgs e)
        {
           // SqlConnection con = new SqlConnection("data source= MAGDA-KOMPUTER\\SQLEXPRESS; database=Sample; integrated security=SSPI ");
           // SqlCommand cmd = new SqlCommand("Select * from tblProduct", con);
          //  con.Open();
          //  SqlDataReader rdr = cmd.ExecuteReader();
          //  GridView1.DataSource = rdr;
          //  GridView1.DataBind();
           // con.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM dbo.User";
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                Session["username"] = txtusername.Text;
                Response.Redirect("WebForm1.aspx");
            }
            else
            {
                Response.Write("Login is not correct please try again");
            }
            con.Close();
        }
    }
}