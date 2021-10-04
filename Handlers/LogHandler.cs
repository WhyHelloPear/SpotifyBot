using Discord;
using Discord.WebSocket;
using System;
using System.Threading.Tasks;

namespace SpotifyBot
{
    public class LogHandler
    {
        public LogHandler()
        {

        }

        public Task Log( LogMessage log )
        {
            Console.WriteLine( log.Message.ToString() );
            return Task.CompletedTask;
        }
    }
}
