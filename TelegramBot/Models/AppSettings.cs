using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelegramBot.Models
{
    public static class AppSettings
    {
        public static string Url { get; set; }  = "https://telegrambotyara.azurewebsites.net:443/{0}";

        public static string Name { get; set; } = "TochnoNe_bot";

        public static string Key { get; set; }  = "705048339:AAFZ8ggHctff1lORTjXy7d8N_kjb4GS5FgY";

    }
}