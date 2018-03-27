using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using UpdateDiagnosticCenterBillMangementSoftware.Model;

namespace UpdateDiagnosticCenterBillMangementSoftware.DAL
{
    public class TypeGetWay
    {
        string connectionstring = WebConfigurationManager.ConnectionStrings["UpdateDCBMS"].ConnectionString;

        public int SaveType(TypeClass aTypeClass)
        {
            SqlConnection connection=new SqlConnection(connectionstring);
            string query = "Insert into Type_t (Name,Date) Values ('" + aTypeClass.Name + "', '" + aTypeClass.Date + "')";
            SqlCommand command=new SqlCommand(query,connection);


            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }

        public List<TypeClass> GetAllType()
        {
            List<TypeClass> aList=new List<TypeClass>();

            SqlConnection connection = new SqlConnection(connectionstring);
            string query = "Select * from Type_t ORDER BY Name ASC";
            SqlCommand command=new SqlCommand(query,connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    TypeClass aTypeClass=new TypeClass();
                    aTypeClass.Id = Convert.ToInt32(reader["ID"].ToString());
                    aTypeClass.Name = reader["Name"].ToString();
                    aTypeClass.Date = reader["Date"].ToString();
                    aList.Add(aTypeClass);
                }
                reader.Close();
            }
            connection.Close();
            return aList;
        }


        public TypeClass GetInfoByTypeName(string name)
        {
            TypeClass aTypeClass = null;

            SqlConnection connection = new SqlConnection(connectionstring);
            string query = "Select * from Type_t where Name='"+name+"'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    aTypeClass = new TypeClass();
                    aTypeClass.Id = Convert.ToInt32(reader["Id"].ToString());
                    aTypeClass.Name = reader["Name"].ToString();
                    aTypeClass.Date = reader["Date"].ToString();
                }
                reader.Close();
            }
            connection.Close();
            return aTypeClass;
        }
    }
}