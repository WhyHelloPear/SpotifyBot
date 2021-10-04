using Discord;
using Discord.WebSocket;
using System.Threading.Tasks;

namespace SpotifyBot
{
    public class DiscordHandler
    {
        public DiscordSocketClient _client;

        public DiscordHandler( string clientToken )
        {
            _client = new DiscordSocketClient();
        }

        public async Task Start()
        {
            //await _client.LoginAsync( TokenType.Bot, _token );
            await _client.StartAsync();
            await Task.Delay( -1 );
        }
    }
}
