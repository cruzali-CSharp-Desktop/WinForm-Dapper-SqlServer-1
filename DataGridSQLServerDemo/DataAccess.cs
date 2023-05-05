using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridSQLServerDemo
{
    public class DataAccess
    {
        public List<Person> GetPeople()
        {
            using (IDbConnection myConnection = new System.Data.SqlClient.SqlConnection(Helper.conVal("DBConn")))
            {
                var output = myConnection.Query<Person>($"SELECT FirstName, LastName FROM People").ToList();
                return output;
            }
        }
    }
}
