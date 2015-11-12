using DatabaseHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMessaging.Models
{
    public class MessageCollection
    {
        public List<WebMessage> Content { get; }
        public MessageCollection()
        {
            Content = new List<WebMessage>();
            DatabaseConnector dbc = new DatabaseConnector();
            var result = dbc.send("select * from Messages");
            foreach(String[] s in result)
            {
                Content.Add(new WebMessage { DateSent = DateTime.Parse(s[0]), Message = s[1] });
            }
            
        }
    }
}