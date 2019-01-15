using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Students.BL
{
    class CLASS_QNAT
    {
        public void ADD_QNAT(string qnat_descr)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@qnat_descr", SqlDbType.VarChar, 200);
            param[0].Value = qnat_descr;
            DAL.ExecuteCommand("ADD_QNAT", param);
            DAL.Close();
        }

        public DataTable GET_ALL_QNAT()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_ALL_QNAT", null);
            DAL.Close();
            return dt;
        }

        public void DELETE_QNAT(int qnat_no)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@qnat_no", SqlDbType.Int);
            param[0].Value = qnat_no;

            DAL.ExecuteCommand("DELETE_QNAT", param);

            DAL.Close();
        }

        public void UPDATE_QNAT(int qnat_no, string qnat_descr)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@qnat_no", SqlDbType.Int);
            param[0].Value = qnat_no;

            param[1] = new SqlParameter("@qnat_descr", SqlDbType.VarChar, 200);
            param[1].Value = qnat_descr;

            DAL.ExecuteCommand("UPDATE_QNAT", param);

            DAL.Close();
        }
    }
}
