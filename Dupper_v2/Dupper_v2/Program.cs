using System;
using System.Collections;
using System.Linq;
using Dapper;



namespace Dupper_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DapperRepository microOrm = new DapperRepository();
            ArrayList arrayList = new ArrayList();

            var result = microOrm.Connection.Query<Customer>("Select * From Customer").ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item.toString());
            }

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
