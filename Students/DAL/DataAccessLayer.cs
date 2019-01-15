using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Students.DAL
{
    class DataAccessLayer
    {

        SqlConnection sqlConecction;

        public DataAccessLayer()
        {
            sqlConecction = new SqlConnection(@"Server=.\SQLEXPRESS; Database=Students_manage; Integrated security=true");
        }

        // Method  To Open Database

        public void Open()
        {
            if (sqlConecction.State != ConnectionState.Open)
            {
                sqlConecction.Open();
            }
        }

        // Method  To Close Database

        public void Close()
        {
            if (sqlConecction.State == ConnectionState.Open)
            {
                sqlConecction.Close();
            }
        }


        // Method  To Read Data From Database

        public DataTable SelectData(string storded_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = storded_procedure;
            sqlcmd.Connection = sqlConecction;

            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    sqlcmd.Parameters.Add(param[i]);
                }
            }

            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;

        }


        // Method  To Insert , Update , and Delete Data From Database

        public void ExecuteCommand(string storded_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = storded_procedure;
            sqlcmd.Connection = sqlConecction;

            if (param != null)
            {
                sqlcmd.Parameters.AddRange(param); // Same For

            }
            sqlcmd.ExecuteNonQuery();

        }
    }
}
