using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data; // Required for using Dataset , Datatable and Sql  
using System.Data.SqlClient; // Required for Using Sql  
//using System.Configuration; // for Using Connection From Web.config   
using BussinessObject;  // for acessing bussiness object class  
namespace DataAccess
{
    public class UserDA
    {

        SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=ThreeTireAppDB;Integrated Security=True");
        public int AddUserDetails(UserBO ObjBO) // passing Bussiness object Here  
        {
            try
            {
                string sql = string.Format(@"INSERT INTO Users (Name, Address, EmailID, Mobilenumber)
VALUES('{0}', '{1}', '{2}', '{3}')", ObjBO.Name, ObjBO.address, ObjBO.EmailID, ObjBO.Mobilenumber);
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                int Result = cmd.ExecuteNonQuery();
                cmd.Dispose();
                return Result;
            }
            catch
            {
                throw;
            }
        }
    }
}