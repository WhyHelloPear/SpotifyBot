using SpotifyAPI.Web;
using System;
using System.Threading.Tasks;

namespace SpotifyBot
{
    public class SpotifyHandler
    {
        public SpotifyClient _client;

        public SpotifyHandler( string token )
        {
            _client = new SpotifyClient( token );
        }

        public async Task GetTrack( string trackId )
        {
            FullTrack track = await _client.Tracks.Get( trackId );
            Console.WriteLine( track.Name );
        }

    }
}
