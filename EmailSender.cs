using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class EmailSender : MessageSender
    {
        public override void SendMessage()
        {
            Console.WriteLine("Enter email:");
           string email= Console.ReadLine();
            Console.WriteLine( email);
        }
    }
}
