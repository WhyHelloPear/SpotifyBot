using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Xml.Linq;
using Discord;
using Discord.WebSocket;
using DiscordSpotify;
using SpotifyAPI.Web;

namespace SpotifyBot
{
    public class Program
    {
        private string _spotifyToken;
        private string _discordToken;
        public static void Main( string[] args )
        {
            new Program().MainAsync().GetAwaiter().GetResult();
        }
        public async Task MainAsync()
        {
            Setup();
            SpotifyDiscordBot spotifyBot = new SpotifyDiscordBot( "token", "token" );
            await spotifyBot.StartBot();
        }

        private void Setup()
        {
            var _spotifyToken = ConfigurationManager.AppSettings["SpotifyToken"];
            var _discordToken = ConfigurationManager.AppSettings["DiscordToken"];

            //_spotifyToken;
            //_discordToken;
        }
    }
}
