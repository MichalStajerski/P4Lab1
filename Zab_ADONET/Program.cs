using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zab_ADONET
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new DB();
            var connectionString = "abc";
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open(); //otwarcie polaczenia 

                db.Select(connection);
                //db.Insert(connection, 11, "Bielsko");
                //db.Delete(connection,11);
                connection.Close();
            }
            Console.ReadKey();
            //uzyte using
            //using (var c1 = new SqlConnection())
            //{
            //} zamiast tego jest using przy var

         
        }

    }
}
