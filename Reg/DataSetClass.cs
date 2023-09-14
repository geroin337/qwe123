using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reg
{
    class DataSetClass
    {
        public static string ConnectionString = "Data Source = DESKTOP-BA89SQ3\\MYSERVERBD; Initial Catalog = Reg; Persist Security Info = true; User ID = sa; Password = '123';";
        public SqlConnection connection = new SqlConnection(ConnectionString);
        public SqlCommand command = new SqlCommand();
        public SqlDependency dependency = new SqlDependency();
        public enum act { manipulation };

        public void sqlExecute(string quety, act act)
        {
            command.Connection = connection;
            command.CommandText = quety;
            command.Notification = null;
            switch (act)
            {
                case act.manipulation:
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    break;
            }
        }
    }
}
