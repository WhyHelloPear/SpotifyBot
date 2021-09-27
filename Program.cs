using System;
using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;
using DiscordSpotify;
using SpotifyAPI.Web;

namespace SpotifyBot
{
    public class Program
    {
        public static async Task Main()
        {
            Bot spotifyBot = new Bot( "token", "token");
            await spotifyBot.StartBot();
        }
    }
}
