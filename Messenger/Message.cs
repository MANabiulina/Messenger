using System;
using System.Collections.Generic;
using System.Text;

namespace Messenger
{
    [Serializable]
    public class Message
    {
        public string UserName { get; set; }
        public string MessageText { get; set; }
        public DateTime TimeStap { get; set; }

        public Message(string userName, string messageText, DateTime timeStap)
        {
            UserName = userName;
            MessageText = messageText;
            TimeStap = timeStap;
        }
        public Message()
        {
            UserName = "Админ";
            MessageText = "Сервер запущен";
            TimeStap = DateTime.Now;
        }

        public override string ToString()
        {
            string output = String.Format("{0} <{2}>: {1}", UserName, MessageText, TimeStap);
            return output;
        }
    }
}
