using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter SQL query (:/c to cancel): ");
            String SQLInput = Console.ReadLine();
            if(SQLInput.ToLower() != "/c")
            {
                //Create new connection to database
                DatabaseConnector dbc = new DatabaseConnector();
                //Send request to database
                var sending = dbc.send(SQLInput);
                foreach(var v in sending)
                {
                    for(int i = 0; i< v.Length; i++)
                    {
                        Console.Write(v[i] + " ");
                    }
                    Console.WriteLine();
                }
                Console.ReadKey();
            }
        }
    }
}
