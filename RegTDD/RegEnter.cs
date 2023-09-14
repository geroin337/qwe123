using Reg;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegTDD
{
    class RegEnter
    {
        public List<string> Enter(string login, string password)
        {
            List<string> list = new List<string>();
            DataSetClass dataSetClass = new DataSetClass();
            string sql = "select [Login_Student], [Password_Student] from [dbo].[Student]";
            dataSetClass.command.CommandText = sql;
            dataSetClass.command.Connection = dataSetClass.connection;
            dataSetClass.connection.Open();
            using (SqlDataReader reader = dataSetClass.command.ExecuteReader())
                while (reader.Read())
                {
                    list.Add(reader["Login_Student"].ToString());
                    Program.Login = reader["Login_Student"].ToString();
                    Program.Password = reader["Password_Student"].ToString();
                    if (login == Program.Login && password == Program.Password)
                        break;
                }
            dataSetClass.connection.Close();
            return list;
        }
    }
}
