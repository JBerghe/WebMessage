using DatabaseHandler;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace WebMessaging.Models
{
    public class WebMessage
    {
        public int ID { get; set; }
        public String Message {get; set; }
        public DateTime DateSent { get; set; }
    }
    
}
