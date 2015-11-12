using System;
using DatabaseHandler;
namespace MessageConsole
{
    class MessageConsoleProgram
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter message to post (or /c to cancel): ");
            String SQLInput = Console.ReadLine();
            if (SQLInput.ToLower() != "/c")
            {
                //Create new connection to database
                DatabaseConnector dbc = new DatabaseConnector();
                //Send request to database
                var sending = dbc.send("INSERT INTO Messages (Message) VALUES ('" + SQLInput + "');");
                Console.WriteLine("Message sent: " + SQLInput);
                Console.ReadKey();
                //INSERT INTO Messages (Message) VALUES ('HELLO')
            }
        }
    }
}
