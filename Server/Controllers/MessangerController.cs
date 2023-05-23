using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Messenger;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using Message = Messenger.Message;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessangerController : ControllerBase
    {
        static List<Message> ListOfMessanges = new List<Message>();
        // GET: api/Messanger/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            string OutputString = "Не найдено";
            if ((id < ListOfMessanges.Count) && (id >= 0))
            {
                OutputString = Newtonsoft.Json.JsonConvert.SerializeObject(ListOfMessanges[id]);
            }
            Console.WriteLine(String.Format("Запрошено сообщение №{0} : {1}", id, OutputString));
            return OutputString;
        }

        // POST: api/Messanger
        [HttpPost]
        public IActionResult SendMessange([FromBody] Message msg) 
        {
            if (msg == null)
            {
                return BadRequest();
            }
            ListOfMessanges.Add(msg);
            Console.WriteLine(String.Format("Всего сообщений: {0} Последнее сообщение: {1}", ListOfMessanges.Count, msg));
            return new OkResult();
        }


    }
}
