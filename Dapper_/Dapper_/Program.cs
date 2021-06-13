using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Dapper;
using System.Linq;
using System.Data;
namespace Dapper_
{
    class Program
    {
        static void Main(string[] args)
        {

            // Console.WriteLine("Hello World!");
            // Data Source=(localdb)\Mssqllocaldb;Initial Catalog=Exp;Integrated Security=True
            var custRepo = new CustomerRepository();

            var customer1 = new Customer { Id = Guid.NewGuid(), FirstName = "Caner", LastName = "Tosuner", Email = "info@canertosuner.com" };
            var customer2 = new Customer { Id = Guid.NewGuid(), FirstName = "Berker", LastName = "Sönmez", Email = "info@berkersonmez.com" };
           
            custRepo.Insert(customer1);
            custRepo.Insert(customer2);
            
            //returns 2 records
            var allCustomersUsingQuery = custRepo.All();

            //returns 2 records
            var allCustomersUsingSp = custRepo.AllUsingSp();


            Console.ReadLine();

            Console.WriteLine(allCustomersUsingQuery);
            Console.WriteLine(allCustomersUsingSp);


        }
    }
}
