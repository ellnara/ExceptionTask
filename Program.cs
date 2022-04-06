using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("MENU: \n1. Send message by email \n2. Send message by sms \n0. Quit ");
                int input = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (input)
                {
                    case 1:
                        EmailSender email = new EmailSender();
                        email.SendMessage();
                        break;
                    case 2:
                        SmsSender sms = new SmsSender();
                        sms.SendMessage();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        if (input > 2)
                        {
                            throw new IntException("bele secim yoxdu");

                        }
                        break;
                }

            }
        }
    }
}
