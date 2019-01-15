using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Students.BL
{
    class CLASS_DEPT
    {
        public void ADD_DEPT(string dept_name)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@dept_name", SqlDbType.VarChar, 200);
            param[0].Value = dept_name;
            DAL.ExecuteCommand("ADD_DEPT", param);
            DAL.Close();
        }

        public DataTable GET_ALL_DEPT()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_ALL_DEPT", null);
            DAL.Close();
            return dt;
        }

        public void DELETE_DEPT(int dept_no)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@dept_no", SqlDbType.Int);
            param[0].Value = dept_no;

            DAL.ExecuteCommand("DELETE_DEPT", param);

            DAL.Close();
        }

        public void UPDATE_DEPT(int dept_no, string dept_name)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@dept_no", SqlDbType.Int);
            param[0].Value = dept_no;

            param[1] = new SqlParameter("@dept_name", SqlDbType.VarChar, 200);
            param[1].Value = dept_name;

            DAL.ExecuteCommand("UPDATE_DEPT", param);

            DAL.Close();
        }
    }
}
