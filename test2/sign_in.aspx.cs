using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace test2
{
    public partial class LoginPage : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataAccess temp = new DataAccess();
            int found = temp.isRegistered(TextBox1.Text, TextBox2.Text);

            if (found > 0)
            {
                Session["CustomerID"] = TextBox1.Text;
                Response.Redirect("HomePage.aspx");
            }
            else
            {
                Label3.Text = "Invalid username or password";
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Logout.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("SignupPage.aspx");
        }
    }
}