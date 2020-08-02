using System;
using Telegram.Bot;
using System.Threading;
using System.Threading.Tasks;

namespace ChatBotTelegram
{
    class Program
    {

        private static TelegramBotClient botClient = new TelegramBotClient("1218489155:AAHT0-fZJMmyTDOZepVLlJgG4fbnqzpWV0E");

        static void Main(string[] args)
        {
            botClient.OnMessage += BotClient_OnMessage;

            botClient.StartReceiving();
            Thread.Sleep(Timeout.Infinite);
            botClient.StopReceiving();
        }

        private static void BotClient_OnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            Console.WriteLine(e.Message.Text);

            if (e.Message.Text.ToUpper() == "BOM DIA")

            {
                botClient.SendTextMessageAsync(
                    e.Message.Chat.Id,
                    $"Olá {e.Message.From.FirstName}, tudo bem? O Banco Carrefour agradece o seu contato! Como posso ajudar? Será gerado um protocolo de atendimento número: 135781113 "
                    );

            }

            if (e.Message.Text.ToUpper() == "BOA TARDE")

            {
                botClient.SendTextMessageAsync(
                    e.Message.Chat.Id,
                    $"Olá {e.Message.From.FirstName}, tudo bem? O Banco Carrefour agradece o seu contato! Como posso ajudar? Será gerado um protocolo de atendimento número: 1357871193 "
                    );

            }

            if (e.Message.Text.ToUpper() == "OI")

            {
                botClient.SendTextMessageAsync(
                    e.Message.Chat.Id,
                    $"Olá {e.Message.From.FirstName}, tudo bem? O Banco Carrefour agradece o seu contato! Como posso ajudar? Será gerado um protocolo de atendimento número: 135788193 "
                    );

            }
            if (e.Message.Text.ToUpper() == "OLÁ")

            {
                botClient.SendTextMessageAsync(
                    e.Message.Chat.Id,
                    $"Olá {e.Message.From.FirstName}, tudo bem? O Banco Carrefour agradece o seu contato! Como posso ajudar? Será gerado um protocolo de atendimento número: 137791113 "
                    );

            }
        }   

    }
}