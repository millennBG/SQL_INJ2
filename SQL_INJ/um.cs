using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;

namespace SQL_INJ
{
    public static class um
    {
        private static string CheckUser1(string UserName, string Password)
        {
            string User = "";
            string ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=db_test;Data Source=CML-8212";
            string SQL = "select UserName from Users where UserName='" + UserName + "' and Password='" + Password + "'";

            SqlConnection conn = new SqlConnection(ConnectionString);

            SqlCommand comm = new SqlCommand(SQL, conn);

            SqlDataAdapter adapter = new SqlDataAdapter(comm);

            DataSet ds = new DataSet();

            adapter.Fill(ds);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                User = row["UserName"].ToString();
            }

            return User;

        }

        private static string CheckUser2(string UserName, string Password)
        {
            string User = "";
            string ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=db_test;Data Source=CML-8212";
            string SQL = "select UserName from Users where UserName=@UserName and Password=@Password";

            SqlConnection conn = new SqlConnection(ConnectionString);

            SqlCommand comm = new SqlCommand(SQL, conn);

            comm.Parameters.Add("@UserName", DbType.String);

            comm.Parameters.Add("@Password",DbType.String);

            comm.Parameters["@UserName"].Value = UserName;

            comm.Parameters["@Password"].Value = Password;

            SqlDataAdapter adapter = new SqlDataAdapter(comm);

            DataSet ds = new DataSet();

            adapter.Fill(ds);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                User = row["UserName"].ToString();
            }

            return User;

        }

        private static string CheckUser3(string UserName, string Password)
        {
            string User = "";
            string ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=db_test;Data Source=CML-8212";
            string SQL = "CheckUser";

            SqlConnection conn = new SqlConnection(ConnectionString);

            SqlCommand comm = new SqlCommand(SQL, conn);

            comm.CommandType = CommandType.StoredProcedure;

            comm.Parameters.Add("@UserName", DbType.String);

            comm.Parameters.Add("@Password", DbType.String);

            comm.Parameters["@UserName"].Value = UserName;

            comm.Parameters["@Password"].Value = Password;

            SqlDataAdapter adapter = new SqlDataAdapter(comm);

            DataSet ds = new DataSet();

            adapter.Fill(ds);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                User = row["UserName"].ToString();
            }

            return User;

        }

        public static string CheckUser(string UserName, string Password)
        {
            //return CheckUser1(UserName, Password);

            return CheckUser3(UserName, Password);


        }

    }
}