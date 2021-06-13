using Dapper;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Dapper_
{
    public class CustomerRepository
    {
        protected SqlConnection GetOpenConnection()
        {
            var connection = new SqlConnection("Data Source=(localdb)\\Mssqllocaldb;Initial Catalog=Exp;Integrated Security=True");
            connection.Open();
            return connection;
        }

        public IEnumerable<Customer> All()
        {
            using (var conn = GetOpenConnection())
            {
                return conn.Query<Customer>("Select * From Customer").ToList();
            }
        }

        public Customer Get(Guid id)
        {
            using (var conn = GetOpenConnection())
            {
                return conn.Query<Customer>("Select * From Customer WHERE Id = @Id", new { id }).SingleOrDefault();
            }
        }

        public void Insert(Customer customer)
        {
            using (var conn = GetOpenConnection())
            {
                string sqlQuery = "INSERT Customer(FirstName,LastName,Email) Values(@FirstName,@LastName,@Email)";
                conn.Execute(sqlQuery, customer);
            }
        }

        

        public IEnumerable<Customer> AllUsingSp()
        {
            using (var conn = GetOpenConnection())
            {
                return conn.Query<Customer>("GetAllCustomersSP", commandType: CommandType.StoredProcedure).ToList();
            }
        }



    }
}
