using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;
using Telegram.Bot.Types;
using TelegramBot.Models;

namespace TelegramBot.Controllers
{
    [Route(@"api/message/update")]
    public class MessageController : ApiController
    {
        public async Task<OkResult> Update([FromBody]Update update) //webhook uri part
        {
            var commands = Bot.Commands;
            var message  = update.Message;
            var client   = await Bot.Get();

            foreach (var command in commands)
            {
                if(command.Contains(message.Text))
                {
                    command.Execute(message, client);
                    break;
                }
            }

                return Ok();
        }
    }
}
