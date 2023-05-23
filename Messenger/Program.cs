using System;
using Newtonsoft.Json;

namespace Messenger
{
    class Program
    {
        private static int MessageID;
        private static string UserName;
        private static Client API = new Client();

        private static void GetNewMessenges()
        {
            Message msg = API.GetMessage(MessageID);
            while (msg != null)
            {
                Console.WriteLine(msg);
                MessageID++;
                msg = API.GetMessage(MessageID);
            }
        }

        static void Main(string[] args)
        {
            MessageID = 1;
            Console.WriteLine("Введите Ваше имя:");
            UserName = Console.ReadLine();
            string MessageText = "";
            while (MessageText != "Выход")
            {
                GetNewMessenges();
                MessageText = Console.ReadLine();
                if (MessageText.Length > 1)
                {
                    Message Sendmsg = new Message(UserName, MessageText, DateTime.Now);
                    API.SendMessage(Sendmsg);
                }
            }
        }
    }
}
