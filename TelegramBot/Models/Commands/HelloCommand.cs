using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace TelegramBot.Models.Commands
{
    public class HelloCommand : Command
    {
        public override string Name => "Hello";

        public override async void Execute(Message message, TelegramBotClient client)
        {
            var chatId = message.Chat.Id;
            var messageId = message.MessageId;

            //Bot logic there

            await client.SendTextMessageAsync(0, "Hello!", replyToMessageId: 0);
        }
    }
}