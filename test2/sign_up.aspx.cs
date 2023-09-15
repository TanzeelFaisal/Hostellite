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
    public partial class SignupPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {

            DataAccess temp = new DataAccess();
            int found = temp.isExitingUser(TextBox1.Text);
            if (found <= 0)
            {
                temp.createNewUser(TextBox1.Text, TextBox2.Text, TextBox6.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox7.Text);
                Label3.Text = "Registration successful!";
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";
                TextBox6.Text = "";
                TextBox7.Text = "";
            }
            else
            {
                Label4.Text = "Username not available";
            }

        }

        public bool checkUser(String username)
        {
            bool userstatus;
            String mycon = "Data Source=DESKTOP-3E2QENC;Initial Catalog=Deliverable02;Integrated Security=True";
            String myquery = "Select * from CustomerDetails where CustomerID='" + TextBox1.Text + "'";
            SqlConnection con = new SqlConnection(mycon);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = myquery;
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {
                userstatus = false;
            }
            else
            {
                userstatus = true;
            }
            con.Close();
            return userstatus;
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("LoginPage.aspx");
        }
    }
}