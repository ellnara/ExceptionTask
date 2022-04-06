using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class SmsSender : MessageSender
    {
        public override void SendMessage()
        {
            Console.WriteLine("Enter sms");
            string sms = Console.ReadLine();
            Console.WriteLine(sms);
        }
    }
}
