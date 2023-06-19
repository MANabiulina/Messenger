using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Messenger
{
    class Client
    {
        public object JsonConvert { get; private set; }

        private static readonly HttpClient client = new HttpClient();

        public void TestNewton()
        {
            Message msg1 = new Message("MANabiulina", "Привет!", DateTime.UtcNow);
            string output = JsonConvert.SerializeObject(msg1);
            Console.WriteLine(output);
            Message deserializedMsg = JsonConvert.DeserializeObject<Message>(output);
            Console.WriteLine(deserializedMsg);
        }

        public Message GetMessage(int MessageId);
        
            public async Task<Message> GetMessageHTTPAsync(int MessageId)
        {
            var responseString = await client.GetStringAsync();
        }

        internal Task<Message> GetMessageHTTPAsync(int messageID) => throw new NotImplementedException();

        internal Task<Message> GetMessageHTTPAssync(int messageID)
        {
            throw new NotImplementedException();
        }

        public bool SendMessage(Message msg)
        {
            WebRequest request = WebRequest.Create("http://localhost:5000/api/Messanger");
            request.Method = "POST";
            string postData = JsonConvert.SerializeObject(msg);
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            request.ContentType = "application/json";
            request.ContentLength = byteArray.Length;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();
            WebResponse response = request.GetResponse();
            dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            reader.Close();
            dataStream.Close();
            response.Close();
            return true;
        }

    }
}
