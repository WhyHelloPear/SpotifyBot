using SpotifyBot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordSpotify
{
    public class Bot
    {
        private SpotifyHandler _spotifyHandler;
        private DiscordHandler _discordHandler;
        public Bot( string spotifyToken, string discordToken )
        {
            _spotifyHandler = new SpotifyHandler( spotifyToken );
            _discordHandler = new DiscordHandler( discordToken );
        }

        public async Task StartBot()
        {
            await _discordHandler.Start();
        }
    }
}
