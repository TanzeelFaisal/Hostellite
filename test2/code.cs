using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace test2
{
    public class DataAccess
    {
        public int temp;

        public void func(int cid, int rid, int rtid, int rating, string sugg)
        {
            string sql = ConfigurationManager.ConnectionStrings["Deliverable01ConnectionString"].ConnectionString;
            DataSet ds = new DataSet();
            string str = "Data Source=DESKTOP-7NMR6P9;Initial Catalog=Deliverable01;Integrated Security=True";
            SqlConnection n = new SqlConnection(str);
            n.Open();
            SqlCommand m = new SqlCommand("insert_ratings", n); //name of procedure
            m.CommandType = CommandType.StoredProcedure;
            m.Parameters.Add("@cid", SqlDbType.Int);
            m.Parameters["@cid"].Value = cid;
            m.Parameters.Add("@rid", SqlDbType.Int);
            m.Parameters["@rid"].Value = rid;
            m.Parameters.Add("@rtid", SqlDbType.Int);
            m.Parameters["@rtid"].Value = rtid;
            m.Parameters.Add("@rating", SqlDbType.Int);
            m.Parameters["@rating"].Value = rating;
            m.Parameters.Add("@sugg", SqlDbType.VarChar);
            m.Parameters["@sugg"].Value = sugg;
            //m.Parameters.Add("@output", SqlDbType.Int).Direction = ParameterDirection.Output;
            //int output = m.Parameters["@output"].Value;
            m.ExecuteNonQuery();
            n.Close();
        }

        public int isExitingUser(String U)
        {
            String mycon = "Data Source=DESKTOP-7NMR6P9;Initial Catalog=Deliverable02;Integrated Security=True";
            SqlConnection con = new SqlConnection(mycon);
            con.Open();
            SqlCommand cmd = new SqlCommand("searchUsername", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@user", SqlDbType.VarChar, 20);
            cmd.Parameters["@user"].Value = U;
            cmd.Parameters.Add("@exists", SqlDbType.Int).Direction = ParameterDirection.Output;

            cmd.ExecuteNonQuery();
            int exists = Convert.ToInt32(cmd.Parameters["@exists"].Value);
            con.Close();
            return exists;
        }

        public int isRegistered(String U, String P)
        {
            String mycon = "Data Source=DESKTOP-7NMR6P9;Initial Catalog=Deliverable02;Integrated Security=True";
            SqlConnection con = new SqlConnection(mycon);
            con.Open();
            SqlCommand cmd = new SqlCommand("searchUser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@user", SqlDbType.VarChar, 20);
            cmd.Parameters["@user"].Value = U;
            cmd.Parameters.Add("@pass", SqlDbType.VarChar, 20);
            cmd.Parameters["@pass"].Value = P;
            cmd.Parameters.Add("@Found", SqlDbType.Int).Direction = ParameterDirection.Output;

            cmd.ExecuteNonQuery();
            int exists = Convert.ToInt32(cmd.Parameters["@Found"].Value);
            con.Close();
            return exists;
        }

        public void createNewUser(String id, String pass, String add, String fn, String ln, String ph, String mail)
        {
            String mycon = "Data Source=DESKTOP-7NMR6P9;Initial Catalog=Deliverable02;Integrated Security=True";
            SqlConnection con = new SqlConnection(mycon);
            con.Open();
            SqlCommand cmd = new SqlCommand("insertNewCustomer", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ID", SqlDbType.VarChar, 20);
            cmd.Parameters["@ID"].Value = id;
            cmd.Parameters.Add("@pass", SqlDbType.VarChar, 20);
            cmd.Parameters["@pass"].Value = pass;
            cmd.Parameters.Add("@add", SqlDbType.VarChar, 255);
            cmd.Parameters["@add"].Value = add;
            cmd.Parameters.Add("@fn", SqlDbType.VarChar, 255);
            cmd.Parameters["@fn"].Value = fn;
            cmd.Parameters.Add("@ln", SqlDbType.VarChar, 255);
            cmd.Parameters["@ln"].Value = ln;
            cmd.Parameters.Add("@ph", SqlDbType.VarChar, 255);
            cmd.Parameters["@ph"].Value = ph;
            cmd.Parameters.Add("@mail", SqlDbType.VarChar, 255);
            cmd.Parameters["@mail"].Value = mail;
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}